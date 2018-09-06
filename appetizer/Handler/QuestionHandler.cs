using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class QuestionHandler
{
	// Handle to the Question DBAccess class
	QuestionDBAccess questionDb = null;

	public QuestionHandler()
	{
		questionDb = new QuestionDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of questions, we can put some logic here if needed 
	public List<Question> GetListAll()
	{
		return questionDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of questions, we can put some logic here if needed 
	public bool Update(Question question)
	{
		return questionDb.Update(question);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of questions, we can put some logic here if needed 
	public Question GetDetails(Int64 questionID)
	{
		return questionDb.GetDetails(questionID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of questions, we can put some logic here if needed 
	public bool Delete(Int64 questionID)
	{
		return questionDb.Delete(questionID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of questions, we can put some logic here if needed 
	public Int64 Insert(Question question)
	{
		return questionDb.Insert(question);
	}

	public bool Exists(Question question)
	{
		return questionDb.Exists(question);
	}

	public bool Exists(Int64 questionID)
	{
		return questionDb.Exists(questionID);
	}

	public List<QuestionScore> GetListQuestionScore(Int64 questionID)
	{
		return questionDb.GetListQuestionScore(questionID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of questions, we can put some logic here if needed 
	public List<Question> SearchLike(Question question)
	{
		return questionDb.SearchLike(question);
	}

}
}
