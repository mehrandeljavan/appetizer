using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormHeritageList
{
	private Int64 formHeritageListID;
	private Int64 formHeritageListDeclarationID;
	private Int64? formHeritageListRegisterarUserNationalCode;
	private string formHeritageListIssuanceDate;
	private string formHeritageListDeathDate;
	private string formHeritageListRegisterInformationDate;
	private string formHeritageListType;
	private string formHeritageListDeadFullName;
	private string formHeritageListTaxOfficeTitle;
	private string formHeritageListDescriptions;
	private string formHeritageListDossierClasses;
	private int? formHeritageListItemCount;

	public Int64 FormHeritageListID
	{
		get
		{
			return formHeritageListID;
		}
		set
		{
			formHeritageListID = value;
		}
	}

	public Int64 FormHeritageListDeclarationID
	{
		get
		{
			return formHeritageListDeclarationID;
		}
		set
		{
			formHeritageListDeclarationID = value;
		}
	}

	public Int64? FormHeritageListRegisterarUserNationalCode
	{
		get
		{
			return formHeritageListRegisterarUserNationalCode;
		}
		set
		{
			formHeritageListRegisterarUserNationalCode = value;
		}
	}

	public string FormHeritageListIssuanceDate
	{
		get
		{
			return formHeritageListIssuanceDate;
		}
		set
		{
			formHeritageListIssuanceDate = value;
		}
	}

	public string FormHeritageListDeathDate
	{
		get
		{
			return formHeritageListDeathDate;
		}
		set
		{
			formHeritageListDeathDate = value;
		}
	}

	public string FormHeritageListRegisterInformationDate
	{
		get
		{
			return formHeritageListRegisterInformationDate;
		}
		set
		{
			formHeritageListRegisterInformationDate = value;
		}
	}

	public string FormHeritageListType
	{
		get
		{
			return formHeritageListType;
		}
		set
		{
			formHeritageListType = value;
		}
	}

	public string FormHeritageListDeadFullName
	{
		get
		{
			return formHeritageListDeadFullName;
		}
		set
		{
			formHeritageListDeadFullName = value;
		}
	}

	public string FormHeritageListTaxOfficeTitle
	{
		get
		{
			return formHeritageListTaxOfficeTitle;
		}
		set
		{
			formHeritageListTaxOfficeTitle = value;
		}
	}

	public string FormHeritageListDescriptions
	{
		get
		{
			return formHeritageListDescriptions;
		}
		set
		{
			formHeritageListDescriptions = value;
		}
	}

	public string FormHeritageListDossierClasses
	{
		get
		{
			return formHeritageListDossierClasses;
		}
		set
		{
			formHeritageListDossierClasses = value;
		}
	}

	public int? FormHeritageListItemCount
	{
		get
		{
			return formHeritageListItemCount;
		}
		set
		{
			formHeritageListItemCount = value;
		}
	}

}
}
