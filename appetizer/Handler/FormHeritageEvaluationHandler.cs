using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormHeritageEvaluationHandler
{
	// Handle to the FormHeritageEvaluation DBAccess class
	FormHeritageEvaluationDBAccess formHeritageEvaluationDb = null;

	public FormHeritageEvaluationHandler()
	{
		formHeritageEvaluationDb = new FormHeritageEvaluationDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritageEvaluations, we can put some logic here if needed 
	public List<FormHeritageEvaluation> GetListAll()
	{
		return formHeritageEvaluationDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritageEvaluations, we can put some logic here if needed 
	public bool Update(FormHeritageEvaluation formHeritageEvaluation)
	{
		return formHeritageEvaluationDb.Update(formHeritageEvaluation);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritageEvaluations, we can put some logic here if needed 
	public FormHeritageEvaluation GetDetails(Int64 formHeritageEvaluationID)
	{
		return formHeritageEvaluationDb.GetDetails(formHeritageEvaluationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritageEvaluations, we can put some logic here if needed 
	public bool Delete(Int64 formHeritageEvaluationID)
	{
		return formHeritageEvaluationDb.Delete(formHeritageEvaluationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritageEvaluations, we can put some logic here if needed 
	public Int64 Insert(FormHeritageEvaluation formHeritageEvaluation)
	{
		return formHeritageEvaluationDb.Insert(formHeritageEvaluation);
	}

	public bool Exists(FormHeritageEvaluation formHeritageEvaluation)
	{
		return formHeritageEvaluationDb.Exists(formHeritageEvaluation);
	}

	public bool Exists(Int64 formHeritageEvaluationID)
	{
		return formHeritageEvaluationDb.Exists(formHeritageEvaluationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritageEvaluations, we can put some logic here if needed 
	public List<FormHeritageEvaluation> SearchLike(FormHeritageEvaluation formHeritageEvaluation)
	{
		return formHeritageEvaluationDb.SearchLike(formHeritageEvaluation);
	}

}
}
