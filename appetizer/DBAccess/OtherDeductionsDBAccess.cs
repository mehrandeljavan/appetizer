using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class OtherDeductionsDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(OtherDeductions otherDeductions)
	{
		if (!heritageDBAccess.Exists(otherDeductions))
			otherDeductions.HeritageID = heritageDBAccess.Insert(otherDeductions);

		SqlParameter[] parametersOtherDeductions = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (otherDeductions.HeritageID > 0) ? otherDeductions.HeritageID : (object)DBNull.Value),
			new SqlParameter("@Title", otherDeductions.Title),
			new SqlParameter("@DeclarationID", (otherDeductions.DeclarationID > 0) ? otherDeductions.DeclarationID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("OtherDeductions_Insert", CommandType.StoredProcedure, parametersOtherDeductions);
	}

	public bool Update(OtherDeductions otherDeductions)
	{
		heritageDBAccess.Update(otherDeductions);

		SqlParameter[] parametersOtherDeductions = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", otherDeductions.HeritageID),
			new SqlParameter("@Title", otherDeductions.Title),
			new SqlParameter("@DeclarationID", otherDeductions.DeclarationID)
		};
		return SqlDBHelper.ExecuteNonQuery("OtherDeductions_Update", CommandType.StoredProcedure, parametersOtherDeductions);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersOtherDeductions = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("OtherDeductions_Delete", CommandType.StoredProcedure, parametersOtherDeductions);
	}

	public OtherDeductions GetDetails(Int64 heritageID)
	{
		OtherDeductions otherDeductions = new OtherDeductions();

		SqlParameter[] parametersOtherDeductions = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("OtherDeductions_GetDetails", CommandType.StoredProcedure, parametersOtherDeductions))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				otherDeductions.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				otherDeductions.Title = row["Title"].ToString();
				otherDeductions.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

				Heritage heritage = heritageDBAccess.GetDetails(otherDeductions.HeritageID);
				otherDeductions.HeritageID = heritage.HeritageID;
				otherDeductions.StageTitle = heritage.StageTitle;
				otherDeductions.RegisterDate = heritage.RegisterDate;
				otherDeductions.OldRegisterDate = heritage.OldRegisterDate;
				otherDeductions.OldRegisterInformationID = heritage.OldRegisterInformationID;
				otherDeductions.Sixth = heritage.Sixth;
				otherDeductions.PreviousOwner = heritage.PreviousOwner;
				otherDeductions.Comment = heritage.Comment;
				otherDeductions.RegisterInformationID = heritage.RegisterInformationID;
				otherDeductions.AdjustmentID = heritage.AdjustmentID;
				otherDeductions.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				otherDeductions.Stage = heritage.Stage;
				otherDeductions.UserOrder = heritage.UserOrder;
				otherDeductions.Value1 = heritage.Value1;
				otherDeductions.Value2 = heritage.Value2;
				otherDeductions.Value3 = heritage.Value3;
				otherDeductions.DeadIsOwner = heritage.DeadIsOwner;
				otherDeductions.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return otherDeductions;
	}

	public List<OtherDeductions> GetListAll()
	{
		List<OtherDeductions> listOtherDeductions = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("OtherDeductions_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listOtherDeductions = new List<OtherDeductions>();

				foreach (DataRow row in table.Rows)
				{
					OtherDeductions otherDeductions = new OtherDeductions();
					otherDeductions.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					otherDeductions.Title = row["Title"].ToString();
					otherDeductions.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(otherDeductions.HeritageID);
					otherDeductions.StageTitle = heritage.StageTitle;
					otherDeductions.RegisterDate = heritage.RegisterDate;
					otherDeductions.OldRegisterDate = heritage.OldRegisterDate;
					otherDeductions.OldRegisterInformationID = heritage.OldRegisterInformationID;
					otherDeductions.Sixth = heritage.Sixth;
					otherDeductions.PreviousOwner = heritage.PreviousOwner;
					otherDeductions.Comment = heritage.Comment;
					otherDeductions.RegisterInformationID = heritage.RegisterInformationID;
					otherDeductions.AdjustmentID = heritage.AdjustmentID;
					otherDeductions.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					otherDeductions.Stage = heritage.Stage;
					otherDeductions.UserOrder = heritage.UserOrder;
					otherDeductions.Value1 = heritage.Value1;
					otherDeductions.Value2 = heritage.Value2;
					otherDeductions.Value3 = heritage.Value3;
					otherDeductions.DeadIsOwner = heritage.DeadIsOwner;
					otherDeductions.IsDiagonesed = heritage.IsDiagonesed;
					listOtherDeductions.Add(otherDeductions);
				}
			}
		}

		return listOtherDeductions;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersOtherDeductions = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("OtherDeductions_Exists", CommandType.StoredProcedure, parametersOtherDeductions)>0);
	}

	public bool Exists(OtherDeductions otherDeductions)
	{
		SqlParameter[] parametersOtherDeductions = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", otherDeductions.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("OtherDeductions_Exists", CommandType.StoredProcedure, parametersOtherDeductions)>0);
	}

	public List<OtherDeductions> SearchLike(OtherDeductions otherDeductions)
	{
		List<OtherDeductions> listOtherDeductions = new List<OtherDeductions>();


		SqlParameter[] parametersOtherDeductions = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", otherDeductions.HeritageID),
			new SqlParameter("@Title", otherDeductions.Title),
			new SqlParameter("@DeclarationID", otherDeductions.DeclarationID),

			new SqlParameter("@StageTitle", otherDeductions.StageTitle),
			new SqlParameter("@RegisterDate", otherDeductions.RegisterDate),
			new SqlParameter("@OldRegisterDate", otherDeductions.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", otherDeductions.OldRegisterInformationID),
			new SqlParameter("@Sixth", otherDeductions.Sixth),
			new SqlParameter("@PreviousOwner", otherDeductions.PreviousOwner),
			new SqlParameter("@Comment", otherDeductions.Comment),
			new SqlParameter("@RegisterInformationID", otherDeductions.RegisterInformationID),
			new SqlParameter("@AdjustmentID", otherDeductions.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", otherDeductions.CommissionAdjustmentID),
			new SqlParameter("@Stage", otherDeductions.Stage),
			new SqlParameter("@UserOrder", otherDeductions.UserOrder),
			new SqlParameter("@Value1", otherDeductions.Value1),
			new SqlParameter("@Value2", otherDeductions.Value2),
			new SqlParameter("@Value3", otherDeductions.Value3),
			new SqlParameter("@DeadIsOwner", otherDeductions.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", otherDeductions.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("OtherDeductions_SearchLike", CommandType.StoredProcedure, parametersOtherDeductions))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					OtherDeductions tmpOtherDeductions = new OtherDeductions();
					tmpOtherDeductions.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpOtherDeductions.Title = row["Title"].ToString();
					tmpOtherDeductions.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(tmpOtherDeductions.HeritageID);
					tmpOtherDeductions.HeritageID = heritage.HeritageID;
					tmpOtherDeductions.StageTitle = heritage.StageTitle;
					tmpOtherDeductions.RegisterDate = heritage.RegisterDate;
					tmpOtherDeductions.OldRegisterDate = heritage.OldRegisterDate;
					tmpOtherDeductions.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpOtherDeductions.Sixth = heritage.Sixth;
					tmpOtherDeductions.PreviousOwner = heritage.PreviousOwner;
					tmpOtherDeductions.Comment = heritage.Comment;
					tmpOtherDeductions.RegisterInformationID = heritage.RegisterInformationID;
					tmpOtherDeductions.AdjustmentID = heritage.AdjustmentID;
					tmpOtherDeductions.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpOtherDeductions.Stage = heritage.Stage;
					tmpOtherDeductions.UserOrder = heritage.UserOrder;
					tmpOtherDeductions.Value1 = heritage.Value1;
					tmpOtherDeductions.Value2 = heritage.Value2;
					tmpOtherDeductions.Value3 = heritage.Value3;
					tmpOtherDeductions.DeadIsOwner = heritage.DeadIsOwner;
					tmpOtherDeductions.IsDiagonesed = heritage.IsDiagonesed;

					listOtherDeductions.Add(tmpOtherDeductions);
				}
			}
		}

		return listOtherDeductions;
	}

}
}
