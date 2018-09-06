using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class RegisterTypesHandler
{
	// Handle to the RegisterTypes DBAccess class
	RegisterTypesDBAccess registerTypesDb = null;

	public RegisterTypesHandler()
	{
		registerTypesDb = new RegisterTypesDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of registerTypess, we can put some logic here if needed 
	public List<RegisterTypes> GetListAll()
	{
		return registerTypesDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of registerTypess, we can put some logic here if needed 
	public bool Update(RegisterTypes registerTypes)
	{
		return registerTypesDb.Update(registerTypes);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of registerTypess, we can put some logic here if needed 
	public RegisterTypes GetDetails(int registerTypeID)
	{
		return registerTypesDb.GetDetails(registerTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of registerTypess, we can put some logic here if needed 
	public bool Delete(int registerTypeID)
	{
		return registerTypesDb.Delete(registerTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of registerTypess, we can put some logic here if needed 
	public Int64 Insert(RegisterTypes registerTypes)
	{
		return registerTypesDb.Insert(registerTypes);
	}

	public bool Exists(RegisterTypes registerTypes)
	{
		return registerTypesDb.Exists(registerTypes);
	}

	public bool Exists(int registerTypeID)
	{
		return registerTypesDb.Exists(registerTypeID);
	}

	public List<RegisterInformation> GetListRegisterInformation(int registerTypeID)
	{
		return registerTypesDb.GetListRegisterInformation(registerTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of registerTypess, we can put some logic here if needed 
	public List<RegisterTypes> SearchLike(RegisterTypes registerTypes)
	{
		return registerTypesDb.SearchLike(registerTypes);
	}

}
}
