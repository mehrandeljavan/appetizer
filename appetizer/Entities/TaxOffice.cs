using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class TaxOffice
{
	private int taxOfficeCode;
	private string title;
	private string cityIDTitle;
	private string taxOfficeDossierAssignMethodIDTitle;
	private string provinceIDTitle;
	private string parentTaxOfficeTitle;
	private string privateTitle;
	private string address;
	private string comment;
	private string fax;
	private string website;
	private string email;
	private int cityID;
	private int? parentTaxOfficeCode;
	private int? taxOfficeDossierAssignMethodID;
	private int? provinceID;
	private int? mainOfficeID;
	private Int64? bossNationalCode;
	private string zipCode;
	private string phoneNumber;
	private List<Dossier> dossierList;
	private List<UserTaxOfficeActivityRolePart> userTaxOfficeActivityRolePartList;
	private List<UserTaxOfficeRolePart> userTaxOfficeRolePartList;

	public int TaxOfficeCode
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

	public string CityIDTitle
	{
		get
		{
			return cityIDTitle;
		}
		set
		{
			cityIDTitle = value;
		}
	}

	public string TaxOfficeDossierAssignMethodIDTitle
	{
		get
		{
			return taxOfficeDossierAssignMethodIDTitle;
		}
		set
		{
			taxOfficeDossierAssignMethodIDTitle = value;
		}
	}

	public string ProvinceIDTitle
	{
		get
		{
			return provinceIDTitle;
		}
		set
		{
			provinceIDTitle = value;
		}
	}

	public string ParentTaxOfficeTitle
	{
		get
		{
			return parentTaxOfficeTitle;
		}
		set
		{
			parentTaxOfficeTitle = value;
		}
	}

	public string PrivateTitle
	{
		get
		{
			return privateTitle;
		}
		set
		{
			privateTitle = value;
		}
	}

	public string Address
	{
		get
		{
			return address;
		}
		set
		{
			address = value;
		}
	}

	public string Comment
	{
		get
		{
			return comment;
		}
		set
		{
			comment = value;
		}
	}

	public string Fax
	{
		get
		{
			return fax;
		}
		set
		{
			fax = value;
		}
	}

	public string Website
	{
		get
		{
			return website;
		}
		set
		{
			website = value;
		}
	}

	public string Email
	{
		get
		{
			return email;
		}
		set
		{
			email = value;
		}
	}

	public int CityID
	{
		get
		{
			return cityID;
		}
		set
		{
			cityID = value;
		}
	}

	public int? ParentTaxOfficeCode
	{
		get
		{
			return parentTaxOfficeCode;
		}
		set
		{
			parentTaxOfficeCode = value;
		}
	}

	public int? TaxOfficeDossierAssignMethodID
	{
		get
		{
			return taxOfficeDossierAssignMethodID;
		}
		set
		{
			taxOfficeDossierAssignMethodID = value;
		}
	}

	public int? ProvinceID
	{
		get
		{
			return provinceID;
		}
		set
		{
			provinceID = value;
		}
	}

	public int? MainOfficeID
	{
		get
		{
			return mainOfficeID;
		}
		set
		{
			mainOfficeID = value;
		}
	}

	public Int64? BossNationalCode
	{
		get
		{
			return bossNationalCode;
		}
		set
		{
			bossNationalCode = value;
		}
	}

	public string ZipCode
	{
		get
		{
			return zipCode;
		}
		set
		{
			zipCode = value;
		}
	}

	public string PhoneNumber
	{
		get
		{
			return phoneNumber;
		}
		set
		{
			phoneNumber = value;
		}
	}

	public List<Dossier> DossierList
	{
		get
		{
			return dossierList;
		}
		set
		{
			dossierList = value;
		}
	}

	public List<UserTaxOfficeActivityRolePart> UserTaxOfficeActivityRolePartList
	{
		get
		{
			return userTaxOfficeActivityRolePartList;
		}
		set
		{
			userTaxOfficeActivityRolePartList = value;
		}
	}

	public List<UserTaxOfficeRolePart> UserTaxOfficeRolePartList
	{
		get
		{
			return userTaxOfficeRolePartList;
		}
		set
		{
			userTaxOfficeRolePartList = value;
		}
	}

	public List<Dossier> GetListDossier()
	{
		DossierList = new TaxOfficeDBAccess().GetListDossier(this.TaxOfficeCode);
		return DossierList;
	}

	public List<UserTaxOfficeActivityRolePart> GetListUserTaxOfficeActivityRolePart()
	{
		UserTaxOfficeActivityRolePartList = new TaxOfficeDBAccess().GetListUserTaxOfficeActivityRolePart(this.TaxOfficeCode);
		return UserTaxOfficeActivityRolePartList;
	}

	public List<UserTaxOfficeRolePart> GetListUserTaxOfficeRolePart()
	{
		UserTaxOfficeRolePartList = new TaxOfficeDBAccess().GetListUserTaxOfficeRolePart(this.TaxOfficeCode);
		return UserTaxOfficeRolePartList;
	}

	public bool AddDossier(Dossier dossier)
	{
		dossier.TaxOfficeCode = this.TaxOfficeCode;
		DossierDBAccess dossierDBAccess = new DossierDBAccess();
		if (dossierDBAccess.Insert(dossier)>0)
			return (true);
		return (false);
	}

	public bool AddUserTaxOfficeActivityRolePart(UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart)
	{
		userTaxOfficeActivityRolePart.TaxOfficeCode = this.TaxOfficeCode;
		UserTaxOfficeActivityRolePartDBAccess userTaxOfficeActivityRolePartDBAccess = new UserTaxOfficeActivityRolePartDBAccess();
		if (userTaxOfficeActivityRolePartDBAccess.Insert(userTaxOfficeActivityRolePart)>0)
			return (true);
		return (false);
	}

	public bool AddUserTaxOfficeRolePart(UserTaxOfficeRolePart userTaxOfficeRolePart)
	{
		userTaxOfficeRolePart.TaxOfficeCode = this.TaxOfficeCode;
		UserTaxOfficeRolePartDBAccess userTaxOfficeRolePartDBAccess = new UserTaxOfficeRolePartDBAccess();
		if (userTaxOfficeRolePartDBAccess.Insert(userTaxOfficeRolePart)>0)
			return (true);
		return (false);
	}

}
}
