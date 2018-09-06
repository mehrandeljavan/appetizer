using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormInquiryResponseHandler
{
	// Handle to the FormInquiryResponse DBAccess class
	FormInquiryResponseDBAccess formInquiryResponseDb = null;

	public FormInquiryResponseHandler()
	{
		formInquiryResponseDb = new FormInquiryResponseDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryResponses, we can put some logic here if needed 
	public List<FormInquiryResponse> GetListAll()
	{
		return formInquiryResponseDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryResponses, we can put some logic here if needed 
	public bool Update(FormInquiryResponse formInquiryResponse)
	{
		return formInquiryResponseDb.Update(formInquiryResponse);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryResponses, we can put some logic here if needed 
	public FormInquiryResponse GetDetails(Int64 registerInformationID)
	{
		return formInquiryResponseDb.GetDetails(registerInformationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryResponses, we can put some logic here if needed 
	public bool Delete(Int64 registerInformationID)
	{
		return formInquiryResponseDb.Delete(registerInformationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryResponses, we can put some logic here if needed 
	public Int64 Insert(FormInquiryResponse formInquiryResponse)
	{
		return formInquiryResponseDb.Insert(formInquiryResponse);
	}

	public bool Exists(FormInquiryResponse formInquiryResponse)
	{
		return formInquiryResponseDb.Exists(formInquiryResponse);
	}

	public bool Exists(Int64 registerInformationID)
	{
		return formInquiryResponseDb.Exists(registerInformationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryResponses, we can put some logic here if needed 
	public List<FormInquiryResponse> SearchLike(FormInquiryResponse formInquiryResponse)
	{
		return formInquiryResponseDb.SearchLike(formInquiryResponse);
	}

}
}
