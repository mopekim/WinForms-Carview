using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwow.ThreeLayer
{
	public class SqlDb
	{
		public static bool Pooling { get; set; } = true;
		public static string GetConnectionString(string KeyOfConnString)
		{
			string connStr = System.Configuration.ConfigurationManager.ConnectionStrings[KeyOfConnString].ToString();
			if (string.IsNullOrEmpty(connStr))
			{
				throw new Exception("找不到連線字串, key=" + KeyOfConnString);
			}
			SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
			sb.Pooling = true;
			return connStr;

		}
		public static SqlConnection GetConnection(string KeyOfConnString)
		{
			string connStr = GetConnectionString(KeyOfConnString);
			return new SqlConnection(connStr);
		}
		public static SqlConnection GetConnection()
		{

			return GetConnection("default");
		}
		public static T Get<T>(Func<SqlConnection> funcConn, Func<SqlDataReader, T> funcAssembly, string sql, params SqlParameter[] parameters)
		{
			using (var conn = funcConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null) cmd.Parameters.AddRange(parameters);
					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
					return reader.Read() ?
						funcAssembly(reader) :
						default(T);

				}
			}
		}
		public static int Create(Func<SqlConnection> funcConn, string sql, params SqlParameter[] parameters)
		{
			sql += ";SELECT Scope_IDENTITY()";

			using (var conn = funcConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null) cmd.Parameters.AddRange(parameters);
					return Convert.ToInt32(cmd.ExecuteScalar());
				}
			}

		}
		public static List<T> Search<T>(Func<SqlConnection> funcConn, Func<SqlDataReader, T> funcAssembly, string sql, params SqlParameter[] parameters)
		{
			using (var conn = funcConn())
			{
				List<T> list = new List<T>();
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null) cmd.Parameters.AddRange(parameters);
					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

					while (reader.Read())
					{
						T entity = funcAssembly(reader);
						list.Add(entity);
					}
					return list;

				}
			}

		}
		public static int UpdateDelete(Func<SqlConnection> funcConn, string sql, params SqlParameter[] parameters)
		{
			using (var conn = funcConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null) cmd.Parameters.AddRange(parameters);
					return cmd.ExecuteNonQuery();
				}
			}
		}
		public static int Reload(Func<SqlConnection> funcConn, string sql, params SqlParameter[] parameters)
		{
			using (var conn = funcConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null) cmd.Parameters.AddRange(parameters);
					return cmd.ExecuteNonQuery();
				}
			}

		}

	}
}
