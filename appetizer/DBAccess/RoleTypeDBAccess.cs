using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class RoleTypeDBAccess
{

	RolePartDBAccess rolePartDBAccess = new RolePartDBAccess();

	public List<RolePart> GetListRolePart(int roleTypeID)
	{
		List<RolePart> listRolePart = new List<RolePart>() { };
		SqlParameter[] parametersRoleType = new SqlParameter[]
		{
			new SqlParameter("@RoleTypeID", roleTypeID)
		};

		//Lets get the list of RolePart records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RolePart_GetList_UseInRoleType", CommandType.StoredProcedure, parametersRoleType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of rolePart
				listRolePart = new List<RolePart>();

				//Now lets populate the RolePart details into the list of roleParts
				foreach (DataRow row in table.Rows)
				{
					RolePart rolePart = ConvertRowToRolePart(row);
					listRolePart.Add(rolePart);
				}
			}
		}

		return listRolePart;
	}

	private RolePart ConvertRowToRolePart(DataRow row)
	{
		RolePart rolePart = new RolePart();
		rolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
		rolePart.Title = row["Title"].ToString();
		rolePart.PartTypeIDTitle = row["PartTypeIDTitle"].ToString();
		rolePart.RoleTypeIDTitle = row["RoleTypeIDTitle"].ToString();
		rolePart.RoleTypeID = (row["RoleTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RoleTypeID"]) : 0 ;
		rolePart.PartTypeID = (row["PartTypeID"] != DBNull.Value) ? Convert.ToInt32(row["PartTypeID"]) : 0 ;
		return rolePart;
	}
	public Int64 Insert(RoleType roleType)
	{
		SqlParameter[] parametersRoleType = new SqlParameter[]
		{
			new SqlParameter("@Title", roleType.Title)
		};
		roleType.RoleTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("RoleType_Insert", CommandType.StoredProcedure, parametersRoleType));
		return roleType.RoleTypeID;
	}

	public bool Update(RoleType roleType)
	{
		SqlParameter[] parametersRoleType = new SqlParameter[]
		{
			new SqlParameter("@RoleTypeID", roleType.RoleTypeID),
			new SqlParameter("@Title", roleType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("RoleType_Update", CommandType.StoredProcedure, parametersRoleType);
	}

	public bool Delete(int roleTypeID)
	{
		SqlParameter[] parametersRoleType = new SqlParameter[]
		{
			new SqlParameter("@RoleTypeID", roleTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("RoleType_Delete", CommandType.StoredProcedure, parametersRoleType);
	}

	public RoleType GetDetails(int roleTypeID)
	{
		RoleType roleType = new RoleType();

		SqlParameter[] parametersRoleType = new SqlParameter[]
		{
			new SqlParameter("@RoleTypeID", roleTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RoleType_GetDetails", CommandType.StoredProcedure, parametersRoleType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				roleType.RoleTypeID = (row["RoleTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RoleTypeID"]) : 0 ;
				roleType.Title = row["Title"].ToString();
			}
		}

		return roleType;
	}

	public List<RoleType> GetListAll()
	{
		List<RoleType> listRoleType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("RoleType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listRoleType = new List<RoleType>();

				foreach (DataRow row in table.Rows)
				{
					RoleType roleType = new RoleType();
					roleType.RoleTypeID = (row["RoleTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RoleTypeID"]) : 0 ;
					roleType.Title = row["Title"].ToString();
					listRoleType.Add(roleType);
				}
			}
		}

		return listRoleType;
	}

	public bool Exists(int roleTypeID)
	{
		SqlParameter[] parametersRoleType = new SqlParameter[]
		{
			new SqlParameter("@RoleTypeID", roleTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("RoleType_Exists", CommandType.StoredProcedure, parametersRoleType)>0);
	}

	public bool Exists(RoleType roleType)
	{
		SqlParameter[] parametersRoleType = new SqlParameter[]
		{
			new SqlParameter("@RoleTypeID", roleType.RoleTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("RoleType_Exists", CommandType.StoredProcedure, parametersRoleType)>0);
	}

	public List<RoleType> SearchLike(RoleType roleType)
	{
		List<RoleType> listRoleType = new List<RoleType>();


		SqlParameter[] parametersRoleType = new SqlParameter[]
		{
			new SqlParameter("@RoleTypeID", roleType.RoleTypeID),
			new SqlParameter("@Title", roleType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RoleType_SearchLike", CommandType.StoredProcedure, parametersRoleType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					RoleType tmpRoleType = new RoleType();
					tmpRoleType.RoleTypeID = (row["RoleTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RoleTypeID"]) : 0 ;
					tmpRoleType.Title = row["Title"].ToString();

					listRoleType.Add(tmpRoleType);
				}
			}
		}

		return listRoleType;
	}

}
}
