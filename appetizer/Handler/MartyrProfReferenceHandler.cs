using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class MartyrProfReferenceHandler
{
	// Handle to the MartyrProfReference DBAccess class
	MartyrProfReferenceDBAccess martyrProfReferenceDb = null;

	public MartyrProfReferenceHandler()
	{
		martyrProfReferenceDb = new MartyrProfReferenceDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of martyrProfReferences, we can put some logic here if needed 
	public List<MartyrProfReference> GetListAll()
	{
		return martyrProfReferenceDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of martyrProfReferences, we can put some logic here if needed 
	public bool Update(MartyrProfReference martyrProfReference)
	{
		return martyrProfReferenceDb.Update(martyrProfReference);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of martyrProfReferences, we can put some logic here if needed 
	public MartyrProfReference GetDetails(int martyrProfReferenceID)
	{
		return martyrProfReferenceDb.GetDetails(martyrProfReferenceID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of martyrProfReferences, we can put some logic here if needed 
	public bool Delete(int martyrProfReferenceID)
	{
		return martyrProfReferenceDb.Delete(martyrProfReferenceID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of martyrProfReferences, we can put some logic here if needed 
	public Int64 Insert(MartyrProfReference martyrProfReference)
	{
		return martyrProfReferenceDb.Insert(martyrProfReference);
	}

	public bool Exists(MartyrProfReference martyrProfReference)
	{
		return martyrProfReferenceDb.Exists(martyrProfReference);
	}

	public bool Exists(int martyrProfReferenceID)
	{
		return martyrProfReferenceDb.Exists(martyrProfReferenceID);
	}

	public List<Dead> GetListDead(int martyrProfReferenceID)
	{
		return martyrProfReferenceDb.GetListDead(martyrProfReferenceID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of martyrProfReferences, we can put some logic here if needed 
	public List<MartyrProfReference> SearchLike(MartyrProfReference martyrProfReference)
	{
		return martyrProfReferenceDb.SearchLike(martyrProfReference);
	}

}
}
