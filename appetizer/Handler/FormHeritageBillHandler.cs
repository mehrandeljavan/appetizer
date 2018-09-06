using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormHeritageBillHandler
{
	// Handle to the FormHeritageBill DBAccess class
	FormHeritageBillDBAccess formHeritageBillDb = null;

	public FormHeritageBillHandler()
	{
		formHeritageBillDb = new FormHeritageBillDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritageBills, we can put some logic here if needed 
	public List<FormHeritageBill> GetListAll()
	{
		return formHeritageBillDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritageBills, we can put some logic here if needed 
	public bool Update(FormHeritageBill formHeritageBill)
	{
		return formHeritageBillDb.Update(formHeritageBill);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritageBills, we can put some logic here if needed 
	public FormHeritageBill GetDetails(Int64 formHeritageBillID)
	{
		return formHeritageBillDb.GetDetails(formHeritageBillID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritageBills, we can put some logic here if needed 
	public bool Delete(Int64 formHeritageBillID)
	{
		return formHeritageBillDb.Delete(formHeritageBillID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritageBills, we can put some logic here if needed 
	public Int64 Insert(FormHeritageBill formHeritageBill)
	{
		return formHeritageBillDb.Insert(formHeritageBill);
	}

	public bool Exists(FormHeritageBill formHeritageBill)
	{
		return formHeritageBillDb.Exists(formHeritageBill);
	}

	public bool Exists(Int64 formHeritageBillID)
	{
		return formHeritageBillDb.Exists(formHeritageBillID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritageBills, we can put some logic here if needed 
	public List<FormHeritageBill> SearchLike(FormHeritageBill formHeritageBill)
	{
		return formHeritageBillDb.SearchLike(formHeritageBill);
	}

}
}
