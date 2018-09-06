using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class PartTypeDBAccess
{

	RolePartDBAccess rolePartDBAccess = new RolePartDBAccess();

	public List<RolePart> GetListRolePart(int partTypeID)
	{
		List<RolePart> listRolePart = new List<RolePart>() { };
		SqlParameter[] parametersPartType = new SqlParameter[]
		{
			new SqlParameter("@PartTypeID", partTypeID)
		};

		//Lets get the list of RolePart records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RolePart_GetList_UseInPartType", CommandType.StoredProcedure, parametersPartType))
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
	public Int64 Insert(PartType partType)
	{
		SqlParameter[] parametersPartType = new SqlParameter[]
		{
			new SqlParameter("@Title", partType.Title)
		};
		partType.PartTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("PartType_Insert", CommandType.StoredProcedure, parametersPartType));
		return partType.PartTypeID;
	}

	public bool Update(PartType partType)
	{
		SqlParameter[] parametersPartType = new SqlParameter[]
		{
			new SqlParameter("@PartTypeID", partType.PartTypeID),
			new SqlParameter("@Title", partType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("PartType_Update", CommandType.StoredProcedure, parametersPartType);
	}

	public bool Delete(int partTypeID)
	{
		SqlParameter[] parametersPartType = new SqlParameter[]
		{
			new SqlParameter("@PartTypeID", partTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("PartType_Delete", CommandType.StoredProcedure, parametersPartType);
	}

	public PartType GetDetails(int partTypeID)
	{
		PartType partType = new PartType();

		SqlParameter[] parametersPartType = new SqlParameter[]
		{
			new SqlParameter("@PartTypeID", partTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("PartType_GetDetails", CommandType.StoredProcedure, parametersPartType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				partType.PartTypeID = (row["PartTypeID"] != DBNull.Value) ? Convert.ToInt32(row["PartTypeID"]) : 0 ;
				partType.Title = row["Title"].ToString();
			}
		}

		return partType;
	}

	public List<PartType> GetListAll()
	{
		List<PartType> listPartType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("PartType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listPartType = new List<PartType>();

				foreach (DataRow row in table.Rows)
				{
					PartType partType = new PartType();
					partType.PartTypeID = (row["PartTypeID"] != DBNull.Value) ? Convert.ToInt32(row["PartTypeID"]) : 0 ;
					partType.Title = row["Title"].ToString();
					listPartType.Add(partType);
				}
			}
		}

		return listPartType;
	}

	public bool Exists(int partTypeID)
	{
		SqlParameter[] parametersPartType = new SqlParameter[]
		{
			new SqlParameter("@PartTypeID", partTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("PartType_Exists", CommandType.StoredProcedure, parametersPartType)>0);
	}

	public bool Exists(PartType partType)
	{
		SqlParameter[] parametersPartType = new SqlParameter[]
		{
			new SqlParameter("@PartTypeID", partType.PartTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("PartType_Exists", CommandType.StoredProcedure, parametersPartType)>0);
	}

	public List<PartType> SearchLike(PartType partType)
	{
		List<PartType> listPartType = new List<PartType>();


		SqlParameter[] parametersPartType = new SqlParameter[]
		{
			new SqlParameter("@PartTypeID", partType.PartTypeID),
			new SqlParameter("@Title", partType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("PartType_SearchLike", CommandType.StoredProcedure, parametersPartType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					PartType tmpPartType = new PartType();
					tmpPartType.PartTypeID = (row["PartTypeID"] != DBNull.Value) ? Convert.ToInt32(row["PartTypeID"]) : 0 ;
					tmpPartType.Title = row["Title"].ToString();

					listPartType.Add(tmpPartType);
				}
			}
		}

		return listPartType;
	}

}
}
