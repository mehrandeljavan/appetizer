using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class Religion_MazhabHandler
{
	// Handle to the Religion_Mazhab DBAccess class
	Religion_MazhabDBAccess religion_MazhabDb = null;

	public Religion_MazhabHandler()
	{
		religion_MazhabDb = new Religion_MazhabDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of religion_Mazhabs, we can put some logic here if needed 
	public List<Religion_Mazhab> GetListAll()
	{
		return religion_MazhabDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of religion_Mazhabs, we can put some logic here if needed 
	public bool Update(Religion_Mazhab religion_Mazhab)
	{
		return religion_MazhabDb.Update(religion_Mazhab);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of religion_Mazhabs, we can put some logic here if needed 
	public Religion_Mazhab GetDetails(int religion_MazhabID)
	{
		return religion_MazhabDb.GetDetails(religion_MazhabID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of religion_Mazhabs, we can put some logic here if needed 
	public bool Delete(int religion_MazhabID)
	{
		return religion_MazhabDb.Delete(religion_MazhabID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of religion_Mazhabs, we can put some logic here if needed 
	public Int64 Insert(Religion_Mazhab religion_Mazhab)
	{
		return religion_MazhabDb.Insert(religion_Mazhab);
	}

	public bool Exists(Religion_Mazhab religion_Mazhab)
	{
		return religion_MazhabDb.Exists(religion_Mazhab);
	}

	public bool Exists(int religion_MazhabID)
	{
		return religion_MazhabDb.Exists(religion_MazhabID);
	}

	public List<Person> GetListPerson(int religion_MazhabID)
	{
		return religion_MazhabDb.GetListPerson(religion_MazhabID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of religion_Mazhabs, we can put some logic here if needed 
	public List<Religion_Mazhab> SearchLike(Religion_Mazhab religion_Mazhab)
	{
		return religion_MazhabDb.SearchLike(religion_Mazhab);
	}

}
}
