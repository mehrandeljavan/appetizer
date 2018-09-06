using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class JewelDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(Jewel jewel)
	{
		if (!heritageDBAccess.Exists(jewel))
			jewel.HeritageID = heritageDBAccess.Insert(jewel);

		SqlParameter[] parametersJewel = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (jewel.HeritageID > 0) ? jewel.HeritageID : (object)DBNull.Value),
			new SqlParameter("@Name", jewel.Name),
			new SqlParameter("@Weight", (jewel.Weight != null) ? jewel.Weight : (object)DBNull.Value),
			new SqlParameter("@FactorNumber", jewel.FactorNumber),
			new SqlParameter("@Place", (jewel.Place != null) ? jewel.Place : (object)DBNull.Value),
			new SqlParameter("@Number", (jewel.Number != null) ? jewel.Number : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (jewel.DeclarationID > 0) ? jewel.DeclarationID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("Jewel_Insert", CommandType.StoredProcedure, parametersJewel);
	}

	public bool Update(Jewel jewel)
	{
		heritageDBAccess.Update(jewel);

		SqlParameter[] parametersJewel = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", jewel.HeritageID),
			new SqlParameter("@Name", jewel.Name),
			new SqlParameter("@Weight", (jewel.Weight != null) ? jewel.Weight : (object)DBNull.Value),
			new SqlParameter("@FactorNumber", jewel.FactorNumber),
			new SqlParameter("@Place", (jewel.Place != null) ? jewel.Place : (object)DBNull.Value),
			new SqlParameter("@Number", (jewel.Number != null) ? jewel.Number : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", jewel.DeclarationID)
		};
		return SqlDBHelper.ExecuteNonQuery("Jewel_Update", CommandType.StoredProcedure, parametersJewel);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersJewel = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("Jewel_Delete", CommandType.StoredProcedure, parametersJewel);
	}

	public Jewel GetDetails(Int64 heritageID)
	{
		Jewel jewel = new Jewel();

		SqlParameter[] parametersJewel = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Jewel_GetDetails", CommandType.StoredProcedure, parametersJewel))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				jewel.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				jewel.Name = row["Name"].ToString();
				jewel.Weight = row["Weight"].ToString();
				jewel.FactorNumber = row["FactorNumber"].ToString();
				jewel.Place = row["Place"].ToString();
				jewel.Number = (row["Number"] != DBNull.Value) ? Convert.ToInt32(row["Number"]) : 0 ;
				jewel.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

				Heritage heritage = heritageDBAccess.GetDetails(jewel.HeritageID);
				jewel.HeritageID = heritage.HeritageID;
				jewel.StageTitle = heritage.StageTitle;
				jewel.RegisterDate = heritage.RegisterDate;
				jewel.OldRegisterDate = heritage.OldRegisterDate;
				jewel.OldRegisterInformationID = heritage.OldRegisterInformationID;
				jewel.Sixth = heritage.Sixth;
				jewel.PreviousOwner = heritage.PreviousOwner;
				jewel.Comment = heritage.Comment;
				jewel.RegisterInformationID = heritage.RegisterInformationID;
				jewel.AdjustmentID = heritage.AdjustmentID;
				jewel.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				jewel.Stage = heritage.Stage;
				jewel.UserOrder = heritage.UserOrder;
				jewel.Value1 = heritage.Value1;
				jewel.Value2 = heritage.Value2;
				jewel.Value3 = heritage.Value3;
				jewel.DeadIsOwner = heritage.DeadIsOwner;
				jewel.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return jewel;
	}

	public List<Jewel> GetListAll()
	{
		List<Jewel> listJewel = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Jewel_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listJewel = new List<Jewel>();

				foreach (DataRow row in table.Rows)
				{
					Jewel jewel = new Jewel();
					jewel.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					jewel.Name = row["Name"].ToString();
					jewel.Weight = row["Weight"].ToString();
					jewel.FactorNumber = row["FactorNumber"].ToString();
					jewel.Place = row["Place"].ToString();
					jewel.Number = (row["Number"] != DBNull.Value) ? Convert.ToInt32(row["Number"]) : 0 ;
					jewel.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(jewel.HeritageID);
					jewel.StageTitle = heritage.StageTitle;
					jewel.RegisterDate = heritage.RegisterDate;
					jewel.OldRegisterDate = heritage.OldRegisterDate;
					jewel.OldRegisterInformationID = heritage.OldRegisterInformationID;
					jewel.Sixth = heritage.Sixth;
					jewel.PreviousOwner = heritage.PreviousOwner;
					jewel.Comment = heritage.Comment;
					jewel.RegisterInformationID = heritage.RegisterInformationID;
					jewel.AdjustmentID = heritage.AdjustmentID;
					jewel.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					jewel.Stage = heritage.Stage;
					jewel.UserOrder = heritage.UserOrder;
					jewel.Value1 = heritage.Value1;
					jewel.Value2 = heritage.Value2;
					jewel.Value3 = heritage.Value3;
					jewel.DeadIsOwner = heritage.DeadIsOwner;
					jewel.IsDiagonesed = heritage.IsDiagonesed;
					listJewel.Add(jewel);
				}
			}
		}

		return listJewel;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersJewel = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Jewel_Exists", CommandType.StoredProcedure, parametersJewel)>0);
	}

	public bool Exists(Jewel jewel)
	{
		SqlParameter[] parametersJewel = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", jewel.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Jewel_Exists", CommandType.StoredProcedure, parametersJewel)>0);
	}

	public List<Jewel> SearchLike(Jewel jewel)
	{
		List<Jewel> listJewel = new List<Jewel>();


		SqlParameter[] parametersJewel = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", jewel.HeritageID),
			new SqlParameter("@Name", jewel.Name),
			new SqlParameter("@Weight", jewel.Weight),
			new SqlParameter("@FactorNumber", jewel.FactorNumber),
			new SqlParameter("@Place", jewel.Place),
			new SqlParameter("@Number", jewel.Number),
			new SqlParameter("@DeclarationID", jewel.DeclarationID),

			new SqlParameter("@StageTitle", jewel.StageTitle),
			new SqlParameter("@RegisterDate", jewel.RegisterDate),
			new SqlParameter("@OldRegisterDate", jewel.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", jewel.OldRegisterInformationID),
			new SqlParameter("@Sixth", jewel.Sixth),
			new SqlParameter("@PreviousOwner", jewel.PreviousOwner),
			new SqlParameter("@Comment", jewel.Comment),
			new SqlParameter("@RegisterInformationID", jewel.RegisterInformationID),
			new SqlParameter("@AdjustmentID", jewel.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", jewel.CommissionAdjustmentID),
			new SqlParameter("@Stage", jewel.Stage),
			new SqlParameter("@UserOrder", jewel.UserOrder),
			new SqlParameter("@Value1", jewel.Value1),
			new SqlParameter("@Value2", jewel.Value2),
			new SqlParameter("@Value3", jewel.Value3),
			new SqlParameter("@DeadIsOwner", jewel.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", jewel.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Jewel_SearchLike", CommandType.StoredProcedure, parametersJewel))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Jewel tmpJewel = new Jewel();
					tmpJewel.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpJewel.Name = row["Name"].ToString();
					tmpJewel.Weight = row["Weight"].ToString();
					tmpJewel.FactorNumber = row["FactorNumber"].ToString();
					tmpJewel.Place = row["Place"].ToString();
					tmpJewel.Number = (row["Number"] != DBNull.Value) ? Convert.ToInt32(row["Number"]) : 0 ;
					tmpJewel.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(tmpJewel.HeritageID);
					tmpJewel.HeritageID = heritage.HeritageID;
					tmpJewel.StageTitle = heritage.StageTitle;
					tmpJewel.RegisterDate = heritage.RegisterDate;
					tmpJewel.OldRegisterDate = heritage.OldRegisterDate;
					tmpJewel.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpJewel.Sixth = heritage.Sixth;
					tmpJewel.PreviousOwner = heritage.PreviousOwner;
					tmpJewel.Comment = heritage.Comment;
					tmpJewel.RegisterInformationID = heritage.RegisterInformationID;
					tmpJewel.AdjustmentID = heritage.AdjustmentID;
					tmpJewel.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpJewel.Stage = heritage.Stage;
					tmpJewel.UserOrder = heritage.UserOrder;
					tmpJewel.Value1 = heritage.Value1;
					tmpJewel.Value2 = heritage.Value2;
					tmpJewel.Value3 = heritage.Value3;
					tmpJewel.DeadIsOwner = heritage.DeadIsOwner;
					tmpJewel.IsDiagonesed = heritage.IsDiagonesed;

					listJewel.Add(tmpJewel);
				}
			}
		}

		return listJewel;
	}

}
}
