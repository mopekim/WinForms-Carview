using Carwow.ThreeLayer.Dto;
using Carwow.ThreeLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Carwow.ThreeLayer.infrastructure
{
	public class CarRepository 
	{
		public List<CarDto> Search(string brand, string type, int? minPrice,int? maxPrice)
		{
			using (SqlConnection conn = SqlDb.GetConnection("default"))
			{
				conn.Open();
				#region sql
				var sql = @"SELECT C.Id, C.Brand, C.Model, C.[Type], C.Price, M.[Name] as Seller
FROM Cars as C
INNER Join Members as M ON C.Fk_memberId = M.Id";


				List<SqlParameter> parameters = new List<SqlParameter>();
				string where = string.Empty;
				if(string.IsNullOrEmpty(brand) == false )
				{
					where += " AND C.Brand = @brand";
					parameters.Add(new SqlParameter("@brand", SqlDbType.VarChar, 20) { Value = brand });
				}

				if(string.IsNullOrEmpty(type) == false)
				{
					where += " AND C.[Type] = @type";
					parameters.Add(new SqlParameter("@type", SqlDbType.VarChar, 20){ Value = type});
				}

				if (minPrice.HasValue)
				{
					where += " AND C.Price > "+ minPrice.Value;
				}

				if (maxPrice.HasValue)
				{
					where += " AND C.Price < " + maxPrice.Value;
				}

				where = string.IsNullOrEmpty(where)? string.Empty : " WHERE " + where.Substring(5);
				sql += where;

				//if (cartegoryId.HasValue)
				//{
				//	sql = sql + " WHERE C.Id=" + cartegoryId.Value;
				//}
				sql = sql + " ORDER BY C.Price";
				#endregion
				List<CarDto> list = new List<CarDto>();
				

				using (var cmd = new SqlCommand(sql, conn))
				{

					if (parameters != null) cmd.Parameters.AddRange(parameters.ToArray());
					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

					while (reader.Read())
					{
						CarDto car = new CarDto
						{
							Id = reader.GetInt32("Id",0),
							Brand = reader.GetString("Brand"),
							Model = reader.GetString("Model"),
							Type = reader.GetString("Type"),
							Price = reader.GetInt32("Price", 0),
							Seller = reader.GetString("Seller")

						};
						list.Add(car);

					}
					return list;
				}


			}
		}

		public DetailDto Get(int carId)
		{
			Func<SqlConnection> funcConn = SqlDb.GetConnection;
			string sql = @"SELECT C.Price, Cd.Fuel, Cd.[Year], Cd.Description,Cd.Image_Url, M.Name, M.Phone_number,M.Email
FROM Cars as C
JOIN Members as M on (Fk_memberId)= M.Id
join Cars_details as Cd on C.Id= Cd.Car_Id
WHERE C.Id=" + carId;

			Func<SqlDataReader, DetailDto> funcAssembly = reader =>
			 new DetailDto
			 {
				 Id = carId,
				 Fuel = reader.GetString("Fuel"),
				 Year = reader.GetString("Year"),
				 Description = reader.GetString("Description"),
				 Price = reader.GetInt32("Price", 0),
				 Image = reader.GetString("Image_Url"),
				 Name = reader.GetString("Name"),
				 PhoneNumber = reader.GetString("Phone_number"),
				 Email = reader.GetString("Email")

			 };
			return SqlDb.Get(funcConn,funcAssembly, sql,null);

				

			
			
		}
		public List<GarageDto> Search(int memberId) 
		{
			string sql = @"SELECT * FROM Cars as C
join Cars_details as Cd on C.Id= Cd.Car_Id
where C.Fk_memberId=" + memberId;

			Func<SqlDataReader, GarageDto> funcAssembly = reader =>
			new GarageDto
			{
				Id = reader.GetInt32("Id",0),
				Brand = reader.GetString("Brand"),
				Model = reader.GetString("Model"),
				Type = reader.GetString("Type"),
				Price = reader.GetInt32("Price", 0),
				MemberId = memberId,
				Fuel = reader.GetString("Fuel"),
				Year = reader.GetString("Year"),
				Description = reader.GetString("Description")
			};
			return SqlDb.Search(SqlDb.GetConnection, funcAssembly, sql,null);
		}
		public GarageDto GetItem(int carId)
		{
			string sql = @"SELECT *FROM Cars as C
join Cars_details as Cd on C.Id= Cd.Car_Id
WHERE C.Id=" + carId;

			Func<SqlDataReader, GarageDto> funcAssembly = reader =>
			 new GarageDto
			 {
				 Id = carId,
				 Brand = reader.GetString("Brand"),
				 Model= reader.GetString("Model"),
				 Type = reader.GetString("Type"),
				 Price = reader.GetInt32("Price", 0),
				 Image= reader.GetString("Image_Url"),
				 MemberId= reader.GetInt32("Fk_memberId", 0),
				 Fuel = reader.GetString("Fuel"),
				 Year = reader.GetString("Year"),
				 Description = reader.GetString("Description"),
				

			 };
			return SqlDb.Get(SqlDb.GetConnection, funcAssembly, sql, null);
		}
		public int Update (GarageDto dto)
		{
			string sql = @"UPDATE Cars SET 
Brand=@Brand,
Model=@Model,
Type=@Type,
Price=@Price
WHERE Id=@Id;

UPDATE Cars_details SET
Fuel =@Fuel,
Year =@Year,
Description=@Description,
Image_Url=@Image
WHERE Car_Id = @Id";

			SqlParameter[] parameters  = SqlParameterBuilder.Create()
				.AddVarChar("@Brand",20, dto.Brand)
				.AddVarChar("@Model",20,dto.Model)
				.AddVarChar("@Type",20, dto.Type)
				.AddInt("@Price", dto.Price)
				.AddNVarChar("@Fuel",20 ,dto.Fuel)
				.AddVarChar("@Year",20, dto.Year)
				.AddNVarChar("@Description", 1000, dto.Description)
				.AddNVarChar("@Image",30,dto.Image)
				.AddInt("@Id",dto.Id)

				.Build();
			return SqlDb.UpdateDelete(SqlDb.GetConnection, sql, parameters);	
		}
		public int Delete (int carId)
		{
			string sql = @"DELETE Cars WHERE Id=@Id";
 //DELETE Cars_details WHERE Car_Id= @Id";

			SqlParameter[] parameters = SqlParameterBuilder.Create()
			.AddInt("@Id", carId)
			.Build();

			return SqlDb.UpdateDelete(SqlDb.GetConnection, sql, parameters);


		}
		public int Create(GarageNewDto dto, int carId )
		{
			string sql = $@"INSERT Cars
(Brand, Model, Type, Price, Fk_memberId)
VALUES
(@Brand, @Model, @Type, @Price, {carId})";

			var parameters = SqlParameterBuilder.Create()
				.AddVarChar("@Brand", 20, dto.Brand)
				.AddVarChar("@Model", 20, dto.Model)
				.AddVarChar("@Type", 20, dto.Type)
				.AddInt("@Price", dto.Price)
				//.AddInt("@Fk_memberId", 1)
				

				.Build();
			return SqlDb.Create(SqlDb.GetConnection, sql, parameters);
			
		}
		public int Reload(GarageNewDsDto dto , int id)
		{
			string sql = $@"INSERT Cars_details
(Fuel, Year, Description,Image_Url, Car_Id)
VALUES
(@Fuel, @Year, @Description,@Image, {id})";

			 var parameters = SqlParameterBuilder.Create()
				.AddNVarChar("@Fuel", 20, dto.Fuel)
				.AddNVarChar("@Year", 20, dto.Year)
				.AddNVarChar("@Description", 1000, dto.Description)
				.AddNVarChar("@Image",30,dto.Image)
				

				.Build();
			return SqlDb.Reload(SqlDb.GetConnection, sql, parameters);


		}  



 

		











	}

		
}

