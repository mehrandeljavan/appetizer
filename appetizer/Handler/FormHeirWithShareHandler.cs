using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormHeirWithShareHandler
{
	// Handle to the FormHeirWithShare DBAccess class
	FormHeirWithShareDBAccess formHeirWithShareDb = null;

	public FormHeirWithShareHandler()
	{
		formHeirWithShareDb = new FormHeirWithShareDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeirWithShares, we can put some logic here if needed 
	public List<FormHeirWithShare> GetListAll()
	{
		return formHeirWithShareDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeirWithShares, we can put some logic here if needed 
	public bool Update(FormHeirWithShare formHeirWithShare)
	{
		return formHeirWithShareDb.Update(formHeirWithShare);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeirWithShares, we can put some logic here if needed 
	public FormHeirWithShare GetDetails(Int64 formHeirWithShareID)
	{
		return formHeirWithShareDb.GetDetails(formHeirWithShareID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeirWithShares, we can put some logic here if needed 
	public bool Delete(Int64 formHeirWithShareID)
	{
		return formHeirWithShareDb.Delete(formHeirWithShareID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeirWithShares, we can put some logic here if needed 
	public Int64 Insert(FormHeirWithShare formHeirWithShare)
	{
		return formHeirWithShareDb.Insert(formHeirWithShare);
	}

	public bool Exists(FormHeirWithShare formHeirWithShare)
	{
		return formHeirWithShareDb.Exists(formHeirWithShare);
	}

	public bool Exists(Int64 formHeirWithShareID)
	{
		return formHeirWithShareDb.Exists(formHeirWithShareID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formHeirWithShares, we can put some logic here if needed 
	public List<FormHeirWithShare> SearchLike(FormHeirWithShare formHeirWithShare)
	{
		return formHeirWithShareDb.SearchLike(formHeirWithShare);
	}

}
}
