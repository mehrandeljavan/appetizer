using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class DowryDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(Dowry dowry)
	{
		if (!heritageDBAccess.Exists(dowry))
			dowry.HeritageID = heritageDBAccess.Insert(dowry);

		SqlParameter[] parametersDowry = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (dowry.HeritageID > 0) ? dowry.HeritageID : (object)DBNull.Value),
			new SqlParameter("@NonCashValue", dowry.NonCashValue),
			new SqlParameter("@Alimony", dowry.Alimony),
			new SqlParameter("@DeclarationID", (dowry.DeclarationID > 0) ? dowry.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@WeddingYear", (dowry.WeddingYear > 0) ? dowry.WeddingYear : (object)DBNull.Value),
			new SqlParameter("@Amount", dowry.Amount)
		};
		return SqlDBHelper.ExecuteScalar("Dowry_Insert", CommandType.StoredProcedure, parametersDowry);
	}

	public bool Update(Dowry dowry)
	{
		heritageDBAccess.Update(dowry);

		SqlParameter[] parametersDowry = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", dowry.HeritageID),
			new SqlParameter("@NonCashValue", dowry.NonCashValue),
			new SqlParameter("@Alimony", dowry.Alimony),
			new SqlParameter("@DeclarationID", dowry.DeclarationID),
			new SqlParameter("@WeddingYear", dowry.WeddingYear),
			new SqlParameter("@Amount", dowry.Amount)
		};
		return SqlDBHelper.ExecuteNonQuery("Dowry_Update", CommandType.StoredProcedure, parametersDowry);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersDowry = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("Dowry_Delete", CommandType.StoredProcedure, parametersDowry);
	}

	public Dowry GetDetails(Int64 heritageID)
	{
		Dowry dowry = new Dowry();

		SqlParameter[] parametersDowry = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Dowry_GetDetails", CommandType.StoredProcedure, parametersDowry))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				dowry.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				dowry.WeddingYearTitle = row["WeddingYearTitle"].ToString();
				dowry.ValueInCentralBank = (row["ValueInCentralBank"] != DBNull.Value) ? Convert.ToSingle(row["ValueInCentralBank"]) : 0 ;
				dowry.NonCashValue = (row["NonCashValue"] != DBNull.Value) ? Convert.ToSingle(row["NonCashValue"]) : 0 ;
				dowry.Alimony = (row["Alimony"] != DBNull.Value) ? Convert.ToSingle(row["Alimony"]) : 0 ;
				dowry.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				dowry.WeddingYear = (row["WeddingYear"] != DBNull.Value) ? Convert.ToInt32(row["WeddingYear"]) : 0 ;
				dowry.Amount = (row["Amount"] != DBNull.Value) ? Convert.ToSingle(row["Amount"]) : 0 ;

				Heritage heritage = heritageDBAccess.GetDetails(dowry.HeritageID);
				dowry.HeritageID = heritage.HeritageID;
				dowry.StageTitle = heritage.StageTitle;
				dowry.RegisterDate = heritage.RegisterDate;
				dowry.OldRegisterDate = heritage.OldRegisterDate;
				dowry.OldRegisterInformationID = heritage.OldRegisterInformationID;
				dowry.Sixth = heritage.Sixth;
				dowry.PreviousOwner = heritage.PreviousOwner;
				dowry.Comment = heritage.Comment;
				dowry.RegisterInformationID = heritage.RegisterInformationID;
				dowry.AdjustmentID = heritage.AdjustmentID;
				dowry.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				dowry.Stage = heritage.Stage;
				dowry.UserOrder = heritage.UserOrder;
				dowry.Value1 = heritage.Value1;
				dowry.Value2 = heritage.Value2;
				dowry.Value3 = heritage.Value3;
				dowry.DeadIsOwner = heritage.DeadIsOwner;
				dowry.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return dowry;
	}

	public List<Dowry> GetListAll()
	{
		List<Dowry> listDowry = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Dowry_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listDowry = new List<Dowry>();

				foreach (DataRow row in table.Rows)
				{
					Dowry dowry = new Dowry();
					dowry.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					dowry.WeddingYearTitle = row["WeddingYearTitle"].ToString();
					dowry.ValueInCentralBank = (row["ValueInCentralBank"] != DBNull.Value) ? Convert.ToSingle(row["ValueInCentralBank"]) : 0 ;
					dowry.NonCashValue = (row["NonCashValue"] != DBNull.Value) ? Convert.ToSingle(row["NonCashValue"]) : 0 ;
					dowry.Alimony = (row["Alimony"] != DBNull.Value) ? Convert.ToSingle(row["Alimony"]) : 0 ;
					dowry.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					dowry.WeddingYear = (row["WeddingYear"] != DBNull.Value) ? Convert.ToInt32(row["WeddingYear"]) : 0 ;
					dowry.Amount = (row["Amount"] != DBNull.Value) ? Convert.ToSingle(row["Amount"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(dowry.HeritageID);
					dowry.StageTitle = heritage.StageTitle;
					dowry.RegisterDate = heritage.RegisterDate;
					dowry.OldRegisterDate = heritage.OldRegisterDate;
					dowry.OldRegisterInformationID = heritage.OldRegisterInformationID;
					dowry.Sixth = heritage.Sixth;
					dowry.PreviousOwner = heritage.PreviousOwner;
					dowry.Comment = heritage.Comment;
					dowry.RegisterInformationID = heritage.RegisterInformationID;
					dowry.AdjustmentID = heritage.AdjustmentID;
					dowry.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					dowry.Stage = heritage.Stage;
					dowry.UserOrder = heritage.UserOrder;
					dowry.Value1 = heritage.Value1;
					dowry.Value2 = heritage.Value2;
					dowry.Value3 = heritage.Value3;
					dowry.DeadIsOwner = heritage.DeadIsOwner;
					dowry.IsDiagonesed = heritage.IsDiagonesed;
					listDowry.Add(dowry);
				}
			}
		}

		return listDowry;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersDowry = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Dowry_Exists", CommandType.StoredProcedure, parametersDowry)>0);
	}

	public bool Exists(Dowry dowry)
	{
		SqlParameter[] parametersDowry = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", dowry.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Dowry_Exists", CommandType.StoredProcedure, parametersDowry)>0);
	}

	public List<Dowry> SearchLike(Dowry dowry)
	{
		List<Dowry> listDowry = new List<Dowry>();


		SqlParameter[] parametersDowry = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", dowry.HeritageID),
			new SqlParameter("@WeddingYearTitle", dowry.WeddingYearTitle),
			new SqlParameter("@ValueInCentralBank", dowry.ValueInCentralBank),
			new SqlParameter("@NonCashValue", dowry.NonCashValue),
			new SqlParameter("@Alimony", dowry.Alimony),
			new SqlParameter("@DeclarationID", dowry.DeclarationID),
			new SqlParameter("@WeddingYear", dowry.WeddingYear),
			new SqlParameter("@Amount", dowry.Amount),

			new SqlParameter("@StageTitle", dowry.StageTitle),
			new SqlParameter("@RegisterDate", dowry.RegisterDate),
			new SqlParameter("@OldRegisterDate", dowry.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", dowry.OldRegisterInformationID),
			new SqlParameter("@Sixth", dowry.Sixth),
			new SqlParameter("@PreviousOwner", dowry.PreviousOwner),
			new SqlParameter("@Comment", dowry.Comment),
			new SqlParameter("@RegisterInformationID", dowry.RegisterInformationID),
			new SqlParameter("@AdjustmentID", dowry.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", dowry.CommissionAdjustmentID),
			new SqlParameter("@Stage", dowry.Stage),
			new SqlParameter("@UserOrder", dowry.UserOrder),
			new SqlParameter("@Value1", dowry.Value1),
			new SqlParameter("@Value2", dowry.Value2),
			new SqlParameter("@Value3", dowry.Value3),
			new SqlParameter("@DeadIsOwner", dowry.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", dowry.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Dowry_SearchLike", CommandType.StoredProcedure, parametersDowry))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Dowry tmpDowry = new Dowry();
					tmpDowry.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpDowry.WeddingYearTitle = row["WeddingYearTitle"].ToString();
					tmpDowry.ValueInCentralBank = (row["ValueInCentralBank"] != DBNull.Value) ? Convert.ToSingle(row["ValueInCentralBank"]) : 0 ;
					tmpDowry.NonCashValue = (row["NonCashValue"] != DBNull.Value) ? Convert.ToSingle(row["NonCashValue"]) : 0 ;
					tmpDowry.Alimony = (row["Alimony"] != DBNull.Value) ? Convert.ToSingle(row["Alimony"]) : 0 ;
					tmpDowry.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpDowry.WeddingYear = (row["WeddingYear"] != DBNull.Value) ? Convert.ToInt32(row["WeddingYear"]) : 0 ;
					tmpDowry.Amount = (row["Amount"] != DBNull.Value) ? Convert.ToSingle(row["Amount"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(tmpDowry.HeritageID);
					tmpDowry.HeritageID = heritage.HeritageID;
					tmpDowry.StageTitle = heritage.StageTitle;
					tmpDowry.RegisterDate = heritage.RegisterDate;
					tmpDowry.OldRegisterDate = heritage.OldRegisterDate;
					tmpDowry.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpDowry.Sixth = heritage.Sixth;
					tmpDowry.PreviousOwner = heritage.PreviousOwner;
					tmpDowry.Comment = heritage.Comment;
					tmpDowry.RegisterInformationID = heritage.RegisterInformationID;
					tmpDowry.AdjustmentID = heritage.AdjustmentID;
					tmpDowry.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpDowry.Stage = heritage.Stage;
					tmpDowry.UserOrder = heritage.UserOrder;
					tmpDowry.Value1 = heritage.Value1;
					tmpDowry.Value2 = heritage.Value2;
					tmpDowry.Value3 = heritage.Value3;
					tmpDowry.DeadIsOwner = heritage.DeadIsOwner;
					tmpDowry.IsDiagonesed = heritage.IsDiagonesed;

					listDowry.Add(tmpDowry);
				}
			}
		}

		return listDowry;
	}

}
}
