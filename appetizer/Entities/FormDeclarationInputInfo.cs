using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormDeclarationInputInfo
{
	private Int64 formDeclarationInputInfoID;
	private string formDeclarationInputInfoPrintRegisterInformationID;
	private string formDeclarationInputInfoPrintRegisterDate;
	private string formDeclarationInputInfoDeadDeathProvince;
	private string formDeclarationInputInfoDeadDeathCity;
	private string formDeclarationInputInfoTaxOfficeRegisterInfoProvince;
	private string formDeclarationInputInfoTaxOfficeRegisterInfoCity;
	private string formDeclarationInputInfoTaxUnitCode;
	private string formDeclarationInputInfoDeadZipCode;
	private string formDeclarationInputInfoDeadFatherName;
	private string formDeclarationInputInfoDeadCertificateNumber;
	private string formDeclarationInputInfoDeadCertificateSerial;
	private string formDeclarationInputInfoDeadIssuanceProvice;
	private string formDeclarationInputInfoDeadIssuanceCity;
	private string formDeclarationInputInfoDeadIssuanceDepartmant;
	private Int64? formDeclarationInputInfoDeclarationID;
	private Int64? formDeclarationInputInfoRegisterInformationID;
	private Int64? formDeclarationInputInfoDeclarationRegisterInformationID;
	private Int64? formDeclarationInputInfoRegisterarUserNationalCode;
	private string formDeclarationInputInfoDeadIssuanceDate;
	private string formDeclarationInputInfoDeadBirthDate;
	private string formDeclarationInputInfoDeadDeathDate;
	private string formDeclarationInputInfoDeclarationRegisterInformationDate;
	private string formDeclarationInputInfoApproveDate;
	private string formDeclarationInputInfoRegisterInformationDate;
	private string formDeclarationInputInfoDeadNationalCode;
	private string formDeclarationInputInfoTaxOfficeTitle;
	private string formDeclarationInputInfoTaxOfficeCity;
	private string formDeclarationInputInfoDeclarationStage;
	private string formDeclarationInputInfoDeadName;
	private string formDeclarationInputInfoDeadFamily;
	private string formDeclarationInputInfoDeadUniqueCode;
	private string formDeclarationInputInfoApprovalUserName;
	private string formDeclarationInputInfoApprovalUserFamily;
	private string formDeclarationInputInfoTaxOfficeProvince;

	public Int64 FormDeclarationInputInfoID
	{
		get
		{
			return formDeclarationInputInfoID;
		}
		set
		{
			formDeclarationInputInfoID = value;
		}
	}

	public string FormDeclarationInputInfoPrintRegisterInformationID
	{
		get
		{
			return formDeclarationInputInfoPrintRegisterInformationID;
		}
		set
		{
			formDeclarationInputInfoPrintRegisterInformationID = value;
		}
	}

	public string FormDeclarationInputInfoPrintRegisterDate
	{
		get
		{
			return formDeclarationInputInfoPrintRegisterDate;
		}
		set
		{
			formDeclarationInputInfoPrintRegisterDate = value;
		}
	}

	public string FormDeclarationInputInfoDeadDeathProvince
	{
		get
		{
			return formDeclarationInputInfoDeadDeathProvince;
		}
		set
		{
			formDeclarationInputInfoDeadDeathProvince = value;
		}
	}

	public string FormDeclarationInputInfoDeadDeathCity
	{
		get
		{
			return formDeclarationInputInfoDeadDeathCity;
		}
		set
		{
			formDeclarationInputInfoDeadDeathCity = value;
		}
	}

	public string FormDeclarationInputInfoTaxOfficeRegisterInfoProvince
	{
		get
		{
			return formDeclarationInputInfoTaxOfficeRegisterInfoProvince;
		}
		set
		{
			formDeclarationInputInfoTaxOfficeRegisterInfoProvince = value;
		}
	}

	public string FormDeclarationInputInfoTaxOfficeRegisterInfoCity
	{
		get
		{
			return formDeclarationInputInfoTaxOfficeRegisterInfoCity;
		}
		set
		{
			formDeclarationInputInfoTaxOfficeRegisterInfoCity = value;
		}
	}

	public string FormDeclarationInputInfoTaxUnitCode
	{
		get
		{
			return formDeclarationInputInfoTaxUnitCode;
		}
		set
		{
			formDeclarationInputInfoTaxUnitCode = value;
		}
	}

	public string FormDeclarationInputInfoDeadZipCode
	{
		get
		{
			return formDeclarationInputInfoDeadZipCode;
		}
		set
		{
			formDeclarationInputInfoDeadZipCode = value;
		}
	}

	public string FormDeclarationInputInfoDeadFatherName
	{
		get
		{
			return formDeclarationInputInfoDeadFatherName;
		}
		set
		{
			formDeclarationInputInfoDeadFatherName = value;
		}
	}

	public string FormDeclarationInputInfoDeadCertificateNumber
	{
		get
		{
			return formDeclarationInputInfoDeadCertificateNumber;
		}
		set
		{
			formDeclarationInputInfoDeadCertificateNumber = value;
		}
	}

	public string FormDeclarationInputInfoDeadCertificateSerial
	{
		get
		{
			return formDeclarationInputInfoDeadCertificateSerial;
		}
		set
		{
			formDeclarationInputInfoDeadCertificateSerial = value;
		}
	}

	public string FormDeclarationInputInfoDeadIssuanceProvice
	{
		get
		{
			return formDeclarationInputInfoDeadIssuanceProvice;
		}
		set
		{
			formDeclarationInputInfoDeadIssuanceProvice = value;
		}
	}

	public string FormDeclarationInputInfoDeadIssuanceCity
	{
		get
		{
			return formDeclarationInputInfoDeadIssuanceCity;
		}
		set
		{
			formDeclarationInputInfoDeadIssuanceCity = value;
		}
	}

	public string FormDeclarationInputInfoDeadIssuanceDepartmant
	{
		get
		{
			return formDeclarationInputInfoDeadIssuanceDepartmant;
		}
		set
		{
			formDeclarationInputInfoDeadIssuanceDepartmant = value;
		}
	}

	public Int64? FormDeclarationInputInfoDeclarationID
	{
		get
		{
			return formDeclarationInputInfoDeclarationID;
		}
		set
		{
			formDeclarationInputInfoDeclarationID = value;
		}
	}

	public Int64? FormDeclarationInputInfoRegisterInformationID
	{
		get
		{
			return formDeclarationInputInfoRegisterInformationID;
		}
		set
		{
			formDeclarationInputInfoRegisterInformationID = value;
		}
	}

	public Int64? FormDeclarationInputInfoDeclarationRegisterInformationID
	{
		get
		{
			return formDeclarationInputInfoDeclarationRegisterInformationID;
		}
		set
		{
			formDeclarationInputInfoDeclarationRegisterInformationID = value;
		}
	}

	public Int64? FormDeclarationInputInfoRegisterarUserNationalCode
	{
		get
		{
			return formDeclarationInputInfoRegisterarUserNationalCode;
		}
		set
		{
			formDeclarationInputInfoRegisterarUserNationalCode = value;
		}
	}

	public string FormDeclarationInputInfoDeadIssuanceDate
	{
		get
		{
			return formDeclarationInputInfoDeadIssuanceDate;
		}
		set
		{
			formDeclarationInputInfoDeadIssuanceDate = value;
		}
	}

	public string FormDeclarationInputInfoDeadBirthDate
	{
		get
		{
			return formDeclarationInputInfoDeadBirthDate;
		}
		set
		{
			formDeclarationInputInfoDeadBirthDate = value;
		}
	}

	public string FormDeclarationInputInfoDeadDeathDate
	{
		get
		{
			return formDeclarationInputInfoDeadDeathDate;
		}
		set
		{
			formDeclarationInputInfoDeadDeathDate = value;
		}
	}

	public string FormDeclarationInputInfoDeclarationRegisterInformationDate
	{
		get
		{
			return formDeclarationInputInfoDeclarationRegisterInformationDate;
		}
		set
		{
			formDeclarationInputInfoDeclarationRegisterInformationDate = value;
		}
	}

	public string FormDeclarationInputInfoApproveDate
	{
		get
		{
			return formDeclarationInputInfoApproveDate;
		}
		set
		{
			formDeclarationInputInfoApproveDate = value;
		}
	}

	public string FormDeclarationInputInfoRegisterInformationDate
	{
		get
		{
			return formDeclarationInputInfoRegisterInformationDate;
		}
		set
		{
			formDeclarationInputInfoRegisterInformationDate = value;
		}
	}

	public string FormDeclarationInputInfoDeadNationalCode
	{
		get
		{
			return formDeclarationInputInfoDeadNationalCode;
		}
		set
		{
			formDeclarationInputInfoDeadNationalCode = value;
		}
	}

	public string FormDeclarationInputInfoTaxOfficeTitle
	{
		get
		{
			return formDeclarationInputInfoTaxOfficeTitle;
		}
		set
		{
			formDeclarationInputInfoTaxOfficeTitle = value;
		}
	}

	public string FormDeclarationInputInfoTaxOfficeCity
	{
		get
		{
			return formDeclarationInputInfoTaxOfficeCity;
		}
		set
		{
			formDeclarationInputInfoTaxOfficeCity = value;
		}
	}

	public string FormDeclarationInputInfoDeclarationStage
	{
		get
		{
			return formDeclarationInputInfoDeclarationStage;
		}
		set
		{
			formDeclarationInputInfoDeclarationStage = value;
		}
	}

	public string FormDeclarationInputInfoDeadName
	{
		get
		{
			return formDeclarationInputInfoDeadName;
		}
		set
		{
			formDeclarationInputInfoDeadName = value;
		}
	}

	public string FormDeclarationInputInfoDeadFamily
	{
		get
		{
			return formDeclarationInputInfoDeadFamily;
		}
		set
		{
			formDeclarationInputInfoDeadFamily = value;
		}
	}

	public string FormDeclarationInputInfoDeadUniqueCode
	{
		get
		{
			return formDeclarationInputInfoDeadUniqueCode;
		}
		set
		{
			formDeclarationInputInfoDeadUniqueCode = value;
		}
	}

	public string FormDeclarationInputInfoApprovalUserName
	{
		get
		{
			return formDeclarationInputInfoApprovalUserName;
		}
		set
		{
			formDeclarationInputInfoApprovalUserName = value;
		}
	}

	public string FormDeclarationInputInfoApprovalUserFamily
	{
		get
		{
			return formDeclarationInputInfoApprovalUserFamily;
		}
		set
		{
			formDeclarationInputInfoApprovalUserFamily = value;
		}
	}

	public string FormDeclarationInputInfoTaxOfficeProvince
	{
		get
		{
			return formDeclarationInputInfoTaxOfficeProvince;
		}
		set
		{
			formDeclarationInputInfoTaxOfficeProvince = value;
		}
	}

}
}
