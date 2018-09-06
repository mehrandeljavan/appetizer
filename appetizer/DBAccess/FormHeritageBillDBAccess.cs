using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormHeritageBillDBAccess
{


	public Int64 Insert(FormHeritageBill formHeritageBill)
	{
		SqlParameter[] parametersFormHeritageBill = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageBillTaxTotalLetter", (formHeritageBill.FormHeritageBillTaxTotalLetter != null) ? formHeritageBill.FormHeritageBillTaxTotalLetter : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillUser1Code", (formHeritageBill.FormHeritageBillUser1Code != null) ? formHeritageBill.FormHeritageBillUser1Code : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillUser2Code", (formHeritageBill.FormHeritageBillUser2Code != null) ? formHeritageBill.FormHeritageBillUser2Code : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillTaxOfficeTitle", (formHeritageBill.FormHeritageBillTaxOfficeTitle != null) ? formHeritageBill.FormHeritageBillTaxOfficeTitle : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDeadFullName", (formHeritageBill.FormHeritageBillDeadFullName != null) ? formHeritageBill.FormHeritageBillDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDescriptions", (formHeritageBill.FormHeritageBillDescriptions != null) ? formHeritageBill.FormHeritageBillDescriptions : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillHeritageBill", (formHeritageBill.FormHeritageBillHeritageBill != null) ? formHeritageBill.FormHeritageBillHeritageBill : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillRegisterInformationID", (formHeritageBill.FormHeritageBillRegisterInformationID > 0) ? formHeritageBill.FormHeritageBillRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDeclarationID", (formHeritageBill.FormHeritageBillDeclarationID > 0) ? formHeritageBill.FormHeritageBillDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillRegisterarUserNationalCode", (formHeritageBill.FormHeritageBillRegisterarUserNationalCode > 0) ? formHeritageBill.FormHeritageBillRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDeadNationalCode", (formHeritageBill.FormHeritageBillDeadNationalCode != null) ? formHeritageBill.FormHeritageBillDeadNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDeadDeathDate", (formHeritageBill.FormHeritageBillDeadDeathDate != null) ? formHeritageBill.FormHeritageBillDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDossierClasses", (formHeritageBill.FormHeritageBillDossierClasses != null) ? formHeritageBill.FormHeritageBillDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillRegisterInformationDate", (formHeritageBill.FormHeritageBillRegisterInformationDate != null) ? formHeritageBill.FormHeritageBillRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillHeirsNumberSummury", (formHeritageBill.FormHeritageBillHeirsNumberSummury != null) ? formHeritageBill.FormHeritageBillHeirsNumberSummury : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillHeirSharesSummury", (formHeritageBill.FormHeritageBillHeirSharesSummury != null) ? formHeritageBill.FormHeritageBillHeirSharesSummury : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillTaxDescription", (formHeritageBill.FormHeritageBillTaxDescription != null) ? formHeritageBill.FormHeritageBillTaxDescription : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillBillType", (formHeritageBill.FormHeritageBillBillType != null) ? formHeritageBill.FormHeritageBillBillType : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillUser2FullName", (formHeritageBill.FormHeritageBillUser2FullName != null) ? formHeritageBill.FormHeritageBillUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillUser1FullName", (formHeritageBill.FormHeritageBillUser1FullName != null) ? formHeritageBill.FormHeritageBillUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillENZ", (formHeritageBill.FormHeritageBillENZ != null) ? formHeritageBill.FormHeritageBillENZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillANZ", (formHeritageBill.FormHeritageBillANZ != null) ? formHeritageBill.FormHeritageBillANZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillMNZ", (formHeritageBill.FormHeritageBillMNZ != null) ? formHeritageBill.FormHeritageBillMNZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDMNZ", (formHeritageBill.FormHeritageBillDMNZ != null) ? formHeritageBill.FormHeritageBillDMNZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDENZ", (formHeritageBill.FormHeritageBillDENZ != null) ? formHeritageBill.FormHeritageBillDENZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDANZ", (formHeritageBill.FormHeritageBillDANZ != null) ? formHeritageBill.FormHeritageBillDANZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillTotalValue", (formHeritageBill.FormHeritageBillTotalValue != null) ? formHeritageBill.FormHeritageBillTotalValue : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillTaxTotal", (formHeritageBill.FormHeritageBillTaxTotal != null) ? formHeritageBill.FormHeritageBillTaxTotal : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDEKHZ", (formHeritageBill.FormHeritageBillDEKHZ != null) ? formHeritageBill.FormHeritageBillDEKHZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDAKHZ", (formHeritageBill.FormHeritageBillDAKHZ != null) ? formHeritageBill.FormHeritageBillDAKHZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDMKHZ", (formHeritageBill.FormHeritageBillDMKHZ != null) ? formHeritageBill.FormHeritageBillDMKHZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillE2KHZ", (formHeritageBill.FormHeritageBillE2KHZ != null) ? formHeritageBill.FormHeritageBillE2KHZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillA2KHZ", (formHeritageBill.FormHeritageBillA2KHZ != null) ? formHeritageBill.FormHeritageBillA2KHZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillM2KHZ", (formHeritageBill.FormHeritageBillM2KHZ != null) ? formHeritageBill.FormHeritageBillM2KHZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillE2NZ", (formHeritageBill.FormHeritageBillE2NZ != null) ? formHeritageBill.FormHeritageBillE2NZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillA2NZ", (formHeritageBill.FormHeritageBillA2NZ != null) ? formHeritageBill.FormHeritageBillA2NZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillM2NZ", (formHeritageBill.FormHeritageBillM2NZ != null) ? formHeritageBill.FormHeritageBillM2NZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillEKHZ", (formHeritageBill.FormHeritageBillEKHZ != null) ? formHeritageBill.FormHeritageBillEKHZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillAKHZ", (formHeritageBill.FormHeritageBillAKHZ != null) ? formHeritageBill.FormHeritageBillAKHZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillMKHZ", (formHeritageBill.FormHeritageBillMKHZ != null) ? formHeritageBill.FormHeritageBillMKHZ : (object)DBNull.Value)
		};
		formHeritageBill.FormHeritageBillID = SqlDBHelper.ExecuteScalar("FormHeritageBill_Insert", CommandType.StoredProcedure, parametersFormHeritageBill);
		return formHeritageBill.FormHeritageBillID;
	}

	public bool Update(FormHeritageBill formHeritageBill)
	{
		SqlParameter[] parametersFormHeritageBill = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageBillID", formHeritageBill.FormHeritageBillID),
			new SqlParameter("@FormHeritageBillTaxTotalLetter", (formHeritageBill.FormHeritageBillTaxTotalLetter != null) ? formHeritageBill.FormHeritageBillTaxTotalLetter : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillUser1Code", (formHeritageBill.FormHeritageBillUser1Code != null) ? formHeritageBill.FormHeritageBillUser1Code : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillUser2Code", (formHeritageBill.FormHeritageBillUser2Code != null) ? formHeritageBill.FormHeritageBillUser2Code : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillTaxOfficeTitle", (formHeritageBill.FormHeritageBillTaxOfficeTitle != null) ? formHeritageBill.FormHeritageBillTaxOfficeTitle : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDeadFullName", (formHeritageBill.FormHeritageBillDeadFullName != null) ? formHeritageBill.FormHeritageBillDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDescriptions", (formHeritageBill.FormHeritageBillDescriptions != null) ? formHeritageBill.FormHeritageBillDescriptions : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillHeritageBill", (formHeritageBill.FormHeritageBillHeritageBill != null) ? formHeritageBill.FormHeritageBillHeritageBill : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillRegisterInformationID", (formHeritageBill.FormHeritageBillRegisterInformationID != null && formHeritageBill.FormHeritageBillRegisterInformationID >0 ) ? formHeritageBill.FormHeritageBillRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDeclarationID", formHeritageBill.FormHeritageBillDeclarationID),
			new SqlParameter("@FormHeritageBillRegisterarUserNationalCode", (formHeritageBill.FormHeritageBillRegisterarUserNationalCode != null && formHeritageBill.FormHeritageBillRegisterarUserNationalCode >0 ) ? formHeritageBill.FormHeritageBillRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDeadNationalCode", (formHeritageBill.FormHeritageBillDeadNationalCode != null) ? formHeritageBill.FormHeritageBillDeadNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDeadDeathDate", (formHeritageBill.FormHeritageBillDeadDeathDate != null) ? formHeritageBill.FormHeritageBillDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDossierClasses", (formHeritageBill.FormHeritageBillDossierClasses != null) ? formHeritageBill.FormHeritageBillDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillRegisterInformationDate", (formHeritageBill.FormHeritageBillRegisterInformationDate != null) ? formHeritageBill.FormHeritageBillRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillHeirsNumberSummury", (formHeritageBill.FormHeritageBillHeirsNumberSummury != null) ? formHeritageBill.FormHeritageBillHeirsNumberSummury : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillHeirSharesSummury", (formHeritageBill.FormHeritageBillHeirSharesSummury != null) ? formHeritageBill.FormHeritageBillHeirSharesSummury : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillTaxDescription", (formHeritageBill.FormHeritageBillTaxDescription != null) ? formHeritageBill.FormHeritageBillTaxDescription : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillBillType", (formHeritageBill.FormHeritageBillBillType != null) ? formHeritageBill.FormHeritageBillBillType : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillUser2FullName", (formHeritageBill.FormHeritageBillUser2FullName != null) ? formHeritageBill.FormHeritageBillUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillUser1FullName", (formHeritageBill.FormHeritageBillUser1FullName != null) ? formHeritageBill.FormHeritageBillUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillENZ", (formHeritageBill.FormHeritageBillENZ != null) ? formHeritageBill.FormHeritageBillENZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillANZ", (formHeritageBill.FormHeritageBillANZ != null) ? formHeritageBill.FormHeritageBillANZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillMNZ", (formHeritageBill.FormHeritageBillMNZ != null) ? formHeritageBill.FormHeritageBillMNZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDMNZ", (formHeritageBill.FormHeritageBillDMNZ != null) ? formHeritageBill.FormHeritageBillDMNZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDENZ", (formHeritageBill.FormHeritageBillDENZ != null) ? formHeritageBill.FormHeritageBillDENZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDANZ", (formHeritageBill.FormHeritageBillDANZ != null) ? formHeritageBill.FormHeritageBillDANZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillTotalValue", (formHeritageBill.FormHeritageBillTotalValue != null) ? formHeritageBill.FormHeritageBillTotalValue : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillTaxTotal", (formHeritageBill.FormHeritageBillTaxTotal != null) ? formHeritageBill.FormHeritageBillTaxTotal : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDEKHZ", (formHeritageBill.FormHeritageBillDEKHZ != null) ? formHeritageBill.FormHeritageBillDEKHZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDAKHZ", (formHeritageBill.FormHeritageBillDAKHZ != null) ? formHeritageBill.FormHeritageBillDAKHZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillDMKHZ", (formHeritageBill.FormHeritageBillDMKHZ != null) ? formHeritageBill.FormHeritageBillDMKHZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillE2KHZ", (formHeritageBill.FormHeritageBillE2KHZ != null) ? formHeritageBill.FormHeritageBillE2KHZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillA2KHZ", (formHeritageBill.FormHeritageBillA2KHZ != null) ? formHeritageBill.FormHeritageBillA2KHZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillM2KHZ", (formHeritageBill.FormHeritageBillM2KHZ != null) ? formHeritageBill.FormHeritageBillM2KHZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillE2NZ", (formHeritageBill.FormHeritageBillE2NZ != null) ? formHeritageBill.FormHeritageBillE2NZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillA2NZ", (formHeritageBill.FormHeritageBillA2NZ != null) ? formHeritageBill.FormHeritageBillA2NZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillM2NZ", (formHeritageBill.FormHeritageBillM2NZ != null) ? formHeritageBill.FormHeritageBillM2NZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillEKHZ", (formHeritageBill.FormHeritageBillEKHZ != null) ? formHeritageBill.FormHeritageBillEKHZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillAKHZ", (formHeritageBill.FormHeritageBillAKHZ != null) ? formHeritageBill.FormHeritageBillAKHZ : (object)DBNull.Value),
			new SqlParameter("@FormHeritageBillMKHZ", (formHeritageBill.FormHeritageBillMKHZ != null) ? formHeritageBill.FormHeritageBillMKHZ : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormHeritageBill_Update", CommandType.StoredProcedure, parametersFormHeritageBill);
	}

	public bool Delete(Int64 formHeritageBillID)
	{
		SqlParameter[] parametersFormHeritageBill = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageBillID", formHeritageBillID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormHeritageBill_Delete", CommandType.StoredProcedure, parametersFormHeritageBill);
	}

	public FormHeritageBill GetDetails(Int64 formHeritageBillID)
	{
		FormHeritageBill formHeritageBill = new FormHeritageBill();

		SqlParameter[] parametersFormHeritageBill = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageBillID", formHeritageBillID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeritageBill_GetDetails", CommandType.StoredProcedure, parametersFormHeritageBill))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				formHeritageBill.FormHeritageBillID = (row["FormHeritageBillID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillID"]) : 0 ;
				formHeritageBill.FormHeritageBillPrintRegisterInformationID = row["FormHeritageBillPrintRegisterInformationID"].ToString();
				formHeritageBill.FormHeritageBillPrintRegisterDate = row["FormHeritageBillPrintRegisterDate"].ToString();
				formHeritageBill.FormHeritageBillTaxTotalLetter = row["FormHeritageBillTaxTotalLetter"].ToString();
				formHeritageBill.FormHeritageBillUser1Code = row["FormHeritageBillUser1Code"].ToString();
				formHeritageBill.FormHeritageBillUser2Code = row["FormHeritageBillUser2Code"].ToString();
				formHeritageBill.FormHeritageBillTaxOfficeTitle = row["FormHeritageBillTaxOfficeTitle"].ToString();
				formHeritageBill.FormHeritageBillDeadFullName = row["FormHeritageBillDeadFullName"].ToString();
				formHeritageBill.FormHeritageBillDescriptions = row["FormHeritageBillDescriptions"].ToString();
				formHeritageBill.FormHeritageBillHeritageBill = row["FormHeritageBillHeritageBill"].ToString();
				formHeritageBill.FormHeritageBillRegisterInformationID = (row["FormHeritageBillRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillRegisterInformationID"]) : 0 ;
				formHeritageBill.FormHeritageBillDeclarationID = (row["FormHeritageBillDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillDeclarationID"]) : 0 ;
				formHeritageBill.FormHeritageBillRegisterarUserNationalCode = (row["FormHeritageBillRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillRegisterarUserNationalCode"]) : 0 ;
				formHeritageBill.FormHeritageBillDeadNationalCode = (row["FormHeritageBillDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillDeadNationalCode"]) : 0 ;
				formHeritageBill.FormHeritageBillDeadDeathDate = row["FormHeritageBillDeadDeathDate"].ToString();
				formHeritageBill.FormHeritageBillDossierClasses = row["FormHeritageBillDossierClasses"].ToString();
				formHeritageBill.FormHeritageBillRegisterInformationDate = row["FormHeritageBillRegisterInformationDate"].ToString();
				formHeritageBill.FormHeritageBillHeirsNumberSummury = row["FormHeritageBillHeirsNumberSummury"].ToString();
				formHeritageBill.FormHeritageBillHeirSharesSummury = row["FormHeritageBillHeirSharesSummury"].ToString();
				formHeritageBill.FormHeritageBillTaxDescription = row["FormHeritageBillTaxDescription"].ToString();
				formHeritageBill.FormHeritageBillBillType = row["FormHeritageBillBillType"].ToString();
				formHeritageBill.FormHeritageBillUser2FullName = row["FormHeritageBillUser2FullName"].ToString();
				formHeritageBill.FormHeritageBillUser1FullName = row["FormHeritageBillUser1FullName"].ToString();
				formHeritageBill.FormHeritageBillENZ = (row["FormHeritageBillENZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillENZ"]) : 0 ;
				formHeritageBill.FormHeritageBillANZ = (row["FormHeritageBillANZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillANZ"]) : 0 ;
				formHeritageBill.FormHeritageBillMNZ = (row["FormHeritageBillMNZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillMNZ"]) : 0 ;
				formHeritageBill.FormHeritageBillDMNZ = (row["FormHeritageBillDMNZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDMNZ"]) : 0 ;
				formHeritageBill.FormHeritageBillDENZ = (row["FormHeritageBillDENZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDENZ"]) : 0 ;
				formHeritageBill.FormHeritageBillDANZ = (row["FormHeritageBillDANZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDANZ"]) : 0 ;
				formHeritageBill.FormHeritageBillTotalValue = (row["FormHeritageBillTotalValue"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillTotalValue"]) : 0 ;
				formHeritageBill.FormHeritageBillTaxTotal = (row["FormHeritageBillTaxTotal"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillTaxTotal"]) : 0 ;
				formHeritageBill.FormHeritageBillDEKHZ = (row["FormHeritageBillDEKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDEKHZ"]) : 0 ;
				formHeritageBill.FormHeritageBillDAKHZ = (row["FormHeritageBillDAKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDAKHZ"]) : 0 ;
				formHeritageBill.FormHeritageBillDMKHZ = (row["FormHeritageBillDMKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDMKHZ"]) : 0 ;
				formHeritageBill.FormHeritageBillE2KHZ = (row["FormHeritageBillE2KHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillE2KHZ"]) : 0 ;
				formHeritageBill.FormHeritageBillA2KHZ = (row["FormHeritageBillA2KHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillA2KHZ"]) : 0 ;
				formHeritageBill.FormHeritageBillM2KHZ = (row["FormHeritageBillM2KHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillM2KHZ"]) : 0 ;
				formHeritageBill.FormHeritageBillE2NZ = (row["FormHeritageBillE2NZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillE2NZ"]) : 0 ;
				formHeritageBill.FormHeritageBillA2NZ = (row["FormHeritageBillA2NZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillA2NZ"]) : 0 ;
				formHeritageBill.FormHeritageBillM2NZ = (row["FormHeritageBillM2NZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillM2NZ"]) : 0 ;
				formHeritageBill.FormHeritageBillEKHZ = (row["FormHeritageBillEKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillEKHZ"]) : 0 ;
				formHeritageBill.FormHeritageBillAKHZ = (row["FormHeritageBillAKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillAKHZ"]) : 0 ;
				formHeritageBill.FormHeritageBillMKHZ = (row["FormHeritageBillMKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillMKHZ"]) : 0 ;
			}
		}

		return formHeritageBill;
	}

	public List<FormHeritageBill> GetListAll()
	{
		List<FormHeritageBill> listFormHeritageBill = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormHeritageBill_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormHeritageBill = new List<FormHeritageBill>();

				foreach (DataRow row in table.Rows)
				{
					FormHeritageBill formHeritageBill = new FormHeritageBill();
					formHeritageBill.FormHeritageBillID = (row["FormHeritageBillID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillID"]) : 0 ;
					formHeritageBill.FormHeritageBillPrintRegisterInformationID = row["FormHeritageBillPrintRegisterInformationID"].ToString();
					formHeritageBill.FormHeritageBillPrintRegisterDate = row["FormHeritageBillPrintRegisterDate"].ToString();
					formHeritageBill.FormHeritageBillTaxTotalLetter = row["FormHeritageBillTaxTotalLetter"].ToString();
					formHeritageBill.FormHeritageBillUser1Code = row["FormHeritageBillUser1Code"].ToString();
					formHeritageBill.FormHeritageBillUser2Code = row["FormHeritageBillUser2Code"].ToString();
					formHeritageBill.FormHeritageBillTaxOfficeTitle = row["FormHeritageBillTaxOfficeTitle"].ToString();
					formHeritageBill.FormHeritageBillDeadFullName = row["FormHeritageBillDeadFullName"].ToString();
					formHeritageBill.FormHeritageBillDescriptions = row["FormHeritageBillDescriptions"].ToString();
					formHeritageBill.FormHeritageBillHeritageBill = row["FormHeritageBillHeritageBill"].ToString();
					formHeritageBill.FormHeritageBillRegisterInformationID = (row["FormHeritageBillRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillRegisterInformationID"]) : 0 ;
					formHeritageBill.FormHeritageBillDeclarationID = (row["FormHeritageBillDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillDeclarationID"]) : 0 ;
					formHeritageBill.FormHeritageBillRegisterarUserNationalCode = (row["FormHeritageBillRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillRegisterarUserNationalCode"]) : 0 ;
					formHeritageBill.FormHeritageBillDeadNationalCode = (row["FormHeritageBillDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillDeadNationalCode"]) : 0 ;
					formHeritageBill.FormHeritageBillDeadDeathDate = row["FormHeritageBillDeadDeathDate"].ToString();
					formHeritageBill.FormHeritageBillDossierClasses = row["FormHeritageBillDossierClasses"].ToString();
					formHeritageBill.FormHeritageBillRegisterInformationDate = row["FormHeritageBillRegisterInformationDate"].ToString();
					formHeritageBill.FormHeritageBillHeirsNumberSummury = row["FormHeritageBillHeirsNumberSummury"].ToString();
					formHeritageBill.FormHeritageBillHeirSharesSummury = row["FormHeritageBillHeirSharesSummury"].ToString();
					formHeritageBill.FormHeritageBillTaxDescription = row["FormHeritageBillTaxDescription"].ToString();
					formHeritageBill.FormHeritageBillBillType = row["FormHeritageBillBillType"].ToString();
					formHeritageBill.FormHeritageBillUser2FullName = row["FormHeritageBillUser2FullName"].ToString();
					formHeritageBill.FormHeritageBillUser1FullName = row["FormHeritageBillUser1FullName"].ToString();
					formHeritageBill.FormHeritageBillENZ = (row["FormHeritageBillENZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillENZ"]) : 0 ;
					formHeritageBill.FormHeritageBillANZ = (row["FormHeritageBillANZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillANZ"]) : 0 ;
					formHeritageBill.FormHeritageBillMNZ = (row["FormHeritageBillMNZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillMNZ"]) : 0 ;
					formHeritageBill.FormHeritageBillDMNZ = (row["FormHeritageBillDMNZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDMNZ"]) : 0 ;
					formHeritageBill.FormHeritageBillDENZ = (row["FormHeritageBillDENZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDENZ"]) : 0 ;
					formHeritageBill.FormHeritageBillDANZ = (row["FormHeritageBillDANZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDANZ"]) : 0 ;
					formHeritageBill.FormHeritageBillTotalValue = (row["FormHeritageBillTotalValue"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillTotalValue"]) : 0 ;
					formHeritageBill.FormHeritageBillTaxTotal = (row["FormHeritageBillTaxTotal"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillTaxTotal"]) : 0 ;
					formHeritageBill.FormHeritageBillDEKHZ = (row["FormHeritageBillDEKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDEKHZ"]) : 0 ;
					formHeritageBill.FormHeritageBillDAKHZ = (row["FormHeritageBillDAKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDAKHZ"]) : 0 ;
					formHeritageBill.FormHeritageBillDMKHZ = (row["FormHeritageBillDMKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDMKHZ"]) : 0 ;
					formHeritageBill.FormHeritageBillE2KHZ = (row["FormHeritageBillE2KHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillE2KHZ"]) : 0 ;
					formHeritageBill.FormHeritageBillA2KHZ = (row["FormHeritageBillA2KHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillA2KHZ"]) : 0 ;
					formHeritageBill.FormHeritageBillM2KHZ = (row["FormHeritageBillM2KHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillM2KHZ"]) : 0 ;
					formHeritageBill.FormHeritageBillE2NZ = (row["FormHeritageBillE2NZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillE2NZ"]) : 0 ;
					formHeritageBill.FormHeritageBillA2NZ = (row["FormHeritageBillA2NZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillA2NZ"]) : 0 ;
					formHeritageBill.FormHeritageBillM2NZ = (row["FormHeritageBillM2NZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillM2NZ"]) : 0 ;
					formHeritageBill.FormHeritageBillEKHZ = (row["FormHeritageBillEKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillEKHZ"]) : 0 ;
					formHeritageBill.FormHeritageBillAKHZ = (row["FormHeritageBillAKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillAKHZ"]) : 0 ;
					formHeritageBill.FormHeritageBillMKHZ = (row["FormHeritageBillMKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillMKHZ"]) : 0 ;
					listFormHeritageBill.Add(formHeritageBill);
				}
			}
		}

		return listFormHeritageBill;
	}

	public bool Exists(Int64 formHeritageBillID)
	{
		SqlParameter[] parametersFormHeritageBill = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageBillID", formHeritageBillID)
		};
		return (SqlDBHelper.ExecuteScalar("FormHeritageBill_Exists", CommandType.StoredProcedure, parametersFormHeritageBill)>0);
	}

	public bool Exists(FormHeritageBill formHeritageBill)
	{
		SqlParameter[] parametersFormHeritageBill = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageBillID", formHeritageBill.FormHeritageBillID)
		};
		return (SqlDBHelper.ExecuteScalar("FormHeritageBill_Exists", CommandType.StoredProcedure, parametersFormHeritageBill)>0);
	}

	public List<FormHeritageBill> SearchLike(FormHeritageBill formHeritageBill)
	{
		List<FormHeritageBill> listFormHeritageBill = new List<FormHeritageBill>();


		SqlParameter[] parametersFormHeritageBill = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageBillID", formHeritageBill.FormHeritageBillID),
			new SqlParameter("@FormHeritageBillPrintRegisterInformationID", formHeritageBill.FormHeritageBillPrintRegisterInformationID),
			new SqlParameter("@FormHeritageBillPrintRegisterDate", formHeritageBill.FormHeritageBillPrintRegisterDate),
			new SqlParameter("@FormHeritageBillTaxTotalLetter", formHeritageBill.FormHeritageBillTaxTotalLetter),
			new SqlParameter("@FormHeritageBillUser1Code", formHeritageBill.FormHeritageBillUser1Code),
			new SqlParameter("@FormHeritageBillUser2Code", formHeritageBill.FormHeritageBillUser2Code),
			new SqlParameter("@FormHeritageBillTaxOfficeTitle", formHeritageBill.FormHeritageBillTaxOfficeTitle),
			new SqlParameter("@FormHeritageBillDeadFullName", formHeritageBill.FormHeritageBillDeadFullName),
			new SqlParameter("@FormHeritageBillDescriptions", formHeritageBill.FormHeritageBillDescriptions),
			new SqlParameter("@FormHeritageBillHeritageBill", formHeritageBill.FormHeritageBillHeritageBill),
			new SqlParameter("@FormHeritageBillRegisterInformationID", formHeritageBill.FormHeritageBillRegisterInformationID),
			new SqlParameter("@FormHeritageBillDeclarationID", formHeritageBill.FormHeritageBillDeclarationID),
			new SqlParameter("@FormHeritageBillRegisterarUserNationalCode", formHeritageBill.FormHeritageBillRegisterarUserNationalCode),
			new SqlParameter("@FormHeritageBillDeadNationalCode", formHeritageBill.FormHeritageBillDeadNationalCode),
			new SqlParameter("@FormHeritageBillDeadDeathDate", formHeritageBill.FormHeritageBillDeadDeathDate),
			new SqlParameter("@FormHeritageBillDossierClasses", formHeritageBill.FormHeritageBillDossierClasses),
			new SqlParameter("@FormHeritageBillRegisterInformationDate", formHeritageBill.FormHeritageBillRegisterInformationDate),
			new SqlParameter("@FormHeritageBillHeirsNumberSummury", formHeritageBill.FormHeritageBillHeirsNumberSummury),
			new SqlParameter("@FormHeritageBillHeirSharesSummury", formHeritageBill.FormHeritageBillHeirSharesSummury),
			new SqlParameter("@FormHeritageBillTaxDescription", formHeritageBill.FormHeritageBillTaxDescription),
			new SqlParameter("@FormHeritageBillBillType", formHeritageBill.FormHeritageBillBillType),
			new SqlParameter("@FormHeritageBillUser2FullName", formHeritageBill.FormHeritageBillUser2FullName),
			new SqlParameter("@FormHeritageBillUser1FullName", formHeritageBill.FormHeritageBillUser1FullName),
			new SqlParameter("@FormHeritageBillENZ", formHeritageBill.FormHeritageBillENZ),
			new SqlParameter("@FormHeritageBillANZ", formHeritageBill.FormHeritageBillANZ),
			new SqlParameter("@FormHeritageBillMNZ", formHeritageBill.FormHeritageBillMNZ),
			new SqlParameter("@FormHeritageBillDMNZ", formHeritageBill.FormHeritageBillDMNZ),
			new SqlParameter("@FormHeritageBillDENZ", formHeritageBill.FormHeritageBillDENZ),
			new SqlParameter("@FormHeritageBillDANZ", formHeritageBill.FormHeritageBillDANZ),
			new SqlParameter("@FormHeritageBillTotalValue", formHeritageBill.FormHeritageBillTotalValue),
			new SqlParameter("@FormHeritageBillTaxTotal", formHeritageBill.FormHeritageBillTaxTotal),
			new SqlParameter("@FormHeritageBillDEKHZ", formHeritageBill.FormHeritageBillDEKHZ),
			new SqlParameter("@FormHeritageBillDAKHZ", formHeritageBill.FormHeritageBillDAKHZ),
			new SqlParameter("@FormHeritageBillDMKHZ", formHeritageBill.FormHeritageBillDMKHZ),
			new SqlParameter("@FormHeritageBillE2KHZ", formHeritageBill.FormHeritageBillE2KHZ),
			new SqlParameter("@FormHeritageBillA2KHZ", formHeritageBill.FormHeritageBillA2KHZ),
			new SqlParameter("@FormHeritageBillM2KHZ", formHeritageBill.FormHeritageBillM2KHZ),
			new SqlParameter("@FormHeritageBillE2NZ", formHeritageBill.FormHeritageBillE2NZ),
			new SqlParameter("@FormHeritageBillA2NZ", formHeritageBill.FormHeritageBillA2NZ),
			new SqlParameter("@FormHeritageBillM2NZ", formHeritageBill.FormHeritageBillM2NZ),
			new SqlParameter("@FormHeritageBillEKHZ", formHeritageBill.FormHeritageBillEKHZ),
			new SqlParameter("@FormHeritageBillAKHZ", formHeritageBill.FormHeritageBillAKHZ),
			new SqlParameter("@FormHeritageBillMKHZ", formHeritageBill.FormHeritageBillMKHZ),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeritageBill_SearchLike", CommandType.StoredProcedure, parametersFormHeritageBill))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormHeritageBill tmpFormHeritageBill = new FormHeritageBill();
					tmpFormHeritageBill.FormHeritageBillID = (row["FormHeritageBillID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillID"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillPrintRegisterInformationID = row["FormHeritageBillPrintRegisterInformationID"].ToString();
					tmpFormHeritageBill.FormHeritageBillPrintRegisterDate = row["FormHeritageBillPrintRegisterDate"].ToString();
					tmpFormHeritageBill.FormHeritageBillTaxTotalLetter = row["FormHeritageBillTaxTotalLetter"].ToString();
					tmpFormHeritageBill.FormHeritageBillUser1Code = row["FormHeritageBillUser1Code"].ToString();
					tmpFormHeritageBill.FormHeritageBillUser2Code = row["FormHeritageBillUser2Code"].ToString();
					tmpFormHeritageBill.FormHeritageBillTaxOfficeTitle = row["FormHeritageBillTaxOfficeTitle"].ToString();
					tmpFormHeritageBill.FormHeritageBillDeadFullName = row["FormHeritageBillDeadFullName"].ToString();
					tmpFormHeritageBill.FormHeritageBillDescriptions = row["FormHeritageBillDescriptions"].ToString();
					tmpFormHeritageBill.FormHeritageBillHeritageBill = row["FormHeritageBillHeritageBill"].ToString();
					tmpFormHeritageBill.FormHeritageBillRegisterInformationID = (row["FormHeritageBillRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillRegisterInformationID"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillDeclarationID = (row["FormHeritageBillDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillDeclarationID"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillRegisterarUserNationalCode = (row["FormHeritageBillRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillRegisterarUserNationalCode"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillDeadNationalCode = (row["FormHeritageBillDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillDeadNationalCode"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillDeadDeathDate = row["FormHeritageBillDeadDeathDate"].ToString();
					tmpFormHeritageBill.FormHeritageBillDossierClasses = row["FormHeritageBillDossierClasses"].ToString();
					tmpFormHeritageBill.FormHeritageBillRegisterInformationDate = row["FormHeritageBillRegisterInformationDate"].ToString();
					tmpFormHeritageBill.FormHeritageBillHeirsNumberSummury = row["FormHeritageBillHeirsNumberSummury"].ToString();
					tmpFormHeritageBill.FormHeritageBillHeirSharesSummury = row["FormHeritageBillHeirSharesSummury"].ToString();
					tmpFormHeritageBill.FormHeritageBillTaxDescription = row["FormHeritageBillTaxDescription"].ToString();
					tmpFormHeritageBill.FormHeritageBillBillType = row["FormHeritageBillBillType"].ToString();
					tmpFormHeritageBill.FormHeritageBillUser2FullName = row["FormHeritageBillUser2FullName"].ToString();
					tmpFormHeritageBill.FormHeritageBillUser1FullName = row["FormHeritageBillUser1FullName"].ToString();
					tmpFormHeritageBill.FormHeritageBillENZ = (row["FormHeritageBillENZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillENZ"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillANZ = (row["FormHeritageBillANZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillANZ"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillMNZ = (row["FormHeritageBillMNZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillMNZ"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillDMNZ = (row["FormHeritageBillDMNZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDMNZ"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillDENZ = (row["FormHeritageBillDENZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDENZ"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillDANZ = (row["FormHeritageBillDANZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDANZ"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillTotalValue = (row["FormHeritageBillTotalValue"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillTotalValue"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillTaxTotal = (row["FormHeritageBillTaxTotal"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillTaxTotal"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillDEKHZ = (row["FormHeritageBillDEKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDEKHZ"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillDAKHZ = (row["FormHeritageBillDAKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDAKHZ"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillDMKHZ = (row["FormHeritageBillDMKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDMKHZ"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillE2KHZ = (row["FormHeritageBillE2KHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillE2KHZ"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillA2KHZ = (row["FormHeritageBillA2KHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillA2KHZ"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillM2KHZ = (row["FormHeritageBillM2KHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillM2KHZ"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillE2NZ = (row["FormHeritageBillE2NZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillE2NZ"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillA2NZ = (row["FormHeritageBillA2NZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillA2NZ"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillM2NZ = (row["FormHeritageBillM2NZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillM2NZ"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillEKHZ = (row["FormHeritageBillEKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillEKHZ"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillAKHZ = (row["FormHeritageBillAKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillAKHZ"]) : 0 ;
					tmpFormHeritageBill.FormHeritageBillMKHZ = (row["FormHeritageBillMKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillMKHZ"]) : 0 ;

					listFormHeritageBill.Add(tmpFormHeritageBill);
				}
			}
		}

		return listFormHeritageBill;
	}

}
}
