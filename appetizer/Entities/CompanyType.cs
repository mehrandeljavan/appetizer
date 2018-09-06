using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class CompanyType
{
	private Int64 companyTypeID;
	private string title;
	private int category;
	private List<StockInOtherCompanies> stockInOtherCompaniesList;
	private List<StockProfit> stockProfitList;

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

	public int Category
	{
		get
		{
			return category;
		}
		set
		{
			category = value;
		}
	}

	public List<StockInOtherCompanies> StockInOtherCompaniesList
	{
		get
		{
			return stockInOtherCompaniesList;
		}
		set
		{
			stockInOtherCompaniesList = value;
		}
	}

	public List<StockProfit> StockProfitList
	{
		get
		{
			return stockProfitList;
		}
		set
		{
			stockProfitList = value;
		}
	}

	public List<StockInOtherCompanies> GetListStockInOtherCompanies()
	{
		StockInOtherCompaniesList = new CompanyTypeDBAccess().GetListStockInOtherCompanies(this.CompanyTypeID);
		return StockInOtherCompaniesList;
	}

	public List<StockProfit> GetListStockProfit()
	{
		StockProfitList = new CompanyTypeDBAccess().GetListStockProfit(this.CompanyTypeID);
		return StockProfitList;
	}

	public bool AddStockInOtherCompanies(StockInOtherCompanies stockInOtherCompanies)
	{
		stockInOtherCompanies.CompanyTypeID = this.CompanyTypeID;
		StockInOtherCompaniesDBAccess stockInOtherCompaniesDBAccess = new StockInOtherCompaniesDBAccess();
		if (stockInOtherCompaniesDBAccess.Insert(stockInOtherCompanies)>0)
			return (true);
		return (false);
	}

	public bool AddStockProfit(StockProfit stockProfit)
	{
		stockProfit.CompanyTypeID = this.CompanyTypeID;
		StockProfitDBAccess stockProfitDBAccess = new StockProfitDBAccess();
		if (stockProfitDBAccess.Insert(stockProfit)>0)
			return (true);
		return (false);
	}

}
}
