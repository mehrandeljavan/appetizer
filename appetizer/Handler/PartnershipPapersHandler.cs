using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class PartnershipPapersHandler
{
	// Handle to the PartnershipPapers DBAccess class
	PartnershipPapersDBAccess partnershipPapersDb = null;

	public PartnershipPapersHandler()
	{
		partnershipPapersDb = new PartnershipPapersDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of partnershipPaperss, we can put some logic here if needed 
	public List<PartnershipPapers> GetListAll()
	{
		return partnershipPapersDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of partnershipPaperss, we can put some logic here if needed 
	public bool Update(PartnershipPapers partnershipPapers)
	{
		return partnershipPapersDb.Update(partnershipPapers);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of partnershipPaperss, we can put some logic here if needed 
	public PartnershipPapers GetDetails(Int64 heritageID)
	{
		return partnershipPapersDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of partnershipPaperss, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return partnershipPapersDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of partnershipPaperss, we can put some logic here if needed 
	public Int64 Insert(PartnershipPapers partnershipPapers)
	{
		return partnershipPapersDb.Insert(partnershipPapers);
	}

	public bool Exists(PartnershipPapers partnershipPapers)
	{
		return partnershipPapersDb.Exists(partnershipPapers);
	}

	public bool Exists(Int64 heritageID)
	{
		return partnershipPapersDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of partnershipPaperss, we can put some logic here if needed 
	public List<PartnershipPapers> SearchLike(PartnershipPapers partnershipPapers)
	{
		return partnershipPapersDb.SearchLike(partnershipPapers);
	}

}
}
