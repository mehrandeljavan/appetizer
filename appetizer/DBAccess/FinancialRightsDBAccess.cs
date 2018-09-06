using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class FinancialRightsDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(FinancialRights financialRights)
	{
		if (!heritageDBAccess.Exists(financialRights))
			financialRights.HeritageID = heritageDBAccess.Insert(financialRights);

		SqlParameter[] parametersFinancialRights = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (financialRights.HeritageID > 0) ? financialRights.HeritageID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (financialRights.DeclarationID > 0) ? financialRights.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@ProductionUnitID", (financialRights.ProductionUnitID > 0) ? financialRights.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@TitleAndDescription", (financialRights.TitleAndDescription != null) ? financialRights.TitleAndDescription : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("FinancialRights_Insert", CommandType.StoredProcedure, parametersFinancialRights);
	}

	public bool Update(FinancialRights financialRights)
	{
		heritageDBAccess.Update(financialRights);

		SqlParameter[] parametersFinancialRights = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", financialRights.HeritageID),
			new SqlParameter("@DeclarationID", financialRights.DeclarationID),
			new SqlParameter("@ProductionUnitID", (financialRights.ProductionUnitID != null && financialRights.ProductionUnitID >0 ) ? financialRights.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@TitleAndDescription", (financialRights.TitleAndDescription != null) ? financialRights.TitleAndDescription : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("FinancialRights_Update", CommandType.StoredProcedure, parametersFinancialRights);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersFinancialRights = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("FinancialRights_Delete", CommandType.StoredProcedure, parametersFinancialRights);
	}

	public FinancialRights GetDetails(Int64 heritageID)
	{
		FinancialRights financialRights = new FinancialRights();

		SqlParameter[] parametersFinancialRights = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FinancialRights_GetDetails", CommandType.StoredProcedure, parametersFinancialRights))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				financialRights.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				financialRights.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				financialRights.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
				financialRights.TitleAndDescription = row["TitleAndDescription"].ToString();

				Heritage heritage = heritageDBAccess.GetDetails(financialRights.HeritageID);
				financialRights.HeritageID = heritage.HeritageID;
				financialRights.StageTitle = heritage.StageTitle;
				financialRights.RegisterDate = heritage.RegisterDate;
				financialRights.OldRegisterDate = heritage.OldRegisterDate;
				financialRights.OldRegisterInformationID = heritage.OldRegisterInformationID;
				financialRights.Sixth = heritage.Sixth;
				financialRights.PreviousOwner = heritage.PreviousOwner;
				financialRights.Comment = heritage.Comment;
				financialRights.RegisterInformationID = heritage.RegisterInformationID;
				financialRights.AdjustmentID = heritage.AdjustmentID;
				financialRights.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				financialRights.Stage = heritage.Stage;
				financialRights.UserOrder = heritage.UserOrder;
				financialRights.Value1 = heritage.Value1;
				financialRights.Value2 = heritage.Value2;
				financialRights.Value3 = heritage.Value3;
				financialRights.DeadIsOwner = heritage.DeadIsOwner;
				financialRights.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return financialRights;
	}

	public List<FinancialRights> GetListAll()
	{
		List<FinancialRights> listFinancialRights = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("FinancialRights_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listFinancialRights = new List<FinancialRights>();

				foreach (DataRow row in table.Rows)
				{
					FinancialRights financialRights = new FinancialRights();
					financialRights.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					financialRights.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					financialRights.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					financialRights.TitleAndDescription = row["TitleAndDescription"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(financialRights.HeritageID);
					financialRights.StageTitle = heritage.StageTitle;
					financialRights.RegisterDate = heritage.RegisterDate;
					financialRights.OldRegisterDate = heritage.OldRegisterDate;
					financialRights.OldRegisterInformationID = heritage.OldRegisterInformationID;
					financialRights.Sixth = heritage.Sixth;
					financialRights.PreviousOwner = heritage.PreviousOwner;
					financialRights.Comment = heritage.Comment;
					financialRights.RegisterInformationID = heritage.RegisterInformationID;
					financialRights.AdjustmentID = heritage.AdjustmentID;
					financialRights.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					financialRights.Stage = heritage.Stage;
					financialRights.UserOrder = heritage.UserOrder;
					financialRights.Value1 = heritage.Value1;
					financialRights.Value2 = heritage.Value2;
					financialRights.Value3 = heritage.Value3;
					financialRights.DeadIsOwner = heritage.DeadIsOwner;
					financialRights.IsDiagonesed = heritage.IsDiagonesed;
					listFinancialRights.Add(financialRights);
				}
			}
		}

		return listFinancialRights;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersFinancialRights = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("FinancialRights_Exists", CommandType.StoredProcedure, parametersFinancialRights)>0);
	}

	public bool Exists(FinancialRights financialRights)
	{
		SqlParameter[] parametersFinancialRights = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", financialRights.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("FinancialRights_Exists", CommandType.StoredProcedure, parametersFinancialRights)>0);
	}

	public List<FinancialRights> SearchLike(FinancialRights financialRights)
	{
		List<FinancialRights> listFinancialRights = new List<FinancialRights>();


		SqlParameter[] parametersFinancialRights = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", financialRights.HeritageID),
			new SqlParameter("@DeclarationID", financialRights.DeclarationID),
			new SqlParameter("@ProductionUnitID", financialRights.ProductionUnitID),
			new SqlParameter("@TitleAndDescription", financialRights.TitleAndDescription),

			new SqlParameter("@StageTitle", financialRights.StageTitle),
			new SqlParameter("@RegisterDate", financialRights.RegisterDate),
			new SqlParameter("@OldRegisterDate", financialRights.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", financialRights.OldRegisterInformationID),
			new SqlParameter("@Sixth", financialRights.Sixth),
			new SqlParameter("@PreviousOwner", financialRights.PreviousOwner),
			new SqlParameter("@Comment", financialRights.Comment),
			new SqlParameter("@RegisterInformationID", financialRights.RegisterInformationID),
			new SqlParameter("@AdjustmentID", financialRights.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", financialRights.CommissionAdjustmentID),
			new SqlParameter("@Stage", financialRights.Stage),
			new SqlParameter("@UserOrder", financialRights.UserOrder),
			new SqlParameter("@Value1", financialRights.Value1),
			new SqlParameter("@Value2", financialRights.Value2),
			new SqlParameter("@Value3", financialRights.Value3),
			new SqlParameter("@DeadIsOwner", financialRights.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", financialRights.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FinancialRights_SearchLike", CommandType.StoredProcedure, parametersFinancialRights))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					FinancialRights tmpFinancialRights = new FinancialRights();
					tmpFinancialRights.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpFinancialRights.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpFinancialRights.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					tmpFinancialRights.TitleAndDescription = row["TitleAndDescription"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(tmpFinancialRights.HeritageID);
					tmpFinancialRights.HeritageID = heritage.HeritageID;
					tmpFinancialRights.StageTitle = heritage.StageTitle;
					tmpFinancialRights.RegisterDate = heritage.RegisterDate;
					tmpFinancialRights.OldRegisterDate = heritage.OldRegisterDate;
					tmpFinancialRights.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpFinancialRights.Sixth = heritage.Sixth;
					tmpFinancialRights.PreviousOwner = heritage.PreviousOwner;
					tmpFinancialRights.Comment = heritage.Comment;
					tmpFinancialRights.RegisterInformationID = heritage.RegisterInformationID;
					tmpFinancialRights.AdjustmentID = heritage.AdjustmentID;
					tmpFinancialRights.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpFinancialRights.Stage = heritage.Stage;
					tmpFinancialRights.UserOrder = heritage.UserOrder;
					tmpFinancialRights.Value1 = heritage.Value1;
					tmpFinancialRights.Value2 = heritage.Value2;
					tmpFinancialRights.Value3 = heritage.Value3;
					tmpFinancialRights.DeadIsOwner = heritage.DeadIsOwner;
					tmpFinancialRights.IsDiagonesed = heritage.IsDiagonesed;

					listFinancialRights.Add(tmpFinancialRights);
				}
			}
		}

		return listFinancialRights;
	}

}
}
