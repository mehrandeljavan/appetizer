using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class ResidenceHandler
{
	// Handle to the Residence DBAccess class
	ResidenceDBAccess residenceDb = null;

	public ResidenceHandler()
	{
		residenceDb = new ResidenceDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of residences, we can put some logic here if needed 
	public List<Residence> GetListAll()
	{
		return residenceDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of residences, we can put some logic here if needed 
	public bool Update(Residence residence)
	{
		return residenceDb.Update(residence);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of residences, we can put some logic here if needed 
	public Residence GetDetails(int residenceID)
	{
		return residenceDb.GetDetails(residenceID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of residences, we can put some logic here if needed 
	public bool Delete(int residenceID)
	{
		return residenceDb.Delete(residenceID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of residences, we can put some logic here if needed 
	public Int64 Insert(Residence residence)
	{
		return residenceDb.Insert(residence);
	}

	public bool Exists(Residence residence)
	{
		return residenceDb.Exists(residence);
	}

	public bool Exists(int residenceID)
	{
		return residenceDb.Exists(residenceID);
	}

	public List<Dead> GetListDead(int residenceID)
	{
		return residenceDb.GetListDead(residenceID);
	}

	public List<Heir> GetListHeir(int residenceID)
	{
		return residenceDb.GetListHeir(residenceID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of residences, we can put some logic here if needed 
	public List<Residence> SearchLike(Residence residence)
	{
		return residenceDb.SearchLike(residence);
	}

}
}
