using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class InquiryResponseDBAccess
{

	FormInquiryBankDepositDBAccess formInquiryBankDepositDBAccess = new FormInquiryBankDepositDBAccess();
	FormInquiryCompanyDBAccess formInquiryCompanyDBAccess = new FormInquiryCompanyDBAccess();
	FormInquiryEstateDBAccess formInquiryEstateDBAccess = new FormInquiryEstateDBAccess();
	FormInquiryGoodWillEvaluationDBAccess formInquiryGoodWillEvaluationDBAccess = new FormInquiryGoodWillEvaluationDBAccess();
	FormInquiryGoodWillScoreDBAccess formInquiryGoodWillScoreDBAccess = new FormInquiryGoodWillScoreDBAccess();
	FormInquiryOtherDBAccess formInquiryOtherDBAccess = new FormInquiryOtherDBAccess();
	FormInquiryTransferRightEvaluationDBAccess formInquiryTransferRightEvaluationDBAccess = new FormInquiryTransferRightEvaluationDBAccess();
	FormInquiryTransferRightScoreDBAccess formInquiryTransferRightScoreDBAccess = new FormInquiryTransferRightScoreDBAccess();

	public List<FormInquiryBankDeposit> GetListFormInquiryBankDeposit(Int64 inquiryResponseID)
	{
		List<FormInquiryBankDeposit> listFormInquiryBankDeposit = new List<FormInquiryBankDeposit>() { };
		SqlParameter[] parametersInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryBankDepositFormInquiryResponseID", inquiryResponseID)
		};

		//Lets get the list of FormInquiryBankDeposit records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryBankDeposit_GetList_UseInInquiryResponse", CommandType.StoredProcedure, parametersInquiryResponse))
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
	public List<FormInquiryCompany> GetListFormInquiryCompany(Int64 inquiryResponseID)
	{
		List<FormInquiryCompany> listFormInquiryCompany = new List<FormInquiryCompany>() { };
		SqlParameter[] parametersInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryCompanyFormInquiryResponseID", inquiryResponseID)
		};

		//Lets get the list of FormInquiryCompany records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryCompany_GetList_UseInInquiryResponse", CommandType.StoredProcedure, parametersInquiryResponse))
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
	public List<FormInquiryEstate> GetListFormInquiryEstate(Int64 inquiryResponseID)
	{
		List<FormInquiryEstate> listFormInquiryEstate = new List<FormInquiryEstate>() { };
		SqlParameter[] parametersInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryEstateFormInquiryResponseID", inquiryResponseID)
		};

		//Lets get the list of FormInquiryEstate records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryEstate_GetList_UseInInquiryResponse", CommandType.StoredProcedure, parametersInquiryResponse))
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
	public List<FormInquiryGoodWillEvaluation> GetListFormInquiryGoodWillEvaluation(Int64 inquiryResponseID)
	{
		List<FormInquiryGoodWillEvaluation> listFormInquiryGoodWillEvaluation = new List<FormInquiryGoodWillEvaluation>() { };
		SqlParameter[] parametersInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillEvaluationFormInquiryResponseID", inquiryResponseID)
		};

		//Lets get the list of FormInquiryGoodWillEvaluation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryGoodWillEvaluation_GetList_UseInInquiryResponse", CommandType.StoredProcedure, parametersInquiryResponse))
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
	public List<FormInquiryGoodWillScore> GetListFormInquiryGoodWillScore(Int64 inquiryResponseID)
	{
		List<FormInquiryGoodWillScore> listFormInquiryGoodWillScore = new List<FormInquiryGoodWillScore>() { };
		SqlParameter[] parametersInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillScoreFormInquiryResponseID", inquiryResponseID)
		};

		//Lets get the list of FormInquiryGoodWillScore records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryGoodWillScore_GetList_UseInInquiryResponse", CommandType.StoredProcedure, parametersInquiryResponse))
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
	public List<FormInquiryOther> GetListFormInquiryOther(Int64 inquiryResponseID)
	{
		List<FormInquiryOther> listFormInquiryOther = new List<FormInquiryOther>() { };
		SqlParameter[] parametersInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryOtherFormInquiryResponseID", inquiryResponseID)
		};

		//Lets get the list of FormInquiryOther records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryOther_GetList_UseInInquiryResponse", CommandType.StoredProcedure, parametersInquiryResponse))
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
	public List<FormInquiryTransferRightEvaluation> GetListFormInquiryTransferRightEvaluation(Int64 inquiryResponseID)
	{
		List<FormInquiryTransferRightEvaluation> listFormInquiryTransferRightEvaluation = new List<FormInquiryTransferRightEvaluation>() { };
		SqlParameter[] parametersInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightEvaluationFormInquiryResponseID", inquiryResponseID)
		};

		//Lets get the list of FormInquiryTransferRightEvaluation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryTransferRightEvaluation_GetList_UseInInquiryResponse", CommandType.StoredProcedure, parametersInquiryResponse))
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
	public List<FormInquiryTransferRightScore> GetListFormInquiryTransferRightScore(Int64 inquiryResponseID)
	{
		List<FormInquiryTransferRightScore> listFormInquiryTransferRightScore = new List<FormInquiryTransferRightScore>() { };
		SqlParameter[] parametersInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightScoreFormInquiryResponseID", inquiryResponseID)
		};

		//Lets get the list of FormInquiryTransferRightScore records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryTransferRightScore_GetList_UseInInquiryResponse", CommandType.StoredProcedure, parametersInquiryResponse))
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
	public Int64 Insert(InquiryResponse inquiryResponse)
	{
		SqlParameter[] parametersInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@InquiryResponseID", inquiryResponse.InquiryResponseID),
			new SqlParameter("@Owner", (inquiryResponse.Owner != null) ? inquiryResponse.Owner : (object)DBNull.Value),
			new SqlParameter("@Number", (inquiryResponse.Number != null) ? inquiryResponse.Number : (object)DBNull.Value),
			new SqlParameter("@Comments", (inquiryResponse.Comments != null) ? inquiryResponse.Comments : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", (inquiryResponse.RegisterInformationID > 0) ? inquiryResponse.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (inquiryResponse.DeclarationID > 0) ? inquiryResponse.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@ResponseDate", (inquiryResponse.ResponseDate != null) ? inquiryResponse.ResponseDate : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("InquiryResponse_Insert", CommandType.StoredProcedure, parametersInquiryResponse);
	}

	public bool Update(InquiryResponse inquiryResponse)
	{
		SqlParameter[] parametersInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@InquiryResponseID", inquiryResponse.InquiryResponseID),
			new SqlParameter("@Owner", (inquiryResponse.Owner != null) ? inquiryResponse.Owner : (object)DBNull.Value),
			new SqlParameter("@Number", (inquiryResponse.Number != null) ? inquiryResponse.Number : (object)DBNull.Value),
			new SqlParameter("@Comments", (inquiryResponse.Comments != null) ? inquiryResponse.Comments : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", inquiryResponse.RegisterInformationID),
			new SqlParameter("@DeclarationID", inquiryResponse.DeclarationID),
			new SqlParameter("@ResponseDate", (inquiryResponse.ResponseDate != null) ? inquiryResponse.ResponseDate : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("InquiryResponse_Update", CommandType.StoredProcedure, parametersInquiryResponse);
	}

	public bool Delete(Int64 inquiryResponseID)
	{
		SqlParameter[] parametersInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@InquiryResponseID", inquiryResponseID)
		};
		return SqlDBHelper.ExecuteNonQuery("InquiryResponse_Delete", CommandType.StoredProcedure, parametersInquiryResponse);
	}

	public InquiryResponse GetDetails(Int64 inquiryResponseID)
	{
		InquiryResponse inquiryResponse = new InquiryResponse();

		SqlParameter[] parametersInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@InquiryResponseID", inquiryResponseID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("InquiryResponse_GetDetails", CommandType.StoredProcedure, parametersInquiryResponse))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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
			}
		}

		return inquiryResponse;
	}

	public List<InquiryResponse> GetListAll()
	{
		List<InquiryResponse> listInquiryResponse = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("InquiryResponse_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listInquiryResponse = new List<InquiryResponse>();

				foreach (DataRow row in table.Rows)
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
					listInquiryResponse.Add(inquiryResponse);
				}
			}
		}

		return listInquiryResponse;
	}

	public bool Exists(Int64 inquiryResponseID)
	{
		SqlParameter[] parametersInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@InquiryResponseID", inquiryResponseID)
		};
		return (SqlDBHelper.ExecuteScalar("InquiryResponse_Exists", CommandType.StoredProcedure, parametersInquiryResponse)>0);
	}

	public bool Exists(InquiryResponse inquiryResponse)
	{
		SqlParameter[] parametersInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@InquiryResponseID", inquiryResponse.InquiryResponseID)
		};
		return (SqlDBHelper.ExecuteScalar("InquiryResponse_Exists", CommandType.StoredProcedure, parametersInquiryResponse)>0);
	}

	public List<InquiryResponse> SearchLike(InquiryResponse inquiryResponse)
	{
		List<InquiryResponse> listInquiryResponse = new List<InquiryResponse>();


		SqlParameter[] parametersInquiryResponse = new SqlParameter[]
		{
			new SqlParameter("@InquiryResponseID", inquiryResponse.InquiryResponseID),
			new SqlParameter("@RegisterDate", inquiryResponse.RegisterDate),
			new SqlParameter("@OldRegisterDate", inquiryResponse.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", inquiryResponse.OldRegisterInformationID),
			new SqlParameter("@Owner", inquiryResponse.Owner),
			new SqlParameter("@Number", inquiryResponse.Number),
			new SqlParameter("@Comments", inquiryResponse.Comments),
			new SqlParameter("@RegisterInformationID", inquiryResponse.RegisterInformationID),
			new SqlParameter("@DeclarationID", inquiryResponse.DeclarationID),
			new SqlParameter("@ResponseDate", inquiryResponse.ResponseDate),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("InquiryResponse_SearchLike", CommandType.StoredProcedure, parametersInquiryResponse))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					InquiryResponse tmpInquiryResponse = new InquiryResponse();
					tmpInquiryResponse.InquiryResponseID = (row["InquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["InquiryResponseID"]) : 0 ;
					tmpInquiryResponse.RegisterDate = row["RegisterDate"].ToString();
					tmpInquiryResponse.OldRegisterDate = row["OldRegisterDate"].ToString();
					tmpInquiryResponse.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					tmpInquiryResponse.Owner = row["Owner"].ToString();
					tmpInquiryResponse.Number = row["Number"].ToString();
					tmpInquiryResponse.Comments = row["Comments"].ToString();
					tmpInquiryResponse.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					tmpInquiryResponse.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpInquiryResponse.ResponseDate = row["ResponseDate"].ToString();

					listInquiryResponse.Add(tmpInquiryResponse);
				}
			}
		}

		return listInquiryResponse;
	}

}
}
