using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormInquiryGoodWillScore
{
	private Int64 formInquiryGoodWillScorelID;
	private string formInquiryGoodWillScorePrintRegisterInformationID;
	private string formInquiryGoodWillScorePrintRegisterDate;
	private string formInquiryGoodWillScoreUser2TaxGroupCode;
	private string formInquiryGoodWillScoreDeadFullName;
	private string formInquiryGoodWillScoreComment;
	private string formInquiryGoodWillScoreTitle;
	private string formInquiryGoodWillScorePlaque;
	private string formInquiryGoodWillScorelSection;
	private string formInquiryGoodWillScorelRegisterInformationDate;
	private string formInquiryGoodWillScoreDossierClasses;
	private string formInquiryGoodWillScoreDeadDeathDate;
	private Int64? formInquiryGoodWillScoreRegisterInformationID;
	private Int64? formInquiryGoodWillScoreRegisterarUserNationalCode;
	private Int64 formInquiryGoodWillScoreDeclarationID;
	private Int64? formInquiryGoodWillScoreFormInquiryResponseID;
	private string formInquiryGoodWillScoreInquiryTo;
	private string formInquiryGoodWillScoreRuleComment;
	private string formInquiryGoodWillScoreTaxUnitCode;
	private string formInquiryGoodWillScoreUser1FullName;
	private string formInquiryGoodWillScoreUser2FullName;
	private string formInquiryGoodWillScoreUser1TaxUnitCode;
	private string formInquiryGoodWillScoreAddress;
	private string formInquiryGoodWillScoreSixth;

	public Int64 FormInquiryGoodWillScorelID
	{
		get
		{
			return formInquiryGoodWillScorelID;
		}
		set
		{
			formInquiryGoodWillScorelID = value;
		}
	}

	public string FormInquiryGoodWillScorePrintRegisterInformationID
	{
		get
		{
			return formInquiryGoodWillScorePrintRegisterInformationID;
		}
		set
		{
			formInquiryGoodWillScorePrintRegisterInformationID = value;
		}
	}

	public string FormInquiryGoodWillScorePrintRegisterDate
	{
		get
		{
			return formInquiryGoodWillScorePrintRegisterDate;
		}
		set
		{
			formInquiryGoodWillScorePrintRegisterDate = value;
		}
	}

	public string FormInquiryGoodWillScoreUser2TaxGroupCode
	{
		get
		{
			return formInquiryGoodWillScoreUser2TaxGroupCode;
		}
		set
		{
			formInquiryGoodWillScoreUser2TaxGroupCode = value;
		}
	}

	public string FormInquiryGoodWillScoreDeadFullName
	{
		get
		{
			return formInquiryGoodWillScoreDeadFullName;
		}
		set
		{
			formInquiryGoodWillScoreDeadFullName = value;
		}
	}

	public string FormInquiryGoodWillScoreComment
	{
		get
		{
			return formInquiryGoodWillScoreComment;
		}
		set
		{
			formInquiryGoodWillScoreComment = value;
		}
	}

	public string FormInquiryGoodWillScoreTitle
	{
		get
		{
			return formInquiryGoodWillScoreTitle;
		}
		set
		{
			formInquiryGoodWillScoreTitle = value;
		}
	}

	public string FormInquiryGoodWillScorePlaque
	{
		get
		{
			return formInquiryGoodWillScorePlaque;
		}
		set
		{
			formInquiryGoodWillScorePlaque = value;
		}
	}

	public string FormInquiryGoodWillScorelSection
	{
		get
		{
			return formInquiryGoodWillScorelSection;
		}
		set
		{
			formInquiryGoodWillScorelSection = value;
		}
	}

	public string FormInquiryGoodWillScorelRegisterInformationDate
	{
		get
		{
			return formInquiryGoodWillScorelRegisterInformationDate;
		}
		set
		{
			formInquiryGoodWillScorelRegisterInformationDate = value;
		}
	}

	public string FormInquiryGoodWillScoreDossierClasses
	{
		get
		{
			return formInquiryGoodWillScoreDossierClasses;
		}
		set
		{
			formInquiryGoodWillScoreDossierClasses = value;
		}
	}

	public string FormInquiryGoodWillScoreDeadDeathDate
	{
		get
		{
			return formInquiryGoodWillScoreDeadDeathDate;
		}
		set
		{
			formInquiryGoodWillScoreDeadDeathDate = value;
		}
	}

	public Int64? FormInquiryGoodWillScoreRegisterInformationID
	{
		get
		{
			return formInquiryGoodWillScoreRegisterInformationID;
		}
		set
		{
			formInquiryGoodWillScoreRegisterInformationID = value;
		}
	}

	public Int64? FormInquiryGoodWillScoreRegisterarUserNationalCode
	{
		get
		{
			return formInquiryGoodWillScoreRegisterarUserNationalCode;
		}
		set
		{
			formInquiryGoodWillScoreRegisterarUserNationalCode = value;
		}
	}

	public Int64 FormInquiryGoodWillScoreDeclarationID
	{
		get
		{
			return formInquiryGoodWillScoreDeclarationID;
		}
		set
		{
			formInquiryGoodWillScoreDeclarationID = value;
		}
	}

	public Int64? FormInquiryGoodWillScoreFormInquiryResponseID
	{
		get
		{
			return formInquiryGoodWillScoreFormInquiryResponseID;
		}
		set
		{
			formInquiryGoodWillScoreFormInquiryResponseID = value;
		}
	}

	public string FormInquiryGoodWillScoreInquiryTo
	{
		get
		{
			return formInquiryGoodWillScoreInquiryTo;
		}
		set
		{
			formInquiryGoodWillScoreInquiryTo = value;
		}
	}

	public string FormInquiryGoodWillScoreRuleComment
	{
		get
		{
			return formInquiryGoodWillScoreRuleComment;
		}
		set
		{
			formInquiryGoodWillScoreRuleComment = value;
		}
	}

	public string FormInquiryGoodWillScoreTaxUnitCode
	{
		get
		{
			return formInquiryGoodWillScoreTaxUnitCode;
		}
		set
		{
			formInquiryGoodWillScoreTaxUnitCode = value;
		}
	}

	public string FormInquiryGoodWillScoreUser1FullName
	{
		get
		{
			return formInquiryGoodWillScoreUser1FullName;
		}
		set
		{
			formInquiryGoodWillScoreUser1FullName = value;
		}
	}

	public string FormInquiryGoodWillScoreUser2FullName
	{
		get
		{
			return formInquiryGoodWillScoreUser2FullName;
		}
		set
		{
			formInquiryGoodWillScoreUser2FullName = value;
		}
	}

	public string FormInquiryGoodWillScoreUser1TaxUnitCode
	{
		get
		{
			return formInquiryGoodWillScoreUser1TaxUnitCode;
		}
		set
		{
			formInquiryGoodWillScoreUser1TaxUnitCode = value;
		}
	}

	public string FormInquiryGoodWillScoreAddress
	{
		get
		{
			return formInquiryGoodWillScoreAddress;
		}
		set
		{
			formInquiryGoodWillScoreAddress = value;
		}
	}

	public string FormInquiryGoodWillScoreSixth
	{
		get
		{
			return formInquiryGoodWillScoreSixth;
		}
		set
		{
			formInquiryGoodWillScoreSixth = value;
		}
	}

}
}
