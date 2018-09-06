using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class PropertiesNumberHandler
{
	// Handle to the PropertiesNumber DBAccess class
	PropertiesNumberDBAccess propertiesNumberDb = null;

	public PropertiesNumberHandler()
	{
		propertiesNumberDb = new PropertiesNumberDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of propertiesNumbers, we can put some logic here if needed 
	public List<PropertiesNumber> GetListAll()
	{
		return propertiesNumberDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of propertiesNumbers, we can put some logic here if needed 
	public bool Update(PropertiesNumber propertiesNumber)
	{
		return propertiesNumberDb.Update(propertiesNumber);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of propertiesNumbers, we can put some logic here if needed 
	public PropertiesNumber GetDetails(Int64 prpertiesNumberID)
	{
		return propertiesNumberDb.GetDetails(prpertiesNumberID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of propertiesNumbers, we can put some logic here if needed 
	public bool Delete(Int64 prpertiesNumberID)
	{
		return propertiesNumberDb.Delete(prpertiesNumberID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of propertiesNumbers, we can put some logic here if needed 
	public Int64 Insert(PropertiesNumber propertiesNumber)
	{
		return propertiesNumberDb.Insert(propertiesNumber);
	}

	public bool Exists(PropertiesNumber propertiesNumber)
	{
		return propertiesNumberDb.Exists(propertiesNumber);
	}

	public bool Exists(Int64 prpertiesNumberID)
	{
		return propertiesNumberDb.Exists(prpertiesNumberID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of propertiesNumbers, we can put some logic here if needed 
	public List<PropertiesNumber> SearchLike(PropertiesNumber propertiesNumber)
	{
		return propertiesNumberDb.SearchLike(propertiesNumber);
	}

}
}
