using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Form19
{
	private Int64 form19ID;
	private string form19PrintRegisterInformationID;
	private string form19PrintRegisterDate;
	private string form19RequestNumber;
	private string form19RequestFullName;
	private string form19HeirFullName;
	private string form19TaxUnitCode;
	private string form19TaxUnitUserFullName;
	private string form19TaxGroupCode;
	private string form19DeadIssuanceCity;
	private string form19DeadDeathCity;
	private string form19Comment1;
	private string form19Comment2;
	private string form19Comment3;
	private string form19HeritagesDescription;
	private string form19RequestFamily;
	private string form19RequestCertificateNumber;
	private string form19RequestIssuanceCity;
	private string form19DeadName;
	private string form19DeadFamily;
	private string form19DeadCertificateNumber;
	private Int64 form19RegisterInformationID;
	private Int64? form19RequestNationalCode;
	private Int64? form19RegisterarUserNationalCode;
	private Int64 form19DeclarationID;
	private Int64? form19DeadNationalCode;
	private string form19RegisterInformationDate;
	private string form19DeadDeathDate;
	private string form19RequestDate;
	private string form19DossierClasses;
	private string form19TaxOfficeProvince;
	private string form19TaxOfficeCity;
	private string form19TaxOfficePhoneNumber;
	private string form19TaxOfficeAddress;
	private string form19RequestName;
	private string form19TaxGroupUserFullName;
	private string form19RequestRelationship;
	private string form19HeirShareDescription;
	private int? form19TaxOfficeCode;

	public Int64 Form19ID
	{
		get
		{
			return form19ID;
		}
		set
		{
			form19ID = value;
		}
	}

	public string Form19PrintRegisterInformationID
	{
		get
		{
			return form19PrintRegisterInformationID;
		}
		set
		{
			form19PrintRegisterInformationID = value;
		}
	}

	public string Form19PrintRegisterDate
	{
		get
		{
			return form19PrintRegisterDate;
		}
		set
		{
			form19PrintRegisterDate = value;
		}
	}

	public string Form19RequestNumber
	{
		get
		{
			return form19RequestNumber;
		}
		set
		{
			form19RequestNumber = value;
		}
	}

	public string Form19RequestFullName
	{
		get
		{
			return form19RequestFullName;
		}
		set
		{
			form19RequestFullName = value;
		}
	}

	public string Form19HeirFullName
	{
		get
		{
			return form19HeirFullName;
		}
		set
		{
			form19HeirFullName = value;
		}
	}

	public string Form19TaxUnitCode
	{
		get
		{
			return form19TaxUnitCode;
		}
		set
		{
			form19TaxUnitCode = value;
		}
	}

	public string Form19TaxUnitUserFullName
	{
		get
		{
			return form19TaxUnitUserFullName;
		}
		set
		{
			form19TaxUnitUserFullName = value;
		}
	}

	public string Form19TaxGroupCode
	{
		get
		{
			return form19TaxGroupCode;
		}
		set
		{
			form19TaxGroupCode = value;
		}
	}

	public string Form19DeadIssuanceCity
	{
		get
		{
			return form19DeadIssuanceCity;
		}
		set
		{
			form19DeadIssuanceCity = value;
		}
	}

	public string Form19DeadDeathCity
	{
		get
		{
			return form19DeadDeathCity;
		}
		set
		{
			form19DeadDeathCity = value;
		}
	}

	public string Form19Comment1
	{
		get
		{
			return form19Comment1;
		}
		set
		{
			form19Comment1 = value;
		}
	}

	public string Form19Comment2
	{
		get
		{
			return form19Comment2;
		}
		set
		{
			form19Comment2 = value;
		}
	}

	public string Form19Comment3
	{
		get
		{
			return form19Comment3;
		}
		set
		{
			form19Comment3 = value;
		}
	}

	public string Form19HeritagesDescription
	{
		get
		{
			return form19HeritagesDescription;
		}
		set
		{
			form19HeritagesDescription = value;
		}
	}

	public string Form19RequestFamily
	{
		get
		{
			return form19RequestFamily;
		}
		set
		{
			form19RequestFamily = value;
		}
	}

	public string Form19RequestCertificateNumber
	{
		get
		{
			return form19RequestCertificateNumber;
		}
		set
		{
			form19RequestCertificateNumber = value;
		}
	}

	public string Form19RequestIssuanceCity
	{
		get
		{
			return form19RequestIssuanceCity;
		}
		set
		{
			form19RequestIssuanceCity = value;
		}
	}

	public string Form19DeadName
	{
		get
		{
			return form19DeadName;
		}
		set
		{
			form19DeadName = value;
		}
	}

	public string Form19DeadFamily
	{
		get
		{
			return form19DeadFamily;
		}
		set
		{
			form19DeadFamily = value;
		}
	}

	public string Form19DeadCertificateNumber
	{
		get
		{
			return form19DeadCertificateNumber;
		}
		set
		{
			form19DeadCertificateNumber = value;
		}
	}

	public Int64 Form19RegisterInformationID
	{
		get
		{
			return form19RegisterInformationID;
		}
		set
		{
			form19RegisterInformationID = value;
		}
	}

	public Int64? Form19RequestNationalCode
	{
		get
		{
			return form19RequestNationalCode;
		}
		set
		{
			form19RequestNationalCode = value;
		}
	}

	public Int64? Form19RegisterarUserNationalCode
	{
		get
		{
			return form19RegisterarUserNationalCode;
		}
		set
		{
			form19RegisterarUserNationalCode = value;
		}
	}

	public Int64 Form19DeclarationID
	{
		get
		{
			return form19DeclarationID;
		}
		set
		{
			form19DeclarationID = value;
		}
	}

	public Int64? Form19DeadNationalCode
	{
		get
		{
			return form19DeadNationalCode;
		}
		set
		{
			form19DeadNationalCode = value;
		}
	}

	public string Form19RegisterInformationDate
	{
		get
		{
			return form19RegisterInformationDate;
		}
		set
		{
			form19RegisterInformationDate = value;
		}
	}

	public string Form19DeadDeathDate
	{
		get
		{
			return form19DeadDeathDate;
		}
		set
		{
			form19DeadDeathDate = value;
		}
	}

	public string Form19RequestDate
	{
		get
		{
			return form19RequestDate;
		}
		set
		{
			form19RequestDate = value;
		}
	}

	public string Form19DossierClasses
	{
		get
		{
			return form19DossierClasses;
		}
		set
		{
			form19DossierClasses = value;
		}
	}

	public string Form19TaxOfficeProvince
	{
		get
		{
			return form19TaxOfficeProvince;
		}
		set
		{
			form19TaxOfficeProvince = value;
		}
	}

	public string Form19TaxOfficeCity
	{
		get
		{
			return form19TaxOfficeCity;
		}
		set
		{
			form19TaxOfficeCity = value;
		}
	}

	public string Form19TaxOfficePhoneNumber
	{
		get
		{
			return form19TaxOfficePhoneNumber;
		}
		set
		{
			form19TaxOfficePhoneNumber = value;
		}
	}

	public string Form19TaxOfficeAddress
	{
		get
		{
			return form19TaxOfficeAddress;
		}
		set
		{
			form19TaxOfficeAddress = value;
		}
	}

	public string Form19RequestName
	{
		get
		{
			return form19RequestName;
		}
		set
		{
			form19RequestName = value;
		}
	}

	public string Form19TaxGroupUserFullName
	{
		get
		{
			return form19TaxGroupUserFullName;
		}
		set
		{
			form19TaxGroupUserFullName = value;
		}
	}

	public string Form19RequestRelationship
	{
		get
		{
			return form19RequestRelationship;
		}
		set
		{
			form19RequestRelationship = value;
		}
	}

	public string Form19HeirShareDescription
	{
		get
		{
			return form19HeirShareDescription;
		}
		set
		{
			form19HeirShareDescription = value;
		}
	}

	public int? Form19TaxOfficeCode
	{
		get
		{
			return form19TaxOfficeCode;
		}
		set
		{
			form19TaxOfficeCode = value;
		}
	}

}
}
