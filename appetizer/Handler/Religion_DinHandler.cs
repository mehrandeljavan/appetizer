using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class Religion_DinHandler
{
	// Handle to the Religion_Din DBAccess class
	Religion_DinDBAccess religion_DinDb = null;

	public Religion_DinHandler()
	{
		religion_DinDb = new Religion_DinDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of religion_Dins, we can put some logic here if needed 
	public List<Religion_Din> GetListAll()
	{
		return religion_DinDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of religion_Dins, we can put some logic here if needed 
	public bool Update(Religion_Din religion_Din)
	{
		return religion_DinDb.Update(religion_Din);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of religion_Dins, we can put some logic here if needed 
	public Religion_Din GetDetails(int religion_DinID)
	{
		return religion_DinDb.GetDetails(religion_DinID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of religion_Dins, we can put some logic here if needed 
	public bool Delete(int religion_DinID)
	{
		return religion_DinDb.Delete(religion_DinID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of religion_Dins, we can put some logic here if needed 
	public Int64 Insert(Religion_Din religion_Din)
	{
		return religion_DinDb.Insert(religion_Din);
	}

	public bool Exists(Religion_Din religion_Din)
	{
		return religion_DinDb.Exists(religion_Din);
	}

	public bool Exists(int religion_DinID)
	{
		return religion_DinDb.Exists(religion_DinID);
	}

	public List<Person> GetListPerson(int religion_DinID)
	{
		return religion_DinDb.GetListPerson(religion_DinID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of religion_Dins, we can put some logic here if needed 
	public List<Religion_Din> SearchLike(Religion_Din religion_Din)
	{
		return religion_DinDb.SearchLike(religion_Din);
	}

}
}
