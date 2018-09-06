using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class BourseStockDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(BourseStock bourseStock)
	{
		if (!heritageDBAccess.Exists(bourseStock))
			bourseStock.HeritageID = heritageDBAccess.Insert(bourseStock);

		SqlParameter[] parametersBourseStock = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (bourseStock.HeritageID > 0) ? bourseStock.HeritageID : (object)DBNull.Value),
			new SqlParameter("@Hall", bourseStock.Hall),
			new SqlParameter("@Seller", bourseStock.Seller),
			new SqlParameter("@SheetNumber", bourseStock.SheetNumber),
			new SqlParameter("@StockNumber", bourseStock.StockNumber),
			new SqlParameter("@StockValue", bourseStock.StockValue),
			new SqlParameter("@DeclarationID", (bourseStock.DeclarationID > 0) ? bourseStock.DeclarationID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("BourseStock_Insert", CommandType.StoredProcedure, parametersBourseStock);
	}

	public bool Update(BourseStock bourseStock)
	{
		heritageDBAccess.Update(bourseStock);

		SqlParameter[] parametersBourseStock = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", bourseStock.HeritageID),
			new SqlParameter("@Hall", bourseStock.Hall),
			new SqlParameter("@Seller", bourseStock.Seller),
			new SqlParameter("@SheetNumber", bourseStock.SheetNumber),
			new SqlParameter("@StockNumber", bourseStock.StockNumber),
			new SqlParameter("@StockValue", bourseStock.StockValue),
			new SqlParameter("@DeclarationID", bourseStock.DeclarationID)
		};
		return SqlDBHelper.ExecuteNonQuery("BourseStock_Update", CommandType.StoredProcedure, parametersBourseStock);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersBourseStock = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("BourseStock_Delete", CommandType.StoredProcedure, parametersBourseStock);
	}

	public BourseStock GetDetails(Int64 heritageID)
	{
		BourseStock bourseStock = new BourseStock();

		SqlParameter[] parametersBourseStock = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BourseStock_GetDetails", CommandType.StoredProcedure, parametersBourseStock))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				bourseStock.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				bourseStock.Hall = row["Hall"].ToString();
				bourseStock.Seller = row["Seller"].ToString();
				bourseStock.SheetNumber = row["SheetNumber"].ToString();
				bourseStock.StockNumber = row["StockNumber"].ToString();
				bourseStock.StockValue = (row["StockValue"] != DBNull.Value) ? Convert.ToSingle(row["StockValue"]) : 0 ;
				bourseStock.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

				Heritage heritage = heritageDBAccess.GetDetails(bourseStock.HeritageID);
				bourseStock.HeritageID = heritage.HeritageID;
				bourseStock.StageTitle = heritage.StageTitle;
				bourseStock.RegisterDate = heritage.RegisterDate;
				bourseStock.OldRegisterDate = heritage.OldRegisterDate;
				bourseStock.OldRegisterInformationID = heritage.OldRegisterInformationID;
				bourseStock.Sixth = heritage.Sixth;
				bourseStock.PreviousOwner = heritage.PreviousOwner;
				bourseStock.Comment = heritage.Comment;
				bourseStock.RegisterInformationID = heritage.RegisterInformationID;
				bourseStock.AdjustmentID = heritage.AdjustmentID;
				bourseStock.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				bourseStock.Stage = heritage.Stage;
				bourseStock.UserOrder = heritage.UserOrder;
				bourseStock.Value1 = heritage.Value1;
				bourseStock.Value2 = heritage.Value2;
				bourseStock.Value3 = heritage.Value3;
				bourseStock.DeadIsOwner = heritage.DeadIsOwner;
				bourseStock.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return bourseStock;
	}

	public List<BourseStock> GetListAll()
	{
		List<BourseStock> listBourseStock = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("BourseStock_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listBourseStock = new List<BourseStock>();

				foreach (DataRow row in table.Rows)
				{
					BourseStock bourseStock = new BourseStock();
					bourseStock.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					bourseStock.Hall = row["Hall"].ToString();
					bourseStock.Seller = row["Seller"].ToString();
					bourseStock.SheetNumber = row["SheetNumber"].ToString();
					bourseStock.StockNumber = row["StockNumber"].ToString();
					bourseStock.StockValue = (row["StockValue"] != DBNull.Value) ? Convert.ToSingle(row["StockValue"]) : 0 ;
					bourseStock.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(bourseStock.HeritageID);
					bourseStock.StageTitle = heritage.StageTitle;
					bourseStock.RegisterDate = heritage.RegisterDate;
					bourseStock.OldRegisterDate = heritage.OldRegisterDate;
					bourseStock.OldRegisterInformationID = heritage.OldRegisterInformationID;
					bourseStock.Sixth = heritage.Sixth;
					bourseStock.PreviousOwner = heritage.PreviousOwner;
					bourseStock.Comment = heritage.Comment;
					bourseStock.RegisterInformationID = heritage.RegisterInformationID;
					bourseStock.AdjustmentID = heritage.AdjustmentID;
					bourseStock.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					bourseStock.Stage = heritage.Stage;
					bourseStock.UserOrder = heritage.UserOrder;
					bourseStock.Value1 = heritage.Value1;
					bourseStock.Value2 = heritage.Value2;
					bourseStock.Value3 = heritage.Value3;
					bourseStock.DeadIsOwner = heritage.DeadIsOwner;
					bourseStock.IsDiagonesed = heritage.IsDiagonesed;
					listBourseStock.Add(bourseStock);
				}
			}
		}

		return listBourseStock;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersBourseStock = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("BourseStock_Exists", CommandType.StoredProcedure, parametersBourseStock)>0);
	}

	public bool Exists(BourseStock bourseStock)
	{
		SqlParameter[] parametersBourseStock = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", bourseStock.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("BourseStock_Exists", CommandType.StoredProcedure, parametersBourseStock)>0);
	}

	public List<BourseStock> SearchLike(BourseStock bourseStock)
	{
		List<BourseStock> listBourseStock = new List<BourseStock>();


		SqlParameter[] parametersBourseStock = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", bourseStock.HeritageID),
			new SqlParameter("@Hall", bourseStock.Hall),
			new SqlParameter("@Seller", bourseStock.Seller),
			new SqlParameter("@SheetNumber", bourseStock.SheetNumber),
			new SqlParameter("@StockNumber", bourseStock.StockNumber),
			new SqlParameter("@StockValue", bourseStock.StockValue),
			new SqlParameter("@DeclarationID", bourseStock.DeclarationID),

			new SqlParameter("@StageTitle", bourseStock.StageTitle),
			new SqlParameter("@RegisterDate", bourseStock.RegisterDate),
			new SqlParameter("@OldRegisterDate", bourseStock.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", bourseStock.OldRegisterInformationID),
			new SqlParameter("@Sixth", bourseStock.Sixth),
			new SqlParameter("@PreviousOwner", bourseStock.PreviousOwner),
			new SqlParameter("@Comment", bourseStock.Comment),
			new SqlParameter("@RegisterInformationID", bourseStock.RegisterInformationID),
			new SqlParameter("@AdjustmentID", bourseStock.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", bourseStock.CommissionAdjustmentID),
			new SqlParameter("@Stage", bourseStock.Stage),
			new SqlParameter("@UserOrder", bourseStock.UserOrder),
			new SqlParameter("@Value1", bourseStock.Value1),
			new SqlParameter("@Value2", bourseStock.Value2),
			new SqlParameter("@Value3", bourseStock.Value3),
			new SqlParameter("@DeadIsOwner", bourseStock.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", bourseStock.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BourseStock_SearchLike", CommandType.StoredProcedure, parametersBourseStock))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					BourseStock tmpBourseStock = new BourseStock();
					tmpBourseStock.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpBourseStock.Hall = row["Hall"].ToString();
					tmpBourseStock.Seller = row["Seller"].ToString();
					tmpBourseStock.SheetNumber = row["SheetNumber"].ToString();
					tmpBourseStock.StockNumber = row["StockNumber"].ToString();
					tmpBourseStock.StockValue = (row["StockValue"] != DBNull.Value) ? Convert.ToSingle(row["StockValue"]) : 0 ;
					tmpBourseStock.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(tmpBourseStock.HeritageID);
					tmpBourseStock.HeritageID = heritage.HeritageID;
					tmpBourseStock.StageTitle = heritage.StageTitle;
					tmpBourseStock.RegisterDate = heritage.RegisterDate;
					tmpBourseStock.OldRegisterDate = heritage.OldRegisterDate;
					tmpBourseStock.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpBourseStock.Sixth = heritage.Sixth;
					tmpBourseStock.PreviousOwner = heritage.PreviousOwner;
					tmpBourseStock.Comment = heritage.Comment;
					tmpBourseStock.RegisterInformationID = heritage.RegisterInformationID;
					tmpBourseStock.AdjustmentID = heritage.AdjustmentID;
					tmpBourseStock.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpBourseStock.Stage = heritage.Stage;
					tmpBourseStock.UserOrder = heritage.UserOrder;
					tmpBourseStock.Value1 = heritage.Value1;
					tmpBourseStock.Value2 = heritage.Value2;
					tmpBourseStock.Value3 = heritage.Value3;
					tmpBourseStock.DeadIsOwner = heritage.DeadIsOwner;
					tmpBourseStock.IsDiagonesed = heritage.IsDiagonesed;

					listBourseStock.Add(tmpBourseStock);
				}
			}
		}

		return listBourseStock;
	}

}
}
