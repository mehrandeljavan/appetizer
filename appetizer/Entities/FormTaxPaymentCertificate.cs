using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormTaxPaymentCertificate
{
	private Int64 formTaxPayementCertificateID;
	private string formTaxPayementCertificatePrintRegisterDate;
	private string formTaxPayementCertificatePrintRegisterInformationID;
	private string formTaxPayementCertificateDeathMounth;
	private string formTaxPayementCertificateDeathYear;
	private string formTaxPayementCertificateDeathCity;
	private string formTaxPayementCertificateDescription1;
	private string formTaxPayementCertificateDescription2;
	private string formTaxPayementCertificateDescription3;
	private string formTaxPayementCertificateHeirsCertificateSource;
	private string formTaxPayementCertificateHeirsCertificateBranch;
	private string formTaxPayementCertificateDeadName;
	private string formTaxPayementCertificateDeadLastName;
	private string formTaxPayementCertificateDeadCertificateNumber;
	private string formTaxPayementCertificateDeathDay;
	private string formTaxPayementCertificateIssuanceCity;
	private string formTaxPayementCertificateDeclarationRequestNumber;
	private string formTaxPayementCertificateDeclarationRequestResource;
	private string formTaxPayementCertificateApplicantFullName;
	private string formTaxPayementCertificateApplicantFatherName;
	private string formTaxPayementCertificateDescription4;
	private string formTaxPayementCertificateDescriptionHeritage;
	private string formTaxPayementCertificateRequestNumber;
	private string formTaxPayementCertificateUser1FullName;
	private string formTaxPayementCertificateUser2FullName;
	private Int64? formTaxPayementCertificateRegisterInformationID;
	private Int64? formTaxPayementCertificateDeadNationalCode;
	private Int64? formTaxPayementCertificateDeclarationID;
	private Int64? formTaxPayementCertificateTaxOfficeZipCode;
	private Int64? formTaxPayementCertificateApplicantNationalCode;
	private Int64? formTaxPayementCertificateZipCode;
	private string formTaxPayementCertificateApplicantName;
	private string formTaxPayementCertificateRegisterDate;
	private string formTaxPayementCertificateHeirsCertificateDate;
	private string formTaxPayementCertificateRequestDate;
	private string formTaxPayementCertificateDeclarationRequestDate;
	private string formTaxPayementCertificateApplicantBirthDate;
	private string formTaxPayementCertificateDossierClasses;
	private string formTaxPayementCertificateTaxOfficeTitle;
	private string formTaxPayementCertificateTaxOfficeCity;
	private string formTaxPayementCertificateTaxOfficeAddress;
	private string formTaxPayementCertificateTaxOfficePhoneNumber;
	private string formTaxPayementCertificateHeirsCertificateNumber;
	private string formTaxPayementCertificateDeadFatherName;
	private string formTaxPayementCertificatePhoneNumber;
	private string formTaxPayementCertificateDeadIssuanceCity;
	private string formTaxPayementCertificateApplicantBirthCity;
	private string formTaxPayementCertificateApplicantCertificateNumber;
	private string formTaxPayementCertificateApplicantIssuanceCity;
	private string formTaxPayementCertificateApplicantRole;
	private string formTaxPayementCertificateAddress;
	private string formTaxPayementCertificateCommercialNumer;
	private int? formTaxPayementCertificateTaxOfficeCode;
	private int? formTaxPayementCertificateTaxGroupCode;
	private int? formTaxPayementCertificateTaxUnitCode;

	public Int64 FormTaxPayementCertificateID
	{
		get
		{
			return formTaxPayementCertificateID;
		}
		set
		{
			formTaxPayementCertificateID = value;
		}
	}

	public string FormTaxPayementCertificatePrintRegisterDate
	{
		get
		{
			return formTaxPayementCertificatePrintRegisterDate;
		}
		set
		{
			formTaxPayementCertificatePrintRegisterDate = value;
		}
	}

	public string FormTaxPayementCertificatePrintRegisterInformationID
	{
		get
		{
			return formTaxPayementCertificatePrintRegisterInformationID;
		}
		set
		{
			formTaxPayementCertificatePrintRegisterInformationID = value;
		}
	}

	public string FormTaxPayementCertificateDeathMounth
	{
		get
		{
			return formTaxPayementCertificateDeathMounth;
		}
		set
		{
			formTaxPayementCertificateDeathMounth = value;
		}
	}

	public string FormTaxPayementCertificateDeathYear
	{
		get
		{
			return formTaxPayementCertificateDeathYear;
		}
		set
		{
			formTaxPayementCertificateDeathYear = value;
		}
	}

	public string FormTaxPayementCertificateDeathCity
	{
		get
		{
			return formTaxPayementCertificateDeathCity;
		}
		set
		{
			formTaxPayementCertificateDeathCity = value;
		}
	}

	public string FormTaxPayementCertificateDescription1
	{
		get
		{
			return formTaxPayementCertificateDescription1;
		}
		set
		{
			formTaxPayementCertificateDescription1 = value;
		}
	}

	public string FormTaxPayementCertificateDescription2
	{
		get
		{
			return formTaxPayementCertificateDescription2;
		}
		set
		{
			formTaxPayementCertificateDescription2 = value;
		}
	}

	public string FormTaxPayementCertificateDescription3
	{
		get
		{
			return formTaxPayementCertificateDescription3;
		}
		set
		{
			formTaxPayementCertificateDescription3 = value;
		}
	}

	public string FormTaxPayementCertificateHeirsCertificateSource
	{
		get
		{
			return formTaxPayementCertificateHeirsCertificateSource;
		}
		set
		{
			formTaxPayementCertificateHeirsCertificateSource = value;
		}
	}

	public string FormTaxPayementCertificateHeirsCertificateBranch
	{
		get
		{
			return formTaxPayementCertificateHeirsCertificateBranch;
		}
		set
		{
			formTaxPayementCertificateHeirsCertificateBranch = value;
		}
	}

	public string FormTaxPayementCertificateDeadName
	{
		get
		{
			return formTaxPayementCertificateDeadName;
		}
		set
		{
			formTaxPayementCertificateDeadName = value;
		}
	}

	public string FormTaxPayementCertificateDeadLastName
	{
		get
		{
			return formTaxPayementCertificateDeadLastName;
		}
		set
		{
			formTaxPayementCertificateDeadLastName = value;
		}
	}

	public string FormTaxPayementCertificateDeadCertificateNumber
	{
		get
		{
			return formTaxPayementCertificateDeadCertificateNumber;
		}
		set
		{
			formTaxPayementCertificateDeadCertificateNumber = value;
		}
	}

	public string FormTaxPayementCertificateDeathDay
	{
		get
		{
			return formTaxPayementCertificateDeathDay;
		}
		set
		{
			formTaxPayementCertificateDeathDay = value;
		}
	}

	public string FormTaxPayementCertificateIssuanceCity
	{
		get
		{
			return formTaxPayementCertificateIssuanceCity;
		}
		set
		{
			formTaxPayementCertificateIssuanceCity = value;
		}
	}

	public string FormTaxPayementCertificateDeclarationRequestNumber
	{
		get
		{
			return formTaxPayementCertificateDeclarationRequestNumber;
		}
		set
		{
			formTaxPayementCertificateDeclarationRequestNumber = value;
		}
	}

	public string FormTaxPayementCertificateDeclarationRequestResource
	{
		get
		{
			return formTaxPayementCertificateDeclarationRequestResource;
		}
		set
		{
			formTaxPayementCertificateDeclarationRequestResource = value;
		}
	}

	public string FormTaxPayementCertificateApplicantFullName
	{
		get
		{
			return formTaxPayementCertificateApplicantFullName;
		}
		set
		{
			formTaxPayementCertificateApplicantFullName = value;
		}
	}

	public string FormTaxPayementCertificateApplicantFatherName
	{
		get
		{
			return formTaxPayementCertificateApplicantFatherName;
		}
		set
		{
			formTaxPayementCertificateApplicantFatherName = value;
		}
	}

	public string FormTaxPayementCertificateDescription4
	{
		get
		{
			return formTaxPayementCertificateDescription4;
		}
		set
		{
			formTaxPayementCertificateDescription4 = value;
		}
	}

	public string FormTaxPayementCertificateDescriptionHeritage
	{
		get
		{
			return formTaxPayementCertificateDescriptionHeritage;
		}
		set
		{
			formTaxPayementCertificateDescriptionHeritage = value;
		}
	}

	public string FormTaxPayementCertificateRequestNumber
	{
		get
		{
			return formTaxPayementCertificateRequestNumber;
		}
		set
		{
			formTaxPayementCertificateRequestNumber = value;
		}
	}

	public string FormTaxPayementCertificateUser1FullName
	{
		get
		{
			return formTaxPayementCertificateUser1FullName;
		}
		set
		{
			formTaxPayementCertificateUser1FullName = value;
		}
	}

	public string FormTaxPayementCertificateUser2FullName
	{
		get
		{
			return formTaxPayementCertificateUser2FullName;
		}
		set
		{
			formTaxPayementCertificateUser2FullName = value;
		}
	}

	public Int64? FormTaxPayementCertificateRegisterInformationID
	{
		get
		{
			return formTaxPayementCertificateRegisterInformationID;
		}
		set
		{
			formTaxPayementCertificateRegisterInformationID = value;
		}
	}

	public Int64? FormTaxPayementCertificateDeadNationalCode
	{
		get
		{
			return formTaxPayementCertificateDeadNationalCode;
		}
		set
		{
			formTaxPayementCertificateDeadNationalCode = value;
		}
	}

	public Int64? FormTaxPayementCertificateDeclarationID
	{
		get
		{
			return formTaxPayementCertificateDeclarationID;
		}
		set
		{
			formTaxPayementCertificateDeclarationID = value;
		}
	}

	public Int64? FormTaxPayementCertificateTaxOfficeZipCode
	{
		get
		{
			return formTaxPayementCertificateTaxOfficeZipCode;
		}
		set
		{
			formTaxPayementCertificateTaxOfficeZipCode = value;
		}
	}

	public Int64? FormTaxPayementCertificateApplicantNationalCode
	{
		get
		{
			return formTaxPayementCertificateApplicantNationalCode;
		}
		set
		{
			formTaxPayementCertificateApplicantNationalCode = value;
		}
	}

	public Int64? FormTaxPayementCertificateZipCode
	{
		get
		{
			return formTaxPayementCertificateZipCode;
		}
		set
		{
			formTaxPayementCertificateZipCode = value;
		}
	}

	public string FormTaxPayementCertificateApplicantName
	{
		get
		{
			return formTaxPayementCertificateApplicantName;
		}
		set
		{
			formTaxPayementCertificateApplicantName = value;
		}
	}

	public string FormTaxPayementCertificateRegisterDate
	{
		get
		{
			return formTaxPayementCertificateRegisterDate;
		}
		set
		{
			formTaxPayementCertificateRegisterDate = value;
		}
	}

	public string FormTaxPayementCertificateHeirsCertificateDate
	{
		get
		{
			return formTaxPayementCertificateHeirsCertificateDate;
		}
		set
		{
			formTaxPayementCertificateHeirsCertificateDate = value;
		}
	}

	public string FormTaxPayementCertificateRequestDate
	{
		get
		{
			return formTaxPayementCertificateRequestDate;
		}
		set
		{
			formTaxPayementCertificateRequestDate = value;
		}
	}

	public string FormTaxPayementCertificateDeclarationRequestDate
	{
		get
		{
			return formTaxPayementCertificateDeclarationRequestDate;
		}
		set
		{
			formTaxPayementCertificateDeclarationRequestDate = value;
		}
	}

	public string FormTaxPayementCertificateApplicantBirthDate
	{
		get
		{
			return formTaxPayementCertificateApplicantBirthDate;
		}
		set
		{
			formTaxPayementCertificateApplicantBirthDate = value;
		}
	}

	public string FormTaxPayementCertificateDossierClasses
	{
		get
		{
			return formTaxPayementCertificateDossierClasses;
		}
		set
		{
			formTaxPayementCertificateDossierClasses = value;
		}
	}

	public string FormTaxPayementCertificateTaxOfficeTitle
	{
		get
		{
			return formTaxPayementCertificateTaxOfficeTitle;
		}
		set
		{
			formTaxPayementCertificateTaxOfficeTitle = value;
		}
	}

	public string FormTaxPayementCertificateTaxOfficeCity
	{
		get
		{
			return formTaxPayementCertificateTaxOfficeCity;
		}
		set
		{
			formTaxPayementCertificateTaxOfficeCity = value;
		}
	}

	public string FormTaxPayementCertificateTaxOfficeAddress
	{
		get
		{
			return formTaxPayementCertificateTaxOfficeAddress;
		}
		set
		{
			formTaxPayementCertificateTaxOfficeAddress = value;
		}
	}

	public string FormTaxPayementCertificateTaxOfficePhoneNumber
	{
		get
		{
			return formTaxPayementCertificateTaxOfficePhoneNumber;
		}
		set
		{
			formTaxPayementCertificateTaxOfficePhoneNumber = value;
		}
	}

	public string FormTaxPayementCertificateHeirsCertificateNumber
	{
		get
		{
			return formTaxPayementCertificateHeirsCertificateNumber;
		}
		set
		{
			formTaxPayementCertificateHeirsCertificateNumber = value;
		}
	}

	public string FormTaxPayementCertificateDeadFatherName
	{
		get
		{
			return formTaxPayementCertificateDeadFatherName;
		}
		set
		{
			formTaxPayementCertificateDeadFatherName = value;
		}
	}

	public string FormTaxPayementCertificatePhoneNumber
	{
		get
		{
			return formTaxPayementCertificatePhoneNumber;
		}
		set
		{
			formTaxPayementCertificatePhoneNumber = value;
		}
	}

	public string FormTaxPayementCertificateDeadIssuanceCity
	{
		get
		{
			return formTaxPayementCertificateDeadIssuanceCity;
		}
		set
		{
			formTaxPayementCertificateDeadIssuanceCity = value;
		}
	}

	public string FormTaxPayementCertificateApplicantBirthCity
	{
		get
		{
			return formTaxPayementCertificateApplicantBirthCity;
		}
		set
		{
			formTaxPayementCertificateApplicantBirthCity = value;
		}
	}

	public string FormTaxPayementCertificateApplicantCertificateNumber
	{
		get
		{
			return formTaxPayementCertificateApplicantCertificateNumber;
		}
		set
		{
			formTaxPayementCertificateApplicantCertificateNumber = value;
		}
	}

	public string FormTaxPayementCertificateApplicantIssuanceCity
	{
		get
		{
			return formTaxPayementCertificateApplicantIssuanceCity;
		}
		set
		{
			formTaxPayementCertificateApplicantIssuanceCity = value;
		}
	}

	public string FormTaxPayementCertificateApplicantRole
	{
		get
		{
			return formTaxPayementCertificateApplicantRole;
		}
		set
		{
			formTaxPayementCertificateApplicantRole = value;
		}
	}

	public string FormTaxPayementCertificateAddress
	{
		get
		{
			return formTaxPayementCertificateAddress;
		}
		set
		{
			formTaxPayementCertificateAddress = value;
		}
	}

	public string FormTaxPayementCertificateCommercialNumer
	{
		get
		{
			return formTaxPayementCertificateCommercialNumer;
		}
		set
		{
			formTaxPayementCertificateCommercialNumer = value;
		}
	}

	public int? FormTaxPayementCertificateTaxOfficeCode
	{
		get
		{
			return formTaxPayementCertificateTaxOfficeCode;
		}
		set
		{
			formTaxPayementCertificateTaxOfficeCode = value;
		}
	}

	public int? FormTaxPayementCertificateTaxGroupCode
	{
		get
		{
			return formTaxPayementCertificateTaxGroupCode;
		}
		set
		{
			formTaxPayementCertificateTaxGroupCode = value;
		}
	}

	public int? FormTaxPayementCertificateTaxUnitCode
	{
		get
		{
			return formTaxPayementCertificateTaxUnitCode;
		}
		set
		{
			formTaxPayementCertificateTaxUnitCode = value;
		}
	}

}
}
