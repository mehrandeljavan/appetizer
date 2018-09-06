using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class UttererRoleDBAccess
{

	UttererDBAccess uttererDBAccess = new UttererDBAccess();

	public List<Utterer> GetListUtterer(int uttererRoleID)
	{
		List<Utterer> listUtterer = new List<Utterer>() { };
		SqlParameter[] parametersUttererRole = new SqlParameter[]
		{
			new SqlParameter("@UttererRoleID", uttererRoleID)
		};

		//Lets get the list of Utterer records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Utterer_GetList_UseInUttererRole", CommandType.StoredProcedure, parametersUttererRole))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of utterer
				listUtterer = new List<Utterer>();

				//Now lets populate the Utterer details into the list of utterers
				foreach (DataRow row in table.Rows)
				{
					Utterer utterer = ConvertRowToUtterer(row);
					listUtterer.Add(utterer);
				}
			}
		}

		return listUtterer;
	}

	private Utterer ConvertRowToUtterer(DataRow row)
	{
		Utterer utterer = new Utterer();
		utterer.UttererID = (row["UttererID"] != DBNull.Value) ? Convert.ToInt64(row["UttererID"]) : 0 ;
		utterer.RegisterDate = row["RegisterDate"].ToString();
		utterer.UttererRoleIDTitle = row["UttererRoleIDTitle"].ToString();
		utterer.OldRegisterDate = row["OldRegisterDate"].ToString();
		utterer.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		utterer.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		utterer.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		utterer.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
		utterer.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		utterer.UttererRoleID = (row["UttererRoleID"] != DBNull.Value) ? Convert.ToInt32(row["UttererRoleID"]) : 0 ;
		utterer.AssertionOrder = (row["AssertionOrder"] != DBNull.Value) ? Convert.ToInt32(row["AssertionOrder"]) : 0 ;
		utterer.IsApplicant = (row["IsApplicant"] != DBNull.Value) ? Convert.ToBoolean((row["IsApplicant"].ToString() == "1" || row["IsApplicant"].ToString().ToLower() == "true" ) ? true : false) : false ;

		utterer.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		utterer.PrintNationalCode = row["PrintNationalCode"].ToString();
		utterer.FullName = row["FullName"].ToString();
		utterer.GenderIDTitle = row["GenderIDTitle"].ToString();
		utterer.Religion_DinIDTitle = row["Religion_DinIDTitle"].ToString();
		utterer.Religion_MazhabIDTitle = row["Religion_MazhabIDTitle"].ToString();
		utterer.IssuanceProvinceIDTitle = row["IssuanceProvinceIDTitle"].ToString();
		utterer.IssuanceCityIDTitle = row["IssuanceCityIDTitle"].ToString();
		utterer.IssuanceDepartment = row["IssuanceDepartment"].ToString();
		utterer.CertificateNumber = row["CertificateNumber"].ToString();
		utterer.CertificateSerial = row["CertificateSerial"].ToString();
		utterer.ZipCode = row["ZipCode"].ToString();
		utterer.HomeAddress = row["HomeAddress"].ToString();
		utterer.PhoneNumber = row["PhoneNumber"].ToString();
		utterer.Job = row["Job"].ToString();
		utterer.JobAddress = row["JobAddress"].ToString();
		utterer.JobPhoneNumber = row["JobPhoneNumber"].ToString();
		utterer.Comment = row["Comment"].ToString();
		utterer.BirthCity = row["BirthCity"].ToString();
		utterer.JobZipCode = row["JobZipCode"].ToString();
		utterer.CertificateSerialLetter = row["CertificateSerialLetter"].ToString();
		utterer.CertificateSerialNumber = row["CertificateSerialNumber"].ToString();
		utterer.FatherName = row["FatherName"].ToString();
		utterer.Name = row["Name"].ToString();
		utterer.Family = row["Family"].ToString();
		utterer.BirthDate = row["BirthDate"].ToString();
		utterer.IssuanceDate = row["IssuanceDate"].ToString();
		utterer.GenderID = (row["GenderID"] != DBNull.Value) ? Convert.ToInt32(row["GenderID"]) : 0 ;
		utterer.IssuanceProvinceID = (row["IssuanceProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceProvinceID"]) : 0 ;
		utterer.IssuanceCityID = (row["IssuanceCityID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceCityID"]) : 0 ;
		utterer.Religion_DinID = (row["Religion_DinID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_DinID"]) : 0 ;
		utterer.Religion_MazhabID = (row["Religion_MazhabID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_MazhabID"]) : 0 ;
		return utterer;
	}
	public Int64 Insert(UttererRole uttererRole)
	{
		SqlParameter[] parametersUttererRole = new SqlParameter[]
		{
			new SqlParameter("@Title", uttererRole.Title)
		};
		uttererRole.UttererRoleID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("UttererRole_Insert", CommandType.StoredProcedure, parametersUttererRole));
		return uttererRole.UttererRoleID;
	}

	public bool Update(UttererRole uttererRole)
	{
		SqlParameter[] parametersUttererRole = new SqlParameter[]
		{
			new SqlParameter("@UttererRoleID", uttererRole.UttererRoleID),
			new SqlParameter("@Title", uttererRole.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("UttererRole_Update", CommandType.StoredProcedure, parametersUttererRole);
	}

	public bool Delete(int uttererRoleID)
	{
		SqlParameter[] parametersUttererRole = new SqlParameter[]
		{
			new SqlParameter("@UttererRoleID", uttererRoleID)
		};
		return SqlDBHelper.ExecuteNonQuery("UttererRole_Delete", CommandType.StoredProcedure, parametersUttererRole);
	}

	public UttererRole GetDetails(int uttererRoleID)
	{
		UttererRole uttererRole = new UttererRole();

		SqlParameter[] parametersUttererRole = new SqlParameter[]
		{
			new SqlParameter("@UttererRoleID", uttererRoleID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UttererRole_GetDetails", CommandType.StoredProcedure, parametersUttererRole))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				uttererRole.UttererRoleID = (row["UttererRoleID"] != DBNull.Value) ? Convert.ToInt32(row["UttererRoleID"]) : 0 ;
				uttererRole.Title = row["Title"].ToString();
			}
		}

		return uttererRole;
	}

	public List<UttererRole> GetListAll()
	{
		List<UttererRole> listUttererRole = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("UttererRole_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listUttererRole = new List<UttererRole>();

				foreach (DataRow row in table.Rows)
				{
					UttererRole uttererRole = new UttererRole();
					uttererRole.UttererRoleID = (row["UttererRoleID"] != DBNull.Value) ? Convert.ToInt32(row["UttererRoleID"]) : 0 ;
					uttererRole.Title = row["Title"].ToString();
					listUttererRole.Add(uttererRole);
				}
			}
		}

		return listUttererRole;
	}

	public bool Exists(int uttererRoleID)
	{
		SqlParameter[] parametersUttererRole = new SqlParameter[]
		{
			new SqlParameter("@UttererRoleID", uttererRoleID)
		};
		return (SqlDBHelper.ExecuteScalar("UttererRole_Exists", CommandType.StoredProcedure, parametersUttererRole)>0);
	}

	public bool Exists(UttererRole uttererRole)
	{
		SqlParameter[] parametersUttererRole = new SqlParameter[]
		{
			new SqlParameter("@UttererRoleID", uttererRole.UttererRoleID)
		};
		return (SqlDBHelper.ExecuteScalar("UttererRole_Exists", CommandType.StoredProcedure, parametersUttererRole)>0);
	}

	public List<UttererRole> SearchLike(UttererRole uttererRole)
	{
		List<UttererRole> listUttererRole = new List<UttererRole>();


		SqlParameter[] parametersUttererRole = new SqlParameter[]
		{
			new SqlParameter("@UttererRoleID", uttererRole.UttererRoleID),
			new SqlParameter("@Title", uttererRole.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UttererRole_SearchLike", CommandType.StoredProcedure, parametersUttererRole))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					UttererRole tmpUttererRole = new UttererRole();
					tmpUttererRole.UttererRoleID = (row["UttererRoleID"] != DBNull.Value) ? Convert.ToInt32(row["UttererRoleID"]) : 0 ;
					tmpUttererRole.Title = row["Title"].ToString();

					listUttererRole.Add(tmpUttererRole);
				}
			}
		}

		return listUttererRole;
	}

}
}
