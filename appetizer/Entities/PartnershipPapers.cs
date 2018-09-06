using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class PartnershipPapers : Heritage
{
	private string partnershipPaperTypeIDTitle;
	private int partnershipPaperTypeID;
	private Int64 declarationID;
	private string projectName;
	private string sellerName;
	private string paperNumber;

	public string PartnershipPaperTypeIDTitle
	{
		get
		{
			return partnershipPaperTypeIDTitle;
		}
		set
		{
			partnershipPaperTypeIDTitle = value;
		}
	}

	public int PartnershipPaperTypeID
	{
		get
		{
			return partnershipPaperTypeID;
		}
		set
		{
			partnershipPaperTypeID = value;
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

	public string ProjectName
	{
		get
		{
			return projectName;
		}
		set
		{
			projectName = value;
		}
	}

	public string SellerName
	{
		get
		{
			return sellerName;
		}
		set
		{
			sellerName = value;
		}
	}

	public string PaperNumber
	{
		get
		{
			return paperNumber;
		}
		set
		{
			paperNumber = value;
		}
	}

}
}
