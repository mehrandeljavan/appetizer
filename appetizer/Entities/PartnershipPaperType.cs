using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class PartnershipPaperType
{
	private int partnershipPaperTypeID;
	private string title;
	private List<PartnershipPapers> partnershipPapersList;

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

	public List<PartnershipPapers> PartnershipPapersList
	{
		get
		{
			return partnershipPapersList;
		}
		set
		{
			partnershipPapersList = value;
		}
	}

	public List<PartnershipPapers> GetListPartnershipPapers()
	{
		PartnershipPapersList = new PartnershipPaperTypeDBAccess().GetListPartnershipPapers(this.PartnershipPaperTypeID);
		return PartnershipPapersList;
	}

	public bool AddPartnershipPapers(PartnershipPapers partnershipPapers)
	{
		partnershipPapers.PartnershipPaperTypeID = this.PartnershipPaperTypeID;
		PartnershipPapersDBAccess partnershipPapersDBAccess = new PartnershipPapersDBAccess();
		if (partnershipPapersDBAccess.Insert(partnershipPapers)>0)
			return (true);
		return (false);
	}

}
}
