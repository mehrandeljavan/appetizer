using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class EducationStateHandler
{
	// Handle to the EducationState DBAccess class
	EducationStateDBAccess educationStateDb = null;

	public EducationStateHandler()
	{
		educationStateDb = new EducationStateDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of educationStates, we can put some logic here if needed 
	public List<EducationState> GetListAll()
	{
		return educationStateDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of educationStates, we can put some logic here if needed 
	public bool Update(EducationState educationState)
	{
		return educationStateDb.Update(educationState);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of educationStates, we can put some logic here if needed 
	public EducationState GetDetails(int educationStateID)
	{
		return educationStateDb.GetDetails(educationStateID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of educationStates, we can put some logic here if needed 
	public bool Delete(int educationStateID)
	{
		return educationStateDb.Delete(educationStateID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of educationStates, we can put some logic here if needed 
	public Int64 Insert(EducationState educationState)
	{
		return educationStateDb.Insert(educationState);
	}

	public bool Exists(EducationState educationState)
	{
		return educationStateDb.Exists(educationState);
	}

	public bool Exists(int educationStateID)
	{
		return educationStateDb.Exists(educationStateID);
	}

	public List<Heir> GetListHeir(int educationStateID)
	{
		return educationStateDb.GetListHeir(educationStateID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of educationStates, we can put some logic here if needed 
	public List<EducationState> SearchLike(EducationState educationState)
	{
		return educationStateDb.SearchLike(educationState);
	}

}
}
