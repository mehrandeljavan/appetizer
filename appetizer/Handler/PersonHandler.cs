using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class PersonHandler
{
	// Handle to the Person DBAccess class
	PersonDBAccess personDb = null;

	public PersonHandler()
	{
		personDb = new PersonDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of persons, we can put some logic here if needed 
	public List<Person> GetListAll()
	{
		return personDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of persons, we can put some logic here if needed 
	public bool Update(Person person)
	{
		return personDb.Update(person);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of persons, we can put some logic here if needed 
	public Person GetDetails(Int64 nationalCode)
	{
		return personDb.GetDetails(nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of persons, we can put some logic here if needed 
	public bool Delete(Int64 nationalCode)
	{
		return personDb.Delete(nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of persons, we can put some logic here if needed 
	public Int64 Insert(Person person)
	{
		return personDb.Insert(person);
	}

	public bool Exists(Person person)
	{
		return personDb.Exists(person);
	}

	public bool Exists(Int64 nationalCode)
	{
		return personDb.Exists(nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of persons, we can put some logic here if needed 
	public List<Person> SearchLike(Person person)
	{
		return personDb.SearchLike(person);
	}

}
}
