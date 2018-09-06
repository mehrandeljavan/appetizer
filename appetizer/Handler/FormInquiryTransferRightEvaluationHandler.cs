using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormInquiryTransferRightEvaluationHandler
{
	// Handle to the FormInquiryTransferRightEvaluation DBAccess class
	FormInquiryTransferRightEvaluationDBAccess formInquiryTransferRightEvaluationDb = null;

	public FormInquiryTransferRightEvaluationHandler()
	{
		formInquiryTransferRightEvaluationDb = new FormInquiryTransferRightEvaluationDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryTransferRightEvaluations, we can put some logic here if needed 
	public List<FormInquiryTransferRightEvaluation> GetListAll()
	{
		return formInquiryTransferRightEvaluationDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryTransferRightEvaluations, we can put some logic here if needed 
	public bool Update(FormInquiryTransferRightEvaluation formInquiryTransferRightEvaluation)
	{
		return formInquiryTransferRightEvaluationDb.Update(formInquiryTransferRightEvaluation);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryTransferRightEvaluations, we can put some logic here if needed 
	public FormInquiryTransferRightEvaluation GetDetails(Int64 formInquiryTransferRightEvaluationID)
	{
		return formInquiryTransferRightEvaluationDb.GetDetails(formInquiryTransferRightEvaluationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryTransferRightEvaluations, we can put some logic here if needed 
	public bool Delete(Int64 formInquiryTransferRightEvaluationID)
	{
		return formInquiryTransferRightEvaluationDb.Delete(formInquiryTransferRightEvaluationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryTransferRightEvaluations, we can put some logic here if needed 
	public Int64 Insert(FormInquiryTransferRightEvaluation formInquiryTransferRightEvaluation)
	{
		return formInquiryTransferRightEvaluationDb.Insert(formInquiryTransferRightEvaluation);
	}

	public bool Exists(FormInquiryTransferRightEvaluation formInquiryTransferRightEvaluation)
	{
		return formInquiryTransferRightEvaluationDb.Exists(formInquiryTransferRightEvaluation);
	}

	public bool Exists(Int64 formInquiryTransferRightEvaluationID)
	{
		return formInquiryTransferRightEvaluationDb.Exists(formInquiryTransferRightEvaluationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryTransferRightEvaluations, we can put some logic here if needed 
	public List<FormInquiryTransferRightEvaluation> SearchLike(FormInquiryTransferRightEvaluation formInquiryTransferRightEvaluation)
	{
		return formInquiryTransferRightEvaluationDb.SearchLike(formInquiryTransferRightEvaluation);
	}

}
}
