using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class HajjType
{
	private int hajjTypeID;
	private string title;
	private List<Hajj> hajjList;

	public int HajjTypeID
	{
		get
		{
			return hajjTypeID;
		}
		set
		{
			hajjTypeID = value;
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

	public List<Hajj> HajjList
	{
		get
		{
			return hajjList;
		}
		set
		{
			hajjList = value;
		}
	}

	public List<Hajj> GetListHajj()
	{
		HajjList = new HajjTypeDBAccess().GetListHajj(this.HajjTypeID);
		return HajjList;
	}

	public bool AddHajj(Hajj hajj)
	{
		hajj.HajjTypeID = this.HajjTypeID;
		HajjDBAccess hajjDBAccess = new HajjDBAccess();
		if (hajjDBAccess.Insert(hajj)>0)
			return (true);
		return (false);
	}

}
}
