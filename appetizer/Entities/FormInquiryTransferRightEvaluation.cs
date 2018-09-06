using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormInquiryTransferRightEvaluation
{
	private Int64 formInquiryTransferRightEvaluationID;
	private string formInquiryTransferRightEvaluationPrintRegisterInformationID;
	private string formInquiryTransferRightEvaluationPrintRegisterDate;
	private string formInquiryTransferRightEvaluationAddress;
	private string formInquiryTransferRightEvaluationUser1FullName;
	private string formInquiryTransferRightEvaluationUser2FullName;
	private string formInquiryTransferRightEvaluationUser1TaxUnitCode;
	private string formInquiryTransferRightEvaluationUser2TaxGroupCode;
	private string formInquiryTransferRightEvaluationPhoneNumber;
	private string formInquiryTransferRightEvaluationlRegisterInformationDate;
	private string formInquiryTransferRightEvaluationDossierClasses;
	private string formInquiryTransferRightEvaluationDeadDeathDate;
	private Int64? formInquiryTransferRightEvaluationRegisterInformationID;
	private Int64 formInquiryTransferRightEvaluationlDeclarationID;
	private Int64? formInquiryTransferRightEvaluationRegisterarUserNationalCode;
	private Int64? formInquiryTransferRightEvaluationFormInquiryResponseID;
	private string formInquiryTransferRightEvaluationDeadFullName;
	private string formInquiryTransferRightEvaluationInquiryTo;
	private string formInquiryTransferRightEvaluationSixth;
	private string formInquiryTransferRightEvaluationFromTransferRight;
	private string formInquiryTransferRightEvaluationPlaque;
	private string formInquiryTransferRightEvaluationSection;

	public Int64 FormInquiryTransferRightEvaluationID
	{
		get
		{
			return formInquiryTransferRightEvaluationID;
		}
		set
		{
			formInquiryTransferRightEvaluationID = value;
		}
	}

	public string FormInquiryTransferRightEvaluationPrintRegisterInformationID
	{
		get
		{
			return formInquiryTransferRightEvaluationPrintRegisterInformationID;
		}
		set
		{
			formInquiryTransferRightEvaluationPrintRegisterInformationID = value;
		}
	}

	public string FormInquiryTransferRightEvaluationPrintRegisterDate
	{
		get
		{
			return formInquiryTransferRightEvaluationPrintRegisterDate;
		}
		set
		{
			formInquiryTransferRightEvaluationPrintRegisterDate = value;
		}
	}

	public string FormInquiryTransferRightEvaluationAddress
	{
		get
		{
			return formInquiryTransferRightEvaluationAddress;
		}
		set
		{
			formInquiryTransferRightEvaluationAddress = value;
		}
	}

	public string FormInquiryTransferRightEvaluationUser1FullName
	{
		get
		{
			return formInquiryTransferRightEvaluationUser1FullName;
		}
		set
		{
			formInquiryTransferRightEvaluationUser1FullName = value;
		}
	}

	public string FormInquiryTransferRightEvaluationUser2FullName
	{
		get
		{
			return formInquiryTransferRightEvaluationUser2FullName;
		}
		set
		{
			formInquiryTransferRightEvaluationUser2FullName = value;
		}
	}

	public string FormInquiryTransferRightEvaluationUser1TaxUnitCode
	{
		get
		{
			return formInquiryTransferRightEvaluationUser1TaxUnitCode;
		}
		set
		{
			formInquiryTransferRightEvaluationUser1TaxUnitCode = value;
		}
	}

	public string FormInquiryTransferRightEvaluationUser2TaxGroupCode
	{
		get
		{
			return formInquiryTransferRightEvaluationUser2TaxGroupCode;
		}
		set
		{
			formInquiryTransferRightEvaluationUser2TaxGroupCode = value;
		}
	}

	public string FormInquiryTransferRightEvaluationPhoneNumber
	{
		get
		{
			return formInquiryTransferRightEvaluationPhoneNumber;
		}
		set
		{
			formInquiryTransferRightEvaluationPhoneNumber = value;
		}
	}

	public string FormInquiryTransferRightEvaluationlRegisterInformationDate
	{
		get
		{
			return formInquiryTransferRightEvaluationlRegisterInformationDate;
		}
		set
		{
			formInquiryTransferRightEvaluationlRegisterInformationDate = value;
		}
	}

	public string FormInquiryTransferRightEvaluationDossierClasses
	{
		get
		{
			return formInquiryTransferRightEvaluationDossierClasses;
		}
		set
		{
			formInquiryTransferRightEvaluationDossierClasses = value;
		}
	}

	public string FormInquiryTransferRightEvaluationDeadDeathDate
	{
		get
		{
			return formInquiryTransferRightEvaluationDeadDeathDate;
		}
		set
		{
			formInquiryTransferRightEvaluationDeadDeathDate = value;
		}
	}

	public Int64? FormInquiryTransferRightEvaluationRegisterInformationID
	{
		get
		{
			return formInquiryTransferRightEvaluationRegisterInformationID;
		}
		set
		{
			formInquiryTransferRightEvaluationRegisterInformationID = value;
		}
	}

	public Int64 FormInquiryTransferRightEvaluationlDeclarationID
	{
		get
		{
			return formInquiryTransferRightEvaluationlDeclarationID;
		}
		set
		{
			formInquiryTransferRightEvaluationlDeclarationID = value;
		}
	}

	public Int64? FormInquiryTransferRightEvaluationRegisterarUserNationalCode
	{
		get
		{
			return formInquiryTransferRightEvaluationRegisterarUserNationalCode;
		}
		set
		{
			formInquiryTransferRightEvaluationRegisterarUserNationalCode = value;
		}
	}

	public Int64? FormInquiryTransferRightEvaluationFormInquiryResponseID
	{
		get
		{
			return formInquiryTransferRightEvaluationFormInquiryResponseID;
		}
		set
		{
			formInquiryTransferRightEvaluationFormInquiryResponseID = value;
		}
	}

	public string FormInquiryTransferRightEvaluationDeadFullName
	{
		get
		{
			return formInquiryTransferRightEvaluationDeadFullName;
		}
		set
		{
			formInquiryTransferRightEvaluationDeadFullName = value;
		}
	}

	public string FormInquiryTransferRightEvaluationInquiryTo
	{
		get
		{
			return formInquiryTransferRightEvaluationInquiryTo;
		}
		set
		{
			formInquiryTransferRightEvaluationInquiryTo = value;
		}
	}

	public string FormInquiryTransferRightEvaluationSixth
	{
		get
		{
			return formInquiryTransferRightEvaluationSixth;
		}
		set
		{
			formInquiryTransferRightEvaluationSixth = value;
		}
	}

	public string FormInquiryTransferRightEvaluationFromTransferRight
	{
		get
		{
			return formInquiryTransferRightEvaluationFromTransferRight;
		}
		set
		{
			formInquiryTransferRightEvaluationFromTransferRight = value;
		}
	}

	public string FormInquiryTransferRightEvaluationPlaque
	{
		get
		{
			return formInquiryTransferRightEvaluationPlaque;
		}
		set
		{
			formInquiryTransferRightEvaluationPlaque = value;
		}
	}

	public string FormInquiryTransferRightEvaluationSection
	{
		get
		{
			return formInquiryTransferRightEvaluationSection;
		}
		set
		{
			formInquiryTransferRightEvaluationSection = value;
		}
	}

}
}
