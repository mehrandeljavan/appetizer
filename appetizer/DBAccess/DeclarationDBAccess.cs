using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class DeclarationDBAccess
{

	ApplicantDBAccess applicantDBAccess = new ApplicantDBAccess();
	BankDepositDBAccess bankDepositDBAccess = new BankDepositDBAccess();
	BankDepositProfitDBAccess bankDepositProfitDBAccess = new BankDepositProfitDBAccess();
	BourseStockDBAccess bourseStockDBAccess = new BourseStockDBAccess();
	CapitalAndCommodityDepositDBAccess capitalAndCommodityDepositDBAccess = new CapitalAndCommodityDepositDBAccess();
	CarDBAccess carDBAccess = new CarDBAccess();
	CommissionInvitationDBAccess commissionInvitationDBAccess = new CommissionInvitationDBAccess();
	CostDBAccess costDBAccess = new CostDBAccess();
	DebtsDBAccess debtsDBAccess = new DebtsDBAccess();
	DemandsDBAccess demandsDBAccess = new DemandsDBAccess();
	DowryDBAccess dowryDBAccess = new DowryDBAccess();
	EstateDBAccess estateDBAccess = new EstateDBAccess();
	FinancialRightsDBAccess financialRightsDBAccess = new FinancialRightsDBAccess();
	Form19DBAccess form19DBAccess = new Form19DBAccess();
	FormCommissionInvitationDBAccess formCommissionInvitationDBAccess = new FormCommissionInvitationDBAccess();
	FormDeclarationDeliveryDBAccess formDeclarationDeliveryDBAccess = new FormDeclarationDeliveryDBAccess();
	FormDeclarationInputInfoDBAccess formDeclarationInputInfoDBAccess = new FormDeclarationInputInfoDBAccess();
	FormDeterministicPaperDBAccess formDeterministicPaperDBAccess = new FormDeterministicPaperDBAccess();
	FormDiagnosisPaperDBAccess formDiagnosisPaperDBAccess = new FormDiagnosisPaperDBAccess();
	FormDiagnosisResultDBAccess formDiagnosisResultDBAccess = new FormDiagnosisResultDBAccess();
	FormFreedomDBAccess formFreedomDBAccess = new FormFreedomDBAccess();
	FormHeritageBillDBAccess formHeritageBillDBAccess = new FormHeritageBillDBAccess();
	FormHeritageEvaluationDBAccess formHeritageEvaluationDBAccess = new FormHeritageEvaluationDBAccess();
	FormHeritageListDBAccess formHeritageListDBAccess = new FormHeritageListDBAccess();
	FormHeritagesDescriptionsDBAccess formHeritagesDescriptionsDBAccess = new FormHeritagesDescriptionsDBAccess();
	FormInquiryBankDepositDBAccess formInquiryBankDepositDBAccess = new FormInquiryBankDepositDBAccess();
	FormInquiryCompanyDBAccess formInquiryCompanyDBAccess = new FormInquiryCompanyDBAccess();
	FormInquiryEstateDBAccess formInquiryEstateDBAccess = new FormInquiryEstateDBAccess();
	FormInquiryGoodWillEvaluationDBAccess formInquiryGoodWillEvaluationDBAccess = new FormInquiryGoodWillEvaluationDBAccess();
	FormInquiryGoodWillScoreDBAccess formInquiryGoodWillScoreDBAccess = new FormInquiryGoodWillScoreDBAccess();
	FormInquiryOtherDBAccess formInquiryOtherDBAccess = new FormInquiryOtherDBAccess();
	FormInquiryTransferRightEvaluationDBAccess formInquiryTransferRightEvaluationDBAccess = new FormInquiryTransferRightEvaluationDBAccess();
	FormInquiryTransferRightScoreDBAccess formInquiryTransferRightScoreDBAccess = new FormInquiryTransferRightScoreDBAccess();
	FormTaxBillDBAccess formTaxBillDBAccess = new FormTaxBillDBAccess();
	FormTaxPaymentCertificateDBAccess formTaxPaymentCertificateDBAccess = new FormTaxPaymentCertificateDBAccess();
	HajjDBAccess hajjDBAccess = new HajjDBAccess();
	HeirDBAccess heirDBAccess = new HeirDBAccess();
	HeirNumberDBAccess heirNumberDBAccess = new HeirNumberDBAccess();
	HomeFurnishingsDBAccess homeFurnishingsDBAccess = new HomeFurnishingsDBAccess();
	InquiryResponseDBAccess inquiryResponseDBAccess = new InquiryResponseDBAccess();
	JewelDBAccess jewelDBAccess = new JewelDBAccess();
	JusticeSharesDBAccess justiceSharesDBAccess = new JusticeSharesDBAccess();
	MachineryDBAccess machineryDBAccess = new MachineryDBAccess();
	OtherDeductionsDBAccess otherDeductionsDBAccess = new OtherDeductionsDBAccess();
	OtherPropertiesDBAccess otherPropertiesDBAccess = new OtherPropertiesDBAccess();
	PartnershipPapersDBAccess partnershipPapersDBAccess = new PartnershipPapersDBAccess();
	PermitDBAccess permitDBAccess = new PermitDBAccess();
	PhoneDBAccess phoneDBAccess = new PhoneDBAccess();
	ProductionUnitDBAccess productionUnitDBAccess = new ProductionUnitDBAccess();
	PropertiesNumberDBAccess propertiesNumberDBAccess = new PropertiesNumberDBAccess();
	ReDiagnosisRequestDBAccess reDiagnosisRequestDBAccess = new ReDiagnosisRequestDBAccess();
	ReligiousDebtDBAccess religiousDebtDBAccess = new ReligiousDebtDBAccess();
	RequestDBAccess requestDBAccess = new RequestDBAccess();
	SafeBoxDBAccess safeBoxDBAccess = new SafeBoxDBAccess();
	ScoreDBAccess scoreDBAccess = new ScoreDBAccess();
	StockInOtherCompaniesDBAccess stockInOtherCompaniesDBAccess = new StockInOtherCompaniesDBAccess();
	StockProfitDBAccess stockProfitDBAccess = new StockProfitDBAccess();
	TransferRightDBAccess transferRightDBAccess = new TransferRightDBAccess();
	TreeDBAccess treeDBAccess = new TreeDBAccess();
	UttererDBAccess uttererDBAccess = new UttererDBAccess();
	WellDBAccess wellDBAccess = new WellDBAccess();
	WillDBAccess willDBAccess = new WillDBAccess();

	public List<Applicant> GetListApplicant(Int64 declarationID)
	{
		List<Applicant> listApplicant = new List<Applicant>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of Applicant records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Applicant_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of applicant
				listApplicant = new List<Applicant>();

				//Now lets populate the Applicant details into the list of applicants
				foreach (DataRow row in table.Rows)
				{
					Applicant applicant = ConvertRowToApplicant(row);
					listApplicant.Add(applicant);
				}
			}
		}

		return listApplicant;
	}

	private Applicant ConvertRowToApplicant(DataRow row)
	{
		Applicant applicant = new Applicant();
		applicant.ApplicantID = (row["ApplicantID"] != DBNull.Value) ? Convert.ToInt64(row["ApplicantID"]) : 0 ;
		applicant.ApplicantRoleIDTitle = row["ApplicantRoleIDTitle"].ToString();
		applicant.RequestTypeIDTitle = row["RequestTypeIDTitle"].ToString();
		applicant.RegisterDate = row["RegisterDate"].ToString();
		applicant.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		applicant.OldRegisterDate = row["OldRegisterDate"].ToString();
		applicant.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		applicant.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		applicant.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		applicant.ApplicantRoleID = (row["ApplicantRoleID"] != DBNull.Value) ? Convert.ToInt32(row["ApplicantRoleID"]) : 0 ;
		applicant.RequestTypeID = (row["RequestTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RequestTypeID"]) : 0 ;

		applicant.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		applicant.PrintNationalCode = row["PrintNationalCode"].ToString();
		applicant.FullName = row["FullName"].ToString();
		applicant.GenderIDTitle = row["GenderIDTitle"].ToString();
		applicant.Religion_DinIDTitle = row["Religion_DinIDTitle"].ToString();
		applicant.Religion_MazhabIDTitle = row["Religion_MazhabIDTitle"].ToString();
		applicant.IssuanceProvinceIDTitle = row["IssuanceProvinceIDTitle"].ToString();
		applicant.IssuanceCityIDTitle = row["IssuanceCityIDTitle"].ToString();
		applicant.IssuanceDepartment = row["IssuanceDepartment"].ToString();
		applicant.CertificateNumber = row["CertificateNumber"].ToString();
		applicant.CertificateSerial = row["CertificateSerial"].ToString();
		applicant.ZipCode = row["ZipCode"].ToString();
		applicant.HomeAddress = row["HomeAddress"].ToString();
		applicant.PhoneNumber = row["PhoneNumber"].ToString();
		applicant.Job = row["Job"].ToString();
		applicant.JobAddress = row["JobAddress"].ToString();
		applicant.JobPhoneNumber = row["JobPhoneNumber"].ToString();
		applicant.Comment = row["Comment"].ToString();
		applicant.BirthCity = row["BirthCity"].ToString();
		applicant.JobZipCode = row["JobZipCode"].ToString();
		applicant.CertificateSerialLetter = row["CertificateSerialLetter"].ToString();
		applicant.CertificateSerialNumber = row["CertificateSerialNumber"].ToString();
		applicant.FatherName = row["FatherName"].ToString();
		applicant.Name = row["Name"].ToString();
		applicant.Family = row["Family"].ToString();
		applicant.BirthDate = row["BirthDate"].ToString();
		applicant.IssuanceDate = row["IssuanceDate"].ToString();
		applicant.GenderID = (row["GenderID"] != DBNull.Value) ? Convert.ToInt32(row["GenderID"]) : 0 ;
		applicant.IssuanceProvinceID = (row["IssuanceProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceProvinceID"]) : 0 ;
		applicant.IssuanceCityID = (row["IssuanceCityID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceCityID"]) : 0 ;
		applicant.Religion_DinID = (row["Religion_DinID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_DinID"]) : 0 ;
		applicant.Religion_MazhabID = (row["Religion_MazhabID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_MazhabID"]) : 0 ;
		return applicant;
	}
	public List<BankDeposit> GetListBankDeposit(Int64 declarationID)
	{
		List<BankDeposit> listBankDeposit = new List<BankDeposit>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of BankDeposit records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BankDeposit_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of bankDeposit
				listBankDeposit = new List<BankDeposit>();

				//Now lets populate the BankDeposit details into the list of bankDeposits
				foreach (DataRow row in table.Rows)
				{
					BankDeposit bankDeposit = ConvertRowToBankDeposit(row);
					listBankDeposit.Add(bankDeposit);
				}
			}
		}

		return listBankDeposit;
	}

	private BankDeposit ConvertRowToBankDeposit(DataRow row)
	{
		BankDeposit bankDeposit = new BankDeposit();
		bankDeposit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		bankDeposit.BankIDTitle = row["BankIDTitle"].ToString();
		bankDeposit.BankAccountTypeIDTitle = row["BankAccountTypeIDTitle"].ToString();
		bankDeposit.BankCategoryIDTitle = row["BankCategoryIDTitle"].ToString();
		bankDeposit.BankTypeIDTitle = row["BankTypeIDTitle"].ToString();
		bankDeposit.BankCategoryID = (row["BankCategoryID"] != DBNull.Value) ? Convert.ToInt64(row["BankCategoryID"]) : 0 ;
		bankDeposit.BankTypeID = (row["BankTypeID"] != DBNull.Value) ? Convert.ToInt64(row["BankTypeID"]) : 0 ;
		bankDeposit.Branch = row["Branch"].ToString();
		bankDeposit.City = row["City"].ToString();
		bankDeposit.AccountNumber = row["AccountNumber"].ToString();
		bankDeposit.BankAccountTypeID = (row["BankAccountTypeID"] != DBNull.Value) ? Convert.ToInt32(row["BankAccountTypeID"]) : 0 ;
		bankDeposit.CurrencyDeposit = (row["CurrencyDeposit"] != DBNull.Value) ? Convert.ToSingle(row["CurrencyDeposit"]) : 0 ;
		bankDeposit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		bankDeposit.BankID = (row["BankID"] != DBNull.Value) ? Convert.ToInt64(row["BankID"]) : 0 ;

		bankDeposit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		bankDeposit.StageTitle = row["StageTitle"].ToString();
		bankDeposit.RegisterDate = row["RegisterDate"].ToString();
		bankDeposit.OldRegisterDate = row["OldRegisterDate"].ToString();
		bankDeposit.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		bankDeposit.Sixth = row["Sixth"].ToString();
		bankDeposit.PreviousOwner = row["PreviousOwner"].ToString();
		bankDeposit.Comment = row["Comment"].ToString();
		bankDeposit.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		bankDeposit.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		bankDeposit.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		bankDeposit.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		bankDeposit.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		bankDeposit.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		bankDeposit.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		bankDeposit.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		bankDeposit.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		bankDeposit.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return bankDeposit;
	}
	public List<BankDepositProfit> GetListBankDepositProfit(Int64 declarationID)
	{
		List<BankDepositProfit> listBankDepositProfit = new List<BankDepositProfit>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of BankDepositProfit records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BankDepositProfit_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of bankDepositProfit
				listBankDepositProfit = new List<BankDepositProfit>();

				//Now lets populate the BankDepositProfit details into the list of bankDepositProfits
				foreach (DataRow row in table.Rows)
				{
					BankDepositProfit bankDepositProfit = ConvertRowToBankDepositProfit(row);
					listBankDepositProfit.Add(bankDepositProfit);
				}
			}
		}

		return listBankDepositProfit;
	}

	private BankDepositProfit ConvertRowToBankDepositProfit(DataRow row)
	{
		BankDepositProfit bankDepositProfit = new BankDepositProfit();
		bankDepositProfit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		bankDepositProfit.BankIDTitle = row["BankIDTitle"].ToString();
		bankDepositProfit.BankAccountTypeIDTitle = row["BankAccountTypeIDTitle"].ToString();
		bankDepositProfit.BankCategoryIDTitle = row["BankCategoryIDTitle"].ToString();
		bankDepositProfit.BankTypeIDTitle = row["BankTypeIDTitle"].ToString();
		bankDepositProfit.BankCategoryID = (row["BankCategoryID"] != DBNull.Value) ? Convert.ToInt64(row["BankCategoryID"]) : 0 ;
		bankDepositProfit.BankTypeID = (row["BankTypeID"] != DBNull.Value) ? Convert.ToInt64(row["BankTypeID"]) : 0 ;
		bankDepositProfit.Branch = row["Branch"].ToString();
		bankDepositProfit.City = row["City"].ToString();
		bankDepositProfit.AccountNumber = row["AccountNumber"].ToString();
		bankDepositProfit.BankAccountTypeID = (row["BankAccountTypeID"] != DBNull.Value) ? Convert.ToInt32(row["BankAccountTypeID"]) : 0 ;
		bankDepositProfit.CurrencyDeposit = (row["CurrencyDeposit"] != DBNull.Value) ? Convert.ToSingle(row["CurrencyDeposit"]) : 0 ;
		bankDepositProfit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		bankDepositProfit.BankID = (row["BankID"] != DBNull.Value) ? Convert.ToInt64(row["BankID"]) : 0 ;

		bankDepositProfit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		bankDepositProfit.StageTitle = row["StageTitle"].ToString();
		bankDepositProfit.RegisterDate = row["RegisterDate"].ToString();
		bankDepositProfit.OldRegisterDate = row["OldRegisterDate"].ToString();
		bankDepositProfit.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		bankDepositProfit.Sixth = row["Sixth"].ToString();
		bankDepositProfit.PreviousOwner = row["PreviousOwner"].ToString();
		bankDepositProfit.Comment = row["Comment"].ToString();
		bankDepositProfit.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		bankDepositProfit.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		bankDepositProfit.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		bankDepositProfit.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		bankDepositProfit.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		bankDepositProfit.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		bankDepositProfit.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		bankDepositProfit.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		bankDepositProfit.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		bankDepositProfit.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return bankDepositProfit;
	}
	public List<BourseStock> GetListBourseStock(Int64 declarationID)
	{
		List<BourseStock> listBourseStock = new List<BourseStock>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of BourseStock records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BourseStock_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of bourseStock
				listBourseStock = new List<BourseStock>();

				//Now lets populate the BourseStock details into the list of bourseStocks
				foreach (DataRow row in table.Rows)
				{
					BourseStock bourseStock = ConvertRowToBourseStock(row);
					listBourseStock.Add(bourseStock);
				}
			}
		}

		return listBourseStock;
	}

	private BourseStock ConvertRowToBourseStock(DataRow row)
	{
		BourseStock bourseStock = new BourseStock();
		bourseStock.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		bourseStock.Hall = row["Hall"].ToString();
		bourseStock.Seller = row["Seller"].ToString();
		bourseStock.SheetNumber = row["SheetNumber"].ToString();
		bourseStock.StockNumber = row["StockNumber"].ToString();
		bourseStock.StockValue = (row["StockValue"] != DBNull.Value) ? Convert.ToSingle(row["StockValue"]) : 0 ;
		bourseStock.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

		bourseStock.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		bourseStock.StageTitle = row["StageTitle"].ToString();
		bourseStock.RegisterDate = row["RegisterDate"].ToString();
		bourseStock.OldRegisterDate = row["OldRegisterDate"].ToString();
		bourseStock.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		bourseStock.Sixth = row["Sixth"].ToString();
		bourseStock.PreviousOwner = row["PreviousOwner"].ToString();
		bourseStock.Comment = row["Comment"].ToString();
		bourseStock.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		bourseStock.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		bourseStock.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		bourseStock.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		bourseStock.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		bourseStock.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		bourseStock.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		bourseStock.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		bourseStock.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		bourseStock.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return bourseStock;
	}
	public List<CapitalAndCommodityDeposit> GetListCapitalAndCommodityDeposit(Int64 declarationID)
	{
		List<CapitalAndCommodityDeposit> listCapitalAndCommodityDeposit = new List<CapitalAndCommodityDeposit>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of CapitalAndCommodityDeposit records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CapitalAndCommodityDeposit_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
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
	public List<Car> GetListCar(Int64 declarationID)
	{
		List<Car> listCar = new List<Car>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of Car records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Car_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
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
	public List<CommissionInvitation> GetListCommissionInvitation(Int64 declarationID)
	{
		List<CommissionInvitation> listCommissionInvitation = new List<CommissionInvitation>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of CommissionInvitation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionInvitation_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of commissionInvitation
				listCommissionInvitation = new List<CommissionInvitation>();

				//Now lets populate the CommissionInvitation details into the list of commissionInvitations
				foreach (DataRow row in table.Rows)
				{
					CommissionInvitation commissionInvitation = ConvertRowToCommissionInvitation(row);
					listCommissionInvitation.Add(commissionInvitation);
				}
			}
		}

		return listCommissionInvitation;
	}

	private CommissionInvitation ConvertRowToCommissionInvitation(DataRow row)
	{
		CommissionInvitation commissionInvitation = new CommissionInvitation();
		commissionInvitation.CommissionInvitationID = (row["CommissionInvitationID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionInvitationID"]) : 0 ;
		commissionInvitation.InvitationTypeIDTitle = row["InvitationTypeIDTitle"].ToString();
		commissionInvitation.CommissionTypeIDTitle = row["CommissionTypeIDTitle"].ToString();
		commissionInvitation.CommissionDayIDTitle = row["CommissionDayIDTitle"].ToString();
		commissionInvitation.InvitationTypeID = (row["InvitationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["InvitationTypeID"]) : 0 ;
		commissionInvitation.CommissionTypeID = (row["CommissionTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionTypeID"]) : 0 ;
		commissionInvitation.CommissionDayID = (row["CommissionDayID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionDayID"]) : 0 ;
		commissionInvitation.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
		commissionInvitation.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		commissionInvitation.CommissionHour = row["CommissionHour"].ToString();
		commissionInvitation.CommssionDate = row["CommssionDate"].ToString();
		commissionInvitation.CommissionAddress = row["CommissionAddress"].ToString();
		return commissionInvitation;
	}
	public List<Cost> GetListCost(Int64 declarationID)
	{
		List<Cost> listCost = new List<Cost>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of Cost records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Cost_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
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
	public List<Debts> GetListDebts(Int64 declarationID)
	{
		List<Debts> listDebts = new List<Debts>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of Debts records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Debts_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
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
	public List<Demands> GetListDemands(Int64 declarationID)
	{
		List<Demands> listDemands = new List<Demands>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of Demands records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Demands_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
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
	public List<Dowry> GetListDowry(Int64 declarationID)
	{
		List<Dowry> listDowry = new List<Dowry>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of Dowry records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Dowry_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of dowry
				listDowry = new List<Dowry>();

				//Now lets populate the Dowry details into the list of dowrys
				foreach (DataRow row in table.Rows)
				{
					Dowry dowry = ConvertRowToDowry(row);
					listDowry.Add(dowry);
				}
			}
		}

		return listDowry;
	}

	private Dowry ConvertRowToDowry(DataRow row)
	{
		Dowry dowry = new Dowry();
		dowry.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		dowry.WeddingYearTitle = row["WeddingYearTitle"].ToString();
		dowry.ValueInCentralBank = (row["ValueInCentralBank"] != DBNull.Value) ? Convert.ToSingle(row["ValueInCentralBank"]) : 0 ;
		dowry.NonCashValue = (row["NonCashValue"] != DBNull.Value) ? Convert.ToSingle(row["NonCashValue"]) : 0 ;
		dowry.Alimony = (row["Alimony"] != DBNull.Value) ? Convert.ToSingle(row["Alimony"]) : 0 ;
		dowry.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		dowry.WeddingYear = (row["WeddingYear"] != DBNull.Value) ? Convert.ToInt32(row["WeddingYear"]) : 0 ;
		dowry.Amount = (row["Amount"] != DBNull.Value) ? Convert.ToSingle(row["Amount"]) : 0 ;

		dowry.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		dowry.StageTitle = row["StageTitle"].ToString();
		dowry.RegisterDate = row["RegisterDate"].ToString();
		dowry.OldRegisterDate = row["OldRegisterDate"].ToString();
		dowry.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		dowry.Sixth = row["Sixth"].ToString();
		dowry.PreviousOwner = row["PreviousOwner"].ToString();
		dowry.Comment = row["Comment"].ToString();
		dowry.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		dowry.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		dowry.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		dowry.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		dowry.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		dowry.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		dowry.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		dowry.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		dowry.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		dowry.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return dowry;
	}
	public List<Estate> GetListEstate(Int64 declarationID)
	{
		List<Estate> listEstate = new List<Estate>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of Estate records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Estate_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
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
	public List<FinancialRights> GetListFinancialRights(Int64 declarationID)
	{
		List<FinancialRights> listFinancialRights = new List<FinancialRights>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of FinancialRights records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FinancialRights_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
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
	public List<Form19> GetListForm19(Int64 declarationID)
	{
		List<Form19> listForm19 = new List<Form19>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@Form19DeclarationID", declarationID)
		};

		//Lets get the list of Form19 records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Form19_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of form19
				listForm19 = new List<Form19>();

				//Now lets populate the Form19 details into the list of form19s
				foreach (DataRow row in table.Rows)
				{
					Form19 form19 = ConvertRowToForm19(row);
					listForm19.Add(form19);
				}
			}
		}

		return listForm19;
	}

	private Form19 ConvertRowToForm19(DataRow row)
	{
		Form19 form19 = new Form19();
		form19.Form19ID = (row["Form19ID"] != DBNull.Value) ? Convert.ToInt64(row["Form19ID"]) : 0 ;
		form19.Form19PrintRegisterInformationID = row["Form19PrintRegisterInformationID"].ToString();
		form19.Form19PrintRegisterDate = row["Form19PrintRegisterDate"].ToString();
		form19.Form19RequestNumber = row["Form19RequestNumber"].ToString();
		form19.Form19RequestFullName = row["Form19RequestFullName"].ToString();
		form19.Form19HeirFullName = row["Form19HeirFullName"].ToString();
		form19.Form19TaxUnitCode = row["Form19TaxUnitCode"].ToString();
		form19.Form19TaxUnitUserFullName = row["Form19TaxUnitUserFullName"].ToString();
		form19.Form19TaxGroupCode = row["Form19TaxGroupCode"].ToString();
		form19.Form19DeadIssuanceCity = row["Form19DeadIssuanceCity"].ToString();
		form19.Form19DeadDeathCity = row["Form19DeadDeathCity"].ToString();
		form19.Form19Comment1 = row["Form19Comment1"].ToString();
		form19.Form19Comment2 = row["Form19Comment2"].ToString();
		form19.Form19Comment3 = row["Form19Comment3"].ToString();
		form19.Form19HeritagesDescription = row["Form19HeritagesDescription"].ToString();
		form19.Form19RequestFamily = row["Form19RequestFamily"].ToString();
		form19.Form19RequestCertificateNumber = row["Form19RequestCertificateNumber"].ToString();
		form19.Form19RequestIssuanceCity = row["Form19RequestIssuanceCity"].ToString();
		form19.Form19DeadName = row["Form19DeadName"].ToString();
		form19.Form19DeadFamily = row["Form19DeadFamily"].ToString();
		form19.Form19DeadCertificateNumber = row["Form19DeadCertificateNumber"].ToString();
		form19.Form19RegisterInformationID = (row["Form19RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["Form19RegisterInformationID"]) : 0 ;
		form19.Form19RequestNationalCode = (row["Form19RequestNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["Form19RequestNationalCode"]) : 0 ;
		form19.Form19RegisterarUserNationalCode = (row["Form19RegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["Form19RegisterarUserNationalCode"]) : 0 ;
		form19.Form19DeclarationID = (row["Form19DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["Form19DeclarationID"]) : 0 ;
		form19.Form19DeadNationalCode = (row["Form19DeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["Form19DeadNationalCode"]) : 0 ;
		form19.Form19RegisterInformationDate = row["Form19RegisterInformationDate"].ToString();
		form19.Form19DeadDeathDate = row["Form19DeadDeathDate"].ToString();
		form19.Form19RequestDate = row["Form19RequestDate"].ToString();
		form19.Form19DossierClasses = row["Form19DossierClasses"].ToString();
		form19.Form19TaxOfficeProvince = row["Form19TaxOfficeProvince"].ToString();
		form19.Form19TaxOfficeCity = row["Form19TaxOfficeCity"].ToString();
		form19.Form19TaxOfficePhoneNumber = row["Form19TaxOfficePhoneNumber"].ToString();
		form19.Form19TaxOfficeAddress = row["Form19TaxOfficeAddress"].ToString();
		form19.Form19RequestName = row["Form19RequestName"].ToString();
		form19.Form19TaxGroupUserFullName = row["Form19TaxGroupUserFullName"].ToString();
		form19.Form19RequestRelationship = row["Form19RequestRelationship"].ToString();
		form19.Form19HeirShareDescription = row["Form19HeirShareDescription"].ToString();
		form19.Form19TaxOfficeCode = (row["Form19TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["Form19TaxOfficeCode"]) : 0 ;
		return form19;
	}
	public List<FormCommissionInvitation> GetListFormCommissionInvitation(Int64 declarationID)
	{
		List<FormCommissionInvitation> listFormCommissionInvitation = new List<FormCommissionInvitation>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormCommissionInvitationDeclarationID", declarationID)
		};

		//Lets get the list of FormCommissionInvitation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormCommissionInvitation_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formCommissionInvitation
				listFormCommissionInvitation = new List<FormCommissionInvitation>();

				//Now lets populate the FormCommissionInvitation details into the list of formCommissionInvitations
				foreach (DataRow row in table.Rows)
				{
					FormCommissionInvitation formCommissionInvitation = ConvertRowToFormCommissionInvitation(row);
					listFormCommissionInvitation.Add(formCommissionInvitation);
				}
			}
		}

		return listFormCommissionInvitation;
	}

	private FormCommissionInvitation ConvertRowToFormCommissionInvitation(DataRow row)
	{
		FormCommissionInvitation formCommissionInvitation = new FormCommissionInvitation();
		formCommissionInvitation.FormCommissionInvitationID = (row["FormCommissionInvitationID"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationID"]) : 0 ;
		formCommissionInvitation.FormCommissionInvitationPrintRegisterInformationID = row["FormCommissionInvitationPrintRegisterInformationID"].ToString();
		formCommissionInvitation.FormCommissionInvitationPrintRegisterDate = row["FormCommissionInvitationPrintRegisterDate"].ToString();
		formCommissionInvitation.FormCommissionInvitationTaxResource = row["FormCommissionInvitationTaxResource"].ToString();
		formCommissionInvitation.FormCommissionInvitationDeadDeathYear = row["FormCommissionInvitationDeadDeathYear"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionAddress = row["FormCommissionInvitationCommissionAddress"].ToString();
		formCommissionInvitation.FormCommissionInvitationUser1FullName = row["FormCommissionInvitationUser1FullName"].ToString();
		formCommissionInvitation.FormCommissionInvitationUser1Code = row["FormCommissionInvitationUser1Code"].ToString();
		formCommissionInvitation.FormCommissionInvitationUser2FullName = row["FormCommissionInvitationUser2FullName"].ToString();
		formCommissionInvitation.FormCommissionInvitationUser2Code = row["FormCommissionInvitationUser2Code"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionType3 = row["FormCommissionInvitationCommissionType3"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionType4 = row["FormCommissionInvitationCommissionType4"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionType5 = row["FormCommissionInvitationCommissionType5"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionType6 = row["FormCommissionInvitationCommissionType6"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionDay = row["FormCommissionInvitationCommissionDay"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionTimePeriod = row["FormCommissionInvitationCommissionTimePeriod"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirJobZipCode = row["FormCommissionInvitationHeirJobZipCode"].ToString();
		formCommissionInvitation.FormCommissionInvitationInvitationType1 = row["FormCommissionInvitationInvitationType1"].ToString();
		formCommissionInvitation.FormCommissionInvitationInvitationType2 = row["FormCommissionInvitationInvitationType2"].ToString();
		formCommissionInvitation.FormCommissionInvitationInvitationType3 = row["FormCommissionInvitationInvitationType3"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionType1 = row["FormCommissionInvitationCommissionType1"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionType2 = row["FormCommissionInvitationCommissionType2"].ToString();
		formCommissionInvitation.FormCommissionInvitationDeadUniqueCode = row["FormCommissionInvitationDeadUniqueCode"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirJobAddress = row["FormCommissionInvitationHeirJobAddress"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirHomeAddress = row["FormCommissionInvitationHeirHomeAddress"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirHomePhoneNumber = row["FormCommissionInvitationHeirHomePhoneNumber"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirHomeJobPhoneNumber = row["FormCommissionInvitationHeirHomeJobPhoneNumber"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirHomeZipCode = row["FormCommissionInvitationHeirHomeZipCode"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirFatherName = row["FormCommissionInvitationHeirFatherName"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirIdentifier = row["FormCommissionInvitationHeirIdentifier"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirCertificateNumber = row["FormCommissionInvitationHeirCertificateNumber"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirIssuanceCity = row["FormCommissionInvitationHeirIssuanceCity"].ToString();
		formCommissionInvitation.FormCommissionInvitationDeadFullName = row["FormCommissionInvitationDeadFullName"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirRelation = row["FormCommissionInvitationHeirRelation"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirBirthDate = row["FormCommissionInvitationHeirBirthDate"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionDate = row["FormCommissionInvitationCommissionDate"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionTime = row["FormCommissionInvitationCommissionTime"].ToString();
		formCommissionInvitation.FormCommissionInvitationPenaltyDate = row["FormCommissionInvitationPenaltyDate"].ToString();
		formCommissionInvitation.FormCommissionInvitationRegisterInformarionID = (row["FormCommissionInvitationRegisterInformarionID"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationRegisterInformarionID"]) : 0 ;
		formCommissionInvitation.FormCommissionInvitationHeirNationalCode = (row["FormCommissionInvitationHeirNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationHeirNationalCode"]) : 0 ;
		formCommissionInvitation.FormCommissionInvitationDeclarationID = (row["FormCommissionInvitationDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationDeclarationID"]) : 0 ;
		formCommissionInvitation.FormCommissionInvitationRegisterDate = row["FormCommissionInvitationRegisterDate"].ToString();
		formCommissionInvitation.FormCommissionInvitationDossierClasses = row["FormCommissionInvitationDossierClasses"].ToString();
		formCommissionInvitation.FormCommissionInvitationTaxOfficeProvince = row["FormCommissionInvitationTaxOfficeProvince"].ToString();
		formCommissionInvitation.FormCommissionInvitationTaxOfficeCity = row["FormCommissionInvitationTaxOfficeCity"].ToString();
		formCommissionInvitation.FormCommissionInvitationTaxOfficeAddress = row["FormCommissionInvitationTaxOfficeAddress"].ToString();
		formCommissionInvitation.FormCommissionInvitationTaxOfficePhoneNumber = row["FormCommissionInvitationTaxOfficePhoneNumber"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirFullName = row["FormCommissionInvitationHeirFullName"].ToString();
		formCommissionInvitation.FormCommissionInvitationTaxUnitCode = (row["FormCommissionInvitationTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["FormCommissionInvitationTaxUnitCode"]) : 0 ;
		formCommissionInvitation.FormCommissionInvitationHeirShare = (row["FormCommissionInvitationHeirShare"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirShare"]) : 0 ;
		formCommissionInvitation.FormCommissionInvitationHeirExemption = (row["FormCommissionInvitationHeirExemption"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirExemption"]) : 0 ;
		formCommissionInvitation.FormCommissionInvitationHeirIncludedIncome = (row["FormCommissionInvitationHeirIncludedIncome"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirIncludedIncome"]) : 0 ;
		formCommissionInvitation.FormCommissionInvitationHeirTax = (row["FormCommissionInvitationHeirTax"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirTax"]) : 0 ;
		formCommissionInvitation.FormCommissionInvitationPenaltySum = (row["FormCommissionInvitationPenaltySum"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationPenaltySum"]) : 0 ;
		return formCommissionInvitation;
	}
	public List<FormDeclarationDelivery> GetListFormDeclarationDelivery(Int64 declarationID)
	{
		List<FormDeclarationDelivery> listFormDeclarationDelivery = new List<FormDeclarationDelivery>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationDeliveryDeclarationID", declarationID)
		};

		//Lets get the list of FormDeclarationDelivery records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDeclarationDelivery_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formDeclarationDelivery
				listFormDeclarationDelivery = new List<FormDeclarationDelivery>();

				//Now lets populate the FormDeclarationDelivery details into the list of formDeclarationDeliverys
				foreach (DataRow row in table.Rows)
				{
					FormDeclarationDelivery formDeclarationDelivery = ConvertRowToFormDeclarationDelivery(row);
					listFormDeclarationDelivery.Add(formDeclarationDelivery);
				}
			}
		}

		return listFormDeclarationDelivery;
	}

	private FormDeclarationDelivery ConvertRowToFormDeclarationDelivery(DataRow row)
	{
		FormDeclarationDelivery formDeclarationDelivery = new FormDeclarationDelivery();
		formDeclarationDelivery.FormDeclarationDeliveryID = (row["FormDeclarationDeliveryID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationDeliveryID"]) : 0 ;
		formDeclarationDelivery.FormDeclarationDeliveryPrintRegisterInformationID = row["FormDeclarationDeliveryPrintRegisterInformationID"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryPrintRegisterDate = row["FormDeclarationDeliveryPrintRegisterDate"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryDeadIssuanceCity = row["FormDeclarationDeliveryDeadIssuanceCity"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryDeadDeathCity = row["FormDeclarationDeliveryDeadDeathCity"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryUttererRole = row["FormDeclarationDeliveryUttererRole"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryDeclarativeValueString = row["FormDeclarationDeliveryDeclarativeValueString"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryRuleComment2 = row["FormDeclarationDeliveryRuleComment2"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryHeritageDescription = row["FormDeclarationDeliveryHeritageDescription"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxGroupCode = row["FormDeclarationDeliveryTaxGroupCode"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxGroupUserName = row["FormDeclarationDeliveryTaxGroupUserName"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryDeadName = row["FormDeclarationDeliveryDeadName"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryDeadFamilu = row["FormDeclarationDeliveryDeadFamilu"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryDeadCertificateNumber = row["FormDeclarationDeliveryDeadCertificateNumber"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryDeadNationalCode = row["FormDeclarationDeliveryDeadNationalCode"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryApplicantName = row["FormDeclarationDeliveryApplicantName"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryApplicantFamily = row["FormDeclarationDeliveryApplicantFamily"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxUnitCode = row["FormDeclarationDeliveryTaxUnitCode"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxUnitUserName = row["FormDeclarationDeliveryTaxUnitUserName"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxUnitUserFamily = row["FormDeclarationDeliveryTaxUnitUserFamily"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxGroupUserFamily = row["FormDeclarationDeliveryTaxGroupUserFamily"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryUttererFamily = row["FormDeclarationDeliveryUttererFamily"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryUttererCertificateNumber = row["FormDeclarationDeliveryUttererCertificateNumber"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryUttererNationalCode = row["FormDeclarationDeliveryUttererNationalCode"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryUttererIssuanceCity = row["FormDeclarationDeliveryUttererIssuanceCity"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryComment2 = row["FormDeclarationDeliveryComment2"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryApplicantNumber = row["FormDeclarationDeliveryApplicantNumber"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryRegisterInformationID = (row["FormDeclarationDeliveryRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationDeliveryRegisterInformationID"]) : 0 ;
		formDeclarationDelivery.FormDeclarationDeliveryDeclarationID = (row["FormDeclarationDeliveryDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationDeliveryDeclarationID"]) : 0 ;
		formDeclarationDelivery.FormDeclarationDeliveryRegisterarUserNationalCode = (row["FormDeclarationDeliveryRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationDeliveryRegisterarUserNationalCode"]) : 0 ;
		formDeclarationDelivery.FormDeclarationDeliveryDossierClasses = row["FormDeclarationDeliveryDossierClasses"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxOfficePhoneNumber = row["FormDeclarationDeliveryTaxOfficePhoneNumber"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryApplicantDate = row["FormDeclarationDeliveryApplicantDate"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryDeadDeathDate = row["FormDeclarationDeliveryDeadDeathDate"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryRegisterInformationDate = row["FormDeclarationDeliveryRegisterInformationDate"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryRuleComment1 = row["FormDeclarationDeliveryRuleComment1"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeProvince = row["FormDeclarationDeliveryTaxOfficeProvince"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeCode = row["FormDeclarationDeliveryTaxOfficeCode"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeCity = row["FormDeclarationDeliveryTaxOfficeCity"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeAddress = row["FormDeclarationDeliveryTaxOfficeAddress"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryUttererName = row["FormDeclarationDeliveryUttererName"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryDeclarativeValue = (row["FormDeclarationDeliveryDeclarativeValue"] != DBNull.Value) ? Convert.ToSingle(row["FormDeclarationDeliveryDeclarativeValue"]) : 0 ;
		return formDeclarationDelivery;
	}
	public List<FormDeclarationInputInfo> GetListFormDeclarationInputInfo(Int64 declarationID)
	{
		List<FormDeclarationInputInfo> listFormDeclarationInputInfo = new List<FormDeclarationInputInfo>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationInputInfoDeclarationID", declarationID)
		};

		//Lets get the list of FormDeclarationInputInfo records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDeclarationInputInfo_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formDeclarationInputInfo
				listFormDeclarationInputInfo = new List<FormDeclarationInputInfo>();

				//Now lets populate the FormDeclarationInputInfo details into the list of formDeclarationInputInfos
				foreach (DataRow row in table.Rows)
				{
					FormDeclarationInputInfo formDeclarationInputInfo = ConvertRowToFormDeclarationInputInfo(row);
					listFormDeclarationInputInfo.Add(formDeclarationInputInfo);
				}
			}
		}

		return listFormDeclarationInputInfo;
	}

	private FormDeclarationInputInfo ConvertRowToFormDeclarationInputInfo(DataRow row)
	{
		FormDeclarationInputInfo formDeclarationInputInfo = new FormDeclarationInputInfo();
		formDeclarationInputInfo.FormDeclarationInputInfoID = (row["FormDeclarationInputInfoID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoID"]) : 0 ;
		formDeclarationInputInfo.FormDeclarationInputInfoPrintRegisterInformationID = row["FormDeclarationInputInfoPrintRegisterInformationID"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoPrintRegisterDate = row["FormDeclarationInputInfoPrintRegisterDate"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathProvince = row["FormDeclarationInputInfoDeadDeathProvince"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathCity = row["FormDeclarationInputInfoDeadDeathCity"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoProvince = row["FormDeclarationInputInfoTaxOfficeRegisterInfoProvince"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoCity = row["FormDeclarationInputInfoTaxOfficeRegisterInfoCity"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoTaxUnitCode = row["FormDeclarationInputInfoTaxUnitCode"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadZipCode = row["FormDeclarationInputInfoDeadZipCode"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadFatherName = row["FormDeclarationInputInfoDeadFatherName"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateNumber = row["FormDeclarationInputInfoDeadCertificateNumber"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateSerial = row["FormDeclarationInputInfoDeadCertificateSerial"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceProvice = row["FormDeclarationInputInfoDeadIssuanceProvice"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceCity = row["FormDeclarationInputInfoDeadIssuanceCity"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDepartmant = row["FormDeclarationInputInfoDeadIssuanceDepartmant"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeclarationID = (row["FormDeclarationInputInfoDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoDeclarationID"]) : 0 ;
		formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationID = (row["FormDeclarationInputInfoRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoRegisterInformationID"]) : 0 ;
		formDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationID = (row["FormDeclarationInputInfoDeclarationRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoDeclarationRegisterInformationID"]) : 0 ;
		formDeclarationInputInfo.FormDeclarationInputInfoRegisterarUserNationalCode = (row["FormDeclarationInputInfoRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoRegisterarUserNationalCode"]) : 0 ;
		formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDate = row["FormDeclarationInputInfoDeadIssuanceDate"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadBirthDate = row["FormDeclarationInputInfoDeadBirthDate"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathDate = row["FormDeclarationInputInfoDeadDeathDate"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationDate = row["FormDeclarationInputInfoDeclarationRegisterInformationDate"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoApproveDate = row["FormDeclarationInputInfoApproveDate"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationDate = row["FormDeclarationInputInfoRegisterInformationDate"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadNationalCode = row["FormDeclarationInputInfoDeadNationalCode"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeTitle = row["FormDeclarationInputInfoTaxOfficeTitle"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeCity = row["FormDeclarationInputInfoTaxOfficeCity"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeclarationStage = row["FormDeclarationInputInfoDeclarationStage"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadName = row["FormDeclarationInputInfoDeadName"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadFamily = row["FormDeclarationInputInfoDeadFamily"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadUniqueCode = row["FormDeclarationInputInfoDeadUniqueCode"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoApprovalUserName = row["FormDeclarationInputInfoApprovalUserName"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoApprovalUserFamily = row["FormDeclarationInputInfoApprovalUserFamily"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeProvince = row["FormDeclarationInputInfoTaxOfficeProvince"].ToString();
		return formDeclarationInputInfo;
	}
	public List<FormDeterministicPaper> GetListFormDeterministicPaper(Int64 declarationID)
	{
		List<FormDeterministicPaper> listFormDeterministicPaper = new List<FormDeterministicPaper>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormDeterministicPaperDeclarationID", declarationID)
		};

		//Lets get the list of FormDeterministicPaper records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDeterministicPaper_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formDeterministicPaper
				listFormDeterministicPaper = new List<FormDeterministicPaper>();

				//Now lets populate the FormDeterministicPaper details into the list of formDeterministicPapers
				foreach (DataRow row in table.Rows)
				{
					FormDeterministicPaper formDeterministicPaper = ConvertRowToFormDeterministicPaper(row);
					listFormDeterministicPaper.Add(formDeterministicPaper);
				}
			}
		}

		return listFormDeterministicPaper;
	}

	private FormDeterministicPaper ConvertRowToFormDeterministicPaper(DataRow row)
	{
		FormDeterministicPaper formDeterministicPaper = new FormDeterministicPaper();
		formDeterministicPaper.FormDeterministicPaperID = (row["FormDeterministicPaperID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperID"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperPrintRegisterInformationID = row["FormDeterministicPaperPrintRegisterInformationID"].ToString();
		formDeterministicPaper.FormDeterministicPaperPrintRegisterDate = row["FormDeterministicPaperPrintRegisterDate"].ToString();
		formDeterministicPaper.FormDeterministicPaperReductionType = row["FormDeterministicPaperReductionType"].ToString();
		formDeterministicPaper.FormDeterministicPaperPenaltyReason = row["FormDeterministicPaperPenaltyReason"].ToString();
		formDeterministicPaper.FormDeterministicPaperComment = row["FormDeterministicPaperComment"].ToString();
		formDeterministicPaper.FormDeterministicPaperUser1Code = row["FormDeterministicPaperUser1Code"].ToString();
		formDeterministicPaper.FormDeterministicPaperUser1FullName = row["FormDeterministicPaperUser1FullName"].ToString();
		formDeterministicPaper.FormDeterministicPaperOperationYear2 = row["FormDeterministicPaperOperationYear2"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirJobZipCode = row["FormDeterministicPaperHeirJobZipCode"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirHomeZipCode = row["FormDeterministicPaperHeirHomeZipCode"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirIdentifier = row["FormDeterministicPaperHeirIdentifier"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxTitle = row["FormDeterministicPaperTaxTitle"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxReason = row["FormDeterministicPaperTaxReason"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxNumber = row["FormDeterministicPaperTaxNumber"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirIssuanceDepartmant = row["FormDeterministicPaperHeirIssuanceDepartmant"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirIssuanceCity = row["FormDeterministicPaperHeirIssuanceCity"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirJobAddress = row["FormDeterministicPaperHeirJobAddress"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirHomeAddress = row["FormDeterministicPaperHeirHomeAddress"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirJobPhoneNumber = row["FormDeterministicPaperHeirJobPhoneNumber"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirHomePhoneNumber = row["FormDeterministicPaperHeirHomePhoneNumber"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirName = row["FormDeterministicPaperHeirName"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirFamily = row["FormDeterministicPaperHeirFamily"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirFatherName = row["FormDeterministicPaperHeirFatherName"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirCertificateNumber = row["FormDeterministicPaperHeirCertificateNumber"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirNationalCode = row["FormDeterministicPaperHeirNationalCode"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirIssuanceDate = row["FormDeterministicPaperHeirIssuanceDate"].ToString();
		formDeterministicPaper.FormDeterministicPaperDossierClasses = row["FormDeterministicPaperDossierClasses"].ToString();
		formDeterministicPaper.FormDeterministicPaperRegisterInformationID = (row["FormDeterministicPaperRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperRegisterInformationID"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperDeclarationID = (row["FormDeterministicPaperDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperDeclarationID"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperRegisterarUserNationalCode = (row["FormDeterministicPaperRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperRegisterarUserNationalCode"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperRegisterInformationDate = row["FormDeterministicPaperRegisterInformationDate"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxDate = row["FormDeterministicPaperTaxDate"].ToString();
		formDeterministicPaper.FormDeterministicPaperAnnonsiationDate = row["FormDeterministicPaperAnnonsiationDate"].ToString();
		formDeterministicPaper.FormDeterministicPaperReductionDate = row["FormDeterministicPaperReductionDate"].ToString();
		formDeterministicPaper.FormDeterministicPaperPenaltyDate = row["FormDeterministicPaperPenaltyDate"].ToString();
		formDeterministicPaper.FormDeterministicPaperOperationYear1 = row["FormDeterministicPaperOperationYear1"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxOfficeProvince = row["FormDeterministicPaperTaxOfficeProvince"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxOfficeCode = row["FormDeterministicPaperTaxOfficeCode"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxUintCode = row["FormDeterministicPaperTaxUintCode"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxOfficeAddress = row["FormDeterministicPaperTaxOfficeAddress"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxOfficePhoneNumber = row["FormDeterministicPaperTaxOfficePhoneNumber"].ToString();
		formDeterministicPaper.FormDeterministicPaperPayableTaxLetter = row["FormDeterministicPaperPayableTaxLetter"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxTitle2 = row["FormDeterministicPaperTaxTitle2"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxBase = (row["FormDeterministicPaperTaxBase"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxBase"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperTaxReduction = (row["FormDeterministicPaperTaxReduction"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxReduction"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperTaxRemaining = (row["FormDeterministicPaperTaxRemaining"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxRemaining"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperTax = (row["FormDeterministicPaperTax"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTax"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperReduction = (row["FormDeterministicPaperReduction"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperReduction"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperPenalty = (row["FormDeterministicPaperPenalty"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperPenalty"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperTotalWithoutPenalty = (row["FormDeterministicPaperTotalWithoutPenalty"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTotalWithoutPenalty"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperTotal = (row["FormDeterministicPaperTotal"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTotal"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperPayableTax = (row["FormDeterministicPaperPayableTax"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperPayableTax"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperTaxRemaining2 = (row["FormDeterministicPaperTaxRemaining2"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxRemaining2"]) : 0 ;
		return formDeterministicPaper;
	}
	public List<FormDiagnosisPaper> GetListFormDiagnosisPaper(Int64 declarationID)
	{
		List<FormDiagnosisPaper> listFormDiagnosisPaper = new List<FormDiagnosisPaper>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisPaperDeclarationID", declarationID)
		};

		//Lets get the list of FormDiagnosisPaper records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDiagnosisPaper_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formDiagnosisPaper
				listFormDiagnosisPaper = new List<FormDiagnosisPaper>();

				//Now lets populate the FormDiagnosisPaper details into the list of formDiagnosisPapers
				foreach (DataRow row in table.Rows)
				{
					FormDiagnosisPaper formDiagnosisPaper = ConvertRowToFormDiagnosisPaper(row);
					listFormDiagnosisPaper.Add(formDiagnosisPaper);
				}
			}
		}

		return listFormDiagnosisPaper;
	}

	private FormDiagnosisPaper ConvertRowToFormDiagnosisPaper(DataRow row)
	{
		FormDiagnosisPaper formDiagnosisPaper = new FormDiagnosisPaper();
		formDiagnosisPaper.FormDiagnosisPaperID = (row["FormDiagnosisPaperID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperID"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperPrintRegisterInformationID = row["FormDiagnosisPaperPrintRegisterInformationID"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperPrintRegisterDate = row["FormDiagnosisPaperPrintRegisterDate"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperlUser1Code = row["FormDiagnosisPaperlUser1Code"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperUser1FullName = row["FormDiagnosisPaperUser1FullName"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperUser2Code = row["FormDiagnosisPaperUser2Code"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperlUser2FullName = row["FormDiagnosisPaperlUser2FullName"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperTaxDescription = row["FormDiagnosisPaperTaxDescription"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperDeadNationality = row["FormDiagnosisPaperDeadNationality"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperDeadLastAddress = row["FormDiagnosisPaperDeadLastAddress"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirLevel1 = row["FormDiagnosisPaperHeirLevel1"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirLevel2 = row["FormDiagnosisPaperHeirLevel2"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirLevel3 = row["FormDiagnosisPaperHeirLevel3"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirLevel4 = row["FormDiagnosisPaperHeirLevel4"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirName = row["FormDiagnosisPaperHeirName"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirFamily = row["FormDiagnosisPaperHeirFamily"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirIdentifier = row["FormDiagnosisPaperHeirIdentifier"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirAddress = row["FormDiagnosisPaperHeirAddress"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirNationalCode = row["FormDiagnosisPaperHeirNationalCode"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperDeadFullName = row["FormDiagnosisPaperDeadFullName"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirZipCode = row["FormDiagnosisPaperHeirZipCode"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperRegisterInformationID = (row["FormDiagnosisPaperRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperRegisterInformationID"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperDeclarationID = (row["FormDiagnosisPaperDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperDeclarationID"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperRegisterarUserNationalCode = (row["FormDiagnosisPaperRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperRegisterarUserNationalCode"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperDossierClasses = row["FormDiagnosisPaperDossierClasses"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperDeadDeathDate = row["FormDiagnosisPaperDeadDeathDate"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperRegisterInformationDate = row["FormDiagnosisPaperRegisterInformationDate"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperCommentHeader = row["FormDiagnosisPaperCommentHeader"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperTaxOfficeProvince = row["FormDiagnosisPaperTaxOfficeProvince"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperTaxOfficeCode = row["FormDiagnosisPaperTaxOfficeCode"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperTaxUnitCode = row["FormDiagnosisPaperTaxUnitCode"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperTaxOfficeAddress = row["FormDiagnosisPaperTaxOfficeAddress"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperTaxOfficePhoneNumber = row["FormDiagnosisPaperTaxOfficePhoneNumber"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperTotalValue1 = (row["FormDiagnosisPaperTotalValue1"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue1"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperReduction1 = (row["FormDiagnosisPaperReduction1"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperReduction1"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperTotalValue2 = (row["FormDiagnosisPaperTotalValue2"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue2"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperReduction2 = (row["FormDiagnosisPaperReduction2"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperReduction2"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperTotalValue3 = (row["FormDiagnosisPaperTotalValue3"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue3"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperYourShare = (row["FormDiagnosisPaperYourShare"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperYourShare"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperIncludedShare = (row["FormDiagnosisPaperIncludedShare"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperIncludedShare"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperYourShareWill = (row["FormDiagnosisPaperYourShareWill"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperYourShareWill"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperTotalValue4 = (row["FormDiagnosisPaperTotalValue4"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue4"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperReduction3 = (row["FormDiagnosisPaperReduction3"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperReduction3"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperTax = (row["FormDiagnosisPaperTax"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTax"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperTaxTypeA = (row["FormDiagnosisPaperTaxTypeA"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTaxTypeA"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperTaxTypeB = (row["FormDiagnosisPaperTaxTypeB"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTaxTypeB"]) : 0 ;
		return formDiagnosisPaper;
	}
	public List<FormDiagnosisResult> GetListFormDiagnosisResult(Int64 declarationID)
	{
		List<FormDiagnosisResult> listFormDiagnosisResult = new List<FormDiagnosisResult>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisResultDeclarationID", declarationID)
		};

		//Lets get the list of FormDiagnosisResult records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDiagnosisResult_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formDiagnosisResult
				listFormDiagnosisResult = new List<FormDiagnosisResult>();

				//Now lets populate the FormDiagnosisResult details into the list of formDiagnosisResults
				foreach (DataRow row in table.Rows)
				{
					FormDiagnosisResult formDiagnosisResult = ConvertRowToFormDiagnosisResult(row);
					listFormDiagnosisResult.Add(formDiagnosisResult);
				}
			}
		}

		return listFormDiagnosisResult;
	}

	private FormDiagnosisResult ConvertRowToFormDiagnosisResult(DataRow row)
	{
		FormDiagnosisResult formDiagnosisResult = new FormDiagnosisResult();
		formDiagnosisResult.FormDiagnosisResultID = (row["FormDiagnosisResultID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisResultID"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultDeclarationID = (row["FormDiagnosisResultDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisResultDeclarationID"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultRegisterInformationID = (row["FormDiagnosisResultRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisResultRegisterInformationID"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultApplicantNationalCode = (row["FormDiagnosisResultApplicantNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisResultApplicantNationalCode"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultZipCode = (row["FormDiagnosisResultZipCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisResultZipCode"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultDeadNationalCode = (row["FormDiagnosisResultDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisResultDeadNationalCode"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultDeadIssuanceCity = row["FormDiagnosisResultDeadIssuanceCity"].ToString();
		formDiagnosisResult.FormDiagnosisResultRegisterDate = row["FormDiagnosisResultRegisterDate"].ToString();
		formDiagnosisResult.FormDiagnosisResultApplicantBirthDate = row["FormDiagnosisResultApplicantBirthDate"].ToString();
		formDiagnosisResult.FormDiagnosisResultDeadDeathDate = row["FormDiagnosisResultDeadDeathDate"].ToString();
		formDiagnosisResult.FormDiagnosisResultDiagnosisReportDate = row["FormDiagnosisResultDiagnosisReportDate"].ToString();
		formDiagnosisResult.FormDiagnosisResultRequestDate = row["FormDiagnosisResultRequestDate"].ToString();
		formDiagnosisResult.FormDiagnosisResultTaxOfficeTitle = row["FormDiagnosisResultTaxOfficeTitle"].ToString();
		formDiagnosisResult.FormDiagnosisResultTaxOfficeAddress = row["FormDiagnosisResultTaxOfficeAddress"].ToString();
		formDiagnosisResult.FormDiagnosisResultTaxOfficePhoneNumber = row["FormDiagnosisResultTaxOfficePhoneNumber"].ToString();
		formDiagnosisResult.FormDiagnosisResultTaxOfficeZipCode = row["FormDiagnosisResultTaxOfficeZipCode"].ToString();
		formDiagnosisResult.FormDiagnosisResultDossierClasses = row["FormDiagnosisResultDossierClasses"].ToString();
		formDiagnosisResult.FormDiagnosisResultApplicantFullName = row["FormDiagnosisResultApplicantFullName"].ToString();
		formDiagnosisResult.FormDiagnosisResultDescription = row["FormDiagnosisResultDescription"].ToString();
		formDiagnosisResult.FormDiagnosisResultUser1FullName = row["FormDiagnosisResultUser1FullName"].ToString();
		formDiagnosisResult.FormDiagnosisResultUser2FullName = row["FormDiagnosisResultUser2FullName"].ToString();
		formDiagnosisResult.FormDiagnosisResultPhoneNumber = row["FormDiagnosisResultPhoneNumber"].ToString();
		formDiagnosisResult.FormDiagnosisResultApplicantRole = row["FormDiagnosisResultApplicantRole"].ToString();
		formDiagnosisResult.FormDiagnosisResultDeadFullName = row["FormDiagnosisResultDeadFullName"].ToString();
		formDiagnosisResult.FormDiagnosisResultDeadFatherName = row["FormDiagnosisResultDeadFatherName"].ToString();
		formDiagnosisResult.FormDiagnosisResultDeadDeathCity = row["FormDiagnosisResultDeadDeathCity"].ToString();
		formDiagnosisResult.FormDiagnosisResultDeadCertificateNumber = row["FormDiagnosisResultDeadCertificateNumber"].ToString();
		formDiagnosisResult.FormDiagnosisResultDiagnosisReportNumber = row["FormDiagnosisResultDiagnosisReportNumber"].ToString();
		formDiagnosisResult.FormDiagnosisResultRequestNumber = row["FormDiagnosisResultRequestNumber"].ToString();
		formDiagnosisResult.FormDiagnosisResultApplicantFatherName = row["FormDiagnosisResultApplicantFatherName"].ToString();
		formDiagnosisResult.FormDiagnosisResultApplicantBirthCity = row["FormDiagnosisResultApplicantBirthCity"].ToString();
		formDiagnosisResult.FormDiagnosisResultApplicantCertificateNumber = row["FormDiagnosisResultApplicantCertificateNumber"].ToString();
		formDiagnosisResult.FormDiagnosisResultApplicantIssuanceCity = row["FormDiagnosisResultApplicantIssuanceCity"].ToString();
		formDiagnosisResult.FormDiagnosisResultCommercialNumber = row["FormDiagnosisResultCommercialNumber"].ToString();
		formDiagnosisResult.FormDiagnosisResultAddress = row["FormDiagnosisResultAddress"].ToString();
		formDiagnosisResult.FormDiagnosisResultTaxOfficeCode = (row["FormDiagnosisResultTaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["FormDiagnosisResultTaxOfficeCode"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultTaxGroupCode = (row["FormDiagnosisResultTaxGroupCode"] != DBNull.Value) ? Convert.ToInt32(row["FormDiagnosisResultTaxGroupCode"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultTaxUnitCode = (row["FormDiagnosisResultTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["FormDiagnosisResultTaxUnitCode"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultUser1Code = (row["FormDiagnosisResultUser1Code"] != DBNull.Value) ? Convert.ToInt32(row["FormDiagnosisResultUser1Code"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultUser2Code = (row["FormDiagnosisResultUser2Code"] != DBNull.Value) ? Convert.ToInt32(row["FormDiagnosisResultUser2Code"]) : 0 ;
		return formDiagnosisResult;
	}
	public List<FormFreedom> GetListFormFreedom(Int64 declarationID)
	{
		List<FormFreedom> listFormFreedom = new List<FormFreedom>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormFreedomDeclarationID", declarationID)
		};

		//Lets get the list of FormFreedom records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormFreedom_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formFreedom
				listFormFreedom = new List<FormFreedom>();

				//Now lets populate the FormFreedom details into the list of formFreedoms
				foreach (DataRow row in table.Rows)
				{
					FormFreedom formFreedom = ConvertRowToFormFreedom(row);
					listFormFreedom.Add(formFreedom);
				}
			}
		}

		return listFormFreedom;
	}

	private FormFreedom ConvertRowToFormFreedom(DataRow row)
	{
		FormFreedom formFreedom = new FormFreedom();
		formFreedom.FormFreedomID = (row["FormFreedomID"] != DBNull.Value) ? Convert.ToInt64(row["FormFreedomID"]) : 0 ;
		formFreedom.FormFreedomDeclarationID = (row["FormFreedomDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormFreedomDeclarationID"]) : 0 ;
		formFreedom.FormFreedomRegisterInformationID = (row["FormFreedomRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormFreedomRegisterInformationID"]) : 0 ;
		formFreedom.FormFreedomApplicantNationalCode = (row["FormFreedomApplicantNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormFreedomApplicantNationalCode"]) : 0 ;
		formFreedom.FormFreedomZipCode = (row["FormFreedomZipCode"] != DBNull.Value) ? Convert.ToInt64(row["FormFreedomZipCode"]) : 0 ;
		formFreedom.FormFreedomDeadNationalCode = (row["FormFreedomDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormFreedomDeadNationalCode"]) : 0 ;
		formFreedom.FormFreedomRegisterDate = row["FormFreedomRegisterDate"].ToString();
		formFreedom.FormFreedomRequestDate = row["FormFreedomRequestDate"].ToString();
		formFreedom.FormFreedomApplicantBirthDate = row["FormFreedomApplicantBirthDate"].ToString();
		formFreedom.FormFreedomDeadDeathDate = row["FormFreedomDeadDeathDate"].ToString();
		formFreedom.FormFreedomDeclarationRegisterDate = row["FormFreedomDeclarationRegisterDate"].ToString();
		formFreedom.FormFreedomDiagnosisDate = row["FormFreedomDiagnosisDate"].ToString();
		formFreedom.FormFreedomHeirsCertificateDate = row["FormFreedomHeirsCertificateDate"].ToString();
		formFreedom.FormFreedomTaxOfficeTitle = row["FormFreedomTaxOfficeTitle"].ToString();
		formFreedom.FormFreedomTaxOfficeAddress = row["FormFreedomTaxOfficeAddress"].ToString();
		formFreedom.FormFreedomTaxOfficePhoneNumber = row["FormFreedomTaxOfficePhoneNumber"].ToString();
		formFreedom.FormFreedomTaxOfficeZipCode = row["FormFreedomTaxOfficeZipCode"].ToString();
		formFreedom.FormFreedomDossierClasses = row["FormFreedomDossierClasses"].ToString();
		formFreedom.FormFreedomRequestResource = row["FormFreedomRequestResource"].ToString();
		formFreedom.FormFreedomDescriptionHeritage = row["FormFreedomDescriptionHeritage"].ToString();
		formFreedom.FormFreedomUser1FullName = row["FormFreedomUser1FullName"].ToString();
		formFreedom.FormFreedomPhoneNumber = row["FormFreedomPhoneNumber"].ToString();
		formFreedom.FormFreedomUttererRole = row["FormFreedomUttererRole"].ToString();
		formFreedom.FormFreedomHeirsCertificateNumber = row["FormFreedomHeirsCertificateNumber"].ToString();
		formFreedom.FormFreedomHeirsCertificateSource = row["FormFreedomHeirsCertificateSource"].ToString();
		formFreedom.FormFreedomHeirsCertificateBranch = row["FormFreedomHeirsCertificateBranch"].ToString();
		formFreedom.FormFreedomDeadIssuanceCity = row["FormFreedomDeadIssuanceCity"].ToString();
		formFreedom.FormFreedomDeclarationRegisterNumber = row["FormFreedomDeclarationRegisterNumber"].ToString();
		formFreedom.FormFreedomDiagnosisNumber = row["FormFreedomDiagnosisNumber"].ToString();
		formFreedom.FormFreedomCourt = row["FormFreedomCourt"].ToString();
		formFreedom.FormFreedomBranch = row["FormFreedomBranch"].ToString();
		formFreedom.FormFreedomUser2FullName = row["FormFreedomUser2FullName"].ToString();
		formFreedom.FormFreedomApplicantIssuanceCity = row["FormFreedomApplicantIssuanceCity"].ToString();
		formFreedom.FormFreedomCommercialNumber = row["FormFreedomCommercialNumber"].ToString();
		formFreedom.FormFreedomDeadFullName = row["FormFreedomDeadFullName"].ToString();
		formFreedom.FormFreedomDeadFatherName = row["FormFreedomDeadFatherName"].ToString();
		formFreedom.FormFreedomDeadDeathCity = row["FormFreedomDeadDeathCity"].ToString();
		formFreedom.FormFreedomDeadCertificateNumber = row["FormFreedomDeadCertificateNumber"].ToString();
		formFreedom.FormFreedomRequestNumber = row["FormFreedomRequestNumber"].ToString();
		formFreedom.FormFreedomAddress = row["FormFreedomAddress"].ToString();
		formFreedom.FormFreedomApplicantFullName = row["FormFreedomApplicantFullName"].ToString();
		formFreedom.FormFreedomApplicantFatherName = row["FormFreedomApplicantFatherName"].ToString();
		formFreedom.FormFreedomApplicantBirthCity = row["FormFreedomApplicantBirthCity"].ToString();
		formFreedom.FormFreedomApplicantCertificateNumber = row["FormFreedomApplicantCertificateNumber"].ToString();
		formFreedom.FormFreedomTaxOfficeCode = (row["FormFreedomTaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["FormFreedomTaxOfficeCode"]) : 0 ;
		formFreedom.FormFreedomTaxGroupCode = (row["FormFreedomTaxGroupCode"] != DBNull.Value) ? Convert.ToInt32(row["FormFreedomTaxGroupCode"]) : 0 ;
		formFreedom.FormFreedomTaxUnitCode = (row["FormFreedomTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["FormFreedomTaxUnitCode"]) : 0 ;
		formFreedom.FormFreedomUser1Code = (row["FormFreedomUser1Code"] != DBNull.Value) ? Convert.ToInt32(row["FormFreedomUser1Code"]) : 0 ;
		formFreedom.FormFreedomUser2Code = (row["FormFreedomUser2Code"] != DBNull.Value) ? Convert.ToInt32(row["FormFreedomUser2Code"]) : 0 ;
		return formFreedom;
	}
	public List<FormHeritageBill> GetListFormHeritageBill(Int64 declarationID)
	{
		List<FormHeritageBill> listFormHeritageBill = new List<FormHeritageBill>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageBillDeclarationID", declarationID)
		};

		//Lets get the list of FormHeritageBill records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeritageBill_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formHeritageBill
				listFormHeritageBill = new List<FormHeritageBill>();

				//Now lets populate the FormHeritageBill details into the list of formHeritageBills
				foreach (DataRow row in table.Rows)
				{
					FormHeritageBill formHeritageBill = ConvertRowToFormHeritageBill(row);
					listFormHeritageBill.Add(formHeritageBill);
				}
			}
		}

		return listFormHeritageBill;
	}

	private FormHeritageBill ConvertRowToFormHeritageBill(DataRow row)
	{
		FormHeritageBill formHeritageBill = new FormHeritageBill();
		formHeritageBill.FormHeritageBillID = (row["FormHeritageBillID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillID"]) : 0 ;
		formHeritageBill.FormHeritageBillPrintRegisterInformationID = row["FormHeritageBillPrintRegisterInformationID"].ToString();
		formHeritageBill.FormHeritageBillPrintRegisterDate = row["FormHeritageBillPrintRegisterDate"].ToString();
		formHeritageBill.FormHeritageBillTaxTotalLetter = row["FormHeritageBillTaxTotalLetter"].ToString();
		formHeritageBill.FormHeritageBillUser1Code = row["FormHeritageBillUser1Code"].ToString();
		formHeritageBill.FormHeritageBillUser2Code = row["FormHeritageBillUser2Code"].ToString();
		formHeritageBill.FormHeritageBillTaxOfficeTitle = row["FormHeritageBillTaxOfficeTitle"].ToString();
		formHeritageBill.FormHeritageBillDeadFullName = row["FormHeritageBillDeadFullName"].ToString();
		formHeritageBill.FormHeritageBillDescriptions = row["FormHeritageBillDescriptions"].ToString();
		formHeritageBill.FormHeritageBillHeritageBill = row["FormHeritageBillHeritageBill"].ToString();
		formHeritageBill.FormHeritageBillRegisterInformationID = (row["FormHeritageBillRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillRegisterInformationID"]) : 0 ;
		formHeritageBill.FormHeritageBillDeclarationID = (row["FormHeritageBillDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillDeclarationID"]) : 0 ;
		formHeritageBill.FormHeritageBillRegisterarUserNationalCode = (row["FormHeritageBillRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillRegisterarUserNationalCode"]) : 0 ;
		formHeritageBill.FormHeritageBillDeadNationalCode = (row["FormHeritageBillDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillDeadNationalCode"]) : 0 ;
		formHeritageBill.FormHeritageBillDeadDeathDate = row["FormHeritageBillDeadDeathDate"].ToString();
		formHeritageBill.FormHeritageBillDossierClasses = row["FormHeritageBillDossierClasses"].ToString();
		formHeritageBill.FormHeritageBillRegisterInformationDate = row["FormHeritageBillRegisterInformationDate"].ToString();
		formHeritageBill.FormHeritageBillHeirsNumberSummury = row["FormHeritageBillHeirsNumberSummury"].ToString();
		formHeritageBill.FormHeritageBillHeirSharesSummury = row["FormHeritageBillHeirSharesSummury"].ToString();
		formHeritageBill.FormHeritageBillTaxDescription = row["FormHeritageBillTaxDescription"].ToString();
		formHeritageBill.FormHeritageBillBillType = row["FormHeritageBillBillType"].ToString();
		formHeritageBill.FormHeritageBillUser2FullName = row["FormHeritageBillUser2FullName"].ToString();
		formHeritageBill.FormHeritageBillUser1FullName = row["FormHeritageBillUser1FullName"].ToString();
		formHeritageBill.FormHeritageBillENZ = (row["FormHeritageBillENZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillENZ"]) : 0 ;
		formHeritageBill.FormHeritageBillANZ = (row["FormHeritageBillANZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillANZ"]) : 0 ;
		formHeritageBill.FormHeritageBillMNZ = (row["FormHeritageBillMNZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillMNZ"]) : 0 ;
		formHeritageBill.FormHeritageBillDMNZ = (row["FormHeritageBillDMNZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDMNZ"]) : 0 ;
		formHeritageBill.FormHeritageBillDENZ = (row["FormHeritageBillDENZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDENZ"]) : 0 ;
		formHeritageBill.FormHeritageBillDANZ = (row["FormHeritageBillDANZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDANZ"]) : 0 ;
		formHeritageBill.FormHeritageBillTotalValue = (row["FormHeritageBillTotalValue"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillTotalValue"]) : 0 ;
		formHeritageBill.FormHeritageBillTaxTotal = (row["FormHeritageBillTaxTotal"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillTaxTotal"]) : 0 ;
		formHeritageBill.FormHeritageBillDEKHZ = (row["FormHeritageBillDEKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDEKHZ"]) : 0 ;
		formHeritageBill.FormHeritageBillDAKHZ = (row["FormHeritageBillDAKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDAKHZ"]) : 0 ;
		formHeritageBill.FormHeritageBillDMKHZ = (row["FormHeritageBillDMKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDMKHZ"]) : 0 ;
		formHeritageBill.FormHeritageBillE2KHZ = (row["FormHeritageBillE2KHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillE2KHZ"]) : 0 ;
		formHeritageBill.FormHeritageBillA2KHZ = (row["FormHeritageBillA2KHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillA2KHZ"]) : 0 ;
		formHeritageBill.FormHeritageBillM2KHZ = (row["FormHeritageBillM2KHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillM2KHZ"]) : 0 ;
		formHeritageBill.FormHeritageBillE2NZ = (row["FormHeritageBillE2NZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillE2NZ"]) : 0 ;
		formHeritageBill.FormHeritageBillA2NZ = (row["FormHeritageBillA2NZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillA2NZ"]) : 0 ;
		formHeritageBill.FormHeritageBillM2NZ = (row["FormHeritageBillM2NZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillM2NZ"]) : 0 ;
		formHeritageBill.FormHeritageBillEKHZ = (row["FormHeritageBillEKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillEKHZ"]) : 0 ;
		formHeritageBill.FormHeritageBillAKHZ = (row["FormHeritageBillAKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillAKHZ"]) : 0 ;
		formHeritageBill.FormHeritageBillMKHZ = (row["FormHeritageBillMKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillMKHZ"]) : 0 ;
		return formHeritageBill;
	}
	public List<FormHeritageEvaluation> GetListFormHeritageEvaluation(Int64 declarationID)
	{
		List<FormHeritageEvaluation> listFormHeritageEvaluation = new List<FormHeritageEvaluation>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageEvaluationDeclarationID", declarationID)
		};

		//Lets get the list of FormHeritageEvaluation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeritageEvaluation_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formHeritageEvaluation
				listFormHeritageEvaluation = new List<FormHeritageEvaluation>();

				//Now lets populate the FormHeritageEvaluation details into the list of formHeritageEvaluations
				foreach (DataRow row in table.Rows)
				{
					FormHeritageEvaluation formHeritageEvaluation = ConvertRowToFormHeritageEvaluation(row);
					listFormHeritageEvaluation.Add(formHeritageEvaluation);
				}
			}
		}

		return listFormHeritageEvaluation;
	}

	private FormHeritageEvaluation ConvertRowToFormHeritageEvaluation(DataRow row)
	{
		FormHeritageEvaluation formHeritageEvaluation = new FormHeritageEvaluation();
		formHeritageEvaluation.FormHeritageEvaluationID = (row["FormHeritageEvaluationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageEvaluationID"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationRegisterInformationID = (row["FormHeritageEvaluationRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageEvaluationRegisterInformationID"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationDeclarationID = (row["FormHeritageEvaluationDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageEvaluationDeclarationID"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationApplicantNationalCode = (row["FormHeritageEvaluationApplicantNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageEvaluationApplicantNationalCode"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationZipCode = (row["FormHeritageEvaluationZipCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageEvaluationZipCode"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationDeadNationalCode = (row["FormHeritageEvaluationDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageEvaluationDeadNationalCode"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationRegisterDate = row["FormHeritageEvaluationRegisterDate"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationApplicantBirthDate = row["FormHeritageEvaluationApplicantBirthDate"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDeadDeathDate = row["FormHeritageEvaluationDeadDeathDate"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDeadIssuanceDate = row["FormHeritageEvaluationDeadIssuanceDate"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDiagnosisReportDate = row["FormHeritageEvaluationDiagnosisReportDate"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationRequestDate = row["FormHeritageEvaluationRequestDate"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationTaxOfficeTitle = row["FormHeritageEvaluationTaxOfficeTitle"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationTaxOfficeAddress = row["FormHeritageEvaluationTaxOfficeAddress"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationTaxOfficePhoneNumber = row["FormHeritageEvaluationTaxOfficePhoneNumber"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationTaxOfficeZipCode = row["FormHeritageEvaluationTaxOfficeZipCode"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDossierClasses = row["FormHeritageEvaluationDossierClasses"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationApplicantFullName = row["FormHeritageEvaluationApplicantFullName"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDescription = row["FormHeritageEvaluationDescription"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationUser1FullName = row["FormHeritageEvaluationUser1FullName"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationUser2FullName = row["FormHeritageEvaluationUser2FullName"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationPhoneNumber = row["FormHeritageEvaluationPhoneNumber"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationApplicantRole = row["FormHeritageEvaluationApplicantRole"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDeadIssuanceCity = row["FormHeritageEvaluationDeadIssuanceCity"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDeadFullName = row["FormHeritageEvaluationDeadFullName"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDeadFatherName = row["FormHeritageEvaluationDeadFatherName"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDeadDeathCity = row["FormHeritageEvaluationDeadDeathCity"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDeadCertificateNumber = row["FormHeritageEvaluationDeadCertificateNumber"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDiagnosisReportNumber = row["FormHeritageEvaluationDiagnosisReportNumber"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationRequestNumber = row["FormHeritageEvaluationRequestNumber"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationApplicantFatherName = row["FormHeritageEvaluationApplicantFatherName"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationApplicantBirthCity = row["FormHeritageEvaluationApplicantBirthCity"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationApplicantCertificateNumber = row["FormHeritageEvaluationApplicantCertificateNumber"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationApplicantIssuanceCity = row["FormHeritageEvaluationApplicantIssuanceCity"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationCommercialNumber = row["FormHeritageEvaluationCommercialNumber"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationAddress = row["FormHeritageEvaluationAddress"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationTaxOfficeCode = (row["FormHeritageEvaluationTaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["FormHeritageEvaluationTaxOfficeCode"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationTaxGroupCode = (row["FormHeritageEvaluationTaxGroupCode"] != DBNull.Value) ? Convert.ToInt32(row["FormHeritageEvaluationTaxGroupCode"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationTaxUnitCode = (row["FormHeritageEvaluationTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["FormHeritageEvaluationTaxUnitCode"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationUser1Code = (row["FormHeritageEvaluationUser1Code"] != DBNull.Value) ? Convert.ToInt32(row["FormHeritageEvaluationUser1Code"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationUser2Code = (row["FormHeritageEvaluationUser2Code"] != DBNull.Value) ? Convert.ToInt32(row["FormHeritageEvaluationUser2Code"]) : 0 ;
		return formHeritageEvaluation;
	}
	public List<FormHeritageList> GetListFormHeritageList(Int64 declarationID)
	{
		List<FormHeritageList> listFormHeritageList = new List<FormHeritageList>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageListDeclarationID", declarationID)
		};

		//Lets get the list of FormHeritageList records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeritageList_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formHeritageList
				listFormHeritageList = new List<FormHeritageList>();

				//Now lets populate the FormHeritageList details into the list of formHeritageLists
				foreach (DataRow row in table.Rows)
				{
					FormHeritageList formHeritageList = ConvertRowToFormHeritageList(row);
					listFormHeritageList.Add(formHeritageList);
				}
			}
		}

		return listFormHeritageList;
	}

	private FormHeritageList ConvertRowToFormHeritageList(DataRow row)
	{
		FormHeritageList formHeritageList = new FormHeritageList();
		formHeritageList.FormHeritageListID = (row["FormHeritageListID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageListID"]) : 0 ;
		formHeritageList.FormHeritageListDeclarationID = (row["FormHeritageListDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageListDeclarationID"]) : 0 ;
		formHeritageList.FormHeritageListRegisterarUserNationalCode = (row["FormHeritageListRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageListRegisterarUserNationalCode"]) : 0 ;
		formHeritageList.FormHeritageListIssuanceDate = row["FormHeritageListIssuanceDate"].ToString();
		formHeritageList.FormHeritageListDeathDate = row["FormHeritageListDeathDate"].ToString();
		formHeritageList.FormHeritageListRegisterInformationDate = row["FormHeritageListRegisterInformationDate"].ToString();
		formHeritageList.FormHeritageListType = row["FormHeritageListType"].ToString();
		formHeritageList.FormHeritageListDeadFullName = row["FormHeritageListDeadFullName"].ToString();
		formHeritageList.FormHeritageListTaxOfficeTitle = row["FormHeritageListTaxOfficeTitle"].ToString();
		formHeritageList.FormHeritageListDescriptions = row["FormHeritageListDescriptions"].ToString();
		formHeritageList.FormHeritageListDossierClasses = row["FormHeritageListDossierClasses"].ToString();
		formHeritageList.FormHeritageListItemCount = (row["FormHeritageListItemCount"] != DBNull.Value) ? Convert.ToInt32(row["FormHeritageListItemCount"]) : 0 ;
		return formHeritageList;
	}
	public List<FormHeritagesDescriptions> GetListFormHeritagesDescriptions(Int64 declarationID)
	{
		List<FormHeritagesDescriptions> listFormHeritagesDescriptions = new List<FormHeritagesDescriptions>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormHeritagesDescriptionsDeclarationID", declarationID)
		};

		//Lets get the list of FormHeritagesDescriptions records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeritagesDescriptions_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formHeritagesDescriptions
				listFormHeritagesDescriptions = new List<FormHeritagesDescriptions>();

				//Now lets populate the FormHeritagesDescriptions details into the list of formHeritagesDescriptionss
				foreach (DataRow row in table.Rows)
				{
					FormHeritagesDescriptions formHeritagesDescriptions = ConvertRowToFormHeritagesDescriptions(row);
					listFormHeritagesDescriptions.Add(formHeritagesDescriptions);
				}
			}
		}

		return listFormHeritagesDescriptions;
	}

	private FormHeritagesDescriptions ConvertRowToFormHeritagesDescriptions(DataRow row)
	{
		FormHeritagesDescriptions formHeritagesDescriptions = new FormHeritagesDescriptions();
		formHeritagesDescriptions.FormHeritagesDescriptionsID = (row["FormHeritagesDescriptionsID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritagesDescriptionsID"]) : 0 ;
		formHeritagesDescriptions.FormHeritagesDescriptionsDeclarationID = (row["FormHeritagesDescriptionsDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritagesDescriptionsDeclarationID"]) : 0 ;
		formHeritagesDescriptions.FormHeritagesDescriptionsRegisterarUserNationalCode = (row["FormHeritagesDescriptionsRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritagesDescriptionsRegisterarUserNationalCode"]) : 0 ;
		formHeritagesDescriptions.FormHeritagesDescriptionsDescription = row["FormHeritagesDescriptionsDescription"].ToString();
		return formHeritagesDescriptions;
	}
	public List<FormInquiryBankDeposit> GetListFormInquiryBankDeposit(Int64 declarationID)
	{
		List<FormInquiryBankDeposit> listFormInquiryBankDeposit = new List<FormInquiryBankDeposit>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryBankDepositDeclarationID", declarationID)
		};

		//Lets get the list of FormInquiryBankDeposit records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryBankDeposit_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formInquiryBankDeposit
				listFormInquiryBankDeposit = new List<FormInquiryBankDeposit>();

				//Now lets populate the FormInquiryBankDeposit details into the list of formInquiryBankDeposits
				foreach (DataRow row in table.Rows)
				{
					FormInquiryBankDeposit formInquiryBankDeposit = ConvertRowToFormInquiryBankDeposit(row);
					listFormInquiryBankDeposit.Add(formInquiryBankDeposit);
				}
			}
		}

		return listFormInquiryBankDeposit;
	}

	private FormInquiryBankDeposit ConvertRowToFormInquiryBankDeposit(DataRow row)
	{
		FormInquiryBankDeposit formInquiryBankDeposit = new FormInquiryBankDeposit();
		formInquiryBankDeposit.FormInquiryBankDepositID = (row["FormInquiryBankDepositID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryBankDepositID"]) : 0 ;
		formInquiryBankDeposit.FormInquiryBankDepositPrintRegisterInformationID = row["FormInquiryBankDepositPrintRegisterInformationID"].ToString();
		formInquiryBankDeposit.FormInquiryBankDepositPrintRegisterDate = row["FormInquiryBankDepositPrintRegisterDate"].ToString();
		formInquiryBankDeposit.FormInquiryBankDepositRegisterInformationDate = row["FormInquiryBankDepositRegisterInformationDate"].ToString();
		formInquiryBankDeposit.FormInquiryBankDepositDossierClasses = row["FormInquiryBankDepositDossierClasses"].ToString();
		formInquiryBankDeposit.FormInquiryBankDepositDeadDeathDate = row["FormInquiryBankDepositDeadDeathDate"].ToString();
		formInquiryBankDeposit.FormInquiryBankDepositRegisterInformationID = (row["FormInquiryBankDepositRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryBankDepositRegisterInformationID"]) : 0 ;
		formInquiryBankDeposit.FormInquiryBankDepositDeclarationID = (row["FormInquiryBankDepositDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryBankDepositDeclarationID"]) : 0 ;
		formInquiryBankDeposit.FormInquiryBankDepositRegisterarUserNationalCode = (row["FormInquiryBankDepositRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryBankDepositRegisterarUserNationalCode"]) : 0 ;
		formInquiryBankDeposit.FormInquiryBankDepositFormInquiryResponseID = (row["FormInquiryBankDepositFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryBankDepositFormInquiryResponseID"]) : 0 ;
		formInquiryBankDeposit.FormInquiryBankDepositBankTitle = row["FormInquiryBankDepositBankTitle"].ToString();
		formInquiryBankDeposit.FormInquiryBankDepositRuleComment = row["FormInquiryBankDepositRuleComment"].ToString();
		formInquiryBankDeposit.FormInquiryBankDepositUser1FullName = row["FormInquiryBankDepositUser1FullName"].ToString();
		formInquiryBankDeposit.FormInquiryBankDepositUser2FullName = row["FormInquiryBankDepositUser2FullName"].ToString();
		formInquiryBankDeposit.FormInquiryBankDepositUser1TaxUnitCode = row["FormInquiryBankDepositUser1TaxUnitCode"].ToString();
		formInquiryBankDeposit.FormInquiryBankDepositUser2TaxGroupCode = row["FormInquiryBankDepositUser2TaxGroupCode"].ToString();
		formInquiryBankDeposit.FormInquiryBankDepositComment = row["FormInquiryBankDepositComment"].ToString();
		formInquiryBankDeposit.FormInquiryBankDepositAccountNumber = row["FormInquiryBankDepositAccountNumber"].ToString();
		formInquiryBankDeposit.FormInquiryBankDepositDeadFullName = row["FormInquiryBankDepositDeadFullName"].ToString();
		formInquiryBankDeposit.FormInquiryBankDepositTaxUnitCode = row["FormInquiryBankDepositTaxUnitCode"].ToString();
		return formInquiryBankDeposit;
	}
	public List<FormInquiryCompany> GetListFormInquiryCompany(Int64 declarationID)
	{
		List<FormInquiryCompany> listFormInquiryCompany = new List<FormInquiryCompany>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryCompanyDeclarationID", declarationID)
		};

		//Lets get the list of FormInquiryCompany records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryCompany_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formInquiryCompany
				listFormInquiryCompany = new List<FormInquiryCompany>();

				//Now lets populate the FormInquiryCompany details into the list of formInquiryCompanys
				foreach (DataRow row in table.Rows)
				{
					FormInquiryCompany formInquiryCompany = ConvertRowToFormInquiryCompany(row);
					listFormInquiryCompany.Add(formInquiryCompany);
				}
			}
		}

		return listFormInquiryCompany;
	}

	private FormInquiryCompany ConvertRowToFormInquiryCompany(DataRow row)
	{
		FormInquiryCompany formInquiryCompany = new FormInquiryCompany();
		formInquiryCompany.FormInquiryCompanyID = (row["FormInquiryCompanyID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyID"]) : 0 ;
		formInquiryCompany.FormInquiryCompanyPrintRegisterInformationID = row["FormInquiryCompanyPrintRegisterInformationID"].ToString();
		formInquiryCompany.FormInquiryCompanyPrintRegisterDate = row["FormInquiryCompanyPrintRegisterDate"].ToString();
		formInquiryCompany.FormInquiryCompanyRuleComment1 = row["FormInquiryCompanyRuleComment1"].ToString();
		formInquiryCompany.FormInquiryCompanyRuleComment2 = row["FormInquiryCompanyRuleComment2"].ToString();
		formInquiryCompany.FormInquiryCompanyRegisterInformationDate = row["FormInquiryCompanyRegisterInformationDate"].ToString();
		formInquiryCompany.FormInquiryCompanyDossierClasses = row["FormInquiryCompanyDossierClasses"].ToString();
		formInquiryCompany.FormInquiryCompanyDeadDeathDate = row["FormInquiryCompanyDeadDeathDate"].ToString();
		formInquiryCompany.FormInquiryCompanyRegisterInformationID = (row["FormInquiryCompanyRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyRegisterInformationID"]) : 0 ;
		formInquiryCompany.FormInquiryCompanyRegisterarUserNationalCode = (row["FormInquiryCompanyRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyRegisterarUserNationalCode"]) : 0 ;
		formInquiryCompany.FormInquiryCompanyDeclarationID = (row["FormInquiryCompanyDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyDeclarationID"]) : 0 ;
		formInquiryCompany.FormInquiryCompanyFormInquiryResponseID = (row["FormInquiryCompanyFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryCompanyFormInquiryResponseID"]) : 0 ;
		formInquiryCompany.FormInquiryCompanyReciver = row["FormInquiryCompanyReciver"].ToString();
		formInquiryCompany.FormInquiryCompanyNumber = row["FormInquiryCompanyNumber"].ToString();
		formInquiryCompany.FormInquiryCompanyUser1FullName = row["FormInquiryCompanyUser1FullName"].ToString();
		formInquiryCompany.FormInquiryCompanyUser2FullName = row["FormInquiryCompanyUser2FullName"].ToString();
		formInquiryCompany.FormInquiryCompanyUser1TaxUnitCode = row["FormInquiryCompanyUser1TaxUnitCode"].ToString();
		formInquiryCompany.FormInquiryCompanyUser2TaxGroupCode = row["FormInquiryCompanyUser2TaxGroupCode"].ToString();
		formInquiryCompany.FormInquiryCompanyDeadFullName = row["FormInquiryCompanyDeadFullName"].ToString();
		formInquiryCompany.FormInquiryCompanyName = row["FormInquiryCompanyName"].ToString();
		return formInquiryCompany;
	}
	public List<FormInquiryEstate> GetListFormInquiryEstate(Int64 declarationID)
	{
		List<FormInquiryEstate> listFormInquiryEstate = new List<FormInquiryEstate>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryEstateDeclarationID", declarationID)
		};

		//Lets get the list of FormInquiryEstate records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryEstate_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formInquiryEstate
				listFormInquiryEstate = new List<FormInquiryEstate>();

				//Now lets populate the FormInquiryEstate details into the list of formInquiryEstates
				foreach (DataRow row in table.Rows)
				{
					FormInquiryEstate formInquiryEstate = ConvertRowToFormInquiryEstate(row);
					listFormInquiryEstate.Add(formInquiryEstate);
				}
			}
		}

		return listFormInquiryEstate;
	}

	private FormInquiryEstate ConvertRowToFormInquiryEstate(DataRow row)
	{
		FormInquiryEstate formInquiryEstate = new FormInquiryEstate();
		formInquiryEstate.FormInquiryEstateID = (row["FormInquiryEstateID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateID"]) : 0 ;
		formInquiryEstate.FormInquiryEstatePrintRegisterInformationID = row["FormInquiryEstatePrintRegisterInformationID"].ToString();
		formInquiryEstate.FormInquiryEstatePrintRegisterDate = row["FormInquiryEstatePrintRegisterDate"].ToString();
		formInquiryEstate.FormInquiryEstateRuleComment1 = row["FormInquiryEstateRuleComment1"].ToString();
		formInquiryEstate.FormInquiryEstateRuleComment2 = row["FormInquiryEstateRuleComment2"].ToString();
		formInquiryEstate.FormInquiryEstateRegisterInformationDate = row["FormInquiryEstateRegisterInformationDate"].ToString();
		formInquiryEstate.FormInquiryEstateDossierClasses = row["FormInquiryEstateDossierClasses"].ToString();
		formInquiryEstate.FormInquiryEstateDeadDeathDate = row["FormInquiryEstateDeadDeathDate"].ToString();
		formInquiryEstate.FormInquiryEstateTaxUnitCode1 = row["FormInquiryEstateTaxUnitCode1"].ToString();
		formInquiryEstate.FormInquiryEstateUser1TaxUnitCode = row["FormInquiryEstateUser1TaxUnitCode"].ToString();
		formInquiryEstate.FormInquiryEstateUser2TaxGroupCode = row["FormInquiryEstateUser2TaxGroupCode"].ToString();
		formInquiryEstate.FormInquiryEstateTaxUnitCode2 = row["FormInquiryEstateTaxUnitCode2"].ToString();
		formInquiryEstate.FormInquiryEstateDeclarationID = (row["FormInquiryEstateDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateDeclarationID"]) : 0 ;
		formInquiryEstate.FormInquiryEstateRegisterarUserNationalCode = (row["FormInquiryEstateRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateRegisterarUserNationalCode"]) : 0 ;
		formInquiryEstate.FormInquiryEstateFormInquiryResponseID = (row["FormInquiryEstateFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateFormInquiryResponseID"]) : 0 ;
		formInquiryEstate.FormInquiryEstateDeadFullName = row["FormInquiryEstateDeadFullName"].ToString();
		formInquiryEstate.FormInquiryEstateUser1FullName = row["FormInquiryEstateUser1FullName"].ToString();
		formInquiryEstate.FormInquiryEstateUser2FullName = row["FormInquiryEstateUser2FullName"].ToString();
		formInquiryEstate.FormInquiryEstateReciver = row["FormInquiryEstateReciver"].ToString();
		formInquiryEstate.FormInquiryEstateReciverRole = row["FormInquiryEstateReciverRole"].ToString();
		formInquiryEstate.FormInquiryEstateReciverHeritageDescription = row["FormInquiryEstateReciverHeritageDescription"].ToString();
		formInquiryEstate.FormInquiryEstateRegisterInformationID = (row["FormInquiryEstateRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryEstateRegisterInformationID"]) : 0 ;
		return formInquiryEstate;
	}
	public List<FormInquiryGoodWillEvaluation> GetListFormInquiryGoodWillEvaluation(Int64 declarationID)
	{
		List<FormInquiryGoodWillEvaluation> listFormInquiryGoodWillEvaluation = new List<FormInquiryGoodWillEvaluation>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillEvaluationlDeclarationID", declarationID)
		};

		//Lets get the list of FormInquiryGoodWillEvaluation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryGoodWillEvaluation_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formInquiryGoodWillEvaluation
				listFormInquiryGoodWillEvaluation = new List<FormInquiryGoodWillEvaluation>();

				//Now lets populate the FormInquiryGoodWillEvaluation details into the list of formInquiryGoodWillEvaluations
				foreach (DataRow row in table.Rows)
				{
					FormInquiryGoodWillEvaluation formInquiryGoodWillEvaluation = ConvertRowToFormInquiryGoodWillEvaluation(row);
					listFormInquiryGoodWillEvaluation.Add(formInquiryGoodWillEvaluation);
				}
			}
		}

		return listFormInquiryGoodWillEvaluation;
	}

	private FormInquiryGoodWillEvaluation ConvertRowToFormInquiryGoodWillEvaluation(DataRow row)
	{
		FormInquiryGoodWillEvaluation formInquiryGoodWillEvaluation = new FormInquiryGoodWillEvaluation();
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationID = (row["FormInquiryGoodWillEvaluationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillEvaluationID"]) : 0 ;
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPrintRegisterInformationID = row["FormInquiryGoodWillEvaluationPrintRegisterInformationID"].ToString();
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPrintRegisterDate = row["FormInquiryGoodWillEvaluationPrintRegisterDate"].ToString();
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationAddress = row["FormInquiryGoodWillEvaluationAddress"].ToString();
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser1FullName = row["FormInquiryGoodWillEvaluationUser1FullName"].ToString();
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser2FullName = row["FormInquiryGoodWillEvaluationUser2FullName"].ToString();
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser1TaxUnitCode = row["FormInquiryGoodWillEvaluationUser1TaxUnitCode"].ToString();
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser2TaxGroupCode = row["FormInquiryGoodWillEvaluationUser2TaxGroupCode"].ToString();
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPhoneNumber = row["FormInquiryGoodWillEvaluationPhoneNumber"].ToString();
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationlRegisterInformationDate = row["FormInquiryGoodWillEvaluationlRegisterInformationDate"].ToString();
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDossierClasses = row["FormInquiryGoodWillEvaluationDossierClasses"].ToString();
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDeadDeathDate = row["FormInquiryGoodWillEvaluationDeadDeathDate"].ToString();
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationRegisterInformationID = (row["FormInquiryGoodWillEvaluationRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillEvaluationRegisterInformationID"]) : 0 ;
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationlDeclarationID = (row["FormInquiryGoodWillEvaluationlDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillEvaluationlDeclarationID"]) : 0 ;
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationRegisterarUserNationalCode = (row["FormInquiryGoodWillEvaluationRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillEvaluationRegisterarUserNationalCode"]) : 0 ;
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationFormInquiryResponseID = (row["FormInquiryGoodWillEvaluationFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillEvaluationFormInquiryResponseID"]) : 0 ;
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDeadFullName = row["FormInquiryGoodWillEvaluationDeadFullName"].ToString();
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationInquiryTo = row["FormInquiryGoodWillEvaluationInquiryTo"].ToString();
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationSixth = row["FormInquiryGoodWillEvaluationSixth"].ToString();
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationFromGoodwill = row["FormInquiryGoodWillEvaluationFromGoodwill"].ToString();
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPlaque = row["FormInquiryGoodWillEvaluationPlaque"].ToString();
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationSection = row["FormInquiryGoodWillEvaluationSection"].ToString();
		return formInquiryGoodWillEvaluation;
	}
	public List<FormInquiryGoodWillScore> GetListFormInquiryGoodWillScore(Int64 declarationID)
	{
		List<FormInquiryGoodWillScore> listFormInquiryGoodWillScore = new List<FormInquiryGoodWillScore>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillScoreDeclarationID", declarationID)
		};

		//Lets get the list of FormInquiryGoodWillScore records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryGoodWillScore_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formInquiryGoodWillScore
				listFormInquiryGoodWillScore = new List<FormInquiryGoodWillScore>();

				//Now lets populate the FormInquiryGoodWillScore details into the list of formInquiryGoodWillScores
				foreach (DataRow row in table.Rows)
				{
					FormInquiryGoodWillScore formInquiryGoodWillScore = ConvertRowToFormInquiryGoodWillScore(row);
					listFormInquiryGoodWillScore.Add(formInquiryGoodWillScore);
				}
			}
		}

		return listFormInquiryGoodWillScore;
	}

	private FormInquiryGoodWillScore ConvertRowToFormInquiryGoodWillScore(DataRow row)
	{
		FormInquiryGoodWillScore formInquiryGoodWillScore = new FormInquiryGoodWillScore();
		formInquiryGoodWillScore.FormInquiryGoodWillScorelID = (row["FormInquiryGoodWillScorelID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScorelID"]) : 0 ;
		formInquiryGoodWillScore.FormInquiryGoodWillScorePrintRegisterInformationID = row["FormInquiryGoodWillScorePrintRegisterInformationID"].ToString();
		formInquiryGoodWillScore.FormInquiryGoodWillScorePrintRegisterDate = row["FormInquiryGoodWillScorePrintRegisterDate"].ToString();
		formInquiryGoodWillScore.FormInquiryGoodWillScoreUser2TaxGroupCode = row["FormInquiryGoodWillScoreUser2TaxGroupCode"].ToString();
		formInquiryGoodWillScore.FormInquiryGoodWillScoreDeadFullName = row["FormInquiryGoodWillScoreDeadFullName"].ToString();
		formInquiryGoodWillScore.FormInquiryGoodWillScoreComment = row["FormInquiryGoodWillScoreComment"].ToString();
		formInquiryGoodWillScore.FormInquiryGoodWillScoreTitle = row["FormInquiryGoodWillScoreTitle"].ToString();
		formInquiryGoodWillScore.FormInquiryGoodWillScorePlaque = row["FormInquiryGoodWillScorePlaque"].ToString();
		formInquiryGoodWillScore.FormInquiryGoodWillScorelSection = row["FormInquiryGoodWillScorelSection"].ToString();
		formInquiryGoodWillScore.FormInquiryGoodWillScorelRegisterInformationDate = row["FormInquiryGoodWillScorelRegisterInformationDate"].ToString();
		formInquiryGoodWillScore.FormInquiryGoodWillScoreDossierClasses = row["FormInquiryGoodWillScoreDossierClasses"].ToString();
		formInquiryGoodWillScore.FormInquiryGoodWillScoreDeadDeathDate = row["FormInquiryGoodWillScoreDeadDeathDate"].ToString();
		formInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterInformationID = (row["FormInquiryGoodWillScoreRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScoreRegisterInformationID"]) : 0 ;
		formInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterarUserNationalCode = (row["FormInquiryGoodWillScoreRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScoreRegisterarUserNationalCode"]) : 0 ;
		formInquiryGoodWillScore.FormInquiryGoodWillScoreDeclarationID = (row["FormInquiryGoodWillScoreDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScoreDeclarationID"]) : 0 ;
		formInquiryGoodWillScore.FormInquiryGoodWillScoreFormInquiryResponseID = (row["FormInquiryGoodWillScoreFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScoreFormInquiryResponseID"]) : 0 ;
		formInquiryGoodWillScore.FormInquiryGoodWillScoreInquiryTo = row["FormInquiryGoodWillScoreInquiryTo"].ToString();
		formInquiryGoodWillScore.FormInquiryGoodWillScoreRuleComment = row["FormInquiryGoodWillScoreRuleComment"].ToString();
		formInquiryGoodWillScore.FormInquiryGoodWillScoreTaxUnitCode = row["FormInquiryGoodWillScoreTaxUnitCode"].ToString();
		formInquiryGoodWillScore.FormInquiryGoodWillScoreUser1FullName = row["FormInquiryGoodWillScoreUser1FullName"].ToString();
		formInquiryGoodWillScore.FormInquiryGoodWillScoreUser2FullName = row["FormInquiryGoodWillScoreUser2FullName"].ToString();
		formInquiryGoodWillScore.FormInquiryGoodWillScoreUser1TaxUnitCode = row["FormInquiryGoodWillScoreUser1TaxUnitCode"].ToString();
		formInquiryGoodWillScore.FormInquiryGoodWillScoreAddress = row["FormInquiryGoodWillScoreAddress"].ToString();
		formInquiryGoodWillScore.FormInquiryGoodWillScoreSixth = row["FormInquiryGoodWillScoreSixth"].ToString();
		return formInquiryGoodWillScore;
	}
	public List<FormInquiryOther> GetListFormInquiryOther(Int64 declarationID)
	{
		List<FormInquiryOther> listFormInquiryOther = new List<FormInquiryOther>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryOtherDeclarationID", declarationID)
		};

		//Lets get the list of FormInquiryOther records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryOther_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formInquiryOther
				listFormInquiryOther = new List<FormInquiryOther>();

				//Now lets populate the FormInquiryOther details into the list of formInquiryOthers
				foreach (DataRow row in table.Rows)
				{
					FormInquiryOther formInquiryOther = ConvertRowToFormInquiryOther(row);
					listFormInquiryOther.Add(formInquiryOther);
				}
			}
		}

		return listFormInquiryOther;
	}

	private FormInquiryOther ConvertRowToFormInquiryOther(DataRow row)
	{
		FormInquiryOther formInquiryOther = new FormInquiryOther();
		formInquiryOther.FormInquiryOtherID = (row["FormInquiryOtherID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherID"]) : 0 ;
		formInquiryOther.FormInquiryOtherPrintRegisterInformationID = row["FormInquiryOtherPrintRegisterInformationID"].ToString();
		formInquiryOther.FormInquiryOtherPrintRegisterDate = row["FormInquiryOtherPrintRegisterDate"].ToString();
		formInquiryOther.FormInquiryOtherRegisterInformationDate = row["FormInquiryOtherRegisterInformationDate"].ToString();
		formInquiryOther.FormInquiryOtherDossierClasses = row["FormInquiryOtherDossierClasses"].ToString();
		formInquiryOther.FormInquiryOtherDeadDeathDate = row["FormInquiryOtherDeadDeathDate"].ToString();
		formInquiryOther.FormInquiryOtherRegisterInformationID = (row["FormInquiryOtherRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherRegisterInformationID"]) : 0 ;
		formInquiryOther.FormInquiryOtherRegisterarUserNationalCode = (row["FormInquiryOtherRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherRegisterarUserNationalCode"]) : 0 ;
		formInquiryOther.FormInquiryOtherDeclarationID = (row["FormInquiryOtherDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherDeclarationID"]) : 0 ;
		formInquiryOther.FormInquiryOtherFormInquiryResponseID = (row["FormInquiryOtherFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryOtherFormInquiryResponseID"]) : 0 ;
		formInquiryOther.FormInquiryOtherDescription = row["FormInquiryOtherDescription"].ToString();
		formInquiryOther.FormInquiryOtherReciever = row["FormInquiryOtherReciever"].ToString();
		formInquiryOther.FormInquiryOtherDeadFullName = row["FormInquiryOtherDeadFullName"].ToString();
		formInquiryOther.FormInquiryOtherTaxUnitCode = row["FormInquiryOtherTaxUnitCode"].ToString();
		formInquiryOther.FormInquiryOtherUser1FullName = row["FormInquiryOtherUser1FullName"].ToString();
		formInquiryOther.FormInquiryOtherUser2FullName = row["FormInquiryOtherUser2FullName"].ToString();
		formInquiryOther.FormInquiryOtherUser1TaxUnitCode = row["FormInquiryOtherUser1TaxUnitCode"].ToString();
		formInquiryOther.FormInquiryOtherUser2TaxGroupCode = row["FormInquiryOtherUser2TaxGroupCode"].ToString();
		formInquiryOther.FormInquiryOtherHeritageDescription = row["FormInquiryOtherHeritageDescription"].ToString();
		return formInquiryOther;
	}
	public List<FormInquiryTransferRightEvaluation> GetListFormInquiryTransferRightEvaluation(Int64 declarationID)
	{
		List<FormInquiryTransferRightEvaluation> listFormInquiryTransferRightEvaluation = new List<FormInquiryTransferRightEvaluation>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightEvaluationlDeclarationID", declarationID)
		};

		//Lets get the list of FormInquiryTransferRightEvaluation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryTransferRightEvaluation_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formInquiryTransferRightEvaluation
				listFormInquiryTransferRightEvaluation = new List<FormInquiryTransferRightEvaluation>();

				//Now lets populate the FormInquiryTransferRightEvaluation details into the list of formInquiryTransferRightEvaluations
				foreach (DataRow row in table.Rows)
				{
					FormInquiryTransferRightEvaluation formInquiryTransferRightEvaluation = ConvertRowToFormInquiryTransferRightEvaluation(row);
					listFormInquiryTransferRightEvaluation.Add(formInquiryTransferRightEvaluation);
				}
			}
		}

		return listFormInquiryTransferRightEvaluation;
	}

	private FormInquiryTransferRightEvaluation ConvertRowToFormInquiryTransferRightEvaluation(DataRow row)
	{
		FormInquiryTransferRightEvaluation formInquiryTransferRightEvaluation = new FormInquiryTransferRightEvaluation();
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationID = (row["FormInquiryTransferRightEvaluationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightEvaluationID"]) : 0 ;
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPrintRegisterInformationID = row["FormInquiryTransferRightEvaluationPrintRegisterInformationID"].ToString();
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPrintRegisterDate = row["FormInquiryTransferRightEvaluationPrintRegisterDate"].ToString();
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationAddress = row["FormInquiryTransferRightEvaluationAddress"].ToString();
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser1FullName = row["FormInquiryTransferRightEvaluationUser1FullName"].ToString();
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser2FullName = row["FormInquiryTransferRightEvaluationUser2FullName"].ToString();
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser1TaxUnitCode = row["FormInquiryTransferRightEvaluationUser1TaxUnitCode"].ToString();
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser2TaxGroupCode = row["FormInquiryTransferRightEvaluationUser2TaxGroupCode"].ToString();
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPhoneNumber = row["FormInquiryTransferRightEvaluationPhoneNumber"].ToString();
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationlRegisterInformationDate = row["FormInquiryTransferRightEvaluationlRegisterInformationDate"].ToString();
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDossierClasses = row["FormInquiryTransferRightEvaluationDossierClasses"].ToString();
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDeadDeathDate = row["FormInquiryTransferRightEvaluationDeadDeathDate"].ToString();
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationRegisterInformationID = (row["FormInquiryTransferRightEvaluationRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightEvaluationRegisterInformationID"]) : 0 ;
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationlDeclarationID = (row["FormInquiryTransferRightEvaluationlDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightEvaluationlDeclarationID"]) : 0 ;
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationRegisterarUserNationalCode = (row["FormInquiryTransferRightEvaluationRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightEvaluationRegisterarUserNationalCode"]) : 0 ;
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationFormInquiryResponseID = (row["FormInquiryTransferRightEvaluationFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightEvaluationFormInquiryResponseID"]) : 0 ;
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDeadFullName = row["FormInquiryTransferRightEvaluationDeadFullName"].ToString();
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationInquiryTo = row["FormInquiryTransferRightEvaluationInquiryTo"].ToString();
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationSixth = row["FormInquiryTransferRightEvaluationSixth"].ToString();
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationFromTransferRight = row["FormInquiryTransferRightEvaluationFromTransferRight"].ToString();
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPlaque = row["FormInquiryTransferRightEvaluationPlaque"].ToString();
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationSection = row["FormInquiryTransferRightEvaluationSection"].ToString();
		return formInquiryTransferRightEvaluation;
	}
	public List<FormInquiryTransferRightScore> GetListFormInquiryTransferRightScore(Int64 declarationID)
	{
		List<FormInquiryTransferRightScore> listFormInquiryTransferRightScore = new List<FormInquiryTransferRightScore>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightScoreDeclarationID", declarationID)
		};

		//Lets get the list of FormInquiryTransferRightScore records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryTransferRightScore_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formInquiryTransferRightScore
				listFormInquiryTransferRightScore = new List<FormInquiryTransferRightScore>();

				//Now lets populate the FormInquiryTransferRightScore details into the list of formInquiryTransferRightScores
				foreach (DataRow row in table.Rows)
				{
					FormInquiryTransferRightScore formInquiryTransferRightScore = ConvertRowToFormInquiryTransferRightScore(row);
					listFormInquiryTransferRightScore.Add(formInquiryTransferRightScore);
				}
			}
		}

		return listFormInquiryTransferRightScore;
	}

	private FormInquiryTransferRightScore ConvertRowToFormInquiryTransferRightScore(DataRow row)
	{
		FormInquiryTransferRightScore formInquiryTransferRightScore = new FormInquiryTransferRightScore();
		formInquiryTransferRightScore.FormInquiryTransferRightScorelID = (row["FormInquiryTransferRightScorelID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScorelID"]) : 0 ;
		formInquiryTransferRightScore.FormInquiryTransferRightScorePrintRegisterInformationID = row["FormInquiryTransferRightScorePrintRegisterInformationID"].ToString();
		formInquiryTransferRightScore.FormInquiryTransferRightScorePrintRegisterDate = row["FormInquiryTransferRightScorePrintRegisterDate"].ToString();
		formInquiryTransferRightScore.FormInquiryTransferRightScoreUser2TaxGroupCode = row["FormInquiryTransferRightScoreUser2TaxGroupCode"].ToString();
		formInquiryTransferRightScore.FormInquiryTransferRightScoreDeadFullName = row["FormInquiryTransferRightScoreDeadFullName"].ToString();
		formInquiryTransferRightScore.FormInquiryTransferRightScoreComment = row["FormInquiryTransferRightScoreComment"].ToString();
		formInquiryTransferRightScore.FormInquiryTransferRightScoreTitle = row["FormInquiryTransferRightScoreTitle"].ToString();
		formInquiryTransferRightScore.FormInquiryTransferRightScorePlaque = row["FormInquiryTransferRightScorePlaque"].ToString();
		formInquiryTransferRightScore.FormInquiryTransferRightScorelSection = row["FormInquiryTransferRightScorelSection"].ToString();
		formInquiryTransferRightScore.FormInquiryTransferRightScorelRegisterInformationDate = row["FormInquiryTransferRightScorelRegisterInformationDate"].ToString();
		formInquiryTransferRightScore.FormInquiryTransferRightScoreDossierClasses = row["FormInquiryTransferRightScoreDossierClasses"].ToString();
		formInquiryTransferRightScore.FormInquiryTransferRightScoreDeadDeathDate = row["FormInquiryTransferRightScoreDeadDeathDate"].ToString();
		formInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterInformationID = (row["FormInquiryTransferRightScoreRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScoreRegisterInformationID"]) : 0 ;
		formInquiryTransferRightScore.FormInquiryTransferRightScoreRegisterarUserNationalCode = (row["FormInquiryTransferRightScoreRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScoreRegisterarUserNationalCode"]) : 0 ;
		formInquiryTransferRightScore.FormInquiryTransferRightScoreDeclarationID = (row["FormInquiryTransferRightScoreDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScoreDeclarationID"]) : 0 ;
		formInquiryTransferRightScore.FormInquiryTransferRightScoreFormInquiryResponseID = (row["FormInquiryTransferRightScoreFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightScoreFormInquiryResponseID"]) : 0 ;
		formInquiryTransferRightScore.FormInquiryTransferRightScoreInquiryTo = row["FormInquiryTransferRightScoreInquiryTo"].ToString();
		formInquiryTransferRightScore.FormInquiryTransferRightScoreRuleComment = row["FormInquiryTransferRightScoreRuleComment"].ToString();
		formInquiryTransferRightScore.FormInquiryTransferRightScoreTaxUnitCode = row["FormInquiryTransferRightScoreTaxUnitCode"].ToString();
		formInquiryTransferRightScore.FormInquiryTransferRightScoreUser1FullName = row["FormInquiryTransferRightScoreUser1FullName"].ToString();
		formInquiryTransferRightScore.FormInquiryTransferRightScoreUser2FullName = row["FormInquiryTransferRightScoreUser2FullName"].ToString();
		formInquiryTransferRightScore.FormInquiryTransferRightScoreUser1TaxUnitCode = row["FormInquiryTransferRightScoreUser1TaxUnitCode"].ToString();
		formInquiryTransferRightScore.FormInquiryTransferRightScoreAddress = row["FormInquiryTransferRightScoreAddress"].ToString();
		formInquiryTransferRightScore.FormInquiryTransferRightScoreSixth = row["FormInquiryTransferRightScoreSixth"].ToString();
		return formInquiryTransferRightScore;
	}
	public List<FormTaxBill> GetListFormTaxBill(Int64 declarationID)
	{
		List<FormTaxBill> listFormTaxBill = new List<FormTaxBill>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormTaxBillDeclarationID", declarationID)
		};

		//Lets get the list of FormTaxBill records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormTaxBill_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formTaxBill
				listFormTaxBill = new List<FormTaxBill>();

				//Now lets populate the FormTaxBill details into the list of formTaxBills
				foreach (DataRow row in table.Rows)
				{
					FormTaxBill formTaxBill = ConvertRowToFormTaxBill(row);
					listFormTaxBill.Add(formTaxBill);
				}
			}
		}

		return listFormTaxBill;
	}

	private FormTaxBill ConvertRowToFormTaxBill(DataRow row)
	{
		FormTaxBill formTaxBill = new FormTaxBill();
		formTaxBill.FormTaxBillID = (row["FormTaxBillID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillID"]) : 0 ;
		formTaxBill.FormTaxBillPrintRegisterDate = row["FormTaxBillPrintRegisterDate"].ToString();
		formTaxBill.FormTaxBillPrintRegisterInformationID = row["FormTaxBillPrintRegisterInformationID"].ToString();
		formTaxBill.FormTaxBillDossierClasses = row["FormTaxBillDossierClasses"].ToString();
		formTaxBill.FormTaxBillUser2Code = row["FormTaxBillUser2Code"].ToString();
		formTaxBill.FormTaxBillDescription = row["FormTaxBillDescription"].ToString();
		formTaxBill.FormTaxBillTaxTotalLetter = row["FormTaxBillTaxTotalLetter"].ToString();
		formTaxBill.FormTaxBillBillType = row["FormTaxBillBillType"].ToString();
		formTaxBill.FormTaxBillTaxTotalDescription = row["FormTaxBillTaxTotalDescription"].ToString();
		formTaxBill.FormTaxBillTaxTypeA = (row["FormTaxBillTaxTypeA"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTaxTypeA"]) : 0 ;
		formTaxBill.FormTaxBillTaxTypeB = (row["FormTaxBillTaxTypeB"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTaxTypeB"]) : 0 ;
		formTaxBill.FormTaxBillTaxTotal = (row["FormTaxBillTaxTotal"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTaxTotal"]) : 0 ;
		formTaxBill.FormTaxBillTotalShare = (row["FormTaxBillTotalShare"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTotalShare"]) : 0 ;
		formTaxBill.FormTaxBillDeclarationID = (row["FormTaxBillDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillDeclarationID"]) : 0 ;
		formTaxBill.FormTaxBillRegisterInformationID = (row["FormTaxBillRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillRegisterInformationID"]) : 0 ;
		formTaxBill.FormTaxBillRegisterarUserNationalCode = (row["FormTaxBillRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillRegisterarUserNationalCode"]) : 0 ;
		formTaxBill.FormTaxBillDeadNationalCode = (row["FormTaxBillDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillDeadNationalCode"]) : 0 ;
		formTaxBill.FormTaxBillDeadDeathDate = row["FormTaxBillDeadDeathDate"].ToString();
		formTaxBill.FormTaxBillRegisterInformationDate = row["FormTaxBillRegisterInformationDate"].ToString();
		formTaxBill.FormTaxBillTaxOfficeTitle = row["FormTaxBillTaxOfficeTitle"].ToString();
		formTaxBill.FormTaxBillDeadFullName = row["FormTaxBillDeadFullName"].ToString();
		formTaxBill.FormTaxBillHeirsNumberSummury = row["FormTaxBillHeirsNumberSummury"].ToString();
		formTaxBill.FormTaxBillUser2FullName = row["FormTaxBillUser2FullName"].ToString();
		formTaxBill.FormTaxBillUser1FullName = row["FormTaxBillUser1FullName"].ToString();
		formTaxBill.FormTaxBillUser1Code = row["FormTaxBillUser1Code"].ToString();
		return formTaxBill;
	}
	public List<FormTaxPaymentCertificate> GetListFormTaxPaymentCertificate(Int64 declarationID)
	{
		List<FormTaxPaymentCertificate> listFormTaxPaymentCertificate = new List<FormTaxPaymentCertificate>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@FormTaxPayementCertificateDeclarationID", declarationID)
		};

		//Lets get the list of FormTaxPaymentCertificate records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormTaxPaymentCertificate_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formTaxPaymentCertificate
				listFormTaxPaymentCertificate = new List<FormTaxPaymentCertificate>();

				//Now lets populate the FormTaxPaymentCertificate details into the list of formTaxPaymentCertificates
				foreach (DataRow row in table.Rows)
				{
					FormTaxPaymentCertificate formTaxPaymentCertificate = ConvertRowToFormTaxPaymentCertificate(row);
					listFormTaxPaymentCertificate.Add(formTaxPaymentCertificate);
				}
			}
		}

		return listFormTaxPaymentCertificate;
	}

	private FormTaxPaymentCertificate ConvertRowToFormTaxPaymentCertificate(DataRow row)
	{
		FormTaxPaymentCertificate formTaxPaymentCertificate = new FormTaxPaymentCertificate();
		formTaxPaymentCertificate.FormTaxPayementCertificateID = (row["FormTaxPayementCertificateID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateID"]) : 0 ;
		formTaxPaymentCertificate.FormTaxPayementCertificatePrintRegisterDate = row["FormTaxPayementCertificatePrintRegisterDate"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificatePrintRegisterInformationID = row["FormTaxPayementCertificatePrintRegisterInformationID"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeathMounth = row["FormTaxPayementCertificateDeathMounth"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeathYear = row["FormTaxPayementCertificateDeathYear"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeathCity = row["FormTaxPayementCertificateDeathCity"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDescription1 = row["FormTaxPayementCertificateDescription1"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDescription2 = row["FormTaxPayementCertificateDescription2"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDescription3 = row["FormTaxPayementCertificateDescription3"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateSource = row["FormTaxPayementCertificateHeirsCertificateSource"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateBranch = row["FormTaxPayementCertificateHeirsCertificateBranch"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeadName = row["FormTaxPayementCertificateDeadName"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeadLastName = row["FormTaxPayementCertificateDeadLastName"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeadCertificateNumber = row["FormTaxPayementCertificateDeadCertificateNumber"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeathDay = row["FormTaxPayementCertificateDeathDay"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateIssuanceCity = row["FormTaxPayementCertificateIssuanceCity"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestNumber = row["FormTaxPayementCertificateDeclarationRequestNumber"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestResource = row["FormTaxPayementCertificateDeclarationRequestResource"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateApplicantFullName = row["FormTaxPayementCertificateApplicantFullName"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateApplicantFatherName = row["FormTaxPayementCertificateApplicantFatherName"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDescription4 = row["FormTaxPayementCertificateDescription4"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDescriptionHeritage = row["FormTaxPayementCertificateDescriptionHeritage"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateRequestNumber = row["FormTaxPayementCertificateRequestNumber"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateUser1FullName = row["FormTaxPayementCertificateUser1FullName"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateUser2FullName = row["FormTaxPayementCertificateUser2FullName"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateRegisterInformationID = (row["FormTaxPayementCertificateRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateRegisterInformationID"]) : 0 ;
		formTaxPaymentCertificate.FormTaxPayementCertificateDeadNationalCode = (row["FormTaxPayementCertificateDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateDeadNationalCode"]) : 0 ;
		formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationID = (row["FormTaxPayementCertificateDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateDeclarationID"]) : 0 ;
		formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeZipCode = (row["FormTaxPayementCertificateTaxOfficeZipCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateTaxOfficeZipCode"]) : 0 ;
		formTaxPaymentCertificate.FormTaxPayementCertificateApplicantNationalCode = (row["FormTaxPayementCertificateApplicantNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateApplicantNationalCode"]) : 0 ;
		formTaxPaymentCertificate.FormTaxPayementCertificateZipCode = (row["FormTaxPayementCertificateZipCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateZipCode"]) : 0 ;
		formTaxPaymentCertificate.FormTaxPayementCertificateApplicantName = row["FormTaxPayementCertificateApplicantName"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateRegisterDate = row["FormTaxPayementCertificateRegisterDate"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateDate = row["FormTaxPayementCertificateHeirsCertificateDate"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateRequestDate = row["FormTaxPayementCertificateRequestDate"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestDate = row["FormTaxPayementCertificateDeclarationRequestDate"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateApplicantBirthDate = row["FormTaxPayementCertificateApplicantBirthDate"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDossierClasses = row["FormTaxPayementCertificateDossierClasses"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeTitle = row["FormTaxPayementCertificateTaxOfficeTitle"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeCity = row["FormTaxPayementCertificateTaxOfficeCity"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeAddress = row["FormTaxPayementCertificateTaxOfficeAddress"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficePhoneNumber = row["FormTaxPayementCertificateTaxOfficePhoneNumber"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateNumber = row["FormTaxPayementCertificateHeirsCertificateNumber"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeadFatherName = row["FormTaxPayementCertificateDeadFatherName"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificatePhoneNumber = row["FormTaxPayementCertificatePhoneNumber"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeadIssuanceCity = row["FormTaxPayementCertificateDeadIssuanceCity"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateApplicantBirthCity = row["FormTaxPayementCertificateApplicantBirthCity"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateApplicantCertificateNumber = row["FormTaxPayementCertificateApplicantCertificateNumber"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateApplicantIssuanceCity = row["FormTaxPayementCertificateApplicantIssuanceCity"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateApplicantRole = row["FormTaxPayementCertificateApplicantRole"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateAddress = row["FormTaxPayementCertificateAddress"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateCommercialNumer = row["FormTaxPayementCertificateCommercialNumer"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeCode = (row["FormTaxPayementCertificateTaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["FormTaxPayementCertificateTaxOfficeCode"]) : 0 ;
		formTaxPaymentCertificate.FormTaxPayementCertificateTaxGroupCode = (row["FormTaxPayementCertificateTaxGroupCode"] != DBNull.Value) ? Convert.ToInt32(row["FormTaxPayementCertificateTaxGroupCode"]) : 0 ;
		formTaxPaymentCertificate.FormTaxPayementCertificateTaxUnitCode = (row["FormTaxPayementCertificateTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["FormTaxPayementCertificateTaxUnitCode"]) : 0 ;
		return formTaxPaymentCertificate;
	}
	public List<Hajj> GetListHajj(Int64 declarationID)
	{
		List<Hajj> listHajj = new List<Hajj>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of Hajj records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Hajj_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of hajj
				listHajj = new List<Hajj>();

				//Now lets populate the Hajj details into the list of hajjs
				foreach (DataRow row in table.Rows)
				{
					Hajj hajj = ConvertRowToHajj(row);
					listHajj.Add(hajj);
				}
			}
		}

		return listHajj;
	}

	private Hajj ConvertRowToHajj(DataRow row)
	{
		Hajj hajj = new Hajj();
		hajj.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		hajj.HajjTypeIDTitle = row["HajjTypeIDTitle"].ToString();
		hajj.BankInquiryHajjIDTitle = row["BankInquiryHajjIDTitle"].ToString();
		hajj.FactorDate = row["FactorDate"].ToString();
		hajj.FactorNumber = row["FactorNumber"].ToString();
		hajj.HajjTypeID = (row["HajjTypeID"] != DBNull.Value) ? Convert.ToInt32(row["HajjTypeID"]) : 0 ;
		hajj.BankInquiryHajjID = (row["BankInquiryHajjID"] != DBNull.Value) ? Convert.ToInt32(row["BankInquiryHajjID"]) : 0 ;
		hajj.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

		hajj.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		hajj.StageTitle = row["StageTitle"].ToString();
		hajj.RegisterDate = row["RegisterDate"].ToString();
		hajj.OldRegisterDate = row["OldRegisterDate"].ToString();
		hajj.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		hajj.Sixth = row["Sixth"].ToString();
		hajj.PreviousOwner = row["PreviousOwner"].ToString();
		hajj.Comment = row["Comment"].ToString();
		hajj.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		hajj.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		hajj.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		hajj.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		hajj.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		hajj.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		hajj.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		hajj.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		hajj.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		hajj.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return hajj;
	}
	public List<Heir> GetListHeir(Int64 declarationID)
	{
		List<Heir> listHeir = new List<Heir>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of Heir records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Heir_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of heir
				listHeir = new List<Heir>();

				//Now lets populate the Heir details into the list of heirs
				foreach (DataRow row in table.Rows)
				{
					Heir heir = ConvertRowToHeir(row);
					listHeir.Add(heir);
				}
			}
		}

		return listHeir;
	}

	private Heir ConvertRowToHeir(DataRow row)
	{
		Heir heir = new Heir();
		heir.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
		heir.RelationIDTitle = row["RelationIDTitle"].ToString();
		heir.EducationStateIDTitle = row["EducationStateIDTitle"].ToString();
		heir.MarriageIDTitle = row["MarriageIDTitle"].ToString();
		heir.NationalityIDTitle = row["NationalityIDTitle"].ToString();
		heir.PhysicalStateIDTitle = row["PhysicalStateIDTitle"].ToString();
		heir.ResidenceIDTitle = row["ResidenceIDTitle"].ToString();
		heir.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		heir.OldRegisterDate = row["OldRegisterDate"].ToString();
		heir.RelationID = (row["RelationID"] != DBNull.Value) ? Convert.ToInt32(row["RelationID"]) : 0 ;
		heir.NationalityID = (row["NationalityID"] != DBNull.Value) ? Convert.ToInt32(row["NationalityID"]) : 0 ;
		heir.ResidenceID = (row["ResidenceID"] != DBNull.Value) ? Convert.ToInt32(row["ResidenceID"]) : 0 ;
		heir.PhysicalStateID = (row["PhysicalStateID"] != DBNull.Value) ? Convert.ToInt32(row["PhysicalStateID"]) : 0 ;
		heir.EducationStateID = (row["EducationStateID"] != DBNull.Value) ? Convert.ToInt32(row["EducationStateID"]) : 0 ;
		heir.MarriageID = (row["MarriageID"] != DBNull.Value) ? Convert.ToInt32(row["MarriageID"]) : 0 ;
		heir.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		heir.AgreementTypeID = (row["AgreementTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AgreementTypeID"]) : 0 ;
		heir.DeclerativeShare = (row["DeclerativeShare"] != DBNull.Value) ? Convert.ToSingle(row["DeclerativeShare"]) : 0 ;
		heir.DiagnosisShare = (row["DiagnosisShare"] != DBNull.Value) ? Convert.ToSingle(row["DiagnosisShare"]) : 0 ;
		heir.HandShare = (row["HandShare"] != DBNull.Value) ? Convert.ToSingle(row["HandShare"]) : 0 ;
		heir.AdjustmentTaxValue = (row["AdjustmentTaxValue"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentTaxValue"]) : 0 ;
		heir.AdjustmentIncomeValue = (row["AdjustmentIncomeValue"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentIncomeValue"]) : 0 ;
		heir.CommissionAdjustmentShareValue1 = (row["CommissionAdjustmentShareValue1"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue1"]) : 0 ;
		heir.CommissionAdjustmentIncomeValue4 = (row["CommissionAdjustmentIncomeValue4"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue4"]) : 0 ;
		heir.CommissionAdjustmentShareValue5 = (row["CommissionAdjustmentShareValue5"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue5"]) : 0 ;
		heir.CommissionAdjustmentIncomeValue5 = (row["CommissionAdjustmentIncomeValue5"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue5"]) : 0 ;
		heir.CommissionAdjustmentShareValue6 = (row["CommissionAdjustmentShareValue6"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue6"]) : 0 ;
		heir.CommissionAdjustmentIncomeValue6 = (row["CommissionAdjustmentIncomeValue6"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue6"]) : 0 ;
		heir.CommissionAdjustmentIncomeValue1 = (row["CommissionAdjustmentIncomeValue1"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue1"]) : 0 ;
		heir.CommissionAdjustmentShareValue2 = (row["CommissionAdjustmentShareValue2"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue2"]) : 0 ;
		heir.CommissionAdjustmentIncomeValue2 = (row["CommissionAdjustmentIncomeValue2"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue2"]) : 0 ;
		heir.CommissionAdjustmentShareValue3 = (row["CommissionAdjustmentShareValue3"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue3"]) : 0 ;
		heir.CommissionAdjustmentIncomeValue3 = (row["CommissionAdjustmentIncomeValue3"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue3"]) : 0 ;
		heir.CommissionAdjustmentShareValue4 = (row["CommissionAdjustmentShareValue4"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue4"]) : 0 ;
		heir.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		heir.ParentHeirID = (row["ParentHeirID"] != DBNull.Value) ? Convert.ToInt64(row["ParentHeirID"]) : 0 ;
		heir.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		heir.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		heir.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		heir.AdjustmentTaxRegisterInformationID = (row["AdjustmentTaxRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentTaxRegisterInformationID"]) : 0 ;
		heir.CommissionAdjustmentIncomeRegisterInformationID5 = (row["CommissionAdjustmentIncomeRegisterInformationID5"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID5"]) : 0 ;
		heir.CommissionAdjustmentShareRegisterInformationID6 = (row["CommissionAdjustmentShareRegisterInformationID6"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID6"]) : 0 ;
		heir.CommissionAdjustmentIncomeRegisterInformationID6 = (row["CommissionAdjustmentIncomeRegisterInformationID6"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID6"]) : 0 ;
		heir.CommissionAdjustmentIncomeRegisterInformationID2 = (row["CommissionAdjustmentIncomeRegisterInformationID2"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID2"]) : 0 ;
		heir.CommissionAdjustmentShareRegisterInformationID3 = (row["CommissionAdjustmentShareRegisterInformationID3"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID3"]) : 0 ;
		heir.CommissionAdjustmentIncomeRegisterInformationID3 = (row["CommissionAdjustmentIncomeRegisterInformationID3"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID3"]) : 0 ;
		heir.CommissionAdjustmentShareRegisterInformationID4 = (row["CommissionAdjustmentShareRegisterInformationID4"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID4"]) : 0 ;
		heir.CommissionAdjustmentIncomeRegisterInformationID4 = (row["CommissionAdjustmentIncomeRegisterInformationID4"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID4"]) : 0 ;
		heir.CommissionAdjustmentShareRegisterInformationID5 = (row["CommissionAdjustmentShareRegisterInformationID5"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID5"]) : 0 ;
		heir.AdjustmentIncomeRegisterInformationID = (row["AdjustmentIncomeRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentIncomeRegisterInformationID"]) : 0 ;
		heir.CommissionAdjustmentShareRegisterInformationID1 = (row["CommissionAdjustmentShareRegisterInformationID1"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID1"]) : 0 ;
		heir.CommissionAdjustmentIncomeRegisterInformationID1 = (row["CommissionAdjustmentIncomeRegisterInformationID1"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID1"]) : 0 ;
		heir.AdjustmentHeritageRegisterInformationID = (row["AdjustmentHeritageRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentHeritageRegisterInformationID"]) : 0 ;
		heir.CommissionAdjustmentHeritageRegisterInformationID = (row["CommissionAdjustmentHeritageRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentHeritageRegisterInformationID"]) : 0 ;
		heir.CommissionAdjustmentShareRegisterInformationID2 = (row["CommissionAdjustmentShareRegisterInformationID2"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID2"]) : 0 ;
		heir.AdjustmentTaxDate = row["AdjustmentTaxDate"].ToString();
		heir.AdjustmentIncomeDate = row["AdjustmentIncomeDate"].ToString();
		heir.CommissionAdjustmentShareDate1 = row["CommissionAdjustmentShareDate1"].ToString();
		heir.CommissionAdjustmentIncomeDate1 = row["CommissionAdjustmentIncomeDate1"].ToString();
		heir.AdjustmentHeritageDate = row["AdjustmentHeritageDate"].ToString();
		heir.CommissionAdjustmentHeritageDate = row["CommissionAdjustmentHeritageDate"].ToString();
		heir.CommissionAdjustmentIncomeDate4 = row["CommissionAdjustmentIncomeDate4"].ToString();
		heir.CommissionAdjustmentShareDate5 = row["CommissionAdjustmentShareDate5"].ToString();
		heir.CommissionAdjustmentIncomeDate5 = row["CommissionAdjustmentIncomeDate5"].ToString();
		heir.CommissionAdjustmentShareDate6 = row["CommissionAdjustmentShareDate6"].ToString();
		heir.CommissionAdjustmentIncomeDate6 = row["CommissionAdjustmentIncomeDate6"].ToString();
		heir.AdjustmentFinalizationDate = row["AdjustmentFinalizationDate"].ToString();
		heir.CommissionAdjustmentShareDate2 = row["CommissionAdjustmentShareDate2"].ToString();
		heir.CommissionAdjustmentIncomeDate2 = row["CommissionAdjustmentIncomeDate2"].ToString();
		heir.CommissionAdjustmentShareDate3 = row["CommissionAdjustmentShareDate3"].ToString();
		heir.CommissionAdjustmentIncomeDate3 = row["CommissionAdjustmentIncomeDate3"].ToString();
		heir.CommissionAdjustmentShareDate4 = row["CommissionAdjustmentShareDate4"].ToString();

		heir.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		heir.PrintNationalCode = row["PrintNationalCode"].ToString();
		heir.FullName = row["FullName"].ToString();
		heir.GenderIDTitle = row["GenderIDTitle"].ToString();
		heir.Religion_DinIDTitle = row["Religion_DinIDTitle"].ToString();
		heir.Religion_MazhabIDTitle = row["Religion_MazhabIDTitle"].ToString();
		heir.IssuanceProvinceIDTitle = row["IssuanceProvinceIDTitle"].ToString();
		heir.IssuanceCityIDTitle = row["IssuanceCityIDTitle"].ToString();
		heir.IssuanceDepartment = row["IssuanceDepartment"].ToString();
		heir.CertificateNumber = row["CertificateNumber"].ToString();
		heir.CertificateSerial = row["CertificateSerial"].ToString();
		heir.ZipCode = row["ZipCode"].ToString();
		heir.HomeAddress = row["HomeAddress"].ToString();
		heir.PhoneNumber = row["PhoneNumber"].ToString();
		heir.Job = row["Job"].ToString();
		heir.JobAddress = row["JobAddress"].ToString();
		heir.JobPhoneNumber = row["JobPhoneNumber"].ToString();
		heir.Comment = row["Comment"].ToString();
		heir.BirthCity = row["BirthCity"].ToString();
		heir.JobZipCode = row["JobZipCode"].ToString();
		heir.CertificateSerialLetter = row["CertificateSerialLetter"].ToString();
		heir.CertificateSerialNumber = row["CertificateSerialNumber"].ToString();
		heir.FatherName = row["FatherName"].ToString();
		heir.Name = row["Name"].ToString();
		heir.Family = row["Family"].ToString();
		heir.BirthDate = row["BirthDate"].ToString();
		heir.IssuanceDate = row["IssuanceDate"].ToString();
		heir.GenderID = (row["GenderID"] != DBNull.Value) ? Convert.ToInt32(row["GenderID"]) : 0 ;
		heir.IssuanceProvinceID = (row["IssuanceProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceProvinceID"]) : 0 ;
		heir.IssuanceCityID = (row["IssuanceCityID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceCityID"]) : 0 ;
		heir.Religion_DinID = (row["Religion_DinID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_DinID"]) : 0 ;
		heir.Religion_MazhabID = (row["Religion_MazhabID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_MazhabID"]) : 0 ;
		return heir;
	}
	public List<HeirNumber> GetListHeirNumber(Int64 declarationID)
	{
		List<HeirNumber> listHeirNumber = new List<HeirNumber>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of HeirNumber records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("HeirNumber_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of heirNumber
				listHeirNumber = new List<HeirNumber>();

				//Now lets populate the HeirNumber details into the list of heirNumbers
				foreach (DataRow row in table.Rows)
				{
					HeirNumber heirNumber = ConvertRowToHeirNumber(row);
					listHeirNumber.Add(heirNumber);
				}
			}
		}

		return listHeirNumber;
	}

	private HeirNumber ConvertRowToHeirNumber(DataRow row)
	{
		HeirNumber heirNumber = new HeirNumber();
		heirNumber.HeirNumberID = (row["HeirNumberID"] != DBNull.Value) ? Convert.ToInt64(row["HeirNumberID"]) : 0 ;
		heirNumber.StageTitle = row["StageTitle"].ToString();
		heirNumber.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		heirNumber.HeirNumber2 = (row["HeirNumber2"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber2"]) : 0 ;
		heirNumber.HeirNumber5 = (row["HeirNumber5"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber5"]) : 0 ;
		heirNumber.HeirNumber6 = (row["HeirNumber6"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber6"]) : 0 ;
		heirNumber.HeirNumber7 = (row["HeirNumber7"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber7"]) : 0 ;
		heirNumber.HeirNumber8 = (row["HeirNumber8"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber8"]) : 0 ;
		heirNumber.HeirNumber9 = (row["HeirNumber9"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber9"]) : 0 ;
		heirNumber.HeirNumber68 = (row["HeirNumber68"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber68"]) : 0 ;
		heirNumber.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		heirNumber.HeirNumber62 = (row["HeirNumber62"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber62"]) : 0 ;
		heirNumber.HeirNumber63 = (row["HeirNumber63"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber63"]) : 0 ;
		heirNumber.HeirNumber64 = (row["HeirNumber64"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber64"]) : 0 ;
		heirNumber.HeirNumber65 = (row["HeirNumber65"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber65"]) : 0 ;
		heirNumber.HeirNumber66 = (row["HeirNumber66"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber66"]) : 0 ;
		heirNumber.HeirNumber67 = (row["HeirNumber67"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber67"]) : 0 ;
		heirNumber.HeirNumber56 = (row["HeirNumber56"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber56"]) : 0 ;
		heirNumber.HeirNumber57 = (row["HeirNumber57"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber57"]) : 0 ;
		heirNumber.HeirNumber58 = (row["HeirNumber58"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber58"]) : 0 ;
		heirNumber.HeirNumber59 = (row["HeirNumber59"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber59"]) : 0 ;
		heirNumber.HeirNumber60 = (row["HeirNumber60"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber60"]) : 0 ;
		heirNumber.HeirNumber61 = (row["HeirNumber61"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber61"]) : 0 ;
		heirNumber.HeirNumber50 = (row["HeirNumber50"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber50"]) : 0 ;
		heirNumber.HeirNumber51 = (row["HeirNumber51"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber51"]) : 0 ;
		heirNumber.HeirNumber52 = (row["HeirNumber52"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber52"]) : 0 ;
		heirNumber.HeirNumber53 = (row["HeirNumber53"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber53"]) : 0 ;
		heirNumber.HeirNumber54 = (row["HeirNumber54"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber54"]) : 0 ;
		heirNumber.HeirNumber55 = (row["HeirNumber55"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber55"]) : 0 ;
		heirNumber.HeirNumber44 = (row["HeirNumber44"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber44"]) : 0 ;
		heirNumber.HeirNumber45 = (row["HeirNumber45"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber45"]) : 0 ;
		heirNumber.HeirNumber46 = (row["HeirNumber46"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber46"]) : 0 ;
		heirNumber.HeirNumber47 = (row["HeirNumber47"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber47"]) : 0 ;
		heirNumber.HeirNumber48 = (row["HeirNumber48"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber48"]) : 0 ;
		heirNumber.HeirNumber49 = (row["HeirNumber49"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber49"]) : 0 ;
		heirNumber.HeirNumber38 = (row["HeirNumber38"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber38"]) : 0 ;
		heirNumber.HeirNumber39 = (row["HeirNumber39"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber39"]) : 0 ;
		heirNumber.HeirNumber40 = (row["HeirNumber40"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber40"]) : 0 ;
		heirNumber.HeirNumber41 = (row["HeirNumber41"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber41"]) : 0 ;
		heirNumber.HeirNumber42 = (row["HeirNumber42"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber42"]) : 0 ;
		heirNumber.HeirNumber43 = (row["HeirNumber43"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber43"]) : 0 ;
		heirNumber.HeirNumber32 = (row["HeirNumber32"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber32"]) : 0 ;
		heirNumber.HeirNumber33 = (row["HeirNumber33"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber33"]) : 0 ;
		heirNumber.HeirNumber34 = (row["HeirNumber34"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber34"]) : 0 ;
		heirNumber.HeirNumber35 = (row["HeirNumber35"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber35"]) : 0 ;
		heirNumber.HeirNumber36 = (row["HeirNumber36"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber36"]) : 0 ;
		heirNumber.HeirNumber37 = (row["HeirNumber37"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber37"]) : 0 ;
		heirNumber.HeirNumber26 = (row["HeirNumber26"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber26"]) : 0 ;
		heirNumber.HeirNumber27 = (row["HeirNumber27"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber27"]) : 0 ;
		heirNumber.HeirNumber28 = (row["HeirNumber28"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber28"]) : 0 ;
		heirNumber.HeirNumber29 = (row["HeirNumber29"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber29"]) : 0 ;
		heirNumber.HeirNumber30 = (row["HeirNumber30"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber30"]) : 0 ;
		heirNumber.HeirNumber31 = (row["HeirNumber31"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber31"]) : 0 ;
		heirNumber.HeirNumber20 = (row["HeirNumber20"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber20"]) : 0 ;
		heirNumber.HeirNumber21 = (row["HeirNumber21"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber21"]) : 0 ;
		heirNumber.HeirNumber22 = (row["HeirNumber22"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber22"]) : 0 ;
		heirNumber.HeirNumber23 = (row["HeirNumber23"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber23"]) : 0 ;
		heirNumber.HeirNumber24 = (row["HeirNumber24"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber24"]) : 0 ;
		heirNumber.HeirNumber25 = (row["HeirNumber25"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber25"]) : 0 ;
		heirNumber.HeirNumber10 = (row["HeirNumber10"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber10"]) : 0 ;
		heirNumber.HeirNumber15 = (row["HeirNumber15"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber15"]) : 0 ;
		heirNumber.HeirNumber16 = (row["HeirNumber16"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber16"]) : 0 ;
		heirNumber.HeirNumber17 = (row["HeirNumber17"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber17"]) : 0 ;
		heirNumber.HeirNumber18 = (row["HeirNumber18"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber18"]) : 0 ;
		heirNumber.HeirNumber19 = (row["HeirNumber19"] != DBNull.Value) ? Convert.ToInt32(row["HeirNumber19"]) : 0 ;
		heirNumber.HeirNumber1 = (row["HeirNumber1"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber1"].ToString() == "1" || row["HeirNumber1"].ToString().ToLower() == "true" ) ? true : false) : false ;
		heirNumber.HeirNumber3 = (row["HeirNumber3"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber3"].ToString() == "1" || row["HeirNumber3"].ToString().ToLower() == "true" ) ? true : false) : false ;
		heirNumber.HeirNumber4 = (row["HeirNumber4"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber4"].ToString() == "1" || row["HeirNumber4"].ToString().ToLower() == "true" ) ? true : false) : false ;
		heirNumber.HeirNumber11 = (row["HeirNumber11"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber11"].ToString() == "1" || row["HeirNumber11"].ToString().ToLower() == "true" ) ? true : false) : false ;
		heirNumber.HeirNumber12 = (row["HeirNumber12"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber12"].ToString() == "1" || row["HeirNumber12"].ToString().ToLower() == "true" ) ? true : false) : false ;
		heirNumber.HeirNumber13 = (row["HeirNumber13"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber13"].ToString() == "1" || row["HeirNumber13"].ToString().ToLower() == "true" ) ? true : false) : false ;
		heirNumber.HeirNumber14 = (row["HeirNumber14"] != DBNull.Value) ? Convert.ToBoolean((row["HeirNumber14"].ToString() == "1" || row["HeirNumber14"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return heirNumber;
	}
	public List<HomeFurnishings> GetListHomeFurnishings(Int64 declarationID)
	{
		List<HomeFurnishings> listHomeFurnishings = new List<HomeFurnishings>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of HomeFurnishings records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("HomeFurnishings_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of homeFurnishings
				listHomeFurnishings = new List<HomeFurnishings>();

				//Now lets populate the HomeFurnishings details into the list of homeFurnishingss
				foreach (DataRow row in table.Rows)
				{
					HomeFurnishings homeFurnishings = ConvertRowToHomeFurnishings(row);
					listHomeFurnishings.Add(homeFurnishings);
				}
			}
		}

		return listHomeFurnishings;
	}

	private HomeFurnishings ConvertRowToHomeFurnishings(DataRow row)
	{
		HomeFurnishings homeFurnishings = new HomeFurnishings();
		homeFurnishings.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		homeFurnishings.Title = row["Title"].ToString();
		homeFurnishings.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

		homeFurnishings.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		homeFurnishings.StageTitle = row["StageTitle"].ToString();
		homeFurnishings.RegisterDate = row["RegisterDate"].ToString();
		homeFurnishings.OldRegisterDate = row["OldRegisterDate"].ToString();
		homeFurnishings.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		homeFurnishings.Sixth = row["Sixth"].ToString();
		homeFurnishings.PreviousOwner = row["PreviousOwner"].ToString();
		homeFurnishings.Comment = row["Comment"].ToString();
		homeFurnishings.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		homeFurnishings.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		homeFurnishings.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		homeFurnishings.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		homeFurnishings.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		homeFurnishings.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		homeFurnishings.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		homeFurnishings.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		homeFurnishings.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		homeFurnishings.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return homeFurnishings;
	}
	public List<InquiryResponse> GetListInquiryResponse(Int64 declarationID)
	{
		List<InquiryResponse> listInquiryResponse = new List<InquiryResponse>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of InquiryResponse records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("InquiryResponse_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of inquiryResponse
				listInquiryResponse = new List<InquiryResponse>();

				//Now lets populate the InquiryResponse details into the list of inquiryResponses
				foreach (DataRow row in table.Rows)
				{
					InquiryResponse inquiryResponse = ConvertRowToInquiryResponse(row);
					listInquiryResponse.Add(inquiryResponse);
				}
			}
		}

		return listInquiryResponse;
	}

	private InquiryResponse ConvertRowToInquiryResponse(DataRow row)
	{
		InquiryResponse inquiryResponse = new InquiryResponse();
		inquiryResponse.InquiryResponseID = (row["InquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["InquiryResponseID"]) : 0 ;
		inquiryResponse.RegisterDate = row["RegisterDate"].ToString();
		inquiryResponse.OldRegisterDate = row["OldRegisterDate"].ToString();
		inquiryResponse.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		inquiryResponse.Owner = row["Owner"].ToString();
		inquiryResponse.Number = row["Number"].ToString();
		inquiryResponse.Comments = row["Comments"].ToString();
		inquiryResponse.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		inquiryResponse.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		inquiryResponse.ResponseDate = row["ResponseDate"].ToString();
		return inquiryResponse;
	}
	public List<Jewel> GetListJewel(Int64 declarationID)
	{
		List<Jewel> listJewel = new List<Jewel>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of Jewel records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Jewel_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of jewel
				listJewel = new List<Jewel>();

				//Now lets populate the Jewel details into the list of jewels
				foreach (DataRow row in table.Rows)
				{
					Jewel jewel = ConvertRowToJewel(row);
					listJewel.Add(jewel);
				}
			}
		}

		return listJewel;
	}

	private Jewel ConvertRowToJewel(DataRow row)
	{
		Jewel jewel = new Jewel();
		jewel.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		jewel.Name = row["Name"].ToString();
		jewel.Weight = row["Weight"].ToString();
		jewel.FactorNumber = row["FactorNumber"].ToString();
		jewel.Place = row["Place"].ToString();
		jewel.Number = (row["Number"] != DBNull.Value) ? Convert.ToInt32(row["Number"]) : 0 ;
		jewel.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

		jewel.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		jewel.StageTitle = row["StageTitle"].ToString();
		jewel.RegisterDate = row["RegisterDate"].ToString();
		jewel.OldRegisterDate = row["OldRegisterDate"].ToString();
		jewel.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		jewel.Sixth = row["Sixth"].ToString();
		jewel.PreviousOwner = row["PreviousOwner"].ToString();
		jewel.Comment = row["Comment"].ToString();
		jewel.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		jewel.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		jewel.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		jewel.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		jewel.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		jewel.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		jewel.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		jewel.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		jewel.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		jewel.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return jewel;
	}
	public List<JusticeShares> GetListJusticeShares(Int64 declarationID)
	{
		List<JusticeShares> listJusticeShares = new List<JusticeShares>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of JusticeShares records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("JusticeShares_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of justiceShares
				listJusticeShares = new List<JusticeShares>();

				//Now lets populate the JusticeShares details into the list of justiceSharess
				foreach (DataRow row in table.Rows)
				{
					JusticeShares justiceShares = ConvertRowToJusticeShares(row);
					listJusticeShares.Add(justiceShares);
				}
			}
		}

		return listJusticeShares;
	}

	private JusticeShares ConvertRowToJusticeShares(DataRow row)
	{
		JusticeShares justiceShares = new JusticeShares();
		justiceShares.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		justiceShares.RegisterNumber = row["RegisterNumber"].ToString();
		justiceShares.ShareNumber = (row["ShareNumber"] != DBNull.Value) ? Convert.ToInt32(row["ShareNumber"]) : 0 ;
		justiceShares.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

		justiceShares.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		justiceShares.StageTitle = row["StageTitle"].ToString();
		justiceShares.RegisterDate = row["RegisterDate"].ToString();
		justiceShares.OldRegisterDate = row["OldRegisterDate"].ToString();
		justiceShares.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		justiceShares.Sixth = row["Sixth"].ToString();
		justiceShares.PreviousOwner = row["PreviousOwner"].ToString();
		justiceShares.Comment = row["Comment"].ToString();
		justiceShares.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		justiceShares.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		justiceShares.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		justiceShares.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		justiceShares.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		justiceShares.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		justiceShares.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		justiceShares.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		justiceShares.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		justiceShares.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return justiceShares;
	}
	public List<Machinery> GetListMachinery(Int64 declarationID)
	{
		List<Machinery> listMachinery = new List<Machinery>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of Machinery records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Machinery_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
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
	public List<OtherDeductions> GetListOtherDeductions(Int64 declarationID)
	{
		List<OtherDeductions> listOtherDeductions = new List<OtherDeductions>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of OtherDeductions records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("OtherDeductions_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of otherDeductions
				listOtherDeductions = new List<OtherDeductions>();

				//Now lets populate the OtherDeductions details into the list of otherDeductionss
				foreach (DataRow row in table.Rows)
				{
					OtherDeductions otherDeductions = ConvertRowToOtherDeductions(row);
					listOtherDeductions.Add(otherDeductions);
				}
			}
		}

		return listOtherDeductions;
	}

	private OtherDeductions ConvertRowToOtherDeductions(DataRow row)
	{
		OtherDeductions otherDeductions = new OtherDeductions();
		otherDeductions.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		otherDeductions.Title = row["Title"].ToString();
		otherDeductions.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

		otherDeductions.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		otherDeductions.StageTitle = row["StageTitle"].ToString();
		otherDeductions.RegisterDate = row["RegisterDate"].ToString();
		otherDeductions.OldRegisterDate = row["OldRegisterDate"].ToString();
		otherDeductions.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		otherDeductions.Sixth = row["Sixth"].ToString();
		otherDeductions.PreviousOwner = row["PreviousOwner"].ToString();
		otherDeductions.Comment = row["Comment"].ToString();
		otherDeductions.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		otherDeductions.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		otherDeductions.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		otherDeductions.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		otherDeductions.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		otherDeductions.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		otherDeductions.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		otherDeductions.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		otherDeductions.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		otherDeductions.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return otherDeductions;
	}
	public List<OtherProperties> GetListOtherProperties(Int64 declarationID)
	{
		List<OtherProperties> listOtherProperties = new List<OtherProperties>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of OtherProperties records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("OtherProperties_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
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
	public List<PartnershipPapers> GetListPartnershipPapers(Int64 declarationID)
	{
		List<PartnershipPapers> listPartnershipPapers = new List<PartnershipPapers>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of PartnershipPapers records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("PartnershipPapers_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of partnershipPapers
				listPartnershipPapers = new List<PartnershipPapers>();

				//Now lets populate the PartnershipPapers details into the list of partnershipPaperss
				foreach (DataRow row in table.Rows)
				{
					PartnershipPapers partnershipPapers = ConvertRowToPartnershipPapers(row);
					listPartnershipPapers.Add(partnershipPapers);
				}
			}
		}

		return listPartnershipPapers;
	}

	private PartnershipPapers ConvertRowToPartnershipPapers(DataRow row)
	{
		PartnershipPapers partnershipPapers = new PartnershipPapers();
		partnershipPapers.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		partnershipPapers.PartnershipPaperTypeIDTitle = row["PartnershipPaperTypeIDTitle"].ToString();
		partnershipPapers.PartnershipPaperTypeID = (row["PartnershipPaperTypeID"] != DBNull.Value) ? Convert.ToInt32(row["PartnershipPaperTypeID"]) : 0 ;
		partnershipPapers.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		partnershipPapers.ProjectName = row["ProjectName"].ToString();
		partnershipPapers.SellerName = row["SellerName"].ToString();
		partnershipPapers.PaperNumber = row["PaperNumber"].ToString();

		partnershipPapers.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		partnershipPapers.StageTitle = row["StageTitle"].ToString();
		partnershipPapers.RegisterDate = row["RegisterDate"].ToString();
		partnershipPapers.OldRegisterDate = row["OldRegisterDate"].ToString();
		partnershipPapers.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		partnershipPapers.Sixth = row["Sixth"].ToString();
		partnershipPapers.PreviousOwner = row["PreviousOwner"].ToString();
		partnershipPapers.Comment = row["Comment"].ToString();
		partnershipPapers.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		partnershipPapers.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		partnershipPapers.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		partnershipPapers.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		partnershipPapers.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		partnershipPapers.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		partnershipPapers.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		partnershipPapers.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		partnershipPapers.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		partnershipPapers.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return partnershipPapers;
	}
	public List<Permit> GetListPermit(Int64 declarationID)
	{
		List<Permit> listPermit = new List<Permit>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of Permit records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Permit_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
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
	public List<Phone> GetListPhone(Int64 declarationID)
	{
		List<Phone> listPhone = new List<Phone>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of Phone records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Phone_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
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
	public List<ProductionUnit> GetListProductionUnit(Int64 declarationID)
	{
		List<ProductionUnit> listProductionUnit = new List<ProductionUnit>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of ProductionUnit records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ProductionUnit_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of productionUnit
				listProductionUnit = new List<ProductionUnit>();

				//Now lets populate the ProductionUnit details into the list of productionUnits
				foreach (DataRow row in table.Rows)
				{
					ProductionUnit productionUnit = ConvertRowToProductionUnit(row);
					listProductionUnit.Add(productionUnit);
				}
			}
		}

		return listProductionUnit;
	}

	private ProductionUnit ConvertRowToProductionUnit(DataRow row)
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

		productionUnit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		productionUnit.StageTitle = row["StageTitle"].ToString();
		productionUnit.RegisterDate = row["RegisterDate"].ToString();
		productionUnit.OldRegisterDate = row["OldRegisterDate"].ToString();
		productionUnit.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		productionUnit.Sixth = row["Sixth"].ToString();
		productionUnit.PreviousOwner = row["PreviousOwner"].ToString();
		productionUnit.Comment = row["Comment"].ToString();
		productionUnit.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		productionUnit.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		productionUnit.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		productionUnit.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		productionUnit.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		productionUnit.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		productionUnit.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		productionUnit.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		productionUnit.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		productionUnit.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return productionUnit;
	}
	public List<PropertiesNumber> GetListPropertiesNumber(Int64 declarationID)
	{
		List<PropertiesNumber> listPropertiesNumber = new List<PropertiesNumber>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of PropertiesNumber records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("PropertiesNumber_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of propertiesNumber
				listPropertiesNumber = new List<PropertiesNumber>();

				//Now lets populate the PropertiesNumber details into the list of propertiesNumbers
				foreach (DataRow row in table.Rows)
				{
					PropertiesNumber propertiesNumber = ConvertRowToPropertiesNumber(row);
					listPropertiesNumber.Add(propertiesNumber);
				}
			}
		}

		return listPropertiesNumber;
	}

	private PropertiesNumber ConvertRowToPropertiesNumber(DataRow row)
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
		return propertiesNumber;
	}
	public List<ReDiagnosisRequest> GetListReDiagnosisRequest(Int64 declarationID)
	{
		List<ReDiagnosisRequest> listReDiagnosisRequest = new List<ReDiagnosisRequest>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of ReDiagnosisRequest records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ReDiagnosisRequest_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of reDiagnosisRequest
				listReDiagnosisRequest = new List<ReDiagnosisRequest>();

				//Now lets populate the ReDiagnosisRequest details into the list of reDiagnosisRequests
				foreach (DataRow row in table.Rows)
				{
					ReDiagnosisRequest reDiagnosisRequest = ConvertRowToReDiagnosisRequest(row);
					listReDiagnosisRequest.Add(reDiagnosisRequest);
				}
			}
		}

		return listReDiagnosisRequest;
	}

	private ReDiagnosisRequest ConvertRowToReDiagnosisRequest(DataRow row)
	{
		ReDiagnosisRequest reDiagnosisRequest = new ReDiagnosisRequest();
		reDiagnosisRequest.ReDiagnosisRequestID = (row["ReDiagnosisRequestID"] != DBNull.Value) ? Convert.ToInt64(row["ReDiagnosisRequestID"]) : 0 ;
		reDiagnosisRequest.PrintRegisterDate = row["PrintRegisterDate"].ToString();
		reDiagnosisRequest.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		reDiagnosisRequest.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		reDiagnosisRequest.RequestDate = row["RequestDate"].ToString();
		return reDiagnosisRequest;
	}
	public List<ReligiousDebt> GetListReligiousDebt(Int64 declarationID)
	{
		List<ReligiousDebt> listReligiousDebt = new List<ReligiousDebt>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of ReligiousDebt records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ReligiousDebt_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of religiousDebt
				listReligiousDebt = new List<ReligiousDebt>();

				//Now lets populate the ReligiousDebt details into the list of religiousDebts
				foreach (DataRow row in table.Rows)
				{
					ReligiousDebt religiousDebt = ConvertRowToReligiousDebt(row);
					listReligiousDebt.Add(religiousDebt);
				}
			}
		}

		return listReligiousDebt;
	}

	private ReligiousDebt ConvertRowToReligiousDebt(DataRow row)
	{
		ReligiousDebt religiousDebt = new ReligiousDebt();
		religiousDebt.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		religiousDebt.FinancialObligationTitle = row["FinancialObligationTitle"].ToString();
		religiousDebt.ReligiousObligationTitle = row["ReligiousObligationTitle"].ToString();
		religiousDebt.FinancialObligationAmount = (row["FinancialObligationAmount"] != DBNull.Value) ? Convert.ToSingle(row["FinancialObligationAmount"]) : 0 ;
		religiousDebt.ReligiousObligationAmount = (row["ReligiousObligationAmount"] != DBNull.Value) ? Convert.ToSingle(row["ReligiousObligationAmount"]) : 0 ;
		religiousDebt.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

		religiousDebt.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		religiousDebt.StageTitle = row["StageTitle"].ToString();
		religiousDebt.RegisterDate = row["RegisterDate"].ToString();
		religiousDebt.OldRegisterDate = row["OldRegisterDate"].ToString();
		religiousDebt.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		religiousDebt.Sixth = row["Sixth"].ToString();
		religiousDebt.PreviousOwner = row["PreviousOwner"].ToString();
		religiousDebt.Comment = row["Comment"].ToString();
		religiousDebt.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		religiousDebt.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		religiousDebt.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		religiousDebt.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		religiousDebt.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		religiousDebt.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		religiousDebt.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		religiousDebt.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		religiousDebt.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		religiousDebt.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return religiousDebt;
	}
	public List<Request> GetListRequest(Int64 declarationID)
	{
		List<Request> listRequest = new List<Request>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of Request records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Request_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of request
				listRequest = new List<Request>();

				//Now lets populate the Request details into the list of requests
				foreach (DataRow row in table.Rows)
				{
					Request request = ConvertRowToRequest(row);
					listRequest.Add(request);
				}
			}
		}

		return listRequest;
	}

	private Request ConvertRowToRequest(DataRow row)
	{
		Request request = new Request();
		request.RequestID = (row["RequestID"] != DBNull.Value) ? Convert.ToInt64(row["RequestID"]) : 0 ;
		request.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		request.RequestDate = row["RequestDate"].ToString();
		request.RequestResource = row["RequestResource"].ToString();
		request.RequestNumber = row["RequestNumber"].ToString();
		return request;
	}
	public List<SafeBox> GetListSafeBox(Int64 declarationID)
	{
		List<SafeBox> listSafeBox = new List<SafeBox>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of SafeBox records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("SafeBox_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of safeBox
				listSafeBox = new List<SafeBox>();

				//Now lets populate the SafeBox details into the list of safeBoxs
				foreach (DataRow row in table.Rows)
				{
					SafeBox safeBox = ConvertRowToSafeBox(row);
					listSafeBox.Add(safeBox);
				}
			}
		}

		return listSafeBox;
	}

	private SafeBox ConvertRowToSafeBox(DataRow row)
	{
		SafeBox safeBox = new SafeBox();
		safeBox.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		safeBox.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		safeBox.BoxNumber = row["BoxNumber"].ToString();
		safeBox.Place = row["Place"].ToString();
		safeBox.Agent = row["Agent"].ToString();
		safeBox.Inquiry = row["Inquiry"].ToString();

		safeBox.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		safeBox.StageTitle = row["StageTitle"].ToString();
		safeBox.RegisterDate = row["RegisterDate"].ToString();
		safeBox.OldRegisterDate = row["OldRegisterDate"].ToString();
		safeBox.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		safeBox.Sixth = row["Sixth"].ToString();
		safeBox.PreviousOwner = row["PreviousOwner"].ToString();
		safeBox.Comment = row["Comment"].ToString();
		safeBox.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		safeBox.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		safeBox.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		safeBox.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		safeBox.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		safeBox.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		safeBox.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		safeBox.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		safeBox.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		safeBox.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return safeBox;
	}
	public List<Score> GetListScore(Int64 declarationID)
	{
		List<Score> listScore = new List<Score>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of Score records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Score_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
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
	public List<StockInOtherCompanies> GetListStockInOtherCompanies(Int64 declarationID)
	{
		List<StockInOtherCompanies> listStockInOtherCompanies = new List<StockInOtherCompanies>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of StockInOtherCompanies records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("StockInOtherCompanies_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
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
	public List<StockProfit> GetListStockProfit(Int64 declarationID)
	{
		List<StockProfit> listStockProfit = new List<StockProfit>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of StockProfit records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("StockProfit_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
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
	public List<TransferRight> GetListTransferRight(Int64 declarationID)
	{
		List<TransferRight> listTransferRight = new List<TransferRight>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of TransferRight records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("TransferRight_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
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
	public List<Tree> GetListTree(Int64 declarationID)
	{
		List<Tree> listTree = new List<Tree>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of Tree records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Tree_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
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
	public List<Utterer> GetListUtterer(Int64 declarationID)
	{
		List<Utterer> listUtterer = new List<Utterer>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of Utterer records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Utterer_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of utterer
				listUtterer = new List<Utterer>();

				//Now lets populate the Utterer details into the list of utterers
				foreach (DataRow row in table.Rows)
				{
					Utterer utterer = ConvertRowToUtterer(row);
					listUtterer.Add(utterer);
				}
			}
		}

		return listUtterer;
	}

	private Utterer ConvertRowToUtterer(DataRow row)
	{
		Utterer utterer = new Utterer();
		utterer.UttererID = (row["UttererID"] != DBNull.Value) ? Convert.ToInt64(row["UttererID"]) : 0 ;
		utterer.RegisterDate = row["RegisterDate"].ToString();
		utterer.UttererRoleIDTitle = row["UttererRoleIDTitle"].ToString();
		utterer.OldRegisterDate = row["OldRegisterDate"].ToString();
		utterer.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		utterer.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		utterer.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		utterer.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
		utterer.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		utterer.UttererRoleID = (row["UttererRoleID"] != DBNull.Value) ? Convert.ToInt32(row["UttererRoleID"]) : 0 ;
		utterer.AssertionOrder = (row["AssertionOrder"] != DBNull.Value) ? Convert.ToInt32(row["AssertionOrder"]) : 0 ;
		utterer.IsApplicant = (row["IsApplicant"] != DBNull.Value) ? Convert.ToBoolean((row["IsApplicant"].ToString() == "1" || row["IsApplicant"].ToString().ToLower() == "true" ) ? true : false) : false ;

		utterer.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		utterer.PrintNationalCode = row["PrintNationalCode"].ToString();
		utterer.FullName = row["FullName"].ToString();
		utterer.GenderIDTitle = row["GenderIDTitle"].ToString();
		utterer.Religion_DinIDTitle = row["Religion_DinIDTitle"].ToString();
		utterer.Religion_MazhabIDTitle = row["Religion_MazhabIDTitle"].ToString();
		utterer.IssuanceProvinceIDTitle = row["IssuanceProvinceIDTitle"].ToString();
		utterer.IssuanceCityIDTitle = row["IssuanceCityIDTitle"].ToString();
		utterer.IssuanceDepartment = row["IssuanceDepartment"].ToString();
		utterer.CertificateNumber = row["CertificateNumber"].ToString();
		utterer.CertificateSerial = row["CertificateSerial"].ToString();
		utterer.ZipCode = row["ZipCode"].ToString();
		utterer.HomeAddress = row["HomeAddress"].ToString();
		utterer.PhoneNumber = row["PhoneNumber"].ToString();
		utterer.Job = row["Job"].ToString();
		utterer.JobAddress = row["JobAddress"].ToString();
		utterer.JobPhoneNumber = row["JobPhoneNumber"].ToString();
		utterer.Comment = row["Comment"].ToString();
		utterer.BirthCity = row["BirthCity"].ToString();
		utterer.JobZipCode = row["JobZipCode"].ToString();
		utterer.CertificateSerialLetter = row["CertificateSerialLetter"].ToString();
		utterer.CertificateSerialNumber = row["CertificateSerialNumber"].ToString();
		utterer.FatherName = row["FatherName"].ToString();
		utterer.Name = row["Name"].ToString();
		utterer.Family = row["Family"].ToString();
		utterer.BirthDate = row["BirthDate"].ToString();
		utterer.IssuanceDate = row["IssuanceDate"].ToString();
		utterer.GenderID = (row["GenderID"] != DBNull.Value) ? Convert.ToInt32(row["GenderID"]) : 0 ;
		utterer.IssuanceProvinceID = (row["IssuanceProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceProvinceID"]) : 0 ;
		utterer.IssuanceCityID = (row["IssuanceCityID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceCityID"]) : 0 ;
		utterer.Religion_DinID = (row["Religion_DinID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_DinID"]) : 0 ;
		utterer.Religion_MazhabID = (row["Religion_MazhabID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_MazhabID"]) : 0 ;
		return utterer;
	}
	public List<Well> GetListWell(Int64 declarationID)
	{
		List<Well> listWell = new List<Well>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};

		//Lets get the list of Well records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Well_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
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
	public List<Will> GetListWill(Int64 declarationID)
	{
		List<Will> listWill = new List<Will>() { };
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclerationID", declarationID)
		};

		//Lets get the list of Will records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Will_GetList_UseInDeclaration", CommandType.StoredProcedure, parametersDeclaration))
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
	public Int64 Insert(Declaration declaration)
	{
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@Stage", declaration.Stage),
			new SqlParameter("@DeclarationTypeID", (declaration.DeclarationTypeID > 0) ? declaration.DeclarationTypeID : (object)DBNull.Value),
			new SqlParameter("@AutomaticShareCalculation1", (declaration.AutomaticShareCalculation1 != null) ? declaration.AutomaticShareCalculation1 : (object)DBNull.Value),
			new SqlParameter("@AutomaticShareCalculation2", (declaration.AutomaticShareCalculation2 != null) ? declaration.AutomaticShareCalculation2 : (object)DBNull.Value),
			new SqlParameter("@RequestResource", (declaration.RequestResource != null) ? declaration.RequestResource : (object)DBNull.Value),
			new SqlParameter("@RequestNumber", (declaration.RequestNumber != null) ? declaration.RequestNumber : (object)DBNull.Value),
			new SqlParameter("@DeclarationTitle", (declaration.DeclarationTitle != null) ? declaration.DeclarationTitle : (object)DBNull.Value),
			new SqlParameter("@DossierID", (declaration.DossierID > 0) ? declaration.DossierID : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", (declaration.RegisterInformationID > 0) ? declaration.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@WillID", (declaration.WillID != null) ? declaration.WillID : (object)DBNull.Value),
			new SqlParameter("@FinalizerUserNationalCode1", (declaration.FinalizerUserNationalCode1 != null) ? declaration.FinalizerUserNationalCode1 : (object)DBNull.Value),
			new SqlParameter("@FinalizerUserNationalCode2", (declaration.FinalizerUserNationalCode2 != null) ? declaration.FinalizerUserNationalCode2 : (object)DBNull.Value),
			new SqlParameter("@DiagnosisFinalizerUserNationalCode1", (declaration.DiagnosisFinalizerUserNationalCode1 != null) ? declaration.DiagnosisFinalizerUserNationalCode1 : (object)DBNull.Value),
			new SqlParameter("@DiagnosisFinalizerUserNationalCode2", (declaration.DiagnosisFinalizerUserNationalCode2 != null) ? declaration.DiagnosisFinalizerUserNationalCode2 : (object)DBNull.Value),
			new SqlParameter("@DiagnosisRegisterInformationID", (declaration.DiagnosisRegisterInformationID != null) ? declaration.DiagnosisRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@DeclarationRegisterNumberInCentral", (declaration.DeclarationRegisterNumberInCentral != null) ? declaration.DeclarationRegisterNumberInCentral : (object)DBNull.Value),
			new SqlParameter("@FinalDate1", (declaration.FinalDate1 != null) ? declaration.FinalDate1 : (object)DBNull.Value),
			new SqlParameter("@FinalDate2", (declaration.FinalDate2 != null) ? declaration.FinalDate2 : (object)DBNull.Value),
			new SqlParameter("@FinalDateDiagnosis1", (declaration.FinalDateDiagnosis1 != null) ? declaration.FinalDateDiagnosis1 : (object)DBNull.Value),
			new SqlParameter("@FinalDateDiagnosis2", (declaration.FinalDateDiagnosis2 != null) ? declaration.FinalDateDiagnosis2 : (object)DBNull.Value),
			new SqlParameter("@FinalDateAdjustment", (declaration.FinalDateAdjustment != null) ? declaration.FinalDateAdjustment : (object)DBNull.Value),
			new SqlParameter("@FinalDateCommisionAdjustment", (declaration.FinalDateCommisionAdjustment != null) ? declaration.FinalDateCommisionAdjustment : (object)DBNull.Value),
			new SqlParameter("@DeliveryDate", (declaration.DeliveryDate != null) ? declaration.DeliveryDate : (object)DBNull.Value),
			new SqlParameter("@DeclarationRegisterDateInCentral", (declaration.DeclarationRegisterDateInCentral != null) ? declaration.DeclarationRegisterDateInCentral : (object)DBNull.Value),
			new SqlParameter("@RequestDate", (declaration.RequestDate != null) ? declaration.RequestDate : (object)DBNull.Value),
			new SqlParameter("@DiagnosisRegisterDate", (declaration.DiagnosisRegisterDate != null) ? declaration.DiagnosisRegisterDate : (object)DBNull.Value)
		};
		declaration.DeclarationID = SqlDBHelper.ExecuteScalar("Declaration_Insert", CommandType.StoredProcedure, parametersDeclaration);
		return declaration.DeclarationID;
	}

	public bool Update(Declaration declaration)
	{
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declaration.DeclarationID),
			new SqlParameter("@Stage", declaration.Stage),
			new SqlParameter("@DeclarationTypeID", declaration.DeclarationTypeID),
			new SqlParameter("@AutomaticShareCalculation1", (declaration.AutomaticShareCalculation1 != null) ? declaration.AutomaticShareCalculation1 : (object)DBNull.Value),
			new SqlParameter("@AutomaticShareCalculation2", (declaration.AutomaticShareCalculation2 != null) ? declaration.AutomaticShareCalculation2 : (object)DBNull.Value),
			new SqlParameter("@RequestResource", (declaration.RequestResource != null) ? declaration.RequestResource : (object)DBNull.Value),
			new SqlParameter("@RequestNumber", (declaration.RequestNumber != null) ? declaration.RequestNumber : (object)DBNull.Value),
			new SqlParameter("@DeclarationTitle", (declaration.DeclarationTitle != null) ? declaration.DeclarationTitle : (object)DBNull.Value),
			new SqlParameter("@DossierID", declaration.DossierID),
			new SqlParameter("@RegisterInformationID", declaration.RegisterInformationID),
			new SqlParameter("@WillID", (declaration.WillID != null) ? declaration.WillID : (object)DBNull.Value),
			new SqlParameter("@FinalizerUserNationalCode1", (declaration.FinalizerUserNationalCode1 != null) ? declaration.FinalizerUserNationalCode1 : (object)DBNull.Value),
			new SqlParameter("@FinalizerUserNationalCode2", (declaration.FinalizerUserNationalCode2 != null) ? declaration.FinalizerUserNationalCode2 : (object)DBNull.Value),
			new SqlParameter("@DiagnosisFinalizerUserNationalCode1", (declaration.DiagnosisFinalizerUserNationalCode1 != null) ? declaration.DiagnosisFinalizerUserNationalCode1 : (object)DBNull.Value),
			new SqlParameter("@DiagnosisFinalizerUserNationalCode2", (declaration.DiagnosisFinalizerUserNationalCode2 != null) ? declaration.DiagnosisFinalizerUserNationalCode2 : (object)DBNull.Value),
			new SqlParameter("@DiagnosisRegisterInformationID", (declaration.DiagnosisRegisterInformationID != null) ? declaration.DiagnosisRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@DeclarationRegisterNumberInCentral", (declaration.DeclarationRegisterNumberInCentral != null) ? declaration.DeclarationRegisterNumberInCentral : (object)DBNull.Value),
			new SqlParameter("@FinalDate1", (declaration.FinalDate1 != null) ? declaration.FinalDate1 : (object)DBNull.Value),
			new SqlParameter("@FinalDate2", (declaration.FinalDate2 != null) ? declaration.FinalDate2 : (object)DBNull.Value),
			new SqlParameter("@FinalDateDiagnosis1", (declaration.FinalDateDiagnosis1 != null) ? declaration.FinalDateDiagnosis1 : (object)DBNull.Value),
			new SqlParameter("@FinalDateDiagnosis2", (declaration.FinalDateDiagnosis2 != null) ? declaration.FinalDateDiagnosis2 : (object)DBNull.Value),
			new SqlParameter("@FinalDateAdjustment", (declaration.FinalDateAdjustment != null) ? declaration.FinalDateAdjustment : (object)DBNull.Value),
			new SqlParameter("@FinalDateCommisionAdjustment", (declaration.FinalDateCommisionAdjustment != null) ? declaration.FinalDateCommisionAdjustment : (object)DBNull.Value),
			new SqlParameter("@DeliveryDate", (declaration.DeliveryDate != null) ? declaration.DeliveryDate : (object)DBNull.Value),
			new SqlParameter("@DeclarationRegisterDateInCentral", (declaration.DeclarationRegisterDateInCentral != null) ? declaration.DeclarationRegisterDateInCentral : (object)DBNull.Value),
			new SqlParameter("@RequestDate", (declaration.RequestDate != null) ? declaration.RequestDate : (object)DBNull.Value),
			new SqlParameter("@DiagnosisRegisterDate", (declaration.DiagnosisRegisterDate != null) ? declaration.DiagnosisRegisterDate : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Declaration_Update", CommandType.StoredProcedure, parametersDeclaration);
	}

	public bool Delete(Int64 declarationID)
	{
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};
		return SqlDBHelper.ExecuteNonQuery("Declaration_Delete", CommandType.StoredProcedure, parametersDeclaration);
	}

	public bool Delete(Int64 declarationID , int stage)
	{
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID),
			new SqlParameter("@Stage", stage)
		};
		return SqlDBHelper.ExecuteNonQuery("Declaration_DeleteBy_DeclarationIDStage", CommandType.StoredProcedure, parametersDeclaration);

	}

	public Declaration GetDetails(Int64 declarationID)
	{
		Declaration declaration = new Declaration();

		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Declaration_GetDetails", CommandType.StoredProcedure, parametersDeclaration))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				declaration.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				declaration.StageTitle = row["StageTitle"].ToString();
				declaration.DeclarationTypeIDTitle = row["DeclarationTypeIDTitle"].ToString();
				declaration.FinalizerUserNationalCode1FullName = row["FinalizerUserNationalCode1FullName"].ToString();
				declaration.FinalizerUserNationalCode2FullName = row["FinalizerUserNationalCode2FullName"].ToString();
				declaration.DiagnosisFinalizerUserNationalCode1FullName = row["DiagnosisFinalizerUserNationalCode1FullName"].ToString();
				declaration.DiagnosisFinalizerUserNationalCode2FullName = row["DiagnosisFinalizerUserNationalCode2FullName"].ToString();
				declaration.PrintRegisterDate = row["PrintRegisterDate"].ToString();
				declaration.RegisterDate = row["RegisterDate"].ToString();
				declaration.RegisterInformationDate = row["RegisterInformationDate"].ToString();
				declaration.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
				declaration.OldRegisterDate = row["OldRegisterDate"].ToString();
				declaration.PrintRegisterInformationID = row["PrintRegisterInformationID"].ToString();
				declaration.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
				declaration.DeclarationTypeID = (row["DeclarationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DeclarationTypeID"]) : 0 ;
				declaration.AutomaticShareCalculation1 = (row["AutomaticShareCalculation1"] != DBNull.Value) ? Convert.ToBoolean((row["AutomaticShareCalculation1"].ToString() == "1" || row["AutomaticShareCalculation1"].ToString().ToLower() == "true" ) ? true : false) : false ;
				declaration.AutomaticShareCalculation2 = (row["AutomaticShareCalculation2"] != DBNull.Value) ? Convert.ToBoolean((row["AutomaticShareCalculation2"].ToString() == "1" || row["AutomaticShareCalculation2"].ToString().ToLower() == "true" ) ? true : false) : false ;
				declaration.RequestResource = row["RequestResource"].ToString();
				declaration.RequestNumber = row["RequestNumber"].ToString();
				declaration.DeclarationTitle = row["DeclarationTitle"].ToString();
				declaration.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
				declaration.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
				declaration.WillID = (row["WillID"] != DBNull.Value) ? Convert.ToInt64(row["WillID"]) : 0 ;
				declaration.FinalizerUserNationalCode1 = (row["FinalizerUserNationalCode1"] != DBNull.Value) ? Convert.ToInt64(row["FinalizerUserNationalCode1"]) : 0 ;
				declaration.FinalizerUserNationalCode2 = (row["FinalizerUserNationalCode2"] != DBNull.Value) ? Convert.ToInt64(row["FinalizerUserNationalCode2"]) : 0 ;
				declaration.DiagnosisFinalizerUserNationalCode1 = (row["DiagnosisFinalizerUserNationalCode1"] != DBNull.Value) ? Convert.ToInt64(row["DiagnosisFinalizerUserNationalCode1"]) : 0 ;
				declaration.DiagnosisFinalizerUserNationalCode2 = (row["DiagnosisFinalizerUserNationalCode2"] != DBNull.Value) ? Convert.ToInt64(row["DiagnosisFinalizerUserNationalCode2"]) : 0 ;
				declaration.DiagnosisRegisterInformationID = (row["DiagnosisRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["DiagnosisRegisterInformationID"]) : 0 ;
				declaration.DeclarationRegisterNumberInCentral = row["DeclarationRegisterNumberInCentral"].ToString();
				declaration.FinalDate1 = row["FinalDate1"].ToString();
				declaration.FinalDate2 = row["FinalDate2"].ToString();
				declaration.FinalDateDiagnosis1 = row["FinalDateDiagnosis1"].ToString();
				declaration.FinalDateDiagnosis2 = row["FinalDateDiagnosis2"].ToString();
				declaration.FinalDateAdjustment = row["FinalDateAdjustment"].ToString();
				declaration.FinalDateCommisionAdjustment = row["FinalDateCommisionAdjustment"].ToString();
				declaration.DeliveryDate = row["DeliveryDate"].ToString();
				declaration.DeclarationRegisterDateInCentral = row["DeclarationRegisterDateInCentral"].ToString();
				declaration.RequestDate = row["RequestDate"].ToString();
				declaration.DiagnosisRegisterDate = row["DiagnosisRegisterDate"].ToString();
			}
		}

		return declaration;
	}

	public Declaration GetDetails(Int64 declarationID , int stage)
	{
		Declaration declaration = new Declaration();

		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID),
			new SqlParameter("@Stage", stage)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Declaration_GetDetailsBy_DeclarationIDStage", CommandType.StoredProcedure, parametersDeclaration))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				declaration.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				declaration.StageTitle = row["StageTitle"].ToString();
				declaration.DeclarationTypeIDTitle = row["DeclarationTypeIDTitle"].ToString();
				declaration.FinalizerUserNationalCode1FullName = row["FinalizerUserNationalCode1FullName"].ToString();
				declaration.FinalizerUserNationalCode2FullName = row["FinalizerUserNationalCode2FullName"].ToString();
				declaration.DiagnosisFinalizerUserNationalCode1FullName = row["DiagnosisFinalizerUserNationalCode1FullName"].ToString();
				declaration.DiagnosisFinalizerUserNationalCode2FullName = row["DiagnosisFinalizerUserNationalCode2FullName"].ToString();
				declaration.PrintRegisterDate = row["PrintRegisterDate"].ToString();
				declaration.RegisterDate = row["RegisterDate"].ToString();
				declaration.RegisterInformationDate = row["RegisterInformationDate"].ToString();
				declaration.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
				declaration.OldRegisterDate = row["OldRegisterDate"].ToString();
				declaration.PrintRegisterInformationID = row["PrintRegisterInformationID"].ToString();
				declaration.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
				declaration.DeclarationTypeID = (row["DeclarationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DeclarationTypeID"]) : 0 ;
				declaration.AutomaticShareCalculation1 = (row["AutomaticShareCalculation1"] != DBNull.Value) ? Convert.ToBoolean((row["AutomaticShareCalculation1"].ToString() == "1" || row["AutomaticShareCalculation1"].ToString().ToLower() == "true" ) ? true : false) : false ;
				declaration.AutomaticShareCalculation2 = (row["AutomaticShareCalculation2"] != DBNull.Value) ? Convert.ToBoolean((row["AutomaticShareCalculation2"].ToString() == "1" || row["AutomaticShareCalculation2"].ToString().ToLower() == "true" ) ? true : false) : false ;
				declaration.RequestResource = row["RequestResource"].ToString();
				declaration.RequestNumber = row["RequestNumber"].ToString();
				declaration.DeclarationTitle = row["DeclarationTitle"].ToString();
				declaration.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
				declaration.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
				declaration.WillID = (row["WillID"] != DBNull.Value) ? Convert.ToInt64(row["WillID"]) : 0 ;
				declaration.FinalizerUserNationalCode1 = (row["FinalizerUserNationalCode1"] != DBNull.Value) ? Convert.ToInt64(row["FinalizerUserNationalCode1"]) : 0 ;
				declaration.FinalizerUserNationalCode2 = (row["FinalizerUserNationalCode2"] != DBNull.Value) ? Convert.ToInt64(row["FinalizerUserNationalCode2"]) : 0 ;
				declaration.DiagnosisFinalizerUserNationalCode1 = (row["DiagnosisFinalizerUserNationalCode1"] != DBNull.Value) ? Convert.ToInt64(row["DiagnosisFinalizerUserNationalCode1"]) : 0 ;
				declaration.DiagnosisFinalizerUserNationalCode2 = (row["DiagnosisFinalizerUserNationalCode2"] != DBNull.Value) ? Convert.ToInt64(row["DiagnosisFinalizerUserNationalCode2"]) : 0 ;
				declaration.DiagnosisRegisterInformationID = (row["DiagnosisRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["DiagnosisRegisterInformationID"]) : 0 ;
				declaration.DeclarationRegisterNumberInCentral = row["DeclarationRegisterNumberInCentral"].ToString();
				declaration.FinalDate1 = row["FinalDate1"].ToString();
				declaration.FinalDate2 = row["FinalDate2"].ToString();
				declaration.FinalDateDiagnosis1 = row["FinalDateDiagnosis1"].ToString();
				declaration.FinalDateDiagnosis2 = row["FinalDateDiagnosis2"].ToString();
				declaration.FinalDateAdjustment = row["FinalDateAdjustment"].ToString();
				declaration.FinalDateCommisionAdjustment = row["FinalDateCommisionAdjustment"].ToString();
				declaration.DeliveryDate = row["DeliveryDate"].ToString();
				declaration.DeclarationRegisterDateInCentral = row["DeclarationRegisterDateInCentral"].ToString();
				declaration.RequestDate = row["RequestDate"].ToString();
				declaration.DiagnosisRegisterDate = row["DiagnosisRegisterDate"].ToString();
			}
		}

		return declaration;
	}

	public List<Declaration> GetListAll()
	{
		List<Declaration> listDeclaration = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Declaration_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listDeclaration = new List<Declaration>();

				foreach (DataRow row in table.Rows)
				{
					Declaration declaration = new Declaration();
					declaration.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					declaration.StageTitle = row["StageTitle"].ToString();
					declaration.DeclarationTypeIDTitle = row["DeclarationTypeIDTitle"].ToString();
					declaration.FinalizerUserNationalCode1FullName = row["FinalizerUserNationalCode1FullName"].ToString();
					declaration.FinalizerUserNationalCode2FullName = row["FinalizerUserNationalCode2FullName"].ToString();
					declaration.DiagnosisFinalizerUserNationalCode1FullName = row["DiagnosisFinalizerUserNationalCode1FullName"].ToString();
					declaration.DiagnosisFinalizerUserNationalCode2FullName = row["DiagnosisFinalizerUserNationalCode2FullName"].ToString();
					declaration.PrintRegisterDate = row["PrintRegisterDate"].ToString();
					declaration.RegisterDate = row["RegisterDate"].ToString();
					declaration.RegisterInformationDate = row["RegisterInformationDate"].ToString();
					declaration.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					declaration.OldRegisterDate = row["OldRegisterDate"].ToString();
					declaration.PrintRegisterInformationID = row["PrintRegisterInformationID"].ToString();
					declaration.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
					declaration.DeclarationTypeID = (row["DeclarationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DeclarationTypeID"]) : 0 ;
				declaration.AutomaticShareCalculation1 = (row["AutomaticShareCalculation1"] != DBNull.Value) ? Convert.ToBoolean((row["AutomaticShareCalculation1"].ToString() == "1" || row["AutomaticShareCalculation1"].ToString().ToLower() == "true" ) ? true : false) : false ;
				declaration.AutomaticShareCalculation2 = (row["AutomaticShareCalculation2"] != DBNull.Value) ? Convert.ToBoolean((row["AutomaticShareCalculation2"].ToString() == "1" || row["AutomaticShareCalculation2"].ToString().ToLower() == "true" ) ? true : false) : false ;
					declaration.RequestResource = row["RequestResource"].ToString();
					declaration.RequestNumber = row["RequestNumber"].ToString();
					declaration.DeclarationTitle = row["DeclarationTitle"].ToString();
					declaration.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					declaration.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					declaration.WillID = (row["WillID"] != DBNull.Value) ? Convert.ToInt64(row["WillID"]) : 0 ;
					declaration.FinalizerUserNationalCode1 = (row["FinalizerUserNationalCode1"] != DBNull.Value) ? Convert.ToInt64(row["FinalizerUserNationalCode1"]) : 0 ;
					declaration.FinalizerUserNationalCode2 = (row["FinalizerUserNationalCode2"] != DBNull.Value) ? Convert.ToInt64(row["FinalizerUserNationalCode2"]) : 0 ;
					declaration.DiagnosisFinalizerUserNationalCode1 = (row["DiagnosisFinalizerUserNationalCode1"] != DBNull.Value) ? Convert.ToInt64(row["DiagnosisFinalizerUserNationalCode1"]) : 0 ;
					declaration.DiagnosisFinalizerUserNationalCode2 = (row["DiagnosisFinalizerUserNationalCode2"] != DBNull.Value) ? Convert.ToInt64(row["DiagnosisFinalizerUserNationalCode2"]) : 0 ;
					declaration.DiagnosisRegisterInformationID = (row["DiagnosisRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["DiagnosisRegisterInformationID"]) : 0 ;
					declaration.DeclarationRegisterNumberInCentral = row["DeclarationRegisterNumberInCentral"].ToString();
					declaration.FinalDate1 = row["FinalDate1"].ToString();
					declaration.FinalDate2 = row["FinalDate2"].ToString();
					declaration.FinalDateDiagnosis1 = row["FinalDateDiagnosis1"].ToString();
					declaration.FinalDateDiagnosis2 = row["FinalDateDiagnosis2"].ToString();
					declaration.FinalDateAdjustment = row["FinalDateAdjustment"].ToString();
					declaration.FinalDateCommisionAdjustment = row["FinalDateCommisionAdjustment"].ToString();
					declaration.DeliveryDate = row["DeliveryDate"].ToString();
					declaration.DeclarationRegisterDateInCentral = row["DeclarationRegisterDateInCentral"].ToString();
					declaration.RequestDate = row["RequestDate"].ToString();
					declaration.DiagnosisRegisterDate = row["DiagnosisRegisterDate"].ToString();
					listDeclaration.Add(declaration);
				}
			}
		}

		return listDeclaration;
	}

	public bool Exists(Int64 declarationID)
	{
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declarationID)
		};
		return (SqlDBHelper.ExecuteScalar("Declaration_Exists", CommandType.StoredProcedure, parametersDeclaration)>0);
	}

	public bool Exists(Declaration declaration)
	{
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declaration.DeclarationID)
		};
		return (SqlDBHelper.ExecuteScalar("Declaration_Exists", CommandType.StoredProcedure, parametersDeclaration)>0);
	}

	public List<Declaration> GetListByDeclarationDeclarationIDStage(Int64 declarationID,int stage)
	{
		List<Declaration> listDeclaration = new List<Declaration>();

		//Lets get the list of all Declaration records from database using DeclarationID Stage
		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@declarationID", declarationID),
			new SqlParameter("@stage", stage)
		};
		//Lets get the list of Declaration records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Declaration_GetListByDeclarationIDStage", CommandType.StoredProcedure, parametersDeclaration))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of declaration
				listDeclaration = new List<Declaration>();

				//Now lets populate the declaration details into the list of declarations
				foreach (DataRow row in table.Rows)
				{
					Declaration declaration = new Declaration();
					declaration.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					declaration.StageTitle = row["StageTitle"].ToString();
					declaration.DeclarationTypeIDTitle = row["DeclarationTypeIDTitle"].ToString();
					declaration.FinalizerUserNationalCode1FullName = row["FinalizerUserNationalCode1FullName"].ToString();
					declaration.FinalizerUserNationalCode2FullName = row["FinalizerUserNationalCode2FullName"].ToString();
					declaration.DiagnosisFinalizerUserNationalCode1FullName = row["DiagnosisFinalizerUserNationalCode1FullName"].ToString();
					declaration.DiagnosisFinalizerUserNationalCode2FullName = row["DiagnosisFinalizerUserNationalCode2FullName"].ToString();
					declaration.PrintRegisterDate = row["PrintRegisterDate"].ToString();
					declaration.RegisterDate = row["RegisterDate"].ToString();
					declaration.RegisterInformationDate = row["RegisterInformationDate"].ToString();
					declaration.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					declaration.OldRegisterDate = row["OldRegisterDate"].ToString();
					declaration.PrintRegisterInformationID = row["PrintRegisterInformationID"].ToString();
					declaration.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
					declaration.DeclarationTypeID = (row["DeclarationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DeclarationTypeID"]) : 0 ;
				declaration.AutomaticShareCalculation1 = (row["AutomaticShareCalculation1"] != DBNull.Value) ? Convert.ToBoolean((row["AutomaticShareCalculation1"].ToString() == "1" || row["AutomaticShareCalculation1"].ToString().ToLower() == "true" ) ? true : false) : false ;
				declaration.AutomaticShareCalculation2 = (row["AutomaticShareCalculation2"] != DBNull.Value) ? Convert.ToBoolean((row["AutomaticShareCalculation2"].ToString() == "1" || row["AutomaticShareCalculation2"].ToString().ToLower() == "true" ) ? true : false) : false ;
					declaration.RequestResource = row["RequestResource"].ToString();
					declaration.RequestNumber = row["RequestNumber"].ToString();
					declaration.DeclarationTitle = row["DeclarationTitle"].ToString();
					declaration.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					declaration.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					declaration.WillID = (row["WillID"] != DBNull.Value) ? Convert.ToInt64(row["WillID"]) : 0 ;
					declaration.FinalizerUserNationalCode1 = (row["FinalizerUserNationalCode1"] != DBNull.Value) ? Convert.ToInt64(row["FinalizerUserNationalCode1"]) : 0 ;
					declaration.FinalizerUserNationalCode2 = (row["FinalizerUserNationalCode2"] != DBNull.Value) ? Convert.ToInt64(row["FinalizerUserNationalCode2"]) : 0 ;
					declaration.DiagnosisFinalizerUserNationalCode1 = (row["DiagnosisFinalizerUserNationalCode1"] != DBNull.Value) ? Convert.ToInt64(row["DiagnosisFinalizerUserNationalCode1"]) : 0 ;
					declaration.DiagnosisFinalizerUserNationalCode2 = (row["DiagnosisFinalizerUserNationalCode2"] != DBNull.Value) ? Convert.ToInt64(row["DiagnosisFinalizerUserNationalCode2"]) : 0 ;
					declaration.DiagnosisRegisterInformationID = (row["DiagnosisRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["DiagnosisRegisterInformationID"]) : 0 ;
					declaration.DeclarationRegisterNumberInCentral = row["DeclarationRegisterNumberInCentral"].ToString();
					declaration.FinalDate1 = row["FinalDate1"].ToString();
					declaration.FinalDate2 = row["FinalDate2"].ToString();
					declaration.FinalDateDiagnosis1 = row["FinalDateDiagnosis1"].ToString();
					declaration.FinalDateDiagnosis2 = row["FinalDateDiagnosis2"].ToString();
					declaration.FinalDateAdjustment = row["FinalDateAdjustment"].ToString();
					declaration.FinalDateCommisionAdjustment = row["FinalDateCommisionAdjustment"].ToString();
					declaration.DeliveryDate = row["DeliveryDate"].ToString();
					declaration.DeclarationRegisterDateInCentral = row["DeclarationRegisterDateInCentral"].ToString();
					declaration.RequestDate = row["RequestDate"].ToString();
					declaration.DiagnosisRegisterDate = row["DiagnosisRegisterDate"].ToString();
					listDeclaration.Add(declaration);
				}
			}
		}

		return listDeclaration;
	}

	public List<Declaration> SearchLike(Declaration declaration)
	{
		List<Declaration> listDeclaration = new List<Declaration>();


		SqlParameter[] parametersDeclaration = new SqlParameter[]
		{
			new SqlParameter("@DeclarationID", declaration.DeclarationID),
			new SqlParameter("@StageTitle", declaration.StageTitle),
			new SqlParameter("@DeclarationTypeIDTitle", declaration.DeclarationTypeIDTitle),
			new SqlParameter("@FinalizerUserNationalCode1FullName", declaration.FinalizerUserNationalCode1FullName),
			new SqlParameter("@FinalizerUserNationalCode2FullName", declaration.FinalizerUserNationalCode2FullName),
			new SqlParameter("@DiagnosisFinalizerUserNationalCode1FullName", declaration.DiagnosisFinalizerUserNationalCode1FullName),
			new SqlParameter("@DiagnosisFinalizerUserNationalCode2FullName", declaration.DiagnosisFinalizerUserNationalCode2FullName),
			new SqlParameter("@PrintRegisterDate", declaration.PrintRegisterDate),
			new SqlParameter("@RegisterDate", declaration.RegisterDate),
			new SqlParameter("@RegisterInformationDate", declaration.RegisterInformationDate),
			new SqlParameter("@OldRegisterInformationID", declaration.OldRegisterInformationID),
			new SqlParameter("@OldRegisterDate", declaration.OldRegisterDate),
			new SqlParameter("@PrintRegisterInformationID", declaration.PrintRegisterInformationID),
			new SqlParameter("@Stage", declaration.Stage),
			new SqlParameter("@DeclarationTypeID", declaration.DeclarationTypeID),
			new SqlParameter("@AutomaticShareCalculation1", declaration.AutomaticShareCalculation1),
			new SqlParameter("@AutomaticShareCalculation2", declaration.AutomaticShareCalculation2),
			new SqlParameter("@RequestResource", declaration.RequestResource),
			new SqlParameter("@RequestNumber", declaration.RequestNumber),
			new SqlParameter("@DeclarationTitle", declaration.DeclarationTitle),
			new SqlParameter("@DossierID", declaration.DossierID),
			new SqlParameter("@RegisterInformationID", declaration.RegisterInformationID),
			new SqlParameter("@WillID", declaration.WillID),
			new SqlParameter("@FinalizerUserNationalCode1", declaration.FinalizerUserNationalCode1),
			new SqlParameter("@FinalizerUserNationalCode2", declaration.FinalizerUserNationalCode2),
			new SqlParameter("@DiagnosisFinalizerUserNationalCode1", declaration.DiagnosisFinalizerUserNationalCode1),
			new SqlParameter("@DiagnosisFinalizerUserNationalCode2", declaration.DiagnosisFinalizerUserNationalCode2),
			new SqlParameter("@DiagnosisRegisterInformationID", declaration.DiagnosisRegisterInformationID),
			new SqlParameter("@DeclarationRegisterNumberInCentral", declaration.DeclarationRegisterNumberInCentral),
			new SqlParameter("@FinalDate1", declaration.FinalDate1),
			new SqlParameter("@FinalDate2", declaration.FinalDate2),
			new SqlParameter("@FinalDateDiagnosis1", declaration.FinalDateDiagnosis1),
			new SqlParameter("@FinalDateDiagnosis2", declaration.FinalDateDiagnosis2),
			new SqlParameter("@FinalDateAdjustment", declaration.FinalDateAdjustment),
			new SqlParameter("@FinalDateCommisionAdjustment", declaration.FinalDateCommisionAdjustment),
			new SqlParameter("@DeliveryDate", declaration.DeliveryDate),
			new SqlParameter("@DeclarationRegisterDateInCentral", declaration.DeclarationRegisterDateInCentral),
			new SqlParameter("@RequestDate", declaration.RequestDate),
			new SqlParameter("@DiagnosisRegisterDate", declaration.DiagnosisRegisterDate),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Declaration_SearchLike", CommandType.StoredProcedure, parametersDeclaration))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Declaration tmpDeclaration = new Declaration();
					tmpDeclaration.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpDeclaration.StageTitle = row["StageTitle"].ToString();
					tmpDeclaration.DeclarationTypeIDTitle = row["DeclarationTypeIDTitle"].ToString();
					tmpDeclaration.FinalizerUserNationalCode1FullName = row["FinalizerUserNationalCode1FullName"].ToString();
					tmpDeclaration.FinalizerUserNationalCode2FullName = row["FinalizerUserNationalCode2FullName"].ToString();
					tmpDeclaration.DiagnosisFinalizerUserNationalCode1FullName = row["DiagnosisFinalizerUserNationalCode1FullName"].ToString();
					tmpDeclaration.DiagnosisFinalizerUserNationalCode2FullName = row["DiagnosisFinalizerUserNationalCode2FullName"].ToString();
					tmpDeclaration.PrintRegisterDate = row["PrintRegisterDate"].ToString();
					tmpDeclaration.RegisterDate = row["RegisterDate"].ToString();
					tmpDeclaration.RegisterInformationDate = row["RegisterInformationDate"].ToString();
					tmpDeclaration.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					tmpDeclaration.OldRegisterDate = row["OldRegisterDate"].ToString();
					tmpDeclaration.PrintRegisterInformationID = row["PrintRegisterInformationID"].ToString();
					tmpDeclaration.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
					tmpDeclaration.DeclarationTypeID = (row["DeclarationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DeclarationTypeID"]) : 0 ;
					tmpDeclaration.AutomaticShareCalculation1 = (row["AutomaticShareCalculation1"] != DBNull.Value) ? Convert.ToBoolean((row["AutomaticShareCalculation1"].ToString() == "1" || row["AutomaticShareCalculation1"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpDeclaration.AutomaticShareCalculation2 = (row["AutomaticShareCalculation2"] != DBNull.Value) ? Convert.ToBoolean((row["AutomaticShareCalculation2"].ToString() == "1" || row["AutomaticShareCalculation2"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpDeclaration.RequestResource = row["RequestResource"].ToString();
					tmpDeclaration.RequestNumber = row["RequestNumber"].ToString();
					tmpDeclaration.DeclarationTitle = row["DeclarationTitle"].ToString();
					tmpDeclaration.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					tmpDeclaration.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					tmpDeclaration.WillID = (row["WillID"] != DBNull.Value) ? Convert.ToInt64(row["WillID"]) : 0 ;
					tmpDeclaration.FinalizerUserNationalCode1 = (row["FinalizerUserNationalCode1"] != DBNull.Value) ? Convert.ToInt64(row["FinalizerUserNationalCode1"]) : 0 ;
					tmpDeclaration.FinalizerUserNationalCode2 = (row["FinalizerUserNationalCode2"] != DBNull.Value) ? Convert.ToInt64(row["FinalizerUserNationalCode2"]) : 0 ;
					tmpDeclaration.DiagnosisFinalizerUserNationalCode1 = (row["DiagnosisFinalizerUserNationalCode1"] != DBNull.Value) ? Convert.ToInt64(row["DiagnosisFinalizerUserNationalCode1"]) : 0 ;
					tmpDeclaration.DiagnosisFinalizerUserNationalCode2 = (row["DiagnosisFinalizerUserNationalCode2"] != DBNull.Value) ? Convert.ToInt64(row["DiagnosisFinalizerUserNationalCode2"]) : 0 ;
					tmpDeclaration.DiagnosisRegisterInformationID = (row["DiagnosisRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["DiagnosisRegisterInformationID"]) : 0 ;
					tmpDeclaration.DeclarationRegisterNumberInCentral = row["DeclarationRegisterNumberInCentral"].ToString();
					tmpDeclaration.FinalDate1 = row["FinalDate1"].ToString();
					tmpDeclaration.FinalDate2 = row["FinalDate2"].ToString();
					tmpDeclaration.FinalDateDiagnosis1 = row["FinalDateDiagnosis1"].ToString();
					tmpDeclaration.FinalDateDiagnosis2 = row["FinalDateDiagnosis2"].ToString();
					tmpDeclaration.FinalDateAdjustment = row["FinalDateAdjustment"].ToString();
					tmpDeclaration.FinalDateCommisionAdjustment = row["FinalDateCommisionAdjustment"].ToString();
					tmpDeclaration.DeliveryDate = row["DeliveryDate"].ToString();
					tmpDeclaration.DeclarationRegisterDateInCentral = row["DeclarationRegisterDateInCentral"].ToString();
					tmpDeclaration.RequestDate = row["RequestDate"].ToString();
					tmpDeclaration.DiagnosisRegisterDate = row["DiagnosisRegisterDate"].ToString();

					listDeclaration.Add(tmpDeclaration);
				}
			}
		}

		return listDeclaration;
	}

}
}
