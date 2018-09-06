using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class TaxOfficeDBAccess
{

	DossierDBAccess dossierDBAccess = new DossierDBAccess();
	UserTaxOfficeActivityRolePartDBAccess userTaxOfficeActivityRolePartDBAccess = new UserTaxOfficeActivityRolePartDBAccess();
	UserTaxOfficeRolePartDBAccess userTaxOfficeRolePartDBAccess = new UserTaxOfficeRolePartDBAccess();

	public List<Dossier> GetListDossier(int taxOfficeCode)
	{
		List<Dossier> listDossier = new List<Dossier>() { };
		SqlParameter[] parametersTaxOffice = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeCode", taxOfficeCode)
		};

		//Lets get the list of Dossier records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Dossier_GetList_UseInTaxOffice", CommandType.StoredProcedure, parametersTaxOffice))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of dossier
				listDossier = new List<Dossier>();

				//Now lets populate the Dossier details into the list of dossiers
				foreach (DataRow row in table.Rows)
				{
					Dossier dossier = ConvertRowToDossier(row);
					listDossier.Add(dossier);
				}
			}
		}

		return listDossier;
	}

	private Dossier ConvertRowToDossier(DataRow row)
	{
		Dossier dossier = new Dossier();
		dossier.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
		dossier.Classes = row["Classes"].ToString();
		dossier.TaxOfficeCodeTitle = row["TaxOfficeCodeTitle"].ToString();
		dossier.TaxOfficeCityIDTitle = row["TaxOfficeCityIDTitle"].ToString();
		dossier.OrderNumber = (row["OrderNumber"] != DBNull.Value) ? Convert.ToInt64(row["OrderNumber"]) : 0 ;
		dossier.OldClasses = row["OldClasses"].ToString();
		dossier.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
		dossier.IsActive = (row["IsActive"] != DBNull.Value) ? Convert.ToBoolean((row["IsActive"].ToString() == "1" || row["IsActive"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return dossier;
	}
	public List<UserTaxOfficeActivityRolePart> GetListUserTaxOfficeActivityRolePart(int taxOfficeCode)
	{
		List<UserTaxOfficeActivityRolePart> listUserTaxOfficeActivityRolePart = new List<UserTaxOfficeActivityRolePart>() { };
		SqlParameter[] parametersTaxOffice = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeCode", taxOfficeCode)
		};

		//Lets get the list of UserTaxOfficeActivityRolePart records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserTaxOfficeActivityRolePart_GetList_UseInTaxOffice", CommandType.StoredProcedure, parametersTaxOffice))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of userTaxOfficeActivityRolePart
				listUserTaxOfficeActivityRolePart = new List<UserTaxOfficeActivityRolePart>();

				//Now lets populate the UserTaxOfficeActivityRolePart details into the list of userTaxOfficeActivityRoleParts
				foreach (DataRow row in table.Rows)
				{
					UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart = ConvertRowToUserTaxOfficeActivityRolePart(row);
					listUserTaxOfficeActivityRolePart.Add(userTaxOfficeActivityRolePart);
				}
			}
		}

		return listUserTaxOfficeActivityRolePart;
	}

	private UserTaxOfficeActivityRolePart ConvertRowToUserTaxOfficeActivityRolePart(DataRow row)
	{
		UserTaxOfficeActivityRolePart userTaxOfficeActivityRolePart = new UserTaxOfficeActivityRolePart();
		userTaxOfficeActivityRolePart.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
		userTaxOfficeActivityRolePart.ActivityID = (row["ActivityID"] != DBNull.Value) ? Convert.ToInt32(row["ActivityID"]) : 0 ;
		userTaxOfficeActivityRolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
		userTaxOfficeActivityRolePart.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
		userTaxOfficeActivityRolePart.UserFullName = row["UserFullName"].ToString();
		userTaxOfficeActivityRolePart.TaxOfficeCodeTitle = row["TaxOfficeCodeTitle"].ToString();
		userTaxOfficeActivityRolePart.RolePartIDTitle = row["RolePartIDTitle"].ToString();
		userTaxOfficeActivityRolePart.ActivityTitle = row["ActivityTitle"].ToString();
		userTaxOfficeActivityRolePart.Permission = (row["Permission"] != DBNull.Value) ? Convert.ToInt32(row["Permission"]) : 0 ;
		return userTaxOfficeActivityRolePart;
	}
	public List<UserTaxOfficeRolePart> GetListUserTaxOfficeRolePart(int taxOfficeCode)
	{
		List<UserTaxOfficeRolePart> listUserTaxOfficeRolePart = new List<UserTaxOfficeRolePart>() { };
		SqlParameter[] parametersTaxOffice = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeCode", taxOfficeCode)
		};

		//Lets get the list of UserTaxOfficeRolePart records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserTaxOfficeRolePart_GetList_UseInTaxOffice", CommandType.StoredProcedure, parametersTaxOffice))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of userTaxOfficeRolePart
				listUserTaxOfficeRolePart = new List<UserTaxOfficeRolePart>();

				//Now lets populate the UserTaxOfficeRolePart details into the list of userTaxOfficeRoleParts
				foreach (DataRow row in table.Rows)
				{
					UserTaxOfficeRolePart userTaxOfficeRolePart = ConvertRowToUserTaxOfficeRolePart(row);
					listUserTaxOfficeRolePart.Add(userTaxOfficeRolePart);
				}
			}
		}

		return listUserTaxOfficeRolePart;
	}

	private UserTaxOfficeRolePart ConvertRowToUserTaxOfficeRolePart(DataRow row)
	{
		UserTaxOfficeRolePart userTaxOfficeRolePart = new UserTaxOfficeRolePart();
		userTaxOfficeRolePart.UserTaxOfficeRolePartID = (row["UserTaxOfficeRolePartID"] != DBNull.Value) ? Convert.ToInt64(row["UserTaxOfficeRolePartID"]) : 0 ;
		userTaxOfficeRolePart.UserFullName = row["UserFullName"].ToString();
		userTaxOfficeRolePart.TaxOfficeTitle = row["TaxOfficeTitle"].ToString();
		userTaxOfficeRolePart.RolePartIDTitle = row["RolePartIDTitle"].ToString();
		userTaxOfficeRolePart.Title = row["Title"].ToString();
		userTaxOfficeRolePart.Letters = row["Letters"].ToString();
		userTaxOfficeRolePart.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
		userTaxOfficeRolePart.RolePartID = (row["RolePartID"] != DBNull.Value) ? Convert.ToInt32(row["RolePartID"]) : 0 ;
		userTaxOfficeRolePart.TaxUnitCode = (row["TaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxUnitCode"]) : 0 ;
		userTaxOfficeRolePart.IsActive = (row["IsActive"] != DBNull.Value) ? Convert.ToBoolean((row["IsActive"].ToString() == "1" || row["IsActive"].ToString().ToLower() == "true" ) ? true : false) : false ;
		userTaxOfficeRolePart.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
		return userTaxOfficeRolePart;
	}
	public Int64 Insert(TaxOffice taxOffice)
	{
		SqlParameter[] parametersTaxOffice = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeCode", taxOffice.TaxOfficeCode),
			new SqlParameter("@PrivateTitle", (taxOffice.PrivateTitle != null) ? taxOffice.PrivateTitle : (object)DBNull.Value),
			new SqlParameter("@Address", (taxOffice.Address != null) ? taxOffice.Address : (object)DBNull.Value),
			new SqlParameter("@Comment", (taxOffice.Comment != null) ? taxOffice.Comment : (object)DBNull.Value),
			new SqlParameter("@Fax", (taxOffice.Fax != null) ? taxOffice.Fax : (object)DBNull.Value),
			new SqlParameter("@Website", (taxOffice.Website != null) ? taxOffice.Website : (object)DBNull.Value),
			new SqlParameter("@Email", (taxOffice.Email != null) ? taxOffice.Email : (object)DBNull.Value),
			new SqlParameter("@CityID", (taxOffice.CityID > 0) ? taxOffice.CityID : (object)DBNull.Value),
			new SqlParameter("@ParentTaxOfficeCode", (taxOffice.ParentTaxOfficeCode != null) ? taxOffice.ParentTaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@TaxOfficeDossierAssignMethodID", (taxOffice.TaxOfficeDossierAssignMethodID > 0) ? taxOffice.TaxOfficeDossierAssignMethodID : (object)DBNull.Value),
			new SqlParameter("@ProvinceID", (taxOffice.ProvinceID > 0) ? taxOffice.ProvinceID : (object)DBNull.Value),
			new SqlParameter("@MainOfficeID", (taxOffice.MainOfficeID > 0) ? taxOffice.MainOfficeID : (object)DBNull.Value),
			new SqlParameter("@BossNationalCode", (taxOffice.BossNationalCode != null) ? taxOffice.BossNationalCode : (object)DBNull.Value),
			new SqlParameter("@ZipCode", (taxOffice.ZipCode != null) ? taxOffice.ZipCode : (object)DBNull.Value),
			new SqlParameter("@PhoneNumber", (taxOffice.PhoneNumber != null) ? taxOffice.PhoneNumber : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("TaxOffice_Insert", CommandType.StoredProcedure, parametersTaxOffice);
	}

	public bool Update(TaxOffice taxOffice)
	{
		SqlParameter[] parametersTaxOffice = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeCode", taxOffice.TaxOfficeCode),
			new SqlParameter("@PrivateTitle", (taxOffice.PrivateTitle != null) ? taxOffice.PrivateTitle : (object)DBNull.Value),
			new SqlParameter("@Address", (taxOffice.Address != null) ? taxOffice.Address : (object)DBNull.Value),
			new SqlParameter("@Comment", (taxOffice.Comment != null) ? taxOffice.Comment : (object)DBNull.Value),
			new SqlParameter("@Fax", (taxOffice.Fax != null) ? taxOffice.Fax : (object)DBNull.Value),
			new SqlParameter("@Website", (taxOffice.Website != null) ? taxOffice.Website : (object)DBNull.Value),
			new SqlParameter("@Email", (taxOffice.Email != null) ? taxOffice.Email : (object)DBNull.Value),
			new SqlParameter("@CityID", taxOffice.CityID),
			new SqlParameter("@ParentTaxOfficeCode", (taxOffice.ParentTaxOfficeCode != null) ? taxOffice.ParentTaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@TaxOfficeDossierAssignMethodID", (taxOffice.TaxOfficeDossierAssignMethodID != null && taxOffice.TaxOfficeDossierAssignMethodID >0 ) ? taxOffice.TaxOfficeDossierAssignMethodID : (object)DBNull.Value),
			new SqlParameter("@ProvinceID", (taxOffice.ProvinceID != null && taxOffice.ProvinceID >0 ) ? taxOffice.ProvinceID : (object)DBNull.Value),
			new SqlParameter("@MainOfficeID", (taxOffice.MainOfficeID != null && taxOffice.MainOfficeID >0 ) ? taxOffice.MainOfficeID : (object)DBNull.Value),
			new SqlParameter("@BossNationalCode", (taxOffice.BossNationalCode != null) ? taxOffice.BossNationalCode : (object)DBNull.Value),
			new SqlParameter("@ZipCode", (taxOffice.ZipCode != null) ? taxOffice.ZipCode : (object)DBNull.Value),
			new SqlParameter("@PhoneNumber", (taxOffice.PhoneNumber != null) ? taxOffice.PhoneNumber : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("TaxOffice_Update", CommandType.StoredProcedure, parametersTaxOffice);
	}

	public bool Delete(int taxOfficeCode)
	{
		SqlParameter[] parametersTaxOffice = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeCode", taxOfficeCode)
		};
		return SqlDBHelper.ExecuteNonQuery("TaxOffice_Delete", CommandType.StoredProcedure, parametersTaxOffice);
	}

	public TaxOffice GetDetails(int taxOfficeCode)
	{
		TaxOffice taxOffice = new TaxOffice();

		SqlParameter[] parametersTaxOffice = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeCode", taxOfficeCode)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("TaxOffice_GetDetails", CommandType.StoredProcedure, parametersTaxOffice))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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
			}
		}

		return taxOffice;
	}

	public List<TaxOffice> GetListAll()
	{
		List<TaxOffice> listTaxOffice = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("TaxOffice_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listTaxOffice = new List<TaxOffice>();

				foreach (DataRow row in table.Rows)
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
					listTaxOffice.Add(taxOffice);
				}
			}
		}

		return listTaxOffice;
	}

	public bool Exists(int taxOfficeCode)
	{
		SqlParameter[] parametersTaxOffice = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeCode", taxOfficeCode)
		};
		return (SqlDBHelper.ExecuteScalar("TaxOffice_Exists", CommandType.StoredProcedure, parametersTaxOffice)>0);
	}

	public bool Exists(TaxOffice taxOffice)
	{
		SqlParameter[] parametersTaxOffice = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeCode", taxOffice.TaxOfficeCode)
		};
		return (SqlDBHelper.ExecuteScalar("TaxOffice_Exists", CommandType.StoredProcedure, parametersTaxOffice)>0);
	}

	public List<TaxOffice> SearchLike(TaxOffice taxOffice)
	{
		List<TaxOffice> listTaxOffice = new List<TaxOffice>();


		SqlParameter[] parametersTaxOffice = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeCode", taxOffice.TaxOfficeCode),
			new SqlParameter("@Title", taxOffice.Title),
			new SqlParameter("@CityIDTitle", taxOffice.CityIDTitle),
			new SqlParameter("@TaxOfficeDossierAssignMethodIDTitle", taxOffice.TaxOfficeDossierAssignMethodIDTitle),
			new SqlParameter("@ProvinceIDTitle", taxOffice.ProvinceIDTitle),
			new SqlParameter("@ParentTaxOfficeTitle", taxOffice.ParentTaxOfficeTitle),
			new SqlParameter("@PrivateTitle", taxOffice.PrivateTitle),
			new SqlParameter("@Address", taxOffice.Address),
			new SqlParameter("@Comment", taxOffice.Comment),
			new SqlParameter("@Fax", taxOffice.Fax),
			new SqlParameter("@Website", taxOffice.Website),
			new SqlParameter("@Email", taxOffice.Email),
			new SqlParameter("@CityID", taxOffice.CityID),
			new SqlParameter("@ParentTaxOfficeCode", taxOffice.ParentTaxOfficeCode),
			new SqlParameter("@TaxOfficeDossierAssignMethodID", taxOffice.TaxOfficeDossierAssignMethodID),
			new SqlParameter("@ProvinceID", taxOffice.ProvinceID),
			new SqlParameter("@MainOfficeID", taxOffice.MainOfficeID),
			new SqlParameter("@BossNationalCode", taxOffice.BossNationalCode),
			new SqlParameter("@ZipCode", taxOffice.ZipCode),
			new SqlParameter("@PhoneNumber", taxOffice.PhoneNumber),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("TaxOffice_SearchLike", CommandType.StoredProcedure, parametersTaxOffice))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					TaxOffice tmpTaxOffice = new TaxOffice();
					tmpTaxOffice.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
					tmpTaxOffice.Title = row["Title"].ToString();
					tmpTaxOffice.CityIDTitle = row["CityIDTitle"].ToString();
					tmpTaxOffice.TaxOfficeDossierAssignMethodIDTitle = row["TaxOfficeDossierAssignMethodIDTitle"].ToString();
					tmpTaxOffice.ProvinceIDTitle = row["ProvinceIDTitle"].ToString();
					tmpTaxOffice.ParentTaxOfficeTitle = row["ParentTaxOfficeTitle"].ToString();
					tmpTaxOffice.PrivateTitle = row["PrivateTitle"].ToString();
					tmpTaxOffice.Address = row["Address"].ToString();
					tmpTaxOffice.Comment = row["Comment"].ToString();
					tmpTaxOffice.Fax = row["Fax"].ToString();
					tmpTaxOffice.Website = row["Website"].ToString();
					tmpTaxOffice.Email = row["Email"].ToString();
					tmpTaxOffice.CityID = (row["CityID"] != DBNull.Value) ? Convert.ToInt32(row["CityID"]) : 0 ;
					tmpTaxOffice.ParentTaxOfficeCode = (row["ParentTaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["ParentTaxOfficeCode"]) : 0 ;
					tmpTaxOffice.TaxOfficeDossierAssignMethodID = (row["TaxOfficeDossierAssignMethodID"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeDossierAssignMethodID"]) : 0 ;
					tmpTaxOffice.ProvinceID = (row["ProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["ProvinceID"]) : 0 ;
					tmpTaxOffice.MainOfficeID = (row["MainOfficeID"] != DBNull.Value) ? Convert.ToInt32(row["MainOfficeID"]) : 0 ;
					tmpTaxOffice.BossNationalCode = (row["BossNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["BossNationalCode"]) : 0 ;
					tmpTaxOffice.ZipCode = row["ZipCode"].ToString();
					tmpTaxOffice.PhoneNumber = row["PhoneNumber"].ToString();

					listTaxOffice.Add(tmpTaxOffice);
				}
			}
		}

		return listTaxOffice;
	}

}
}
