using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class FormHeritagesDescriptions
{
	private Int64 formHeritagesDescriptionsID;
	private Int64? formHeritagesDescriptionsDeclarationID;
	private Int64? formHeritagesDescriptionsRegisterarUserNationalCode;
	private string formHeritagesDescriptionsDescription;

	public Int64 FormHeritagesDescriptionsID
	{
		get
		{
			return formHeritagesDescriptionsID;
		}
		set
		{
			formHeritagesDescriptionsID = value;
		}
	}

	public Int64? FormHeritagesDescriptionsDeclarationID
	{
		get
		{
			return formHeritagesDescriptionsDeclarationID;
		}
		set
		{
			formHeritagesDescriptionsDeclarationID = value;
		}
	}

	public Int64? FormHeritagesDescriptionsRegisterarUserNationalCode
	{
		get
		{
			return formHeritagesDescriptionsRegisterarUserNationalCode;
		}
		set
		{
			formHeritagesDescriptionsRegisterarUserNationalCode = value;
		}
	}

	public string FormHeritagesDescriptionsDescription
	{
		get
		{
			return formHeritagesDescriptionsDescription;
		}
		set
		{
			formHeritagesDescriptionsDescription = value;
		}
	}

}
}
