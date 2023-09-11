using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carwow.ThreeLayer.Dto;

namespace Carwow.ThreeLayer.infrastructure
{
	public class MemberRepository
	{
		public MemberDto Get(int memberId)
		{
		  string sql = $"SELECT*From Members WHERE Id= {memberId}";

			Func<SqlDataReader, MemberDto> funcAssembly = reader =>
			new MemberDto
			{
				Id = memberId,
				Name = reader.GetString("Name"),
				PhoneNumber = reader.GetString("Phone_number"),
				Email = reader.GetString("Email"),
				Account = reader.GetString("Account"),
				Password = reader.GetString("Password")
			};

			return SqlDb.Get<MemberDto>(SqlDb.GetConnection, funcAssembly, sql, null);



		}
	
		public int Update(MemberDto dto)
		{
			string sql = @"UPDATE Members
SET 
Name= @Name,
Phone_number=@PhoneNumber,
Account= @Account,
Password= @Password,
Email= @Email
WHERE
 Id= @Id";

			SqlParameter[] parameters = SqlParameterBuilder.Create()
			  .AddNVarChar("@Name", 20, dto.Name)
			  .AddChar("@PhoneNumber",10, dto.PhoneNumber)
			  .AddNVarChar("@Email", 30, dto.Email)
			  .AddNVarChar("@Account", 10, dto.Account)
			  .AddNVarChar("@Password", 10, dto.Password)
			  .AddInt("@Id", dto.Id)

			  .Build();

			using (var conn = SqlDb.GetConnection("default"))
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{

					cmd.Parameters.AddRange(parameters);
					return cmd.ExecuteNonQuery();
				}
			}
		}
		public void Create(MemberDto dto)
		{
			string sql = @"INSERT Members(Name, Phone_number, Email, Account, Password)
Values(@Name, @Phone_number, @Email, @Account, @Password)";

			var parameters = SqlParameterBuilder.Create()
				.AddNVarChar("@Name", 20, dto.Name)
				.AddChar("@Phone_number", 10, dto.PhoneNumber)
				.AddNVarChar("@Email", 30, dto.Email)
				.AddVarChar("@Account", 10, dto.Account)
				.AddVarChar("@Password", 10, dto.Password)

				.Build();

			 SqlDb.Create(SqlDb.GetConnection,sql, parameters);

		}
		public List<MemberDto> Search(string account) // search 回傳改CategoryDto，再轉VM給Grid使用(格式化呈現內容)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();
			string sql = $"SELECT * FROM Members WHERE Account= '{account}'";
			
			Func<SqlDataReader, MemberDto> funcAssembly = reader =>
			  new MemberDto
			{
				Id =reader.GetInt32("Id", 0),
				Name = reader.GetString("Name"),
				PhoneNumber =reader.GetString("PhoneNumber"),
				Email=reader.GetString("Email"),
				Account = reader.GetString("Account"),
				Password = reader.GetString("Password"),
			 };
				  
			

			return SqlDb.Search(SqlDb.GetConnection, funcAssembly, sql,null);
		}
		public MemberLgDto GetByAccount(string account)
		{
			string sql = "SELECT * FROM Members WHERE Account=@Account";

			SqlParameter parameter = new SqlParameter("@Account",SqlDbType.VarChar, 10) { Value = account };

			Func<SqlDataReader, MemberLgDto> funcAssembly = reader =>
			new MemberLgDto
			{
				Id = reader.GetInt32("Id", 0),
				Account = reader.GetString("Account"),
				Password = reader.GetString("Password")
			};

			return SqlDb.Get<MemberLgDto>(SqlDb.GetConnection, funcAssembly, sql, parameter);
		}


	}
}
