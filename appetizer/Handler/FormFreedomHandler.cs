using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormFreedomHandler
{
	// Handle to the FormFreedom DBAccess class
	FormFreedomDBAccess formFreedomDb = null;

	public FormFreedomHandler()
	{
		formFreedomDb = new FormFreedomDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formFreedoms, we can put some logic here if needed 
	public List<FormFreedom> GetListAll()
	{
		return formFreedomDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formFreedoms, we can put some logic here if needed 
	public bool Update(FormFreedom formFreedom)
	{
		return formFreedomDb.Update(formFreedom);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formFreedoms, we can put some logic here if needed 
	public FormFreedom GetDetails(Int64 formFreedomID)
	{
		return formFreedomDb.GetDetails(formFreedomID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formFreedoms, we can put some logic here if needed 
	public bool Delete(Int64 formFreedomID)
	{
		return formFreedomDb.Delete(formFreedomID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formFreedoms, we can put some logic here if needed 
	public Int64 Insert(FormFreedom formFreedom)
	{
		return formFreedomDb.Insert(formFreedom);
	}

	public bool Exists(FormFreedom formFreedom)
	{
		return formFreedomDb.Exists(formFreedom);
	}

	public bool Exists(Int64 formFreedomID)
	{
		return formFreedomDb.Exists(formFreedomID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formFreedoms, we can put some logic here if needed 
	public List<FormFreedom> SearchLike(FormFreedom formFreedom)
	{
		return formFreedomDb.SearchLike(formFreedom);
	}

}
}
