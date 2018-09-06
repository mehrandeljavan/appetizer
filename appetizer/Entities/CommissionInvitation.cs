using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class CommissionInvitation
{
	private Int64 commissionInvitationID;
	private string invitationTypeIDTitle;
	private string commissionTypeIDTitle;
	private string commissionDayIDTitle;
	private int? invitationTypeID;
	private int? commissionTypeID;
	private int? commissionDayID;
	private Int64 heirID;
	private Int64 declarationID;
	private string commissionHour;
	private string commssionDate;
	private string commissionAddress;

	public Int64 CommissionInvitationID
	{
		get
		{
			return commissionInvitationID;
		}
		set
		{
			commissionInvitationID = value;
		}
	}

	public string InvitationTypeIDTitle
	{
		get
		{
			return invitationTypeIDTitle;
		}
		set
		{
			invitationTypeIDTitle = value;
		}
	}

	public string CommissionTypeIDTitle
	{
		get
		{
			return commissionTypeIDTitle;
		}
		set
		{
			commissionTypeIDTitle = value;
		}
	}

	public string CommissionDayIDTitle
	{
		get
		{
			return commissionDayIDTitle;
		}
		set
		{
			commissionDayIDTitle = value;
		}
	}

	public int? InvitationTypeID
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

	public int? CommissionTypeID
	{
		get
		{
			return commissionTypeID;
		}
		set
		{
			commissionTypeID = value;
		}
	}

	public int? CommissionDayID
	{
		get
		{
			return commissionDayID;
		}
		set
		{
			commissionDayID = value;
		}
	}

	public Int64 HeirID
	{
		get
		{
			return heirID;
		}
		set
		{
			heirID = value;
		}
	}

	public Int64 DeclarationID
	{
		get
		{
			return declarationID;
		}
		set
		{
			declarationID = value;
		}
	}

	public string CommissionHour
	{
		get
		{
			return commissionHour;
		}
		set
		{
			commissionHour = value;
		}
	}

	public string CommssionDate
	{
		get
		{
			return commssionDate;
		}
		set
		{
			commssionDate = value;
		}
	}

	public string CommissionAddress
	{
		get
		{
			return commissionAddress;
		}
		set
		{
			commissionAddress = value;
		}
	}

}
}
