using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class CompanyTypeDBAccess
{

	StockInOtherCompaniesDBAccess stockInOtherCompaniesDBAccess = new StockInOtherCompaniesDBAccess();
	StockProfitDBAccess stockProfitDBAccess = new StockProfitDBAccess();

	public List<StockInOtherCompanies> GetListStockInOtherCompanies(Int64 companyTypeID)
	{
		List<StockInOtherCompanies> listStockInOtherCompanies = new List<StockInOtherCompanies>() { };
		SqlParameter[] parametersCompanyType = new SqlParameter[]
		{
			new SqlParameter("@CompanyTypeID", companyTypeID)
		};

		//Lets get the list of StockInOtherCompanies records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("StockInOtherCompanies_GetList_UseInCompanyType", CommandType.StoredProcedure, parametersCompanyType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of stockInOtherCompanies
				listStockInOtherCompanies = new List<StockInOtherCompanies>();

				//Now lets populate the StockInOtherCompanies details into the list of stockInOtherCompaniess
				foreach (DataRow row in table.Rows)
				{
					StockInOtherCompanies stockInOtherCompanies = ConvertRowToStockInOtherCompanies(row);
					listStockInOtherCompanies.Add(stockInOtherCompanies);
				}
			}
		}

		return listStockInOtherCompanies;
	}

	private StockInOtherCompanies ConvertRowToStockInOtherCompanies(DataRow row)
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

		stockInOtherCompanies.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		stockInOtherCompanies.StageTitle = row["StageTitle"].ToString();
		stockInOtherCompanies.RegisterDate = row["RegisterDate"].ToString();
		stockInOtherCompanies.OldRegisterDate = row["OldRegisterDate"].ToString();
		stockInOtherCompanies.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		stockInOtherCompanies.Sixth = row["Sixth"].ToString();
		stockInOtherCompanies.PreviousOwner = row["PreviousOwner"].ToString();
		stockInOtherCompanies.Comment = row["Comment"].ToString();
		stockInOtherCompanies.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		stockInOtherCompanies.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		stockInOtherCompanies.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		stockInOtherCompanies.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		stockInOtherCompanies.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		stockInOtherCompanies.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		stockInOtherCompanies.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		stockInOtherCompanies.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		stockInOtherCompanies.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		stockInOtherCompanies.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return stockInOtherCompanies;
	}
	public List<StockProfit> GetListStockProfit(Int64 companyTypeID)
	{
		List<StockProfit> listStockProfit = new List<StockProfit>() { };
		SqlParameter[] parametersCompanyType = new SqlParameter[]
		{
			new SqlParameter("@CompanyTypeID", companyTypeID)
		};

		//Lets get the list of StockProfit records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("StockProfit_GetList_UseInCompanyType", CommandType.StoredProcedure, parametersCompanyType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of stockProfit
				listStockProfit = new List<StockProfit>();

				//Now lets populate the StockProfit details into the list of stockProfits
				foreach (DataRow row in table.Rows)
				{
					StockProfit stockProfit = ConvertRowToStockProfit(row);
					listStockProfit.Add(stockProfit);
				}
			}
		}

		return listStockProfit;
	}

	private StockProfit ConvertRowToStockProfit(DataRow row)
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

		stockProfit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		stockProfit.StageTitle = row["StageTitle"].ToString();
		stockProfit.RegisterDate = row["RegisterDate"].ToString();
		stockProfit.OldRegisterDate = row["OldRegisterDate"].ToString();
		stockProfit.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		stockProfit.Sixth = row["Sixth"].ToString();
		stockProfit.PreviousOwner = row["PreviousOwner"].ToString();
		stockProfit.Comment = row["Comment"].ToString();
		stockProfit.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		stockProfit.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		stockProfit.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		stockProfit.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		stockProfit.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		stockProfit.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		stockProfit.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		stockProfit.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		stockProfit.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		stockProfit.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return stockProfit;
	}
	public Int64 Insert(CompanyType companyType)
	{
		SqlParameter[] parametersCompanyType = new SqlParameter[]
		{
			new SqlParameter("@Title", companyType.Title),
			new SqlParameter("@Category", companyType.Category)
		};
		companyType.CompanyTypeID = SqlDBHelper.ExecuteScalar("CompanyType_Insert", CommandType.StoredProcedure, parametersCompanyType);
		return companyType.CompanyTypeID;
	}

	public bool Update(CompanyType companyType)
	{
		SqlParameter[] parametersCompanyType = new SqlParameter[]
		{
			new SqlParameter("@CompanyTypeID", companyType.CompanyTypeID),
			new SqlParameter("@Title", companyType.Title),
			new SqlParameter("@Category", companyType.Category)
		};
		return SqlDBHelper.ExecuteNonQuery("CompanyType_Update", CommandType.StoredProcedure, parametersCompanyType);
	}

	public bool Delete(Int64 companyTypeID)
	{
		SqlParameter[] parametersCompanyType = new SqlParameter[]
		{
			new SqlParameter("@CompanyTypeID", companyTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("CompanyType_Delete", CommandType.StoredProcedure, parametersCompanyType);
	}

	public CompanyType GetDetails(Int64 companyTypeID)
	{
		CompanyType companyType = new CompanyType();

		SqlParameter[] parametersCompanyType = new SqlParameter[]
		{
			new SqlParameter("@CompanyTypeID", companyTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CompanyType_GetDetails", CommandType.StoredProcedure, parametersCompanyType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				companyType.CompanyTypeID = (row["CompanyTypeID"] != DBNull.Value) ? Convert.ToInt64(row["CompanyTypeID"]) : 0 ;
				companyType.Title = row["Title"].ToString();
				companyType.Category = (row["Category"] != DBNull.Value) ? Convert.ToInt32(row["Category"]) : 0 ;
			}
		}

		return companyType;
	}

	public List<CompanyType> GetListAll()
	{
		List<CompanyType> listCompanyType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("CompanyType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listCompanyType = new List<CompanyType>();

				foreach (DataRow row in table.Rows)
				{
					CompanyType companyType = new CompanyType();
					companyType.CompanyTypeID = (row["CompanyTypeID"] != DBNull.Value) ? Convert.ToInt64(row["CompanyTypeID"]) : 0 ;
					companyType.Title = row["Title"].ToString();
					companyType.Category = (row["Category"] != DBNull.Value) ? Convert.ToInt32(row["Category"]) : 0 ;
					listCompanyType.Add(companyType);
				}
			}
		}

		return listCompanyType;
	}

	public bool Exists(Int64 companyTypeID)
	{
		SqlParameter[] parametersCompanyType = new SqlParameter[]
		{
			new SqlParameter("@CompanyTypeID", companyTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("CompanyType_Exists", CommandType.StoredProcedure, parametersCompanyType)>0);
	}

	public bool Exists(CompanyType companyType)
	{
		SqlParameter[] parametersCompanyType = new SqlParameter[]
		{
			new SqlParameter("@CompanyTypeID", companyType.CompanyTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("CompanyType_Exists", CommandType.StoredProcedure, parametersCompanyType)>0);
	}

	public List<CompanyType> SearchLike(CompanyType companyType)
	{
		List<CompanyType> listCompanyType = new List<CompanyType>();


		SqlParameter[] parametersCompanyType = new SqlParameter[]
		{
			new SqlParameter("@CompanyTypeID", companyType.CompanyTypeID),
			new SqlParameter("@Title", companyType.Title),
			new SqlParameter("@Category", companyType.Category),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CompanyType_SearchLike", CommandType.StoredProcedure, parametersCompanyType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					CompanyType tmpCompanyType = new CompanyType();
					tmpCompanyType.CompanyTypeID = (row["CompanyTypeID"] != DBNull.Value) ? Convert.ToInt64(row["CompanyTypeID"]) : 0 ;
					tmpCompanyType.Title = row["Title"].ToString();
					tmpCompanyType.Category = (row["Category"] != DBNull.Value) ? Convert.ToInt32(row["Category"]) : 0 ;

					listCompanyType.Add(tmpCompanyType);
				}
			}
		}

		return listCompanyType;
	}

}
}
