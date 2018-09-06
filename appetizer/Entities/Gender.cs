using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Gender
{
	private int genderID;
	private string title;
	private List<Person> personList;

	public int GenderID
	{
		get
		{
			return genderID;
		}
		set
		{
			genderID = value;
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
		PersonList = new GenderDBAccess().GetListPerson(this.GenderID);
		return PersonList;
	}

	public bool AddPerson(Person person)
	{
		person.GenderID = this.GenderID;
		PersonDBAccess personDBAccess = new PersonDBAccess();
		if (personDBAccess.Insert(person)>0)
			return (true);
		return (false);
	}

}
}
