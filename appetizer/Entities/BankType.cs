using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class BankType
{
	private Int64 bankTypeID;
	private string title;
	private List<BankCategory> bankCategoryList;
	private List<BankDeposit> bankDepositList;
	private List<BankDepositProfit> bankDepositProfitList;

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

	public List<BankCategory> BankCategoryList
	{
		get
		{
			return bankCategoryList;
		}
		set
		{
			bankCategoryList = value;
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

	public List<BankCategory> GetListBankCategory()
	{
		BankCategoryList = new BankTypeDBAccess().GetListBankCategory(this.BankTypeID);
		return BankCategoryList;
	}

	public List<BankDeposit> GetListBankDeposit()
	{
		BankDepositList = new BankTypeDBAccess().GetListBankDeposit(this.BankTypeID);
		return BankDepositList;
	}

	public List<BankDepositProfit> GetListBankDepositProfit()
	{
		BankDepositProfitList = new BankTypeDBAccess().GetListBankDepositProfit(this.BankTypeID);
		return BankDepositProfitList;
	}

	public bool AddBankCategory(BankCategory bankCategory)
	{
		bankCategory.BankTypeID = this.BankTypeID;
		BankCategoryDBAccess bankCategoryDBAccess = new BankCategoryDBAccess();
		if (bankCategoryDBAccess.Insert(bankCategory)>0)
			return (true);
		return (false);
	}

	public bool AddBankDeposit(BankDeposit bankDeposit)
	{
		bankDeposit.BankTypeID = this.BankTypeID;
		BankDepositDBAccess bankDepositDBAccess = new BankDepositDBAccess();
		if (bankDepositDBAccess.Insert(bankDeposit)>0)
			return (true);
		return (false);
	}

	public bool AddBankDepositProfit(BankDepositProfit bankDepositProfit)
	{
		bankDepositProfit.BankTypeID = this.BankTypeID;
		BankDepositProfitDBAccess bankDepositProfitDBAccess = new BankDepositProfitDBAccess();
		if (bankDepositProfitDBAccess.Insert(bankDepositProfit)>0)
			return (true);
		return (false);
	}

}
}
