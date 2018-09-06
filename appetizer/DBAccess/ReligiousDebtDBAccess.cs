using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class ReligiousDebtDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(ReligiousDebt religiousDebt)
	{
		if (!heritageDBAccess.Exists(religiousDebt))
			religiousDebt.HeritageID = heritageDBAccess.Insert(religiousDebt);

		SqlParameter[] parametersReligiousDebt = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (religiousDebt.HeritageID > 0) ? religiousDebt.HeritageID : (object)DBNull.Value),
			new SqlParameter("@FinancialObligationTitle", (religiousDebt.FinancialObligationTitle != null) ? religiousDebt.FinancialObligationTitle : (object)DBNull.Value),
			new SqlParameter("@ReligiousObligationTitle", (religiousDebt.ReligiousObligationTitle != null) ? religiousDebt.ReligiousObligationTitle : (object)DBNull.Value),
			new SqlParameter("@FinancialObligationAmount", (religiousDebt.FinancialObligationAmount != null) ? religiousDebt.FinancialObligationAmount : (object)DBNull.Value),
			new SqlParameter("@ReligiousObligationAmount", (religiousDebt.ReligiousObligationAmount != null) ? religiousDebt.ReligiousObligationAmount : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (religiousDebt.DeclarationID > 0) ? religiousDebt.DeclarationID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("ReligiousDebt_Insert", CommandType.StoredProcedure, parametersReligiousDebt);
	}

	public bool Update(ReligiousDebt religiousDebt)
	{
		heritageDBAccess.Update(religiousDebt);

		SqlParameter[] parametersReligiousDebt = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", religiousDebt.HeritageID),
			new SqlParameter("@FinancialObligationTitle", (religiousDebt.FinancialObligationTitle != null) ? religiousDebt.FinancialObligationTitle : (object)DBNull.Value),
			new SqlParameter("@ReligiousObligationTitle", (religiousDebt.ReligiousObligationTitle != null) ? religiousDebt.ReligiousObligationTitle : (object)DBNull.Value),
			new SqlParameter("@FinancialObligationAmount", (religiousDebt.FinancialObligationAmount != null) ? religiousDebt.FinancialObligationAmount : (object)DBNull.Value),
			new SqlParameter("@ReligiousObligationAmount", (religiousDebt.ReligiousObligationAmount != null) ? religiousDebt.ReligiousObligationAmount : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", religiousDebt.DeclarationID)
		};
		return SqlDBHelper.ExecuteNonQuery("ReligiousDebt_Update", CommandType.StoredProcedure, parametersReligiousDebt);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersReligiousDebt = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("ReligiousDebt_Delete", CommandType.StoredProcedure, parametersReligiousDebt);
	}

	public ReligiousDebt GetDetails(Int64 heritageID)
	{
		ReligiousDebt religiousDebt = new ReligiousDebt();

		SqlParameter[] parametersReligiousDebt = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ReligiousDebt_GetDetails", CommandType.StoredProcedure, parametersReligiousDebt))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				religiousDebt.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				religiousDebt.FinancialObligationTitle = row["FinancialObligationTitle"].ToString();
				religiousDebt.ReligiousObligationTitle = row["ReligiousObligationTitle"].ToString();
				religiousDebt.FinancialObligationAmount = (row["FinancialObligationAmount"] != DBNull.Value) ? Convert.ToSingle(row["FinancialObligationAmount"]) : 0 ;
				religiousDebt.ReligiousObligationAmount = (row["ReligiousObligationAmount"] != DBNull.Value) ? Convert.ToSingle(row["ReligiousObligationAmount"]) : 0 ;
				religiousDebt.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

				Heritage heritage = heritageDBAccess.GetDetails(religiousDebt.HeritageID);
				religiousDebt.HeritageID = heritage.HeritageID;
				religiousDebt.StageTitle = heritage.StageTitle;
				religiousDebt.RegisterDate = heritage.RegisterDate;
				religiousDebt.OldRegisterDate = heritage.OldRegisterDate;
				religiousDebt.OldRegisterInformationID = heritage.OldRegisterInformationID;
				religiousDebt.Sixth = heritage.Sixth;
				religiousDebt.PreviousOwner = heritage.PreviousOwner;
				religiousDebt.Comment = heritage.Comment;
				religiousDebt.RegisterInformationID = heritage.RegisterInformationID;
				religiousDebt.AdjustmentID = heritage.AdjustmentID;
				religiousDebt.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				religiousDebt.Stage = heritage.Stage;
				religiousDebt.UserOrder = heritage.UserOrder;
				religiousDebt.Value1 = heritage.Value1;
				religiousDebt.Value2 = heritage.Value2;
				religiousDebt.Value3 = heritage.Value3;
				religiousDebt.DeadIsOwner = heritage.DeadIsOwner;
				religiousDebt.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return religiousDebt;
	}

	public List<ReligiousDebt> GetListAll()
	{
		List<ReligiousDebt> listReligiousDebt = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("ReligiousDebt_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listReligiousDebt = new List<ReligiousDebt>();

				foreach (DataRow row in table.Rows)
				{
					ReligiousDebt religiousDebt = new ReligiousDebt();
					religiousDebt.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					religiousDebt.FinancialObligationTitle = row["FinancialObligationTitle"].ToString();
					religiousDebt.ReligiousObligationTitle = row["ReligiousObligationTitle"].ToString();
					religiousDebt.FinancialObligationAmount = (row["FinancialObligationAmount"] != DBNull.Value) ? Convert.ToSingle(row["FinancialObligationAmount"]) : 0 ;
					religiousDebt.ReligiousObligationAmount = (row["ReligiousObligationAmount"] != DBNull.Value) ? Convert.ToSingle(row["ReligiousObligationAmount"]) : 0 ;
					religiousDebt.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(religiousDebt.HeritageID);
					religiousDebt.StageTitle = heritage.StageTitle;
					religiousDebt.RegisterDate = heritage.RegisterDate;
					religiousDebt.OldRegisterDate = heritage.OldRegisterDate;
					religiousDebt.OldRegisterInformationID = heritage.OldRegisterInformationID;
					religiousDebt.Sixth = heritage.Sixth;
					religiousDebt.PreviousOwner = heritage.PreviousOwner;
					religiousDebt.Comment = heritage.Comment;
					religiousDebt.RegisterInformationID = heritage.RegisterInformationID;
					religiousDebt.AdjustmentID = heritage.AdjustmentID;
					religiousDebt.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					religiousDebt.Stage = heritage.Stage;
					religiousDebt.UserOrder = heritage.UserOrder;
					religiousDebt.Value1 = heritage.Value1;
					religiousDebt.Value2 = heritage.Value2;
					religiousDebt.Value3 = heritage.Value3;
					religiousDebt.DeadIsOwner = heritage.DeadIsOwner;
					religiousDebt.IsDiagonesed = heritage.IsDiagonesed;
					listReligiousDebt.Add(religiousDebt);
				}
			}
		}

		return listReligiousDebt;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersReligiousDebt = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("ReligiousDebt_Exists", CommandType.StoredProcedure, parametersReligiousDebt)>0);
	}

	public bool Exists(ReligiousDebt religiousDebt)
	{
		SqlParameter[] parametersReligiousDebt = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", religiousDebt.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("ReligiousDebt_Exists", CommandType.StoredProcedure, parametersReligiousDebt)>0);
	}

	public List<ReligiousDebt> SearchLike(ReligiousDebt religiousDebt)
	{
		List<ReligiousDebt> listReligiousDebt = new List<ReligiousDebt>();


		SqlParameter[] parametersReligiousDebt = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", religiousDebt.HeritageID),
			new SqlParameter("@FinancialObligationTitle", religiousDebt.FinancialObligationTitle),
			new SqlParameter("@ReligiousObligationTitle", religiousDebt.ReligiousObligationTitle),
			new SqlParameter("@FinancialObligationAmount", religiousDebt.FinancialObligationAmount),
			new SqlParameter("@ReligiousObligationAmount", religiousDebt.ReligiousObligationAmount),
			new SqlParameter("@DeclarationID", religiousDebt.DeclarationID),

			new SqlParameter("@StageTitle", religiousDebt.StageTitle),
			new SqlParameter("@RegisterDate", religiousDebt.RegisterDate),
			new SqlParameter("@OldRegisterDate", religiousDebt.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", religiousDebt.OldRegisterInformationID),
			new SqlParameter("@Sixth", religiousDebt.Sixth),
			new SqlParameter("@PreviousOwner", religiousDebt.PreviousOwner),
			new SqlParameter("@Comment", religiousDebt.Comment),
			new SqlParameter("@RegisterInformationID", religiousDebt.RegisterInformationID),
			new SqlParameter("@AdjustmentID", religiousDebt.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", religiousDebt.CommissionAdjustmentID),
			new SqlParameter("@Stage", religiousDebt.Stage),
			new SqlParameter("@UserOrder", religiousDebt.UserOrder),
			new SqlParameter("@Value1", religiousDebt.Value1),
			new SqlParameter("@Value2", religiousDebt.Value2),
			new SqlParameter("@Value3", religiousDebt.Value3),
			new SqlParameter("@DeadIsOwner", religiousDebt.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", religiousDebt.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ReligiousDebt_SearchLike", CommandType.StoredProcedure, parametersReligiousDebt))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					ReligiousDebt tmpReligiousDebt = new ReligiousDebt();
					tmpReligiousDebt.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpReligiousDebt.FinancialObligationTitle = row["FinancialObligationTitle"].ToString();
					tmpReligiousDebt.ReligiousObligationTitle = row["ReligiousObligationTitle"].ToString();
					tmpReligiousDebt.FinancialObligationAmount = (row["FinancialObligationAmount"] != DBNull.Value) ? Convert.ToSingle(row["FinancialObligationAmount"]) : 0 ;
					tmpReligiousDebt.ReligiousObligationAmount = (row["ReligiousObligationAmount"] != DBNull.Value) ? Convert.ToSingle(row["ReligiousObligationAmount"]) : 0 ;
					tmpReligiousDebt.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(tmpReligiousDebt.HeritageID);
					tmpReligiousDebt.HeritageID = heritage.HeritageID;
					tmpReligiousDebt.StageTitle = heritage.StageTitle;
					tmpReligiousDebt.RegisterDate = heritage.RegisterDate;
					tmpReligiousDebt.OldRegisterDate = heritage.OldRegisterDate;
					tmpReligiousDebt.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpReligiousDebt.Sixth = heritage.Sixth;
					tmpReligiousDebt.PreviousOwner = heritage.PreviousOwner;
					tmpReligiousDebt.Comment = heritage.Comment;
					tmpReligiousDebt.RegisterInformationID = heritage.RegisterInformationID;
					tmpReligiousDebt.AdjustmentID = heritage.AdjustmentID;
					tmpReligiousDebt.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpReligiousDebt.Stage = heritage.Stage;
					tmpReligiousDebt.UserOrder = heritage.UserOrder;
					tmpReligiousDebt.Value1 = heritage.Value1;
					tmpReligiousDebt.Value2 = heritage.Value2;
					tmpReligiousDebt.Value3 = heritage.Value3;
					tmpReligiousDebt.DeadIsOwner = heritage.DeadIsOwner;
					tmpReligiousDebt.IsDiagonesed = heritage.IsDiagonesed;

					listReligiousDebt.Add(tmpReligiousDebt);
				}
			}
		}

		return listReligiousDebt;
	}

}
}
