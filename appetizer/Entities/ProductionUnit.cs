using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class ProductionUnit : Heritage
{
	private Int64 productionUnitID;
	private string productionUnitTypeIDTitle;
	private int? productionUnitTypeID;
	private Int64 declarationID;
	private string documentDate;
	private string unitName;
	private string documentNumber;
	private List<CapitalAndCommodityDeposit> capitalAndCommodityDepositList;
	private List<Car> carList;
	private List<Debts> debtsList;
	private List<Demands> demandsList;
	private List<Estate> estateList;
	private List<FinancialRights> financialRightsList;
	private List<Machinery> machineryList;
	private List<OtherProperties> otherPropertiesList;
	private List<Permit> permitList;
	private List<Phone> phoneList;
	private List<Score> scoreList;
	private List<TransferRight> transferRightList;
	private List<Tree> treeList;
	private List<Well> wellList;

	public Int64 ProductionUnitID
	{
		get
		{
			return productionUnitID;
		}
		set
		{
			productionUnitID = value;
		}
	}

	public string ProductionUnitTypeIDTitle
	{
		get
		{
			return productionUnitTypeIDTitle;
		}
		set
		{
			productionUnitTypeIDTitle = value;
		}
	}

	public int? ProductionUnitTypeID
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

	public string DocumentDate
	{
		get
		{
			return documentDate;
		}
		set
		{
			documentDate = value;
		}
	}

	public string UnitName
	{
		get
		{
			return unitName;
		}
		set
		{
			unitName = value;
		}
	}

	public string DocumentNumber
	{
		get
		{
			return documentNumber;
		}
		set
		{
			documentNumber = value;
		}
	}

	public List<CapitalAndCommodityDeposit> CapitalAndCommodityDepositList
	{
		get
		{
			return capitalAndCommodityDepositList;
		}
		set
		{
			capitalAndCommodityDepositList = value;
		}
	}

	public List<Car> CarList
	{
		get
		{
			return carList;
		}
		set
		{
			carList = value;
		}
	}

	public List<Debts> DebtsList
	{
		get
		{
			return debtsList;
		}
		set
		{
			debtsList = value;
		}
	}

	public List<Demands> DemandsList
	{
		get
		{
			return demandsList;
		}
		set
		{
			demandsList = value;
		}
	}

	public List<Estate> EstateList
	{
		get
		{
			return estateList;
		}
		set
		{
			estateList = value;
		}
	}

	public List<FinancialRights> FinancialRightsList
	{
		get
		{
			return financialRightsList;
		}
		set
		{
			financialRightsList = value;
		}
	}

	public List<Machinery> MachineryList
	{
		get
		{
			return machineryList;
		}
		set
		{
			machineryList = value;
		}
	}

	public List<OtherProperties> OtherPropertiesList
	{
		get
		{
			return otherPropertiesList;
		}
		set
		{
			otherPropertiesList = value;
		}
	}

	public List<Permit> PermitList
	{
		get
		{
			return permitList;
		}
		set
		{
			permitList = value;
		}
	}

	public List<Phone> PhoneList
	{
		get
		{
			return phoneList;
		}
		set
		{
			phoneList = value;
		}
	}

	public List<Score> ScoreList
	{
		get
		{
			return scoreList;
		}
		set
		{
			scoreList = value;
		}
	}

	public List<TransferRight> TransferRightList
	{
		get
		{
			return transferRightList;
		}
		set
		{
			transferRightList = value;
		}
	}

	public List<Tree> TreeList
	{
		get
		{
			return treeList;
		}
		set
		{
			treeList = value;
		}
	}

	public List<Well> WellList
	{
		get
		{
			return wellList;
		}
		set
		{
			wellList = value;
		}
	}

	public List<CapitalAndCommodityDeposit> GetListCapitalAndCommodityDeposit()
	{
		CapitalAndCommodityDepositList = new ProductionUnitDBAccess().GetListCapitalAndCommodityDeposit(this.ProductionUnitID);
		return CapitalAndCommodityDepositList;
	}

	public List<Car> GetListCar()
	{
		CarList = new ProductionUnitDBAccess().GetListCar(this.ProductionUnitID);
		return CarList;
	}

	public List<Debts> GetListDebts()
	{
		DebtsList = new ProductionUnitDBAccess().GetListDebts(this.ProductionUnitID);
		return DebtsList;
	}

	public List<Demands> GetListDemands()
	{
		DemandsList = new ProductionUnitDBAccess().GetListDemands(this.ProductionUnitID);
		return DemandsList;
	}

	public List<Estate> GetListEstate()
	{
		EstateList = new ProductionUnitDBAccess().GetListEstate(this.ProductionUnitID);
		return EstateList;
	}

	public List<FinancialRights> GetListFinancialRights()
	{
		FinancialRightsList = new ProductionUnitDBAccess().GetListFinancialRights(this.ProductionUnitID);
		return FinancialRightsList;
	}

	public List<Machinery> GetListMachinery()
	{
		MachineryList = new ProductionUnitDBAccess().GetListMachinery(this.ProductionUnitID);
		return MachineryList;
	}

	public List<OtherProperties> GetListOtherProperties()
	{
		OtherPropertiesList = new ProductionUnitDBAccess().GetListOtherProperties(this.ProductionUnitID);
		return OtherPropertiesList;
	}

	public List<Permit> GetListPermit()
	{
		PermitList = new ProductionUnitDBAccess().GetListPermit(this.ProductionUnitID);
		return PermitList;
	}

	public List<Phone> GetListPhone()
	{
		PhoneList = new ProductionUnitDBAccess().GetListPhone(this.ProductionUnitID);
		return PhoneList;
	}

	public List<Score> GetListScore()
	{
		ScoreList = new ProductionUnitDBAccess().GetListScore(this.ProductionUnitID);
		return ScoreList;
	}

	public List<TransferRight> GetListTransferRight()
	{
		TransferRightList = new ProductionUnitDBAccess().GetListTransferRight(this.ProductionUnitID);
		return TransferRightList;
	}

	public List<Tree> GetListTree()
	{
		TreeList = new ProductionUnitDBAccess().GetListTree(this.ProductionUnitID);
		return TreeList;
	}

	public List<Well> GetListWell()
	{
		WellList = new ProductionUnitDBAccess().GetListWell(this.ProductionUnitID);
		return WellList;
	}

	public bool AddCapitalAndCommodityDeposit(CapitalAndCommodityDeposit capitalAndCommodityDeposit)
	{
		capitalAndCommodityDeposit.ProductionUnitID = this.ProductionUnitID;
		CapitalAndCommodityDepositDBAccess capitalAndCommodityDepositDBAccess = new CapitalAndCommodityDepositDBAccess();
		if (capitalAndCommodityDepositDBAccess.Insert(capitalAndCommodityDeposit)>0)
			return (true);
		return (false);
	}

	public bool AddCar(Car car)
	{
		car.ProductionUnitID = this.ProductionUnitID;
		CarDBAccess carDBAccess = new CarDBAccess();
		if (carDBAccess.Insert(car)>0)
			return (true);
		return (false);
	}

	public bool AddDebts(Debts debts)
	{
		debts.ProductionUnitID = this.ProductionUnitID;
		DebtsDBAccess debtsDBAccess = new DebtsDBAccess();
		if (debtsDBAccess.Insert(debts)>0)
			return (true);
		return (false);
	}

	public bool AddDemands(Demands demands)
	{
		demands.ProductionUnitID = this.ProductionUnitID;
		DemandsDBAccess demandsDBAccess = new DemandsDBAccess();
		if (demandsDBAccess.Insert(demands)>0)
			return (true);
		return (false);
	}

	public bool AddEstate(Estate estate)
	{
		estate.ProductionUnitID = this.ProductionUnitID;
		EstateDBAccess estateDBAccess = new EstateDBAccess();
		if (estateDBAccess.Insert(estate)>0)
			return (true);
		return (false);
	}

	public bool AddFinancialRights(FinancialRights financialRights)
	{
		financialRights.ProductionUnitID = this.ProductionUnitID;
		FinancialRightsDBAccess financialRightsDBAccess = new FinancialRightsDBAccess();
		if (financialRightsDBAccess.Insert(financialRights)>0)
			return (true);
		return (false);
	}

	public bool AddMachinery(Machinery machinery)
	{
		machinery.ProductionUnitID = this.ProductionUnitID;
		MachineryDBAccess machineryDBAccess = new MachineryDBAccess();
		if (machineryDBAccess.Insert(machinery)>0)
			return (true);
		return (false);
	}

	public bool AddOtherProperties(OtherProperties otherProperties)
	{
		otherProperties.ProductionUnitID = this.ProductionUnitID;
		OtherPropertiesDBAccess otherPropertiesDBAccess = new OtherPropertiesDBAccess();
		if (otherPropertiesDBAccess.Insert(otherProperties)>0)
			return (true);
		return (false);
	}

	public bool AddPermit(Permit permit)
	{
		permit.ProductionUnitID = this.ProductionUnitID;
		PermitDBAccess permitDBAccess = new PermitDBAccess();
		if (permitDBAccess.Insert(permit)>0)
			return (true);
		return (false);
	}

	public bool AddPhone(Phone phone)
	{
		phone.ProductionUnitID = this.ProductionUnitID;
		PhoneDBAccess phoneDBAccess = new PhoneDBAccess();
		if (phoneDBAccess.Insert(phone)>0)
			return (true);
		return (false);
	}

	public bool AddScore(Score score)
	{
		score.ProductionUnitID = this.ProductionUnitID;
		ScoreDBAccess scoreDBAccess = new ScoreDBAccess();
		if (scoreDBAccess.Insert(score)>0)
			return (true);
		return (false);
	}

	public bool AddTransferRight(TransferRight transferRight)
	{
		transferRight.ProductionUnitID = this.ProductionUnitID;
		TransferRightDBAccess transferRightDBAccess = new TransferRightDBAccess();
		if (transferRightDBAccess.Insert(transferRight)>0)
			return (true);
		return (false);
	}

	public bool AddTree(Tree tree)
	{
		tree.ProductionUnitID = this.ProductionUnitID;
		TreeDBAccess treeDBAccess = new TreeDBAccess();
		if (treeDBAccess.Insert(tree)>0)
			return (true);
		return (false);
	}

	public bool AddWell(Well well)
	{
		well.ProductionUnitID = this.ProductionUnitID;
		WellDBAccess wellDBAccess = new WellDBAccess();
		if (wellDBAccess.Insert(well)>0)
			return (true);
		return (false);
	}

}
}
