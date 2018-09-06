using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Bank
{
	private Int64 bankID;
	private string bankCategoryIDTitle;
	private Int64 bankCategoryID;
	private string title;
	private List<BankDeposit> bankDepositList;
	private List<BankDepositProfit> bankDepositProfitList;

	public Int64 BankID
	{
		get
		{
			return bankID;
		}
		set
		{
			bankID = value;
		}
	}

	public string BankCategoryIDTitle
	{
		get
		{
			return bankCategoryIDTitle;
		}
		set
		{
			bankCategoryIDTitle = value;
		}
	}

	public Int64 BankCategoryID
	{
		get
		{
			return bankCategoryID;
		}
		set
		{
			bankCategoryID = value;
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

	public List<BankDeposit> BankDepositList
	{
		get
		{
			return bankDepositList;
		}
		set
		{
			bankDepositList = value;
		}
	}

	public List<BankDepositProfit> BankDepositProfitList
	{
		get
		{
			return bankDepositProfitList;
		}
		set
		{
			bankDepositProfitList = value;
		}
	}

	public List<BankDeposit> GetListBankDeposit()
	{
		BankDepositList = new BankDBAccess().GetListBankDeposit(this.BankID);
		return BankDepositList;
	}

	public List<BankDepositProfit> GetListBankDepositProfit()
	{
		BankDepositProfitList = new BankDBAccess().GetListBankDepositProfit(this.BankID);
		return BankDepositProfitList;
	}

	public bool AddBankDeposit(BankDeposit bankDeposit)
	{
		bankDeposit.BankID = this.BankID;
		BankDepositDBAccess bankDepositDBAccess = new BankDepositDBAccess();
		if (bankDepositDBAccess.Insert(bankDeposit)>0)
			return (true);
		return (false);
	}

	public bool AddBankDepositProfit(BankDepositProfit bankDepositProfit)
	{
		bankDepositProfit.BankID = this.BankID;
		BankDepositProfitDBAccess bankDepositProfitDBAccess = new BankDepositProfitDBAccess();
		if (bankDepositProfitDBAccess.Insert(bankDepositProfit)>0)
			return (true);
		return (false);
	}

}
}
