using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class DebtsDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(Debts debts)
	{
		if (!heritageDBAccess.Exists(debts))
			debts.HeritageID = heritageDBAccess.Insert(debts);

		SqlParameter[] parametersDebts = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (debts.HeritageID > 0) ? debts.HeritageID : (object)DBNull.Value),
			new SqlParameter("@DebtsTypeID", (debts.DebtsTypeID > 0) ? debts.DebtsTypeID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (debts.DeclarationID > 0) ? debts.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@ProductionUnitID", (debts.ProductionUnitID > 0) ? debts.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@CreditorName", debts.CreditorName),
			new SqlParameter("@CreditorAddress", (debts.CreditorAddress != null) ? debts.CreditorAddress : (object)DBNull.Value),
			new SqlParameter("@DebtResource", (debts.DebtResource != null) ? debts.DebtResource : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("Debts_Insert", CommandType.StoredProcedure, parametersDebts);
	}

	public bool Update(Debts debts)
	{
		heritageDBAccess.Update(debts);

		SqlParameter[] parametersDebts = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", debts.HeritageID),
			new SqlParameter("@DebtsTypeID", (debts.DebtsTypeID != null && debts.DebtsTypeID >0 ) ? debts.DebtsTypeID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", debts.DeclarationID),
			new SqlParameter("@ProductionUnitID", (debts.ProductionUnitID != null && debts.ProductionUnitID >0 ) ? debts.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@CreditorName", debts.CreditorName),
			new SqlParameter("@CreditorAddress", (debts.CreditorAddress != null) ? debts.CreditorAddress : (object)DBNull.Value),
			new SqlParameter("@DebtResource", (debts.DebtResource != null) ? debts.DebtResource : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Debts_Update", CommandType.StoredProcedure, parametersDebts);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersDebts = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("Debts_Delete", CommandType.StoredProcedure, parametersDebts);
	}

	public Debts GetDetails(Int64 heritageID)
	{
		Debts debts = new Debts();

		SqlParameter[] parametersDebts = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Debts_GetDetails", CommandType.StoredProcedure, parametersDebts))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				debts.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				debts.DebtsTypeIDTitle = row["DebtsTypeIDTitle"].ToString();
				debts.DebtsTypeID = (row["DebtsTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DebtsTypeID"]) : 0 ;
				debts.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				debts.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
				debts.CreditorName = row["CreditorName"].ToString();
				debts.CreditorAddress = row["CreditorAddress"].ToString();
				debts.DebtResource = row["DebtResource"].ToString();

				Heritage heritage = heritageDBAccess.GetDetails(debts.HeritageID);
				debts.HeritageID = heritage.HeritageID;
				debts.StageTitle = heritage.StageTitle;
				debts.RegisterDate = heritage.RegisterDate;
				debts.OldRegisterDate = heritage.OldRegisterDate;
				debts.OldRegisterInformationID = heritage.OldRegisterInformationID;
				debts.Sixth = heritage.Sixth;
				debts.PreviousOwner = heritage.PreviousOwner;
				debts.Comment = heritage.Comment;
				debts.RegisterInformationID = heritage.RegisterInformationID;
				debts.AdjustmentID = heritage.AdjustmentID;
				debts.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				debts.Stage = heritage.Stage;
				debts.UserOrder = heritage.UserOrder;
				debts.Value1 = heritage.Value1;
				debts.Value2 = heritage.Value2;
				debts.Value3 = heritage.Value3;
				debts.DeadIsOwner = heritage.DeadIsOwner;
				debts.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return debts;
	}

	public List<Debts> GetListAll()
	{
		List<Debts> listDebts = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Debts_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listDebts = new List<Debts>();

				foreach (DataRow row in table.Rows)
				{
					Debts debts = new Debts();
					debts.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					debts.DebtsTypeIDTitle = row["DebtsTypeIDTitle"].ToString();
					debts.DebtsTypeID = (row["DebtsTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DebtsTypeID"]) : 0 ;
					debts.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					debts.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					debts.CreditorName = row["CreditorName"].ToString();
					debts.CreditorAddress = row["CreditorAddress"].ToString();
					debts.DebtResource = row["DebtResource"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(debts.HeritageID);
					debts.StageTitle = heritage.StageTitle;
					debts.RegisterDate = heritage.RegisterDate;
					debts.OldRegisterDate = heritage.OldRegisterDate;
					debts.OldRegisterInformationID = heritage.OldRegisterInformationID;
					debts.Sixth = heritage.Sixth;
					debts.PreviousOwner = heritage.PreviousOwner;
					debts.Comment = heritage.Comment;
					debts.RegisterInformationID = heritage.RegisterInformationID;
					debts.AdjustmentID = heritage.AdjustmentID;
					debts.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					debts.Stage = heritage.Stage;
					debts.UserOrder = heritage.UserOrder;
					debts.Value1 = heritage.Value1;
					debts.Value2 = heritage.Value2;
					debts.Value3 = heritage.Value3;
					debts.DeadIsOwner = heritage.DeadIsOwner;
					debts.IsDiagonesed = heritage.IsDiagonesed;
					listDebts.Add(debts);
				}
			}
		}

		return listDebts;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersDebts = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Debts_Exists", CommandType.StoredProcedure, parametersDebts)>0);
	}

	public bool Exists(Debts debts)
	{
		SqlParameter[] parametersDebts = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", debts.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Debts_Exists", CommandType.StoredProcedure, parametersDebts)>0);
	}

	public List<Debts> SearchLike(Debts debts)
	{
		List<Debts> listDebts = new List<Debts>();


		SqlParameter[] parametersDebts = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", debts.HeritageID),
			new SqlParameter("@DebtsTypeIDTitle", debts.DebtsTypeIDTitle),
			new SqlParameter("@DebtsTypeID", debts.DebtsTypeID),
			new SqlParameter("@DeclarationID", debts.DeclarationID),
			new SqlParameter("@ProductionUnitID", debts.ProductionUnitID),
			new SqlParameter("@CreditorName", debts.CreditorName),
			new SqlParameter("@CreditorAddress", debts.CreditorAddress),
			new SqlParameter("@DebtResource", debts.DebtResource),

			new SqlParameter("@StageTitle", debts.StageTitle),
			new SqlParameter("@RegisterDate", debts.RegisterDate),
			new SqlParameter("@OldRegisterDate", debts.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", debts.OldRegisterInformationID),
			new SqlParameter("@Sixth", debts.Sixth),
			new SqlParameter("@PreviousOwner", debts.PreviousOwner),
			new SqlParameter("@Comment", debts.Comment),
			new SqlParameter("@RegisterInformationID", debts.RegisterInformationID),
			new SqlParameter("@AdjustmentID", debts.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", debts.CommissionAdjustmentID),
			new SqlParameter("@Stage", debts.Stage),
			new SqlParameter("@UserOrder", debts.UserOrder),
			new SqlParameter("@Value1", debts.Value1),
			new SqlParameter("@Value2", debts.Value2),
			new SqlParameter("@Value3", debts.Value3),
			new SqlParameter("@DeadIsOwner", debts.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", debts.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Debts_SearchLike", CommandType.StoredProcedure, parametersDebts))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Debts tmpDebts = new Debts();
					tmpDebts.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpDebts.DebtsTypeIDTitle = row["DebtsTypeIDTitle"].ToString();
					tmpDebts.DebtsTypeID = (row["DebtsTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DebtsTypeID"]) : 0 ;
					tmpDebts.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpDebts.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					tmpDebts.CreditorName = row["CreditorName"].ToString();
					tmpDebts.CreditorAddress = row["CreditorAddress"].ToString();
					tmpDebts.DebtResource = row["DebtResource"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(tmpDebts.HeritageID);
					tmpDebts.HeritageID = heritage.HeritageID;
					tmpDebts.StageTitle = heritage.StageTitle;
					tmpDebts.RegisterDate = heritage.RegisterDate;
					tmpDebts.OldRegisterDate = heritage.OldRegisterDate;
					tmpDebts.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpDebts.Sixth = heritage.Sixth;
					tmpDebts.PreviousOwner = heritage.PreviousOwner;
					tmpDebts.Comment = heritage.Comment;
					tmpDebts.RegisterInformationID = heritage.RegisterInformationID;
					tmpDebts.AdjustmentID = heritage.AdjustmentID;
					tmpDebts.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpDebts.Stage = heritage.Stage;
					tmpDebts.UserOrder = heritage.UserOrder;
					tmpDebts.Value1 = heritage.Value1;
					tmpDebts.Value2 = heritage.Value2;
					tmpDebts.Value3 = heritage.Value3;
					tmpDebts.DeadIsOwner = heritage.DeadIsOwner;
					tmpDebts.IsDiagonesed = heritage.IsDiagonesed;

					listDebts.Add(tmpDebts);
				}
			}
		}

		return listDebts;
	}

}
}
