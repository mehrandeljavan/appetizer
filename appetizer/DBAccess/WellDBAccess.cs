using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class WellDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(Well well)
	{
		if (!heritageDBAccess.Exists(well))
			well.HeritageID = heritageDBAccess.Insert(well);

		SqlParameter[] parametersWell = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (well.HeritageID > 0) ? well.HeritageID : (object)DBNull.Value),
			new SqlParameter("@WellTypeID", (well.WellTypeID > 0) ? well.WellTypeID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (well.DeclarationID > 0) ? well.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@ProductionUnitID", (well.ProductionUnitID > 0) ? well.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@Plaque", well.Plaque),
			new SqlParameter("@Scope", well.Scope),
			new SqlParameter("@DocNo", well.DocNo)
		};
		return SqlDBHelper.ExecuteScalar("Well_Insert", CommandType.StoredProcedure, parametersWell);
	}

	public bool Update(Well well)
	{
		heritageDBAccess.Update(well);

		SqlParameter[] parametersWell = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", well.HeritageID),
			new SqlParameter("@WellTypeID", (well.WellTypeID != null && well.WellTypeID >0 ) ? well.WellTypeID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", well.DeclarationID),
			new SqlParameter("@ProductionUnitID", (well.ProductionUnitID != null && well.ProductionUnitID >0 ) ? well.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@Plaque", well.Plaque),
			new SqlParameter("@Scope", well.Scope),
			new SqlParameter("@DocNo", well.DocNo)
		};
		return SqlDBHelper.ExecuteNonQuery("Well_Update", CommandType.StoredProcedure, parametersWell);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersWell = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("Well_Delete", CommandType.StoredProcedure, parametersWell);
	}

	public Well GetDetails(Int64 heritageID)
	{
		Well well = new Well();

		SqlParameter[] parametersWell = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Well_GetDetails", CommandType.StoredProcedure, parametersWell))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				well.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				well.WellTypeIDTitle = row["WellTypeIDTitle"].ToString();
				well.WellTypeID = (row["WellTypeID"] != DBNull.Value) ? Convert.ToInt32(row["WellTypeID"]) : 0 ;
				well.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				well.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
				well.Plaque = row["Plaque"].ToString();
				well.Scope = row["Scope"].ToString();
				well.DocNo = row["DocNo"].ToString();

				Heritage heritage = heritageDBAccess.GetDetails(well.HeritageID);
				well.HeritageID = heritage.HeritageID;
				well.StageTitle = heritage.StageTitle;
				well.RegisterDate = heritage.RegisterDate;
				well.OldRegisterDate = heritage.OldRegisterDate;
				well.OldRegisterInformationID = heritage.OldRegisterInformationID;
				well.Sixth = heritage.Sixth;
				well.PreviousOwner = heritage.PreviousOwner;
				well.Comment = heritage.Comment;
				well.RegisterInformationID = heritage.RegisterInformationID;
				well.AdjustmentID = heritage.AdjustmentID;
				well.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				well.Stage = heritage.Stage;
				well.UserOrder = heritage.UserOrder;
				well.Value1 = heritage.Value1;
				well.Value2 = heritage.Value2;
				well.Value3 = heritage.Value3;
				well.DeadIsOwner = heritage.DeadIsOwner;
				well.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return well;
	}

	public List<Well> GetListAll()
	{
		List<Well> listWell = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Well_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listWell = new List<Well>();

				foreach (DataRow row in table.Rows)
				{
					Well well = new Well();
					well.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					well.WellTypeIDTitle = row["WellTypeIDTitle"].ToString();
					well.WellTypeID = (row["WellTypeID"] != DBNull.Value) ? Convert.ToInt32(row["WellTypeID"]) : 0 ;
					well.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					well.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					well.Plaque = row["Plaque"].ToString();
					well.Scope = row["Scope"].ToString();
					well.DocNo = row["DocNo"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(well.HeritageID);
					well.StageTitle = heritage.StageTitle;
					well.RegisterDate = heritage.RegisterDate;
					well.OldRegisterDate = heritage.OldRegisterDate;
					well.OldRegisterInformationID = heritage.OldRegisterInformationID;
					well.Sixth = heritage.Sixth;
					well.PreviousOwner = heritage.PreviousOwner;
					well.Comment = heritage.Comment;
					well.RegisterInformationID = heritage.RegisterInformationID;
					well.AdjustmentID = heritage.AdjustmentID;
					well.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					well.Stage = heritage.Stage;
					well.UserOrder = heritage.UserOrder;
					well.Value1 = heritage.Value1;
					well.Value2 = heritage.Value2;
					well.Value3 = heritage.Value3;
					well.DeadIsOwner = heritage.DeadIsOwner;
					well.IsDiagonesed = heritage.IsDiagonesed;
					listWell.Add(well);
				}
			}
		}

		return listWell;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersWell = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Well_Exists", CommandType.StoredProcedure, parametersWell)>0);
	}

	public bool Exists(Well well)
	{
		SqlParameter[] parametersWell = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", well.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Well_Exists", CommandType.StoredProcedure, parametersWell)>0);
	}

	public List<Well> SearchLike(Well well)
	{
		List<Well> listWell = new List<Well>();


		SqlParameter[] parametersWell = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", well.HeritageID),
			new SqlParameter("@WellTypeIDTitle", well.WellTypeIDTitle),
			new SqlParameter("@WellTypeID", well.WellTypeID),
			new SqlParameter("@DeclarationID", well.DeclarationID),
			new SqlParameter("@ProductionUnitID", well.ProductionUnitID),
			new SqlParameter("@Plaque", well.Plaque),
			new SqlParameter("@Scope", well.Scope),
			new SqlParameter("@DocNo", well.DocNo),

			new SqlParameter("@StageTitle", well.StageTitle),
			new SqlParameter("@RegisterDate", well.RegisterDate),
			new SqlParameter("@OldRegisterDate", well.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", well.OldRegisterInformationID),
			new SqlParameter("@Sixth", well.Sixth),
			new SqlParameter("@PreviousOwner", well.PreviousOwner),
			new SqlParameter("@Comment", well.Comment),
			new SqlParameter("@RegisterInformationID", well.RegisterInformationID),
			new SqlParameter("@AdjustmentID", well.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", well.CommissionAdjustmentID),
			new SqlParameter("@Stage", well.Stage),
			new SqlParameter("@UserOrder", well.UserOrder),
			new SqlParameter("@Value1", well.Value1),
			new SqlParameter("@Value2", well.Value2),
			new SqlParameter("@Value3", well.Value3),
			new SqlParameter("@DeadIsOwner", well.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", well.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Well_SearchLike", CommandType.StoredProcedure, parametersWell))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Well tmpWell = new Well();
					tmpWell.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpWell.WellTypeIDTitle = row["WellTypeIDTitle"].ToString();
					tmpWell.WellTypeID = (row["WellTypeID"] != DBNull.Value) ? Convert.ToInt32(row["WellTypeID"]) : 0 ;
					tmpWell.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpWell.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					tmpWell.Plaque = row["Plaque"].ToString();
					tmpWell.Scope = row["Scope"].ToString();
					tmpWell.DocNo = row["DocNo"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(tmpWell.HeritageID);
					tmpWell.HeritageID = heritage.HeritageID;
					tmpWell.StageTitle = heritage.StageTitle;
					tmpWell.RegisterDate = heritage.RegisterDate;
					tmpWell.OldRegisterDate = heritage.OldRegisterDate;
					tmpWell.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpWell.Sixth = heritage.Sixth;
					tmpWell.PreviousOwner = heritage.PreviousOwner;
					tmpWell.Comment = heritage.Comment;
					tmpWell.RegisterInformationID = heritage.RegisterInformationID;
					tmpWell.AdjustmentID = heritage.AdjustmentID;
					tmpWell.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpWell.Stage = heritage.Stage;
					tmpWell.UserOrder = heritage.UserOrder;
					tmpWell.Value1 = heritage.Value1;
					tmpWell.Value2 = heritage.Value2;
					tmpWell.Value3 = heritage.Value3;
					tmpWell.DeadIsOwner = heritage.DeadIsOwner;
					tmpWell.IsDiagonesed = heritage.IsDiagonesed;

					listWell.Add(tmpWell);
				}
			}
		}

		return listWell;
	}

}
}
