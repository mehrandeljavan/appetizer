using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class WellType
{
	private int wellTypeID;
	private string title;
	private List<Well> wellList;

	public int WellTypeID
	{
		get
		{
			return wellTypeID;
		}
		set
		{
			wellTypeID = value;
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

	public List<Well> WellList
	{
		get
		{
			return wellList;
		}
		set
		{
			wellList = value;
		}
	}

	public List<Well> GetListWell()
	{
		WellList = new WellTypeDBAccess().GetListWell(this.WellTypeID);
		return WellList;
	}

	public bool AddWell(Well well)
	{
		well.WellTypeID = this.WellTypeID;
		WellDBAccess wellDBAccess = new WellDBAccess();
		if (wellDBAccess.Insert(well)>0)
			return (true);
		return (false);
	}

}
}
