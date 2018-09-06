using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormDeterministicPaperDBAccess
{


	public Int64 Insert(FormDeterministicPaper formDeterministicPaper)
	{
		SqlParameter[] parametersFormDeterministicPaper = new SqlParameter[]
		{
			new SqlParameter("@FormDeterministicPaperReductionType", (formDeterministicPaper.FormDeterministicPaperReductionType != null) ? formDeterministicPaper.FormDeterministicPaperReductionType : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperPenaltyReason", (formDeterministicPaper.FormDeterministicPaperPenaltyReason != null) ? formDeterministicPaper.FormDeterministicPaperPenaltyReason : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperComment", (formDeterministicPaper.FormDeterministicPaperComment != null) ? formDeterministicPaper.FormDeterministicPaperComment : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperUser1Code", (formDeterministicPaper.FormDeterministicPaperUser1Code != null) ? formDeterministicPaper.FormDeterministicPaperUser1Code : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperUser1FullName", (formDeterministicPaper.FormDeterministicPaperUser1FullName != null) ? formDeterministicPaper.FormDeterministicPaperUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperOperationYear2", (formDeterministicPaper.FormDeterministicPaperOperationYear2 != null) ? formDeterministicPaper.FormDeterministicPaperOperationYear2 : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirJobZipCode", (formDeterministicPaper.FormDeterministicPaperHeirJobZipCode != null) ? formDeterministicPaper.FormDeterministicPaperHeirJobZipCode : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirHomeZipCode", (formDeterministicPaper.FormDeterministicPaperHeirHomeZipCode != null) ? formDeterministicPaper.FormDeterministicPaperHeirHomeZipCode : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirIdentifier", (formDeterministicPaper.FormDeterministicPaperHeirIdentifier != null) ? formDeterministicPaper.FormDeterministicPaperHeirIdentifier : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxTitle", (formDeterministicPaper.FormDeterministicPaperTaxTitle != null) ? formDeterministicPaper.FormDeterministicPaperTaxTitle : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxReason", (formDeterministicPaper.FormDeterministicPaperTaxReason != null) ? formDeterministicPaper.FormDeterministicPaperTaxReason : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxNumber", (formDeterministicPaper.FormDeterministicPaperTaxNumber != null) ? formDeterministicPaper.FormDeterministicPaperTaxNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirIssuanceDepartmant", (formDeterministicPaper.FormDeterministicPaperHeirIssuanceDepartmant != null) ? formDeterministicPaper.FormDeterministicPaperHeirIssuanceDepartmant : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirIssuanceCity", (formDeterministicPaper.FormDeterministicPaperHeirIssuanceCity != null) ? formDeterministicPaper.FormDeterministicPaperHeirIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirJobAddress", (formDeterministicPaper.FormDeterministicPaperHeirJobAddress != null) ? formDeterministicPaper.FormDeterministicPaperHeirJobAddress : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirHomeAddress", (formDeterministicPaper.FormDeterministicPaperHeirHomeAddress != null) ? formDeterministicPaper.FormDeterministicPaperHeirHomeAddress : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirJobPhoneNumber", (formDeterministicPaper.FormDeterministicPaperHeirJobPhoneNumber != null) ? formDeterministicPaper.FormDeterministicPaperHeirJobPhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirHomePhoneNumber", (formDeterministicPaper.FormDeterministicPaperHeirHomePhoneNumber != null) ? formDeterministicPaper.FormDeterministicPaperHeirHomePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirName", (formDeterministicPaper.FormDeterministicPaperHeirName != null) ? formDeterministicPaper.FormDeterministicPaperHeirName : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirFamily", (formDeterministicPaper.FormDeterministicPaperHeirFamily != null) ? formDeterministicPaper.FormDeterministicPaperHeirFamily : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirFatherName", (formDeterministicPaper.FormDeterministicPaperHeirFatherName != null) ? formDeterministicPaper.FormDeterministicPaperHeirFatherName : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirCertificateNumber", (formDeterministicPaper.FormDeterministicPaperHeirCertificateNumber != null) ? formDeterministicPaper.FormDeterministicPaperHeirCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirNationalCode", (formDeterministicPaper.FormDeterministicPaperHeirNationalCode != null) ? formDeterministicPaper.FormDeterministicPaperHeirNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirIssuanceDate", (formDeterministicPaper.FormDeterministicPaperHeirIssuanceDate != null) ? formDeterministicPaper.FormDeterministicPaperHeirIssuanceDate : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperDossierClasses", (formDeterministicPaper.FormDeterministicPaperDossierClasses != null) ? formDeterministicPaper.FormDeterministicPaperDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperRegisterInformationID", (formDeterministicPaper.FormDeterministicPaperRegisterInformationID > 0) ? formDeterministicPaper.FormDeterministicPaperRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperDeclarationID", (formDeterministicPaper.FormDeterministicPaperDeclarationID > 0) ? formDeterministicPaper.FormDeterministicPaperDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperRegisterarUserNationalCode", (formDeterministicPaper.FormDeterministicPaperRegisterarUserNationalCode > 0) ? formDeterministicPaper.FormDeterministicPaperRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperRegisterInformationDate", (formDeterministicPaper.FormDeterministicPaperRegisterInformationDate != null) ? formDeterministicPaper.FormDeterministicPaperRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxDate", (formDeterministicPaper.FormDeterministicPaperTaxDate != null) ? formDeterministicPaper.FormDeterministicPaperTaxDate : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperAnnonsiationDate", (formDeterministicPaper.FormDeterministicPaperAnnonsiationDate != null) ? formDeterministicPaper.FormDeterministicPaperAnnonsiationDate : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperReductionDate", (formDeterministicPaper.FormDeterministicPaperReductionDate != null) ? formDeterministicPaper.FormDeterministicPaperReductionDate : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperPenaltyDate", (formDeterministicPaper.FormDeterministicPaperPenaltyDate != null) ? formDeterministicPaper.FormDeterministicPaperPenaltyDate : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperOperationYear1", (formDeterministicPaper.FormDeterministicPaperOperationYear1 != null) ? formDeterministicPaper.FormDeterministicPaperOperationYear1 : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxOfficeProvince", (formDeterministicPaper.FormDeterministicPaperTaxOfficeProvince != null) ? formDeterministicPaper.FormDeterministicPaperTaxOfficeProvince : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxOfficeCode", (formDeterministicPaper.FormDeterministicPaperTaxOfficeCode != null) ? formDeterministicPaper.FormDeterministicPaperTaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxUintCode", (formDeterministicPaper.FormDeterministicPaperTaxUintCode != null) ? formDeterministicPaper.FormDeterministicPaperTaxUintCode : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxOfficeAddress", (formDeterministicPaper.FormDeterministicPaperTaxOfficeAddress != null) ? formDeterministicPaper.FormDeterministicPaperTaxOfficeAddress : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxOfficePhoneNumber", (formDeterministicPaper.FormDeterministicPaperTaxOfficePhoneNumber != null) ? formDeterministicPaper.FormDeterministicPaperTaxOfficePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperPayableTaxLetter", (formDeterministicPaper.FormDeterministicPaperPayableTaxLetter != null) ? formDeterministicPaper.FormDeterministicPaperPayableTaxLetter : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxTitle2", (formDeterministicPaper.FormDeterministicPaperTaxTitle2 != null) ? formDeterministicPaper.FormDeterministicPaperTaxTitle2 : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxBase", (formDeterministicPaper.FormDeterministicPaperTaxBase != null) ? formDeterministicPaper.FormDeterministicPaperTaxBase : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxReduction", (formDeterministicPaper.FormDeterministicPaperTaxReduction != null) ? formDeterministicPaper.FormDeterministicPaperTaxReduction : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxRemaining", (formDeterministicPaper.FormDeterministicPaperTaxRemaining != null) ? formDeterministicPaper.FormDeterministicPaperTaxRemaining : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTax", (formDeterministicPaper.FormDeterministicPaperTax != null) ? formDeterministicPaper.FormDeterministicPaperTax : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperReduction", (formDeterministicPaper.FormDeterministicPaperReduction != null) ? formDeterministicPaper.FormDeterministicPaperReduction : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperPenalty", (formDeterministicPaper.FormDeterministicPaperPenalty != null) ? formDeterministicPaper.FormDeterministicPaperPenalty : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTotalWithoutPenalty", (formDeterministicPaper.FormDeterministicPaperTotalWithoutPenalty != null) ? formDeterministicPaper.FormDeterministicPaperTotalWithoutPenalty : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTotal", (formDeterministicPaper.FormDeterministicPaperTotal != null) ? formDeterministicPaper.FormDeterministicPaperTotal : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperPayableTax", (formDeterministicPaper.FormDeterministicPaperPayableTax != null) ? formDeterministicPaper.FormDeterministicPaperPayableTax : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxRemaining2", (formDeterministicPaper.FormDeterministicPaperTaxRemaining2 != null) ? formDeterministicPaper.FormDeterministicPaperTaxRemaining2 : (object)DBNull.Value)
		};
		formDeterministicPaper.FormDeterministicPaperID = SqlDBHelper.ExecuteScalar("FormDeterministicPaper_Insert", CommandType.StoredProcedure, parametersFormDeterministicPaper);
		return formDeterministicPaper.FormDeterministicPaperID;
	}

	public bool Update(FormDeterministicPaper formDeterministicPaper)
	{
		SqlParameter[] parametersFormDeterministicPaper = new SqlParameter[]
		{
			new SqlParameter("@FormDeterministicPaperID", formDeterministicPaper.FormDeterministicPaperID),
			new SqlParameter("@FormDeterministicPaperReductionType", (formDeterministicPaper.FormDeterministicPaperReductionType != null) ? formDeterministicPaper.FormDeterministicPaperReductionType : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperPenaltyReason", (formDeterministicPaper.FormDeterministicPaperPenaltyReason != null) ? formDeterministicPaper.FormDeterministicPaperPenaltyReason : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperComment", (formDeterministicPaper.FormDeterministicPaperComment != null) ? formDeterministicPaper.FormDeterministicPaperComment : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperUser1Code", (formDeterministicPaper.FormDeterministicPaperUser1Code != null) ? formDeterministicPaper.FormDeterministicPaperUser1Code : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperUser1FullName", (formDeterministicPaper.FormDeterministicPaperUser1FullName != null) ? formDeterministicPaper.FormDeterministicPaperUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperOperationYear2", (formDeterministicPaper.FormDeterministicPaperOperationYear2 != null) ? formDeterministicPaper.FormDeterministicPaperOperationYear2 : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirJobZipCode", (formDeterministicPaper.FormDeterministicPaperHeirJobZipCode != null) ? formDeterministicPaper.FormDeterministicPaperHeirJobZipCode : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirHomeZipCode", (formDeterministicPaper.FormDeterministicPaperHeirHomeZipCode != null) ? formDeterministicPaper.FormDeterministicPaperHeirHomeZipCode : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirIdentifier", (formDeterministicPaper.FormDeterministicPaperHeirIdentifier != null) ? formDeterministicPaper.FormDeterministicPaperHeirIdentifier : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxTitle", (formDeterministicPaper.FormDeterministicPaperTaxTitle != null) ? formDeterministicPaper.FormDeterministicPaperTaxTitle : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxReason", (formDeterministicPaper.FormDeterministicPaperTaxReason != null) ? formDeterministicPaper.FormDeterministicPaperTaxReason : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxNumber", (formDeterministicPaper.FormDeterministicPaperTaxNumber != null) ? formDeterministicPaper.FormDeterministicPaperTaxNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirIssuanceDepartmant", (formDeterministicPaper.FormDeterministicPaperHeirIssuanceDepartmant != null) ? formDeterministicPaper.FormDeterministicPaperHeirIssuanceDepartmant : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirIssuanceCity", (formDeterministicPaper.FormDeterministicPaperHeirIssuanceCity != null) ? formDeterministicPaper.FormDeterministicPaperHeirIssuanceCity : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirJobAddress", (formDeterministicPaper.FormDeterministicPaperHeirJobAddress != null) ? formDeterministicPaper.FormDeterministicPaperHeirJobAddress : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirHomeAddress", (formDeterministicPaper.FormDeterministicPaperHeirHomeAddress != null) ? formDeterministicPaper.FormDeterministicPaperHeirHomeAddress : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirJobPhoneNumber", (formDeterministicPaper.FormDeterministicPaperHeirJobPhoneNumber != null) ? formDeterministicPaper.FormDeterministicPaperHeirJobPhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirHomePhoneNumber", (formDeterministicPaper.FormDeterministicPaperHeirHomePhoneNumber != null) ? formDeterministicPaper.FormDeterministicPaperHeirHomePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirName", (formDeterministicPaper.FormDeterministicPaperHeirName != null) ? formDeterministicPaper.FormDeterministicPaperHeirName : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirFamily", (formDeterministicPaper.FormDeterministicPaperHeirFamily != null) ? formDeterministicPaper.FormDeterministicPaperHeirFamily : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirFatherName", (formDeterministicPaper.FormDeterministicPaperHeirFatherName != null) ? formDeterministicPaper.FormDeterministicPaperHeirFatherName : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirCertificateNumber", (formDeterministicPaper.FormDeterministicPaperHeirCertificateNumber != null) ? formDeterministicPaper.FormDeterministicPaperHeirCertificateNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirNationalCode", (formDeterministicPaper.FormDeterministicPaperHeirNationalCode != null) ? formDeterministicPaper.FormDeterministicPaperHeirNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperHeirIssuanceDate", (formDeterministicPaper.FormDeterministicPaperHeirIssuanceDate != null) ? formDeterministicPaper.FormDeterministicPaperHeirIssuanceDate : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperDossierClasses", (formDeterministicPaper.FormDeterministicPaperDossierClasses != null) ? formDeterministicPaper.FormDeterministicPaperDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperRegisterInformationID", (formDeterministicPaper.FormDeterministicPaperRegisterInformationID != null && formDeterministicPaper.FormDeterministicPaperRegisterInformationID >0 ) ? formDeterministicPaper.FormDeterministicPaperRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperDeclarationID", (formDeterministicPaper.FormDeterministicPaperDeclarationID != null && formDeterministicPaper.FormDeterministicPaperDeclarationID >0 ) ? formDeterministicPaper.FormDeterministicPaperDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperRegisterarUserNationalCode", (formDeterministicPaper.FormDeterministicPaperRegisterarUserNationalCode != null && formDeterministicPaper.FormDeterministicPaperRegisterarUserNationalCode >0 ) ? formDeterministicPaper.FormDeterministicPaperRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperRegisterInformationDate", (formDeterministicPaper.FormDeterministicPaperRegisterInformationDate != null) ? formDeterministicPaper.FormDeterministicPaperRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxDate", (formDeterministicPaper.FormDeterministicPaperTaxDate != null) ? formDeterministicPaper.FormDeterministicPaperTaxDate : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperAnnonsiationDate", (formDeterministicPaper.FormDeterministicPaperAnnonsiationDate != null) ? formDeterministicPaper.FormDeterministicPaperAnnonsiationDate : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperReductionDate", (formDeterministicPaper.FormDeterministicPaperReductionDate != null) ? formDeterministicPaper.FormDeterministicPaperReductionDate : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperPenaltyDate", (formDeterministicPaper.FormDeterministicPaperPenaltyDate != null) ? formDeterministicPaper.FormDeterministicPaperPenaltyDate : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperOperationYear1", (formDeterministicPaper.FormDeterministicPaperOperationYear1 != null) ? formDeterministicPaper.FormDeterministicPaperOperationYear1 : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxOfficeProvince", (formDeterministicPaper.FormDeterministicPaperTaxOfficeProvince != null) ? formDeterministicPaper.FormDeterministicPaperTaxOfficeProvince : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxOfficeCode", (formDeterministicPaper.FormDeterministicPaperTaxOfficeCode != null) ? formDeterministicPaper.FormDeterministicPaperTaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxUintCode", (formDeterministicPaper.FormDeterministicPaperTaxUintCode != null) ? formDeterministicPaper.FormDeterministicPaperTaxUintCode : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxOfficeAddress", (formDeterministicPaper.FormDeterministicPaperTaxOfficeAddress != null) ? formDeterministicPaper.FormDeterministicPaperTaxOfficeAddress : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxOfficePhoneNumber", (formDeterministicPaper.FormDeterministicPaperTaxOfficePhoneNumber != null) ? formDeterministicPaper.FormDeterministicPaperTaxOfficePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperPayableTaxLetter", (formDeterministicPaper.FormDeterministicPaperPayableTaxLetter != null) ? formDeterministicPaper.FormDeterministicPaperPayableTaxLetter : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxTitle2", (formDeterministicPaper.FormDeterministicPaperTaxTitle2 != null) ? formDeterministicPaper.FormDeterministicPaperTaxTitle2 : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxBase", (formDeterministicPaper.FormDeterministicPaperTaxBase != null) ? formDeterministicPaper.FormDeterministicPaperTaxBase : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxReduction", (formDeterministicPaper.FormDeterministicPaperTaxReduction != null) ? formDeterministicPaper.FormDeterministicPaperTaxReduction : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxRemaining", (formDeterministicPaper.FormDeterministicPaperTaxRemaining != null) ? formDeterministicPaper.FormDeterministicPaperTaxRemaining : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTax", (formDeterministicPaper.FormDeterministicPaperTax != null) ? formDeterministicPaper.FormDeterministicPaperTax : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperReduction", (formDeterministicPaper.FormDeterministicPaperReduction != null) ? formDeterministicPaper.FormDeterministicPaperReduction : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperPenalty", (formDeterministicPaper.FormDeterministicPaperPenalty != null) ? formDeterministicPaper.FormDeterministicPaperPenalty : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTotalWithoutPenalty", (formDeterministicPaper.FormDeterministicPaperTotalWithoutPenalty != null) ? formDeterministicPaper.FormDeterministicPaperTotalWithoutPenalty : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTotal", (formDeterministicPaper.FormDeterministicPaperTotal != null) ? formDeterministicPaper.FormDeterministicPaperTotal : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperPayableTax", (formDeterministicPaper.FormDeterministicPaperPayableTax != null) ? formDeterministicPaper.FormDeterministicPaperPayableTax : (object)DBNull.Value),
			new SqlParameter("@FormDeterministicPaperTaxRemaining2", (formDeterministicPaper.FormDeterministicPaperTaxRemaining2 != null) ? formDeterministicPaper.FormDeterministicPaperTaxRemaining2 : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormDeterministicPaper_Update", CommandType.StoredProcedure, parametersFormDeterministicPaper);
	}

	public bool Delete(Int64 formDeterministicPaperID)
	{
		SqlParameter[] parametersFormDeterministicPaper = new SqlParameter[]
		{
			new SqlParameter("@FormDeterministicPaperID", formDeterministicPaperID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormDeterministicPaper_Delete", CommandType.StoredProcedure, parametersFormDeterministicPaper);
	}

	public FormDeterministicPaper GetDetails(Int64 formDeterministicPaperID)
	{
		FormDeterministicPaper formDeterministicPaper = new FormDeterministicPaper();

		SqlParameter[] parametersFormDeterministicPaper = new SqlParameter[]
		{
			new SqlParameter("@FormDeterministicPaperID", formDeterministicPaperID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDeterministicPaper_GetDetails", CommandType.StoredProcedure, parametersFormDeterministicPaper))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				formDeterministicPaper.FormDeterministicPaperID = (row["FormDeterministicPaperID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperID"]) : 0 ;
				formDeterministicPaper.FormDeterministicPaperPrintRegisterInformationID = row["FormDeterministicPaperPrintRegisterInformationID"].ToString();
				formDeterministicPaper.FormDeterministicPaperPrintRegisterDate = row["FormDeterministicPaperPrintRegisterDate"].ToString();
				formDeterministicPaper.FormDeterministicPaperReductionType = row["FormDeterministicPaperReductionType"].ToString();
				formDeterministicPaper.FormDeterministicPaperPenaltyReason = row["FormDeterministicPaperPenaltyReason"].ToString();
				formDeterministicPaper.FormDeterministicPaperComment = row["FormDeterministicPaperComment"].ToString();
				formDeterministicPaper.FormDeterministicPaperUser1Code = row["FormDeterministicPaperUser1Code"].ToString();
				formDeterministicPaper.FormDeterministicPaperUser1FullName = row["FormDeterministicPaperUser1FullName"].ToString();
				formDeterministicPaper.FormDeterministicPaperOperationYear2 = row["FormDeterministicPaperOperationYear2"].ToString();
				formDeterministicPaper.FormDeterministicPaperHeirJobZipCode = row["FormDeterministicPaperHeirJobZipCode"].ToString();
				formDeterministicPaper.FormDeterministicPaperHeirHomeZipCode = row["FormDeterministicPaperHeirHomeZipCode"].ToString();
				formDeterministicPaper.FormDeterministicPaperHeirIdentifier = row["FormDeterministicPaperHeirIdentifier"].ToString();
				formDeterministicPaper.FormDeterministicPaperTaxTitle = row["FormDeterministicPaperTaxTitle"].ToString();
				formDeterministicPaper.FormDeterministicPaperTaxReason = row["FormDeterministicPaperTaxReason"].ToString();
				formDeterministicPaper.FormDeterministicPaperTaxNumber = row["FormDeterministicPaperTaxNumber"].ToString();
				formDeterministicPaper.FormDeterministicPaperHeirIssuanceDepartmant = row["FormDeterministicPaperHeirIssuanceDepartmant"].ToString();
				formDeterministicPaper.FormDeterministicPaperHeirIssuanceCity = row["FormDeterministicPaperHeirIssuanceCity"].ToString();
				formDeterministicPaper.FormDeterministicPaperHeirJobAddress = row["FormDeterministicPaperHeirJobAddress"].ToString();
				formDeterministicPaper.FormDeterministicPaperHeirHomeAddress = row["FormDeterministicPaperHeirHomeAddress"].ToString();
				formDeterministicPaper.FormDeterministicPaperHeirJobPhoneNumber = row["FormDeterministicPaperHeirJobPhoneNumber"].ToString();
				formDeterministicPaper.FormDeterministicPaperHeirHomePhoneNumber = row["FormDeterministicPaperHeirHomePhoneNumber"].ToString();
				formDeterministicPaper.FormDeterministicPaperHeirName = row["FormDeterministicPaperHeirName"].ToString();
				formDeterministicPaper.FormDeterministicPaperHeirFamily = row["FormDeterministicPaperHeirFamily"].ToString();
				formDeterministicPaper.FormDeterministicPaperHeirFatherName = row["FormDeterministicPaperHeirFatherName"].ToString();
				formDeterministicPaper.FormDeterministicPaperHeirCertificateNumber = row["FormDeterministicPaperHeirCertificateNumber"].ToString();
				formDeterministicPaper.FormDeterministicPaperHeirNationalCode = row["FormDeterministicPaperHeirNationalCode"].ToString();
				formDeterministicPaper.FormDeterministicPaperHeirIssuanceDate = row["FormDeterministicPaperHeirIssuanceDate"].ToString();
				formDeterministicPaper.FormDeterministicPaperDossierClasses = row["FormDeterministicPaperDossierClasses"].ToString();
				formDeterministicPaper.FormDeterministicPaperRegisterInformationID = (row["FormDeterministicPaperRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperRegisterInformationID"]) : 0 ;
				formDeterministicPaper.FormDeterministicPaperDeclarationID = (row["FormDeterministicPaperDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperDeclarationID"]) : 0 ;
				formDeterministicPaper.FormDeterministicPaperRegisterarUserNationalCode = (row["FormDeterministicPaperRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperRegisterarUserNationalCode"]) : 0 ;
				formDeterministicPaper.FormDeterministicPaperRegisterInformationDate = row["FormDeterministicPaperRegisterInformationDate"].ToString();
				formDeterministicPaper.FormDeterministicPaperTaxDate = row["FormDeterministicPaperTaxDate"].ToString();
				formDeterministicPaper.FormDeterministicPaperAnnonsiationDate = row["FormDeterministicPaperAnnonsiationDate"].ToString();
				formDeterministicPaper.FormDeterministicPaperReductionDate = row["FormDeterministicPaperReductionDate"].ToString();
				formDeterministicPaper.FormDeterministicPaperPenaltyDate = row["FormDeterministicPaperPenaltyDate"].ToString();
				formDeterministicPaper.FormDeterministicPaperOperationYear1 = row["FormDeterministicPaperOperationYear1"].ToString();
				formDeterministicPaper.FormDeterministicPaperTaxOfficeProvince = row["FormDeterministicPaperTaxOfficeProvince"].ToString();
				formDeterministicPaper.FormDeterministicPaperTaxOfficeCode = row["FormDeterministicPaperTaxOfficeCode"].ToString();
				formDeterministicPaper.FormDeterministicPaperTaxUintCode = row["FormDeterministicPaperTaxUintCode"].ToString();
				formDeterministicPaper.FormDeterministicPaperTaxOfficeAddress = row["FormDeterministicPaperTaxOfficeAddress"].ToString();
				formDeterministicPaper.FormDeterministicPaperTaxOfficePhoneNumber = row["FormDeterministicPaperTaxOfficePhoneNumber"].ToString();
				formDeterministicPaper.FormDeterministicPaperPayableTaxLetter = row["FormDeterministicPaperPayableTaxLetter"].ToString();
				formDeterministicPaper.FormDeterministicPaperTaxTitle2 = row["FormDeterministicPaperTaxTitle2"].ToString();
				formDeterministicPaper.FormDeterministicPaperTaxBase = (row["FormDeterministicPaperTaxBase"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxBase"]) : 0 ;
				formDeterministicPaper.FormDeterministicPaperTaxReduction = (row["FormDeterministicPaperTaxReduction"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxReduction"]) : 0 ;
				formDeterministicPaper.FormDeterministicPaperTaxRemaining = (row["FormDeterministicPaperTaxRemaining"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxRemaining"]) : 0 ;
				formDeterministicPaper.FormDeterministicPaperTax = (row["FormDeterministicPaperTax"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTax"]) : 0 ;
				formDeterministicPaper.FormDeterministicPaperReduction = (row["FormDeterministicPaperReduction"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperReduction"]) : 0 ;
				formDeterministicPaper.FormDeterministicPaperPenalty = (row["FormDeterministicPaperPenalty"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperPenalty"]) : 0 ;
				formDeterministicPaper.FormDeterministicPaperTotalWithoutPenalty = (row["FormDeterministicPaperTotalWithoutPenalty"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTotalWithoutPenalty"]) : 0 ;
				formDeterministicPaper.FormDeterministicPaperTotal = (row["FormDeterministicPaperTotal"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTotal"]) : 0 ;
				formDeterministicPaper.FormDeterministicPaperPayableTax = (row["FormDeterministicPaperPayableTax"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperPayableTax"]) : 0 ;
				formDeterministicPaper.FormDeterministicPaperTaxRemaining2 = (row["FormDeterministicPaperTaxRemaining2"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxRemaining2"]) : 0 ;
			}
		}

		return formDeterministicPaper;
	}

	public List<FormDeterministicPaper> GetListAll()
	{
		List<FormDeterministicPaper> listFormDeterministicPaper = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormDeterministicPaper_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormDeterministicPaper = new List<FormDeterministicPaper>();

				foreach (DataRow row in table.Rows)
				{
					FormDeterministicPaper formDeterministicPaper = new FormDeterministicPaper();
					formDeterministicPaper.FormDeterministicPaperID = (row["FormDeterministicPaperID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperID"]) : 0 ;
					formDeterministicPaper.FormDeterministicPaperPrintRegisterInformationID = row["FormDeterministicPaperPrintRegisterInformationID"].ToString();
					formDeterministicPaper.FormDeterministicPaperPrintRegisterDate = row["FormDeterministicPaperPrintRegisterDate"].ToString();
					formDeterministicPaper.FormDeterministicPaperReductionType = row["FormDeterministicPaperReductionType"].ToString();
					formDeterministicPaper.FormDeterministicPaperPenaltyReason = row["FormDeterministicPaperPenaltyReason"].ToString();
					formDeterministicPaper.FormDeterministicPaperComment = row["FormDeterministicPaperComment"].ToString();
					formDeterministicPaper.FormDeterministicPaperUser1Code = row["FormDeterministicPaperUser1Code"].ToString();
					formDeterministicPaper.FormDeterministicPaperUser1FullName = row["FormDeterministicPaperUser1FullName"].ToString();
					formDeterministicPaper.FormDeterministicPaperOperationYear2 = row["FormDeterministicPaperOperationYear2"].ToString();
					formDeterministicPaper.FormDeterministicPaperHeirJobZipCode = row["FormDeterministicPaperHeirJobZipCode"].ToString();
					formDeterministicPaper.FormDeterministicPaperHeirHomeZipCode = row["FormDeterministicPaperHeirHomeZipCode"].ToString();
					formDeterministicPaper.FormDeterministicPaperHeirIdentifier = row["FormDeterministicPaperHeirIdentifier"].ToString();
					formDeterministicPaper.FormDeterministicPaperTaxTitle = row["FormDeterministicPaperTaxTitle"].ToString();
					formDeterministicPaper.FormDeterministicPaperTaxReason = row["FormDeterministicPaperTaxReason"].ToString();
					formDeterministicPaper.FormDeterministicPaperTaxNumber = row["FormDeterministicPaperTaxNumber"].ToString();
					formDeterministicPaper.FormDeterministicPaperHeirIssuanceDepartmant = row["FormDeterministicPaperHeirIssuanceDepartmant"].ToString();
					formDeterministicPaper.FormDeterministicPaperHeirIssuanceCity = row["FormDeterministicPaperHeirIssuanceCity"].ToString();
					formDeterministicPaper.FormDeterministicPaperHeirJobAddress = row["FormDeterministicPaperHeirJobAddress"].ToString();
					formDeterministicPaper.FormDeterministicPaperHeirHomeAddress = row["FormDeterministicPaperHeirHomeAddress"].ToString();
					formDeterministicPaper.FormDeterministicPaperHeirJobPhoneNumber = row["FormDeterministicPaperHeirJobPhoneNumber"].ToString();
					formDeterministicPaper.FormDeterministicPaperHeirHomePhoneNumber = row["FormDeterministicPaperHeirHomePhoneNumber"].ToString();
					formDeterministicPaper.FormDeterministicPaperHeirName = row["FormDeterministicPaperHeirName"].ToString();
					formDeterministicPaper.FormDeterministicPaperHeirFamily = row["FormDeterministicPaperHeirFamily"].ToString();
					formDeterministicPaper.FormDeterministicPaperHeirFatherName = row["FormDeterministicPaperHeirFatherName"].ToString();
					formDeterministicPaper.FormDeterministicPaperHeirCertificateNumber = row["FormDeterministicPaperHeirCertificateNumber"].ToString();
					formDeterministicPaper.FormDeterministicPaperHeirNationalCode = row["FormDeterministicPaperHeirNationalCode"].ToString();
					formDeterministicPaper.FormDeterministicPaperHeirIssuanceDate = row["FormDeterministicPaperHeirIssuanceDate"].ToString();
					formDeterministicPaper.FormDeterministicPaperDossierClasses = row["FormDeterministicPaperDossierClasses"].ToString();
					formDeterministicPaper.FormDeterministicPaperRegisterInformationID = (row["FormDeterministicPaperRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperRegisterInformationID"]) : 0 ;
					formDeterministicPaper.FormDeterministicPaperDeclarationID = (row["FormDeterministicPaperDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperDeclarationID"]) : 0 ;
					formDeterministicPaper.FormDeterministicPaperRegisterarUserNationalCode = (row["FormDeterministicPaperRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperRegisterarUserNationalCode"]) : 0 ;
					formDeterministicPaper.FormDeterministicPaperRegisterInformationDate = row["FormDeterministicPaperRegisterInformationDate"].ToString();
					formDeterministicPaper.FormDeterministicPaperTaxDate = row["FormDeterministicPaperTaxDate"].ToString();
					formDeterministicPaper.FormDeterministicPaperAnnonsiationDate = row["FormDeterministicPaperAnnonsiationDate"].ToString();
					formDeterministicPaper.FormDeterministicPaperReductionDate = row["FormDeterministicPaperReductionDate"].ToString();
					formDeterministicPaper.FormDeterministicPaperPenaltyDate = row["FormDeterministicPaperPenaltyDate"].ToString();
					formDeterministicPaper.FormDeterministicPaperOperationYear1 = row["FormDeterministicPaperOperationYear1"].ToString();
					formDeterministicPaper.FormDeterministicPaperTaxOfficeProvince = row["FormDeterministicPaperTaxOfficeProvince"].ToString();
					formDeterministicPaper.FormDeterministicPaperTaxOfficeCode = row["FormDeterministicPaperTaxOfficeCode"].ToString();
					formDeterministicPaper.FormDeterministicPaperTaxUintCode = row["FormDeterministicPaperTaxUintCode"].ToString();
					formDeterministicPaper.FormDeterministicPaperTaxOfficeAddress = row["FormDeterministicPaperTaxOfficeAddress"].ToString();
					formDeterministicPaper.FormDeterministicPaperTaxOfficePhoneNumber = row["FormDeterministicPaperTaxOfficePhoneNumber"].ToString();
					formDeterministicPaper.FormDeterministicPaperPayableTaxLetter = row["FormDeterministicPaperPayableTaxLetter"].ToString();
					formDeterministicPaper.FormDeterministicPaperTaxTitle2 = row["FormDeterministicPaperTaxTitle2"].ToString();
					formDeterministicPaper.FormDeterministicPaperTaxBase = (row["FormDeterministicPaperTaxBase"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxBase"]) : 0 ;
					formDeterministicPaper.FormDeterministicPaperTaxReduction = (row["FormDeterministicPaperTaxReduction"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxReduction"]) : 0 ;
					formDeterministicPaper.FormDeterministicPaperTaxRemaining = (row["FormDeterministicPaperTaxRemaining"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxRemaining"]) : 0 ;
					formDeterministicPaper.FormDeterministicPaperTax = (row["FormDeterministicPaperTax"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTax"]) : 0 ;
					formDeterministicPaper.FormDeterministicPaperReduction = (row["FormDeterministicPaperReduction"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperReduction"]) : 0 ;
					formDeterministicPaper.FormDeterministicPaperPenalty = (row["FormDeterministicPaperPenalty"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperPenalty"]) : 0 ;
					formDeterministicPaper.FormDeterministicPaperTotalWithoutPenalty = (row["FormDeterministicPaperTotalWithoutPenalty"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTotalWithoutPenalty"]) : 0 ;
					formDeterministicPaper.FormDeterministicPaperTotal = (row["FormDeterministicPaperTotal"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTotal"]) : 0 ;
					formDeterministicPaper.FormDeterministicPaperPayableTax = (row["FormDeterministicPaperPayableTax"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperPayableTax"]) : 0 ;
					formDeterministicPaper.FormDeterministicPaperTaxRemaining2 = (row["FormDeterministicPaperTaxRemaining2"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxRemaining2"]) : 0 ;
					listFormDeterministicPaper.Add(formDeterministicPaper);
				}
			}
		}

		return listFormDeterministicPaper;
	}

	public bool Exists(Int64 formDeterministicPaperID)
	{
		SqlParameter[] parametersFormDeterministicPaper = new SqlParameter[]
		{
			new SqlParameter("@FormDeterministicPaperID", formDeterministicPaperID)
		};
		return (SqlDBHelper.ExecuteScalar("FormDeterministicPaper_Exists", CommandType.StoredProcedure, parametersFormDeterministicPaper)>0);
	}

	public bool Exists(FormDeterministicPaper formDeterministicPaper)
	{
		SqlParameter[] parametersFormDeterministicPaper = new SqlParameter[]
		{
			new SqlParameter("@FormDeterministicPaperID", formDeterministicPaper.FormDeterministicPaperID)
		};
		return (SqlDBHelper.ExecuteScalar("FormDeterministicPaper_Exists", CommandType.StoredProcedure, parametersFormDeterministicPaper)>0);
	}

	public List<FormDeterministicPaper> SearchLike(FormDeterministicPaper formDeterministicPaper)
	{
		List<FormDeterministicPaper> listFormDeterministicPaper = new List<FormDeterministicPaper>();


		SqlParameter[] parametersFormDeterministicPaper = new SqlParameter[]
		{
			new SqlParameter("@FormDeterministicPaperID", formDeterministicPaper.FormDeterministicPaperID),
			new SqlParameter("@FormDeterministicPaperPrintRegisterInformationID", formDeterministicPaper.FormDeterministicPaperPrintRegisterInformationID),
			new SqlParameter("@FormDeterministicPaperPrintRegisterDate", formDeterministicPaper.FormDeterministicPaperPrintRegisterDate),
			new SqlParameter("@FormDeterministicPaperReductionType", formDeterministicPaper.FormDeterministicPaperReductionType),
			new SqlParameter("@FormDeterministicPaperPenaltyReason", formDeterministicPaper.FormDeterministicPaperPenaltyReason),
			new SqlParameter("@FormDeterministicPaperComment", formDeterministicPaper.FormDeterministicPaperComment),
			new SqlParameter("@FormDeterministicPaperUser1Code", formDeterministicPaper.FormDeterministicPaperUser1Code),
			new SqlParameter("@FormDeterministicPaperUser1FullName", formDeterministicPaper.FormDeterministicPaperUser1FullName),
			new SqlParameter("@FormDeterministicPaperOperationYear2", formDeterministicPaper.FormDeterministicPaperOperationYear2),
			new SqlParameter("@FormDeterministicPaperHeirJobZipCode", formDeterministicPaper.FormDeterministicPaperHeirJobZipCode),
			new SqlParameter("@FormDeterministicPaperHeirHomeZipCode", formDeterministicPaper.FormDeterministicPaperHeirHomeZipCode),
			new SqlParameter("@FormDeterministicPaperHeirIdentifier", formDeterministicPaper.FormDeterministicPaperHeirIdentifier),
			new SqlParameter("@FormDeterministicPaperTaxTitle", formDeterministicPaper.FormDeterministicPaperTaxTitle),
			new SqlParameter("@FormDeterministicPaperTaxReason", formDeterministicPaper.FormDeterministicPaperTaxReason),
			new SqlParameter("@FormDeterministicPaperTaxNumber", formDeterministicPaper.FormDeterministicPaperTaxNumber),
			new SqlParameter("@FormDeterministicPaperHeirIssuanceDepartmant", formDeterministicPaper.FormDeterministicPaperHeirIssuanceDepartmant),
			new SqlParameter("@FormDeterministicPaperHeirIssuanceCity", formDeterministicPaper.FormDeterministicPaperHeirIssuanceCity),
			new SqlParameter("@FormDeterministicPaperHeirJobAddress", formDeterministicPaper.FormDeterministicPaperHeirJobAddress),
			new SqlParameter("@FormDeterministicPaperHeirHomeAddress", formDeterministicPaper.FormDeterministicPaperHeirHomeAddress),
			new SqlParameter("@FormDeterministicPaperHeirJobPhoneNumber", formDeterministicPaper.FormDeterministicPaperHeirJobPhoneNumber),
			new SqlParameter("@FormDeterministicPaperHeirHomePhoneNumber", formDeterministicPaper.FormDeterministicPaperHeirHomePhoneNumber),
			new SqlParameter("@FormDeterministicPaperHeirName", formDeterministicPaper.FormDeterministicPaperHeirName),
			new SqlParameter("@FormDeterministicPaperHeirFamily", formDeterministicPaper.FormDeterministicPaperHeirFamily),
			new SqlParameter("@FormDeterministicPaperHeirFatherName", formDeterministicPaper.FormDeterministicPaperHeirFatherName),
			new SqlParameter("@FormDeterministicPaperHeirCertificateNumber", formDeterministicPaper.FormDeterministicPaperHeirCertificateNumber),
			new SqlParameter("@FormDeterministicPaperHeirNationalCode", formDeterministicPaper.FormDeterministicPaperHeirNationalCode),
			new SqlParameter("@FormDeterministicPaperHeirIssuanceDate", formDeterministicPaper.FormDeterministicPaperHeirIssuanceDate),
			new SqlParameter("@FormDeterministicPaperDossierClasses", formDeterministicPaper.FormDeterministicPaperDossierClasses),
			new SqlParameter("@FormDeterministicPaperRegisterInformationID", formDeterministicPaper.FormDeterministicPaperRegisterInformationID),
			new SqlParameter("@FormDeterministicPaperDeclarationID", formDeterministicPaper.FormDeterministicPaperDeclarationID),
			new SqlParameter("@FormDeterministicPaperRegisterarUserNationalCode", formDeterministicPaper.FormDeterministicPaperRegisterarUserNationalCode),
			new SqlParameter("@FormDeterministicPaperRegisterInformationDate", formDeterministicPaper.FormDeterministicPaperRegisterInformationDate),
			new SqlParameter("@FormDeterministicPaperTaxDate", formDeterministicPaper.FormDeterministicPaperTaxDate),
			new SqlParameter("@FormDeterministicPaperAnnonsiationDate", formDeterministicPaper.FormDeterministicPaperAnnonsiationDate),
			new SqlParameter("@FormDeterministicPaperReductionDate", formDeterministicPaper.FormDeterministicPaperReductionDate),
			new SqlParameter("@FormDeterministicPaperPenaltyDate", formDeterministicPaper.FormDeterministicPaperPenaltyDate),
			new SqlParameter("@FormDeterministicPaperOperationYear1", formDeterministicPaper.FormDeterministicPaperOperationYear1),
			new SqlParameter("@FormDeterministicPaperTaxOfficeProvince", formDeterministicPaper.FormDeterministicPaperTaxOfficeProvince),
			new SqlParameter("@FormDeterministicPaperTaxOfficeCode", formDeterministicPaper.FormDeterministicPaperTaxOfficeCode),
			new SqlParameter("@FormDeterministicPaperTaxUintCode", formDeterministicPaper.FormDeterministicPaperTaxUintCode),
			new SqlParameter("@FormDeterministicPaperTaxOfficeAddress", formDeterministicPaper.FormDeterministicPaperTaxOfficeAddress),
			new SqlParameter("@FormDeterministicPaperTaxOfficePhoneNumber", formDeterministicPaper.FormDeterministicPaperTaxOfficePhoneNumber),
			new SqlParameter("@FormDeterministicPaperPayableTaxLetter", formDeterministicPaper.FormDeterministicPaperPayableTaxLetter),
			new SqlParameter("@FormDeterministicPaperTaxTitle2", formDeterministicPaper.FormDeterministicPaperTaxTitle2),
			new SqlParameter("@FormDeterministicPaperTaxBase", formDeterministicPaper.FormDeterministicPaperTaxBase),
			new SqlParameter("@FormDeterministicPaperTaxReduction", formDeterministicPaper.FormDeterministicPaperTaxReduction),
			new SqlParameter("@FormDeterministicPaperTaxRemaining", formDeterministicPaper.FormDeterministicPaperTaxRemaining),
			new SqlParameter("@FormDeterministicPaperTax", formDeterministicPaper.FormDeterministicPaperTax),
			new SqlParameter("@FormDeterministicPaperReduction", formDeterministicPaper.FormDeterministicPaperReduction),
			new SqlParameter("@FormDeterministicPaperPenalty", formDeterministicPaper.FormDeterministicPaperPenalty),
			new SqlParameter("@FormDeterministicPaperTotalWithoutPenalty", formDeterministicPaper.FormDeterministicPaperTotalWithoutPenalty),
			new SqlParameter("@FormDeterministicPaperTotal", formDeterministicPaper.FormDeterministicPaperTotal),
			new SqlParameter("@FormDeterministicPaperPayableTax", formDeterministicPaper.FormDeterministicPaperPayableTax),
			new SqlParameter("@FormDeterministicPaperTaxRemaining2", formDeterministicPaper.FormDeterministicPaperTaxRemaining2),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDeterministicPaper_SearchLike", CommandType.StoredProcedure, parametersFormDeterministicPaper))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormDeterministicPaper tmpFormDeterministicPaper = new FormDeterministicPaper();
					tmpFormDeterministicPaper.FormDeterministicPaperID = (row["FormDeterministicPaperID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperID"]) : 0 ;
					tmpFormDeterministicPaper.FormDeterministicPaperPrintRegisterInformationID = row["FormDeterministicPaperPrintRegisterInformationID"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperPrintRegisterDate = row["FormDeterministicPaperPrintRegisterDate"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperReductionType = row["FormDeterministicPaperReductionType"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperPenaltyReason = row["FormDeterministicPaperPenaltyReason"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperComment = row["FormDeterministicPaperComment"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperUser1Code = row["FormDeterministicPaperUser1Code"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperUser1FullName = row["FormDeterministicPaperUser1FullName"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperOperationYear2 = row["FormDeterministicPaperOperationYear2"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperHeirJobZipCode = row["FormDeterministicPaperHeirJobZipCode"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperHeirHomeZipCode = row["FormDeterministicPaperHeirHomeZipCode"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperHeirIdentifier = row["FormDeterministicPaperHeirIdentifier"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperTaxTitle = row["FormDeterministicPaperTaxTitle"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperTaxReason = row["FormDeterministicPaperTaxReason"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperTaxNumber = row["FormDeterministicPaperTaxNumber"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperHeirIssuanceDepartmant = row["FormDeterministicPaperHeirIssuanceDepartmant"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperHeirIssuanceCity = row["FormDeterministicPaperHeirIssuanceCity"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperHeirJobAddress = row["FormDeterministicPaperHeirJobAddress"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperHeirHomeAddress = row["FormDeterministicPaperHeirHomeAddress"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperHeirJobPhoneNumber = row["FormDeterministicPaperHeirJobPhoneNumber"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperHeirHomePhoneNumber = row["FormDeterministicPaperHeirHomePhoneNumber"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperHeirName = row["FormDeterministicPaperHeirName"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperHeirFamily = row["FormDeterministicPaperHeirFamily"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperHeirFatherName = row["FormDeterministicPaperHeirFatherName"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperHeirCertificateNumber = row["FormDeterministicPaperHeirCertificateNumber"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperHeirNationalCode = row["FormDeterministicPaperHeirNationalCode"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperHeirIssuanceDate = row["FormDeterministicPaperHeirIssuanceDate"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperDossierClasses = row["FormDeterministicPaperDossierClasses"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperRegisterInformationID = (row["FormDeterministicPaperRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperRegisterInformationID"]) : 0 ;
					tmpFormDeterministicPaper.FormDeterministicPaperDeclarationID = (row["FormDeterministicPaperDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperDeclarationID"]) : 0 ;
					tmpFormDeterministicPaper.FormDeterministicPaperRegisterarUserNationalCode = (row["FormDeterministicPaperRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperRegisterarUserNationalCode"]) : 0 ;
					tmpFormDeterministicPaper.FormDeterministicPaperRegisterInformationDate = row["FormDeterministicPaperRegisterInformationDate"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperTaxDate = row["FormDeterministicPaperTaxDate"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperAnnonsiationDate = row["FormDeterministicPaperAnnonsiationDate"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperReductionDate = row["FormDeterministicPaperReductionDate"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperPenaltyDate = row["FormDeterministicPaperPenaltyDate"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperOperationYear1 = row["FormDeterministicPaperOperationYear1"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperTaxOfficeProvince = row["FormDeterministicPaperTaxOfficeProvince"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperTaxOfficeCode = row["FormDeterministicPaperTaxOfficeCode"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperTaxUintCode = row["FormDeterministicPaperTaxUintCode"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperTaxOfficeAddress = row["FormDeterministicPaperTaxOfficeAddress"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperTaxOfficePhoneNumber = row["FormDeterministicPaperTaxOfficePhoneNumber"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperPayableTaxLetter = row["FormDeterministicPaperPayableTaxLetter"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperTaxTitle2 = row["FormDeterministicPaperTaxTitle2"].ToString();
					tmpFormDeterministicPaper.FormDeterministicPaperTaxBase = (row["FormDeterministicPaperTaxBase"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxBase"]) : 0 ;
					tmpFormDeterministicPaper.FormDeterministicPaperTaxReduction = (row["FormDeterministicPaperTaxReduction"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxReduction"]) : 0 ;
					tmpFormDeterministicPaper.FormDeterministicPaperTaxRemaining = (row["FormDeterministicPaperTaxRemaining"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxRemaining"]) : 0 ;
					tmpFormDeterministicPaper.FormDeterministicPaperTax = (row["FormDeterministicPaperTax"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTax"]) : 0 ;
					tmpFormDeterministicPaper.FormDeterministicPaperReduction = (row["FormDeterministicPaperReduction"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperReduction"]) : 0 ;
					tmpFormDeterministicPaper.FormDeterministicPaperPenalty = (row["FormDeterministicPaperPenalty"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperPenalty"]) : 0 ;
					tmpFormDeterministicPaper.FormDeterministicPaperTotalWithoutPenalty = (row["FormDeterministicPaperTotalWithoutPenalty"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTotalWithoutPenalty"]) : 0 ;
					tmpFormDeterministicPaper.FormDeterministicPaperTotal = (row["FormDeterministicPaperTotal"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTotal"]) : 0 ;
					tmpFormDeterministicPaper.FormDeterministicPaperPayableTax = (row["FormDeterministicPaperPayableTax"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperPayableTax"]) : 0 ;
					tmpFormDeterministicPaper.FormDeterministicPaperTaxRemaining2 = (row["FormDeterministicPaperTaxRemaining2"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxRemaining2"]) : 0 ;

					listFormDeterministicPaper.Add(tmpFormDeterministicPaper);
				}
			}
		}

		return listFormDeterministicPaper;
	}

}
}
