using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormFreedomDBAccess
{


	public Int64 Insert(FormFreedom formFreedom)
	{
		SqlParameter[] parametersFormFreedom = new SqlParameter[]
		{
			new SqlParameter("@FormFreedomDeclarationID", (formFreedom.FormFreedomDeclarationID > 0) ? formFreedom.FormFreedomDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormFreedomRegisterInformationID", (formFreedom.FormFreedomRegisterInformationID > 0) ? formFreedom.FormFreedomRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormFreedomApplicantNationalCode", (formFreedom.FormFreedomApplicantNationalCode != null) ? formFreedom.FormFreedomApplicantNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormFreedomZipCode", (formFreedom.FormFreedomZipCode != null) ? formFreedom.FormFreedomZipCode : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDeadNationalCode", (formFreedom.FormFreedomDeadNationalCode != null) ? formFreedom.FormFreedomDeadNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormFreedomRegisterDate", (formFreedom.FormFreedomRegisterDate != null) ? formFreedom.FormFreedomRegisterDate : (object)DBNull.Value),
			new SqlParameter("@FormFreedomRequestDate", (formFreedom.FormFreedomRequestDate != null) ? formFreedom.FormFreedomRequestDate : (object)DBNull.Value),
			new SqlParameter("@FormFreedomApplicantBirthDate", (formFreedom.FormFreedomApplicantBirthDate != null) ? formFreedom.FormFreedomApplicantBirthDate : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDeadDeathDate", (formFreedom.FormFreedomDeadDeathDate != null) ? formFreedom.FormFreedomDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDeclarationRegisterDate", (formFreedom.FormFreedomDeclarationRegisterDate != null) ? formFreedom.FormFreedomDeclarationRegisterDate : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDiagnosisDate", (formFreedom.FormFreedomDiagnosisDate != null) ? formFreedom.FormFreedomDiagnosisDate : (object)DBNull.Value),
			new SqlParameter("@FormFreedomHeirsCertificateDate", (formFreedom.FormFreedomHeirsCertificateDate != null) ? formFreedom.FormFreedomHeirsCertificateDate : (object)DBNull.Value),
			new SqlParameter("@FormFreedomTaxOfficeTitle", (formFreedom.FormFreedomTaxOfficeTitle != null) ? formFreedom.FormFreedomTaxOfficeTitle : (object)DBNull.Value),
			new SqlParameter("@FormFreedomTaxOfficeAddress", (formFreedom.FormFreedomTaxOfficeAddress != null) ? formFreedom.FormFreedomTaxOfficeAddress : (object)DBNull.Value),
			new SqlParameter("@FormFreedomTaxOfficePhoneNumber", (formFreedom.FormFreedomTaxOfficePhoneNumber != null) ? formFreedom.FormFreedomTaxOfficePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormFreedomTaxOfficeZipCode", (formFreedom.FormFreedomTaxOfficeZipCode != null) ? formFreedom.FormFreedomTaxOfficeZipCode : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDossierClasses", (formFreedom.FormFreedomDossierClasses != null) ? formFreedom.FormFreedomDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormFreedomRequestResource", (formFreedom.FormFreedomRequestResource != null) ? formFreedom.FormFreedomRequestResource : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDescriptionHeritage", (formFreedom.FormFreedomDescriptionHeritage != null) ? formFreedom.FormFreedomDescriptionHeritage : (object)DBNull.Value),
			new SqlParameter("@FormFreedomUser1FullName", (formFreedom.FormFreedomUser1FullName != null) ? formFreedom.FormFreedomUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormFreedomPhoneNumber", (formFreedom.FormFreedomPhoneNumber != null) ? formFreedom.FormFreedomPhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormFreedomUttererRole", (formFreedom.FormFreedomUttererRole != null) ? formFreedom.FormFreedomUttererRole : (object)DBNull.Value),
			new SqlParameter("@FormFreedomHeirsCertificateNumber", (formFreedom.FormFreedomHeirsCertificateNumber != null) ? formFreedom.FormFreedomHeirsCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormFreedomHeirsCertificateSource", (formFreedom.FormFreedomHeirsCertificateSource != null) ? formFreedom.FormFreedomHeirsCertificateSource : (object)DBNull.Value),
			new SqlParameter("@FormFreedomHeirsCertificateBranch", (formFreedom.FormFreedomHeirsCertificateBranch != null) ? formFreedom.FormFreedomHeirsCertificateBranch : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDeadIssuanceCity", (formFreedom.FormFreedomDeadIssuanceCity != null) ? formFreedom.FormFreedomDeadIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDeclarationRegisterNumber", (formFreedom.FormFreedomDeclarationRegisterNumber != null) ? formFreedom.FormFreedomDeclarationRegisterNumber : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDiagnosisNumber", (formFreedom.FormFreedomDiagnosisNumber != null) ? formFreedom.FormFreedomDiagnosisNumber : (object)DBNull.Value),
			new SqlParameter("@FormFreedomCourt", (formFreedom.FormFreedomCourt != null) ? formFreedom.FormFreedomCourt : (object)DBNull.Value),
			new SqlParameter("@FormFreedomBranch", (formFreedom.FormFreedomBranch != null) ? formFreedom.FormFreedomBranch : (object)DBNull.Value),
			new SqlParameter("@FormFreedomUser2FullName", (formFreedom.FormFreedomUser2FullName != null) ? formFreedom.FormFreedomUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormFreedomApplicantIssuanceCity", (formFreedom.FormFreedomApplicantIssuanceCity != null) ? formFreedom.FormFreedomApplicantIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormFreedomCommercialNumber", (formFreedom.FormFreedomCommercialNumber != null) ? formFreedom.FormFreedomCommercialNumber : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDeadFullName", (formFreedom.FormFreedomDeadFullName != null) ? formFreedom.FormFreedomDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDeadFatherName", (formFreedom.FormFreedomDeadFatherName != null) ? formFreedom.FormFreedomDeadFatherName : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDeadDeathCity", (formFreedom.FormFreedomDeadDeathCity != null) ? formFreedom.FormFreedomDeadDeathCity : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDeadCertificateNumber", (formFreedom.FormFreedomDeadCertificateNumber != null) ? formFreedom.FormFreedomDeadCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormFreedomRequestNumber", (formFreedom.FormFreedomRequestNumber != null) ? formFreedom.FormFreedomRequestNumber : (object)DBNull.Value),
			new SqlParameter("@FormFreedomAddress", (formFreedom.FormFreedomAddress != null) ? formFreedom.FormFreedomAddress : (object)DBNull.Value),
			new SqlParameter("@FormFreedomApplicantFullName", (formFreedom.FormFreedomApplicantFullName != null) ? formFreedom.FormFreedomApplicantFullName : (object)DBNull.Value),
			new SqlParameter("@FormFreedomApplicantFatherName", (formFreedom.FormFreedomApplicantFatherName != null) ? formFreedom.FormFreedomApplicantFatherName : (object)DBNull.Value),
			new SqlParameter("@FormFreedomApplicantBirthCity", (formFreedom.FormFreedomApplicantBirthCity != null) ? formFreedom.FormFreedomApplicantBirthCity : (object)DBNull.Value),
			new SqlParameter("@FormFreedomApplicantCertificateNumber", (formFreedom.FormFreedomApplicantCertificateNumber != null) ? formFreedom.FormFreedomApplicantCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormFreedomTaxOfficeCode", (formFreedom.FormFreedomTaxOfficeCode != null) ? formFreedom.FormFreedomTaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@FormFreedomTaxGroupCode", (formFreedom.FormFreedomTaxGroupCode != null) ? formFreedom.FormFreedomTaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormFreedomTaxUnitCode", (formFreedom.FormFreedomTaxUnitCode != null) ? formFreedom.FormFreedomTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormFreedomUser1Code", (formFreedom.FormFreedomUser1Code != null) ? formFreedom.FormFreedomUser1Code : (object)DBNull.Value),
			new SqlParameter("@FormFreedomUser2Code", (formFreedom.FormFreedomUser2Code != null) ? formFreedom.FormFreedomUser2Code : (object)DBNull.Value)
		};
		formFreedom.FormFreedomID = SqlDBHelper.ExecuteScalar("FormFreedom_Insert", CommandType.StoredProcedure, parametersFormFreedom);
		return formFreedom.FormFreedomID;
	}

	public bool Update(FormFreedom formFreedom)
	{
		SqlParameter[] parametersFormFreedom = new SqlParameter[]
		{
			new SqlParameter("@FormFreedomID", formFreedom.FormFreedomID),
			new SqlParameter("@FormFreedomDeclarationID", formFreedom.FormFreedomDeclarationID),
			new SqlParameter("@FormFreedomRegisterInformationID", (formFreedom.FormFreedomRegisterInformationID != null && formFreedom.FormFreedomRegisterInformationID >0 ) ? formFreedom.FormFreedomRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormFreedomApplicantNationalCode", (formFreedom.FormFreedomApplicantNationalCode != null) ? formFreedom.FormFreedomApplicantNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormFreedomZipCode", (formFreedom.FormFreedomZipCode != null) ? formFreedom.FormFreedomZipCode : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDeadNationalCode", (formFreedom.FormFreedomDeadNationalCode != null) ? formFreedom.FormFreedomDeadNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormFreedomRegisterDate", (formFreedom.FormFreedomRegisterDate != null) ? formFreedom.FormFreedomRegisterDate : (object)DBNull.Value),
			new SqlParameter("@FormFreedomRequestDate", (formFreedom.FormFreedomRequestDate != null) ? formFreedom.FormFreedomRequestDate : (object)DBNull.Value),
			new SqlParameter("@FormFreedomApplicantBirthDate", (formFreedom.FormFreedomApplicantBirthDate != null) ? formFreedom.FormFreedomApplicantBirthDate : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDeadDeathDate", (formFreedom.FormFreedomDeadDeathDate != null) ? formFreedom.FormFreedomDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDeclarationRegisterDate", (formFreedom.FormFreedomDeclarationRegisterDate != null) ? formFreedom.FormFreedomDeclarationRegisterDate : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDiagnosisDate", (formFreedom.FormFreedomDiagnosisDate != null) ? formFreedom.FormFreedomDiagnosisDate : (object)DBNull.Value),
			new SqlParameter("@FormFreedomHeirsCertificateDate", (formFreedom.FormFreedomHeirsCertificateDate != null) ? formFreedom.FormFreedomHeirsCertificateDate : (object)DBNull.Value),
			new SqlParameter("@FormFreedomTaxOfficeTitle", (formFreedom.FormFreedomTaxOfficeTitle != null) ? formFreedom.FormFreedomTaxOfficeTitle : (object)DBNull.Value),
			new SqlParameter("@FormFreedomTaxOfficeAddress", (formFreedom.FormFreedomTaxOfficeAddress != null) ? formFreedom.FormFreedomTaxOfficeAddress : (object)DBNull.Value),
			new SqlParameter("@FormFreedomTaxOfficePhoneNumber", (formFreedom.FormFreedomTaxOfficePhoneNumber != null) ? formFreedom.FormFreedomTaxOfficePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormFreedomTaxOfficeZipCode", (formFreedom.FormFreedomTaxOfficeZipCode != null) ? formFreedom.FormFreedomTaxOfficeZipCode : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDossierClasses", (formFreedom.FormFreedomDossierClasses != null) ? formFreedom.FormFreedomDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormFreedomRequestResource", (formFreedom.FormFreedomRequestResource != null) ? formFreedom.FormFreedomRequestResource : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDescriptionHeritage", (formFreedom.FormFreedomDescriptionHeritage != null) ? formFreedom.FormFreedomDescriptionHeritage : (object)DBNull.Value),
			new SqlParameter("@FormFreedomUser1FullName", (formFreedom.FormFreedomUser1FullName != null) ? formFreedom.FormFreedomUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormFreedomPhoneNumber", (formFreedom.FormFreedomPhoneNumber != null) ? formFreedom.FormFreedomPhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormFreedomUttererRole", (formFreedom.FormFreedomUttererRole != null) ? formFreedom.FormFreedomUttererRole : (object)DBNull.Value),
			new SqlParameter("@FormFreedomHeirsCertificateNumber", (formFreedom.FormFreedomHeirsCertificateNumber != null) ? formFreedom.FormFreedomHeirsCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormFreedomHeirsCertificateSource", (formFreedom.FormFreedomHeirsCertificateSource != null) ? formFreedom.FormFreedomHeirsCertificateSource : (object)DBNull.Value),
			new SqlParameter("@FormFreedomHeirsCertificateBranch", (formFreedom.FormFreedomHeirsCertificateBranch != null) ? formFreedom.FormFreedomHeirsCertificateBranch : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDeadIssuanceCity", (formFreedom.FormFreedomDeadIssuanceCity != null) ? formFreedom.FormFreedomDeadIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDeclarationRegisterNumber", (formFreedom.FormFreedomDeclarationRegisterNumber != null) ? formFreedom.FormFreedomDeclarationRegisterNumber : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDiagnosisNumber", (formFreedom.FormFreedomDiagnosisNumber != null) ? formFreedom.FormFreedomDiagnosisNumber : (object)DBNull.Value),
			new SqlParameter("@FormFreedomCourt", (formFreedom.FormFreedomCourt != null) ? formFreedom.FormFreedomCourt : (object)DBNull.Value),
			new SqlParameter("@FormFreedomBranch", (formFreedom.FormFreedomBranch != null) ? formFreedom.FormFreedomBranch : (object)DBNull.Value),
			new SqlParameter("@FormFreedomUser2FullName", (formFreedom.FormFreedomUser2FullName != null) ? formFreedom.FormFreedomUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormFreedomApplicantIssuanceCity", (formFreedom.FormFreedomApplicantIssuanceCity != null) ? formFreedom.FormFreedomApplicantIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormFreedomCommercialNumber", (formFreedom.FormFreedomCommercialNumber != null) ? formFreedom.FormFreedomCommercialNumber : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDeadFullName", (formFreedom.FormFreedomDeadFullName != null) ? formFreedom.FormFreedomDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDeadFatherName", (formFreedom.FormFreedomDeadFatherName != null) ? formFreedom.FormFreedomDeadFatherName : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDeadDeathCity", (formFreedom.FormFreedomDeadDeathCity != null) ? formFreedom.FormFreedomDeadDeathCity : (object)DBNull.Value),
			new SqlParameter("@FormFreedomDeadCertificateNumber", (formFreedom.FormFreedomDeadCertificateNumber != null) ? formFreedom.FormFreedomDeadCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormFreedomRequestNumber", (formFreedom.FormFreedomRequestNumber != null) ? formFreedom.FormFreedomRequestNumber : (object)DBNull.Value),
			new SqlParameter("@FormFreedomAddress", (formFreedom.FormFreedomAddress != null) ? formFreedom.FormFreedomAddress : (object)DBNull.Value),
			new SqlParameter("@FormFreedomApplicantFullName", (formFreedom.FormFreedomApplicantFullName != null) ? formFreedom.FormFreedomApplicantFullName : (object)DBNull.Value),
			new SqlParameter("@FormFreedomApplicantFatherName", (formFreedom.FormFreedomApplicantFatherName != null) ? formFreedom.FormFreedomApplicantFatherName : (object)DBNull.Value),
			new SqlParameter("@FormFreedomApplicantBirthCity", (formFreedom.FormFreedomApplicantBirthCity != null) ? formFreedom.FormFreedomApplicantBirthCity : (object)DBNull.Value),
			new SqlParameter("@FormFreedomApplicantCertificateNumber", (formFreedom.FormFreedomApplicantCertificateNumber != null) ? formFreedom.FormFreedomApplicantCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormFreedomTaxOfficeCode", (formFreedom.FormFreedomTaxOfficeCode != null) ? formFreedom.FormFreedomTaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@FormFreedomTaxGroupCode", (formFreedom.FormFreedomTaxGroupCode != null) ? formFreedom.FormFreedomTaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormFreedomTaxUnitCode", (formFreedom.FormFreedomTaxUnitCode != null) ? formFreedom.FormFreedomTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormFreedomUser1Code", (formFreedom.FormFreedomUser1Code != null) ? formFreedom.FormFreedomUser1Code : (object)DBNull.Value),
			new SqlParameter("@FormFreedomUser2Code", (formFreedom.FormFreedomUser2Code != null) ? formFreedom.FormFreedomUser2Code : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormFreedom_Update", CommandType.StoredProcedure, parametersFormFreedom);
	}

	public bool Delete(Int64 formFreedomID)
	{
		SqlParameter[] parametersFormFreedom = new SqlParameter[]
		{
			new SqlParameter("@FormFreedomID", formFreedomID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormFreedom_Delete", CommandType.StoredProcedure, parametersFormFreedom);
	}

	public FormFreedom GetDetails(Int64 formFreedomID)
	{
		FormFreedom formFreedom = new FormFreedom();

		SqlParameter[] parametersFormFreedom = new SqlParameter[]
		{
			new SqlParameter("@FormFreedomID", formFreedomID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormFreedom_GetDetails", CommandType.StoredProcedure, parametersFormFreedom))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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
			}
		}

		return formFreedom;
	}

	public List<FormFreedom> GetListAll()
	{
		List<FormFreedom> listFormFreedom = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormFreedom_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormFreedom = new List<FormFreedom>();

				foreach (DataRow row in table.Rows)
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
					listFormFreedom.Add(formFreedom);
				}
			}
		}

		return listFormFreedom;
	}

	public bool Exists(Int64 formFreedomID)
	{
		SqlParameter[] parametersFormFreedom = new SqlParameter[]
		{
			new SqlParameter("@FormFreedomID", formFreedomID)
		};
		return (SqlDBHelper.ExecuteScalar("FormFreedom_Exists", CommandType.StoredProcedure, parametersFormFreedom)>0);
	}

	public bool Exists(FormFreedom formFreedom)
	{
		SqlParameter[] parametersFormFreedom = new SqlParameter[]
		{
			new SqlParameter("@FormFreedomID", formFreedom.FormFreedomID)
		};
		return (SqlDBHelper.ExecuteScalar("FormFreedom_Exists", CommandType.StoredProcedure, parametersFormFreedom)>0);
	}

	public List<FormFreedom> SearchLike(FormFreedom formFreedom)
	{
		List<FormFreedom> listFormFreedom = new List<FormFreedom>();


		SqlParameter[] parametersFormFreedom = new SqlParameter[]
		{
			new SqlParameter("@FormFreedomID", formFreedom.FormFreedomID),
			new SqlParameter("@FormFreedomDeclarationID", formFreedom.FormFreedomDeclarationID),
			new SqlParameter("@FormFreedomRegisterInformationID", formFreedom.FormFreedomRegisterInformationID),
			new SqlParameter("@FormFreedomApplicantNationalCode", formFreedom.FormFreedomApplicantNationalCode),
			new SqlParameter("@FormFreedomZipCode", formFreedom.FormFreedomZipCode),
			new SqlParameter("@FormFreedomDeadNationalCode", formFreedom.FormFreedomDeadNationalCode),
			new SqlParameter("@FormFreedomRegisterDate", formFreedom.FormFreedomRegisterDate),
			new SqlParameter("@FormFreedomRequestDate", formFreedom.FormFreedomRequestDate),
			new SqlParameter("@FormFreedomApplicantBirthDate", formFreedom.FormFreedomApplicantBirthDate),
			new SqlParameter("@FormFreedomDeadDeathDate", formFreedom.FormFreedomDeadDeathDate),
			new SqlParameter("@FormFreedomDeclarationRegisterDate", formFreedom.FormFreedomDeclarationRegisterDate),
			new SqlParameter("@FormFreedomDiagnosisDate", formFreedom.FormFreedomDiagnosisDate),
			new SqlParameter("@FormFreedomHeirsCertificateDate", formFreedom.FormFreedomHeirsCertificateDate),
			new SqlParameter("@FormFreedomTaxOfficeTitle", formFreedom.FormFreedomTaxOfficeTitle),
			new SqlParameter("@FormFreedomTaxOfficeAddress", formFreedom.FormFreedomTaxOfficeAddress),
			new SqlParameter("@FormFreedomTaxOfficePhoneNumber", formFreedom.FormFreedomTaxOfficePhoneNumber),
			new SqlParameter("@FormFreedomTaxOfficeZipCode", formFreedom.FormFreedomTaxOfficeZipCode),
			new SqlParameter("@FormFreedomDossierClasses", formFreedom.FormFreedomDossierClasses),
			new SqlParameter("@FormFreedomRequestResource", formFreedom.FormFreedomRequestResource),
			new SqlParameter("@FormFreedomDescriptionHeritage", formFreedom.FormFreedomDescriptionHeritage),
			new SqlParameter("@FormFreedomUser1FullName", formFreedom.FormFreedomUser1FullName),
			new SqlParameter("@FormFreedomPhoneNumber", formFreedom.FormFreedomPhoneNumber),
			new SqlParameter("@FormFreedomUttererRole", formFreedom.FormFreedomUttererRole),
			new SqlParameter("@FormFreedomHeirsCertificateNumber", formFreedom.FormFreedomHeirsCertificateNumber),
			new SqlParameter("@FormFreedomHeirsCertificateSource", formFreedom.FormFreedomHeirsCertificateSource),
			new SqlParameter("@FormFreedomHeirsCertificateBranch", formFreedom.FormFreedomHeirsCertificateBranch),
			new SqlParameter("@FormFreedomDeadIssuanceCity", formFreedom.FormFreedomDeadIssuanceCity),
			new SqlParameter("@FormFreedomDeclarationRegisterNumber", formFreedom.FormFreedomDeclarationRegisterNumber),
			new SqlParameter("@FormFreedomDiagnosisNumber", formFreedom.FormFreedomDiagnosisNumber),
			new SqlParameter("@FormFreedomCourt", formFreedom.FormFreedomCourt),
			new SqlParameter("@FormFreedomBranch", formFreedom.FormFreedomBranch),
			new SqlParameter("@FormFreedomUser2FullName", formFreedom.FormFreedomUser2FullName),
			new SqlParameter("@FormFreedomApplicantIssuanceCity", formFreedom.FormFreedomApplicantIssuanceCity),
			new SqlParameter("@FormFreedomCommercialNumber", formFreedom.FormFreedomCommercialNumber),
			new SqlParameter("@FormFreedomDeadFullName", formFreedom.FormFreedomDeadFullName),
			new SqlParameter("@FormFreedomDeadFatherName", formFreedom.FormFreedomDeadFatherName),
			new SqlParameter("@FormFreedomDeadDeathCity", formFreedom.FormFreedomDeadDeathCity),
			new SqlParameter("@FormFreedomDeadCertificateNumber", formFreedom.FormFreedomDeadCertificateNumber),
			new SqlParameter("@FormFreedomRequestNumber", formFreedom.FormFreedomRequestNumber),
			new SqlParameter("@FormFreedomAddress", formFreedom.FormFreedomAddress),
			new SqlParameter("@FormFreedomApplicantFullName", formFreedom.FormFreedomApplicantFullName),
			new SqlParameter("@FormFreedomApplicantFatherName", formFreedom.FormFreedomApplicantFatherName),
			new SqlParameter("@FormFreedomApplicantBirthCity", formFreedom.FormFreedomApplicantBirthCity),
			new SqlParameter("@FormFreedomApplicantCertificateNumber", formFreedom.FormFreedomApplicantCertificateNumber),
			new SqlParameter("@FormFreedomTaxOfficeCode", formFreedom.FormFreedomTaxOfficeCode),
			new SqlParameter("@FormFreedomTaxGroupCode", formFreedom.FormFreedomTaxGroupCode),
			new SqlParameter("@FormFreedomTaxUnitCode", formFreedom.FormFreedomTaxUnitCode),
			new SqlParameter("@FormFreedomUser1Code", formFreedom.FormFreedomUser1Code),
			new SqlParameter("@FormFreedomUser2Code", formFreedom.FormFreedomUser2Code),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormFreedom_SearchLike", CommandType.StoredProcedure, parametersFormFreedom))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormFreedom tmpFormFreedom = new FormFreedom();
					tmpFormFreedom.FormFreedomID = (row["FormFreedomID"] != DBNull.Value) ? Convert.ToInt64(row["FormFreedomID"]) : 0 ;
					tmpFormFreedom.FormFreedomDeclarationID = (row["FormFreedomDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormFreedomDeclarationID"]) : 0 ;
					tmpFormFreedom.FormFreedomRegisterInformationID = (row["FormFreedomRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormFreedomRegisterInformationID"]) : 0 ;
					tmpFormFreedom.FormFreedomApplicantNationalCode = (row["FormFreedomApplicantNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormFreedomApplicantNationalCode"]) : 0 ;
					tmpFormFreedom.FormFreedomZipCode = (row["FormFreedomZipCode"] != DBNull.Value) ? Convert.ToInt64(row["FormFreedomZipCode"]) : 0 ;
					tmpFormFreedom.FormFreedomDeadNationalCode = (row["FormFreedomDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormFreedomDeadNationalCode"]) : 0 ;
					tmpFormFreedom.FormFreedomRegisterDate = row["FormFreedomRegisterDate"].ToString();
					tmpFormFreedom.FormFreedomRequestDate = row["FormFreedomRequestDate"].ToString();
					tmpFormFreedom.FormFreedomApplicantBirthDate = row["FormFreedomApplicantBirthDate"].ToString();
					tmpFormFreedom.FormFreedomDeadDeathDate = row["FormFreedomDeadDeathDate"].ToString();
					tmpFormFreedom.FormFreedomDeclarationRegisterDate = row["FormFreedomDeclarationRegisterDate"].ToString();
					tmpFormFreedom.FormFreedomDiagnosisDate = row["FormFreedomDiagnosisDate"].ToString();
					tmpFormFreedom.FormFreedomHeirsCertificateDate = row["FormFreedomHeirsCertificateDate"].ToString();
					tmpFormFreedom.FormFreedomTaxOfficeTitle = row["FormFreedomTaxOfficeTitle"].ToString();
					tmpFormFreedom.FormFreedomTaxOfficeAddress = row["FormFreedomTaxOfficeAddress"].ToString();
					tmpFormFreedom.FormFreedomTaxOfficePhoneNumber = row["FormFreedomTaxOfficePhoneNumber"].ToString();
					tmpFormFreedom.FormFreedomTaxOfficeZipCode = row["FormFreedomTaxOfficeZipCode"].ToString();
					tmpFormFreedom.FormFreedomDossierClasses = row["FormFreedomDossierClasses"].ToString();
					tmpFormFreedom.FormFreedomRequestResource = row["FormFreedomRequestResource"].ToString();
					tmpFormFreedom.FormFreedomDescriptionHeritage = row["FormFreedomDescriptionHeritage"].ToString();
					tmpFormFreedom.FormFreedomUser1FullName = row["FormFreedomUser1FullName"].ToString();
					tmpFormFreedom.FormFreedomPhoneNumber = row["FormFreedomPhoneNumber"].ToString();
					tmpFormFreedom.FormFreedomUttererRole = row["FormFreedomUttererRole"].ToString();
					tmpFormFreedom.FormFreedomHeirsCertificateNumber = row["FormFreedomHeirsCertificateNumber"].ToString();
					tmpFormFreedom.FormFreedomHeirsCertificateSource = row["FormFreedomHeirsCertificateSource"].ToString();
					tmpFormFreedom.FormFreedomHeirsCertificateBranch = row["FormFreedomHeirsCertificateBranch"].ToString();
					tmpFormFreedom.FormFreedomDeadIssuanceCity = row["FormFreedomDeadIssuanceCity"].ToString();
					tmpFormFreedom.FormFreedomDeclarationRegisterNumber = row["FormFreedomDeclarationRegisterNumber"].ToString();
					tmpFormFreedom.FormFreedomDiagnosisNumber = row["FormFreedomDiagnosisNumber"].ToString();
					tmpFormFreedom.FormFreedomCourt = row["FormFreedomCourt"].ToString();
					tmpFormFreedom.FormFreedomBranch = row["FormFreedomBranch"].ToString();
					tmpFormFreedom.FormFreedomUser2FullName = row["FormFreedomUser2FullName"].ToString();
					tmpFormFreedom.FormFreedomApplicantIssuanceCity = row["FormFreedomApplicantIssuanceCity"].ToString();
					tmpFormFreedom.FormFreedomCommercialNumber = row["FormFreedomCommercialNumber"].ToString();
					tmpFormFreedom.FormFreedomDeadFullName = row["FormFreedomDeadFullName"].ToString();
					tmpFormFreedom.FormFreedomDeadFatherName = row["FormFreedomDeadFatherName"].ToString();
					tmpFormFreedom.FormFreedomDeadDeathCity = row["FormFreedomDeadDeathCity"].ToString();
					tmpFormFreedom.FormFreedomDeadCertificateNumber = row["FormFreedomDeadCertificateNumber"].ToString();
					tmpFormFreedom.FormFreedomRequestNumber = row["FormFreedomRequestNumber"].ToString();
					tmpFormFreedom.FormFreedomAddress = row["FormFreedomAddress"].ToString();
					tmpFormFreedom.FormFreedomApplicantFullName = row["FormFreedomApplicantFullName"].ToString();
					tmpFormFreedom.FormFreedomApplicantFatherName = row["FormFreedomApplicantFatherName"].ToString();
					tmpFormFreedom.FormFreedomApplicantBirthCity = row["FormFreedomApplicantBirthCity"].ToString();
					tmpFormFreedom.FormFreedomApplicantCertificateNumber = row["FormFreedomApplicantCertificateNumber"].ToString();
					tmpFormFreedom.FormFreedomTaxOfficeCode = (row["FormFreedomTaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["FormFreedomTaxOfficeCode"]) : 0 ;
					tmpFormFreedom.FormFreedomTaxGroupCode = (row["FormFreedomTaxGroupCode"] != DBNull.Value) ? Convert.ToInt32(row["FormFreedomTaxGroupCode"]) : 0 ;
					tmpFormFreedom.FormFreedomTaxUnitCode = (row["FormFreedomTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["FormFreedomTaxUnitCode"]) : 0 ;
					tmpFormFreedom.FormFreedomUser1Code = (row["FormFreedomUser1Code"] != DBNull.Value) ? Convert.ToInt32(row["FormFreedomUser1Code"]) : 0 ;
					tmpFormFreedom.FormFreedomUser2Code = (row["FormFreedomUser2Code"] != DBNull.Value) ? Convert.ToInt32(row["FormFreedomUser2Code"]) : 0 ;

					listFormFreedom.Add(tmpFormFreedom);
				}
			}
		}

		return listFormFreedom;
	}

}
}
