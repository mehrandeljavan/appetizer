using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormHeritageEvaluation
{
	private Int64 formHeritageEvaluationID;
	private Int64? formHeritageEvaluationRegisterInformationID;
	private Int64 formHeritageEvaluationDeclarationID;
	private Int64? formHeritageEvaluationApplicantNationalCode;
	private Int64? formHeritageEvaluationZipCode;
	private Int64? formHeritageEvaluationDeadNationalCode;
	private string formHeritageEvaluationRegisterDate;
	private string formHeritageEvaluationApplicantBirthDate;
	private string formHeritageEvaluationDeadDeathDate;
	private string formHeritageEvaluationDeadIssuanceDate;
	private string formHeritageEvaluationDiagnosisReportDate;
	private string formHeritageEvaluationRequestDate;
	private string formHeritageEvaluationTaxOfficeTitle;
	private string formHeritageEvaluationTaxOfficeAddress;
	private string formHeritageEvaluationTaxOfficePhoneNumber;
	private string formHeritageEvaluationTaxOfficeZipCode;
	private string formHeritageEvaluationDossierClasses;
	private string formHeritageEvaluationApplicantFullName;
	private string formHeritageEvaluationDescription;
	private string formHeritageEvaluationUser1FullName;
	private string formHeritageEvaluationUser2FullName;
	private string formHeritageEvaluationPhoneNumber;
	private string formHeritageEvaluationApplicantRole;
	private string formHeritageEvaluationDeadIssuanceCity;
	private string formHeritageEvaluationDeadFullName;
	private string formHeritageEvaluationDeadFatherName;
	private string formHeritageEvaluationDeadDeathCity;
	private string formHeritageEvaluationDeadCertificateNumber;
	private string formHeritageEvaluationDiagnosisReportNumber;
	private string formHeritageEvaluationRequestNumber;
	private string formHeritageEvaluationApplicantFatherName;
	private string formHeritageEvaluationApplicantBirthCity;
	private string formHeritageEvaluationApplicantCertificateNumber;
	private string formHeritageEvaluationApplicantIssuanceCity;
	private string formHeritageEvaluationCommercialNumber;
	private string formHeritageEvaluationAddress;
	private int? formHeritageEvaluationTaxOfficeCode;
	private int? formHeritageEvaluationTaxGroupCode;
	private int? formHeritageEvaluationTaxUnitCode;
	private int? formHeritageEvaluationUser1Code;
	private int? formHeritageEvaluationUser2Code;

	public Int64 FormHeritageEvaluationID
	{
		get
		{
			return formHeritageEvaluationID;
		}
		set
		{
			formHeritageEvaluationID = value;
		}
	}

	public Int64? FormHeritageEvaluationRegisterInformationID
	{
		get
		{
			return formHeritageEvaluationRegisterInformationID;
		}
		set
		{
			formHeritageEvaluationRegisterInformationID = value;
		}
	}

	public Int64 FormHeritageEvaluationDeclarationID
	{
		get
		{
			return formHeritageEvaluationDeclarationID;
		}
		set
		{
			formHeritageEvaluationDeclarationID = value;
		}
	}

	public Int64? FormHeritageEvaluationApplicantNationalCode
	{
		get
		{
			return formHeritageEvaluationApplicantNationalCode;
		}
		set
		{
			formHeritageEvaluationApplicantNationalCode = value;
		}
	}

	public Int64? FormHeritageEvaluationZipCode
	{
		get
		{
			return formHeritageEvaluationZipCode;
		}
		set
		{
			formHeritageEvaluationZipCode = value;
		}
	}

	public Int64? FormHeritageEvaluationDeadNationalCode
	{
		get
		{
			return formHeritageEvaluationDeadNationalCode;
		}
		set
		{
			formHeritageEvaluationDeadNationalCode = value;
		}
	}

	public string FormHeritageEvaluationRegisterDate
	{
		get
		{
			return formHeritageEvaluationRegisterDate;
		}
		set
		{
			formHeritageEvaluationRegisterDate = value;
		}
	}

	public string FormHeritageEvaluationApplicantBirthDate
	{
		get
		{
			return formHeritageEvaluationApplicantBirthDate;
		}
		set
		{
			formHeritageEvaluationApplicantBirthDate = value;
		}
	}

	public string FormHeritageEvaluationDeadDeathDate
	{
		get
		{
			return formHeritageEvaluationDeadDeathDate;
		}
		set
		{
			formHeritageEvaluationDeadDeathDate = value;
		}
	}

	public string FormHeritageEvaluationDeadIssuanceDate
	{
		get
		{
			return formHeritageEvaluationDeadIssuanceDate;
		}
		set
		{
			formHeritageEvaluationDeadIssuanceDate = value;
		}
	}

	public string FormHeritageEvaluationDiagnosisReportDate
	{
		get
		{
			return formHeritageEvaluationDiagnosisReportDate;
		}
		set
		{
			formHeritageEvaluationDiagnosisReportDate = value;
		}
	}

	public string FormHeritageEvaluationRequestDate
	{
		get
		{
			return formHeritageEvaluationRequestDate;
		}
		set
		{
			formHeritageEvaluationRequestDate = value;
		}
	}

	public string FormHeritageEvaluationTaxOfficeTitle
	{
		get
		{
			return formHeritageEvaluationTaxOfficeTitle;
		}
		set
		{
			formHeritageEvaluationTaxOfficeTitle = value;
		}
	}

	public string FormHeritageEvaluationTaxOfficeAddress
	{
		get
		{
			return formHeritageEvaluationTaxOfficeAddress;
		}
		set
		{
			formHeritageEvaluationTaxOfficeAddress = value;
		}
	}

	public string FormHeritageEvaluationTaxOfficePhoneNumber
	{
		get
		{
			return formHeritageEvaluationTaxOfficePhoneNumber;
		}
		set
		{
			formHeritageEvaluationTaxOfficePhoneNumber = value;
		}
	}

	public string FormHeritageEvaluationTaxOfficeZipCode
	{
		get
		{
			return formHeritageEvaluationTaxOfficeZipCode;
		}
		set
		{
			formHeritageEvaluationTaxOfficeZipCode = value;
		}
	}

	public string FormHeritageEvaluationDossierClasses
	{
		get
		{
			return formHeritageEvaluationDossierClasses;
		}
		set
		{
			formHeritageEvaluationDossierClasses = value;
		}
	}

	public string FormHeritageEvaluationApplicantFullName
	{
		get
		{
			return formHeritageEvaluationApplicantFullName;
		}
		set
		{
			formHeritageEvaluationApplicantFullName = value;
		}
	}

	public string FormHeritageEvaluationDescription
	{
		get
		{
			return formHeritageEvaluationDescription;
		}
		set
		{
			formHeritageEvaluationDescription = value;
		}
	}

	public string FormHeritageEvaluationUser1FullName
	{
		get
		{
			return formHeritageEvaluationUser1FullName;
		}
		set
		{
			formHeritageEvaluationUser1FullName = value;
		}
	}

	public string FormHeritageEvaluationUser2FullName
	{
		get
		{
			return formHeritageEvaluationUser2FullName;
		}
		set
		{
			formHeritageEvaluationUser2FullName = value;
		}
	}

	public string FormHeritageEvaluationPhoneNumber
	{
		get
		{
			return formHeritageEvaluationPhoneNumber;
		}
		set
		{
			formHeritageEvaluationPhoneNumber = value;
		}
	}

	public string FormHeritageEvaluationApplicantRole
	{
		get
		{
			return formHeritageEvaluationApplicantRole;
		}
		set
		{
			formHeritageEvaluationApplicantRole = value;
		}
	}

	public string FormHeritageEvaluationDeadIssuanceCity
	{
		get
		{
			return formHeritageEvaluationDeadIssuanceCity;
		}
		set
		{
			formHeritageEvaluationDeadIssuanceCity = value;
		}
	}

	public string FormHeritageEvaluationDeadFullName
	{
		get
		{
			return formHeritageEvaluationDeadFullName;
		}
		set
		{
			formHeritageEvaluationDeadFullName = value;
		}
	}

	public string FormHeritageEvaluationDeadFatherName
	{
		get
		{
			return formHeritageEvaluationDeadFatherName;
		}
		set
		{
			formHeritageEvaluationDeadFatherName = value;
		}
	}

	public string FormHeritageEvaluationDeadDeathCity
	{
		get
		{
			return formHeritageEvaluationDeadDeathCity;
		}
		set
		{
			formHeritageEvaluationDeadDeathCity = value;
		}
	}

	public string FormHeritageEvaluationDeadCertificateNumber
	{
		get
		{
			return formHeritageEvaluationDeadCertificateNumber;
		}
		set
		{
			formHeritageEvaluationDeadCertificateNumber = value;
		}
	}

	public string FormHeritageEvaluationDiagnosisReportNumber
	{
		get
		{
			return formHeritageEvaluationDiagnosisReportNumber;
		}
		set
		{
			formHeritageEvaluationDiagnosisReportNumber = value;
		}
	}

	public string FormHeritageEvaluationRequestNumber
	{
		get
		{
			return formHeritageEvaluationRequestNumber;
		}
		set
		{
			formHeritageEvaluationRequestNumber = value;
		}
	}

	public string FormHeritageEvaluationApplicantFatherName
	{
		get
		{
			return formHeritageEvaluationApplicantFatherName;
		}
		set
		{
			formHeritageEvaluationApplicantFatherName = value;
		}
	}

	public string FormHeritageEvaluationApplicantBirthCity
	{
		get
		{
			return formHeritageEvaluationApplicantBirthCity;
		}
		set
		{
			formHeritageEvaluationApplicantBirthCity = value;
		}
	}

	public string FormHeritageEvaluationApplicantCertificateNumber
	{
		get
		{
			return formHeritageEvaluationApplicantCertificateNumber;
		}
		set
		{
			formHeritageEvaluationApplicantCertificateNumber = value;
		}
	}

	public string FormHeritageEvaluationApplicantIssuanceCity
	{
		get
		{
			return formHeritageEvaluationApplicantIssuanceCity;
		}
		set
		{
			formHeritageEvaluationApplicantIssuanceCity = value;
		}
	}

	public string FormHeritageEvaluationCommercialNumber
	{
		get
		{
			return formHeritageEvaluationCommercialNumber;
		}
		set
		{
			formHeritageEvaluationCommercialNumber = value;
		}
	}

	public string FormHeritageEvaluationAddress
	{
		get
		{
			return formHeritageEvaluationAddress;
		}
		set
		{
			formHeritageEvaluationAddress = value;
		}
	}

	public int? FormHeritageEvaluationTaxOfficeCode
	{
		get
		{
			return formHeritageEvaluationTaxOfficeCode;
		}
		set
		{
			formHeritageEvaluationTaxOfficeCode = value;
		}
	}

	public int? FormHeritageEvaluationTaxGroupCode
	{
		get
		{
			return formHeritageEvaluationTaxGroupCode;
		}
		set
		{
			formHeritageEvaluationTaxGroupCode = value;
		}
	}

	public int? FormHeritageEvaluationTaxUnitCode
	{
		get
		{
			return formHeritageEvaluationTaxUnitCode;
		}
		set
		{
			formHeritageEvaluationTaxUnitCode = value;
		}
	}

	public int? FormHeritageEvaluationUser1Code
	{
		get
		{
			return formHeritageEvaluationUser1Code;
		}
		set
		{
			formHeritageEvaluationUser1Code = value;
		}
	}

	public int? FormHeritageEvaluationUser2Code
	{
		get
		{
			return formHeritageEvaluationUser2Code;
		}
		set
		{
			formHeritageEvaluationUser2Code = value;
		}
	}

}
}
