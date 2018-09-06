using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Taxer.DBA
{
class SqlDBHelper
{
static string CONNECTION_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["Ers_Data_Web"].ConnectionString;

	// This function will be used to execute R(CRUD) operation of parameterless commands
	internal static DataTable ExecuteSelectCommand(string CommandName, CommandType cmdType)
	{
		DataTable table = null;
		using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
		{
			using (SqlCommand cmd = con.CreateCommand()) 
			{
				cmd.CommandType = cmdType;
				cmd.CommandText = CommandName;

				try
				{
					if (con.State != ConnectionState.Open)
					{
						con.Open();
					}

					using (SqlDataAdapter da = new SqlDataAdapter(cmd))
					{
						table = new DataTable();
						da.Fill(table);
					}
				}
				catch
				{
					throw;
				}
			}
		}

		return table;
	}

	// This function will be used to execute R(CRUD) operation of parameterized commands
	internal static DataTable ExecuteParamerizedSelectCommand(string CommandName, CommandType cmdType, SqlParameter[] param)
	{
		DataTable table = new DataTable();

		using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
		{
			using (SqlCommand cmd = con.CreateCommand())
			{
				cmd.CommandType = cmdType;
				cmd.CommandText = CommandName;
				cmd.Parameters.AddRange(param);

				try
				{
					if (con.State != ConnectionState.Open)
					{
						con.Open();
					}

					using (SqlDataAdapter da = new SqlDataAdapter(cmd))
					{
						da.Fill(table);
					}
				}
				catch
				{
					throw;
				}
			}
		}

		return table;
	}

	// This function will be used to execute CUD(CRUD) operation of parameterized commands
	internal static bool ExecuteNonQuery(string CommandName, CommandType cmdType, SqlParameter[] pars)
	{
		int result = 0;

		using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
		{
			using (SqlCommand cmd = con.CreateCommand())
			{
				cmd.CommandType = cmdType;
				cmd.CommandText = CommandName;
				cmd.Parameters.AddRange(pars);

				try
				{
					if (con.State != ConnectionState.Open)
					{
						con.Open();
					}

					result = cmd.ExecuteNonQuery();
				}
				catch
				{
					throw;
				}
			}
		}
		return (result > 0);
	}

	internal static Int64 ExecuteScalar(string CommandName, CommandType cmdType, SqlParameter[] pars)
	{
		Int64 result = 0;

		using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
		{
			using (SqlCommand cmd = con.CreateCommand())
			{
				cmd.CommandType = cmdType;
				cmd.CommandText = CommandName;
				cmd.Parameters.AddRange(pars);

				try
				{
					if (con.State != ConnectionState.Open)
					{
						con.Open();
					}

					result = Convert.ToInt64(cmd.ExecuteScalar());
				}
				catch
				{
					throw;
				}
			}
		}

		return (result);
	}
}
}
