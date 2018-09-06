using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class QuestionScoreHandler
{
	// Handle to the QuestionScore DBAccess class
	QuestionScoreDBAccess questionScoreDb = null;

	public QuestionScoreHandler()
	{
		questionScoreDb = new QuestionScoreDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of questionScores, we can put some logic here if needed 
	public List<QuestionScore> GetListAll()
	{
		return questionScoreDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of questionScores, we can put some logic here if needed 
	public bool Update(QuestionScore questionScore)
	{
		return questionScoreDb.Update(questionScore);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of questionScores, we can put some logic here if needed 
	public QuestionScore GetDetails(Int64 questionID , Int64 userNationalCode)
	{
		return questionScoreDb.GetDetails(questionID , userNationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of questionScores, we can put some logic here if needed 
	public bool Delete(Int64 questionID , Int64 userNationalCode)
	{
		return questionScoreDb.Delete(questionID , userNationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of questionScores, we can put some logic here if needed 
	public Int64 Insert(QuestionScore questionScore)
	{
		return questionScoreDb.Insert(questionScore);
	}

	public bool Exists(QuestionScore questionScore)
	{
		return questionScoreDb.Exists(questionScore);
	}

	public bool Exists(Int64 questionID , Int64 userNationalCode)
	{
		return questionScoreDb.Exists(questionID , userNationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of questionScores, we can put some logic here if needed 
	public List<QuestionScore> SearchLike(QuestionScore questionScore)
	{
		return questionScoreDb.SearchLike(questionScore);
	}

}
}
