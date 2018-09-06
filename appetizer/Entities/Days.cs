using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Days
{
	private int dayID;
	private string title;
	private List<CommissionInvitation> commissionInvitationList;

	public int DayID
	{
		get
		{
			return dayID;
		}
		set
		{
			dayID = value;
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
		CommissionInvitationList = new DaysDBAccess().GetListCommissionInvitation(this.DayID);
		return CommissionInvitationList;
	}

	public bool AddCommissionInvitation(CommissionInvitation commissionInvitation)
	{
		commissionInvitation.CommissionDayID = this.DayID;
		CommissionInvitationDBAccess commissionInvitationDBAccess = new CommissionInvitationDBAccess();
		if (commissionInvitationDBAccess.Insert(commissionInvitation)>0)
			return (true);
		return (false);
	}

}
}
