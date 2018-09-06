using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class CommissionVerdictHandler
{
	// Handle to the CommissionVerdict DBAccess class
	CommissionVerdictDBAccess commissionVerdictDb = null;

	public CommissionVerdictHandler()
	{
		commissionVerdictDb = new CommissionVerdictDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionVerdicts, we can put some logic here if needed 
	public List<CommissionVerdict> GetListAll()
	{
		return commissionVerdictDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionVerdicts, we can put some logic here if needed 
	public bool Update(CommissionVerdict commissionVerdict)
	{
		return commissionVerdictDb.Update(commissionVerdict);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionVerdicts, we can put some logic here if needed 
	public CommissionVerdict GetDetails(int commissionVerdictTypeID , Int64 heirID)
	{
		return commissionVerdictDb.GetDetails(commissionVerdictTypeID , heirID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionVerdicts, we can put some logic here if needed 
	public bool Delete(int commissionVerdictTypeID , Int64 heirID)
	{
		return commissionVerdictDb.Delete(commissionVerdictTypeID , heirID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionVerdicts, we can put some logic here if needed 
	public Int64 Insert(CommissionVerdict commissionVerdict)
	{
		return commissionVerdictDb.Insert(commissionVerdict);
	}

	public bool Exists(CommissionVerdict commissionVerdict)
	{
		return commissionVerdictDb.Exists(commissionVerdict);
	}

	public bool Exists(int commissionVerdictTypeID , Int64 heirID)
	{
		return commissionVerdictDb.Exists(commissionVerdictTypeID , heirID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionVerdicts, we can put some logic here if needed 
	public List<CommissionVerdict> SearchLike(CommissionVerdict commissionVerdict)
	{
		return commissionVerdictDb.SearchLike(commissionVerdict);
	}

}
}
