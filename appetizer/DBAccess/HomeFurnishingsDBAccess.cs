using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class HomeFurnishingsDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(HomeFurnishings homeFurnishings)
	{
		if (!heritageDBAccess.Exists(homeFurnishings))
			homeFurnishings.HeritageID = heritageDBAccess.Insert(homeFurnishings);

		SqlParameter[] parametersHomeFurnishings = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (homeFurnishings.HeritageID > 0) ? homeFurnishings.HeritageID : (object)DBNull.Value),
			new SqlParameter("@Title", homeFurnishings.Title),
			new SqlParameter("@DeclarationID", (homeFurnishings.DeclarationID > 0) ? homeFurnishings.DeclarationID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("HomeFurnishings_Insert", CommandType.StoredProcedure, parametersHomeFurnishings);
	}

	public bool Update(HomeFurnishings homeFurnishings)
	{
		heritageDBAccess.Update(homeFurnishings);

		SqlParameter[] parametersHomeFurnishings = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", homeFurnishings.HeritageID),
			new SqlParameter("@Title", homeFurnishings.Title),
			new SqlParameter("@DeclarationID", homeFurnishings.DeclarationID)
		};
		return SqlDBHelper.ExecuteNonQuery("HomeFurnishings_Update", CommandType.StoredProcedure, parametersHomeFurnishings);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersHomeFurnishings = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("HomeFurnishings_Delete", CommandType.StoredProcedure, parametersHomeFurnishings);
	}

	public HomeFurnishings GetDetails(Int64 heritageID)
	{
		HomeFurnishings homeFurnishings = new HomeFurnishings();

		SqlParameter[] parametersHomeFurnishings = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("HomeFurnishings_GetDetails", CommandType.StoredProcedure, parametersHomeFurnishings))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				homeFurnishings.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				homeFurnishings.Title = row["Title"].ToString();
				homeFurnishings.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

				Heritage heritage = heritageDBAccess.GetDetails(homeFurnishings.HeritageID);
				homeFurnishings.HeritageID = heritage.HeritageID;
				homeFurnishings.StageTitle = heritage.StageTitle;
				homeFurnishings.RegisterDate = heritage.RegisterDate;
				homeFurnishings.OldRegisterDate = heritage.OldRegisterDate;
				homeFurnishings.OldRegisterInformationID = heritage.OldRegisterInformationID;
				homeFurnishings.Sixth = heritage.Sixth;
				homeFurnishings.PreviousOwner = heritage.PreviousOwner;
				homeFurnishings.Comment = heritage.Comment;
				homeFurnishings.RegisterInformationID = heritage.RegisterInformationID;
				homeFurnishings.AdjustmentID = heritage.AdjustmentID;
				homeFurnishings.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				homeFurnishings.Stage = heritage.Stage;
				homeFurnishings.UserOrder = heritage.UserOrder;
				homeFurnishings.Value1 = heritage.Value1;
				homeFurnishings.Value2 = heritage.Value2;
				homeFurnishings.Value3 = heritage.Value3;
				homeFurnishings.DeadIsOwner = heritage.DeadIsOwner;
				homeFurnishings.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return homeFurnishings;
	}

	public List<HomeFurnishings> GetListAll()
	{
		List<HomeFurnishings> listHomeFurnishings = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("HomeFurnishings_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listHomeFurnishings = new List<HomeFurnishings>();

				foreach (DataRow row in table.Rows)
				{
					HomeFurnishings homeFurnishings = new HomeFurnishings();
					homeFurnishings.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					homeFurnishings.Title = row["Title"].ToString();
					homeFurnishings.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(homeFurnishings.HeritageID);
					homeFurnishings.StageTitle = heritage.StageTitle;
					homeFurnishings.RegisterDate = heritage.RegisterDate;
					homeFurnishings.OldRegisterDate = heritage.OldRegisterDate;
					homeFurnishings.OldRegisterInformationID = heritage.OldRegisterInformationID;
					homeFurnishings.Sixth = heritage.Sixth;
					homeFurnishings.PreviousOwner = heritage.PreviousOwner;
					homeFurnishings.Comment = heritage.Comment;
					homeFurnishings.RegisterInformationID = heritage.RegisterInformationID;
					homeFurnishings.AdjustmentID = heritage.AdjustmentID;
					homeFurnishings.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					homeFurnishings.Stage = heritage.Stage;
					homeFurnishings.UserOrder = heritage.UserOrder;
					homeFurnishings.Value1 = heritage.Value1;
					homeFurnishings.Value2 = heritage.Value2;
					homeFurnishings.Value3 = heritage.Value3;
					homeFurnishings.DeadIsOwner = heritage.DeadIsOwner;
					homeFurnishings.IsDiagonesed = heritage.IsDiagonesed;
					listHomeFurnishings.Add(homeFurnishings);
				}
			}
		}

		return listHomeFurnishings;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersHomeFurnishings = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("HomeFurnishings_Exists", CommandType.StoredProcedure, parametersHomeFurnishings)>0);
	}

	public bool Exists(HomeFurnishings homeFurnishings)
	{
		SqlParameter[] parametersHomeFurnishings = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", homeFurnishings.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("HomeFurnishings_Exists", CommandType.StoredProcedure, parametersHomeFurnishings)>0);
	}

	public List<HomeFurnishings> SearchLike(HomeFurnishings homeFurnishings)
	{
		List<HomeFurnishings> listHomeFurnishings = new List<HomeFurnishings>();


		SqlParameter[] parametersHomeFurnishings = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", homeFurnishings.HeritageID),
			new SqlParameter("@Title", homeFurnishings.Title),
			new SqlParameter("@DeclarationID", homeFurnishings.DeclarationID),

			new SqlParameter("@StageTitle", homeFurnishings.StageTitle),
			new SqlParameter("@RegisterDate", homeFurnishings.RegisterDate),
			new SqlParameter("@OldRegisterDate", homeFurnishings.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", homeFurnishings.OldRegisterInformationID),
			new SqlParameter("@Sixth", homeFurnishings.Sixth),
			new SqlParameter("@PreviousOwner", homeFurnishings.PreviousOwner),
			new SqlParameter("@Comment", homeFurnishings.Comment),
			new SqlParameter("@RegisterInformationID", homeFurnishings.RegisterInformationID),
			new SqlParameter("@AdjustmentID", homeFurnishings.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", homeFurnishings.CommissionAdjustmentID),
			new SqlParameter("@Stage", homeFurnishings.Stage),
			new SqlParameter("@UserOrder", homeFurnishings.UserOrder),
			new SqlParameter("@Value1", homeFurnishings.Value1),
			new SqlParameter("@Value2", homeFurnishings.Value2),
			new SqlParameter("@Value3", homeFurnishings.Value3),
			new SqlParameter("@DeadIsOwner", homeFurnishings.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", homeFurnishings.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("HomeFurnishings_SearchLike", CommandType.StoredProcedure, parametersHomeFurnishings))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					HomeFurnishings tmpHomeFurnishings = new HomeFurnishings();
					tmpHomeFurnishings.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpHomeFurnishings.Title = row["Title"].ToString();
					tmpHomeFurnishings.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(tmpHomeFurnishings.HeritageID);
					tmpHomeFurnishings.HeritageID = heritage.HeritageID;
					tmpHomeFurnishings.StageTitle = heritage.StageTitle;
					tmpHomeFurnishings.RegisterDate = heritage.RegisterDate;
					tmpHomeFurnishings.OldRegisterDate = heritage.OldRegisterDate;
					tmpHomeFurnishings.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpHomeFurnishings.Sixth = heritage.Sixth;
					tmpHomeFurnishings.PreviousOwner = heritage.PreviousOwner;
					tmpHomeFurnishings.Comment = heritage.Comment;
					tmpHomeFurnishings.RegisterInformationID = heritage.RegisterInformationID;
					tmpHomeFurnishings.AdjustmentID = heritage.AdjustmentID;
					tmpHomeFurnishings.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpHomeFurnishings.Stage = heritage.Stage;
					tmpHomeFurnishings.UserOrder = heritage.UserOrder;
					tmpHomeFurnishings.Value1 = heritage.Value1;
					tmpHomeFurnishings.Value2 = heritage.Value2;
					tmpHomeFurnishings.Value3 = heritage.Value3;
					tmpHomeFurnishings.DeadIsOwner = heritage.DeadIsOwner;
					tmpHomeFurnishings.IsDiagonesed = heritage.IsDiagonesed;

					listHomeFurnishings.Add(tmpHomeFurnishings);
				}
			}
		}

		return listHomeFurnishings;
	}

}
}
