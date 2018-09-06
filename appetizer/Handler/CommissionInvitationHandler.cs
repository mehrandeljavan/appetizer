using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class CommissionInvitationHandler
{
	// Handle to the CommissionInvitation DBAccess class
	CommissionInvitationDBAccess commissionInvitationDb = null;

	public CommissionInvitationHandler()
	{
		commissionInvitationDb = new CommissionInvitationDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionInvitations, we can put some logic here if needed 
	public List<CommissionInvitation> GetListAll()
	{
		return commissionInvitationDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionInvitations, we can put some logic here if needed 
	public bool Update(CommissionInvitation commissionInvitation)
	{
		return commissionInvitationDb.Update(commissionInvitation);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionInvitations, we can put some logic here if needed 
	public CommissionInvitation GetDetails(Int64 commissionInvitationID)
	{
		return commissionInvitationDb.GetDetails(commissionInvitationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionInvitations, we can put some logic here if needed 
	public bool Delete(Int64 commissionInvitationID)
	{
		return commissionInvitationDb.Delete(commissionInvitationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionInvitations, we can put some logic here if needed 
	public Int64 Insert(CommissionInvitation commissionInvitation)
	{
		return commissionInvitationDb.Insert(commissionInvitation);
	}

	public bool Exists(CommissionInvitation commissionInvitation)
	{
		return commissionInvitationDb.Exists(commissionInvitation);
	}

	public bool Exists(Int64 commissionInvitationID)
	{
		return commissionInvitationDb.Exists(commissionInvitationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionInvitations, we can put some logic here if needed 
	public List<CommissionInvitation> SearchLike(CommissionInvitation commissionInvitation)
	{
		return commissionInvitationDb.SearchLike(commissionInvitation);
	}

}
}
