using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Utterer : Person
{
	private Int64 uttererID;
	private string registerDate;
	private string uttererRoleIDTitle;
	private string oldRegisterDate;
	private string oldRegisterInformationID;
	private Int64? registerInformationID;
	private Int64? dossierID;
	private Int64? declarationID;
	private int? uttererRoleID;
	private int assertionOrder;
	private bool isApplicant;

	public Int64 UttererID
	{
		get
		{
			return uttererID;
		}
		set
		{
			uttererID = value;
		}
	}

	public string RegisterDate
	{
		get
		{
			return registerDate;
		}
		set
		{
			registerDate = value;
		}
	}

	public string UttererRoleIDTitle
	{
		get
		{
			return uttererRoleIDTitle;
		}
		set
		{
			uttererRoleIDTitle = value;
		}
	}

	public string OldRegisterDate
	{
		get
		{
			return oldRegisterDate;
		}
		set
		{
			oldRegisterDate = value;
		}
	}

	public string OldRegisterInformationID
	{
		get
		{
			return oldRegisterInformationID;
		}
		set
		{
			oldRegisterInformationID = value;
		}
	}

	public Int64? RegisterInformationID
	{
		get
		{
			return registerInformationID;
		}
		set
		{
			registerInformationID = value;
		}
	}

	public Int64? DossierID
	{
		get
		{
			return dossierID;
		}
		set
		{
			dossierID = value;
		}
	}

	public Int64? DeclarationID
	{
		get
		{
			return declarationID;
		}
		set
		{
			declarationID = value;
		}
	}

	public int? UttererRoleID
	{
		get
		{
			return uttererRoleID;
		}
		set
		{
			uttererRoleID = value;
		}
	}

	public int AssertionOrder
	{
		get
		{
			return assertionOrder;
		}
		set
		{
			assertionOrder = value;
		}
	}

	public bool IsApplicant
	{
		get
		{
			return isApplicant;
		}
		set
		{
			isApplicant = value;
		}
	}

}
}
