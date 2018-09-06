using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Religion_Din
{
	private int religion_DinID;
	private string title;
	private List<Person> personList;

	public int Religion_DinID
	{
		get
		{
			return religion_DinID;
		}
		set
		{
			religion_DinID = value;
		}
	}

	public string Title
	{
		get
		{
			return title;
		}
		set
		{
			title = value;
		}
	}

	public List<Person> PersonList
	{
		get
		{
			return personList;
		}
		set
		{
			personList = value;
		}
	}

	public List<Person> GetListPerson()
	{
		PersonList = new Religion_DinDBAccess().GetListPerson(this.Religion_DinID);
		return PersonList;
	}

	public bool AddPerson(Person person)
	{
		person.Religion_DinID = this.Religion_DinID;
		PersonDBAccess personDBAccess = new PersonDBAccess();
		if (personDBAccess.Insert(person)>0)
			return (true);
		return (false);
	}

}
}
