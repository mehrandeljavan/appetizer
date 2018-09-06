using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class QuestionDBAccess
{

	QuestionScoreDBAccess questionScoreDBAccess = new QuestionScoreDBAccess();

	public List<QuestionScore> GetListQuestionScore(Int64 questionID)
	{
		List<QuestionScore> listQuestionScore = new List<QuestionScore>() { };
		SqlParameter[] parametersQuestion = new SqlParameter[]
		{
			new SqlParameter("@QuestionID", questionID)
		};

		//Lets get the list of QuestionScore records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("QuestionScore_GetList_UseInQuestion", CommandType.StoredProcedure, parametersQuestion))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of questionScore
				listQuestionScore = new List<QuestionScore>();

				//Now lets populate the QuestionScore details into the list of questionScores
				foreach (DataRow row in table.Rows)
				{
					QuestionScore questionScore = ConvertRowToQuestionScore(row);
					listQuestionScore.Add(questionScore);
				}
			}
		}

		return listQuestionScore;
	}

	private QuestionScore ConvertRowToQuestionScore(DataRow row)
	{
		QuestionScore questionScore = new QuestionScore();
		questionScore.QuestionID = (row["QuestionID"] != DBNull.Value) ? Convert.ToInt64(row["QuestionID"]) : 0 ;
		questionScore.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
		questionScore.UserFullName = row["UserFullName"].ToString();
		questionScore.ScoreMark = (row["ScoreMark"] != DBNull.Value) ? Convert.ToInt32(row["ScoreMark"]) : 0 ;
		questionScore.ScoreDate = row["ScoreDate"].ToString();
		return questionScore;
	}
	public Int64 Insert(Question question)
	{
		SqlParameter[] parametersQuestion = new SqlParameter[]
		{
			new SqlParameter("@QuestionDate", (question.QuestionDate != null) ? question.QuestionDate : (object)DBNull.Value),
			new SqlParameter("@QuestionText", question.QuestionText),
			new SqlParameter("@Answer", (question.Answer != null) ? question.Answer : (object)DBNull.Value),
			new SqlParameter("@Visible", question.Visible),
			new SqlParameter("@UserNationalCode", (question.UserNationalCode > 0) ? question.UserNationalCode : (object)DBNull.Value)
		};
		question.QuestionID = SqlDBHelper.ExecuteScalar("Question_Insert", CommandType.StoredProcedure, parametersQuestion);
		return question.QuestionID;
	}

	public bool Update(Question question)
	{
		SqlParameter[] parametersQuestion = new SqlParameter[]
		{
			new SqlParameter("@QuestionID", question.QuestionID),
			new SqlParameter("@QuestionDate", (question.QuestionDate != null) ? question.QuestionDate : (object)DBNull.Value),
			new SqlParameter("@QuestionText", question.QuestionText),
			new SqlParameter("@Answer", (question.Answer != null) ? question.Answer : (object)DBNull.Value),
			new SqlParameter("@Visible", question.Visible),
			new SqlParameter("@UserNationalCode", question.UserNationalCode)
		};
		return SqlDBHelper.ExecuteNonQuery("Question_Update", CommandType.StoredProcedure, parametersQuestion);
	}

	public bool Delete(Int64 questionID)
	{
		SqlParameter[] parametersQuestion = new SqlParameter[]
		{
			new SqlParameter("@QuestionID", questionID)
		};
		return SqlDBHelper.ExecuteNonQuery("Question_Delete", CommandType.StoredProcedure, parametersQuestion);
	}

	public Question GetDetails(Int64 questionID)
	{
		Question question = new Question();

		SqlParameter[] parametersQuestion = new SqlParameter[]
		{
			new SqlParameter("@QuestionID", questionID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Question_GetDetails", CommandType.StoredProcedure, parametersQuestion))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				question.QuestionID = (row["QuestionID"] != DBNull.Value) ? Convert.ToInt64(row["QuestionID"]) : 0 ;
				question.UserFullName = row["UserFullName"].ToString();
				question.TotalMark = (row["TotalMark"] != DBNull.Value) ? Convert.ToInt64(row["TotalMark"]) : 0 ;
				question.QuestionDate = row["QuestionDate"].ToString();
				question.QuestionText = row["QuestionText"].ToString();
				question.Answer = row["Answer"].ToString();
				question.Visible = (row["Visible"] != DBNull.Value) ? Convert.ToBoolean((row["Visible"].ToString() == "1" || row["Visible"].ToString().ToLower() == "true" ) ? true : false) : false ;
				question.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
			}
		}

		return question;
	}

	public List<Question> GetListAll()
	{
		List<Question> listQuestion = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Question_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listQuestion = new List<Question>();

				foreach (DataRow row in table.Rows)
				{
					Question question = new Question();
					question.QuestionID = (row["QuestionID"] != DBNull.Value) ? Convert.ToInt64(row["QuestionID"]) : 0 ;
					question.UserFullName = row["UserFullName"].ToString();
					question.TotalMark = (row["TotalMark"] != DBNull.Value) ? Convert.ToInt64(row["TotalMark"]) : 0 ;
					question.QuestionDate = row["QuestionDate"].ToString();
					question.QuestionText = row["QuestionText"].ToString();
					question.Answer = row["Answer"].ToString();
				question.Visible = (row["Visible"] != DBNull.Value) ? Convert.ToBoolean((row["Visible"].ToString() == "1" || row["Visible"].ToString().ToLower() == "true" ) ? true : false) : false ;
					question.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
					listQuestion.Add(question);
				}
			}
		}

		return listQuestion;
	}

	public bool Exists(Int64 questionID)
	{
		SqlParameter[] parametersQuestion = new SqlParameter[]
		{
			new SqlParameter("@QuestionID", questionID)
		};
		return (SqlDBHelper.ExecuteScalar("Question_Exists", CommandType.StoredProcedure, parametersQuestion)>0);
	}

	public bool Exists(Question question)
	{
		SqlParameter[] parametersQuestion = new SqlParameter[]
		{
			new SqlParameter("@QuestionID", question.QuestionID)
		};
		return (SqlDBHelper.ExecuteScalar("Question_Exists", CommandType.StoredProcedure, parametersQuestion)>0);
	}

	public List<Question> SearchLike(Question question)
	{
		List<Question> listQuestion = new List<Question>();


		SqlParameter[] parametersQuestion = new SqlParameter[]
		{
			new SqlParameter("@QuestionID", question.QuestionID),
			new SqlParameter("@UserFullName", question.UserFullName),
			new SqlParameter("@TotalMark", question.TotalMark),
			new SqlParameter("@QuestionDate", question.QuestionDate),
			new SqlParameter("@QuestionText", question.QuestionText),
			new SqlParameter("@Answer", question.Answer),
			new SqlParameter("@Visible", question.Visible),
			new SqlParameter("@UserNationalCode", question.UserNationalCode),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Question_SearchLike", CommandType.StoredProcedure, parametersQuestion))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Question tmpQuestion = new Question();
					tmpQuestion.QuestionID = (row["QuestionID"] != DBNull.Value) ? Convert.ToInt64(row["QuestionID"]) : 0 ;
					tmpQuestion.UserFullName = row["UserFullName"].ToString();
					tmpQuestion.TotalMark = (row["TotalMark"] != DBNull.Value) ? Convert.ToInt64(row["TotalMark"]) : 0 ;
					tmpQuestion.QuestionDate = row["QuestionDate"].ToString();
					tmpQuestion.QuestionText = row["QuestionText"].ToString();
					tmpQuestion.Answer = row["Answer"].ToString();
					tmpQuestion.Visible = (row["Visible"] != DBNull.Value) ? Convert.ToBoolean((row["Visible"].ToString() == "1" || row["Visible"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpQuestion.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;

					listQuestion.Add(tmpQuestion);
				}
			}
		}

		return listQuestion;
	}

}
}
