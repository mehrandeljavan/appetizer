using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class MainOffice
{
	private int mainOfficeID;
	private string title;
	private List<TaxOffice> taxOfficeList;

	public int MainOfficeID
	{
		get
		{
			return mainOfficeID;
		}
		set
		{
			mainOfficeID = value;
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

	public List<TaxOffice> TaxOfficeList
	{
		get
		{
			return taxOfficeList;
		}
		set
		{
			taxOfficeList = value;
		}
	}

	public List<TaxOffice> GetListTaxOffice()
	{
		TaxOfficeList = new MainOfficeDBAccess().GetListTaxOffice(this.MainOfficeID);
		return TaxOfficeList;
	}

	public bool AddTaxOffice(TaxOffice taxOffice)
	{
		taxOffice.MainOfficeID = this.MainOfficeID;
		TaxOfficeDBAccess taxOfficeDBAccess = new TaxOfficeDBAccess();
		if (taxOfficeDBAccess.Insert(taxOffice)>0)
			return (true);
		return (false);
	}

}
}
