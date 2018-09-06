using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class ScoreTypeDBAccess
{

	ScoreDBAccess scoreDBAccess = new ScoreDBAccess();

	public List<Score> GetListScore(int scoreTypeID)
	{
		List<Score> listScore = new List<Score>() { };
		SqlParameter[] parametersScoreType = new SqlParameter[]
		{
			new SqlParameter("@ScoreTypeID", scoreTypeID)
		};

		//Lets get the list of Score records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Score_GetList_UseInScoreType", CommandType.StoredProcedure, parametersScoreType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of score
				listScore = new List<Score>();

				//Now lets populate the Score details into the list of scores
				foreach (DataRow row in table.Rows)
				{
					Score score = ConvertRowToScore(row);
					listScore.Add(score);
				}
			}
		}

		return listScore;
	}

	private Score ConvertRowToScore(DataRow row)
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

		score.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		score.StageTitle = row["StageTitle"].ToString();
		score.RegisterDate = row["RegisterDate"].ToString();
		score.OldRegisterDate = row["OldRegisterDate"].ToString();
		score.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		score.Sixth = row["Sixth"].ToString();
		score.PreviousOwner = row["PreviousOwner"].ToString();
		score.Comment = row["Comment"].ToString();
		score.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		score.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		score.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		score.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		score.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		score.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		score.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		score.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		score.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		score.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return score;
	}
	public Int64 Insert(ScoreType scoreType)
	{
		SqlParameter[] parametersScoreType = new SqlParameter[]
		{
			new SqlParameter("@Title", scoreType.Title)
		};
		scoreType.ScoreTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("ScoreType_Insert", CommandType.StoredProcedure, parametersScoreType));
		return scoreType.ScoreTypeID;
	}

	public bool Update(ScoreType scoreType)
	{
		SqlParameter[] parametersScoreType = new SqlParameter[]
		{
			new SqlParameter("@ScoreTypeID", scoreType.ScoreTypeID),
			new SqlParameter("@Title", scoreType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("ScoreType_Update", CommandType.StoredProcedure, parametersScoreType);
	}

	public bool Delete(int scoreTypeID)
	{
		SqlParameter[] parametersScoreType = new SqlParameter[]
		{
			new SqlParameter("@ScoreTypeID", scoreTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("ScoreType_Delete", CommandType.StoredProcedure, parametersScoreType);
	}

	public ScoreType GetDetails(int scoreTypeID)
	{
		ScoreType scoreType = new ScoreType();

		SqlParameter[] parametersScoreType = new SqlParameter[]
		{
			new SqlParameter("@ScoreTypeID", scoreTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ScoreType_GetDetails", CommandType.StoredProcedure, parametersScoreType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				scoreType.ScoreTypeID = (row["ScoreTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ScoreTypeID"]) : 0 ;
				scoreType.Title = row["Title"].ToString();
			}
		}

		return scoreType;
	}

	public List<ScoreType> GetListAll()
	{
		List<ScoreType> listScoreType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("ScoreType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listScoreType = new List<ScoreType>();

				foreach (DataRow row in table.Rows)
				{
					ScoreType scoreType = new ScoreType();
					scoreType.ScoreTypeID = (row["ScoreTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ScoreTypeID"]) : 0 ;
					scoreType.Title = row["Title"].ToString();
					listScoreType.Add(scoreType);
				}
			}
		}

		return listScoreType;
	}

	public bool Exists(int scoreTypeID)
	{
		SqlParameter[] parametersScoreType = new SqlParameter[]
		{
			new SqlParameter("@ScoreTypeID", scoreTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("ScoreType_Exists", CommandType.StoredProcedure, parametersScoreType)>0);
	}

	public bool Exists(ScoreType scoreType)
	{
		SqlParameter[] parametersScoreType = new SqlParameter[]
		{
			new SqlParameter("@ScoreTypeID", scoreType.ScoreTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("ScoreType_Exists", CommandType.StoredProcedure, parametersScoreType)>0);
	}

	public List<ScoreType> SearchLike(ScoreType scoreType)
	{
		List<ScoreType> listScoreType = new List<ScoreType>();


		SqlParameter[] parametersScoreType = new SqlParameter[]
		{
			new SqlParameter("@ScoreTypeID", scoreType.ScoreTypeID),
			new SqlParameter("@Title", scoreType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ScoreType_SearchLike", CommandType.StoredProcedure, parametersScoreType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					ScoreType tmpScoreType = new ScoreType();
					tmpScoreType.ScoreTypeID = (row["ScoreTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ScoreTypeID"]) : 0 ;
					tmpScoreType.Title = row["Title"].ToString();

					listScoreType.Add(tmpScoreType);
				}
			}
		}

		return listScoreType;
	}

}
}
