using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormDiagnosisResultDBAccess
{


	public Int64 Insert(FormDiagnosisResult formDiagnosisResult)
	{
		SqlParameter[] parametersFormDiagnosisResult = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisResultDeclarationID", (formDiagnosisResult.FormDiagnosisResultDeclarationID > 0) ? formDiagnosisResult.FormDiagnosisResultDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultRegisterInformationID", (formDiagnosisResult.FormDiagnosisResultRegisterInformationID > 0) ? formDiagnosisResult.FormDiagnosisResultRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultApplicantNationalCode", (formDiagnosisResult.FormDiagnosisResultApplicantNationalCode != null) ? formDiagnosisResult.FormDiagnosisResultApplicantNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultZipCode", (formDiagnosisResult.FormDiagnosisResultZipCode != null) ? formDiagnosisResult.FormDiagnosisResultZipCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDeadNationalCode", (formDiagnosisResult.FormDiagnosisResultDeadNationalCode != null) ? formDiagnosisResult.FormDiagnosisResultDeadNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDeadIssuanceCity", (formDiagnosisResult.FormDiagnosisResultDeadIssuanceCity != null) ? formDiagnosisResult.FormDiagnosisResultDeadIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultRegisterDate", (formDiagnosisResult.FormDiagnosisResultRegisterDate != null) ? formDiagnosisResult.FormDiagnosisResultRegisterDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultApplicantBirthDate", (formDiagnosisResult.FormDiagnosisResultApplicantBirthDate != null) ? formDiagnosisResult.FormDiagnosisResultApplicantBirthDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDeadDeathDate", (formDiagnosisResult.FormDiagnosisResultDeadDeathDate != null) ? formDiagnosisResult.FormDiagnosisResultDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDiagnosisReportDate", (formDiagnosisResult.FormDiagnosisResultDiagnosisReportDate != null) ? formDiagnosisResult.FormDiagnosisResultDiagnosisReportDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultRequestDate", (formDiagnosisResult.FormDiagnosisResultRequestDate != null) ? formDiagnosisResult.FormDiagnosisResultRequestDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultTaxOfficeTitle", (formDiagnosisResult.FormDiagnosisResultTaxOfficeTitle != null) ? formDiagnosisResult.FormDiagnosisResultTaxOfficeTitle : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultTaxOfficeAddress", (formDiagnosisResult.FormDiagnosisResultTaxOfficeAddress != null) ? formDiagnosisResult.FormDiagnosisResultTaxOfficeAddress : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultTaxOfficePhoneNumber", (formDiagnosisResult.FormDiagnosisResultTaxOfficePhoneNumber != null) ? formDiagnosisResult.FormDiagnosisResultTaxOfficePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultTaxOfficeZipCode", (formDiagnosisResult.FormDiagnosisResultTaxOfficeZipCode != null) ? formDiagnosisResult.FormDiagnosisResultTaxOfficeZipCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDossierClasses", (formDiagnosisResult.FormDiagnosisResultDossierClasses != null) ? formDiagnosisResult.FormDiagnosisResultDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultApplicantFullName", (formDiagnosisResult.FormDiagnosisResultApplicantFullName != null) ? formDiagnosisResult.FormDiagnosisResultApplicantFullName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDescription", (formDiagnosisResult.FormDiagnosisResultDescription != null) ? formDiagnosisResult.FormDiagnosisResultDescription : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultUser1FullName", (formDiagnosisResult.FormDiagnosisResultUser1FullName != null) ? formDiagnosisResult.FormDiagnosisResultUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultUser2FullName", (formDiagnosisResult.FormDiagnosisResultUser2FullName != null) ? formDiagnosisResult.FormDiagnosisResultUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultPhoneNumber", (formDiagnosisResult.FormDiagnosisResultPhoneNumber != null) ? formDiagnosisResult.FormDiagnosisResultPhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultApplicantRole", (formDiagnosisResult.FormDiagnosisResultApplicantRole != null) ? formDiagnosisResult.FormDiagnosisResultApplicantRole : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDeadFullName", (formDiagnosisResult.FormDiagnosisResultDeadFullName != null) ? formDiagnosisResult.FormDiagnosisResultDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDeadFatherName", (formDiagnosisResult.FormDiagnosisResultDeadFatherName != null) ? formDiagnosisResult.FormDiagnosisResultDeadFatherName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDeadDeathCity", (formDiagnosisResult.FormDiagnosisResultDeadDeathCity != null) ? formDiagnosisResult.FormDiagnosisResultDeadDeathCity : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDeadCertificateNumber", (formDiagnosisResult.FormDiagnosisResultDeadCertificateNumber != null) ? formDiagnosisResult.FormDiagnosisResultDeadCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDiagnosisReportNumber", (formDiagnosisResult.FormDiagnosisResultDiagnosisReportNumber != null) ? formDiagnosisResult.FormDiagnosisResultDiagnosisReportNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultRequestNumber", (formDiagnosisResult.FormDiagnosisResultRequestNumber != null) ? formDiagnosisResult.FormDiagnosisResultRequestNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultApplicantFatherName", (formDiagnosisResult.FormDiagnosisResultApplicantFatherName != null) ? formDiagnosisResult.FormDiagnosisResultApplicantFatherName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultApplicantBirthCity", (formDiagnosisResult.FormDiagnosisResultApplicantBirthCity != null) ? formDiagnosisResult.FormDiagnosisResultApplicantBirthCity : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultApplicantCertificateNumber", (formDiagnosisResult.FormDiagnosisResultApplicantCertificateNumber != null) ? formDiagnosisResult.FormDiagnosisResultApplicantCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultApplicantIssuanceCity", (formDiagnosisResult.FormDiagnosisResultApplicantIssuanceCity != null) ? formDiagnosisResult.FormDiagnosisResultApplicantIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultCommercialNumber", (formDiagnosisResult.FormDiagnosisResultCommercialNumber != null) ? formDiagnosisResult.FormDiagnosisResultCommercialNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultAddress", (formDiagnosisResult.FormDiagnosisResultAddress != null) ? formDiagnosisResult.FormDiagnosisResultAddress : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultTaxOfficeCode", (formDiagnosisResult.FormDiagnosisResultTaxOfficeCode != null) ? formDiagnosisResult.FormDiagnosisResultTaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultTaxGroupCode", (formDiagnosisResult.FormDiagnosisResultTaxGroupCode != null) ? formDiagnosisResult.FormDiagnosisResultTaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultTaxUnitCode", (formDiagnosisResult.FormDiagnosisResultTaxUnitCode != null) ? formDiagnosisResult.FormDiagnosisResultTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultUser1Code", (formDiagnosisResult.FormDiagnosisResultUser1Code != null) ? formDiagnosisResult.FormDiagnosisResultUser1Code : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultUser2Code", (formDiagnosisResult.FormDiagnosisResultUser2Code != null) ? formDiagnosisResult.FormDiagnosisResultUser2Code : (object)DBNull.Value)
		};
		formDiagnosisResult.FormDiagnosisResultID = SqlDBHelper.ExecuteScalar("FormDiagnosisResult_Insert", CommandType.StoredProcedure, parametersFormDiagnosisResult);
		return formDiagnosisResult.FormDiagnosisResultID;
	}

	public bool Update(FormDiagnosisResult formDiagnosisResult)
	{
		SqlParameter[] parametersFormDiagnosisResult = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisResultID", formDiagnosisResult.FormDiagnosisResultID),
			new SqlParameter("@FormDiagnosisResultDeclarationID", formDiagnosisResult.FormDiagnosisResultDeclarationID),
			new SqlParameter("@FormDiagnosisResultRegisterInformationID", (formDiagnosisResult.FormDiagnosisResultRegisterInformationID != null && formDiagnosisResult.FormDiagnosisResultRegisterInformationID >0 ) ? formDiagnosisResult.FormDiagnosisResultRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultApplicantNationalCode", (formDiagnosisResult.FormDiagnosisResultApplicantNationalCode != null) ? formDiagnosisResult.FormDiagnosisResultApplicantNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultZipCode", (formDiagnosisResult.FormDiagnosisResultZipCode != null) ? formDiagnosisResult.FormDiagnosisResultZipCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDeadNationalCode", (formDiagnosisResult.FormDiagnosisResultDeadNationalCode != null) ? formDiagnosisResult.FormDiagnosisResultDeadNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDeadIssuanceCity", (formDiagnosisResult.FormDiagnosisResultDeadIssuanceCity != null) ? formDiagnosisResult.FormDiagnosisResultDeadIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultRegisterDate", (formDiagnosisResult.FormDiagnosisResultRegisterDate != null) ? formDiagnosisResult.FormDiagnosisResultRegisterDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultApplicantBirthDate", (formDiagnosisResult.FormDiagnosisResultApplicantBirthDate != null) ? formDiagnosisResult.FormDiagnosisResultApplicantBirthDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDeadDeathDate", (formDiagnosisResult.FormDiagnosisResultDeadDeathDate != null) ? formDiagnosisResult.FormDiagnosisResultDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDiagnosisReportDate", (formDiagnosisResult.FormDiagnosisResultDiagnosisReportDate != null) ? formDiagnosisResult.FormDiagnosisResultDiagnosisReportDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultRequestDate", (formDiagnosisResult.FormDiagnosisResultRequestDate != null) ? formDiagnosisResult.FormDiagnosisResultRequestDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultTaxOfficeTitle", (formDiagnosisResult.FormDiagnosisResultTaxOfficeTitle != null) ? formDiagnosisResult.FormDiagnosisResultTaxOfficeTitle : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultTaxOfficeAddress", (formDiagnosisResult.FormDiagnosisResultTaxOfficeAddress != null) ? formDiagnosisResult.FormDiagnosisResultTaxOfficeAddress : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultTaxOfficePhoneNumber", (formDiagnosisResult.FormDiagnosisResultTaxOfficePhoneNumber != null) ? formDiagnosisResult.FormDiagnosisResultTaxOfficePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultTaxOfficeZipCode", (formDiagnosisResult.FormDiagnosisResultTaxOfficeZipCode != null) ? formDiagnosisResult.FormDiagnosisResultTaxOfficeZipCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDossierClasses", (formDiagnosisResult.FormDiagnosisResultDossierClasses != null) ? formDiagnosisResult.FormDiagnosisResultDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultApplicantFullName", (formDiagnosisResult.FormDiagnosisResultApplicantFullName != null) ? formDiagnosisResult.FormDiagnosisResultApplicantFullName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDescription", (formDiagnosisResult.FormDiagnosisResultDescription != null) ? formDiagnosisResult.FormDiagnosisResultDescription : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultUser1FullName", (formDiagnosisResult.FormDiagnosisResultUser1FullName != null) ? formDiagnosisResult.FormDiagnosisResultUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultUser2FullName", (formDiagnosisResult.FormDiagnosisResultUser2FullName != null) ? formDiagnosisResult.FormDiagnosisResultUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultPhoneNumber", (formDiagnosisResult.FormDiagnosisResultPhoneNumber != null) ? formDiagnosisResult.FormDiagnosisResultPhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultApplicantRole", (formDiagnosisResult.FormDiagnosisResultApplicantRole != null) ? formDiagnosisResult.FormDiagnosisResultApplicantRole : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDeadFullName", (formDiagnosisResult.FormDiagnosisResultDeadFullName != null) ? formDiagnosisResult.FormDiagnosisResultDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDeadFatherName", (formDiagnosisResult.FormDiagnosisResultDeadFatherName != null) ? formDiagnosisResult.FormDiagnosisResultDeadFatherName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDeadDeathCity", (formDiagnosisResult.FormDiagnosisResultDeadDeathCity != null) ? formDiagnosisResult.FormDiagnosisResultDeadDeathCity : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDeadCertificateNumber", (formDiagnosisResult.FormDiagnosisResultDeadCertificateNumber != null) ? formDiagnosisResult.FormDiagnosisResultDeadCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultDiagnosisReportNumber", (formDiagnosisResult.FormDiagnosisResultDiagnosisReportNumber != null) ? formDiagnosisResult.FormDiagnosisResultDiagnosisReportNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultRequestNumber", (formDiagnosisResult.FormDiagnosisResultRequestNumber != null) ? formDiagnosisResult.FormDiagnosisResultRequestNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultApplicantFatherName", (formDiagnosisResult.FormDiagnosisResultApplicantFatherName != null) ? formDiagnosisResult.FormDiagnosisResultApplicantFatherName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultApplicantBirthCity", (formDiagnosisResult.FormDiagnosisResultApplicantBirthCity != null) ? formDiagnosisResult.FormDiagnosisResultApplicantBirthCity : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultApplicantCertificateNumber", (formDiagnosisResult.FormDiagnosisResultApplicantCertificateNumber != null) ? formDiagnosisResult.FormDiagnosisResultApplicantCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultApplicantIssuanceCity", (formDiagnosisResult.FormDiagnosisResultApplicantIssuanceCity != null) ? formDiagnosisResult.FormDiagnosisResultApplicantIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultCommercialNumber", (formDiagnosisResult.FormDiagnosisResultCommercialNumber != null) ? formDiagnosisResult.FormDiagnosisResultCommercialNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultAddress", (formDiagnosisResult.FormDiagnosisResultAddress != null) ? formDiagnosisResult.FormDiagnosisResultAddress : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultTaxOfficeCode", (formDiagnosisResult.FormDiagnosisResultTaxOfficeCode != null) ? formDiagnosisResult.FormDiagnosisResultTaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultTaxGroupCode", (formDiagnosisResult.FormDiagnosisResultTaxGroupCode != null) ? formDiagnosisResult.FormDiagnosisResultTaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultTaxUnitCode", (formDiagnosisResult.FormDiagnosisResultTaxUnitCode != null) ? formDiagnosisResult.FormDiagnosisResultTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultUser1Code", (formDiagnosisResult.FormDiagnosisResultUser1Code != null) ? formDiagnosisResult.FormDiagnosisResultUser1Code : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisResultUser2Code", (formDiagnosisResult.FormDiagnosisResultUser2Code != null) ? formDiagnosisResult.FormDiagnosisResultUser2Code : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormDiagnosisResult_Update", CommandType.StoredProcedure, parametersFormDiagnosisResult);
	}

	public bool Delete(Int64 formDiagnosisResultID)
	{
		SqlParameter[] parametersFormDiagnosisResult = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisResultID", formDiagnosisResultID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormDiagnosisResult_Delete", CommandType.StoredProcedure, parametersFormDiagnosisResult);
	}

	public FormDiagnosisResult GetDetails(Int64 formDiagnosisResultID)
	{
		FormDiagnosisResult formDiagnosisResult = new FormDiagnosisResult();

		SqlParameter[] parametersFormDiagnosisResult = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisResultID", formDiagnosisResultID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDiagnosisResult_GetDetails", CommandType.StoredProcedure, parametersFormDiagnosisResult))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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
			}
		}

		return formDiagnosisResult;
	}

	public List<FormDiagnosisResult> GetListAll()
	{
		List<FormDiagnosisResult> listFormDiagnosisResult = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormDiagnosisResult_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormDiagnosisResult = new List<FormDiagnosisResult>();

				foreach (DataRow row in table.Rows)
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
					listFormDiagnosisResult.Add(formDiagnosisResult);
				}
			}
		}

		return listFormDiagnosisResult;
	}

	public bool Exists(Int64 formDiagnosisResultID)
	{
		SqlParameter[] parametersFormDiagnosisResult = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisResultID", formDiagnosisResultID)
		};
		return (SqlDBHelper.ExecuteScalar("FormDiagnosisResult_Exists", CommandType.StoredProcedure, parametersFormDiagnosisResult)>0);
	}

	public bool Exists(FormDiagnosisResult formDiagnosisResult)
	{
		SqlParameter[] parametersFormDiagnosisResult = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisResultID", formDiagnosisResult.FormDiagnosisResultID)
		};
		return (SqlDBHelper.ExecuteScalar("FormDiagnosisResult_Exists", CommandType.StoredProcedure, parametersFormDiagnosisResult)>0);
	}

	public List<FormDiagnosisResult> SearchLike(FormDiagnosisResult formDiagnosisResult)
	{
		List<FormDiagnosisResult> listFormDiagnosisResult = new List<FormDiagnosisResult>();


		SqlParameter[] parametersFormDiagnosisResult = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisResultID", formDiagnosisResult.FormDiagnosisResultID),
			new SqlParameter("@FormDiagnosisResultDeclarationID", formDiagnosisResult.FormDiagnosisResultDeclarationID),
			new SqlParameter("@FormDiagnosisResultRegisterInformationID", formDiagnosisResult.FormDiagnosisResultRegisterInformationID),
			new SqlParameter("@FormDiagnosisResultApplicantNationalCode", formDiagnosisResult.FormDiagnosisResultApplicantNationalCode),
			new SqlParameter("@FormDiagnosisResultZipCode", formDiagnosisResult.FormDiagnosisResultZipCode),
			new SqlParameter("@FormDiagnosisResultDeadNationalCode", formDiagnosisResult.FormDiagnosisResultDeadNationalCode),
			new SqlParameter("@FormDiagnosisResultDeadIssuanceCity", formDiagnosisResult.FormDiagnosisResultDeadIssuanceCity),
			new SqlParameter("@FormDiagnosisResultRegisterDate", formDiagnosisResult.FormDiagnosisResultRegisterDate),
			new SqlParameter("@FormDiagnosisResultApplicantBirthDate", formDiagnosisResult.FormDiagnosisResultApplicantBirthDate),
			new SqlParameter("@FormDiagnosisResultDeadDeathDate", formDiagnosisResult.FormDiagnosisResultDeadDeathDate),
			new SqlParameter("@FormDiagnosisResultDiagnosisReportDate", formDiagnosisResult.FormDiagnosisResultDiagnosisReportDate),
			new SqlParameter("@FormDiagnosisResultRequestDate", formDiagnosisResult.FormDiagnosisResultRequestDate),
			new SqlParameter("@FormDiagnosisResultTaxOfficeTitle", formDiagnosisResult.FormDiagnosisResultTaxOfficeTitle),
			new SqlParameter("@FormDiagnosisResultTaxOfficeAddress", formDiagnosisResult.FormDiagnosisResultTaxOfficeAddress),
			new SqlParameter("@FormDiagnosisResultTaxOfficePhoneNumber", formDiagnosisResult.FormDiagnosisResultTaxOfficePhoneNumber),
			new SqlParameter("@FormDiagnosisResultTaxOfficeZipCode", formDiagnosisResult.FormDiagnosisResultTaxOfficeZipCode),
			new SqlParameter("@FormDiagnosisResultDossierClasses", formDiagnosisResult.FormDiagnosisResultDossierClasses),
			new SqlParameter("@FormDiagnosisResultApplicantFullName", formDiagnosisResult.FormDiagnosisResultApplicantFullName),
			new SqlParameter("@FormDiagnosisResultDescription", formDiagnosisResult.FormDiagnosisResultDescription),
			new SqlParameter("@FormDiagnosisResultUser1FullName", formDiagnosisResult.FormDiagnosisResultUser1FullName),
			new SqlParameter("@FormDiagnosisResultUser2FullName", formDiagnosisResult.FormDiagnosisResultUser2FullName),
			new SqlParameter("@FormDiagnosisResultPhoneNumber", formDiagnosisResult.FormDiagnosisResultPhoneNumber),
			new SqlParameter("@FormDiagnosisResultApplicantRole", formDiagnosisResult.FormDiagnosisResultApplicantRole),
			new SqlParameter("@FormDiagnosisResultDeadFullName", formDiagnosisResult.FormDiagnosisResultDeadFullName),
			new SqlParameter("@FormDiagnosisResultDeadFatherName", formDiagnosisResult.FormDiagnosisResultDeadFatherName),
			new SqlParameter("@FormDiagnosisResultDeadDeathCity", formDiagnosisResult.FormDiagnosisResultDeadDeathCity),
			new SqlParameter("@FormDiagnosisResultDeadCertificateNumber", formDiagnosisResult.FormDiagnosisResultDeadCertificateNumber),
			new SqlParameter("@FormDiagnosisResultDiagnosisReportNumber", formDiagnosisResult.FormDiagnosisResultDiagnosisReportNumber),
			new SqlParameter("@FormDiagnosisResultRequestNumber", formDiagnosisResult.FormDiagnosisResultRequestNumber),
			new SqlParameter("@FormDiagnosisResultApplicantFatherName", formDiagnosisResult.FormDiagnosisResultApplicantFatherName),
			new SqlParameter("@FormDiagnosisResultApplicantBirthCity", formDiagnosisResult.FormDiagnosisResultApplicantBirthCity),
			new SqlParameter("@FormDiagnosisResultApplicantCertificateNumber", formDiagnosisResult.FormDiagnosisResultApplicantCertificateNumber),
			new SqlParameter("@FormDiagnosisResultApplicantIssuanceCity", formDiagnosisResult.FormDiagnosisResultApplicantIssuanceCity),
			new SqlParameter("@FormDiagnosisResultCommercialNumber", formDiagnosisResult.FormDiagnosisResultCommercialNumber),
			new SqlParameter("@FormDiagnosisResultAddress", formDiagnosisResult.FormDiagnosisResultAddress),
			new SqlParameter("@FormDiagnosisResultTaxOfficeCode", formDiagnosisResult.FormDiagnosisResultTaxOfficeCode),
			new SqlParameter("@FormDiagnosisResultTaxGroupCode", formDiagnosisResult.FormDiagnosisResultTaxGroupCode),
			new SqlParameter("@FormDiagnosisResultTaxUnitCode", formDiagnosisResult.FormDiagnosisResultTaxUnitCode),
			new SqlParameter("@FormDiagnosisResultUser1Code", formDiagnosisResult.FormDiagnosisResultUser1Code),
			new SqlParameter("@FormDiagnosisResultUser2Code", formDiagnosisResult.FormDiagnosisResultUser2Code),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDiagnosisResult_SearchLike", CommandType.StoredProcedure, parametersFormDiagnosisResult))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormDiagnosisResult tmpFormDiagnosisResult = new FormDiagnosisResult();
					tmpFormDiagnosisResult.FormDiagnosisResultID = (row["FormDiagnosisResultID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisResultID"]) : 0 ;
					tmpFormDiagnosisResult.FormDiagnosisResultDeclarationID = (row["FormDiagnosisResultDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisResultDeclarationID"]) : 0 ;
					tmpFormDiagnosisResult.FormDiagnosisResultRegisterInformationID = (row["FormDiagnosisResultRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisResultRegisterInformationID"]) : 0 ;
					tmpFormDiagnosisResult.FormDiagnosisResultApplicantNationalCode = (row["FormDiagnosisResultApplicantNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisResultApplicantNationalCode"]) : 0 ;
					tmpFormDiagnosisResult.FormDiagnosisResultZipCode = (row["FormDiagnosisResultZipCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisResultZipCode"]) : 0 ;
					tmpFormDiagnosisResult.FormDiagnosisResultDeadNationalCode = (row["FormDiagnosisResultDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisResultDeadNationalCode"]) : 0 ;
					tmpFormDiagnosisResult.FormDiagnosisResultDeadIssuanceCity = row["FormDiagnosisResultDeadIssuanceCity"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultRegisterDate = row["FormDiagnosisResultRegisterDate"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultApplicantBirthDate = row["FormDiagnosisResultApplicantBirthDate"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultDeadDeathDate = row["FormDiagnosisResultDeadDeathDate"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultDiagnosisReportDate = row["FormDiagnosisResultDiagnosisReportDate"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultRequestDate = row["FormDiagnosisResultRequestDate"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultTaxOfficeTitle = row["FormDiagnosisResultTaxOfficeTitle"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultTaxOfficeAddress = row["FormDiagnosisResultTaxOfficeAddress"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultTaxOfficePhoneNumber = row["FormDiagnosisResultTaxOfficePhoneNumber"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultTaxOfficeZipCode = row["FormDiagnosisResultTaxOfficeZipCode"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultDossierClasses = row["FormDiagnosisResultDossierClasses"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultApplicantFullName = row["FormDiagnosisResultApplicantFullName"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultDescription = row["FormDiagnosisResultDescription"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultUser1FullName = row["FormDiagnosisResultUser1FullName"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultUser2FullName = row["FormDiagnosisResultUser2FullName"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultPhoneNumber = row["FormDiagnosisResultPhoneNumber"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultApplicantRole = row["FormDiagnosisResultApplicantRole"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultDeadFullName = row["FormDiagnosisResultDeadFullName"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultDeadFatherName = row["FormDiagnosisResultDeadFatherName"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultDeadDeathCity = row["FormDiagnosisResultDeadDeathCity"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultDeadCertificateNumber = row["FormDiagnosisResultDeadCertificateNumber"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultDiagnosisReportNumber = row["FormDiagnosisResultDiagnosisReportNumber"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultRequestNumber = row["FormDiagnosisResultRequestNumber"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultApplicantFatherName = row["FormDiagnosisResultApplicantFatherName"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultApplicantBirthCity = row["FormDiagnosisResultApplicantBirthCity"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultApplicantCertificateNumber = row["FormDiagnosisResultApplicantCertificateNumber"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultApplicantIssuanceCity = row["FormDiagnosisResultApplicantIssuanceCity"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultCommercialNumber = row["FormDiagnosisResultCommercialNumber"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultAddress = row["FormDiagnosisResultAddress"].ToString();
					tmpFormDiagnosisResult.FormDiagnosisResultTaxOfficeCode = (row["FormDiagnosisResultTaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["FormDiagnosisResultTaxOfficeCode"]) : 0 ;
					tmpFormDiagnosisResult.FormDiagnosisResultTaxGroupCode = (row["FormDiagnosisResultTaxGroupCode"] != DBNull.Value) ? Convert.ToInt32(row["FormDiagnosisResultTaxGroupCode"]) : 0 ;
					tmpFormDiagnosisResult.FormDiagnosisResultTaxUnitCode = (row["FormDiagnosisResultTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["FormDiagnosisResultTaxUnitCode"]) : 0 ;
					tmpFormDiagnosisResult.FormDiagnosisResultUser1Code = (row["FormDiagnosisResultUser1Code"] != DBNull.Value) ? Convert.ToInt32(row["FormDiagnosisResultUser1Code"]) : 0 ;
					tmpFormDiagnosisResult.FormDiagnosisResultUser2Code = (row["FormDiagnosisResultUser2Code"] != DBNull.Value) ? Convert.ToInt32(row["FormDiagnosisResultUser2Code"]) : 0 ;

					listFormDiagnosisResult.Add(tmpFormDiagnosisResult);
				}
			}
		}

		return listFormDiagnosisResult;
	}

}
}
