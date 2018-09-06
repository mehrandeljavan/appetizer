using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class CommissionType
{
	private int commisionTypeID;
	private string title;
	private List<CommissionInvitation> commissionInvitationList;

	public int CommisionTypeID
	{
		get
		{
			return commisionTypeID;
		}
		set
		{
			commisionTypeID = value;
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
		CommissionInvitationList = new CommissionTypeDBAccess().GetListCommissionInvitation(this.CommisionTypeID);
		return CommissionInvitationList;
	}

	public bool AddCommissionInvitation(CommissionInvitation commissionInvitation)
	{
		commissionInvitation.CommissionTypeID = this.CommisionTypeID;
		CommissionInvitationDBAccess commissionInvitationDBAccess = new CommissionInvitationDBAccess();
		if (commissionInvitationDBAccess.Insert(commissionInvitation)>0)
			return (true);
		return (false);
	}

}
}
