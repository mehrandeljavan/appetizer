using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormTaxBill
{
	private Int64 formTaxBillID;
	private string formTaxBillPrintRegisterDate;
	private string formTaxBillPrintRegisterInformationID;
	private string formTaxBillDossierClasses;
	private string formTaxBillUser2Code;
	private string formTaxBillDescription;
	private string formTaxBillTaxTotalLetter;
	private string formTaxBillBillType;
	private string formTaxBillTaxTotalDescription;
	private float? formTaxBillTaxTypeA;
	private float? formTaxBillTaxTypeB;
	private float? formTaxBillTaxTotal;
	private float? formTaxBillTotalShare;
	private Int64? formTaxBillDeclarationID;
	private Int64 formTaxBillRegisterInformationID;
	private Int64? formTaxBillRegisterarUserNationalCode;
	private Int64? formTaxBillDeadNationalCode;
	private string formTaxBillDeadDeathDate;
	private string formTaxBillRegisterInformationDate;
	private string formTaxBillTaxOfficeTitle;
	private string formTaxBillDeadFullName;
	private string formTaxBillHeirsNumberSummury;
	private string formTaxBillUser2FullName;
	private string formTaxBillUser1FullName;
	private string formTaxBillUser1Code;
	private List<FormHeirWithShare> formHeirWithShareList;

	public Int64 FormTaxBillID
	{
		get
		{
			return formTaxBillID;
		}
		set
		{
			formTaxBillID = value;
		}
	}

	public string FormTaxBillPrintRegisterDate
	{
		get
		{
			return formTaxBillPrintRegisterDate;
		}
		set
		{
			formTaxBillPrintRegisterDate = value;
		}
	}

	public string FormTaxBillPrintRegisterInformationID
	{
		get
		{
			return formTaxBillPrintRegisterInformationID;
		}
		set
		{
			formTaxBillPrintRegisterInformationID = value;
		}
	}

	public string FormTaxBillDossierClasses
	{
		get
		{
			return formTaxBillDossierClasses;
		}
		set
		{
			formTaxBillDossierClasses = value;
		}
	}

	public string FormTaxBillUser2Code
	{
		get
		{
			return formTaxBillUser2Code;
		}
		set
		{
			formTaxBillUser2Code = value;
		}
	}

	public string FormTaxBillDescription
	{
		get
		{
			return formTaxBillDescription;
		}
		set
		{
			formTaxBillDescription = value;
		}
	}

	public string FormTaxBillTaxTotalLetter
	{
		get
		{
			return formTaxBillTaxTotalLetter;
		}
		set
		{
			formTaxBillTaxTotalLetter = value;
		}
	}

	public string FormTaxBillBillType
	{
		get
		{
			return formTaxBillBillType;
		}
		set
		{
			formTaxBillBillType = value;
		}
	}

	public string FormTaxBillTaxTotalDescription
	{
		get
		{
			return formTaxBillTaxTotalDescription;
		}
		set
		{
			formTaxBillTaxTotalDescription = value;
		}
	}

	public float? FormTaxBillTaxTypeA
	{
		get
		{
			return formTaxBillTaxTypeA;
		}
		set
		{
			formTaxBillTaxTypeA = value;
		}
	}

	public float? FormTaxBillTaxTypeB
	{
		get
		{
			return formTaxBillTaxTypeB;
		}
		set
		{
			formTaxBillTaxTypeB = value;
		}
	}

	public float? FormTaxBillTaxTotal
	{
		get
		{
			return formTaxBillTaxTotal;
		}
		set
		{
			formTaxBillTaxTotal = value;
		}
	}

	public float? FormTaxBillTotalShare
	{
		get
		{
			return formTaxBillTotalShare;
		}
		set
		{
			formTaxBillTotalShare = value;
		}
	}

	public Int64? FormTaxBillDeclarationID
	{
		get
		{
			return formTaxBillDeclarationID;
		}
		set
		{
			formTaxBillDeclarationID = value;
		}
	}

	public Int64 FormTaxBillRegisterInformationID
	{
		get
		{
			return formTaxBillRegisterInformationID;
		}
		set
		{
			formTaxBillRegisterInformationID = value;
		}
	}

	public Int64? FormTaxBillRegisterarUserNationalCode
	{
		get
		{
			return formTaxBillRegisterarUserNationalCode;
		}
		set
		{
			formTaxBillRegisterarUserNationalCode = value;
		}
	}

	public Int64? FormTaxBillDeadNationalCode
	{
		get
		{
			return formTaxBillDeadNationalCode;
		}
		set
		{
			formTaxBillDeadNationalCode = value;
		}
	}

	public string FormTaxBillDeadDeathDate
	{
		get
		{
			return formTaxBillDeadDeathDate;
		}
		set
		{
			formTaxBillDeadDeathDate = value;
		}
	}

	public string FormTaxBillRegisterInformationDate
	{
		get
		{
			return formTaxBillRegisterInformationDate;
		}
		set
		{
			formTaxBillRegisterInformationDate = value;
		}
	}

	public string FormTaxBillTaxOfficeTitle
	{
		get
		{
			return formTaxBillTaxOfficeTitle;
		}
		set
		{
			formTaxBillTaxOfficeTitle = value;
		}
	}

	public string FormTaxBillDeadFullName
	{
		get
		{
			return formTaxBillDeadFullName;
		}
		set
		{
			formTaxBillDeadFullName = value;
		}
	}

	public string FormTaxBillHeirsNumberSummury
	{
		get
		{
			return formTaxBillHeirsNumberSummury;
		}
		set
		{
			formTaxBillHeirsNumberSummury = value;
		}
	}

	public string FormTaxBillUser2FullName
	{
		get
		{
			return formTaxBillUser2FullName;
		}
		set
		{
			formTaxBillUser2FullName = value;
		}
	}

	public string FormTaxBillUser1FullName
	{
		get
		{
			return formTaxBillUser1FullName;
		}
		set
		{
			formTaxBillUser1FullName = value;
		}
	}

	public string FormTaxBillUser1Code
	{
		get
		{
			return formTaxBillUser1Code;
		}
		set
		{
			formTaxBillUser1Code = value;
		}
	}

	public List<FormHeirWithShare> FormHeirWithShareList
	{
		get
		{
			return formHeirWithShareList;
		}
		set
		{
			formHeirWithShareList = value;
		}
	}

	public List<FormHeirWithShare> GetListFormHeirWithShare()
	{
		FormHeirWithShareList = new FormTaxBillDBAccess().GetListFormHeirWithShare(this.FormTaxBillID);
		return FormHeirWithShareList;
	}

	public bool AddFormHeirWithShare(FormHeirWithShare formHeirWithShare)
	{
		formHeirWithShare.FormHeirWithShareFormBillTaxID = this.FormTaxBillID;
		FormHeirWithShareDBAccess formHeirWithShareDBAccess = new FormHeirWithShareDBAccess();
		if (formHeirWithShareDBAccess.Insert(formHeirWithShare)>0)
			return (true);
		return (false);
	}

}
}
