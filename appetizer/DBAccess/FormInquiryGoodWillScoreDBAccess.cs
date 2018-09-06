using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormInquiryGoodWillScoreDBAccess
{


	public Int64 Insert(FormInquiryGoodWillScore formInquiryGoodWillScore)
	{
		SqlParameter[] parametersFormInquiryGoodWillScore = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillScoreUser2TaxGroupCode", (formInquiryGoodWillScore.FormInquiryGoodWillScoreUser2TaxGroupCode != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreUser2TaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreDeadFullName", (formInquiryGoodWillScore.FormInquiryGoodWillScoreDeadFullName != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreComment", (formInquiryGoodWillScore.FormInquiryGoodWillScoreComment != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreComment : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreTitle", (formInquiryGoodWillScore.FormInquiryGoodWillScoreTitle != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreTitle : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScorePlaque", (formInquiryGoodWillScore.FormInquiryGoodWillScorePlaque != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScorePlaque : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScorelSection", (formInquiryGoodWillScore.FormInquiryGoodWillScorelSection != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScorelSection : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScorelRegisterInformationDate", (formInquiryGoodWillScore.FormInquiryGoodWillScorelRegisterInformationDate != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScorelRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreDossierClasses", (formInquiryGoodWillScore.FormInquiryGoodWillScoreDossierClasses != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreDeadDeathDate", (formInquiryGoodWillScore.FormInquiryGoodWillScoreDeadDeathDate != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreRegisterInformationID", (formInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterInformationID != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreRegisterarUserNationalCode", (formInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterarUserNationalCode > 0) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreDeclarationID", (formInquiryGoodWillScore.FormInquiryGoodWillScoreDeclarationID > 0) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreDeclarationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreFormInquiryResponseID", (formInquiryGoodWillScore.FormInquiryGoodWillScoreFormInquiryResponseID > 0) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreFormInquiryResponseID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreInquiryTo", (formInquiryGoodWillScore.FormInquiryGoodWillScoreInquiryTo != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreInquiryTo : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreRuleComment", (formInquiryGoodWillScore.FormInquiryGoodWillScoreRuleComment != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreRuleComment : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreTaxUnitCode", (formInquiryGoodWillScore.FormInquiryGoodWillScoreTaxUnitCode != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreUser1FullName", (formInquiryGoodWillScore.FormInquiryGoodWillScoreUser1FullName != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreUser2FullName", (formInquiryGoodWillScore.FormInquiryGoodWillScoreUser2FullName != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreUser1TaxUnitCode", (formInquiryGoodWillScore.FormInquiryGoodWillScoreUser1TaxUnitCode != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreUser1TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreAddress", (formInquiryGoodWillScore.FormInquiryGoodWillScoreAddress != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreAddress : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreSixth", (formInquiryGoodWillScore.FormInquiryGoodWillScoreSixth != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreSixth : (object)DBNull.Value)
		};
		formInquiryGoodWillScore.FormInquiryGoodWillScorelID = SqlDBHelper.ExecuteScalar("FormInquiryGoodWillScore_Insert", CommandType.StoredProcedure, parametersFormInquiryGoodWillScore);
		return formInquiryGoodWillScore.FormInquiryGoodWillScorelID;
	}

	public bool Update(FormInquiryGoodWillScore formInquiryGoodWillScore)
	{
		SqlParameter[] parametersFormInquiryGoodWillScore = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillScorelID", formInquiryGoodWillScore.FormInquiryGoodWillScorelID),
			new SqlParameter("@FormInquiryGoodWillScoreUser2TaxGroupCode", (formInquiryGoodWillScore.FormInquiryGoodWillScoreUser2TaxGroupCode != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreUser2TaxGroupCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreDeadFullName", (formInquiryGoodWillScore.FormInquiryGoodWillScoreDeadFullName != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreDeadFullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreComment", (formInquiryGoodWillScore.FormInquiryGoodWillScoreComment != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreComment : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreTitle", (formInquiryGoodWillScore.FormInquiryGoodWillScoreTitle != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreTitle : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScorePlaque", (formInquiryGoodWillScore.FormInquiryGoodWillScorePlaque != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScorePlaque : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScorelSection", (formInquiryGoodWillScore.FormInquiryGoodWillScorelSection != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScorelSection : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScorelRegisterInformationDate", (formInquiryGoodWillScore.FormInquiryGoodWillScorelRegisterInformationDate != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScorelRegisterInformationDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreDossierClasses", (formInquiryGoodWillScore.FormInquiryGoodWillScoreDossierClasses != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreDossierClasses : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreDeadDeathDate", (formInquiryGoodWillScore.FormInquiryGoodWillScoreDeadDeathDate != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreDeadDeathDate : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreRegisterInformationID", (formInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterInformationID != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreRegisterarUserNationalCode", (formInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterarUserNationalCode != null && formInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterarUserNationalCode >0 ) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterarUserNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreDeclarationID", formInquiryGoodWillScore.FormInquiryGoodWillScoreDeclarationID),
			new SqlParameter("@FormInquiryGoodWillScoreFormInquiryResponseID", (formInquiryGoodWillScore.FormInquiryGoodWillScoreFormInquiryResponseID != null && formInquiryGoodWillScore.FormInquiryGoodWillScoreFormInquiryResponseID >0 ) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreFormInquiryResponseID : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreInquiryTo", (formInquiryGoodWillScore.FormInquiryGoodWillScoreInquiryTo != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreInquiryTo : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreRuleComment", (formInquiryGoodWillScore.FormInquiryGoodWillScoreRuleComment != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreRuleComment : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreTaxUnitCode", (formInquiryGoodWillScore.FormInquiryGoodWillScoreTaxUnitCode != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreTaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreUser1FullName", (formInquiryGoodWillScore.FormInquiryGoodWillScoreUser1FullName != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreUser1FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreUser2FullName", (formInquiryGoodWillScore.FormInquiryGoodWillScoreUser2FullName != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreUser2FullName : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreUser1TaxUnitCode", (formInquiryGoodWillScore.FormInquiryGoodWillScoreUser1TaxUnitCode != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreUser1TaxUnitCode : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreAddress", (formInquiryGoodWillScore.FormInquiryGoodWillScoreAddress != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreAddress : (object)DBNull.Value),
			new SqlParameter("@FormInquiryGoodWillScoreSixth", (formInquiryGoodWillScore.FormInquiryGoodWillScoreSixth != null) ? formInquiryGoodWillScore.FormInquiryGoodWillScoreSixth : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormInquiryGoodWillScore_Update", CommandType.StoredProcedure, parametersFormInquiryGoodWillScore);
	}

	public bool Delete(Int64 formInquiryGoodWillScorelID)
	{
		SqlParameter[] parametersFormInquiryGoodWillScore = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillScorelID", formInquiryGoodWillScorelID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormInquiryGoodWillScore_Delete", CommandType.StoredProcedure, parametersFormInquiryGoodWillScore);
	}

	public FormInquiryGoodWillScore GetDetails(Int64 formInquiryGoodWillScorelID)
	{
		FormInquiryGoodWillScore formInquiryGoodWillScore = new FormInquiryGoodWillScore();

		SqlParameter[] parametersFormInquiryGoodWillScore = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillScorelID", formInquiryGoodWillScorelID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryGoodWillScore_GetDetails", CommandType.StoredProcedure, parametersFormInquiryGoodWillScore))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				formInquiryGoodWillScore.FormInquiryGoodWillScorelID = (row["FormInquiryGoodWillScorelID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScorelID"]) : 0 ;
				formInquiryGoodWillScore.FormInquiryGoodWillScorePrintRegisterInformationID = row["FormInquiryGoodWillScorePrintRegisterInformationID"].ToString();
				formInquiryGoodWillScore.FormInquiryGoodWillScorePrintRegisterDate = row["FormInquiryGoodWillScorePrintRegisterDate"].ToString();
				formInquiryGoodWillScore.FormInquiryGoodWillScoreUser2TaxGroupCode = row["FormInquiryGoodWillScoreUser2TaxGroupCode"].ToString();
				formInquiryGoodWillScore.FormInquiryGoodWillScoreDeadFullName = row["FormInquiryGoodWillScoreDeadFullName"].ToString();
				formInquiryGoodWillScore.FormInquiryGoodWillScoreComment = row["FormInquiryGoodWillScoreComment"].ToString();
				formInquiryGoodWillScore.FormInquiryGoodWillScoreTitle = row["FormInquiryGoodWillScoreTitle"].ToString();
				formInquiryGoodWillScore.FormInquiryGoodWillScorePlaque = row["FormInquiryGoodWillScorePlaque"].ToString();
				formInquiryGoodWillScore.FormInquiryGoodWillScorelSection = row["FormInquiryGoodWillScorelSection"].ToString();
				formInquiryGoodWillScore.FormInquiryGoodWillScorelRegisterInformationDate = row["FormInquiryGoodWillScorelRegisterInformationDate"].ToString();
				formInquiryGoodWillScore.FormInquiryGoodWillScoreDossierClasses = row["FormInquiryGoodWillScoreDossierClasses"].ToString();
				formInquiryGoodWillScore.FormInquiryGoodWillScoreDeadDeathDate = row["FormInquiryGoodWillScoreDeadDeathDate"].ToString();
				formInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterInformationID = (row["FormInquiryGoodWillScoreRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScoreRegisterInformationID"]) : 0 ;
				formInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterarUserNationalCode = (row["FormInquiryGoodWillScoreRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScoreRegisterarUserNationalCode"]) : 0 ;
				formInquiryGoodWillScore.FormInquiryGoodWillScoreDeclarationID = (row["FormInquiryGoodWillScoreDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScoreDeclarationID"]) : 0 ;
				formInquiryGoodWillScore.FormInquiryGoodWillScoreFormInquiryResponseID = (row["FormInquiryGoodWillScoreFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScoreFormInquiryResponseID"]) : 0 ;
				formInquiryGoodWillScore.FormInquiryGoodWillScoreInquiryTo = row["FormInquiryGoodWillScoreInquiryTo"].ToString();
				formInquiryGoodWillScore.FormInquiryGoodWillScoreRuleComment = row["FormInquiryGoodWillScoreRuleComment"].ToString();
				formInquiryGoodWillScore.FormInquiryGoodWillScoreTaxUnitCode = row["FormInquiryGoodWillScoreTaxUnitCode"].ToString();
				formInquiryGoodWillScore.FormInquiryGoodWillScoreUser1FullName = row["FormInquiryGoodWillScoreUser1FullName"].ToString();
				formInquiryGoodWillScore.FormInquiryGoodWillScoreUser2FullName = row["FormInquiryGoodWillScoreUser2FullName"].ToString();
				formInquiryGoodWillScore.FormInquiryGoodWillScoreUser1TaxUnitCode = row["FormInquiryGoodWillScoreUser1TaxUnitCode"].ToString();
				formInquiryGoodWillScore.FormInquiryGoodWillScoreAddress = row["FormInquiryGoodWillScoreAddress"].ToString();
				formInquiryGoodWillScore.FormInquiryGoodWillScoreSixth = row["FormInquiryGoodWillScoreSixth"].ToString();
			}
		}

		return formInquiryGoodWillScore;
	}

	public List<FormInquiryGoodWillScore> GetListAll()
	{
		List<FormInquiryGoodWillScore> listFormInquiryGoodWillScore = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormInquiryGoodWillScore_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormInquiryGoodWillScore = new List<FormInquiryGoodWillScore>();

				foreach (DataRow row in table.Rows)
				{
					FormInquiryGoodWillScore formInquiryGoodWillScore = new FormInquiryGoodWillScore();
					formInquiryGoodWillScore.FormInquiryGoodWillScorelID = (row["FormInquiryGoodWillScorelID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScorelID"]) : 0 ;
					formInquiryGoodWillScore.FormInquiryGoodWillScorePrintRegisterInformationID = row["FormInquiryGoodWillScorePrintRegisterInformationID"].ToString();
					formInquiryGoodWillScore.FormInquiryGoodWillScorePrintRegisterDate = row["FormInquiryGoodWillScorePrintRegisterDate"].ToString();
					formInquiryGoodWillScore.FormInquiryGoodWillScoreUser2TaxGroupCode = row["FormInquiryGoodWillScoreUser2TaxGroupCode"].ToString();
					formInquiryGoodWillScore.FormInquiryGoodWillScoreDeadFullName = row["FormInquiryGoodWillScoreDeadFullName"].ToString();
					formInquiryGoodWillScore.FormInquiryGoodWillScoreComment = row["FormInquiryGoodWillScoreComment"].ToString();
					formInquiryGoodWillScore.FormInquiryGoodWillScoreTitle = row["FormInquiryGoodWillScoreTitle"].ToString();
					formInquiryGoodWillScore.FormInquiryGoodWillScorePlaque = row["FormInquiryGoodWillScorePlaque"].ToString();
					formInquiryGoodWillScore.FormInquiryGoodWillScorelSection = row["FormInquiryGoodWillScorelSection"].ToString();
					formInquiryGoodWillScore.FormInquiryGoodWillScorelRegisterInformationDate = row["FormInquiryGoodWillScorelRegisterInformationDate"].ToString();
					formInquiryGoodWillScore.FormInquiryGoodWillScoreDossierClasses = row["FormInquiryGoodWillScoreDossierClasses"].ToString();
					formInquiryGoodWillScore.FormInquiryGoodWillScoreDeadDeathDate = row["FormInquiryGoodWillScoreDeadDeathDate"].ToString();
					formInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterInformationID = (row["FormInquiryGoodWillScoreRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScoreRegisterInformationID"]) : 0 ;
					formInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterarUserNationalCode = (row["FormInquiryGoodWillScoreRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScoreRegisterarUserNationalCode"]) : 0 ;
					formInquiryGoodWillScore.FormInquiryGoodWillScoreDeclarationID = (row["FormInquiryGoodWillScoreDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScoreDeclarationID"]) : 0 ;
					formInquiryGoodWillScore.FormInquiryGoodWillScoreFormInquiryResponseID = (row["FormInquiryGoodWillScoreFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScoreFormInquiryResponseID"]) : 0 ;
					formInquiryGoodWillScore.FormInquiryGoodWillScoreInquiryTo = row["FormInquiryGoodWillScoreInquiryTo"].ToString();
					formInquiryGoodWillScore.FormInquiryGoodWillScoreRuleComment = row["FormInquiryGoodWillScoreRuleComment"].ToString();
					formInquiryGoodWillScore.FormInquiryGoodWillScoreTaxUnitCode = row["FormInquiryGoodWillScoreTaxUnitCode"].ToString();
					formInquiryGoodWillScore.FormInquiryGoodWillScoreUser1FullName = row["FormInquiryGoodWillScoreUser1FullName"].ToString();
					formInquiryGoodWillScore.FormInquiryGoodWillScoreUser2FullName = row["FormInquiryGoodWillScoreUser2FullName"].ToString();
					formInquiryGoodWillScore.FormInquiryGoodWillScoreUser1TaxUnitCode = row["FormInquiryGoodWillScoreUser1TaxUnitCode"].ToString();
					formInquiryGoodWillScore.FormInquiryGoodWillScoreAddress = row["FormInquiryGoodWillScoreAddress"].ToString();
					formInquiryGoodWillScore.FormInquiryGoodWillScoreSixth = row["FormInquiryGoodWillScoreSixth"].ToString();
					listFormInquiryGoodWillScore.Add(formInquiryGoodWillScore);
				}
			}
		}

		return listFormInquiryGoodWillScore;
	}

	public bool Exists(Int64 formInquiryGoodWillScorelID)
	{
		SqlParameter[] parametersFormInquiryGoodWillScore = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillScorelID", formInquiryGoodWillScorelID)
		};
		return (SqlDBHelper.ExecuteScalar("FormInquiryGoodWillScore_Exists", CommandType.StoredProcedure, parametersFormInquiryGoodWillScore)>0);
	}

	public bool Exists(FormInquiryGoodWillScore formInquiryGoodWillScore)
	{
		SqlParameter[] parametersFormInquiryGoodWillScore = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillScorelID", formInquiryGoodWillScore.FormInquiryGoodWillScorelID)
		};
		return (SqlDBHelper.ExecuteScalar("FormInquiryGoodWillScore_Exists", CommandType.StoredProcedure, parametersFormInquiryGoodWillScore)>0);
	}

	public List<FormInquiryGoodWillScore> SearchLike(FormInquiryGoodWillScore formInquiryGoodWillScore)
	{
		List<FormInquiryGoodWillScore> listFormInquiryGoodWillScore = new List<FormInquiryGoodWillScore>();


		SqlParameter[] parametersFormInquiryGoodWillScore = new SqlParameter[]
		{
			new SqlParameter("@FormInquiryGoodWillScorelID", formInquiryGoodWillScore.FormInquiryGoodWillScorelID),
			new SqlParameter("@FormInquiryGoodWillScorePrintRegisterInformationID", formInquiryGoodWillScore.FormInquiryGoodWillScorePrintRegisterInformationID),
			new SqlParameter("@FormInquiryGoodWillScorePrintRegisterDate", formInquiryGoodWillScore.FormInquiryGoodWillScorePrintRegisterDate),
			new SqlParameter("@FormInquiryGoodWillScoreUser2TaxGroupCode", formInquiryGoodWillScore.FormInquiryGoodWillScoreUser2TaxGroupCode),
			new SqlParameter("@FormInquiryGoodWillScoreDeadFullName", formInquiryGoodWillScore.FormInquiryGoodWillScoreDeadFullName),
			new SqlParameter("@FormInquiryGoodWillScoreComment", formInquiryGoodWillScore.FormInquiryGoodWillScoreComment),
			new SqlParameter("@FormInquiryGoodWillScoreTitle", formInquiryGoodWillScore.FormInquiryGoodWillScoreTitle),
			new SqlParameter("@FormInquiryGoodWillScorePlaque", formInquiryGoodWillScore.FormInquiryGoodWillScorePlaque),
			new SqlParameter("@FormInquiryGoodWillScorelSection", formInquiryGoodWillScore.FormInquiryGoodWillScorelSection),
			new SqlParameter("@FormInquiryGoodWillScorelRegisterInformationDate", formInquiryGoodWillScore.FormInquiryGoodWillScorelRegisterInformationDate),
			new SqlParameter("@FormInquiryGoodWillScoreDossierClasses", formInquiryGoodWillScore.FormInquiryGoodWillScoreDossierClasses),
			new SqlParameter("@FormInquiryGoodWillScoreDeadDeathDate", formInquiryGoodWillScore.FormInquiryGoodWillScoreDeadDeathDate),
			new SqlParameter("@FormInquiryGoodWillScoreRegisterInformationID", formInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterInformationID),
			new SqlParameter("@FormInquiryGoodWillScoreRegisterarUserNationalCode", formInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterarUserNationalCode),
			new SqlParameter("@FormInquiryGoodWillScoreDeclarationID", formInquiryGoodWillScore.FormInquiryGoodWillScoreDeclarationID),
			new SqlParameter("@FormInquiryGoodWillScoreFormInquiryResponseID", formInquiryGoodWillScore.FormInquiryGoodWillScoreFormInquiryResponseID),
			new SqlParameter("@FormInquiryGoodWillScoreInquiryTo", formInquiryGoodWillScore.FormInquiryGoodWillScoreInquiryTo),
			new SqlParameter("@FormInquiryGoodWillScoreRuleComment", formInquiryGoodWillScore.FormInquiryGoodWillScoreRuleComment),
			new SqlParameter("@FormInquiryGoodWillScoreTaxUnitCode", formInquiryGoodWillScore.FormInquiryGoodWillScoreTaxUnitCode),
			new SqlParameter("@FormInquiryGoodWillScoreUser1FullName", formInquiryGoodWillScore.FormInquiryGoodWillScoreUser1FullName),
			new SqlParameter("@FormInquiryGoodWillScoreUser2FullName", formInquiryGoodWillScore.FormInquiryGoodWillScoreUser2FullName),
			new SqlParameter("@FormInquiryGoodWillScoreUser1TaxUnitCode", formInquiryGoodWillScore.FormInquiryGoodWillScoreUser1TaxUnitCode),
			new SqlParameter("@FormInquiryGoodWillScoreAddress", formInquiryGoodWillScore.FormInquiryGoodWillScoreAddress),
			new SqlParameter("@FormInquiryGoodWillScoreSixth", formInquiryGoodWillScore.FormInquiryGoodWillScoreSixth),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormInquiryGoodWillScore_SearchLike", CommandType.StoredProcedure, parametersFormInquiryGoodWillScore))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormInquiryGoodWillScore tmpFormInquiryGoodWillScore = new FormInquiryGoodWillScore();
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScorelID = (row["FormInquiryGoodWillScorelID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScorelID"]) : 0 ;
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScorePrintRegisterInformationID = row["FormInquiryGoodWillScorePrintRegisterInformationID"].ToString();
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScorePrintRegisterDate = row["FormInquiryGoodWillScorePrintRegisterDate"].ToString();
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScoreUser2TaxGroupCode = row["FormInquiryGoodWillScoreUser2TaxGroupCode"].ToString();
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScoreDeadFullName = row["FormInquiryGoodWillScoreDeadFullName"].ToString();
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScoreComment = row["FormInquiryGoodWillScoreComment"].ToString();
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScoreTitle = row["FormInquiryGoodWillScoreTitle"].ToString();
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScorePlaque = row["FormInquiryGoodWillScorePlaque"].ToString();
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScorelSection = row["FormInquiryGoodWillScorelSection"].ToString();
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScorelRegisterInformationDate = row["FormInquiryGoodWillScorelRegisterInformationDate"].ToString();
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScoreDossierClasses = row["FormInquiryGoodWillScoreDossierClasses"].ToString();
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScoreDeadDeathDate = row["FormInquiryGoodWillScoreDeadDeathDate"].ToString();
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterInformationID = (row["FormInquiryGoodWillScoreRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScoreRegisterInformationID"]) : 0 ;
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScoreRegisterarUserNationalCode = (row["FormInquiryGoodWillScoreRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScoreRegisterarUserNationalCode"]) : 0 ;
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScoreDeclarationID = (row["FormInquiryGoodWillScoreDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScoreDeclarationID"]) : 0 ;
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScoreFormInquiryResponseID = (row["FormInquiryGoodWillScoreFormInquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["FormInquiryGoodWillScoreFormInquiryResponseID"]) : 0 ;
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScoreInquiryTo = row["FormInquiryGoodWillScoreInquiryTo"].ToString();
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScoreRuleComment = row["FormInquiryGoodWillScoreRuleComment"].ToString();
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScoreTaxUnitCode = row["FormInquiryGoodWillScoreTaxUnitCode"].ToString();
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScoreUser1FullName = row["FormInquiryGoodWillScoreUser1FullName"].ToString();
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScoreUser2FullName = row["FormInquiryGoodWillScoreUser2FullName"].ToString();
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScoreUser1TaxUnitCode = row["FormInquiryGoodWillScoreUser1TaxUnitCode"].ToString();
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScoreAddress = row["FormInquiryGoodWillScoreAddress"].ToString();
					tmpFormInquiryGoodWillScore.FormInquiryGoodWillScoreSixth = row["FormInquiryGoodWillScoreSixth"].ToString();

					listFormInquiryGoodWillScore.Add(tmpFormInquiryGoodWillScore);
				}
			}
		}

		return listFormInquiryGoodWillScore;
	}

}
}
