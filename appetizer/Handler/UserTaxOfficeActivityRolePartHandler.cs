using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class UserTaxOfficeActivityRolePartHandler
{
	// Handle to the UserTaxOfficeActivityRolePart DBAccess class
	UserTaxOfficeActivityRolePartDBAccess userTaxOfficeActivityRolePartDb = null;

	public UserTaxOfficeActivityRolePartHandler()
	{
		userTaxOfficeActivityRolePartDb = new UserTaxOfficeActivityRolePartDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userTaxOfficeActivityRoleParts, we can put some logic here if needed 
	public List<UserTaxOfficeActivityRolePart> GetListAll()
	{
		return userTaxOfficeActivityRolePartDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userTaxOfficeActivityRoleParts, we can put some logic here if needed 
	public bool Update(UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart)
	{
		return userTaxOfficeActivityRolePartDb.Update(userTaxOfficeActivityRolePart);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userTaxOfficeActivityRoleParts, we can put some logic here if needed 
	public UserTaxOfficeActivityRolePart GetDetails(int taxOfficeCode , int activityID , int rolePartID , Int64 userNationalCode)
	{
		return userTaxOfficeActivityRolePartDb.GetDetails(taxOfficeCode , activityID , rolePartID , userNationalCode);
	}

	public UserTaxOfficeActivityRolePart GetDetails(Int64 userNationalCode , int taxOfficeCode)
	{
		return userTaxOfficeActivityRolePartDb.GetDetails(userNationalCode , taxOfficeCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userTaxOfficeActivityRoleParts, we can put some logic here if needed 
	public bool Delete(int taxOfficeCode , int activityID , int rolePartID , Int64 userNationalCode)
	{
		return userTaxOfficeActivityRolePartDb.Delete(taxOfficeCode , activityID , rolePartID , userNationalCode);
	}

	public bool Delete(Int64 userNationalCode , int taxOfficeCode)
	{
		return userTaxOfficeActivityRolePartDb.Delete(userNationalCode , taxOfficeCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userTaxOfficeActivityRoleParts, we can put some logic here if needed 
	public Int64 Insert(UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart)
	{
		return userTaxOfficeActivityRolePartDb.Insert(userTaxOfficeActivityRolePart);
	}

	public bool Exists(UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart)
	{
		return userTaxOfficeActivityRolePartDb.Exists(userTaxOfficeActivityRolePart);
	}

	public bool Exists(int taxOfficeCode , int activityID , int rolePartID , Int64 userNationalCode)
	{
		return userTaxOfficeActivityRolePartDb.Exists(taxOfficeCode , activityID , rolePartID , userNationalCode);
	}

	public List<UserTaxOfficeActivityRolePart> GetListByUserTaxOfficeActivityRolePartUserNationalCodeTaxOfficeCode(Int64 userNationalCode,int taxOfficeCode)
	{
		return userTaxOfficeActivityRolePartDb.GetListByUserTaxOfficeActivityRolePartUserNationalCodeTaxOfficeCode(userNationalCode,taxOfficeCode);
	}

	public List<UserTaxOfficeActivityRolePart> GetListByUserTaxOfficeActivityRolePartUserNationalCodeTaxOfficeCodeRolePartID(Int64 userNationalCode,int taxOfficeCode,int rolePartID)
	{
		return userTaxOfficeActivityRolePartDb.GetListByUserTaxOfficeActivityRolePartUserNationalCodeTaxOfficeCodeRolePartID(userNationalCode,taxOfficeCode,rolePartID);
	}

	public List<UserTaxOfficeActivityRolePart> GetListByUserTaxOfficeActivityRolePartUserNationalCodeTaxOfficeCodeActivityIDRolePartID(Int64 userNationalCode,int taxOfficeCode,int activityID,int rolePartID)
	{
		return userTaxOfficeActivityRolePartDb.GetListByUserTaxOfficeActivityRolePartUserNationalCodeTaxOfficeCodeActivityIDRolePartID(userNationalCode,taxOfficeCode,activityID,rolePartID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userTaxOfficeActivityRoleParts, we can put some logic here if needed 
	public List<UserTaxOfficeActivityRolePart> SearchLike(UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart)
	{
		return userTaxOfficeActivityRolePartDb.SearchLike(userTaxOfficeActivityRolePart);
	}

}
}
