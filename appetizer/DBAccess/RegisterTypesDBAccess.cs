using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class RegisterTypesDBAccess
{

	RegisterInformationDBAccess registerInformationDBAccess = new RegisterInformationDBAccess();

	public List<RegisterInformation> GetListRegisterInformation(int registerTypeID)
	{
		List<RegisterInformation> listRegisterInformation = new List<RegisterInformation>() { };
		SqlParameter[] parametersRegisterTypes = new SqlParameter[]
		{
			new SqlParameter("@RegisterTypeID", registerTypeID)
		};

		//Lets get the list of RegisterInformation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RegisterInformation_GetList_UseInRegisterTypes", CommandType.StoredProcedure, parametersRegisterTypes))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of registerInformation
				listRegisterInformation = new List<RegisterInformation>();

				//Now lets populate the RegisterInformation details into the list of registerInformations
				foreach (DataRow row in table.Rows)
				{
					RegisterInformation registerInformation = ConvertRowToRegisterInformation(row);
					listRegisterInformation.Add(registerInformation);
				}
			}
		}

		return listRegisterInformation;
	}

	private RegisterInformation ConvertRowToRegisterInformation(DataRow row)
	{
		RegisterInformation registerInformation = new RegisterInformation();
		registerInformation.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		registerInformation.RegisterTypeIDTitle = row["RegisterTypeIDTitle"].ToString();
		registerInformation.RegisterTypeID = (row["RegisterTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RegisterTypeID"]) : 0 ;
		registerInformation.UserID = (row["UserID"] != DBNull.Value) ? Convert.ToInt64(row["UserID"]) : 0 ;
		registerInformation.OldID = (row["OldID"] != DBNull.Value) ? Convert.ToInt64(row["OldID"]) : 0 ;
		registerInformation.OldRegisterInformationID = (row["OldRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["OldRegisterInformationID"]) : 0 ;
		registerInformation.RegisterDate = row["RegisterDate"].ToString();
		registerInformation.RegisterTime = row["RegisterTime"].ToString();
		registerInformation.OldRegisterDate = row["OldRegisterDate"].ToString();
		return registerInformation;
	}
	public Int64 Insert(RegisterTypes registerTypes)
	{
		SqlParameter[] parametersRegisterTypes = new SqlParameter[]
		{
			new SqlParameter("@RegisterTypeID", registerTypes.RegisterTypeID),
			new SqlParameter("@Title", (registerTypes.Title != null) ? registerTypes.Title : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("RegisterTypes_Insert", CommandType.StoredProcedure, parametersRegisterTypes);
	}

	public bool Update(RegisterTypes registerTypes)
	{
		SqlParameter[] parametersRegisterTypes = new SqlParameter[]
		{
			new SqlParameter("@RegisterTypeID", registerTypes.RegisterTypeID),
			new SqlParameter("@Title", (registerTypes.Title != null) ? registerTypes.Title : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("RegisterTypes_Update", CommandType.StoredProcedure, parametersRegisterTypes);
	}

	public bool Delete(int registerTypeID)
	{
		SqlParameter[] parametersRegisterTypes = new SqlParameter[]
		{
			new SqlParameter("@RegisterTypeID", registerTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("RegisterTypes_Delete", CommandType.StoredProcedure, parametersRegisterTypes);
	}

	public RegisterTypes GetDetails(int registerTypeID)
	{
		RegisterTypes registerTypes = new RegisterTypes();

		SqlParameter[] parametersRegisterTypes = new SqlParameter[]
		{
			new SqlParameter("@RegisterTypeID", registerTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RegisterTypes_GetDetails", CommandType.StoredProcedure, parametersRegisterTypes))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				registerTypes.RegisterTypeID = (row["RegisterTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RegisterTypeID"]) : 0 ;
				registerTypes.Title = row["Title"].ToString();
			}
		}

		return registerTypes;
	}

	public List<RegisterTypes> GetListAll()
	{
		List<RegisterTypes> listRegisterTypes = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("RegisterTypes_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listRegisterTypes = new List<RegisterTypes>();

				foreach (DataRow row in table.Rows)
				{
					RegisterTypes registerTypes = new RegisterTypes();
					registerTypes.RegisterTypeID = (row["RegisterTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RegisterTypeID"]) : 0 ;
					registerTypes.Title = row["Title"].ToString();
					listRegisterTypes.Add(registerTypes);
				}
			}
		}

		return listRegisterTypes;
	}

	public bool Exists(int registerTypeID)
	{
		SqlParameter[] parametersRegisterTypes = new SqlParameter[]
		{
			new SqlParameter("@RegisterTypeID", registerTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("RegisterTypes_Exists", CommandType.StoredProcedure, parametersRegisterTypes)>0);
	}

	public bool Exists(RegisterTypes registerTypes)
	{
		SqlParameter[] parametersRegisterTypes = new SqlParameter[]
		{
			new SqlParameter("@RegisterTypeID", registerTypes.RegisterTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("RegisterTypes_Exists", CommandType.StoredProcedure, parametersRegisterTypes)>0);
	}

	public List<RegisterTypes> SearchLike(RegisterTypes registerTypes)
	{
		List<RegisterTypes> listRegisterTypes = new List<RegisterTypes>();


		SqlParameter[] parametersRegisterTypes = new SqlParameter[]
		{
			new SqlParameter("@RegisterTypeID", registerTypes.RegisterTypeID),
			new SqlParameter("@Title", registerTypes.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RegisterTypes_SearchLike", CommandType.StoredProcedure, parametersRegisterTypes))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					RegisterTypes tmpRegisterTypes = new RegisterTypes();
					tmpRegisterTypes.RegisterTypeID = (row["RegisterTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RegisterTypeID"]) : 0 ;
					tmpRegisterTypes.Title = row["Title"].ToString();

					listRegisterTypes.Add(tmpRegisterTypes);
				}
			}
		}

		return listRegisterTypes;
	}

}
}
