using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class DossierCartable
{
	private Int64 dossierID;
	private string oldClasses;
	private int? fromTaxOffice;
	private int? toTaxOffice;
	private int? oldTaxUnitCode;
	private Int64? oldOrderNumber;
	private string sendDate;
	private string reciveDate;

	public Int64 DossierID
	{
		get
		{
			return dossierID;
		}
		set
		{
			dossierID = value;
		}
	}

	public string OldClasses
	{
		get
		{
			return oldClasses;
		}
		set
		{
			oldClasses = value;
		}
	}

	public int? FromTaxOffice
	{
		get
		{
			return fromTaxOffice;
		}
		set
		{
			fromTaxOffice = value;
		}
	}

	public int? ToTaxOffice
	{
		get
		{
			return toTaxOffice;
		}
		set
		{
			toTaxOffice = value;
		}
	}

	public int? OldTaxUnitCode
	{
		get
		{
			return oldTaxUnitCode;
		}
		set
		{
			oldTaxUnitCode = value;
		}
	}

	public Int64? OldOrderNumber
	{
		get
		{
			return oldOrderNumber;
		}
		set
		{
			oldOrderNumber = value;
		}
	}

	public string SendDate
	{
		get
		{
			return sendDate;
		}
		set
		{
			sendDate = value;
		}
	}

	public string ReciveDate
	{
		get
		{
			return reciveDate;
		}
		set
		{
			reciveDate = value;
		}
	}

}
}
