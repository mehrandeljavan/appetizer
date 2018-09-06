using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class DemandDocument
{
	private int demandDocumentID;
	private string title;
	private List<Demands> demandsList;

	public int DemandDocumentID
	{
		get
		{
			return demandDocumentID;
		}
		set
		{
			demandDocumentID = value;
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
		DemandsList = new DemandDocumentDBAccess().GetListDemands(this.DemandDocumentID);
		return DemandsList;
	}

	public bool AddDemands(Demands demands)
	{
		demands.DemandDocumentID = this.DemandDocumentID;
		DemandsDBAccess demandsDBAccess = new DemandsDBAccess();
		if (demandsDBAccess.Insert(demands)>0)
			return (true);
		return (false);
	}

}
}
