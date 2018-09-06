using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class ScoreDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(Score score)
	{
		if (!heritageDBAccess.Exists(score))
			score.HeritageID = heritageDBAccess.Insert(score);

		SqlParameter[] parametersScore = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (score.HeritageID > 0) ? score.HeritageID : (object)DBNull.Value),
			new SqlParameter("@ScoreTypeID", (score.ScoreTypeID > 0) ? score.ScoreTypeID : (object)DBNull.Value),
			new SqlParameter("@Number", (score.Number != null) ? score.Number : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (score.DeclarationID > 0) ? score.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@ProductionUnitID", (score.ProductionUnitID > 0) ? score.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@LicenseDate", (score.LicenseDate != null) ? score.LicenseDate : (object)DBNull.Value),
			new SqlParameter("@Name", score.Name),
			new SqlParameter("@ProofReference", (score.ProofReference != null) ? score.ProofReference : (object)DBNull.Value),
			new SqlParameter("@LicenseNo", (score.LicenseNo != null) ? score.LicenseNo : (object)DBNull.Value),
			new SqlParameter("@Address", score.Address),
			new SqlParameter("@PartialPlaque", (score.PartialPlaque != null) ? score.PartialPlaque : (object)DBNull.Value),
			new SqlParameter("@RegisterScope", (score.RegisterScope != null) ? score.RegisterScope : (object)DBNull.Value),
			new SqlParameter("@Area", (score.Area != null) ? score.Area : (object)DBNull.Value),
			new SqlParameter("@Balcony", (score.Balcony != null) ? score.Balcony : (object)DBNull.Value),
			new SqlParameter("@BaseMent", (score.BaseMent != null) ? score.BaseMent : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("Score_Insert", CommandType.StoredProcedure, parametersScore);
	}

	public bool Update(Score score)
	{
		heritageDBAccess.Update(score);

		SqlParameter[] parametersScore = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", score.HeritageID),
			new SqlParameter("@ScoreTypeID", (score.ScoreTypeID != null && score.ScoreTypeID >0 ) ? score.ScoreTypeID : (object)DBNull.Value),
			new SqlParameter("@Number", (score.Number != null) ? score.Number : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", score.DeclarationID),
			new SqlParameter("@ProductionUnitID", (score.ProductionUnitID != null && score.ProductionUnitID >0 ) ? score.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@LicenseDate", (score.LicenseDate != null) ? score.LicenseDate : (object)DBNull.Value),
			new SqlParameter("@Name", score.Name),
			new SqlParameter("@ProofReference", (score.ProofReference != null) ? score.ProofReference : (object)DBNull.Value),
			new SqlParameter("@LicenseNo", (score.LicenseNo != null) ? score.LicenseNo : (object)DBNull.Value),
			new SqlParameter("@Address", score.Address),
			new SqlParameter("@PartialPlaque", (score.PartialPlaque != null) ? score.PartialPlaque : (object)DBNull.Value),
			new SqlParameter("@RegisterScope", (score.RegisterScope != null) ? score.RegisterScope : (object)DBNull.Value),
			new SqlParameter("@Area", (score.Area != null) ? score.Area : (object)DBNull.Value),
			new SqlParameter("@Balcony", (score.Balcony != null) ? score.Balcony : (object)DBNull.Value),
			new SqlParameter("@BaseMent", (score.BaseMent != null) ? score.BaseMent : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Score_Update", CommandType.StoredProcedure, parametersScore);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersScore = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("Score_Delete", CommandType.StoredProcedure, parametersScore);
	}

	public Score GetDetails(Int64 heritageID)
	{
		Score score = new Score();

		SqlParameter[] parametersScore = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Score_GetDetails", CommandType.StoredProcedure, parametersScore))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				score.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				score.ScoreTypeIDTitle = row["ScoreTypeIDTitle"].ToString();
				score.ScoreTypeID = (row["ScoreTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ScoreTypeID"]) : 0 ;
				score.Number = (row["Number"] != DBNull.Value) ? Convert.ToInt32(row["Number"]) : 0 ;
				score.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				score.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
				score.LicenseDate = row["LicenseDate"].ToString();
				score.Name = row["Name"].ToString();
				score.ProofReference = row["ProofReference"].ToString();
				score.LicenseNo = row["LicenseNo"].ToString();
				score.Address = row["Address"].ToString();
				score.PartialPlaque = row["PartialPlaque"].ToString();
				score.RegisterScope = row["RegisterScope"].ToString();
				score.Area = row["Area"].ToString();
				score.Balcony = row["Balcony"].ToString();
				score.BaseMent = row["BaseMent"].ToString();

				Heritage heritage = heritageDBAccess.GetDetails(score.HeritageID);
				score.HeritageID = heritage.HeritageID;
				score.StageTitle = heritage.StageTitle;
				score.RegisterDate = heritage.RegisterDate;
				score.OldRegisterDate = heritage.OldRegisterDate;
				score.OldRegisterInformationID = heritage.OldRegisterInformationID;
				score.Sixth = heritage.Sixth;
				score.PreviousOwner = heritage.PreviousOwner;
				score.Comment = heritage.Comment;
				score.RegisterInformationID = heritage.RegisterInformationID;
				score.AdjustmentID = heritage.AdjustmentID;
				score.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				score.Stage = heritage.Stage;
				score.UserOrder = heritage.UserOrder;
				score.Value1 = heritage.Value1;
				score.Value2 = heritage.Value2;
				score.Value3 = heritage.Value3;
				score.DeadIsOwner = heritage.DeadIsOwner;
				score.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return score;
	}

	public List<Score> GetListAll()
	{
		List<Score> listScore = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Score_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listScore = new List<Score>();

				foreach (DataRow row in table.Rows)
				{
					Score score = new Score();
					score.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					score.ScoreTypeIDTitle = row["ScoreTypeIDTitle"].ToString();
					score.ScoreTypeID = (row["ScoreTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ScoreTypeID"]) : 0 ;
					score.Number = (row["Number"] != DBNull.Value) ? Convert.ToInt32(row["Number"]) : 0 ;
					score.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					score.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					score.LicenseDate = row["LicenseDate"].ToString();
					score.Name = row["Name"].ToString();
					score.ProofReference = row["ProofReference"].ToString();
					score.LicenseNo = row["LicenseNo"].ToString();
					score.Address = row["Address"].ToString();
					score.PartialPlaque = row["PartialPlaque"].ToString();
					score.RegisterScope = row["RegisterScope"].ToString();
					score.Area = row["Area"].ToString();
					score.Balcony = row["Balcony"].ToString();
					score.BaseMent = row["BaseMent"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(score.HeritageID);
					score.StageTitle = heritage.StageTitle;
					score.RegisterDate = heritage.RegisterDate;
					score.OldRegisterDate = heritage.OldRegisterDate;
					score.OldRegisterInformationID = heritage.OldRegisterInformationID;
					score.Sixth = heritage.Sixth;
					score.PreviousOwner = heritage.PreviousOwner;
					score.Comment = heritage.Comment;
					score.RegisterInformationID = heritage.RegisterInformationID;
					score.AdjustmentID = heritage.AdjustmentID;
					score.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					score.Stage = heritage.Stage;
					score.UserOrder = heritage.UserOrder;
					score.Value1 = heritage.Value1;
					score.Value2 = heritage.Value2;
					score.Value3 = heritage.Value3;
					score.DeadIsOwner = heritage.DeadIsOwner;
					score.IsDiagonesed = heritage.IsDiagonesed;
					listScore.Add(score);
				}
			}
		}

		return listScore;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersScore = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Score_Exists", CommandType.StoredProcedure, parametersScore)>0);
	}

	public bool Exists(Score score)
	{
		SqlParameter[] parametersScore = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", score.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Score_Exists", CommandType.StoredProcedure, parametersScore)>0);
	}

	public List<Score> SearchLike(Score score)
	{
		List<Score> listScore = new List<Score>();


		SqlParameter[] parametersScore = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", score.HeritageID),
			new SqlParameter("@ScoreTypeIDTitle", score.ScoreTypeIDTitle),
			new SqlParameter("@ScoreTypeID", score.ScoreTypeID),
			new SqlParameter("@Number", score.Number),
			new SqlParameter("@DeclarationID", score.DeclarationID),
			new SqlParameter("@ProductionUnitID", score.ProductionUnitID),
			new SqlParameter("@LicenseDate", score.LicenseDate),
			new SqlParameter("@Name", score.Name),
			new SqlParameter("@ProofReference", score.ProofReference),
			new SqlParameter("@LicenseNo", score.LicenseNo),
			new SqlParameter("@Address", score.Address),
			new SqlParameter("@PartialPlaque", score.PartialPlaque),
			new SqlParameter("@RegisterScope", score.RegisterScope),
			new SqlParameter("@Area", score.Area),
			new SqlParameter("@Balcony", score.Balcony),
			new SqlParameter("@BaseMent", score.BaseMent),

			new SqlParameter("@StageTitle", score.StageTitle),
			new SqlParameter("@RegisterDate", score.RegisterDate),
			new SqlParameter("@OldRegisterDate", score.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", score.OldRegisterInformationID),
			new SqlParameter("@Sixth", score.Sixth),
			new SqlParameter("@PreviousOwner", score.PreviousOwner),
			new SqlParameter("@Comment", score.Comment),
			new SqlParameter("@RegisterInformationID", score.RegisterInformationID),
			new SqlParameter("@AdjustmentID", score.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", score.CommissionAdjustmentID),
			new SqlParameter("@Stage", score.Stage),
			new SqlParameter("@UserOrder", score.UserOrder),
			new SqlParameter("@Value1", score.Value1),
			new SqlParameter("@Value2", score.Value2),
			new SqlParameter("@Value3", score.Value3),
			new SqlParameter("@DeadIsOwner", score.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", score.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Score_SearchLike", CommandType.StoredProcedure, parametersScore))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Score tmpScore = new Score();
					tmpScore.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpScore.ScoreTypeIDTitle = row["ScoreTypeIDTitle"].ToString();
					tmpScore.ScoreTypeID = (row["ScoreTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ScoreTypeID"]) : 0 ;
					tmpScore.Number = (row["Number"] != DBNull.Value) ? Convert.ToInt32(row["Number"]) : 0 ;
					tmpScore.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpScore.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					tmpScore.LicenseDate = row["LicenseDate"].ToString();
					tmpScore.Name = row["Name"].ToString();
					tmpScore.ProofReference = row["ProofReference"].ToString();
					tmpScore.LicenseNo = row["LicenseNo"].ToString();
					tmpScore.Address = row["Address"].ToString();
					tmpScore.PartialPlaque = row["PartialPlaque"].ToString();
					tmpScore.RegisterScope = row["RegisterScope"].ToString();
					tmpScore.Area = row["Area"].ToString();
					tmpScore.Balcony = row["Balcony"].ToString();
					tmpScore.BaseMent = row["BaseMent"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(tmpScore.HeritageID);
					tmpScore.HeritageID = heritage.HeritageID;
					tmpScore.StageTitle = heritage.StageTitle;
					tmpScore.RegisterDate = heritage.RegisterDate;
					tmpScore.OldRegisterDate = heritage.OldRegisterDate;
					tmpScore.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpScore.Sixth = heritage.Sixth;
					tmpScore.PreviousOwner = heritage.PreviousOwner;
					tmpScore.Comment = heritage.Comment;
					tmpScore.RegisterInformationID = heritage.RegisterInformationID;
					tmpScore.AdjustmentID = heritage.AdjustmentID;
					tmpScore.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpScore.Stage = heritage.Stage;
					tmpScore.UserOrder = heritage.UserOrder;
					tmpScore.Value1 = heritage.Value1;
					tmpScore.Value2 = heritage.Value2;
					tmpScore.Value3 = heritage.Value3;
					tmpScore.DeadIsOwner = heritage.DeadIsOwner;
					tmpScore.IsDiagonesed = heritage.IsDiagonesed;

					listScore.Add(tmpScore);
				}
			}
		}

		return listScore;
	}

}
}
