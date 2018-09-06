using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class CommissionInvitationType
{
	private int invitationTypeID;
	private string title;
	private List<CommissionInvitation> commissionInvitationList;

	public int InvitationTypeID
	{
		get
		{
			return invitationTypeID;
		}
		set
		{
			invitationTypeID = value;
		}
	}

	public string Title
	{
		get
		{
			return title;
		}
		set
		{
			title = value;
		}
	}

	public List<CommissionInvitation> CommissionInvitationList
	{
		get
		{
			return commissionInvitationList;
		}
		set
		{
			commissionInvitationList = value;
		}
	}

	public List<CommissionInvitation> GetListCommissionInvitation()
	{
		CommissionInvitationList = new CommissionInvitationTypeDBAccess().GetListCommissionInvitation(this.InvitationTypeID);
		return CommissionInvitationList;
	}

	public bool AddCommissionInvitation(CommissionInvitation commissionInvitation)
	{
		commissionInvitation.InvitationTypeID = this.InvitationTypeID;
		CommissionInvitationDBAccess commissionInvitationDBAccess = new CommissionInvitationDBAccess();
		if (commissionInvitationDBAccess.Insert(commissionInvitation)>0)
			return (true);
		return (false);
	}

}
}
