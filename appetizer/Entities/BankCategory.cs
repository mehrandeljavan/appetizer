using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class BankCategory
{
	private Int64 bankCategoryID;
	private string bankTypeIDTitle;
	private Int64 bankTypeID;
	private string title;
	private List<Bank> bankList;
	private List<BankDeposit> bankDepositList;
	private List<BankDepositProfit> bankDepositProfitList;

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

	public string BankTypeIDTitle
	{
		get
		{
			return bankTypeIDTitle;
		}
		set
		{
			bankTypeIDTitle = value;
		}
	}

	public Int64 BankTypeID
	{
		get
		{
			return bankTypeID;
		}
		set
		{
			bankTypeID = value;
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

	public List<Bank> BankList
	{
		get
		{
			return bankList;
		}
		set
		{
			bankList = value;
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

	public List<Bank> GetListBank()
	{
		BankList = new BankCategoryDBAccess().GetListBank(this.BankCategoryID);
		return BankList;
	}

	public List<BankDeposit> GetListBankDeposit()
	{
		BankDepositList = new BankCategoryDBAccess().GetListBankDeposit(this.BankCategoryID);
		return BankDepositList;
	}

	public List<BankDepositProfit> GetListBankDepositProfit()
	{
		BankDepositProfitList = new BankCategoryDBAccess().GetListBankDepositProfit(this.BankCategoryID);
		return BankDepositProfitList;
	}

	public bool AddBank(Bank bank)
	{
		bank.BankCategoryID = this.BankCategoryID;
		BankDBAccess bankDBAccess = new BankDBAccess();
		if (bankDBAccess.Insert(bank)>0)
			return (true);
		return (false);
	}

	public bool AddBankDeposit(BankDeposit bankDeposit)
	{
		bankDeposit.BankCategoryID = this.BankCategoryID;
		BankDepositDBAccess bankDepositDBAccess = new BankDepositDBAccess();
		if (bankDepositDBAccess.Insert(bankDeposit)>0)
			return (true);
		return (false);
	}

	public bool AddBankDepositProfit(BankDepositProfit bankDepositProfit)
	{
		bankDepositProfit.BankCategoryID = this.BankCategoryID;
		BankDepositProfitDBAccess bankDepositProfitDBAccess = new BankDepositProfitDBAccess();
		if (bankDepositProfitDBAccess.Insert(bankDepositProfit)>0)
			return (true);
		return (false);
	}

}
}
