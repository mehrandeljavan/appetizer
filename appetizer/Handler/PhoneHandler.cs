using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class PhoneHandler
{
	// Handle to the Phone DBAccess class
	PhoneDBAccess phoneDb = null;

	public PhoneHandler()
	{
		phoneDb = new PhoneDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of phones, we can put some logic here if needed 
	public List<Phone> GetListAll()
	{
		return phoneDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of phones, we can put some logic here if needed 
	public bool Update(Phone phone)
	{
		return phoneDb.Update(phone);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of phones, we can put some logic here if needed 
	public Phone GetDetails(Int64 heritageID)
	{
		return phoneDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of phones, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return phoneDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of phones, we can put some logic here if needed 
	public Int64 Insert(Phone phone)
	{
		return phoneDb.Insert(phone);
	}

	public bool Exists(Phone phone)
	{
		return phoneDb.Exists(phone);
	}

	public bool Exists(Int64 heritageID)
	{
		return phoneDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of phones, we can put some logic here if needed 
	public List<Phone> SearchLike(Phone phone)
	{
		return phoneDb.SearchLike(phone);
	}

}
}
