using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class UserTaxOfficeRolePartDBAccess
{


	public Int64 Insert(UserTaxOfficeRolePart userTaxOfficeRolePart)
	{
		SqlParameter[] parametersUserTaxOfficeRolePart = new SqlParameter[]
		{
			new SqlParameter("@Title", (userTaxOfficeRolePart.Title != null) ? userTaxOfficeRolePart.Title : (object)DBNull.Value),
			new SqlParameter("@Letters", (userTaxOfficeRolePart.Letters != null) ? userTaxOfficeRolePart.Letters : (object)DBNull.Value),
			new SqlParameter("@TaxOfficeCode", (userTaxOfficeRolePart.TaxOfficeCode > 0) ? userTaxOfficeRolePart.TaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@RolePartID", (userTaxOfficeRolePart.RolePartID > 0) ? userTaxOfficeRolePart.RolePartID : (object)DBNull.Value),
			new SqlParameter("@TaxUnitCode", (userTaxOfficeRolePart.TaxUnitCode != null) ? userTaxOfficeRolePart.TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@IsActive", userTaxOfficeRolePart.IsActive),
			new SqlParameter("@UserNationalCode", (userTaxOfficeRolePart.UserNationalCode > 0) ? userTaxOfficeRolePart.UserNationalCode : (object)DBNull.Value)
		};
		userTaxOfficeRolePart.UserTaxOfficeRolePartID = SqlDBHelper.ExecuteScalar("UserTaxOfficeRolePart_Insert", CommandType.StoredProcedure, parametersUserTaxOfficeRolePart);
		return userTaxOfficeRolePart.UserTaxOfficeRolePartID;
	}

	public bool Update(UserTaxOfficeRolePart userTaxOfficeRolePart)
	{
		SqlParameter[] parametersUserTaxOfficeRolePart = new SqlParameter[]
		{
			new SqlParameter("@UserTaxOfficeRolePartID", userTaxOfficeRolePart.UserTaxOfficeRolePartID),
			new SqlParameter("@Title", (userTaxOfficeRolePart.Title != null) ? userTaxOfficeRolePart.Title : (object)DBNull.Value),
			new SqlParameter("@Letters", (userTaxOfficeRolePart.Letters != null) ? userTaxOfficeRolePart.Letters : (object)DBNull.Value),
			new SqlParameter("@TaxOfficeCode", userTaxOfficeRolePart.TaxOfficeCode),
			new SqlParameter("@RolePartID", userTaxOfficeRolePart.RolePartID),
			new SqlParameter("@TaxUnitCode", (userTaxOfficeRolePart.TaxUnitCode != null) ? userTaxOfficeRolePart.TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@IsActive", userTaxOfficeRolePart.IsActive),
			new SqlParameter("@UserNationalCode", userTaxOfficeRolePart.UserNationalCode)
		};
		return SqlDBHelper.ExecuteNonQuery("UserTaxOfficeRolePart_Update", CommandType.StoredProcedure, parametersUserTaxOfficeRolePart);
	}

	public bool Delete(Int64 userTaxOfficeRolePartID)
	{
		SqlParameter[] parametersUserTaxOfficeRolePart = new SqlParameter[]
		{
			new SqlParameter("@UserTaxOfficeRolePartID", userTaxOfficeRolePartID)
		};
		return SqlDBHelper.ExecuteNonQuery("UserTaxOfficeRolePart_Delete", CommandType.StoredProcedure, parametersUserTaxOfficeRolePart);
	}

	public bool Delete(Int64 userNationalCode , int taxOfficeCode , int rolePartID)
	{
		SqlParameter[] parametersUserTaxOfficeRolePart = new SqlParameter[]
		{
			new SqlParameter("@UserNationalCode", userNationalCode),
			new SqlParameter("@TaxOfficeCode", taxOfficeCode),
			new SqlParameter("@RolePartID", rolePartID)
		};
		return SqlDBHelper.ExecuteNonQuery("UserTaxOfficeRolePart_DeleteBy_UserNationalCodeTaxOfficeCodeRolePartID", CommandType.StoredProcedure, parametersUserTaxOfficeRolePart);

	}

	public UserTaxOfficeRolePart GetDetails(Int64 userTaxOfficeRolePartID)
	{
		UserTaxOfficeRolePart userTaxOfficeRolePart = new UserTaxOfficeRolePart();

		SqlParameter[] parametersUserTaxOfficeRolePart = new SqlParameter[]
		{
			new SqlParameter("@UserTaxOfficeRolePartID", userTaxOfficeRolePartID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserTaxOfficeRolePart_GetDetails", CommandType.StoredProcedure, parametersUserTaxOfficeRolePart))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				userTaxOfficeRolePart.UserTaxOfficeRolePartID = (row["UserTaxOfficeRolePartID"] != DBNull.Value) ? Convert.ToInt64(row["UserTaxOfficeRolePartID"]) : 0 ;
				userTaxOfficeRolePart.UserFullName = row["UserFullName"].ToString();
				userTaxOfficeRolePart.TaxOfficeTitle = row["TaxOfficeTitle"].ToString();
				userTaxOfficeRolePart.RolePartIDTitle = row["RolePartIDTitle"].ToString();
				userTaxOfficeRolePart.Title = row["Title"].ToString();
				userTaxOfficeRolePart.Letters = row["Letters"].ToString();
				userTaxOfficeRolePart.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
				userTaxOfficeRolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
				userTaxOfficeRolePart.TaxUnitCode = (row["TaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxUnitCode"]) : 0 ;
				userTaxOfficeRolePart.IsActive = (row["IsActive"] != DBNull.Value) ? Convert.ToBoolean((row["IsActive"].ToString() == "1" || row["IsActive"].ToString().ToLower() == "true" ) ? true : false) : false ;
				userTaxOfficeRolePart.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
			}
		}

		return userTaxOfficeRolePart;
	}

	public UserTaxOfficeRolePart GetDetails(Int64 userNationalCode , int taxOfficeCode , int rolePartID)
	{
		UserTaxOfficeRolePart userTaxOfficeRolePart = new UserTaxOfficeRolePart();

		SqlParameter[] parametersUserTaxOfficeRolePart = new SqlParameter[]
		{
			new SqlParameter("@UserNationalCode", userNationalCode),
			new SqlParameter("@TaxOfficeCode", taxOfficeCode),
			new SqlParameter("@RolePartID", rolePartID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserTaxOfficeRolePart_GetDetailsBy_UserNationalCodeTaxOfficeCodeRolePartID", CommandType.StoredProcedure, parametersUserTaxOfficeRolePart))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				userTaxOfficeRolePart.UserTaxOfficeRolePartID = (row["UserTaxOfficeRolePartID"] != DBNull.Value) ? Convert.ToInt64(row["UserTaxOfficeRolePartID"]) : 0 ;
				userTaxOfficeRolePart.UserFullName = row["UserFullName"].ToString();
				userTaxOfficeRolePart.TaxOfficeTitle = row["TaxOfficeTitle"].ToString();
				userTaxOfficeRolePart.RolePartIDTitle = row["RolePartIDTitle"].ToString();
				userTaxOfficeRolePart.Title = row["Title"].ToString();
				userTaxOfficeRolePart.Letters = row["Letters"].ToString();
				userTaxOfficeRolePart.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
				userTaxOfficeRolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
				userTaxOfficeRolePart.TaxUnitCode = (row["TaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxUnitCode"]) : 0 ;
				userTaxOfficeRolePart.IsActive = (row["IsActive"] != DBNull.Value) ? Convert.ToBoolean((row["IsActive"].ToString() == "1" || row["IsActive"].ToString().ToLower() == "true" ) ? true : false) : false ;
				userTaxOfficeRolePart.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
			}
		}

		return userTaxOfficeRolePart;
	}

	public List<UserTaxOfficeRolePart> GetListAll()
	{
		List<UserTaxOfficeRolePart> listUserTaxOfficeRolePart = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("UserTaxOfficeRolePart_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listUserTaxOfficeRolePart = new List<UserTaxOfficeRolePart>();

				foreach (DataRow row in table.Rows)
				{
					UserTaxOfficeRolePart userTaxOfficeRolePart = new UserTaxOfficeRolePart();
					userTaxOfficeRolePart.UserTaxOfficeRolePartID = (row["UserTaxOfficeRolePartID"] != DBNull.Value) ? Convert.ToInt64(row["UserTaxOfficeRolePartID"]) : 0 ;
					userTaxOfficeRolePart.UserFullName = row["UserFullName"].ToString();
					userTaxOfficeRolePart.TaxOfficeTitle = row["TaxOfficeTitle"].ToString();
					userTaxOfficeRolePart.RolePartIDTitle = row["RolePartIDTitle"].ToString();
					userTaxOfficeRolePart.Title = row["Title"].ToString();
					userTaxOfficeRolePart.Letters = row["Letters"].ToString();
					userTaxOfficeRolePart.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
					userTaxOfficeRolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
					userTaxOfficeRolePart.TaxUnitCode = (row["TaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxUnitCode"]) : 0 ;
				userTaxOfficeRolePart.IsActive = (row["IsActive"] != DBNull.Value) ? Convert.ToBoolean((row["IsActive"].ToString() == "1" || row["IsActive"].ToString().ToLower() == "true" ) ? true : false) : false ;
					userTaxOfficeRolePart.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
					listUserTaxOfficeRolePart.Add(userTaxOfficeRolePart);
				}
			}
		}

		return listUserTaxOfficeRolePart;
	}

	public bool Exists(Int64 userTaxOfficeRolePartID)
	{
		SqlParameter[] parametersUserTaxOfficeRolePart = new SqlParameter[]
		{
			new SqlParameter("@UserTaxOfficeRolePartID", userTaxOfficeRolePartID)
		};
		return (SqlDBHelper.ExecuteScalar("UserTaxOfficeRolePart_Exists", CommandType.StoredProcedure, parametersUserTaxOfficeRolePart)>0);
	}

	public bool Exists(UserTaxOfficeRolePart userTaxOfficeRolePart)
	{
		SqlParameter[] parametersUserTaxOfficeRolePart = new SqlParameter[]
		{
			new SqlParameter("@UserTaxOfficeRolePartID", userTaxOfficeRolePart.UserTaxOfficeRolePartID)
		};
		return (SqlDBHelper.ExecuteScalar("UserTaxOfficeRolePart_Exists", CommandType.StoredProcedure, parametersUserTaxOfficeRolePart)>0);
	}

	public List<UserTaxOfficeRolePart> GetListByUserTaxOfficeRolePartUserNationalCodeTaxOfficeCodeRolePartID(Int64 userNationalCode,int taxOfficeCode,int rolePartID)
	{
		List<UserTaxOfficeRolePart> listUserTaxOfficeRolePart = new List<UserTaxOfficeRolePart>();

		//Lets get the list of all UserTaxOfficeRolePart records from database using UserNationalCode TaxOfficeCode RolePartID
		SqlParameter[] parametersUserTaxOfficeRolePart = new SqlParameter[]
		{
			new SqlParameter("@userNationalCode", userNationalCode),
			new SqlParameter("@taxOfficeCode", taxOfficeCode),
			new SqlParameter("@rolePartID", rolePartID)
		};
		//Lets get the list of UserTaxOfficeRolePart records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserTaxOfficeRolePart_GetListByUserNationalCodeTaxOfficeCodeRolePartID", CommandType.StoredProcedure, parametersUserTaxOfficeRolePart))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of userTaxOfficeRolePart
				listUserTaxOfficeRolePart = new List<UserTaxOfficeRolePart>();

				//Now lets populate the userTaxOfficeRolePart details into the list of userTaxOfficeRoleParts
				foreach (DataRow row in table.Rows)
				{
					UserTaxOfficeRolePart userTaxOfficeRolePart = new UserTaxOfficeRolePart();
					userTaxOfficeRolePart.UserTaxOfficeRolePartID = (row["UserTaxOfficeRolePartID"] != DBNull.Value) ? Convert.ToInt64(row["UserTaxOfficeRolePartID"]) : 0 ;
					userTaxOfficeRolePart.UserFullName = row["UserFullName"].ToString();
					userTaxOfficeRolePart.TaxOfficeTitle = row["TaxOfficeTitle"].ToString();
					userTaxOfficeRolePart.RolePartIDTitle = row["RolePartIDTitle"].ToString();
					userTaxOfficeRolePart.Title = row["Title"].ToString();
					userTaxOfficeRolePart.Letters = row["Letters"].ToString();
					userTaxOfficeRolePart.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
					userTaxOfficeRolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
					userTaxOfficeRolePart.TaxUnitCode = (row["TaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxUnitCode"]) : 0 ;
				userTaxOfficeRolePart.IsActive = (row["IsActive"] != DBNull.Value) ? Convert.ToBoolean((row["IsActive"].ToString() == "1" || row["IsActive"].ToString().ToLower() == "true" ) ? true : false) : false ;
					userTaxOfficeRolePart.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
					listUserTaxOfficeRolePart.Add(userTaxOfficeRolePart);
				}
			}
		}

		return listUserTaxOfficeRolePart;
	}

	public List<UserTaxOfficeRolePart> GetListByUserTaxOfficeRolePartUserNationalCodeTaxOfficeCode(Int64 userNationalCode,int taxOfficeCode)
	{
		List<UserTaxOfficeRolePart> listUserTaxOfficeRolePart = new List<UserTaxOfficeRolePart>();

		//Lets get the list of all UserTaxOfficeRolePart records from database using UserNationalCode TaxOfficeCode
		SqlParameter[] parametersUserTaxOfficeRolePart = new SqlParameter[]
		{
			new SqlParameter("@userNationalCode", userNationalCode),
			new SqlParameter("@taxOfficeCode", taxOfficeCode)
		};
		//Lets get the list of UserTaxOfficeRolePart records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserTaxOfficeRolePart_GetListByUserNationalCodeTaxOfficeCode", CommandType.StoredProcedure, parametersUserTaxOfficeRolePart))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of userTaxOfficeRolePart
				listUserTaxOfficeRolePart = new List<UserTaxOfficeRolePart>();

				//Now lets populate the userTaxOfficeRolePart details into the list of userTaxOfficeRoleParts
				foreach (DataRow row in table.Rows)
				{
					UserTaxOfficeRolePart userTaxOfficeRolePart = new UserTaxOfficeRolePart();
					userTaxOfficeRolePart.UserTaxOfficeRolePartID = (row["UserTaxOfficeRolePartID"] != DBNull.Value) ? Convert.ToInt64(row["UserTaxOfficeRolePartID"]) : 0 ;
					userTaxOfficeRolePart.UserFullName = row["UserFullName"].ToString();
					userTaxOfficeRolePart.TaxOfficeTitle = row["TaxOfficeTitle"].ToString();
					userTaxOfficeRolePart.RolePartIDTitle = row["RolePartIDTitle"].ToString();
					userTaxOfficeRolePart.Title = row["Title"].ToString();
					userTaxOfficeRolePart.Letters = row["Letters"].ToString();
					userTaxOfficeRolePart.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
					userTaxOfficeRolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
					userTaxOfficeRolePart.TaxUnitCode = (row["TaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxUnitCode"]) : 0 ;
				userTaxOfficeRolePart.IsActive = (row["IsActive"] != DBNull.Value) ? Convert.ToBoolean((row["IsActive"].ToString() == "1" || row["IsActive"].ToString().ToLower() == "true" ) ? true : false) : false ;
					userTaxOfficeRolePart.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
					listUserTaxOfficeRolePart.Add(userTaxOfficeRolePart);
				}
			}
		}

		return listUserTaxOfficeRolePart;
	}

	public List<UserTaxOfficeRolePart> SearchLike(UserTaxOfficeRolePart userTaxOfficeRolePart)
	{
		List<UserTaxOfficeRolePart> listUserTaxOfficeRolePart = new List<UserTaxOfficeRolePart>();


		SqlParameter[] parametersUserTaxOfficeRolePart = new SqlParameter[]
		{
			new SqlParameter("@UserTaxOfficeRolePartID", userTaxOfficeRolePart.UserTaxOfficeRolePartID),
			new SqlParameter("@UserFullName", userTaxOfficeRolePart.UserFullName),
			new SqlParameter("@TaxOfficeTitle", userTaxOfficeRolePart.TaxOfficeTitle),
			new SqlParameter("@RolePartIDTitle", userTaxOfficeRolePart.RolePartIDTitle),
			new SqlParameter("@Title", userTaxOfficeRolePart.Title),
			new SqlParameter("@Letters", userTaxOfficeRolePart.Letters),
			new SqlParameter("@TaxOfficeCode", userTaxOfficeRolePart.TaxOfficeCode),
			new SqlParameter("@RolePartID", userTaxOfficeRolePart.RolePartID),
			new SqlParameter("@TaxUnitCode", userTaxOfficeRolePart.TaxUnitCode),
			new SqlParameter("@IsActive", userTaxOfficeRolePart.IsActive),
			new SqlParameter("@UserNationalCode", userTaxOfficeRolePart.UserNationalCode),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserTaxOfficeRolePart_SearchLike", CommandType.StoredProcedure, parametersUserTaxOfficeRolePart))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					UserTaxOfficeRolePart tmpUserTaxOfficeRolePart = new UserTaxOfficeRolePart();
					tmpUserTaxOfficeRolePart.UserTaxOfficeRolePartID = (row["UserTaxOfficeRolePartID"] != DBNull.Value) ? Convert.ToInt64(row["UserTaxOfficeRolePartID"]) : 0 ;
					tmpUserTaxOfficeRolePart.UserFullName = row["UserFullName"].ToString();
					tmpUserTaxOfficeRolePart.TaxOfficeTitle = row["TaxOfficeTitle"].ToString();
					tmpUserTaxOfficeRolePart.RolePartIDTitle = row["RolePartIDTitle"].ToString();
					tmpUserTaxOfficeRolePart.Title = row["Title"].ToString();
					tmpUserTaxOfficeRolePart.Letters = row["Letters"].ToString();
					tmpUserTaxOfficeRolePart.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
					tmpUserTaxOfficeRolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
					tmpUserTaxOfficeRolePart.TaxUnitCode = (row["TaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxUnitCode"]) : 0 ;
					tmpUserTaxOfficeRolePart.IsActive = (row["IsActive"] != DBNull.Value) ? Convert.ToBoolean((row["IsActive"].ToString() == "1" || row["IsActive"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpUserTaxOfficeRolePart.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;

					listUserTaxOfficeRolePart.Add(tmpUserTaxOfficeRolePart);
				}
			}
		}

		return listUserTaxOfficeRolePart;
	}

}
}
