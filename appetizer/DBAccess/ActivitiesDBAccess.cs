using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class ActivitiesDBAccess
{

	RolePartActivityDBAccess rolePartActivityDBAccess = new RolePartActivityDBAccess();
	UserTaxOfficeActivityRolePartDBAccess userTaxOfficeActivityRolePartDBAccess = new UserTaxOfficeActivityRolePartDBAccess();

	public List<RolePartActivity> GetListRolePartActivity(int activityID)
	{
		List<RolePartActivity> listRolePartActivity = new List<RolePartActivity>() { };
		SqlParameter[] parametersActivities = new SqlParameter[]
		{
			new SqlParameter("@ActivityID", activityID)
		};

		//Lets get the list of RolePartActivity records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RolePartActivity_GetList_UseInActivities", CommandType.StoredProcedure, parametersActivities))
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
	public List<UserTaxOfficeActivityRolePart> GetListUserTaxOfficeActivityRolePart(int activityID)
	{
		List<UserTaxOfficeActivityRolePart> listUserTaxOfficeActivityRolePart = new List<UserTaxOfficeActivityRolePart>() { };
		SqlParameter[] parametersActivities = new SqlParameter[]
		{
			new SqlParameter("@ActivityID", activityID)
		};

		//Lets get the list of UserTaxOfficeActivityRolePart records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserTaxOfficeActivityRolePart_GetList_UseInActivities", CommandType.StoredProcedure, parametersActivities))
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
	public Int64 Insert(Activities activities)
	{
		SqlParameter[] parametersActivities = new SqlParameter[]
		{
			new SqlParameter("@OrderNumber", (activities.OrderNumber != null) ? activities.OrderNumber : (object)DBNull.Value),
			new SqlParameter("@Prefix", (activities.Prefix != null) ? activities.Prefix : (object)DBNull.Value),
			new SqlParameter("@ActivityTitle", (activities.ActivityTitle != null) ? activities.ActivityTitle : (object)DBNull.Value),
			new SqlParameter("@ActivityConstantTitle", (activities.ActivityConstantTitle != null) ? activities.ActivityConstantTitle : (object)DBNull.Value),
			new SqlParameter("@ActivityCategory", (activities.ActivityCategory != null) ? activities.ActivityCategory : (object)DBNull.Value)
		};
		activities.ActivityID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("Activities_Insert", CommandType.StoredProcedure, parametersActivities));
		return activities.ActivityID;
	}

	public bool Update(Activities activities)
	{
		SqlParameter[] parametersActivities = new SqlParameter[]
		{
			new SqlParameter("@ActivityID", activities.ActivityID),
			new SqlParameter("@OrderNumber", (activities.OrderNumber != null) ? activities.OrderNumber : (object)DBNull.Value),
			new SqlParameter("@Prefix", (activities.Prefix != null) ? activities.Prefix : (object)DBNull.Value),
			new SqlParameter("@ActivityTitle", (activities.ActivityTitle != null) ? activities.ActivityTitle : (object)DBNull.Value),
			new SqlParameter("@ActivityConstantTitle", (activities.ActivityConstantTitle != null) ? activities.ActivityConstantTitle : (object)DBNull.Value),
			new SqlParameter("@ActivityCategory", (activities.ActivityCategory != null) ? activities.ActivityCategory : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Activities_Update", CommandType.StoredProcedure, parametersActivities);
	}

	public bool Delete(int activityID)
	{
		SqlParameter[] parametersActivities = new SqlParameter[]
		{
			new SqlParameter("@ActivityID", activityID)
		};
		return SqlDBHelper.ExecuteNonQuery("Activities_Delete", CommandType.StoredProcedure, parametersActivities);
	}

	public Activities GetDetails(int activityID)
	{
		Activities activities = new Activities();

		SqlParameter[] parametersActivities = new SqlParameter[]
		{
			new SqlParameter("@ActivityID", activityID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Activities_GetDetails", CommandType.StoredProcedure, parametersActivities))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				activities.ActivityID = (row["ActivityID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityID"]) : 0 ;
				activities.OrderNumber = (row["OrderNumber"] != DBNull.Value) ? Convert.ToInt32(row["OrderNumber"]) : 0 ;
				activities.Prefix = row["Prefix"].ToString();
				activities.ActivityTitle = row["ActivityTitle"].ToString();
				activities.ActivityConstantTitle = row["ActivityConstantTitle"].ToString();
				activities.ActivityCategory = row["ActivityCategory"].ToString();
			}
		}

		return activities;
	}

	public List<Activities> GetListAll()
	{
		List<Activities> listActivities = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Activities_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listActivities = new List<Activities>();

				foreach (DataRow row in table.Rows)
				{
					Activities activities = new Activities();
					activities.ActivityID = (row["ActivityID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityID"]) : 0 ;
					activities.OrderNumber = (row["OrderNumber"] != DBNull.Value) ? Convert.ToInt32(row["OrderNumber"]) : 0 ;
					activities.Prefix = row["Prefix"].ToString();
					activities.ActivityTitle = row["ActivityTitle"].ToString();
					activities.ActivityConstantTitle = row["ActivityConstantTitle"].ToString();
					activities.ActivityCategory = row["ActivityCategory"].ToString();
					listActivities.Add(activities);
				}
			}
		}

		return listActivities;
	}

	public bool Exists(int activityID)
	{
		SqlParameter[] parametersActivities = new SqlParameter[]
		{
			new SqlParameter("@ActivityID", activityID)
		};
		return (SqlDBHelper.ExecuteScalar("Activities_Exists", CommandType.StoredProcedure, parametersActivities)>0);
	}

	public bool Exists(Activities activities)
	{
		SqlParameter[] parametersActivities = new SqlParameter[]
		{
			new SqlParameter("@ActivityID", activities.ActivityID)
		};
		return (SqlDBHelper.ExecuteScalar("Activities_Exists", CommandType.StoredProcedure, parametersActivities)>0);
	}

	public List<Activities> SearchLike(Activities activities)
	{
		List<Activities> listActivities = new List<Activities>();


		SqlParameter[] parametersActivities = new SqlParameter[]
		{
			new SqlParameter("@ActivityID", activities.ActivityID),
			new SqlParameter("@OrderNumber", activities.OrderNumber),
			new SqlParameter("@Prefix", activities.Prefix),
			new SqlParameter("@ActivityTitle", activities.ActivityTitle),
			new SqlParameter("@ActivityConstantTitle", activities.ActivityConstantTitle),
			new SqlParameter("@ActivityCategory", activities.ActivityCategory),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Activities_SearchLike", CommandType.StoredProcedure, parametersActivities))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Activities tmpActivities = new Activities();
					tmpActivities.ActivityID = (row["ActivityID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityID"]) : 0 ;
					tmpActivities.OrderNumber = (row["OrderNumber"] != DBNull.Value) ? Convert.ToInt32(row["OrderNumber"]) : 0 ;
					tmpActivities.Prefix = row["Prefix"].ToString();
					tmpActivities.ActivityTitle = row["ActivityTitle"].ToString();
					tmpActivities.ActivityConstantTitle = row["ActivityConstantTitle"].ToString();
					tmpActivities.ActivityCategory = row["ActivityCategory"].ToString();

					listActivities.Add(tmpActivities);
				}
			}
		}

		return listActivities;
	}

}
}
