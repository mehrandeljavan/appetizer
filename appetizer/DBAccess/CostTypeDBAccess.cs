using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class CostTypeDBAccess
{

	CostDBAccess costDBAccess = new CostDBAccess();

	public List<Cost> GetListCost(int costTypeID)
	{
		List<Cost> listCost = new List<Cost>() { };
		SqlParameter[] parametersCostType = new SqlParameter[]
		{
			new SqlParameter("@CostTypeID", costTypeID)
		};

		//Lets get the list of Cost records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Cost_GetList_UseInCostType", CommandType.StoredProcedure, parametersCostType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of cost
				listCost = new List<Cost>();

				//Now lets populate the Cost details into the list of costs
				foreach (DataRow row in table.Rows)
				{
					Cost cost = ConvertRowToCost(row);
					listCost.Add(cost);
				}
			}
		}

		return listCost;
	}

	private Cost ConvertRowToCost(DataRow row)
	{
		Cost cost = new Cost();
		cost.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		cost.CostTypeIDTitle = row["CostTypeIDTitle"].ToString();
		cost.CostTitle = row["CostTitle"].ToString();
		cost.CostTypeID = (row["CostTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CostTypeID"]) : 0 ;
		cost.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

		cost.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		cost.StageTitle = row["StageTitle"].ToString();
		cost.RegisterDate = row["RegisterDate"].ToString();
		cost.OldRegisterDate = row["OldRegisterDate"].ToString();
		cost.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		cost.Sixth = row["Sixth"].ToString();
		cost.PreviousOwner = row["PreviousOwner"].ToString();
		cost.Comment = row["Comment"].ToString();
		cost.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		cost.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		cost.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		cost.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		cost.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		cost.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		cost.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		cost.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		cost.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		cost.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return cost;
	}
	public Int64 Insert(CostType costType)
	{
		SqlParameter[] parametersCostType = new SqlParameter[]
		{
			new SqlParameter("@Title", (costType.Title != null) ? costType.Title : (object)DBNull.Value)
		};
		costType.CostTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("CostType_Insert", CommandType.StoredProcedure, parametersCostType));
		return costType.CostTypeID;
	}

	public bool Update(CostType costType)
	{
		SqlParameter[] parametersCostType = new SqlParameter[]
		{
			new SqlParameter("@CostTypeID", costType.CostTypeID),
			new SqlParameter("@Title", (costType.Title != null) ? costType.Title : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("CostType_Update", CommandType.StoredProcedure, parametersCostType);
	}

	public bool Delete(int costTypeID)
	{
		SqlParameter[] parametersCostType = new SqlParameter[]
		{
			new SqlParameter("@CostTypeID", costTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("CostType_Delete", CommandType.StoredProcedure, parametersCostType);
	}

	public CostType GetDetails(int costTypeID)
	{
		CostType costType = new CostType();

		SqlParameter[] parametersCostType = new SqlParameter[]
		{
			new SqlParameter("@CostTypeID", costTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CostType_GetDetails", CommandType.StoredProcedure, parametersCostType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				costType.CostTypeID = (row["CostTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CostTypeID"]) : 0 ;
				costType.Title = row["Title"].ToString();
			}
		}

		return costType;
	}

	public List<CostType> GetListAll()
	{
		List<CostType> listCostType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("CostType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listCostType = new List<CostType>();

				foreach (DataRow row in table.Rows)
				{
					CostType costType = new CostType();
					costType.CostTypeID = (row["CostTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CostTypeID"]) : 0 ;
					costType.Title = row["Title"].ToString();
					listCostType.Add(costType);
				}
			}
		}

		return listCostType;
	}

	public bool Exists(int costTypeID)
	{
		SqlParameter[] parametersCostType = new SqlParameter[]
		{
			new SqlParameter("@CostTypeID", costTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("CostType_Exists", CommandType.StoredProcedure, parametersCostType)>0);
	}

	public bool Exists(CostType costType)
	{
		SqlParameter[] parametersCostType = new SqlParameter[]
		{
			new SqlParameter("@CostTypeID", costType.CostTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("CostType_Exists", CommandType.StoredProcedure, parametersCostType)>0);
	}

	public List<CostType> SearchLike(CostType costType)
	{
		List<CostType> listCostType = new List<CostType>();


		SqlParameter[] parametersCostType = new SqlParameter[]
		{
			new SqlParameter("@CostTypeID", costType.CostTypeID),
			new SqlParameter("@Title", costType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CostType_SearchLike", CommandType.StoredProcedure, parametersCostType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					CostType tmpCostType = new CostType();
					tmpCostType.CostTypeID = (row["CostTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CostTypeID"]) : 0 ;
					tmpCostType.Title = row["Title"].ToString();

					listCostType.Add(tmpCostType);
				}
			}
		}

		return listCostType;
	}

}
}
