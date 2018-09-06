using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class RolePartActivityDBAccess
{


	public Int64 Insert(RolePartActivity rolePartActivity)
	{
		SqlParameter[] parametersRolePartActivity = new SqlParameter[]
		{
			new SqlParameter("@RolePartID", (rolePartActivity.RolePartID > 0) ? rolePartActivity.RolePartID : (object)DBNull.Value),
			new SqlParameter("@ActivityID", (rolePartActivity.ActivityID > 0) ? rolePartActivity.ActivityID : (object)DBNull.Value),
			new SqlParameter("@Permission", (rolePartActivity.Permission != null) ? rolePartActivity.Permission : (object)DBNull.Value)
		};
		rolePartActivity.RolePartActivityID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("RolePartActivity_Insert", CommandType.StoredProcedure, parametersRolePartActivity));
		return rolePartActivity.RolePartActivityID;
	}

	public bool Update(RolePartActivity rolePartActivity)
	{
		SqlParameter[] parametersRolePartActivity = new SqlParameter[]
		{
			new SqlParameter("@RolePartActivityID", rolePartActivity.RolePartActivityID),
			new SqlParameter("@RolePartID", rolePartActivity.RolePartID),
			new SqlParameter("@ActivityID", rolePartActivity.ActivityID),
			new SqlParameter("@Permission", (rolePartActivity.Permission != null) ? rolePartActivity.Permission : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("RolePartActivity_Update", CommandType.StoredProcedure, parametersRolePartActivity);
	}

	public bool Delete(int rolePartActivityID)
	{
		SqlParameter[] parametersRolePartActivity = new SqlParameter[]
		{
			new SqlParameter("@RolePartActivityID", rolePartActivityID)
		};
		return SqlDBHelper.ExecuteNonQuery("RolePartActivity_Delete", CommandType.StoredProcedure, parametersRolePartActivity);
	}

	public RolePartActivity GetDetails(int rolePartActivityID)
	{
		RolePartActivity rolePartActivity = new RolePartActivity();

		SqlParameter[] parametersRolePartActivity = new SqlParameter[]
		{
			new SqlParameter("@RolePartActivityID", rolePartActivityID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RolePartActivity_GetDetails", CommandType.StoredProcedure, parametersRolePartActivity))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				rolePartActivity.RolePartActivityID = (row["RolePartActivityID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartActivityID"]) : 0 ;
				rolePartActivity.ActivityTitle = row["ActivityTitle"].ToString();
				rolePartActivity.RolePartIDTitle = row["RolePartIDTitle"].ToString();
				rolePartActivity.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
				rolePartActivity.ActivityID = (row["ActivityID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityID"]) : 0 ;
				rolePartActivity.Permission = (row["Permission"] != DBNull.Value) ? Convert.ToInt32(row["Permission"]) : 0 ;
			}
		}

		return rolePartActivity;
	}

	public List<RolePartActivity> GetListAll()
	{
		List<RolePartActivity> listRolePartActivity = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("RolePartActivity_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listRolePartActivity = new List<RolePartActivity>();

				foreach (DataRow row in table.Rows)
				{
					RolePartActivity rolePartActivity = new RolePartActivity();
					rolePartActivity.RolePartActivityID = (row["RolePartActivityID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartActivityID"]) : 0 ;
					rolePartActivity.ActivityTitle = row["ActivityTitle"].ToString();
					rolePartActivity.RolePartIDTitle = row["RolePartIDTitle"].ToString();
					rolePartActivity.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
					rolePartActivity.ActivityID = (row["ActivityID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityID"]) : 0 ;
					rolePartActivity.Permission = (row["Permission"] != DBNull.Value) ? Convert.ToInt32(row["Permission"]) : 0 ;
					listRolePartActivity.Add(rolePartActivity);
				}
			}
		}

		return listRolePartActivity;
	}

	public bool Exists(int rolePartActivityID)
	{
		SqlParameter[] parametersRolePartActivity = new SqlParameter[]
		{
			new SqlParameter("@RolePartActivityID", rolePartActivityID)
		};
		return (SqlDBHelper.ExecuteScalar("RolePartActivity_Exists", CommandType.StoredProcedure, parametersRolePartActivity)>0);
	}

	public bool Exists(RolePartActivity rolePartActivity)
	{
		SqlParameter[] parametersRolePartActivity = new SqlParameter[]
		{
			new SqlParameter("@RolePartActivityID", rolePartActivity.RolePartActivityID)
		};
		return (SqlDBHelper.ExecuteScalar("RolePartActivity_Exists", CommandType.StoredProcedure, parametersRolePartActivity)>0);
	}

	public List<RolePartActivity> SearchLike(RolePartActivity rolePartActivity)
	{
		List<RolePartActivity> listRolePartActivity = new List<RolePartActivity>();


		SqlParameter[] parametersRolePartActivity = new SqlParameter[]
		{
			new SqlParameter("@RolePartActivityID", rolePartActivity.RolePartActivityID),
			new SqlParameter("@ActivityTitle", rolePartActivity.ActivityTitle),
			new SqlParameter("@RolePartIDTitle", rolePartActivity.RolePartIDTitle),
			new SqlParameter("@RolePartID", rolePartActivity.RolePartID),
			new SqlParameter("@ActivityID", rolePartActivity.ActivityID),
			new SqlParameter("@Permission", rolePartActivity.Permission),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RolePartActivity_SearchLike", CommandType.StoredProcedure, parametersRolePartActivity))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					RolePartActivity tmpRolePartActivity = new RolePartActivity();
					tmpRolePartActivity.RolePartActivityID = (row["RolePartActivityID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartActivityID"]) : 0 ;
					tmpRolePartActivity.ActivityTitle = row["ActivityTitle"].ToString();
					tmpRolePartActivity.RolePartIDTitle = row["RolePartIDTitle"].ToString();
					tmpRolePartActivity.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
					tmpRolePartActivity.ActivityID = (row["ActivityID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityID"]) : 0 ;
					tmpRolePartActivity.Permission = (row["Permission"] != DBNull.Value) ? Convert.ToInt32(row["Permission"]) : 0 ;

					listRolePartActivity.Add(tmpRolePartActivity);
				}
			}
		}

		return listRolePartActivity;
	}

}
}
