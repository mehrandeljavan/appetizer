using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class BoolFieldsTitleHandler
{
	// Handle to the BoolFieldsTitle DBAccess class
	BoolFieldsTitleDBAccess boolFieldsTitleDb = null;

	public BoolFieldsTitleHandler()
	{
		boolFieldsTitleDb = new BoolFieldsTitleDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of boolFieldsTitles, we can put some logic here if needed 
	public List<BoolFieldsTitle> GetListAll()
	{
		return boolFieldsTitleDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of boolFieldsTitles, we can put some logic here if needed 
	public bool Update(BoolFieldsTitle boolFieldsTitle)
	{
		return boolFieldsTitleDb.Update(boolFieldsTitle);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of boolFieldsTitles, we can put some logic here if needed 
	public BoolFieldsTitle GetDetails(int boolFieldsTitleID)
	{
		return boolFieldsTitleDb.GetDetails(boolFieldsTitleID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of boolFieldsTitles, we can put some logic here if needed 
	public bool Delete(int boolFieldsTitleID)
	{
		return boolFieldsTitleDb.Delete(boolFieldsTitleID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of boolFieldsTitles, we can put some logic here if needed 
	public Int64 Insert(BoolFieldsTitle boolFieldsTitle)
	{
		return boolFieldsTitleDb.Insert(boolFieldsTitle);
	}

	public bool Exists(BoolFieldsTitle boolFieldsTitle)
	{
		return boolFieldsTitleDb.Exists(boolFieldsTitle);
	}

	public bool Exists(int boolFieldsTitleID)
	{
		return boolFieldsTitleDb.Exists(boolFieldsTitleID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of boolFieldsTitles, we can put some logic here if needed 
	public List<BoolFieldsTitle> SearchLike(BoolFieldsTitle boolFieldsTitle)
	{
		return boolFieldsTitleDb.SearchLike(boolFieldsTitle);
	}

}
}
