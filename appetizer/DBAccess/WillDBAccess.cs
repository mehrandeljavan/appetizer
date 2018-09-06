using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class WillDBAccess
{


	public Int64 Insert(Will will)
	{
		SqlParameter[] parametersWill = new SqlParameter[]
		{
			new SqlParameter("@WillTypeID", (will.WillTypeID > 0) ? will.WillTypeID : (object)DBNull.Value),
			new SqlParameter("@DeclerationID", (will.DeclerationID > 0) ? will.DeclerationID : (object)DBNull.Value),
			new SqlParameter("@WillDate", (will.WillDate != null) ? will.WillDate : (object)DBNull.Value),
			new SqlParameter("@VoteDate", (will.VoteDate != null) ? will.VoteDate : (object)DBNull.Value),
			new SqlParameter("@WillNumber", (will.WillNumber != null) ? will.WillNumber : (object)DBNull.Value),
			new SqlParameter("@ScriptoriumNumber", (will.ScriptoriumNumber != null) ? will.ScriptoriumNumber : (object)DBNull.Value),
			new SqlParameter("@VoteNumber", (will.VoteNumber != null) ? will.VoteNumber : (object)DBNull.Value),
			new SqlParameter("@VoteBranchDescription", (will.VoteBranchDescription != null) ? will.VoteBranchDescription : (object)DBNull.Value),
			new SqlParameter("@City", (will.City != null) ? will.City : (object)DBNull.Value)
		};
		will.WillID = SqlDBHelper.ExecuteScalar("Will_Insert", CommandType.StoredProcedure, parametersWill);
		return will.WillID;
	}

	public bool Update(Will will)
	{
		SqlParameter[] parametersWill = new SqlParameter[]
		{
			new SqlParameter("@WillID", will.WillID),
			new SqlParameter("@WillTypeID", will.WillTypeID),
			new SqlParameter("@DeclerationID", (will.DeclerationID != null && will.DeclerationID >0 ) ? will.DeclerationID : (object)DBNull.Value),
			new SqlParameter("@WillDate", (will.WillDate != null) ? will.WillDate : (object)DBNull.Value),
			new SqlParameter("@VoteDate", (will.VoteDate != null) ? will.VoteDate : (object)DBNull.Value),
			new SqlParameter("@WillNumber", (will.WillNumber != null) ? will.WillNumber : (object)DBNull.Value),
			new SqlParameter("@ScriptoriumNumber", (will.ScriptoriumNumber != null) ? will.ScriptoriumNumber : (object)DBNull.Value),
			new SqlParameter("@VoteNumber", (will.VoteNumber != null) ? will.VoteNumber : (object)DBNull.Value),
			new SqlParameter("@VoteBranchDescription", (will.VoteBranchDescription != null) ? will.VoteBranchDescription : (object)DBNull.Value),
			new SqlParameter("@City", (will.City != null) ? will.City : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Will_Update", CommandType.StoredProcedure, parametersWill);
	}

	public bool Delete(Int64 willID)
	{
		SqlParameter[] parametersWill = new SqlParameter[]
		{
			new SqlParameter("@WillID", willID)
		};
		return SqlDBHelper.ExecuteNonQuery("Will_Delete", CommandType.StoredProcedure, parametersWill);
	}

	public Will GetDetails(Int64 willID)
	{
		Will will = new Will();

		SqlParameter[] parametersWill = new SqlParameter[]
		{
			new SqlParameter("@WillID", willID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Will_GetDetails", CommandType.StoredProcedure, parametersWill))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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
			}
		}

		return will;
	}

	public List<Will> GetListAll()
	{
		List<Will> listWill = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Will_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listWill = new List<Will>();

				foreach (DataRow row in table.Rows)
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
					listWill.Add(will);
				}
			}
		}

		return listWill;
	}

	public bool Exists(Int64 willID)
	{
		SqlParameter[] parametersWill = new SqlParameter[]
		{
			new SqlParameter("@WillID", willID)
		};
		return (SqlDBHelper.ExecuteScalar("Will_Exists", CommandType.StoredProcedure, parametersWill)>0);
	}

	public bool Exists(Will will)
	{
		SqlParameter[] parametersWill = new SqlParameter[]
		{
			new SqlParameter("@WillID", will.WillID)
		};
		return (SqlDBHelper.ExecuteScalar("Will_Exists", CommandType.StoredProcedure, parametersWill)>0);
	}

	public List<Will> SearchLike(Will will)
	{
		List<Will> listWill = new List<Will>();


		SqlParameter[] parametersWill = new SqlParameter[]
		{
			new SqlParameter("@WillID", will.WillID),
			new SqlParameter("@WillTypeIDTitle", will.WillTypeIDTitle),
			new SqlParameter("@WillTypeID", will.WillTypeID),
			new SqlParameter("@DeclerationID", will.DeclerationID),
			new SqlParameter("@WillDate", will.WillDate),
			new SqlParameter("@VoteDate", will.VoteDate),
			new SqlParameter("@WillNumber", will.WillNumber),
			new SqlParameter("@ScriptoriumNumber", will.ScriptoriumNumber),
			new SqlParameter("@VoteNumber", will.VoteNumber),
			new SqlParameter("@VoteBranchDescription", will.VoteBranchDescription),
			new SqlParameter("@City", will.City),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Will_SearchLike", CommandType.StoredProcedure, parametersWill))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Will tmpWill = new Will();
					tmpWill.WillID = (row["WillID"] != DBNull.Value) ? Convert.ToInt64(row["WillID"]) : 0 ;
					tmpWill.WillTypeIDTitle = row["WillTypeIDTitle"].ToString();
					tmpWill.WillTypeID = (row["WillTypeID"] != DBNull.Value) ? Convert.ToInt32(row["WillTypeID"]) : 0 ;
					tmpWill.DeclerationID = (row["DeclerationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclerationID"]) : 0 ;
					tmpWill.WillDate = row["WillDate"].ToString();
					tmpWill.VoteDate = row["VoteDate"].ToString();
					tmpWill.WillNumber = row["WillNumber"].ToString();
					tmpWill.ScriptoriumNumber = row["ScriptoriumNumber"].ToString();
					tmpWill.VoteNumber = row["VoteNumber"].ToString();
					tmpWill.VoteBranchDescription = row["VoteBranchDescription"].ToString();
					tmpWill.City = row["City"].ToString();

					listWill.Add(tmpWill);
				}
			}
		}

		return listWill;
	}

}
}
