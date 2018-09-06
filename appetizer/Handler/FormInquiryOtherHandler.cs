using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormInquiryOtherHandler
{
	// Handle to the FormInquiryOther DBAccess class
	FormInquiryOtherDBAccess formInquiryOtherDb = null;

	public FormInquiryOtherHandler()
	{
		formInquiryOtherDb = new FormInquiryOtherDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryOthers, we can put some logic here if needed 
	public List<FormInquiryOther> GetListAll()
	{
		return formInquiryOtherDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryOthers, we can put some logic here if needed 
	public bool Update(FormInquiryOther formInquiryOther)
	{
		return formInquiryOtherDb.Update(formInquiryOther);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryOthers, we can put some logic here if needed 
	public FormInquiryOther GetDetails(Int64 formInquiryOtherID)
	{
		return formInquiryOtherDb.GetDetails(formInquiryOtherID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryOthers, we can put some logic here if needed 
	public bool Delete(Int64 formInquiryOtherID)
	{
		return formInquiryOtherDb.Delete(formInquiryOtherID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryOthers, we can put some logic here if needed 
	public Int64 Insert(FormInquiryOther formInquiryOther)
	{
		return formInquiryOtherDb.Insert(formInquiryOther);
	}

	public bool Exists(FormInquiryOther formInquiryOther)
	{
		return formInquiryOtherDb.Exists(formInquiryOther);
	}

	public bool Exists(Int64 formInquiryOtherID)
	{
		return formInquiryOtherDb.Exists(formInquiryOtherID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryOthers, we can put some logic here if needed 
	public List<FormInquiryOther> SearchLike(FormInquiryOther formInquiryOther)
	{
		return formInquiryOtherDb.SearchLike(formInquiryOther);
	}

}
}
