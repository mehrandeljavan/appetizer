using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class TreeHandler
{
	// Handle to the Tree DBAccess class
	TreeDBAccess treeDb = null;

	public TreeHandler()
	{
		treeDb = new TreeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of trees, we can put some logic here if needed 
	public List<Tree> GetListAll()
	{
		return treeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of trees, we can put some logic here if needed 
	public bool Update(Tree tree)
	{
		return treeDb.Update(tree);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of trees, we can put some logic here if needed 
	public Tree GetDetails(Int64 heritageID)
	{
		return treeDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of trees, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return treeDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of trees, we can put some logic here if needed 
	public Int64 Insert(Tree tree)
	{
		return treeDb.Insert(tree);
	}

	public bool Exists(Tree tree)
	{
		return treeDb.Exists(tree);
	}

	public bool Exists(Int64 heritageID)
	{
		return treeDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of trees, we can put some logic here if needed 
	public List<Tree> SearchLike(Tree tree)
	{
		return treeDb.SearchLike(tree);
	}

}
}
