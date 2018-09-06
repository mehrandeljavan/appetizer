using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class PhysicalState
{
	private int physicalStateID;
	private string title;
	private List<Heir> heirList;

	public int PhysicalStateID
	{
		get
		{
			return physicalStateID;
		}
		set
		{
			physicalStateID = value;
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

	public List<Heir> GetListHeir()
	{
		HeirList = new PhysicalStateDBAccess().GetListHeir(this.PhysicalStateID);
		return HeirList;
	}

	public bool AddHeir(Heir heir)
	{
		heir.PhysicalStateID = this.PhysicalStateID;
		HeirDBAccess heirDBAccess = new HeirDBAccess();
		if (heirDBAccess.Insert(heir)>0)
			return (true);
		return (false);
	}

}
}
