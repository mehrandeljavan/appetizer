using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class EstateType
{
	private int estateTypeID;
	private int? category;
	private string title;
	private List<Estate> estateList;

	public int EstateTypeID
	{
		get
		{
			return estateTypeID;
		}
		set
		{
			estateTypeID = value;
		}
	}

	public int? Category
	{
		get
		{
			return category;
		}
		set
		{
			category = value;
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

	public List<Estate> EstateList
	{
		get
		{
			return estateList;
		}
		set
		{
			estateList = value;
		}
	}

	public List<Estate> GetListEstate()
	{
		EstateList = new EstateTypeDBAccess().GetListEstate(this.EstateTypeID);
		return EstateList;
	}

	public bool AddEstate(Estate estate)
	{
		estate.EstateTypeID = this.EstateTypeID;
		EstateDBAccess estateDBAccess = new EstateDBAccess();
		if (estateDBAccess.Insert(estate)>0)
			return (true);
		return (false);
	}

}
}
