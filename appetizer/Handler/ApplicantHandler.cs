using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class ApplicantHandler
{
	// Handle to the Applicant DBAccess class
	ApplicantDBAccess applicantDb = null;

	public ApplicantHandler()
	{
		applicantDb = new ApplicantDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of applicants, we can put some logic here if needed 
	public List<Applicant> GetListAll()
	{
		return applicantDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of applicants, we can put some logic here if needed 
	public bool Update(Applicant applicant)
	{
		return applicantDb.Update(applicant);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of applicants, we can put some logic here if needed 
	public Applicant GetDetails(Int64 applicantID)
	{
		return applicantDb.GetDetails(applicantID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of applicants, we can put some logic here if needed 
	public bool Delete(Int64 applicantID)
	{
		return applicantDb.Delete(applicantID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of applicants, we can put some logic here if needed 
	public Int64 Insert(Applicant applicant)
	{
		return applicantDb.Insert(applicant);
	}

	public bool Exists(Applicant applicant)
	{
		return applicantDb.Exists(applicant);
	}

	public bool Exists(Int64 applicantID)
	{
		return applicantDb.Exists(applicantID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of applicants, we can put some logic here if needed 
	public List<Applicant> SearchLike(Applicant applicant)
	{
		return applicantDb.SearchLike(applicant);
	}

}
}
