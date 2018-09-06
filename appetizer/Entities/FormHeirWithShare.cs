using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormHeirWithShare
{
	private Int64 formHeirWithShareID;
	private Int64 formHeirWithShareFormBillTaxID;
	private Int64? formHeirWithShareNationalCode;
	private string formHeirWithShareFullName;
	private string formHeirWithShareRelationTitle;
	private string formHeirWithShareComment;
	private string formHeirWithShareTaxTotalLetter;
	private float? formHeirWithShareHeirShare;
	private float? formHeirWithShareReduction;
	private float? formHeirWithShareRemaining;
	private float? formHeirWithShareTaxTotal;
	private float? formHeirWithShareTaxTypeB;
	private float? formHeirWithShareTaxTypeA;

	public Int64 FormHeirWithShareID
	{
		get
		{
			return formHeirWithShareID;
		}
		set
		{
			formHeirWithShareID = value;
		}
	}

	public Int64 FormHeirWithShareFormBillTaxID
	{
		get
		{
			return formHeirWithShareFormBillTaxID;
		}
		set
		{
			formHeirWithShareFormBillTaxID = value;
		}
	}

	public Int64? FormHeirWithShareNationalCode
	{
		get
		{
			return formHeirWithShareNationalCode;
		}
		set
		{
			formHeirWithShareNationalCode = value;
		}
	}

	public string FormHeirWithShareFullName
	{
		get
		{
			return formHeirWithShareFullName;
		}
		set
		{
			formHeirWithShareFullName = value;
		}
	}

	public string FormHeirWithShareRelationTitle
	{
		get
		{
			return formHeirWithShareRelationTitle;
		}
		set
		{
			formHeirWithShareRelationTitle = value;
		}
	}

	public string FormHeirWithShareComment
	{
		get
		{
			return formHeirWithShareComment;
		}
		set
		{
			formHeirWithShareComment = value;
		}
	}

	public string FormHeirWithShareTaxTotalLetter
	{
		get
		{
			return formHeirWithShareTaxTotalLetter;
		}
		set
		{
			formHeirWithShareTaxTotalLetter = value;
		}
	}

	public float? FormHeirWithShareHeirShare
	{
		get
		{
			return formHeirWithShareHeirShare;
		}
		set
		{
			formHeirWithShareHeirShare = value;
		}
	}

	public float? FormHeirWithShareReduction
	{
		get
		{
			return formHeirWithShareReduction;
		}
		set
		{
			formHeirWithShareReduction = value;
		}
	}

	public float? FormHeirWithShareRemaining
	{
		get
		{
			return formHeirWithShareRemaining;
		}
		set
		{
			formHeirWithShareRemaining = value;
		}
	}

	public float? FormHeirWithShareTaxTotal
	{
		get
		{
			return formHeirWithShareTaxTotal;
		}
		set
		{
			formHeirWithShareTaxTotal = value;
		}
	}

	public float? FormHeirWithShareTaxTypeB
	{
		get
		{
			return formHeirWithShareTaxTypeB;
		}
		set
		{
			formHeirWithShareTaxTypeB = value;
		}
	}

	public float? FormHeirWithShareTaxTypeA
	{
		get
		{
			return formHeirWithShareTaxTypeA;
		}
		set
		{
			formHeirWithShareTaxTypeA = value;
		}
	}

}
}
