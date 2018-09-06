using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class MartyrProfReference
{
	private int martyrProfReferenceID;
	private string title;
	private List<Dead> deadList;

	public int MartyrProfReferenceID
	{
		get
		{
			return martyrProfReferenceID;
		}
		set
		{
			martyrProfReferenceID = value;
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

	public List<Dead> GetListDead()
	{
		DeadList = new MartyrProfReferenceDBAccess().GetListDead(this.MartyrProfReferenceID);
		return DeadList;
	}

	public bool AddDead(Dead dead)
	{
		dead.MartyrProfReferenceID = this.MartyrProfReferenceID;
		DeadDBAccess deadDBAccess = new DeadDBAccess();
		if (deadDBAccess.Insert(dead)>0)
			return (true);
		return (false);
	}

}
}
