using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class ApplicantRole
{
	private int applicantRoleID;
	private string title;
	private List<Applicant> applicantList;

	public int ApplicantRoleID
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
		ApplicantList = new ApplicantRoleDBAccess().GetListApplicant(this.ApplicantRoleID);
		return ApplicantList;
	}

	public bool AddApplicant(Applicant applicant)
	{
		applicant.ApplicantRoleID = this.ApplicantRoleID;
		ApplicantDBAccess applicantDBAccess = new ApplicantDBAccess();
		if (applicantDBAccess.Insert(applicant)>0)
			return (true);
		return (false);
	}

}
}
