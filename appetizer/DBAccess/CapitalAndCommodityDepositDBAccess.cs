using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class CapitalAndCommodityDepositDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(CapitalAndCommodityDeposit capitalAndCommodityDeposit)
	{
		if (!heritageDBAccess.Exists(capitalAndCommodityDeposit))
			capitalAndCommodityDeposit.HeritageID = heritageDBAccess.Insert(capitalAndCommodityDeposit);

		SqlParameter[] parametersCapitalAndCommodityDeposit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (capitalAndCommodityDeposit.HeritageID > 0) ? capitalAndCommodityDeposit.HeritageID : (object)DBNull.Value),
			new SqlParameter("@ProductionUnitID", (capitalAndCommodityDeposit.ProductionUnitID > 0) ? capitalAndCommodityDeposit.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@Title", capitalAndCommodityDeposit.Title),
			new SqlParameter("@Address", capitalAndCommodityDeposit.Address),
			new SqlParameter("@DeclarationID", (capitalAndCommodityDeposit.DeclarationID > 0) ? capitalAndCommodityDeposit.DeclarationID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("CapitalAndCommodityDeposit_Insert", CommandType.StoredProcedure, parametersCapitalAndCommodityDeposit);
	}

	public bool Update(CapitalAndCommodityDeposit capitalAndCommodityDeposit)
	{
		heritageDBAccess.Update(capitalAndCommodityDeposit);

		SqlParameter[] parametersCapitalAndCommodityDeposit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", capitalAndCommodityDeposit.HeritageID),
			new SqlParameter("@ProductionUnitID", (capitalAndCommodityDeposit.ProductionUnitID != null && capitalAndCommodityDeposit.ProductionUnitID >0 ) ? capitalAndCommodityDeposit.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@Title", capitalAndCommodityDeposit.Title),
			new SqlParameter("@Address", capitalAndCommodityDeposit.Address),
			new SqlParameter("@DeclarationID", capitalAndCommodityDeposit.DeclarationID)
		};
		return SqlDBHelper.ExecuteNonQuery("CapitalAndCommodityDeposit_Update", CommandType.StoredProcedure, parametersCapitalAndCommodityDeposit);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersCapitalAndCommodityDeposit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("CapitalAndCommodityDeposit_Delete", CommandType.StoredProcedure, parametersCapitalAndCommodityDeposit);
	}

	public CapitalAndCommodityDeposit GetDetails(Int64 heritageID)
	{
		CapitalAndCommodityDeposit capitalAndCommodityDeposit = new CapitalAndCommodityDeposit();

		SqlParameter[] parametersCapitalAndCommodityDeposit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CapitalAndCommodityDeposit_GetDetails", CommandType.StoredProcedure, parametersCapitalAndCommodityDeposit))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				capitalAndCommodityDeposit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				capitalAndCommodityDeposit.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
				capitalAndCommodityDeposit.Title = row["Title"].ToString();
				capitalAndCommodityDeposit.Address = row["Address"].ToString();
				capitalAndCommodityDeposit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

				Heritage heritage = heritageDBAccess.GetDetails(capitalAndCommodityDeposit.HeritageID);
				capitalAndCommodityDeposit.HeritageID = heritage.HeritageID;
				capitalAndCommodityDeposit.StageTitle = heritage.StageTitle;
				capitalAndCommodityDeposit.RegisterDate = heritage.RegisterDate;
				capitalAndCommodityDeposit.OldRegisterDate = heritage.OldRegisterDate;
				capitalAndCommodityDeposit.OldRegisterInformationID = heritage.OldRegisterInformationID;
				capitalAndCommodityDeposit.Sixth = heritage.Sixth;
				capitalAndCommodityDeposit.PreviousOwner = heritage.PreviousOwner;
				capitalAndCommodityDeposit.Comment = heritage.Comment;
				capitalAndCommodityDeposit.RegisterInformationID = heritage.RegisterInformationID;
				capitalAndCommodityDeposit.AdjustmentID = heritage.AdjustmentID;
				capitalAndCommodityDeposit.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				capitalAndCommodityDeposit.Stage = heritage.Stage;
				capitalAndCommodityDeposit.UserOrder = heritage.UserOrder;
				capitalAndCommodityDeposit.Value1 = heritage.Value1;
				capitalAndCommodityDeposit.Value2 = heritage.Value2;
				capitalAndCommodityDeposit.Value3 = heritage.Value3;
				capitalAndCommodityDeposit.DeadIsOwner = heritage.DeadIsOwner;
				capitalAndCommodityDeposit.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return capitalAndCommodityDeposit;
	}

	public List<CapitalAndCommodityDeposit> GetListAll()
	{
		List<CapitalAndCommodityDeposit> listCapitalAndCommodityDeposit = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("CapitalAndCommodityDeposit_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listCapitalAndCommodityDeposit = new List<CapitalAndCommodityDeposit>();

				foreach (DataRow row in table.Rows)
				{
					CapitalAndCommodityDeposit capitalAndCommodityDeposit = new CapitalAndCommodityDeposit();
					capitalAndCommodityDeposit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					capitalAndCommodityDeposit.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					capitalAndCommodityDeposit.Title = row["Title"].ToString();
					capitalAndCommodityDeposit.Address = row["Address"].ToString();
					capitalAndCommodityDeposit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(capitalAndCommodityDeposit.HeritageID);
					capitalAndCommodityDeposit.StageTitle = heritage.StageTitle;
					capitalAndCommodityDeposit.RegisterDate = heritage.RegisterDate;
					capitalAndCommodityDeposit.OldRegisterDate = heritage.OldRegisterDate;
					capitalAndCommodityDeposit.OldRegisterInformationID = heritage.OldRegisterInformationID;
					capitalAndCommodityDeposit.Sixth = heritage.Sixth;
					capitalAndCommodityDeposit.PreviousOwner = heritage.PreviousOwner;
					capitalAndCommodityDeposit.Comment = heritage.Comment;
					capitalAndCommodityDeposit.RegisterInformationID = heritage.RegisterInformationID;
					capitalAndCommodityDeposit.AdjustmentID = heritage.AdjustmentID;
					capitalAndCommodityDeposit.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					capitalAndCommodityDeposit.Stage = heritage.Stage;
					capitalAndCommodityDeposit.UserOrder = heritage.UserOrder;
					capitalAndCommodityDeposit.Value1 = heritage.Value1;
					capitalAndCommodityDeposit.Value2 = heritage.Value2;
					capitalAndCommodityDeposit.Value3 = heritage.Value3;
					capitalAndCommodityDeposit.DeadIsOwner = heritage.DeadIsOwner;
					capitalAndCommodityDeposit.IsDiagonesed = heritage.IsDiagonesed;
					listCapitalAndCommodityDeposit.Add(capitalAndCommodityDeposit);
				}
			}
		}

		return listCapitalAndCommodityDeposit;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersCapitalAndCommodityDeposit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("CapitalAndCommodityDeposit_Exists", CommandType.StoredProcedure, parametersCapitalAndCommodityDeposit)>0);
	}

	public bool Exists(CapitalAndCommodityDeposit capitalAndCommodityDeposit)
	{
		SqlParameter[] parametersCapitalAndCommodityDeposit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", capitalAndCommodityDeposit.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("CapitalAndCommodityDeposit_Exists", CommandType.StoredProcedure, parametersCapitalAndCommodityDeposit)>0);
	}

	public List<CapitalAndCommodityDeposit> SearchLike(CapitalAndCommodityDeposit capitalAndCommodityDeposit)
	{
		List<CapitalAndCommodityDeposit> listCapitalAndCommodityDeposit = new List<CapitalAndCommodityDeposit>();


		SqlParameter[] parametersCapitalAndCommodityDeposit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", capitalAndCommodityDeposit.HeritageID),
			new SqlParameter("@ProductionUnitID", capitalAndCommodityDeposit.ProductionUnitID),
			new SqlParameter("@Title", capitalAndCommodityDeposit.Title),
			new SqlParameter("@Address", capitalAndCommodityDeposit.Address),
			new SqlParameter("@DeclarationID", capitalAndCommodityDeposit.DeclarationID),

			new SqlParameter("@StageTitle", capitalAndCommodityDeposit.StageTitle),
			new SqlParameter("@RegisterDate", capitalAndCommodityDeposit.RegisterDate),
			new SqlParameter("@OldRegisterDate", capitalAndCommodityDeposit.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", capitalAndCommodityDeposit.OldRegisterInformationID),
			new SqlParameter("@Sixth", capitalAndCommodityDeposit.Sixth),
			new SqlParameter("@PreviousOwner", capitalAndCommodityDeposit.PreviousOwner),
			new SqlParameter("@Comment", capitalAndCommodityDeposit.Comment),
			new SqlParameter("@RegisterInformationID", capitalAndCommodityDeposit.RegisterInformationID),
			new SqlParameter("@AdjustmentID", capitalAndCommodityDeposit.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", capitalAndCommodityDeposit.CommissionAdjustmentID),
			new SqlParameter("@Stage", capitalAndCommodityDeposit.Stage),
			new SqlParameter("@UserOrder", capitalAndCommodityDeposit.UserOrder),
			new SqlParameter("@Value1", capitalAndCommodityDeposit.Value1),
			new SqlParameter("@Value2", capitalAndCommodityDeposit.Value2),
			new SqlParameter("@Value3", capitalAndCommodityDeposit.Value3),
			new SqlParameter("@DeadIsOwner", capitalAndCommodityDeposit.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", capitalAndCommodityDeposit.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CapitalAndCommodityDeposit_SearchLike", CommandType.StoredProcedure, parametersCapitalAndCommodityDeposit))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					CapitalAndCommodityDeposit tmpCapitalAndCommodityDeposit = new CapitalAndCommodityDeposit();
					tmpCapitalAndCommodityDeposit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpCapitalAndCommodityDeposit.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					tmpCapitalAndCommodityDeposit.Title = row["Title"].ToString();
					tmpCapitalAndCommodityDeposit.Address = row["Address"].ToString();
					tmpCapitalAndCommodityDeposit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(tmpCapitalAndCommodityDeposit.HeritageID);
					tmpCapitalAndCommodityDeposit.HeritageID = heritage.HeritageID;
					tmpCapitalAndCommodityDeposit.StageTitle = heritage.StageTitle;
					tmpCapitalAndCommodityDeposit.RegisterDate = heritage.RegisterDate;
					tmpCapitalAndCommodityDeposit.OldRegisterDate = heritage.OldRegisterDate;
					tmpCapitalAndCommodityDeposit.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpCapitalAndCommodityDeposit.Sixth = heritage.Sixth;
					tmpCapitalAndCommodityDeposit.PreviousOwner = heritage.PreviousOwner;
					tmpCapitalAndCommodityDeposit.Comment = heritage.Comment;
					tmpCapitalAndCommodityDeposit.RegisterInformationID = heritage.RegisterInformationID;
					tmpCapitalAndCommodityDeposit.AdjustmentID = heritage.AdjustmentID;
					tmpCapitalAndCommodityDeposit.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpCapitalAndCommodityDeposit.Stage = heritage.Stage;
					tmpCapitalAndCommodityDeposit.UserOrder = heritage.UserOrder;
					tmpCapitalAndCommodityDeposit.Value1 = heritage.Value1;
					tmpCapitalAndCommodityDeposit.Value2 = heritage.Value2;
					tmpCapitalAndCommodityDeposit.Value3 = heritage.Value3;
					tmpCapitalAndCommodityDeposit.DeadIsOwner = heritage.DeadIsOwner;
					tmpCapitalAndCommodityDeposit.IsDiagonesed = heritage.IsDiagonesed;

					listCapitalAndCommodityDeposit.Add(tmpCapitalAndCommodityDeposit);
				}
			}
		}

		return listCapitalAndCommodityDeposit;
	}

}
}
