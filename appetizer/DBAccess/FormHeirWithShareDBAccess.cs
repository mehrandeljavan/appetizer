using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormHeirWithShareDBAccess
{


	public Int64 Insert(FormHeirWithShare formHeirWithShare)
	{
		SqlParameter[] parametersFormHeirWithShare = new SqlParameter[]
		{
			new SqlParameter("@FormHeirWithShareFormBillTaxID", (formHeirWithShare.FormHeirWithShareFormBillTaxID > 0) ? formHeirWithShare.FormHeirWithShareFormBillTaxID : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareNationalCode", (formHeirWithShare.FormHeirWithShareNationalCode != null) ? formHeirWithShare.FormHeirWithShareNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareFullName", (formHeirWithShare.FormHeirWithShareFullName != null) ? formHeirWithShare.FormHeirWithShareFullName : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareRelationTitle", (formHeirWithShare.FormHeirWithShareRelationTitle != null) ? formHeirWithShare.FormHeirWithShareRelationTitle : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareComment", (formHeirWithShare.FormHeirWithShareComment != null) ? formHeirWithShare.FormHeirWithShareComment : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareTaxTotalLetter", (formHeirWithShare.FormHeirWithShareTaxTotalLetter != null) ? formHeirWithShare.FormHeirWithShareTaxTotalLetter : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareHeirShare", (formHeirWithShare.FormHeirWithShareHeirShare != null) ? formHeirWithShare.FormHeirWithShareHeirShare : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareReduction", (formHeirWithShare.FormHeirWithShareReduction != null) ? formHeirWithShare.FormHeirWithShareReduction : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareRemaining", (formHeirWithShare.FormHeirWithShareRemaining != null) ? formHeirWithShare.FormHeirWithShareRemaining : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareTaxTotal", (formHeirWithShare.FormHeirWithShareTaxTotal != null) ? formHeirWithShare.FormHeirWithShareTaxTotal : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareTaxTypeB", (formHeirWithShare.FormHeirWithShareTaxTypeB != null) ? formHeirWithShare.FormHeirWithShareTaxTypeB : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareTaxTypeA", (formHeirWithShare.FormHeirWithShareTaxTypeA != null) ? formHeirWithShare.FormHeirWithShareTaxTypeA : (object)DBNull.Value)
		};
		formHeirWithShare.FormHeirWithShareID = SqlDBHelper.ExecuteScalar("FormHeirWithShare_Insert", CommandType.StoredProcedure, parametersFormHeirWithShare);
		return formHeirWithShare.FormHeirWithShareID;
	}

	public bool Update(FormHeirWithShare formHeirWithShare)
	{
		SqlParameter[] parametersFormHeirWithShare = new SqlParameter[]
		{
			new SqlParameter("@FormHeirWithShareID", formHeirWithShare.FormHeirWithShareID),
			new SqlParameter("@FormHeirWithShareFormBillTaxID", formHeirWithShare.FormHeirWithShareFormBillTaxID),
			new SqlParameter("@FormHeirWithShareNationalCode", (formHeirWithShare.FormHeirWithShareNationalCode != null) ? formHeirWithShare.FormHeirWithShareNationalCode : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareFullName", (formHeirWithShare.FormHeirWithShareFullName != null) ? formHeirWithShare.FormHeirWithShareFullName : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareRelationTitle", (formHeirWithShare.FormHeirWithShareRelationTitle != null) ? formHeirWithShare.FormHeirWithShareRelationTitle : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareComment", (formHeirWithShare.FormHeirWithShareComment != null) ? formHeirWithShare.FormHeirWithShareComment : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareTaxTotalLetter", (formHeirWithShare.FormHeirWithShareTaxTotalLetter != null) ? formHeirWithShare.FormHeirWithShareTaxTotalLetter : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareHeirShare", (formHeirWithShare.FormHeirWithShareHeirShare != null) ? formHeirWithShare.FormHeirWithShareHeirShare : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareReduction", (formHeirWithShare.FormHeirWithShareReduction != null) ? formHeirWithShare.FormHeirWithShareReduction : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareRemaining", (formHeirWithShare.FormHeirWithShareRemaining != null) ? formHeirWithShare.FormHeirWithShareRemaining : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareTaxTotal", (formHeirWithShare.FormHeirWithShareTaxTotal != null) ? formHeirWithShare.FormHeirWithShareTaxTotal : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareTaxTypeB", (formHeirWithShare.FormHeirWithShareTaxTypeB != null) ? formHeirWithShare.FormHeirWithShareTaxTypeB : (object)DBNull.Value),
			new SqlParameter("@FormHeirWithShareTaxTypeA", (formHeirWithShare.FormHeirWithShareTaxTypeA != null) ? formHeirWithShare.FormHeirWithShareTaxTypeA : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormHeirWithShare_Update", CommandType.StoredProcedure, parametersFormHeirWithShare);
	}

	public bool Delete(Int64 formHeirWithShareID)
	{
		SqlParameter[] parametersFormHeirWithShare = new SqlParameter[]
		{
			new SqlParameter("@FormHeirWithShareID", formHeirWithShareID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormHeirWithShare_Delete", CommandType.StoredProcedure, parametersFormHeirWithShare);
	}

	public FormHeirWithShare GetDetails(Int64 formHeirWithShareID)
	{
		FormHeirWithShare formHeirWithShare = new FormHeirWithShare();

		SqlParameter[] parametersFormHeirWithShare = new SqlParameter[]
		{
			new SqlParameter("@FormHeirWithShareID", formHeirWithShareID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeirWithShare_GetDetails", CommandType.StoredProcedure, parametersFormHeirWithShare))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				formHeirWithShare.FormHeirWithShareID = (row["FormHeirWithShareID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeirWithShareID"]) : 0 ;
				formHeirWithShare.FormHeirWithShareFormBillTaxID = (row["FormHeirWithShareFormBillTaxID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeirWithShareFormBillTaxID"]) : 0 ;
				formHeirWithShare.FormHeirWithShareNationalCode = (row["FormHeirWithShareNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeirWithShareNationalCode"]) : 0 ;
				formHeirWithShare.FormHeirWithShareFullName = row["FormHeirWithShareFullName"].ToString();
				formHeirWithShare.FormHeirWithShareRelationTitle = row["FormHeirWithShareRelationTitle"].ToString();
				formHeirWithShare.FormHeirWithShareComment = row["FormHeirWithShareComment"].ToString();
				formHeirWithShare.FormHeirWithShareTaxTotalLetter = row["FormHeirWithShareTaxTotalLetter"].ToString();
				formHeirWithShare.FormHeirWithShareHeirShare = (row["FormHeirWithShareHeirShare"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareHeirShare"]) : 0 ;
				formHeirWithShare.FormHeirWithShareReduction = (row["FormHeirWithShareReduction"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareReduction"]) : 0 ;
				formHeirWithShare.FormHeirWithShareRemaining = (row["FormHeirWithShareRemaining"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareRemaining"]) : 0 ;
				formHeirWithShare.FormHeirWithShareTaxTotal = (row["FormHeirWithShareTaxTotal"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareTaxTotal"]) : 0 ;
				formHeirWithShare.FormHeirWithShareTaxTypeB = (row["FormHeirWithShareTaxTypeB"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareTaxTypeB"]) : 0 ;
				formHeirWithShare.FormHeirWithShareTaxTypeA = (row["FormHeirWithShareTaxTypeA"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareTaxTypeA"]) : 0 ;
			}
		}

		return formHeirWithShare;
	}

	public List<FormHeirWithShare> GetListAll()
	{
		List<FormHeirWithShare> listFormHeirWithShare = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormHeirWithShare_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormHeirWithShare = new List<FormHeirWithShare>();

				foreach (DataRow row in table.Rows)
				{
					FormHeirWithShare formHeirWithShare = new FormHeirWithShare();
					formHeirWithShare.FormHeirWithShareID = (row["FormHeirWithShareID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeirWithShareID"]) : 0 ;
					formHeirWithShare.FormHeirWithShareFormBillTaxID = (row["FormHeirWithShareFormBillTaxID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeirWithShareFormBillTaxID"]) : 0 ;
					formHeirWithShare.FormHeirWithShareNationalCode = (row["FormHeirWithShareNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeirWithShareNationalCode"]) : 0 ;
					formHeirWithShare.FormHeirWithShareFullName = row["FormHeirWithShareFullName"].ToString();
					formHeirWithShare.FormHeirWithShareRelationTitle = row["FormHeirWithShareRelationTitle"].ToString();
					formHeirWithShare.FormHeirWithShareComment = row["FormHeirWithShareComment"].ToString();
					formHeirWithShare.FormHeirWithShareTaxTotalLetter = row["FormHeirWithShareTaxTotalLetter"].ToString();
					formHeirWithShare.FormHeirWithShareHeirShare = (row["FormHeirWithShareHeirShare"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareHeirShare"]) : 0 ;
					formHeirWithShare.FormHeirWithShareReduction = (row["FormHeirWithShareReduction"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareReduction"]) : 0 ;
					formHeirWithShare.FormHeirWithShareRemaining = (row["FormHeirWithShareRemaining"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareRemaining"]) : 0 ;
					formHeirWithShare.FormHeirWithShareTaxTotal = (row["FormHeirWithShareTaxTotal"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareTaxTotal"]) : 0 ;
					formHeirWithShare.FormHeirWithShareTaxTypeB = (row["FormHeirWithShareTaxTypeB"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareTaxTypeB"]) : 0 ;
					formHeirWithShare.FormHeirWithShareTaxTypeA = (row["FormHeirWithShareTaxTypeA"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareTaxTypeA"]) : 0 ;
					listFormHeirWithShare.Add(formHeirWithShare);
				}
			}
		}

		return listFormHeirWithShare;
	}

	public bool Exists(Int64 formHeirWithShareID)
	{
		SqlParameter[] parametersFormHeirWithShare = new SqlParameter[]
		{
			new SqlParameter("@FormHeirWithShareID", formHeirWithShareID)
		};
		return (SqlDBHelper.ExecuteScalar("FormHeirWithShare_Exists", CommandType.StoredProcedure, parametersFormHeirWithShare)>0);
	}

	public bool Exists(FormHeirWithShare formHeirWithShare)
	{
		SqlParameter[] parametersFormHeirWithShare = new SqlParameter[]
		{
			new SqlParameter("@FormHeirWithShareID", formHeirWithShare.FormHeirWithShareID)
		};
		return (SqlDBHelper.ExecuteScalar("FormHeirWithShare_Exists", CommandType.StoredProcedure, parametersFormHeirWithShare)>0);
	}

	public List<FormHeirWithShare> SearchLike(FormHeirWithShare formHeirWithShare)
	{
		List<FormHeirWithShare> listFormHeirWithShare = new List<FormHeirWithShare>();


		SqlParameter[] parametersFormHeirWithShare = new SqlParameter[]
		{
			new SqlParameter("@FormHeirWithShareID", formHeirWithShare.FormHeirWithShareID),
			new SqlParameter("@FormHeirWithShareFormBillTaxID", formHeirWithShare.FormHeirWithShareFormBillTaxID),
			new SqlParameter("@FormHeirWithShareNationalCode", formHeirWithShare.FormHeirWithShareNationalCode),
			new SqlParameter("@FormHeirWithShareFullName", formHeirWithShare.FormHeirWithShareFullName),
			new SqlParameter("@FormHeirWithShareRelationTitle", formHeirWithShare.FormHeirWithShareRelationTitle),
			new SqlParameter("@FormHeirWithShareComment", formHeirWithShare.FormHeirWithShareComment),
			new SqlParameter("@FormHeirWithShareTaxTotalLetter", formHeirWithShare.FormHeirWithShareTaxTotalLetter),
			new SqlParameter("@FormHeirWithShareHeirShare", formHeirWithShare.FormHeirWithShareHeirShare),
			new SqlParameter("@FormHeirWithShareReduction", formHeirWithShare.FormHeirWithShareReduction),
			new SqlParameter("@FormHeirWithShareRemaining", formHeirWithShare.FormHeirWithShareRemaining),
			new SqlParameter("@FormHeirWithShareTaxTotal", formHeirWithShare.FormHeirWithShareTaxTotal),
			new SqlParameter("@FormHeirWithShareTaxTypeB", formHeirWithShare.FormHeirWithShareTaxTypeB),
			new SqlParameter("@FormHeirWithShareTaxTypeA", formHeirWithShare.FormHeirWithShareTaxTypeA),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeirWithShare_SearchLike", CommandType.StoredProcedure, parametersFormHeirWithShare))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormHeirWithShare tmpFormHeirWithShare = new FormHeirWithShare();
					tmpFormHeirWithShare.FormHeirWithShareID = (row["FormHeirWithShareID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeirWithShareID"]) : 0 ;
					tmpFormHeirWithShare.FormHeirWithShareFormBillTaxID = (row["FormHeirWithShareFormBillTaxID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeirWithShareFormBillTaxID"]) : 0 ;
					tmpFormHeirWithShare.FormHeirWithShareNationalCode = (row["FormHeirWithShareNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeirWithShareNationalCode"]) : 0 ;
					tmpFormHeirWithShare.FormHeirWithShareFullName = row["FormHeirWithShareFullName"].ToString();
					tmpFormHeirWithShare.FormHeirWithShareRelationTitle = row["FormHeirWithShareRelationTitle"].ToString();
					tmpFormHeirWithShare.FormHeirWithShareComment = row["FormHeirWithShareComment"].ToString();
					tmpFormHeirWithShare.FormHeirWithShareTaxTotalLetter = row["FormHeirWithShareTaxTotalLetter"].ToString();
					tmpFormHeirWithShare.FormHeirWithShareHeirShare = (row["FormHeirWithShareHeirShare"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareHeirShare"]) : 0 ;
					tmpFormHeirWithShare.FormHeirWithShareReduction = (row["FormHeirWithShareReduction"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareReduction"]) : 0 ;
					tmpFormHeirWithShare.FormHeirWithShareRemaining = (row["FormHeirWithShareRemaining"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareRemaining"]) : 0 ;
					tmpFormHeirWithShare.FormHeirWithShareTaxTotal = (row["FormHeirWithShareTaxTotal"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareTaxTotal"]) : 0 ;
					tmpFormHeirWithShare.FormHeirWithShareTaxTypeB = (row["FormHeirWithShareTaxTypeB"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareTaxTypeB"]) : 0 ;
					tmpFormHeirWithShare.FormHeirWithShareTaxTypeA = (row["FormHeirWithShareTaxTypeA"] != DBNull.Value) ? Convert.ToSingle(row["FormHeirWithShareTaxTypeA"]) : 0 ;

					listFormHeirWithShare.Add(tmpFormHeirWithShare);
				}
			}
		}

		return listFormHeirWithShare;
	}

}
}
