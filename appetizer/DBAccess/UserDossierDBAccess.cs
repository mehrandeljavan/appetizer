using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class UserDossierDBAccess
{


	public Int64 Insert(UserDossier userDossier)
	{
		SqlParameter[] parametersUserDossier = new SqlParameter[]
		{
			new SqlParameter("@UserNationalCode", (userDossier.UserNationalCode > 0) ? userDossier.UserNationalCode : (object)DBNull.Value),
			new SqlParameter("@DossierID", (userDossier.DossierID > 0) ? userDossier.DossierID : (object)DBNull.Value),
			new SqlParameter("@ReferrerUserNationalCode", (userDossier.ReferrerUserNationalCode != null) ? userDossier.ReferrerUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@StartDate", (userDossier.StartDate != null) ? userDossier.StartDate : (object)DBNull.Value),
			new SqlParameter("@EndDate", (userDossier.EndDate != null) ? userDossier.EndDate : (object)DBNull.Value),
			new SqlParameter("@ReferenceDate", (userDossier.ReferenceDate != null) ? userDossier.ReferenceDate : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("UserDossier_Insert", CommandType.StoredProcedure, parametersUserDossier);
	}

	public bool Update(UserDossier userDossier)
	{
		SqlParameter[] parametersUserDossier = new SqlParameter[]
		{
			new SqlParameter("@UserNationalCode", userDossier.UserNationalCode),
			new SqlParameter("@DossierID", userDossier.DossierID),
			new SqlParameter("@ReferrerUserNationalCode", (userDossier.ReferrerUserNationalCode != null) ? userDossier.ReferrerUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@StartDate", (userDossier.StartDate != null) ? userDossier.StartDate : (object)DBNull.Value),
			new SqlParameter("@EndDate", (userDossier.EndDate != null) ? userDossier.EndDate : (object)DBNull.Value),
			new SqlParameter("@ReferenceDate", (userDossier.ReferenceDate != null) ? userDossier.ReferenceDate : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("UserDossier_Update", CommandType.StoredProcedure, parametersUserDossier);
	}

	public bool Delete(Int64 userNationalCode , Int64 dossierID)
	{
		SqlParameter[] parametersUserDossier = new SqlParameter[]
		{
			new SqlParameter("@UserNationalCode", userNationalCode),
			new SqlParameter("@DossierID", dossierID)
		};
		return SqlDBHelper.ExecuteNonQuery("UserDossier_Delete", CommandType.StoredProcedure, parametersUserDossier);
	}

	public bool Delete(Int64 userNationalCode)
	{
		SqlParameter[] parametersUserDossier = new SqlParameter[]
		{
			new SqlParameter("@UserNationalCode", userNationalCode)
		};
		return SqlDBHelper.ExecuteNonQuery("UserDossier_DeleteBy_UserNationalCode", CommandType.StoredProcedure, parametersUserDossier);

	}

	public UserDossier GetDetails(Int64 userNationalCode , Int64 dossierID)
	{
		UserDossier userDossier = new UserDossier();

		SqlParameter[] parametersUserDossier = new SqlParameter[]
		{
			new SqlParameter("@UserNationalCode", userNationalCode),
			new SqlParameter("@DossierID", dossierID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserDossier_GetDetails", CommandType.StoredProcedure, parametersUserDossier))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				userDossier.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
				userDossier.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
				userDossier.UserFullName = row["UserFullName"].ToString();
				userDossier.ReferrerUserNationalCode = (row["ReferrerUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["ReferrerUserNationalCode"]) : 0 ;
				userDossier.StartDate = row["StartDate"].ToString();
				userDossier.EndDate = row["EndDate"].ToString();
				userDossier.ReferenceDate = row["ReferenceDate"].ToString();
			}
		}

		return userDossier;
	}

	public UserDossier GetDetails(Int64 userNationalCode)
	{
		UserDossier userDossier = new UserDossier();

		SqlParameter[] parametersUserDossier = new SqlParameter[]
		{
			new SqlParameter("@UserNationalCode", userNationalCode)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserDossier_GetDetailsBy_UserNationalCode", CommandType.StoredProcedure, parametersUserDossier))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				userDossier.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
				userDossier.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
				userDossier.UserFullName = row["UserFullName"].ToString();
				userDossier.ReferrerUserNationalCode = (row["ReferrerUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["ReferrerUserNationalCode"]) : 0 ;
				userDossier.StartDate = row["StartDate"].ToString();
				userDossier.EndDate = row["EndDate"].ToString();
				userDossier.ReferenceDate = row["ReferenceDate"].ToString();
			}
		}

		return userDossier;
	}

	public List<UserDossier> GetListAll()
	{
		List<UserDossier> listUserDossier = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("UserDossier_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listUserDossier = new List<UserDossier>();

				foreach (DataRow row in table.Rows)
				{
					UserDossier userDossier = new UserDossier();
					userDossier.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
					userDossier.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					userDossier.UserFullName = row["UserFullName"].ToString();
					userDossier.ReferrerUserNationalCode = (row["ReferrerUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["ReferrerUserNationalCode"]) : 0 ;
					userDossier.StartDate = row["StartDate"].ToString();
					userDossier.EndDate = row["EndDate"].ToString();
					userDossier.ReferenceDate = row["ReferenceDate"].ToString();
					listUserDossier.Add(userDossier);
				}
			}
		}

		return listUserDossier;
	}

	public bool Exists(Int64 userNationalCode , Int64 dossierID)
	{
		SqlParameter[] parametersUserDossier = new SqlParameter[]
		{
			new SqlParameter("@UserNationalCode", userNationalCode),
			new SqlParameter("@DossierID", dossierID)
		};
		return (SqlDBHelper.ExecuteScalar("UserDossier_Exists", CommandType.StoredProcedure, parametersUserDossier)>0);
	}

	public bool Exists(UserDossier userDossier)
	{
		SqlParameter[] parametersUserDossier = new SqlParameter[]
		{
			new SqlParameter("@UserNationalCode", userDossier.UserNationalCode),
			new SqlParameter("@DossierID", userDossier.DossierID)
		};
		return (SqlDBHelper.ExecuteScalar("UserDossier_Exists", CommandType.StoredProcedure, parametersUserDossier)>0);
	}

	public List<UserDossier> GetListByUserDossierUserNationalCode(Int64 userNationalCode)
	{
		List<UserDossier> listUserDossier = new List<UserDossier>();

		//Lets get the list of all UserDossier records from database using UserNationalCode
		SqlParameter[] parametersUserDossier = new SqlParameter[]
		{
			new SqlParameter("@userNationalCode", userNationalCode)
		};
		//Lets get the list of UserDossier records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserDossier_GetListByUserNationalCode", CommandType.StoredProcedure, parametersUserDossier))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of userDossier
				listUserDossier = new List<UserDossier>();

				//Now lets populate the userDossier details into the list of userDossiers
				foreach (DataRow row in table.Rows)
				{
					UserDossier userDossier = new UserDossier();
					userDossier.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
					userDossier.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					userDossier.UserFullName = row["UserFullName"].ToString();
					userDossier.ReferrerUserNationalCode = (row["ReferrerUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["ReferrerUserNationalCode"]) : 0 ;
					userDossier.StartDate = row["StartDate"].ToString();
					userDossier.EndDate = row["EndDate"].ToString();
					userDossier.ReferenceDate = row["ReferenceDate"].ToString();
					listUserDossier.Add(userDossier);
				}
			}
		}

		return listUserDossier;
	}

	public List<UserDossier> GetListByUserDossierDossierID(Int64 dossierID)
	{
		List<UserDossier> listUserDossier = new List<UserDossier>();

		//Lets get the list of all UserDossier records from database using DossierID
		SqlParameter[] parametersUserDossier = new SqlParameter[]
		{
			new SqlParameter("@dossierID", dossierID)
		};
		//Lets get the list of UserDossier records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserDossier_GetListByDossierID", CommandType.StoredProcedure, parametersUserDossier))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of userDossier
				listUserDossier = new List<UserDossier>();

				//Now lets populate the userDossier details into the list of userDossiers
				foreach (DataRow row in table.Rows)
				{
					UserDossier userDossier = new UserDossier();
					userDossier.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
					userDossier.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					userDossier.UserFullName = row["UserFullName"].ToString();
					userDossier.ReferrerUserNationalCode = (row["ReferrerUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["ReferrerUserNationalCode"]) : 0 ;
					userDossier.StartDate = row["StartDate"].ToString();
					userDossier.EndDate = row["EndDate"].ToString();
					userDossier.ReferenceDate = row["ReferenceDate"].ToString();
					listUserDossier.Add(userDossier);
				}
			}
		}

		return listUserDossier;
	}

	public List<UserDossier> SearchLike(UserDossier userDossier)
	{
		List<UserDossier> listUserDossier = new List<UserDossier>();


		SqlParameter[] parametersUserDossier = new SqlParameter[]
		{
			new SqlParameter("@UserNationalCode", userDossier.UserNationalCode),
			new SqlParameter("@DossierID", userDossier.DossierID),
			new SqlParameter("@UserFullName", userDossier.UserFullName),
			new SqlParameter("@ReferrerUserNationalCode", userDossier.ReferrerUserNationalCode),
			new SqlParameter("@StartDate", userDossier.StartDate),
			new SqlParameter("@EndDate", userDossier.EndDate),
			new SqlParameter("@ReferenceDate", userDossier.ReferenceDate),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserDossier_SearchLike", CommandType.StoredProcedure, parametersUserDossier))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					UserDossier tmpUserDossier = new UserDossier();
					tmpUserDossier.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
					tmpUserDossier.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					tmpUserDossier.UserFullName = row["UserFullName"].ToString();
					tmpUserDossier.ReferrerUserNationalCode = (row["ReferrerUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["ReferrerUserNationalCode"]) : 0 ;
					tmpUserDossier.StartDate = row["StartDate"].ToString();
					tmpUserDossier.EndDate = row["EndDate"].ToString();
					tmpUserDossier.ReferenceDate = row["ReferenceDate"].ToString();

					listUserDossier.Add(tmpUserDossier);
				}
			}
		}

		return listUserDossier;
	}

}
}
