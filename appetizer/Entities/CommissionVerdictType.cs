using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class CommissionVerdictType
{
	private int commissionVerdictTypeID;
	private string title;
	private List<CommissionAdjustmentHeritage> commissionAdjustmentHeritageList;
	private List<CommissionVerdict> commissionVerdictList;

	public int CommissionVerdictTypeID
	{
		get
		{
			return commissionVerdictTypeID;
		}
		set
		{
			commissionVerdictTypeID = value;
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

	public List<CommissionAdjustmentHeritage> CommissionAdjustmentHeritageList
	{
		get
		{
			return commissionAdjustmentHeritageList;
		}
		set
		{
			commissionAdjustmentHeritageList = value;
		}
	}

	public List<CommissionVerdict> CommissionVerdictList
	{
		get
		{
			return commissionVerdictList;
		}
		set
		{
			commissionVerdictList = value;
		}
	}

	public List<CommissionAdjustmentHeritage> GetListCommissionAdjustmentHeritage()
	{
		CommissionAdjustmentHeritageList = new CommissionVerdictTypeDBAccess().GetListCommissionAdjustmentHeritage(this.CommissionVerdictTypeID);
		return CommissionAdjustmentHeritageList;
	}

	public List<CommissionVerdict> GetListCommissionVerdict()
	{
		CommissionVerdictList = new CommissionVerdictTypeDBAccess().GetListCommissionVerdict(this.CommissionVerdictTypeID);
		return CommissionVerdictList;
	}

	public bool AddCommissionAdjustmentHeritage(CommissionAdjustmentHeritage commissionAdjustmentHeritage)
	{
		commissionAdjustmentHeritage.CommissionVerdictTypeID = this.CommissionVerdictTypeID;
		CommissionAdjustmentHeritageDBAccess commissionAdjustmentHeritageDBAccess = new CommissionAdjustmentHeritageDBAccess();
		if (commissionAdjustmentHeritageDBAccess.Insert(commissionAdjustmentHeritage)>0)
			return (true);
		return (false);
	}

	public bool AddCommissionVerdict(CommissionVerdict commissionVerdict)
	{
		commissionVerdict.CommissionVerdictTypeID = this.CommissionVerdictTypeID;
		CommissionVerdictDBAccess commissionVerdictDBAccess = new CommissionVerdictDBAccess();
		if (commissionVerdictDBAccess.Insert(commissionVerdict)>0)
			return (true);
		return (false);
	}

}
}
