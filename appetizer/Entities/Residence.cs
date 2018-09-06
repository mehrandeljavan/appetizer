using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Residence
{
	private int residenceID;
	private string title;
	private List<Dead> deadList;
	private List<Heir> heirList;

	public int ResidenceID
	{
		get
		{
			return residenceID;
		}
		set
		{
			residenceID = value;
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
		DeadList = new ResidenceDBAccess().GetListDead(this.ResidenceID);
		return DeadList;
	}

	public List<Heir> GetListHeir()
	{
		HeirList = new ResidenceDBAccess().GetListHeir(this.ResidenceID);
		return HeirList;
	}

	public bool AddDead(Dead dead)
	{
		dead.ResidenceID = this.ResidenceID;
		DeadDBAccess deadDBAccess = new DeadDBAccess();
		if (deadDBAccess.Insert(dead)>0)
			return (true);
		return (false);
	}

	public bool AddHeir(Heir heir)
	{
		heir.ResidenceID = this.ResidenceID;
		HeirDBAccess heirDBAccess = new HeirDBAccess();
		if (heirDBAccess.Insert(heir)>0)
			return (true);
		return (false);
	}

}
}
