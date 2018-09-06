using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class PermitDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(Permit permit)
	{
		if (!heritageDBAccess.Exists(permit))
			permit.HeritageID = heritageDBAccess.Insert(permit);

		SqlParameter[] parametersPermit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (permit.HeritageID > 0) ? permit.HeritageID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (permit.DeclarationID > 0) ? permit.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@ProductionUnitID", (permit.ProductionUnitID > 0) ? permit.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@PermitName", (permit.PermitName != null) ? permit.PermitName : (object)DBNull.Value),
			new SqlParameter("@PermitReference", (permit.PermitReference != null) ? permit.PermitReference : (object)DBNull.Value),
			new SqlParameter("@PermitNumber", (permit.PermitNumber != null) ? permit.PermitNumber : (object)DBNull.Value),
			new SqlParameter("@LocationAddress", (permit.LocationAddress != null) ? permit.LocationAddress : (object)DBNull.Value),
			new SqlParameter("@PermitDate", (permit.PermitDate != null) ? permit.PermitDate : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("Permit_Insert", CommandType.StoredProcedure, parametersPermit);
	}

	public bool Update(Permit permit)
	{
		heritageDBAccess.Update(permit);

		SqlParameter[] parametersPermit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", permit.HeritageID),
			new SqlParameter("@DeclarationID", permit.DeclarationID),
			new SqlParameter("@ProductionUnitID", (permit.ProductionUnitID != null && permit.ProductionUnitID >0 ) ? permit.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@PermitName", (permit.PermitName != null) ? permit.PermitName : (object)DBNull.Value),
			new SqlParameter("@PermitReference", (permit.PermitReference != null) ? permit.PermitReference : (object)DBNull.Value),
			new SqlParameter("@PermitNumber", (permit.PermitNumber != null) ? permit.PermitNumber : (object)DBNull.Value),
			new SqlParameter("@LocationAddress", (permit.LocationAddress != null) ? permit.LocationAddress : (object)DBNull.Value),
			new SqlParameter("@PermitDate", (permit.PermitDate != null) ? permit.PermitDate : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Permit_Update", CommandType.StoredProcedure, parametersPermit);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersPermit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("Permit_Delete", CommandType.StoredProcedure, parametersPermit);
	}

	public Permit GetDetails(Int64 heritageID)
	{
		Permit permit = new Permit();

		SqlParameter[] parametersPermit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Permit_GetDetails", CommandType.StoredProcedure, parametersPermit))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				permit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				permit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				permit.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
				permit.PermitName = row["PermitName"].ToString();
				permit.PermitReference = row["PermitReference"].ToString();
				permit.PermitNumber = row["PermitNumber"].ToString();
				permit.LocationAddress = row["LocationAddress"].ToString();
				permit.PermitDate = row["PermitDate"].ToString();

				Heritage heritage = heritageDBAccess.GetDetails(permit.HeritageID);
				permit.HeritageID = heritage.HeritageID;
				permit.StageTitle = heritage.StageTitle;
				permit.RegisterDate = heritage.RegisterDate;
				permit.OldRegisterDate = heritage.OldRegisterDate;
				permit.OldRegisterInformationID = heritage.OldRegisterInformationID;
				permit.Sixth = heritage.Sixth;
				permit.PreviousOwner = heritage.PreviousOwner;
				permit.Comment = heritage.Comment;
				permit.RegisterInformationID = heritage.RegisterInformationID;
				permit.AdjustmentID = heritage.AdjustmentID;
				permit.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				permit.Stage = heritage.Stage;
				permit.UserOrder = heritage.UserOrder;
				permit.Value1 = heritage.Value1;
				permit.Value2 = heritage.Value2;
				permit.Value3 = heritage.Value3;
				permit.DeadIsOwner = heritage.DeadIsOwner;
				permit.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return permit;
	}

	public List<Permit> GetListAll()
	{
		List<Permit> listPermit = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Permit_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listPermit = new List<Permit>();

				foreach (DataRow row in table.Rows)
				{
					Permit permit = new Permit();
					permit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					permit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					permit.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					permit.PermitName = row["PermitName"].ToString();
					permit.PermitReference = row["PermitReference"].ToString();
					permit.PermitNumber = row["PermitNumber"].ToString();
					permit.LocationAddress = row["LocationAddress"].ToString();
					permit.PermitDate = row["PermitDate"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(permit.HeritageID);
					permit.StageTitle = heritage.StageTitle;
					permit.RegisterDate = heritage.RegisterDate;
					permit.OldRegisterDate = heritage.OldRegisterDate;
					permit.OldRegisterInformationID = heritage.OldRegisterInformationID;
					permit.Sixth = heritage.Sixth;
					permit.PreviousOwner = heritage.PreviousOwner;
					permit.Comment = heritage.Comment;
					permit.RegisterInformationID = heritage.RegisterInformationID;
					permit.AdjustmentID = heritage.AdjustmentID;
					permit.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					permit.Stage = heritage.Stage;
					permit.UserOrder = heritage.UserOrder;
					permit.Value1 = heritage.Value1;
					permit.Value2 = heritage.Value2;
					permit.Value3 = heritage.Value3;
					permit.DeadIsOwner = heritage.DeadIsOwner;
					permit.IsDiagonesed = heritage.IsDiagonesed;
					listPermit.Add(permit);
				}
			}
		}

		return listPermit;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersPermit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Permit_Exists", CommandType.StoredProcedure, parametersPermit)>0);
	}

	public bool Exists(Permit permit)
	{
		SqlParameter[] parametersPermit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", permit.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Permit_Exists", CommandType.StoredProcedure, parametersPermit)>0);
	}

	public List<Permit> SearchLike(Permit permit)
	{
		List<Permit> listPermit = new List<Permit>();


		SqlParameter[] parametersPermit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", permit.HeritageID),
			new SqlParameter("@DeclarationID", permit.DeclarationID),
			new SqlParameter("@ProductionUnitID", permit.ProductionUnitID),
			new SqlParameter("@PermitName", permit.PermitName),
			new SqlParameter("@PermitReference", permit.PermitReference),
			new SqlParameter("@PermitNumber", permit.PermitNumber),
			new SqlParameter("@LocationAddress", permit.LocationAddress),
			new SqlParameter("@PermitDate", permit.PermitDate),

			new SqlParameter("@StageTitle", permit.StageTitle),
			new SqlParameter("@RegisterDate", permit.RegisterDate),
			new SqlParameter("@OldRegisterDate", permit.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", permit.OldRegisterInformationID),
			new SqlParameter("@Sixth", permit.Sixth),
			new SqlParameter("@PreviousOwner", permit.PreviousOwner),
			new SqlParameter("@Comment", permit.Comment),
			new SqlParameter("@RegisterInformationID", permit.RegisterInformationID),
			new SqlParameter("@AdjustmentID", permit.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", permit.CommissionAdjustmentID),
			new SqlParameter("@Stage", permit.Stage),
			new SqlParameter("@UserOrder", permit.UserOrder),
			new SqlParameter("@Value1", permit.Value1),
			new SqlParameter("@Value2", permit.Value2),
			new SqlParameter("@Value3", permit.Value3),
			new SqlParameter("@DeadIsOwner", permit.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", permit.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Permit_SearchLike", CommandType.StoredProcedure, parametersPermit))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Permit tmpPermit = new Permit();
					tmpPermit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpPermit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpPermit.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					tmpPermit.PermitName = row["PermitName"].ToString();
					tmpPermit.PermitReference = row["PermitReference"].ToString();
					tmpPermit.PermitNumber = row["PermitNumber"].ToString();
					tmpPermit.LocationAddress = row["LocationAddress"].ToString();
					tmpPermit.PermitDate = row["PermitDate"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(tmpPermit.HeritageID);
					tmpPermit.HeritageID = heritage.HeritageID;
					tmpPermit.StageTitle = heritage.StageTitle;
					tmpPermit.RegisterDate = heritage.RegisterDate;
					tmpPermit.OldRegisterDate = heritage.OldRegisterDate;
					tmpPermit.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpPermit.Sixth = heritage.Sixth;
					tmpPermit.PreviousOwner = heritage.PreviousOwner;
					tmpPermit.Comment = heritage.Comment;
					tmpPermit.RegisterInformationID = heritage.RegisterInformationID;
					tmpPermit.AdjustmentID = heritage.AdjustmentID;
					tmpPermit.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpPermit.Stage = heritage.Stage;
					tmpPermit.UserOrder = heritage.UserOrder;
					tmpPermit.Value1 = heritage.Value1;
					tmpPermit.Value2 = heritage.Value2;
					tmpPermit.Value3 = heritage.Value3;
					tmpPermit.DeadIsOwner = heritage.DeadIsOwner;
					tmpPermit.IsDiagonesed = heritage.IsDiagonesed;

					listPermit.Add(tmpPermit);
				}
			}
		}

		return listPermit;
	}

}
}
