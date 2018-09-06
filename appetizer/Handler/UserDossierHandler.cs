using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class UserDossierHandler
{
	// Handle to the UserDossier DBAccess class
	UserDossierDBAccess userDossierDb = null;

	public UserDossierHandler()
	{
		userDossierDb = new UserDossierDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userDossiers, we can put some logic here if needed 
	public List<UserDossier> GetListAll()
	{
		return userDossierDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userDossiers, we can put some logic here if needed 
	public bool Update(UserDossier userDossier)
	{
		return userDossierDb.Update(userDossier);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userDossiers, we can put some logic here if needed 
	public UserDossier GetDetails(Int64 userNationalCode , Int64 dossierID)
	{
		return userDossierDb.GetDetails(userNationalCode , dossierID);
	}

	public UserDossier GetDetails(Int64 userNationalCode)
	{
		return userDossierDb.GetDetails(userNationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userDossiers, we can put some logic here if needed 
	public bool Delete(Int64 userNationalCode , Int64 dossierID)
	{
		return userDossierDb.Delete(userNationalCode , dossierID);
	}

	public bool Delete(Int64 userNationalCode)
	{
		return userDossierDb.Delete(userNationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userDossiers, we can put some logic here if needed 
	public Int64 Insert(UserDossier userDossier)
	{
		return userDossierDb.Insert(userDossier);
	}

	public bool Exists(UserDossier userDossier)
	{
		return userDossierDb.Exists(userDossier);
	}

	public bool Exists(Int64 userNationalCode , Int64 dossierID)
	{
		return userDossierDb.Exists(userNationalCode , dossierID);
	}

	public List<UserDossier> GetListByUserDossierUserNationalCode(Int64 userNationalCode)
	{
		return userDossierDb.GetListByUserDossierUserNationalCode(userNationalCode);
	}

	public List<UserDossier> GetListByUserDossierDossierID(Int64 dossierID)
	{
		return userDossierDb.GetListByUserDossierDossierID(dossierID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userDossiers, we can put some logic here if needed 
	public List<UserDossier> SearchLike(UserDossier userDossier)
	{
		return userDossierDb.SearchLike(userDossier);
	}

}
}
