using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class OtherDeductionsHandler
{
	// Handle to the OtherDeductions DBAccess class
	OtherDeductionsDBAccess otherDeductionsDb = null;

	public OtherDeductionsHandler()
	{
		otherDeductionsDb = new OtherDeductionsDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of otherDeductionss, we can put some logic here if needed 
	public List<OtherDeductions> GetListAll()
	{
		return otherDeductionsDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of otherDeductionss, we can put some logic here if needed 
	public bool Update(OtherDeductions otherDeductions)
	{
		return otherDeductionsDb.Update(otherDeductions);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of otherDeductionss, we can put some logic here if needed 
	public OtherDeductions GetDetails(Int64 heritageID)
	{
		return otherDeductionsDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of otherDeductionss, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return otherDeductionsDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of otherDeductionss, we can put some logic here if needed 
	public Int64 Insert(OtherDeductions otherDeductions)
	{
		return otherDeductionsDb.Insert(otherDeductions);
	}

	public bool Exists(OtherDeductions otherDeductions)
	{
		return otherDeductionsDb.Exists(otherDeductions);
	}

	public bool Exists(Int64 heritageID)
	{
		return otherDeductionsDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of otherDeductionss, we can put some logic here if needed 
	public List<OtherDeductions> SearchLike(OtherDeductions otherDeductions)
	{
		return otherDeductionsDb.SearchLike(otherDeductions);
	}

}
}
