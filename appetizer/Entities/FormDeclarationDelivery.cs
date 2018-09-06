using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormDeclarationDelivery
{
	private Int64 formDeclarationDeliveryID;
	private string formDeclarationDeliveryPrintRegisterInformationID;
	private string formDeclarationDeliveryPrintRegisterDate;
	private string formDeclarationDeliveryDeadIssuanceCity;
	private string formDeclarationDeliveryDeadDeathCity;
	private string formDeclarationDeliveryUttererRole;
	private string formDeclarationDeliveryDeclarativeValueString;
	private string formDeclarationDeliveryRuleComment2;
	private string formDeclarationDeliveryHeritageDescription;
	private string formDeclarationDeliveryTaxGroupCode;
	private string formDeclarationDeliveryTaxGroupUserName;
	private string formDeclarationDeliveryDeadName;
	private string formDeclarationDeliveryDeadFamilu;
	private string formDeclarationDeliveryDeadCertificateNumber;
	private string formDeclarationDeliveryDeadNationalCode;
	private string formDeclarationDeliveryApplicantName;
	private string formDeclarationDeliveryApplicantFamily;
	private string formDeclarationDeliveryTaxUnitCode;
	private string formDeclarationDeliveryTaxUnitUserName;
	private string formDeclarationDeliveryTaxUnitUserFamily;
	private string formDeclarationDeliveryTaxGroupUserFamily;
	private string formDeclarationDeliveryUttererFamily;
	private string formDeclarationDeliveryUttererCertificateNumber;
	private string formDeclarationDeliveryUttererNationalCode;
	private string formDeclarationDeliveryUttererIssuanceCity;
	private string formDeclarationDeliveryComment2;
	private string formDeclarationDeliveryApplicantNumber;
	private Int64? formDeclarationDeliveryRegisterInformationID;
	private Int64 formDeclarationDeliveryDeclarationID;
	private Int64? formDeclarationDeliveryRegisterarUserNationalCode;
	private string formDeclarationDeliveryDossierClasses;
	private string formDeclarationDeliveryTaxOfficePhoneNumber;
	private string formDeclarationDeliveryApplicantDate;
	private string formDeclarationDeliveryDeadDeathDate;
	private string formDeclarationDeliveryRegisterInformationDate;
	private string formDeclarationDeliveryRuleComment1;
	private string formDeclarationDeliveryTaxOfficeProvince;
	private string formDeclarationDeliveryTaxOfficeCode;
	private string formDeclarationDeliveryTaxOfficeCity;
	private string formDeclarationDeliveryTaxOfficeAddress;
	private string formDeclarationDeliveryUttererName;
	private float? formDeclarationDeliveryDeclarativeValue;

	public Int64 FormDeclarationDeliveryID
	{
		get
		{
			return formDeclarationDeliveryID;
		}
		set
		{
			formDeclarationDeliveryID = value;
		}
	}

	public string FormDeclarationDeliveryPrintRegisterInformationID
	{
		get
		{
			return formDeclarationDeliveryPrintRegisterInformationID;
		}
		set
		{
			formDeclarationDeliveryPrintRegisterInformationID = value;
		}
	}

	public string FormDeclarationDeliveryPrintRegisterDate
	{
		get
		{
			return formDeclarationDeliveryPrintRegisterDate;
		}
		set
		{
			formDeclarationDeliveryPrintRegisterDate = value;
		}
	}

	public string FormDeclarationDeliveryDeadIssuanceCity
	{
		get
		{
			return formDeclarationDeliveryDeadIssuanceCity;
		}
		set
		{
			formDeclarationDeliveryDeadIssuanceCity = value;
		}
	}

	public string FormDeclarationDeliveryDeadDeathCity
	{
		get
		{
			return formDeclarationDeliveryDeadDeathCity;
		}
		set
		{
			formDeclarationDeliveryDeadDeathCity = value;
		}
	}

	public string FormDeclarationDeliveryUttererRole
	{
		get
		{
			return formDeclarationDeliveryUttererRole;
		}
		set
		{
			formDeclarationDeliveryUttererRole = value;
		}
	}

	public string FormDeclarationDeliveryDeclarativeValueString
	{
		get
		{
			return formDeclarationDeliveryDeclarativeValueString;
		}
		set
		{
			formDeclarationDeliveryDeclarativeValueString = value;
		}
	}

	public string FormDeclarationDeliveryRuleComment2
	{
		get
		{
			return formDeclarationDeliveryRuleComment2;
		}
		set
		{
			formDeclarationDeliveryRuleComment2 = value;
		}
	}

	public string FormDeclarationDeliveryHeritageDescription
	{
		get
		{
			return formDeclarationDeliveryHeritageDescription;
		}
		set
		{
			formDeclarationDeliveryHeritageDescription = value;
		}
	}

	public string FormDeclarationDeliveryTaxGroupCode
	{
		get
		{
			return formDeclarationDeliveryTaxGroupCode;
		}
		set
		{
			formDeclarationDeliveryTaxGroupCode = value;
		}
	}

	public string FormDeclarationDeliveryTaxGroupUserName
	{
		get
		{
			return formDeclarationDeliveryTaxGroupUserName;
		}
		set
		{
			formDeclarationDeliveryTaxGroupUserName = value;
		}
	}

	public string FormDeclarationDeliveryDeadName
	{
		get
		{
			return formDeclarationDeliveryDeadName;
		}
		set
		{
			formDeclarationDeliveryDeadName = value;
		}
	}

	public string FormDeclarationDeliveryDeadFamilu
	{
		get
		{
			return formDeclarationDeliveryDeadFamilu;
		}
		set
		{
			formDeclarationDeliveryDeadFamilu = value;
		}
	}

	public string FormDeclarationDeliveryDeadCertificateNumber
	{
		get
		{
			return formDeclarationDeliveryDeadCertificateNumber;
		}
		set
		{
			formDeclarationDeliveryDeadCertificateNumber = value;
		}
	}

	public string FormDeclarationDeliveryDeadNationalCode
	{
		get
		{
			return formDeclarationDeliveryDeadNationalCode;
		}
		set
		{
			formDeclarationDeliveryDeadNationalCode = value;
		}
	}

	public string FormDeclarationDeliveryApplicantName
	{
		get
		{
			return formDeclarationDeliveryApplicantName;
		}
		set
		{
			formDeclarationDeliveryApplicantName = value;
		}
	}

	public string FormDeclarationDeliveryApplicantFamily
	{
		get
		{
			return formDeclarationDeliveryApplicantFamily;
		}
		set
		{
			formDeclarationDeliveryApplicantFamily = value;
		}
	}

	public string FormDeclarationDeliveryTaxUnitCode
	{
		get
		{
			return formDeclarationDeliveryTaxUnitCode;
		}
		set
		{
			formDeclarationDeliveryTaxUnitCode = value;
		}
	}

	public string FormDeclarationDeliveryTaxUnitUserName
	{
		get
		{
			return formDeclarationDeliveryTaxUnitUserName;
		}
		set
		{
			formDeclarationDeliveryTaxUnitUserName = value;
		}
	}

	public string FormDeclarationDeliveryTaxUnitUserFamily
	{
		get
		{
			return formDeclarationDeliveryTaxUnitUserFamily;
		}
		set
		{
			formDeclarationDeliveryTaxUnitUserFamily = value;
		}
	}

	public string FormDeclarationDeliveryTaxGroupUserFamily
	{
		get
		{
			return formDeclarationDeliveryTaxGroupUserFamily;
		}
		set
		{
			formDeclarationDeliveryTaxGroupUserFamily = value;
		}
	}

	public string FormDeclarationDeliveryUttererFamily
	{
		get
		{
			return formDeclarationDeliveryUttererFamily;
		}
		set
		{
			formDeclarationDeliveryUttererFamily = value;
		}
	}

	public string FormDeclarationDeliveryUttererCertificateNumber
	{
		get
		{
			return formDeclarationDeliveryUttererCertificateNumber;
		}
		set
		{
			formDeclarationDeliveryUttererCertificateNumber = value;
		}
	}

	public string FormDeclarationDeliveryUttererNationalCode
	{
		get
		{
			return formDeclarationDeliveryUttererNationalCode;
		}
		set
		{
			formDeclarationDeliveryUttererNationalCode = value;
		}
	}

	public string FormDeclarationDeliveryUttererIssuanceCity
	{
		get
		{
			return formDeclarationDeliveryUttererIssuanceCity;
		}
		set
		{
			formDeclarationDeliveryUttererIssuanceCity = value;
		}
	}

	public string FormDeclarationDeliveryComment2
	{
		get
		{
			return formDeclarationDeliveryComment2;
		}
		set
		{
			formDeclarationDeliveryComment2 = value;
		}
	}

	public string FormDeclarationDeliveryApplicantNumber
	{
		get
		{
			return formDeclarationDeliveryApplicantNumber;
		}
		set
		{
			formDeclarationDeliveryApplicantNumber = value;
		}
	}

	public Int64? FormDeclarationDeliveryRegisterInformationID
	{
		get
		{
			return formDeclarationDeliveryRegisterInformationID;
		}
		set
		{
			formDeclarationDeliveryRegisterInformationID = value;
		}
	}

	public Int64 FormDeclarationDeliveryDeclarationID
	{
		get
		{
			return formDeclarationDeliveryDeclarationID;
		}
		set
		{
			formDeclarationDeliveryDeclarationID = value;
		}
	}

	public Int64? FormDeclarationDeliveryRegisterarUserNationalCode
	{
		get
		{
			return formDeclarationDeliveryRegisterarUserNationalCode;
		}
		set
		{
			formDeclarationDeliveryRegisterarUserNationalCode = value;
		}
	}

	public string FormDeclarationDeliveryDossierClasses
	{
		get
		{
			return formDeclarationDeliveryDossierClasses;
		}
		set
		{
			formDeclarationDeliveryDossierClasses = value;
		}
	}

	public string FormDeclarationDeliveryTaxOfficePhoneNumber
	{
		get
		{
			return formDeclarationDeliveryTaxOfficePhoneNumber;
		}
		set
		{
			formDeclarationDeliveryTaxOfficePhoneNumber = value;
		}
	}

	public string FormDeclarationDeliveryApplicantDate
	{
		get
		{
			return formDeclarationDeliveryApplicantDate;
		}
		set
		{
			formDeclarationDeliveryApplicantDate = value;
		}
	}

	public string FormDeclarationDeliveryDeadDeathDate
	{
		get
		{
			return formDeclarationDeliveryDeadDeathDate;
		}
		set
		{
			formDeclarationDeliveryDeadDeathDate = value;
		}
	}

	public string FormDeclarationDeliveryRegisterInformationDate
	{
		get
		{
			return formDeclarationDeliveryRegisterInformationDate;
		}
		set
		{
			formDeclarationDeliveryRegisterInformationDate = value;
		}
	}

	public string FormDeclarationDeliveryRuleComment1
	{
		get
		{
			return formDeclarationDeliveryRuleComment1;
		}
		set
		{
			formDeclarationDeliveryRuleComment1 = value;
		}
	}

	public string FormDeclarationDeliveryTaxOfficeProvince
	{
		get
		{
			return formDeclarationDeliveryTaxOfficeProvince;
		}
		set
		{
			formDeclarationDeliveryTaxOfficeProvince = value;
		}
	}

	public string FormDeclarationDeliveryTaxOfficeCode
	{
		get
		{
			return formDeclarationDeliveryTaxOfficeCode;
		}
		set
		{
			formDeclarationDeliveryTaxOfficeCode = value;
		}
	}

	public string FormDeclarationDeliveryTaxOfficeCity
	{
		get
		{
			return formDeclarationDeliveryTaxOfficeCity;
		}
		set
		{
			formDeclarationDeliveryTaxOfficeCity = value;
		}
	}

	public string FormDeclarationDeliveryTaxOfficeAddress
	{
		get
		{
			return formDeclarationDeliveryTaxOfficeAddress;
		}
		set
		{
			formDeclarationDeliveryTaxOfficeAddress = value;
		}
	}

	public string FormDeclarationDeliveryUttererName
	{
		get
		{
			return formDeclarationDeliveryUttererName;
		}
		set
		{
			formDeclarationDeliveryUttererName = value;
		}
	}

	public float? FormDeclarationDeliveryDeclarativeValue
	{
		get
		{
			return formDeclarationDeliveryDeclarativeValue;
		}
		set
		{
			formDeclarationDeliveryDeclarativeValue = value;
		}
	}

}
}
