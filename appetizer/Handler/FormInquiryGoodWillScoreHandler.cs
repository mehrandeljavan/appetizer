using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormInquiryGoodWillScoreHandler
{
	// Handle to the FormInquiryGoodWillScore DBAccess class
	FormInquiryGoodWillScoreDBAccess formInquiryGoodWillScoreDb = null;

	public FormInquiryGoodWillScoreHandler()
	{
		formInquiryGoodWillScoreDb = new FormInquiryGoodWillScoreDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryGoodWillScores, we can put some logic here if needed 
	public List<FormInquiryGoodWillScore> GetListAll()
	{
		return formInquiryGoodWillScoreDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryGoodWillScores, we can put some logic here if needed 
	public bool Update(FormInquiryGoodWillScore formInquiryGoodWillScore)
	{
		return formInquiryGoodWillScoreDb.Update(formInquiryGoodWillScore);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryGoodWillScores, we can put some logic here if needed 
	public FormInquiryGoodWillScore GetDetails(Int64 formInquiryGoodWillScorelID)
	{
		return formInquiryGoodWillScoreDb.GetDetails(formInquiryGoodWillScorelID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryGoodWillScores, we can put some logic here if needed 
	public bool Delete(Int64 formInquiryGoodWillScorelID)
	{
		return formInquiryGoodWillScoreDb.Delete(formInquiryGoodWillScorelID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryGoodWillScores, we can put some logic here if needed 
	public Int64 Insert(FormInquiryGoodWillScore formInquiryGoodWillScore)
	{
		return formInquiryGoodWillScoreDb.Insert(formInquiryGoodWillScore);
	}

	public bool Exists(FormInquiryGoodWillScore formInquiryGoodWillScore)
	{
		return formInquiryGoodWillScoreDb.Exists(formInquiryGoodWillScore);
	}

	public bool Exists(Int64 formInquiryGoodWillScorelID)
	{
		return formInquiryGoodWillScoreDb.Exists(formInquiryGoodWillScorelID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryGoodWillScores, we can put some logic here if needed 
	public List<FormInquiryGoodWillScore> SearchLike(FormInquiryGoodWillScore formInquiryGoodWillScore)
	{
		return formInquiryGoodWillScoreDb.SearchLike(formInquiryGoodWillScore);
	}

}
}
