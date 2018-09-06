using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class BankAccountType
{
	private int bankAccountTypeID;
	private string title;
	private List<BankDeposit> bankDepositList;
	private List<BankDepositProfit> bankDepositProfitList;

	public int BankAccountTypeID
	{
		get
		{
			return bankAccountTypeID;
		}
		set
		{
			bankAccountTypeID = value;
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
		BankDepositList = new BankAccountTypeDBAccess().GetListBankDeposit(this.BankAccountTypeID);
		return BankDepositList;
	}

	public List<BankDepositProfit> GetListBankDepositProfit()
	{
		BankDepositProfitList = new BankAccountTypeDBAccess().GetListBankDepositProfit(this.BankAccountTypeID);
		return BankDepositProfitList;
	}

	public bool AddBankDeposit(BankDeposit bankDeposit)
	{
		bankDeposit.BankAccountTypeID = this.BankAccountTypeID;
		BankDepositDBAccess bankDepositDBAccess = new BankDepositDBAccess();
		if (bankDepositDBAccess.Insert(bankDeposit)>0)
			return (true);
		return (false);
	}

	public bool AddBankDepositProfit(BankDepositProfit bankDepositProfit)
	{
		bankDepositProfit.BankAccountTypeID = this.BankAccountTypeID;
		BankDepositProfitDBAccess bankDepositProfitDBAccess = new BankDepositProfitDBAccess();
		if (bankDepositProfitDBAccess.Insert(bankDepositProfit)>0)
			return (true);
		return (false);
	}

}
}
