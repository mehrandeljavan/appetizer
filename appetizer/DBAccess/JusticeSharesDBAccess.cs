using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class JusticeSharesDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(JusticeShares justiceShares)
	{
		if (!heritageDBAccess.Exists(justiceShares))
			justiceShares.HeritageID = heritageDBAccess.Insert(justiceShares);

		SqlParameter[] parametersJusticeShares = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (justiceShares.HeritageID > 0) ? justiceShares.HeritageID : (object)DBNull.Value),
			new SqlParameter("@RegisterNumber", (justiceShares.RegisterNumber != null) ? justiceShares.RegisterNumber : (object)DBNull.Value),
			new SqlParameter("@ShareNumber", justiceShares.ShareNumber),
			new SqlParameter("@DeclarationID", (justiceShares.DeclarationID > 0) ? justiceShares.DeclarationID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("JusticeShares_Insert", CommandType.StoredProcedure, parametersJusticeShares);
	}

	public bool Update(JusticeShares justiceShares)
	{
		heritageDBAccess.Update(justiceShares);

		SqlParameter[] parametersJusticeShares = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", justiceShares.HeritageID),
			new SqlParameter("@RegisterNumber", (justiceShares.RegisterNumber != null) ? justiceShares.RegisterNumber : (object)DBNull.Value),
			new SqlParameter("@ShareNumber", justiceShares.ShareNumber),
			new SqlParameter("@DeclarationID", justiceShares.DeclarationID)
		};
		return SqlDBHelper.ExecuteNonQuery("JusticeShares_Update", CommandType.StoredProcedure, parametersJusticeShares);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersJusticeShares = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("JusticeShares_Delete", CommandType.StoredProcedure, parametersJusticeShares);
	}

	public JusticeShares GetDetails(Int64 heritageID)
	{
		JusticeShares justiceShares = new JusticeShares();

		SqlParameter[] parametersJusticeShares = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("JusticeShares_GetDetails", CommandType.StoredProcedure, parametersJusticeShares))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				justiceShares.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				justiceShares.RegisterNumber = row["RegisterNumber"].ToString();
				justiceShares.ShareNumber = (row["ShareNumber"] != DBNull.Value) ? Convert.ToInt32(row["ShareNumber"]) : 0 ;
				justiceShares.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

				Heritage heritage = heritageDBAccess.GetDetails(justiceShares.HeritageID);
				justiceShares.HeritageID = heritage.HeritageID;
				justiceShares.StageTitle = heritage.StageTitle;
				justiceShares.RegisterDate = heritage.RegisterDate;
				justiceShares.OldRegisterDate = heritage.OldRegisterDate;
				justiceShares.OldRegisterInformationID = heritage.OldRegisterInformationID;
				justiceShares.Sixth = heritage.Sixth;
				justiceShares.PreviousOwner = heritage.PreviousOwner;
				justiceShares.Comment = heritage.Comment;
				justiceShares.RegisterInformationID = heritage.RegisterInformationID;
				justiceShares.AdjustmentID = heritage.AdjustmentID;
				justiceShares.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				justiceShares.Stage = heritage.Stage;
				justiceShares.UserOrder = heritage.UserOrder;
				justiceShares.Value1 = heritage.Value1;
				justiceShares.Value2 = heritage.Value2;
				justiceShares.Value3 = heritage.Value3;
				justiceShares.DeadIsOwner = heritage.DeadIsOwner;
				justiceShares.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return justiceShares;
	}

	public List<JusticeShares> GetListAll()
	{
		List<JusticeShares> listJusticeShares = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("JusticeShares_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listJusticeShares = new List<JusticeShares>();

				foreach (DataRow row in table.Rows)
				{
					JusticeShares justiceShares = new JusticeShares();
					justiceShares.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					justiceShares.RegisterNumber = row["RegisterNumber"].ToString();
					justiceShares.ShareNumber = (row["ShareNumber"] != DBNull.Value) ? Convert.ToInt32(row["ShareNumber"]) : 0 ;
					justiceShares.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(justiceShares.HeritageID);
					justiceShares.StageTitle = heritage.StageTitle;
					justiceShares.RegisterDate = heritage.RegisterDate;
					justiceShares.OldRegisterDate = heritage.OldRegisterDate;
					justiceShares.OldRegisterInformationID = heritage.OldRegisterInformationID;
					justiceShares.Sixth = heritage.Sixth;
					justiceShares.PreviousOwner = heritage.PreviousOwner;
					justiceShares.Comment = heritage.Comment;
					justiceShares.RegisterInformationID = heritage.RegisterInformationID;
					justiceShares.AdjustmentID = heritage.AdjustmentID;
					justiceShares.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					justiceShares.Stage = heritage.Stage;
					justiceShares.UserOrder = heritage.UserOrder;
					justiceShares.Value1 = heritage.Value1;
					justiceShares.Value2 = heritage.Value2;
					justiceShares.Value3 = heritage.Value3;
					justiceShares.DeadIsOwner = heritage.DeadIsOwner;
					justiceShares.IsDiagonesed = heritage.IsDiagonesed;
					listJusticeShares.Add(justiceShares);
				}
			}
		}

		return listJusticeShares;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersJusticeShares = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("JusticeShares_Exists", CommandType.StoredProcedure, parametersJusticeShares)>0);
	}

	public bool Exists(JusticeShares justiceShares)
	{
		SqlParameter[] parametersJusticeShares = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", justiceShares.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("JusticeShares_Exists", CommandType.StoredProcedure, parametersJusticeShares)>0);
	}

	public List<JusticeShares> SearchLike(JusticeShares justiceShares)
	{
		List<JusticeShares> listJusticeShares = new List<JusticeShares>();


		SqlParameter[] parametersJusticeShares = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", justiceShares.HeritageID),
			new SqlParameter("@RegisterNumber", justiceShares.RegisterNumber),
			new SqlParameter("@ShareNumber", justiceShares.ShareNumber),
			new SqlParameter("@DeclarationID", justiceShares.DeclarationID),

			new SqlParameter("@StageTitle", justiceShares.StageTitle),
			new SqlParameter("@RegisterDate", justiceShares.RegisterDate),
			new SqlParameter("@OldRegisterDate", justiceShares.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", justiceShares.OldRegisterInformationID),
			new SqlParameter("@Sixth", justiceShares.Sixth),
			new SqlParameter("@PreviousOwner", justiceShares.PreviousOwner),
			new SqlParameter("@Comment", justiceShares.Comment),
			new SqlParameter("@RegisterInformationID", justiceShares.RegisterInformationID),
			new SqlParameter("@AdjustmentID", justiceShares.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", justiceShares.CommissionAdjustmentID),
			new SqlParameter("@Stage", justiceShares.Stage),
			new SqlParameter("@UserOrder", justiceShares.UserOrder),
			new SqlParameter("@Value1", justiceShares.Value1),
			new SqlParameter("@Value2", justiceShares.Value2),
			new SqlParameter("@Value3", justiceShares.Value3),
			new SqlParameter("@DeadIsOwner", justiceShares.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", justiceShares.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("JusticeShares_SearchLike", CommandType.StoredProcedure, parametersJusticeShares))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					JusticeShares tmpJusticeShares = new JusticeShares();
					tmpJusticeShares.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpJusticeShares.RegisterNumber = row["RegisterNumber"].ToString();
					tmpJusticeShares.ShareNumber = (row["ShareNumber"] != DBNull.Value) ? Convert.ToInt32(row["ShareNumber"]) : 0 ;
					tmpJusticeShares.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(tmpJusticeShares.HeritageID);
					tmpJusticeShares.HeritageID = heritage.HeritageID;
					tmpJusticeShares.StageTitle = heritage.StageTitle;
					tmpJusticeShares.RegisterDate = heritage.RegisterDate;
					tmpJusticeShares.OldRegisterDate = heritage.OldRegisterDate;
					tmpJusticeShares.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpJusticeShares.Sixth = heritage.Sixth;
					tmpJusticeShares.PreviousOwner = heritage.PreviousOwner;
					tmpJusticeShares.Comment = heritage.Comment;
					tmpJusticeShares.RegisterInformationID = heritage.RegisterInformationID;
					tmpJusticeShares.AdjustmentID = heritage.AdjustmentID;
					tmpJusticeShares.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpJusticeShares.Stage = heritage.Stage;
					tmpJusticeShares.UserOrder = heritage.UserOrder;
					tmpJusticeShares.Value1 = heritage.Value1;
					tmpJusticeShares.Value2 = heritage.Value2;
					tmpJusticeShares.Value3 = heritage.Value3;
					tmpJusticeShares.DeadIsOwner = heritage.DeadIsOwner;
					tmpJusticeShares.IsDiagonesed = heritage.IsDiagonesed;

					listJusticeShares.Add(tmpJusticeShares);
				}
			}
		}

		return listJusticeShares;
	}

}
}
