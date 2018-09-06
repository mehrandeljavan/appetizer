using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormDiagnosisPaperDBAccess
{

	FormDiagnosisPaperBackDBAccess formDiagnosisPaperBackDBAccess = new FormDiagnosisPaperBackDBAccess();

	public List<FormDiagnosisPaperBack> GetListFormDiagnosisPaperBack(Int64 formDiagnosisPaperID)
	{
		List<FormDiagnosisPaperBack> listFormDiagnosisPaperBack = new List<FormDiagnosisPaperBack>() { };
		SqlParameter[] parametersFormDiagnosisPaper = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisPaperBackID", formDiagnosisPaperID)
		};

		//Lets get the list of FormDiagnosisPaperBack records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDiagnosisPaperBack_GetList_UseInFormDiagnosisPaper", CommandType.StoredProcedure, parametersFormDiagnosisPaper))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formDiagnosisPaperBack
				listFormDiagnosisPaperBack = new List<FormDiagnosisPaperBack>();

				//Now lets populate the FormDiagnosisPaperBack details into the list of formDiagnosisPaperBacks
				foreach (DataRow row in table.Rows)
				{
					FormDiagnosisPaperBack formDiagnosisPaperBack = ConvertRowToFormDiagnosisPaperBack(row);
					listFormDiagnosisPaperBack.Add(formDiagnosisPaperBack);
				}
			}
		}

		return listFormDiagnosisPaperBack;
	}

	private FormDiagnosisPaperBack ConvertRowToFormDiagnosisPaperBack(DataRow row)
	{
		FormDiagnosisPaperBack formDiagnosisPaperBack = new FormDiagnosisPaperBack();
		formDiagnosisPaperBack.FormDiagnosisPaperBackID = (row["FormDiagnosisPaperBackID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperBackID"]) : 0 ;
		formDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationNumber = (row["FormDiagnosisPaperBackAnnunciationNumber"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperBackAnnunciationNumber"]) : 0 ;
		formDiagnosisPaperBack.FormDiagnosisPaperBackAdjustmentNumber = (row["FormDiagnosisPaperBackAdjustmentNumber"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperBackAdjustmentNumber"]) : 0 ;
		formDiagnosisPaperBack.FormDiagnosisPaperBackCurrentDate = row["FormDiagnosisPaperBackCurrentDate"].ToString();
		formDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationDate = row["FormDiagnosisPaperBackAnnunciationDate"].ToString();
		formDiagnosisPaperBack.FormDiagnosisPaperBackAdjustmentDate = row["FormDiagnosisPaperBackAdjustmentDate"].ToString();
		formDiagnosisPaperBack.FormDiagnosisPaperBackOperatorFullName1 = row["FormDiagnosisPaperBackOperatorFullName1"].ToString();
		formDiagnosisPaperBack.FormDiagnosisPaperBackOperatorType = row["FormDiagnosisPaperBackOperatorType"].ToString();
		formDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationResponseTypeIDTitle = row["FormDiagnosisPaperBackAnnunciationResponseTypeIDTitle"].ToString();
		formDiagnosisPaperBack.FormDiagnosisPaperBackPaidBillPrice = row["FormDiagnosisPaperBackPaidBillPrice"].ToString();
		formDiagnosisPaperBack.FormDiagnosisPaperBackPaidBillNumber = row["FormDiagnosisPaperBackPaidBillNumber"].ToString();
		formDiagnosisPaperBack.FormDiagnosisPaperBackOperatorFullName2 = row["FormDiagnosisPaperBackOperatorFullName2"].ToString();
		formDiagnosisPaperBack.FormDiagnosisPaperBackAdjustedShare = (row["FormDiagnosisPaperBackAdjustedShare"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperBackAdjustedShare"]) : 0 ;
		return formDiagnosisPaperBack;
	}
	public Int64 Insert(FormDiagnosisPaper formDiagnosisPaper)
	{
		SqlParameter[] parametersFormDiagnosisPaper = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisPaperlUser1Code", (formDiagnosisPaper.FormDiagnosisPaperlUser1Code != null) ? formDiagnosisPaper.FormDiagnosisPaperlUser1Code : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperUser1FullName", (formDiagnosisPaper.FormDiagnosisPaperUser1FullName != null) ? formDiagnosisPaper.FormDiagnosisPaperUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperUser2Code", (formDiagnosisPaper.FormDiagnosisPaperUser2Code != null) ? formDiagnosisPaper.FormDiagnosisPaperUser2Code : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperlUser2FullName", (formDiagnosisPaper.FormDiagnosisPaperlUser2FullName != null) ? formDiagnosisPaper.FormDiagnosisPaperlUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTaxDescription", (formDiagnosisPaper.FormDiagnosisPaperTaxDescription != null) ? formDiagnosisPaper.FormDiagnosisPaperTaxDescription : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperDeadNationality", (formDiagnosisPaper.FormDiagnosisPaperDeadNationality != null) ? formDiagnosisPaper.FormDiagnosisPaperDeadNationality : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperDeadLastAddress", (formDiagnosisPaper.FormDiagnosisPaperDeadLastAddress != null) ? formDiagnosisPaper.FormDiagnosisPaperDeadLastAddress : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirLevel1", (formDiagnosisPaper.FormDiagnosisPaperHeirLevel1 != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirLevel1 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirLevel2", (formDiagnosisPaper.FormDiagnosisPaperHeirLevel2 != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirLevel2 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirLevel3", (formDiagnosisPaper.FormDiagnosisPaperHeirLevel3 != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirLevel3 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirLevel4", (formDiagnosisPaper.FormDiagnosisPaperHeirLevel4 != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirLevel4 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirName", (formDiagnosisPaper.FormDiagnosisPaperHeirName != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirFamily", (formDiagnosisPaper.FormDiagnosisPaperHeirFamily != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirFamily : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirIdentifier", (formDiagnosisPaper.FormDiagnosisPaperHeirIdentifier != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirIdentifier : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirAddress", (formDiagnosisPaper.FormDiagnosisPaperHeirAddress != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirAddress : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirNationalCode", (formDiagnosisPaper.FormDiagnosisPaperHeirNationalCode != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperDeadFullName", (formDiagnosisPaper.FormDiagnosisPaperDeadFullName != null) ? formDiagnosisPaper.FormDiagnosisPaperDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirZipCode", (formDiagnosisPaper.FormDiagnosisPaperHeirZipCode != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirZipCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperRegisterInformationID", (formDiagnosisPaper.FormDiagnosisPaperRegisterInformationID > 0) ? formDiagnosisPaper.FormDiagnosisPaperRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperDeclarationID", (formDiagnosisPaper.FormDiagnosisPaperDeclarationID > 0) ? formDiagnosisPaper.FormDiagnosisPaperDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperRegisterarUserNationalCode", (formDiagnosisPaper.FormDiagnosisPaperRegisterarUserNationalCode > 0) ? formDiagnosisPaper.FormDiagnosisPaperRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperDossierClasses", (formDiagnosisPaper.FormDiagnosisPaperDossierClasses != null) ? formDiagnosisPaper.FormDiagnosisPaperDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperDeadDeathDate", (formDiagnosisPaper.FormDiagnosisPaperDeadDeathDate != null) ? formDiagnosisPaper.FormDiagnosisPaperDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperRegisterInformationDate", (formDiagnosisPaper.FormDiagnosisPaperRegisterInformationDate != null) ? formDiagnosisPaper.FormDiagnosisPaperRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperCommentHeader", (formDiagnosisPaper.FormDiagnosisPaperCommentHeader != null) ? formDiagnosisPaper.FormDiagnosisPaperCommentHeader : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTaxOfficeProvince", (formDiagnosisPaper.FormDiagnosisPaperTaxOfficeProvince != null) ? formDiagnosisPaper.FormDiagnosisPaperTaxOfficeProvince : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTaxOfficeCode", (formDiagnosisPaper.FormDiagnosisPaperTaxOfficeCode != null) ? formDiagnosisPaper.FormDiagnosisPaperTaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTaxUnitCode", (formDiagnosisPaper.FormDiagnosisPaperTaxUnitCode != null) ? formDiagnosisPaper.FormDiagnosisPaperTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTaxOfficeAddress", (formDiagnosisPaper.FormDiagnosisPaperTaxOfficeAddress != null) ? formDiagnosisPaper.FormDiagnosisPaperTaxOfficeAddress : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTaxOfficePhoneNumber", (formDiagnosisPaper.FormDiagnosisPaperTaxOfficePhoneNumber != null) ? formDiagnosisPaper.FormDiagnosisPaperTaxOfficePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTotalValue1", (formDiagnosisPaper.FormDiagnosisPaperTotalValue1 != null) ? formDiagnosisPaper.FormDiagnosisPaperTotalValue1 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperReduction1", (formDiagnosisPaper.FormDiagnosisPaperReduction1 != null) ? formDiagnosisPaper.FormDiagnosisPaperReduction1 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTotalValue2", (formDiagnosisPaper.FormDiagnosisPaperTotalValue2 != null) ? formDiagnosisPaper.FormDiagnosisPaperTotalValue2 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperReduction2", (formDiagnosisPaper.FormDiagnosisPaperReduction2 != null) ? formDiagnosisPaper.FormDiagnosisPaperReduction2 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTotalValue3", (formDiagnosisPaper.FormDiagnosisPaperTotalValue3 != null) ? formDiagnosisPaper.FormDiagnosisPaperTotalValue3 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperYourShare", (formDiagnosisPaper.FormDiagnosisPaperYourShare != null) ? formDiagnosisPaper.FormDiagnosisPaperYourShare : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperIncludedShare", (formDiagnosisPaper.FormDiagnosisPaperIncludedShare != null) ? formDiagnosisPaper.FormDiagnosisPaperIncludedShare : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperYourShareWill", (formDiagnosisPaper.FormDiagnosisPaperYourShareWill != null) ? formDiagnosisPaper.FormDiagnosisPaperYourShareWill : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTotalValue4", (formDiagnosisPaper.FormDiagnosisPaperTotalValue4 != null) ? formDiagnosisPaper.FormDiagnosisPaperTotalValue4 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperReduction3", (formDiagnosisPaper.FormDiagnosisPaperReduction3 != null) ? formDiagnosisPaper.FormDiagnosisPaperReduction3 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTax", (formDiagnosisPaper.FormDiagnosisPaperTax != null) ? formDiagnosisPaper.FormDiagnosisPaperTax : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTaxTypeA", (formDiagnosisPaper.FormDiagnosisPaperTaxTypeA != null) ? formDiagnosisPaper.FormDiagnosisPaperTaxTypeA : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTaxTypeB", (formDiagnosisPaper.FormDiagnosisPaperTaxTypeB != null) ? formDiagnosisPaper.FormDiagnosisPaperTaxTypeB : (object)DBNull.Value)
		};
		formDiagnosisPaper.FormDiagnosisPaperID = SqlDBHelper.ExecuteScalar("FormDiagnosisPaper_Insert", CommandType.StoredProcedure, parametersFormDiagnosisPaper);
		return formDiagnosisPaper.FormDiagnosisPaperID;
	}

	public bool Update(FormDiagnosisPaper formDiagnosisPaper)
	{
		SqlParameter[] parametersFormDiagnosisPaper = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisPaperID", formDiagnosisPaper.FormDiagnosisPaperID),
			new SqlParameter("@FormDiagnosisPaperlUser1Code", (formDiagnosisPaper.FormDiagnosisPaperlUser1Code != null) ? formDiagnosisPaper.FormDiagnosisPaperlUser1Code : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperUser1FullName", (formDiagnosisPaper.FormDiagnosisPaperUser1FullName != null) ? formDiagnosisPaper.FormDiagnosisPaperUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperUser2Code", (formDiagnosisPaper.FormDiagnosisPaperUser2Code != null) ? formDiagnosisPaper.FormDiagnosisPaperUser2Code : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperlUser2FullName", (formDiagnosisPaper.FormDiagnosisPaperlUser2FullName != null) ? formDiagnosisPaper.FormDiagnosisPaperlUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTaxDescription", (formDiagnosisPaper.FormDiagnosisPaperTaxDescription != null) ? formDiagnosisPaper.FormDiagnosisPaperTaxDescription : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperDeadNationality", (formDiagnosisPaper.FormDiagnosisPaperDeadNationality != null) ? formDiagnosisPaper.FormDiagnosisPaperDeadNationality : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperDeadLastAddress", (formDiagnosisPaper.FormDiagnosisPaperDeadLastAddress != null) ? formDiagnosisPaper.FormDiagnosisPaperDeadLastAddress : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirLevel1", (formDiagnosisPaper.FormDiagnosisPaperHeirLevel1 != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirLevel1 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirLevel2", (formDiagnosisPaper.FormDiagnosisPaperHeirLevel2 != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirLevel2 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirLevel3", (formDiagnosisPaper.FormDiagnosisPaperHeirLevel3 != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirLevel3 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirLevel4", (formDiagnosisPaper.FormDiagnosisPaperHeirLevel4 != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirLevel4 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirName", (formDiagnosisPaper.FormDiagnosisPaperHeirName != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirFamily", (formDiagnosisPaper.FormDiagnosisPaperHeirFamily != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirFamily : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirIdentifier", (formDiagnosisPaper.FormDiagnosisPaperHeirIdentifier != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirIdentifier : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirAddress", (formDiagnosisPaper.FormDiagnosisPaperHeirAddress != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirAddress : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirNationalCode", (formDiagnosisPaper.FormDiagnosisPaperHeirNationalCode != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperDeadFullName", (formDiagnosisPaper.FormDiagnosisPaperDeadFullName != null) ? formDiagnosisPaper.FormDiagnosisPaperDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperHeirZipCode", (formDiagnosisPaper.FormDiagnosisPaperHeirZipCode != null) ? formDiagnosisPaper.FormDiagnosisPaperHeirZipCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperRegisterInformationID", formDiagnosisPaper.FormDiagnosisPaperRegisterInformationID),
			new SqlParameter("@FormDiagnosisPaperDeclarationID", (formDiagnosisPaper.FormDiagnosisPaperDeclarationID != null && formDiagnosisPaper.FormDiagnosisPaperDeclarationID >0 ) ? formDiagnosisPaper.FormDiagnosisPaperDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperRegisterarUserNationalCode", (formDiagnosisPaper.FormDiagnosisPaperRegisterarUserNationalCode != null && formDiagnosisPaper.FormDiagnosisPaperRegisterarUserNationalCode >0 ) ? formDiagnosisPaper.FormDiagnosisPaperRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperDossierClasses", (formDiagnosisPaper.FormDiagnosisPaperDossierClasses != null) ? formDiagnosisPaper.FormDiagnosisPaperDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperDeadDeathDate", (formDiagnosisPaper.FormDiagnosisPaperDeadDeathDate != null) ? formDiagnosisPaper.FormDiagnosisPaperDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperRegisterInformationDate", (formDiagnosisPaper.FormDiagnosisPaperRegisterInformationDate != null) ? formDiagnosisPaper.FormDiagnosisPaperRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperCommentHeader", (formDiagnosisPaper.FormDiagnosisPaperCommentHeader != null) ? formDiagnosisPaper.FormDiagnosisPaperCommentHeader : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTaxOfficeProvince", (formDiagnosisPaper.FormDiagnosisPaperTaxOfficeProvince != null) ? formDiagnosisPaper.FormDiagnosisPaperTaxOfficeProvince : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTaxOfficeCode", (formDiagnosisPaper.FormDiagnosisPaperTaxOfficeCode != null) ? formDiagnosisPaper.FormDiagnosisPaperTaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTaxUnitCode", (formDiagnosisPaper.FormDiagnosisPaperTaxUnitCode != null) ? formDiagnosisPaper.FormDiagnosisPaperTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTaxOfficeAddress", (formDiagnosisPaper.FormDiagnosisPaperTaxOfficeAddress != null) ? formDiagnosisPaper.FormDiagnosisPaperTaxOfficeAddress : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTaxOfficePhoneNumber", (formDiagnosisPaper.FormDiagnosisPaperTaxOfficePhoneNumber != null) ? formDiagnosisPaper.FormDiagnosisPaperTaxOfficePhoneNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTotalValue1", (formDiagnosisPaper.FormDiagnosisPaperTotalValue1 != null) ? formDiagnosisPaper.FormDiagnosisPaperTotalValue1 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperReduction1", (formDiagnosisPaper.FormDiagnosisPaperReduction1 != null) ? formDiagnosisPaper.FormDiagnosisPaperReduction1 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTotalValue2", (formDiagnosisPaper.FormDiagnosisPaperTotalValue2 != null) ? formDiagnosisPaper.FormDiagnosisPaperTotalValue2 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperReduction2", (formDiagnosisPaper.FormDiagnosisPaperReduction2 != null) ? formDiagnosisPaper.FormDiagnosisPaperReduction2 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTotalValue3", (formDiagnosisPaper.FormDiagnosisPaperTotalValue3 != null) ? formDiagnosisPaper.FormDiagnosisPaperTotalValue3 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperYourShare", (formDiagnosisPaper.FormDiagnosisPaperYourShare != null) ? formDiagnosisPaper.FormDiagnosisPaperYourShare : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperIncludedShare", (formDiagnosisPaper.FormDiagnosisPaperIncludedShare != null) ? formDiagnosisPaper.FormDiagnosisPaperIncludedShare : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperYourShareWill", (formDiagnosisPaper.FormDiagnosisPaperYourShareWill != null) ? formDiagnosisPaper.FormDiagnosisPaperYourShareWill : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTotalValue4", (formDiagnosisPaper.FormDiagnosisPaperTotalValue4 != null) ? formDiagnosisPaper.FormDiagnosisPaperTotalValue4 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperReduction3", (formDiagnosisPaper.FormDiagnosisPaperReduction3 != null) ? formDiagnosisPaper.FormDiagnosisPaperReduction3 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTax", (formDiagnosisPaper.FormDiagnosisPaperTax != null) ? formDiagnosisPaper.FormDiagnosisPaperTax : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTaxTypeA", (formDiagnosisPaper.FormDiagnosisPaperTaxTypeA != null) ? formDiagnosisPaper.FormDiagnosisPaperTaxTypeA : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperTaxTypeB", (formDiagnosisPaper.FormDiagnosisPaperTaxTypeB != null) ? formDiagnosisPaper.FormDiagnosisPaperTaxTypeB : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormDiagnosisPaper_Update", CommandType.StoredProcedure, parametersFormDiagnosisPaper);
	}

	public bool Delete(Int64 formDiagnosisPaperID)
	{
		SqlParameter[] parametersFormDiagnosisPaper = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisPaperID", formDiagnosisPaperID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormDiagnosisPaper_Delete", CommandType.StoredProcedure, parametersFormDiagnosisPaper);
	}

	public FormDiagnosisPaper GetDetails(Int64 formDiagnosisPaperID)
	{
		FormDiagnosisPaper formDiagnosisPaper = new FormDiagnosisPaper();

		SqlParameter[] parametersFormDiagnosisPaper = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisPaperID", formDiagnosisPaperID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDiagnosisPaper_GetDetails", CommandType.StoredProcedure, parametersFormDiagnosisPaper))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				formDiagnosisPaper.FormDiagnosisPaperID = (row["FormDiagnosisPaperID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperID"]) : 0 ;
				formDiagnosisPaper.FormDiagnosisPaperPrintRegisterInformationID = row["FormDiagnosisPaperPrintRegisterInformationID"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperPrintRegisterDate = row["FormDiagnosisPaperPrintRegisterDate"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperlUser1Code = row["FormDiagnosisPaperlUser1Code"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperUser1FullName = row["FormDiagnosisPaperUser1FullName"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperUser2Code = row["FormDiagnosisPaperUser2Code"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperlUser2FullName = row["FormDiagnosisPaperlUser2FullName"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperTaxDescription = row["FormDiagnosisPaperTaxDescription"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperDeadNationality = row["FormDiagnosisPaperDeadNationality"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperDeadLastAddress = row["FormDiagnosisPaperDeadLastAddress"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperHeirLevel1 = row["FormDiagnosisPaperHeirLevel1"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperHeirLevel2 = row["FormDiagnosisPaperHeirLevel2"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperHeirLevel3 = row["FormDiagnosisPaperHeirLevel3"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperHeirLevel4 = row["FormDiagnosisPaperHeirLevel4"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperHeirName = row["FormDiagnosisPaperHeirName"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperHeirFamily = row["FormDiagnosisPaperHeirFamily"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperHeirIdentifier = row["FormDiagnosisPaperHeirIdentifier"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperHeirAddress = row["FormDiagnosisPaperHeirAddress"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperHeirNationalCode = row["FormDiagnosisPaperHeirNationalCode"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperDeadFullName = row["FormDiagnosisPaperDeadFullName"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperHeirZipCode = row["FormDiagnosisPaperHeirZipCode"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperRegisterInformationID = (row["FormDiagnosisPaperRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperRegisterInformationID"]) : 0 ;
				formDiagnosisPaper.FormDiagnosisPaperDeclarationID = (row["FormDiagnosisPaperDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperDeclarationID"]) : 0 ;
				formDiagnosisPaper.FormDiagnosisPaperRegisterarUserNationalCode = (row["FormDiagnosisPaperRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperRegisterarUserNationalCode"]) : 0 ;
				formDiagnosisPaper.FormDiagnosisPaperDossierClasses = row["FormDiagnosisPaperDossierClasses"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperDeadDeathDate = row["FormDiagnosisPaperDeadDeathDate"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperRegisterInformationDate = row["FormDiagnosisPaperRegisterInformationDate"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperCommentHeader = row["FormDiagnosisPaperCommentHeader"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperTaxOfficeProvince = row["FormDiagnosisPaperTaxOfficeProvince"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperTaxOfficeCode = row["FormDiagnosisPaperTaxOfficeCode"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperTaxUnitCode = row["FormDiagnosisPaperTaxUnitCode"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperTaxOfficeAddress = row["FormDiagnosisPaperTaxOfficeAddress"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperTaxOfficePhoneNumber = row["FormDiagnosisPaperTaxOfficePhoneNumber"].ToString();
				formDiagnosisPaper.FormDiagnosisPaperTotalValue1 = (row["FormDiagnosisPaperTotalValue1"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue1"]) : 0 ;
				formDiagnosisPaper.FormDiagnosisPaperReduction1 = (row["FormDiagnosisPaperReduction1"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperReduction1"]) : 0 ;
				formDiagnosisPaper.FormDiagnosisPaperTotalValue2 = (row["FormDiagnosisPaperTotalValue2"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue2"]) : 0 ;
				formDiagnosisPaper.FormDiagnosisPaperReduction2 = (row["FormDiagnosisPaperReduction2"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperReduction2"]) : 0 ;
				formDiagnosisPaper.FormDiagnosisPaperTotalValue3 = (row["FormDiagnosisPaperTotalValue3"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue3"]) : 0 ;
				formDiagnosisPaper.FormDiagnosisPaperYourShare = (row["FormDiagnosisPaperYourShare"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperYourShare"]) : 0 ;
				formDiagnosisPaper.FormDiagnosisPaperIncludedShare = (row["FormDiagnosisPaperIncludedShare"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperIncludedShare"]) : 0 ;
				formDiagnosisPaper.FormDiagnosisPaperYourShareWill = (row["FormDiagnosisPaperYourShareWill"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperYourShareWill"]) : 0 ;
				formDiagnosisPaper.FormDiagnosisPaperTotalValue4 = (row["FormDiagnosisPaperTotalValue4"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue4"]) : 0 ;
				formDiagnosisPaper.FormDiagnosisPaperReduction3 = (row["FormDiagnosisPaperReduction3"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperReduction3"]) : 0 ;
				formDiagnosisPaper.FormDiagnosisPaperTax = (row["FormDiagnosisPaperTax"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTax"]) : 0 ;
				formDiagnosisPaper.FormDiagnosisPaperTaxTypeA = (row["FormDiagnosisPaperTaxTypeA"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTaxTypeA"]) : 0 ;
				formDiagnosisPaper.FormDiagnosisPaperTaxTypeB = (row["FormDiagnosisPaperTaxTypeB"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTaxTypeB"]) : 0 ;
			}
		}

		return formDiagnosisPaper;
	}

	public List<FormDiagnosisPaper> GetListAll()
	{
		List<FormDiagnosisPaper> listFormDiagnosisPaper = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormDiagnosisPaper_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormDiagnosisPaper = new List<FormDiagnosisPaper>();

				foreach (DataRow row in table.Rows)
				{
					FormDiagnosisPaper formDiagnosisPaper = new FormDiagnosisPaper();
					formDiagnosisPaper.FormDiagnosisPaperID = (row["FormDiagnosisPaperID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperID"]) : 0 ;
					formDiagnosisPaper.FormDiagnosisPaperPrintRegisterInformationID = row["FormDiagnosisPaperPrintRegisterInformationID"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperPrintRegisterDate = row["FormDiagnosisPaperPrintRegisterDate"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperlUser1Code = row["FormDiagnosisPaperlUser1Code"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperUser1FullName = row["FormDiagnosisPaperUser1FullName"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperUser2Code = row["FormDiagnosisPaperUser2Code"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperlUser2FullName = row["FormDiagnosisPaperlUser2FullName"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperTaxDescription = row["FormDiagnosisPaperTaxDescription"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperDeadNationality = row["FormDiagnosisPaperDeadNationality"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperDeadLastAddress = row["FormDiagnosisPaperDeadLastAddress"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperHeirLevel1 = row["FormDiagnosisPaperHeirLevel1"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperHeirLevel2 = row["FormDiagnosisPaperHeirLevel2"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperHeirLevel3 = row["FormDiagnosisPaperHeirLevel3"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperHeirLevel4 = row["FormDiagnosisPaperHeirLevel4"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperHeirName = row["FormDiagnosisPaperHeirName"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperHeirFamily = row["FormDiagnosisPaperHeirFamily"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperHeirIdentifier = row["FormDiagnosisPaperHeirIdentifier"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperHeirAddress = row["FormDiagnosisPaperHeirAddress"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperHeirNationalCode = row["FormDiagnosisPaperHeirNationalCode"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperDeadFullName = row["FormDiagnosisPaperDeadFullName"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperHeirZipCode = row["FormDiagnosisPaperHeirZipCode"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperRegisterInformationID = (row["FormDiagnosisPaperRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperRegisterInformationID"]) : 0 ;
					formDiagnosisPaper.FormDiagnosisPaperDeclarationID = (row["FormDiagnosisPaperDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperDeclarationID"]) : 0 ;
					formDiagnosisPaper.FormDiagnosisPaperRegisterarUserNationalCode = (row["FormDiagnosisPaperRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperRegisterarUserNationalCode"]) : 0 ;
					formDiagnosisPaper.FormDiagnosisPaperDossierClasses = row["FormDiagnosisPaperDossierClasses"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperDeadDeathDate = row["FormDiagnosisPaperDeadDeathDate"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperRegisterInformationDate = row["FormDiagnosisPaperRegisterInformationDate"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperCommentHeader = row["FormDiagnosisPaperCommentHeader"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperTaxOfficeProvince = row["FormDiagnosisPaperTaxOfficeProvince"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperTaxOfficeCode = row["FormDiagnosisPaperTaxOfficeCode"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperTaxUnitCode = row["FormDiagnosisPaperTaxUnitCode"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperTaxOfficeAddress = row["FormDiagnosisPaperTaxOfficeAddress"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperTaxOfficePhoneNumber = row["FormDiagnosisPaperTaxOfficePhoneNumber"].ToString();
					formDiagnosisPaper.FormDiagnosisPaperTotalValue1 = (row["FormDiagnosisPaperTotalValue1"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue1"]) : 0 ;
					formDiagnosisPaper.FormDiagnosisPaperReduction1 = (row["FormDiagnosisPaperReduction1"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperReduction1"]) : 0 ;
					formDiagnosisPaper.FormDiagnosisPaperTotalValue2 = (row["FormDiagnosisPaperTotalValue2"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue2"]) : 0 ;
					formDiagnosisPaper.FormDiagnosisPaperReduction2 = (row["FormDiagnosisPaperReduction2"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperReduction2"]) : 0 ;
					formDiagnosisPaper.FormDiagnosisPaperTotalValue3 = (row["FormDiagnosisPaperTotalValue3"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue3"]) : 0 ;
					formDiagnosisPaper.FormDiagnosisPaperYourShare = (row["FormDiagnosisPaperYourShare"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperYourShare"]) : 0 ;
					formDiagnosisPaper.FormDiagnosisPaperIncludedShare = (row["FormDiagnosisPaperIncludedShare"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperIncludedShare"]) : 0 ;
					formDiagnosisPaper.FormDiagnosisPaperYourShareWill = (row["FormDiagnosisPaperYourShareWill"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperYourShareWill"]) : 0 ;
					formDiagnosisPaper.FormDiagnosisPaperTotalValue4 = (row["FormDiagnosisPaperTotalValue4"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue4"]) : 0 ;
					formDiagnosisPaper.FormDiagnosisPaperReduction3 = (row["FormDiagnosisPaperReduction3"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperReduction3"]) : 0 ;
					formDiagnosisPaper.FormDiagnosisPaperTax = (row["FormDiagnosisPaperTax"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTax"]) : 0 ;
					formDiagnosisPaper.FormDiagnosisPaperTaxTypeA = (row["FormDiagnosisPaperTaxTypeA"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTaxTypeA"]) : 0 ;
					formDiagnosisPaper.FormDiagnosisPaperTaxTypeB = (row["FormDiagnosisPaperTaxTypeB"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTaxTypeB"]) : 0 ;
					listFormDiagnosisPaper.Add(formDiagnosisPaper);
				}
			}
		}

		return listFormDiagnosisPaper;
	}

	public bool Exists(Int64 formDiagnosisPaperID)
	{
		SqlParameter[] parametersFormDiagnosisPaper = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisPaperID", formDiagnosisPaperID)
		};
		return (SqlDBHelper.ExecuteScalar("FormDiagnosisPaper_Exists", CommandType.StoredProcedure, parametersFormDiagnosisPaper)>0);
	}

	public bool Exists(FormDiagnosisPaper formDiagnosisPaper)
	{
		SqlParameter[] parametersFormDiagnosisPaper = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisPaperID", formDiagnosisPaper.FormDiagnosisPaperID)
		};
		return (SqlDBHelper.ExecuteScalar("FormDiagnosisPaper_Exists", CommandType.StoredProcedure, parametersFormDiagnosisPaper)>0);
	}

	public List<FormDiagnosisPaper> SearchLike(FormDiagnosisPaper formDiagnosisPaper)
	{
		List<FormDiagnosisPaper> listFormDiagnosisPaper = new List<FormDiagnosisPaper>();


		SqlParameter[] parametersFormDiagnosisPaper = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisPaperID", formDiagnosisPaper.FormDiagnosisPaperID),
			new SqlParameter("@FormDiagnosisPaperPrintRegisterInformationID", formDiagnosisPaper.FormDiagnosisPaperPrintRegisterInformationID),
			new SqlParameter("@FormDiagnosisPaperPrintRegisterDate", formDiagnosisPaper.FormDiagnosisPaperPrintRegisterDate),
			new SqlParameter("@FormDiagnosisPaperlUser1Code", formDiagnosisPaper.FormDiagnosisPaperlUser1Code),
			new SqlParameter("@FormDiagnosisPaperUser1FullName", formDiagnosisPaper.FormDiagnosisPaperUser1FullName),
			new SqlParameter("@FormDiagnosisPaperUser2Code", formDiagnosisPaper.FormDiagnosisPaperUser2Code),
			new SqlParameter("@FormDiagnosisPaperlUser2FullName", formDiagnosisPaper.FormDiagnosisPaperlUser2FullName),
			new SqlParameter("@FormDiagnosisPaperTaxDescription", formDiagnosisPaper.FormDiagnosisPaperTaxDescription),
			new SqlParameter("@FormDiagnosisPaperDeadNationality", formDiagnosisPaper.FormDiagnosisPaperDeadNationality),
			new SqlParameter("@FormDiagnosisPaperDeadLastAddress", formDiagnosisPaper.FormDiagnosisPaperDeadLastAddress),
			new SqlParameter("@FormDiagnosisPaperHeirLevel1", formDiagnosisPaper.FormDiagnosisPaperHeirLevel1),
			new SqlParameter("@FormDiagnosisPaperHeirLevel2", formDiagnosisPaper.FormDiagnosisPaperHeirLevel2),
			new SqlParameter("@FormDiagnosisPaperHeirLevel3", formDiagnosisPaper.FormDiagnosisPaperHeirLevel3),
			new SqlParameter("@FormDiagnosisPaperHeirLevel4", formDiagnosisPaper.FormDiagnosisPaperHeirLevel4),
			new SqlParameter("@FormDiagnosisPaperHeirName", formDiagnosisPaper.FormDiagnosisPaperHeirName),
			new SqlParameter("@FormDiagnosisPaperHeirFamily", formDiagnosisPaper.FormDiagnosisPaperHeirFamily),
			new SqlParameter("@FormDiagnosisPaperHeirIdentifier", formDiagnosisPaper.FormDiagnosisPaperHeirIdentifier),
			new SqlParameter("@FormDiagnosisPaperHeirAddress", formDiagnosisPaper.FormDiagnosisPaperHeirAddress),
			new SqlParameter("@FormDiagnosisPaperHeirNationalCode", formDiagnosisPaper.FormDiagnosisPaperHeirNationalCode),
			new SqlParameter("@FormDiagnosisPaperDeadFullName", formDiagnosisPaper.FormDiagnosisPaperDeadFullName),
			new SqlParameter("@FormDiagnosisPaperHeirZipCode", formDiagnosisPaper.FormDiagnosisPaperHeirZipCode),
			new SqlParameter("@FormDiagnosisPaperRegisterInformationID", formDiagnosisPaper.FormDiagnosisPaperRegisterInformationID),
			new SqlParameter("@FormDiagnosisPaperDeclarationID", formDiagnosisPaper.FormDiagnosisPaperDeclarationID),
			new SqlParameter("@FormDiagnosisPaperRegisterarUserNationalCode", formDiagnosisPaper.FormDiagnosisPaperRegisterarUserNationalCode),
			new SqlParameter("@FormDiagnosisPaperDossierClasses", formDiagnosisPaper.FormDiagnosisPaperDossierClasses),
			new SqlParameter("@FormDiagnosisPaperDeadDeathDate", formDiagnosisPaper.FormDiagnosisPaperDeadDeathDate),
			new SqlParameter("@FormDiagnosisPaperRegisterInformationDate", formDiagnosisPaper.FormDiagnosisPaperRegisterInformationDate),
			new SqlParameter("@FormDiagnosisPaperCommentHeader", formDiagnosisPaper.FormDiagnosisPaperCommentHeader),
			new SqlParameter("@FormDiagnosisPaperTaxOfficeProvince", formDiagnosisPaper.FormDiagnosisPaperTaxOfficeProvince),
			new SqlParameter("@FormDiagnosisPaperTaxOfficeCode", formDiagnosisPaper.FormDiagnosisPaperTaxOfficeCode),
			new SqlParameter("@FormDiagnosisPaperTaxUnitCode", formDiagnosisPaper.FormDiagnosisPaperTaxUnitCode),
			new SqlParameter("@FormDiagnosisPaperTaxOfficeAddress", formDiagnosisPaper.FormDiagnosisPaperTaxOfficeAddress),
			new SqlParameter("@FormDiagnosisPaperTaxOfficePhoneNumber", formDiagnosisPaper.FormDiagnosisPaperTaxOfficePhoneNumber),
			new SqlParameter("@FormDiagnosisPaperTotalValue1", formDiagnosisPaper.FormDiagnosisPaperTotalValue1),
			new SqlParameter("@FormDiagnosisPaperReduction1", formDiagnosisPaper.FormDiagnosisPaperReduction1),
			new SqlParameter("@FormDiagnosisPaperTotalValue2", formDiagnosisPaper.FormDiagnosisPaperTotalValue2),
			new SqlParameter("@FormDiagnosisPaperReduction2", formDiagnosisPaper.FormDiagnosisPaperReduction2),
			new SqlParameter("@FormDiagnosisPaperTotalValue3", formDiagnosisPaper.FormDiagnosisPaperTotalValue3),
			new SqlParameter("@FormDiagnosisPaperYourShare", formDiagnosisPaper.FormDiagnosisPaperYourShare),
			new SqlParameter("@FormDiagnosisPaperIncludedShare", formDiagnosisPaper.FormDiagnosisPaperIncludedShare),
			new SqlParameter("@FormDiagnosisPaperYourShareWill", formDiagnosisPaper.FormDiagnosisPaperYourShareWill),
			new SqlParameter("@FormDiagnosisPaperTotalValue4", formDiagnosisPaper.FormDiagnosisPaperTotalValue4),
			new SqlParameter("@FormDiagnosisPaperReduction3", formDiagnosisPaper.FormDiagnosisPaperReduction3),
			new SqlParameter("@FormDiagnosisPaperTax", formDiagnosisPaper.FormDiagnosisPaperTax),
			new SqlParameter("@FormDiagnosisPaperTaxTypeA", formDiagnosisPaper.FormDiagnosisPaperTaxTypeA),
			new SqlParameter("@FormDiagnosisPaperTaxTypeB", formDiagnosisPaper.FormDiagnosisPaperTaxTypeB),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDiagnosisPaper_SearchLike", CommandType.StoredProcedure, parametersFormDiagnosisPaper))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormDiagnosisPaper tmpFormDiagnosisPaper = new FormDiagnosisPaper();
					tmpFormDiagnosisPaper.FormDiagnosisPaperID = (row["FormDiagnosisPaperID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperID"]) : 0 ;
					tmpFormDiagnosisPaper.FormDiagnosisPaperPrintRegisterInformationID = row["FormDiagnosisPaperPrintRegisterInformationID"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperPrintRegisterDate = row["FormDiagnosisPaperPrintRegisterDate"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperlUser1Code = row["FormDiagnosisPaperlUser1Code"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperUser1FullName = row["FormDiagnosisPaperUser1FullName"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperUser2Code = row["FormDiagnosisPaperUser2Code"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperlUser2FullName = row["FormDiagnosisPaperlUser2FullName"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperTaxDescription = row["FormDiagnosisPaperTaxDescription"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperDeadNationality = row["FormDiagnosisPaperDeadNationality"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperDeadLastAddress = row["FormDiagnosisPaperDeadLastAddress"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperHeirLevel1 = row["FormDiagnosisPaperHeirLevel1"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperHeirLevel2 = row["FormDiagnosisPaperHeirLevel2"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperHeirLevel3 = row["FormDiagnosisPaperHeirLevel3"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperHeirLevel4 = row["FormDiagnosisPaperHeirLevel4"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperHeirName = row["FormDiagnosisPaperHeirName"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperHeirFamily = row["FormDiagnosisPaperHeirFamily"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperHeirIdentifier = row["FormDiagnosisPaperHeirIdentifier"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperHeirAddress = row["FormDiagnosisPaperHeirAddress"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperHeirNationalCode = row["FormDiagnosisPaperHeirNationalCode"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperDeadFullName = row["FormDiagnosisPaperDeadFullName"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperHeirZipCode = row["FormDiagnosisPaperHeirZipCode"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperRegisterInformationID = (row["FormDiagnosisPaperRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperRegisterInformationID"]) : 0 ;
					tmpFormDiagnosisPaper.FormDiagnosisPaperDeclarationID = (row["FormDiagnosisPaperDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperDeclarationID"]) : 0 ;
					tmpFormDiagnosisPaper.FormDiagnosisPaperRegisterarUserNationalCode = (row["FormDiagnosisPaperRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperRegisterarUserNationalCode"]) : 0 ;
					tmpFormDiagnosisPaper.FormDiagnosisPaperDossierClasses = row["FormDiagnosisPaperDossierClasses"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperDeadDeathDate = row["FormDiagnosisPaperDeadDeathDate"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperRegisterInformationDate = row["FormDiagnosisPaperRegisterInformationDate"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperCommentHeader = row["FormDiagnosisPaperCommentHeader"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperTaxOfficeProvince = row["FormDiagnosisPaperTaxOfficeProvince"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperTaxOfficeCode = row["FormDiagnosisPaperTaxOfficeCode"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperTaxUnitCode = row["FormDiagnosisPaperTaxUnitCode"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperTaxOfficeAddress = row["FormDiagnosisPaperTaxOfficeAddress"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperTaxOfficePhoneNumber = row["FormDiagnosisPaperTaxOfficePhoneNumber"].ToString();
					tmpFormDiagnosisPaper.FormDiagnosisPaperTotalValue1 = (row["FormDiagnosisPaperTotalValue1"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue1"]) : 0 ;
					tmpFormDiagnosisPaper.FormDiagnosisPaperReduction1 = (row["FormDiagnosisPaperReduction1"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperReduction1"]) : 0 ;
					tmpFormDiagnosisPaper.FormDiagnosisPaperTotalValue2 = (row["FormDiagnosisPaperTotalValue2"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue2"]) : 0 ;
					tmpFormDiagnosisPaper.FormDiagnosisPaperReduction2 = (row["FormDiagnosisPaperReduction2"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperReduction2"]) : 0 ;
					tmpFormDiagnosisPaper.FormDiagnosisPaperTotalValue3 = (row["FormDiagnosisPaperTotalValue3"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue3"]) : 0 ;
					tmpFormDiagnosisPaper.FormDiagnosisPaperYourShare = (row["FormDiagnosisPaperYourShare"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperYourShare"]) : 0 ;
					tmpFormDiagnosisPaper.FormDiagnosisPaperIncludedShare = (row["FormDiagnosisPaperIncludedShare"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperIncludedShare"]) : 0 ;
					tmpFormDiagnosisPaper.FormDiagnosisPaperYourShareWill = (row["FormDiagnosisPaperYourShareWill"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperYourShareWill"]) : 0 ;
					tmpFormDiagnosisPaper.FormDiagnosisPaperTotalValue4 = (row["FormDiagnosisPaperTotalValue4"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue4"]) : 0 ;
					tmpFormDiagnosisPaper.FormDiagnosisPaperReduction3 = (row["FormDiagnosisPaperReduction3"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperReduction3"]) : 0 ;
					tmpFormDiagnosisPaper.FormDiagnosisPaperTax = (row["FormDiagnosisPaperTax"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTax"]) : 0 ;
					tmpFormDiagnosisPaper.FormDiagnosisPaperTaxTypeA = (row["FormDiagnosisPaperTaxTypeA"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTaxTypeA"]) : 0 ;
					tmpFormDiagnosisPaper.FormDiagnosisPaperTaxTypeB = (row["FormDiagnosisPaperTaxTypeB"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTaxTypeB"]) : 0 ;

					listFormDiagnosisPaper.Add(tmpFormDiagnosisPaper);
				}
			}
		}

		return listFormDiagnosisPaper;
	}

}
}
