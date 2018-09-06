using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Dowry : Heritage
{
	private string weddingYearTitle;
	private float? valueInCentralBank;
	private float nonCashValue;
	private float alimony;
	private Int64 declarationID;
	private int weddingYear;
	private float amount;

	public string WeddingYearTitle
	{
		get
		{
			return weddingYearTitle;
		}
		set
		{
			weddingYearTitle = value;
		}
	}

	public float? ValueInCentralBank
	{
		get
		{
			return valueInCentralBank;
		}
		set
		{
			valueInCentralBank = value;
		}
	}

	public float NonCashValue
	{
		get
		{
			return nonCashValue;
		}
		set
		{
			nonCashValue = value;
		}
	}

	public float Alimony
	{
		get
		{
			return alimony;
		}
		set
		{
			alimony = value;
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

	public int WeddingYear
	{
		get
		{
			return weddingYear;
		}
		set
		{
			weddingYear = value;
		}
	}

	public float Amount
	{
		get
		{
			return amount;
		}
		set
		{
			amount = value;
		}
	}

}
}
