using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class RequestTypeDBAccess
{

	ApplicantDBAccess applicantDBAccess = new ApplicantDBAccess();

	public List<Applicant> GetListApplicant(int requestTypeID)
	{
		List<Applicant> listApplicant = new List<Applicant>() { };
		SqlParameter[] parametersRequestType = new SqlParameter[]
		{
			new SqlParameter("@RequestTypeID", requestTypeID)
		};

		//Lets get the list of Applicant records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Applicant_GetList_UseInRequestType", CommandType.StoredProcedure, parametersRequestType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of applicant
				listApplicant = new List<Applicant>();

				//Now lets populate the Applicant details into the list of applicants
				foreach (DataRow row in table.Rows)
				{
					Applicant applicant = ConvertRowToApplicant(row);
					listApplicant.Add(applicant);
				}
			}
		}

		return listApplicant;
	}

	private Applicant ConvertRowToApplicant(DataRow row)
	{
		Applicant applicant = new Applicant();
		applicant.ApplicantID = (row["ApplicantID"] != DBNull.Value) ? Convert.ToInt64(row["ApplicantID"]) : 0 ;
		applicant.ApplicantRoleIDTitle = row["ApplicantRoleIDTitle"].ToString();
		applicant.RequestTypeIDTitle = row["RequestTypeIDTitle"].ToString();
		applicant.RegisterDate = row["RegisterDate"].ToString();
		applicant.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		applicant.OldRegisterDate = row["OldRegisterDate"].ToString();
		applicant.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		applicant.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		applicant.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		applicant.ApplicantRoleID = (row["ApplicantRoleID"] != DBNull.Value) ? Convert.ToInt32(row["ApplicantRoleID"]) : 0 ;
		applicant.RequestTypeID = (row["RequestTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RequestTypeID"]) : 0 ;

		applicant.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		applicant.PrintNationalCode = row["PrintNationalCode"].ToString();
		applicant.FullName = row["FullName"].ToString();
		applicant.GenderIDTitle = row["GenderIDTitle"].ToString();
		applicant.Religion_DinIDTitle = row["Religion_DinIDTitle"].ToString();
		applicant.Religion_MazhabIDTitle = row["Religion_MazhabIDTitle"].ToString();
		applicant.IssuanceProvinceIDTitle = row["IssuanceProvinceIDTitle"].ToString();
		applicant.IssuanceCityIDTitle = row["IssuanceCityIDTitle"].ToString();
		applicant.IssuanceDepartment = row["IssuanceDepartment"].ToString();
		applicant.CertificateNumber = row["CertificateNumber"].ToString();
		applicant.CertificateSerial = row["CertificateSerial"].ToString();
		applicant.ZipCode = row["ZipCode"].ToString();
		applicant.HomeAddress = row["HomeAddress"].ToString();
		applicant.PhoneNumber = row["PhoneNumber"].ToString();
		applicant.Job = row["Job"].ToString();
		applicant.JobAddress = row["JobAddress"].ToString();
		applicant.JobPhoneNumber = row["JobPhoneNumber"].ToString();
		applicant.Comment = row["Comment"].ToString();
		applicant.BirthCity = row["BirthCity"].ToString();
		applicant.JobZipCode = row["JobZipCode"].ToString();
		applicant.CertificateSerialLetter = row["CertificateSerialLetter"].ToString();
		applicant.CertificateSerialNumber = row["CertificateSerialNumber"].ToString();
		applicant.FatherName = row["FatherName"].ToString();
		applicant.Name = row["Name"].ToString();
		applicant.Family = row["Family"].ToString();
		applicant.BirthDate = row["BirthDate"].ToString();
		applicant.IssuanceDate = row["IssuanceDate"].ToString();
		applicant.GenderID = (row["GenderID"] != DBNull.Value) ? Convert.ToInt32(row["GenderID"]) : 0 ;
		applicant.IssuanceProvinceID = (row["IssuanceProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceProvinceID"]) : 0 ;
		applicant.IssuanceCityID = (row["IssuanceCityID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceCityID"]) : 0 ;
		applicant.Religion_DinID = (row["Religion_DinID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_DinID"]) : 0 ;
		applicant.Religion_MazhabID = (row["Religion_MazhabID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_MazhabID"]) : 0 ;
		return applicant;
	}
	public Int64 Insert(RequestType requestType)
	{
		SqlParameter[] parametersRequestType = new SqlParameter[]
		{
			new SqlParameter("@CodeForRegisterInformation", (requestType.CodeForRegisterInformation != null) ? requestType.CodeForRegisterInformation : (object)DBNull.Value),
			new SqlParameter("@OrderNumber", (requestType.OrderNumber != null) ? requestType.OrderNumber : (object)DBNull.Value),
			new SqlParameter("@NewLaw", (requestType.NewLaw != null) ? requestType.NewLaw : (object)DBNull.Value),
			new SqlParameter("@Title", requestType.Title)
		};
		requestType.RequestTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("RequestType_Insert", CommandType.StoredProcedure, parametersRequestType));
		return requestType.RequestTypeID;
	}

	public bool Update(RequestType requestType)
	{
		SqlParameter[] parametersRequestType = new SqlParameter[]
		{
			new SqlParameter("@RequestTypeID", requestType.RequestTypeID),
			new SqlParameter("@CodeForRegisterInformation", (requestType.CodeForRegisterInformation != null) ? requestType.CodeForRegisterInformation : (object)DBNull.Value),
			new SqlParameter("@OrderNumber", (requestType.OrderNumber != null) ? requestType.OrderNumber : (object)DBNull.Value),
			new SqlParameter("@NewLaw", (requestType.NewLaw != null) ? requestType.NewLaw : (object)DBNull.Value),
			new SqlParameter("@Title", requestType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("RequestType_Update", CommandType.StoredProcedure, parametersRequestType);
	}

	public bool Delete(int requestTypeID)
	{
		SqlParameter[] parametersRequestType = new SqlParameter[]
		{
			new SqlParameter("@RequestTypeID", requestTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("RequestType_Delete", CommandType.StoredProcedure, parametersRequestType);
	}

	public RequestType GetDetails(int requestTypeID)
	{
		RequestType requestType = new RequestType();

		SqlParameter[] parametersRequestType = new SqlParameter[]
		{
			new SqlParameter("@RequestTypeID", requestTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RequestType_GetDetails", CommandType.StoredProcedure, parametersRequestType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				requestType.RequestTypeID = (row["RequestTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RequestTypeID"]) : 0 ;
				requestType.CodeForRegisterInformation = (row["CodeForRegisterInformation"] != DBNull.Value) ? Convert.ToInt32(row["CodeForRegisterInformation"]) : 0 ;
				requestType.OrderNumber = (row["OrderNumber"] != DBNull.Value) ? Convert.ToInt32(row["OrderNumber"]) : 0 ;
				requestType.NewLaw = (row["NewLaw"] != DBNull.Value) ? Convert.ToBoolean((row["NewLaw"].ToString() == "1" || row["NewLaw"].ToString().ToLower() == "true" ) ? true : false) : false ;
				requestType.Title = row["Title"].ToString();
			}
		}

		return requestType;
	}

	public List<RequestType> GetListAll()
	{
		List<RequestType> listRequestType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("RequestType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listRequestType = new List<RequestType>();

				foreach (DataRow row in table.Rows)
				{
					RequestType requestType = new RequestType();
					requestType.RequestTypeID = (row["RequestTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RequestTypeID"]) : 0 ;
					requestType.CodeForRegisterInformation = (row["CodeForRegisterInformation"] != DBNull.Value) ? Convert.ToInt32(row["CodeForRegisterInformation"]) : 0 ;
					requestType.OrderNumber = (row["OrderNumber"] != DBNull.Value) ? Convert.ToInt32(row["OrderNumber"]) : 0 ;
				requestType.NewLaw = (row["NewLaw"] != DBNull.Value) ? Convert.ToBoolean((row["NewLaw"].ToString() == "1" || row["NewLaw"].ToString().ToLower() == "true" ) ? true : false) : false ;
					requestType.Title = row["Title"].ToString();
					listRequestType.Add(requestType);
				}
			}
		}

		return listRequestType;
	}

	public bool Exists(int requestTypeID)
	{
		SqlParameter[] parametersRequestType = new SqlParameter[]
		{
			new SqlParameter("@RequestTypeID", requestTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("RequestType_Exists", CommandType.StoredProcedure, parametersRequestType)>0);
	}

	public bool Exists(RequestType requestType)
	{
		SqlParameter[] parametersRequestType = new SqlParameter[]
		{
			new SqlParameter("@RequestTypeID", requestType.RequestTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("RequestType_Exists", CommandType.StoredProcedure, parametersRequestType)>0);
	}

	public List<RequestType> SearchLike(RequestType requestType)
	{
		List<RequestType> listRequestType = new List<RequestType>();


		SqlParameter[] parametersRequestType = new SqlParameter[]
		{
			new SqlParameter("@RequestTypeID", requestType.RequestTypeID),
			new SqlParameter("@CodeForRegisterInformation", requestType.CodeForRegisterInformation),
			new SqlParameter("@OrderNumber", requestType.OrderNumber),
			new SqlParameter("@NewLaw", requestType.NewLaw),
			new SqlParameter("@Title", requestType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RequestType_SearchLike", CommandType.StoredProcedure, parametersRequestType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					RequestType tmpRequestType = new RequestType();
					tmpRequestType.RequestTypeID = (row["RequestTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RequestTypeID"]) : 0 ;
					tmpRequestType.CodeForRegisterInformation = (row["CodeForRegisterInformation"] != DBNull.Value) ? Convert.ToInt32(row["CodeForRegisterInformation"]) : 0 ;
					tmpRequestType.OrderNumber = (row["OrderNumber"] != DBNull.Value) ? Convert.ToInt32(row["OrderNumber"]) : 0 ;
					tmpRequestType.NewLaw = (row["NewLaw"] != DBNull.Value) ? Convert.ToBoolean((row["NewLaw"].ToString() == "1" || row["NewLaw"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpRequestType.Title = row["Title"].ToString();

					listRequestType.Add(tmpRequestType);
				}
			}
		}

		return listRequestType;
	}

}
}
