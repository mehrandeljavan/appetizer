using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormInquiryGoodWillEvaluation
{
	private Int64 formInquiryGoodWillEvaluationID;
	private string formInquiryGoodWillEvaluationPrintRegisterInformationID;
	private string formInquiryGoodWillEvaluationPrintRegisterDate;
	private string formInquiryGoodWillEvaluationAddress;
	private string formInquiryGoodWillEvaluationUser1FullName;
	private string formInquiryGoodWillEvaluationUser2FullName;
	private string formInquiryGoodWillEvaluationUser1TaxUnitCode;
	private string formInquiryGoodWillEvaluationUser2TaxGroupCode;
	private string formInquiryGoodWillEvaluationPhoneNumber;
	private string formInquiryGoodWillEvaluationlRegisterInformationDate;
	private string formInquiryGoodWillEvaluationDossierClasses;
	private string formInquiryGoodWillEvaluationDeadDeathDate;
	private Int64? formInquiryGoodWillEvaluationRegisterInformationID;
	private Int64 formInquiryGoodWillEvaluationlDeclarationID;
	private Int64? formInquiryGoodWillEvaluationRegisterarUserNationalCode;
	private Int64? formInquiryGoodWillEvaluationFormInquiryResponseID;
	private string formInquiryGoodWillEvaluationDeadFullName;
	private string formInquiryGoodWillEvaluationInquiryTo;
	private string formInquiryGoodWillEvaluationSixth;
	private string formInquiryGoodWillEvaluationFromGoodwill;
	private string formInquiryGoodWillEvaluationPlaque;
	private string formInquiryGoodWillEvaluationSection;

	public Int64 FormInquiryGoodWillEvaluationID
	{
		get
		{
			return formInquiryGoodWillEvaluationID;
		}
		set
		{
			formInquiryGoodWillEvaluationID = value;
		}
	}

	public string FormInquiryGoodWillEvaluationPrintRegisterInformationID
	{
		get
		{
			return formInquiryGoodWillEvaluationPrintRegisterInformationID;
		}
		set
		{
			formInquiryGoodWillEvaluationPrintRegisterInformationID = value;
		}
	}

	public string FormInquiryGoodWillEvaluationPrintRegisterDate
	{
		get
		{
			return formInquiryGoodWillEvaluationPrintRegisterDate;
		}
		set
		{
			formInquiryGoodWillEvaluationPrintRegisterDate = value;
		}
	}

	public string FormInquiryGoodWillEvaluationAddress
	{
		get
		{
			return formInquiryGoodWillEvaluationAddress;
		}
		set
		{
			formInquiryGoodWillEvaluationAddress = value;
		}
	}

	public string FormInquiryGoodWillEvaluationUser1FullName
	{
		get
		{
			return formInquiryGoodWillEvaluationUser1FullName;
		}
		set
		{
			formInquiryGoodWillEvaluationUser1FullName = value;
		}
	}

	public string FormInquiryGoodWillEvaluationUser2FullName
	{
		get
		{
			return formInquiryGoodWillEvaluationUser2FullName;
		}
		set
		{
			formInquiryGoodWillEvaluationUser2FullName = value;
		}
	}

	public string FormInquiryGoodWillEvaluationUser1TaxUnitCode
	{
		get
		{
			return formInquiryGoodWillEvaluationUser1TaxUnitCode;
		}
		set
		{
			formInquiryGoodWillEvaluationUser1TaxUnitCode = value;
		}
	}

	public string FormInquiryGoodWillEvaluationUser2TaxGroupCode
	{
		get
		{
			return formInquiryGoodWillEvaluationUser2TaxGroupCode;
		}
		set
		{
			formInquiryGoodWillEvaluationUser2TaxGroupCode = value;
		}
	}

	public string FormInquiryGoodWillEvaluationPhoneNumber
	{
		get
		{
			return formInquiryGoodWillEvaluationPhoneNumber;
		}
		set
		{
			formInquiryGoodWillEvaluationPhoneNumber = value;
		}
	}

	public string FormInquiryGoodWillEvaluationlRegisterInformationDate
	{
		get
		{
			return formInquiryGoodWillEvaluationlRegisterInformationDate;
		}
		set
		{
			formInquiryGoodWillEvaluationlRegisterInformationDate = value;
		}
	}

	public string FormInquiryGoodWillEvaluationDossierClasses
	{
		get
		{
			return formInquiryGoodWillEvaluationDossierClasses;
		}
		set
		{
			formInquiryGoodWillEvaluationDossierClasses = value;
		}
	}

	public string FormInquiryGoodWillEvaluationDeadDeathDate
	{
		get
		{
			return formInquiryGoodWillEvaluationDeadDeathDate;
		}
		set
		{
			formInquiryGoodWillEvaluationDeadDeathDate = value;
		}
	}

	public Int64? FormInquiryGoodWillEvaluationRegisterInformationID
	{
		get
		{
			return formInquiryGoodWillEvaluationRegisterInformationID;
		}
		set
		{
			formInquiryGoodWillEvaluationRegisterInformationID = value;
		}
	}

	public Int64 FormInquiryGoodWillEvaluationlDeclarationID
	{
		get
		{
			return formInquiryGoodWillEvaluationlDeclarationID;
		}
		set
		{
			formInquiryGoodWillEvaluationlDeclarationID = value;
		}
	}

	public Int64? FormInquiryGoodWillEvaluationRegisterarUserNationalCode
	{
		get
		{
			return formInquiryGoodWillEvaluationRegisterarUserNationalCode;
		}
		set
		{
			formInquiryGoodWillEvaluationRegisterarUserNationalCode = value;
		}
	}

	public Int64? FormInquiryGoodWillEvaluationFormInquiryResponseID
	{
		get
		{
			return formInquiryGoodWillEvaluationFormInquiryResponseID;
		}
		set
		{
			formInquiryGoodWillEvaluationFormInquiryResponseID = value;
		}
	}

	public string FormInquiryGoodWillEvaluationDeadFullName
	{
		get
		{
			return formInquiryGoodWillEvaluationDeadFullName;
		}
		set
		{
			formInquiryGoodWillEvaluationDeadFullName = value;
		}
	}

	public string FormInquiryGoodWillEvaluationInquiryTo
	{
		get
		{
			return formInquiryGoodWillEvaluationInquiryTo;
		}
		set
		{
			formInquiryGoodWillEvaluationInquiryTo = value;
		}
	}

	public string FormInquiryGoodWillEvaluationSixth
	{
		get
		{
			return formInquiryGoodWillEvaluationSixth;
		}
		set
		{
			formInquiryGoodWillEvaluationSixth = value;
		}
	}

	public string FormInquiryGoodWillEvaluationFromGoodwill
	{
		get
		{
			return formInquiryGoodWillEvaluationFromGoodwill;
		}
		set
		{
			formInquiryGoodWillEvaluationFromGoodwill = value;
		}
	}

	public string FormInquiryGoodWillEvaluationPlaque
	{
		get
		{
			return formInquiryGoodWillEvaluationPlaque;
		}
		set
		{
			formInquiryGoodWillEvaluationPlaque = value;
		}
	}

	public string FormInquiryGoodWillEvaluationSection
	{
		get
		{
			return formInquiryGoodWillEvaluationSection;
		}
		set
		{
			formInquiryGoodWillEvaluationSection = value;
		}
	}

}
}
