using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class ApplicantRoleHandler
{
	// Handle to the ApplicantRole DBAccess class
	ApplicantRoleDBAccess applicantRoleDb = null;

	public ApplicantRoleHandler()
	{
		applicantRoleDb = new ApplicantRoleDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of applicantRoles, we can put some logic here if needed 
	public List<ApplicantRole> GetListAll()
	{
		return applicantRoleDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of applicantRoles, we can put some logic here if needed 
	public bool Update(ApplicantRole applicantRole)
	{
		return applicantRoleDb.Update(applicantRole);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of applicantRoles, we can put some logic here if needed 
	public ApplicantRole GetDetails(int applicantRoleID)
	{
		return applicantRoleDb.GetDetails(applicantRoleID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of applicantRoles, we can put some logic here if needed 
	public bool Delete(int applicantRoleID)
	{
		return applicantRoleDb.Delete(applicantRoleID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of applicantRoles, we can put some logic here if needed 
	public Int64 Insert(ApplicantRole applicantRole)
	{
		return applicantRoleDb.Insert(applicantRole);
	}

	public bool Exists(ApplicantRole applicantRole)
	{
		return applicantRoleDb.Exists(applicantRole);
	}

	public bool Exists(int applicantRoleID)
	{
		return applicantRoleDb.Exists(applicantRoleID);
	}

	public List<Applicant> GetListApplicant(int applicantRoleID)
	{
		return applicantRoleDb.GetListApplicant(applicantRoleID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of applicantRoles, we can put some logic here if needed 
	public List<ApplicantRole> SearchLike(ApplicantRole applicantRole)
	{
		return applicantRoleDb.SearchLike(applicantRole);
	}

}
}
