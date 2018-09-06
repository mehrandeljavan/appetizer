using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class DemandsType
{
	private int demandsTypeID;
	private int? categoty;
	private string title;
	private List<Demands> demandsList;

	public int DemandsTypeID
	{
		get
		{
			return demandsTypeID;
		}
		set
		{
			demandsTypeID = value;
		}
	}

	public int? Categoty
	{
		get
		{
			return categoty;
		}
		set
		{
			categoty = value;
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

	public List<Demands> DemandsList
	{
		get
		{
			return demandsList;
		}
		set
		{
			demandsList = value;
		}
	}

	public List<Demands> GetListDemands()
	{
		DemandsList = new DemandsTypeDBAccess().GetListDemands(this.DemandsTypeID);
		return DemandsList;
	}

	public bool AddDemands(Demands demands)
	{
		demands.DemandsTypeID = this.DemandsTypeID;
		DemandsDBAccess demandsDBAccess = new DemandsDBAccess();
		if (demandsDBAccess.Insert(demands)>0)
			return (true);
		return (false);
	}

}
}
