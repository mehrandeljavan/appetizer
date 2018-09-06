using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class CommissionTypeHandler
{
	// Handle to the CommissionType DBAccess class
	CommissionTypeDBAccess commissionTypeDb = null;

	public CommissionTypeHandler()
	{
		commissionTypeDb = new CommissionTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionTypes, we can put some logic here if needed 
	public List<CommissionType> GetListAll()
	{
		return commissionTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionTypes, we can put some logic here if needed 
	public bool Update(CommissionType commissionType)
	{
		return commissionTypeDb.Update(commissionType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionTypes, we can put some logic here if needed 
	public CommissionType GetDetails(int commisionTypeID)
	{
		return commissionTypeDb.GetDetails(commisionTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionTypes, we can put some logic here if needed 
	public bool Delete(int commisionTypeID)
	{
		return commissionTypeDb.Delete(commisionTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionTypes, we can put some logic here if needed 
	public Int64 Insert(CommissionType commissionType)
	{
		return commissionTypeDb.Insert(commissionType);
	}

	public bool Exists(CommissionType commissionType)
	{
		return commissionTypeDb.Exists(commissionType);
	}

	public bool Exists(int commisionTypeID)
	{
		return commissionTypeDb.Exists(commisionTypeID);
	}

	public List<CommissionInvitation> GetListCommissionInvitation(int commisionTypeID)
	{
		return commissionTypeDb.GetListCommissionInvitation(commisionTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionTypes, we can put some logic here if needed 
	public List<CommissionType> SearchLike(CommissionType commissionType)
	{
		return commissionTypeDb.SearchLike(commissionType);
	}

}
}
