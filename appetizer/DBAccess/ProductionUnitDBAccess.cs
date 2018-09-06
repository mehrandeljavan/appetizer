using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class ProductionUnitDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();

	CapitalAndCommodityDepositDBAccess capitalAndCommodityDepositDBAccess = new CapitalAndCommodityDepositDBAccess();
	CarDBAccess carDBAccess = new CarDBAccess();
	DebtsDBAccess debtsDBAccess = new DebtsDBAccess();
	DemandsDBAccess demandsDBAccess = new DemandsDBAccess();
	EstateDBAccess estateDBAccess = new EstateDBAccess();
	FinancialRightsDBAccess financialRightsDBAccess = new FinancialRightsDBAccess();
	MachineryDBAccess machineryDBAccess = new MachineryDBAccess();
	OtherPropertiesDBAccess otherPropertiesDBAccess = new OtherPropertiesDBAccess();
	PermitDBAccess permitDBAccess = new PermitDBAccess();
	PhoneDBAccess phoneDBAccess = new PhoneDBAccess();
	ScoreDBAccess scoreDBAccess = new ScoreDBAccess();
	TransferRightDBAccess transferRightDBAccess = new TransferRightDBAccess();
	TreeDBAccess treeDBAccess = new TreeDBAccess();
	WellDBAccess wellDBAccess = new WellDBAccess();

	public List<CapitalAndCommodityDeposit> GetListCapitalAndCommodityDeposit(Int64 productionUnitID)
	{
		List<CapitalAndCommodityDeposit> listCapitalAndCommodityDeposit = new List<CapitalAndCommodityDeposit>() { };
		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnitID)
		};

		//Lets get the list of CapitalAndCommodityDeposit records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CapitalAndCommodityDeposit_GetList_UseInProductionUnit", CommandType.StoredProcedure, parametersProductionUnit))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of capitalAndCommodityDeposit
				listCapitalAndCommodityDeposit = new List<CapitalAndCommodityDeposit>();

				//Now lets populate the CapitalAndCommodityDeposit details into the list of capitalAndCommodityDeposits
				foreach (DataRow row in table.Rows)
				{
					CapitalAndCommodityDeposit capitalAndCommodityDeposit = ConvertRowToCapitalAndCommodityDeposit(row);
					listCapitalAndCommodityDeposit.Add(capitalAndCommodityDeposit);
				}
			}
		}

		return listCapitalAndCommodityDeposit;
	}

	private CapitalAndCommodityDeposit ConvertRowToCapitalAndCommodityDeposit(DataRow row)
	{
		CapitalAndCommodityDeposit capitalAndCommodityDeposit = new CapitalAndCommodityDeposit();
		capitalAndCommodityDeposit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		capitalAndCommodityDeposit.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
		capitalAndCommodityDeposit.Title = row["Title"].ToString();
		capitalAndCommodityDeposit.Address = row["Address"].ToString();
		capitalAndCommodityDeposit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

		capitalAndCommodityDeposit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		capitalAndCommodityDeposit.StageTitle = row["StageTitle"].ToString();
		capitalAndCommodityDeposit.RegisterDate = row["RegisterDate"].ToString();
		capitalAndCommodityDeposit.OldRegisterDate = row["OldRegisterDate"].ToString();
		capitalAndCommodityDeposit.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		capitalAndCommodityDeposit.Sixth = row["Sixth"].ToString();
		capitalAndCommodityDeposit.PreviousOwner = row["PreviousOwner"].ToString();
		capitalAndCommodityDeposit.Comment = row["Comment"].ToString();
		capitalAndCommodityDeposit.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		capitalAndCommodityDeposit.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		capitalAndCommodityDeposit.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		capitalAndCommodityDeposit.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		capitalAndCommodityDeposit.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		capitalAndCommodityDeposit.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		capitalAndCommodityDeposit.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		capitalAndCommodityDeposit.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		capitalAndCommodityDeposit.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		capitalAndCommodityDeposit.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return capitalAndCommodityDeposit;
	}
	public List<Car> GetListCar(Int64 productionUnitID)
	{
		List<Car> listCar = new List<Car>() { };
		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnitID)
		};

		//Lets get the list of Car records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Car_GetList_UseInProductionUnit", CommandType.StoredProcedure, parametersProductionUnit))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of car
				listCar = new List<Car>();

				//Now lets populate the Car details into the list of cars
				foreach (DataRow row in table.Rows)
				{
					Car car = ConvertRowToCar(row);
					listCar.Add(car);
				}
			}
		}

		return listCar;
	}

	private Car ConvertRowToCar(DataRow row)
	{
		Car car = new Car();
		car.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		car.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		car.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
		car.Title = row["Title"].ToString();
		car.PlaqueNumber = row["PlaqueNumber"].ToString();
		car.Color = row["Color"].ToString();
		car.MotorNumber = row["MotorNumber"].ToString();
		car.ChassisNumber = row["ChassisNumber"].ToString();
		car.ProductionYear = (row["ProductionYear"] != DBNull.Value) ? Convert.ToInt32(row["ProductionYear"]) : 0 ;

		car.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		car.StageTitle = row["StageTitle"].ToString();
		car.RegisterDate = row["RegisterDate"].ToString();
		car.OldRegisterDate = row["OldRegisterDate"].ToString();
		car.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		car.Sixth = row["Sixth"].ToString();
		car.PreviousOwner = row["PreviousOwner"].ToString();
		car.Comment = row["Comment"].ToString();
		car.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		car.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		car.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		car.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		car.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		car.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		car.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		car.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		car.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		car.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return car;
	}
	public List<Debts> GetListDebts(Int64 productionUnitID)
	{
		List<Debts> listDebts = new List<Debts>() { };
		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnitID)
		};

		//Lets get the list of Debts records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Debts_GetList_UseInProductionUnit", CommandType.StoredProcedure, parametersProductionUnit))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of debts
				listDebts = new List<Debts>();

				//Now lets populate the Debts details into the list of debtss
				foreach (DataRow row in table.Rows)
				{
					Debts debts = ConvertRowToDebts(row);
					listDebts.Add(debts);
				}
			}
		}

		return listDebts;
	}

	private Debts ConvertRowToDebts(DataRow row)
	{
		Debts debts = new Debts();
		debts.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		debts.DebtsTypeIDTitle = row["DebtsTypeIDTitle"].ToString();
		debts.DebtsTypeID = (row["DebtsTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DebtsTypeID"]) : 0 ;
		debts.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		debts.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
		debts.CreditorName = row["CreditorName"].ToString();
		debts.CreditorAddress = row["CreditorAddress"].ToString();
		debts.DebtResource = row["DebtResource"].ToString();

		debts.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		debts.StageTitle = row["StageTitle"].ToString();
		debts.RegisterDate = row["RegisterDate"].ToString();
		debts.OldRegisterDate = row["OldRegisterDate"].ToString();
		debts.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		debts.Sixth = row["Sixth"].ToString();
		debts.PreviousOwner = row["PreviousOwner"].ToString();
		debts.Comment = row["Comment"].ToString();
		debts.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		debts.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		debts.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		debts.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		debts.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		debts.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		debts.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		debts.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		debts.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		debts.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return debts;
	}
	public List<Demands> GetListDemands(Int64 productionUnitID)
	{
		List<Demands> listDemands = new List<Demands>() { };
		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnitID)
		};

		//Lets get the list of Demands records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Demands_GetList_UseInProductionUnit", CommandType.StoredProcedure, parametersProductionUnit))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of demands
				listDemands = new List<Demands>();

				//Now lets populate the Demands details into the list of demandss
				foreach (DataRow row in table.Rows)
				{
					Demands demands = ConvertRowToDemands(row);
					listDemands.Add(demands);
				}
			}
		}

		return listDemands;
	}

	private Demands ConvertRowToDemands(DataRow row)
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

		demands.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		demands.StageTitle = row["StageTitle"].ToString();
		demands.RegisterDate = row["RegisterDate"].ToString();
		demands.OldRegisterDate = row["OldRegisterDate"].ToString();
		demands.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		demands.Sixth = row["Sixth"].ToString();
		demands.PreviousOwner = row["PreviousOwner"].ToString();
		demands.Comment = row["Comment"].ToString();
		demands.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		demands.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		demands.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		demands.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		demands.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		demands.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		demands.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		demands.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		demands.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		demands.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return demands;
	}
	public List<Estate> GetListEstate(Int64 productionUnitID)
	{
		List<Estate> listEstate = new List<Estate>() { };
		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnitID)
		};

		//Lets get the list of Estate records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Estate_GetList_UseInProductionUnit", CommandType.StoredProcedure, parametersProductionUnit))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of estate
				listEstate = new List<Estate>();

				//Now lets populate the Estate details into the list of estates
				foreach (DataRow row in table.Rows)
				{
					Estate estate = ConvertRowToEstate(row);
					listEstate.Add(estate);
				}
			}
		}

		return listEstate;
	}

	private Estate ConvertRowToEstate(DataRow row)
	{
		Estate estate = new Estate();
		estate.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		estate.EstateTypeIDTitle = row["EstateTypeIDTitle"].ToString();
		estate.IndependentOf = row["IndependentOf"].ToString();
		estate.InquiryTo = row["InquiryTo"].ToString();
		estate.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
		estate.MainPlaqueNumber = row["MainPlaqueNumber"].ToString();
		estate.SubPlaqueNumber = row["SubPlaqueNumber"].ToString();
		estate.SectionPlaqueNumber = row["SectionPlaqueNumber"].ToString();
		estate.RegisterState = row["RegisterState"].ToString();
		estate.EstateTypeID = (row["EstateTypeID"] != DBNull.Value) ? Convert.ToInt32(row["EstateTypeID"]) : 0 ;
		estate.Water = (row["Water"] != DBNull.Value) ? Convert.ToInt32(row["Water"]) : 0 ;
		estate.Electric = (row["Electric"] != DBNull.Value) ? Convert.ToInt32(row["Electric"]) : 0 ;
		estate.Gass = (row["Gass"] != DBNull.Value) ? Convert.ToInt32(row["Gass"]) : 0 ;
		estate.Wastewater = (row["Wastewater"] != DBNull.Value) ? Convert.ToInt32(row["Wastewater"]) : 0 ;
		estate.GoodwillValue = (row["GoodwillValue"] != DBNull.Value) ? Convert.ToSingle(row["GoodwillValue"]) : 0 ;
		estate.Area1 = (row["Area1"] != DBNull.Value) ? Convert.ToSingle(row["Area1"]) : 0 ;
		estate.Area2 = (row["Area2"] != DBNull.Value) ? Convert.ToSingle(row["Area2"]) : 0 ;
		estate.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

		estate.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		estate.StageTitle = row["StageTitle"].ToString();
		estate.RegisterDate = row["RegisterDate"].ToString();
		estate.OldRegisterDate = row["OldRegisterDate"].ToString();
		estate.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		estate.Sixth = row["Sixth"].ToString();
		estate.PreviousOwner = row["PreviousOwner"].ToString();
		estate.Comment = row["Comment"].ToString();
		estate.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		estate.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		estate.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		estate.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		estate.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		estate.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		estate.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		estate.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		estate.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		estate.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return estate;
	}
	public List<FinancialRights> GetListFinancialRights(Int64 productionUnitID)
	{
		List<FinancialRights> listFinancialRights = new List<FinancialRights>() { };
		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnitID)
		};

		//Lets get the list of FinancialRights records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FinancialRights_GetList_UseInProductionUnit", CommandType.StoredProcedure, parametersProductionUnit))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of financialRights
				listFinancialRights = new List<FinancialRights>();

				//Now lets populate the FinancialRights details into the list of financialRightss
				foreach (DataRow row in table.Rows)
				{
					FinancialRights financialRights = ConvertRowToFinancialRights(row);
					listFinancialRights.Add(financialRights);
				}
			}
		}

		return listFinancialRights;
	}

	private FinancialRights ConvertRowToFinancialRights(DataRow row)
	{
		FinancialRights financialRights = new FinancialRights();
		financialRights.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		financialRights.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		financialRights.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
		financialRights.TitleAndDescription = row["TitleAndDescription"].ToString();

		financialRights.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		financialRights.StageTitle = row["StageTitle"].ToString();
		financialRights.RegisterDate = row["RegisterDate"].ToString();
		financialRights.OldRegisterDate = row["OldRegisterDate"].ToString();
		financialRights.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		financialRights.Sixth = row["Sixth"].ToString();
		financialRights.PreviousOwner = row["PreviousOwner"].ToString();
		financialRights.Comment = row["Comment"].ToString();
		financialRights.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		financialRights.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		financialRights.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		financialRights.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		financialRights.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		financialRights.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		financialRights.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		financialRights.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		financialRights.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		financialRights.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return financialRights;
	}
	public List<Machinery> GetListMachinery(Int64 productionUnitID)
	{
		List<Machinery> listMachinery = new List<Machinery>() { };
		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnitID)
		};

		//Lets get the list of Machinery records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Machinery_GetList_UseInProductionUnit", CommandType.StoredProcedure, parametersProductionUnit))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of machinery
				listMachinery = new List<Machinery>();

				//Now lets populate the Machinery details into the list of machinerys
				foreach (DataRow row in table.Rows)
				{
					Machinery machinery = ConvertRowToMachinery(row);
					listMachinery.Add(machinery);
				}
			}
		}

		return listMachinery;
	}

	private Machinery ConvertRowToMachinery(DataRow row)
	{
		Machinery machinery = new Machinery();
		machinery.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		machinery.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
		machinery.Name = row["Name"].ToString();
		machinery.Year = row["Year"].ToString();
		machinery.Country = row["Country"].ToString();
		machinery.Usage = row["Usage"].ToString();
		machinery.Number = row["Number"].ToString();
		machinery.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

		machinery.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		machinery.StageTitle = row["StageTitle"].ToString();
		machinery.RegisterDate = row["RegisterDate"].ToString();
		machinery.OldRegisterDate = row["OldRegisterDate"].ToString();
		machinery.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		machinery.Sixth = row["Sixth"].ToString();
		machinery.PreviousOwner = row["PreviousOwner"].ToString();
		machinery.Comment = row["Comment"].ToString();
		machinery.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		machinery.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		machinery.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		machinery.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		machinery.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		machinery.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		machinery.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		machinery.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		machinery.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		machinery.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return machinery;
	}
	public List<OtherProperties> GetListOtherProperties(Int64 productionUnitID)
	{
		List<OtherProperties> listOtherProperties = new List<OtherProperties>() { };
		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnitID)
		};

		//Lets get the list of OtherProperties records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("OtherProperties_GetList_UseInProductionUnit", CommandType.StoredProcedure, parametersProductionUnit))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of otherProperties
				listOtherProperties = new List<OtherProperties>();

				//Now lets populate the OtherProperties details into the list of otherPropertiess
				foreach (DataRow row in table.Rows)
				{
					OtherProperties otherProperties = ConvertRowToOtherProperties(row);
					listOtherProperties.Add(otherProperties);
				}
			}
		}

		return listOtherProperties;
	}

	private OtherProperties ConvertRowToOtherProperties(DataRow row)
	{
		OtherProperties otherProperties = new OtherProperties();
		otherProperties.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		otherProperties.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
		otherProperties.Name = row["Name"].ToString();
		otherProperties.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

		otherProperties.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		otherProperties.StageTitle = row["StageTitle"].ToString();
		otherProperties.RegisterDate = row["RegisterDate"].ToString();
		otherProperties.OldRegisterDate = row["OldRegisterDate"].ToString();
		otherProperties.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		otherProperties.Sixth = row["Sixth"].ToString();
		otherProperties.PreviousOwner = row["PreviousOwner"].ToString();
		otherProperties.Comment = row["Comment"].ToString();
		otherProperties.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		otherProperties.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		otherProperties.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		otherProperties.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		otherProperties.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		otherProperties.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		otherProperties.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		otherProperties.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		otherProperties.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		otherProperties.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return otherProperties;
	}
	public List<Permit> GetListPermit(Int64 productionUnitID)
	{
		List<Permit> listPermit = new List<Permit>() { };
		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnitID)
		};

		//Lets get the list of Permit records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Permit_GetList_UseInProductionUnit", CommandType.StoredProcedure, parametersProductionUnit))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of permit
				listPermit = new List<Permit>();

				//Now lets populate the Permit details into the list of permits
				foreach (DataRow row in table.Rows)
				{
					Permit permit = ConvertRowToPermit(row);
					listPermit.Add(permit);
				}
			}
		}

		return listPermit;
	}

	private Permit ConvertRowToPermit(DataRow row)
	{
		Permit permit = new Permit();
		permit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		permit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		permit.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
		permit.PermitName = row["PermitName"].ToString();
		permit.PermitReference = row["PermitReference"].ToString();
		permit.PermitNumber = row["PermitNumber"].ToString();
		permit.LocationAddress = row["LocationAddress"].ToString();
		permit.PermitDate = row["PermitDate"].ToString();

		permit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		permit.StageTitle = row["StageTitle"].ToString();
		permit.RegisterDate = row["RegisterDate"].ToString();
		permit.OldRegisterDate = row["OldRegisterDate"].ToString();
		permit.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		permit.Sixth = row["Sixth"].ToString();
		permit.PreviousOwner = row["PreviousOwner"].ToString();
		permit.Comment = row["Comment"].ToString();
		permit.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		permit.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		permit.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		permit.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		permit.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		permit.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		permit.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		permit.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		permit.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		permit.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return permit;
	}
	public List<Phone> GetListPhone(Int64 productionUnitID)
	{
		List<Phone> listPhone = new List<Phone>() { };
		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnitID)
		};

		//Lets get the list of Phone records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Phone_GetList_UseInProductionUnit", CommandType.StoredProcedure, parametersProductionUnit))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of phone
				listPhone = new List<Phone>();

				//Now lets populate the Phone details into the list of phones
				foreach (DataRow row in table.Rows)
				{
					Phone phone = ConvertRowToPhone(row);
					listPhone.Add(phone);
				}
			}
		}

		return listPhone;
	}

	private Phone ConvertRowToPhone(DataRow row)
	{
		Phone phone = new Phone();
		phone.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		phone.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		phone.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
		phone.Number = row["Number"].ToString();
		phone.City = row["City"].ToString();
		phone.Type = (row["Type"] != DBNull.Value) ? Convert.ToBoolean((row["Type"].ToString() == "1" || row["Type"].ToString().ToLower() == "true" ) ? true : false) : false ;

		phone.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		phone.StageTitle = row["StageTitle"].ToString();
		phone.RegisterDate = row["RegisterDate"].ToString();
		phone.OldRegisterDate = row["OldRegisterDate"].ToString();
		phone.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		phone.Sixth = row["Sixth"].ToString();
		phone.PreviousOwner = row["PreviousOwner"].ToString();
		phone.Comment = row["Comment"].ToString();
		phone.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		phone.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		phone.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		phone.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		phone.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		phone.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		phone.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		phone.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		phone.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		phone.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return phone;
	}
	public List<Score> GetListScore(Int64 productionUnitID)
	{
		List<Score> listScore = new List<Score>() { };
		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnitID)
		};

		//Lets get the list of Score records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Score_GetList_UseInProductionUnit", CommandType.StoredProcedure, parametersProductionUnit))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of score
				listScore = new List<Score>();

				//Now lets populate the Score details into the list of scores
				foreach (DataRow row in table.Rows)
				{
					Score score = ConvertRowToScore(row);
					listScore.Add(score);
				}
			}
		}

		return listScore;
	}

	private Score ConvertRowToScore(DataRow row)
	{
		Score score = new Score();
		score.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		score.ScoreTypeIDTitle = row["ScoreTypeIDTitle"].ToString();
		score.ScoreTypeID = (row["ScoreTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ScoreTypeID"]) : 0 ;
		score.Number = (row["Number"] != DBNull.Value) ? Convert.ToInt32(row["Number"]) : 0 ;
		score.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		score.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
		score.LicenseDate = row["LicenseDate"].ToString();
		score.Name = row["Name"].ToString();
		score.ProofReference = row["ProofReference"].ToString();
		score.LicenseNo = row["LicenseNo"].ToString();
		score.Address = row["Address"].ToString();
		score.PartialPlaque = row["PartialPlaque"].ToString();
		score.RegisterScope = row["RegisterScope"].ToString();
		score.Area = row["Area"].ToString();
		score.Balcony = row["Balcony"].ToString();
		score.BaseMent = row["BaseMent"].ToString();

		score.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		score.StageTitle = row["StageTitle"].ToString();
		score.RegisterDate = row["RegisterDate"].ToString();
		score.OldRegisterDate = row["OldRegisterDate"].ToString();
		score.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		score.Sixth = row["Sixth"].ToString();
		score.PreviousOwner = row["PreviousOwner"].ToString();
		score.Comment = row["Comment"].ToString();
		score.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		score.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		score.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		score.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		score.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		score.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		score.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		score.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		score.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		score.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return score;
	}
	public List<TransferRight> GetListTransferRight(Int64 productionUnitID)
	{
		List<TransferRight> listTransferRight = new List<TransferRight>() { };
		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnitID)
		};

		//Lets get the list of TransferRight records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("TransferRight_GetList_UseInProductionUnit", CommandType.StoredProcedure, parametersProductionUnit))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of transferRight
				listTransferRight = new List<TransferRight>();

				//Now lets populate the TransferRight details into the list of transferRights
				foreach (DataRow row in table.Rows)
				{
					TransferRight transferRight = ConvertRowToTransferRight(row);
					listTransferRight.Add(transferRight);
				}
			}
		}

		return listTransferRight;
	}

	private TransferRight ConvertRowToTransferRight(DataRow row)
	{
		TransferRight transferRight = new TransferRight();
		transferRight.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		transferRight.TransferRightTypeIDTitle = row["TransferRightTypeIDTitle"].ToString();
		transferRight.BalconyArea = row["BalconyArea"].ToString();
		transferRight.BalconyHeight = row["BalconyHeight"].ToString();
		transferRight.UndergroundArea = row["UndergroundArea"].ToString();
		transferRight.UndergroundHeight = row["UndergroundHeight"].ToString();
		transferRight.Adderss = row["Adderss"].ToString();
		transferRight.RegisterPart = row["RegisterPart"].ToString();
		transferRight.TransferRightTypeID = (row["TransferRightTypeID"] != DBNull.Value) ? Convert.ToInt32(row["TransferRightTypeID"]) : 0 ;
		transferRight.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		transferRight.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
		transferRight.Name = row["Name"].ToString();
		transferRight.ShopArea = row["ShopArea"].ToString();
		transferRight.ShopHeight = row["ShopHeight"].ToString();
		transferRight.Door = row["Door"].ToString();
		transferRight.DoorsNumber = row["DoorsNumber"].ToString();
		transferRight.DoorNumber = row["DoorNumber"].ToString();
		transferRight.RegisterPlague = row["RegisterPlague"].ToString();

		transferRight.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		transferRight.StageTitle = row["StageTitle"].ToString();
		transferRight.RegisterDate = row["RegisterDate"].ToString();
		transferRight.OldRegisterDate = row["OldRegisterDate"].ToString();
		transferRight.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		transferRight.Sixth = row["Sixth"].ToString();
		transferRight.PreviousOwner = row["PreviousOwner"].ToString();
		transferRight.Comment = row["Comment"].ToString();
		transferRight.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		transferRight.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		transferRight.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		transferRight.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		transferRight.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		transferRight.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		transferRight.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		transferRight.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		transferRight.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		transferRight.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return transferRight;
	}
	public List<Tree> GetListTree(Int64 productionUnitID)
	{
		List<Tree> listTree = new List<Tree>() { };
		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnitID)
		};

		//Lets get the list of Tree records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Tree_GetList_UseInProductionUnit", CommandType.StoredProcedure, parametersProductionUnit))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of tree
				listTree = new List<Tree>();

				//Now lets populate the Tree details into the list of trees
				foreach (DataRow row in table.Rows)
				{
					Tree tree = ConvertRowToTree(row);
					listTree.Add(tree);
				}
			}
		}

		return listTree;
	}

	private Tree ConvertRowToTree(DataRow row)
	{
		Tree tree = new Tree();
		tree.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		tree.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
		tree.TreeType = row["TreeType"].ToString();
		tree.RegisterPlaque = row["RegisterPlaque"].ToString();
		tree.DocNumber = row["DocNumber"].ToString();
		tree.Section = row["Section"].ToString();
		tree.TreeNumber = (row["TreeNumber"] != DBNull.Value) ? Convert.ToInt32(row["TreeNumber"]) : 0 ;
		tree.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

		tree.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		tree.StageTitle = row["StageTitle"].ToString();
		tree.RegisterDate = row["RegisterDate"].ToString();
		tree.OldRegisterDate = row["OldRegisterDate"].ToString();
		tree.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		tree.Sixth = row["Sixth"].ToString();
		tree.PreviousOwner = row["PreviousOwner"].ToString();
		tree.Comment = row["Comment"].ToString();
		tree.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		tree.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		tree.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		tree.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		tree.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		tree.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		tree.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		tree.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		tree.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		tree.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return tree;
	}
	public List<Well> GetListWell(Int64 productionUnitID)
	{
		List<Well> listWell = new List<Well>() { };
		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnitID)
		};

		//Lets get the list of Well records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Well_GetList_UseInProductionUnit", CommandType.StoredProcedure, parametersProductionUnit))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of well
				listWell = new List<Well>();

				//Now lets populate the Well details into the list of wells
				foreach (DataRow row in table.Rows)
				{
					Well well = ConvertRowToWell(row);
					listWell.Add(well);
				}
			}
		}

		return listWell;
	}

	private Well ConvertRowToWell(DataRow row)
	{
		Well well = new Well();
		well.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		well.WellTypeIDTitle = row["WellTypeIDTitle"].ToString();
		well.WellTypeID = (row["WellTypeID"] != DBNull.Value) ? Convert.ToInt32(row["WellTypeID"]) : 0 ;
		well.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		well.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
		well.Plaque = row["Plaque"].ToString();
		well.Scope = row["Scope"].ToString();
		well.DocNo = row["DocNo"].ToString();

		well.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		well.StageTitle = row["StageTitle"].ToString();
		well.RegisterDate = row["RegisterDate"].ToString();
		well.OldRegisterDate = row["OldRegisterDate"].ToString();
		well.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		well.Sixth = row["Sixth"].ToString();
		well.PreviousOwner = row["PreviousOwner"].ToString();
		well.Comment = row["Comment"].ToString();
		well.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		well.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		well.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		well.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		well.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		well.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		well.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		well.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		well.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		well.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return well;
	}
	public Int64 Insert(ProductionUnit productionUnit)
	{
		if (!heritageDBAccess.Exists(productionUnit))
			productionUnit.HeritageID = heritageDBAccess.Insert(productionUnit);

		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitTypeID", (productionUnit.ProductionUnitTypeID > 0) ? productionUnit.ProductionUnitTypeID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (productionUnit.DeclarationID > 0) ? productionUnit.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@HeritageID", (productionUnit.HeritageID > 0) ? productionUnit.HeritageID : (object)DBNull.Value),
			new SqlParameter("@DocumentDate", (productionUnit.DocumentDate != null) ? productionUnit.DocumentDate : (object)DBNull.Value),
			new SqlParameter("@UnitName", productionUnit.UnitName),
			new SqlParameter("@DocumentNumber", productionUnit.DocumentNumber)
		};
		productionUnit.ProductionUnitID = SqlDBHelper.ExecuteScalar("ProductionUnit_Insert", CommandType.StoredProcedure, parametersProductionUnit);
		return productionUnit.ProductionUnitID;
	}

	public bool Update(ProductionUnit productionUnit)
	{
		heritageDBAccess.Update(productionUnit);

		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnit.ProductionUnitID),
			new SqlParameter("@ProductionUnitTypeID", (productionUnit.ProductionUnitTypeID != null && productionUnit.ProductionUnitTypeID >0 ) ? productionUnit.ProductionUnitTypeID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", productionUnit.DeclarationID),
			new SqlParameter("@HeritageID", productionUnit.HeritageID),
			new SqlParameter("@DocumentDate", (productionUnit.DocumentDate != null) ? productionUnit.DocumentDate : (object)DBNull.Value),
			new SqlParameter("@UnitName", productionUnit.UnitName),
			new SqlParameter("@DocumentNumber", productionUnit.DocumentNumber)
		};
		return SqlDBHelper.ExecuteNonQuery("ProductionUnit_Update", CommandType.StoredProcedure, parametersProductionUnit);
	}

	public bool Delete(Int64 productionUnitID)
	{
		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnitID)
		};
		return SqlDBHelper.ExecuteNonQuery("ProductionUnit_Delete", CommandType.StoredProcedure, parametersProductionUnit);
	}

	public ProductionUnit GetDetails(Int64 productionUnitID)
	{
		ProductionUnit productionUnit = new ProductionUnit();

		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnitID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ProductionUnit_GetDetails", CommandType.StoredProcedure, parametersProductionUnit))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				productionUnit.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
				productionUnit.ProductionUnitTypeIDTitle = row["ProductionUnitTypeIDTitle"].ToString();
				productionUnit.ProductionUnitTypeID = (row["ProductionUnitTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ProductionUnitTypeID"]) : 0 ;
				productionUnit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				productionUnit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				productionUnit.DocumentDate = row["DocumentDate"].ToString();
				productionUnit.UnitName = row["UnitName"].ToString();
				productionUnit.DocumentNumber = row["DocumentNumber"].ToString();

				Heritage heritage = heritageDBAccess.GetDetails(productionUnit.HeritageID);
				productionUnit.HeritageID = heritage.HeritageID;
				productionUnit.StageTitle = heritage.StageTitle;
				productionUnit.RegisterDate = heritage.RegisterDate;
				productionUnit.OldRegisterDate = heritage.OldRegisterDate;
				productionUnit.OldRegisterInformationID = heritage.OldRegisterInformationID;
				productionUnit.Sixth = heritage.Sixth;
				productionUnit.PreviousOwner = heritage.PreviousOwner;
				productionUnit.Comment = heritage.Comment;
				productionUnit.RegisterInformationID = heritage.RegisterInformationID;
				productionUnit.AdjustmentID = heritage.AdjustmentID;
				productionUnit.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				productionUnit.Stage = heritage.Stage;
				productionUnit.UserOrder = heritage.UserOrder;
				productionUnit.Value1 = heritage.Value1;
				productionUnit.Value2 = heritage.Value2;
				productionUnit.Value3 = heritage.Value3;
				productionUnit.DeadIsOwner = heritage.DeadIsOwner;
				productionUnit.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return productionUnit;
	}

	public List<ProductionUnit> GetListAll()
	{
		List<ProductionUnit> listProductionUnit = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("ProductionUnit_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listProductionUnit = new List<ProductionUnit>();

				foreach (DataRow row in table.Rows)
				{
					ProductionUnit productionUnit = new ProductionUnit();
					productionUnit.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					productionUnit.ProductionUnitTypeIDTitle = row["ProductionUnitTypeIDTitle"].ToString();
					productionUnit.ProductionUnitTypeID = (row["ProductionUnitTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ProductionUnitTypeID"]) : 0 ;
					productionUnit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					productionUnit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					productionUnit.DocumentDate = row["DocumentDate"].ToString();
					productionUnit.UnitName = row["UnitName"].ToString();
					productionUnit.DocumentNumber = row["DocumentNumber"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(productionUnit.HeritageID);
					productionUnit.StageTitle = heritage.StageTitle;
					productionUnit.RegisterDate = heritage.RegisterDate;
					productionUnit.OldRegisterDate = heritage.OldRegisterDate;
					productionUnit.OldRegisterInformationID = heritage.OldRegisterInformationID;
					productionUnit.Sixth = heritage.Sixth;
					productionUnit.PreviousOwner = heritage.PreviousOwner;
					productionUnit.Comment = heritage.Comment;
					productionUnit.RegisterInformationID = heritage.RegisterInformationID;
					productionUnit.AdjustmentID = heritage.AdjustmentID;
					productionUnit.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					productionUnit.Stage = heritage.Stage;
					productionUnit.UserOrder = heritage.UserOrder;
					productionUnit.Value1 = heritage.Value1;
					productionUnit.Value2 = heritage.Value2;
					productionUnit.Value3 = heritage.Value3;
					productionUnit.DeadIsOwner = heritage.DeadIsOwner;
					productionUnit.IsDiagonesed = heritage.IsDiagonesed;
					listProductionUnit.Add(productionUnit);
				}
			}
		}

		return listProductionUnit;
	}

	public bool Exists(Int64 productionUnitID)
	{
		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnitID)
		};
		return (SqlDBHelper.ExecuteScalar("ProductionUnit_Exists", CommandType.StoredProcedure, parametersProductionUnit)>0);
	}

	public bool Exists(ProductionUnit productionUnit)
	{
		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnit.ProductionUnitID)
		};
		return (SqlDBHelper.ExecuteScalar("ProductionUnit_Exists", CommandType.StoredProcedure, parametersProductionUnit)>0);
	}

	public List<ProductionUnit> SearchLike(ProductionUnit productionUnit)
	{
		List<ProductionUnit> listProductionUnit = new List<ProductionUnit>();


		SqlParameter[] parametersProductionUnit = new SqlParameter[]
		{
			new SqlParameter("@ProductionUnitID", productionUnit.ProductionUnitID),
			new SqlParameter("@ProductionUnitTypeIDTitle", productionUnit.ProductionUnitTypeIDTitle),
			new SqlParameter("@ProductionUnitTypeID", productionUnit.ProductionUnitTypeID),
			new SqlParameter("@DeclarationID", productionUnit.DeclarationID),
			new SqlParameter("@HeritageID", productionUnit.HeritageID),
			new SqlParameter("@DocumentDate", productionUnit.DocumentDate),
			new SqlParameter("@UnitName", productionUnit.UnitName),
			new SqlParameter("@DocumentNumber", productionUnit.DocumentNumber),

			new SqlParameter("@StageTitle", productionUnit.StageTitle),
			new SqlParameter("@RegisterDate", productionUnit.RegisterDate),
			new SqlParameter("@OldRegisterDate", productionUnit.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", productionUnit.OldRegisterInformationID),
			new SqlParameter("@Sixth", productionUnit.Sixth),
			new SqlParameter("@PreviousOwner", productionUnit.PreviousOwner),
			new SqlParameter("@Comment", productionUnit.Comment),
			new SqlParameter("@RegisterInformationID", productionUnit.RegisterInformationID),
			new SqlParameter("@AdjustmentID", productionUnit.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", productionUnit.CommissionAdjustmentID),
			new SqlParameter("@Stage", productionUnit.Stage),
			new SqlParameter("@UserOrder", productionUnit.UserOrder),
			new SqlParameter("@Value1", productionUnit.Value1),
			new SqlParameter("@Value2", productionUnit.Value2),
			new SqlParameter("@Value3", productionUnit.Value3),
			new SqlParameter("@DeadIsOwner", productionUnit.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", productionUnit.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ProductionUnit_SearchLike", CommandType.StoredProcedure, parametersProductionUnit))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					ProductionUnit tmpProductionUnit = new ProductionUnit();
					tmpProductionUnit.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					tmpProductionUnit.ProductionUnitTypeIDTitle = row["ProductionUnitTypeIDTitle"].ToString();
					tmpProductionUnit.ProductionUnitTypeID = (row["ProductionUnitTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ProductionUnitTypeID"]) : 0 ;
					tmpProductionUnit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpProductionUnit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpProductionUnit.DocumentDate = row["DocumentDate"].ToString();
					tmpProductionUnit.UnitName = row["UnitName"].ToString();
					tmpProductionUnit.DocumentNumber = row["DocumentNumber"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(tmpProductionUnit.HeritageID);
					tmpProductionUnit.HeritageID = heritage.HeritageID;
					tmpProductionUnit.StageTitle = heritage.StageTitle;
					tmpProductionUnit.RegisterDate = heritage.RegisterDate;
					tmpProductionUnit.OldRegisterDate = heritage.OldRegisterDate;
					tmpProductionUnit.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpProductionUnit.Sixth = heritage.Sixth;
					tmpProductionUnit.PreviousOwner = heritage.PreviousOwner;
					tmpProductionUnit.Comment = heritage.Comment;
					tmpProductionUnit.RegisterInformationID = heritage.RegisterInformationID;
					tmpProductionUnit.AdjustmentID = heritage.AdjustmentID;
					tmpProductionUnit.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpProductionUnit.Stage = heritage.Stage;
					tmpProductionUnit.UserOrder = heritage.UserOrder;
					tmpProductionUnit.Value1 = heritage.Value1;
					tmpProductionUnit.Value2 = heritage.Value2;
					tmpProductionUnit.Value3 = heritage.Value3;
					tmpProductionUnit.DeadIsOwner = heritage.DeadIsOwner;
					tmpProductionUnit.IsDiagonesed = heritage.IsDiagonesed;

					listProductionUnit.Add(tmpProductionUnit);
				}
			}
		}

		return listProductionUnit;
	}

}
}
