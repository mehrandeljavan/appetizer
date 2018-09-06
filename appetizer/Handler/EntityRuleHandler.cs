using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class EntityRuleHandler
{
	// Handle to the EntityRule DBAccess class
	EntityRuleDBAccess entityRuleDb = null;

	public EntityRuleHandler()
	{
		entityRuleDb = new EntityRuleDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of entityRules, we can put some logic here if needed 
	public List<EntityRule> GetListAll()
	{
		return entityRuleDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of entityRules, we can put some logic here if needed 
	public bool Update(EntityRule entityRule)
	{
		return entityRuleDb.Update(entityRule);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of entityRules, we can put some logic here if needed 
	public EntityRule GetDetails(Int64 entityRuleID)
	{
		return entityRuleDb.GetDetails(entityRuleID);
	}

	public EntityRule GetDetails(string entityName , string propertyName)
	{
		return entityRuleDb.GetDetails(entityName , propertyName);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of entityRules, we can put some logic here if needed 
	public bool Delete(Int64 entityRuleID)
	{
		return entityRuleDb.Delete(entityRuleID);
	}

	public bool Delete(string entityName , string propertyName)
	{
		return entityRuleDb.Delete(entityName , propertyName);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of entityRules, we can put some logic here if needed 
	public Int64 Insert(EntityRule entityRule)
	{
		return entityRuleDb.Insert(entityRule);
	}

	public bool Exists(EntityRule entityRule)
	{
		return entityRuleDb.Exists(entityRule);
	}

	public bool Exists(Int64 entityRuleID)
	{
		return entityRuleDb.Exists(entityRuleID);
	}

	public List<EntityRule> GetListByEntityRuleEntityNamePropertyName(string entityName,string propertyName)
	{
		return entityRuleDb.GetListByEntityRuleEntityNamePropertyName(entityName,propertyName);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of entityRules, we can put some logic here if needed 
	public List<EntityRule> SearchLike(EntityRule entityRule)
	{
		return entityRuleDb.SearchLike(entityRule);
	}

}
}
