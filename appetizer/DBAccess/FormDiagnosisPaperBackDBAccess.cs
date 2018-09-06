using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FormDiagnosisPaperBackDBAccess
{


	public Int64 Insert(FormDiagnosisPaperBack formDiagnosisPaperBack)
	{
		SqlParameter[] parametersFormDiagnosisPaperBack = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisPaperBackID", (formDiagnosisPaperBack.FormDiagnosisPaperBackID > 0) ? formDiagnosisPaperBack.FormDiagnosisPaperBackID : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackAnnunciationNumber", (formDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationNumber != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackAdjustmentNumber", (formDiagnosisPaperBack.FormDiagnosisPaperBackAdjustmentNumber != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackAdjustmentNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackCurrentDate", (formDiagnosisPaperBack.FormDiagnosisPaperBackCurrentDate != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackCurrentDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackAnnunciationDate", (formDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationDate != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackAdjustmentDate", (formDiagnosisPaperBack.FormDiagnosisPaperBackAdjustmentDate != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackAdjustmentDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackOperatorFullName1", (formDiagnosisPaperBack.FormDiagnosisPaperBackOperatorFullName1 != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackOperatorFullName1 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackOperatorType", (formDiagnosisPaperBack.FormDiagnosisPaperBackOperatorType != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackOperatorType : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackAnnunciationResponseTypeIDTitle", (formDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationResponseTypeIDTitle != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationResponseTypeIDTitle : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackPaidBillPrice", (formDiagnosisPaperBack.FormDiagnosisPaperBackPaidBillPrice != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackPaidBillPrice : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackPaidBillNumber", (formDiagnosisPaperBack.FormDiagnosisPaperBackPaidBillNumber != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackPaidBillNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackOperatorFullName2", (formDiagnosisPaperBack.FormDiagnosisPaperBackOperatorFullName2 != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackOperatorFullName2 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackAdjustedShare", (formDiagnosisPaperBack.FormDiagnosisPaperBackAdjustedShare != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackAdjustedShare : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("FormDiagnosisPaperBack_Insert", CommandType.StoredProcedure, parametersFormDiagnosisPaperBack);
	}

	public bool Update(FormDiagnosisPaperBack formDiagnosisPaperBack)
	{
		SqlParameter[] parametersFormDiagnosisPaperBack = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisPaperBackID", formDiagnosisPaperBack.FormDiagnosisPaperBackID),
			new SqlParameter("@FormDiagnosisPaperBackAnnunciationNumber", (formDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationNumber != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackAdjustmentNumber", (formDiagnosisPaperBack.FormDiagnosisPaperBackAdjustmentNumber != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackAdjustmentNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackCurrentDate", (formDiagnosisPaperBack.FormDiagnosisPaperBackCurrentDate != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackCurrentDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackAnnunciationDate", (formDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationDate != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackAdjustmentDate", (formDiagnosisPaperBack.FormDiagnosisPaperBackAdjustmentDate != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackAdjustmentDate : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackOperatorFullName1", (formDiagnosisPaperBack.FormDiagnosisPaperBackOperatorFullName1 != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackOperatorFullName1 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackOperatorType", (formDiagnosisPaperBack.FormDiagnosisPaperBackOperatorType != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackOperatorType : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackAnnunciationResponseTypeIDTitle", (formDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationResponseTypeIDTitle != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationResponseTypeIDTitle : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackPaidBillPrice", (formDiagnosisPaperBack.FormDiagnosisPaperBackPaidBillPrice != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackPaidBillPrice : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackPaidBillNumber", (formDiagnosisPaperBack.FormDiagnosisPaperBackPaidBillNumber != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackPaidBillNumber : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackOperatorFullName2", (formDiagnosisPaperBack.FormDiagnosisPaperBackOperatorFullName2 != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackOperatorFullName2 : (object)DBNull.Value),
			new SqlParameter("@FormDiagnosisPaperBackAdjustedShare", (formDiagnosisPaperBack.FormDiagnosisPaperBackAdjustedShare != null) ? formDiagnosisPaperBack.FormDiagnosisPaperBackAdjustedShare : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FormDiagnosisPaperBack_Update", CommandType.StoredProcedure, parametersFormDiagnosisPaperBack);
	}

	public bool Delete(Int64 formDiagnosisPaperBackID)
	{
		SqlParameter[] parametersFormDiagnosisPaperBack = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisPaperBackID", formDiagnosisPaperBackID)
		};
		return SqlDBHelper.ExecuteNonQuery("FormDiagnosisPaperBack_Delete", CommandType.StoredProcedure, parametersFormDiagnosisPaperBack);
	}

	public FormDiagnosisPaperBack GetDetails(Int64 formDiagnosisPaperBackID)
	{
		FormDiagnosisPaperBack formDiagnosisPaperBack = new FormDiagnosisPaperBack();

		SqlParameter[] parametersFormDiagnosisPaperBack = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisPaperBackID", formDiagnosisPaperBackID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDiagnosisPaperBack_GetDetails", CommandType.StoredProcedure, parametersFormDiagnosisPaperBack))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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
			}
		}

		return formDiagnosisPaperBack;
	}

	public List<FormDiagnosisPaperBack> GetListAll()
	{
		List<FormDiagnosisPaperBack> listFormDiagnosisPaperBack = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FormDiagnosisPaperBack_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFormDiagnosisPaperBack = new List<FormDiagnosisPaperBack>();

				foreach (DataRow row in table.Rows)
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
					listFormDiagnosisPaperBack.Add(formDiagnosisPaperBack);
				}
			}
		}

		return listFormDiagnosisPaperBack;
	}

	public bool Exists(Int64 formDiagnosisPaperBackID)
	{
		SqlParameter[] parametersFormDiagnosisPaperBack = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisPaperBackID", formDiagnosisPaperBackID)
		};
		return (SqlDBHelper.ExecuteScalar("FormDiagnosisPaperBack_Exists", CommandType.StoredProcedure, parametersFormDiagnosisPaperBack)>0);
	}

	public bool Exists(FormDiagnosisPaperBack formDiagnosisPaperBack)
	{
		SqlParameter[] parametersFormDiagnosisPaperBack = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisPaperBackID", formDiagnosisPaperBack.FormDiagnosisPaperBackID)
		};
		return (SqlDBHelper.ExecuteScalar("FormDiagnosisPaperBack_Exists", CommandType.StoredProcedure, parametersFormDiagnosisPaperBack)>0);
	}

	public List<FormDiagnosisPaperBack> SearchLike(FormDiagnosisPaperBack formDiagnosisPaperBack)
	{
		List<FormDiagnosisPaperBack> listFormDiagnosisPaperBack = new List<FormDiagnosisPaperBack>();


		SqlParameter[] parametersFormDiagnosisPaperBack = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisPaperBackID", formDiagnosisPaperBack.FormDiagnosisPaperBackID),
			new SqlParameter("@FormDiagnosisPaperBackAnnunciationNumber", formDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationNumber),
			new SqlParameter("@FormDiagnosisPaperBackAdjustmentNumber", formDiagnosisPaperBack.FormDiagnosisPaperBackAdjustmentNumber),
			new SqlParameter("@FormDiagnosisPaperBackCurrentDate", formDiagnosisPaperBack.FormDiagnosisPaperBackCurrentDate),
			new SqlParameter("@FormDiagnosisPaperBackAnnunciationDate", formDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationDate),
			new SqlParameter("@FormDiagnosisPaperBackAdjustmentDate", formDiagnosisPaperBack.FormDiagnosisPaperBackAdjustmentDate),
			new SqlParameter("@FormDiagnosisPaperBackOperatorFullName1", formDiagnosisPaperBack.FormDiagnosisPaperBackOperatorFullName1),
			new SqlParameter("@FormDiagnosisPaperBackOperatorType", formDiagnosisPaperBack.FormDiagnosisPaperBackOperatorType),
			new SqlParameter("@FormDiagnosisPaperBackAnnunciationResponseTypeIDTitle", formDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationResponseTypeIDTitle),
			new SqlParameter("@FormDiagnosisPaperBackPaidBillPrice", formDiagnosisPaperBack.FormDiagnosisPaperBackPaidBillPrice),
			new SqlParameter("@FormDiagnosisPaperBackPaidBillNumber", formDiagnosisPaperBack.FormDiagnosisPaperBackPaidBillNumber),
			new SqlParameter("@FormDiagnosisPaperBackOperatorFullName2", formDiagnosisPaperBack.FormDiagnosisPaperBackOperatorFullName2),
			new SqlParameter("@FormDiagnosisPaperBackAdjustedShare", formDiagnosisPaperBack.FormDiagnosisPaperBackAdjustedShare),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDiagnosisPaperBack_SearchLike", CommandType.StoredProcedure, parametersFormDiagnosisPaperBack))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FormDiagnosisPaperBack tmpFormDiagnosisPaperBack = new FormDiagnosisPaperBack();
					tmpFormDiagnosisPaperBack.FormDiagnosisPaperBackID = (row["FormDiagnosisPaperBackID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperBackID"]) : 0 ;
					tmpFormDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationNumber = (row["FormDiagnosisPaperBackAnnunciationNumber"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperBackAnnunciationNumber"]) : 0 ;
					tmpFormDiagnosisPaperBack.FormDiagnosisPaperBackAdjustmentNumber = (row["FormDiagnosisPaperBackAdjustmentNumber"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperBackAdjustmentNumber"]) : 0 ;
					tmpFormDiagnosisPaperBack.FormDiagnosisPaperBackCurrentDate = row["FormDiagnosisPaperBackCurrentDate"].ToString();
					tmpFormDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationDate = row["FormDiagnosisPaperBackAnnunciationDate"].ToString();
					tmpFormDiagnosisPaperBack.FormDiagnosisPaperBackAdjustmentDate = row["FormDiagnosisPaperBackAdjustmentDate"].ToString();
					tmpFormDiagnosisPaperBack.FormDiagnosisPaperBackOperatorFullName1 = row["FormDiagnosisPaperBackOperatorFullName1"].ToString();
					tmpFormDiagnosisPaperBack.FormDiagnosisPaperBackOperatorType = row["FormDiagnosisPaperBackOperatorType"].ToString();
					tmpFormDiagnosisPaperBack.FormDiagnosisPaperBackAnnunciationResponseTypeIDTitle = row["FormDiagnosisPaperBackAnnunciationResponseTypeIDTitle"].ToString();
					tmpFormDiagnosisPaperBack.FormDiagnosisPaperBackPaidBillPrice = row["FormDiagnosisPaperBackPaidBillPrice"].ToString();
					tmpFormDiagnosisPaperBack.FormDiagnosisPaperBackPaidBillNumber = row["FormDiagnosisPaperBackPaidBillNumber"].ToString();
					tmpFormDiagnosisPaperBack.FormDiagnosisPaperBackOperatorFullName2 = row["FormDiagnosisPaperBackOperatorFullName2"].ToString();
					tmpFormDiagnosisPaperBack.FormDiagnosisPaperBackAdjustedShare = (row["FormDiagnosisPaperBackAdjustedShare"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperBackAdjustedShare"]) : 0 ;

					listFormDiagnosisPaperBack.Add(tmpFormDiagnosisPaperBack);
				}
			}
		}

		return listFormDiagnosisPaperBack;
	}

}
}
