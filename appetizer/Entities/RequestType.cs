using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class RequestType
{
	private int requestTypeID;
	private int? codeForRegisterInformation;
	private int? orderNumber;
	private bool? newLaw;
	private string title;
	private List<Applicant> applicantList;

	public int RequestTypeID
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

	public int? CodeForRegisterInformation
	{
		get
		{
			return codeForRegisterInformation;
		}
		set
		{
			codeForRegisterInformation = value;
		}
	}

	public int? OrderNumber
	{
		get
		{
			return orderNumber;
		}
		set
		{
			orderNumber = value;
		}
	}

	public bool? NewLaw
	{
		get
		{
			return newLaw;
		}
		set
		{
			newLaw = value;
		}
	}

	public string Title
	{
		get
		{
			return title;
		}
		set
		{
			title = value;
		}
	}

	public List<Applicant> ApplicantList
	{
		get
		{
			return applicantList;
		}
		set
		{
			applicantList = value;
		}
	}

	public List<Applicant> GetListApplicant()
	{
		ApplicantList = new RequestTypeDBAccess().GetListApplicant(this.RequestTypeID);
		return ApplicantList;
	}

	public bool AddApplicant(Applicant applicant)
	{
		applicant.RequestTypeID = this.RequestTypeID;
		ApplicantDBAccess applicantDBAccess = new ApplicantDBAccess();
		if (applicantDBAccess.Insert(applicant)>0)
			return (true);
		return (false);
	}

}
}
