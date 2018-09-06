using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class PartnershipPaperTypeHandler
{
	// Handle to the PartnershipPaperType DBAccess class
	PartnershipPaperTypeDBAccess partnershipPaperTypeDb = null;

	public PartnershipPaperTypeHandler()
	{
		partnershipPaperTypeDb = new PartnershipPaperTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of partnershipPaperTypes, we can put some logic here if needed 
	public List<PartnershipPaperType> GetListAll()
	{
		return partnershipPaperTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of partnershipPaperTypes, we can put some logic here if needed 
	public bool Update(PartnershipPaperType partnershipPaperType)
	{
		return partnershipPaperTypeDb.Update(partnershipPaperType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of partnershipPaperTypes, we can put some logic here if needed 
	public PartnershipPaperType GetDetails(int partnershipPaperTypeID)
	{
		return partnershipPaperTypeDb.GetDetails(partnershipPaperTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of partnershipPaperTypes, we can put some logic here if needed 
	public bool Delete(int partnershipPaperTypeID)
	{
		return partnershipPaperTypeDb.Delete(partnershipPaperTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of partnershipPaperTypes, we can put some logic here if needed 
	public Int64 Insert(PartnershipPaperType partnershipPaperType)
	{
		return partnershipPaperTypeDb.Insert(partnershipPaperType);
	}

	public bool Exists(PartnershipPaperType partnershipPaperType)
	{
		return partnershipPaperTypeDb.Exists(partnershipPaperType);
	}

	public bool Exists(int partnershipPaperTypeID)
	{
		return partnershipPaperTypeDb.Exists(partnershipPaperTypeID);
	}

	public List<PartnershipPapers> GetListPartnershipPapers(int partnershipPaperTypeID)
	{
		return partnershipPaperTypeDb.GetListPartnershipPapers(partnershipPaperTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of partnershipPaperTypes, we can put some logic here if needed 
	public List<PartnershipPaperType> SearchLike(PartnershipPaperType partnershipPaperType)
	{
		return partnershipPaperTypeDb.SearchLike(partnershipPaperType);
	}

}
}
