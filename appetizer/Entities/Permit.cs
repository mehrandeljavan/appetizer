using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Permit : Heritage
{
	private Int64 declarationID;
	private Int64? productionUnitID;
	private string permitName;
	private string permitReference;
	private string permitNumber;
	private string locationAddress;
	private string permitDate;

	public Int64 DeclarationID
	{
		get
		{
			return declarationID;
		}
		set
		{
			declarationID = value;
		}
	}

	public Int64? ProductionUnitID
	{
		get
		{
			return productionUnitID;
		}
		set
		{
			productionUnitID = value;
		}
	}

	public string PermitName
	{
		get
		{
			return permitName;
		}
		set
		{
			permitName = value;
		}
	}

	public string PermitReference
	{
		get
		{
			return permitReference;
		}
		set
		{
			permitReference = value;
		}
	}

	public string PermitNumber
	{
		get
		{
			return permitNumber;
		}
		set
		{
			permitNumber = value;
		}
	}

	public string LocationAddress
	{
		get
		{
			return locationAddress;
		}
		set
		{
			locationAddress = value;
		}
	}

	public string PermitDate
	{
		get
		{
			return permitDate;
		}
		set
		{
			permitDate = value;
		}
	}

}
}
