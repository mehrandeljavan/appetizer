using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class RolePartDBAccess
{

	RolePartActivityDBAccess rolePartActivityDBAccess = new RolePartActivityDBAccess();
	UserTaxOfficeActivityRolePartDBAccess userTaxOfficeActivityRolePartDBAccess = new UserTaxOfficeActivityRolePartDBAccess();
	UserTaxOfficeRolePartDBAccess userTaxOfficeRolePartDBAccess = new UserTaxOfficeRolePartDBAccess();

	public List<RolePartActivity> GetListRolePartActivity(int rolePartID)
	{
		List<RolePartActivity> listRolePartActivity = new List<RolePartActivity>() { };
		SqlParameter[] parametersRolePart = new SqlParameter[]
		{
			new SqlParameter("@RolePartID", rolePartID)
		};

		//Lets get the list of RolePartActivity records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RolePartActivity_GetList_UseInRolePart", CommandType.StoredProcedure, parametersRolePart))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of rolePartActivity
				listRolePartActivity = new List<RolePartActivity>();

				//Now lets populate the RolePartActivity details into the list of rolePartActivitys
				foreach (DataRow row in table.Rows)
				{
					RolePartActivity rolePartActivity = ConvertRowToRolePartActivity(row);
					listRolePartActivity.Add(rolePartActivity);
				}
			}
		}

		return listRolePartActivity;
	}

	private RolePartActivity ConvertRowToRolePartActivity(DataRow row)
	{
		RolePartActivity rolePartActivity = new RolePartActivity();
		rolePartActivity.RolePartActivityID = (row["RolePartActivityID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartActivityID"]) : 0 ;
		rolePartActivity.ActivityTitle = row["ActivityTitle"].ToString();
		rolePartActivity.RolePartIDTitle = row["RolePartIDTitle"].ToString();
		rolePartActivity.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
		rolePartActivity.ActivityID = (row["ActivityID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityID"]) : 0 ;
		rolePartActivity.Permission = (row["Permission"] != DBNull.Value) ? Convert.ToInt32(row["Permission"]) : 0 ;
		return rolePartActivity;
	}
	public List<UserTaxOfficeActivityRolePart> GetListUserTaxOfficeActivityRolePart(int rolePartID)
	{
		List<UserTaxOfficeActivityRolePart> listUserTaxOfficeActivityRolePart = new List<UserTaxOfficeActivityRolePart>() { };
		SqlParameter[] parametersRolePart = new SqlParameter[]
		{
			new SqlParameter("@RolePartID", rolePartID)
		};

		//Lets get the list of UserTaxOfficeActivityRolePart records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserTaxOfficeActivityRolePart_GetList_UseInRolePart", CommandType.StoredProcedure, parametersRolePart))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of userTaxOfficeActivityRolePart
				listUserTaxOfficeActivityRolePart = new List<UserTaxOfficeActivityRolePart>();

				//Now lets populate the UserTaxOfficeActivityRolePart details into the list of userTaxOfficeActivityRoleParts
				foreach (DataRow row in table.Rows)
				{
					UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart = ConvertRowToUserTaxOfficeActivityRolePart(row);
					listUserTaxOfficeActivityRolePart.Add(userTaxOfficeActivityRolePart);
				}
			}
		}

		return listUserTaxOfficeActivityRolePart;
	}

	private UserTaxOfficeActivityRolePart ConvertRowToUserTaxOfficeActivityRolePart(DataRow row)
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
		return userTaxOfficeActivityRolePart;
	}
	public List<UserTaxOfficeRolePart> GetListUserTaxOfficeRolePart(int rolePartID)
	{
		List<UserTaxOfficeRolePart> listUserTaxOfficeRolePart = new List<UserTaxOfficeRolePart>() { };
		SqlParameter[] parametersRolePart = new SqlParameter[]
		{
			new SqlParameter("@RolePartID", rolePartID)
		};

		//Lets get the list of UserTaxOfficeRolePart records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserTaxOfficeRolePart_GetList_UseInRolePart", CommandType.StoredProcedure, parametersRolePart))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of userTaxOfficeRolePart
				listUserTaxOfficeRolePart = new List<UserTaxOfficeRolePart>();

				//Now lets populate the UserTaxOfficeRolePart details into the list of userTaxOfficeRoleParts
				foreach (DataRow row in table.Rows)
				{
					UserTaxOfficeRolePart userTaxOfficeRolePart = ConvertRowToUserTaxOfficeRolePart(row);
					listUserTaxOfficeRolePart.Add(userTaxOfficeRolePart);
				}
			}
		}

		return listUserTaxOfficeRolePart;
	}

	private UserTaxOfficeRolePart ConvertRowToUserTaxOfficeRolePart(DataRow row)
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
		return userTaxOfficeRolePart;
	}
	public Int64 Insert(RolePart rolePart)
	{
		SqlParameter[] parametersRolePart = new SqlParameter[]
		{
			new SqlParameter("@RoleTypeID", (rolePart.RoleTypeID > 0) ? rolePart.RoleTypeID : (object)DBNull.Value),
			new SqlParameter("@PartTypeID", (rolePart.PartTypeID > 0) ? rolePart.PartTypeID : (object)DBNull.Value)
		};
		rolePart.RolePartID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("RolePart_Insert", CommandType.StoredProcedure, parametersRolePart));
		return rolePart.RolePartID;
	}

	public bool Update(RolePart rolePart)
	{
		SqlParameter[] parametersRolePart = new SqlParameter[]
		{
			new SqlParameter("@RolePartID", rolePart.RolePartID),
			new SqlParameter("@RoleTypeID", rolePart.RoleTypeID),
			new SqlParameter("@PartTypeID", rolePart.PartTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("RolePart_Update", CommandType.StoredProcedure, parametersRolePart);
	}

	public bool Delete(int rolePartID)
	{
		SqlParameter[] parametersRolePart = new SqlParameter[]
		{
			new SqlParameter("@RolePartID", rolePartID)
		};
		return SqlDBHelper.ExecuteNonQuery("RolePart_Delete", CommandType.StoredProcedure, parametersRolePart);
	}

	public RolePart GetDetails(int rolePartID)
	{
		RolePart rolePart = new RolePart();

		SqlParameter[] parametersRolePart = new SqlParameter[]
		{
			new SqlParameter("@RolePartID", rolePartID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RolePart_GetDetails", CommandType.StoredProcedure, parametersRolePart))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				rolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
				rolePart.Title = row["Title"].ToString();
				rolePart.PartTypeIDTitle = row["PartTypeIDTitle"].ToString();
				rolePart.RoleTypeIDTitle = row["RoleTypeIDTitle"].ToString();
				rolePart.RoleTypeID = (row["RoleTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RoleTypeID"]) : 0 ;
				rolePart.PartTypeID = (row["PartTypeID"] != DBNull.Value) ? Convert.ToInt32(row["PartTypeID"]) : 0 ;
			}
		}

		return rolePart;
	}

	public List<RolePart> GetListAll()
	{
		List<RolePart> listRolePart = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("RolePart_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listRolePart = new List<RolePart>();

				foreach (DataRow row in table.Rows)
				{
					RolePart rolePart = new RolePart();
					rolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
					rolePart.Title = row["Title"].ToString();
					rolePart.PartTypeIDTitle = row["PartTypeIDTitle"].ToString();
					rolePart.RoleTypeIDTitle = row["RoleTypeIDTitle"].ToString();
					rolePart.RoleTypeID = (row["RoleTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RoleTypeID"]) : 0 ;
					rolePart.PartTypeID = (row["PartTypeID"] != DBNull.Value) ? Convert.ToInt32(row["PartTypeID"]) : 0 ;
					listRolePart.Add(rolePart);
				}
			}
		}

		return listRolePart;
	}

	public bool Exists(int rolePartID)
	{
		SqlParameter[] parametersRolePart = new SqlParameter[]
		{
			new SqlParameter("@RolePartID", rolePartID)
		};
		return (SqlDBHelper.ExecuteScalar("RolePart_Exists", CommandType.StoredProcedure, parametersRolePart)>0);
	}

	public bool Exists(RolePart rolePart)
	{
		SqlParameter[] parametersRolePart = new SqlParameter[]
		{
			new SqlParameter("@RolePartID", rolePart.RolePartID)
		};
		return (SqlDBHelper.ExecuteScalar("RolePart_Exists", CommandType.StoredProcedure, parametersRolePart)>0);
	}

	public List<RolePart> SearchLike(RolePart rolePart)
	{
		List<RolePart> listRolePart = new List<RolePart>();


		SqlParameter[] parametersRolePart = new SqlParameter[]
		{
			new SqlParameter("@RolePartID", rolePart.RolePartID),
			new SqlParameter("@Title", rolePart.Title),
			new SqlParameter("@PartTypeIDTitle", rolePart.PartTypeIDTitle),
			new SqlParameter("@RoleTypeIDTitle", rolePart.RoleTypeIDTitle),
			new SqlParameter("@RoleTypeID", rolePart.RoleTypeID),
			new SqlParameter("@PartTypeID", rolePart.PartTypeID),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RolePart_SearchLike", CommandType.StoredProcedure, parametersRolePart))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					RolePart tmpRolePart = new RolePart();
					tmpRolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
					tmpRolePart.Title = row["Title"].ToString();
					tmpRolePart.PartTypeIDTitle = row["PartTypeIDTitle"].ToString();
					tmpRolePart.RoleTypeIDTitle = row["RoleTypeIDTitle"].ToString();
					tmpRolePart.RoleTypeID = (row["RoleTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RoleTypeID"]) : 0 ;
					tmpRolePart.PartTypeID = (row["PartTypeID"] != DBNull.Value) ? Convert.ToInt32(row["PartTypeID"]) : 0 ;

					listRolePart.Add(tmpRolePart);
				}
			}
		}

		return listRolePart;
	}

}
}
