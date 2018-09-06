using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class BankDepositProfit : Heritage
{
	private string bankIDTitle;
	private string bankAccountTypeIDTitle;
	private string bankCategoryIDTitle;
	private string bankTypeIDTitle;
	private Int64? bankCategoryID;
	private Int64? bankTypeID;
	private string branch;
	private string city;
	private string accountNumber;
	private int? bankAccountTypeID;
	private float currencyDeposit;
	private Int64 declarationID;
	private Int64? bankID;

	public string BankIDTitle
	{
		get
		{
			return bankIDTitle;
		}
		set
		{
			bankIDTitle = value;
		}
	}

	public string BankAccountTypeIDTitle
	{
		get
		{
			return bankAccountTypeIDTitle;
		}
		set
		{
			bankAccountTypeIDTitle = value;
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

	public Int64? BankCategoryID
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

	public Int64? BankTypeID
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

	public string Branch
	{
		get
		{
			return branch;
		}
		set
		{
			branch = value;
		}
	}

	public string City
	{
		get
		{
			return city;
		}
		set
		{
			city = value;
		}
	}

	public string AccountNumber
	{
		get
		{
			return accountNumber;
		}
		set
		{
			accountNumber = value;
		}
	}

	public int? BankAccountTypeID
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

	public float CurrencyDeposit
	{
		get
		{
			return currencyDeposit;
		}
		set
		{
			currencyDeposit = value;
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

	public Int64? BankID
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

}
}
