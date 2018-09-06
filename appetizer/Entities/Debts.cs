using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Debts : Heritage
{
	private string debtsTypeIDTitle;
	private int? debtsTypeID;
	private Int64 declarationID;
	private Int64? productionUnitID;
	private string creditorName;
	private string creditorAddress;
	private string debtResource;

	public string DebtsTypeIDTitle
	{
		get
		{
			return debtsTypeIDTitle;
		}
		set
		{
			debtsTypeIDTitle = value;
		}
	}

	public int? DebtsTypeID
	{
		get
		{
			return debtsTypeID;
		}
		set
		{
			debtsTypeID = value;
		}
	}

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

	public string CreditorName
	{
		get
		{
			return creditorName;
		}
		set
		{
			creditorName = value;
		}
	}

	public string CreditorAddress
	{
		get
		{
			return creditorAddress;
		}
		set
		{
			creditorAddress = value;
		}
	}

	public string DebtResource
	{
		get
		{
			return debtResource;
		}
		set
		{
			debtResource = value;
		}
	}

}
}
