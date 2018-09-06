using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class MachineryDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(Machinery machinery)
	{
		if (!heritageDBAccess.Exists(machinery))
			machinery.HeritageID = heritageDBAccess.Insert(machinery);

		SqlParameter[] parametersMachinery = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (machinery.HeritageID > 0) ? machinery.HeritageID : (object)DBNull.Value),
			new SqlParameter("@ProductionUnitID", (machinery.ProductionUnitID > 0) ? machinery.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@Name", (machinery.Name != null) ? machinery.Name : (object)DBNull.Value),
			new SqlParameter("@Year", (machinery.Year != null) ? machinery.Year : (object)DBNull.Value),
			new SqlParameter("@Country", (machinery.Country != null) ? machinery.Country : (object)DBNull.Value),
			new SqlParameter("@Usage", (machinery.Usage != null) ? machinery.Usage : (object)DBNull.Value),
			new SqlParameter("@Number", (machinery.Number != null) ? machinery.Number : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (machinery.DeclarationID > 0) ? machinery.DeclarationID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("Machinery_Insert", CommandType.StoredProcedure, parametersMachinery);
	}

	public bool Update(Machinery machinery)
	{
		heritageDBAccess.Update(machinery);

		SqlParameter[] parametersMachinery = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", machinery.HeritageID),
			new SqlParameter("@ProductionUnitID", (machinery.ProductionUnitID != null && machinery.ProductionUnitID >0 ) ? machinery.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@Name", (machinery.Name != null) ? machinery.Name : (object)DBNull.Value),
			new SqlParameter("@Year", (machinery.Year != null) ? machinery.Year : (object)DBNull.Value),
			new SqlParameter("@Country", (machinery.Country != null) ? machinery.Country : (object)DBNull.Value),
			new SqlParameter("@Usage", (machinery.Usage != null) ? machinery.Usage : (object)DBNull.Value),
			new SqlParameter("@Number", (machinery.Number != null) ? machinery.Number : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", machinery.DeclarationID)
		};
		return SqlDBHelper.ExecuteNonQuery("Machinery_Update", CommandType.StoredProcedure, parametersMachinery);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersMachinery = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("Machinery_Delete", CommandType.StoredProcedure, parametersMachinery);
	}

	public Machinery GetDetails(Int64 heritageID)
	{
		Machinery machinery = new Machinery();

		SqlParameter[] parametersMachinery = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Machinery_GetDetails", CommandType.StoredProcedure, parametersMachinery))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				machinery.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				machinery.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
				machinery.Name = row["Name"].ToString();
				machinery.Year = row["Year"].ToString();
				machinery.Country = row["Country"].ToString();
				machinery.Usage = row["Usage"].ToString();
				machinery.Number = row["Number"].ToString();
				machinery.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

				Heritage heritage = heritageDBAccess.GetDetails(machinery.HeritageID);
				machinery.HeritageID = heritage.HeritageID;
				machinery.StageTitle = heritage.StageTitle;
				machinery.RegisterDate = heritage.RegisterDate;
				machinery.OldRegisterDate = heritage.OldRegisterDate;
				machinery.OldRegisterInformationID = heritage.OldRegisterInformationID;
				machinery.Sixth = heritage.Sixth;
				machinery.PreviousOwner = heritage.PreviousOwner;
				machinery.Comment = heritage.Comment;
				machinery.RegisterInformationID = heritage.RegisterInformationID;
				machinery.AdjustmentID = heritage.AdjustmentID;
				machinery.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				machinery.Stage = heritage.Stage;
				machinery.UserOrder = heritage.UserOrder;
				machinery.Value1 = heritage.Value1;
				machinery.Value2 = heritage.Value2;
				machinery.Value3 = heritage.Value3;
				machinery.DeadIsOwner = heritage.DeadIsOwner;
				machinery.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return machinery;
	}

	public List<Machinery> GetListAll()
	{
		List<Machinery> listMachinery = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Machinery_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listMachinery = new List<Machinery>();

				foreach (DataRow row in table.Rows)
				{
					Machinery machinery = new Machinery();
					machinery.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					machinery.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					machinery.Name = row["Name"].ToString();
					machinery.Year = row["Year"].ToString();
					machinery.Country = row["Country"].ToString();
					machinery.Usage = row["Usage"].ToString();
					machinery.Number = row["Number"].ToString();
					machinery.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(machinery.HeritageID);
					machinery.StageTitle = heritage.StageTitle;
					machinery.RegisterDate = heritage.RegisterDate;
					machinery.OldRegisterDate = heritage.OldRegisterDate;
					machinery.OldRegisterInformationID = heritage.OldRegisterInformationID;
					machinery.Sixth = heritage.Sixth;
					machinery.PreviousOwner = heritage.PreviousOwner;
					machinery.Comment = heritage.Comment;
					machinery.RegisterInformationID = heritage.RegisterInformationID;
					machinery.AdjustmentID = heritage.AdjustmentID;
					machinery.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					machinery.Stage = heritage.Stage;
					machinery.UserOrder = heritage.UserOrder;
					machinery.Value1 = heritage.Value1;
					machinery.Value2 = heritage.Value2;
					machinery.Value3 = heritage.Value3;
					machinery.DeadIsOwner = heritage.DeadIsOwner;
					machinery.IsDiagonesed = heritage.IsDiagonesed;
					listMachinery.Add(machinery);
				}
			}
		}

		return listMachinery;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersMachinery = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Machinery_Exists", CommandType.StoredProcedure, parametersMachinery)>0);
	}

	public bool Exists(Machinery machinery)
	{
		SqlParameter[] parametersMachinery = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", machinery.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Machinery_Exists", CommandType.StoredProcedure, parametersMachinery)>0);
	}

	public List<Machinery> SearchLike(Machinery machinery)
	{
		List<Machinery> listMachinery = new List<Machinery>();


		SqlParameter[] parametersMachinery = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", machinery.HeritageID),
			new SqlParameter("@ProductionUnitID", machinery.ProductionUnitID),
			new SqlParameter("@Name", machinery.Name),
			new SqlParameter("@Year", machinery.Year),
			new SqlParameter("@Country", machinery.Country),
			new SqlParameter("@Usage", machinery.Usage),
			new SqlParameter("@Number", machinery.Number),
			new SqlParameter("@DeclarationID", machinery.DeclarationID),

			new SqlParameter("@StageTitle", machinery.StageTitle),
			new SqlParameter("@RegisterDate", machinery.RegisterDate),
			new SqlParameter("@OldRegisterDate", machinery.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", machinery.OldRegisterInformationID),
			new SqlParameter("@Sixth", machinery.Sixth),
			new SqlParameter("@PreviousOwner", machinery.PreviousOwner),
			new SqlParameter("@Comment", machinery.Comment),
			new SqlParameter("@RegisterInformationID", machinery.RegisterInformationID),
			new SqlParameter("@AdjustmentID", machinery.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", machinery.CommissionAdjustmentID),
			new SqlParameter("@Stage", machinery.Stage),
			new SqlParameter("@UserOrder", machinery.UserOrder),
			new SqlParameter("@Value1", machinery.Value1),
			new SqlParameter("@Value2", machinery.Value2),
			new SqlParameter("@Value3", machinery.Value3),
			new SqlParameter("@DeadIsOwner", machinery.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", machinery.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Machinery_SearchLike", CommandType.StoredProcedure, parametersMachinery))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Machinery tmpMachinery = new Machinery();
					tmpMachinery.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpMachinery.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					tmpMachinery.Name = row["Name"].ToString();
					tmpMachinery.Year = row["Year"].ToString();
					tmpMachinery.Country = row["Country"].ToString();
					tmpMachinery.Usage = row["Usage"].ToString();
					tmpMachinery.Number = row["Number"].ToString();
					tmpMachinery.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(tmpMachinery.HeritageID);
					tmpMachinery.HeritageID = heritage.HeritageID;
					tmpMachinery.StageTitle = heritage.StageTitle;
					tmpMachinery.RegisterDate = heritage.RegisterDate;
					tmpMachinery.OldRegisterDate = heritage.OldRegisterDate;
					tmpMachinery.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpMachinery.Sixth = heritage.Sixth;
					tmpMachinery.PreviousOwner = heritage.PreviousOwner;
					tmpMachinery.Comment = heritage.Comment;
					tmpMachinery.RegisterInformationID = heritage.RegisterInformationID;
					tmpMachinery.AdjustmentID = heritage.AdjustmentID;
					tmpMachinery.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpMachinery.Stage = heritage.Stage;
					tmpMachinery.UserOrder = heritage.UserOrder;
					tmpMachinery.Value1 = heritage.Value1;
					tmpMachinery.Value2 = heritage.Value2;
					tmpMachinery.Value3 = heritage.Value3;
					tmpMachinery.DeadIsOwner = heritage.DeadIsOwner;
					tmpMachinery.IsDiagonesed = heritage.IsDiagonesed;

					listMachinery.Add(tmpMachinery);
				}
			}
		}

		return listMachinery;
	}

}
}
