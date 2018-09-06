using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class CommissionAdjustmentHeritageHandler
{
	// Handle to the CommissionAdjustmentHeritage DBAccess class
	CommissionAdjustmentHeritageDBAccess commissionAdjustmentHeritageDb = null;

	public CommissionAdjustmentHeritageHandler()
	{
		commissionAdjustmentHeritageDb = new CommissionAdjustmentHeritageDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionAdjustmentHeritages, we can put some logic here if needed 
	public List<CommissionAdjustmentHeritage> GetListAll()
	{
		return commissionAdjustmentHeritageDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionAdjustmentHeritages, we can put some logic here if needed 
	public bool Update(CommissionAdjustmentHeritage commissionAdjustmentHeritage)
	{
		return commissionAdjustmentHeritageDb.Update(commissionAdjustmentHeritage);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionAdjustmentHeritages, we can put some logic here if needed 
	public CommissionAdjustmentHeritage GetDetails(int commissionVerdictTypeID , Int64 heirID , Int64 heritageID)
	{
		return commissionAdjustmentHeritageDb.GetDetails(commissionVerdictTypeID , heirID , heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionAdjustmentHeritages, we can put some logic here if needed 
	public bool Delete(int commissionVerdictTypeID , Int64 heirID , Int64 heritageID)
	{
		return commissionAdjustmentHeritageDb.Delete(commissionVerdictTypeID , heirID , heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionAdjustmentHeritages, we can put some logic here if needed 
	public Int64 Insert(CommissionAdjustmentHeritage commissionAdjustmentHeritage)
	{
		return commissionAdjustmentHeritageDb.Insert(commissionAdjustmentHeritage);
	}

	public bool Exists(CommissionAdjustmentHeritage commissionAdjustmentHeritage)
	{
		return commissionAdjustmentHeritageDb.Exists(commissionAdjustmentHeritage);
	}

	public bool Exists(int commissionVerdictTypeID , Int64 heirID , Int64 heritageID)
	{
		return commissionAdjustmentHeritageDb.Exists(commissionVerdictTypeID , heirID , heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionAdjustmentHeritages, we can put some logic here if needed 
	public List<CommissionAdjustmentHeritage> SearchLike(CommissionAdjustmentHeritage commissionAdjustmentHeritage)
	{
		return commissionAdjustmentHeritageDb.SearchLike(commissionAdjustmentHeritage);
	}

}
}
