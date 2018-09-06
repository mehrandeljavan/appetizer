using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class EntityRuleDBAccess
{


	public Int64 Insert(EntityRule entityRule)
	{
		SqlParameter[] parametersEntityRule = new SqlParameter[]
		{
			new SqlParameter("@ValidationType", entityRule.ValidationType),
			new SqlParameter("@EntityName", entityRule.EntityName),
			new SqlParameter("@PropertyName", entityRule.PropertyName),
			new SqlParameter("@ValueType", entityRule.ValueType),
			new SqlParameter("@ErrorMessage", entityRule.ErrorMessage),
			new SqlParameter("@FilterdBy", (entityRule.FilterdBy != null) ? entityRule.FilterdBy : (object)DBNull.Value),
			new SqlParameter("@Filters", (entityRule.Filters != null) ? entityRule.Filters : (object)DBNull.Value),
			new SqlParameter("@EmptyText", (entityRule.EmptyText != null) ? entityRule.EmptyText : (object)DBNull.Value),
			new SqlParameter("@DefaultValue", (entityRule.DefaultValue != null) ? entityRule.DefaultValue : (object)DBNull.Value),
			new SqlParameter("@FieldOrder", entityRule.FieldOrder),
			new SqlParameter("@GridOrder", entityRule.GridOrder),
			new SqlParameter("@PropertyGroup", entityRule.PropertyGroup),
			new SqlParameter("@PropertyVisible", entityRule.PropertyVisible),
			new SqlParameter("@GridVisible", entityRule.GridVisible),
			new SqlParameter("@IsRequiered", entityRule.IsRequiered),
			new SqlParameter("@ReadOnly", entityRule.ReadOnly),
			new SqlParameter("@HasLookup", entityRule.HasLookup)
		};
		entityRule.EntityRuleID = SqlDBHelper.ExecuteScalar("EntityRule_Insert", CommandType.StoredProcedure, parametersEntityRule);
		return entityRule.EntityRuleID;
	}

	public bool Update(EntityRule entityRule)
	{
		SqlParameter[] parametersEntityRule = new SqlParameter[]
		{
			new SqlParameter("@EntityRuleID", entityRule.EntityRuleID),
			new SqlParameter("@ValidationType", entityRule.ValidationType),
			new SqlParameter("@EntityName", entityRule.EntityName),
			new SqlParameter("@PropertyName", entityRule.PropertyName),
			new SqlParameter("@ValueType", entityRule.ValueType),
			new SqlParameter("@ErrorMessage", entityRule.ErrorMessage),
			new SqlParameter("@FilterdBy", (entityRule.FilterdBy != null) ? entityRule.FilterdBy : (object)DBNull.Value),
			new SqlParameter("@Filters", (entityRule.Filters != null) ? entityRule.Filters : (object)DBNull.Value),
			new SqlParameter("@EmptyText", (entityRule.EmptyText != null) ? entityRule.EmptyText : (object)DBNull.Value),
			new SqlParameter("@DefaultValue", (entityRule.DefaultValue != null) ? entityRule.DefaultValue : (object)DBNull.Value),
			new SqlParameter("@FieldOrder", entityRule.FieldOrder),
			new SqlParameter("@GridOrder", entityRule.GridOrder),
			new SqlParameter("@PropertyGroup", entityRule.PropertyGroup),
			new SqlParameter("@PropertyVisible", entityRule.PropertyVisible),
			new SqlParameter("@GridVisible", entityRule.GridVisible),
			new SqlParameter("@IsRequiered", entityRule.IsRequiered),
			new SqlParameter("@ReadOnly", entityRule.ReadOnly),
			new SqlParameter("@HasLookup", entityRule.HasLookup)
		};
		return SqlDBHelper.ExecuteNonQuery("EntityRule_Update", CommandType.StoredProcedure, parametersEntityRule);
	}

	public bool Delete(Int64 entityRuleID)
	{
		SqlParameter[] parametersEntityRule = new SqlParameter[]
		{
			new SqlParameter("@EntityRuleID", entityRuleID)
		};
		return SqlDBHelper.ExecuteNonQuery("EntityRule_Delete", CommandType.StoredProcedure, parametersEntityRule);
	}

	public bool Delete(string entityName , string propertyName)
	{
		SqlParameter[] parametersEntityRule = new SqlParameter[]
		{
			new SqlParameter("@EntityName", entityName),
			new SqlParameter("@PropertyName", propertyName)
		};
		return SqlDBHelper.ExecuteNonQuery("EntityRule_DeleteBy_EntityNamePropertyName", CommandType.StoredProcedure, parametersEntityRule);

	}

	public EntityRule GetDetails(Int64 entityRuleID)
	{
		EntityRule entityRule = new EntityRule();

		SqlParameter[] parametersEntityRule = new SqlParameter[]
		{
			new SqlParameter("@EntityRuleID", entityRuleID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("EntityRule_GetDetails", CommandType.StoredProcedure, parametersEntityRule))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				entityRule.EntityRuleID = (row["EntityRuleID"] != DBNull.Value) ? Convert.ToInt64(row["EntityRuleID"]) : 0 ;
				entityRule.ValidationType = row["ValidationType"].ToString();
				entityRule.EntityName = row["EntityName"].ToString();
				entityRule.PropertyName = row["PropertyName"].ToString();
				entityRule.ValueType = row["ValueType"].ToString();
				entityRule.ErrorMessage = row["ErrorMessage"].ToString();
				entityRule.FilterdBy = row["FilterdBy"].ToString();
				entityRule.Filters = row["Filters"].ToString();
				entityRule.EmptyText = row["EmptyText"].ToString();
				entityRule.DefaultValue = row["DefaultValue"].ToString();
				entityRule.FieldOrder = (row["FieldOrder"] != DBNull.Value) ? Convert.ToInt32(row["FieldOrder"]) : 0 ;
				entityRule.GridOrder = (row["GridOrder"] != DBNull.Value) ? Convert.ToInt32(row["GridOrder"]) : 0 ;
				entityRule.PropertyGroup = (row["PropertyGroup"] != DBNull.Value) ? Convert.ToInt32(row["PropertyGroup"]) : 0 ;
				entityRule.PropertyVisible = (row["PropertyVisible"] != DBNull.Value) ? Convert.ToBoolean((row["PropertyVisible"].ToString() == "1" || row["PropertyVisible"].ToString().ToLower() == "true" ) ? true : false) : false ;
				entityRule.GridVisible = (row["GridVisible"] != DBNull.Value) ? Convert.ToBoolean((row["GridVisible"].ToString() == "1" || row["GridVisible"].ToString().ToLower() == "true" ) ? true : false) : false ;
				entityRule.IsRequiered = (row["IsRequiered"] != DBNull.Value) ? Convert.ToBoolean((row["IsRequiered"].ToString() == "1" || row["IsRequiered"].ToString().ToLower() == "true" ) ? true : false) : false ;
				entityRule.ReadOnly = (row["ReadOnly"] != DBNull.Value) ? Convert.ToBoolean((row["ReadOnly"].ToString() == "1" || row["ReadOnly"].ToString().ToLower() == "true" ) ? true : false) : false ;
				entityRule.HasLookup = (row["HasLookup"] != DBNull.Value) ? Convert.ToBoolean((row["HasLookup"].ToString() == "1" || row["HasLookup"].ToString().ToLower() == "true" ) ? true : false) : false ;
			}
		}

		return entityRule;
	}

	public EntityRule GetDetails(string entityName , string propertyName)
	{
		EntityRule entityRule = new EntityRule();

		SqlParameter[] parametersEntityRule = new SqlParameter[]
		{
			new SqlParameter("@EntityName", entityName),
			new SqlParameter("@PropertyName", propertyName)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("EntityRule_GetDetailsBy_EntityNamePropertyName", CommandType.StoredProcedure, parametersEntityRule))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				entityRule.EntityRuleID = (row["EntityRuleID"] != DBNull.Value) ? Convert.ToInt64(row["EntityRuleID"]) : 0 ;
				entityRule.ValidationType = row["ValidationType"].ToString();
				entityRule.EntityName = row["EntityName"].ToString();
				entityRule.PropertyName = row["PropertyName"].ToString();
				entityRule.ValueType = row["ValueType"].ToString();
				entityRule.ErrorMessage = row["ErrorMessage"].ToString();
				entityRule.FilterdBy = row["FilterdBy"].ToString();
				entityRule.Filters = row["Filters"].ToString();
				entityRule.EmptyText = row["EmptyText"].ToString();
				entityRule.DefaultValue = row["DefaultValue"].ToString();
				entityRule.FieldOrder = (row["FieldOrder"] != DBNull.Value) ? Convert.ToInt32(row["FieldOrder"]) : 0 ;
				entityRule.GridOrder = (row["GridOrder"] != DBNull.Value) ? Convert.ToInt32(row["GridOrder"]) : 0 ;
				entityRule.PropertyGroup = (row["PropertyGroup"] != DBNull.Value) ? Convert.ToInt32(row["PropertyGroup"]) : 0 ;
				entityRule.PropertyVisible = (row["PropertyVisible"] != DBNull.Value) ? Convert.ToBoolean((row["PropertyVisible"].ToString() == "1" || row["PropertyVisible"].ToString().ToLower() == "true" ) ? true : false) : false ;
				entityRule.GridVisible = (row["GridVisible"] != DBNull.Value) ? Convert.ToBoolean((row["GridVisible"].ToString() == "1" || row["GridVisible"].ToString().ToLower() == "true" ) ? true : false) : false ;
				entityRule.IsRequiered = (row["IsRequiered"] != DBNull.Value) ? Convert.ToBoolean((row["IsRequiered"].ToString() == "1" || row["IsRequiered"].ToString().ToLower() == "true" ) ? true : false) : false ;
				entityRule.ReadOnly = (row["ReadOnly"] != DBNull.Value) ? Convert.ToBoolean((row["ReadOnly"].ToString() == "1" || row["ReadOnly"].ToString().ToLower() == "true" ) ? true : false) : false ;
				entityRule.HasLookup = (row["HasLookup"] != DBNull.Value) ? Convert.ToBoolean((row["HasLookup"].ToString() == "1" || row["HasLookup"].ToString().ToLower() == "true" ) ? true : false) : false ;
			}
		}

		return entityRule;
	}

	public List<EntityRule> GetListAll()
	{
		List<EntityRule> listEntityRule = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("EntityRule_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listEntityRule = new List<EntityRule>();

				foreach (DataRow row in table.Rows)
				{
					EntityRule entityRule = new EntityRule();
					entityRule.EntityRuleID = (row["EntityRuleID"] != DBNull.Value) ? Convert.ToInt64(row["EntityRuleID"]) : 0 ;
					entityRule.ValidationType = row["ValidationType"].ToString();
					entityRule.EntityName = row["EntityName"].ToString();
					entityRule.PropertyName = row["PropertyName"].ToString();
					entityRule.ValueType = row["ValueType"].ToString();
					entityRule.ErrorMessage = row["ErrorMessage"].ToString();
					entityRule.FilterdBy = row["FilterdBy"].ToString();
					entityRule.Filters = row["Filters"].ToString();
					entityRule.EmptyText = row["EmptyText"].ToString();
					entityRule.DefaultValue = row["DefaultValue"].ToString();
					entityRule.FieldOrder = (row["FieldOrder"] != DBNull.Value) ? Convert.ToInt32(row["FieldOrder"]) : 0 ;
					entityRule.GridOrder = (row["GridOrder"] != DBNull.Value) ? Convert.ToInt32(row["GridOrder"]) : 0 ;
					entityRule.PropertyGroup = (row["PropertyGroup"] != DBNull.Value) ? Convert.ToInt32(row["PropertyGroup"]) : 0 ;
				entityRule.PropertyVisible = (row["PropertyVisible"] != DBNull.Value) ? Convert.ToBoolean((row["PropertyVisible"].ToString() == "1" || row["PropertyVisible"].ToString().ToLower() == "true" ) ? true : false) : false ;
				entityRule.GridVisible = (row["GridVisible"] != DBNull.Value) ? Convert.ToBoolean((row["GridVisible"].ToString() == "1" || row["GridVisible"].ToString().ToLower() == "true" ) ? true : false) : false ;
				entityRule.IsRequiered = (row["IsRequiered"] != DBNull.Value) ? Convert.ToBoolean((row["IsRequiered"].ToString() == "1" || row["IsRequiered"].ToString().ToLower() == "true" ) ? true : false) : false ;
				entityRule.ReadOnly = (row["ReadOnly"] != DBNull.Value) ? Convert.ToBoolean((row["ReadOnly"].ToString() == "1" || row["ReadOnly"].ToString().ToLower() == "true" ) ? true : false) : false ;
				entityRule.HasLookup = (row["HasLookup"] != DBNull.Value) ? Convert.ToBoolean((row["HasLookup"].ToString() == "1" || row["HasLookup"].ToString().ToLower() == "true" ) ? true : false) : false ;
					listEntityRule.Add(entityRule);
				}
			}
		}

		return listEntityRule;
	}

	public bool Exists(Int64 entityRuleID)
	{
		SqlParameter[] parametersEntityRule = new SqlParameter[]
		{
			new SqlParameter("@EntityRuleID", entityRuleID)
		};
		return (SqlDBHelper.ExecuteScalar("EntityRule_Exists", CommandType.StoredProcedure, parametersEntityRule)>0);
	}

	public bool Exists(EntityRule entityRule)
	{
		SqlParameter[] parametersEntityRule = new SqlParameter[]
		{
			new SqlParameter("@EntityRuleID", entityRule.EntityRuleID)
		};
		return (SqlDBHelper.ExecuteScalar("EntityRule_Exists", CommandType.StoredProcedure, parametersEntityRule)>0);
	}

	public List<EntityRule> GetListByEntityRuleEntityNamePropertyName(string entityName,string propertyName)
	{
		List<EntityRule> listEntityRule = new List<EntityRule>();

		//Lets get the list of all EntityRule records from database using EntityName PropertyName
		SqlParameter[] parametersEntityRule = new SqlParameter[]
		{
			new SqlParameter("@entityName", entityName),
			new SqlParameter("@propertyName", propertyName)
		};
		//Lets get the list of EntityRule records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("EntityRule_GetListByEntityNamePropertyName", CommandType.StoredProcedure, parametersEntityRule))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of entityRule
				listEntityRule = new List<EntityRule>();

				//Now lets populate the entityRule details into the list of entityRules
				foreach (DataRow row in table.Rows)
				{
					EntityRule entityRule = new EntityRule();
					entityRule.EntityRuleID = (row["EntityRuleID"] != DBNull.Value) ? Convert.ToInt64(row["EntityRuleID"]) : 0 ;
					entityRule.ValidationType = row["ValidationType"].ToString();
					entityRule.EntityName = row["EntityName"].ToString();
					entityRule.PropertyName = row["PropertyName"].ToString();
					entityRule.ValueType = row["ValueType"].ToString();
					entityRule.ErrorMessage = row["ErrorMessage"].ToString();
					entityRule.FilterdBy = row["FilterdBy"].ToString();
					entityRule.Filters = row["Filters"].ToString();
					entityRule.EmptyText = row["EmptyText"].ToString();
					entityRule.DefaultValue = row["DefaultValue"].ToString();
					entityRule.FieldOrder = (row["FieldOrder"] != DBNull.Value) ? Convert.ToInt32(row["FieldOrder"]) : 0 ;
					entityRule.GridOrder = (row["GridOrder"] != DBNull.Value) ? Convert.ToInt32(row["GridOrder"]) : 0 ;
					entityRule.PropertyGroup = (row["PropertyGroup"] != DBNull.Value) ? Convert.ToInt32(row["PropertyGroup"]) : 0 ;
				entityRule.PropertyVisible = (row["PropertyVisible"] != DBNull.Value) ? Convert.ToBoolean((row["PropertyVisible"].ToString() == "1" || row["PropertyVisible"].ToString().ToLower() == "true" ) ? true : false) : false ;
				entityRule.GridVisible = (row["GridVisible"] != DBNull.Value) ? Convert.ToBoolean((row["GridVisible"].ToString() == "1" || row["GridVisible"].ToString().ToLower() == "true" ) ? true : false) : false ;
				entityRule.IsRequiered = (row["IsRequiered"] != DBNull.Value) ? Convert.ToBoolean((row["IsRequiered"].ToString() == "1" || row["IsRequiered"].ToString().ToLower() == "true" ) ? true : false) : false ;
				entityRule.ReadOnly = (row["ReadOnly"] != DBNull.Value) ? Convert.ToBoolean((row["ReadOnly"].ToString() == "1" || row["ReadOnly"].ToString().ToLower() == "true" ) ? true : false) : false ;
				entityRule.HasLookup = (row["HasLookup"] != DBNull.Value) ? Convert.ToBoolean((row["HasLookup"].ToString() == "1" || row["HasLookup"].ToString().ToLower() == "true" ) ? true : false) : false ;
					listEntityRule.Add(entityRule);
				}
			}
		}

		return listEntityRule;
	}

	public List<EntityRule> SearchLike(EntityRule entityRule)
	{
		List<EntityRule> listEntityRule = new List<EntityRule>();


		SqlParameter[] parametersEntityRule = new SqlParameter[]
		{
			new SqlParameter("@EntityRuleID", entityRule.EntityRuleID),
			new SqlParameter("@ValidationType", entityRule.ValidationType),
			new SqlParameter("@EntityName", entityRule.EntityName),
			new SqlParameter("@PropertyName", entityRule.PropertyName),
			new SqlParameter("@ValueType", entityRule.ValueType),
			new SqlParameter("@ErrorMessage", entityRule.ErrorMessage),
			new SqlParameter("@FilterdBy", entityRule.FilterdBy),
			new SqlParameter("@Filters", entityRule.Filters),
			new SqlParameter("@EmptyText", entityRule.EmptyText),
			new SqlParameter("@DefaultValue", entityRule.DefaultValue),
			new SqlParameter("@FieldOrder", entityRule.FieldOrder),
			new SqlParameter("@GridOrder", entityRule.GridOrder),
			new SqlParameter("@PropertyGroup", entityRule.PropertyGroup),
			new SqlParameter("@PropertyVisible", entityRule.PropertyVisible),
			new SqlParameter("@GridVisible", entityRule.GridVisible),
			new SqlParameter("@IsRequiered", entityRule.IsRequiered),
			new SqlParameter("@ReadOnly", entityRule.ReadOnly),
			new SqlParameter("@HasLookup", entityRule.HasLookup),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("EntityRule_SearchLike", CommandType.StoredProcedure, parametersEntityRule))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					EntityRule tmpEntityRule = new EntityRule();
					tmpEntityRule.EntityRuleID = (row["EntityRuleID"] != DBNull.Value) ? Convert.ToInt64(row["EntityRuleID"]) : 0 ;
					tmpEntityRule.ValidationType = row["ValidationType"].ToString();
					tmpEntityRule.EntityName = row["EntityName"].ToString();
					tmpEntityRule.PropertyName = row["PropertyName"].ToString();
					tmpEntityRule.ValueType = row["ValueType"].ToString();
					tmpEntityRule.ErrorMessage = row["ErrorMessage"].ToString();
					tmpEntityRule.FilterdBy = row["FilterdBy"].ToString();
					tmpEntityRule.Filters = row["Filters"].ToString();
					tmpEntityRule.EmptyText = row["EmptyText"].ToString();
					tmpEntityRule.DefaultValue = row["DefaultValue"].ToString();
					tmpEntityRule.FieldOrder = (row["FieldOrder"] != DBNull.Value) ? Convert.ToInt32(row["FieldOrder"]) : 0 ;
					tmpEntityRule.GridOrder = (row["GridOrder"] != DBNull.Value) ? Convert.ToInt32(row["GridOrder"]) : 0 ;
					tmpEntityRule.PropertyGroup = (row["PropertyGroup"] != DBNull.Value) ? Convert.ToInt32(row["PropertyGroup"]) : 0 ;
					tmpEntityRule.PropertyVisible = (row["PropertyVisible"] != DBNull.Value) ? Convert.ToBoolean((row["PropertyVisible"].ToString() == "1" || row["PropertyVisible"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpEntityRule.GridVisible = (row["GridVisible"] != DBNull.Value) ? Convert.ToBoolean((row["GridVisible"].ToString() == "1" || row["GridVisible"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpEntityRule.IsRequiered = (row["IsRequiered"] != DBNull.Value) ? Convert.ToBoolean((row["IsRequiered"].ToString() == "1" || row["IsRequiered"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpEntityRule.ReadOnly = (row["ReadOnly"] != DBNull.Value) ? Convert.ToBoolean((row["ReadOnly"].ToString() == "1" || row["ReadOnly"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpEntityRule.HasLookup = (row["HasLookup"] != DBNull.Value) ? Convert.ToBoolean((row["HasLookup"].ToString() == "1" || row["HasLookup"].ToString().ToLower() == "true" ) ? true : false) : false ;

					listEntityRule.Add(tmpEntityRule);
				}
			}
		}

		return listEntityRule;
	}

}
}
