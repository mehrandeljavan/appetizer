using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormCommissionInvitationHandler
{
	// Handle to the FormCommissionInvitation DBAccess class
	FormCommissionInvitationDBAccess formCommissionInvitationDb = null;

	public FormCommissionInvitationHandler()
	{
		formCommissionInvitationDb = new FormCommissionInvitationDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formCommissionInvitations, we can put some logic here if needed 
	public List<FormCommissionInvitation> GetListAll()
	{
		return formCommissionInvitationDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formCommissionInvitations, we can put some logic here if needed 
	public bool Update(FormCommissionInvitation formCommissionInvitation)
	{
		return formCommissionInvitationDb.Update(formCommissionInvitation);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formCommissionInvitations, we can put some logic here if needed 
	public FormCommissionInvitation GetDetails(Int64 formCommissionInvitationID)
	{
		return formCommissionInvitationDb.GetDetails(formCommissionInvitationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formCommissionInvitations, we can put some logic here if needed 
	public bool Delete(Int64 formCommissionInvitationID)
	{
		return formCommissionInvitationDb.Delete(formCommissionInvitationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formCommissionInvitations, we can put some logic here if needed 
	public Int64 Insert(FormCommissionInvitation formCommissionInvitation)
	{
		return formCommissionInvitationDb.Insert(formCommissionInvitation);
	}

	public bool Exists(FormCommissionInvitation formCommissionInvitation)
	{
		return formCommissionInvitationDb.Exists(formCommissionInvitation);
	}

	public bool Exists(Int64 formCommissionInvitationID)
	{
		return formCommissionInvitationDb.Exists(formCommissionInvitationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of formCommissionInvitations, we can put some logic here if needed 
	public List<FormCommissionInvitation> SearchLike(FormCommissionInvitation formCommissionInvitation)
	{
		return formCommissionInvitationDb.SearchLike(formCommissionInvitation);
	}

}
}
