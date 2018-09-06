using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class AgreementType
{
	private int agreementTypeID;
	private string title;
	private List<Heir> heirList;

	public int AgreementTypeID
	{
		get
		{
			return agreementTypeID;
		}
		set
		{
			agreementTypeID = value;
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
		HeirList = new AgreementTypeDBAccess().GetListHeir(this.AgreementTypeID);
		return HeirList;
	}

	public bool AddHeir(Heir heir)
	{
		heir.AgreementTypeID = this.AgreementTypeID;
		HeirDBAccess heirDBAccess = new HeirDBAccess();
		if (heirDBAccess.Insert(heir)>0)
			return (true);
		return (false);
	}

}
}
