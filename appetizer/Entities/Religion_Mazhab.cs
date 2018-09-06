using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Religion_Mazhab
{
	private int religion_MazhabID;
	private string title;
	private List<Person> personList;

	public int Religion_MazhabID
	{
		get
		{
			return religion_MazhabID;
		}
		set
		{
			religion_MazhabID = value;
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
		PersonList = new Religion_MazhabDBAccess().GetListPerson(this.Religion_MazhabID);
		return PersonList;
	}

	public bool AddPerson(Person person)
	{
		person.Religion_MazhabID = this.Religion_MazhabID;
		PersonDBAccess personDBAccess = new PersonDBAccess();
		if (personDBAccess.Insert(person)>0)
			return (true);
		return (false);
	}

}
}
