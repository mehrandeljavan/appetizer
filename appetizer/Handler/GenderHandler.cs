using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class GenderHandler
{
	// Handle to the Gender DBAccess class
	GenderDBAccess genderDb = null;

	public GenderHandler()
	{
		genderDb = new GenderDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of genders, we can put some logic here if needed 
	public List<Gender> GetListAll()
	{
		return genderDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of genders, we can put some logic here if needed 
	public bool Update(Gender gender)
	{
		return genderDb.Update(gender);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of genders, we can put some logic here if needed 
	public Gender GetDetails(int genderID)
	{
		return genderDb.GetDetails(genderID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of genders, we can put some logic here if needed 
	public bool Delete(int genderID)
	{
		return genderDb.Delete(genderID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of genders, we can put some logic here if needed 
	public Int64 Insert(Gender gender)
	{
		return genderDb.Insert(gender);
	}

	public bool Exists(Gender gender)
	{
		return genderDb.Exists(gender);
	}

	public bool Exists(int genderID)
	{
		return genderDb.Exists(genderID);
	}

	public List<Person> GetListPerson(int genderID)
	{
		return genderDb.GetListPerson(genderID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of genders, we can put some logic here if needed 
	public List<Gender> SearchLike(Gender gender)
	{
		return genderDb.SearchLike(gender);
	}

}
}
