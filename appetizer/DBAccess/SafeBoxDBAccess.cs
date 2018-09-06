using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class SafeBoxDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(SafeBox safeBox)
	{
		if (!heritageDBAccess.Exists(safeBox))
			safeBox.HeritageID = heritageDBAccess.Insert(safeBox);

		SqlParameter[] parametersSafeBox = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (safeBox.HeritageID > 0) ? safeBox.HeritageID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (safeBox.DeclarationID > 0) ? safeBox.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@BoxNumber", (safeBox.BoxNumber != null) ? safeBox.BoxNumber : (object)DBNull.Value),
			new SqlParameter("@Place", (safeBox.Place != null) ? safeBox.Place : (object)DBNull.Value),
			new SqlParameter("@Agent", (safeBox.Agent != null) ? safeBox.Agent : (object)DBNull.Value),
			new SqlParameter("@Inquiry", (safeBox.Inquiry != null) ? safeBox.Inquiry : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("SafeBox_Insert", CommandType.StoredProcedure, parametersSafeBox);
	}

	public bool Update(SafeBox safeBox)
	{
		heritageDBAccess.Update(safeBox);

		SqlParameter[] parametersSafeBox = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", safeBox.HeritageID),
			new SqlParameter("@DeclarationID", safeBox.DeclarationID),
			new SqlParameter("@BoxNumber", (safeBox.BoxNumber != null) ? safeBox.BoxNumber : (object)DBNull.Value),
			new SqlParameter("@Place", (safeBox.Place != null) ? safeBox.Place : (object)DBNull.Value),
			new SqlParameter("@Agent", (safeBox.Agent != null) ? safeBox.Agent : (object)DBNull.Value),
			new SqlParameter("@Inquiry", (safeBox.Inquiry != null) ? safeBox.Inquiry : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("SafeBox_Update", CommandType.StoredProcedure, parametersSafeBox);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersSafeBox = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("SafeBox_Delete", CommandType.StoredProcedure, parametersSafeBox);
	}

	public SafeBox GetDetails(Int64 heritageID)
	{
		SafeBox safeBox = new SafeBox();

		SqlParameter[] parametersSafeBox = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("SafeBox_GetDetails", CommandType.StoredProcedure, parametersSafeBox))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				safeBox.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				safeBox.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				safeBox.BoxNumber = row["BoxNumber"].ToString();
				safeBox.Place = row["Place"].ToString();
				safeBox.Agent = row["Agent"].ToString();
				safeBox.Inquiry = row["Inquiry"].ToString();

				Heritage heritage = heritageDBAccess.GetDetails(safeBox.HeritageID);
				safeBox.HeritageID = heritage.HeritageID;
				safeBox.StageTitle = heritage.StageTitle;
				safeBox.RegisterDate = heritage.RegisterDate;
				safeBox.OldRegisterDate = heritage.OldRegisterDate;
				safeBox.OldRegisterInformationID = heritage.OldRegisterInformationID;
				safeBox.Sixth = heritage.Sixth;
				safeBox.PreviousOwner = heritage.PreviousOwner;
				safeBox.Comment = heritage.Comment;
				safeBox.RegisterInformationID = heritage.RegisterInformationID;
				safeBox.AdjustmentID = heritage.AdjustmentID;
				safeBox.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				safeBox.Stage = heritage.Stage;
				safeBox.UserOrder = heritage.UserOrder;
				safeBox.Value1 = heritage.Value1;
				safeBox.Value2 = heritage.Value2;
				safeBox.Value3 = heritage.Value3;
				safeBox.DeadIsOwner = heritage.DeadIsOwner;
				safeBox.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return safeBox;
	}

	public List<SafeBox> GetListAll()
	{
		List<SafeBox> listSafeBox = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("SafeBox_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listSafeBox = new List<SafeBox>();

				foreach (DataRow row in table.Rows)
				{
					SafeBox safeBox = new SafeBox();
					safeBox.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					safeBox.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					safeBox.BoxNumber = row["BoxNumber"].ToString();
					safeBox.Place = row["Place"].ToString();
					safeBox.Agent = row["Agent"].ToString();
					safeBox.Inquiry = row["Inquiry"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(safeBox.HeritageID);
					safeBox.StageTitle = heritage.StageTitle;
					safeBox.RegisterDate = heritage.RegisterDate;
					safeBox.OldRegisterDate = heritage.OldRegisterDate;
					safeBox.OldRegisterInformationID = heritage.OldRegisterInformationID;
					safeBox.Sixth = heritage.Sixth;
					safeBox.PreviousOwner = heritage.PreviousOwner;
					safeBox.Comment = heritage.Comment;
					safeBox.RegisterInformationID = heritage.RegisterInformationID;
					safeBox.AdjustmentID = heritage.AdjustmentID;
					safeBox.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					safeBox.Stage = heritage.Stage;
					safeBox.UserOrder = heritage.UserOrder;
					safeBox.Value1 = heritage.Value1;
					safeBox.Value2 = heritage.Value2;
					safeBox.Value3 = heritage.Value3;
					safeBox.DeadIsOwner = heritage.DeadIsOwner;
					safeBox.IsDiagonesed = heritage.IsDiagonesed;
					listSafeBox.Add(safeBox);
				}
			}
		}

		return listSafeBox;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersSafeBox = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("SafeBox_Exists", CommandType.StoredProcedure, parametersSafeBox)>0);
	}

	public bool Exists(SafeBox safeBox)
	{
		SqlParameter[] parametersSafeBox = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", safeBox.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("SafeBox_Exists", CommandType.StoredProcedure, parametersSafeBox)>0);
	}

	public List<SafeBox> SearchLike(SafeBox safeBox)
	{
		List<SafeBox> listSafeBox = new List<SafeBox>();


		SqlParameter[] parametersSafeBox = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", safeBox.HeritageID),
			new SqlParameter("@DeclarationID", safeBox.DeclarationID),
			new SqlParameter("@BoxNumber", safeBox.BoxNumber),
			new SqlParameter("@Place", safeBox.Place),
			new SqlParameter("@Agent", safeBox.Agent),
			new SqlParameter("@Inquiry", safeBox.Inquiry),

			new SqlParameter("@StageTitle", safeBox.StageTitle),
			new SqlParameter("@RegisterDate", safeBox.RegisterDate),
			new SqlParameter("@OldRegisterDate", safeBox.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", safeBox.OldRegisterInformationID),
			new SqlParameter("@Sixth", safeBox.Sixth),
			new SqlParameter("@PreviousOwner", safeBox.PreviousOwner),
			new SqlParameter("@Comment", safeBox.Comment),
			new SqlParameter("@RegisterInformationID", safeBox.RegisterInformationID),
			new SqlParameter("@AdjustmentID", safeBox.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", safeBox.CommissionAdjustmentID),
			new SqlParameter("@Stage", safeBox.Stage),
			new SqlParameter("@UserOrder", safeBox.UserOrder),
			new SqlParameter("@Value1", safeBox.Value1),
			new SqlParameter("@Value2", safeBox.Value2),
			new SqlParameter("@Value3", safeBox.Value3),
			new SqlParameter("@DeadIsOwner", safeBox.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", safeBox.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("SafeBox_SearchLike", CommandType.StoredProcedure, parametersSafeBox))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					SafeBox tmpSafeBox = new SafeBox();
					tmpSafeBox.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpSafeBox.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpSafeBox.BoxNumber = row["BoxNumber"].ToString();
					tmpSafeBox.Place = row["Place"].ToString();
					tmpSafeBox.Agent = row["Agent"].ToString();
					tmpSafeBox.Inquiry = row["Inquiry"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(tmpSafeBox.HeritageID);
					tmpSafeBox.HeritageID = heritage.HeritageID;
					tmpSafeBox.StageTitle = heritage.StageTitle;
					tmpSafeBox.RegisterDate = heritage.RegisterDate;
					tmpSafeBox.OldRegisterDate = heritage.OldRegisterDate;
					tmpSafeBox.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpSafeBox.Sixth = heritage.Sixth;
					tmpSafeBox.PreviousOwner = heritage.PreviousOwner;
					tmpSafeBox.Comment = heritage.Comment;
					tmpSafeBox.RegisterInformationID = heritage.RegisterInformationID;
					tmpSafeBox.AdjustmentID = heritage.AdjustmentID;
					tmpSafeBox.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpSafeBox.Stage = heritage.Stage;
					tmpSafeBox.UserOrder = heritage.UserOrder;
					tmpSafeBox.Value1 = heritage.Value1;
					tmpSafeBox.Value2 = heritage.Value2;
					tmpSafeBox.Value3 = heritage.Value3;
					tmpSafeBox.DeadIsOwner = heritage.DeadIsOwner;
					tmpSafeBox.IsDiagonesed = heritage.IsDiagonesed;

					listSafeBox.Add(tmpSafeBox);
				}
			}
		}

		return listSafeBox;
	}

}
}
