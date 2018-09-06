using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class WillTypeDBAccess
{

	WillDBAccess willDBAccess = new WillDBAccess();

	public List<Will> GetListWill(int willTypeID)
	{
		List<Will> listWill = new List<Will>() { };
		SqlParameter[] parametersWillType = new SqlParameter[]
		{
			new SqlParameter("@WillTypeID", willTypeID)
		};

		//Lets get the list of Will records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Will_GetList_UseInWillType", CommandType.StoredProcedure, parametersWillType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of will
				listWill = new List<Will>();

				//Now lets populate the Will details into the list of wills
				foreach (DataRow row in table.Rows)
				{
					Will will = ConvertRowToWill(row);
					listWill.Add(will);
				}
			}
		}

		return listWill;
	}

	private Will ConvertRowToWill(DataRow row)
	{
		Will will = new Will();
		will.WillID = (row["WillID"] != DBNull.Value) ? Convert.ToInt64(row["WillID"]) : 0 ;
		will.WillTypeIDTitle = row["WillTypeIDTitle"].ToString();
		will.WillTypeID = (row["WillTypeID"] != DBNull.Value) ? Convert.ToInt32(row["WillTypeID"]) : 0 ;
		will.DeclerationID = (row["DeclerationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclerationID"]) : 0 ;
		will.WillDate = row["WillDate"].ToString();
		will.VoteDate = row["VoteDate"].ToString();
		will.WillNumber = row["WillNumber"].ToString();
		will.ScriptoriumNumber = row["ScriptoriumNumber"].ToString();
		will.VoteNumber = row["VoteNumber"].ToString();
		will.VoteBranchDescription = row["VoteBranchDescription"].ToString();
		will.City = row["City"].ToString();
		return will;
	}
	public Int64 Insert(WillType willType)
	{
		SqlParameter[] parametersWillType = new SqlParameter[]
		{
			new SqlParameter("@Title", willType.Title)
		};
		willType.WillTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("WillType_Insert", CommandType.StoredProcedure, parametersWillType));
		return willType.WillTypeID;
	}

	public bool Update(WillType willType)
	{
		SqlParameter[] parametersWillType = new SqlParameter[]
		{
			new SqlParameter("@WillTypeID", willType.WillTypeID),
			new SqlParameter("@Title", willType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("WillType_Update", CommandType.StoredProcedure, parametersWillType);
	}

	public bool Delete(int willTypeID)
	{
		SqlParameter[] parametersWillType = new SqlParameter[]
		{
			new SqlParameter("@WillTypeID", willTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("WillType_Delete", CommandType.StoredProcedure, parametersWillType);
	}

	public WillType GetDetails(int willTypeID)
	{
		WillType willType = new WillType();

		SqlParameter[] parametersWillType = new SqlParameter[]
		{
			new SqlParameter("@WillTypeID", willTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("WillType_GetDetails", CommandType.StoredProcedure, parametersWillType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				willType.WillTypeID = (row["WillTypeID"] != DBNull.Value) ? Convert.ToInt32(row["WillTypeID"]) : 0 ;
				willType.Title = row["Title"].ToString();
			}
		}

		return willType;
	}

	public List<WillType> GetListAll()
	{
		List<WillType> listWillType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("WillType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listWillType = new List<WillType>();

				foreach (DataRow row in table.Rows)
				{
					WillType willType = new WillType();
					willType.WillTypeID = (row["WillTypeID"] != DBNull.Value) ? Convert.ToInt32(row["WillTypeID"]) : 0 ;
					willType.Title = row["Title"].ToString();
					listWillType.Add(willType);
				}
			}
		}

		return listWillType;
	}

	public bool Exists(int willTypeID)
	{
		SqlParameter[] parametersWillType = new SqlParameter[]
		{
			new SqlParameter("@WillTypeID", willTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("WillType_Exists", CommandType.StoredProcedure, parametersWillType)>0);
	}

	public bool Exists(WillType willType)
	{
		SqlParameter[] parametersWillType = new SqlParameter[]
		{
			new SqlParameter("@WillTypeID", willType.WillTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("WillType_Exists", CommandType.StoredProcedure, parametersWillType)>0);
	}

	public List<WillType> SearchLike(WillType willType)
	{
		List<WillType> listWillType = new List<WillType>();


		SqlParameter[] parametersWillType = new SqlParameter[]
		{
			new SqlParameter("@WillTypeID", willType.WillTypeID),
			new SqlParameter("@Title", willType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("WillType_SearchLike", CommandType.StoredProcedure, parametersWillType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					WillType tmpWillType = new WillType();
					tmpWillType.WillTypeID = (row["WillTypeID"] != DBNull.Value) ? Convert.ToInt32(row["WillTypeID"]) : 0 ;
					tmpWillType.Title = row["Title"].ToString();

					listWillType.Add(tmpWillType);
				}
			}
		}

		return listWillType;
	}

}
}
