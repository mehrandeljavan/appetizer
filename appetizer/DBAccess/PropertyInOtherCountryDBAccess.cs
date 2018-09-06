using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class PropertyInOtherCountryDBAccess
{


	public Int64 Insert(PropertyInOtherCountry propertyInOtherCountry)
	{
		SqlParameter[] parametersPropertyInOtherCountry = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (propertyInOtherCountry.HeritageID > 0) ? propertyInOtherCountry.HeritageID : (object)DBNull.Value),
			new SqlParameter("@Name", (propertyInOtherCountry.Name != null) ? propertyInOtherCountry.Name : (object)DBNull.Value),
			new SqlParameter("@HostCountry", (propertyInOtherCountry.HostCountry != null) ? propertyInOtherCountry.HostCountry : (object)DBNull.Value),
			new SqlParameter("@PayedTaxInHostCountry", propertyInOtherCountry.PayedTaxInHostCountry)
		};
		return SqlDBHelper.ExecuteScalar("PropertyInOtherCountry_Insert", CommandType.StoredProcedure, parametersPropertyInOtherCountry);
	}

	public bool Update(PropertyInOtherCountry propertyInOtherCountry)
	{
		SqlParameter[] parametersPropertyInOtherCountry = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", propertyInOtherCountry.HeritageID),
			new SqlParameter("@Name", (propertyInOtherCountry.Name != null) ? propertyInOtherCountry.Name : (object)DBNull.Value),
			new SqlParameter("@HostCountry", (propertyInOtherCountry.HostCountry != null) ? propertyInOtherCountry.HostCountry : (object)DBNull.Value),
			new SqlParameter("@PayedTaxInHostCountry", propertyInOtherCountry.PayedTaxInHostCountry)
		};
		return SqlDBHelper.ExecuteNonQuery("PropertyInOtherCountry_Update", CommandType.StoredProcedure, parametersPropertyInOtherCountry);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersPropertyInOtherCountry = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("PropertyInOtherCountry_Delete", CommandType.StoredProcedure, parametersPropertyInOtherCountry);
	}

	public PropertyInOtherCountry GetDetails(Int64 heritageID)
	{
		PropertyInOtherCountry propertyInOtherCountry = new PropertyInOtherCountry();

		SqlParameter[] parametersPropertyInOtherCountry = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("PropertyInOtherCountry_GetDetails", CommandType.StoredProcedure, parametersPropertyInOtherCountry))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				propertyInOtherCountry.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				propertyInOtherCountry.Name = row["Name"].ToString();
				propertyInOtherCountry.HostCountry = row["HostCountry"].ToString();
				propertyInOtherCountry.PayedTaxInHostCountry = (row["PayedTaxInHostCountry"] != DBNull.Value) ? Convert.ToSingle(row["PayedTaxInHostCountry"]) : 0 ;
			}
		}

		return propertyInOtherCountry;
	}

	public List<PropertyInOtherCountry> GetListAll()
	{
		List<PropertyInOtherCountry> listPropertyInOtherCountry = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("PropertyInOtherCountry_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listPropertyInOtherCountry = new List<PropertyInOtherCountry>();

				foreach (DataRow row in table.Rows)
				{
					PropertyInOtherCountry propertyInOtherCountry = new PropertyInOtherCountry();
					propertyInOtherCountry.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					propertyInOtherCountry.Name = row["Name"].ToString();
					propertyInOtherCountry.HostCountry = row["HostCountry"].ToString();
					propertyInOtherCountry.PayedTaxInHostCountry = (row["PayedTaxInHostCountry"] != DBNull.Value) ? Convert.ToSingle(row["PayedTaxInHostCountry"]) : 0 ;
					listPropertyInOtherCountry.Add(propertyInOtherCountry);
				}
			}
		}

		return listPropertyInOtherCountry;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersPropertyInOtherCountry = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("PropertyInOtherCountry_Exists", CommandType.StoredProcedure, parametersPropertyInOtherCountry)>0);
	}

	public bool Exists(PropertyInOtherCountry propertyInOtherCountry)
	{
		SqlParameter[] parametersPropertyInOtherCountry = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", propertyInOtherCountry.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("PropertyInOtherCountry_Exists", CommandType.StoredProcedure, parametersPropertyInOtherCountry)>0);
	}

	public List<PropertyInOtherCountry> SearchLike(PropertyInOtherCountry propertyInOtherCountry)
	{
		List<PropertyInOtherCountry> listPropertyInOtherCountry = new List<PropertyInOtherCountry>();


		SqlParameter[] parametersPropertyInOtherCountry = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", propertyInOtherCountry.HeritageID),
			new SqlParameter("@Name", propertyInOtherCountry.Name),
			new SqlParameter("@HostCountry", propertyInOtherCountry.HostCountry),
			new SqlParameter("@PayedTaxInHostCountry", propertyInOtherCountry.PayedTaxInHostCountry),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("PropertyInOtherCountry_SearchLike", CommandType.StoredProcedure, parametersPropertyInOtherCountry))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					PropertyInOtherCountry tmpPropertyInOtherCountry = new PropertyInOtherCountry();
					tmpPropertyInOtherCountry.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpPropertyInOtherCountry.Name = row["Name"].ToString();
					tmpPropertyInOtherCountry.HostCountry = row["HostCountry"].ToString();
					tmpPropertyInOtherCountry.PayedTaxInHostCountry = (row["PayedTaxInHostCountry"] != DBNull.Value) ? Convert.ToSingle(row["PayedTaxInHostCountry"]) : 0 ;

					listPropertyInOtherCountry.Add(tmpPropertyInOtherCountry);
				}
			}
		}

		return listPropertyInOtherCountry;
	}

}
}
