using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class CostType
{
	private int costTypeID;
	private string title;
	private List<Cost> costList;

	public int CostTypeID
	{
		get
		{
			return costTypeID;
		}
		set
		{
			costTypeID = value;
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

	public List<Cost> CostList
	{
		get
		{
			return costList;
		}
		set
		{
			costList = value;
		}
	}

	public List<Cost> GetListCost()
	{
		CostList = new CostTypeDBAccess().GetListCost(this.CostTypeID);
		return CostList;
	}

	public bool AddCost(Cost cost)
	{
		cost.CostTypeID = this.CostTypeID;
		CostDBAccess costDBAccess = new CostDBAccess();
		if (costDBAccess.Insert(cost)>0)
			return (true);
		return (false);
	}

}
}
