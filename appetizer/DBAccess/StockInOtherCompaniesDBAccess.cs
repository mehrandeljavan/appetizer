using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class StockInOtherCompaniesDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(StockInOtherCompanies stockInOtherCompanies)
	{
		if (!heritageDBAccess.Exists(stockInOtherCompanies))
			stockInOtherCompanies.HeritageID = heritageDBAccess.Insert(stockInOtherCompanies);

		SqlParameter[] parametersStockInOtherCompanies = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (stockInOtherCompanies.HeritageID > 0) ? stockInOtherCompanies.HeritageID : (object)DBNull.Value),
			new SqlParameter("@InquiryTo", (stockInOtherCompanies.InquiryTo != null) ? stockInOtherCompanies.InquiryTo : (object)DBNull.Value),
			new SqlParameter("@StockNumber", (stockInOtherCompanies.StockNumber != null) ? stockInOtherCompanies.StockNumber : (object)DBNull.Value),
			new SqlParameter("@StockPercent", (stockInOtherCompanies.StockPercent != null) ? stockInOtherCompanies.StockPercent : (object)DBNull.Value),
			new SqlParameter("@TotalStockValue", stockInOtherCompanies.TotalStockValue),
			new SqlParameter("@DeclarationID", (stockInOtherCompanies.DeclarationID > 0) ? stockInOtherCompanies.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@CompanyTypeID", (stockInOtherCompanies.CompanyTypeID > 0) ? stockInOtherCompanies.CompanyTypeID : (object)DBNull.Value),
			new SqlParameter("@CompanyName", stockInOtherCompanies.CompanyName),
			new SqlParameter("@CompanyRegisterNumber", stockInOtherCompanies.CompanyRegisterNumber)
		};
		return SqlDBHelper.ExecuteScalar("StockInOtherCompanies_Insert", CommandType.StoredProcedure, parametersStockInOtherCompanies);
	}

	public bool Update(StockInOtherCompanies stockInOtherCompanies)
	{
		heritageDBAccess.Update(stockInOtherCompanies);

		SqlParameter[] parametersStockInOtherCompanies = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", stockInOtherCompanies.HeritageID),
			new SqlParameter("@InquiryTo", (stockInOtherCompanies.InquiryTo != null) ? stockInOtherCompanies.InquiryTo : (object)DBNull.Value),
			new SqlParameter("@StockNumber", (stockInOtherCompanies.StockNumber != null) ? stockInOtherCompanies.StockNumber : (object)DBNull.Value),
			new SqlParameter("@StockPercent", (stockInOtherCompanies.StockPercent != null) ? stockInOtherCompanies.StockPercent : (object)DBNull.Value),
			new SqlParameter("@TotalStockValue", stockInOtherCompanies.TotalStockValue),
			new SqlParameter("@DeclarationID", stockInOtherCompanies.DeclarationID),
			new SqlParameter("@CompanyTypeID", (stockInOtherCompanies.CompanyTypeID != null && stockInOtherCompanies.CompanyTypeID >0 ) ? stockInOtherCompanies.CompanyTypeID : (object)DBNull.Value),
			new SqlParameter("@CompanyName", stockInOtherCompanies.CompanyName),
			new SqlParameter("@CompanyRegisterNumber", stockInOtherCompanies.CompanyRegisterNumber)
		};
		return SqlDBHelper.ExecuteNonQuery("StockInOtherCompanies_Update", CommandType.StoredProcedure, parametersStockInOtherCompanies);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersStockInOtherCompanies = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("StockInOtherCompanies_Delete", CommandType.StoredProcedure, parametersStockInOtherCompanies);
	}

	public StockInOtherCompanies GetDetails(Int64 heritageID)
	{
		StockInOtherCompanies stockInOtherCompanies = new StockInOtherCompanies();

		SqlParameter[] parametersStockInOtherCompanies = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("StockInOtherCompanies_GetDetails", CommandType.StoredProcedure, parametersStockInOtherCompanies))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				stockInOtherCompanies.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				stockInOtherCompanies.CompanyTypeIDTitle = row["CompanyTypeIDTitle"].ToString();
				stockInOtherCompanies.InquiryTo = row["InquiryTo"].ToString();
				stockInOtherCompanies.StockNumber = (row["StockNumber"] != DBNull.Value) ? Convert.ToInt32(row["StockNumber"]) : 0 ;
				stockInOtherCompanies.StockPercent = (row["StockPercent"] != DBNull.Value) ? Convert.ToInt32(row["StockPercent"]) : 0 ;
				stockInOtherCompanies.TotalStockValue = (row["TotalStockValue"] != DBNull.Value) ? Convert.ToSingle(row["TotalStockValue"]) : 0 ;
				stockInOtherCompanies.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				stockInOtherCompanies.CompanyTypeID = (row["CompanyTypeID"] != DBNull.Value) ? Convert.ToInt64(row["CompanyTypeID"]) : 0 ;
				stockInOtherCompanies.CompanyName = row["CompanyName"].ToString();
				stockInOtherCompanies.CompanyRegisterNumber = row["CompanyRegisterNumber"].ToString();

				Heritage heritage = heritageDBAccess.GetDetails(stockInOtherCompanies.HeritageID);
				stockInOtherCompanies.HeritageID = heritage.HeritageID;
				stockInOtherCompanies.StageTitle = heritage.StageTitle;
				stockInOtherCompanies.RegisterDate = heritage.RegisterDate;
				stockInOtherCompanies.OldRegisterDate = heritage.OldRegisterDate;
				stockInOtherCompanies.OldRegisterInformationID = heritage.OldRegisterInformationID;
				stockInOtherCompanies.Sixth = heritage.Sixth;
				stockInOtherCompanies.PreviousOwner = heritage.PreviousOwner;
				stockInOtherCompanies.Comment = heritage.Comment;
				stockInOtherCompanies.RegisterInformationID = heritage.RegisterInformationID;
				stockInOtherCompanies.AdjustmentID = heritage.AdjustmentID;
				stockInOtherCompanies.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				stockInOtherCompanies.Stage = heritage.Stage;
				stockInOtherCompanies.UserOrder = heritage.UserOrder;
				stockInOtherCompanies.Value1 = heritage.Value1;
				stockInOtherCompanies.Value2 = heritage.Value2;
				stockInOtherCompanies.Value3 = heritage.Value3;
				stockInOtherCompanies.DeadIsOwner = heritage.DeadIsOwner;
				stockInOtherCompanies.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return stockInOtherCompanies;
	}

	public List<StockInOtherCompanies> GetListAll()
	{
		List<StockInOtherCompanies> listStockInOtherCompanies = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("StockInOtherCompanies_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listStockInOtherCompanies = new List<StockInOtherCompanies>();

				foreach (DataRow row in table.Rows)
				{
					StockInOtherCompanies stockInOtherCompanies = new StockInOtherCompanies();
					stockInOtherCompanies.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					stockInOtherCompanies.CompanyTypeIDTitle = row["CompanyTypeIDTitle"].ToString();
					stockInOtherCompanies.InquiryTo = row["InquiryTo"].ToString();
					stockInOtherCompanies.StockNumber = (row["StockNumber"] != DBNull.Value) ? Convert.ToInt32(row["StockNumber"]) : 0 ;
					stockInOtherCompanies.StockPercent = (row["StockPercent"] != DBNull.Value) ? Convert.ToInt32(row["StockPercent"]) : 0 ;
					stockInOtherCompanies.TotalStockValue = (row["TotalStockValue"] != DBNull.Value) ? Convert.ToSingle(row["TotalStockValue"]) : 0 ;
					stockInOtherCompanies.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					stockInOtherCompanies.CompanyTypeID = (row["CompanyTypeID"] != DBNull.Value) ? Convert.ToInt64(row["CompanyTypeID"]) : 0 ;
					stockInOtherCompanies.CompanyName = row["CompanyName"].ToString();
					stockInOtherCompanies.CompanyRegisterNumber = row["CompanyRegisterNumber"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(stockInOtherCompanies.HeritageID);
					stockInOtherCompanies.StageTitle = heritage.StageTitle;
					stockInOtherCompanies.RegisterDate = heritage.RegisterDate;
					stockInOtherCompanies.OldRegisterDate = heritage.OldRegisterDate;
					stockInOtherCompanies.OldRegisterInformationID = heritage.OldRegisterInformationID;
					stockInOtherCompanies.Sixth = heritage.Sixth;
					stockInOtherCompanies.PreviousOwner = heritage.PreviousOwner;
					stockInOtherCompanies.Comment = heritage.Comment;
					stockInOtherCompanies.RegisterInformationID = heritage.RegisterInformationID;
					stockInOtherCompanies.AdjustmentID = heritage.AdjustmentID;
					stockInOtherCompanies.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					stockInOtherCompanies.Stage = heritage.Stage;
					stockInOtherCompanies.UserOrder = heritage.UserOrder;
					stockInOtherCompanies.Value1 = heritage.Value1;
					stockInOtherCompanies.Value2 = heritage.Value2;
					stockInOtherCompanies.Value3 = heritage.Value3;
					stockInOtherCompanies.DeadIsOwner = heritage.DeadIsOwner;
					stockInOtherCompanies.IsDiagonesed = heritage.IsDiagonesed;
					listStockInOtherCompanies.Add(stockInOtherCompanies);
				}
			}
		}

		return listStockInOtherCompanies;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersStockInOtherCompanies = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("StockInOtherCompanies_Exists", CommandType.StoredProcedure, parametersStockInOtherCompanies)>0);
	}

	public bool Exists(StockInOtherCompanies stockInOtherCompanies)
	{
		SqlParameter[] parametersStockInOtherCompanies = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", stockInOtherCompanies.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("StockInOtherCompanies_Exists", CommandType.StoredProcedure, parametersStockInOtherCompanies)>0);
	}

	public List<StockInOtherCompanies> SearchLike(StockInOtherCompanies stockInOtherCompanies)
	{
		List<StockInOtherCompanies> listStockInOtherCompanies = new List<StockInOtherCompanies>();


		SqlParameter[] parametersStockInOtherCompanies = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", stockInOtherCompanies.HeritageID),
			new SqlParameter("@CompanyTypeIDTitle", stockInOtherCompanies.CompanyTypeIDTitle),
			new SqlParameter("@InquiryTo", stockInOtherCompanies.InquiryTo),
			new SqlParameter("@StockNumber", stockInOtherCompanies.StockNumber),
			new SqlParameter("@StockPercent", stockInOtherCompanies.StockPercent),
			new SqlParameter("@TotalStockValue", stockInOtherCompanies.TotalStockValue),
			new SqlParameter("@DeclarationID", stockInOtherCompanies.DeclarationID),
			new SqlParameter("@CompanyTypeID", stockInOtherCompanies.CompanyTypeID),
			new SqlParameter("@CompanyName", stockInOtherCompanies.CompanyName),
			new SqlParameter("@CompanyRegisterNumber", stockInOtherCompanies.CompanyRegisterNumber),

			new SqlParameter("@StageTitle", stockInOtherCompanies.StageTitle),
			new SqlParameter("@RegisterDate", stockInOtherCompanies.RegisterDate),
			new SqlParameter("@OldRegisterDate", stockInOtherCompanies.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", stockInOtherCompanies.OldRegisterInformationID),
			new SqlParameter("@Sixth", stockInOtherCompanies.Sixth),
			new SqlParameter("@PreviousOwner", stockInOtherCompanies.PreviousOwner),
			new SqlParameter("@Comment", stockInOtherCompanies.Comment),
			new SqlParameter("@RegisterInformationID", stockInOtherCompanies.RegisterInformationID),
			new SqlParameter("@AdjustmentID", stockInOtherCompanies.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", stockInOtherCompanies.CommissionAdjustmentID),
			new SqlParameter("@Stage", stockInOtherCompanies.Stage),
			new SqlParameter("@UserOrder", stockInOtherCompanies.UserOrder),
			new SqlParameter("@Value1", stockInOtherCompanies.Value1),
			new SqlParameter("@Value2", stockInOtherCompanies.Value2),
			new SqlParameter("@Value3", stockInOtherCompanies.Value3),
			new SqlParameter("@DeadIsOwner", stockInOtherCompanies.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", stockInOtherCompanies.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("StockInOtherCompanies_SearchLike", CommandType.StoredProcedure, parametersStockInOtherCompanies))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					StockInOtherCompanies tmpStockInOtherCompanies = new StockInOtherCompanies();
					tmpStockInOtherCompanies.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpStockInOtherCompanies.CompanyTypeIDTitle = row["CompanyTypeIDTitle"].ToString();
					tmpStockInOtherCompanies.InquiryTo = row["InquiryTo"].ToString();
					tmpStockInOtherCompanies.StockNumber = (row["StockNumber"] != DBNull.Value) ? Convert.ToInt32(row["StockNumber"]) : 0 ;
					tmpStockInOtherCompanies.StockPercent = (row["StockPercent"] != DBNull.Value) ? Convert.ToInt32(row["StockPercent"]) : 0 ;
					tmpStockInOtherCompanies.TotalStockValue = (row["TotalStockValue"] != DBNull.Value) ? Convert.ToSingle(row["TotalStockValue"]) : 0 ;
					tmpStockInOtherCompanies.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpStockInOtherCompanies.CompanyTypeID = (row["CompanyTypeID"] != DBNull.Value) ? Convert.ToInt64(row["CompanyTypeID"]) : 0 ;
					tmpStockInOtherCompanies.CompanyName = row["CompanyName"].ToString();
					tmpStockInOtherCompanies.CompanyRegisterNumber = row["CompanyRegisterNumber"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(tmpStockInOtherCompanies.HeritageID);
					tmpStockInOtherCompanies.HeritageID = heritage.HeritageID;
					tmpStockInOtherCompanies.StageTitle = heritage.StageTitle;
					tmpStockInOtherCompanies.RegisterDate = heritage.RegisterDate;
					tmpStockInOtherCompanies.OldRegisterDate = heritage.OldRegisterDate;
					tmpStockInOtherCompanies.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpStockInOtherCompanies.Sixth = heritage.Sixth;
					tmpStockInOtherCompanies.PreviousOwner = heritage.PreviousOwner;
					tmpStockInOtherCompanies.Comment = heritage.Comment;
					tmpStockInOtherCompanies.RegisterInformationID = heritage.RegisterInformationID;
					tmpStockInOtherCompanies.AdjustmentID = heritage.AdjustmentID;
					tmpStockInOtherCompanies.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpStockInOtherCompanies.Stage = heritage.Stage;
					tmpStockInOtherCompanies.UserOrder = heritage.UserOrder;
					tmpStockInOtherCompanies.Value1 = heritage.Value1;
					tmpStockInOtherCompanies.Value2 = heritage.Value2;
					tmpStockInOtherCompanies.Value3 = heritage.Value3;
					tmpStockInOtherCompanies.DeadIsOwner = heritage.DeadIsOwner;
					tmpStockInOtherCompanies.IsDiagonesed = heritage.IsDiagonesed;

					listStockInOtherCompanies.Add(tmpStockInOtherCompanies);
				}
			}
		}

		return listStockInOtherCompanies;
	}

}
}
