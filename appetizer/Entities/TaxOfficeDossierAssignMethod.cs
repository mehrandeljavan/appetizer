using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class TaxOfficeDossierAssignMethod
{
	private int taxOfficeDossierAssignMethodID;
	private string title;
	private List<TaxOffice> taxOfficeList;

	public int TaxOfficeDossierAssignMethodID
	{
		get
		{
			return taxOfficeDossierAssignMethodID;
		}
		set
		{
			taxOfficeDossierAssignMethodID = value;
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
		TaxOfficeList = new TaxOfficeDossierAssignMethodDBAccess().GetListTaxOffice(this.TaxOfficeDossierAssignMethodID);
		return TaxOfficeList;
	}

	public bool AddTaxOffice(TaxOffice taxOffice)
	{
		taxOffice.TaxOfficeDossierAssignMethodID = this.TaxOfficeDossierAssignMethodID;
		TaxOfficeDBAccess taxOfficeDBAccess = new TaxOfficeDBAccess();
		if (taxOfficeDBAccess.Insert(taxOffice)>0)
			return (true);
		return (false);
	}

}
}
