using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class TaxOfficeDossierAssignMethodDBAccess
{

	TaxOfficeDBAccess taxOfficeDBAccess = new TaxOfficeDBAccess();

	public List<TaxOffice> GetListTaxOffice(int taxOfficeDossierAssignMethodID)
	{
		List<TaxOffice> listTaxOffice = new List<TaxOffice>() { };
		SqlParameter[] parametersTaxOfficeDossierAssignMethod = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeDossierAssignMethodID", taxOfficeDossierAssignMethodID)
		};

		//Lets get the list of TaxOffice records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("TaxOffice_GetList_UseInTaxOfficeDossierAssignMethod", CommandType.StoredProcedure, parametersTaxOfficeDossierAssignMethod))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of taxOffice
				listTaxOffice = new List<TaxOffice>();

				//Now lets populate the TaxOffice details into the list of taxOffices
				foreach (DataRow row in table.Rows)
				{
					TaxOffice taxOffice = ConvertRowToTaxOffice(row);
					listTaxOffice.Add(taxOffice);
				}
			}
		}

		return listTaxOffice;
	}

	private TaxOffice ConvertRowToTaxOffice(DataRow row)
	{
		TaxOffice taxOffice = new TaxOffice();
		taxOffice.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
		taxOffice.Title = row["Title"].ToString();
		taxOffice.CityIDTitle = row["CityIDTitle"].ToString();
		taxOffice.TaxOfficeDossierAssignMethodIDTitle = row["TaxOfficeDossierAssignMethodIDTitle"].ToString();
		taxOffice.ProvinceIDTitle = row["ProvinceIDTitle"].ToString();
		taxOffice.ParentTaxOfficeTitle = row["ParentTaxOfficeTitle"].ToString();
		taxOffice.PrivateTitle = row["PrivateTitle"].ToString();
		taxOffice.Address = row["Address"].ToString();
		taxOffice.Comment = row["Comment"].ToString();
		taxOffice.Fax = row["Fax"].ToString();
		taxOffice.Website = row["Website"].ToString();
		taxOffice.Email = row["Email"].ToString();
		taxOffice.CityID = (row["CityID"] != DBNull.Value) ? Convert.ToInt32(row["CityID"]) : 0 ;
		taxOffice.ParentTaxOfficeCode = (row["ParentTaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["ParentTaxOfficeCode"]) : 0 ;
		taxOffice.TaxOfficeDossierAssignMethodID = (row["TaxOfficeDossierAssignMethodID"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeDossierAssignMethodID"]) : 0 ;
		taxOffice.ProvinceID = (row["ProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["ProvinceID"]) : 0 ;
		taxOffice.MainOfficeID = (row["MainOfficeID"] != DBNull.Value) ? Convert.ToInt32(row["MainOfficeID"]) : 0 ;
		taxOffice.BossNationalCode = (row["BossNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["BossNationalCode"]) : 0 ;
		taxOffice.ZipCode = row["ZipCode"].ToString();
		taxOffice.PhoneNumber = row["PhoneNumber"].ToString();
		return taxOffice;
	}
	public Int64 Insert(TaxOfficeDossierAssignMethod taxOfficeDossierAssignMethod)
	{
		SqlParameter[] parametersTaxOfficeDossierAssignMethod = new SqlParameter[]
		{
			new SqlParameter("@Title", (taxOfficeDossierAssignMethod.Title != null) ? taxOfficeDossierAssignMethod.Title : (object)DBNull.Value)
		};
		taxOfficeDossierAssignMethod.TaxOfficeDossierAssignMethodID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("TaxOfficeDossierAssignMethod_Insert", CommandType.StoredProcedure, parametersTaxOfficeDossierAssignMethod));
		return taxOfficeDossierAssignMethod.TaxOfficeDossierAssignMethodID;
	}

	public bool Update(TaxOfficeDossierAssignMethod taxOfficeDossierAssignMethod)
	{
		SqlParameter[] parametersTaxOfficeDossierAssignMethod = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeDossierAssignMethodID", taxOfficeDossierAssignMethod.TaxOfficeDossierAssignMethodID),
			new SqlParameter("@Title", (taxOfficeDossierAssignMethod.Title != null) ? taxOfficeDossierAssignMethod.Title : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("TaxOfficeDossierAssignMethod_Update", CommandType.StoredProcedure, parametersTaxOfficeDossierAssignMethod);
	}

	public bool Delete(int taxOfficeDossierAssignMethodID)
	{
		SqlParameter[] parametersTaxOfficeDossierAssignMethod = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeDossierAssignMethodID", taxOfficeDossierAssignMethodID)
		};
		return SqlDBHelper.ExecuteNonQuery("TaxOfficeDossierAssignMethod_Delete", CommandType.StoredProcedure, parametersTaxOfficeDossierAssignMethod);
	}

	public TaxOfficeDossierAssignMethod GetDetails(int taxOfficeDossierAssignMethodID)
	{
		TaxOfficeDossierAssignMethod taxOfficeDossierAssignMethod = new TaxOfficeDossierAssignMethod();

		SqlParameter[] parametersTaxOfficeDossierAssignMethod = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeDossierAssignMethodID", taxOfficeDossierAssignMethodID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("TaxOfficeDossierAssignMethod_GetDetails", CommandType.StoredProcedure, parametersTaxOfficeDossierAssignMethod))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				taxOfficeDossierAssignMethod.TaxOfficeDossierAssignMethodID = (row["TaxOfficeDossierAssignMethodID"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeDossierAssignMethodID"]) : 0 ;
				taxOfficeDossierAssignMethod.Title = row["Title"].ToString();
			}
		}

		return taxOfficeDossierAssignMethod;
	}

	public List<TaxOfficeDossierAssignMethod> GetListAll()
	{
		List<TaxOfficeDossierAssignMethod> listTaxOfficeDossierAssignMethod = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("TaxOfficeDossierAssignMethod_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listTaxOfficeDossierAssignMethod = new List<TaxOfficeDossierAssignMethod>();

				foreach (DataRow row in table.Rows)
				{
					TaxOfficeDossierAssignMethod taxOfficeDossierAssignMethod = new TaxOfficeDossierAssignMethod();
					taxOfficeDossierAssignMethod.TaxOfficeDossierAssignMethodID = (row["TaxOfficeDossierAssignMethodID"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeDossierAssignMethodID"]) : 0 ;
					taxOfficeDossierAssignMethod.Title = row["Title"].ToString();
					listTaxOfficeDossierAssignMethod.Add(taxOfficeDossierAssignMethod);
				}
			}
		}

		return listTaxOfficeDossierAssignMethod;
	}

	public bool Exists(int taxOfficeDossierAssignMethodID)
	{
		SqlParameter[] parametersTaxOfficeDossierAssignMethod = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeDossierAssignMethodID", taxOfficeDossierAssignMethodID)
		};
		return (SqlDBHelper.ExecuteScalar("TaxOfficeDossierAssignMethod_Exists", CommandType.StoredProcedure, parametersTaxOfficeDossierAssignMethod)>0);
	}

	public bool Exists(TaxOfficeDossierAssignMethod taxOfficeDossierAssignMethod)
	{
		SqlParameter[] parametersTaxOfficeDossierAssignMethod = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeDossierAssignMethodID", taxOfficeDossierAssignMethod.TaxOfficeDossierAssignMethodID)
		};
		return (SqlDBHelper.ExecuteScalar("TaxOfficeDossierAssignMethod_Exists", CommandType.StoredProcedure, parametersTaxOfficeDossierAssignMethod)>0);
	}

	public List<TaxOfficeDossierAssignMethod> SearchLike(TaxOfficeDossierAssignMethod taxOfficeDossierAssignMethod)
	{
		List<TaxOfficeDossierAssignMethod> listTaxOfficeDossierAssignMethod = new List<TaxOfficeDossierAssignMethod>();


		SqlParameter[] parametersTaxOfficeDossierAssignMethod = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeDossierAssignMethodID", taxOfficeDossierAssignMethod.TaxOfficeDossierAssignMethodID),
			new SqlParameter("@Title", taxOfficeDossierAssignMethod.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("TaxOfficeDossierAssignMethod_SearchLike", CommandType.StoredProcedure, parametersTaxOfficeDossierAssignMethod))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					TaxOfficeDossierAssignMethod tmpTaxOfficeDossierAssignMethod = new TaxOfficeDossierAssignMethod();
					tmpTaxOfficeDossierAssignMethod.TaxOfficeDossierAssignMethodID = (row["TaxOfficeDossierAssignMethodID"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeDossierAssignMethodID"]) : 0 ;
					tmpTaxOfficeDossierAssignMethod.Title = row["Title"].ToString();

					listTaxOfficeDossierAssignMethod.Add(tmpTaxOfficeDossierAssignMethod);
				}
			}
		}

		return listTaxOfficeDossierAssignMethod;
	}

}
}
