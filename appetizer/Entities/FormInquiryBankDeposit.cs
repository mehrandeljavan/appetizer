using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormInquiryBankDeposit
{
	private Int64 formInquiryBankDepositID;
	private string formInquiryBankDepositPrintRegisterInformationID;
	private string formInquiryBankDepositPrintRegisterDate;
	private string formInquiryBankDepositRegisterInformationDate;
	private string formInquiryBankDepositDossierClasses;
	private string formInquiryBankDepositDeadDeathDate;
	private Int64? formInquiryBankDepositRegisterInformationID;
	private Int64 formInquiryBankDepositDeclarationID;
	private Int64? formInquiryBankDepositRegisterarUserNationalCode;
	private Int64? formInquiryBankDepositFormInquiryResponseID;
	private string formInquiryBankDepositBankTitle;
	private string formInquiryBankDepositRuleComment;
	private string formInquiryBankDepositUser1FullName;
	private string formInquiryBankDepositUser2FullName;
	private string formInquiryBankDepositUser1TaxUnitCode;
	private string formInquiryBankDepositUser2TaxGroupCode;
	private string formInquiryBankDepositComment;
	private string formInquiryBankDepositAccountNumber;
	private string formInquiryBankDepositDeadFullName;
	private string formInquiryBankDepositTaxUnitCode;

	public Int64 FormInquiryBankDepositID
	{
		get
		{
			return formInquiryBankDepositID;
		}
		set
		{
			formInquiryBankDepositID = value;
		}
	}

	public string FormInquiryBankDepositPrintRegisterInformationID
	{
		get
		{
			return formInquiryBankDepositPrintRegisterInformationID;
		}
		set
		{
			formInquiryBankDepositPrintRegisterInformationID = value;
		}
	}

	public string FormInquiryBankDepositPrintRegisterDate
	{
		get
		{
			return formInquiryBankDepositPrintRegisterDate;
		}
		set
		{
			formInquiryBankDepositPrintRegisterDate = value;
		}
	}

	public string FormInquiryBankDepositRegisterInformationDate
	{
		get
		{
			return formInquiryBankDepositRegisterInformationDate;
		}
		set
		{
			formInquiryBankDepositRegisterInformationDate = value;
		}
	}

	public string FormInquiryBankDepositDossierClasses
	{
		get
		{
			return formInquiryBankDepositDossierClasses;
		}
		set
		{
			formInquiryBankDepositDossierClasses = value;
		}
	}

	public string FormInquiryBankDepositDeadDeathDate
	{
		get
		{
			return formInquiryBankDepositDeadDeathDate;
		}
		set
		{
			formInquiryBankDepositDeadDeathDate = value;
		}
	}

	public Int64? FormInquiryBankDepositRegisterInformationID
	{
		get
		{
			return formInquiryBankDepositRegisterInformationID;
		}
		set
		{
			formInquiryBankDepositRegisterInformationID = value;
		}
	}

	public Int64 FormInquiryBankDepositDeclarationID
	{
		get
		{
			return formInquiryBankDepositDeclarationID;
		}
		set
		{
			formInquiryBankDepositDeclarationID = value;
		}
	}

	public Int64? FormInquiryBankDepositRegisterarUserNationalCode
	{
		get
		{
			return formInquiryBankDepositRegisterarUserNationalCode;
		}
		set
		{
			formInquiryBankDepositRegisterarUserNationalCode = value;
		}
	}

	public Int64? FormInquiryBankDepositFormInquiryResponseID
	{
		get
		{
			return formInquiryBankDepositFormInquiryResponseID;
		}
		set
		{
			formInquiryBankDepositFormInquiryResponseID = value;
		}
	}

	public string FormInquiryBankDepositBankTitle
	{
		get
		{
			return formInquiryBankDepositBankTitle;
		}
		set
		{
			formInquiryBankDepositBankTitle = value;
		}
	}

	public string FormInquiryBankDepositRuleComment
	{
		get
		{
			return formInquiryBankDepositRuleComment;
		}
		set
		{
			formInquiryBankDepositRuleComment = value;
		}
	}

	public string FormInquiryBankDepositUser1FullName
	{
		get
		{
			return formInquiryBankDepositUser1FullName;
		}
		set
		{
			formInquiryBankDepositUser1FullName = value;
		}
	}

	public string FormInquiryBankDepositUser2FullName
	{
		get
		{
			return formInquiryBankDepositUser2FullName;
		}
		set
		{
			formInquiryBankDepositUser2FullName = value;
		}
	}

	public string FormInquiryBankDepositUser1TaxUnitCode
	{
		get
		{
			return formInquiryBankDepositUser1TaxUnitCode;
		}
		set
		{
			formInquiryBankDepositUser1TaxUnitCode = value;
		}
	}

	public string FormInquiryBankDepositUser2TaxGroupCode
	{
		get
		{
			return formInquiryBankDepositUser2TaxGroupCode;
		}
		set
		{
			formInquiryBankDepositUser2TaxGroupCode = value;
		}
	}

	public string FormInquiryBankDepositComment
	{
		get
		{
			return formInquiryBankDepositComment;
		}
		set
		{
			formInquiryBankDepositComment = value;
		}
	}

	public string FormInquiryBankDepositAccountNumber
	{
		get
		{
			return formInquiryBankDepositAccountNumber;
		}
		set
		{
			formInquiryBankDepositAccountNumber = value;
		}
	}

	public string FormInquiryBankDepositDeadFullName
	{
		get
		{
			return formInquiryBankDepositDeadFullName;
		}
		set
		{
			formInquiryBankDepositDeadFullName = value;
		}
	}

	public string FormInquiryBankDepositTaxUnitCode
	{
		get
		{
			return formInquiryBankDepositTaxUnitCode;
		}
		set
		{
			formInquiryBankDepositTaxUnitCode = value;
		}
	}

}
}
