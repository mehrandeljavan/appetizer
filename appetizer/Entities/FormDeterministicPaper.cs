using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormDeterministicPaper
{
	private Int64 formDeterministicPaperID;
	private string formDeterministicPaperPrintRegisterInformationID;
	private string formDeterministicPaperPrintRegisterDate;
	private string formDeterministicPaperReductionType;
	private string formDeterministicPaperPenaltyReason;
	private string formDeterministicPaperComment;
	private string formDeterministicPaperUser1Code;
	private string formDeterministicPaperUser1FullName;
	private string formDeterministicPaperOperationYear2;
	private string formDeterministicPaperHeirJobZipCode;
	private string formDeterministicPaperHeirHomeZipCode;
	private string formDeterministicPaperHeirIdentifier;
	private string formDeterministicPaperTaxTitle;
	private string formDeterministicPaperTaxReason;
	private string formDeterministicPaperTaxNumber;
	private string formDeterministicPaperHeirIssuanceDepartmant;
	private string formDeterministicPaperHeirIssuanceCity;
	private string formDeterministicPaperHeirJobAddress;
	private string formDeterministicPaperHeirHomeAddress;
	private string formDeterministicPaperHeirJobPhoneNumber;
	private string formDeterministicPaperHeirHomePhoneNumber;
	private string formDeterministicPaperHeirName;
	private string formDeterministicPaperHeirFamily;
	private string formDeterministicPaperHeirFatherName;
	private string formDeterministicPaperHeirCertificateNumber;
	private string formDeterministicPaperHeirNationalCode;
	private string formDeterministicPaperHeirIssuanceDate;
	private string formDeterministicPaperDossierClasses;
	private Int64? formDeterministicPaperRegisterInformationID;
	private Int64? formDeterministicPaperDeclarationID;
	private Int64? formDeterministicPaperRegisterarUserNationalCode;
	private string formDeterministicPaperRegisterInformationDate;
	private string formDeterministicPaperTaxDate;
	private string formDeterministicPaperAnnonsiationDate;
	private string formDeterministicPaperReductionDate;
	private string formDeterministicPaperPenaltyDate;
	private string formDeterministicPaperOperationYear1;
	private string formDeterministicPaperTaxOfficeProvince;
	private string formDeterministicPaperTaxOfficeCode;
	private string formDeterministicPaperTaxUintCode;
	private string formDeterministicPaperTaxOfficeAddress;
	private string formDeterministicPaperTaxOfficePhoneNumber;
	private string formDeterministicPaperPayableTaxLetter;
	private string formDeterministicPaperTaxTitle2;
	private float? formDeterministicPaperTaxBase;
	private float? formDeterministicPaperTaxReduction;
	private float? formDeterministicPaperTaxRemaining;
	private float? formDeterministicPaperTax;
	private float? formDeterministicPaperReduction;
	private float? formDeterministicPaperPenalty;
	private float? formDeterministicPaperTotalWithoutPenalty;
	private float? formDeterministicPaperTotal;
	private float? formDeterministicPaperPayableTax;
	private float? formDeterministicPaperTaxRemaining2;

	public Int64 FormDeterministicPaperID
	{
		get
		{
			return formDeterministicPaperID;
		}
		set
		{
			formDeterministicPaperID = value;
		}
	}

	public string FormDeterministicPaperPrintRegisterInformationID
	{
		get
		{
			return formDeterministicPaperPrintRegisterInformationID;
		}
		set
		{
			formDeterministicPaperPrintRegisterInformationID = value;
		}
	}

	public string FormDeterministicPaperPrintRegisterDate
	{
		get
		{
			return formDeterministicPaperPrintRegisterDate;
		}
		set
		{
			formDeterministicPaperPrintRegisterDate = value;
		}
	}

	public string FormDeterministicPaperReductionType
	{
		get
		{
			return formDeterministicPaperReductionType;
		}
		set
		{
			formDeterministicPaperReductionType = value;
		}
	}

	public string FormDeterministicPaperPenaltyReason
	{
		get
		{
			return formDeterministicPaperPenaltyReason;
		}
		set
		{
			formDeterministicPaperPenaltyReason = value;
		}
	}

	public string FormDeterministicPaperComment
	{
		get
		{
			return formDeterministicPaperComment;
		}
		set
		{
			formDeterministicPaperComment = value;
		}
	}

	public string FormDeterministicPaperUser1Code
	{
		get
		{
			return formDeterministicPaperUser1Code;
		}
		set
		{
			formDeterministicPaperUser1Code = value;
		}
	}

	public string FormDeterministicPaperUser1FullName
	{
		get
		{
			return formDeterministicPaperUser1FullName;
		}
		set
		{
			formDeterministicPaperUser1FullName = value;
		}
	}

	public string FormDeterministicPaperOperationYear2
	{
		get
		{
			return formDeterministicPaperOperationYear2;
		}
		set
		{
			formDeterministicPaperOperationYear2 = value;
		}
	}

	public string FormDeterministicPaperHeirJobZipCode
	{
		get
		{
			return formDeterministicPaperHeirJobZipCode;
		}
		set
		{
			formDeterministicPaperHeirJobZipCode = value;
		}
	}

	public string FormDeterministicPaperHeirHomeZipCode
	{
		get
		{
			return formDeterministicPaperHeirHomeZipCode;
		}
		set
		{
			formDeterministicPaperHeirHomeZipCode = value;
		}
	}

	public string FormDeterministicPaperHeirIdentifier
	{
		get
		{
			return formDeterministicPaperHeirIdentifier;
		}
		set
		{
			formDeterministicPaperHeirIdentifier = value;
		}
	}

	public string FormDeterministicPaperTaxTitle
	{
		get
		{
			return formDeterministicPaperTaxTitle;
		}
		set
		{
			formDeterministicPaperTaxTitle = value;
		}
	}

	public string FormDeterministicPaperTaxReason
	{
		get
		{
			return formDeterministicPaperTaxReason;
		}
		set
		{
			formDeterministicPaperTaxReason = value;
		}
	}

	public string FormDeterministicPaperTaxNumber
	{
		get
		{
			return formDeterministicPaperTaxNumber;
		}
		set
		{
			formDeterministicPaperTaxNumber = value;
		}
	}

	public string FormDeterministicPaperHeirIssuanceDepartmant
	{
		get
		{
			return formDeterministicPaperHeirIssuanceDepartmant;
		}
		set
		{
			formDeterministicPaperHeirIssuanceDepartmant = value;
		}
	}

	public string FormDeterministicPaperHeirIssuanceCity
	{
		get
		{
			return formDeterministicPaperHeirIssuanceCity;
		}
		set
		{
			formDeterministicPaperHeirIssuanceCity = value;
		}
	}

	public string FormDeterministicPaperHeirJobAddress
	{
		get
		{
			return formDeterministicPaperHeirJobAddress;
		}
		set
		{
			formDeterministicPaperHeirJobAddress = value;
		}
	}

	public string FormDeterministicPaperHeirHomeAddress
	{
		get
		{
			return formDeterministicPaperHeirHomeAddress;
		}
		set
		{
			formDeterministicPaperHeirHomeAddress = value;
		}
	}

	public string FormDeterministicPaperHeirJobPhoneNumber
	{
		get
		{
			return formDeterministicPaperHeirJobPhoneNumber;
		}
		set
		{
			formDeterministicPaperHeirJobPhoneNumber = value;
		}
	}

	public string FormDeterministicPaperHeirHomePhoneNumber
	{
		get
		{
			return formDeterministicPaperHeirHomePhoneNumber;
		}
		set
		{
			formDeterministicPaperHeirHomePhoneNumber = value;
		}
	}

	public string FormDeterministicPaperHeirName
	{
		get
		{
			return formDeterministicPaperHeirName;
		}
		set
		{
			formDeterministicPaperHeirName = value;
		}
	}

	public string FormDeterministicPaperHeirFamily
	{
		get
		{
			return formDeterministicPaperHeirFamily;
		}
		set
		{
			formDeterministicPaperHeirFamily = value;
		}
	}

	public string FormDeterministicPaperHeirFatherName
	{
		get
		{
			return formDeterministicPaperHeirFatherName;
		}
		set
		{
			formDeterministicPaperHeirFatherName = value;
		}
	}

	public string FormDeterministicPaperHeirCertificateNumber
	{
		get
		{
			return formDeterministicPaperHeirCertificateNumber;
		}
		set
		{
			formDeterministicPaperHeirCertificateNumber = value;
		}
	}

	public string FormDeterministicPaperHeirNationalCode
	{
		get
		{
			return formDeterministicPaperHeirNationalCode;
		}
		set
		{
			formDeterministicPaperHeirNationalCode = value;
		}
	}

	public string FormDeterministicPaperHeirIssuanceDate
	{
		get
		{
			return formDeterministicPaperHeirIssuanceDate;
		}
		set
		{
			formDeterministicPaperHeirIssuanceDate = value;
		}
	}

	public string FormDeterministicPaperDossierClasses
	{
		get
		{
			return formDeterministicPaperDossierClasses;
		}
		set
		{
			formDeterministicPaperDossierClasses = value;
		}
	}

	public Int64? FormDeterministicPaperRegisterInformationID
	{
		get
		{
			return formDeterministicPaperRegisterInformationID;
		}
		set
		{
			formDeterministicPaperRegisterInformationID = value;
		}
	}

	public Int64? FormDeterministicPaperDeclarationID
	{
		get
		{
			return formDeterministicPaperDeclarationID;
		}
		set
		{
			formDeterministicPaperDeclarationID = value;
		}
	}

	public Int64? FormDeterministicPaperRegisterarUserNationalCode
	{
		get
		{
			return formDeterministicPaperRegisterarUserNationalCode;
		}
		set
		{
			formDeterministicPaperRegisterarUserNationalCode = value;
		}
	}

	public string FormDeterministicPaperRegisterInformationDate
	{
		get
		{
			return formDeterministicPaperRegisterInformationDate;
		}
		set
		{
			formDeterministicPaperRegisterInformationDate = value;
		}
	}

	public string FormDeterministicPaperTaxDate
	{
		get
		{
			return formDeterministicPaperTaxDate;
		}
		set
		{
			formDeterministicPaperTaxDate = value;
		}
	}

	public string FormDeterministicPaperAnnonsiationDate
	{
		get
		{
			return formDeterministicPaperAnnonsiationDate;
		}
		set
		{
			formDeterministicPaperAnnonsiationDate = value;
		}
	}

	public string FormDeterministicPaperReductionDate
	{
		get
		{
			return formDeterministicPaperReductionDate;
		}
		set
		{
			formDeterministicPaperReductionDate = value;
		}
	}

	public string FormDeterministicPaperPenaltyDate
	{
		get
		{
			return formDeterministicPaperPenaltyDate;
		}
		set
		{
			formDeterministicPaperPenaltyDate = value;
		}
	}

	public string FormDeterministicPaperOperationYear1
	{
		get
		{
			return formDeterministicPaperOperationYear1;
		}
		set
		{
			formDeterministicPaperOperationYear1 = value;
		}
	}

	public string FormDeterministicPaperTaxOfficeProvince
	{
		get
		{
			return formDeterministicPaperTaxOfficeProvince;
		}
		set
		{
			formDeterministicPaperTaxOfficeProvince = value;
		}
	}

	public string FormDeterministicPaperTaxOfficeCode
	{
		get
		{
			return formDeterministicPaperTaxOfficeCode;
		}
		set
		{
			formDeterministicPaperTaxOfficeCode = value;
		}
	}

	public string FormDeterministicPaperTaxUintCode
	{
		get
		{
			return formDeterministicPaperTaxUintCode;
		}
		set
		{
			formDeterministicPaperTaxUintCode = value;
		}
	}

	public string FormDeterministicPaperTaxOfficeAddress
	{
		get
		{
			return formDeterministicPaperTaxOfficeAddress;
		}
		set
		{
			formDeterministicPaperTaxOfficeAddress = value;
		}
	}

	public string FormDeterministicPaperTaxOfficePhoneNumber
	{
		get
		{
			return formDeterministicPaperTaxOfficePhoneNumber;
		}
		set
		{
			formDeterministicPaperTaxOfficePhoneNumber = value;
		}
	}

	public string FormDeterministicPaperPayableTaxLetter
	{
		get
		{
			return formDeterministicPaperPayableTaxLetter;
		}
		set
		{
			formDeterministicPaperPayableTaxLetter = value;
		}
	}

	public string FormDeterministicPaperTaxTitle2
	{
		get
		{
			return formDeterministicPaperTaxTitle2;
		}
		set
		{
			formDeterministicPaperTaxTitle2 = value;
		}
	}

	public float? FormDeterministicPaperTaxBase
	{
		get
		{
			return formDeterministicPaperTaxBase;
		}
		set
		{
			formDeterministicPaperTaxBase = value;
		}
	}

	public float? FormDeterministicPaperTaxReduction
	{
		get
		{
			return formDeterministicPaperTaxReduction;
		}
		set
		{
			formDeterministicPaperTaxReduction = value;
		}
	}

	public float? FormDeterministicPaperTaxRemaining
	{
		get
		{
			return formDeterministicPaperTaxRemaining;
		}
		set
		{
			formDeterministicPaperTaxRemaining = value;
		}
	}

	public float? FormDeterministicPaperTax
	{
		get
		{
			return formDeterministicPaperTax;
		}
		set
		{
			formDeterministicPaperTax = value;
		}
	}

	public float? FormDeterministicPaperReduction
	{
		get
		{
			return formDeterministicPaperReduction;
		}
		set
		{
			formDeterministicPaperReduction = value;
		}
	}

	public float? FormDeterministicPaperPenalty
	{
		get
		{
			return formDeterministicPaperPenalty;
		}
		set
		{
			formDeterministicPaperPenalty = value;
		}
	}

	public float? FormDeterministicPaperTotalWithoutPenalty
	{
		get
		{
			return formDeterministicPaperTotalWithoutPenalty;
		}
		set
		{
			formDeterministicPaperTotalWithoutPenalty = value;
		}
	}

	public float? FormDeterministicPaperTotal
	{
		get
		{
			return formDeterministicPaperTotal;
		}
		set
		{
			formDeterministicPaperTotal = value;
		}
	}

	public float? FormDeterministicPaperPayableTax
	{
		get
		{
			return formDeterministicPaperPayableTax;
		}
		set
		{
			formDeterministicPaperPayableTax = value;
		}
	}

	public float? FormDeterministicPaperTaxRemaining2
	{
		get
		{
			return formDeterministicPaperTaxRemaining2;
		}
		set
		{
			formDeterministicPaperTaxRemaining2 = value;
		}
	}

}
}
