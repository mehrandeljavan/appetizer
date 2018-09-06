using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormCommissionInvitation
{
	private Int64 formCommissionInvitationID;
	private string formCommissionInvitationPrintRegisterInformationID;
	private string formCommissionInvitationPrintRegisterDate;
	private string formCommissionInvitationTaxResource;
	private string formCommissionInvitationDeadDeathYear;
	private string formCommissionInvitationCommissionAddress;
	private string formCommissionInvitationUser1FullName;
	private string formCommissionInvitationUser1Code;
	private string formCommissionInvitationUser2FullName;
	private string formCommissionInvitationUser2Code;
	private string formCommissionInvitationCommissionType3;
	private string formCommissionInvitationCommissionType4;
	private string formCommissionInvitationCommissionType5;
	private string formCommissionInvitationCommissionType6;
	private string formCommissionInvitationCommissionDay;
	private string formCommissionInvitationCommissionTimePeriod;
	private string formCommissionInvitationHeirJobZipCode;
	private string formCommissionInvitationInvitationType1;
	private string formCommissionInvitationInvitationType2;
	private string formCommissionInvitationInvitationType3;
	private string formCommissionInvitationCommissionType1;
	private string formCommissionInvitationCommissionType2;
	private string formCommissionInvitationDeadUniqueCode;
	private string formCommissionInvitationHeirJobAddress;
	private string formCommissionInvitationHeirHomeAddress;
	private string formCommissionInvitationHeirHomePhoneNumber;
	private string formCommissionInvitationHeirHomeJobPhoneNumber;
	private string formCommissionInvitationHeirHomeZipCode;
	private string formCommissionInvitationHeirFatherName;
	private string formCommissionInvitationHeirIdentifier;
	private string formCommissionInvitationHeirCertificateNumber;
	private string formCommissionInvitationHeirIssuanceCity;
	private string formCommissionInvitationDeadFullName;
	private string formCommissionInvitationHeirRelation;
	private string formCommissionInvitationHeirBirthDate;
	private string formCommissionInvitationCommissionDate;
	private string formCommissionInvitationCommissionTime;
	private string formCommissionInvitationPenaltyDate;
	private Int64 formCommissionInvitationRegisterInformarionID;
	private Int64? formCommissionInvitationHeirNationalCode;
	private Int64? formCommissionInvitationDeclarationID;
	private string formCommissionInvitationRegisterDate;
	private string formCommissionInvitationDossierClasses;
	private string formCommissionInvitationTaxOfficeProvince;
	private string formCommissionInvitationTaxOfficeCity;
	private string formCommissionInvitationTaxOfficeAddress;
	private string formCommissionInvitationTaxOfficePhoneNumber;
	private string formCommissionInvitationHeirFullName;
	private int? formCommissionInvitationTaxUnitCode;
	private float? formCommissionInvitationHeirShare;
	private float? formCommissionInvitationHeirExemption;
	private float? formCommissionInvitationHeirIncludedIncome;
	private float? formCommissionInvitationHeirTax;
	private float? formCommissionInvitationPenaltySum;

	public Int64 FormCommissionInvitationID
	{
		get
		{
			return formCommissionInvitationID;
		}
		set
		{
			formCommissionInvitationID = value;
		}
	}

	public string FormCommissionInvitationPrintRegisterInformationID
	{
		get
		{
			return formCommissionInvitationPrintRegisterInformationID;
		}
		set
		{
			formCommissionInvitationPrintRegisterInformationID = value;
		}
	}

	public string FormCommissionInvitationPrintRegisterDate
	{
		get
		{
			return formCommissionInvitationPrintRegisterDate;
		}
		set
		{
			formCommissionInvitationPrintRegisterDate = value;
		}
	}

	public string FormCommissionInvitationTaxResource
	{
		get
		{
			return formCommissionInvitationTaxResource;
		}
		set
		{
			formCommissionInvitationTaxResource = value;
		}
	}

	public string FormCommissionInvitationDeadDeathYear
	{
		get
		{
			return formCommissionInvitationDeadDeathYear;
		}
		set
		{
			formCommissionInvitationDeadDeathYear = value;
		}
	}

	public string FormCommissionInvitationCommissionAddress
	{
		get
		{
			return formCommissionInvitationCommissionAddress;
		}
		set
		{
			formCommissionInvitationCommissionAddress = value;
		}
	}

	public string FormCommissionInvitationUser1FullName
	{
		get
		{
			return formCommissionInvitationUser1FullName;
		}
		set
		{
			formCommissionInvitationUser1FullName = value;
		}
	}

	public string FormCommissionInvitationUser1Code
	{
		get
		{
			return formCommissionInvitationUser1Code;
		}
		set
		{
			formCommissionInvitationUser1Code = value;
		}
	}

	public string FormCommissionInvitationUser2FullName
	{
		get
		{
			return formCommissionInvitationUser2FullName;
		}
		set
		{
			formCommissionInvitationUser2FullName = value;
		}
	}

	public string FormCommissionInvitationUser2Code
	{
		get
		{
			return formCommissionInvitationUser2Code;
		}
		set
		{
			formCommissionInvitationUser2Code = value;
		}
	}

	public string FormCommissionInvitationCommissionType3
	{
		get
		{
			return formCommissionInvitationCommissionType3;
		}
		set
		{
			formCommissionInvitationCommissionType3 = value;
		}
	}

	public string FormCommissionInvitationCommissionType4
	{
		get
		{
			return formCommissionInvitationCommissionType4;
		}
		set
		{
			formCommissionInvitationCommissionType4 = value;
		}
	}

	public string FormCommissionInvitationCommissionType5
	{
		get
		{
			return formCommissionInvitationCommissionType5;
		}
		set
		{
			formCommissionInvitationCommissionType5 = value;
		}
	}

	public string FormCommissionInvitationCommissionType6
	{
		get
		{
			return formCommissionInvitationCommissionType6;
		}
		set
		{
			formCommissionInvitationCommissionType6 = value;
		}
	}

	public string FormCommissionInvitationCommissionDay
	{
		get
		{
			return formCommissionInvitationCommissionDay;
		}
		set
		{
			formCommissionInvitationCommissionDay = value;
		}
	}

	public string FormCommissionInvitationCommissionTimePeriod
	{
		get
		{
			return formCommissionInvitationCommissionTimePeriod;
		}
		set
		{
			formCommissionInvitationCommissionTimePeriod = value;
		}
	}

	public string FormCommissionInvitationHeirJobZipCode
	{
		get
		{
			return formCommissionInvitationHeirJobZipCode;
		}
		set
		{
			formCommissionInvitationHeirJobZipCode = value;
		}
	}

	public string FormCommissionInvitationInvitationType1
	{
		get
		{
			return formCommissionInvitationInvitationType1;
		}
		set
		{
			formCommissionInvitationInvitationType1 = value;
		}
	}

	public string FormCommissionInvitationInvitationType2
	{
		get
		{
			return formCommissionInvitationInvitationType2;
		}
		set
		{
			formCommissionInvitationInvitationType2 = value;
		}
	}

	public string FormCommissionInvitationInvitationType3
	{
		get
		{
			return formCommissionInvitationInvitationType3;
		}
		set
		{
			formCommissionInvitationInvitationType3 = value;
		}
	}

	public string FormCommissionInvitationCommissionType1
	{
		get
		{
			return formCommissionInvitationCommissionType1;
		}
		set
		{
			formCommissionInvitationCommissionType1 = value;
		}
	}

	public string FormCommissionInvitationCommissionType2
	{
		get
		{
			return formCommissionInvitationCommissionType2;
		}
		set
		{
			formCommissionInvitationCommissionType2 = value;
		}
	}

	public string FormCommissionInvitationDeadUniqueCode
	{
		get
		{
			return formCommissionInvitationDeadUniqueCode;
		}
		set
		{
			formCommissionInvitationDeadUniqueCode = value;
		}
	}

	public string FormCommissionInvitationHeirJobAddress
	{
		get
		{
			return formCommissionInvitationHeirJobAddress;
		}
		set
		{
			formCommissionInvitationHeirJobAddress = value;
		}
	}

	public string FormCommissionInvitationHeirHomeAddress
	{
		get
		{
			return formCommissionInvitationHeirHomeAddress;
		}
		set
		{
			formCommissionInvitationHeirHomeAddress = value;
		}
	}

	public string FormCommissionInvitationHeirHomePhoneNumber
	{
		get
		{
			return formCommissionInvitationHeirHomePhoneNumber;
		}
		set
		{
			formCommissionInvitationHeirHomePhoneNumber = value;
		}
	}

	public string FormCommissionInvitationHeirHomeJobPhoneNumber
	{
		get
		{
			return formCommissionInvitationHeirHomeJobPhoneNumber;
		}
		set
		{
			formCommissionInvitationHeirHomeJobPhoneNumber = value;
		}
	}

	public string FormCommissionInvitationHeirHomeZipCode
	{
		get
		{
			return formCommissionInvitationHeirHomeZipCode;
		}
		set
		{
			formCommissionInvitationHeirHomeZipCode = value;
		}
	}

	public string FormCommissionInvitationHeirFatherName
	{
		get
		{
			return formCommissionInvitationHeirFatherName;
		}
		set
		{
			formCommissionInvitationHeirFatherName = value;
		}
	}

	public string FormCommissionInvitationHeirIdentifier
	{
		get
		{
			return formCommissionInvitationHeirIdentifier;
		}
		set
		{
			formCommissionInvitationHeirIdentifier = value;
		}
	}

	public string FormCommissionInvitationHeirCertificateNumber
	{
		get
		{
			return formCommissionInvitationHeirCertificateNumber;
		}
		set
		{
			formCommissionInvitationHeirCertificateNumber = value;
		}
	}

	public string FormCommissionInvitationHeirIssuanceCity
	{
		get
		{
			return formCommissionInvitationHeirIssuanceCity;
		}
		set
		{
			formCommissionInvitationHeirIssuanceCity = value;
		}
	}

	public string FormCommissionInvitationDeadFullName
	{
		get
		{
			return formCommissionInvitationDeadFullName;
		}
		set
		{
			formCommissionInvitationDeadFullName = value;
		}
	}

	public string FormCommissionInvitationHeirRelation
	{
		get
		{
			return formCommissionInvitationHeirRelation;
		}
		set
		{
			formCommissionInvitationHeirRelation = value;
		}
	}

	public string FormCommissionInvitationHeirBirthDate
	{
		get
		{
			return formCommissionInvitationHeirBirthDate;
		}
		set
		{
			formCommissionInvitationHeirBirthDate = value;
		}
	}

	public string FormCommissionInvitationCommissionDate
	{
		get
		{
			return formCommissionInvitationCommissionDate;
		}
		set
		{
			formCommissionInvitationCommissionDate = value;
		}
	}

	public string FormCommissionInvitationCommissionTime
	{
		get
		{
			return formCommissionInvitationCommissionTime;
		}
		set
		{
			formCommissionInvitationCommissionTime = value;
		}
	}

	public string FormCommissionInvitationPenaltyDate
	{
		get
		{
			return formCommissionInvitationPenaltyDate;
		}
		set
		{
			formCommissionInvitationPenaltyDate = value;
		}
	}

	public Int64 FormCommissionInvitationRegisterInformarionID
	{
		get
		{
			return formCommissionInvitationRegisterInformarionID;
		}
		set
		{
			formCommissionInvitationRegisterInformarionID = value;
		}
	}

	public Int64? FormCommissionInvitationHeirNationalCode
	{
		get
		{
			return formCommissionInvitationHeirNationalCode;
		}
		set
		{
			formCommissionInvitationHeirNationalCode = value;
		}
	}

	public Int64? FormCommissionInvitationDeclarationID
	{
		get
		{
			return formCommissionInvitationDeclarationID;
		}
		set
		{
			formCommissionInvitationDeclarationID = value;
		}
	}

	public string FormCommissionInvitationRegisterDate
	{
		get
		{
			return formCommissionInvitationRegisterDate;
		}
		set
		{
			formCommissionInvitationRegisterDate = value;
		}
	}

	public string FormCommissionInvitationDossierClasses
	{
		get
		{
			return formCommissionInvitationDossierClasses;
		}
		set
		{
			formCommissionInvitationDossierClasses = value;
		}
	}

	public string FormCommissionInvitationTaxOfficeProvince
	{
		get
		{
			return formCommissionInvitationTaxOfficeProvince;
		}
		set
		{
			formCommissionInvitationTaxOfficeProvince = value;
		}
	}

	public string FormCommissionInvitationTaxOfficeCity
	{
		get
		{
			return formCommissionInvitationTaxOfficeCity;
		}
		set
		{
			formCommissionInvitationTaxOfficeCity = value;
		}
	}

	public string FormCommissionInvitationTaxOfficeAddress
	{
		get
		{
			return formCommissionInvitationTaxOfficeAddress;
		}
		set
		{
			formCommissionInvitationTaxOfficeAddress = value;
		}
	}

	public string FormCommissionInvitationTaxOfficePhoneNumber
	{
		get
		{
			return formCommissionInvitationTaxOfficePhoneNumber;
		}
		set
		{
			formCommissionInvitationTaxOfficePhoneNumber = value;
		}
	}

	public string FormCommissionInvitationHeirFullName
	{
		get
		{
			return formCommissionInvitationHeirFullName;
		}
		set
		{
			formCommissionInvitationHeirFullName = value;
		}
	}

	public int? FormCommissionInvitationTaxUnitCode
	{
		get
		{
			return formCommissionInvitationTaxUnitCode;
		}
		set
		{
			formCommissionInvitationTaxUnitCode = value;
		}
	}

	public float? FormCommissionInvitationHeirShare
	{
		get
		{
			return formCommissionInvitationHeirShare;
		}
		set
		{
			formCommissionInvitationHeirShare = value;
		}
	}

	public float? FormCommissionInvitationHeirExemption
	{
		get
		{
			return formCommissionInvitationHeirExemption;
		}
		set
		{
			formCommissionInvitationHeirExemption = value;
		}
	}

	public float? FormCommissionInvitationHeirIncludedIncome
	{
		get
		{
			return formCommissionInvitationHeirIncludedIncome;
		}
		set
		{
			formCommissionInvitationHeirIncludedIncome = value;
		}
	}

	public float? FormCommissionInvitationHeirTax
	{
		get
		{
			return formCommissionInvitationHeirTax;
		}
		set
		{
			formCommissionInvitationHeirTax = value;
		}
	}

	public float? FormCommissionInvitationPenaltySum
	{
		get
		{
			return formCommissionInvitationPenaltySum;
		}
		set
		{
			formCommissionInvitationPenaltySum = value;
		}
	}

}
}
