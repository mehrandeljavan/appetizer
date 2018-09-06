using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormCommissionInvitationDBAccess
{


	public Int64 Insert(FormCommissionInvitation formCommissionInvitation)
	{
		SqlParameter[] parametersFormCommissionInvitation = new SqlParameter[]
		{
			new SqlParameter("@FormCommissionInvitationTaxResource", (formCommissionInvitation.FormCommissionInvitationTaxResource != null) ? formCommissionInvitation.FormCommissionInvitationTaxResource : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationDeadDeathYear", (formCommissionInvitation.FormCommissionInvitationDeadDeathYear != null) ? formCommissionInvitation.FormCommissionInvitationDeadDeathYear : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionAddress", (formCommissionInvitation.FormCommissionInvitationCommissionAddress != null) ? formCommissionInvitation.FormCommissionInvitationCommissionAddress : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationUser1FullName", (formCommissionInvitation.FormCommissionInvitationUser1FullName != null) ? formCommissionInvitation.FormCommissionInvitationUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationUser1Code", (formCommissionInvitation.FormCommissionInvitationUser1Code != null) ? formCommissionInvitation.FormCommissionInvitationUser1Code : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationUser2FullName", (formCommissionInvitation.FormCommissionInvitationUser2FullName != null) ? formCommissionInvitation.FormCommissionInvitationUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationUser2Code", (formCommissionInvitation.FormCommissionInvitationUser2Code != null) ? formCommissionInvitation.FormCommissionInvitationUser2Code : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionType3", (formCommissionInvitation.FormCommissionInvitationCommissionType3 != null) ? formCommissionInvitation.FormCommissionInvitationCommissionType3 : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionType4", (formCommissionInvitation.FormCommissionInvitationCommissionType4 != null) ? formCommissionInvitation.FormCommissionInvitationCommissionType4 : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionType5", (formCommissionInvitation.FormCommissionInvitationCommissionType5 != null) ? formCommissionInvitation.FormCommissionInvitationCommissionType5 : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionType6", (formCommissionInvitation.FormCommissionInvitationCommissionType6 != null) ? formCommissionInvitation.FormCommissionInvitationCommissionType6 : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionDay", (formCommissionInvitation.FormCommissionInvitationCommissionDay != null) ? formCommissionInvitation.FormCommissionInvitationCommissionDay : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionTimePeriod", (formCommissionInvitation.FormCommissionInvitationCommissionTimePeriod != null) ? formCommissionInvitation.FormCommissionInvitationCommissionTimePeriod : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirJobZipCode", (formCommissionInvitation.FormCommissionInvitationHeirJobZipCode != null) ? formCommissionInvitation.FormCommissionInvitationHeirJobZipCode : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationInvitationType1", (formCommissionInvitation.FormCommissionInvitationInvitationType1 != null) ? formCommissionInvitation.FormCommissionInvitationInvitationType1 : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationInvitationType2", (formCommissionInvitation.FormCommissionInvitationInvitationType2 != null) ? formCommissionInvitation.FormCommissionInvitationInvitationType2 : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationInvitationType3", (formCommissionInvitation.FormCommissionInvitationInvitationType3 != null) ? formCommissionInvitation.FormCommissionInvitationInvitationType3 : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionType1", (formCommissionInvitation.FormCommissionInvitationCommissionType1 != null) ? formCommissionInvitation.FormCommissionInvitationCommissionType1 : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionType2", (formCommissionInvitation.FormCommissionInvitationCommissionType2 != null) ? formCommissionInvitation.FormCommissionInvitationCommissionType2 : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationDeadUniqueCode", (formCommissionInvitation.FormCommissionInvitationDeadUniqueCode != null) ? formCommissionInvitation.FormCommissionInvitationDeadUniqueCode : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirJobAddress", (formCommissionInvitation.FormCommissionInvitationHeirJobAddress != null) ? formCommissionInvitation.FormCommissionInvitationHeirJobAddress : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirHomeAddress", (formCommissionInvitation.FormCommissionInvitationHeirHomeAddress != null) ? formCommissionInvitation.FormCommissionInvitationHeirHomeAddress : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirHomePhoneNumber", (formCommissionInvitation.FormCommissionInvitationHeirHomePhoneNumber != null) ? formCommissionInvitation.FormCommissionInvitationHeirHomePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirHomeJobPhoneNumber", (formCommissionInvitation.FormCommissionInvitationHeirHomeJobPhoneNumber != null) ? formCommissionInvitation.FormCommissionInvitationHeirHomeJobPhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirHomeZipCode", (formCommissionInvitation.FormCommissionInvitationHeirHomeZipCode != null) ? formCommissionInvitation.FormCommissionInvitationHeirHomeZipCode : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirFatherName", (formCommissionInvitation.FormCommissionInvitationHeirFatherName != null) ? formCommissionInvitation.FormCommissionInvitationHeirFatherName : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirIdentifier", (formCommissionInvitation.FormCommissionInvitationHeirIdentifier != null) ? formCommissionInvitation.FormCommissionInvitationHeirIdentifier : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirCertificateNumber", (formCommissionInvitation.FormCommissionInvitationHeirCertificateNumber != null) ? formCommissionInvitation.FormCommissionInvitationHeirCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirIssuanceCity", (formCommissionInvitation.FormCommissionInvitationHeirIssuanceCity != null) ? formCommissionInvitation.FormCommissionInvitationHeirIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationDeadFullName", (formCommissionInvitation.FormCommissionInvitationDeadFullName != null) ? formCommissionInvitation.FormCommissionInvitationDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirRelation", (formCommissionInvitation.FormCommissionInvitationHeirRelation != null) ? formCommissionInvitation.FormCommissionInvitationHeirRelation : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirBirthDate", (formCommissionInvitation.FormCommissionInvitationHeirBirthDate != null) ? formCommissionInvitation.FormCommissionInvitationHeirBirthDate : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionDate", (formCommissionInvitation.FormCommissionInvitationCommissionDate != null) ? formCommissionInvitation.FormCommissionInvitationCommissionDate : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionTime", (formCommissionInvitation.FormCommissionInvitationCommissionTime != null) ? formCommissionInvitation.FormCommissionInvitationCommissionTime : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationPenaltyDate", (formCommissionInvitation.FormCommissionInvitationPenaltyDate != null) ? formCommissionInvitation.FormCommissionInvitationPenaltyDate : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationRegisterInformarionID", (formCommissionInvitation.FormCommissionInvitationRegisterInformarionID > 0) ? formCommissionInvitation.FormCommissionInvitationRegisterInformarionID : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirNationalCode", (formCommissionInvitation.FormCommissionInvitationHeirNationalCode != null) ? formCommissionInvitation.FormCommissionInvitationHeirNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationDeclarationID", (formCommissionInvitation.FormCommissionInvitationDeclarationID > 0) ? formCommissionInvitation.FormCommissionInvitationDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationRegisterDate", (formCommissionInvitation.FormCommissionInvitationRegisterDate != null) ? formCommissionInvitation.FormCommissionInvitationRegisterDate : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationDossierClasses", (formCommissionInvitation.FormCommissionInvitationDossierClasses != null) ? formCommissionInvitation.FormCommissionInvitationDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationTaxOfficeProvince", (formCommissionInvitation.FormCommissionInvitationTaxOfficeProvince != null) ? formCommissionInvitation.FormCommissionInvitationTaxOfficeProvince : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationTaxOfficeCity", (formCommissionInvitation.FormCommissionInvitationTaxOfficeCity != null) ? formCommissionInvitation.FormCommissionInvitationTaxOfficeCity : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationTaxOfficeAddress", (formCommissionInvitation.FormCommissionInvitationTaxOfficeAddress != null) ? formCommissionInvitation.FormCommissionInvitationTaxOfficeAddress : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationTaxOfficePhoneNumber", (formCommissionInvitation.FormCommissionInvitationTaxOfficePhoneNumber != null) ? formCommissionInvitation.FormCommissionInvitationTaxOfficePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirFullName", (formCommissionInvitation.FormCommissionInvitationHeirFullName != null) ? formCommissionInvitation.FormCommissionInvitationHeirFullName : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationTaxUnitCode", (formCommissionInvitation.FormCommissionInvitationTaxUnitCode != null) ? formCommissionInvitation.FormCommissionInvitationTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirShare", (formCommissionInvitation.FormCommissionInvitationHeirShare != null) ? formCommissionInvitation.FormCommissionInvitationHeirShare : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirExemption", (formCommissionInvitation.FormCommissionInvitationHeirExemption != null) ? formCommissionInvitation.FormCommissionInvitationHeirExemption : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirIncludedIncome", (formCommissionInvitation.FormCommissionInvitationHeirIncludedIncome != null) ? formCommissionInvitation.FormCommissionInvitationHeirIncludedIncome : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirTax", (formCommissionInvitation.FormCommissionInvitationHeirTax != null) ? formCommissionInvitation.FormCommissionInvitationHeirTax : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationPenaltySum", (formCommissionInvitation.FormCommissionInvitationPenaltySum != null) ? formCommissionInvitation.FormCommissionInvitationPenaltySum : (object)DBNull.Value)
		};
		formCommissionInvitation.FormCommissionInvitationID = SqlDBHelper.ExecuteScalar("FormCommissionInvitation_Insert", CommandType.StoredProcedure, parametersFormCommissionInvitation);
		return formCommissionInvitation.FormCommissionInvitationID;
	}

	public bool Update(FormCommissionInvitation formCommissionInvitation)
	{
		SqlParameter[] parametersFormCommissionInvitation = new SqlParameter[]
		{
			new SqlParameter("@FormCommissionInvitationID", formCommissionInvitation.FormCommissionInvitationID),
			new SqlParameter("@FormCommissionInvitationTaxResource", (formCommissionInvitation.FormCommissionInvitationTaxResource != null) ? formCommissionInvitation.FormCommissionInvitationTaxResource : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationDeadDeathYear", (formCommissionInvitation.FormCommissionInvitationDeadDeathYear != null) ? formCommissionInvitation.FormCommissionInvitationDeadDeathYear : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionAddress", (formCommissionInvitation.FormCommissionInvitationCommissionAddress != null) ? formCommissionInvitation.FormCommissionInvitationCommissionAddress : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationUser1FullName", (formCommissionInvitation.FormCommissionInvitationUser1FullName != null) ? formCommissionInvitation.FormCommissionInvitationUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationUser1Code", (formCommissionInvitation.FormCommissionInvitationUser1Code != null) ? formCommissionInvitation.FormCommissionInvitationUser1Code : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationUser2FullName", (formCommissionInvitation.FormCommissionInvitationUser2FullName != null) ? formCommissionInvitation.FormCommissionInvitationUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationUser2Code", (formCommissionInvitation.FormCommissionInvitationUser2Code != null) ? formCommissionInvitation.FormCommissionInvitationUser2Code : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionType3", (formCommissionInvitation.FormCommissionInvitationCommissionType3 != null) ? formCommissionInvitation.FormCommissionInvitationCommissionType3 : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionType4", (formCommissionInvitation.FormCommissionInvitationCommissionType4 != null) ? formCommissionInvitation.FormCommissionInvitationCommissionType4 : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionType5", (formCommissionInvitation.FormCommissionInvitationCommissionType5 != null) ? formCommissionInvitation.FormCommissionInvitationCommissionType5 : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionType6", (formCommissionInvitation.FormCommissionInvitationCommissionType6 != null) ? formCommissionInvitation.FormCommissionInvitationCommissionType6 : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionDay", (formCommissionInvitation.FormCommissionInvitationCommissionDay != null) ? formCommissionInvitation.FormCommissionInvitationCommissionDay : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionTimePeriod", (formCommissionInvitation.FormCommissionInvitationCommissionTimePeriod != null) ? formCommissionInvitation.FormCommissionInvitationCommissionTimePeriod : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirJobZipCode", (formCommissionInvitation.FormCommissionInvitationHeirJobZipCode != null) ? formCommissionInvitation.FormCommissionInvitationHeirJobZipCode : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationInvitationType1", (formCommissionInvitation.FormCommissionInvitationInvitationType1 != null) ? formCommissionInvitation.FormCommissionInvitationInvitationType1 : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationInvitationType2", (formCommissionInvitation.FormCommissionInvitationInvitationType2 != null) ? formCommissionInvitation.FormCommissionInvitationInvitationType2 : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationInvitationType3", (formCommissionInvitation.FormCommissionInvitationInvitationType3 != null) ? formCommissionInvitation.FormCommissionInvitationInvitationType3 : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionType1", (formCommissionInvitation.FormCommissionInvitationCommissionType1 != null) ? formCommissionInvitation.FormCommissionInvitationCommissionType1 : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionType2", (formCommissionInvitation.FormCommissionInvitationCommissionType2 != null) ? formCommissionInvitation.FormCommissionInvitationCommissionType2 : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationDeadUniqueCode", (formCommissionInvitation.FormCommissionInvitationDeadUniqueCode != null) ? formCommissionInvitation.FormCommissionInvitationDeadUniqueCode : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirJobAddress", (formCommissionInvitation.FormCommissionInvitationHeirJobAddress != null) ? formCommissionInvitation.FormCommissionInvitationHeirJobAddress : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirHomeAddress", (formCommissionInvitation.FormCommissionInvitationHeirHomeAddress != null) ? formCommissionInvitation.FormCommissionInvitationHeirHomeAddress : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirHomePhoneNumber", (formCommissionInvitation.FormCommissionInvitationHeirHomePhoneNumber != null) ? formCommissionInvitation.FormCommissionInvitationHeirHomePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirHomeJobPhoneNumber", (formCommissionInvitation.FormCommissionInvitationHeirHomeJobPhoneNumber != null) ? formCommissionInvitation.FormCommissionInvitationHeirHomeJobPhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirHomeZipCode", (formCommissionInvitation.FormCommissionInvitationHeirHomeZipCode != null) ? formCommissionInvitation.FormCommissionInvitationHeirHomeZipCode : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirFatherName", (formCommissionInvitation.FormCommissionInvitationHeirFatherName != null) ? formCommissionInvitation.FormCommissionInvitationHeirFatherName : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirIdentifier", (formCommissionInvitation.FormCommissionInvitationHeirIdentifier != null) ? formCommissionInvitation.FormCommissionInvitationHeirIdentifier : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirCertificateNumber", (formCommissionInvitation.FormCommissionInvitationHeirCertificateNumber != null) ? formCommissionInvitation.FormCommissionInvitationHeirCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirIssuanceCity", (formCommissionInvitation.FormCommissionInvitationHeirIssuanceCity != null) ? formCommissionInvitation.FormCommissionInvitationHeirIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationDeadFullName", (formCommissionInvitation.FormCommissionInvitationDeadFullName != null) ? formCommissionInvitation.FormCommissionInvitationDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirRelation", (formCommissionInvitation.FormCommissionInvitationHeirRelation != null) ? formCommissionInvitation.FormCommissionInvitationHeirRelation : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirBirthDate", (formCommissionInvitation.FormCommissionInvitationHeirBirthDate != null) ? formCommissionInvitation.FormCommissionInvitationHeirBirthDate : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionDate", (formCommissionInvitation.FormCommissionInvitationCommissionDate != null) ? formCommissionInvitation.FormCommissionInvitationCommissionDate : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationCommissionTime", (formCommissionInvitation.FormCommissionInvitationCommissionTime != null) ? formCommissionInvitation.FormCommissionInvitationCommissionTime : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationPenaltyDate", (formCommissionInvitation.FormCommissionInvitationPenaltyDate != null) ? formCommissionInvitation.FormCommissionInvitationPenaltyDate : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationRegisterInformarionID", formCommissionInvitation.FormCommissionInvitationRegisterInformarionID),
			new SqlParameter("@FormCommissionInvitationHeirNationalCode", (formCommissionInvitation.FormCommissionInvitationHeirNationalCode != null) ? formCommissionInvitation.FormCommissionInvitationHeirNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationDeclarationID", (formCommissionInvitation.FormCommissionInvitationDeclarationID != null && formCommissionInvitation.FormCommissionInvitationDeclarationID >0 ) ? formCommissionInvitation.FormCommissionInvitationDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationRegisterDate", (formCommissionInvitation.FormCommissionInvitationRegisterDate != null) ? formCommissionInvitation.FormCommissionInvitationRegisterDate : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationDossierClasses", (formCommissionInvitation.FormCommissionInvitationDossierClasses != null) ? formCommissionInvitation.FormCommissionInvitationDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationTaxOfficeProvince", (formCommissionInvitation.FormCommissionInvitationTaxOfficeProvince != null) ? formCommissionInvitation.FormCommissionInvitationTaxOfficeProvince : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationTaxOfficeCity", (formCommissionInvitation.FormCommissionInvitationTaxOfficeCity != null) ? formCommissionInvitation.FormCommissionInvitationTaxOfficeCity : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationTaxOfficeAddress", (formCommissionInvitation.FormCommissionInvitationTaxOfficeAddress != null) ? formCommissionInvitation.FormCommissionInvitationTaxOfficeAddress : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationTaxOfficePhoneNumber", (formCommissionInvitation.FormCommissionInvitationTaxOfficePhoneNumber != null) ? formCommissionInvitation.FormCommissionInvitationTaxOfficePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirFullName", (formCommissionInvitation.FormCommissionInvitationHeirFullName != null) ? formCommissionInvitation.FormCommissionInvitationHeirFullName : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationTaxUnitCode", (formCommissionInvitation.FormCommissionInvitationTaxUnitCode != null) ? formCommissionInvitation.FormCommissionInvitationTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirShare", (formCommissionInvitation.FormCommissionInvitationHeirShare != null) ? formCommissionInvitation.FormCommissionInvitationHeirShare : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirExemption", (formCommissionInvitation.FormCommissionInvitationHeirExemption != null) ? formCommissionInvitation.FormCommissionInvitationHeirExemption : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirIncludedIncome", (formCommissionInvitation.FormCommissionInvitationHeirIncludedIncome != null) ? formCommissionInvitation.FormCommissionInvitationHeirIncludedIncome : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationHeirTax", (formCommissionInvitation.FormCommissionInvitationHeirTax != null) ? formCommissionInvitation.FormCommissionInvitationHeirTax : (object)DBNull.Value),
			new SqlParameter("@FormCommissionInvitationPenaltySum", (formCommissionInvitation.FormCommissionInvitationPenaltySum != null) ? formCommissionInvitation.FormCommissionInvitationPenaltySum : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormCommissionInvitation_Update", CommandType.StoredProcedure, parametersFormCommissionInvitation);
	}

	public bool Delete(Int64 formCommissionInvitationID)
	{
		SqlParameter[] parametersFormCommissionInvitation = new SqlParameter[]
		{
			new SqlParameter("@FormCommissionInvitationID", formCommissionInvitationID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormCommissionInvitation_Delete", CommandType.StoredProcedure, parametersFormCommissionInvitation);
	}

	public FormCommissionInvitation GetDetails(Int64 formCommissionInvitationID)
	{
		FormCommissionInvitation formCommissionInvitation = new FormCommissionInvitation();

		SqlParameter[] parametersFormCommissionInvitation = new SqlParameter[]
		{
			new SqlParameter("@FormCommissionInvitationID", formCommissionInvitationID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormCommissionInvitation_GetDetails", CommandType.StoredProcedure, parametersFormCommissionInvitation))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				formCommissionInvitation.FormCommissionInvitationID = (row["FormCommissionInvitationID"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationID"]) : 0 ;
				formCommissionInvitation.FormCommissionInvitationPrintRegisterInformationID = row["FormCommissionInvitationPrintRegisterInformationID"].ToString();
				formCommissionInvitation.FormCommissionInvitationPrintRegisterDate = row["FormCommissionInvitationPrintRegisterDate"].ToString();
				formCommissionInvitation.FormCommissionInvitationTaxResource = row["FormCommissionInvitationTaxResource"].ToString();
				formCommissionInvitation.FormCommissionInvitationDeadDeathYear = row["FormCommissionInvitationDeadDeathYear"].ToString();
				formCommissionInvitation.FormCommissionInvitationCommissionAddress = row["FormCommissionInvitationCommissionAddress"].ToString();
				formCommissionInvitation.FormCommissionInvitationUser1FullName = row["FormCommissionInvitationUser1FullName"].ToString();
				formCommissionInvitation.FormCommissionInvitationUser1Code = row["FormCommissionInvitationUser1Code"].ToString();
				formCommissionInvitation.FormCommissionInvitationUser2FullName = row["FormCommissionInvitationUser2FullName"].ToString();
				formCommissionInvitation.FormCommissionInvitationUser2Code = row["FormCommissionInvitationUser2Code"].ToString();
				formCommissionInvitation.FormCommissionInvitationCommissionType3 = row["FormCommissionInvitationCommissionType3"].ToString();
				formCommissionInvitation.FormCommissionInvitationCommissionType4 = row["FormCommissionInvitationCommissionType4"].ToString();
				formCommissionInvitation.FormCommissionInvitationCommissionType5 = row["FormCommissionInvitationCommissionType5"].ToString();
				formCommissionInvitation.FormCommissionInvitationCommissionType6 = row["FormCommissionInvitationCommissionType6"].ToString();
				formCommissionInvitation.FormCommissionInvitationCommissionDay = row["FormCommissionInvitationCommissionDay"].ToString();
				formCommissionInvitation.FormCommissionInvitationCommissionTimePeriod = row["FormCommissionInvitationCommissionTimePeriod"].ToString();
				formCommissionInvitation.FormCommissionInvitationHeirJobZipCode = row["FormCommissionInvitationHeirJobZipCode"].ToString();
				formCommissionInvitation.FormCommissionInvitationInvitationType1 = row["FormCommissionInvitationInvitationType1"].ToString();
				formCommissionInvitation.FormCommissionInvitationInvitationType2 = row["FormCommissionInvitationInvitationType2"].ToString();
				formCommissionInvitation.FormCommissionInvitationInvitationType3 = row["FormCommissionInvitationInvitationType3"].ToString();
				formCommissionInvitation.FormCommissionInvitationCommissionType1 = row["FormCommissionInvitationCommissionType1"].ToString();
				formCommissionInvitation.FormCommissionInvitationCommissionType2 = row["FormCommissionInvitationCommissionType2"].ToString();
				formCommissionInvitation.FormCommissionInvitationDeadUniqueCode = row["FormCommissionInvitationDeadUniqueCode"].ToString();
				formCommissionInvitation.FormCommissionInvitationHeirJobAddress = row["FormCommissionInvitationHeirJobAddress"].ToString();
				formCommissionInvitation.FormCommissionInvitationHeirHomeAddress = row["FormCommissionInvitationHeirHomeAddress"].ToString();
				formCommissionInvitation.FormCommissionInvitationHeirHomePhoneNumber = row["FormCommissionInvitationHeirHomePhoneNumber"].ToString();
				formCommissionInvitation.FormCommissionInvitationHeirHomeJobPhoneNumber = row["FormCommissionInvitationHeirHomeJobPhoneNumber"].ToString();
				formCommissionInvitation.FormCommissionInvitationHeirHomeZipCode = row["FormCommissionInvitationHeirHomeZipCode"].ToString();
				formCommissionInvitation.FormCommissionInvitationHeirFatherName = row["FormCommissionInvitationHeirFatherName"].ToString();
				formCommissionInvitation.FormCommissionInvitationHeirIdentifier = row["FormCommissionInvitationHeirIdentifier"].ToString();
				formCommissionInvitation.FormCommissionInvitationHeirCertificateNumber = row["FormCommissionInvitationHeirCertificateNumber"].ToString();
				formCommissionInvitation.FormCommissionInvitationHeirIssuanceCity = row["FormCommissionInvitationHeirIssuanceCity"].ToString();
				formCommissionInvitation.FormCommissionInvitationDeadFullName = row["FormCommissionInvitationDeadFullName"].ToString();
				formCommissionInvitation.FormCommissionInvitationHeirRelation = row["FormCommissionInvitationHeirRelation"].ToString();
				formCommissionInvitation.FormCommissionInvitationHeirBirthDate = row["FormCommissionInvitationHeirBirthDate"].ToString();
				formCommissionInvitation.FormCommissionInvitationCommissionDate = row["FormCommissionInvitationCommissionDate"].ToString();
				formCommissionInvitation.FormCommissionInvitationCommissionTime = row["FormCommissionInvitationCommissionTime"].ToString();
				formCommissionInvitation.FormCommissionInvitationPenaltyDate = row["FormCommissionInvitationPenaltyDate"].ToString();
				formCommissionInvitation.FormCommissionInvitationRegisterInformarionID = (row["FormCommissionInvitationRegisterInformarionID"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationRegisterInformarionID"]) : 0 ;
				formCommissionInvitation.FormCommissionInvitationHeirNationalCode = (row["FormCommissionInvitationHeirNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationHeirNationalCode"]) : 0 ;
				formCommissionInvitation.FormCommissionInvitationDeclarationID = (row["FormCommissionInvitationDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationDeclarationID"]) : 0 ;
				formCommissionInvitation.FormCommissionInvitationRegisterDate = row["FormCommissionInvitationRegisterDate"].ToString();
				formCommissionInvitation.FormCommissionInvitationDossierClasses = row["FormCommissionInvitationDossierClasses"].ToString();
				formCommissionInvitation.FormCommissionInvitationTaxOfficeProvince = row["FormCommissionInvitationTaxOfficeProvince"].ToString();
				formCommissionInvitation.FormCommissionInvitationTaxOfficeCity = row["FormCommissionInvitationTaxOfficeCity"].ToString();
				formCommissionInvitation.FormCommissionInvitationTaxOfficeAddress = row["FormCommissionInvitationTaxOfficeAddress"].ToString();
				formCommissionInvitation.FormCommissionInvitationTaxOfficePhoneNumber = row["FormCommissionInvitationTaxOfficePhoneNumber"].ToString();
				formCommissionInvitation.FormCommissionInvitationHeirFullName = row["FormCommissionInvitationHeirFullName"].ToString();
				formCommissionInvitation.FormCommissionInvitationTaxUnitCode = (row["FormCommissionInvitationTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["FormCommissionInvitationTaxUnitCode"]) : 0 ;
				formCommissionInvitation.FormCommissionInvitationHeirShare = (row["FormCommissionInvitationHeirShare"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirShare"]) : 0 ;
				formCommissionInvitation.FormCommissionInvitationHeirExemption = (row["FormCommissionInvitationHeirExemption"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirExemption"]) : 0 ;
				formCommissionInvitation.FormCommissionInvitationHeirIncludedIncome = (row["FormCommissionInvitationHeirIncludedIncome"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirIncludedIncome"]) : 0 ;
				formCommissionInvitation.FormCommissionInvitationHeirTax = (row["FormCommissionInvitationHeirTax"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirTax"]) : 0 ;
				formCommissionInvitation.FormCommissionInvitationPenaltySum = (row["FormCommissionInvitationPenaltySum"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationPenaltySum"]) : 0 ;
			}
		}

		return formCommissionInvitation;
	}

	public List<FormCommissionInvitation> GetListAll()
	{
		List<FormCommissionInvitation> listFormCommissionInvitation = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormCommissionInvitation_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormCommissionInvitation = new List<FormCommissionInvitation>();

				foreach (DataRow row in table.Rows)
				{
					FormCommissionInvitation formCommissionInvitation = new FormCommissionInvitation();
					formCommissionInvitation.FormCommissionInvitationID = (row["FormCommissionInvitationID"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationID"]) : 0 ;
					formCommissionInvitation.FormCommissionInvitationPrintRegisterInformationID = row["FormCommissionInvitationPrintRegisterInformationID"].ToString();
					formCommissionInvitation.FormCommissionInvitationPrintRegisterDate = row["FormCommissionInvitationPrintRegisterDate"].ToString();
					formCommissionInvitation.FormCommissionInvitationTaxResource = row["FormCommissionInvitationTaxResource"].ToString();
					formCommissionInvitation.FormCommissionInvitationDeadDeathYear = row["FormCommissionInvitationDeadDeathYear"].ToString();
					formCommissionInvitation.FormCommissionInvitationCommissionAddress = row["FormCommissionInvitationCommissionAddress"].ToString();
					formCommissionInvitation.FormCommissionInvitationUser1FullName = row["FormCommissionInvitationUser1FullName"].ToString();
					formCommissionInvitation.FormCommissionInvitationUser1Code = row["FormCommissionInvitationUser1Code"].ToString();
					formCommissionInvitation.FormCommissionInvitationUser2FullName = row["FormCommissionInvitationUser2FullName"].ToString();
					formCommissionInvitation.FormCommissionInvitationUser2Code = row["FormCommissionInvitationUser2Code"].ToString();
					formCommissionInvitation.FormCommissionInvitationCommissionType3 = row["FormCommissionInvitationCommissionType3"].ToString();
					formCommissionInvitation.FormCommissionInvitationCommissionType4 = row["FormCommissionInvitationCommissionType4"].ToString();
					formCommissionInvitation.FormCommissionInvitationCommissionType5 = row["FormCommissionInvitationCommissionType5"].ToString();
					formCommissionInvitation.FormCommissionInvitationCommissionType6 = row["FormCommissionInvitationCommissionType6"].ToString();
					formCommissionInvitation.FormCommissionInvitationCommissionDay = row["FormCommissionInvitationCommissionDay"].ToString();
					formCommissionInvitation.FormCommissionInvitationCommissionTimePeriod = row["FormCommissionInvitationCommissionTimePeriod"].ToString();
					formCommissionInvitation.FormCommissionInvitationHeirJobZipCode = row["FormCommissionInvitationHeirJobZipCode"].ToString();
					formCommissionInvitation.FormCommissionInvitationInvitationType1 = row["FormCommissionInvitationInvitationType1"].ToString();
					formCommissionInvitation.FormCommissionInvitationInvitationType2 = row["FormCommissionInvitationInvitationType2"].ToString();
					formCommissionInvitation.FormCommissionInvitationInvitationType3 = row["FormCommissionInvitationInvitationType3"].ToString();
					formCommissionInvitation.FormCommissionInvitationCommissionType1 = row["FormCommissionInvitationCommissionType1"].ToString();
					formCommissionInvitation.FormCommissionInvitationCommissionType2 = row["FormCommissionInvitationCommissionType2"].ToString();
					formCommissionInvitation.FormCommissionInvitationDeadUniqueCode = row["FormCommissionInvitationDeadUniqueCode"].ToString();
					formCommissionInvitation.FormCommissionInvitationHeirJobAddress = row["FormCommissionInvitationHeirJobAddress"].ToString();
					formCommissionInvitation.FormCommissionInvitationHeirHomeAddress = row["FormCommissionInvitationHeirHomeAddress"].ToString();
					formCommissionInvitation.FormCommissionInvitationHeirHomePhoneNumber = row["FormCommissionInvitationHeirHomePhoneNumber"].ToString();
					formCommissionInvitation.FormCommissionInvitationHeirHomeJobPhoneNumber = row["FormCommissionInvitationHeirHomeJobPhoneNumber"].ToString();
					formCommissionInvitation.FormCommissionInvitationHeirHomeZipCode = row["FormCommissionInvitationHeirHomeZipCode"].ToString();
					formCommissionInvitation.FormCommissionInvitationHeirFatherName = row["FormCommissionInvitationHeirFatherName"].ToString();
					formCommissionInvitation.FormCommissionInvitationHeirIdentifier = row["FormCommissionInvitationHeirIdentifier"].ToString();
					formCommissionInvitation.FormCommissionInvitationHeirCertificateNumber = row["FormCommissionInvitationHeirCertificateNumber"].ToString();
					formCommissionInvitation.FormCommissionInvitationHeirIssuanceCity = row["FormCommissionInvitationHeirIssuanceCity"].ToString();
					formCommissionInvitation.FormCommissionInvitationDeadFullName = row["FormCommissionInvitationDeadFullName"].ToString();
					formCommissionInvitation.FormCommissionInvitationHeirRelation = row["FormCommissionInvitationHeirRelation"].ToString();
					formCommissionInvitation.FormCommissionInvitationHeirBirthDate = row["FormCommissionInvitationHeirBirthDate"].ToString();
					formCommissionInvitation.FormCommissionInvitationCommissionDate = row["FormCommissionInvitationCommissionDate"].ToString();
					formCommissionInvitation.FormCommissionInvitationCommissionTime = row["FormCommissionInvitationCommissionTime"].ToString();
					formCommissionInvitation.FormCommissionInvitationPenaltyDate = row["FormCommissionInvitationPenaltyDate"].ToString();
					formCommissionInvitation.FormCommissionInvitationRegisterInformarionID = (row["FormCommissionInvitationRegisterInformarionID"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationRegisterInformarionID"]) : 0 ;
					formCommissionInvitation.FormCommissionInvitationHeirNationalCode = (row["FormCommissionInvitationHeirNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationHeirNationalCode"]) : 0 ;
					formCommissionInvitation.FormCommissionInvitationDeclarationID = (row["FormCommissionInvitationDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationDeclarationID"]) : 0 ;
					formCommissionInvitation.FormCommissionInvitationRegisterDate = row["FormCommissionInvitationRegisterDate"].ToString();
					formCommissionInvitation.FormCommissionInvitationDossierClasses = row["FormCommissionInvitationDossierClasses"].ToString();
					formCommissionInvitation.FormCommissionInvitationTaxOfficeProvince = row["FormCommissionInvitationTaxOfficeProvince"].ToString();
					formCommissionInvitation.FormCommissionInvitationTaxOfficeCity = row["FormCommissionInvitationTaxOfficeCity"].ToString();
					formCommissionInvitation.FormCommissionInvitationTaxOfficeAddress = row["FormCommissionInvitationTaxOfficeAddress"].ToString();
					formCommissionInvitation.FormCommissionInvitationTaxOfficePhoneNumber = row["FormCommissionInvitationTaxOfficePhoneNumber"].ToString();
					formCommissionInvitation.FormCommissionInvitationHeirFullName = row["FormCommissionInvitationHeirFullName"].ToString();
					formCommissionInvitation.FormCommissionInvitationTaxUnitCode = (row["FormCommissionInvitationTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["FormCommissionInvitationTaxUnitCode"]) : 0 ;
					formCommissionInvitation.FormCommissionInvitationHeirShare = (row["FormCommissionInvitationHeirShare"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirShare"]) : 0 ;
					formCommissionInvitation.FormCommissionInvitationHeirExemption = (row["FormCommissionInvitationHeirExemption"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirExemption"]) : 0 ;
					formCommissionInvitation.FormCommissionInvitationHeirIncludedIncome = (row["FormCommissionInvitationHeirIncludedIncome"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirIncludedIncome"]) : 0 ;
					formCommissionInvitation.FormCommissionInvitationHeirTax = (row["FormCommissionInvitationHeirTax"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirTax"]) : 0 ;
					formCommissionInvitation.FormCommissionInvitationPenaltySum = (row["FormCommissionInvitationPenaltySum"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationPenaltySum"]) : 0 ;
					listFormCommissionInvitation.Add(formCommissionInvitation);
				}
			}
		}

		return listFormCommissionInvitation;
	}

	public bool Exists(Int64 formCommissionInvitationID)
	{
		SqlParameter[] parametersFormCommissionInvitation = new SqlParameter[]
		{
			new SqlParameter("@FormCommissionInvitationID", formCommissionInvitationID)
		};
		return (SqlDBHelper.ExecuteScalar("FormCommissionInvitation_Exists", CommandType.StoredProcedure, parametersFormCommissionInvitation)>0);
	}

	public bool Exists(FormCommissionInvitation formCommissionInvitation)
	{
		SqlParameter[] parametersFormCommissionInvitation = new SqlParameter[]
		{
			new SqlParameter("@FormCommissionInvitationID", formCommissionInvitation.FormCommissionInvitationID)
		};
		return (SqlDBHelper.ExecuteScalar("FormCommissionInvitation_Exists", CommandType.StoredProcedure, parametersFormCommissionInvitation)>0);
	}

	public List<FormCommissionInvitation> SearchLike(FormCommissionInvitation formCommissionInvitation)
	{
		List<FormCommissionInvitation> listFormCommissionInvitation = new List<FormCommissionInvitation>();


		SqlParameter[] parametersFormCommissionInvitation = new SqlParameter[]
		{
			new SqlParameter("@FormCommissionInvitationID", formCommissionInvitation.FormCommissionInvitationID),
			new SqlParameter("@FormCommissionInvitationPrintRegisterInformationID", formCommissionInvitation.FormCommissionInvitationPrintRegisterInformationID),
			new SqlParameter("@FormCommissionInvitationPrintRegisterDate", formCommissionInvitation.FormCommissionInvitationPrintRegisterDate),
			new SqlParameter("@FormCommissionInvitationTaxResource", formCommissionInvitation.FormCommissionInvitationTaxResource),
			new SqlParameter("@FormCommissionInvitationDeadDeathYear", formCommissionInvitation.FormCommissionInvitationDeadDeathYear),
			new SqlParameter("@FormCommissionInvitationCommissionAddress", formCommissionInvitation.FormCommissionInvitationCommissionAddress),
			new SqlParameter("@FormCommissionInvitationUser1FullName", formCommissionInvitation.FormCommissionInvitationUser1FullName),
			new SqlParameter("@FormCommissionInvitationUser1Code", formCommissionInvitation.FormCommissionInvitationUser1Code),
			new SqlParameter("@FormCommissionInvitationUser2FullName", formCommissionInvitation.FormCommissionInvitationUser2FullName),
			new SqlParameter("@FormCommissionInvitationUser2Code", formCommissionInvitation.FormCommissionInvitationUser2Code),
			new SqlParameter("@FormCommissionInvitationCommissionType3", formCommissionInvitation.FormCommissionInvitationCommissionType3),
			new SqlParameter("@FormCommissionInvitationCommissionType4", formCommissionInvitation.FormCommissionInvitationCommissionType4),
			new SqlParameter("@FormCommissionInvitationCommissionType5", formCommissionInvitation.FormCommissionInvitationCommissionType5),
			new SqlParameter("@FormCommissionInvitationCommissionType6", formCommissionInvitation.FormCommissionInvitationCommissionType6),
			new SqlParameter("@FormCommissionInvitationCommissionDay", formCommissionInvitation.FormCommissionInvitationCommissionDay),
			new SqlParameter("@FormCommissionInvitationCommissionTimePeriod", formCommissionInvitation.FormCommissionInvitationCommissionTimePeriod),
			new SqlParameter("@FormCommissionInvitationHeirJobZipCode", formCommissionInvitation.FormCommissionInvitationHeirJobZipCode),
			new SqlParameter("@FormCommissionInvitationInvitationType1", formCommissionInvitation.FormCommissionInvitationInvitationType1),
			new SqlParameter("@FormCommissionInvitationInvitationType2", formCommissionInvitation.FormCommissionInvitationInvitationType2),
			new SqlParameter("@FormCommissionInvitationInvitationType3", formCommissionInvitation.FormCommissionInvitationInvitationType3),
			new SqlParameter("@FormCommissionInvitationCommissionType1", formCommissionInvitation.FormCommissionInvitationCommissionType1),
			new SqlParameter("@FormCommissionInvitationCommissionType2", formCommissionInvitation.FormCommissionInvitationCommissionType2),
			new SqlParameter("@FormCommissionInvitationDeadUniqueCode", formCommissionInvitation.FormCommissionInvitationDeadUniqueCode),
			new SqlParameter("@FormCommissionInvitationHeirJobAddress", formCommissionInvitation.FormCommissionInvitationHeirJobAddress),
			new SqlParameter("@FormCommissionInvitationHeirHomeAddress", formCommissionInvitation.FormCommissionInvitationHeirHomeAddress),
			new SqlParameter("@FormCommissionInvitationHeirHomePhoneNumber", formCommissionInvitation.FormCommissionInvitationHeirHomePhoneNumber),
			new SqlParameter("@FormCommissionInvitationHeirHomeJobPhoneNumber", formCommissionInvitation.FormCommissionInvitationHeirHomeJobPhoneNumber),
			new SqlParameter("@FormCommissionInvitationHeirHomeZipCode", formCommissionInvitation.FormCommissionInvitationHeirHomeZipCode),
			new SqlParameter("@FormCommissionInvitationHeirFatherName", formCommissionInvitation.FormCommissionInvitationHeirFatherName),
			new SqlParameter("@FormCommissionInvitationHeirIdentifier", formCommissionInvitation.FormCommissionInvitationHeirIdentifier),
			new SqlParameter("@FormCommissionInvitationHeirCertificateNumber", formCommissionInvitation.FormCommissionInvitationHeirCertificateNumber),
			new SqlParameter("@FormCommissionInvitationHeirIssuanceCity", formCommissionInvitation.FormCommissionInvitationHeirIssuanceCity),
			new SqlParameter("@FormCommissionInvitationDeadFullName", formCommissionInvitation.FormCommissionInvitationDeadFullName),
			new SqlParameter("@FormCommissionInvitationHeirRelation", formCommissionInvitation.FormCommissionInvitationHeirRelation),
			new SqlParameter("@FormCommissionInvitationHeirBirthDate", formCommissionInvitation.FormCommissionInvitationHeirBirthDate),
			new SqlParameter("@FormCommissionInvitationCommissionDate", formCommissionInvitation.FormCommissionInvitationCommissionDate),
			new SqlParameter("@FormCommissionInvitationCommissionTime", formCommissionInvitation.FormCommissionInvitationCommissionTime),
			new SqlParameter("@FormCommissionInvitationPenaltyDate", formCommissionInvitation.FormCommissionInvitationPenaltyDate),
			new SqlParameter("@FormCommissionInvitationRegisterInformarionID", formCommissionInvitation.FormCommissionInvitationRegisterInformarionID),
			new SqlParameter("@FormCommissionInvitationHeirNationalCode", formCommissionInvitation.FormCommissionInvitationHeirNationalCode),
			new SqlParameter("@FormCommissionInvitationDeclarationID", formCommissionInvitation.FormCommissionInvitationDeclarationID),
			new SqlParameter("@FormCommissionInvitationRegisterDate", formCommissionInvitation.FormCommissionInvitationRegisterDate),
			new SqlParameter("@FormCommissionInvitationDossierClasses", formCommissionInvitation.FormCommissionInvitationDossierClasses),
			new SqlParameter("@FormCommissionInvitationTaxOfficeProvince", formCommissionInvitation.FormCommissionInvitationTaxOfficeProvince),
			new SqlParameter("@FormCommissionInvitationTaxOfficeCity", formCommissionInvitation.FormCommissionInvitationTaxOfficeCity),
			new SqlParameter("@FormCommissionInvitationTaxOfficeAddress", formCommissionInvitation.FormCommissionInvitationTaxOfficeAddress),
			new SqlParameter("@FormCommissionInvitationTaxOfficePhoneNumber", formCommissionInvitation.FormCommissionInvitationTaxOfficePhoneNumber),
			new SqlParameter("@FormCommissionInvitationHeirFullName", formCommissionInvitation.FormCommissionInvitationHeirFullName),
			new SqlParameter("@FormCommissionInvitationTaxUnitCode", formCommissionInvitation.FormCommissionInvitationTaxUnitCode),
			new SqlParameter("@FormCommissionInvitationHeirShare", formCommissionInvitation.FormCommissionInvitationHeirShare),
			new SqlParameter("@FormCommissionInvitationHeirExemption", formCommissionInvitation.FormCommissionInvitationHeirExemption),
			new SqlParameter("@FormCommissionInvitationHeirIncludedIncome", formCommissionInvitation.FormCommissionInvitationHeirIncludedIncome),
			new SqlParameter("@FormCommissionInvitationHeirTax", formCommissionInvitation.FormCommissionInvitationHeirTax),
			new SqlParameter("@FormCommissionInvitationPenaltySum", formCommissionInvitation.FormCommissionInvitationPenaltySum),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormCommissionInvitation_SearchLike", CommandType.StoredProcedure, parametersFormCommissionInvitation))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormCommissionInvitation tmpFormCommissionInvitation = new FormCommissionInvitation();
					tmpFormCommissionInvitation.FormCommissionInvitationID = (row["FormCommissionInvitationID"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationID"]) : 0 ;
					tmpFormCommissionInvitation.FormCommissionInvitationPrintRegisterInformationID = row["FormCommissionInvitationPrintRegisterInformationID"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationPrintRegisterDate = row["FormCommissionInvitationPrintRegisterDate"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationTaxResource = row["FormCommissionInvitationTaxResource"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationDeadDeathYear = row["FormCommissionInvitationDeadDeathYear"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationCommissionAddress = row["FormCommissionInvitationCommissionAddress"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationUser1FullName = row["FormCommissionInvitationUser1FullName"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationUser1Code = row["FormCommissionInvitationUser1Code"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationUser2FullName = row["FormCommissionInvitationUser2FullName"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationUser2Code = row["FormCommissionInvitationUser2Code"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationCommissionType3 = row["FormCommissionInvitationCommissionType3"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationCommissionType4 = row["FormCommissionInvitationCommissionType4"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationCommissionType5 = row["FormCommissionInvitationCommissionType5"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationCommissionType6 = row["FormCommissionInvitationCommissionType6"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationCommissionDay = row["FormCommissionInvitationCommissionDay"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationCommissionTimePeriod = row["FormCommissionInvitationCommissionTimePeriod"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationHeirJobZipCode = row["FormCommissionInvitationHeirJobZipCode"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationInvitationType1 = row["FormCommissionInvitationInvitationType1"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationInvitationType2 = row["FormCommissionInvitationInvitationType2"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationInvitationType3 = row["FormCommissionInvitationInvitationType3"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationCommissionType1 = row["FormCommissionInvitationCommissionType1"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationCommissionType2 = row["FormCommissionInvitationCommissionType2"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationDeadUniqueCode = row["FormCommissionInvitationDeadUniqueCode"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationHeirJobAddress = row["FormCommissionInvitationHeirJobAddress"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationHeirHomeAddress = row["FormCommissionInvitationHeirHomeAddress"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationHeirHomePhoneNumber = row["FormCommissionInvitationHeirHomePhoneNumber"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationHeirHomeJobPhoneNumber = row["FormCommissionInvitationHeirHomeJobPhoneNumber"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationHeirHomeZipCode = row["FormCommissionInvitationHeirHomeZipCode"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationHeirFatherName = row["FormCommissionInvitationHeirFatherName"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationHeirIdentifier = row["FormCommissionInvitationHeirIdentifier"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationHeirCertificateNumber = row["FormCommissionInvitationHeirCertificateNumber"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationHeirIssuanceCity = row["FormCommissionInvitationHeirIssuanceCity"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationDeadFullName = row["FormCommissionInvitationDeadFullName"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationHeirRelation = row["FormCommissionInvitationHeirRelation"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationHeirBirthDate = row["FormCommissionInvitationHeirBirthDate"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationCommissionDate = row["FormCommissionInvitationCommissionDate"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationCommissionTime = row["FormCommissionInvitationCommissionTime"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationPenaltyDate = row["FormCommissionInvitationPenaltyDate"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationRegisterInformarionID = (row["FormCommissionInvitationRegisterInformarionID"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationRegisterInformarionID"]) : 0 ;
					tmpFormCommissionInvitation.FormCommissionInvitationHeirNationalCode = (row["FormCommissionInvitationHeirNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationHeirNationalCode"]) : 0 ;
					tmpFormCommissionInvitation.FormCommissionInvitationDeclarationID = (row["FormCommissionInvitationDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationDeclarationID"]) : 0 ;
					tmpFormCommissionInvitation.FormCommissionInvitationRegisterDate = row["FormCommissionInvitationRegisterDate"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationDossierClasses = row["FormCommissionInvitationDossierClasses"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationTaxOfficeProvince = row["FormCommissionInvitationTaxOfficeProvince"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationTaxOfficeCity = row["FormCommissionInvitationTaxOfficeCity"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationTaxOfficeAddress = row["FormCommissionInvitationTaxOfficeAddress"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationTaxOfficePhoneNumber = row["FormCommissionInvitationTaxOfficePhoneNumber"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationHeirFullName = row["FormCommissionInvitationHeirFullName"].ToString();
					tmpFormCommissionInvitation.FormCommissionInvitationTaxUnitCode = (row["FormCommissionInvitationTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["FormCommissionInvitationTaxUnitCode"]) : 0 ;
					tmpFormCommissionInvitation.FormCommissionInvitationHeirShare = (row["FormCommissionInvitationHeirShare"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirShare"]) : 0 ;
					tmpFormCommissionInvitation.FormCommissionInvitationHeirExemption = (row["FormCommissionInvitationHeirExemption"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirExemption"]) : 0 ;
					tmpFormCommissionInvitation.FormCommissionInvitationHeirIncludedIncome = (row["FormCommissionInvitationHeirIncludedIncome"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirIncludedIncome"]) : 0 ;
					tmpFormCommissionInvitation.FormCommissionInvitationHeirTax = (row["FormCommissionInvitationHeirTax"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirTax"]) : 0 ;
					tmpFormCommissionInvitation.FormCommissionInvitationPenaltySum = (row["FormCommissionInvitationPenaltySum"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationPenaltySum"]) : 0 ;

					listFormCommissionInvitation.Add(tmpFormCommissionInvitation);
				}
			}
		}

		return listFormCommissionInvitation;
	}

}
}
