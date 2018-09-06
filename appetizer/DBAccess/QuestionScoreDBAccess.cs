using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class QuestionScoreDBAccess
{


	public Int64 Insert(QuestionScore questionScore)
	{
		SqlParameter[] parametersQuestionScore = new SqlParameter[]
		{
			new SqlParameter("@QuestionID", (questionScore.QuestionID > 0) ? questionScore.QuestionID : (object)DBNull.Value),
			new SqlParameter("@UserNationalCode", (questionScore.UserNationalCode > 0) ? questionScore.UserNationalCode : (object)DBNull.Value),
			new SqlParameter("@ScoreMark", questionScore.ScoreMark),
			new SqlParameter("@ScoreDate", (questionScore.ScoreDate != null) ? questionScore.ScoreDate : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("QuestionScore_Insert", CommandType.StoredProcedure, parametersQuestionScore);
	}

	public bool Update(QuestionScore questionScore)
	{
		SqlParameter[] parametersQuestionScore = new SqlParameter[]
		{
			new SqlParameter("@QuestionID", questionScore.QuestionID),
			new SqlParameter("@UserNationalCode", questionScore.UserNationalCode),
			new SqlParameter("@ScoreMark", questionScore.ScoreMark),
			new SqlParameter("@ScoreDate", (questionScore.ScoreDate != null) ? questionScore.ScoreDate : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("QuestionScore_Update", CommandType.StoredProcedure, parametersQuestionScore);
	}

	public bool Delete(Int64 questionID , Int64 userNationalCode)
	{
		SqlParameter[] parametersQuestionScore = new SqlParameter[]
		{
			new SqlParameter("@QuestionID", questionID),
			new SqlParameter("@UserNationalCode", userNationalCode)
		};
		return SqlDBHelper.ExecuteNonQuery("QuestionScore_Delete", CommandType.StoredProcedure, parametersQuestionScore);
	}

	public QuestionScore GetDetails(Int64 questionID , Int64 userNationalCode)
	{
		QuestionScore questionScore = new QuestionScore();

		SqlParameter[] parametersQuestionScore = new SqlParameter[]
		{
			new SqlParameter("@QuestionID", questionID),
			new SqlParameter("@UserNationalCode", userNationalCode)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("QuestionScore_GetDetails", CommandType.StoredProcedure, parametersQuestionScore))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				questionScore.QuestionID = (row["QuestionID"] != DBNull.Value) ? Convert.ToInt64(row["QuestionID"]) : 0 ;
				questionScore.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
				questionScore.UserFullName = row["UserFullName"].ToString();
				questionScore.ScoreMark = (row["ScoreMark"] != DBNull.Value) ? Convert.ToInt32(row["ScoreMark"]) : 0 ;
				questionScore.ScoreDate = row["ScoreDate"].ToString();
			}
		}

		return questionScore;
	}

	public List<QuestionScore> GetListAll()
	{
		List<QuestionScore> listQuestionScore = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("QuestionScore_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listQuestionScore = new List<QuestionScore>();

				foreach (DataRow row in table.Rows)
				{
					QuestionScore questionScore = new QuestionScore();
					questionScore.QuestionID = (row["QuestionID"] != DBNull.Value) ? Convert.ToInt64(row["QuestionID"]) : 0 ;
					questionScore.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
					questionScore.UserFullName = row["UserFullName"].ToString();
					questionScore.ScoreMark = (row["ScoreMark"] != DBNull.Value) ? Convert.ToInt32(row["ScoreMark"]) : 0 ;
					questionScore.ScoreDate = row["ScoreDate"].ToString();
					listQuestionScore.Add(questionScore);
				}
			}
		}

		return listQuestionScore;
	}

	public bool Exists(Int64 questionID , Int64 userNationalCode)
	{
		SqlParameter[] parametersQuestionScore = new SqlParameter[]
		{
			new SqlParameter("@QuestionID", questionID),
			new SqlParameter("@UserNationalCode", userNationalCode)
		};
		return (SqlDBHelper.ExecuteScalar("QuestionScore_Exists", CommandType.StoredProcedure, parametersQuestionScore)>0);
	}

	public bool Exists(QuestionScore questionScore)
	{
		SqlParameter[] parametersQuestionScore = new SqlParameter[]
		{
			new SqlParameter("@QuestionID", questionScore.QuestionID),
			new SqlParameter("@UserNationalCode", questionScore.UserNationalCode)
		};
		return (SqlDBHelper.ExecuteScalar("QuestionScore_Exists", CommandType.StoredProcedure, parametersQuestionScore)>0);
	}

	public List<QuestionScore> SearchLike(QuestionScore questionScore)
	{
		List<QuestionScore> listQuestionScore = new List<QuestionScore>();


		SqlParameter[] parametersQuestionScore = new SqlParameter[]
		{
			new SqlParameter("@QuestionID", questionScore.QuestionID),
			new SqlParameter("@UserNationalCode", questionScore.UserNationalCode),
			new SqlParameter("@UserFullName", questionScore.UserFullName),
			new SqlParameter("@ScoreMark", questionScore.ScoreMark),
			new SqlParameter("@ScoreDate", questionScore.ScoreDate),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("QuestionScore_SearchLike", CommandType.StoredProcedure, parametersQuestionScore))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					QuestionScore tmpQuestionScore = new QuestionScore();
					tmpQuestionScore.QuestionID = (row["QuestionID"] != DBNull.Value) ? Convert.ToInt64(row["QuestionID"]) : 0 ;
					tmpQuestionScore.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
					tmpQuestionScore.UserFullName = row["UserFullName"].ToString();
					tmpQuestionScore.ScoreMark = (row["ScoreMark"] != DBNull.Value) ? Convert.ToInt32(row["ScoreMark"]) : 0 ;
					tmpQuestionScore.ScoreDate = row["ScoreDate"].ToString();

					listQuestionScore.Add(tmpQuestionScore);
				}
			}
		}

		return listQuestionScore;
	}

}
}
