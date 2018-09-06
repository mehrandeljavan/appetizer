using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class CostDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(Cost cost)
	{
		if (!heritageDBAccess.Exists(cost))
			cost.HeritageID = heritageDBAccess.Insert(cost);

		SqlParameter[] parametersCost = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (cost.HeritageID > 0) ? cost.HeritageID : (object)DBNull.Value),
			new SqlParameter("@CostTitle", (cost.CostTitle != null) ? cost.CostTitle : (object)DBNull.Value),
			new SqlParameter("@CostTypeID", (cost.CostTypeID > 0) ? cost.CostTypeID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (cost.DeclarationID > 0) ? cost.DeclarationID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("Cost_Insert", CommandType.StoredProcedure, parametersCost);
	}

	public bool Update(Cost cost)
	{
		heritageDBAccess.Update(cost);

		SqlParameter[] parametersCost = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", cost.HeritageID),
			new SqlParameter("@CostTitle", (cost.CostTitle != null) ? cost.CostTitle : (object)DBNull.Value),
			new SqlParameter("@CostTypeID", (cost.CostTypeID != null && cost.CostTypeID >0 ) ? cost.CostTypeID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", cost.DeclarationID)
		};
		return SqlDBHelper.ExecuteNonQuery("Cost_Update", CommandType.StoredProcedure, parametersCost);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersCost = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("Cost_Delete", CommandType.StoredProcedure, parametersCost);
	}

	public Cost GetDetails(Int64 heritageID)
	{
		Cost cost = new Cost();

		SqlParameter[] parametersCost = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Cost_GetDetails", CommandType.StoredProcedure, parametersCost))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				cost.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				cost.CostTypeIDTitle = row["CostTypeIDTitle"].ToString();
				cost.CostTitle = row["CostTitle"].ToString();
				cost.CostTypeID = (row["CostTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CostTypeID"]) : 0 ;
				cost.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

				Heritage heritage = heritageDBAccess.GetDetails(cost.HeritageID);
				cost.HeritageID = heritage.HeritageID;
				cost.StageTitle = heritage.StageTitle;
				cost.RegisterDate = heritage.RegisterDate;
				cost.OldRegisterDate = heritage.OldRegisterDate;
				cost.OldRegisterInformationID = heritage.OldRegisterInformationID;
				cost.Sixth = heritage.Sixth;
				cost.PreviousOwner = heritage.PreviousOwner;
				cost.Comment = heritage.Comment;
				cost.RegisterInformationID = heritage.RegisterInformationID;
				cost.AdjustmentID = heritage.AdjustmentID;
				cost.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				cost.Stage = heritage.Stage;
				cost.UserOrder = heritage.UserOrder;
				cost.Value1 = heritage.Value1;
				cost.Value2 = heritage.Value2;
				cost.Value3 = heritage.Value3;
				cost.DeadIsOwner = heritage.DeadIsOwner;
				cost.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return cost;
	}

	public List<Cost> GetListAll()
	{
		List<Cost> listCost = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Cost_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listCost = new List<Cost>();

				foreach (DataRow row in table.Rows)
				{
					Cost cost = new Cost();
					cost.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					cost.CostTypeIDTitle = row["CostTypeIDTitle"].ToString();
					cost.CostTitle = row["CostTitle"].ToString();
					cost.CostTypeID = (row["CostTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CostTypeID"]) : 0 ;
					cost.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(cost.HeritageID);
					cost.StageTitle = heritage.StageTitle;
					cost.RegisterDate = heritage.RegisterDate;
					cost.OldRegisterDate = heritage.OldRegisterDate;
					cost.OldRegisterInformationID = heritage.OldRegisterInformationID;
					cost.Sixth = heritage.Sixth;
					cost.PreviousOwner = heritage.PreviousOwner;
					cost.Comment = heritage.Comment;
					cost.RegisterInformationID = heritage.RegisterInformationID;
					cost.AdjustmentID = heritage.AdjustmentID;
					cost.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					cost.Stage = heritage.Stage;
					cost.UserOrder = heritage.UserOrder;
					cost.Value1 = heritage.Value1;
					cost.Value2 = heritage.Value2;
					cost.Value3 = heritage.Value3;
					cost.DeadIsOwner = heritage.DeadIsOwner;
					cost.IsDiagonesed = heritage.IsDiagonesed;
					listCost.Add(cost);
				}
			}
		}

		return listCost;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersCost = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Cost_Exists", CommandType.StoredProcedure, parametersCost)>0);
	}

	public bool Exists(Cost cost)
	{
		SqlParameter[] parametersCost = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", cost.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Cost_Exists", CommandType.StoredProcedure, parametersCost)>0);
	}

	public List<Cost> SearchLike(Cost cost)
	{
		List<Cost> listCost = new List<Cost>();


		SqlParameter[] parametersCost = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", cost.HeritageID),
			new SqlParameter("@CostTypeIDTitle", cost.CostTypeIDTitle),
			new SqlParameter("@CostTitle", cost.CostTitle),
			new SqlParameter("@CostTypeID", cost.CostTypeID),
			new SqlParameter("@DeclarationID", cost.DeclarationID),

			new SqlParameter("@StageTitle", cost.StageTitle),
			new SqlParameter("@RegisterDate", cost.RegisterDate),
			new SqlParameter("@OldRegisterDate", cost.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", cost.OldRegisterInformationID),
			new SqlParameter("@Sixth", cost.Sixth),
			new SqlParameter("@PreviousOwner", cost.PreviousOwner),
			new SqlParameter("@Comment", cost.Comment),
			new SqlParameter("@RegisterInformationID", cost.RegisterInformationID),
			new SqlParameter("@AdjustmentID", cost.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", cost.CommissionAdjustmentID),
			new SqlParameter("@Stage", cost.Stage),
			new SqlParameter("@UserOrder", cost.UserOrder),
			new SqlParameter("@Value1", cost.Value1),
			new SqlParameter("@Value2", cost.Value2),
			new SqlParameter("@Value3", cost.Value3),
			new SqlParameter("@DeadIsOwner", cost.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", cost.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Cost_SearchLike", CommandType.StoredProcedure, parametersCost))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Cost tmpCost = new Cost();
					tmpCost.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpCost.CostTypeIDTitle = row["CostTypeIDTitle"].ToString();
					tmpCost.CostTitle = row["CostTitle"].ToString();
					tmpCost.CostTypeID = (row["CostTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CostTypeID"]) : 0 ;
					tmpCost.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(tmpCost.HeritageID);
					tmpCost.HeritageID = heritage.HeritageID;
					tmpCost.StageTitle = heritage.StageTitle;
					tmpCost.RegisterDate = heritage.RegisterDate;
					tmpCost.OldRegisterDate = heritage.OldRegisterDate;
					tmpCost.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpCost.Sixth = heritage.Sixth;
					tmpCost.PreviousOwner = heritage.PreviousOwner;
					tmpCost.Comment = heritage.Comment;
					tmpCost.RegisterInformationID = heritage.RegisterInformationID;
					tmpCost.AdjustmentID = heritage.AdjustmentID;
					tmpCost.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpCost.Stage = heritage.Stage;
					tmpCost.UserOrder = heritage.UserOrder;
					tmpCost.Value1 = heritage.Value1;
					tmpCost.Value2 = heritage.Value2;
					tmpCost.Value3 = heritage.Value3;
					tmpCost.DeadIsOwner = heritage.DeadIsOwner;
					tmpCost.IsDiagonesed = heritage.IsDiagonesed;

					listCost.Add(tmpCost);
				}
			}
		}

		return listCost;
	}

}
}
