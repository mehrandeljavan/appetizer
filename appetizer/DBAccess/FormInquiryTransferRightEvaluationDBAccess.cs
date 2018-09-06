using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormInquiryTransferRightEvaluationDBAccess
{


	public Int64 Insert(FormInquiryTransferRightEvaluation formInquiryTransferRightEvaluation)
	{
		SqlParameter[] parametersFormInquiryTransferRightEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightEvaluationAddress", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationAddress != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationAddress : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationUser1FullName", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser1FullName != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationUser2FullName", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser2FullName != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationUser1TaxUnitCode", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser1TaxUnitCode != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser1TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationUser2TaxGroupCode", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser2TaxGroupCode != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser2TaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationPhoneNumber", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPhoneNumber != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationlRegisterInformationDate", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationlRegisterInformationDate != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationlRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationDossierClasses", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDossierClasses != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationDeadDeathDate", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDeadDeathDate != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationRegisterInformationID", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationRegisterInformationID != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationlDeclarationID", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationlDeclarationID > 0) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationlDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationRegisterarUserNationalCode", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationRegisterarUserNationalCode > 0) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationFormInquiryResponseID", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationFormInquiryResponseID > 0) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationFormInquiryResponseID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationDeadFullName", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDeadFullName != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationInquiryTo", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationInquiryTo != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationInquiryTo : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationSixth", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationSixth != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationSixth : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationFromTransferRight", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationFromTransferRight != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationFromTransferRight : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationPlaque", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPlaque != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPlaque : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationSection", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationSection != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationSection : (object)DBNull.Value)
		};
		formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationID = SqlDBHelper.ExecuteScalar("FormInquiryTransferRightEvaluation_Insert", CommandType.StoredProcedure, parametersFormInquiryTransferRightEvaluation);
		return formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationID;
	}

	public bool Update(FormInquiryTransferRightEvaluation formInquiryTransferRightEvaluation)
	{
		SqlParameter[] parametersFormInquiryTransferRightEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightEvaluationID", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationID),
			new SqlParameter("@FormInquiryTransferRightEvaluationAddress", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationAddress != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationAddress : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationUser1FullName", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser1FullName != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationUser2FullName", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser2FullName != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationUser1TaxUnitCode", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser1TaxUnitCode != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser1TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationUser2TaxGroupCode", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser2TaxGroupCode != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser2TaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationPhoneNumber", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPhoneNumber != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationlRegisterInformationDate", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationlRegisterInformationDate != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationlRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationDossierClasses", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDossierClasses != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationDeadDeathDate", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDeadDeathDate != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationRegisterInformationID", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationRegisterInformationID != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationlDeclarationID", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationlDeclarationID),
			new SqlParameter("@FormInquiryTransferRightEvaluationRegisterarUserNationalCode", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationRegisterarUserNationalCode != null && formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationRegisterarUserNationalCode >0 ) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationFormInquiryResponseID", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationFormInquiryResponseID != null && formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationFormInquiryResponseID >0 ) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationFormInquiryResponseID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationDeadFullName", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDeadFullName != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationInquiryTo", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationInquiryTo != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationInquiryTo : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationSixth", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationSixth != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationSixth : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationFromTransferRight", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationFromTransferRight != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationFromTransferRight : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationPlaque", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPlaque != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPlaque : (object)DBNull.Value),
			new SqlParameter("@FormInquiryTransferRightEvaluationSection", (formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationSection != null) ? formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationSection : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormInquiryTransferRightEvaluation_Update", CommandType.StoredProcedure, parametersFormInquiryTransferRightEvaluation);
	}

	public bool Delete(Int64 formInquiryTransferRightEvaluationID)
	{
		SqlParameter[] parametersFormInquiryTransferRightEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightEvaluationID", formInquiryTransferRightEvaluationID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormInquiryTransferRightEvaluation_Delete", CommandType.StoredProcedure, parametersFormInquiryTransferRightEvaluation);
	}

	public FormInquiryTransferRightEvaluation GetDetails(Int64 formInquiryTransferRightEvaluationID)
	{
		FormInquiryTransferRightEvaluation formInquiryTransferRightEvaluation = new FormInquiryTransferRightEvaluation();

		SqlParameter[] parametersFormInquiryTransferRightEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightEvaluationID", formInquiryTransferRightEvaluationID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryTransferRightEvaluation_GetDetails", CommandType.StoredProcedure, parametersFormInquiryTransferRightEvaluation))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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
			}
		}

		return formInquiryTransferRightEvaluation;
	}

	public List<FormInquiryTransferRightEvaluation> GetListAll()
	{
		List<FormInquiryTransferRightEvaluation> listFormInquiryTransferRightEvaluation = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormInquiryTransferRightEvaluation_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormInquiryTransferRightEvaluation = new List<FormInquiryTransferRightEvaluation>();

				foreach (DataRow row in table.Rows)
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
					listFormInquiryTransferRightEvaluation.Add(formInquiryTransferRightEvaluation);
				}
			}
		}

		return listFormInquiryTransferRightEvaluation;
	}

	public bool Exists(Int64 formInquiryTransferRightEvaluationID)
	{
		SqlParameter[] parametersFormInquiryTransferRightEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightEvaluationID", formInquiryTransferRightEvaluationID)
		};
		return (SqlDBHelper.ExecuteScalar("FormInquiryTransferRightEvaluation_Exists", CommandType.StoredProcedure, parametersFormInquiryTransferRightEvaluation)>0);
	}

	public bool Exists(FormInquiryTransferRightEvaluation formInquiryTransferRightEvaluation)
	{
		SqlParameter[] parametersFormInquiryTransferRightEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightEvaluationID", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationID)
		};
		return (SqlDBHelper.ExecuteScalar("FormInquiryTransferRightEvaluation_Exists", CommandType.StoredProcedure, parametersFormInquiryTransferRightEvaluation)>0);
	}

	public List<FormInquiryTransferRightEvaluation> SearchLike(FormInquiryTransferRightEvaluation formInquiryTransferRightEvaluation)
	{
		List<FormInquiryTransferRightEvaluation> listFormInquiryTransferRightEvaluation = new List<FormInquiryTransferRightEvaluation>();


		SqlParameter[] parametersFormInquiryTransferRightEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryTransferRightEvaluationID", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationID),
			new SqlParameter("@FormInquiryTransferRightEvaluationPrintRegisterInformationID", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPrintRegisterInformationID),
			new SqlParameter("@FormInquiryTransferRightEvaluationPrintRegisterDate", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPrintRegisterDate),
			new SqlParameter("@FormInquiryTransferRightEvaluationAddress", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationAddress),
			new SqlParameter("@FormInquiryTransferRightEvaluationUser1FullName", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser1FullName),
			new SqlParameter("@FormInquiryTransferRightEvaluationUser2FullName", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser2FullName),
			new SqlParameter("@FormInquiryTransferRightEvaluationUser1TaxUnitCode", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser1TaxUnitCode),
			new SqlParameter("@FormInquiryTransferRightEvaluationUser2TaxGroupCode", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser2TaxGroupCode),
			new SqlParameter("@FormInquiryTransferRightEvaluationPhoneNumber", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPhoneNumber),
			new SqlParameter("@FormInquiryTransferRightEvaluationlRegisterInformationDate", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationlRegisterInformationDate),
			new SqlParameter("@FormInquiryTransferRightEvaluationDossierClasses", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDossierClasses),
			new SqlParameter("@FormInquiryTransferRightEvaluationDeadDeathDate", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDeadDeathDate),
			new SqlParameter("@FormInquiryTransferRightEvaluationRegisterInformationID", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationRegisterInformationID),
			new SqlParameter("@FormInquiryTransferRightEvaluationlDeclarationID", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationlDeclarationID),
			new SqlParameter("@FormInquiryTransferRightEvaluationRegisterarUserNationalCode", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationRegisterarUserNationalCode),
			new SqlParameter("@FormInquiryTransferRightEvaluationFormInquiryResponseID", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationFormInquiryResponseID),
			new SqlParameter("@FormInquiryTransferRightEvaluationDeadFullName", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDeadFullName),
			new SqlParameter("@FormInquiryTransferRightEvaluationInquiryTo", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationInquiryTo),
			new SqlParameter("@FormInquiryTransferRightEvaluationSixth", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationSixth),
			new SqlParameter("@FormInquiryTransferRightEvaluationFromTransferRight", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationFromTransferRight),
			new SqlParameter("@FormInquiryTransferRightEvaluationPlaque", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPlaque),
			new SqlParameter("@FormInquiryTransferRightEvaluationSection", formInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationSection),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryTransferRightEvaluation_SearchLike", CommandType.StoredProcedure, parametersFormInquiryTransferRightEvaluation))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormInquiryTransferRightEvaluation tmpFormInquiryTransferRightEvaluation = new FormInquiryTransferRightEvaluation();
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationID = (row["FormInquiryTransferRightEvaluationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightEvaluationID"]) : 0 ;
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPrintRegisterInformationID = row["FormInquiryTransferRightEvaluationPrintRegisterInformationID"].ToString();
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPrintRegisterDate = row["FormInquiryTransferRightEvaluationPrintRegisterDate"].ToString();
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationAddress = row["FormInquiryTransferRightEvaluationAddress"].ToString();
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser1FullName = row["FormInquiryTransferRightEvaluationUser1FullName"].ToString();
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser2FullName = row["FormInquiryTransferRightEvaluationUser2FullName"].ToString();
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser1TaxUnitCode = row["FormInquiryTransferRightEvaluationUser1TaxUnitCode"].ToString();
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationUser2TaxGroupCode = row["FormInquiryTransferRightEvaluationUser2TaxGroupCode"].ToString();
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPhoneNumber = row["FormInquiryTransferRightEvaluationPhoneNumber"].ToString();
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationlRegisterInformationDate = row["FormInquiryTransferRightEvaluationlRegisterInformationDate"].ToString();
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDossierClasses = row["FormInquiryTransferRightEvaluationDossierClasses"].ToString();
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDeadDeathDate = row["FormInquiryTransferRightEvaluationDeadDeathDate"].ToString();
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationRegisterInformationID = (row["FormInquiryTransferRightEvaluationRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightEvaluationRegisterInformationID"]) : 0 ;
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationlDeclarationID = (row["FormInquiryTransferRightEvaluationlDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightEvaluationlDeclarationID"]) : 0 ;
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationRegisterarUserNationalCode = (row["FormInquiryTransferRightEvaluationRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightEvaluationRegisterarUserNationalCode"]) : 0 ;
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationFormInquiryResponseID = (row["FormInquiryTransferRightEvaluationFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryTransferRightEvaluationFormInquiryResponseID"]) : 0 ;
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationDeadFullName = row["FormInquiryTransferRightEvaluationDeadFullName"].ToString();
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationInquiryTo = row["FormInquiryTransferRightEvaluationInquiryTo"].ToString();
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationSixth = row["FormInquiryTransferRightEvaluationSixth"].ToString();
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationFromTransferRight = row["FormInquiryTransferRightEvaluationFromTransferRight"].ToString();
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationPlaque = row["FormInquiryTransferRightEvaluationPlaque"].ToString();
					tmpFormInquiryTransferRightEvaluation.FormInquiryTransferRightEvaluationSection = row["FormInquiryTransferRightEvaluationSection"].ToString();

					listFormInquiryTransferRightEvaluation.Add(tmpFormInquiryTransferRightEvaluation);
				}
			}
		}

		return listFormInquiryTransferRightEvaluation;
	}

}
}
