using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Nationality
{
	private int nationalityID;
	private string title;
	private List<Dead> deadList;
	private List<Heir> heirList;

	public int NationalityID
	{
		get
		{
			return nationalityID;
		}
		set
		{
			nationalityID = value;
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

	public List<Heir> HeirList
	{
		get
		{
			return heirList;
		}
		set
		{
			heirList = value;
		}
	}

	public List<Dead> GetListDead()
	{
		DeadList = new NationalityDBAccess().GetListDead(this.NationalityID);
		return DeadList;
	}

	public List<Heir> GetListHeir()
	{
		HeirList = new NationalityDBAccess().GetListHeir(this.NationalityID);
		return HeirList;
	}

	public bool AddDead(Dead dead)
	{
		dead.NationalityID = this.NationalityID;
		DeadDBAccess deadDBAccess = new DeadDBAccess();
		if (deadDBAccess.Insert(dead)>0)
			return (true);
		return (false);
	}

	public bool AddHeir(Heir heir)
	{
		heir.NationalityID = this.NationalityID;
		HeirDBAccess heirDBAccess = new HeirDBAccess();
		if (heirDBAccess.Insert(heir)>0)
			return (true);
		return (false);
	}

}
}
