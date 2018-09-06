using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormTaxPaymentCertificateDBAccess
{


	public Int64 Insert(FormTaxPaymentCertificate formTaxPaymentCertificate)
	{
		SqlParameter[] parametersFormTaxPaymentCertificate = new SqlParameter[]
		{
			new SqlParameter("@FormTaxPayementCertificateDeathMounth", (formTaxPaymentCertificate.FormTaxPayementCertificateDeathMounth != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeathMounth : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeathYear", (formTaxPaymentCertificate.FormTaxPayementCertificateDeathYear != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeathYear : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeathCity", (formTaxPaymentCertificate.FormTaxPayementCertificateDeathCity != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeathCity : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDescription1", (formTaxPaymentCertificate.FormTaxPayementCertificateDescription1 != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDescription1 : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDescription2", (formTaxPaymentCertificate.FormTaxPayementCertificateDescription2 != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDescription2 : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDescription3", (formTaxPaymentCertificate.FormTaxPayementCertificateDescription3 != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDescription3 : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateHeirsCertificateSource", (formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateSource != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateSource : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateHeirsCertificateBranch", (formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateBranch != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateBranch : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeadName", (formTaxPaymentCertificate.FormTaxPayementCertificateDeadName != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeadName : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeadLastName", (formTaxPaymentCertificate.FormTaxPayementCertificateDeadLastName != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeadLastName : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeadCertificateNumber", (formTaxPaymentCertificate.FormTaxPayementCertificateDeadCertificateNumber != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeadCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeathDay", (formTaxPaymentCertificate.FormTaxPayementCertificateDeathDay != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeathDay : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateIssuanceCity", (formTaxPaymentCertificate.FormTaxPayementCertificateIssuanceCity != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeclarationRequestNumber", (formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestNumber != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestNumber : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeclarationRequestResource", (formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestResource != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestResource : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateApplicantFullName", (formTaxPaymentCertificate.FormTaxPayementCertificateApplicantFullName != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateApplicantFullName : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateApplicantFatherName", (formTaxPaymentCertificate.FormTaxPayementCertificateApplicantFatherName != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateApplicantFatherName : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDescription4", (formTaxPaymentCertificate.FormTaxPayementCertificateDescription4 != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDescription4 : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDescriptionHeritage", (formTaxPaymentCertificate.FormTaxPayementCertificateDescriptionHeritage != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDescriptionHeritage : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateRequestNumber", (formTaxPaymentCertificate.FormTaxPayementCertificateRequestNumber != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateRequestNumber : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateUser1FullName", (formTaxPaymentCertificate.FormTaxPayementCertificateUser1FullName != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateUser2FullName", (formTaxPaymentCertificate.FormTaxPayementCertificateUser2FullName != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateRegisterInformationID", (formTaxPaymentCertificate.FormTaxPayementCertificateRegisterInformationID > 0) ? formTaxPaymentCertificate.FormTaxPayementCertificateRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeadNationalCode", (formTaxPaymentCertificate.FormTaxPayementCertificateDeadNationalCode != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeadNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeclarationID", (formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationID > 0) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateTaxOfficeZipCode", (formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeZipCode != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeZipCode : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateApplicantNationalCode", (formTaxPaymentCertificate.FormTaxPayementCertificateApplicantNationalCode != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateApplicantNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateZipCode", (formTaxPaymentCertificate.FormTaxPayementCertificateZipCode != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateZipCode : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateApplicantName", (formTaxPaymentCertificate.FormTaxPayementCertificateApplicantName != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateApplicantName : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateRegisterDate", (formTaxPaymentCertificate.FormTaxPayementCertificateRegisterDate != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateRegisterDate : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateHeirsCertificateDate", (formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateDate != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateDate : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateRequestDate", (formTaxPaymentCertificate.FormTaxPayementCertificateRequestDate != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateRequestDate : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeclarationRequestDate", (formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestDate != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestDate : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateApplicantBirthDate", (formTaxPaymentCertificate.FormTaxPayementCertificateApplicantBirthDate != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateApplicantBirthDate : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDossierClasses", (formTaxPaymentCertificate.FormTaxPayementCertificateDossierClasses != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateTaxOfficeTitle", (formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeTitle != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeTitle : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateTaxOfficeCity", (formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeCity != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeCity : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateTaxOfficeAddress", (formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeAddress != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeAddress : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateTaxOfficePhoneNumber", (formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficePhoneNumber != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateHeirsCertificateNumber", (formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateNumber != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeadFatherName", (formTaxPaymentCertificate.FormTaxPayementCertificateDeadFatherName != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeadFatherName : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificatePhoneNumber", (formTaxPaymentCertificate.FormTaxPayementCertificatePhoneNumber != null) ? formTaxPaymentCertificate.FormTaxPayementCertificatePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeadIssuanceCity", (formTaxPaymentCertificate.FormTaxPayementCertificateDeadIssuanceCity != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeadIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateApplicantBirthCity", (formTaxPaymentCertificate.FormTaxPayementCertificateApplicantBirthCity != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateApplicantBirthCity : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateApplicantCertificateNumber", (formTaxPaymentCertificate.FormTaxPayementCertificateApplicantCertificateNumber != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateApplicantCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateApplicantIssuanceCity", (formTaxPaymentCertificate.FormTaxPayementCertificateApplicantIssuanceCity != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateApplicantIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateApplicantRole", (formTaxPaymentCertificate.FormTaxPayementCertificateApplicantRole != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateApplicantRole : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateAddress", (formTaxPaymentCertificate.FormTaxPayementCertificateAddress != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateAddress : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateCommercialNumer", (formTaxPaymentCertificate.FormTaxPayementCertificateCommercialNumer != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateCommercialNumer : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateTaxOfficeCode", (formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeCode != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateTaxGroupCode", (formTaxPaymentCertificate.FormTaxPayementCertificateTaxGroupCode != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateTaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateTaxUnitCode", (formTaxPaymentCertificate.FormTaxPayementCertificateTaxUnitCode != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateTaxUnitCode : (object)DBNull.Value)
		};
		formTaxPaymentCertificate.FormTaxPayementCertificateID = SqlDBHelper.ExecuteScalar("FormTaxPaymentCertificate_Insert", CommandType.StoredProcedure, parametersFormTaxPaymentCertificate);
		return formTaxPaymentCertificate.FormTaxPayementCertificateID;
	}

	public bool Update(FormTaxPaymentCertificate formTaxPaymentCertificate)
	{
		SqlParameter[] parametersFormTaxPaymentCertificate = new SqlParameter[]
		{
			new SqlParameter("@FormTaxPayementCertificateID", formTaxPaymentCertificate.FormTaxPayementCertificateID),
			new SqlParameter("@FormTaxPayementCertificateDeathMounth", (formTaxPaymentCertificate.FormTaxPayementCertificateDeathMounth != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeathMounth : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeathYear", (formTaxPaymentCertificate.FormTaxPayementCertificateDeathYear != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeathYear : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeathCity", (formTaxPaymentCertificate.FormTaxPayementCertificateDeathCity != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeathCity : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDescription1", (formTaxPaymentCertificate.FormTaxPayementCertificateDescription1 != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDescription1 : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDescription2", (formTaxPaymentCertificate.FormTaxPayementCertificateDescription2 != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDescription2 : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDescription3", (formTaxPaymentCertificate.FormTaxPayementCertificateDescription3 != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDescription3 : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateHeirsCertificateSource", (formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateSource != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateSource : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateHeirsCertificateBranch", (formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateBranch != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateBranch : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeadName", (formTaxPaymentCertificate.FormTaxPayementCertificateDeadName != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeadName : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeadLastName", (formTaxPaymentCertificate.FormTaxPayementCertificateDeadLastName != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeadLastName : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeadCertificateNumber", (formTaxPaymentCertificate.FormTaxPayementCertificateDeadCertificateNumber != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeadCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeathDay", (formTaxPaymentCertificate.FormTaxPayementCertificateDeathDay != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeathDay : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateIssuanceCity", (formTaxPaymentCertificate.FormTaxPayementCertificateIssuanceCity != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeclarationRequestNumber", (formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestNumber != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestNumber : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeclarationRequestResource", (formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestResource != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestResource : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateApplicantFullName", (formTaxPaymentCertificate.FormTaxPayementCertificateApplicantFullName != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateApplicantFullName : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateApplicantFatherName", (formTaxPaymentCertificate.FormTaxPayementCertificateApplicantFatherName != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateApplicantFatherName : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDescription4", (formTaxPaymentCertificate.FormTaxPayementCertificateDescription4 != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDescription4 : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDescriptionHeritage", (formTaxPaymentCertificate.FormTaxPayementCertificateDescriptionHeritage != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDescriptionHeritage : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateRequestNumber", (formTaxPaymentCertificate.FormTaxPayementCertificateRequestNumber != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateRequestNumber : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateUser1FullName", (formTaxPaymentCertificate.FormTaxPayementCertificateUser1FullName != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateUser2FullName", (formTaxPaymentCertificate.FormTaxPayementCertificateUser2FullName != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateRegisterInformationID", (formTaxPaymentCertificate.FormTaxPayementCertificateRegisterInformationID != null && formTaxPaymentCertificate.FormTaxPayementCertificateRegisterInformationID >0 ) ? formTaxPaymentCertificate.FormTaxPayementCertificateRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeadNationalCode", (formTaxPaymentCertificate.FormTaxPayementCertificateDeadNationalCode != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeadNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeclarationID", (formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationID != null && formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationID >0 ) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateTaxOfficeZipCode", (formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeZipCode != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeZipCode : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateApplicantNationalCode", (formTaxPaymentCertificate.FormTaxPayementCertificateApplicantNationalCode != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateApplicantNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateZipCode", (formTaxPaymentCertificate.FormTaxPayementCertificateZipCode != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateZipCode : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateApplicantName", (formTaxPaymentCertificate.FormTaxPayementCertificateApplicantName != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateApplicantName : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateRegisterDate", (formTaxPaymentCertificate.FormTaxPayementCertificateRegisterDate != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateRegisterDate : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateHeirsCertificateDate", (formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateDate != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateDate : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateRequestDate", (formTaxPaymentCertificate.FormTaxPayementCertificateRequestDate != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateRequestDate : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeclarationRequestDate", (formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestDate != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestDate : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateApplicantBirthDate", (formTaxPaymentCertificate.FormTaxPayementCertificateApplicantBirthDate != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateApplicantBirthDate : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDossierClasses", (formTaxPaymentCertificate.FormTaxPayementCertificateDossierClasses != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateTaxOfficeTitle", (formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeTitle != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeTitle : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateTaxOfficeCity", (formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeCity != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeCity : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateTaxOfficeAddress", (formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeAddress != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeAddress : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateTaxOfficePhoneNumber", (formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficePhoneNumber != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateHeirsCertificateNumber", (formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateNumber != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeadFatherName", (formTaxPaymentCertificate.FormTaxPayementCertificateDeadFatherName != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeadFatherName : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificatePhoneNumber", (formTaxPaymentCertificate.FormTaxPayementCertificatePhoneNumber != null) ? formTaxPaymentCertificate.FormTaxPayementCertificatePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateDeadIssuanceCity", (formTaxPaymentCertificate.FormTaxPayementCertificateDeadIssuanceCity != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateDeadIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateApplicantBirthCity", (formTaxPaymentCertificate.FormTaxPayementCertificateApplicantBirthCity != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateApplicantBirthCity : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateApplicantCertificateNumber", (formTaxPaymentCertificate.FormTaxPayementCertificateApplicantCertificateNumber != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateApplicantCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateApplicantIssuanceCity", (formTaxPaymentCertificate.FormTaxPayementCertificateApplicantIssuanceCity != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateApplicantIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateApplicantRole", (formTaxPaymentCertificate.FormTaxPayementCertificateApplicantRole != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateApplicantRole : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateAddress", (formTaxPaymentCertificate.FormTaxPayementCertificateAddress != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateAddress : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateCommercialNumer", (formTaxPaymentCertificate.FormTaxPayementCertificateCommercialNumer != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateCommercialNumer : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateTaxOfficeCode", (formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeCode != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateTaxGroupCode", (formTaxPaymentCertificate.FormTaxPayementCertificateTaxGroupCode != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateTaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormTaxPayementCertificateTaxUnitCode", (formTaxPaymentCertificate.FormTaxPayementCertificateTaxUnitCode != null) ? formTaxPaymentCertificate.FormTaxPayementCertificateTaxUnitCode : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormTaxPaymentCertificate_Update", CommandType.StoredProcedure, parametersFormTaxPaymentCertificate);
	}

	public bool Delete(Int64 formTaxPayementCertificateID)
	{
		SqlParameter[] parametersFormTaxPaymentCertificate = new SqlParameter[]
		{
			new SqlParameter("@FormTaxPayementCertificateID", formTaxPayementCertificateID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormTaxPaymentCertificate_Delete", CommandType.StoredProcedure, parametersFormTaxPaymentCertificate);
	}

	public FormTaxPaymentCertificate GetDetails(Int64 formTaxPayementCertificateID)
	{
		FormTaxPaymentCertificate formTaxPaymentCertificate = new FormTaxPaymentCertificate();

		SqlParameter[] parametersFormTaxPaymentCertificate = new SqlParameter[]
		{
			new SqlParameter("@FormTaxPayementCertificateID", formTaxPayementCertificateID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormTaxPaymentCertificate_GetDetails", CommandType.StoredProcedure, parametersFormTaxPaymentCertificate))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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
			}
		}

		return formTaxPaymentCertificate;
	}

	public List<FormTaxPaymentCertificate> GetListAll()
	{
		List<FormTaxPaymentCertificate> listFormTaxPaymentCertificate = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormTaxPaymentCertificate_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormTaxPaymentCertificate = new List<FormTaxPaymentCertificate>();

				foreach (DataRow row in table.Rows)
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
					listFormTaxPaymentCertificate.Add(formTaxPaymentCertificate);
				}
			}
		}

		return listFormTaxPaymentCertificate;
	}

	public bool Exists(Int64 formTaxPayementCertificateID)
	{
		SqlParameter[] parametersFormTaxPaymentCertificate = new SqlParameter[]
		{
			new SqlParameter("@FormTaxPayementCertificateID", formTaxPayementCertificateID)
		};
		return (SqlDBHelper.ExecuteScalar("FormTaxPaymentCertificate_Exists", CommandType.StoredProcedure, parametersFormTaxPaymentCertificate)>0);
	}

	public bool Exists(FormTaxPaymentCertificate formTaxPaymentCertificate)
	{
		SqlParameter[] parametersFormTaxPaymentCertificate = new SqlParameter[]
		{
			new SqlParameter("@FormTaxPayementCertificateID", formTaxPaymentCertificate.FormTaxPayementCertificateID)
		};
		return (SqlDBHelper.ExecuteScalar("FormTaxPaymentCertificate_Exists", CommandType.StoredProcedure, parametersFormTaxPaymentCertificate)>0);
	}

	public List<FormTaxPaymentCertificate> SearchLike(FormTaxPaymentCertificate formTaxPaymentCertificate)
	{
		List<FormTaxPaymentCertificate> listFormTaxPaymentCertificate = new List<FormTaxPaymentCertificate>();


		SqlParameter[] parametersFormTaxPaymentCertificate = new SqlParameter[]
		{
			new SqlParameter("@FormTaxPayementCertificateID", formTaxPaymentCertificate.FormTaxPayementCertificateID),
			new SqlParameter("@FormTaxPayementCertificatePrintRegisterDate", formTaxPaymentCertificate.FormTaxPayementCertificatePrintRegisterDate),
			new SqlParameter("@FormTaxPayementCertificatePrintRegisterInformationID", formTaxPaymentCertificate.FormTaxPayementCertificatePrintRegisterInformationID),
			new SqlParameter("@FormTaxPayementCertificateDeathMounth", formTaxPaymentCertificate.FormTaxPayementCertificateDeathMounth),
			new SqlParameter("@FormTaxPayementCertificateDeathYear", formTaxPaymentCertificate.FormTaxPayementCertificateDeathYear),
			new SqlParameter("@FormTaxPayementCertificateDeathCity", formTaxPaymentCertificate.FormTaxPayementCertificateDeathCity),
			new SqlParameter("@FormTaxPayementCertificateDescription1", formTaxPaymentCertificate.FormTaxPayementCertificateDescription1),
			new SqlParameter("@FormTaxPayementCertificateDescription2", formTaxPaymentCertificate.FormTaxPayementCertificateDescription2),
			new SqlParameter("@FormTaxPayementCertificateDescription3", formTaxPaymentCertificate.FormTaxPayementCertificateDescription3),
			new SqlParameter("@FormTaxPayementCertificateHeirsCertificateSource", formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateSource),
			new SqlParameter("@FormTaxPayementCertificateHeirsCertificateBranch", formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateBranch),
			new SqlParameter("@FormTaxPayementCertificateDeadName", formTaxPaymentCertificate.FormTaxPayementCertificateDeadName),
			new SqlParameter("@FormTaxPayementCertificateDeadLastName", formTaxPaymentCertificate.FormTaxPayementCertificateDeadLastName),
			new SqlParameter("@FormTaxPayementCertificateDeadCertificateNumber", formTaxPaymentCertificate.FormTaxPayementCertificateDeadCertificateNumber),
			new SqlParameter("@FormTaxPayementCertificateDeathDay", formTaxPaymentCertificate.FormTaxPayementCertificateDeathDay),
			new SqlParameter("@FormTaxPayementCertificateIssuanceCity", formTaxPaymentCertificate.FormTaxPayementCertificateIssuanceCity),
			new SqlParameter("@FormTaxPayementCertificateDeclarationRequestNumber", formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestNumber),
			new SqlParameter("@FormTaxPayementCertificateDeclarationRequestResource", formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestResource),
			new SqlParameter("@FormTaxPayementCertificateApplicantFullName", formTaxPaymentCertificate.FormTaxPayementCertificateApplicantFullName),
			new SqlParameter("@FormTaxPayementCertificateApplicantFatherName", formTaxPaymentCertificate.FormTaxPayementCertificateApplicantFatherName),
			new SqlParameter("@FormTaxPayementCertificateDescription4", formTaxPaymentCertificate.FormTaxPayementCertificateDescription4),
			new SqlParameter("@FormTaxPayementCertificateDescriptionHeritage", formTaxPaymentCertificate.FormTaxPayementCertificateDescriptionHeritage),
			new SqlParameter("@FormTaxPayementCertificateRequestNumber", formTaxPaymentCertificate.FormTaxPayementCertificateRequestNumber),
			new SqlParameter("@FormTaxPayementCertificateUser1FullName", formTaxPaymentCertificate.FormTaxPayementCertificateUser1FullName),
			new SqlParameter("@FormTaxPayementCertificateUser2FullName", formTaxPaymentCertificate.FormTaxPayementCertificateUser2FullName),
			new SqlParameter("@FormTaxPayementCertificateRegisterInformationID", formTaxPaymentCertificate.FormTaxPayementCertificateRegisterInformationID),
			new SqlParameter("@FormTaxPayementCertificateDeadNationalCode", formTaxPaymentCertificate.FormTaxPayementCertificateDeadNationalCode),
			new SqlParameter("@FormTaxPayementCertificateDeclarationID", formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationID),
			new SqlParameter("@FormTaxPayementCertificateTaxOfficeZipCode", formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeZipCode),
			new SqlParameter("@FormTaxPayementCertificateApplicantNationalCode", formTaxPaymentCertificate.FormTaxPayementCertificateApplicantNationalCode),
			new SqlParameter("@FormTaxPayementCertificateZipCode", formTaxPaymentCertificate.FormTaxPayementCertificateZipCode),
			new SqlParameter("@FormTaxPayementCertificateApplicantName", formTaxPaymentCertificate.FormTaxPayementCertificateApplicantName),
			new SqlParameter("@FormTaxPayementCertificateRegisterDate", formTaxPaymentCertificate.FormTaxPayementCertificateRegisterDate),
			new SqlParameter("@FormTaxPayementCertificateHeirsCertificateDate", formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateDate),
			new SqlParameter("@FormTaxPayementCertificateRequestDate", formTaxPaymentCertificate.FormTaxPayementCertificateRequestDate),
			new SqlParameter("@FormTaxPayementCertificateDeclarationRequestDate", formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestDate),
			new SqlParameter("@FormTaxPayementCertificateApplicantBirthDate", formTaxPaymentCertificate.FormTaxPayementCertificateApplicantBirthDate),
			new SqlParameter("@FormTaxPayementCertificateDossierClasses", formTaxPaymentCertificate.FormTaxPayementCertificateDossierClasses),
			new SqlParameter("@FormTaxPayementCertificateTaxOfficeTitle", formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeTitle),
			new SqlParameter("@FormTaxPayementCertificateTaxOfficeCity", formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeCity),
			new SqlParameter("@FormTaxPayementCertificateTaxOfficeAddress", formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeAddress),
			new SqlParameter("@FormTaxPayementCertificateTaxOfficePhoneNumber", formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficePhoneNumber),
			new SqlParameter("@FormTaxPayementCertificateHeirsCertificateNumber", formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateNumber),
			new SqlParameter("@FormTaxPayementCertificateDeadFatherName", formTaxPaymentCertificate.FormTaxPayementCertificateDeadFatherName),
			new SqlParameter("@FormTaxPayementCertificatePhoneNumber", formTaxPaymentCertificate.FormTaxPayementCertificatePhoneNumber),
			new SqlParameter("@FormTaxPayementCertificateDeadIssuanceCity", formTaxPaymentCertificate.FormTaxPayementCertificateDeadIssuanceCity),
			new SqlParameter("@FormTaxPayementCertificateApplicantBirthCity", formTaxPaymentCertificate.FormTaxPayementCertificateApplicantBirthCity),
			new SqlParameter("@FormTaxPayementCertificateApplicantCertificateNumber", formTaxPaymentCertificate.FormTaxPayementCertificateApplicantCertificateNumber),
			new SqlParameter("@FormTaxPayementCertificateApplicantIssuanceCity", formTaxPaymentCertificate.FormTaxPayementCertificateApplicantIssuanceCity),
			new SqlParameter("@FormTaxPayementCertificateApplicantRole", formTaxPaymentCertificate.FormTaxPayementCertificateApplicantRole),
			new SqlParameter("@FormTaxPayementCertificateAddress", formTaxPaymentCertificate.FormTaxPayementCertificateAddress),
			new SqlParameter("@FormTaxPayementCertificateCommercialNumer", formTaxPaymentCertificate.FormTaxPayementCertificateCommercialNumer),
			new SqlParameter("@FormTaxPayementCertificateTaxOfficeCode", formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeCode),
			new SqlParameter("@FormTaxPayementCertificateTaxGroupCode", formTaxPaymentCertificate.FormTaxPayementCertificateTaxGroupCode),
			new SqlParameter("@FormTaxPayementCertificateTaxUnitCode", formTaxPaymentCertificate.FormTaxPayementCertificateTaxUnitCode),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormTaxPaymentCertificate_SearchLike", CommandType.StoredProcedure, parametersFormTaxPaymentCertificate))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormTaxPaymentCertificate tmpFormTaxPaymentCertificate = new FormTaxPaymentCertificate();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateID = (row["FormTaxPayementCertificateID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateID"]) : 0 ;
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificatePrintRegisterDate = row["FormTaxPayementCertificatePrintRegisterDate"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificatePrintRegisterInformationID = row["FormTaxPayementCertificatePrintRegisterInformationID"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDeathMounth = row["FormTaxPayementCertificateDeathMounth"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDeathYear = row["FormTaxPayementCertificateDeathYear"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDeathCity = row["FormTaxPayementCertificateDeathCity"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDescription1 = row["FormTaxPayementCertificateDescription1"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDescription2 = row["FormTaxPayementCertificateDescription2"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDescription3 = row["FormTaxPayementCertificateDescription3"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateSource = row["FormTaxPayementCertificateHeirsCertificateSource"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateBranch = row["FormTaxPayementCertificateHeirsCertificateBranch"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDeadName = row["FormTaxPayementCertificateDeadName"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDeadLastName = row["FormTaxPayementCertificateDeadLastName"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDeadCertificateNumber = row["FormTaxPayementCertificateDeadCertificateNumber"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDeathDay = row["FormTaxPayementCertificateDeathDay"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateIssuanceCity = row["FormTaxPayementCertificateIssuanceCity"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestNumber = row["FormTaxPayementCertificateDeclarationRequestNumber"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestResource = row["FormTaxPayementCertificateDeclarationRequestResource"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateApplicantFullName = row["FormTaxPayementCertificateApplicantFullName"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateApplicantFatherName = row["FormTaxPayementCertificateApplicantFatherName"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDescription4 = row["FormTaxPayementCertificateDescription4"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDescriptionHeritage = row["FormTaxPayementCertificateDescriptionHeritage"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateRequestNumber = row["FormTaxPayementCertificateRequestNumber"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateUser1FullName = row["FormTaxPayementCertificateUser1FullName"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateUser2FullName = row["FormTaxPayementCertificateUser2FullName"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateRegisterInformationID = (row["FormTaxPayementCertificateRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateRegisterInformationID"]) : 0 ;
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDeadNationalCode = (row["FormTaxPayementCertificateDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateDeadNationalCode"]) : 0 ;
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDeclarationID = (row["FormTaxPayementCertificateDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateDeclarationID"]) : 0 ;
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeZipCode = (row["FormTaxPayementCertificateTaxOfficeZipCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateTaxOfficeZipCode"]) : 0 ;
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateApplicantNationalCode = (row["FormTaxPayementCertificateApplicantNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateApplicantNationalCode"]) : 0 ;
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateZipCode = (row["FormTaxPayementCertificateZipCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateZipCode"]) : 0 ;
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateApplicantName = row["FormTaxPayementCertificateApplicantName"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateRegisterDate = row["FormTaxPayementCertificateRegisterDate"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateDate = row["FormTaxPayementCertificateHeirsCertificateDate"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateRequestDate = row["FormTaxPayementCertificateRequestDate"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestDate = row["FormTaxPayementCertificateDeclarationRequestDate"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateApplicantBirthDate = row["FormTaxPayementCertificateApplicantBirthDate"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDossierClasses = row["FormTaxPayementCertificateDossierClasses"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeTitle = row["FormTaxPayementCertificateTaxOfficeTitle"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeCity = row["FormTaxPayementCertificateTaxOfficeCity"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeAddress = row["FormTaxPayementCertificateTaxOfficeAddress"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficePhoneNumber = row["FormTaxPayementCertificateTaxOfficePhoneNumber"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateNumber = row["FormTaxPayementCertificateHeirsCertificateNumber"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDeadFatherName = row["FormTaxPayementCertificateDeadFatherName"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificatePhoneNumber = row["FormTaxPayementCertificatePhoneNumber"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateDeadIssuanceCity = row["FormTaxPayementCertificateDeadIssuanceCity"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateApplicantBirthCity = row["FormTaxPayementCertificateApplicantBirthCity"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateApplicantCertificateNumber = row["FormTaxPayementCertificateApplicantCertificateNumber"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateApplicantIssuanceCity = row["FormTaxPayementCertificateApplicantIssuanceCity"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateApplicantRole = row["FormTaxPayementCertificateApplicantRole"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateAddress = row["FormTaxPayementCertificateAddress"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateCommercialNumer = row["FormTaxPayementCertificateCommercialNumer"].ToString();
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeCode = (row["FormTaxPayementCertificateTaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["FormTaxPayementCertificateTaxOfficeCode"]) : 0 ;
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateTaxGroupCode = (row["FormTaxPayementCertificateTaxGroupCode"] != DBNull.Value) ? Convert.ToInt32(row["FormTaxPayementCertificateTaxGroupCode"]) : 0 ;
					tmpFormTaxPaymentCertificate.FormTaxPayementCertificateTaxUnitCode = (row["FormTaxPayementCertificateTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["FormTaxPayementCertificateTaxUnitCode"]) : 0 ;

					listFormTaxPaymentCertificate.Add(tmpFormTaxPaymentCertificate);
				}
			}
		}

		return listFormTaxPaymentCertificate;
	}

}
}
