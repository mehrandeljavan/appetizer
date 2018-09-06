using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class InquiryResponseHandler
{
	// Handle to the InquiryResponse DBAccess class
	InquiryResponseDBAccess inquiryResponseDb = null;

	public InquiryResponseHandler()
	{
		inquiryResponseDb = new InquiryResponseDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of inquiryResponses, we can put some logic here if needed 
	public List<InquiryResponse> GetListAll()
	{
		return inquiryResponseDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of inquiryResponses, we can put some logic here if needed 
	public bool Update(InquiryResponse inquiryResponse)
	{
		return inquiryResponseDb.Update(inquiryResponse);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of inquiryResponses, we can put some logic here if needed 
	public InquiryResponse GetDetails(Int64 inquiryResponseID)
	{
		return inquiryResponseDb.GetDetails(inquiryResponseID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of inquiryResponses, we can put some logic here if needed 
	public bool Delete(Int64 inquiryResponseID)
	{
		return inquiryResponseDb.Delete(inquiryResponseID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of inquiryResponses, we can put some logic here if needed 
	public Int64 Insert(InquiryResponse inquiryResponse)
	{
		return inquiryResponseDb.Insert(inquiryResponse);
	}

	public bool Exists(InquiryResponse inquiryResponse)
	{
		return inquiryResponseDb.Exists(inquiryResponse);
	}

	public bool Exists(Int64 inquiryResponseID)
	{
		return inquiryResponseDb.Exists(inquiryResponseID);
	}

	public List<FormInquiryBankDeposit> GetListFormInquiryBankDeposit(Int64 inquiryResponseID)
	{
		return inquiryResponseDb.GetListFormInquiryBankDeposit(inquiryResponseID);
	}

	public List<FormInquiryCompany> GetListFormInquiryCompany(Int64 inquiryResponseID)
	{
		return inquiryResponseDb.GetListFormInquiryCompany(inquiryResponseID);
	}

	public List<FormInquiryEstate> GetListFormInquiryEstate(Int64 inquiryResponseID)
	{
		return inquiryResponseDb.GetListFormInquiryEstate(inquiryResponseID);
	}

	public List<FormInquiryGoodWillEvaluation> GetListFormInquiryGoodWillEvaluation(Int64 inquiryResponseID)
	{
		return inquiryResponseDb.GetListFormInquiryGoodWillEvaluation(inquiryResponseID);
	}

	public List<FormInquiryGoodWillScore> GetListFormInquiryGoodWillScore(Int64 inquiryResponseID)
	{
		return inquiryResponseDb.GetListFormInquiryGoodWillScore(inquiryResponseID);
	}

	public List<FormInquiryOther> GetListFormInquiryOther(Int64 inquiryResponseID)
	{
		return inquiryResponseDb.GetListFormInquiryOther(inquiryResponseID);
	}

	public List<FormInquiryTransferRightEvaluation> GetListFormInquiryTransferRightEvaluation(Int64 inquiryResponseID)
	{
		return inquiryResponseDb.GetListFormInquiryTransferRightEvaluation(inquiryResponseID);
	}

	public List<FormInquiryTransferRightScore> GetListFormInquiryTransferRightScore(Int64 inquiryResponseID)
	{
		return inquiryResponseDb.GetListFormInquiryTransferRightScore(inquiryResponseID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of inquiryResponses, we can put some logic here if needed 
	public List<InquiryResponse> SearchLike(InquiryResponse inquiryResponse)
	{
		return inquiryResponseDb.SearchLike(inquiryResponse);
	}

}
}
