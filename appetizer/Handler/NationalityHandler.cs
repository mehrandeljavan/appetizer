using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class NationalityHandler
{
	// Handle to the Nationality DBAccess class
	NationalityDBAccess nationalityDb = null;

	public NationalityHandler()
	{
		nationalityDb = new NationalityDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of nationalitys, we can put some logic here if needed 
	public List<Nationality> GetListAll()
	{
		return nationalityDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of nationalitys, we can put some logic here if needed 
	public bool Update(Nationality nationality)
	{
		return nationalityDb.Update(nationality);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of nationalitys, we can put some logic here if needed 
	public Nationality GetDetails(int nationalityID)
	{
		return nationalityDb.GetDetails(nationalityID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of nationalitys, we can put some logic here if needed 
	public bool Delete(int nationalityID)
	{
		return nationalityDb.Delete(nationalityID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of nationalitys, we can put some logic here if needed 
	public Int64 Insert(Nationality nationality)
	{
		return nationalityDb.Insert(nationality);
	}

	public bool Exists(Nationality nationality)
	{
		return nationalityDb.Exists(nationality);
	}

	public bool Exists(int nationalityID)
	{
		return nationalityDb.Exists(nationalityID);
	}

	public List<Dead> GetListDead(int nationalityID)
	{
		return nationalityDb.GetListDead(nationalityID);
	}

	public List<Heir> GetListHeir(int nationalityID)
	{
		return nationalityDb.GetListHeir(nationalityID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of nationalitys, we can put some logic here if needed 
	public List<Nationality> SearchLike(Nationality nationality)
	{
		return nationalityDb.SearchLike(nationality);
	}

}
}
