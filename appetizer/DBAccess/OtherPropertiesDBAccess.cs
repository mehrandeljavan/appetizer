using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class OtherPropertiesDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(OtherProperties otherProperties)
	{
		if (!heritageDBAccess.Exists(otherProperties))
			otherProperties.HeritageID = heritageDBAccess.Insert(otherProperties);

		SqlParameter[] parametersOtherProperties = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (otherProperties.HeritageID > 0) ? otherProperties.HeritageID : (object)DBNull.Value),
			new SqlParameter("@ProductionUnitID", (otherProperties.ProductionUnitID > 0) ? otherProperties.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@Name", (otherProperties.Name != null) ? otherProperties.Name : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (otherProperties.DeclarationID > 0) ? otherProperties.DeclarationID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("OtherProperties_Insert", CommandType.StoredProcedure, parametersOtherProperties);
	}

	public bool Update(OtherProperties otherProperties)
	{
		heritageDBAccess.Update(otherProperties);

		SqlParameter[] parametersOtherProperties = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", otherProperties.HeritageID),
			new SqlParameter("@ProductionUnitID", (otherProperties.ProductionUnitID != null && otherProperties.ProductionUnitID >0 ) ? otherProperties.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@Name", (otherProperties.Name != null) ? otherProperties.Name : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", otherProperties.DeclarationID)
		};
		return SqlDBHelper.ExecuteNonQuery("OtherProperties_Update", CommandType.StoredProcedure, parametersOtherProperties);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersOtherProperties = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("OtherProperties_Delete", CommandType.StoredProcedure, parametersOtherProperties);
	}

	public OtherProperties GetDetails(Int64 heritageID)
	{
		OtherProperties otherProperties = new OtherProperties();

		SqlParameter[] parametersOtherProperties = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("OtherProperties_GetDetails", CommandType.StoredProcedure, parametersOtherProperties))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				otherProperties.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				otherProperties.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
				otherProperties.Name = row["Name"].ToString();
				otherProperties.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

				Heritage heritage = heritageDBAccess.GetDetails(otherProperties.HeritageID);
				otherProperties.HeritageID = heritage.HeritageID;
				otherProperties.StageTitle = heritage.StageTitle;
				otherProperties.RegisterDate = heritage.RegisterDate;
				otherProperties.OldRegisterDate = heritage.OldRegisterDate;
				otherProperties.OldRegisterInformationID = heritage.OldRegisterInformationID;
				otherProperties.Sixth = heritage.Sixth;
				otherProperties.PreviousOwner = heritage.PreviousOwner;
				otherProperties.Comment = heritage.Comment;
				otherProperties.RegisterInformationID = heritage.RegisterInformationID;
				otherProperties.AdjustmentID = heritage.AdjustmentID;
				otherProperties.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				otherProperties.Stage = heritage.Stage;
				otherProperties.UserOrder = heritage.UserOrder;
				otherProperties.Value1 = heritage.Value1;
				otherProperties.Value2 = heritage.Value2;
				otherProperties.Value3 = heritage.Value3;
				otherProperties.DeadIsOwner = heritage.DeadIsOwner;
				otherProperties.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return otherProperties;
	}

	public List<OtherProperties> GetListAll()
	{
		List<OtherProperties> listOtherProperties = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("OtherProperties_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listOtherProperties = new List<OtherProperties>();

				foreach (DataRow row in table.Rows)
				{
					OtherProperties otherProperties = new OtherProperties();
					otherProperties.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					otherProperties.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					otherProperties.Name = row["Name"].ToString();
					otherProperties.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(otherProperties.HeritageID);
					otherProperties.StageTitle = heritage.StageTitle;
					otherProperties.RegisterDate = heritage.RegisterDate;
					otherProperties.OldRegisterDate = heritage.OldRegisterDate;
					otherProperties.OldRegisterInformationID = heritage.OldRegisterInformationID;
					otherProperties.Sixth = heritage.Sixth;
					otherProperties.PreviousOwner = heritage.PreviousOwner;
					otherProperties.Comment = heritage.Comment;
					otherProperties.RegisterInformationID = heritage.RegisterInformationID;
					otherProperties.AdjustmentID = heritage.AdjustmentID;
					otherProperties.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					otherProperties.Stage = heritage.Stage;
					otherProperties.UserOrder = heritage.UserOrder;
					otherProperties.Value1 = heritage.Value1;
					otherProperties.Value2 = heritage.Value2;
					otherProperties.Value3 = heritage.Value3;
					otherProperties.DeadIsOwner = heritage.DeadIsOwner;
					otherProperties.IsDiagonesed = heritage.IsDiagonesed;
					listOtherProperties.Add(otherProperties);
				}
			}
		}

		return listOtherProperties;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersOtherProperties = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("OtherProperties_Exists", CommandType.StoredProcedure, parametersOtherProperties)>0);
	}

	public bool Exists(OtherProperties otherProperties)
	{
		SqlParameter[] parametersOtherProperties = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", otherProperties.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("OtherProperties_Exists", CommandType.StoredProcedure, parametersOtherProperties)>0);
	}

	public List<OtherProperties> SearchLike(OtherProperties otherProperties)
	{
		List<OtherProperties> listOtherProperties = new List<OtherProperties>();


		SqlParameter[] parametersOtherProperties = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", otherProperties.HeritageID),
			new SqlParameter("@ProductionUnitID", otherProperties.ProductionUnitID),
			new SqlParameter("@Name", otherProperties.Name),
			new SqlParameter("@DeclarationID", otherProperties.DeclarationID),

			new SqlParameter("@StageTitle", otherProperties.StageTitle),
			new SqlParameter("@RegisterDate", otherProperties.RegisterDate),
			new SqlParameter("@OldRegisterDate", otherProperties.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", otherProperties.OldRegisterInformationID),
			new SqlParameter("@Sixth", otherProperties.Sixth),
			new SqlParameter("@PreviousOwner", otherProperties.PreviousOwner),
			new SqlParameter("@Comment", otherProperties.Comment),
			new SqlParameter("@RegisterInformationID", otherProperties.RegisterInformationID),
			new SqlParameter("@AdjustmentID", otherProperties.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", otherProperties.CommissionAdjustmentID),
			new SqlParameter("@Stage", otherProperties.Stage),
			new SqlParameter("@UserOrder", otherProperties.UserOrder),
			new SqlParameter("@Value1", otherProperties.Value1),
			new SqlParameter("@Value2", otherProperties.Value2),
			new SqlParameter("@Value3", otherProperties.Value3),
			new SqlParameter("@DeadIsOwner", otherProperties.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", otherProperties.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("OtherProperties_SearchLike", CommandType.StoredProcedure, parametersOtherProperties))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					OtherProperties tmpOtherProperties = new OtherProperties();
					tmpOtherProperties.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpOtherProperties.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					tmpOtherProperties.Name = row["Name"].ToString();
					tmpOtherProperties.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(tmpOtherProperties.HeritageID);
					tmpOtherProperties.HeritageID = heritage.HeritageID;
					tmpOtherProperties.StageTitle = heritage.StageTitle;
					tmpOtherProperties.RegisterDate = heritage.RegisterDate;
					tmpOtherProperties.OldRegisterDate = heritage.OldRegisterDate;
					tmpOtherProperties.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpOtherProperties.Sixth = heritage.Sixth;
					tmpOtherProperties.PreviousOwner = heritage.PreviousOwner;
					tmpOtherProperties.Comment = heritage.Comment;
					tmpOtherProperties.RegisterInformationID = heritage.RegisterInformationID;
					tmpOtherProperties.AdjustmentID = heritage.AdjustmentID;
					tmpOtherProperties.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpOtherProperties.Stage = heritage.Stage;
					tmpOtherProperties.UserOrder = heritage.UserOrder;
					tmpOtherProperties.Value1 = heritage.Value1;
					tmpOtherProperties.Value2 = heritage.Value2;
					tmpOtherProperties.Value3 = heritage.Value3;
					tmpOtherProperties.DeadIsOwner = heritage.DeadIsOwner;
					tmpOtherProperties.IsDiagonesed = heritage.IsDiagonesed;

					listOtherProperties.Add(tmpOtherProperties);
				}
			}
		}

		return listOtherProperties;
	}

}
}
