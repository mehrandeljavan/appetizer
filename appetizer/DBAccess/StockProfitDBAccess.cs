using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class StockProfitDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(StockProfit stockProfit)
	{
		if (!heritageDBAccess.Exists(stockProfit))
			stockProfit.HeritageID = heritageDBAccess.Insert(stockProfit);

		SqlParameter[] parametersStockProfit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (stockProfit.HeritageID > 0) ? stockProfit.HeritageID : (object)DBNull.Value),
			new SqlParameter("@Branch", (stockProfit.Branch != null) ? stockProfit.Branch : (object)DBNull.Value),
			new SqlParameter("@BranchCity", (stockProfit.BranchCity != null) ? stockProfit.BranchCity : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (stockProfit.DeclarationID > 0) ? stockProfit.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@CompanyTypeID", (stockProfit.CompanyTypeID > 0) ? stockProfit.CompanyTypeID : (object)DBNull.Value),
			new SqlParameter("@CompanyName", stockProfit.CompanyName),
			new SqlParameter("@CompanyRegisterNumber", stockProfit.CompanyRegisterNumber)
		};
		return SqlDBHelper.ExecuteScalar("StockProfit_Insert", CommandType.StoredProcedure, parametersStockProfit);
	}

	public bool Update(StockProfit stockProfit)
	{
		heritageDBAccess.Update(stockProfit);

		SqlParameter[] parametersStockProfit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", stockProfit.HeritageID),
			new SqlParameter("@Branch", (stockProfit.Branch != null) ? stockProfit.Branch : (object)DBNull.Value),
			new SqlParameter("@BranchCity", (stockProfit.BranchCity != null) ? stockProfit.BranchCity : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", stockProfit.DeclarationID),
			new SqlParameter("@CompanyTypeID", stockProfit.CompanyTypeID),
			new SqlParameter("@CompanyName", stockProfit.CompanyName),
			new SqlParameter("@CompanyRegisterNumber", stockProfit.CompanyRegisterNumber)
		};
		return SqlDBHelper.ExecuteNonQuery("StockProfit_Update", CommandType.StoredProcedure, parametersStockProfit);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersStockProfit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("StockProfit_Delete", CommandType.StoredProcedure, parametersStockProfit);
	}

	public StockProfit GetDetails(Int64 heritageID)
	{
		StockProfit stockProfit = new StockProfit();

		SqlParameter[] parametersStockProfit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("StockProfit_GetDetails", CommandType.StoredProcedure, parametersStockProfit))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				stockProfit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				stockProfit.CompanyTypeIDTitle = row["CompanyTypeIDTitle"].ToString();
				stockProfit.Branch = row["Branch"].ToString();
				stockProfit.BranchCity = row["BranchCity"].ToString();
				stockProfit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				stockProfit.CompanyTypeID = (row["CompanyTypeID"] != DBNull.Value) ? Convert.ToInt64(row["CompanyTypeID"]) : 0 ;
				stockProfit.CompanyName = row["CompanyName"].ToString();
				stockProfit.CompanyRegisterNumber = row["CompanyRegisterNumber"].ToString();

				Heritage heritage = heritageDBAccess.GetDetails(stockProfit.HeritageID);
				stockProfit.HeritageID = heritage.HeritageID;
				stockProfit.StageTitle = heritage.StageTitle;
				stockProfit.RegisterDate = heritage.RegisterDate;
				stockProfit.OldRegisterDate = heritage.OldRegisterDate;
				stockProfit.OldRegisterInformationID = heritage.OldRegisterInformationID;
				stockProfit.Sixth = heritage.Sixth;
				stockProfit.PreviousOwner = heritage.PreviousOwner;
				stockProfit.Comment = heritage.Comment;
				stockProfit.RegisterInformationID = heritage.RegisterInformationID;
				stockProfit.AdjustmentID = heritage.AdjustmentID;
				stockProfit.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				stockProfit.Stage = heritage.Stage;
				stockProfit.UserOrder = heritage.UserOrder;
				stockProfit.Value1 = heritage.Value1;
				stockProfit.Value2 = heritage.Value2;
				stockProfit.Value3 = heritage.Value3;
				stockProfit.DeadIsOwner = heritage.DeadIsOwner;
				stockProfit.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return stockProfit;
	}

	public List<StockProfit> GetListAll()
	{
		List<StockProfit> listStockProfit = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("StockProfit_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listStockProfit = new List<StockProfit>();

				foreach (DataRow row in table.Rows)
				{
					StockProfit stockProfit = new StockProfit();
					stockProfit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					stockProfit.CompanyTypeIDTitle = row["CompanyTypeIDTitle"].ToString();
					stockProfit.Branch = row["Branch"].ToString();
					stockProfit.BranchCity = row["BranchCity"].ToString();
					stockProfit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					stockProfit.CompanyTypeID = (row["CompanyTypeID"] != DBNull.Value) ? Convert.ToInt64(row["CompanyTypeID"]) : 0 ;
					stockProfit.CompanyName = row["CompanyName"].ToString();
					stockProfit.CompanyRegisterNumber = row["CompanyRegisterNumber"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(stockProfit.HeritageID);
					stockProfit.StageTitle = heritage.StageTitle;
					stockProfit.RegisterDate = heritage.RegisterDate;
					stockProfit.OldRegisterDate = heritage.OldRegisterDate;
					stockProfit.OldRegisterInformationID = heritage.OldRegisterInformationID;
					stockProfit.Sixth = heritage.Sixth;
					stockProfit.PreviousOwner = heritage.PreviousOwner;
					stockProfit.Comment = heritage.Comment;
					stockProfit.RegisterInformationID = heritage.RegisterInformationID;
					stockProfit.AdjustmentID = heritage.AdjustmentID;
					stockProfit.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					stockProfit.Stage = heritage.Stage;
					stockProfit.UserOrder = heritage.UserOrder;
					stockProfit.Value1 = heritage.Value1;
					stockProfit.Value2 = heritage.Value2;
					stockProfit.Value3 = heritage.Value3;
					stockProfit.DeadIsOwner = heritage.DeadIsOwner;
					stockProfit.IsDiagonesed = heritage.IsDiagonesed;
					listStockProfit.Add(stockProfit);
				}
			}
		}

		return listStockProfit;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersStockProfit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("StockProfit_Exists", CommandType.StoredProcedure, parametersStockProfit)>0);
	}

	public bool Exists(StockProfit stockProfit)
	{
		SqlParameter[] parametersStockProfit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", stockProfit.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("StockProfit_Exists", CommandType.StoredProcedure, parametersStockProfit)>0);
	}

	public List<StockProfit> SearchLike(StockProfit stockProfit)
	{
		List<StockProfit> listStockProfit = new List<StockProfit>();


		SqlParameter[] parametersStockProfit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", stockProfit.HeritageID),
			new SqlParameter("@CompanyTypeIDTitle", stockProfit.CompanyTypeIDTitle),
			new SqlParameter("@Branch", stockProfit.Branch),
			new SqlParameter("@BranchCity", stockProfit.BranchCity),
			new SqlParameter("@DeclarationID", stockProfit.DeclarationID),
			new SqlParameter("@CompanyTypeID", stockProfit.CompanyTypeID),
			new SqlParameter("@CompanyName", stockProfit.CompanyName),
			new SqlParameter("@CompanyRegisterNumber", stockProfit.CompanyRegisterNumber),

			new SqlParameter("@StageTitle", stockProfit.StageTitle),
			new SqlParameter("@RegisterDate", stockProfit.RegisterDate),
			new SqlParameter("@OldRegisterDate", stockProfit.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", stockProfit.OldRegisterInformationID),
			new SqlParameter("@Sixth", stockProfit.Sixth),
			new SqlParameter("@PreviousOwner", stockProfit.PreviousOwner),
			new SqlParameter("@Comment", stockProfit.Comment),
			new SqlParameter("@RegisterInformationID", stockProfit.RegisterInformationID),
			new SqlParameter("@AdjustmentID", stockProfit.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", stockProfit.CommissionAdjustmentID),
			new SqlParameter("@Stage", stockProfit.Stage),
			new SqlParameter("@UserOrder", stockProfit.UserOrder),
			new SqlParameter("@Value1", stockProfit.Value1),
			new SqlParameter("@Value2", stockProfit.Value2),
			new SqlParameter("@Value3", stockProfit.Value3),
			new SqlParameter("@DeadIsOwner", stockProfit.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", stockProfit.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("StockProfit_SearchLike", CommandType.StoredProcedure, parametersStockProfit))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					StockProfit tmpStockProfit = new StockProfit();
					tmpStockProfit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpStockProfit.CompanyTypeIDTitle = row["CompanyTypeIDTitle"].ToString();
					tmpStockProfit.Branch = row["Branch"].ToString();
					tmpStockProfit.BranchCity = row["BranchCity"].ToString();
					tmpStockProfit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpStockProfit.CompanyTypeID = (row["CompanyTypeID"] != DBNull.Value) ? Convert.ToInt64(row["CompanyTypeID"]) : 0 ;
					tmpStockProfit.CompanyName = row["CompanyName"].ToString();
					tmpStockProfit.CompanyRegisterNumber = row["CompanyRegisterNumber"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(tmpStockProfit.HeritageID);
					tmpStockProfit.HeritageID = heritage.HeritageID;
					tmpStockProfit.StageTitle = heritage.StageTitle;
					tmpStockProfit.RegisterDate = heritage.RegisterDate;
					tmpStockProfit.OldRegisterDate = heritage.OldRegisterDate;
					tmpStockProfit.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpStockProfit.Sixth = heritage.Sixth;
					tmpStockProfit.PreviousOwner = heritage.PreviousOwner;
					tmpStockProfit.Comment = heritage.Comment;
					tmpStockProfit.RegisterInformationID = heritage.RegisterInformationID;
					tmpStockProfit.AdjustmentID = heritage.AdjustmentID;
					tmpStockProfit.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpStockProfit.Stage = heritage.Stage;
					tmpStockProfit.UserOrder = heritage.UserOrder;
					tmpStockProfit.Value1 = heritage.Value1;
					tmpStockProfit.Value2 = heritage.Value2;
					tmpStockProfit.Value3 = heritage.Value3;
					tmpStockProfit.DeadIsOwner = heritage.DeadIsOwner;
					tmpStockProfit.IsDiagonesed = heritage.IsDiagonesed;

					listStockProfit.Add(tmpStockProfit);
				}
			}
		}

		return listStockProfit;
	}

}
}
