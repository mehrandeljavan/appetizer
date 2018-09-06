using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormInquiryGoodWillEvaluationDBAccess
{


	public Int64 Insert(FormInquiryGoodWillEvaluation formInquiryGoodWillEvaluation)
	{
		SqlParameter[] parametersFormInquiryGoodWillEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillEvaluationAddress", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationAddress != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationAddress : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationUser1FullName", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser1FullName != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationUser2FullName", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser2FullName != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationUser1TaxUnitCode", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser1TaxUnitCode != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser1TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationUser2TaxGroupCode", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser2TaxGroupCode != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser2TaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationPhoneNumber", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPhoneNumber != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationlRegisterInformationDate", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationlRegisterInformationDate != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationlRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationDossierClasses", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDossierClasses != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationDeadDeathDate", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDeadDeathDate != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationRegisterInformationID", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationRegisterInformationID != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationlDeclarationID", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationlDeclarationID > 0) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationlDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationRegisterarUserNationalCode", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationRegisterarUserNationalCode > 0) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationFormInquiryResponseID", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationFormInquiryResponseID > 0) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationFormInquiryResponseID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationDeadFullName", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDeadFullName != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationInquiryTo", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationInquiryTo != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationInquiryTo : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationSixth", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationSixth != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationSixth : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationFromGoodwill", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationFromGoodwill != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationFromGoodwill : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationPlaque", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPlaque != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPlaque : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationSection", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationSection != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationSection : (object)DBNull.Value)
		};
		formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationID = SqlDBHelper.ExecuteScalar("FormInquiryGoodWillEvaluation_Insert", CommandType.StoredProcedure, parametersFormInquiryGoodWillEvaluation);
		return formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationID;
	}

	public bool Update(FormInquiryGoodWillEvaluation formInquiryGoodWillEvaluation)
	{
		SqlParameter[] parametersFormInquiryGoodWillEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillEvaluationID", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationID),
			new SqlParameter("@FormInquiryGoodWillEvaluationAddress", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationAddress != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationAddress : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationUser1FullName", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser1FullName != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationUser2FullName", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser2FullName != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationUser1TaxUnitCode", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser1TaxUnitCode != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser1TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationUser2TaxGroupCode", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser2TaxGroupCode != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser2TaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationPhoneNumber", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPhoneNumber != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationlRegisterInformationDate", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationlRegisterInformationDate != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationlRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationDossierClasses", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDossierClasses != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationDeadDeathDate", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDeadDeathDate != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationRegisterInformationID", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationRegisterInformationID != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationlDeclarationID", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationlDeclarationID),
			new SqlParameter("@FormInquiryGoodWillEvaluationRegisterarUserNationalCode", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationRegisterarUserNationalCode != null && formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationRegisterarUserNationalCode >0 ) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationFormInquiryResponseID", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationFormInquiryResponseID != null && formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationFormInquiryResponseID >0 ) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationFormInquiryResponseID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationDeadFullName", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDeadFullName != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationInquiryTo", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationInquiryTo != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationInquiryTo : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationSixth", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationSixth != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationSixth : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationFromGoodwill", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationFromGoodwill != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationFromGoodwill : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationPlaque", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPlaque != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPlaque : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillEvaluationSection", (formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationSection != null) ? formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationSection : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormInquiryGoodWillEvaluation_Update", CommandType.StoredProcedure, parametersFormInquiryGoodWillEvaluation);
	}

	public bool Delete(Int64 formInquiryGoodWillEvaluationID)
	{
		SqlParameter[] parametersFormInquiryGoodWillEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillEvaluationID", formInquiryGoodWillEvaluationID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormInquiryGoodWillEvaluation_Delete", CommandType.StoredProcedure, parametersFormInquiryGoodWillEvaluation);
	}

	public FormInquiryGoodWillEvaluation GetDetails(Int64 formInquiryGoodWillEvaluationID)
	{
		FormInquiryGoodWillEvaluation formInquiryGoodWillEvaluation = new FormInquiryGoodWillEvaluation();

		SqlParameter[] parametersFormInquiryGoodWillEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillEvaluationID", formInquiryGoodWillEvaluationID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryGoodWillEvaluation_GetDetails", CommandType.StoredProcedure, parametersFormInquiryGoodWillEvaluation))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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
			}
		}

		return formInquiryGoodWillEvaluation;
	}

	public List<FormInquiryGoodWillEvaluation> GetListAll()
	{
		List<FormInquiryGoodWillEvaluation> listFormInquiryGoodWillEvaluation = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormInquiryGoodWillEvaluation_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormInquiryGoodWillEvaluation = new List<FormInquiryGoodWillEvaluation>();

				foreach (DataRow row in table.Rows)
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
					listFormInquiryGoodWillEvaluation.Add(formInquiryGoodWillEvaluation);
				}
			}
		}

		return listFormInquiryGoodWillEvaluation;
	}

	public bool Exists(Int64 formInquiryGoodWillEvaluationID)
	{
		SqlParameter[] parametersFormInquiryGoodWillEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillEvaluationID", formInquiryGoodWillEvaluationID)
		};
		return (SqlDBHelper.ExecuteScalar("FormInquiryGoodWillEvaluation_Exists", CommandType.StoredProcedure, parametersFormInquiryGoodWillEvaluation)>0);
	}

	public bool Exists(FormInquiryGoodWillEvaluation formInquiryGoodWillEvaluation)
	{
		SqlParameter[] parametersFormInquiryGoodWillEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillEvaluationID", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationID)
		};
		return (SqlDBHelper.ExecuteScalar("FormInquiryGoodWillEvaluation_Exists", CommandType.StoredProcedure, parametersFormInquiryGoodWillEvaluation)>0);
	}

	public List<FormInquiryGoodWillEvaluation> SearchLike(FormInquiryGoodWillEvaluation formInquiryGoodWillEvaluation)
	{
		List<FormInquiryGoodWillEvaluation> listFormInquiryGoodWillEvaluation = new List<FormInquiryGoodWillEvaluation>();


		SqlParameter[] parametersFormInquiryGoodWillEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillEvaluationID", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationID),
			new SqlParameter("@FormInquiryGoodWillEvaluationPrintRegisterInformationID", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPrintRegisterInformationID),
			new SqlParameter("@FormInquiryGoodWillEvaluationPrintRegisterDate", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPrintRegisterDate),
			new SqlParameter("@FormInquiryGoodWillEvaluationAddress", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationAddress),
			new SqlParameter("@FormInquiryGoodWillEvaluationUser1FullName", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser1FullName),
			new SqlParameter("@FormInquiryGoodWillEvaluationUser2FullName", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser2FullName),
			new SqlParameter("@FormInquiryGoodWillEvaluationUser1TaxUnitCode", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser1TaxUnitCode),
			new SqlParameter("@FormInquiryGoodWillEvaluationUser2TaxGroupCode", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser2TaxGroupCode),
			new SqlParameter("@FormInquiryGoodWillEvaluationPhoneNumber", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPhoneNumber),
			new SqlParameter("@FormInquiryGoodWillEvaluationlRegisterInformationDate", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationlRegisterInformationDate),
			new SqlParameter("@FormInquiryGoodWillEvaluationDossierClasses", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDossierClasses),
			new SqlParameter("@FormInquiryGoodWillEvaluationDeadDeathDate", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDeadDeathDate),
			new SqlParameter("@FormInquiryGoodWillEvaluationRegisterInformationID", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationRegisterInformationID),
			new SqlParameter("@FormInquiryGoodWillEvaluationlDeclarationID", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationlDeclarationID),
			new SqlParameter("@FormInquiryGoodWillEvaluationRegisterarUserNationalCode", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationRegisterarUserNationalCode),
			new SqlParameter("@FormInquiryGoodWillEvaluationFormInquiryResponseID", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationFormInquiryResponseID),
			new SqlParameter("@FormInquiryGoodWillEvaluationDeadFullName", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDeadFullName),
			new SqlParameter("@FormInquiryGoodWillEvaluationInquiryTo", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationInquiryTo),
			new SqlParameter("@FormInquiryGoodWillEvaluationSixth", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationSixth),
			new SqlParameter("@FormInquiryGoodWillEvaluationFromGoodwill", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationFromGoodwill),
			new SqlParameter("@FormInquiryGoodWillEvaluationPlaque", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPlaque),
			new SqlParameter("@FormInquiryGoodWillEvaluationSection", formInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationSection),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryGoodWillEvaluation_SearchLike", CommandType.StoredProcedure, parametersFormInquiryGoodWillEvaluation))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormInquiryGoodWillEvaluation tmpFormInquiryGoodWillEvaluation = new FormInquiryGoodWillEvaluation();
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationID = (row["FormInquiryGoodWillEvaluationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillEvaluationID"]) : 0 ;
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPrintRegisterInformationID = row["FormInquiryGoodWillEvaluationPrintRegisterInformationID"].ToString();
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPrintRegisterDate = row["FormInquiryGoodWillEvaluationPrintRegisterDate"].ToString();
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationAddress = row["FormInquiryGoodWillEvaluationAddress"].ToString();
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser1FullName = row["FormInquiryGoodWillEvaluationUser1FullName"].ToString();
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser2FullName = row["FormInquiryGoodWillEvaluationUser2FullName"].ToString();
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser1TaxUnitCode = row["FormInquiryGoodWillEvaluationUser1TaxUnitCode"].ToString();
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationUser2TaxGroupCode = row["FormInquiryGoodWillEvaluationUser2TaxGroupCode"].ToString();
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPhoneNumber = row["FormInquiryGoodWillEvaluationPhoneNumber"].ToString();
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationlRegisterInformationDate = row["FormInquiryGoodWillEvaluationlRegisterInformationDate"].ToString();
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDossierClasses = row["FormInquiryGoodWillEvaluationDossierClasses"].ToString();
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDeadDeathDate = row["FormInquiryGoodWillEvaluationDeadDeathDate"].ToString();
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationRegisterInformationID = (row["FormInquiryGoodWillEvaluationRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillEvaluationRegisterInformationID"]) : 0 ;
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationlDeclarationID = (row["FormInquiryGoodWillEvaluationlDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillEvaluationlDeclarationID"]) : 0 ;
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationRegisterarUserNationalCode = (row["FormInquiryGoodWillEvaluationRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillEvaluationRegisterarUserNationalCode"]) : 0 ;
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationFormInquiryResponseID = (row["FormInquiryGoodWillEvaluationFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillEvaluationFormInquiryResponseID"]) : 0 ;
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationDeadFullName = row["FormInquiryGoodWillEvaluationDeadFullName"].ToString();
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationInquiryTo = row["FormInquiryGoodWillEvaluationInquiryTo"].ToString();
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationSixth = row["FormInquiryGoodWillEvaluationSixth"].ToString();
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationFromGoodwill = row["FormInquiryGoodWillEvaluationFromGoodwill"].ToString();
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationPlaque = row["FormInquiryGoodWillEvaluationPlaque"].ToString();
					tmpFormInquiryGoodWillEvaluation.FormInquiryGoodWillEvaluationSection = row["FormInquiryGoodWillEvaluationSection"].ToString();

					listFormInquiryGoodWillEvaluation.Add(tmpFormInquiryGoodWillEvaluation);
				}
			}
		}

		return listFormInquiryGoodWillEvaluation;
	}

}
}
