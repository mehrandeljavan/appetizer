using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormInquiryGoodWillEvaluationHandler
{
	// Handle to the FormInquiryGoodWillEvaluation DBAccess class
	FormInquiryGoodWillEvaluationDBAccess formInquiryGoodWillEvaluationDb = null;

	public FormInquiryGoodWillEvaluationHandler()
	{
		formInquiryGoodWillEvaluationDb = new FormInquiryGoodWillEvaluationDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryGoodWillEvaluations, we can put some logic here if needed 
	public List<FormInquiryGoodWillEvaluation> GetListAll()
	{
		return formInquiryGoodWillEvaluationDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryGoodWillEvaluations, we can put some logic here if needed 
	public bool Update(FormInquiryGoodWillEvaluation formInquiryGoodWillEvaluation)
	{
		return formInquiryGoodWillEvaluationDb.Update(formInquiryGoodWillEvaluation);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryGoodWillEvaluations, we can put some logic here if needed 
	public FormInquiryGoodWillEvaluation GetDetails(Int64 formInquiryGoodWillEvaluationID)
	{
		return formInquiryGoodWillEvaluationDb.GetDetails(formInquiryGoodWillEvaluationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryGoodWillEvaluations, we can put some logic here if needed 
	public bool Delete(Int64 formInquiryGoodWillEvaluationID)
	{
		return formInquiryGoodWillEvaluationDb.Delete(formInquiryGoodWillEvaluationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryGoodWillEvaluations, we can put some logic here if needed 
	public Int64 Insert(FormInquiryGoodWillEvaluation formInquiryGoodWillEvaluation)
	{
		return formInquiryGoodWillEvaluationDb.Insert(formInquiryGoodWillEvaluation);
	}

	public bool Exists(FormInquiryGoodWillEvaluation formInquiryGoodWillEvaluation)
	{
		return formInquiryGoodWillEvaluationDb.Exists(formInquiryGoodWillEvaluation);
	}

	public bool Exists(Int64 formInquiryGoodWillEvaluationID)
	{
		return formInquiryGoodWillEvaluationDb.Exists(formInquiryGoodWillEvaluationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryGoodWillEvaluations, we can put some logic here if needed 
	public List<FormInquiryGoodWillEvaluation> SearchLike(FormInquiryGoodWillEvaluation formInquiryGoodWillEvaluation)
	{
		return formInquiryGoodWillEvaluationDb.SearchLike(formInquiryGoodWillEvaluation);
	}

}
}
