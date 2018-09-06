using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class DemandsDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(Demands demands)
	{
		if (!heritageDBAccess.Exists(demands))
			demands.HeritageID = heritageDBAccess.Insert(demands);

		SqlParameter[] parametersDemands = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (demands.HeritageID > 0) ? demands.HeritageID : (object)DBNull.Value),
			new SqlParameter("@DemandsTypeID", (demands.DemandsTypeID > 0) ? demands.DemandsTypeID : (object)DBNull.Value),
			new SqlParameter("@DemandDocumentID", (demands.DemandDocumentID > 0) ? demands.DemandDocumentID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (demands.DeclarationID > 0) ? demands.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@ProductionUnitID", (demands.ProductionUnitID > 0) ? demands.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@DebtorName", demands.DebtorName),
			new SqlParameter("@DocumentNumber", demands.DocumentNumber)
		};
		return SqlDBHelper.ExecuteScalar("Demands_Insert", CommandType.StoredProcedure, parametersDemands);
	}

	public bool Update(Demands demands)
	{
		heritageDBAccess.Update(demands);

		SqlParameter[] parametersDemands = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", demands.HeritageID),
			new SqlParameter("@DemandsTypeID", (demands.DemandsTypeID != null && demands.DemandsTypeID >0 ) ? demands.DemandsTypeID : (object)DBNull.Value),
			new SqlParameter("@DemandDocumentID", (demands.DemandDocumentID != null && demands.DemandDocumentID >0 ) ? demands.DemandDocumentID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", demands.DeclarationID),
			new SqlParameter("@ProductionUnitID", (demands.ProductionUnitID != null && demands.ProductionUnitID >0 ) ? demands.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@DebtorName", demands.DebtorName),
			new SqlParameter("@DocumentNumber", demands.DocumentNumber)
		};
		return SqlDBHelper.ExecuteNonQuery("Demands_Update", CommandType.StoredProcedure, parametersDemands);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersDemands = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("Demands_Delete", CommandType.StoredProcedure, parametersDemands);
	}

	public Demands GetDetails(Int64 heritageID)
	{
		Demands demands = new Demands();

		SqlParameter[] parametersDemands = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Demands_GetDetails", CommandType.StoredProcedure, parametersDemands))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				demands.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				demands.DemandDocumentIDTitle = row["DemandDocumentIDTitle"].ToString();
				demands.DemandsTypeIDTitle = row["DemandsTypeIDTitle"].ToString();
				demands.DemandsTypeID = (row["DemandsTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DemandsTypeID"]) : 0 ;
				demands.DemandDocumentID = (row["DemandDocumentID"] != DBNull.Value) ? Convert.ToInt32(row["DemandDocumentID"]) : 0 ;
				demands.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				demands.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
				demands.DebtorName = row["DebtorName"].ToString();
				demands.DocumentNumber = row["DocumentNumber"].ToString();

				Heritage heritage = heritageDBAccess.GetDetails(demands.HeritageID);
				demands.HeritageID = heritage.HeritageID;
				demands.StageTitle = heritage.StageTitle;
				demands.RegisterDate = heritage.RegisterDate;
				demands.OldRegisterDate = heritage.OldRegisterDate;
				demands.OldRegisterInformationID = heritage.OldRegisterInformationID;
				demands.Sixth = heritage.Sixth;
				demands.PreviousOwner = heritage.PreviousOwner;
				demands.Comment = heritage.Comment;
				demands.RegisterInformationID = heritage.RegisterInformationID;
				demands.AdjustmentID = heritage.AdjustmentID;
				demands.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				demands.Stage = heritage.Stage;
				demands.UserOrder = heritage.UserOrder;
				demands.Value1 = heritage.Value1;
				demands.Value2 = heritage.Value2;
				demands.Value3 = heritage.Value3;
				demands.DeadIsOwner = heritage.DeadIsOwner;
				demands.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return demands;
	}

	public List<Demands> GetListAll()
	{
		List<Demands> listDemands = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Demands_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listDemands = new List<Demands>();

				foreach (DataRow row in table.Rows)
				{
					Demands demands = new Demands();
					demands.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					demands.DemandDocumentIDTitle = row["DemandDocumentIDTitle"].ToString();
					demands.DemandsTypeIDTitle = row["DemandsTypeIDTitle"].ToString();
					demands.DemandsTypeID = (row["DemandsTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DemandsTypeID"]) : 0 ;
					demands.DemandDocumentID = (row["DemandDocumentID"] != DBNull.Value) ? Convert.ToInt32(row["DemandDocumentID"]) : 0 ;
					demands.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					demands.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					demands.DebtorName = row["DebtorName"].ToString();
					demands.DocumentNumber = row["DocumentNumber"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(demands.HeritageID);
					demands.StageTitle = heritage.StageTitle;
					demands.RegisterDate = heritage.RegisterDate;
					demands.OldRegisterDate = heritage.OldRegisterDate;
					demands.OldRegisterInformationID = heritage.OldRegisterInformationID;
					demands.Sixth = heritage.Sixth;
					demands.PreviousOwner = heritage.PreviousOwner;
					demands.Comment = heritage.Comment;
					demands.RegisterInformationID = heritage.RegisterInformationID;
					demands.AdjustmentID = heritage.AdjustmentID;
					demands.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					demands.Stage = heritage.Stage;
					demands.UserOrder = heritage.UserOrder;
					demands.Value1 = heritage.Value1;
					demands.Value2 = heritage.Value2;
					demands.Value3 = heritage.Value3;
					demands.DeadIsOwner = heritage.DeadIsOwner;
					demands.IsDiagonesed = heritage.IsDiagonesed;
					listDemands.Add(demands);
				}
			}
		}

		return listDemands;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersDemands = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Demands_Exists", CommandType.StoredProcedure, parametersDemands)>0);
	}

	public bool Exists(Demands demands)
	{
		SqlParameter[] parametersDemands = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", demands.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Demands_Exists", CommandType.StoredProcedure, parametersDemands)>0);
	}

	public List<Demands> SearchLike(Demands demands)
	{
		List<Demands> listDemands = new List<Demands>();


		SqlParameter[] parametersDemands = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", demands.HeritageID),
			new SqlParameter("@DemandDocumentIDTitle", demands.DemandDocumentIDTitle),
			new SqlParameter("@DemandsTypeIDTitle", demands.DemandsTypeIDTitle),
			new SqlParameter("@DemandsTypeID", demands.DemandsTypeID),
			new SqlParameter("@DemandDocumentID", demands.DemandDocumentID),
			new SqlParameter("@DeclarationID", demands.DeclarationID),
			new SqlParameter("@ProductionUnitID", demands.ProductionUnitID),
			new SqlParameter("@DebtorName", demands.DebtorName),
			new SqlParameter("@DocumentNumber", demands.DocumentNumber),

			new SqlParameter("@StageTitle", demands.StageTitle),
			new SqlParameter("@RegisterDate", demands.RegisterDate),
			new SqlParameter("@OldRegisterDate", demands.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", demands.OldRegisterInformationID),
			new SqlParameter("@Sixth", demands.Sixth),
			new SqlParameter("@PreviousOwner", demands.PreviousOwner),
			new SqlParameter("@Comment", demands.Comment),
			new SqlParameter("@RegisterInformationID", demands.RegisterInformationID),
			new SqlParameter("@AdjustmentID", demands.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", demands.CommissionAdjustmentID),
			new SqlParameter("@Stage", demands.Stage),
			new SqlParameter("@UserOrder", demands.UserOrder),
			new SqlParameter("@Value1", demands.Value1),
			new SqlParameter("@Value2", demands.Value2),
			new SqlParameter("@Value3", demands.Value3),
			new SqlParameter("@DeadIsOwner", demands.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", demands.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Demands_SearchLike", CommandType.StoredProcedure, parametersDemands))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Demands tmpDemands = new Demands();
					tmpDemands.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpDemands.DemandDocumentIDTitle = row["DemandDocumentIDTitle"].ToString();
					tmpDemands.DemandsTypeIDTitle = row["DemandsTypeIDTitle"].ToString();
					tmpDemands.DemandsTypeID = (row["DemandsTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DemandsTypeID"]) : 0 ;
					tmpDemands.DemandDocumentID = (row["DemandDocumentID"] != DBNull.Value) ? Convert.ToInt32(row["DemandDocumentID"]) : 0 ;
					tmpDemands.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpDemands.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					tmpDemands.DebtorName = row["DebtorName"].ToString();
					tmpDemands.DocumentNumber = row["DocumentNumber"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(tmpDemands.HeritageID);
					tmpDemands.HeritageID = heritage.HeritageID;
					tmpDemands.StageTitle = heritage.StageTitle;
					tmpDemands.RegisterDate = heritage.RegisterDate;
					tmpDemands.OldRegisterDate = heritage.OldRegisterDate;
					tmpDemands.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpDemands.Sixth = heritage.Sixth;
					tmpDemands.PreviousOwner = heritage.PreviousOwner;
					tmpDemands.Comment = heritage.Comment;
					tmpDemands.RegisterInformationID = heritage.RegisterInformationID;
					tmpDemands.AdjustmentID = heritage.AdjustmentID;
					tmpDemands.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpDemands.Stage = heritage.Stage;
					tmpDemands.UserOrder = heritage.UserOrder;
					tmpDemands.Value1 = heritage.Value1;
					tmpDemands.Value2 = heritage.Value2;
					tmpDemands.Value3 = heritage.Value3;
					tmpDemands.DeadIsOwner = heritage.DeadIsOwner;
					tmpDemands.IsDiagonesed = heritage.IsDiagonesed;

					listDemands.Add(tmpDemands);
				}
			}
		}

		return listDemands;
	}

}
}
