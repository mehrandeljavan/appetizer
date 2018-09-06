using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class ProductionUnitType
{
	private int productionUnitTypeID;
	private int? category;
	private string title;
	private List<ProductionUnit> productionUnitList;

	public int ProductionUnitTypeID
	{
		get
		{
			return productionUnitTypeID;
		}
		set
		{
			productionUnitTypeID = value;
		}
	}

	public int? Category
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

	public List<ProductionUnit> ProductionUnitList
	{
		get
		{
			return productionUnitList;
		}
		set
		{
			productionUnitList = value;
		}
	}

	public List<ProductionUnit> GetListProductionUnit()
	{
		ProductionUnitList = new ProductionUnitTypeDBAccess().GetListProductionUnit(this.ProductionUnitTypeID);
		return ProductionUnitList;
	}

	public bool AddProductionUnit(ProductionUnit productionUnit)
	{
		productionUnit.ProductionUnitTypeID = this.ProductionUnitTypeID;
		ProductionUnitDBAccess productionUnitDBAccess = new ProductionUnitDBAccess();
		if (productionUnitDBAccess.Insert(productionUnit)>0)
			return (true);
		return (false);
	}

}
}
