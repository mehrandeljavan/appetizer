using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class ProductionUnitTypeHandler
{
	// Handle to the ProductionUnitType DBAccess class
	ProductionUnitTypeDBAccess productionUnitTypeDb = null;

	public ProductionUnitTypeHandler()
	{
		productionUnitTypeDb = new ProductionUnitTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of productionUnitTypes, we can put some logic here if needed 
	public List<ProductionUnitType> GetListAll()
	{
		return productionUnitTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of productionUnitTypes, we can put some logic here if needed 
	public bool Update(ProductionUnitType productionUnitType)
	{
		return productionUnitTypeDb.Update(productionUnitType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of productionUnitTypes, we can put some logic here if needed 
	public ProductionUnitType GetDetails(int productionUnitTypeID)
	{
		return productionUnitTypeDb.GetDetails(productionUnitTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of productionUnitTypes, we can put some logic here if needed 
	public bool Delete(int productionUnitTypeID)
	{
		return productionUnitTypeDb.Delete(productionUnitTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of productionUnitTypes, we can put some logic here if needed 
	public Int64 Insert(ProductionUnitType productionUnitType)
	{
		return productionUnitTypeDb.Insert(productionUnitType);
	}

	public bool Exists(ProductionUnitType productionUnitType)
	{
		return productionUnitTypeDb.Exists(productionUnitType);
	}

	public bool Exists(int productionUnitTypeID)
	{
		return productionUnitTypeDb.Exists(productionUnitTypeID);
	}

	public List<ProductionUnit> GetListProductionUnit(int productionUnitTypeID)
	{
		return productionUnitTypeDb.GetListProductionUnit(productionUnitTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of productionUnitTypes, we can put some logic here if needed 
	public List<ProductionUnitType> SearchLike(ProductionUnitType productionUnitType)
	{
		return productionUnitTypeDb.SearchLike(productionUnitType);
	}

}
}
