using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormInquiryCompanyHandler
{
	// Handle to the FormInquiryCompany DBAccess class
	FormInquiryCompanyDBAccess formInquiryCompanyDb = null;

	public FormInquiryCompanyHandler()
	{
		formInquiryCompanyDb = new FormInquiryCompanyDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryCompanys, we can put some logic here if needed 
	public List<FormInquiryCompany> GetListAll()
	{
		return formInquiryCompanyDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryCompanys, we can put some logic here if needed 
	public bool Update(FormInquiryCompany formInquiryCompany)
	{
		return formInquiryCompanyDb.Update(formInquiryCompany);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryCompanys, we can put some logic here if needed 
	public FormInquiryCompany GetDetails(Int64 formInquiryCompanyID)
	{
		return formInquiryCompanyDb.GetDetails(formInquiryCompanyID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryCompanys, we can put some logic here if needed 
	public bool Delete(Int64 formInquiryCompanyID)
	{
		return formInquiryCompanyDb.Delete(formInquiryCompanyID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryCompanys, we can put some logic here if needed 
	public Int64 Insert(FormInquiryCompany formInquiryCompany)
	{
		return formInquiryCompanyDb.Insert(formInquiryCompany);
	}

	public bool Exists(FormInquiryCompany formInquiryCompany)
	{
		return formInquiryCompanyDb.Exists(formInquiryCompany);
	}

	public bool Exists(Int64 formInquiryCompanyID)
	{
		return formInquiryCompanyDb.Exists(formInquiryCompanyID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryCompanys, we can put some logic here if needed 
	public List<FormInquiryCompany> SearchLike(FormInquiryCompany formInquiryCompany)
	{
		return formInquiryCompanyDb.SearchLike(formInquiryCompany);
	}

}
}
