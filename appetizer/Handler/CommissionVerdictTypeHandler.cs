using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class CommissionVerdictTypeHandler
{
	// Handle to the CommissionVerdictType DBAccess class
	CommissionVerdictTypeDBAccess commissionVerdictTypeDb = null;

	public CommissionVerdictTypeHandler()
	{
		commissionVerdictTypeDb = new CommissionVerdictTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionVerdictTypes, we can put some logic here if needed 
	public List<CommissionVerdictType> GetListAll()
	{
		return commissionVerdictTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionVerdictTypes, we can put some logic here if needed 
	public bool Update(CommissionVerdictType commissionVerdictType)
	{
		return commissionVerdictTypeDb.Update(commissionVerdictType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionVerdictTypes, we can put some logic here if needed 
	public CommissionVerdictType GetDetails(int commissionVerdictTypeID)
	{
		return commissionVerdictTypeDb.GetDetails(commissionVerdictTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionVerdictTypes, we can put some logic here if needed 
	public bool Delete(int commissionVerdictTypeID)
	{
		return commissionVerdictTypeDb.Delete(commissionVerdictTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionVerdictTypes, we can put some logic here if needed 
	public Int64 Insert(CommissionVerdictType commissionVerdictType)
	{
		return commissionVerdictTypeDb.Insert(commissionVerdictType);
	}

	public bool Exists(CommissionVerdictType commissionVerdictType)
	{
		return commissionVerdictTypeDb.Exists(commissionVerdictType);
	}

	public bool Exists(int commissionVerdictTypeID)
	{
		return commissionVerdictTypeDb.Exists(commissionVerdictTypeID);
	}

	public List<CommissionAdjustmentHeritage> GetListCommissionAdjustmentHeritage(int commissionVerdictTypeID)
	{
		return commissionVerdictTypeDb.GetListCommissionAdjustmentHeritage(commissionVerdictTypeID);
	}

	public List<CommissionVerdict> GetListCommissionVerdict(int commissionVerdictTypeID)
	{
		return commissionVerdictTypeDb.GetListCommissionVerdict(commissionVerdictTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionVerdictTypes, we can put some logic here if needed 
	public List<CommissionVerdictType> SearchLike(CommissionVerdictType commissionVerdictType)
	{
		return commissionVerdictTypeDb.SearchLike(commissionVerdictType);
	}

}
}
