using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormInquiryBankDepositDBAccess
{


	public Int64 Insert(FormInquiryBankDeposit formInquiryBankDeposit)
	{
		SqlParameter[] parametersFormInquiryBankDeposit = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryBankDepositRegisterInformationDate", (formInquiryBankDeposit.FormInquiryBankDepositRegisterInformationDate != null) ? formInquiryBankDeposit.FormInquiryBankDepositRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositDossierClasses", (formInquiryBankDeposit.FormInquiryBankDepositDossierClasses != null) ? formInquiryBankDeposit.FormInquiryBankDepositDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositDeadDeathDate", (formInquiryBankDeposit.FormInquiryBankDepositDeadDeathDate != null) ? formInquiryBankDeposit.FormInquiryBankDepositDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositRegisterInformationID", (formInquiryBankDeposit.FormInquiryBankDepositRegisterInformationID != null) ? formInquiryBankDeposit.FormInquiryBankDepositRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositDeclarationID", (formInquiryBankDeposit.FormInquiryBankDepositDeclarationID > 0) ? formInquiryBankDeposit.FormInquiryBankDepositDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositRegisterarUserNationalCode", (formInquiryBankDeposit.FormInquiryBankDepositRegisterarUserNationalCode > 0) ? formInquiryBankDeposit.FormInquiryBankDepositRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositFormInquiryResponseID", (formInquiryBankDeposit.FormInquiryBankDepositFormInquiryResponseID > 0) ? formInquiryBankDeposit.FormInquiryBankDepositFormInquiryResponseID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositBankTitle", (formInquiryBankDeposit.FormInquiryBankDepositBankTitle != null) ? formInquiryBankDeposit.FormInquiryBankDepositBankTitle : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositRuleComment", (formInquiryBankDeposit.FormInquiryBankDepositRuleComment != null) ? formInquiryBankDeposit.FormInquiryBankDepositRuleComment : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositUser1FullName", (formInquiryBankDeposit.FormInquiryBankDepositUser1FullName != null) ? formInquiryBankDeposit.FormInquiryBankDepositUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositUser2FullName", (formInquiryBankDeposit.FormInquiryBankDepositUser2FullName != null) ? formInquiryBankDeposit.FormInquiryBankDepositUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositUser1TaxUnitCode", (formInquiryBankDeposit.FormInquiryBankDepositUser1TaxUnitCode != null) ? formInquiryBankDeposit.FormInquiryBankDepositUser1TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositUser2TaxGroupCode", (formInquiryBankDeposit.FormInquiryBankDepositUser2TaxGroupCode != null) ? formInquiryBankDeposit.FormInquiryBankDepositUser2TaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositComment", (formInquiryBankDeposit.FormInquiryBankDepositComment != null) ? formInquiryBankDeposit.FormInquiryBankDepositComment : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositAccountNumber", (formInquiryBankDeposit.FormInquiryBankDepositAccountNumber != null) ? formInquiryBankDeposit.FormInquiryBankDepositAccountNumber : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositDeadFullName", (formInquiryBankDeposit.FormInquiryBankDepositDeadFullName != null) ? formInquiryBankDeposit.FormInquiryBankDepositDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositTaxUnitCode", (formInquiryBankDeposit.FormInquiryBankDepositTaxUnitCode != null) ? formInquiryBankDeposit.FormInquiryBankDepositTaxUnitCode : (object)DBNull.Value)
		};
		formInquiryBankDeposit.FormInquiryBankDepositID = SqlDBHelper.ExecuteScalar("FormInquiryBankDeposit_Insert", CommandType.StoredProcedure, parametersFormInquiryBankDeposit);
		return formInquiryBankDeposit.FormInquiryBankDepositID;
	}

	public bool Update(FormInquiryBankDeposit formInquiryBankDeposit)
	{
		SqlParameter[] parametersFormInquiryBankDeposit = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryBankDepositID", formInquiryBankDeposit.FormInquiryBankDepositID),
			new SqlParameter("@FormInquiryBankDepositRegisterInformationDate", (formInquiryBankDeposit.FormInquiryBankDepositRegisterInformationDate != null) ? formInquiryBankDeposit.FormInquiryBankDepositRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositDossierClasses", (formInquiryBankDeposit.FormInquiryBankDepositDossierClasses != null) ? formInquiryBankDeposit.FormInquiryBankDepositDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositDeadDeathDate", (formInquiryBankDeposit.FormInquiryBankDepositDeadDeathDate != null) ? formInquiryBankDeposit.FormInquiryBankDepositDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositRegisterInformationID", (formInquiryBankDeposit.FormInquiryBankDepositRegisterInformationID != null) ? formInquiryBankDeposit.FormInquiryBankDepositRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositDeclarationID", formInquiryBankDeposit.FormInquiryBankDepositDeclarationID),
			new SqlParameter("@FormInquiryBankDepositRegisterarUserNationalCode", (formInquiryBankDeposit.FormInquiryBankDepositRegisterarUserNationalCode != null && formInquiryBankDeposit.FormInquiryBankDepositRegisterarUserNationalCode >0 ) ? formInquiryBankDeposit.FormInquiryBankDepositRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositFormInquiryResponseID", (formInquiryBankDeposit.FormInquiryBankDepositFormInquiryResponseID != null && formInquiryBankDeposit.FormInquiryBankDepositFormInquiryResponseID >0 ) ? formInquiryBankDeposit.FormInquiryBankDepositFormInquiryResponseID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositBankTitle", (formInquiryBankDeposit.FormInquiryBankDepositBankTitle != null) ? formInquiryBankDeposit.FormInquiryBankDepositBankTitle : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositRuleComment", (formInquiryBankDeposit.FormInquiryBankDepositRuleComment != null) ? formInquiryBankDeposit.FormInquiryBankDepositRuleComment : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositUser1FullName", (formInquiryBankDeposit.FormInquiryBankDepositUser1FullName != null) ? formInquiryBankDeposit.FormInquiryBankDepositUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositUser2FullName", (formInquiryBankDeposit.FormInquiryBankDepositUser2FullName != null) ? formInquiryBankDeposit.FormInquiryBankDepositUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositUser1TaxUnitCode", (formInquiryBankDeposit.FormInquiryBankDepositUser1TaxUnitCode != null) ? formInquiryBankDeposit.FormInquiryBankDepositUser1TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositUser2TaxGroupCode", (formInquiryBankDeposit.FormInquiryBankDepositUser2TaxGroupCode != null) ? formInquiryBankDeposit.FormInquiryBankDepositUser2TaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositComment", (formInquiryBankDeposit.FormInquiryBankDepositComment != null) ? formInquiryBankDeposit.FormInquiryBankDepositComment : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositAccountNumber", (formInquiryBankDeposit.FormInquiryBankDepositAccountNumber != null) ? formInquiryBankDeposit.FormInquiryBankDepositAccountNumber : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositDeadFullName", (formInquiryBankDeposit.FormInquiryBankDepositDeadFullName != null) ? formInquiryBankDeposit.FormInquiryBankDepositDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryBankDepositTaxUnitCode", (formInquiryBankDeposit.FormInquiryBankDepositTaxUnitCode != null) ? formInquiryBankDeposit.FormInquiryBankDepositTaxUnitCode : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormInquiryBankDeposit_Update", CommandType.StoredProcedure, parametersFormInquiryBankDeposit);
	}

	public bool Delete(Int64 formInquiryBankDepositID)
	{
		SqlParameter[] parametersFormInquiryBankDeposit = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryBankDepositID", formInquiryBankDepositID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormInquiryBankDeposit_Delete", CommandType.StoredProcedure, parametersFormInquiryBankDeposit);
	}

	public FormInquiryBankDeposit GetDetails(Int64 formInquiryBankDepositID)
	{
		FormInquiryBankDeposit formInquiryBankDeposit = new FormInquiryBankDeposit();

		SqlParameter[] parametersFormInquiryBankDeposit = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryBankDepositID", formInquiryBankDepositID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryBankDeposit_GetDetails", CommandType.StoredProcedure, parametersFormInquiryBankDeposit))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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
			}
		}

		return formInquiryBankDeposit;
	}

	public List<FormInquiryBankDeposit> GetListAll()
	{
		List<FormInquiryBankDeposit> listFormInquiryBankDeposit = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormInquiryBankDeposit_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormInquiryBankDeposit = new List<FormInquiryBankDeposit>();

				foreach (DataRow row in table.Rows)
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
					listFormInquiryBankDeposit.Add(formInquiryBankDeposit);
				}
			}
		}

		return listFormInquiryBankDeposit;
	}

	public bool Exists(Int64 formInquiryBankDepositID)
	{
		SqlParameter[] parametersFormInquiryBankDeposit = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryBankDepositID", formInquiryBankDepositID)
		};
		return (SqlDBHelper.ExecuteScalar("FormInquiryBankDeposit_Exists", CommandType.StoredProcedure, parametersFormInquiryBankDeposit)>0);
	}

	public bool Exists(FormInquiryBankDeposit formInquiryBankDeposit)
	{
		SqlParameter[] parametersFormInquiryBankDeposit = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryBankDepositID", formInquiryBankDeposit.FormInquiryBankDepositID)
		};
		return (SqlDBHelper.ExecuteScalar("FormInquiryBankDeposit_Exists", CommandType.StoredProcedure, parametersFormInquiryBankDeposit)>0);
	}

	public List<FormInquiryBankDeposit> SearchLike(FormInquiryBankDeposit formInquiryBankDeposit)
	{
		List<FormInquiryBankDeposit> listFormInquiryBankDeposit = new List<FormInquiryBankDeposit>();


		SqlParameter[] parametersFormInquiryBankDeposit = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryBankDepositID", formInquiryBankDeposit.FormInquiryBankDepositID),
			new SqlParameter("@FormInquiryBankDepositPrintRegisterInformationID", formInquiryBankDeposit.FormInquiryBankDepositPrintRegisterInformationID),
			new SqlParameter("@FormInquiryBankDepositPrintRegisterDate", formInquiryBankDeposit.FormInquiryBankDepositPrintRegisterDate),
			new SqlParameter("@FormInquiryBankDepositRegisterInformationDate", formInquiryBankDeposit.FormInquiryBankDepositRegisterInformationDate),
			new SqlParameter("@FormInquiryBankDepositDossierClasses", formInquiryBankDeposit.FormInquiryBankDepositDossierClasses),
			new SqlParameter("@FormInquiryBankDepositDeadDeathDate", formInquiryBankDeposit.FormInquiryBankDepositDeadDeathDate),
			new SqlParameter("@FormInquiryBankDepositRegisterInformationID", formInquiryBankDeposit.FormInquiryBankDepositRegisterInformationID),
			new SqlParameter("@FormInquiryBankDepositDeclarationID", formInquiryBankDeposit.FormInquiryBankDepositDeclarationID),
			new SqlParameter("@FormInquiryBankDepositRegisterarUserNationalCode", formInquiryBankDeposit.FormInquiryBankDepositRegisterarUserNationalCode),
			new SqlParameter("@FormInquiryBankDepositFormInquiryResponseID", formInquiryBankDeposit.FormInquiryBankDepositFormInquiryResponseID),
			new SqlParameter("@FormInquiryBankDepositBankTitle", formInquiryBankDeposit.FormInquiryBankDepositBankTitle),
			new SqlParameter("@FormInquiryBankDepositRuleComment", formInquiryBankDeposit.FormInquiryBankDepositRuleComment),
			new SqlParameter("@FormInquiryBankDepositUser1FullName", formInquiryBankDeposit.FormInquiryBankDepositUser1FullName),
			new SqlParameter("@FormInquiryBankDepositUser2FullName", formInquiryBankDeposit.FormInquiryBankDepositUser2FullName),
			new SqlParameter("@FormInquiryBankDepositUser1TaxUnitCode", formInquiryBankDeposit.FormInquiryBankDepositUser1TaxUnitCode),
			new SqlParameter("@FormInquiryBankDepositUser2TaxGroupCode", formInquiryBankDeposit.FormInquiryBankDepositUser2TaxGroupCode),
			new SqlParameter("@FormInquiryBankDepositComment", formInquiryBankDeposit.FormInquiryBankDepositComment),
			new SqlParameter("@FormInquiryBankDepositAccountNumber", formInquiryBankDeposit.FormInquiryBankDepositAccountNumber),
			new SqlParameter("@FormInquiryBankDepositDeadFullName", formInquiryBankDeposit.FormInquiryBankDepositDeadFullName),
			new SqlParameter("@FormInquiryBankDepositTaxUnitCode", formInquiryBankDeposit.FormInquiryBankDepositTaxUnitCode),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryBankDeposit_SearchLike", CommandType.StoredProcedure, parametersFormInquiryBankDeposit))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormInquiryBankDeposit tmpFormInquiryBankDeposit = new FormInquiryBankDeposit();
					tmpFormInquiryBankDeposit.FormInquiryBankDepositID = (row["FormInquiryBankDepositID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryBankDepositID"]) : 0 ;
					tmpFormInquiryBankDeposit.FormInquiryBankDepositPrintRegisterInformationID = row["FormInquiryBankDepositPrintRegisterInformationID"].ToString();
					tmpFormInquiryBankDeposit.FormInquiryBankDepositPrintRegisterDate = row["FormInquiryBankDepositPrintRegisterDate"].ToString();
					tmpFormInquiryBankDeposit.FormInquiryBankDepositRegisterInformationDate = row["FormInquiryBankDepositRegisterInformationDate"].ToString();
					tmpFormInquiryBankDeposit.FormInquiryBankDepositDossierClasses = row["FormInquiryBankDepositDossierClasses"].ToString();
					tmpFormInquiryBankDeposit.FormInquiryBankDepositDeadDeathDate = row["FormInquiryBankDepositDeadDeathDate"].ToString();
					tmpFormInquiryBankDeposit.FormInquiryBankDepositRegisterInformationID = (row["FormInquiryBankDepositRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryBankDepositRegisterInformationID"]) : 0 ;
					tmpFormInquiryBankDeposit.FormInquiryBankDepositDeclarationID = (row["FormInquiryBankDepositDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryBankDepositDeclarationID"]) : 0 ;
					tmpFormInquiryBankDeposit.FormInquiryBankDepositRegisterarUserNationalCode = (row["FormInquiryBankDepositRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryBankDepositRegisterarUserNationalCode"]) : 0 ;
					tmpFormInquiryBankDeposit.FormInquiryBankDepositFormInquiryResponseID = (row["FormInquiryBankDepositFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryBankDepositFormInquiryResponseID"]) : 0 ;
					tmpFormInquiryBankDeposit.FormInquiryBankDepositBankTitle = row["FormInquiryBankDepositBankTitle"].ToString();
					tmpFormInquiryBankDeposit.FormInquiryBankDepositRuleComment = row["FormInquiryBankDepositRuleComment"].ToString();
					tmpFormInquiryBankDeposit.FormInquiryBankDepositUser1FullName = row["FormInquiryBankDepositUser1FullName"].ToString();
					tmpFormInquiryBankDeposit.FormInquiryBankDepositUser2FullName = row["FormInquiryBankDepositUser2FullName"].ToString();
					tmpFormInquiryBankDeposit.FormInquiryBankDepositUser1TaxUnitCode = row["FormInquiryBankDepositUser1TaxUnitCode"].ToString();
					tmpFormInquiryBankDeposit.FormInquiryBankDepositUser2TaxGroupCode = row["FormInquiryBankDepositUser2TaxGroupCode"].ToString();
					tmpFormInquiryBankDeposit.FormInquiryBankDepositComment = row["FormInquiryBankDepositComment"].ToString();
					tmpFormInquiryBankDeposit.FormInquiryBankDepositAccountNumber = row["FormInquiryBankDepositAccountNumber"].ToString();
					tmpFormInquiryBankDeposit.FormInquiryBankDepositDeadFullName = row["FormInquiryBankDepositDeadFullName"].ToString();
					tmpFormInquiryBankDeposit.FormInquiryBankDepositTaxUnitCode = row["FormInquiryBankDepositTaxUnitCode"].ToString();

					listFormInquiryBankDeposit.Add(tmpFormInquiryBankDeposit);
				}
			}
		}

		return listFormInquiryBankDeposit;
	}

}
}
