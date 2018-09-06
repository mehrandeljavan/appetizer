using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class ReligiousDebt : Heritage
{
	private string financialObligationTitle;
	private string religiousObligationTitle;
	private float? financialObligationAmount;
	private float? religiousObligationAmount;
	private Int64 declarationID;

	public string FinancialObligationTitle
	{
		get
		{
			return financialObligationTitle;
		}
		set
		{
			financialObligationTitle = value;
		}
	}

	public string ReligiousObligationTitle
	{
		get
		{
			return religiousObligationTitle;
		}
		set
		{
			religiousObligationTitle = value;
		}
	}

	public float? FinancialObligationAmount
	{
		get
		{
			return financialObligationAmount;
		}
		set
		{
			financialObligationAmount = value;
		}
	}

	public float? ReligiousObligationAmount
	{
		get
		{
			return religiousObligationAmount;
		}
		set
		{
			religiousObligationAmount = value;
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

}
}
