using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormFreedom
{
	private Int64 formFreedomID;
	private Int64 formFreedomDeclarationID;
	private Int64? formFreedomRegisterInformationID;
	private Int64? formFreedomApplicantNationalCode;
	private Int64? formFreedomZipCode;
	private Int64? formFreedomDeadNationalCode;
	private string formFreedomRegisterDate;
	private string formFreedomRequestDate;
	private string formFreedomApplicantBirthDate;
	private string formFreedomDeadDeathDate;
	private string formFreedomDeclarationRegisterDate;
	private string formFreedomDiagnosisDate;
	private string formFreedomHeirsCertificateDate;
	private string formFreedomTaxOfficeTitle;
	private string formFreedomTaxOfficeAddress;
	private string formFreedomTaxOfficePhoneNumber;
	private string formFreedomTaxOfficeZipCode;
	private string formFreedomDossierClasses;
	private string formFreedomRequestResource;
	private string formFreedomDescriptionHeritage;
	private string formFreedomUser1FullName;
	private string formFreedomPhoneNumber;
	private string formFreedomUttererRole;
	private string formFreedomHeirsCertificateNumber;
	private string formFreedomHeirsCertificateSource;
	private string formFreedomHeirsCertificateBranch;
	private string formFreedomDeadIssuanceCity;
	private string formFreedomDeclarationRegisterNumber;
	private string formFreedomDiagnosisNumber;
	private string formFreedomCourt;
	private string formFreedomBranch;
	private string formFreedomUser2FullName;
	private string formFreedomApplicantIssuanceCity;
	private string formFreedomCommercialNumber;
	private string formFreedomDeadFullName;
	private string formFreedomDeadFatherName;
	private string formFreedomDeadDeathCity;
	private string formFreedomDeadCertificateNumber;
	private string formFreedomRequestNumber;
	private string formFreedomAddress;
	private string formFreedomApplicantFullName;
	private string formFreedomApplicantFatherName;
	private string formFreedomApplicantBirthCity;
	private string formFreedomApplicantCertificateNumber;
	private int? formFreedomTaxOfficeCode;
	private int? formFreedomTaxGroupCode;
	private int? formFreedomTaxUnitCode;
	private int? formFreedomUser1Code;
	private int? formFreedomUser2Code;

	public Int64 FormFreedomID
	{
		get
		{
			return formFreedomID;
		}
		set
		{
			formFreedomID = value;
		}
	}

	public Int64 FormFreedomDeclarationID
	{
		get
		{
			return formFreedomDeclarationID;
		}
		set
		{
			formFreedomDeclarationID = value;
		}
	}

	public Int64? FormFreedomRegisterInformationID
	{
		get
		{
			return formFreedomRegisterInformationID;
		}
		set
		{
			formFreedomRegisterInformationID = value;
		}
	}

	public Int64? FormFreedomApplicantNationalCode
	{
		get
		{
			return formFreedomApplicantNationalCode;
		}
		set
		{
			formFreedomApplicantNationalCode = value;
		}
	}

	public Int64? FormFreedomZipCode
	{
		get
		{
			return formFreedomZipCode;
		}
		set
		{
			formFreedomZipCode = value;
		}
	}

	public Int64? FormFreedomDeadNationalCode
	{
		get
		{
			return formFreedomDeadNationalCode;
		}
		set
		{
			formFreedomDeadNationalCode = value;
		}
	}

	public string FormFreedomRegisterDate
	{
		get
		{
			return formFreedomRegisterDate;
		}
		set
		{
			formFreedomRegisterDate = value;
		}
	}

	public string FormFreedomRequestDate
	{
		get
		{
			return formFreedomRequestDate;
		}
		set
		{
			formFreedomRequestDate = value;
		}
	}

	public string FormFreedomApplicantBirthDate
	{
		get
		{
			return formFreedomApplicantBirthDate;
		}
		set
		{
			formFreedomApplicantBirthDate = value;
		}
	}

	public string FormFreedomDeadDeathDate
	{
		get
		{
			return formFreedomDeadDeathDate;
		}
		set
		{
			formFreedomDeadDeathDate = value;
		}
	}

	public string FormFreedomDeclarationRegisterDate
	{
		get
		{
			return formFreedomDeclarationRegisterDate;
		}
		set
		{
			formFreedomDeclarationRegisterDate = value;
		}
	}

	public string FormFreedomDiagnosisDate
	{
		get
		{
			return formFreedomDiagnosisDate;
		}
		set
		{
			formFreedomDiagnosisDate = value;
		}
	}

	public string FormFreedomHeirsCertificateDate
	{
		get
		{
			return formFreedomHeirsCertificateDate;
		}
		set
		{
			formFreedomHeirsCertificateDate = value;
		}
	}

	public string FormFreedomTaxOfficeTitle
	{
		get
		{
			return formFreedomTaxOfficeTitle;
		}
		set
		{
			formFreedomTaxOfficeTitle = value;
		}
	}

	public string FormFreedomTaxOfficeAddress
	{
		get
		{
			return formFreedomTaxOfficeAddress;
		}
		set
		{
			formFreedomTaxOfficeAddress = value;
		}
	}

	public string FormFreedomTaxOfficePhoneNumber
	{
		get
		{
			return formFreedomTaxOfficePhoneNumber;
		}
		set
		{
			formFreedomTaxOfficePhoneNumber = value;
		}
	}

	public string FormFreedomTaxOfficeZipCode
	{
		get
		{
			return formFreedomTaxOfficeZipCode;
		}
		set
		{
			formFreedomTaxOfficeZipCode = value;
		}
	}

	public string FormFreedomDossierClasses
	{
		get
		{
			return formFreedomDossierClasses;
		}
		set
		{
			formFreedomDossierClasses = value;
		}
	}

	public string FormFreedomRequestResource
	{
		get
		{
			return formFreedomRequestResource;
		}
		set
		{
			formFreedomRequestResource = value;
		}
	}

	public string FormFreedomDescriptionHeritage
	{
		get
		{
			return formFreedomDescriptionHeritage;
		}
		set
		{
			formFreedomDescriptionHeritage = value;
		}
	}

	public string FormFreedomUser1FullName
	{
		get
		{
			return formFreedomUser1FullName;
		}
		set
		{
			formFreedomUser1FullName = value;
		}
	}

	public string FormFreedomPhoneNumber
	{
		get
		{
			return formFreedomPhoneNumber;
		}
		set
		{
			formFreedomPhoneNumber = value;
		}
	}

	public string FormFreedomUttererRole
	{
		get
		{
			return formFreedomUttererRole;
		}
		set
		{
			formFreedomUttererRole = value;
		}
	}

	public string FormFreedomHeirsCertificateNumber
	{
		get
		{
			return formFreedomHeirsCertificateNumber;
		}
		set
		{
			formFreedomHeirsCertificateNumber = value;
		}
	}

	public string FormFreedomHeirsCertificateSource
	{
		get
		{
			return formFreedomHeirsCertificateSource;
		}
		set
		{
			formFreedomHeirsCertificateSource = value;
		}
	}

	public string FormFreedomHeirsCertificateBranch
	{
		get
		{
			return formFreedomHeirsCertificateBranch;
		}
		set
		{
			formFreedomHeirsCertificateBranch = value;
		}
	}

	public string FormFreedomDeadIssuanceCity
	{
		get
		{
			return formFreedomDeadIssuanceCity;
		}
		set
		{
			formFreedomDeadIssuanceCity = value;
		}
	}

	public string FormFreedomDeclarationRegisterNumber
	{
		get
		{
			return formFreedomDeclarationRegisterNumber;
		}
		set
		{
			formFreedomDeclarationRegisterNumber = value;
		}
	}

	public string FormFreedomDiagnosisNumber
	{
		get
		{
			return formFreedomDiagnosisNumber;
		}
		set
		{
			formFreedomDiagnosisNumber = value;
		}
	}

	public string FormFreedomCourt
	{
		get
		{
			return formFreedomCourt;
		}
		set
		{
			formFreedomCourt = value;
		}
	}

	public string FormFreedomBranch
	{
		get
		{
			return formFreedomBranch;
		}
		set
		{
			formFreedomBranch = value;
		}
	}

	public string FormFreedomUser2FullName
	{
		get
		{
			return formFreedomUser2FullName;
		}
		set
		{
			formFreedomUser2FullName = value;
		}
	}

	public string FormFreedomApplicantIssuanceCity
	{
		get
		{
			return formFreedomApplicantIssuanceCity;
		}
		set
		{
			formFreedomApplicantIssuanceCity = value;
		}
	}

	public string FormFreedomCommercialNumber
	{
		get
		{
			return formFreedomCommercialNumber;
		}
		set
		{
			formFreedomCommercialNumber = value;
		}
	}

	public string FormFreedomDeadFullName
	{
		get
		{
			return formFreedomDeadFullName;
		}
		set
		{
			formFreedomDeadFullName = value;
		}
	}

	public string FormFreedomDeadFatherName
	{
		get
		{
			return formFreedomDeadFatherName;
		}
		set
		{
			formFreedomDeadFatherName = value;
		}
	}

	public string FormFreedomDeadDeathCity
	{
		get
		{
			return formFreedomDeadDeathCity;
		}
		set
		{
			formFreedomDeadDeathCity = value;
		}
	}

	public string FormFreedomDeadCertificateNumber
	{
		get
		{
			return formFreedomDeadCertificateNumber;
		}
		set
		{
			formFreedomDeadCertificateNumber = value;
		}
	}

	public string FormFreedomRequestNumber
	{
		get
		{
			return formFreedomRequestNumber;
		}
		set
		{
			formFreedomRequestNumber = value;
		}
	}

	public string FormFreedomAddress
	{
		get
		{
			return formFreedomAddress;
		}
		set
		{
			formFreedomAddress = value;
		}
	}

	public string FormFreedomApplicantFullName
	{
		get
		{
			return formFreedomApplicantFullName;
		}
		set
		{
			formFreedomApplicantFullName = value;
		}
	}

	public string FormFreedomApplicantFatherName
	{
		get
		{
			return formFreedomApplicantFatherName;
		}
		set
		{
			formFreedomApplicantFatherName = value;
		}
	}

	public string FormFreedomApplicantBirthCity
	{
		get
		{
			return formFreedomApplicantBirthCity;
		}
		set
		{
			formFreedomApplicantBirthCity = value;
		}
	}

	public string FormFreedomApplicantCertificateNumber
	{
		get
		{
			return formFreedomApplicantCertificateNumber;
		}
		set
		{
			formFreedomApplicantCertificateNumber = value;
		}
	}

	public int? FormFreedomTaxOfficeCode
	{
		get
		{
			return formFreedomTaxOfficeCode;
		}
		set
		{
			formFreedomTaxOfficeCode = value;
		}
	}

	public int? FormFreedomTaxGroupCode
	{
		get
		{
			return formFreedomTaxGroupCode;
		}
		set
		{
			formFreedomTaxGroupCode = value;
		}
	}

	public int? FormFreedomTaxUnitCode
	{
		get
		{
			return formFreedomTaxUnitCode;
		}
		set
		{
			formFreedomTaxUnitCode = value;
		}
	}

	public int? FormFreedomUser1Code
	{
		get
		{
			return formFreedomUser1Code;
		}
		set
		{
			formFreedomUser1Code = value;
		}
	}

	public int? FormFreedomUser2Code
	{
		get
		{
			return formFreedomUser2Code;
		}
		set
		{
			formFreedomUser2Code = value;
		}
	}

}
}
