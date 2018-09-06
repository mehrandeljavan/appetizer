using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Province
{
	private int provinceID;
	private string title;
	private List<City> cityList;
	private List<Dead> deadList;
	private List<Person> personList;
	private List<TaxOffice> taxOfficeList;
	private List<User> userList;

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

	public List<City> CityList
	{
		get
		{
			return cityList;
		}
		set
		{
			cityList = value;
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

	public List<User> UserList
	{
		get
		{
			return userList;
		}
		set
		{
			userList = value;
		}
	}

	public List<City> GetListCity()
	{
		CityList = new ProvinceDBAccess().GetListCity(this.ProvinceID);
		return CityList;
	}

	public List<Dead> GetListDead()
	{
		DeadList = new ProvinceDBAccess().GetListDead(this.ProvinceID);
		return DeadList;
	}

	public List<Person> GetListPerson()
	{
		PersonList = new ProvinceDBAccess().GetListPerson(this.ProvinceID);
		return PersonList;
	}

	public List<TaxOffice> GetListTaxOffice()
	{
		TaxOfficeList = new ProvinceDBAccess().GetListTaxOffice(this.ProvinceID);
		return TaxOfficeList;
	}

	public List<User> GetListUser()
	{
		UserList = new ProvinceDBAccess().GetListUser(this.ProvinceID);
		return UserList;
	}

	public bool AddCity(City city)
	{
		city.ProvinceID = this.ProvinceID;
		CityDBAccess cityDBAccess = new CityDBAccess();
		if (cityDBAccess.Insert(city)>0)
			return (true);
		return (false);
	}

	public bool AddDead(Dead dead)
	{
		dead.DeathProvinceID = this.ProvinceID;
		DeadDBAccess deadDBAccess = new DeadDBAccess();
		if (deadDBAccess.Insert(dead)>0)
			return (true);
		return (false);
	}

	public bool AddPerson(Person person)
	{
		person.IssuanceProvinceID = this.ProvinceID;
		PersonDBAccess personDBAccess = new PersonDBAccess();
		if (personDBAccess.Insert(person)>0)
			return (true);
		return (false);
	}

	public bool AddTaxOffice(TaxOffice taxOffice)
	{
		taxOffice.ProvinceID = this.ProvinceID;
		TaxOfficeDBAccess taxOfficeDBAccess = new TaxOfficeDBAccess();
		if (taxOfficeDBAccess.Insert(taxOffice)>0)
			return (true);
		return (false);
	}

	public bool AddUser(User user)
	{
		user.ProvinceIDDefault = this.ProvinceID;
		UserDBAccess userDBAccess = new UserDBAccess();
		if (userDBAccess.Insert(user)>0)
			return (true);
		return (false);
	}

}
}
