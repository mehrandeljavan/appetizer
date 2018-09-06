using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Marriage
{
	private int marriageID;
	private string title;
	private List<Heir> heirList;

	public int MarriageID
	{
		get
		{
			return marriageID;
		}
		set
		{
			marriageID = value;
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
		HeirList = new MarriageDBAccess().GetListHeir(this.MarriageID);
		return HeirList;
	}

	public bool AddHeir(Heir heir)
	{
		heir.MarriageID = this.MarriageID;
		HeirDBAccess heirDBAccess = new HeirDBAccess();
		if (heirDBAccess.Insert(heir)>0)
			return (true);
		return (false);
	}

}
}
