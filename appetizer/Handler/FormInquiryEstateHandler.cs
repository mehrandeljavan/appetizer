using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormInquiryEstateHandler
{
	// Handle to the FormInquiryEstate DBAccess class
	FormInquiryEstateDBAccess formInquiryEstateDb = null;

	public FormInquiryEstateHandler()
	{
		formInquiryEstateDb = new FormInquiryEstateDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryEstates, we can put some logic here if needed 
	public List<FormInquiryEstate> GetListAll()
	{
		return formInquiryEstateDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryEstates, we can put some logic here if needed 
	public bool Update(FormInquiryEstate formInquiryEstate)
	{
		return formInquiryEstateDb.Update(formInquiryEstate);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryEstates, we can put some logic here if needed 
	public FormInquiryEstate GetDetails(Int64 formInquiryEstateID)
	{
		return formInquiryEstateDb.GetDetails(formInquiryEstateID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryEstates, we can put some logic here if needed 
	public bool Delete(Int64 formInquiryEstateID)
	{
		return formInquiryEstateDb.Delete(formInquiryEstateID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryEstates, we can put some logic here if needed 
	public Int64 Insert(FormInquiryEstate formInquiryEstate)
	{
		return formInquiryEstateDb.Insert(formInquiryEstate);
	}

	public bool Exists(FormInquiryEstate formInquiryEstate)
	{
		return formInquiryEstateDb.Exists(formInquiryEstate);
	}

	public bool Exists(Int64 formInquiryEstateID)
	{
		return formInquiryEstateDb.Exists(formInquiryEstateID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formInquiryEstates, we can put some logic here if needed 
	public List<FormInquiryEstate> SearchLike(FormInquiryEstate formInquiryEstate)
	{
		return formInquiryEstateDb.SearchLike(formInquiryEstate);
	}

}
}
