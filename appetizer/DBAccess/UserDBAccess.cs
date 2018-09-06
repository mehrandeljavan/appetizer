using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class UserDBAccess
{
	PersonDBAccess personDBAccess = new PersonDBAccess();

	FormDeclarationDeliveryDBAccess formDeclarationDeliveryDBAccess = new FormDeclarationDeliveryDBAccess();
	FormDeclarationInputInfoDBAccess formDeclarationInputInfoDBAccess = new FormDeclarationInputInfoDBAccess();
	FormDeterministicPaperDBAccess formDeterministicPaperDBAccess = new FormDeterministicPaperDBAccess();
	FormDiagnosisPaperDBAccess formDiagnosisPaperDBAccess = new FormDiagnosisPaperDBAccess();
	FormHeritageBillDBAccess formHeritageBillDBAccess = new FormHeritageBillDBAccess();
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
	PhysicalDossierDeliveryDBAccess physicalDossierDeliveryDBAccess = new PhysicalDossierDeliveryDBAccess();
	QuestionDBAccess questionDBAccess = new QuestionDBAccess();
	QuestionScoreDBAccess questionScoreDBAccess = new QuestionScoreDBAccess();
	UserDossierDBAccess userDossierDBAccess = new UserDossierDBAccess();
	UserTaxOfficeActivityRolePartDBAccess userTaxOfficeActivityRolePartDBAccess = new UserTaxOfficeActivityRolePartDBAccess();
	UserTaxOfficeRolePartDBAccess userTaxOfficeRolePartDBAccess = new UserTaxOfficeRolePartDBAccess();

	public List<FormDeclarationDelivery> GetListFormDeclarationDelivery(Int64 nationalCode)
	{
		List<FormDeclarationDelivery> listFormDeclarationDelivery = new List<FormDeclarationDelivery>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationDeliveryRegisterarUserNationalCode", nationalCode)
		};

		//Lets get the list of FormDeclarationDelivery records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDeclarationDelivery_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
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
	public List<FormDeclarationInputInfo> GetListFormDeclarationInputInfo(Int64 nationalCode)
	{
		List<FormDeclarationInputInfo> listFormDeclarationInputInfo = new List<FormDeclarationInputInfo>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationInputInfoRegisterarUserNationalCode", nationalCode)
		};

		//Lets get the list of FormDeclarationInputInfo records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDeclarationInputInfo_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
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
	public List<FormDeterministicPaper> GetListFormDeterministicPaper(Int64 nationalCode)
	{
		List<FormDeterministicPaper> listFormDeterministicPaper = new List<FormDeterministicPaper>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@FormDeterministicPaperRegisterarUserNationalCode", nationalCode)
		};

		//Lets get the list of FormDeterministicPaper records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDeterministicPaper_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
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
	public List<FormDiagnosisPaper> GetListFormDiagnosisPaper(Int64 nationalCode)
	{
		List<FormDiagnosisPaper> listFormDiagnosisPaper = new List<FormDiagnosisPaper>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisPaperRegisterarUserNationalCode", nationalCode)
		};

		//Lets get the list of FormDiagnosisPaper records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDiagnosisPaper_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
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
	public List<FormHeritageBill> GetListFormHeritageBill(Int64 nationalCode)
	{
		List<FormHeritageBill> listFormHeritageBill = new List<FormHeritageBill>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageBillRegisterarUserNationalCode", nationalCode)
		};

		//Lets get the list of FormHeritageBill records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeritageBill_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
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
	public List<FormHeritageList> GetListFormHeritageList(Int64 nationalCode)
	{
		List<FormHeritageList> listFormHeritageList = new List<FormHeritageList>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageListRegisterarUserNationalCode", nationalCode)
		};

		//Lets get the list of FormHeritageList records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeritageList_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
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
	public List<FormHeritagesDescriptions> GetListFormHeritagesDescriptions(Int64 nationalCode)
	{
		List<FormHeritagesDescriptions> listFormHeritagesDescriptions = new List<FormHeritagesDescriptions>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@FormHeritagesDescriptionsRegisterarUserNationalCode", nationalCode)
		};

		//Lets get the list of FormHeritagesDescriptions records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeritagesDescriptions_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
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
	public List<FormInquiryBankDeposit> GetListFormInquiryBankDeposit(Int64 nationalCode)
	{
		List<FormInquiryBankDeposit> listFormInquiryBankDeposit = new List<FormInquiryBankDeposit>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryBankDepositRegisterarUserNationalCode", nationalCode)
		};

		//Lets get the list of FormInquiryBankDeposit records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryBankDeposit_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
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
	public List<FormInquiryCompany> GetListFormInquiryCompany(Int64 nationalCode)
	{
		List<FormInquiryCompany> listFormInquiryCompany = new List<FormInquiryCompany>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryCompanyRegisterarUserNationalCode", nationalCode)
		};

		//Lets get the list of FormInquiryCompany records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryCompany_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
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
	public List<FormInquiryEstate> GetListFormInquiryEstate(Int64 nationalCode)
	{
		List<FormInquiryEstate> listFormInquiryEstate = new List<FormInquiryEstate>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryEstateRegisterarUserNationalCode", nationalCode)
		};

		//Lets get the list of FormInquiryEstate records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryEstate_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
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
	public List<FormInquiryGoodWillEvaluation> GetListFormInquiryGoodWillEvaluation(Int64 nationalCode)
	{
		List<FormInquiryGoodWillEvaluation> listFormInquiryGoodWillEvaluation = new List<FormInquiryGoodWillEvaluation>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillEvaluationRegisterarUserNationalCode", nationalCode)
		};

		//Lets get the list of FormInquiryGoodWillEvaluation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryGoodWillEvaluation_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
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
	public List<FormInquiryGoodWillScore> GetListFormInquiryGoodWillScore(Int64 nationalCode)
	{
		List<FormInquiryGoodWillScore> listFormInquiryGoodWillScore = new List<FormInquiryGoodWillScore>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillScoreRegisterarUserNationalCode", nationalCode)
		};

		//Lets get the list of FormInquiryGoodWillScore records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryGoodWillScore_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
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
	public List<FormInquiryOther> GetListFormInquiryOther(Int64 nationalCode)
	{
		List<FormInquiryOther> listFormInquiryOther = new List<FormInquiryOther>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryOtherRegisterarUserNationalCode", nationalCode)
		};

		//Lets get the list of FormInquiryOther records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryOther_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
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
	public List<FormInquiryTransferRightEvaluation> GetListFormInquiryTransferRightEvaluation(Int64 nationalCode)
	{
		List<FormInquiryTransferRightEvaluation> listFormInquiryTransferRightEvaluation = new List<FormInquiryTransferRightEvaluation>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightEvaluationRegisterarUserNationalCode", nationalCode)
		};

		//Lets get the list of FormInquiryTransferRightEvaluation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryTransferRightEvaluation_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
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
	public List<FormInquiryTransferRightScore> GetListFormInquiryTransferRightScore(Int64 nationalCode)
	{
		List<FormInquiryTransferRightScore> listFormInquiryTransferRightScore = new List<FormInquiryTransferRightScore>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightScoreRegisterarUserNationalCode", nationalCode)
		};

		//Lets get the list of FormInquiryTransferRightScore records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryTransferRightScore_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
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
	public List<FormTaxBill> GetListFormTaxBill(Int64 nationalCode)
	{
		List<FormTaxBill> listFormTaxBill = new List<FormTaxBill>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@FormTaxBillRegisterarUserNationalCode", nationalCode)
		};

		//Lets get the list of FormTaxBill records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormTaxBill_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
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
	public List<PhysicalDossierDelivery> GetListPhysicalDossierDelivery(Int64 nationalCode)
	{
		List<PhysicalDossierDelivery> listPhysicalDossierDelivery = new List<PhysicalDossierDelivery>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@ToUserNationalCode", nationalCode)
		};

		//Lets get the list of PhysicalDossierDelivery records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("PhysicalDossierDelivery_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of physicalDossierDelivery
				listPhysicalDossierDelivery = new List<PhysicalDossierDelivery>();

				//Now lets populate the PhysicalDossierDelivery details into the list of physicalDossierDeliverys
				foreach (DataRow row in table.Rows)
				{
					PhysicalDossierDelivery physicalDossierDelivery = ConvertRowToPhysicalDossierDelivery(row);
					listPhysicalDossierDelivery.Add(physicalDossierDelivery);
				}
			}
		}

		return listPhysicalDossierDelivery;
	}

	private PhysicalDossierDelivery ConvertRowToPhysicalDossierDelivery(DataRow row)
	{
		PhysicalDossierDelivery physicalDossierDelivery = new PhysicalDossierDelivery();
		physicalDossierDelivery.PhysicalDossierDeliveryID = (row["PhysicalDossierDeliveryID"] != DBNull.Value) ? Convert.ToInt64(row["PhysicalDossierDeliveryID"]) : 0 ;
		physicalDossierDelivery.FromUserFullName = row["FromUserFullName"].ToString();
		physicalDossierDelivery.ToUserFullName = row["ToUserFullName"].ToString();
		physicalDossierDelivery.DeliveryTypeIDTitle = row["DeliveryTypeIDTitle"].ToString();
		physicalDossierDelivery.DeliveryTypeID = (row["DeliveryTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DeliveryTypeID"]) : 0 ;
		physicalDossierDelivery.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
		physicalDossierDelivery.FromUserNationalCode = (row["FromUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FromUserNationalCode"]) : 0 ;
		physicalDossierDelivery.ToUserNationalCode = (row["ToUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["ToUserNationalCode"]) : 0 ;
		physicalDossierDelivery.DeliveryDate = row["DeliveryDate"].ToString();
		physicalDossierDelivery.DeliveryTime = row["DeliveryTime"].ToString();
		physicalDossierDelivery.Description = row["Description"].ToString();
		return physicalDossierDelivery;
	}
	public List<Question> GetListQuestion(Int64 nationalCode)
	{
		List<Question> listQuestion = new List<Question>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@UserNationalCode", nationalCode)
		};

		//Lets get the list of Question records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Question_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of question
				listQuestion = new List<Question>();

				//Now lets populate the Question details into the list of questions
				foreach (DataRow row in table.Rows)
				{
					Question question = ConvertRowToQuestion(row);
					listQuestion.Add(question);
				}
			}
		}

		return listQuestion;
	}

	private Question ConvertRowToQuestion(DataRow row)
	{
		Question question = new Question();
		question.QuestionID = (row["QuestionID"] != DBNull.Value) ? Convert.ToInt64(row["QuestionID"]) : 0 ;
		question.UserFullName = row["UserFullName"].ToString();
		question.TotalMark = (row["TotalMark"] != DBNull.Value) ? Convert.ToInt64(row["TotalMark"]) : 0 ;
		question.QuestionDate = row["QuestionDate"].ToString();
		question.QuestionText = row["QuestionText"].ToString();
		question.Answer = row["Answer"].ToString();
		question.Visible = (row["Visible"] != DBNull.Value) ? Convert.ToBoolean((row["Visible"].ToString() == "1" || row["Visible"].ToString().ToLower() == "true" ) ? true : false) : false ;
		question.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
		return question;
	}
	public List<QuestionScore> GetListQuestionScore(Int64 nationalCode)
	{
		List<QuestionScore> listQuestionScore = new List<QuestionScore>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@UserNationalCode", nationalCode)
		};

		//Lets get the list of QuestionScore records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("QuestionScore_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of questionScore
				listQuestionScore = new List<QuestionScore>();

				//Now lets populate the QuestionScore details into the list of questionScores
				foreach (DataRow row in table.Rows)
				{
					QuestionScore questionScore = ConvertRowToQuestionScore(row);
					listQuestionScore.Add(questionScore);
				}
			}
		}

		return listQuestionScore;
	}

	private QuestionScore ConvertRowToQuestionScore(DataRow row)
	{
		QuestionScore questionScore = new QuestionScore();
		questionScore.QuestionID = (row["QuestionID"] != DBNull.Value) ? Convert.ToInt64(row["QuestionID"]) : 0 ;
		questionScore.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
		questionScore.UserFullName = row["UserFullName"].ToString();
		questionScore.ScoreMark = (row["ScoreMark"] != DBNull.Value) ? Convert.ToInt32(row["ScoreMark"]) : 0 ;
		questionScore.ScoreDate = row["ScoreDate"].ToString();
		return questionScore;
	}
	public List<UserDossier> GetListUserDossier(Int64 nationalCode)
	{
		List<UserDossier> listUserDossier = new List<UserDossier>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@UserNationalCode", nationalCode)
		};

		//Lets get the list of UserDossier records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserDossier_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of userDossier
				listUserDossier = new List<UserDossier>();

				//Now lets populate the UserDossier details into the list of userDossiers
				foreach (DataRow row in table.Rows)
				{
					UserDossier userDossier = ConvertRowToUserDossier(row);
					listUserDossier.Add(userDossier);
				}
			}
		}

		return listUserDossier;
	}

	private UserDossier ConvertRowToUserDossier(DataRow row)
	{
		UserDossier userDossier = new UserDossier();
		userDossier.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
		userDossier.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
		userDossier.UserFullName = row["UserFullName"].ToString();
		userDossier.ReferrerUserNationalCode = (row["ReferrerUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["ReferrerUserNationalCode"]) : 0 ;
		userDossier.StartDate = row["StartDate"].ToString();
		userDossier.EndDate = row["EndDate"].ToString();
		userDossier.ReferenceDate = row["ReferenceDate"].ToString();
		return userDossier;
	}
	public List<UserTaxOfficeActivityRolePart> GetListUserTaxOfficeActivityRolePart(Int64 nationalCode)
	{
		List<UserTaxOfficeActivityRolePart> listUserTaxOfficeActivityRolePart = new List<UserTaxOfficeActivityRolePart>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@UserNationalCode", nationalCode)
		};

		//Lets get the list of UserTaxOfficeActivityRolePart records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserTaxOfficeActivityRolePart_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of userTaxOfficeActivityRolePart
				listUserTaxOfficeActivityRolePart = new List<UserTaxOfficeActivityRolePart>();

				//Now lets populate the UserTaxOfficeActivityRolePart details into the list of userTaxOfficeActivityRoleParts
				foreach (DataRow row in table.Rows)
				{
					UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart = ConvertRowToUserTaxOfficeActivityRolePart(row);
					listUserTaxOfficeActivityRolePart.Add(userTaxOfficeActivityRolePart);
				}
			}
		}

		return listUserTaxOfficeActivityRolePart;
	}

	private UserTaxOfficeActivityRolePart ConvertRowToUserTaxOfficeActivityRolePart(DataRow row)
	{
		UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart = new UserTaxOfficeActivityRolePart();
		userTaxOfficeActivityRolePart.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
		userTaxOfficeActivityRolePart.ActivityID = (row["ActivityID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityID"]) : 0 ;
		userTaxOfficeActivityRolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
		userTaxOfficeActivityRolePart.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
		userTaxOfficeActivityRolePart.UserFullName = row["UserFullName"].ToString();
		userTaxOfficeActivityRolePart.TaxOfficeCodeTitle = row["TaxOfficeCodeTitle"].ToString();
		userTaxOfficeActivityRolePart.RolePartIDTitle = row["RolePartIDTitle"].ToString();
		userTaxOfficeActivityRolePart.ActivityTitle = row["ActivityTitle"].ToString();
		userTaxOfficeActivityRolePart.Permission = (row["Permission"] != DBNull.Value) ? Convert.ToInt32(row["Permission"]) : 0 ;
		return userTaxOfficeActivityRolePart;
	}
	public List<UserTaxOfficeRolePart> GetListUserTaxOfficeRolePart(Int64 nationalCode)
	{
		List<UserTaxOfficeRolePart> listUserTaxOfficeRolePart = new List<UserTaxOfficeRolePart>() { };
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@UserNationalCode", nationalCode)
		};

		//Lets get the list of UserTaxOfficeRolePart records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserTaxOfficeRolePart_GetList_UseInUser", CommandType.StoredProcedure, parametersUser))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of userTaxOfficeRolePart
				listUserTaxOfficeRolePart = new List<UserTaxOfficeRolePart>();

				//Now lets populate the UserTaxOfficeRolePart details into the list of userTaxOfficeRoleParts
				foreach (DataRow row in table.Rows)
				{
					UserTaxOfficeRolePart userTaxOfficeRolePart = ConvertRowToUserTaxOfficeRolePart(row);
					listUserTaxOfficeRolePart.Add(userTaxOfficeRolePart);
				}
			}
		}

		return listUserTaxOfficeRolePart;
	}

	private UserTaxOfficeRolePart ConvertRowToUserTaxOfficeRolePart(DataRow row)
	{
		UserTaxOfficeRolePart userTaxOfficeRolePart = new UserTaxOfficeRolePart();
		userTaxOfficeRolePart.UserTaxOfficeRolePartID = (row["UserTaxOfficeRolePartID"] != DBNull.Value) ? Convert.ToInt64(row["UserTaxOfficeRolePartID"]) : 0 ;
		userTaxOfficeRolePart.UserFullName = row["UserFullName"].ToString();
		userTaxOfficeRolePart.TaxOfficeTitle = row["TaxOfficeTitle"].ToString();
		userTaxOfficeRolePart.RolePartIDTitle = row["RolePartIDTitle"].ToString();
		userTaxOfficeRolePart.Title = row["Title"].ToString();
		userTaxOfficeRolePart.Letters = row["Letters"].ToString();
		userTaxOfficeRolePart.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
		userTaxOfficeRolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
		userTaxOfficeRolePart.TaxUnitCode = (row["TaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxUnitCode"]) : 0 ;
		userTaxOfficeRolePart.IsActive = (row["IsActive"] != DBNull.Value) ? Convert.ToBoolean((row["IsActive"].ToString() == "1" || row["IsActive"].ToString().ToLower() == "true" ) ? true : false) : false ;
		userTaxOfficeRolePart.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
		return userTaxOfficeRolePart;
	}
	public Int64 Insert(User user)
	{
		if (!personDBAccess.Exists(user))
			user.NationalCode = personDBAccess.Insert(user);

		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", (user.NationalCode > 0) ? user.NationalCode : (object)DBNull.Value),
			new SqlParameter("@Password", (user.Password != null) ? user.Password : (object)DBNull.Value),
			new SqlParameter("@PersonalCode", (user.PersonalCode != null) ? user.PersonalCode : (object)DBNull.Value),
			new SqlParameter("@StartDate", (user.StartDate != null) ? user.StartDate : (object)DBNull.Value),
			new SqlParameter("@EndDate", (user.EndDate != null) ? user.EndDate : (object)DBNull.Value),
			new SqlParameter("@Signature", (user.Signature != null) ? user.Signature : (object)DBNull.Value),
			new SqlParameter("@ProvinceIDDefault", (user.ProvinceIDDefault > 0) ? user.ProvinceIDDefault : (object)DBNull.Value),
			new SqlParameter("@SignaturePrint", user.SignaturePrint),
			new SqlParameter("@IsActive", user.IsActive)
		};
		return SqlDBHelper.ExecuteScalar("User_Insert", CommandType.StoredProcedure, parametersUser);
	}

	public bool Update(User user)
	{
		personDBAccess.Update(user);

		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", user.NationalCode),
			new SqlParameter("@Password", (user.Password != null) ? user.Password : (object)DBNull.Value),
			new SqlParameter("@PersonalCode", (user.PersonalCode != null) ? user.PersonalCode : (object)DBNull.Value),
			new SqlParameter("@StartDate", (user.StartDate != null) ? user.StartDate : (object)DBNull.Value),
			new SqlParameter("@EndDate", (user.EndDate != null) ? user.EndDate : (object)DBNull.Value),
			new SqlParameter("@Signature", (user.Signature != null) ? user.Signature : (object)DBNull.Value),
			new SqlParameter("@ProvinceIDDefault", user.ProvinceIDDefault),
			new SqlParameter("@SignaturePrint", user.SignaturePrint),
			new SqlParameter("@IsActive", user.IsActive)
		};
		return SqlDBHelper.ExecuteNonQuery("User_Update", CommandType.StoredProcedure, parametersUser);
	}

	public bool Delete(Int64 nationalCode)
	{
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode)
		};
		return SqlDBHelper.ExecuteNonQuery("User_Delete", CommandType.StoredProcedure, parametersUser);
	}

	public User GetDetails(Int64 nationalCode)
	{
		User user = new User();

		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("User_GetDetails", CommandType.StoredProcedure, parametersUser))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				user.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
				user.UserFullName = row["UserFullName"].ToString();
				user.ProvinceIDDefaultTitle = row["ProvinceIDDefaultTitle"].ToString();
				user.Password = row["Password"].ToString();
				user.PersonalCode = row["PersonalCode"].ToString();
				user.StartDate = row["StartDate"].ToString();
				user.EndDate = row["EndDate"].ToString();
				user.Signature = (row["Signature"] != DBNull.Value) ? Convert.ToInt32(row["Signature"]) : 0 ;
				user.ProvinceIDDefault = (row["ProvinceIDDefault"] != DBNull.Value) ? Convert.ToInt32(row["ProvinceIDDefault"]) : 0 ;
				user.SignaturePrint = (row["SignaturePrint"] != DBNull.Value) ? Convert.ToBoolean((row["SignaturePrint"].ToString() == "1" || row["SignaturePrint"].ToString().ToLower() == "true" ) ? true : false) : false ;
				user.IsActive = (row["IsActive"] != DBNull.Value) ? Convert.ToBoolean((row["IsActive"].ToString() == "1" || row["IsActive"].ToString().ToLower() == "true" ) ? true : false) : false ;

				Person person = personDBAccess.GetDetails(user.NationalCode);
				user.NationalCode = person.NationalCode;
				user.PrintNationalCode = person.PrintNationalCode;
				user.FullName = person.FullName;
				user.GenderIDTitle = person.GenderIDTitle;
				user.Religion_DinIDTitle = person.Religion_DinIDTitle;
				user.Religion_MazhabIDTitle = person.Religion_MazhabIDTitle;
				user.IssuanceProvinceIDTitle = person.IssuanceProvinceIDTitle;
				user.IssuanceCityIDTitle = person.IssuanceCityIDTitle;
				user.IssuanceDepartment = person.IssuanceDepartment;
				user.CertificateNumber = person.CertificateNumber;
				user.CertificateSerial = person.CertificateSerial;
				user.ZipCode = person.ZipCode;
				user.HomeAddress = person.HomeAddress;
				user.PhoneNumber = person.PhoneNumber;
				user.Job = person.Job;
				user.JobAddress = person.JobAddress;
				user.JobPhoneNumber = person.JobPhoneNumber;
				user.Comment = person.Comment;
				user.BirthCity = person.BirthCity;
				user.JobZipCode = person.JobZipCode;
				user.CertificateSerialLetter = person.CertificateSerialLetter;
				user.CertificateSerialNumber = person.CertificateSerialNumber;
				user.FatherName = person.FatherName;
				user.Name = person.Name;
				user.Family = person.Family;
				user.BirthDate = person.BirthDate;
				user.IssuanceDate = person.IssuanceDate;
				user.GenderID = person.GenderID;
				user.IssuanceProvinceID = person.IssuanceProvinceID;
				user.IssuanceCityID = person.IssuanceCityID;
				user.Religion_DinID = person.Religion_DinID;
				user.Religion_MazhabID = person.Religion_MazhabID;
			}
		}

		return user;
	}

	public List<User> GetListAll()
	{
		List<User> listUser = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("User_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listUser = new List<User>();

				foreach (DataRow row in table.Rows)
				{
					User user = new User();
					user.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					user.UserFullName = row["UserFullName"].ToString();
					user.ProvinceIDDefaultTitle = row["ProvinceIDDefaultTitle"].ToString();
					user.Password = row["Password"].ToString();
					user.PersonalCode = row["PersonalCode"].ToString();
					user.StartDate = row["StartDate"].ToString();
					user.EndDate = row["EndDate"].ToString();
					user.Signature = (row["Signature"] != DBNull.Value) ? Convert.ToInt32(row["Signature"]) : 0 ;
					user.ProvinceIDDefault = (row["ProvinceIDDefault"] != DBNull.Value) ? Convert.ToInt32(row["ProvinceIDDefault"]) : 0 ;
				user.SignaturePrint = (row["SignaturePrint"] != DBNull.Value) ? Convert.ToBoolean((row["SignaturePrint"].ToString() == "1" || row["SignaturePrint"].ToString().ToLower() == "true" ) ? true : false) : false ;
				user.IsActive = (row["IsActive"] != DBNull.Value) ? Convert.ToBoolean((row["IsActive"].ToString() == "1" || row["IsActive"].ToString().ToLower() == "true" ) ? true : false) : false ;

					Person person = personDBAccess.GetDetails(user.NationalCode);
					user.PrintNationalCode = person.PrintNationalCode;
					user.FullName = person.FullName;
					user.GenderIDTitle = person.GenderIDTitle;
					user.Religion_DinIDTitle = person.Religion_DinIDTitle;
					user.Religion_MazhabIDTitle = person.Religion_MazhabIDTitle;
					user.IssuanceProvinceIDTitle = person.IssuanceProvinceIDTitle;
					user.IssuanceCityIDTitle = person.IssuanceCityIDTitle;
					user.IssuanceDepartment = person.IssuanceDepartment;
					user.CertificateNumber = person.CertificateNumber;
					user.CertificateSerial = person.CertificateSerial;
					user.ZipCode = person.ZipCode;
					user.HomeAddress = person.HomeAddress;
					user.PhoneNumber = person.PhoneNumber;
					user.Job = person.Job;
					user.JobAddress = person.JobAddress;
					user.JobPhoneNumber = person.JobPhoneNumber;
					user.Comment = person.Comment;
					user.BirthCity = person.BirthCity;
					user.JobZipCode = person.JobZipCode;
					user.CertificateSerialLetter = person.CertificateSerialLetter;
					user.CertificateSerialNumber = person.CertificateSerialNumber;
					user.FatherName = person.FatherName;
					user.Name = person.Name;
					user.Family = person.Family;
					user.BirthDate = person.BirthDate;
					user.IssuanceDate = person.IssuanceDate;
					user.GenderID = person.GenderID;
					user.IssuanceProvinceID = person.IssuanceProvinceID;
					user.IssuanceCityID = person.IssuanceCityID;
					user.Religion_DinID = person.Religion_DinID;
					user.Religion_MazhabID = person.Religion_MazhabID;
					listUser.Add(user);
				}
			}
		}

		return listUser;
	}

	public bool Exists(Int64 nationalCode)
	{
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", nationalCode)
		};
		return (SqlDBHelper.ExecuteScalar("User_Exists", CommandType.StoredProcedure, parametersUser)>0);
	}

	public bool Exists(User user)
	{
		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", user.NationalCode)
		};
		return (SqlDBHelper.ExecuteScalar("User_Exists", CommandType.StoredProcedure, parametersUser)>0);
	}

	public List<User> SearchLike(User user)
	{
		List<User> listUser = new List<User>();


		SqlParameter[] parametersUser = new SqlParameter[]
		{
			new SqlParameter("@NationalCode", user.NationalCode),
			new SqlParameter("@UserFullName", user.UserFullName),
			new SqlParameter("@ProvinceIDDefaultTitle", user.ProvinceIDDefaultTitle),
			new SqlParameter("@Password", user.Password),
			new SqlParameter("@PersonalCode", user.PersonalCode),
			new SqlParameter("@StartDate", user.StartDate),
			new SqlParameter("@EndDate", user.EndDate),
			new SqlParameter("@Signature", user.Signature),
			new SqlParameter("@ProvinceIDDefault", user.ProvinceIDDefault),
			new SqlParameter("@SignaturePrint", user.SignaturePrint),
			new SqlParameter("@IsActive", user.IsActive),

			new SqlParameter("@PrintNationalCode", user.PrintNationalCode),
			new SqlParameter("@FullName", user.FullName),
			new SqlParameter("@GenderIDTitle", user.GenderIDTitle),
			new SqlParameter("@Religion_DinIDTitle", user.Religion_DinIDTitle),
			new SqlParameter("@Religion_MazhabIDTitle", user.Religion_MazhabIDTitle),
			new SqlParameter("@IssuanceProvinceIDTitle", user.IssuanceProvinceIDTitle),
			new SqlParameter("@IssuanceCityIDTitle", user.IssuanceCityIDTitle),
			new SqlParameter("@IssuanceDepartment", user.IssuanceDepartment),
			new SqlParameter("@CertificateNumber", user.CertificateNumber),
			new SqlParameter("@CertificateSerial", user.CertificateSerial),
			new SqlParameter("@ZipCode", user.ZipCode),
			new SqlParameter("@HomeAddress", user.HomeAddress),
			new SqlParameter("@PhoneNumber", user.PhoneNumber),
			new SqlParameter("@Job", user.Job),
			new SqlParameter("@JobAddress", user.JobAddress),
			new SqlParameter("@JobPhoneNumber", user.JobPhoneNumber),
			new SqlParameter("@Comment", user.Comment),
			new SqlParameter("@BirthCity", user.BirthCity),
			new SqlParameter("@JobZipCode", user.JobZipCode),
			new SqlParameter("@CertificateSerialLetter", user.CertificateSerialLetter),
			new SqlParameter("@CertificateSerialNumber", user.CertificateSerialNumber),
			new SqlParameter("@FatherName", user.FatherName),
			new SqlParameter("@Name", user.Name),
			new SqlParameter("@Family", user.Family),
			new SqlParameter("@BirthDate", user.BirthDate),
			new SqlParameter("@IssuanceDate", user.IssuanceDate),
			new SqlParameter("@GenderID", user.GenderID),
			new SqlParameter("@IssuanceProvinceID", user.IssuanceProvinceID),
			new SqlParameter("@IssuanceCityID", user.IssuanceCityID),
			new SqlParameter("@Religion_DinID", user.Religion_DinID),
			new SqlParameter("@Religion_MazhabID", user.Religion_MazhabID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("User_SearchLike", CommandType.StoredProcedure, parametersUser))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					User tmpUser = new User();
					tmpUser.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					tmpUser.UserFullName = row["UserFullName"].ToString();
					tmpUser.ProvinceIDDefaultTitle = row["ProvinceIDDefaultTitle"].ToString();
					tmpUser.Password = row["Password"].ToString();
					tmpUser.PersonalCode = row["PersonalCode"].ToString();
					tmpUser.StartDate = row["StartDate"].ToString();
					tmpUser.EndDate = row["EndDate"].ToString();
					tmpUser.Signature = (row["Signature"] != DBNull.Value) ? Convert.ToInt32(row["Signature"]) : 0 ;
					tmpUser.ProvinceIDDefault = (row["ProvinceIDDefault"] != DBNull.Value) ? Convert.ToInt32(row["ProvinceIDDefault"]) : 0 ;
					tmpUser.SignaturePrint = (row["SignaturePrint"] != DBNull.Value) ? Convert.ToBoolean((row["SignaturePrint"].ToString() == "1" || row["SignaturePrint"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpUser.IsActive = (row["IsActive"] != DBNull.Value) ? Convert.ToBoolean((row["IsActive"].ToString() == "1" || row["IsActive"].ToString().ToLower() == "true" ) ? true : false) : false ;

					Person person = personDBAccess.GetDetails(tmpUser.NationalCode);
					tmpUser.NationalCode = person.NationalCode;
					tmpUser.PrintNationalCode = person.PrintNationalCode;
					tmpUser.FullName = person.FullName;
					tmpUser.GenderIDTitle = person.GenderIDTitle;
					tmpUser.Religion_DinIDTitle = person.Religion_DinIDTitle;
					tmpUser.Religion_MazhabIDTitle = person.Religion_MazhabIDTitle;
					tmpUser.IssuanceProvinceIDTitle = person.IssuanceProvinceIDTitle;
					tmpUser.IssuanceCityIDTitle = person.IssuanceCityIDTitle;
					tmpUser.IssuanceDepartment = person.IssuanceDepartment;
					tmpUser.CertificateNumber = person.CertificateNumber;
					tmpUser.CertificateSerial = person.CertificateSerial;
					tmpUser.ZipCode = person.ZipCode;
					tmpUser.HomeAddress = person.HomeAddress;
					tmpUser.PhoneNumber = person.PhoneNumber;
					tmpUser.Job = person.Job;
					tmpUser.JobAddress = person.JobAddress;
					tmpUser.JobPhoneNumber = person.JobPhoneNumber;
					tmpUser.Comment = person.Comment;
					tmpUser.BirthCity = person.BirthCity;
					tmpUser.JobZipCode = person.JobZipCode;
					tmpUser.CertificateSerialLetter = person.CertificateSerialLetter;
					tmpUser.CertificateSerialNumber = person.CertificateSerialNumber;
					tmpUser.FatherName = person.FatherName;
					tmpUser.Name = person.Name;
					tmpUser.Family = person.Family;
					tmpUser.BirthDate = person.BirthDate;
					tmpUser.IssuanceDate = person.IssuanceDate;
					tmpUser.GenderID = person.GenderID;
					tmpUser.IssuanceProvinceID = person.IssuanceProvinceID;
					tmpUser.IssuanceCityID = person.IssuanceCityID;
					tmpUser.Religion_DinID = person.Religion_DinID;
					tmpUser.Religion_MazhabID = person.Religion_MazhabID;

					listUser.Add(tmpUser);
				}
			}
		}

		return listUser;
	}

}
}
