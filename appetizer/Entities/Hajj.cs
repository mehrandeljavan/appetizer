using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Hajj : Heritage
{
	private string hajjTypeIDTitle;
	private string bankInquiryHajjIDTitle;
	private string factorDate;
	private string factorNumber;
	private int? hajjTypeID;
	private int? bankInquiryHajjID;
	private Int64 declarationID;

	public string HajjTypeIDTitle
	{
		get
		{
			return hajjTypeIDTitle;
		}
		set
		{
			hajjTypeIDTitle = value;
		}
	}

	public string BankInquiryHajjIDTitle
	{
		get
		{
			return bankInquiryHajjIDTitle;
		}
		set
		{
			bankInquiryHajjIDTitle = value;
		}
	}

	public string FactorDate
	{
		get
		{
			return factorDate;
		}
		set
		{
			factorDate = value;
		}
	}

	public string FactorNumber
	{
		get
		{
			return factorNumber;
		}
		set
		{
			factorNumber = value;
		}
	}

	public int? HajjTypeID
	{
		get
		{
			return hajjTypeID;
		}
		set
		{
			hajjTypeID = value;
		}
	}

	public int? BankInquiryHajjID
	{
		get
		{
			return bankInquiryHajjID;
		}
		set
		{
			bankInquiryHajjID = value;
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
