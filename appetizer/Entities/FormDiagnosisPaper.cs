using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormDiagnosisPaper
{
	private Int64 formDiagnosisPaperID;
	private string formDiagnosisPaperPrintRegisterInformationID;
	private string formDiagnosisPaperPrintRegisterDate;
	private string formDiagnosisPaperlUser1Code;
	private string formDiagnosisPaperUser1FullName;
	private string formDiagnosisPaperUser2Code;
	private string formDiagnosisPaperlUser2FullName;
	private string formDiagnosisPaperTaxDescription;
	private string formDiagnosisPaperDeadNationality;
	private string formDiagnosisPaperDeadLastAddress;
	private string formDiagnosisPaperHeirLevel1;
	private string formDiagnosisPaperHeirLevel2;
	private string formDiagnosisPaperHeirLevel3;
	private string formDiagnosisPaperHeirLevel4;
	private string formDiagnosisPaperHeirName;
	private string formDiagnosisPaperHeirFamily;
	private string formDiagnosisPaperHeirIdentifier;
	private string formDiagnosisPaperHeirAddress;
	private string formDiagnosisPaperHeirNationalCode;
	private string formDiagnosisPaperDeadFullName;
	private string formDiagnosisPaperHeirZipCode;
	private Int64 formDiagnosisPaperRegisterInformationID;
	private Int64? formDiagnosisPaperDeclarationID;
	private Int64? formDiagnosisPaperRegisterarUserNationalCode;
	private string formDiagnosisPaperDossierClasses;
	private string formDiagnosisPaperDeadDeathDate;
	private string formDiagnosisPaperRegisterInformationDate;
	private string formDiagnosisPaperCommentHeader;
	private string formDiagnosisPaperTaxOfficeProvince;
	private string formDiagnosisPaperTaxOfficeCode;
	private string formDiagnosisPaperTaxUnitCode;
	private string formDiagnosisPaperTaxOfficeAddress;
	private string formDiagnosisPaperTaxOfficePhoneNumber;
	private float? formDiagnosisPaperTotalValue1;
	private float? formDiagnosisPaperReduction1;
	private float? formDiagnosisPaperTotalValue2;
	private float? formDiagnosisPaperReduction2;
	private float? formDiagnosisPaperTotalValue3;
	private float? formDiagnosisPaperYourShare;
	private float? formDiagnosisPaperIncludedShare;
	private float? formDiagnosisPaperYourShareWill;
	private float? formDiagnosisPaperTotalValue4;
	private float? formDiagnosisPaperReduction3;
	private float? formDiagnosisPaperTax;
	private float? formDiagnosisPaperTaxTypeA;
	private float? formDiagnosisPaperTaxTypeB;
	private List<FormDiagnosisPaperBack> formDiagnosisPaperBackList;

	public Int64 FormDiagnosisPaperID
	{
		get
		{
			return formDiagnosisPaperID;
		}
		set
		{
			formDiagnosisPaperID = value;
		}
	}

	public string FormDiagnosisPaperPrintRegisterInformationID
	{
		get
		{
			return formDiagnosisPaperPrintRegisterInformationID;
		}
		set
		{
			formDiagnosisPaperPrintRegisterInformationID = value;
		}
	}

	public string FormDiagnosisPaperPrintRegisterDate
	{
		get
		{
			return formDiagnosisPaperPrintRegisterDate;
		}
		set
		{
			formDiagnosisPaperPrintRegisterDate = value;
		}
	}

	public string FormDiagnosisPaperlUser1Code
	{
		get
		{
			return formDiagnosisPaperlUser1Code;
		}
		set
		{
			formDiagnosisPaperlUser1Code = value;
		}
	}

	public string FormDiagnosisPaperUser1FullName
	{
		get
		{
			return formDiagnosisPaperUser1FullName;
		}
		set
		{
			formDiagnosisPaperUser1FullName = value;
		}
	}

	public string FormDiagnosisPaperUser2Code
	{
		get
		{
			return formDiagnosisPaperUser2Code;
		}
		set
		{
			formDiagnosisPaperUser2Code = value;
		}
	}

	public string FormDiagnosisPaperlUser2FullName
	{
		get
		{
			return formDiagnosisPaperlUser2FullName;
		}
		set
		{
			formDiagnosisPaperlUser2FullName = value;
		}
	}

	public string FormDiagnosisPaperTaxDescription
	{
		get
		{
			return formDiagnosisPaperTaxDescription;
		}
		set
		{
			formDiagnosisPaperTaxDescription = value;
		}
	}

	public string FormDiagnosisPaperDeadNationality
	{
		get
		{
			return formDiagnosisPaperDeadNationality;
		}
		set
		{
			formDiagnosisPaperDeadNationality = value;
		}
	}

	public string FormDiagnosisPaperDeadLastAddress
	{
		get
		{
			return formDiagnosisPaperDeadLastAddress;
		}
		set
		{
			formDiagnosisPaperDeadLastAddress = value;
		}
	}

	public string FormDiagnosisPaperHeirLevel1
	{
		get
		{
			return formDiagnosisPaperHeirLevel1;
		}
		set
		{
			formDiagnosisPaperHeirLevel1 = value;
		}
	}

	public string FormDiagnosisPaperHeirLevel2
	{
		get
		{
			return formDiagnosisPaperHeirLevel2;
		}
		set
		{
			formDiagnosisPaperHeirLevel2 = value;
		}
	}

	public string FormDiagnosisPaperHeirLevel3
	{
		get
		{
			return formDiagnosisPaperHeirLevel3;
		}
		set
		{
			formDiagnosisPaperHeirLevel3 = value;
		}
	}

	public string FormDiagnosisPaperHeirLevel4
	{
		get
		{
			return formDiagnosisPaperHeirLevel4;
		}
		set
		{
			formDiagnosisPaperHeirLevel4 = value;
		}
	}

	public string FormDiagnosisPaperHeirName
	{
		get
		{
			return formDiagnosisPaperHeirName;
		}
		set
		{
			formDiagnosisPaperHeirName = value;
		}
	}

	public string FormDiagnosisPaperHeirFamily
	{
		get
		{
			return formDiagnosisPaperHeirFamily;
		}
		set
		{
			formDiagnosisPaperHeirFamily = value;
		}
	}

	public string FormDiagnosisPaperHeirIdentifier
	{
		get
		{
			return formDiagnosisPaperHeirIdentifier;
		}
		set
		{
			formDiagnosisPaperHeirIdentifier = value;
		}
	}

	public string FormDiagnosisPaperHeirAddress
	{
		get
		{
			return formDiagnosisPaperHeirAddress;
		}
		set
		{
			formDiagnosisPaperHeirAddress = value;
		}
	}

	public string FormDiagnosisPaperHeirNationalCode
	{
		get
		{
			return formDiagnosisPaperHeirNationalCode;
		}
		set
		{
			formDiagnosisPaperHeirNationalCode = value;
		}
	}

	public string FormDiagnosisPaperDeadFullName
	{
		get
		{
			return formDiagnosisPaperDeadFullName;
		}
		set
		{
			formDiagnosisPaperDeadFullName = value;
		}
	}

	public string FormDiagnosisPaperHeirZipCode
	{
		get
		{
			return formDiagnosisPaperHeirZipCode;
		}
		set
		{
			formDiagnosisPaperHeirZipCode = value;
		}
	}

	public Int64 FormDiagnosisPaperRegisterInformationID
	{
		get
		{
			return formDiagnosisPaperRegisterInformationID;
		}
		set
		{
			formDiagnosisPaperRegisterInformationID = value;
		}
	}

	public Int64? FormDiagnosisPaperDeclarationID
	{
		get
		{
			return formDiagnosisPaperDeclarationID;
		}
		set
		{
			formDiagnosisPaperDeclarationID = value;
		}
	}

	public Int64? FormDiagnosisPaperRegisterarUserNationalCode
	{
		get
		{
			return formDiagnosisPaperRegisterarUserNationalCode;
		}
		set
		{
			formDiagnosisPaperRegisterarUserNationalCode = value;
		}
	}

	public string FormDiagnosisPaperDossierClasses
	{
		get
		{
			return formDiagnosisPaperDossierClasses;
		}
		set
		{
			formDiagnosisPaperDossierClasses = value;
		}
	}

	public string FormDiagnosisPaperDeadDeathDate
	{
		get
		{
			return formDiagnosisPaperDeadDeathDate;
		}
		set
		{
			formDiagnosisPaperDeadDeathDate = value;
		}
	}

	public string FormDiagnosisPaperRegisterInformationDate
	{
		get
		{
			return formDiagnosisPaperRegisterInformationDate;
		}
		set
		{
			formDiagnosisPaperRegisterInformationDate = value;
		}
	}

	public string FormDiagnosisPaperCommentHeader
	{
		get
		{
			return formDiagnosisPaperCommentHeader;
		}
		set
		{
			formDiagnosisPaperCommentHeader = value;
		}
	}

	public string FormDiagnosisPaperTaxOfficeProvince
	{
		get
		{
			return formDiagnosisPaperTaxOfficeProvince;
		}
		set
		{
			formDiagnosisPaperTaxOfficeProvince = value;
		}
	}

	public string FormDiagnosisPaperTaxOfficeCode
	{
		get
		{
			return formDiagnosisPaperTaxOfficeCode;
		}
		set
		{
			formDiagnosisPaperTaxOfficeCode = value;
		}
	}

	public string FormDiagnosisPaperTaxUnitCode
	{
		get
		{
			return formDiagnosisPaperTaxUnitCode;
		}
		set
		{
			formDiagnosisPaperTaxUnitCode = value;
		}
	}

	public string FormDiagnosisPaperTaxOfficeAddress
	{
		get
		{
			return formDiagnosisPaperTaxOfficeAddress;
		}
		set
		{
			formDiagnosisPaperTaxOfficeAddress = value;
		}
	}

	public string FormDiagnosisPaperTaxOfficePhoneNumber
	{
		get
		{
			return formDiagnosisPaperTaxOfficePhoneNumber;
		}
		set
		{
			formDiagnosisPaperTaxOfficePhoneNumber = value;
		}
	}

	public float? FormDiagnosisPaperTotalValue1
	{
		get
		{
			return formDiagnosisPaperTotalValue1;
		}
		set
		{
			formDiagnosisPaperTotalValue1 = value;
		}
	}

	public float? FormDiagnosisPaperReduction1
	{
		get
		{
			return formDiagnosisPaperReduction1;
		}
		set
		{
			formDiagnosisPaperReduction1 = value;
		}
	}

	public float? FormDiagnosisPaperTotalValue2
	{
		get
		{
			return formDiagnosisPaperTotalValue2;
		}
		set
		{
			formDiagnosisPaperTotalValue2 = value;
		}
	}

	public float? FormDiagnosisPaperReduction2
	{
		get
		{
			return formDiagnosisPaperReduction2;
		}
		set
		{
			formDiagnosisPaperReduction2 = value;
		}
	}

	public float? FormDiagnosisPaperTotalValue3
	{
		get
		{
			return formDiagnosisPaperTotalValue3;
		}
		set
		{
			formDiagnosisPaperTotalValue3 = value;
		}
	}

	public float? FormDiagnosisPaperYourShare
	{
		get
		{
			return formDiagnosisPaperYourShare;
		}
		set
		{
			formDiagnosisPaperYourShare = value;
		}
	}

	public float? FormDiagnosisPaperIncludedShare
	{
		get
		{
			return formDiagnosisPaperIncludedShare;
		}
		set
		{
			formDiagnosisPaperIncludedShare = value;
		}
	}

	public float? FormDiagnosisPaperYourShareWill
	{
		get
		{
			return formDiagnosisPaperYourShareWill;
		}
		set
		{
			formDiagnosisPaperYourShareWill = value;
		}
	}

	public float? FormDiagnosisPaperTotalValue4
	{
		get
		{
			return formDiagnosisPaperTotalValue4;
		}
		set
		{
			formDiagnosisPaperTotalValue4 = value;
		}
	}

	public float? FormDiagnosisPaperReduction3
	{
		get
		{
			return formDiagnosisPaperReduction3;
		}
		set
		{
			formDiagnosisPaperReduction3 = value;
		}
	}

	public float? FormDiagnosisPaperTax
	{
		get
		{
			return formDiagnosisPaperTax;
		}
		set
		{
			formDiagnosisPaperTax = value;
		}
	}

	public float? FormDiagnosisPaperTaxTypeA
	{
		get
		{
			return formDiagnosisPaperTaxTypeA;
		}
		set
		{
			formDiagnosisPaperTaxTypeA = value;
		}
	}

	public float? FormDiagnosisPaperTaxTypeB
	{
		get
		{
			return formDiagnosisPaperTaxTypeB;
		}
		set
		{
			formDiagnosisPaperTaxTypeB = value;
		}
	}

	public List<FormDiagnosisPaperBack> FormDiagnosisPaperBackList
	{
		get
		{
			return formDiagnosisPaperBackList;
		}
		set
		{
			formDiagnosisPaperBackList = value;
		}
	}

	public List<FormDiagnosisPaperBack> GetListFormDiagnosisPaperBack()
	{
		FormDiagnosisPaperBackList = new FormDiagnosisPaperDBAccess().GetListFormDiagnosisPaperBack(this.FormDiagnosisPaperID);
		return FormDiagnosisPaperBackList;
	}

	public bool AddFormDiagnosisPaperBack(FormDiagnosisPaperBack formDiagnosisPaperBack)
	{
		formDiagnosisPaperBack.FormDiagnosisPaperBackID = this.FormDiagnosisPaperID;
		FormDiagnosisPaperBackDBAccess formDiagnosisPaperBackDBAccess = new FormDiagnosisPaperBackDBAccess();
		if (formDiagnosisPaperBackDBAccess.Insert(formDiagnosisPaperBack)>0)
			return (true);
		return (false);
	}

}
}
