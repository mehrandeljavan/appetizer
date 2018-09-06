using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class EntityRule
{
	private Int64 entityRuleID;
	private string validationType;
	private string entityName;
	private string propertyName;
	private string valueType;
	private string errorMessage;
	private string filterdBy;
	private string filters;
	private string emptyText;
	private string defaultValue;
	private int fieldOrder;
	private int gridOrder;
	private int propertyGroup;
	private bool propertyVisible;
	private bool gridVisible;
	private bool isRequiered;
	private bool readOnly;
	private bool hasLookup;

	public Int64 EntityRuleID
	{
		get
		{
			return entityRuleID;
		}
		set
		{
			entityRuleID = value;
		}
	}

	public string ValidationType
	{
		get
		{
			return validationType;
		}
		set
		{
			validationType = value;
		}
	}

	public string EntityName
	{
		get
		{
			return entityName;
		}
		set
		{
			entityName = value;
		}
	}

	public string PropertyName
	{
		get
		{
			return propertyName;
		}
		set
		{
			propertyName = value;
		}
	}

	public string ValueType
	{
		get
		{
			return valueType;
		}
		set
		{
			valueType = value;
		}
	}

	public string ErrorMessage
	{
		get
		{
			return errorMessage;
		}
		set
		{
			errorMessage = value;
		}
	}

	public string FilterdBy
	{
		get
		{
			return filterdBy;
		}
		set
		{
			filterdBy = value;
		}
	}

	public string Filters
	{
		get
		{
			return filters;
		}
		set
		{
			filters = value;
		}
	}

	public string EmptyText
	{
		get
		{
			return emptyText;
		}
		set
		{
			emptyText = value;
		}
	}

	public string DefaultValue
	{
		get
		{
			return defaultValue;
		}
		set
		{
			defaultValue = value;
		}
	}

	public int FieldOrder
	{
		get
		{
			return fieldOrder;
		}
		set
		{
			fieldOrder = value;
		}
	}

	public int GridOrder
	{
		get
		{
			return gridOrder;
		}
		set
		{
			gridOrder = value;
		}
	}

	public int PropertyGroup
	{
		get
		{
			return propertyGroup;
		}
		set
		{
			propertyGroup = value;
		}
	}

	public bool PropertyVisible
	{
		get
		{
			return propertyVisible;
		}
		set
		{
			propertyVisible = value;
		}
	}

	public bool GridVisible
	{
		get
		{
			return gridVisible;
		}
		set
		{
			gridVisible = value;
		}
	}

	public bool IsRequiered
	{
		get
		{
			return isRequiered;
		}
		set
		{
			isRequiered = value;
		}
	}

	public bool ReadOnly
	{
		get
		{
			return readOnly;
		}
		set
		{
			readOnly = value;
		}
	}

	public bool HasLookup
	{
		get
		{
			return hasLookup;
		}
		set
		{
			hasLookup = value;
		}
	}

}
}
