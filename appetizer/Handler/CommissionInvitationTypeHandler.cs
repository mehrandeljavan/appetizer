using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class CommissionInvitationTypeHandler
{
	// Handle to the CommissionInvitationType DBAccess class
	CommissionInvitationTypeDBAccess commissionInvitationTypeDb = null;

	public CommissionInvitationTypeHandler()
	{
		commissionInvitationTypeDb = new CommissionInvitationTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionInvitationTypes, we can put some logic here if needed 
	public List<CommissionInvitationType> GetListAll()
	{
		return commissionInvitationTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionInvitationTypes, we can put some logic here if needed 
	public bool Update(CommissionInvitationType commissionInvitationType)
	{
		return commissionInvitationTypeDb.Update(commissionInvitationType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionInvitationTypes, we can put some logic here if needed 
	public CommissionInvitationType GetDetails(int invitationTypeID)
	{
		return commissionInvitationTypeDb.GetDetails(invitationTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionInvitationTypes, we can put some logic here if needed 
	public bool Delete(int invitationTypeID)
	{
		return commissionInvitationTypeDb.Delete(invitationTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionInvitationTypes, we can put some logic here if needed 
	public Int64 Insert(CommissionInvitationType commissionInvitationType)
	{
		return commissionInvitationTypeDb.Insert(commissionInvitationType);
	}

	public bool Exists(CommissionInvitationType commissionInvitationType)
	{
		return commissionInvitationTypeDb.Exists(commissionInvitationType);
	}

	public bool Exists(int invitationTypeID)
	{
		return commissionInvitationTypeDb.Exists(invitationTypeID);
	}

	public List<CommissionInvitation> GetListCommissionInvitation(int invitationTypeID)
	{
		return commissionInvitationTypeDb.GetListCommissionInvitation(invitationTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of commissionInvitationTypes, we can put some logic here if needed 
	public List<CommissionInvitationType> SearchLike(CommissionInvitationType commissionInvitationType)
	{
		return commissionInvitationTypeDb.SearchLike(commissionInvitationType);
	}

}
}
