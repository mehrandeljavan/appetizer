using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class MartyrProfReferenceDBAccess
{

	DeadDBAccess deadDBAccess = new DeadDBAccess();

	public List<Dead> GetListDead(int martyrProfReferenceID)
	{
		List<Dead> listDead = new List<Dead>() { };
		SqlParameter[] parametersMartyrProfReference = new SqlParameter[]
		{
			new SqlParameter("@MartyrProfReferenceID", martyrProfReferenceID)
		};

		//Lets get the list of Dead records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Dead_GetList_UseInMartyrProfReference", CommandType.StoredProcedure, parametersMartyrProfReference))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of dead
				listDead = new List<Dead>();

				//Now lets populate the Dead details into the list of deads
				foreach (DataRow row in table.Rows)
				{
					Dead dead = ConvertRowToDead(row);
					listDead.Add(dead);
				}
			}
		}

		return listDead;
	}

	private Dead ConvertRowToDead(DataRow row)
	{
		Dead dead = new Dead();
		dead.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		dead.RegisterDate = row["RegisterDate"].ToString();
		dead.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		dead.OldRegisterDate = row["OldRegisterDate"].ToString();
		dead.DeathProvinceIDTitle = row["DeathProvinceIDTitle"].ToString();
		dead.DeathCityIDTitle = row["DeathCityIDTitle"].ToString();
		dead.MartyrProfReferenceIDTitle = row["MartyrProfReferenceIDTitle"].ToString();
		dead.NationalityIDTitle = row["NationalityIDTitle"].ToString();
		dead.ResidenceIDTitle = row["ResidenceIDTitle"].ToString();
		dead.MartyrProfDescription = row["MartyrProfDescription"].ToString();
		dead.UniqeCode = row["UniqeCode"].ToString();
		dead.ProbateIssuedCity = row["ProbateIssuedCity"].ToString();
		dead.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
		dead.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		dead.ProbateDocNumber = row["ProbateDocNumber"].ToString();
		dead.ProbateIssued = row["ProbateIssued"].ToString();
		dead.DeathDate = row["DeathDate"].ToString();
		dead.ProbateDate = row["ProbateDate"].ToString();
		dead.DeathProvinceID = (row["DeathProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["DeathProvinceID"]) : 0 ;
		dead.DeathCityID = (row["DeathCityID"] != DBNull.Value) ? Convert.ToInt32(row["DeathCityID"]) : 0 ;
		dead.MartyrProfReferenceID = (row["MartyrProfReferenceID"] != DBNull.Value) ? Convert.ToInt32(row["MartyrProfReferenceID"]) : 0 ;
		dead.NationalityID = (row["NationalityID"] != DBNull.Value) ? Convert.ToInt32(row["NationalityID"]) : 0 ;
		dead.ResidenceID = (row["ResidenceID"] != DBNull.Value) ? Convert.ToInt32(row["ResidenceID"]) : 0 ;
		dead.IsMartyr = (row["IsMartyr"] != DBNull.Value) ? Convert.ToBoolean((row["IsMartyr"].ToString() == "1" || row["IsMartyr"].ToString().ToLower() == "true" ) ? true : false) : false ;

		dead.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		dead.PrintNationalCode = row["PrintNationalCode"].ToString();
		dead.FullName = row["FullName"].ToString();
		dead.GenderIDTitle = row["GenderIDTitle"].ToString();
		dead.Religion_DinIDTitle = row["Religion_DinIDTitle"].ToString();
		dead.Religion_MazhabIDTitle = row["Religion_MazhabIDTitle"].ToString();
		dead.IssuanceProvinceIDTitle = row["IssuanceProvinceIDTitle"].ToString();
		dead.IssuanceCityIDTitle = row["IssuanceCityIDTitle"].ToString();
		dead.IssuanceDepartment = row["IssuanceDepartment"].ToString();
		dead.CertificateNumber = row["CertificateNumber"].ToString();
		dead.CertificateSerial = row["CertificateSerial"].ToString();
		dead.ZipCode = row["ZipCode"].ToString();
		dead.HomeAddress = row["HomeAddress"].ToString();
		dead.PhoneNumber = row["PhoneNumber"].ToString();
		dead.Job = row["Job"].ToString();
		dead.JobAddress = row["JobAddress"].ToString();
		dead.JobPhoneNumber = row["JobPhoneNumber"].ToString();
		dead.Comment = row["Comment"].ToString();
		dead.BirthCity = row["BirthCity"].ToString();
		dead.JobZipCode = row["JobZipCode"].ToString();
		dead.CertificateSerialLetter = row["CertificateSerialLetter"].ToString();
		dead.CertificateSerialNumber = row["CertificateSerialNumber"].ToString();
		dead.FatherName = row["FatherName"].ToString();
		dead.Name = row["Name"].ToString();
		dead.Family = row["Family"].ToString();
		dead.BirthDate = row["BirthDate"].ToString();
		dead.IssuanceDate = row["IssuanceDate"].ToString();
		dead.GenderID = (row["GenderID"] != DBNull.Value) ? Convert.ToInt32(row["GenderID"]) : 0 ;
		dead.IssuanceProvinceID = (row["IssuanceProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceProvinceID"]) : 0 ;
		dead.IssuanceCityID = (row["IssuanceCityID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceCityID"]) : 0 ;
		dead.Religion_DinID = (row["Religion_DinID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_DinID"]) : 0 ;
		dead.Religion_MazhabID = (row["Religion_MazhabID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_MazhabID"]) : 0 ;
		return dead;
	}
	public Int64 Insert(MartyrProfReference martyrProfReference)
	{
		SqlParameter[] parametersMartyrProfReference = new SqlParameter[]
		{
			new SqlParameter("@Title", martyrProfReference.Title)
		};
		martyrProfReference.MartyrProfReferenceID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("MartyrProfReference_Insert", CommandType.StoredProcedure, parametersMartyrProfReference));
		return martyrProfReference.MartyrProfReferenceID;
	}

	public bool Update(MartyrProfReference martyrProfReference)
	{
		SqlParameter[] parametersMartyrProfReference = new SqlParameter[]
		{
			new SqlParameter("@MartyrProfReferenceID", martyrProfReference.MartyrProfReferenceID),
			new SqlParameter("@Title", martyrProfReference.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("MartyrProfReference_Update", CommandType.StoredProcedure, parametersMartyrProfReference);
	}

	public bool Delete(int martyrProfReferenceID)
	{
		SqlParameter[] parametersMartyrProfReference = new SqlParameter[]
		{
			new SqlParameter("@MartyrProfReferenceID", martyrProfReferenceID)
		};
		return SqlDBHelper.ExecuteNonQuery("MartyrProfReference_Delete", CommandType.StoredProcedure, parametersMartyrProfReference);
	}

	public MartyrProfReference GetDetails(int martyrProfReferenceID)
	{
		MartyrProfReference martyrProfReference = new MartyrProfReference();

		SqlParameter[] parametersMartyrProfReference = new SqlParameter[]
		{
			new SqlParameter("@MartyrProfReferenceID", martyrProfReferenceID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("MartyrProfReference_GetDetails", CommandType.StoredProcedure, parametersMartyrProfReference))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				martyrProfReference.MartyrProfReferenceID = (row["MartyrProfReferenceID"] != DBNull.Value) ? Convert.ToInt32(row["MartyrProfReferenceID"]) : 0 ;
				martyrProfReference.Title = row["Title"].ToString();
			}
		}

		return martyrProfReference;
	}

	public List<MartyrProfReference> GetListAll()
	{
		List<MartyrProfReference> listMartyrProfReference = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("MartyrProfReference_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listMartyrProfReference = new List<MartyrProfReference>();

				foreach (DataRow row in table.Rows)
				{
					MartyrProfReference martyrProfReference = new MartyrProfReference();
					martyrProfReference.MartyrProfReferenceID = (row["MartyrProfReferenceID"] != DBNull.Value) ? Convert.ToInt32(row["MartyrProfReferenceID"]) : 0 ;
					martyrProfReference.Title = row["Title"].ToString();
					listMartyrProfReference.Add(martyrProfReference);
				}
			}
		}

		return listMartyrProfReference;
	}

	public bool Exists(int martyrProfReferenceID)
	{
		SqlParameter[] parametersMartyrProfReference = new SqlParameter[]
		{
			new SqlParameter("@MartyrProfReferenceID", martyrProfReferenceID)
		};
		return (SqlDBHelper.ExecuteScalar("MartyrProfReference_Exists", CommandType.StoredProcedure, parametersMartyrProfReference)>0);
	}

	public bool Exists(MartyrProfReference martyrProfReference)
	{
		SqlParameter[] parametersMartyrProfReference = new SqlParameter[]
		{
			new SqlParameter("@MartyrProfReferenceID", martyrProfReference.MartyrProfReferenceID)
		};
		return (SqlDBHelper.ExecuteScalar("MartyrProfReference_Exists", CommandType.StoredProcedure, parametersMartyrProfReference)>0);
	}

	public List<MartyrProfReference> SearchLike(MartyrProfReference martyrProfReference)
	{
		List<MartyrProfReference> listMartyrProfReference = new List<MartyrProfReference>();


		SqlParameter[] parametersMartyrProfReference = new SqlParameter[]
		{
			new SqlParameter("@MartyrProfReferenceID", martyrProfReference.MartyrProfReferenceID),
			new SqlParameter("@Title", martyrProfReference.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("MartyrProfReference_SearchLike", CommandType.StoredProcedure, parametersMartyrProfReference))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					MartyrProfReference tmpMartyrProfReference = new MartyrProfReference();
					tmpMartyrProfReference.MartyrProfReferenceID = (row["MartyrProfReferenceID"] != DBNull.Value) ? Convert.ToInt32(row["MartyrProfReferenceID"]) : 0 ;
					tmpMartyrProfReference.Title = row["Title"].ToString();

					listMartyrProfReference.Add(tmpMartyrProfReference);
				}
			}
		}

		return listMartyrProfReference;
	}

}
}
