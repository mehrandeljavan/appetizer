using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class MainOfficeDBAccess
{

	TaxOfficeDBAccess taxOfficeDBAccess = new TaxOfficeDBAccess();

	public List<TaxOffice> GetListTaxOffice(int mainOfficeID)
	{
		List<TaxOffice> listTaxOffice = new List<TaxOffice>() { };
		SqlParameter[] parametersMainOffice = new SqlParameter[]
		{
			new SqlParameter("@MainOfficeID", mainOfficeID)
		};

		//Lets get the list of TaxOffice records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("TaxOffice_GetList_UseInMainOffice", CommandType.StoredProcedure, parametersMainOffice))
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
	public Int64 Insert(MainOffice mainOffice)
	{
		SqlParameter[] parametersMainOffice = new SqlParameter[]
		{
			new SqlParameter("@Title", (mainOffice.Title != null) ? mainOffice.Title : (object)DBNull.Value)
		};
		mainOffice.MainOfficeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("MainOffice_Insert", CommandType.StoredProcedure, parametersMainOffice));
		return mainOffice.MainOfficeID;
	}

	public bool Update(MainOffice mainOffice)
	{
		SqlParameter[] parametersMainOffice = new SqlParameter[]
		{
			new SqlParameter("@MainOfficeID", mainOffice.MainOfficeID),
			new SqlParameter("@Title", (mainOffice.Title != null) ? mainOffice.Title : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("MainOffice_Update", CommandType.StoredProcedure, parametersMainOffice);
	}

	public bool Delete(int mainOfficeID)
	{
		SqlParameter[] parametersMainOffice = new SqlParameter[]
		{
			new SqlParameter("@MainOfficeID", mainOfficeID)
		};
		return SqlDBHelper.ExecuteNonQuery("MainOffice_Delete", CommandType.StoredProcedure, parametersMainOffice);
	}

	public MainOffice GetDetails(int mainOfficeID)
	{
		MainOffice mainOffice = new MainOffice();

		SqlParameter[] parametersMainOffice = new SqlParameter[]
		{
			new SqlParameter("@MainOfficeID", mainOfficeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("MainOffice_GetDetails", CommandType.StoredProcedure, parametersMainOffice))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				mainOffice.MainOfficeID = (row["MainOfficeID"] != DBNull.Value) ? Convert.ToInt32(row["MainOfficeID"]) : 0 ;
				mainOffice.Title = row["Title"].ToString();
			}
		}

		return mainOffice;
	}

	public List<MainOffice> GetListAll()
	{
		List<MainOffice> listMainOffice = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("MainOffice_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listMainOffice = new List<MainOffice>();

				foreach (DataRow row in table.Rows)
				{
					MainOffice mainOffice = new MainOffice();
					mainOffice.MainOfficeID = (row["MainOfficeID"] != DBNull.Value) ? Convert.ToInt32(row["MainOfficeID"]) : 0 ;
					mainOffice.Title = row["Title"].ToString();
					listMainOffice.Add(mainOffice);
				}
			}
		}

		return listMainOffice;
	}

	public bool Exists(int mainOfficeID)
	{
		SqlParameter[] parametersMainOffice = new SqlParameter[]
		{
			new SqlParameter("@MainOfficeID", mainOfficeID)
		};
		return (SqlDBHelper.ExecuteScalar("MainOffice_Exists", CommandType.StoredProcedure, parametersMainOffice)>0);
	}

	public bool Exists(MainOffice mainOffice)
	{
		SqlParameter[] parametersMainOffice = new SqlParameter[]
		{
			new SqlParameter("@MainOfficeID", mainOffice.MainOfficeID)
		};
		return (SqlDBHelper.ExecuteScalar("MainOffice_Exists", CommandType.StoredProcedure, parametersMainOffice)>0);
	}

	public List<MainOffice> SearchLike(MainOffice mainOffice)
	{
		List<MainOffice> listMainOffice = new List<MainOffice>();


		SqlParameter[] parametersMainOffice = new SqlParameter[]
		{
			new SqlParameter("@MainOfficeID", mainOffice.MainOfficeID),
			new SqlParameter("@Title", mainOffice.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("MainOffice_SearchLike", CommandType.StoredProcedure, parametersMainOffice))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					MainOffice tmpMainOffice = new MainOffice();
					tmpMainOffice.MainOfficeID = (row["MainOfficeID"] != DBNull.Value) ? Convert.ToInt32(row["MainOfficeID"]) : 0 ;
					tmpMainOffice.Title = row["Title"].ToString();

					listMainOffice.Add(tmpMainOffice);
				}
			}
		}

		return listMainOffice;
	}

}
}
