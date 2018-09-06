using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class PropertiesNumberDBAccess
{


	public Int64 Insert(PropertiesNumber propertiesNumber)
	{
		SqlParameter[] parametersPropertiesNumber = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", (propertiesNumber.DeclarationID > 0) ? propertiesNumber.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@Stage", (propertiesNumber.Stage != null) ? propertiesNumber.Stage : (object)DBNull.Value),
			new SqlParameter("@ProductionUnitNumber", (propertiesNumber.ProductionUnitNumber != null) ? propertiesNumber.ProductionUnitNumber : (object)DBNull.Value),
			new SqlParameter("@HomeFurnishingsNumber", (propertiesNumber.HomeFurnishingsNumber != null) ? propertiesNumber.HomeFurnishingsNumber : (object)DBNull.Value),
			new SqlParameter("@CarNumber", (propertiesNumber.CarNumber != null) ? propertiesNumber.CarNumber : (object)DBNull.Value),
			new SqlParameter("@JusticeSharesNumber", (propertiesNumber.JusticeSharesNumber != null) ? propertiesNumber.JusticeSharesNumber : (object)DBNull.Value),
			new SqlParameter("@CapitalAndCommodityDepositNumber", (propertiesNumber.CapitalAndCommodityDepositNumber != null) ? propertiesNumber.CapitalAndCommodityDepositNumber : (object)DBNull.Value),
			new SqlParameter("@StockProfitNumber", (propertiesNumber.StockProfitNumber != null) ? propertiesNumber.StockProfitNumber : (object)DBNull.Value),
			new SqlParameter("@BankDepositProfit", (propertiesNumber.BankDepositProfit != null) ? propertiesNumber.BankDepositProfit : (object)DBNull.Value),
			new SqlParameter("@BankDepositNumber", (propertiesNumber.BankDepositNumber != null) ? propertiesNumber.BankDepositNumber : (object)DBNull.Value),
			new SqlParameter("@DemmandsNumber", (propertiesNumber.DemmandsNumber != null) ? propertiesNumber.DemmandsNumber : (object)DBNull.Value),
			new SqlParameter("@SafeBoxNumber", (propertiesNumber.SafeBoxNumber != null) ? propertiesNumber.SafeBoxNumber : (object)DBNull.Value),
			new SqlParameter("@PermitNumber", (propertiesNumber.PermitNumber != null) ? propertiesNumber.PermitNumber : (object)DBNull.Value),
			new SqlParameter("@FinancialRightsNumber", (propertiesNumber.FinancialRightsNumber != null) ? propertiesNumber.FinancialRightsNumber : (object)DBNull.Value),
			new SqlParameter("@TransferRights", (propertiesNumber.TransferRights != null) ? propertiesNumber.TransferRights : (object)DBNull.Value),
			new SqlParameter("@TreeNumber", (propertiesNumber.TreeNumber != null) ? propertiesNumber.TreeNumber : (object)DBNull.Value),
			new SqlParameter("@EstateNumber", (propertiesNumber.EstateNumber != null) ? propertiesNumber.EstateNumber : (object)DBNull.Value),
			new SqlParameter("@StockInOtherCompaniesNumber", (propertiesNumber.StockInOtherCompaniesNumber != null) ? propertiesNumber.StockInOtherCompaniesNumber : (object)DBNull.Value),
			new SqlParameter("@PartnershipPapersNumber", (propertiesNumber.PartnershipPapersNumber != null) ? propertiesNumber.PartnershipPapersNumber : (object)DBNull.Value),
			new SqlParameter("@HajjNumber", (propertiesNumber.HajjNumber != null) ? propertiesNumber.HajjNumber : (object)DBNull.Value),
			new SqlParameter("@ScoreNumber", (propertiesNumber.ScoreNumber != null) ? propertiesNumber.ScoreNumber : (object)DBNull.Value),
			new SqlParameter("@BourseStockNumber", (propertiesNumber.BourseStockNumber != null) ? propertiesNumber.BourseStockNumber : (object)DBNull.Value),
			new SqlParameter("@MachineryNumber", (propertiesNumber.MachineryNumber != null) ? propertiesNumber.MachineryNumber : (object)DBNull.Value),
			new SqlParameter("@OtherPropertiesNumber", (propertiesNumber.OtherPropertiesNumber != null) ? propertiesNumber.OtherPropertiesNumber : (object)DBNull.Value),
			new SqlParameter("@WellNumber", (propertiesNumber.WellNumber != null) ? propertiesNumber.WellNumber : (object)DBNull.Value),
			new SqlParameter("@JewelNumber", (propertiesNumber.JewelNumber != null) ? propertiesNumber.JewelNumber : (object)DBNull.Value),
			new SqlParameter("@PhoneNumber", (propertiesNumber.PhoneNumber != null) ? propertiesNumber.PhoneNumber : (object)DBNull.Value)
		};
		propertiesNumber.PrpertiesNumberID = SqlDBHelper.ExecuteScalar("PropertiesNumber_Insert", CommandType.StoredProcedure, parametersPropertiesNumber);
		return propertiesNumber.PrpertiesNumberID;
	}

	public bool Update(PropertiesNumber propertiesNumber)
	{
		SqlParameter[] parametersPropertiesNumber = new SqlParameter[]
		{
			new SqlParameter("@PrpertiesNumberID", propertiesNumber.PrpertiesNumberID),
			new SqlParameter("@DeclarationID", propertiesNumber.DeclarationID),
			new SqlParameter("@Stage", (propertiesNumber.Stage != null) ? propertiesNumber.Stage : (object)DBNull.Value),
			new SqlParameter("@ProductionUnitNumber", (propertiesNumber.ProductionUnitNumber != null) ? propertiesNumber.ProductionUnitNumber : (object)DBNull.Value),
			new SqlParameter("@HomeFurnishingsNumber", (propertiesNumber.HomeFurnishingsNumber != null) ? propertiesNumber.HomeFurnishingsNumber : (object)DBNull.Value),
			new SqlParameter("@CarNumber", (propertiesNumber.CarNumber != null) ? propertiesNumber.CarNumber : (object)DBNull.Value),
			new SqlParameter("@JusticeSharesNumber", (propertiesNumber.JusticeSharesNumber != null) ? propertiesNumber.JusticeSharesNumber : (object)DBNull.Value),
			new SqlParameter("@CapitalAndCommodityDepositNumber", (propertiesNumber.CapitalAndCommodityDepositNumber != null) ? propertiesNumber.CapitalAndCommodityDepositNumber : (object)DBNull.Value),
			new SqlParameter("@StockProfitNumber", (propertiesNumber.StockProfitNumber != null) ? propertiesNumber.StockProfitNumber : (object)DBNull.Value),
			new SqlParameter("@BankDepositProfit", (propertiesNumber.BankDepositProfit != null) ? propertiesNumber.BankDepositProfit : (object)DBNull.Value),
			new SqlParameter("@BankDepositNumber", (propertiesNumber.BankDepositNumber != null) ? propertiesNumber.BankDepositNumber : (object)DBNull.Value),
			new SqlParameter("@DemmandsNumber", (propertiesNumber.DemmandsNumber != null) ? propertiesNumber.DemmandsNumber : (object)DBNull.Value),
			new SqlParameter("@SafeBoxNumber", (propertiesNumber.SafeBoxNumber != null) ? propertiesNumber.SafeBoxNumber : (object)DBNull.Value),
			new SqlParameter("@PermitNumber", (propertiesNumber.PermitNumber != null) ? propertiesNumber.PermitNumber : (object)DBNull.Value),
			new SqlParameter("@FinancialRightsNumber", (propertiesNumber.FinancialRightsNumber != null) ? propertiesNumber.FinancialRightsNumber : (object)DBNull.Value),
			new SqlParameter("@TransferRights", (propertiesNumber.TransferRights != null) ? propertiesNumber.TransferRights : (object)DBNull.Value),
			new SqlParameter("@TreeNumber", (propertiesNumber.TreeNumber != null) ? propertiesNumber.TreeNumber : (object)DBNull.Value),
			new SqlParameter("@EstateNumber", (propertiesNumber.EstateNumber != null) ? propertiesNumber.EstateNumber : (object)DBNull.Value),
			new SqlParameter("@StockInOtherCompaniesNumber", (propertiesNumber.StockInOtherCompaniesNumber != null) ? propertiesNumber.StockInOtherCompaniesNumber : (object)DBNull.Value),
			new SqlParameter("@PartnershipPapersNumber", (propertiesNumber.PartnershipPapersNumber != null) ? propertiesNumber.PartnershipPapersNumber : (object)DBNull.Value),
			new SqlParameter("@HajjNumber", (propertiesNumber.HajjNumber != null) ? propertiesNumber.HajjNumber : (object)DBNull.Value),
			new SqlParameter("@ScoreNumber", (propertiesNumber.ScoreNumber != null) ? propertiesNumber.ScoreNumber : (object)DBNull.Value),
			new SqlParameter("@BourseStockNumber", (propertiesNumber.BourseStockNumber != null) ? propertiesNumber.BourseStockNumber : (object)DBNull.Value),
			new SqlParameter("@MachineryNumber", (propertiesNumber.MachineryNumber != null) ? propertiesNumber.MachineryNumber : (object)DBNull.Value),
			new SqlParameter("@OtherPropertiesNumber", (propertiesNumber.OtherPropertiesNumber != null) ? propertiesNumber.OtherPropertiesNumber : (object)DBNull.Value),
			new SqlParameter("@WellNumber", (propertiesNumber.WellNumber != null) ? propertiesNumber.WellNumber : (object)DBNull.Value),
			new SqlParameter("@JewelNumber", (propertiesNumber.JewelNumber != null) ? propertiesNumber.JewelNumber : (object)DBNull.Value),
			new SqlParameter("@PhoneNumber", (propertiesNumber.PhoneNumber != null) ? propertiesNumber.PhoneNumber : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("PropertiesNumber_Update", CommandType.StoredProcedure, parametersPropertiesNumber);
	}

	public bool Delete(Int64 prpertiesNumberID)
	{
		SqlParameter[] parametersPropertiesNumber = new SqlParameter[]
		{
			new SqlParameter("@PrpertiesNumberID", prpertiesNumberID)
		};
		return SqlDBHelper.ExecuteNonQuery("PropertiesNumber_Delete", CommandType.StoredProcedure, parametersPropertiesNumber);
	}

	public PropertiesNumber GetDetails(Int64 prpertiesNumberID)
	{
		PropertiesNumber propertiesNumber = new PropertiesNumber();

		SqlParameter[] parametersPropertiesNumber = new SqlParameter[]
		{
			new SqlParameter("@PrpertiesNumberID", prpertiesNumberID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("PropertiesNumber_GetDetails", CommandType.StoredProcedure, parametersPropertiesNumber))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				propertiesNumber.PrpertiesNumberID = (row["PrpertiesNumberID"] != DBNull.Value) ? Convert.ToInt64(row["PrpertiesNumberID"]) : 0 ;
				propertiesNumber.StageTitle = row["StageTitle"].ToString();
				propertiesNumber.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				propertiesNumber.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
				propertiesNumber.ProductionUnitNumber = (row["ProductionUnitNumber"] != DBNull.Value) ? Convert.ToInt32(row["ProductionUnitNumber"]) : 0 ;
				propertiesNumber.HomeFurnishingsNumber = (row["HomeFurnishingsNumber"] != DBNull.Value) ? Convert.ToInt32(row["HomeFurnishingsNumber"]) : 0 ;
				propertiesNumber.CarNumber = (row["CarNumber"] != DBNull.Value) ? Convert.ToInt32(row["CarNumber"]) : 0 ;
				propertiesNumber.JusticeSharesNumber = (row["JusticeSharesNumber"] != DBNull.Value) ? Convert.ToInt32(row["JusticeSharesNumber"]) : 0 ;
				propertiesNumber.CapitalAndCommodityDepositNumber = (row["CapitalAndCommodityDepositNumber"] != DBNull.Value) ? Convert.ToInt32(row["CapitalAndCommodityDepositNumber"]) : 0 ;
				propertiesNumber.StockProfitNumber = (row["StockProfitNumber"] != DBNull.Value) ? Convert.ToInt32(row["StockProfitNumber"]) : 0 ;
				propertiesNumber.BankDepositProfit = (row["BankDepositProfit"] != DBNull.Value) ? Convert.ToInt32(row["BankDepositProfit"]) : 0 ;
				propertiesNumber.BankDepositNumber = (row["BankDepositNumber"] != DBNull.Value) ? Convert.ToInt32(row["BankDepositNumber"]) : 0 ;
				propertiesNumber.DemmandsNumber = (row["DemmandsNumber"] != DBNull.Value) ? Convert.ToInt32(row["DemmandsNumber"]) : 0 ;
				propertiesNumber.SafeBoxNumber = (row["SafeBoxNumber"] != DBNull.Value) ? Convert.ToInt32(row["SafeBoxNumber"]) : 0 ;
				propertiesNumber.PermitNumber = (row["PermitNumber"] != DBNull.Value) ? Convert.ToInt32(row["PermitNumber"]) : 0 ;
				propertiesNumber.FinancialRightsNumber = (row["FinancialRightsNumber"] != DBNull.Value) ? Convert.ToInt32(row["FinancialRightsNumber"]) : 0 ;
				propertiesNumber.TransferRights = (row["TransferRights"] != DBNull.Value) ? Convert.ToInt32(row["TransferRights"]) : 0 ;
				propertiesNumber.TreeNumber = (row["TreeNumber"] != DBNull.Value) ? Convert.ToInt32(row["TreeNumber"]) : 0 ;
				propertiesNumber.EstateNumber = (row["EstateNumber"] != DBNull.Value) ? Convert.ToInt32(row["EstateNumber"]) : 0 ;
				propertiesNumber.StockInOtherCompaniesNumber = (row["StockInOtherCompaniesNumber"] != DBNull.Value) ? Convert.ToInt32(row["StockInOtherCompaniesNumber"]) : 0 ;
				propertiesNumber.PartnershipPapersNumber = (row["PartnershipPapersNumber"] != DBNull.Value) ? Convert.ToInt32(row["PartnershipPapersNumber"]) : 0 ;
				propertiesNumber.HajjNumber = (row["HajjNumber"] != DBNull.Value) ? Convert.ToInt32(row["HajjNumber"]) : 0 ;
				propertiesNumber.ScoreNumber = (row["ScoreNumber"] != DBNull.Value) ? Convert.ToInt32(row["ScoreNumber"]) : 0 ;
				propertiesNumber.BourseStockNumber = (row["BourseStockNumber"] != DBNull.Value) ? Convert.ToInt32(row["BourseStockNumber"]) : 0 ;
				propertiesNumber.MachineryNumber = (row["MachineryNumber"] != DBNull.Value) ? Convert.ToInt32(row["MachineryNumber"]) : 0 ;
				propertiesNumber.OtherPropertiesNumber = (row["OtherPropertiesNumber"] != DBNull.Value) ? Convert.ToInt32(row["OtherPropertiesNumber"]) : 0 ;
				propertiesNumber.WellNumber = (row["WellNumber"] != DBNull.Value) ? Convert.ToInt32(row["WellNumber"]) : 0 ;
				propertiesNumber.JewelNumber = (row["JewelNumber"] != DBNull.Value) ? Convert.ToInt32(row["JewelNumber"]) : 0 ;
				propertiesNumber.PhoneNumber = (row["PhoneNumber"] != DBNull.Value) ? Convert.ToInt32(row["PhoneNumber"]) : 0 ;
			}
		}

		return propertiesNumber;
	}

	public List<PropertiesNumber> GetListAll()
	{
		List<PropertiesNumber> listPropertiesNumber = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("PropertiesNumber_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listPropertiesNumber = new List<PropertiesNumber>();

				foreach (DataRow row in table.Rows)
				{
					PropertiesNumber propertiesNumber = new PropertiesNumber();
					propertiesNumber.PrpertiesNumberID = (row["PrpertiesNumberID"] != DBNull.Value) ? Convert.ToInt64(row["PrpertiesNumberID"]) : 0 ;
					propertiesNumber.StageTitle = row["StageTitle"].ToString();
					propertiesNumber.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					propertiesNumber.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
					propertiesNumber.ProductionUnitNumber = (row["ProductionUnitNumber"] != DBNull.Value) ? Convert.ToInt32(row["ProductionUnitNumber"]) : 0 ;
					propertiesNumber.HomeFurnishingsNumber = (row["HomeFurnishingsNumber"] != DBNull.Value) ? Convert.ToInt32(row["HomeFurnishingsNumber"]) : 0 ;
					propertiesNumber.CarNumber = (row["CarNumber"] != DBNull.Value) ? Convert.ToInt32(row["CarNumber"]) : 0 ;
					propertiesNumber.JusticeSharesNumber = (row["JusticeSharesNumber"] != DBNull.Value) ? Convert.ToInt32(row["JusticeSharesNumber"]) : 0 ;
					propertiesNumber.CapitalAndCommodityDepositNumber = (row["CapitalAndCommodityDepositNumber"] != DBNull.Value) ? Convert.ToInt32(row["CapitalAndCommodityDepositNumber"]) : 0 ;
					propertiesNumber.StockProfitNumber = (row["StockProfitNumber"] != DBNull.Value) ? Convert.ToInt32(row["StockProfitNumber"]) : 0 ;
					propertiesNumber.BankDepositProfit = (row["BankDepositProfit"] != DBNull.Value) ? Convert.ToInt32(row["BankDepositProfit"]) : 0 ;
					propertiesNumber.BankDepositNumber = (row["BankDepositNumber"] != DBNull.Value) ? Convert.ToInt32(row["BankDepositNumber"]) : 0 ;
					propertiesNumber.DemmandsNumber = (row["DemmandsNumber"] != DBNull.Value) ? Convert.ToInt32(row["DemmandsNumber"]) : 0 ;
					propertiesNumber.SafeBoxNumber = (row["SafeBoxNumber"] != DBNull.Value) ? Convert.ToInt32(row["SafeBoxNumber"]) : 0 ;
					propertiesNumber.PermitNumber = (row["PermitNumber"] != DBNull.Value) ? Convert.ToInt32(row["PermitNumber"]) : 0 ;
					propertiesNumber.FinancialRightsNumber = (row["FinancialRightsNumber"] != DBNull.Value) ? Convert.ToInt32(row["FinancialRightsNumber"]) : 0 ;
					propertiesNumber.TransferRights = (row["TransferRights"] != DBNull.Value) ? Convert.ToInt32(row["TransferRights"]) : 0 ;
					propertiesNumber.TreeNumber = (row["TreeNumber"] != DBNull.Value) ? Convert.ToInt32(row["TreeNumber"]) : 0 ;
					propertiesNumber.EstateNumber = (row["EstateNumber"] != DBNull.Value) ? Convert.ToInt32(row["EstateNumber"]) : 0 ;
					propertiesNumber.StockInOtherCompaniesNumber = (row["StockInOtherCompaniesNumber"] != DBNull.Value) ? Convert.ToInt32(row["StockInOtherCompaniesNumber"]) : 0 ;
					propertiesNumber.PartnershipPapersNumber = (row["PartnershipPapersNumber"] != DBNull.Value) ? Convert.ToInt32(row["PartnershipPapersNumber"]) : 0 ;
					propertiesNumber.HajjNumber = (row["HajjNumber"] != DBNull.Value) ? Convert.ToInt32(row["HajjNumber"]) : 0 ;
					propertiesNumber.ScoreNumber = (row["ScoreNumber"] != DBNull.Value) ? Convert.ToInt32(row["ScoreNumber"]) : 0 ;
					propertiesNumber.BourseStockNumber = (row["BourseStockNumber"] != DBNull.Value) ? Convert.ToInt32(row["BourseStockNumber"]) : 0 ;
					propertiesNumber.MachineryNumber = (row["MachineryNumber"] != DBNull.Value) ? Convert.ToInt32(row["MachineryNumber"]) : 0 ;
					propertiesNumber.OtherPropertiesNumber = (row["OtherPropertiesNumber"] != DBNull.Value) ? Convert.ToInt32(row["OtherPropertiesNumber"]) : 0 ;
					propertiesNumber.WellNumber = (row["WellNumber"] != DBNull.Value) ? Convert.ToInt32(row["WellNumber"]) : 0 ;
					propertiesNumber.JewelNumber = (row["JewelNumber"] != DBNull.Value) ? Convert.ToInt32(row["JewelNumber"]) : 0 ;
					propertiesNumber.PhoneNumber = (row["PhoneNumber"] != DBNull.Value) ? Convert.ToInt32(row["PhoneNumber"]) : 0 ;
					listPropertiesNumber.Add(propertiesNumber);
				}
			}
		}

		return listPropertiesNumber;
	}

	public bool Exists(Int64 prpertiesNumberID)
	{
		SqlParameter[] parametersPropertiesNumber = new SqlParameter[]
		{
			new SqlParameter("@PrpertiesNumberID", prpertiesNumberID)
		};
		return (SqlDBHelper.ExecuteScalar("PropertiesNumber_Exists", CommandType.StoredProcedure, parametersPropertiesNumber)>0);
	}

	public bool Exists(PropertiesNumber propertiesNumber)
	{
		SqlParameter[] parametersPropertiesNumber = new SqlParameter[]
		{
			new SqlParameter("@PrpertiesNumberID", propertiesNumber.PrpertiesNumberID)
		};
		return (SqlDBHelper.ExecuteScalar("PropertiesNumber_Exists", CommandType.StoredProcedure, parametersPropertiesNumber)>0);
	}

	public List<PropertiesNumber> SearchLike(PropertiesNumber propertiesNumber)
	{
		List<PropertiesNumber> listPropertiesNumber = new List<PropertiesNumber>();


		SqlParameter[] parametersPropertiesNumber = new SqlParameter[]
		{
			new SqlParameter("@PrpertiesNumberID", propertiesNumber.PrpertiesNumberID),
			new SqlParameter("@StageTitle", propertiesNumber.StageTitle),
			new SqlParameter("@DeclarationID", propertiesNumber.DeclarationID),
			new SqlParameter("@Stage", propertiesNumber.Stage),
			new SqlParameter("@ProductionUnitNumber", propertiesNumber.ProductionUnitNumber),
			new SqlParameter("@HomeFurnishingsNumber", propertiesNumber.HomeFurnishingsNumber),
			new SqlParameter("@CarNumber", propertiesNumber.CarNumber),
			new SqlParameter("@JusticeSharesNumber", propertiesNumber.JusticeSharesNumber),
			new SqlParameter("@CapitalAndCommodityDepositNumber", propertiesNumber.CapitalAndCommodityDepositNumber),
			new SqlParameter("@StockProfitNumber", propertiesNumber.StockProfitNumber),
			new SqlParameter("@BankDepositProfit", propertiesNumber.BankDepositProfit),
			new SqlParameter("@BankDepositNumber", propertiesNumber.BankDepositNumber),
			new SqlParameter("@DemmandsNumber", propertiesNumber.DemmandsNumber),
			new SqlParameter("@SafeBoxNumber", propertiesNumber.SafeBoxNumber),
			new SqlParameter("@PermitNumber", propertiesNumber.PermitNumber),
			new SqlParameter("@FinancialRightsNumber", propertiesNumber.FinancialRightsNumber),
			new SqlParameter("@TransferRights", propertiesNumber.TransferRights),
			new SqlParameter("@TreeNumber", propertiesNumber.TreeNumber),
			new SqlParameter("@EstateNumber", propertiesNumber.EstateNumber),
			new SqlParameter("@StockInOtherCompaniesNumber", propertiesNumber.StockInOtherCompaniesNumber),
			new SqlParameter("@PartnershipPapersNumber", propertiesNumber.PartnershipPapersNumber),
			new SqlParameter("@HajjNumber", propertiesNumber.HajjNumber),
			new SqlParameter("@ScoreNumber", propertiesNumber.ScoreNumber),
			new SqlParameter("@BourseStockNumber", propertiesNumber.BourseStockNumber),
			new SqlParameter("@MachineryNumber", propertiesNumber.MachineryNumber),
			new SqlParameter("@OtherPropertiesNumber", propertiesNumber.OtherPropertiesNumber),
			new SqlParameter("@WellNumber", propertiesNumber.WellNumber),
			new SqlParameter("@JewelNumber", propertiesNumber.JewelNumber),
			new SqlParameter("@PhoneNumber", propertiesNumber.PhoneNumber),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("PropertiesNumber_SearchLike", CommandType.StoredProcedure, parametersPropertiesNumber))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					PropertiesNumber tmpPropertiesNumber = new PropertiesNumber();
					tmpPropertiesNumber.PrpertiesNumberID = (row["PrpertiesNumberID"] != DBNull.Value) ? Convert.ToInt64(row["PrpertiesNumberID"]) : 0 ;
					tmpPropertiesNumber.StageTitle = row["StageTitle"].ToString();
					tmpPropertiesNumber.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpPropertiesNumber.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
					tmpPropertiesNumber.ProductionUnitNumber = (row["ProductionUnitNumber"] != DBNull.Value) ? Convert.ToInt32(row["ProductionUnitNumber"]) : 0 ;
					tmpPropertiesNumber.HomeFurnishingsNumber = (row["HomeFurnishingsNumber"] != DBNull.Value) ? Convert.ToInt32(row["HomeFurnishingsNumber"]) : 0 ;
					tmpPropertiesNumber.CarNumber = (row["CarNumber"] != DBNull.Value) ? Convert.ToInt32(row["CarNumber"]) : 0 ;
					tmpPropertiesNumber.JusticeSharesNumber = (row["JusticeSharesNumber"] != DBNull.Value) ? Convert.ToInt32(row["JusticeSharesNumber"]) : 0 ;
					tmpPropertiesNumber.CapitalAndCommodityDepositNumber = (row["CapitalAndCommodityDepositNumber"] != DBNull.Value) ? Convert.ToInt32(row["CapitalAndCommodityDepositNumber"]) : 0 ;
					tmpPropertiesNumber.StockProfitNumber = (row["StockProfitNumber"] != DBNull.Value) ? Convert.ToInt32(row["StockProfitNumber"]) : 0 ;
					tmpPropertiesNumber.BankDepositProfit = (row["BankDepositProfit"] != DBNull.Value) ? Convert.ToInt32(row["BankDepositProfit"]) : 0 ;
					tmpPropertiesNumber.BankDepositNumber = (row["BankDepositNumber"] != DBNull.Value) ? Convert.ToInt32(row["BankDepositNumber"]) : 0 ;
					tmpPropertiesNumber.DemmandsNumber = (row["DemmandsNumber"] != DBNull.Value) ? Convert.ToInt32(row["DemmandsNumber"]) : 0 ;
					tmpPropertiesNumber.SafeBoxNumber = (row["SafeBoxNumber"] != DBNull.Value) ? Convert.ToInt32(row["SafeBoxNumber"]) : 0 ;
					tmpPropertiesNumber.PermitNumber = (row["PermitNumber"] != DBNull.Value) ? Convert.ToInt32(row["PermitNumber"]) : 0 ;
					tmpPropertiesNumber.FinancialRightsNumber = (row["FinancialRightsNumber"] != DBNull.Value) ? Convert.ToInt32(row["FinancialRightsNumber"]) : 0 ;
					tmpPropertiesNumber.TransferRights = (row["TransferRights"] != DBNull.Value) ? Convert.ToInt32(row["TransferRights"]) : 0 ;
					tmpPropertiesNumber.TreeNumber = (row["TreeNumber"] != DBNull.Value) ? Convert.ToInt32(row["TreeNumber"]) : 0 ;
					tmpPropertiesNumber.EstateNumber = (row["EstateNumber"] != DBNull.Value) ? Convert.ToInt32(row["EstateNumber"]) : 0 ;
					tmpPropertiesNumber.StockInOtherCompaniesNumber = (row["StockInOtherCompaniesNumber"] != DBNull.Value) ? Convert.ToInt32(row["StockInOtherCompaniesNumber"]) : 0 ;
					tmpPropertiesNumber.PartnershipPapersNumber = (row["PartnershipPapersNumber"] != DBNull.Value) ? Convert.ToInt32(row["PartnershipPapersNumber"]) : 0 ;
					tmpPropertiesNumber.HajjNumber = (row["HajjNumber"] != DBNull.Value) ? Convert.ToInt32(row["HajjNumber"]) : 0 ;
					tmpPropertiesNumber.ScoreNumber = (row["ScoreNumber"] != DBNull.Value) ? Convert.ToInt32(row["ScoreNumber"]) : 0 ;
					tmpPropertiesNumber.BourseStockNumber = (row["BourseStockNumber"] != DBNull.Value) ? Convert.ToInt32(row["BourseStockNumber"]) : 0 ;
					tmpPropertiesNumber.MachineryNumber = (row["MachineryNumber"] != DBNull.Value) ? Convert.ToInt32(row["MachineryNumber"]) : 0 ;
					tmpPropertiesNumber.OtherPropertiesNumber = (row["OtherPropertiesNumber"] != DBNull.Value) ? Convert.ToInt32(row["OtherPropertiesNumber"]) : 0 ;
					tmpPropertiesNumber.WellNumber = (row["WellNumber"] != DBNull.Value) ? Convert.ToInt32(row["WellNumber"]) : 0 ;
					tmpPropertiesNumber.JewelNumber = (row["JewelNumber"] != DBNull.Value) ? Convert.ToInt32(row["JewelNumber"]) : 0 ;
					tmpPropertiesNumber.PhoneNumber = (row["PhoneNumber"] != DBNull.Value) ? Convert.ToInt32(row["PhoneNumber"]) : 0 ;

					listPropertiesNumber.Add(tmpPropertiesNumber);
				}
			}
		}

		return listPropertiesNumber;
	}

}
}
