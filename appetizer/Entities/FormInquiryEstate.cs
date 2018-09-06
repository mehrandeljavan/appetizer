using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormInquiryEstate
{
	private Int64 formInquiryEstateID;
	private string formInquiryEstatePrintRegisterInformationID;
	private string formInquiryEstatePrintRegisterDate;
	private string formInquiryEstateRuleComment1;
	private string formInquiryEstateRuleComment2;
	private string formInquiryEstateRegisterInformationDate;
	private string formInquiryEstateDossierClasses;
	private string formInquiryEstateDeadDeathDate;
	private string formInquiryEstateTaxUnitCode1;
	private string formInquiryEstateUser1TaxUnitCode;
	private string formInquiryEstateUser2TaxGroupCode;
	private string formInquiryEstateTaxUnitCode2;
	private Int64 formInquiryEstateDeclarationID;
	private Int64? formInquiryEstateRegisterarUserNationalCode;
	private Int64? formInquiryEstateFormInquiryResponseID;
	private string formInquiryEstateDeadFullName;
	private string formInquiryEstateUser1FullName;
	private string formInquiryEstateUser2FullName;
	private string formInquiryEstateReciver;
	private string formInquiryEstateReciverRole;
	private string formInquiryEstateReciverHeritageDescription;
	private Int64 formInquiryEstateRegisterInformationID;

	public Int64 FormInquiryEstateID
	{
		get
		{
			return formInquiryEstateID;
		}
		set
		{
			formInquiryEstateID = value;
		}
	}

	public string FormInquiryEstatePrintRegisterInformationID
	{
		get
		{
			return formInquiryEstatePrintRegisterInformationID;
		}
		set
		{
			formInquiryEstatePrintRegisterInformationID = value;
		}
	}

	public string FormInquiryEstatePrintRegisterDate
	{
		get
		{
			return formInquiryEstatePrintRegisterDate;
		}
		set
		{
			formInquiryEstatePrintRegisterDate = value;
		}
	}

	public string FormInquiryEstateRuleComment1
	{
		get
		{
			return formInquiryEstateRuleComment1;
		}
		set
		{
			formInquiryEstateRuleComment1 = value;
		}
	}

	public string FormInquiryEstateRuleComment2
	{
		get
		{
			return formInquiryEstateRuleComment2;
		}
		set
		{
			formInquiryEstateRuleComment2 = value;
		}
	}

	public string FormInquiryEstateRegisterInformationDate
	{
		get
		{
			return formInquiryEstateRegisterInformationDate;
		}
		set
		{
			formInquiryEstateRegisterInformationDate = value;
		}
	}

	public string FormInquiryEstateDossierClasses
	{
		get
		{
			return formInquiryEstateDossierClasses;
		}
		set
		{
			formInquiryEstateDossierClasses = value;
		}
	}

	public string FormInquiryEstateDeadDeathDate
	{
		get
		{
			return formInquiryEstateDeadDeathDate;
		}
		set
		{
			formInquiryEstateDeadDeathDate = value;
		}
	}

	public string FormInquiryEstateTaxUnitCode1
	{
		get
		{
			return formInquiryEstateTaxUnitCode1;
		}
		set
		{
			formInquiryEstateTaxUnitCode1 = value;
		}
	}

	public string FormInquiryEstateUser1TaxUnitCode
	{
		get
		{
			return formInquiryEstateUser1TaxUnitCode;
		}
		set
		{
			formInquiryEstateUser1TaxUnitCode = value;
		}
	}

	public string FormInquiryEstateUser2TaxGroupCode
	{
		get
		{
			return formInquiryEstateUser2TaxGroupCode;
		}
		set
		{
			formInquiryEstateUser2TaxGroupCode = value;
		}
	}

	public string FormInquiryEstateTaxUnitCode2
	{
		get
		{
			return formInquiryEstateTaxUnitCode2;
		}
		set
		{
			formInquiryEstateTaxUnitCode2 = value;
		}
	}

	public Int64 FormInquiryEstateDeclarationID
	{
		get
		{
			return formInquiryEstateDeclarationID;
		}
		set
		{
			formInquiryEstateDeclarationID = value;
		}
	}

	public Int64? FormInquiryEstateRegisterarUserNationalCode
	{
		get
		{
			return formInquiryEstateRegisterarUserNationalCode;
		}
		set
		{
			formInquiryEstateRegisterarUserNationalCode = value;
		}
	}

	public Int64? FormInquiryEstateFormInquiryResponseID
	{
		get
		{
			return formInquiryEstateFormInquiryResponseID;
		}
		set
		{
			formInquiryEstateFormInquiryResponseID = value;
		}
	}

	public string FormInquiryEstateDeadFullName
	{
		get
		{
			return formInquiryEstateDeadFullName;
		}
		set
		{
			formInquiryEstateDeadFullName = value;
		}
	}

	public string FormInquiryEstateUser1FullName
	{
		get
		{
			return formInquiryEstateUser1FullName;
		}
		set
		{
			formInquiryEstateUser1FullName = value;
		}
	}

	public string FormInquiryEstateUser2FullName
	{
		get
		{
			return formInquiryEstateUser2FullName;
		}
		set
		{
			formInquiryEstateUser2FullName = value;
		}
	}

	public string FormInquiryEstateReciver
	{
		get
		{
			return formInquiryEstateReciver;
		}
		set
		{
			formInquiryEstateReciver = value;
		}
	}

	public string FormInquiryEstateReciverRole
	{
		get
		{
			return formInquiryEstateReciverRole;
		}
		set
		{
			formInquiryEstateReciverRole = value;
		}
	}

	public string FormInquiryEstateReciverHeritageDescription
	{
		get
		{
			return formInquiryEstateReciverHeritageDescription;
		}
		set
		{
			formInquiryEstateReciverHeritageDescription = value;
		}
	}

	public Int64 FormInquiryEstateRegisterInformationID
	{
		get
		{
			return formInquiryEstateRegisterInformationID;
		}
		set
		{
			formInquiryEstateRegisterInformationID = value;
		}
	}

}
}
