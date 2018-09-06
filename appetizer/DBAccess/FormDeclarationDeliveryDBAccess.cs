using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormDeclarationDeliveryDBAccess
{


	public Int64 Insert(FormDeclarationDelivery formDeclarationDelivery)
	{
		SqlParameter[] parametersFormDeclarationDelivery = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationDeliveryDeadIssuanceCity", (formDeclarationDelivery.FormDeclarationDeliveryDeadIssuanceCity != null) ? formDeclarationDelivery.FormDeclarationDeliveryDeadIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDeadDeathCity", (formDeclarationDelivery.FormDeclarationDeliveryDeadDeathCity != null) ? formDeclarationDelivery.FormDeclarationDeliveryDeadDeathCity : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryUttererRole", (formDeclarationDelivery.FormDeclarationDeliveryUttererRole != null) ? formDeclarationDelivery.FormDeclarationDeliveryUttererRole : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDeclarativeValueString", (formDeclarationDelivery.FormDeclarationDeliveryDeclarativeValueString != null) ? formDeclarationDelivery.FormDeclarationDeliveryDeclarativeValueString : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryRuleComment2", (formDeclarationDelivery.FormDeclarationDeliveryRuleComment2 != null) ? formDeclarationDelivery.FormDeclarationDeliveryRuleComment2 : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryHeritageDescription", (formDeclarationDelivery.FormDeclarationDeliveryHeritageDescription != null) ? formDeclarationDelivery.FormDeclarationDeliveryHeritageDescription : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxGroupCode", (formDeclarationDelivery.FormDeclarationDeliveryTaxGroupCode != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxGroupUserName", (formDeclarationDelivery.FormDeclarationDeliveryTaxGroupUserName != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxGroupUserName : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDeadName", (formDeclarationDelivery.FormDeclarationDeliveryDeadName != null) ? formDeclarationDelivery.FormDeclarationDeliveryDeadName : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDeadFamilu", (formDeclarationDelivery.FormDeclarationDeliveryDeadFamilu != null) ? formDeclarationDelivery.FormDeclarationDeliveryDeadFamilu : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDeadCertificateNumber", (formDeclarationDelivery.FormDeclarationDeliveryDeadCertificateNumber != null) ? formDeclarationDelivery.FormDeclarationDeliveryDeadCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDeadNationalCode", (formDeclarationDelivery.FormDeclarationDeliveryDeadNationalCode != null) ? formDeclarationDelivery.FormDeclarationDeliveryDeadNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryApplicantName", (formDeclarationDelivery.FormDeclarationDeliveryApplicantName != null) ? formDeclarationDelivery.FormDeclarationDeliveryApplicantName : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryApplicantFamily", (formDeclarationDelivery.FormDeclarationDeliveryApplicantFamily != null) ? formDeclarationDelivery.FormDeclarationDeliveryApplicantFamily : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxUnitCode", (formDeclarationDelivery.FormDeclarationDeliveryTaxUnitCode != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxUnitUserName", (formDeclarationDelivery.FormDeclarationDeliveryTaxUnitUserName != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxUnitUserName : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxUnitUserFamily", (formDeclarationDelivery.FormDeclarationDeliveryTaxUnitUserFamily != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxUnitUserFamily : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxGroupUserFamily", (formDeclarationDelivery.FormDeclarationDeliveryTaxGroupUserFamily != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxGroupUserFamily : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryUttererFamily", (formDeclarationDelivery.FormDeclarationDeliveryUttererFamily != null) ? formDeclarationDelivery.FormDeclarationDeliveryUttererFamily : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryUttererCertificateNumber", (formDeclarationDelivery.FormDeclarationDeliveryUttererCertificateNumber != null) ? formDeclarationDelivery.FormDeclarationDeliveryUttererCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryUttererNationalCode", (formDeclarationDelivery.FormDeclarationDeliveryUttererNationalCode != null) ? formDeclarationDelivery.FormDeclarationDeliveryUttererNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryUttererIssuanceCity", (formDeclarationDelivery.FormDeclarationDeliveryUttererIssuanceCity != null) ? formDeclarationDelivery.FormDeclarationDeliveryUttererIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryComment2", (formDeclarationDelivery.FormDeclarationDeliveryComment2 != null) ? formDeclarationDelivery.FormDeclarationDeliveryComment2 : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryApplicantNumber", (formDeclarationDelivery.FormDeclarationDeliveryApplicantNumber != null) ? formDeclarationDelivery.FormDeclarationDeliveryApplicantNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryRegisterInformationID", (formDeclarationDelivery.FormDeclarationDeliveryRegisterInformationID > 0) ? formDeclarationDelivery.FormDeclarationDeliveryRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDeclarationID", (formDeclarationDelivery.FormDeclarationDeliveryDeclarationID > 0) ? formDeclarationDelivery.FormDeclarationDeliveryDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryRegisterarUserNationalCode", (formDeclarationDelivery.FormDeclarationDeliveryRegisterarUserNationalCode > 0) ? formDeclarationDelivery.FormDeclarationDeliveryRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDossierClasses", (formDeclarationDelivery.FormDeclarationDeliveryDossierClasses != null) ? formDeclarationDelivery.FormDeclarationDeliveryDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxOfficePhoneNumber", (formDeclarationDelivery.FormDeclarationDeliveryTaxOfficePhoneNumber != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxOfficePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryApplicantDate", (formDeclarationDelivery.FormDeclarationDeliveryApplicantDate != null) ? formDeclarationDelivery.FormDeclarationDeliveryApplicantDate : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDeadDeathDate", (formDeclarationDelivery.FormDeclarationDeliveryDeadDeathDate != null) ? formDeclarationDelivery.FormDeclarationDeliveryDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryRegisterInformationDate", (formDeclarationDelivery.FormDeclarationDeliveryRegisterInformationDate != null) ? formDeclarationDelivery.FormDeclarationDeliveryRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryRuleComment1", (formDeclarationDelivery.FormDeclarationDeliveryRuleComment1 != null) ? formDeclarationDelivery.FormDeclarationDeliveryRuleComment1 : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxOfficeProvince", (formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeProvince != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeProvince : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxOfficeCode", (formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeCode != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxOfficeCity", (formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeCity != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeCity : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxOfficeAddress", (formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeAddress != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeAddress : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryUttererName", (formDeclarationDelivery.FormDeclarationDeliveryUttererName != null) ? formDeclarationDelivery.FormDeclarationDeliveryUttererName : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDeclarativeValue", (formDeclarationDelivery.FormDeclarationDeliveryDeclarativeValue != null) ? formDeclarationDelivery.FormDeclarationDeliveryDeclarativeValue : (object)DBNull.Value)
		};
		formDeclarationDelivery.FormDeclarationDeliveryID = SqlDBHelper.ExecuteScalar("FormDeclarationDelivery_Insert", CommandType.StoredProcedure, parametersFormDeclarationDelivery);
		return formDeclarationDelivery.FormDeclarationDeliveryID;
	}

	public bool Update(FormDeclarationDelivery formDeclarationDelivery)
	{
		SqlParameter[] parametersFormDeclarationDelivery = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationDeliveryID", formDeclarationDelivery.FormDeclarationDeliveryID),
			new SqlParameter("@FormDeclarationDeliveryDeadIssuanceCity", (formDeclarationDelivery.FormDeclarationDeliveryDeadIssuanceCity != null) ? formDeclarationDelivery.FormDeclarationDeliveryDeadIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDeadDeathCity", (formDeclarationDelivery.FormDeclarationDeliveryDeadDeathCity != null) ? formDeclarationDelivery.FormDeclarationDeliveryDeadDeathCity : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryUttererRole", (formDeclarationDelivery.FormDeclarationDeliveryUttererRole != null) ? formDeclarationDelivery.FormDeclarationDeliveryUttererRole : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDeclarativeValueString", (formDeclarationDelivery.FormDeclarationDeliveryDeclarativeValueString != null) ? formDeclarationDelivery.FormDeclarationDeliveryDeclarativeValueString : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryRuleComment2", (formDeclarationDelivery.FormDeclarationDeliveryRuleComment2 != null) ? formDeclarationDelivery.FormDeclarationDeliveryRuleComment2 : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryHeritageDescription", (formDeclarationDelivery.FormDeclarationDeliveryHeritageDescription != null) ? formDeclarationDelivery.FormDeclarationDeliveryHeritageDescription : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxGroupCode", (formDeclarationDelivery.FormDeclarationDeliveryTaxGroupCode != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxGroupUserName", (formDeclarationDelivery.FormDeclarationDeliveryTaxGroupUserName != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxGroupUserName : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDeadName", (formDeclarationDelivery.FormDeclarationDeliveryDeadName != null) ? formDeclarationDelivery.FormDeclarationDeliveryDeadName : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDeadFamilu", (formDeclarationDelivery.FormDeclarationDeliveryDeadFamilu != null) ? formDeclarationDelivery.FormDeclarationDeliveryDeadFamilu : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDeadCertificateNumber", (formDeclarationDelivery.FormDeclarationDeliveryDeadCertificateNumber != null) ? formDeclarationDelivery.FormDeclarationDeliveryDeadCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDeadNationalCode", (formDeclarationDelivery.FormDeclarationDeliveryDeadNationalCode != null) ? formDeclarationDelivery.FormDeclarationDeliveryDeadNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryApplicantName", (formDeclarationDelivery.FormDeclarationDeliveryApplicantName != null) ? formDeclarationDelivery.FormDeclarationDeliveryApplicantName : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryApplicantFamily", (formDeclarationDelivery.FormDeclarationDeliveryApplicantFamily != null) ? formDeclarationDelivery.FormDeclarationDeliveryApplicantFamily : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxUnitCode", (formDeclarationDelivery.FormDeclarationDeliveryTaxUnitCode != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxUnitUserName", (formDeclarationDelivery.FormDeclarationDeliveryTaxUnitUserName != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxUnitUserName : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxUnitUserFamily", (formDeclarationDelivery.FormDeclarationDeliveryTaxUnitUserFamily != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxUnitUserFamily : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxGroupUserFamily", (formDeclarationDelivery.FormDeclarationDeliveryTaxGroupUserFamily != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxGroupUserFamily : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryUttererFamily", (formDeclarationDelivery.FormDeclarationDeliveryUttererFamily != null) ? formDeclarationDelivery.FormDeclarationDeliveryUttererFamily : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryUttererCertificateNumber", (formDeclarationDelivery.FormDeclarationDeliveryUttererCertificateNumber != null) ? formDeclarationDelivery.FormDeclarationDeliveryUttererCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryUttererNationalCode", (formDeclarationDelivery.FormDeclarationDeliveryUttererNationalCode != null) ? formDeclarationDelivery.FormDeclarationDeliveryUttererNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryUttererIssuanceCity", (formDeclarationDelivery.FormDeclarationDeliveryUttererIssuanceCity != null) ? formDeclarationDelivery.FormDeclarationDeliveryUttererIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryComment2", (formDeclarationDelivery.FormDeclarationDeliveryComment2 != null) ? formDeclarationDelivery.FormDeclarationDeliveryComment2 : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryApplicantNumber", (formDeclarationDelivery.FormDeclarationDeliveryApplicantNumber != null) ? formDeclarationDelivery.FormDeclarationDeliveryApplicantNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryRegisterInformationID", (formDeclarationDelivery.FormDeclarationDeliveryRegisterInformationID != null && formDeclarationDelivery.FormDeclarationDeliveryRegisterInformationID >0 ) ? formDeclarationDelivery.FormDeclarationDeliveryRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDeclarationID", formDeclarationDelivery.FormDeclarationDeliveryDeclarationID),
			new SqlParameter("@FormDeclarationDeliveryRegisterarUserNationalCode", (formDeclarationDelivery.FormDeclarationDeliveryRegisterarUserNationalCode != null && formDeclarationDelivery.FormDeclarationDeliveryRegisterarUserNationalCode >0 ) ? formDeclarationDelivery.FormDeclarationDeliveryRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDossierClasses", (formDeclarationDelivery.FormDeclarationDeliveryDossierClasses != null) ? formDeclarationDelivery.FormDeclarationDeliveryDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxOfficePhoneNumber", (formDeclarationDelivery.FormDeclarationDeliveryTaxOfficePhoneNumber != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxOfficePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryApplicantDate", (formDeclarationDelivery.FormDeclarationDeliveryApplicantDate != null) ? formDeclarationDelivery.FormDeclarationDeliveryApplicantDate : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDeadDeathDate", (formDeclarationDelivery.FormDeclarationDeliveryDeadDeathDate != null) ? formDeclarationDelivery.FormDeclarationDeliveryDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryRegisterInformationDate", (formDeclarationDelivery.FormDeclarationDeliveryRegisterInformationDate != null) ? formDeclarationDelivery.FormDeclarationDeliveryRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryRuleComment1", (formDeclarationDelivery.FormDeclarationDeliveryRuleComment1 != null) ? formDeclarationDelivery.FormDeclarationDeliveryRuleComment1 : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxOfficeProvince", (formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeProvince != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeProvince : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxOfficeCode", (formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeCode != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxOfficeCity", (formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeCity != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeCity : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryTaxOfficeAddress", (formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeAddress != null) ? formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeAddress : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryUttererName", (formDeclarationDelivery.FormDeclarationDeliveryUttererName != null) ? formDeclarationDelivery.FormDeclarationDeliveryUttererName : (object)DBNull.Value),
			new SqlParameter("@FormDeclarationDeliveryDeclarativeValue", (formDeclarationDelivery.FormDeclarationDeliveryDeclarativeValue != null) ? formDeclarationDelivery.FormDeclarationDeliveryDeclarativeValue : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormDeclarationDelivery_Update", CommandType.StoredProcedure, parametersFormDeclarationDelivery);
	}

	public bool Delete(Int64 formDeclarationDeliveryID)
	{
		SqlParameter[] parametersFormDeclarationDelivery = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationDeliveryID", formDeclarationDeliveryID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormDeclarationDelivery_Delete", CommandType.StoredProcedure, parametersFormDeclarationDelivery);
	}

	public FormDeclarationDelivery GetDetails(Int64 formDeclarationDeliveryID)
	{
		FormDeclarationDelivery formDeclarationDelivery = new FormDeclarationDelivery();

		SqlParameter[] parametersFormDeclarationDelivery = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationDeliveryID", formDeclarationDeliveryID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDeclarationDelivery_GetDetails", CommandType.StoredProcedure, parametersFormDeclarationDelivery))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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
			}
		}

		return formDeclarationDelivery;
	}

	public List<FormDeclarationDelivery> GetListAll()
	{
		List<FormDeclarationDelivery> listFormDeclarationDelivery = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormDeclarationDelivery_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormDeclarationDelivery = new List<FormDeclarationDelivery>();

				foreach (DataRow row in table.Rows)
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
					listFormDeclarationDelivery.Add(formDeclarationDelivery);
				}
			}
		}

		return listFormDeclarationDelivery;
	}

	public bool Exists(Int64 formDeclarationDeliveryID)
	{
		SqlParameter[] parametersFormDeclarationDelivery = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationDeliveryID", formDeclarationDeliveryID)
		};
		return (SqlDBHelper.ExecuteScalar("FormDeclarationDelivery_Exists", CommandType.StoredProcedure, parametersFormDeclarationDelivery)>0);
	}

	public bool Exists(FormDeclarationDelivery formDeclarationDelivery)
	{
		SqlParameter[] parametersFormDeclarationDelivery = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationDeliveryID", formDeclarationDelivery.FormDeclarationDeliveryID)
		};
		return (SqlDBHelper.ExecuteScalar("FormDeclarationDelivery_Exists", CommandType.StoredProcedure, parametersFormDeclarationDelivery)>0);
	}

	public List<FormDeclarationDelivery> SearchLike(FormDeclarationDelivery formDeclarationDelivery)
	{
		List<FormDeclarationDelivery> listFormDeclarationDelivery = new List<FormDeclarationDelivery>();


		SqlParameter[] parametersFormDeclarationDelivery = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationDeliveryID", formDeclarationDelivery.FormDeclarationDeliveryID),
			new SqlParameter("@FormDeclarationDeliveryPrintRegisterInformationID", formDeclarationDelivery.FormDeclarationDeliveryPrintRegisterInformationID),
			new SqlParameter("@FormDeclarationDeliveryPrintRegisterDate", formDeclarationDelivery.FormDeclarationDeliveryPrintRegisterDate),
			new SqlParameter("@FormDeclarationDeliveryDeadIssuanceCity", formDeclarationDelivery.FormDeclarationDeliveryDeadIssuanceCity),
			new SqlParameter("@FormDeclarationDeliveryDeadDeathCity", formDeclarationDelivery.FormDeclarationDeliveryDeadDeathCity),
			new SqlParameter("@FormDeclarationDeliveryUttererRole", formDeclarationDelivery.FormDeclarationDeliveryUttererRole),
			new SqlParameter("@FormDeclarationDeliveryDeclarativeValueString", formDeclarationDelivery.FormDeclarationDeliveryDeclarativeValueString),
			new SqlParameter("@FormDeclarationDeliveryRuleComment2", formDeclarationDelivery.FormDeclarationDeliveryRuleComment2),
			new SqlParameter("@FormDeclarationDeliveryHeritageDescription", formDeclarationDelivery.FormDeclarationDeliveryHeritageDescription),
			new SqlParameter("@FormDeclarationDeliveryTaxGroupCode", formDeclarationDelivery.FormDeclarationDeliveryTaxGroupCode),
			new SqlParameter("@FormDeclarationDeliveryTaxGroupUserName", formDeclarationDelivery.FormDeclarationDeliveryTaxGroupUserName),
			new SqlParameter("@FormDeclarationDeliveryDeadName", formDeclarationDelivery.FormDeclarationDeliveryDeadName),
			new SqlParameter("@FormDeclarationDeliveryDeadFamilu", formDeclarationDelivery.FormDeclarationDeliveryDeadFamilu),
			new SqlParameter("@FormDeclarationDeliveryDeadCertificateNumber", formDeclarationDelivery.FormDeclarationDeliveryDeadCertificateNumber),
			new SqlParameter("@FormDeclarationDeliveryDeadNationalCode", formDeclarationDelivery.FormDeclarationDeliveryDeadNationalCode),
			new SqlParameter("@FormDeclarationDeliveryApplicantName", formDeclarationDelivery.FormDeclarationDeliveryApplicantName),
			new SqlParameter("@FormDeclarationDeliveryApplicantFamily", formDeclarationDelivery.FormDeclarationDeliveryApplicantFamily),
			new SqlParameter("@FormDeclarationDeliveryTaxUnitCode", formDeclarationDelivery.FormDeclarationDeliveryTaxUnitCode),
			new SqlParameter("@FormDeclarationDeliveryTaxUnitUserName", formDeclarationDelivery.FormDeclarationDeliveryTaxUnitUserName),
			new SqlParameter("@FormDeclarationDeliveryTaxUnitUserFamily", formDeclarationDelivery.FormDeclarationDeliveryTaxUnitUserFamily),
			new SqlParameter("@FormDeclarationDeliveryTaxGroupUserFamily", formDeclarationDelivery.FormDeclarationDeliveryTaxGroupUserFamily),
			new SqlParameter("@FormDeclarationDeliveryUttererFamily", formDeclarationDelivery.FormDeclarationDeliveryUttererFamily),
			new SqlParameter("@FormDeclarationDeliveryUttererCertificateNumber", formDeclarationDelivery.FormDeclarationDeliveryUttererCertificateNumber),
			new SqlParameter("@FormDeclarationDeliveryUttererNationalCode", formDeclarationDelivery.FormDeclarationDeliveryUttererNationalCode),
			new SqlParameter("@FormDeclarationDeliveryUttererIssuanceCity", formDeclarationDelivery.FormDeclarationDeliveryUttererIssuanceCity),
			new SqlParameter("@FormDeclarationDeliveryComment2", formDeclarationDelivery.FormDeclarationDeliveryComment2),
			new SqlParameter("@FormDeclarationDeliveryApplicantNumber", formDeclarationDelivery.FormDeclarationDeliveryApplicantNumber),
			new SqlParameter("@FormDeclarationDeliveryRegisterInformationID", formDeclarationDelivery.FormDeclarationDeliveryRegisterInformationID),
			new SqlParameter("@FormDeclarationDeliveryDeclarationID", formDeclarationDelivery.FormDeclarationDeliveryDeclarationID),
			new SqlParameter("@FormDeclarationDeliveryRegisterarUserNationalCode", formDeclarationDelivery.FormDeclarationDeliveryRegisterarUserNationalCode),
			new SqlParameter("@FormDeclarationDeliveryDossierClasses", formDeclarationDelivery.FormDeclarationDeliveryDossierClasses),
			new SqlParameter("@FormDeclarationDeliveryTaxOfficePhoneNumber", formDeclarationDelivery.FormDeclarationDeliveryTaxOfficePhoneNumber),
			new SqlParameter("@FormDeclarationDeliveryApplicantDate", formDeclarationDelivery.FormDeclarationDeliveryApplicantDate),
			new SqlParameter("@FormDeclarationDeliveryDeadDeathDate", formDeclarationDelivery.FormDeclarationDeliveryDeadDeathDate),
			new SqlParameter("@FormDeclarationDeliveryRegisterInformationDate", formDeclarationDelivery.FormDeclarationDeliveryRegisterInformationDate),
			new SqlParameter("@FormDeclarationDeliveryRuleComment1", formDeclarationDelivery.FormDeclarationDeliveryRuleComment1),
			new SqlParameter("@FormDeclarationDeliveryTaxOfficeProvince", formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeProvince),
			new SqlParameter("@FormDeclarationDeliveryTaxOfficeCode", formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeCode),
			new SqlParameter("@FormDeclarationDeliveryTaxOfficeCity", formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeCity),
			new SqlParameter("@FormDeclarationDeliveryTaxOfficeAddress", formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeAddress),
			new SqlParameter("@FormDeclarationDeliveryUttererName", formDeclarationDelivery.FormDeclarationDeliveryUttererName),
			new SqlParameter("@FormDeclarationDeliveryDeclarativeValue", formDeclarationDelivery.FormDeclarationDeliveryDeclarativeValue),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDeclarationDelivery_SearchLike", CommandType.StoredProcedure, parametersFormDeclarationDelivery))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormDeclarationDelivery tmpFormDeclarationDelivery = new FormDeclarationDelivery();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryID = (row["FormDeclarationDeliveryID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationDeliveryID"]) : 0 ;
					tmpFormDeclarationDelivery.FormDeclarationDeliveryPrintRegisterInformationID = row["FormDeclarationDeliveryPrintRegisterInformationID"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryPrintRegisterDate = row["FormDeclarationDeliveryPrintRegisterDate"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryDeadIssuanceCity = row["FormDeclarationDeliveryDeadIssuanceCity"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryDeadDeathCity = row["FormDeclarationDeliveryDeadDeathCity"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryUttererRole = row["FormDeclarationDeliveryUttererRole"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryDeclarativeValueString = row["FormDeclarationDeliveryDeclarativeValueString"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryRuleComment2 = row["FormDeclarationDeliveryRuleComment2"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryHeritageDescription = row["FormDeclarationDeliveryHeritageDescription"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryTaxGroupCode = row["FormDeclarationDeliveryTaxGroupCode"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryTaxGroupUserName = row["FormDeclarationDeliveryTaxGroupUserName"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryDeadName = row["FormDeclarationDeliveryDeadName"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryDeadFamilu = row["FormDeclarationDeliveryDeadFamilu"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryDeadCertificateNumber = row["FormDeclarationDeliveryDeadCertificateNumber"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryDeadNationalCode = row["FormDeclarationDeliveryDeadNationalCode"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryApplicantName = row["FormDeclarationDeliveryApplicantName"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryApplicantFamily = row["FormDeclarationDeliveryApplicantFamily"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryTaxUnitCode = row["FormDeclarationDeliveryTaxUnitCode"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryTaxUnitUserName = row["FormDeclarationDeliveryTaxUnitUserName"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryTaxUnitUserFamily = row["FormDeclarationDeliveryTaxUnitUserFamily"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryTaxGroupUserFamily = row["FormDeclarationDeliveryTaxGroupUserFamily"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryUttererFamily = row["FormDeclarationDeliveryUttererFamily"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryUttererCertificateNumber = row["FormDeclarationDeliveryUttererCertificateNumber"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryUttererNationalCode = row["FormDeclarationDeliveryUttererNationalCode"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryUttererIssuanceCity = row["FormDeclarationDeliveryUttererIssuanceCity"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryComment2 = row["FormDeclarationDeliveryComment2"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryApplicantNumber = row["FormDeclarationDeliveryApplicantNumber"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryRegisterInformationID = (row["FormDeclarationDeliveryRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationDeliveryRegisterInformationID"]) : 0 ;
					tmpFormDeclarationDelivery.FormDeclarationDeliveryDeclarationID = (row["FormDeclarationDeliveryDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationDeliveryDeclarationID"]) : 0 ;
					tmpFormDeclarationDelivery.FormDeclarationDeliveryRegisterarUserNationalCode = (row["FormDeclarationDeliveryRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationDeliveryRegisterarUserNationalCode"]) : 0 ;
					tmpFormDeclarationDelivery.FormDeclarationDeliveryDossierClasses = row["FormDeclarationDeliveryDossierClasses"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryTaxOfficePhoneNumber = row["FormDeclarationDeliveryTaxOfficePhoneNumber"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryApplicantDate = row["FormDeclarationDeliveryApplicantDate"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryDeadDeathDate = row["FormDeclarationDeliveryDeadDeathDate"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryRegisterInformationDate = row["FormDeclarationDeliveryRegisterInformationDate"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryRuleComment1 = row["FormDeclarationDeliveryRuleComment1"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryTaxOfficeProvince = row["FormDeclarationDeliveryTaxOfficeProvince"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryTaxOfficeCode = row["FormDeclarationDeliveryTaxOfficeCode"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryTaxOfficeCity = row["FormDeclarationDeliveryTaxOfficeCity"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryTaxOfficeAddress = row["FormDeclarationDeliveryTaxOfficeAddress"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryUttererName = row["FormDeclarationDeliveryUttererName"].ToString();
					tmpFormDeclarationDelivery.FormDeclarationDeliveryDeclarativeValue = (row["FormDeclarationDeliveryDeclarativeValue"] != DBNull.Value) ? Convert.ToSingle(row["FormDeclarationDeliveryDeclarativeValue"]) : 0 ;

					listFormDeclarationDelivery.Add(tmpFormDeclarationDelivery);
				}
			}
		}

		return listFormDeclarationDelivery;
	}

}
}
