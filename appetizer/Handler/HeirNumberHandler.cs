using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class HeirNumberHandler
{
	// Handle to the HeirNumber DBAccess class
	HeirNumberDBAccess heirNumberDb = null;

	public HeirNumberHandler()
	{
		heirNumberDb = new HeirNumberDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of heirNumbers, we can put some logic here if needed 
	public List<HeirNumber> GetListAll()
	{
		return heirNumberDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of heirNumbers, we can put some logic here if needed 
	public bool Update(HeirNumber heirNumber)
	{
		return heirNumberDb.Update(heirNumber);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of heirNumbers, we can put some logic here if needed 
	public HeirNumber GetDetails(Int64 heirNumberID)
	{
		return heirNumberDb.GetDetails(heirNumberID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of heirNumbers, we can put some logic here if needed 
	public bool Delete(Int64 heirNumberID)
	{
		return heirNumberDb.Delete(heirNumberID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of heirNumbers, we can put some logic here if needed 
	public Int64 Insert(HeirNumber heirNumber)
	{
		return heirNumberDb.Insert(heirNumber);
	}

	public bool Exists(HeirNumber heirNumber)
	{
		return heirNumberDb.Exists(heirNumber);
	}

	public bool Exists(Int64 heirNumberID)
	{
		return heirNumberDb.Exists(heirNumberID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of heirNumbers, we can put some logic here if needed 
	public List<HeirNumber> SearchLike(HeirNumber heirNumber)
	{
		return heirNumberDb.SearchLike(heirNumber);
	}

}
}
