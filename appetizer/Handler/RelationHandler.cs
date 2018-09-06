using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class RelationHandler
{
	// Handle to the Relation DBAccess class
	RelationDBAccess relationDb = null;

	public RelationHandler()
	{
		relationDb = new RelationDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of relations, we can put some logic here if needed 
	public List<Relation> GetListAll()
	{
		return relationDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of relations, we can put some logic here if needed 
	public bool Update(Relation relation)
	{
		return relationDb.Update(relation);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of relations, we can put some logic here if needed 
	public Relation GetDetails(int relationID)
	{
		return relationDb.GetDetails(relationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of relations, we can put some logic here if needed 
	public bool Delete(int relationID)
	{
		return relationDb.Delete(relationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of relations, we can put some logic here if needed 
	public Int64 Insert(Relation relation)
	{
		return relationDb.Insert(relation);
	}

	public bool Exists(Relation relation)
	{
		return relationDb.Exists(relation);
	}

	public bool Exists(int relationID)
	{
		return relationDb.Exists(relationID);
	}

	public List<Heir> GetListHeir(int relationID)
	{
		return relationDb.GetListHeir(relationID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of relations, we can put some logic here if needed 
	public List<Relation> SearchLike(Relation relation)
	{
		return relationDb.SearchLike(relation);
	}

}
}
