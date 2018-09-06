using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class City
{
	private int cityID;
	private string provinceIDTitle;
	private int provinceID;
	private string title;
	private List<Dead> deadList;
	private List<Person> personList;
	private List<TaxOffice> taxOfficeList;

	public int CityID
	{
		get
		{
			return cityID;
		}
		set
		{
			cityID = value;
		}
	}

	public string ProvinceIDTitle
	{
		get
		{
			return provinceIDTitle;
		}
		set
		{
			provinceIDTitle = value;
		}
	}

	public int ProvinceID
	{
		get
		{
			return provinceID;
		}
		set
		{
			provinceID = value;
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

	public List<Dead> DeadList
	{
		get
		{
			return deadList;
		}
		set
		{
			deadList = value;
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

	public List<TaxOffice> TaxOfficeList
	{
		get
		{
			return taxOfficeList;
		}
		set
		{
			taxOfficeList = value;
		}
	}

	public List<Dead> GetListDead()
	{
		DeadList = new CityDBAccess().GetListDead(this.CityID);
		return DeadList;
	}

	public List<Person> GetListPerson()
	{
		PersonList = new CityDBAccess().GetListPerson(this.CityID);
		return PersonList;
	}

	public List<TaxOffice> GetListTaxOffice()
	{
		TaxOfficeList = new CityDBAccess().GetListTaxOffice(this.CityID);
		return TaxOfficeList;
	}

	public bool AddDead(Dead dead)
	{
		dead.DeathCityID = this.CityID;
		DeadDBAccess deadDBAccess = new DeadDBAccess();
		if (deadDBAccess.Insert(dead)>0)
			return (true);
		return (false);
	}

	public bool AddPerson(Person person)
	{
		person.IssuanceCityID = this.CityID;
		PersonDBAccess personDBAccess = new PersonDBAccess();
		if (personDBAccess.Insert(person)>0)
			return (true);
		return (false);
	}

	public bool AddTaxOffice(TaxOffice taxOffice)
	{
		taxOffice.CityID = this.CityID;
		TaxOfficeDBAccess taxOfficeDBAccess = new TaxOfficeDBAccess();
		if (taxOfficeDBAccess.Insert(taxOffice)>0)
			return (true);
		return (false);
	}

}
}
