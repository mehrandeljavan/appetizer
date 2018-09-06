using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class StockInOtherCompanies : Heritage
{
	private string companyTypeIDTitle;
	private string inquiryTo;
	private int? stockNumber;
	private int? stockPercent;
	private float totalStockValue;
	private Int64 declarationID;
	private Int64? companyTypeID;
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

	public string InquiryTo
	{
		get
		{
			return inquiryTo;
		}
		set
		{
			inquiryTo = value;
		}
	}

	public int? StockNumber
	{
		get
		{
			return stockNumber;
		}
		set
		{
			stockNumber = value;
		}
	}

	public int? StockPercent
	{
		get
		{
			return stockPercent;
		}
		set
		{
			stockPercent = value;
		}
	}

	public float TotalStockValue
	{
		get
		{
			return totalStockValue;
		}
		set
		{
			totalStockValue = value;
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

	public Int64? CompanyTypeID
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
