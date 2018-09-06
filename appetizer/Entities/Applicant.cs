using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Applicant : Person
{
	private Int64 applicantID;
	private string applicantRoleIDTitle;
	private string requestTypeIDTitle;
	private string registerDate;
	private string oldRegisterInformationID;
	private string oldRegisterDate;
	private Int64? declarationID;
	private Int64? registerInformationID;
	private int? applicantRoleID;
	private int? requestTypeID;

	public Int64 ApplicantID
	{
		get
		{
			return applicantID;
		}
		set
		{
			applicantID = value;
		}
	}

	public string ApplicantRoleIDTitle
	{
		get
		{
			return applicantRoleIDTitle;
		}
		set
		{
			applicantRoleIDTitle = value;
		}
	}

	public string RequestTypeIDTitle
	{
		get
		{
			return requestTypeIDTitle;
		}
		set
		{
			requestTypeIDTitle = value;
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

	public int? ApplicantRoleID
	{
		get
		{
			return applicantRoleID;
		}
		set
		{
			applicantRoleID = value;
		}
	}

	public int? RequestTypeID
	{
		get
		{
			return requestTypeID;
		}
		set
		{
			requestTypeID = value;
		}
	}

}
}
