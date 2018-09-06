using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class UserTaxOfficeRolePartHandler
{
	// Handle to the UserTaxOfficeRolePart DBAccess class
	UserTaxOfficeRolePartDBAccess userTaxOfficeRolePartDb = null;

	public UserTaxOfficeRolePartHandler()
	{
		userTaxOfficeRolePartDb = new UserTaxOfficeRolePartDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userTaxOfficeRoleParts, we can put some logic here if needed 
	public List<UserTaxOfficeRolePart> GetListAll()
	{
		return userTaxOfficeRolePartDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userTaxOfficeRoleParts, we can put some logic here if needed 
	public bool Update(UserTaxOfficeRolePart userTaxOfficeRolePart)
	{
		return userTaxOfficeRolePartDb.Update(userTaxOfficeRolePart);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userTaxOfficeRoleParts, we can put some logic here if needed 
	public UserTaxOfficeRolePart GetDetails(Int64 userTaxOfficeRolePartID)
	{
		return userTaxOfficeRolePartDb.GetDetails(userTaxOfficeRolePartID);
	}

	public UserTaxOfficeRolePart GetDetails(Int64 userNationalCode , int taxOfficeCode , int rolePartID)
	{
		return userTaxOfficeRolePartDb.GetDetails(userNationalCode , taxOfficeCode , rolePartID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userTaxOfficeRoleParts, we can put some logic here if needed 
	public bool Delete(Int64 userTaxOfficeRolePartID)
	{
		return userTaxOfficeRolePartDb.Delete(userTaxOfficeRolePartID);
	}

	public bool Delete(Int64 userNationalCode , int taxOfficeCode , int rolePartID)
	{
		return userTaxOfficeRolePartDb.Delete(userNationalCode , taxOfficeCode , rolePartID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userTaxOfficeRoleParts, we can put some logic here if needed 
	public Int64 Insert(UserTaxOfficeRolePart userTaxOfficeRolePart)
	{
		return userTaxOfficeRolePartDb.Insert(userTaxOfficeRolePart);
	}

	public bool Exists(UserTaxOfficeRolePart userTaxOfficeRolePart)
	{
		return userTaxOfficeRolePartDb.Exists(userTaxOfficeRolePart);
	}

	public bool Exists(Int64 userTaxOfficeRolePartID)
	{
		return userTaxOfficeRolePartDb.Exists(userTaxOfficeRolePartID);
	}

	public List<UserTaxOfficeRolePart> GetListByUserTaxOfficeRolePartUserNationalCodeTaxOfficeCodeRolePartID(Int64 userNationalCode,int taxOfficeCode,int rolePartID)
	{
		return userTaxOfficeRolePartDb.GetListByUserTaxOfficeRolePartUserNationalCodeTaxOfficeCodeRolePartID(userNationalCode,taxOfficeCode,rolePartID);
	}

	public List<UserTaxOfficeRolePart> GetListByUserTaxOfficeRolePartUserNationalCodeTaxOfficeCode(Int64 userNationalCode,int taxOfficeCode)
	{
		return userTaxOfficeRolePartDb.GetListByUserTaxOfficeRolePartUserNationalCodeTaxOfficeCode(userNationalCode,taxOfficeCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userTaxOfficeRoleParts, we can put some logic here if needed 
	public List<UserTaxOfficeRolePart> SearchLike(UserTaxOfficeRolePart userTaxOfficeRolePart)
	{
		return userTaxOfficeRolePartDb.SearchLike(userTaxOfficeRolePart);
	}

}
}
