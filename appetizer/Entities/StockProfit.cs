using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class StockProfit : Heritage
{
	private string companyTypeIDTitle;
	private string branch;
	private string branchCity;
	private Int64 declarationID;
	private Int64 companyTypeID;
	private string companyName;
	private string companyRegisterNumber;

	public string CompanyTypeIDTitle
	{
		get
		{
			return companyTypeIDTitle;
		}
		set
		{
			companyTypeIDTitle = value;
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

	public string BranchCity
	{
		get
		{
			return branchCity;
		}
		set
		{
			branchCity = value;
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

	public Int64 CompanyTypeID
	{
		get
		{
			return companyTypeID;
		}
		set
		{
			companyTypeID = value;
		}
	}

	public string CompanyName
	{
		get
		{
			return companyName;
		}
		set
		{
			companyName = value;
		}
	}

	public string CompanyRegisterNumber
	{
		get
		{
			return companyRegisterNumber;
		}
		set
		{
			companyRegisterNumber = value;
		}
	}

}
}
