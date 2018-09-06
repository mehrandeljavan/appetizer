using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class PartnershipPapersDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(PartnershipPapers partnershipPapers)
	{
		if (!heritageDBAccess.Exists(partnershipPapers))
			partnershipPapers.HeritageID = heritageDBAccess.Insert(partnershipPapers);

		SqlParameter[] parametersPartnershipPapers = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (partnershipPapers.HeritageID > 0) ? partnershipPapers.HeritageID : (object)DBNull.Value),
			new SqlParameter("@PartnershipPaperTypeID", (partnershipPapers.PartnershipPaperTypeID > 0) ? partnershipPapers.PartnershipPaperTypeID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (partnershipPapers.DeclarationID > 0) ? partnershipPapers.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@ProjectName", partnershipPapers.ProjectName),
			new SqlParameter("@SellerName", partnershipPapers.SellerName),
			new SqlParameter("@PaperNumber", partnershipPapers.PaperNumber)
		};
		return SqlDBHelper.ExecuteScalar("PartnershipPapers_Insert", CommandType.StoredProcedure, parametersPartnershipPapers);
	}

	public bool Update(PartnershipPapers partnershipPapers)
	{
		heritageDBAccess.Update(partnershipPapers);

		SqlParameter[] parametersPartnershipPapers = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", partnershipPapers.HeritageID),
			new SqlParameter("@PartnershipPaperTypeID", partnershipPapers.PartnershipPaperTypeID),
			new SqlParameter("@DeclarationID", partnershipPapers.DeclarationID),
			new SqlParameter("@ProjectName", partnershipPapers.ProjectName),
			new SqlParameter("@SellerName", partnershipPapers.SellerName),
			new SqlParameter("@PaperNumber", partnershipPapers.PaperNumber)
		};
		return SqlDBHelper.ExecuteNonQuery("PartnershipPapers_Update", CommandType.StoredProcedure, parametersPartnershipPapers);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersPartnershipPapers = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("PartnershipPapers_Delete", CommandType.StoredProcedure, parametersPartnershipPapers);
	}

	public PartnershipPapers GetDetails(Int64 heritageID)
	{
		PartnershipPapers partnershipPapers = new PartnershipPapers();

		SqlParameter[] parametersPartnershipPapers = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("PartnershipPapers_GetDetails", CommandType.StoredProcedure, parametersPartnershipPapers))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				partnershipPapers.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				partnershipPapers.PartnershipPaperTypeIDTitle = row["PartnershipPaperTypeIDTitle"].ToString();
				partnershipPapers.PartnershipPaperTypeID = (row["PartnershipPaperTypeID"] != DBNull.Value) ? Convert.ToInt32(row["PartnershipPaperTypeID"]) : 0 ;
				partnershipPapers.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				partnershipPapers.ProjectName = row["ProjectName"].ToString();
				partnershipPapers.SellerName = row["SellerName"].ToString();
				partnershipPapers.PaperNumber = row["PaperNumber"].ToString();

				Heritage heritage = heritageDBAccess.GetDetails(partnershipPapers.HeritageID);
				partnershipPapers.HeritageID = heritage.HeritageID;
				partnershipPapers.StageTitle = heritage.StageTitle;
				partnershipPapers.RegisterDate = heritage.RegisterDate;
				partnershipPapers.OldRegisterDate = heritage.OldRegisterDate;
				partnershipPapers.OldRegisterInformationID = heritage.OldRegisterInformationID;
				partnershipPapers.Sixth = heritage.Sixth;
				partnershipPapers.PreviousOwner = heritage.PreviousOwner;
				partnershipPapers.Comment = heritage.Comment;
				partnershipPapers.RegisterInformationID = heritage.RegisterInformationID;
				partnershipPapers.AdjustmentID = heritage.AdjustmentID;
				partnershipPapers.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				partnershipPapers.Stage = heritage.Stage;
				partnershipPapers.UserOrder = heritage.UserOrder;
				partnershipPapers.Value1 = heritage.Value1;
				partnershipPapers.Value2 = heritage.Value2;
				partnershipPapers.Value3 = heritage.Value3;
				partnershipPapers.DeadIsOwner = heritage.DeadIsOwner;
				partnershipPapers.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return partnershipPapers;
	}

	public List<PartnershipPapers> GetListAll()
	{
		List<PartnershipPapers> listPartnershipPapers = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("PartnershipPapers_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listPartnershipPapers = new List<PartnershipPapers>();

				foreach (DataRow row in table.Rows)
				{
					PartnershipPapers partnershipPapers = new PartnershipPapers();
					partnershipPapers.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					partnershipPapers.PartnershipPaperTypeIDTitle = row["PartnershipPaperTypeIDTitle"].ToString();
					partnershipPapers.PartnershipPaperTypeID = (row["PartnershipPaperTypeID"] != DBNull.Value) ? Convert.ToInt32(row["PartnershipPaperTypeID"]) : 0 ;
					partnershipPapers.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					partnershipPapers.ProjectName = row["ProjectName"].ToString();
					partnershipPapers.SellerName = row["SellerName"].ToString();
					partnershipPapers.PaperNumber = row["PaperNumber"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(partnershipPapers.HeritageID);
					partnershipPapers.StageTitle = heritage.StageTitle;
					partnershipPapers.RegisterDate = heritage.RegisterDate;
					partnershipPapers.OldRegisterDate = heritage.OldRegisterDate;
					partnershipPapers.OldRegisterInformationID = heritage.OldRegisterInformationID;
					partnershipPapers.Sixth = heritage.Sixth;
					partnershipPapers.PreviousOwner = heritage.PreviousOwner;
					partnershipPapers.Comment = heritage.Comment;
					partnershipPapers.RegisterInformationID = heritage.RegisterInformationID;
					partnershipPapers.AdjustmentID = heritage.AdjustmentID;
					partnershipPapers.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					partnershipPapers.Stage = heritage.Stage;
					partnershipPapers.UserOrder = heritage.UserOrder;
					partnershipPapers.Value1 = heritage.Value1;
					partnershipPapers.Value2 = heritage.Value2;
					partnershipPapers.Value3 = heritage.Value3;
					partnershipPapers.DeadIsOwner = heritage.DeadIsOwner;
					partnershipPapers.IsDiagonesed = heritage.IsDiagonesed;
					listPartnershipPapers.Add(partnershipPapers);
				}
			}
		}

		return listPartnershipPapers;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersPartnershipPapers = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("PartnershipPapers_Exists", CommandType.StoredProcedure, parametersPartnershipPapers)>0);
	}

	public bool Exists(PartnershipPapers partnershipPapers)
	{
		SqlParameter[] parametersPartnershipPapers = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", partnershipPapers.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("PartnershipPapers_Exists", CommandType.StoredProcedure, parametersPartnershipPapers)>0);
	}

	public List<PartnershipPapers> SearchLike(PartnershipPapers partnershipPapers)
	{
		List<PartnershipPapers> listPartnershipPapers = new List<PartnershipPapers>();


		SqlParameter[] parametersPartnershipPapers = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", partnershipPapers.HeritageID),
			new SqlParameter("@PartnershipPaperTypeIDTitle", partnershipPapers.PartnershipPaperTypeIDTitle),
			new SqlParameter("@PartnershipPaperTypeID", partnershipPapers.PartnershipPaperTypeID),
			new SqlParameter("@DeclarationID", partnershipPapers.DeclarationID),
			new SqlParameter("@ProjectName", partnershipPapers.ProjectName),
			new SqlParameter("@SellerName", partnershipPapers.SellerName),
			new SqlParameter("@PaperNumber", partnershipPapers.PaperNumber),

			new SqlParameter("@StageTitle", partnershipPapers.StageTitle),
			new SqlParameter("@RegisterDate", partnershipPapers.RegisterDate),
			new SqlParameter("@OldRegisterDate", partnershipPapers.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", partnershipPapers.OldRegisterInformationID),
			new SqlParameter("@Sixth", partnershipPapers.Sixth),
			new SqlParameter("@PreviousOwner", partnershipPapers.PreviousOwner),
			new SqlParameter("@Comment", partnershipPapers.Comment),
			new SqlParameter("@RegisterInformationID", partnershipPapers.RegisterInformationID),
			new SqlParameter("@AdjustmentID", partnershipPapers.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", partnershipPapers.CommissionAdjustmentID),
			new SqlParameter("@Stage", partnershipPapers.Stage),
			new SqlParameter("@UserOrder", partnershipPapers.UserOrder),
			new SqlParameter("@Value1", partnershipPapers.Value1),
			new SqlParameter("@Value2", partnershipPapers.Value2),
			new SqlParameter("@Value3", partnershipPapers.Value3),
			new SqlParameter("@DeadIsOwner", partnershipPapers.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", partnershipPapers.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("PartnershipPapers_SearchLike", CommandType.StoredProcedure, parametersPartnershipPapers))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					PartnershipPapers tmpPartnershipPapers = new PartnershipPapers();
					tmpPartnershipPapers.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpPartnershipPapers.PartnershipPaperTypeIDTitle = row["PartnershipPaperTypeIDTitle"].ToString();
					tmpPartnershipPapers.PartnershipPaperTypeID = (row["PartnershipPaperTypeID"] != DBNull.Value) ? Convert.ToInt32(row["PartnershipPaperTypeID"]) : 0 ;
					tmpPartnershipPapers.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpPartnershipPapers.ProjectName = row["ProjectName"].ToString();
					tmpPartnershipPapers.SellerName = row["SellerName"].ToString();
					tmpPartnershipPapers.PaperNumber = row["PaperNumber"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(tmpPartnershipPapers.HeritageID);
					tmpPartnershipPapers.HeritageID = heritage.HeritageID;
					tmpPartnershipPapers.StageTitle = heritage.StageTitle;
					tmpPartnershipPapers.RegisterDate = heritage.RegisterDate;
					tmpPartnershipPapers.OldRegisterDate = heritage.OldRegisterDate;
					tmpPartnershipPapers.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpPartnershipPapers.Sixth = heritage.Sixth;
					tmpPartnershipPapers.PreviousOwner = heritage.PreviousOwner;
					tmpPartnershipPapers.Comment = heritage.Comment;
					tmpPartnershipPapers.RegisterInformationID = heritage.RegisterInformationID;
					tmpPartnershipPapers.AdjustmentID = heritage.AdjustmentID;
					tmpPartnershipPapers.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpPartnershipPapers.Stage = heritage.Stage;
					tmpPartnershipPapers.UserOrder = heritage.UserOrder;
					tmpPartnershipPapers.Value1 = heritage.Value1;
					tmpPartnershipPapers.Value2 = heritage.Value2;
					tmpPartnershipPapers.Value3 = heritage.Value3;
					tmpPartnershipPapers.DeadIsOwner = heritage.DeadIsOwner;
					tmpPartnershipPapers.IsDiagonesed = heritage.IsDiagonesed;

					listPartnershipPapers.Add(tmpPartnershipPapers);
				}
			}
		}

		return listPartnershipPapers;
	}

}
}
