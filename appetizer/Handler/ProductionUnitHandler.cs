using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class ProductionUnitHandler
{
	// Handle to the ProductionUnit DBAccess class
	ProductionUnitDBAccess productionUnitDb = null;

	public ProductionUnitHandler()
	{
		productionUnitDb = new ProductionUnitDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of productionUnits, we can put some logic here if needed 
	public List<ProductionUnit> GetListAll()
	{
		return productionUnitDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of productionUnits, we can put some logic here if needed 
	public bool Update(ProductionUnit productionUnit)
	{
		return productionUnitDb.Update(productionUnit);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of productionUnits, we can put some logic here if needed 
	public ProductionUnit GetDetails(Int64 productionUnitID)
	{
		return productionUnitDb.GetDetails(productionUnitID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of productionUnits, we can put some logic here if needed 
	public bool Delete(Int64 productionUnitID)
	{
		return productionUnitDb.Delete(productionUnitID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of productionUnits, we can put some logic here if needed 
	public Int64 Insert(ProductionUnit productionUnit)
	{
		return productionUnitDb.Insert(productionUnit);
	}

	public bool Exists(ProductionUnit productionUnit)
	{
		return productionUnitDb.Exists(productionUnit);
	}

	public bool Exists(Int64 productionUnitID)
	{
		return productionUnitDb.Exists(productionUnitID);
	}

	public List<CapitalAndCommodityDeposit> GetListCapitalAndCommodityDeposit(Int64 productionUnitID)
	{
		return productionUnitDb.GetListCapitalAndCommodityDeposit(productionUnitID);
	}

	public List<Car> GetListCar(Int64 productionUnitID)
	{
		return productionUnitDb.GetListCar(productionUnitID);
	}

	public List<Debts> GetListDebts(Int64 productionUnitID)
	{
		return productionUnitDb.GetListDebts(productionUnitID);
	}

	public List<Demands> GetListDemands(Int64 productionUnitID)
	{
		return productionUnitDb.GetListDemands(productionUnitID);
	}

	public List<Estate> GetListEstate(Int64 productionUnitID)
	{
		return productionUnitDb.GetListEstate(productionUnitID);
	}

	public List<FinancialRights> GetListFinancialRights(Int64 productionUnitID)
	{
		return productionUnitDb.GetListFinancialRights(productionUnitID);
	}

	public List<Machinery> GetListMachinery(Int64 productionUnitID)
	{
		return productionUnitDb.GetListMachinery(productionUnitID);
	}

	public List<OtherProperties> GetListOtherProperties(Int64 productionUnitID)
	{
		return productionUnitDb.GetListOtherProperties(productionUnitID);
	}

	public List<Permit> GetListPermit(Int64 productionUnitID)
	{
		return productionUnitDb.GetListPermit(productionUnitID);
	}

	public List<Phone> GetListPhone(Int64 productionUnitID)
	{
		return productionUnitDb.GetListPhone(productionUnitID);
	}

	public List<Score> GetListScore(Int64 productionUnitID)
	{
		return productionUnitDb.GetListScore(productionUnitID);
	}

	public List<TransferRight> GetListTransferRight(Int64 productionUnitID)
	{
		return productionUnitDb.GetListTransferRight(productionUnitID);
	}

	public List<Tree> GetListTree(Int64 productionUnitID)
	{
		return productionUnitDb.GetListTree(productionUnitID);
	}

	public List<Well> GetListWell(Int64 productionUnitID)
	{
		return productionUnitDb.GetListWell(productionUnitID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of productionUnits, we can put some logic here if needed 
	public List<ProductionUnit> SearchLike(ProductionUnit productionUnit)
	{
		return productionUnitDb.SearchLike(productionUnit);
	}

}
}
