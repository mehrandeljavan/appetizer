using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class WillType
{
	private int willTypeID;
	private string title;
	private List<Will> willList;

	public int WillTypeID
	{
		get
		{
			return willTypeID;
		}
		set
		{
			willTypeID = value;
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

	public List<Will> WillList
	{
		get
		{
			return willList;
		}
		set
		{
			willList = value;
		}
	}

	public List<Will> GetListWill()
	{
		WillList = new WillTypeDBAccess().GetListWill(this.WillTypeID);
		return WillList;
	}

	public bool AddWill(Will will)
	{
		will.WillTypeID = this.WillTypeID;
		WillDBAccess willDBAccess = new WillDBAccess();
		if (willDBAccess.Insert(will)>0)
			return (true);
		return (false);
	}

}
}
