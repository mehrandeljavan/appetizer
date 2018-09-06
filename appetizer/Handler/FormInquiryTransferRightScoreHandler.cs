using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormInquiryTransferRightScoreHandler
{
	// Handle to the FormInquiryTransferRightScore DBAccess class
	FormInquiryTransferRightScoreDBAccess formInquiryTransferRightScoreDb = null;

	public FormInquiryTransferRightScoreHandler()
	{
		formInquiryTransferRightScoreDb = new FormInquiryTransferRightScoreDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryTransferRightScores, we can put some logic here if needed 
	public List<FormInquiryTransferRightScore> GetListAll()
	{
		return formInquiryTransferRightScoreDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryTransferRightScores, we can put some logic here if needed 
	public bool Update(FormInquiryTransferRightScore formInquiryTransferRightScore)
	{
		return formInquiryTransferRightScoreDb.Update(formInquiryTransferRightScore);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryTransferRightScores, we can put some logic here if needed 
	public FormInquiryTransferRightScore GetDetails(Int64 formInquiryTransferRightScorelID)
	{
		return formInquiryTransferRightScoreDb.GetDetails(formInquiryTransferRightScorelID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryTransferRightScores, we can put some logic here if needed 
	public bool Delete(Int64 formInquiryTransferRightScorelID)
	{
		return formInquiryTransferRightScoreDb.Delete(formInquiryTransferRightScorelID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryTransferRightScores, we can put some logic here if needed 
	public Int64 Insert(FormInquiryTransferRightScore formInquiryTransferRightScore)
	{
		return formInquiryTransferRightScoreDb.Insert(formInquiryTransferRightScore);
	}

	public bool Exists(FormInquiryTransferRightScore formInquiryTransferRightScore)
	{
		return formInquiryTransferRightScoreDb.Exists(formInquiryTransferRightScore);
	}

	public bool Exists(Int64 formInquiryTransferRightScorelID)
	{
		return formInquiryTransferRightScoreDb.Exists(formInquiryTransferRightScorelID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryTransferRightScores, we can put some logic here if needed 
	public List<FormInquiryTransferRightScore> SearchLike(FormInquiryTransferRightScore formInquiryTransferRightScore)
	{
		return formInquiryTransferRightScoreDb.SearchLike(formInquiryTransferRightScore);
	}

}
}
