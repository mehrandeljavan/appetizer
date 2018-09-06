using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Dossier
{
	private Int64 dossierID;
	private string classes;
	private string taxOfficeCodeTitle;
	private string taxOfficeCityIDTitle;
	private Int64 orderNumber;
	private string oldClasses;
	private int? taxOfficeCode;
	private bool isActive;
	private List<Dead> deadList;
	private List<Declaration> declarationList;
	private List<DossierCartable> dossierCartableList;
	private List<Payment> paymentList;
	private List<PhysicalDossierDelivery> physicalDossierDeliveryList;
	private List<Reports> reportsList;
	private List<UserDossier> userDossierList;
	private List<Utterer> uttererList;

	public Int64 DossierID
	{
		get
		{
			return dossierID;
		}
		set
		{
			dossierID = value;
		}
	}

	public string Classes
	{
		get
		{
			return classes;
		}
		set
		{
			classes = value;
		}
	}

	public string TaxOfficeCodeTitle
	{
		get
		{
			return taxOfficeCodeTitle;
		}
		set
		{
			taxOfficeCodeTitle = value;
		}
	}

	public string TaxOfficeCityIDTitle
	{
		get
		{
			return taxOfficeCityIDTitle;
		}
		set
		{
			taxOfficeCityIDTitle = value;
		}
	}

	public Int64 OrderNumber
	{
		get
		{
			return orderNumber;
		}
		set
		{
			orderNumber = value;
		}
	}

	public string OldClasses
	{
		get
		{
			return oldClasses;
		}
		set
		{
			oldClasses = value;
		}
	}

	public int? TaxOfficeCode
	{
		get
		{
			return taxOfficeCode;
		}
		set
		{
			taxOfficeCode = value;
		}
	}

	public bool IsActive
	{
		get
		{
			return isActive;
		}
		set
		{
			isActive = value;
		}
	}

	public List<Dead> DeadList
	{
		get
		{
			return deadList;
		}
		set
		{
			deadList = value;
		}
	}

	public List<Declaration> DeclarationList
	{
		get
		{
			return declarationList;
		}
		set
		{
			declarationList = value;
		}
	}

	public List<DossierCartable> DossierCartableList
	{
		get
		{
			return dossierCartableList;
		}
		set
		{
			dossierCartableList = value;
		}
	}

	public List<Payment> PaymentList
	{
		get
		{
			return paymentList;
		}
		set
		{
			paymentList = value;
		}
	}

	public List<PhysicalDossierDelivery> PhysicalDossierDeliveryList
	{
		get
		{
			return physicalDossierDeliveryList;
		}
		set
		{
			physicalDossierDeliveryList = value;
		}
	}

	public List<Reports> ReportsList
	{
		get
		{
			return reportsList;
		}
		set
		{
			reportsList = value;
		}
	}

	public List<UserDossier> UserDossierList
	{
		get
		{
			return userDossierList;
		}
		set
		{
			userDossierList = value;
		}
	}

	public List<Utterer> UttererList
	{
		get
		{
			return uttererList;
		}
		set
		{
			uttererList = value;
		}
	}

	public List<Dead> GetListDead()
	{
		DeadList = new DossierDBAccess().GetListDead(this.DossierID);
		return DeadList;
	}

	public List<Declaration> GetListDeclaration()
	{
		DeclarationList = new DossierDBAccess().GetListDeclaration(this.DossierID);
		return DeclarationList;
	}

	public List<DossierCartable> GetListDossierCartable()
	{
		DossierCartableList = new DossierDBAccess().GetListDossierCartable(this.DossierID);
		return DossierCartableList;
	}

	public List<Payment> GetListPayment()
	{
		PaymentList = new DossierDBAccess().GetListPayment(this.DossierID);
		return PaymentList;
	}

	public List<PhysicalDossierDelivery> GetListPhysicalDossierDelivery()
	{
		PhysicalDossierDeliveryList = new DossierDBAccess().GetListPhysicalDossierDelivery(this.DossierID);
		return PhysicalDossierDeliveryList;
	}

	public List<Reports> GetListReports()
	{
		ReportsList = new DossierDBAccess().GetListReports(this.DossierID);
		return ReportsList;
	}

	public List<UserDossier> GetListUserDossier()
	{
		UserDossierList = new DossierDBAccess().GetListUserDossier(this.DossierID);
		return UserDossierList;
	}

	public List<Utterer> GetListUtterer()
	{
		UttererList = new DossierDBAccess().GetListUtterer(this.DossierID);
		return UttererList;
	}

	public bool AddDead(Dead dead)
	{
		dead.DossierID = this.DossierID;
		DeadDBAccess deadDBAccess = new DeadDBAccess();
		if (deadDBAccess.Insert(dead)>0)
			return (true);
		return (false);
	}

	public bool AddDeclaration(Declaration declaration)
	{
		declaration.DossierID = this.DossierID;
		DeclarationDBAccess declarationDBAccess = new DeclarationDBAccess();
		if (declarationDBAccess.Insert(declaration)>0)
			return (true);
		return (false);
	}

	public bool AddDossierCartable(DossierCartable dossierCartable)
	{
		dossierCartable.DossierID = this.DossierID;
		DossierCartableDBAccess dossierCartableDBAccess = new DossierCartableDBAccess();
		if (dossierCartableDBAccess.Insert(dossierCartable)>0)
			return (true);
		return (false);
	}

	public bool AddPayment(Payment payment)
	{
		payment.DossierID = this.DossierID;
		PaymentDBAccess paymentDBAccess = new PaymentDBAccess();
		if (paymentDBAccess.Insert(payment)>0)
			return (true);
		return (false);
	}

	public bool AddPhysicalDossierDelivery(PhysicalDossierDelivery physicalDossierDelivery)
	{
		physicalDossierDelivery.DossierID = this.DossierID;
		PhysicalDossierDeliveryDBAccess physicalDossierDeliveryDBAccess = new PhysicalDossierDeliveryDBAccess();
		if (physicalDossierDeliveryDBAccess.Insert(physicalDossierDelivery)>0)
			return (true);
		return (false);
	}

	public bool AddReports(Reports reports)
	{
		reports.DossierID = this.DossierID;
		ReportsDBAccess reportsDBAccess = new ReportsDBAccess();
		if (reportsDBAccess.Insert(reports)>0)
			return (true);
		return (false);
	}

	public bool AddUserDossier(UserDossier userDossier)
	{
		userDossier.DossierID = this.DossierID;
		UserDossierDBAccess userDossierDBAccess = new UserDossierDBAccess();
		if (userDossierDBAccess.Insert(userDossier)>0)
			return (true);
		return (false);
	}

	public bool AddUtterer(Utterer utterer)
	{
		utterer.DossierID = this.DossierID;
		UttererDBAccess uttererDBAccess = new UttererDBAccess();
		if (uttererDBAccess.Insert(utterer)>0)
			return (true);
		return (false);
	}

}
}
