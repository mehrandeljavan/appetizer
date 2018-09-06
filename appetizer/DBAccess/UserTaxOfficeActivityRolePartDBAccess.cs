using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class UserTaxOfficeActivityRolePartDBAccess
{


	public Int64 Insert(UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart)
	{
		SqlParameter[] parametersUserTaxOfficeActivityRolePart = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeCode", (userTaxOfficeActivityRolePart.TaxOfficeCode > 0) ? userTaxOfficeActivityRolePart.TaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@ActivityID", (userTaxOfficeActivityRolePart.ActivityID > 0) ? userTaxOfficeActivityRolePart.ActivityID : (object)DBNull.Value),
			new SqlParameter("@RolePartID", (userTaxOfficeActivityRolePart.RolePartID > 0) ? userTaxOfficeActivityRolePart.RolePartID : (object)DBNull.Value),
			new SqlParameter("@UserNationalCode", (userTaxOfficeActivityRolePart.UserNationalCode > 0) ? userTaxOfficeActivityRolePart.UserNationalCode : (object)DBNull.Value),
			new SqlParameter("@Permission", userTaxOfficeActivityRolePart.Permission)
		};
		return SqlDBHelper.ExecuteScalar("UserTaxOfficeActivityRolePart_Insert", CommandType.StoredProcedure, parametersUserTaxOfficeActivityRolePart);
	}

	public bool Update(UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart)
	{
		SqlParameter[] parametersUserTaxOfficeActivityRolePart = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeCode", userTaxOfficeActivityRolePart.TaxOfficeCode),
			new SqlParameter("@ActivityID", userTaxOfficeActivityRolePart.ActivityID),
			new SqlParameter("@RolePartID", userTaxOfficeActivityRolePart.RolePartID),
			new SqlParameter("@UserNationalCode", userTaxOfficeActivityRolePart.UserNationalCode),
			new SqlParameter("@Permission", userTaxOfficeActivityRolePart.Permission)
		};
		return SqlDBHelper.ExecuteNonQuery("UserTaxOfficeActivityRolePart_Update", CommandType.StoredProcedure, parametersUserTaxOfficeActivityRolePart);
	}

	public bool Delete(int taxOfficeCode , int activityID , int rolePartID , Int64 userNationalCode)
	{
		SqlParameter[] parametersUserTaxOfficeActivityRolePart = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeCode", taxOfficeCode),
			new SqlParameter("@ActivityID", activityID),
			new SqlParameter("@RolePartID", rolePartID),
			new SqlParameter("@UserNationalCode", userNationalCode)
		};
		return SqlDBHelper.ExecuteNonQuery("UserTaxOfficeActivityRolePart_Delete", CommandType.StoredProcedure, parametersUserTaxOfficeActivityRolePart);
	}

	public bool Delete(Int64 userNationalCode , int taxOfficeCode)
	{
		SqlParameter[] parametersUserTaxOfficeActivityRolePart = new SqlParameter[]
		{
			new SqlParameter("@UserNationalCode", userNationalCode),
			new SqlParameter("@TaxOfficeCode", taxOfficeCode)
		};
		return SqlDBHelper.ExecuteNonQuery("UserTaxOfficeActivityRolePart_DeleteBy_UserNationalCodeTaxOfficeCode", CommandType.StoredProcedure, parametersUserTaxOfficeActivityRolePart);

	}

	public UserTaxOfficeActivityRolePart GetDetails(int taxOfficeCode , int activityID , int rolePartID , Int64 userNationalCode)
	{
		UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart = new UserTaxOfficeActivityRolePart();

		SqlParameter[] parametersUserTaxOfficeActivityRolePart = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeCode", taxOfficeCode),
			new SqlParameter("@ActivityID", activityID),
			new SqlParameter("@RolePartID", rolePartID),
			new SqlParameter("@UserNationalCode", userNationalCode)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserTaxOfficeActivityRolePart_GetDetails", CommandType.StoredProcedure, parametersUserTaxOfficeActivityRolePart))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				userTaxOfficeActivityRolePart.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
				userTaxOfficeActivityRolePart.ActivityID = (row["ActivityID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityID"]) : 0 ;
				userTaxOfficeActivityRolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
				userTaxOfficeActivityRolePart.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
				userTaxOfficeActivityRolePart.UserFullName = row["UserFullName"].ToString();
				userTaxOfficeActivityRolePart.TaxOfficeCodeTitle = row["TaxOfficeCodeTitle"].ToString();
				userTaxOfficeActivityRolePart.RolePartIDTitle = row["RolePartIDTitle"].ToString();
				userTaxOfficeActivityRolePart.ActivityTitle = row["ActivityTitle"].ToString();
				userTaxOfficeActivityRolePart.Permission = (row["Permission"] != DBNull.Value) ? Convert.ToInt32(row["Permission"]) : 0 ;
			}
		}

		return userTaxOfficeActivityRolePart;
	}

	public UserTaxOfficeActivityRolePart GetDetails(Int64 userNationalCode , int taxOfficeCode)
	{
		UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart = new UserTaxOfficeActivityRolePart();

		SqlParameter[] parametersUserTaxOfficeActivityRolePart = new SqlParameter[]
		{
			new SqlParameter("@UserNationalCode", userNationalCode),
			new SqlParameter("@TaxOfficeCode", taxOfficeCode)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserTaxOfficeActivityRolePart_GetDetailsBy_UserNationalCodeTaxOfficeCode", CommandType.StoredProcedure, parametersUserTaxOfficeActivityRolePart))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				userTaxOfficeActivityRolePart.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
				userTaxOfficeActivityRolePart.ActivityID = (row["ActivityID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityID"]) : 0 ;
				userTaxOfficeActivityRolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
				userTaxOfficeActivityRolePart.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
				userTaxOfficeActivityRolePart.UserFullName = row["UserFullName"].ToString();
				userTaxOfficeActivityRolePart.TaxOfficeCodeTitle = row["TaxOfficeCodeTitle"].ToString();
				userTaxOfficeActivityRolePart.RolePartIDTitle = row["RolePartIDTitle"].ToString();
				userTaxOfficeActivityRolePart.ActivityTitle = row["ActivityTitle"].ToString();
				userTaxOfficeActivityRolePart.Permission = (row["Permission"] != DBNull.Value) ? Convert.ToInt32(row["Permission"]) : 0 ;
			}
		}

		return userTaxOfficeActivityRolePart;
	}

	public List<UserTaxOfficeActivityRolePart> GetListAll()
	{
		List<UserTaxOfficeActivityRolePart> listUserTaxOfficeActivityRolePart = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("UserTaxOfficeActivityRolePart_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listUserTaxOfficeActivityRolePart = new List<UserTaxOfficeActivityRolePart>();

				foreach (DataRow row in table.Rows)
				{
					UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart = new UserTaxOfficeActivityRolePart();
					userTaxOfficeActivityRolePart.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
					userTaxOfficeActivityRolePart.ActivityID = (row["ActivityID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityID"]) : 0 ;
					userTaxOfficeActivityRolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
					userTaxOfficeActivityRolePart.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
					userTaxOfficeActivityRolePart.UserFullName = row["UserFullName"].ToString();
					userTaxOfficeActivityRolePart.TaxOfficeCodeTitle = row["TaxOfficeCodeTitle"].ToString();
					userTaxOfficeActivityRolePart.RolePartIDTitle = row["RolePartIDTitle"].ToString();
					userTaxOfficeActivityRolePart.ActivityTitle = row["ActivityTitle"].ToString();
					userTaxOfficeActivityRolePart.Permission = (row["Permission"] != DBNull.Value) ? Convert.ToInt32(row["Permission"]) : 0 ;
					listUserTaxOfficeActivityRolePart.Add(userTaxOfficeActivityRolePart);
				}
			}
		}

		return listUserTaxOfficeActivityRolePart;
	}

	public bool Exists(int taxOfficeCode , int activityID , int rolePartID , Int64 userNationalCode)
	{
		SqlParameter[] parametersUserTaxOfficeActivityRolePart = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeCode", taxOfficeCode),
			new SqlParameter("@ActivityID", activityID),
			new SqlParameter("@RolePartID", rolePartID),
			new SqlParameter("@UserNationalCode", userNationalCode)
		};
		return (SqlDBHelper.ExecuteScalar("UserTaxOfficeActivityRolePart_Exists", CommandType.StoredProcedure, parametersUserTaxOfficeActivityRolePart)>0);
	}

	public bool Exists(UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart)
	{
		SqlParameter[] parametersUserTaxOfficeActivityRolePart = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeCode", userTaxOfficeActivityRolePart.TaxOfficeCode),
			new SqlParameter("@ActivityID", userTaxOfficeActivityRolePart.ActivityID),
			new SqlParameter("@RolePartID", userTaxOfficeActivityRolePart.RolePartID),
			new SqlParameter("@UserNationalCode", userTaxOfficeActivityRolePart.UserNationalCode)
		};
		return (SqlDBHelper.ExecuteScalar("UserTaxOfficeActivityRolePart_Exists", CommandType.StoredProcedure, parametersUserTaxOfficeActivityRolePart)>0);
	}

	public List<UserTaxOfficeActivityRolePart> GetListByUserTaxOfficeActivityRolePartUserNationalCodeTaxOfficeCode(Int64 userNationalCode,int taxOfficeCode)
	{
		List<UserTaxOfficeActivityRolePart> listUserTaxOfficeActivityRolePart = new List<UserTaxOfficeActivityRolePart>();

		//Lets get the list of all UserTaxOfficeActivityRolePart records from database using UserNationalCode TaxOfficeCode
		SqlParameter[] parametersUserTaxOfficeActivityRolePart = new SqlParameter[]
		{
			new SqlParameter("@userNationalCode", userNationalCode),
			new SqlParameter("@taxOfficeCode", taxOfficeCode)
		};
		//Lets get the list of UserTaxOfficeActivityRolePart records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserTaxOfficeActivityRolePart_GetListByUserNationalCodeTaxOfficeCode", CommandType.StoredProcedure, parametersUserTaxOfficeActivityRolePart))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of userTaxOfficeActivityRolePart
				listUserTaxOfficeActivityRolePart = new List<UserTaxOfficeActivityRolePart>();

				//Now lets populate the userTaxOfficeActivityRolePart details into the list of userTaxOfficeActivityRoleParts
				foreach (DataRow row in table.Rows)
				{
					UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart = new UserTaxOfficeActivityRolePart();
					userTaxOfficeActivityRolePart.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
					userTaxOfficeActivityRolePart.ActivityID = (row["ActivityID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityID"]) : 0 ;
					userTaxOfficeActivityRolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
					userTaxOfficeActivityRolePart.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
					userTaxOfficeActivityRolePart.UserFullName = row["UserFullName"].ToString();
					userTaxOfficeActivityRolePart.TaxOfficeCodeTitle = row["TaxOfficeCodeTitle"].ToString();
					userTaxOfficeActivityRolePart.RolePartIDTitle = row["RolePartIDTitle"].ToString();
					userTaxOfficeActivityRolePart.ActivityTitle = row["ActivityTitle"].ToString();
					userTaxOfficeActivityRolePart.Permission = (row["Permission"] != DBNull.Value) ? Convert.ToInt32(row["Permission"]) : 0 ;
					listUserTaxOfficeActivityRolePart.Add(userTaxOfficeActivityRolePart);
				}
			}
		}

		return listUserTaxOfficeActivityRolePart;
	}

	public List<UserTaxOfficeActivityRolePart> GetListByUserTaxOfficeActivityRolePartUserNationalCodeTaxOfficeCodeRolePartID(Int64 userNationalCode,int taxOfficeCode,int rolePartID)
	{
		List<UserTaxOfficeActivityRolePart> listUserTaxOfficeActivityRolePart = new List<UserTaxOfficeActivityRolePart>();

		//Lets get the list of all UserTaxOfficeActivityRolePart records from database using UserNationalCode TaxOfficeCode RolePartID
		SqlParameter[] parametersUserTaxOfficeActivityRolePart = new SqlParameter[]
		{
			new SqlParameter("@userNationalCode", userNationalCode),
			new SqlParameter("@taxOfficeCode", taxOfficeCode),
			new SqlParameter("@rolePartID", rolePartID)
		};
		//Lets get the list of UserTaxOfficeActivityRolePart records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserTaxOfficeActivityRolePart_GetListByUserNationalCodeTaxOfficeCodeRolePartID", CommandType.StoredProcedure, parametersUserTaxOfficeActivityRolePart))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of userTaxOfficeActivityRolePart
				listUserTaxOfficeActivityRolePart = new List<UserTaxOfficeActivityRolePart>();

				//Now lets populate the userTaxOfficeActivityRolePart details into the list of userTaxOfficeActivityRoleParts
				foreach (DataRow row in table.Rows)
				{
					UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart = new UserTaxOfficeActivityRolePart();
					userTaxOfficeActivityRolePart.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
					userTaxOfficeActivityRolePart.ActivityID = (row["ActivityID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityID"]) : 0 ;
					userTaxOfficeActivityRolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
					userTaxOfficeActivityRolePart.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
					userTaxOfficeActivityRolePart.UserFullName = row["UserFullName"].ToString();
					userTaxOfficeActivityRolePart.TaxOfficeCodeTitle = row["TaxOfficeCodeTitle"].ToString();
					userTaxOfficeActivityRolePart.RolePartIDTitle = row["RolePartIDTitle"].ToString();
					userTaxOfficeActivityRolePart.ActivityTitle = row["ActivityTitle"].ToString();
					userTaxOfficeActivityRolePart.Permission = (row["Permission"] != DBNull.Value) ? Convert.ToInt32(row["Permission"]) : 0 ;
					listUserTaxOfficeActivityRolePart.Add(userTaxOfficeActivityRolePart);
				}
			}
		}

		return listUserTaxOfficeActivityRolePart;
	}

	public List<UserTaxOfficeActivityRolePart> GetListByUserTaxOfficeActivityRolePartUserNationalCodeTaxOfficeCodeActivityIDRolePartID(Int64 userNationalCode,int taxOfficeCode,int activityID,int rolePartID)
	{
		List<UserTaxOfficeActivityRolePart> listUserTaxOfficeActivityRolePart = new List<UserTaxOfficeActivityRolePart>();

		//Lets get the list of all UserTaxOfficeActivityRolePart records from database using UserNationalCode TaxOfficeCode ActivityID RolePartID
		SqlParameter[] parametersUserTaxOfficeActivityRolePart = new SqlParameter[]
		{
			new SqlParameter("@userNationalCode", userNationalCode),
			new SqlParameter("@taxOfficeCode", taxOfficeCode),
			new SqlParameter("@activityID", activityID),
			new SqlParameter("@rolePartID", rolePartID)
		};
		//Lets get the list of UserTaxOfficeActivityRolePart records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserTaxOfficeActivityRolePart_GetListByUserNationalCodeTaxOfficeCodeActivityIDRolePartID", CommandType.StoredProcedure, parametersUserTaxOfficeActivityRolePart))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of userTaxOfficeActivityRolePart
				listUserTaxOfficeActivityRolePart = new List<UserTaxOfficeActivityRolePart>();

				//Now lets populate the userTaxOfficeActivityRolePart details into the list of userTaxOfficeActivityRoleParts
				foreach (DataRow row in table.Rows)
				{
					UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart = new UserTaxOfficeActivityRolePart();
					userTaxOfficeActivityRolePart.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
					userTaxOfficeActivityRolePart.ActivityID = (row["ActivityID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityID"]) : 0 ;
					userTaxOfficeActivityRolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
					userTaxOfficeActivityRolePart.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
					userTaxOfficeActivityRolePart.UserFullName = row["UserFullName"].ToString();
					userTaxOfficeActivityRolePart.TaxOfficeCodeTitle = row["TaxOfficeCodeTitle"].ToString();
					userTaxOfficeActivityRolePart.RolePartIDTitle = row["RolePartIDTitle"].ToString();
					userTaxOfficeActivityRolePart.ActivityTitle = row["ActivityTitle"].ToString();
					userTaxOfficeActivityRolePart.Permission = (row["Permission"] != DBNull.Value) ? Convert.ToInt32(row["Permission"]) : 0 ;
					listUserTaxOfficeActivityRolePart.Add(userTaxOfficeActivityRolePart);
				}
			}
		}

		return listUserTaxOfficeActivityRolePart;
	}

	public List<UserTaxOfficeActivityRolePart> SearchLike(UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart)
	{
		List<UserTaxOfficeActivityRolePart> listUserTaxOfficeActivityRolePart = new List<UserTaxOfficeActivityRolePart>();


		SqlParameter[] parametersUserTaxOfficeActivityRolePart = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeCode", userTaxOfficeActivityRolePart.TaxOfficeCode),
			new SqlParameter("@ActivityID", userTaxOfficeActivityRolePart.ActivityID),
			new SqlParameter("@RolePartID", userTaxOfficeActivityRolePart.RolePartID),
			new SqlParameter("@UserNationalCode", userTaxOfficeActivityRolePart.UserNationalCode),
			new SqlParameter("@UserFullName", userTaxOfficeActivityRolePart.UserFullName),
			new SqlParameter("@TaxOfficeCodeTitle", userTaxOfficeActivityRolePart.TaxOfficeCodeTitle),
			new SqlParameter("@RolePartIDTitle", userTaxOfficeActivityRolePart.RolePartIDTitle),
			new SqlParameter("@ActivityTitle", userTaxOfficeActivityRolePart.ActivityTitle),
			new SqlParameter("@Permission", userTaxOfficeActivityRolePart.Permission),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserTaxOfficeActivityRolePart_SearchLike", CommandType.StoredProcedure, parametersUserTaxOfficeActivityRolePart))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					UserTaxOfficeActivityRolePart tmpUserTaxOfficeActivityRolePart = new UserTaxOfficeActivityRolePart();
					tmpUserTaxOfficeActivityRolePart.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
					tmpUserTaxOfficeActivityRolePart.ActivityID = (row["ActivityID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityID"]) : 0 ;
					tmpUserTaxOfficeActivityRolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
					tmpUserTaxOfficeActivityRolePart.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
					tmpUserTaxOfficeActivityRolePart.UserFullName = row["UserFullName"].ToString();
					tmpUserTaxOfficeActivityRolePart.TaxOfficeCodeTitle = row["TaxOfficeCodeTitle"].ToString();
					tmpUserTaxOfficeActivityRolePart.RolePartIDTitle = row["RolePartIDTitle"].ToString();
					tmpUserTaxOfficeActivityRolePart.ActivityTitle = row["ActivityTitle"].ToString();
					tmpUserTaxOfficeActivityRolePart.Permission = (row["Permission"] != DBNull.Value) ? Convert.ToInt32(row["Permission"]) : 0 ;

					listUserTaxOfficeActivityRolePart.Add(tmpUserTaxOfficeActivityRolePart);
				}
			}
		}

		return listUserTaxOfficeActivityRolePart;
	}

}
}
