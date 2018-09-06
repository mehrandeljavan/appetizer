using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormDiagnosisResult
{
	private Int64 formDiagnosisResultID;
	private Int64 formDiagnosisResultDeclarationID;
	private Int64? formDiagnosisResultRegisterInformationID;
	private Int64? formDiagnosisResultApplicantNationalCode;
	private Int64? formDiagnosisResultZipCode;
	private Int64? formDiagnosisResultDeadNationalCode;
	private string formDiagnosisResultDeadIssuanceCity;
	private string formDiagnosisResultRegisterDate;
	private string formDiagnosisResultApplicantBirthDate;
	private string formDiagnosisResultDeadDeathDate;
	private string formDiagnosisResultDiagnosisReportDate;
	private string formDiagnosisResultRequestDate;
	private string formDiagnosisResultTaxOfficeTitle;
	private string formDiagnosisResultTaxOfficeAddress;
	private string formDiagnosisResultTaxOfficePhoneNumber;
	private string formDiagnosisResultTaxOfficeZipCode;
	private string formDiagnosisResultDossierClasses;
	private string formDiagnosisResultApplicantFullName;
	private string formDiagnosisResultDescription;
	private string formDiagnosisResultUser1FullName;
	private string formDiagnosisResultUser2FullName;
	private string formDiagnosisResultPhoneNumber;
	private string formDiagnosisResultApplicantRole;
	private string formDiagnosisResultDeadFullName;
	private string formDiagnosisResultDeadFatherName;
	private string formDiagnosisResultDeadDeathCity;
	private string formDiagnosisResultDeadCertificateNumber;
	private string formDiagnosisResultDiagnosisReportNumber;
	private string formDiagnosisResultRequestNumber;
	private string formDiagnosisResultApplicantFatherName;
	private string formDiagnosisResultApplicantBirthCity;
	private string formDiagnosisResultApplicantCertificateNumber;
	private string formDiagnosisResultApplicantIssuanceCity;
	private string formDiagnosisResultCommercialNumber;
	private string formDiagnosisResultAddress;
	private int? formDiagnosisResultTaxOfficeCode;
	private int? formDiagnosisResultTaxGroupCode;
	private int? formDiagnosisResultTaxUnitCode;
	private int? formDiagnosisResultUser1Code;
	private int? formDiagnosisResultUser2Code;

	public Int64 FormDiagnosisResultID
	{
		get
		{
			return formDiagnosisResultID;
		}
		set
		{
			formDiagnosisResultID = value;
		}
	}

	public Int64 FormDiagnosisResultDeclarationID
	{
		get
		{
			return formDiagnosisResultDeclarationID;
		}
		set
		{
			formDiagnosisResultDeclarationID = value;
		}
	}

	public Int64? FormDiagnosisResultRegisterInformationID
	{
		get
		{
			return formDiagnosisResultRegisterInformationID;
		}
		set
		{
			formDiagnosisResultRegisterInformationID = value;
		}
	}

	public Int64? FormDiagnosisResultApplicantNationalCode
	{
		get
		{
			return formDiagnosisResultApplicantNationalCode;
		}
		set
		{
			formDiagnosisResultApplicantNationalCode = value;
		}
	}

	public Int64? FormDiagnosisResultZipCode
	{
		get
		{
			return formDiagnosisResultZipCode;
		}
		set
		{
			formDiagnosisResultZipCode = value;
		}
	}

	public Int64? FormDiagnosisResultDeadNationalCode
	{
		get
		{
			return formDiagnosisResultDeadNationalCode;
		}
		set
		{
			formDiagnosisResultDeadNationalCode = value;
		}
	}

	public string FormDiagnosisResultDeadIssuanceCity
	{
		get
		{
			return formDiagnosisResultDeadIssuanceCity;
		}
		set
		{
			formDiagnosisResultDeadIssuanceCity = value;
		}
	}

	public string FormDiagnosisResultRegisterDate
	{
		get
		{
			return formDiagnosisResultRegisterDate;
		}
		set
		{
			formDiagnosisResultRegisterDate = value;
		}
	}

	public string FormDiagnosisResultApplicantBirthDate
	{
		get
		{
			return formDiagnosisResultApplicantBirthDate;
		}
		set
		{
			formDiagnosisResultApplicantBirthDate = value;
		}
	}

	public string FormDiagnosisResultDeadDeathDate
	{
		get
		{
			return formDiagnosisResultDeadDeathDate;
		}
		set
		{
			formDiagnosisResultDeadDeathDate = value;
		}
	}

	public string FormDiagnosisResultDiagnosisReportDate
	{
		get
		{
			return formDiagnosisResultDiagnosisReportDate;
		}
		set
		{
			formDiagnosisResultDiagnosisReportDate = value;
		}
	}

	public string FormDiagnosisResultRequestDate
	{
		get
		{
			return formDiagnosisResultRequestDate;
		}
		set
		{
			formDiagnosisResultRequestDate = value;
		}
	}

	public string FormDiagnosisResultTaxOfficeTitle
	{
		get
		{
			return formDiagnosisResultTaxOfficeTitle;
		}
		set
		{
			formDiagnosisResultTaxOfficeTitle = value;
		}
	}

	public string FormDiagnosisResultTaxOfficeAddress
	{
		get
		{
			return formDiagnosisResultTaxOfficeAddress;
		}
		set
		{
			formDiagnosisResultTaxOfficeAddress = value;
		}
	}

	public string FormDiagnosisResultTaxOfficePhoneNumber
	{
		get
		{
			return formDiagnosisResultTaxOfficePhoneNumber;
		}
		set
		{
			formDiagnosisResultTaxOfficePhoneNumber = value;
		}
	}

	public string FormDiagnosisResultTaxOfficeZipCode
	{
		get
		{
			return formDiagnosisResultTaxOfficeZipCode;
		}
		set
		{
			formDiagnosisResultTaxOfficeZipCode = value;
		}
	}

	public string FormDiagnosisResultDossierClasses
	{
		get
		{
			return formDiagnosisResultDossierClasses;
		}
		set
		{
			formDiagnosisResultDossierClasses = value;
		}
	}

	public string FormDiagnosisResultApplicantFullName
	{
		get
		{
			return formDiagnosisResultApplicantFullName;
		}
		set
		{
			formDiagnosisResultApplicantFullName = value;
		}
	}

	public string FormDiagnosisResultDescription
	{
		get
		{
			return formDiagnosisResultDescription;
		}
		set
		{
			formDiagnosisResultDescription = value;
		}
	}

	public string FormDiagnosisResultUser1FullName
	{
		get
		{
			return formDiagnosisResultUser1FullName;
		}
		set
		{
			formDiagnosisResultUser1FullName = value;
		}
	}

	public string FormDiagnosisResultUser2FullName
	{
		get
		{
			return formDiagnosisResultUser2FullName;
		}
		set
		{
			formDiagnosisResultUser2FullName = value;
		}
	}

	public string FormDiagnosisResultPhoneNumber
	{
		get
		{
			return formDiagnosisResultPhoneNumber;
		}
		set
		{
			formDiagnosisResultPhoneNumber = value;
		}
	}

	public string FormDiagnosisResultApplicantRole
	{
		get
		{
			return formDiagnosisResultApplicantRole;
		}
		set
		{
			formDiagnosisResultApplicantRole = value;
		}
	}

	public string FormDiagnosisResultDeadFullName
	{
		get
		{
			return formDiagnosisResultDeadFullName;
		}
		set
		{
			formDiagnosisResultDeadFullName = value;
		}
	}

	public string FormDiagnosisResultDeadFatherName
	{
		get
		{
			return formDiagnosisResultDeadFatherName;
		}
		set
		{
			formDiagnosisResultDeadFatherName = value;
		}
	}

	public string FormDiagnosisResultDeadDeathCity
	{
		get
		{
			return formDiagnosisResultDeadDeathCity;
		}
		set
		{
			formDiagnosisResultDeadDeathCity = value;
		}
	}

	public string FormDiagnosisResultDeadCertificateNumber
	{
		get
		{
			return formDiagnosisResultDeadCertificateNumber;
		}
		set
		{
			formDiagnosisResultDeadCertificateNumber = value;
		}
	}

	public string FormDiagnosisResultDiagnosisReportNumber
	{
		get
		{
			return formDiagnosisResultDiagnosisReportNumber;
		}
		set
		{
			formDiagnosisResultDiagnosisReportNumber = value;
		}
	}

	public string FormDiagnosisResultRequestNumber
	{
		get
		{
			return formDiagnosisResultRequestNumber;
		}
		set
		{
			formDiagnosisResultRequestNumber = value;
		}
	}

	public string FormDiagnosisResultApplicantFatherName
	{
		get
		{
			return formDiagnosisResultApplicantFatherName;
		}
		set
		{
			formDiagnosisResultApplicantFatherName = value;
		}
	}

	public string FormDiagnosisResultApplicantBirthCity
	{
		get
		{
			return formDiagnosisResultApplicantBirthCity;
		}
		set
		{
			formDiagnosisResultApplicantBirthCity = value;
		}
	}

	public string FormDiagnosisResultApplicantCertificateNumber
	{
		get
		{
			return formDiagnosisResultApplicantCertificateNumber;
		}
		set
		{
			formDiagnosisResultApplicantCertificateNumber = value;
		}
	}

	public string FormDiagnosisResultApplicantIssuanceCity
	{
		get
		{
			return formDiagnosisResultApplicantIssuanceCity;
		}
		set
		{
			formDiagnosisResultApplicantIssuanceCity = value;
		}
	}

	public string FormDiagnosisResultCommercialNumber
	{
		get
		{
			return formDiagnosisResultCommercialNumber;
		}
		set
		{
			formDiagnosisResultCommercialNumber = value;
		}
	}

	public string FormDiagnosisResultAddress
	{
		get
		{
			return formDiagnosisResultAddress;
		}
		set
		{
			formDiagnosisResultAddress = value;
		}
	}

	public int? FormDiagnosisResultTaxOfficeCode
	{
		get
		{
			return formDiagnosisResultTaxOfficeCode;
		}
		set
		{
			formDiagnosisResultTaxOfficeCode = value;
		}
	}

	public int? FormDiagnosisResultTaxGroupCode
	{
		get
		{
			return formDiagnosisResultTaxGroupCode;
		}
		set
		{
			formDiagnosisResultTaxGroupCode = value;
		}
	}

	public int? FormDiagnosisResultTaxUnitCode
	{
		get
		{
			return formDiagnosisResultTaxUnitCode;
		}
		set
		{
			formDiagnosisResultTaxUnitCode = value;
		}
	}

	public int? FormDiagnosisResultUser1Code
	{
		get
		{
			return formDiagnosisResultUser1Code;
		}
		set
		{
			formDiagnosisResultUser1Code = value;
		}
	}

	public int? FormDiagnosisResultUser2Code
	{
		get
		{
			return formDiagnosisResultUser2Code;
		}
		set
		{
			formDiagnosisResultUser2Code = value;
		}
	}

}
}
