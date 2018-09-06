using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormHeritageEvaluationDBAccess
{


	public Int64 Insert(FormHeritageEvaluation formHeritageEvaluation)
	{
		SqlParameter[] parametersFormHeritageEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageEvaluationRegisterInformationID", (formHeritageEvaluation.FormHeritageEvaluationRegisterInformationID > 0) ? formHeritageEvaluation.FormHeritageEvaluationRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDeclarationID", (formHeritageEvaluation.FormHeritageEvaluationDeclarationID > 0) ? formHeritageEvaluation.FormHeritageEvaluationDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationApplicantNationalCode", (formHeritageEvaluation.FormHeritageEvaluationApplicantNationalCode != null) ? formHeritageEvaluation.FormHeritageEvaluationApplicantNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationZipCode", (formHeritageEvaluation.FormHeritageEvaluationZipCode != null) ? formHeritageEvaluation.FormHeritageEvaluationZipCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDeadNationalCode", (formHeritageEvaluation.FormHeritageEvaluationDeadNationalCode != null) ? formHeritageEvaluation.FormHeritageEvaluationDeadNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationRegisterDate", (formHeritageEvaluation.FormHeritageEvaluationRegisterDate != null) ? formHeritageEvaluation.FormHeritageEvaluationRegisterDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationApplicantBirthDate", (formHeritageEvaluation.FormHeritageEvaluationApplicantBirthDate != null) ? formHeritageEvaluation.FormHeritageEvaluationApplicantBirthDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDeadDeathDate", (formHeritageEvaluation.FormHeritageEvaluationDeadDeathDate != null) ? formHeritageEvaluation.FormHeritageEvaluationDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDeadIssuanceDate", (formHeritageEvaluation.FormHeritageEvaluationDeadIssuanceDate != null) ? formHeritageEvaluation.FormHeritageEvaluationDeadIssuanceDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDiagnosisReportDate", (formHeritageEvaluation.FormHeritageEvaluationDiagnosisReportDate != null) ? formHeritageEvaluation.FormHeritageEvaluationDiagnosisReportDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationRequestDate", (formHeritageEvaluation.FormHeritageEvaluationRequestDate != null) ? formHeritageEvaluation.FormHeritageEvaluationRequestDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationTaxOfficeTitle", (formHeritageEvaluation.FormHeritageEvaluationTaxOfficeTitle != null) ? formHeritageEvaluation.FormHeritageEvaluationTaxOfficeTitle : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationTaxOfficeAddress", (formHeritageEvaluation.FormHeritageEvaluationTaxOfficeAddress != null) ? formHeritageEvaluation.FormHeritageEvaluationTaxOfficeAddress : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationTaxOfficePhoneNumber", (formHeritageEvaluation.FormHeritageEvaluationTaxOfficePhoneNumber != null) ? formHeritageEvaluation.FormHeritageEvaluationTaxOfficePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationTaxOfficeZipCode", (formHeritageEvaluation.FormHeritageEvaluationTaxOfficeZipCode != null) ? formHeritageEvaluation.FormHeritageEvaluationTaxOfficeZipCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDossierClasses", (formHeritageEvaluation.FormHeritageEvaluationDossierClasses != null) ? formHeritageEvaluation.FormHeritageEvaluationDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationApplicantFullName", (formHeritageEvaluation.FormHeritageEvaluationApplicantFullName != null) ? formHeritageEvaluation.FormHeritageEvaluationApplicantFullName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDescription", (formHeritageEvaluation.FormHeritageEvaluationDescription != null) ? formHeritageEvaluation.FormHeritageEvaluationDescription : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationUser1FullName", (formHeritageEvaluation.FormHeritageEvaluationUser1FullName != null) ? formHeritageEvaluation.FormHeritageEvaluationUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationUser2FullName", (formHeritageEvaluation.FormHeritageEvaluationUser2FullName != null) ? formHeritageEvaluation.FormHeritageEvaluationUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationPhoneNumber", (formHeritageEvaluation.FormHeritageEvaluationPhoneNumber != null) ? formHeritageEvaluation.FormHeritageEvaluationPhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationApplicantRole", (formHeritageEvaluation.FormHeritageEvaluationApplicantRole != null) ? formHeritageEvaluation.FormHeritageEvaluationApplicantRole : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDeadIssuanceCity", (formHeritageEvaluation.FormHeritageEvaluationDeadIssuanceCity != null) ? formHeritageEvaluation.FormHeritageEvaluationDeadIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDeadFullName", (formHeritageEvaluation.FormHeritageEvaluationDeadFullName != null) ? formHeritageEvaluation.FormHeritageEvaluationDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDeadFatherName", (formHeritageEvaluation.FormHeritageEvaluationDeadFatherName != null) ? formHeritageEvaluation.FormHeritageEvaluationDeadFatherName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDeadDeathCity", (formHeritageEvaluation.FormHeritageEvaluationDeadDeathCity != null) ? formHeritageEvaluation.FormHeritageEvaluationDeadDeathCity : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDeadCertificateNumber", (formHeritageEvaluation.FormHeritageEvaluationDeadCertificateNumber != null) ? formHeritageEvaluation.FormHeritageEvaluationDeadCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDiagnosisReportNumber", (formHeritageEvaluation.FormHeritageEvaluationDiagnosisReportNumber != null) ? formHeritageEvaluation.FormHeritageEvaluationDiagnosisReportNumber : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationRequestNumber", (formHeritageEvaluation.FormHeritageEvaluationRequestNumber != null) ? formHeritageEvaluation.FormHeritageEvaluationRequestNumber : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationApplicantFatherName", (formHeritageEvaluation.FormHeritageEvaluationApplicantFatherName != null) ? formHeritageEvaluation.FormHeritageEvaluationApplicantFatherName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationApplicantBirthCity", (formHeritageEvaluation.FormHeritageEvaluationApplicantBirthCity != null) ? formHeritageEvaluation.FormHeritageEvaluationApplicantBirthCity : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationApplicantCertificateNumber", (formHeritageEvaluation.FormHeritageEvaluationApplicantCertificateNumber != null) ? formHeritageEvaluation.FormHeritageEvaluationApplicantCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationApplicantIssuanceCity", (formHeritageEvaluation.FormHeritageEvaluationApplicantIssuanceCity != null) ? formHeritageEvaluation.FormHeritageEvaluationApplicantIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationCommercialNumber", (formHeritageEvaluation.FormHeritageEvaluationCommercialNumber != null) ? formHeritageEvaluation.FormHeritageEvaluationCommercialNumber : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationAddress", (formHeritageEvaluation.FormHeritageEvaluationAddress != null) ? formHeritageEvaluation.FormHeritageEvaluationAddress : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationTaxOfficeCode", (formHeritageEvaluation.FormHeritageEvaluationTaxOfficeCode != null) ? formHeritageEvaluation.FormHeritageEvaluationTaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationTaxGroupCode", (formHeritageEvaluation.FormHeritageEvaluationTaxGroupCode != null) ? formHeritageEvaluation.FormHeritageEvaluationTaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationTaxUnitCode", (formHeritageEvaluation.FormHeritageEvaluationTaxUnitCode != null) ? formHeritageEvaluation.FormHeritageEvaluationTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationUser1Code", (formHeritageEvaluation.FormHeritageEvaluationUser1Code != null) ? formHeritageEvaluation.FormHeritageEvaluationUser1Code : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationUser2Code", (formHeritageEvaluation.FormHeritageEvaluationUser2Code != null) ? formHeritageEvaluation.FormHeritageEvaluationUser2Code : (object)DBNull.Value)
		};
		formHeritageEvaluation.FormHeritageEvaluationID = SqlDBHelper.ExecuteScalar("FormHeritageEvaluation_Insert", CommandType.StoredProcedure, parametersFormHeritageEvaluation);
		return formHeritageEvaluation.FormHeritageEvaluationID;
	}

	public bool Update(FormHeritageEvaluation formHeritageEvaluation)
	{
		SqlParameter[] parametersFormHeritageEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageEvaluationID", formHeritageEvaluation.FormHeritageEvaluationID),
			new SqlParameter("@FormHeritageEvaluationRegisterInformationID", (formHeritageEvaluation.FormHeritageEvaluationRegisterInformationID != null && formHeritageEvaluation.FormHeritageEvaluationRegisterInformationID >0 ) ? formHeritageEvaluation.FormHeritageEvaluationRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDeclarationID", formHeritageEvaluation.FormHeritageEvaluationDeclarationID),
			new SqlParameter("@FormHeritageEvaluationApplicantNationalCode", (formHeritageEvaluation.FormHeritageEvaluationApplicantNationalCode != null) ? formHeritageEvaluation.FormHeritageEvaluationApplicantNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationZipCode", (formHeritageEvaluation.FormHeritageEvaluationZipCode != null) ? formHeritageEvaluation.FormHeritageEvaluationZipCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDeadNationalCode", (formHeritageEvaluation.FormHeritageEvaluationDeadNationalCode != null) ? formHeritageEvaluation.FormHeritageEvaluationDeadNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationRegisterDate", (formHeritageEvaluation.FormHeritageEvaluationRegisterDate != null) ? formHeritageEvaluation.FormHeritageEvaluationRegisterDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationApplicantBirthDate", (formHeritageEvaluation.FormHeritageEvaluationApplicantBirthDate != null) ? formHeritageEvaluation.FormHeritageEvaluationApplicantBirthDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDeadDeathDate", (formHeritageEvaluation.FormHeritageEvaluationDeadDeathDate != null) ? formHeritageEvaluation.FormHeritageEvaluationDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDeadIssuanceDate", (formHeritageEvaluation.FormHeritageEvaluationDeadIssuanceDate != null) ? formHeritageEvaluation.FormHeritageEvaluationDeadIssuanceDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDiagnosisReportDate", (formHeritageEvaluation.FormHeritageEvaluationDiagnosisReportDate != null) ? formHeritageEvaluation.FormHeritageEvaluationDiagnosisReportDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationRequestDate", (formHeritageEvaluation.FormHeritageEvaluationRequestDate != null) ? formHeritageEvaluation.FormHeritageEvaluationRequestDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationTaxOfficeTitle", (formHeritageEvaluation.FormHeritageEvaluationTaxOfficeTitle != null) ? formHeritageEvaluation.FormHeritageEvaluationTaxOfficeTitle : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationTaxOfficeAddress", (formHeritageEvaluation.FormHeritageEvaluationTaxOfficeAddress != null) ? formHeritageEvaluation.FormHeritageEvaluationTaxOfficeAddress : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationTaxOfficePhoneNumber", (formHeritageEvaluation.FormHeritageEvaluationTaxOfficePhoneNumber != null) ? formHeritageEvaluation.FormHeritageEvaluationTaxOfficePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationTaxOfficeZipCode", (formHeritageEvaluation.FormHeritageEvaluationTaxOfficeZipCode != null) ? formHeritageEvaluation.FormHeritageEvaluationTaxOfficeZipCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDossierClasses", (formHeritageEvaluation.FormHeritageEvaluationDossierClasses != null) ? formHeritageEvaluation.FormHeritageEvaluationDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationApplicantFullName", (formHeritageEvaluation.FormHeritageEvaluationApplicantFullName != null) ? formHeritageEvaluation.FormHeritageEvaluationApplicantFullName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDescription", (formHeritageEvaluation.FormHeritageEvaluationDescription != null) ? formHeritageEvaluation.FormHeritageEvaluationDescription : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationUser1FullName", (formHeritageEvaluation.FormHeritageEvaluationUser1FullName != null) ? formHeritageEvaluation.FormHeritageEvaluationUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationUser2FullName", (formHeritageEvaluation.FormHeritageEvaluationUser2FullName != null) ? formHeritageEvaluation.FormHeritageEvaluationUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationPhoneNumber", (formHeritageEvaluation.FormHeritageEvaluationPhoneNumber != null) ? formHeritageEvaluation.FormHeritageEvaluationPhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationApplicantRole", (formHeritageEvaluation.FormHeritageEvaluationApplicantRole != null) ? formHeritageEvaluation.FormHeritageEvaluationApplicantRole : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDeadIssuanceCity", (formHeritageEvaluation.FormHeritageEvaluationDeadIssuanceCity != null) ? formHeritageEvaluation.FormHeritageEvaluationDeadIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDeadFullName", (formHeritageEvaluation.FormHeritageEvaluationDeadFullName != null) ? formHeritageEvaluation.FormHeritageEvaluationDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDeadFatherName", (formHeritageEvaluation.FormHeritageEvaluationDeadFatherName != null) ? formHeritageEvaluation.FormHeritageEvaluationDeadFatherName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDeadDeathCity", (formHeritageEvaluation.FormHeritageEvaluationDeadDeathCity != null) ? formHeritageEvaluation.FormHeritageEvaluationDeadDeathCity : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDeadCertificateNumber", (formHeritageEvaluation.FormHeritageEvaluationDeadCertificateNumber != null) ? formHeritageEvaluation.FormHeritageEvaluationDeadCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationDiagnosisReportNumber", (formHeritageEvaluation.FormHeritageEvaluationDiagnosisReportNumber != null) ? formHeritageEvaluation.FormHeritageEvaluationDiagnosisReportNumber : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationRequestNumber", (formHeritageEvaluation.FormHeritageEvaluationRequestNumber != null) ? formHeritageEvaluation.FormHeritageEvaluationRequestNumber : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationApplicantFatherName", (formHeritageEvaluation.FormHeritageEvaluationApplicantFatherName != null) ? formHeritageEvaluation.FormHeritageEvaluationApplicantFatherName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationApplicantBirthCity", (formHeritageEvaluation.FormHeritageEvaluationApplicantBirthCity != null) ? formHeritageEvaluation.FormHeritageEvaluationApplicantBirthCity : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationApplicantCertificateNumber", (formHeritageEvaluation.FormHeritageEvaluationApplicantCertificateNumber != null) ? formHeritageEvaluation.FormHeritageEvaluationApplicantCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationApplicantIssuanceCity", (formHeritageEvaluation.FormHeritageEvaluationApplicantIssuanceCity != null) ? formHeritageEvaluation.FormHeritageEvaluationApplicantIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationCommercialNumber", (formHeritageEvaluation.FormHeritageEvaluationCommercialNumber != null) ? formHeritageEvaluation.FormHeritageEvaluationCommercialNumber : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationAddress", (formHeritageEvaluation.FormHeritageEvaluationAddress != null) ? formHeritageEvaluation.FormHeritageEvaluationAddress : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationTaxOfficeCode", (formHeritageEvaluation.FormHeritageEvaluationTaxOfficeCode != null) ? formHeritageEvaluation.FormHeritageEvaluationTaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationTaxGroupCode", (formHeritageEvaluation.FormHeritageEvaluationTaxGroupCode != null) ? formHeritageEvaluation.FormHeritageEvaluationTaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationTaxUnitCode", (formHeritageEvaluation.FormHeritageEvaluationTaxUnitCode != null) ? formHeritageEvaluation.FormHeritageEvaluationTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationUser1Code", (formHeritageEvaluation.FormHeritageEvaluationUser1Code != null) ? formHeritageEvaluation.FormHeritageEvaluationUser1Code : (object)DBNull.Value),
			new SqlParameter("@FormHeritageEvaluationUser2Code", (formHeritageEvaluation.FormHeritageEvaluationUser2Code != null) ? formHeritageEvaluation.FormHeritageEvaluationUser2Code : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormHeritageEvaluation_Update", CommandType.StoredProcedure, parametersFormHeritageEvaluation);
	}

	public bool Delete(Int64 formHeritageEvaluationID)
	{
		SqlParameter[] parametersFormHeritageEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageEvaluationID", formHeritageEvaluationID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormHeritageEvaluation_Delete", CommandType.StoredProcedure, parametersFormHeritageEvaluation);
	}

	public FormHeritageEvaluation GetDetails(Int64 formHeritageEvaluationID)
	{
		FormHeritageEvaluation formHeritageEvaluation = new FormHeritageEvaluation();

		SqlParameter[] parametersFormHeritageEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageEvaluationID", formHeritageEvaluationID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeritageEvaluation_GetDetails", CommandType.StoredProcedure, parametersFormHeritageEvaluation))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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
			}
		}

		return formHeritageEvaluation;
	}

	public List<FormHeritageEvaluation> GetListAll()
	{
		List<FormHeritageEvaluation> listFormHeritageEvaluation = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormHeritageEvaluation_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormHeritageEvaluation = new List<FormHeritageEvaluation>();

				foreach (DataRow row in table.Rows)
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
					listFormHeritageEvaluation.Add(formHeritageEvaluation);
				}
			}
		}

		return listFormHeritageEvaluation;
	}

	public bool Exists(Int64 formHeritageEvaluationID)
	{
		SqlParameter[] parametersFormHeritageEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageEvaluationID", formHeritageEvaluationID)
		};
		return (SqlDBHelper.ExecuteScalar("FormHeritageEvaluation_Exists", CommandType.StoredProcedure, parametersFormHeritageEvaluation)>0);
	}

	public bool Exists(FormHeritageEvaluation formHeritageEvaluation)
	{
		SqlParameter[] parametersFormHeritageEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageEvaluationID", formHeritageEvaluation.FormHeritageEvaluationID)
		};
		return (SqlDBHelper.ExecuteScalar("FormHeritageEvaluation_Exists", CommandType.StoredProcedure, parametersFormHeritageEvaluation)>0);
	}

	public List<FormHeritageEvaluation> SearchLike(FormHeritageEvaluation formHeritageEvaluation)
	{
		List<FormHeritageEvaluation> listFormHeritageEvaluation = new List<FormHeritageEvaluation>();


		SqlParameter[] parametersFormHeritageEvaluation = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageEvaluationID", formHeritageEvaluation.FormHeritageEvaluationID),
			new SqlParameter("@FormHeritageEvaluationRegisterInformationID", formHeritageEvaluation.FormHeritageEvaluationRegisterInformationID),
			new SqlParameter("@FormHeritageEvaluationDeclarationID", formHeritageEvaluation.FormHeritageEvaluationDeclarationID),
			new SqlParameter("@FormHeritageEvaluationApplicantNationalCode", formHeritageEvaluation.FormHeritageEvaluationApplicantNationalCode),
			new SqlParameter("@FormHeritageEvaluationZipCode", formHeritageEvaluation.FormHeritageEvaluationZipCode),
			new SqlParameter("@FormHeritageEvaluationDeadNationalCode", formHeritageEvaluation.FormHeritageEvaluationDeadNationalCode),
			new SqlParameter("@FormHeritageEvaluationRegisterDate", formHeritageEvaluation.FormHeritageEvaluationRegisterDate),
			new SqlParameter("@FormHeritageEvaluationApplicantBirthDate", formHeritageEvaluation.FormHeritageEvaluationApplicantBirthDate),
			new SqlParameter("@FormHeritageEvaluationDeadDeathDate", formHeritageEvaluation.FormHeritageEvaluationDeadDeathDate),
			new SqlParameter("@FormHeritageEvaluationDeadIssuanceDate", formHeritageEvaluation.FormHeritageEvaluationDeadIssuanceDate),
			new SqlParameter("@FormHeritageEvaluationDiagnosisReportDate", formHeritageEvaluation.FormHeritageEvaluationDiagnosisReportDate),
			new SqlParameter("@FormHeritageEvaluationRequestDate", formHeritageEvaluation.FormHeritageEvaluationRequestDate),
			new SqlParameter("@FormHeritageEvaluationTaxOfficeTitle", formHeritageEvaluation.FormHeritageEvaluationTaxOfficeTitle),
			new SqlParameter("@FormHeritageEvaluationTaxOfficeAddress", formHeritageEvaluation.FormHeritageEvaluationTaxOfficeAddress),
			new SqlParameter("@FormHeritageEvaluationTaxOfficePhoneNumber", formHeritageEvaluation.FormHeritageEvaluationTaxOfficePhoneNumber),
			new SqlParameter("@FormHeritageEvaluationTaxOfficeZipCode", formHeritageEvaluation.FormHeritageEvaluationTaxOfficeZipCode),
			new SqlParameter("@FormHeritageEvaluationDossierClasses", formHeritageEvaluation.FormHeritageEvaluationDossierClasses),
			new SqlParameter("@FormHeritageEvaluationApplicantFullName", formHeritageEvaluation.FormHeritageEvaluationApplicantFullName),
			new SqlParameter("@FormHeritageEvaluationDescription", formHeritageEvaluation.FormHeritageEvaluationDescription),
			new SqlParameter("@FormHeritageEvaluationUser1FullName", formHeritageEvaluation.FormHeritageEvaluationUser1FullName),
			new SqlParameter("@FormHeritageEvaluationUser2FullName", formHeritageEvaluation.FormHeritageEvaluationUser2FullName),
			new SqlParameter("@FormHeritageEvaluationPhoneNumber", formHeritageEvaluation.FormHeritageEvaluationPhoneNumber),
			new SqlParameter("@FormHeritageEvaluationApplicantRole", formHeritageEvaluation.FormHeritageEvaluationApplicantRole),
			new SqlParameter("@FormHeritageEvaluationDeadIssuanceCity", formHeritageEvaluation.FormHeritageEvaluationDeadIssuanceCity),
			new SqlParameter("@FormHeritageEvaluationDeadFullName", formHeritageEvaluation.FormHeritageEvaluationDeadFullName),
			new SqlParameter("@FormHeritageEvaluationDeadFatherName", formHeritageEvaluation.FormHeritageEvaluationDeadFatherName),
			new SqlParameter("@FormHeritageEvaluationDeadDeathCity", formHeritageEvaluation.FormHeritageEvaluationDeadDeathCity),
			new SqlParameter("@FormHeritageEvaluationDeadCertificateNumber", formHeritageEvaluation.FormHeritageEvaluationDeadCertificateNumber),
			new SqlParameter("@FormHeritageEvaluationDiagnosisReportNumber", formHeritageEvaluation.FormHeritageEvaluationDiagnosisReportNumber),
			new SqlParameter("@FormHeritageEvaluationRequestNumber", formHeritageEvaluation.FormHeritageEvaluationRequestNumber),
			new SqlParameter("@FormHeritageEvaluationApplicantFatherName", formHeritageEvaluation.FormHeritageEvaluationApplicantFatherName),
			new SqlParameter("@FormHeritageEvaluationApplicantBirthCity", formHeritageEvaluation.FormHeritageEvaluationApplicantBirthCity),
			new SqlParameter("@FormHeritageEvaluationApplicantCertificateNumber", formHeritageEvaluation.FormHeritageEvaluationApplicantCertificateNumber),
			new SqlParameter("@FormHeritageEvaluationApplicantIssuanceCity", formHeritageEvaluation.FormHeritageEvaluationApplicantIssuanceCity),
			new SqlParameter("@FormHeritageEvaluationCommercialNumber", formHeritageEvaluation.FormHeritageEvaluationCommercialNumber),
			new SqlParameter("@FormHeritageEvaluationAddress", formHeritageEvaluation.FormHeritageEvaluationAddress),
			new SqlParameter("@FormHeritageEvaluationTaxOfficeCode", formHeritageEvaluation.FormHeritageEvaluationTaxOfficeCode),
			new SqlParameter("@FormHeritageEvaluationTaxGroupCode", formHeritageEvaluation.FormHeritageEvaluationTaxGroupCode),
			new SqlParameter("@FormHeritageEvaluationTaxUnitCode", formHeritageEvaluation.FormHeritageEvaluationTaxUnitCode),
			new SqlParameter("@FormHeritageEvaluationUser1Code", formHeritageEvaluation.FormHeritageEvaluationUser1Code),
			new SqlParameter("@FormHeritageEvaluationUser2Code", formHeritageEvaluation.FormHeritageEvaluationUser2Code),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeritageEvaluation_SearchLike", CommandType.StoredProcedure, parametersFormHeritageEvaluation))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormHeritageEvaluation tmpFormHeritageEvaluation = new FormHeritageEvaluation();
					tmpFormHeritageEvaluation.FormHeritageEvaluationID = (row["FormHeritageEvaluationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageEvaluationID"]) : 0 ;
					tmpFormHeritageEvaluation.FormHeritageEvaluationRegisterInformationID = (row["FormHeritageEvaluationRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageEvaluationRegisterInformationID"]) : 0 ;
					tmpFormHeritageEvaluation.FormHeritageEvaluationDeclarationID = (row["FormHeritageEvaluationDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageEvaluationDeclarationID"]) : 0 ;
					tmpFormHeritageEvaluation.FormHeritageEvaluationApplicantNationalCode = (row["FormHeritageEvaluationApplicantNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageEvaluationApplicantNationalCode"]) : 0 ;
					tmpFormHeritageEvaluation.FormHeritageEvaluationZipCode = (row["FormHeritageEvaluationZipCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageEvaluationZipCode"]) : 0 ;
					tmpFormHeritageEvaluation.FormHeritageEvaluationDeadNationalCode = (row["FormHeritageEvaluationDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageEvaluationDeadNationalCode"]) : 0 ;
					tmpFormHeritageEvaluation.FormHeritageEvaluationRegisterDate = row["FormHeritageEvaluationRegisterDate"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationApplicantBirthDate = row["FormHeritageEvaluationApplicantBirthDate"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationDeadDeathDate = row["FormHeritageEvaluationDeadDeathDate"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationDeadIssuanceDate = row["FormHeritageEvaluationDeadIssuanceDate"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationDiagnosisReportDate = row["FormHeritageEvaluationDiagnosisReportDate"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationRequestDate = row["FormHeritageEvaluationRequestDate"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationTaxOfficeTitle = row["FormHeritageEvaluationTaxOfficeTitle"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationTaxOfficeAddress = row["FormHeritageEvaluationTaxOfficeAddress"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationTaxOfficePhoneNumber = row["FormHeritageEvaluationTaxOfficePhoneNumber"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationTaxOfficeZipCode = row["FormHeritageEvaluationTaxOfficeZipCode"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationDossierClasses = row["FormHeritageEvaluationDossierClasses"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationApplicantFullName = row["FormHeritageEvaluationApplicantFullName"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationDescription = row["FormHeritageEvaluationDescription"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationUser1FullName = row["FormHeritageEvaluationUser1FullName"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationUser2FullName = row["FormHeritageEvaluationUser2FullName"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationPhoneNumber = row["FormHeritageEvaluationPhoneNumber"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationApplicantRole = row["FormHeritageEvaluationApplicantRole"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationDeadIssuanceCity = row["FormHeritageEvaluationDeadIssuanceCity"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationDeadFullName = row["FormHeritageEvaluationDeadFullName"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationDeadFatherName = row["FormHeritageEvaluationDeadFatherName"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationDeadDeathCity = row["FormHeritageEvaluationDeadDeathCity"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationDeadCertificateNumber = row["FormHeritageEvaluationDeadCertificateNumber"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationDiagnosisReportNumber = row["FormHeritageEvaluationDiagnosisReportNumber"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationRequestNumber = row["FormHeritageEvaluationRequestNumber"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationApplicantFatherName = row["FormHeritageEvaluationApplicantFatherName"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationApplicantBirthCity = row["FormHeritageEvaluationApplicantBirthCity"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationApplicantCertificateNumber = row["FormHeritageEvaluationApplicantCertificateNumber"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationApplicantIssuanceCity = row["FormHeritageEvaluationApplicantIssuanceCity"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationCommercialNumber = row["FormHeritageEvaluationCommercialNumber"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationAddress = row["FormHeritageEvaluationAddress"].ToString();
					tmpFormHeritageEvaluation.FormHeritageEvaluationTaxOfficeCode = (row["FormHeritageEvaluationTaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["FormHeritageEvaluationTaxOfficeCode"]) : 0 ;
					tmpFormHeritageEvaluation.FormHeritageEvaluationTaxGroupCode = (row["FormHeritageEvaluationTaxGroupCode"] != DBNull.Value) ? Convert.ToInt32(row["FormHeritageEvaluationTaxGroupCode"]) : 0 ;
					tmpFormHeritageEvaluation.FormHeritageEvaluationTaxUnitCode = (row["FormHeritageEvaluationTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["FormHeritageEvaluationTaxUnitCode"]) : 0 ;
					tmpFormHeritageEvaluation.FormHeritageEvaluationUser1Code = (row["FormHeritageEvaluationUser1Code"] != DBNull.Value) ? Convert.ToInt32(row["FormHeritageEvaluationUser1Code"]) : 0 ;
					tmpFormHeritageEvaluation.FormHeritageEvaluationUser2Code = (row["FormHeritageEvaluationUser2Code"] != DBNull.Value) ? Convert.ToInt32(row["FormHeritageEvaluationUser2Code"]) : 0 ;

					listFormHeritageEvaluation.Add(tmpFormHeritageEvaluation);
				}
			}
		}

		return listFormHeritageEvaluation;
	}

}
}
