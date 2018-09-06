using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class DossierDBAccess
{

	DeadDBAccess deadDBAccess = new DeadDBAccess();
	DeclarationDBAccess declarationDBAccess = new DeclarationDBAccess();
	DossierCartableDBAccess dossierCartableDBAccess = new DossierCartableDBAccess();
	PaymentDBAccess paymentDBAccess = new PaymentDBAccess();
	PhysicalDossierDeliveryDBAccess physicalDossierDeliveryDBAccess = new PhysicalDossierDeliveryDBAccess();
	ReportsDBAccess reportsDBAccess = new ReportsDBAccess();
	UserDossierDBAccess userDossierDBAccess = new UserDossierDBAccess();
	UttererDBAccess uttererDBAccess = new UttererDBAccess();

	public List<Dead> GetListDead(Int64 dossierID)
	{
		List<Dead> listDead = new List<Dead>() { };
		SqlParameter[] parametersDossier = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossierID)
		};

		//Lets get the list of Dead records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Dead_GetList_UseInDossier", CommandType.StoredProcedure, parametersDossier))
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
	public List<Declaration> GetListDeclaration(Int64 dossierID)
	{
		List<Declaration> listDeclaration = new List<Declaration>() { };
		SqlParameter[] parametersDossier = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossierID)
		};

		//Lets get the list of Declaration records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Declaration_GetList_UseInDossier", CommandType.StoredProcedure, parametersDossier))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of declaration
				listDeclaration = new List<Declaration>();

				//Now lets populate the Declaration details into the list of declarations
				foreach (DataRow row in table.Rows)
				{
					Declaration declaration = ConvertRowToDeclaration(row);
					listDeclaration.Add(declaration);
				}
			}
		}

		return listDeclaration;
	}

	private Declaration ConvertRowToDeclaration(DataRow row)
	{
		Declaration declaration = new Declaration();
		declaration.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		declaration.StageTitle = row["StageTitle"].ToString();
		declaration.DeclarationTypeIDTitle = row["DeclarationTypeIDTitle"].ToString();
		declaration.FinalizerUserNationalCode1FullName = row["FinalizerUserNationalCode1FullName"].ToString();
		declaration.FinalizerUserNationalCode2FullName = row["FinalizerUserNationalCode2FullName"].ToString();
		declaration.DiagnosisFinalizerUserNationalCode1FullName = row["DiagnosisFinalizerUserNationalCode1FullName"].ToString();
		declaration.DiagnosisFinalizerUserNationalCode2FullName = row["DiagnosisFinalizerUserNationalCode2FullName"].ToString();
		declaration.PrintRegisterDate = row["PrintRegisterDate"].ToString();
		declaration.RegisterDate = row["RegisterDate"].ToString();
		declaration.RegisterInformationDate = row["RegisterInformationDate"].ToString();
		declaration.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		declaration.OldRegisterDate = row["OldRegisterDate"].ToString();
		declaration.PrintRegisterInformationID = row["PrintRegisterInformationID"].ToString();
		declaration.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		declaration.DeclarationTypeID = (row["DeclarationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DeclarationTypeID"]) : 0 ;
		declaration.AutomaticShareCalculation1 = (row["AutomaticShareCalculation1"] != DBNull.Value) ? Convert.ToBoolean((row["AutomaticShareCalculation1"].ToString() == "1" || row["AutomaticShareCalculation1"].ToString().ToLower() == "true" ) ? true : false) : false ;
		declaration.AutomaticShareCalculation2 = (row["AutomaticShareCalculation2"] != DBNull.Value) ? Convert.ToBoolean((row["AutomaticShareCalculation2"].ToString() == "1" || row["AutomaticShareCalculation2"].ToString().ToLower() == "true" ) ? true : false) : false ;
		declaration.RequestResource = row["RequestResource"].ToString();
		declaration.RequestNumber = row["RequestNumber"].ToString();
		declaration.DeclarationTitle = row["DeclarationTitle"].ToString();
		declaration.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
		declaration.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		declaration.WillID = (row["WillID"] != DBNull.Value) ? Convert.ToInt64(row["WillID"]) : 0 ;
		declaration.FinalizerUserNationalCode1 = (row["FinalizerUserNationalCode1"] != DBNull.Value) ? Convert.ToInt64(row["FinalizerUserNationalCode1"]) : 0 ;
		declaration.FinalizerUserNationalCode2 = (row["FinalizerUserNationalCode2"] != DBNull.Value) ? Convert.ToInt64(row["FinalizerUserNationalCode2"]) : 0 ;
		declaration.DiagnosisFinalizerUserNationalCode1 = (row["DiagnosisFinalizerUserNationalCode1"] != DBNull.Value) ? Convert.ToInt64(row["DiagnosisFinalizerUserNationalCode1"]) : 0 ;
		declaration.DiagnosisFinalizerUserNationalCode2 = (row["DiagnosisFinalizerUserNationalCode2"] != DBNull.Value) ? Convert.ToInt64(row["DiagnosisFinalizerUserNationalCode2"]) : 0 ;
		declaration.DiagnosisRegisterInformationID = (row["DiagnosisRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["DiagnosisRegisterInformationID"]) : 0 ;
		declaration.DeclarationRegisterNumberInCentral = row["DeclarationRegisterNumberInCentral"].ToString();
		declaration.FinalDate1 = row["FinalDate1"].ToString();
		declaration.FinalDate2 = row["FinalDate2"].ToString();
		declaration.FinalDateDiagnosis1 = row["FinalDateDiagnosis1"].ToString();
		declaration.FinalDateDiagnosis2 = row["FinalDateDiagnosis2"].ToString();
		declaration.FinalDateAdjustment = row["FinalDateAdjustment"].ToString();
		declaration.FinalDateCommisionAdjustment = row["FinalDateCommisionAdjustment"].ToString();
		declaration.DeliveryDate = row["DeliveryDate"].ToString();
		declaration.DeclarationRegisterDateInCentral = row["DeclarationRegisterDateInCentral"].ToString();
		declaration.RequestDate = row["RequestDate"].ToString();
		declaration.DiagnosisRegisterDate = row["DiagnosisRegisterDate"].ToString();
		return declaration;
	}
	public List<DossierCartable> GetListDossierCartable(Int64 dossierID)
	{
		List<DossierCartable> listDossierCartable = new List<DossierCartable>() { };
		SqlParameter[] parametersDossier = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossierID)
		};

		//Lets get the list of DossierCartable records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DossierCartable_GetList_UseInDossier", CommandType.StoredProcedure, parametersDossier))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of dossierCartable
				listDossierCartable = new List<DossierCartable>();

				//Now lets populate the DossierCartable details into the list of dossierCartables
				foreach (DataRow row in table.Rows)
				{
					DossierCartable dossierCartable = ConvertRowToDossierCartable(row);
					listDossierCartable.Add(dossierCartable);
				}
			}
		}

		return listDossierCartable;
	}

	private DossierCartable ConvertRowToDossierCartable(DataRow row)
	{
		DossierCartable dossierCartable = new DossierCartable();
		dossierCartable.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
		dossierCartable.OldClasses = row["OldClasses"].ToString();
		dossierCartable.FromTaxOffice = (row["FromTaxOffice"] != DBNull.Value) ? Convert.ToInt32(row["FromTaxOffice"]) : 0 ;
		dossierCartable.ToTaxOffice = (row["ToTaxOffice"] != DBNull.Value) ? Convert.ToInt32(row["ToTaxOffice"]) : 0 ;
		dossierCartable.OldTaxUnitCode = (row["OldTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["OldTaxUnitCode"]) : 0 ;
		dossierCartable.OldOrderNumber = (row["OldOrderNumber"] != DBNull.Value) ? Convert.ToInt64(row["OldOrderNumber"]) : 0 ;
		dossierCartable.SendDate = row["SendDate"].ToString();
		dossierCartable.ReciveDate = row["ReciveDate"].ToString();
		return dossierCartable;
	}
	public List<Payment> GetListPayment(Int64 dossierID)
	{
		List<Payment> listPayment = new List<Payment>() { };
		SqlParameter[] parametersDossier = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossierID)
		};

		//Lets get the list of Payment records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Payment_GetList_UseInDossier", CommandType.StoredProcedure, parametersDossier))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of payment
				listPayment = new List<Payment>();

				//Now lets populate the Payment details into the list of payments
				foreach (DataRow row in table.Rows)
				{
					Payment payment = ConvertRowToPayment(row);
					listPayment.Add(payment);
				}
			}
		}

		return listPayment;
	}

	private Payment ConvertRowToPayment(DataRow row)
	{
		Payment payment = new Payment();
		payment.PaymentID = (row["PaymentID"] != DBNull.Value) ? Convert.ToInt64(row["PaymentID"]) : 0 ;
		payment.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
		payment.PaymentValue = (row["PaymentValue"] != DBNull.Value) ? Convert.ToInt64(row["PaymentValue"]) : 0 ;
		payment.PaymentDate = row["PaymentDate"].ToString();
		payment.Number = row["Number"].ToString();
		payment.Comment = row["Comment"].ToString();
		return payment;
	}
	public List<PhysicalDossierDelivery> GetListPhysicalDossierDelivery(Int64 dossierID)
	{
		List<PhysicalDossierDelivery> listPhysicalDossierDelivery = new List<PhysicalDossierDelivery>() { };
		SqlParameter[] parametersDossier = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossierID)
		};

		//Lets get the list of PhysicalDossierDelivery records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("PhysicalDossierDelivery_GetList_UseInDossier", CommandType.StoredProcedure, parametersDossier))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of physicalDossierDelivery
				listPhysicalDossierDelivery = new List<PhysicalDossierDelivery>();

				//Now lets populate the PhysicalDossierDelivery details into the list of physicalDossierDeliverys
				foreach (DataRow row in table.Rows)
				{
					PhysicalDossierDelivery physicalDossierDelivery = ConvertRowToPhysicalDossierDelivery(row);
					listPhysicalDossierDelivery.Add(physicalDossierDelivery);
				}
			}
		}

		return listPhysicalDossierDelivery;
	}

	private PhysicalDossierDelivery ConvertRowToPhysicalDossierDelivery(DataRow row)
	{
		PhysicalDossierDelivery physicalDossierDelivery = new PhysicalDossierDelivery();
		physicalDossierDelivery.PhysicalDossierDeliveryID = (row["PhysicalDossierDeliveryID"] != DBNull.Value) ? Convert.ToInt64(row["PhysicalDossierDeliveryID"]) : 0 ;
		physicalDossierDelivery.FromUserFullName = row["FromUserFullName"].ToString();
		physicalDossierDelivery.ToUserFullName = row["ToUserFullName"].ToString();
		physicalDossierDelivery.DeliveryTypeIDTitle = row["DeliveryTypeIDTitle"].ToString();
		physicalDossierDelivery.DeliveryTypeID = (row["DeliveryTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DeliveryTypeID"]) : 0 ;
		physicalDossierDelivery.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
		physicalDossierDelivery.FromUserNationalCode = (row["FromUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FromUserNationalCode"]) : 0 ;
		physicalDossierDelivery.ToUserNationalCode = (row["ToUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["ToUserNationalCode"]) : 0 ;
		physicalDossierDelivery.DeliveryDate = row["DeliveryDate"].ToString();
		physicalDossierDelivery.DeliveryTime = row["DeliveryTime"].ToString();
		physicalDossierDelivery.Description = row["Description"].ToString();
		return physicalDossierDelivery;
	}
	public List<Reports> GetListReports(Int64 dossierID)
	{
		List<Reports> listReports = new List<Reports>() { };
		SqlParameter[] parametersDossier = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossierID)
		};

		//Lets get the list of Reports records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Reports_GetList_UseInDossier", CommandType.StoredProcedure, parametersDossier))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of reports
				listReports = new List<Reports>();

				//Now lets populate the Reports details into the list of reportss
				foreach (DataRow row in table.Rows)
				{
					Reports reports = ConvertRowToReports(row);
					listReports.Add(reports);
				}
			}
		}

		return listReports;
	}

	private Reports ConvertRowToReports(DataRow row)
	{
		Reports reports = new Reports();
		reports.ReportsID = (row["ReportsID"] != DBNull.Value) ? Convert.ToInt64(row["ReportsID"]) : 0 ;
		reports.ReportTypeIDTitle = row["ReportTypeIDTitle"].ToString();
		reports.OldRegisterDate = row["OldRegisterDate"].ToString();
		reports.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		reports.ReportTypeID = (row["ReportTypeID"] != DBNull.Value) ? Convert.ToInt32(row["ReportTypeID"]) : 0 ;
		reports.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		reports.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
		reports.ReportDate = row["ReportDate"].ToString();
		reports.Body = row["Body"].ToString();
		return reports;
	}
	public List<UserDossier> GetListUserDossier(Int64 dossierID)
	{
		List<UserDossier> listUserDossier = new List<UserDossier>() { };
		SqlParameter[] parametersDossier = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossierID)
		};

		//Lets get the list of UserDossier records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("UserDossier_GetList_UseInDossier", CommandType.StoredProcedure, parametersDossier))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of userDossier
				listUserDossier = new List<UserDossier>();

				//Now lets populate the UserDossier details into the list of userDossiers
				foreach (DataRow row in table.Rows)
				{
					UserDossier userDossier = ConvertRowToUserDossier(row);
					listUserDossier.Add(userDossier);
				}
			}
		}

		return listUserDossier;
	}

	private UserDossier ConvertRowToUserDossier(DataRow row)
	{
		UserDossier userDossier = new UserDossier();
		userDossier.UserNationalCode = (row["UserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["UserNationalCode"]) : 0 ;
		userDossier.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
		userDossier.UserFullName = row["UserFullName"].ToString();
		userDossier.ReferrerUserNationalCode = (row["ReferrerUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["ReferrerUserNationalCode"]) : 0 ;
		userDossier.StartDate = row["StartDate"].ToString();
		userDossier.EndDate = row["EndDate"].ToString();
		userDossier.ReferenceDate = row["ReferenceDate"].ToString();
		return userDossier;
	}
	public List<Utterer> GetListUtterer(Int64 dossierID)
	{
		List<Utterer> listUtterer = new List<Utterer>() { };
		SqlParameter[] parametersDossier = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossierID)
		};

		//Lets get the list of Utterer records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Utterer_GetList_UseInDossier", CommandType.StoredProcedure, parametersDossier))
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
	public Int64 Insert(Dossier dossier)
	{
		SqlParameter[] parametersDossier = new SqlParameter[]
		{
			new SqlParameter("@OrderNumber", dossier.OrderNumber),
			new SqlParameter("@OldClasses", (dossier.OldClasses != null) ? dossier.OldClasses : (object)DBNull.Value),
			new SqlParameter("@TaxOfficeCode", (dossier.TaxOfficeCode > 0) ? dossier.TaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@IsActive", dossier.IsActive)
		};
		dossier.DossierID = SqlDBHelper.ExecuteScalar("Dossier_Insert", CommandType.StoredProcedure, parametersDossier);
		return dossier.DossierID;
	}

	public bool Update(Dossier dossier)
	{
		SqlParameter[] parametersDossier = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossier.DossierID),
			new SqlParameter("@OrderNumber", dossier.OrderNumber),
			new SqlParameter("@OldClasses", (dossier.OldClasses != null) ? dossier.OldClasses : (object)DBNull.Value),
			new SqlParameter("@TaxOfficeCode", (dossier.TaxOfficeCode != null && dossier.TaxOfficeCode >0 ) ? dossier.TaxOfficeCode : (object)DBNull.Value),
			new SqlParameter("@IsActive", dossier.IsActive)
		};
		return SqlDBHelper.ExecuteNonQuery("Dossier_Update", CommandType.StoredProcedure, parametersDossier);
	}

	public bool Delete(Int64 dossierID)
	{
		SqlParameter[] parametersDossier = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossierID)
		};
		return SqlDBHelper.ExecuteNonQuery("Dossier_Delete", CommandType.StoredProcedure, parametersDossier);
	}

	public bool Delete(int taxOfficeCode)
	{
		SqlParameter[] parametersDossier = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeCode", taxOfficeCode)
		};
		return SqlDBHelper.ExecuteNonQuery("Dossier_DeleteBy_TaxOfficeCode", CommandType.StoredProcedure, parametersDossier);

	}

	public Dossier GetDetails(Int64 dossierID)
	{
		Dossier dossier = new Dossier();

		SqlParameter[] parametersDossier = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossierID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Dossier_GetDetails", CommandType.StoredProcedure, parametersDossier))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				dossier.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
				dossier.Classes = row["Classes"].ToString();
				dossier.TaxOfficeCodeTitle = row["TaxOfficeCodeTitle"].ToString();
				dossier.TaxOfficeCityIDTitle = row["TaxOfficeCityIDTitle"].ToString();
				dossier.OrderNumber = (row["OrderNumber"] != DBNull.Value) ? Convert.ToInt64(row["OrderNumber"]) : 0 ;
				dossier.OldClasses = row["OldClasses"].ToString();
				dossier.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
				dossier.IsActive = (row["IsActive"] != DBNull.Value) ? Convert.ToBoolean((row["IsActive"].ToString() == "1" || row["IsActive"].ToString().ToLower() == "true" ) ? true : false) : false ;
			}
		}

		return dossier;
	}

	public Dossier GetDetails(int taxOfficeCode)
	{
		Dossier dossier = new Dossier();

		SqlParameter[] parametersDossier = new SqlParameter[]
		{
			new SqlParameter("@TaxOfficeCode", taxOfficeCode)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Dossier_GetDetailsBy_TaxOfficeCode", CommandType.StoredProcedure, parametersDossier))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				dossier.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
				dossier.Classes = row["Classes"].ToString();
				dossier.TaxOfficeCodeTitle = row["TaxOfficeCodeTitle"].ToString();
				dossier.TaxOfficeCityIDTitle = row["TaxOfficeCityIDTitle"].ToString();
				dossier.OrderNumber = (row["OrderNumber"] != DBNull.Value) ? Convert.ToInt64(row["OrderNumber"]) : 0 ;
				dossier.OldClasses = row["OldClasses"].ToString();
				dossier.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
				dossier.IsActive = (row["IsActive"] != DBNull.Value) ? Convert.ToBoolean((row["IsActive"].ToString() == "1" || row["IsActive"].ToString().ToLower() == "true" ) ? true : false) : false ;
			}
		}

		return dossier;
	}

	public List<Dossier> GetListAll()
	{
		List<Dossier> listDossier = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Dossier_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listDossier = new List<Dossier>();

				foreach (DataRow row in table.Rows)
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
					listDossier.Add(dossier);
				}
			}
		}

		return listDossier;
	}

	public bool Exists(Int64 dossierID)
	{
		SqlParameter[] parametersDossier = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossierID)
		};
		return (SqlDBHelper.ExecuteScalar("Dossier_Exists", CommandType.StoredProcedure, parametersDossier)>0);
	}

	public bool Exists(Dossier dossier)
	{
		SqlParameter[] parametersDossier = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossier.DossierID)
		};
		return (SqlDBHelper.ExecuteScalar("Dossier_Exists", CommandType.StoredProcedure, parametersDossier)>0);
	}

	public List<Dossier> GetListByDossierTaxOfficeCode(int taxOfficeCode)
	{
		List<Dossier> listDossier = new List<Dossier>();

		//Lets get the list of all Dossier records from database using TaxOfficeCode
		SqlParameter[] parametersDossier = new SqlParameter[]
		{
			new SqlParameter("@taxOfficeCode", taxOfficeCode)
		};
		//Lets get the list of Dossier records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Dossier_GetListByTaxOfficeCode", CommandType.StoredProcedure, parametersDossier))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of dossier
				listDossier = new List<Dossier>();

				//Now lets populate the dossier details into the list of dossiers
				foreach (DataRow row in table.Rows)
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
					listDossier.Add(dossier);
				}
			}
		}

		return listDossier;
	}

	public List<Dossier> SearchLike(Dossier dossier)
	{
		List<Dossier> listDossier = new List<Dossier>();


		SqlParameter[] parametersDossier = new SqlParameter[]
		{
			new SqlParameter("@DossierID", dossier.DossierID),
			new SqlParameter("@Classes", dossier.Classes),
			new SqlParameter("@TaxOfficeCodeTitle", dossier.TaxOfficeCodeTitle),
			new SqlParameter("@TaxOfficeCityIDTitle", dossier.TaxOfficeCityIDTitle),
			new SqlParameter("@OrderNumber", dossier.OrderNumber),
			new SqlParameter("@OldClasses", dossier.OldClasses),
			new SqlParameter("@TaxOfficeCode", dossier.TaxOfficeCode),
			new SqlParameter("@IsActive", dossier.IsActive),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Dossier_SearchLike", CommandType.StoredProcedure, parametersDossier))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Dossier tmpDossier = new Dossier();
					tmpDossier.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					tmpDossier.Classes = row["Classes"].ToString();
					tmpDossier.TaxOfficeCodeTitle = row["TaxOfficeCodeTitle"].ToString();
					tmpDossier.TaxOfficeCityIDTitle = row["TaxOfficeCityIDTitle"].ToString();
					tmpDossier.OrderNumber = (row["OrderNumber"] != DBNull.Value) ? Convert.ToInt64(row["OrderNumber"]) : 0 ;
					tmpDossier.OldClasses = row["OldClasses"].ToString();
					tmpDossier.TaxOfficeCode = (row["TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["TaxOfficeCode"]) : 0 ;
					tmpDossier.IsActive = (row["IsActive"] != DBNull.Value) ? Convert.ToBoolean((row["IsActive"].ToString() == "1" || row["IsActive"].ToString().ToLower() == "true" ) ? true : false) : false ;

					listDossier.Add(tmpDossier);
				}
			}
		}

		return listDossier;
	}

}
}
