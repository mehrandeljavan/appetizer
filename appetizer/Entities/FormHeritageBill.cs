using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormHeritageBill
{
	private Int64 formHeritageBillID;
	private string formHeritageBillPrintRegisterInformationID;
	private string formHeritageBillPrintRegisterDate;
	private string formHeritageBillTaxTotalLetter;
	private string formHeritageBillUser1Code;
	private string formHeritageBillUser2Code;
	private string formHeritageBillTaxOfficeTitle;
	private string formHeritageBillDeadFullName;
	private string formHeritageBillDescriptions;
	private string formHeritageBillHeritageBill;
	private Int64? formHeritageBillRegisterInformationID;
	private Int64 formHeritageBillDeclarationID;
	private Int64? formHeritageBillRegisterarUserNationalCode;
	private Int64? formHeritageBillDeadNationalCode;
	private string formHeritageBillDeadDeathDate;
	private string formHeritageBillDossierClasses;
	private string formHeritageBillRegisterInformationDate;
	private string formHeritageBillHeirsNumberSummury;
	private string formHeritageBillHeirSharesSummury;
	private string formHeritageBillTaxDescription;
	private string formHeritageBillBillType;
	private string formHeritageBillUser2FullName;
	private string formHeritageBillUser1FullName;
	private float? formHeritageBillENZ;
	private float? formHeritageBillANZ;
	private float? formHeritageBillMNZ;
	private float? formHeritageBillDMNZ;
	private float? formHeritageBillDENZ;
	private float? formHeritageBillDANZ;
	private float? formHeritageBillTotalValue;
	private float? formHeritageBillTaxTotal;
	private float? formHeritageBillDEKHZ;
	private float? formHeritageBillDAKHZ;
	private float? formHeritageBillDMKHZ;
	private float? formHeritageBillE2KHZ;
	private float? formHeritageBillA2KHZ;
	private float? formHeritageBillM2KHZ;
	private float? formHeritageBillE2NZ;
	private float? formHeritageBillA2NZ;
	private float? formHeritageBillM2NZ;
	private float? formHeritageBillEKHZ;
	private float? formHeritageBillAKHZ;
	private float? formHeritageBillMKHZ;

	public Int64 FormHeritageBillID
	{
		get
		{
			return formHeritageBillID;
		}
		set
		{
			formHeritageBillID = value;
		}
	}

	public string FormHeritageBillPrintRegisterInformationID
	{
		get
		{
			return formHeritageBillPrintRegisterInformationID;
		}
		set
		{
			formHeritageBillPrintRegisterInformationID = value;
		}
	}

	public string FormHeritageBillPrintRegisterDate
	{
		get
		{
			return formHeritageBillPrintRegisterDate;
		}
		set
		{
			formHeritageBillPrintRegisterDate = value;
		}
	}

	public string FormHeritageBillTaxTotalLetter
	{
		get
		{
			return formHeritageBillTaxTotalLetter;
		}
		set
		{
			formHeritageBillTaxTotalLetter = value;
		}
	}

	public string FormHeritageBillUser1Code
	{
		get
		{
			return formHeritageBillUser1Code;
		}
		set
		{
			formHeritageBillUser1Code = value;
		}
	}

	public string FormHeritageBillUser2Code
	{
		get
		{
			return formHeritageBillUser2Code;
		}
		set
		{
			formHeritageBillUser2Code = value;
		}
	}

	public string FormHeritageBillTaxOfficeTitle
	{
		get
		{
			return formHeritageBillTaxOfficeTitle;
		}
		set
		{
			formHeritageBillTaxOfficeTitle = value;
		}
	}

	public string FormHeritageBillDeadFullName
	{
		get
		{
			return formHeritageBillDeadFullName;
		}
		set
		{
			formHeritageBillDeadFullName = value;
		}
	}

	public string FormHeritageBillDescriptions
	{
		get
		{
			return formHeritageBillDescriptions;
		}
		set
		{
			formHeritageBillDescriptions = value;
		}
	}

	public string FormHeritageBillHeritageBill
	{
		get
		{
			return formHeritageBillHeritageBill;
		}
		set
		{
			formHeritageBillHeritageBill = value;
		}
	}

	public Int64? FormHeritageBillRegisterInformationID
	{
		get
		{
			return formHeritageBillRegisterInformationID;
		}
		set
		{
			formHeritageBillRegisterInformationID = value;
		}
	}

	public Int64 FormHeritageBillDeclarationID
	{
		get
		{
			return formHeritageBillDeclarationID;
		}
		set
		{
			formHeritageBillDeclarationID = value;
		}
	}

	public Int64? FormHeritageBillRegisterarUserNationalCode
	{
		get
		{
			return formHeritageBillRegisterarUserNationalCode;
		}
		set
		{
			formHeritageBillRegisterarUserNationalCode = value;
		}
	}

	public Int64? FormHeritageBillDeadNationalCode
	{
		get
		{
			return formHeritageBillDeadNationalCode;
		}
		set
		{
			formHeritageBillDeadNationalCode = value;
		}
	}

	public string FormHeritageBillDeadDeathDate
	{
		get
		{
			return formHeritageBillDeadDeathDate;
		}
		set
		{
			formHeritageBillDeadDeathDate = value;
		}
	}

	public string FormHeritageBillDossierClasses
	{
		get
		{
			return formHeritageBillDossierClasses;
		}
		set
		{
			formHeritageBillDossierClasses = value;
		}
	}

	public string FormHeritageBillRegisterInformationDate
	{
		get
		{
			return formHeritageBillRegisterInformationDate;
		}
		set
		{
			formHeritageBillRegisterInformationDate = value;
		}
	}

	public string FormHeritageBillHeirsNumberSummury
	{
		get
		{
			return formHeritageBillHeirsNumberSummury;
		}
		set
		{
			formHeritageBillHeirsNumberSummury = value;
		}
	}

	public string FormHeritageBillHeirSharesSummury
	{
		get
		{
			return formHeritageBillHeirSharesSummury;
		}
		set
		{
			formHeritageBillHeirSharesSummury = value;
		}
	}

	public string FormHeritageBillTaxDescription
	{
		get
		{
			return formHeritageBillTaxDescription;
		}
		set
		{
			formHeritageBillTaxDescription = value;
		}
	}

	public string FormHeritageBillBillType
	{
		get
		{
			return formHeritageBillBillType;
		}
		set
		{
			formHeritageBillBillType = value;
		}
	}

	public string FormHeritageBillUser2FullName
	{
		get
		{
			return formHeritageBillUser2FullName;
		}
		set
		{
			formHeritageBillUser2FullName = value;
		}
	}

	public string FormHeritageBillUser1FullName
	{
		get
		{
			return formHeritageBillUser1FullName;
		}
		set
		{
			formHeritageBillUser1FullName = value;
		}
	}

	public float? FormHeritageBillENZ
	{
		get
		{
			return formHeritageBillENZ;
		}
		set
		{
			formHeritageBillENZ = value;
		}
	}

	public float? FormHeritageBillANZ
	{
		get
		{
			return formHeritageBillANZ;
		}
		set
		{
			formHeritageBillANZ = value;
		}
	}

	public float? FormHeritageBillMNZ
	{
		get
		{
			return formHeritageBillMNZ;
		}
		set
		{
			formHeritageBillMNZ = value;
		}
	}

	public float? FormHeritageBillDMNZ
	{
		get
		{
			return formHeritageBillDMNZ;
		}
		set
		{
			formHeritageBillDMNZ = value;
		}
	}

	public float? FormHeritageBillDENZ
	{
		get
		{
			return formHeritageBillDENZ;
		}
		set
		{
			formHeritageBillDENZ = value;
		}
	}

	public float? FormHeritageBillDANZ
	{
		get
		{
			return formHeritageBillDANZ;
		}
		set
		{
			formHeritageBillDANZ = value;
		}
	}

	public float? FormHeritageBillTotalValue
	{
		get
		{
			return formHeritageBillTotalValue;
		}
		set
		{
			formHeritageBillTotalValue = value;
		}
	}

	public float? FormHeritageBillTaxTotal
	{
		get
		{
			return formHeritageBillTaxTotal;
		}
		set
		{
			formHeritageBillTaxTotal = value;
		}
	}

	public float? FormHeritageBillDEKHZ
	{
		get
		{
			return formHeritageBillDEKHZ;
		}
		set
		{
			formHeritageBillDEKHZ = value;
		}
	}

	public float? FormHeritageBillDAKHZ
	{
		get
		{
			return formHeritageBillDAKHZ;
		}
		set
		{
			formHeritageBillDAKHZ = value;
		}
	}

	public float? FormHeritageBillDMKHZ
	{
		get
		{
			return formHeritageBillDMKHZ;
		}
		set
		{
			formHeritageBillDMKHZ = value;
		}
	}

	public float? FormHeritageBillE2KHZ
	{
		get
		{
			return formHeritageBillE2KHZ;
		}
		set
		{
			formHeritageBillE2KHZ = value;
		}
	}

	public float? FormHeritageBillA2KHZ
	{
		get
		{
			return formHeritageBillA2KHZ;
		}
		set
		{
			formHeritageBillA2KHZ = value;
		}
	}

	public float? FormHeritageBillM2KHZ
	{
		get
		{
			return formHeritageBillM2KHZ;
		}
		set
		{
			formHeritageBillM2KHZ = value;
		}
	}

	public float? FormHeritageBillE2NZ
	{
		get
		{
			return formHeritageBillE2NZ;
		}
		set
		{
			formHeritageBillE2NZ = value;
		}
	}

	public float? FormHeritageBillA2NZ
	{
		get
		{
			return formHeritageBillA2NZ;
		}
		set
		{
			formHeritageBillA2NZ = value;
		}
	}

	public float? FormHeritageBillM2NZ
	{
		get
		{
			return formHeritageBillM2NZ;
		}
		set
		{
			formHeritageBillM2NZ = value;
		}
	}

	public float? FormHeritageBillEKHZ
	{
		get
		{
			return formHeritageBillEKHZ;
		}
		set
		{
			formHeritageBillEKHZ = value;
		}
	}

	public float? FormHeritageBillAKHZ
	{
		get
		{
			return formHeritageBillAKHZ;
		}
		set
		{
			formHeritageBillAKHZ = value;
		}
	}

	public float? FormHeritageBillMKHZ
	{
		get
		{
			return formHeritageBillMKHZ;
		}
		set
		{
			formHeritageBillMKHZ = value;
		}
	}

}
}
