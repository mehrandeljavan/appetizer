using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class HajjDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(Hajj hajj)
	{
		if (!heritageDBAccess.Exists(hajj))
			hajj.HeritageID = heritageDBAccess.Insert(hajj);

		SqlParameter[] parametersHajj = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (hajj.HeritageID > 0) ? hajj.HeritageID : (object)DBNull.Value),
			new SqlParameter("@FactorDate", hajj.FactorDate),
			new SqlParameter("@FactorNumber", hajj.FactorNumber),
			new SqlParameter("@HajjTypeID", (hajj.HajjTypeID > 0) ? hajj.HajjTypeID : (object)DBNull.Value),
			new SqlParameter("@BankInquiryHajjID", (hajj.BankInquiryHajjID > 0) ? hajj.BankInquiryHajjID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (hajj.DeclarationID > 0) ? hajj.DeclarationID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("Hajj_Insert", CommandType.StoredProcedure, parametersHajj);
	}

	public bool Update(Hajj hajj)
	{
		heritageDBAccess.Update(hajj);

		SqlParameter[] parametersHajj = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", hajj.HeritageID),
			new SqlParameter("@FactorDate", hajj.FactorDate),
			new SqlParameter("@FactorNumber", hajj.FactorNumber),
			new SqlParameter("@HajjTypeID", (hajj.HajjTypeID != null && hajj.HajjTypeID >0 ) ? hajj.HajjTypeID : (object)DBNull.Value),
			new SqlParameter("@BankInquiryHajjID", (hajj.BankInquiryHajjID != null && hajj.BankInquiryHajjID >0 ) ? hajj.BankInquiryHajjID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", hajj.DeclarationID)
		};
		return SqlDBHelper.ExecuteNonQuery("Hajj_Update", CommandType.StoredProcedure, parametersHajj);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersHajj = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("Hajj_Delete", CommandType.StoredProcedure, parametersHajj);
	}

	public Hajj GetDetails(Int64 heritageID)
	{
		Hajj hajj = new Hajj();

		SqlParameter[] parametersHajj = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Hajj_GetDetails", CommandType.StoredProcedure, parametersHajj))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				hajj.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				hajj.HajjTypeIDTitle = row["HajjTypeIDTitle"].ToString();
				hajj.BankInquiryHajjIDTitle = row["BankInquiryHajjIDTitle"].ToString();
				hajj.FactorDate = row["FactorDate"].ToString();
				hajj.FactorNumber = row["FactorNumber"].ToString();
				hajj.HajjTypeID = (row["HajjTypeID"] != DBNull.Value) ? Convert.ToInt32(row["HajjTypeID"]) : 0 ;
				hajj.BankInquiryHajjID = (row["BankInquiryHajjID"] != DBNull.Value) ? Convert.ToInt32(row["BankInquiryHajjID"]) : 0 ;
				hajj.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

				Heritage heritage = heritageDBAccess.GetDetails(hajj.HeritageID);
				hajj.HeritageID = heritage.HeritageID;
				hajj.StageTitle = heritage.StageTitle;
				hajj.RegisterDate = heritage.RegisterDate;
				hajj.OldRegisterDate = heritage.OldRegisterDate;
				hajj.OldRegisterInformationID = heritage.OldRegisterInformationID;
				hajj.Sixth = heritage.Sixth;
				hajj.PreviousOwner = heritage.PreviousOwner;
				hajj.Comment = heritage.Comment;
				hajj.RegisterInformationID = heritage.RegisterInformationID;
				hajj.AdjustmentID = heritage.AdjustmentID;
				hajj.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				hajj.Stage = heritage.Stage;
				hajj.UserOrder = heritage.UserOrder;
				hajj.Value1 = heritage.Value1;
				hajj.Value2 = heritage.Value2;
				hajj.Value3 = heritage.Value3;
				hajj.DeadIsOwner = heritage.DeadIsOwner;
				hajj.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return hajj;
	}

	public List<Hajj> GetListAll()
	{
		List<Hajj> listHajj = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Hajj_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listHajj = new List<Hajj>();

				foreach (DataRow row in table.Rows)
				{
					Hajj hajj = new Hajj();
					hajj.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					hajj.HajjTypeIDTitle = row["HajjTypeIDTitle"].ToString();
					hajj.BankInquiryHajjIDTitle = row["BankInquiryHajjIDTitle"].ToString();
					hajj.FactorDate = row["FactorDate"].ToString();
					hajj.FactorNumber = row["FactorNumber"].ToString();
					hajj.HajjTypeID = (row["HajjTypeID"] != DBNull.Value) ? Convert.ToInt32(row["HajjTypeID"]) : 0 ;
					hajj.BankInquiryHajjID = (row["BankInquiryHajjID"] != DBNull.Value) ? Convert.ToInt32(row["BankInquiryHajjID"]) : 0 ;
					hajj.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(hajj.HeritageID);
					hajj.StageTitle = heritage.StageTitle;
					hajj.RegisterDate = heritage.RegisterDate;
					hajj.OldRegisterDate = heritage.OldRegisterDate;
					hajj.OldRegisterInformationID = heritage.OldRegisterInformationID;
					hajj.Sixth = heritage.Sixth;
					hajj.PreviousOwner = heritage.PreviousOwner;
					hajj.Comment = heritage.Comment;
					hajj.RegisterInformationID = heritage.RegisterInformationID;
					hajj.AdjustmentID = heritage.AdjustmentID;
					hajj.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					hajj.Stage = heritage.Stage;
					hajj.UserOrder = heritage.UserOrder;
					hajj.Value1 = heritage.Value1;
					hajj.Value2 = heritage.Value2;
					hajj.Value3 = heritage.Value3;
					hajj.DeadIsOwner = heritage.DeadIsOwner;
					hajj.IsDiagonesed = heritage.IsDiagonesed;
					listHajj.Add(hajj);
				}
			}
		}

		return listHajj;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersHajj = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Hajj_Exists", CommandType.StoredProcedure, parametersHajj)>0);
	}

	public bool Exists(Hajj hajj)
	{
		SqlParameter[] parametersHajj = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", hajj.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Hajj_Exists", CommandType.StoredProcedure, parametersHajj)>0);
	}

	public List<Hajj> SearchLike(Hajj hajj)
	{
		List<Hajj> listHajj = new List<Hajj>();


		SqlParameter[] parametersHajj = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", hajj.HeritageID),
			new SqlParameter("@HajjTypeIDTitle", hajj.HajjTypeIDTitle),
			new SqlParameter("@BankInquiryHajjIDTitle", hajj.BankInquiryHajjIDTitle),
			new SqlParameter("@FactorDate", hajj.FactorDate),
			new SqlParameter("@FactorNumber", hajj.FactorNumber),
			new SqlParameter("@HajjTypeID", hajj.HajjTypeID),
			new SqlParameter("@BankInquiryHajjID", hajj.BankInquiryHajjID),
			new SqlParameter("@DeclarationID", hajj.DeclarationID),

			new SqlParameter("@StageTitle", hajj.StageTitle),
			new SqlParameter("@RegisterDate", hajj.RegisterDate),
			new SqlParameter("@OldRegisterDate", hajj.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", hajj.OldRegisterInformationID),
			new SqlParameter("@Sixth", hajj.Sixth),
			new SqlParameter("@PreviousOwner", hajj.PreviousOwner),
			new SqlParameter("@Comment", hajj.Comment),
			new SqlParameter("@RegisterInformationID", hajj.RegisterInformationID),
			new SqlParameter("@AdjustmentID", hajj.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", hajj.CommissionAdjustmentID),
			new SqlParameter("@Stage", hajj.Stage),
			new SqlParameter("@UserOrder", hajj.UserOrder),
			new SqlParameter("@Value1", hajj.Value1),
			new SqlParameter("@Value2", hajj.Value2),
			new SqlParameter("@Value3", hajj.Value3),
			new SqlParameter("@DeadIsOwner", hajj.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", hajj.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Hajj_SearchLike", CommandType.StoredProcedure, parametersHajj))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Hajj tmpHajj = new Hajj();
					tmpHajj.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpHajj.HajjTypeIDTitle = row["HajjTypeIDTitle"].ToString();
					tmpHajj.BankInquiryHajjIDTitle = row["BankInquiryHajjIDTitle"].ToString();
					tmpHajj.FactorDate = row["FactorDate"].ToString();
					tmpHajj.FactorNumber = row["FactorNumber"].ToString();
					tmpHajj.HajjTypeID = (row["HajjTypeID"] != DBNull.Value) ? Convert.ToInt32(row["HajjTypeID"]) : 0 ;
					tmpHajj.BankInquiryHajjID = (row["BankInquiryHajjID"] != DBNull.Value) ? Convert.ToInt32(row["BankInquiryHajjID"]) : 0 ;
					tmpHajj.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(tmpHajj.HeritageID);
					tmpHajj.HeritageID = heritage.HeritageID;
					tmpHajj.StageTitle = heritage.StageTitle;
					tmpHajj.RegisterDate = heritage.RegisterDate;
					tmpHajj.OldRegisterDate = heritage.OldRegisterDate;
					tmpHajj.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpHajj.Sixth = heritage.Sixth;
					tmpHajj.PreviousOwner = heritage.PreviousOwner;
					tmpHajj.Comment = heritage.Comment;
					tmpHajj.RegisterInformationID = heritage.RegisterInformationID;
					tmpHajj.AdjustmentID = heritage.AdjustmentID;
					tmpHajj.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpHajj.Stage = heritage.Stage;
					tmpHajj.UserOrder = heritage.UserOrder;
					tmpHajj.Value1 = heritage.Value1;
					tmpHajj.Value2 = heritage.Value2;
					tmpHajj.Value3 = heritage.Value3;
					tmpHajj.DeadIsOwner = heritage.DeadIsOwner;
					tmpHajj.IsDiagonesed = heritage.IsDiagonesed;

					listHajj.Add(tmpHajj);
				}
			}
		}

		return listHajj;
	}

}
}
