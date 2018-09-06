using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class DictionaryHandler
{
	// Handle to the Dictionary DBAccess class
	DictionaryDBAccess dictionaryDb = null;

	public DictionaryHandler()
	{
		dictionaryDb = new DictionaryDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dictionarys, we can put some logic here if needed 
	public List<Dictionary> GetListAll()
	{
		return dictionaryDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dictionarys, we can put some logic here if needed 
	public bool Update(Dictionary dictionary)
	{
		return dictionaryDb.Update(dictionary);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dictionarys, we can put some logic here if needed 
	public Dictionary GetDetails(string tableName , string columnName)
	{
		return dictionaryDb.GetDetails(tableName , columnName);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dictionarys, we can put some logic here if needed 
	public bool Delete(string tableName , string columnName)
	{
		return dictionaryDb.Delete(tableName , columnName);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dictionarys, we can put some logic here if needed 
	public Int64 Insert(Dictionary dictionary)
	{
		return dictionaryDb.Insert(dictionary);
	}

	public bool Exists(Dictionary dictionary)
	{
		return dictionaryDb.Exists(dictionary);
	}

	public bool Exists(string tableName , string columnName)
	{
		return dictionaryDb.Exists(tableName , columnName);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of dictionarys, we can put some logic here if needed 
	public List<Dictionary> SearchLike(Dictionary dictionary)
	{
		return dictionaryDb.SearchLike(dictionary);
	}

}
}
