using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class DebtsType
{
	private int debtsTypeID;
	private string title;
	private List<Debts> debtsList;

	public int DebtsTypeID
	{
		get
		{
			return debtsTypeID;
		}
		set
		{
			debtsTypeID = value;
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

	public List<Debts> DebtsList
	{
		get
		{
			return debtsList;
		}
		set
		{
			debtsList = value;
		}
	}

	public List<Debts> GetListDebts()
	{
		DebtsList = new DebtsTypeDBAccess().GetListDebts(this.DebtsTypeID);
		return DebtsList;
	}

	public bool AddDebts(Debts debts)
	{
		debts.DebtsTypeID = this.DebtsTypeID;
		DebtsDBAccess debtsDBAccess = new DebtsDBAccess();
		if (debtsDBAccess.Insert(debts)>0)
			return (true);
		return (false);
	}

}
}
