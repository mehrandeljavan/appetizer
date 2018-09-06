using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormHeritageListHandler
{
	// Handle to the FormHeritageList DBAccess class
	FormHeritageListDBAccess formHeritageListDb = null;

	public FormHeritageListHandler()
	{
		formHeritageListDb = new FormHeritageListDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritageLists, we can put some logic here if needed 
	public List<FormHeritageList> GetListAll()
	{
		return formHeritageListDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritageLists, we can put some logic here if needed 
	public bool Update(FormHeritageList formHeritageList)
	{
		return formHeritageListDb.Update(formHeritageList);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritageLists, we can put some logic here if needed 
	public FormHeritageList GetDetails(Int64 formHeritageListID)
	{
		return formHeritageListDb.GetDetails(formHeritageListID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritageLists, we can put some logic here if needed 
	public bool Delete(Int64 formHeritageListID)
	{
		return formHeritageListDb.Delete(formHeritageListID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritageLists, we can put some logic here if needed 
	public Int64 Insert(FormHeritageList formHeritageList)
	{
		return formHeritageListDb.Insert(formHeritageList);
	}

	public bool Exists(FormHeritageList formHeritageList)
	{
		return formHeritageListDb.Exists(formHeritageList);
	}

	public bool Exists(Int64 formHeritageListID)
	{
		return formHeritageListDb.Exists(formHeritageListID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeritageLists, we can put some logic here if needed 
	public List<FormHeritageList> SearchLike(FormHeritageList formHeritageList)
	{
		return formHeritageListDb.SearchLike(formHeritageList);
	}

}
}
