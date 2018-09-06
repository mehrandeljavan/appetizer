using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class RegisterInformationDBAccess
{

	AdjustmentHeritageDBAccess adjustmentHeritageDBAccess = new AdjustmentHeritageDBAccess();
	ApplicantDBAccess applicantDBAccess = new ApplicantDBAccess();
	CommissionVerdictDBAccess commissionVerdictDBAccess = new CommissionVerdictDBAccess();
	DeadDBAccess deadDBAccess = new DeadDBAccess();
	DeclarationDBAccess declarationDBAccess = new DeclarationDBAccess();
	Form19DBAccess form19DBAccess = new Form19DBAccess();
	FormCommissionInvitationDBAccess formCommissionInvitationDBAccess = new FormCommissionInvitationDBAccess();
	FormDeclarationDeliveryDBAccess formDeclarationDeliveryDBAccess = new FormDeclarationDeliveryDBAccess();
	FormDeclarationInputInfoDBAccess formDeclarationInputInfoDBAccess = new FormDeclarationInputInfoDBAccess();
	FormDeterministicPaperDBAccess formDeterministicPaperDBAccess = new FormDeterministicPaperDBAccess();
	FormDiagnosisPaperDBAccess formDiagnosisPaperDBAccess = new FormDiagnosisPaperDBAccess();
	FormDiagnosisResultDBAccess formDiagnosisResultDBAccess = new FormDiagnosisResultDBAccess();
	FormFreedomDBAccess formFreedomDBAccess = new FormFreedomDBAccess();
	FormHeritageBillDBAccess formHeritageBillDBAccess = new FormHeritageBillDBAccess();
	FormHeritageEvaluationDBAccess formHeritageEvaluationDBAccess = new FormHeritageEvaluationDBAccess();
	FormTaxBillDBAccess formTaxBillDBAccess = new FormTaxBillDBAccess();
	FormTaxPaymentCertificateDBAccess formTaxPaymentCertificateDBAccess = new FormTaxPaymentCertificateDBAccess();
	HeirDBAccess heirDBAccess = new HeirDBAccess();
	InquiryResponseDBAccess inquiryResponseDBAccess = new InquiryResponseDBAccess();
	ReDiagnosisRequestDBAccess reDiagnosisRequestDBAccess = new ReDiagnosisRequestDBAccess();
	ReportsDBAccess reportsDBAccess = new ReportsDBAccess();
	UttererDBAccess uttererDBAccess = new UttererDBAccess();

	public List<AdjustmentHeritage> GetListAdjustmentHeritage(Int64 registerInformationID)
	{
		List<AdjustmentHeritage> listAdjustmentHeritage = new List<AdjustmentHeritage>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", registerInformationID)
		};

		//Lets get the list of AdjustmentHeritage records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("AdjustmentHeritage_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of adjustmentHeritage
				listAdjustmentHeritage = new List<AdjustmentHeritage>();

				//Now lets populate the AdjustmentHeritage details into the list of adjustmentHeritages
				foreach (DataRow row in table.Rows)
				{
					AdjustmentHeritage adjustmentHeritage = ConvertRowToAdjustmentHeritage(row);
					listAdjustmentHeritage.Add(adjustmentHeritage);
				}
			}
		}

		return listAdjustmentHeritage;
	}

	private AdjustmentHeritage ConvertRowToAdjustmentHeritage(DataRow row)
	{
		AdjustmentHeritage adjustmentHeritage = new AdjustmentHeritage();
		adjustmentHeritage.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
		adjustmentHeritage.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		adjustmentHeritage.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		adjustmentHeritage.OldRegisterDate = row["OldRegisterDate"].ToString();
		adjustmentHeritage.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		adjustmentHeritage.AdjustmentValue1 = (row["AdjustmentValue1"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue1"]) : 0 ;
		adjustmentHeritage.AdjustmentValue2 = (row["AdjustmentValue2"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue2"]) : 0 ;
		return adjustmentHeritage;
	}
	public List<Applicant> GetListApplicant(Int64 registerInformationID)
	{
		List<Applicant> listApplicant = new List<Applicant>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", registerInformationID)
		};

		//Lets get the list of Applicant records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Applicant_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
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
	public List<CommissionVerdict> GetListCommissionVerdict(Int64 registerInformationID)
	{
		List<CommissionVerdict> listCommissionVerdict = new List<CommissionVerdict>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", registerInformationID)
		};

		//Lets get the list of CommissionVerdict records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionVerdict_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of commissionVerdict
				listCommissionVerdict = new List<CommissionVerdict>();

				//Now lets populate the CommissionVerdict details into the list of commissionVerdicts
				foreach (DataRow row in table.Rows)
				{
					CommissionVerdict commissionVerdict = ConvertRowToCommissionVerdict(row);
					listCommissionVerdict.Add(commissionVerdict);
				}
			}
		}

		return listCommissionVerdict;
	}

	private CommissionVerdict ConvertRowToCommissionVerdict(DataRow row)
	{
		CommissionVerdict commissionVerdict = new CommissionVerdict();
		commissionVerdict.CommissionVerdictTypeID = (row["CommissionVerdictTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionVerdictTypeID"]) : 0 ;
		commissionVerdict.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
		commissionVerdict.CommissionVerdictTypeIDTitle = row["CommissionVerdictTypeIDTitle"].ToString();
		commissionVerdict.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		commissionVerdict.OldRegisterDate = row["OldRegisterDate"].ToString();
		commissionVerdict.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		commissionVerdict.VerdictDate = row["VerdictDate"].ToString();
		commissionVerdict.VerdictNumber = row["VerdictNumber"].ToString();
		commissionVerdict.Comment = row["Comment"].ToString();
		return commissionVerdict;
	}
	public List<Dead> GetListDead(Int64 registerInformationID)
	{
		List<Dead> listDead = new List<Dead>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", registerInformationID)
		};

		//Lets get the list of Dead records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Dead_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
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
	public List<Declaration> GetListDeclaration(Int64 registerInformationID)
	{
		List<Declaration> listDeclaration = new List<Declaration>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", registerInformationID)
		};

		//Lets get the list of Declaration records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Declaration_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
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
	public List<Form19> GetListForm19(Int64 registerInformationID)
	{
		List<Form19> listForm19 = new List<Form19>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@Form19RegisterInformationID", registerInformationID)
		};

		//Lets get the list of Form19 records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Form19_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of form19
				listForm19 = new List<Form19>();

				//Now lets populate the Form19 details into the list of form19s
				foreach (DataRow row in table.Rows)
				{
					Form19 form19 = ConvertRowToForm19(row);
					listForm19.Add(form19);
				}
			}
		}

		return listForm19;
	}

	private Form19 ConvertRowToForm19(DataRow row)
	{
		Form19 form19 = new Form19();
		form19.Form19ID = (row["Form19ID"] != DBNull.Value) ? Convert.ToInt64(row["Form19ID"]) : 0 ;
		form19.Form19PrintRegisterInformationID = row["Form19PrintRegisterInformationID"].ToString();
		form19.Form19PrintRegisterDate = row["Form19PrintRegisterDate"].ToString();
		form19.Form19RequestNumber = row["Form19RequestNumber"].ToString();
		form19.Form19RequestFullName = row["Form19RequestFullName"].ToString();
		form19.Form19HeirFullName = row["Form19HeirFullName"].ToString();
		form19.Form19TaxUnitCode = row["Form19TaxUnitCode"].ToString();
		form19.Form19TaxUnitUserFullName = row["Form19TaxUnitUserFullName"].ToString();
		form19.Form19TaxGroupCode = row["Form19TaxGroupCode"].ToString();
		form19.Form19DeadIssuanceCity = row["Form19DeadIssuanceCity"].ToString();
		form19.Form19DeadDeathCity = row["Form19DeadDeathCity"].ToString();
		form19.Form19Comment1 = row["Form19Comment1"].ToString();
		form19.Form19Comment2 = row["Form19Comment2"].ToString();
		form19.Form19Comment3 = row["Form19Comment3"].ToString();
		form19.Form19HeritagesDescription = row["Form19HeritagesDescription"].ToString();
		form19.Form19RequestFamily = row["Form19RequestFamily"].ToString();
		form19.Form19RequestCertificateNumber = row["Form19RequestCertificateNumber"].ToString();
		form19.Form19RequestIssuanceCity = row["Form19RequestIssuanceCity"].ToString();
		form19.Form19DeadName = row["Form19DeadName"].ToString();
		form19.Form19DeadFamily = row["Form19DeadFamily"].ToString();
		form19.Form19DeadCertificateNumber = row["Form19DeadCertificateNumber"].ToString();
		form19.Form19RegisterInformationID = (row["Form19RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["Form19RegisterInformationID"]) : 0 ;
		form19.Form19RequestNationalCode = (row["Form19RequestNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["Form19RequestNationalCode"]) : 0 ;
		form19.Form19RegisterarUserNationalCode = (row["Form19RegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["Form19RegisterarUserNationalCode"]) : 0 ;
		form19.Form19DeclarationID = (row["Form19DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["Form19DeclarationID"]) : 0 ;
		form19.Form19DeadNationalCode = (row["Form19DeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["Form19DeadNationalCode"]) : 0 ;
		form19.Form19RegisterInformationDate = row["Form19RegisterInformationDate"].ToString();
		form19.Form19DeadDeathDate = row["Form19DeadDeathDate"].ToString();
		form19.Form19RequestDate = row["Form19RequestDate"].ToString();
		form19.Form19DossierClasses = row["Form19DossierClasses"].ToString();
		form19.Form19TaxOfficeProvince = row["Form19TaxOfficeProvince"].ToString();
		form19.Form19TaxOfficeCity = row["Form19TaxOfficeCity"].ToString();
		form19.Form19TaxOfficePhoneNumber = row["Form19TaxOfficePhoneNumber"].ToString();
		form19.Form19TaxOfficeAddress = row["Form19TaxOfficeAddress"].ToString();
		form19.Form19RequestName = row["Form19RequestName"].ToString();
		form19.Form19TaxGroupUserFullName = row["Form19TaxGroupUserFullName"].ToString();
		form19.Form19RequestRelationship = row["Form19RequestRelationship"].ToString();
		form19.Form19HeirShareDescription = row["Form19HeirShareDescription"].ToString();
		form19.Form19TaxOfficeCode = (row["Form19TaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["Form19TaxOfficeCode"]) : 0 ;
		return form19;
	}
	public List<FormCommissionInvitation> GetListFormCommissionInvitation(Int64 registerInformationID)
	{
		List<FormCommissionInvitation> listFormCommissionInvitation = new List<FormCommissionInvitation>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@FormCommissionInvitationRegisterInformarionID", registerInformationID)
		};

		//Lets get the list of FormCommissionInvitation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormCommissionInvitation_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formCommissionInvitation
				listFormCommissionInvitation = new List<FormCommissionInvitation>();

				//Now lets populate the FormCommissionInvitation details into the list of formCommissionInvitations
				foreach (DataRow row in table.Rows)
				{
					FormCommissionInvitation formCommissionInvitation = ConvertRowToFormCommissionInvitation(row);
					listFormCommissionInvitation.Add(formCommissionInvitation);
				}
			}
		}

		return listFormCommissionInvitation;
	}

	private FormCommissionInvitation ConvertRowToFormCommissionInvitation(DataRow row)
	{
		FormCommissionInvitation formCommissionInvitation = new FormCommissionInvitation();
		formCommissionInvitation.FormCommissionInvitationID = (row["FormCommissionInvitationID"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationID"]) : 0 ;
		formCommissionInvitation.FormCommissionInvitationPrintRegisterInformationID = row["FormCommissionInvitationPrintRegisterInformationID"].ToString();
		formCommissionInvitation.FormCommissionInvitationPrintRegisterDate = row["FormCommissionInvitationPrintRegisterDate"].ToString();
		formCommissionInvitation.FormCommissionInvitationTaxResource = row["FormCommissionInvitationTaxResource"].ToString();
		formCommissionInvitation.FormCommissionInvitationDeadDeathYear = row["FormCommissionInvitationDeadDeathYear"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionAddress = row["FormCommissionInvitationCommissionAddress"].ToString();
		formCommissionInvitation.FormCommissionInvitationUser1FullName = row["FormCommissionInvitationUser1FullName"].ToString();
		formCommissionInvitation.FormCommissionInvitationUser1Code = row["FormCommissionInvitationUser1Code"].ToString();
		formCommissionInvitation.FormCommissionInvitationUser2FullName = row["FormCommissionInvitationUser2FullName"].ToString();
		formCommissionInvitation.FormCommissionInvitationUser2Code = row["FormCommissionInvitationUser2Code"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionType3 = row["FormCommissionInvitationCommissionType3"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionType4 = row["FormCommissionInvitationCommissionType4"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionType5 = row["FormCommissionInvitationCommissionType5"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionType6 = row["FormCommissionInvitationCommissionType6"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionDay = row["FormCommissionInvitationCommissionDay"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionTimePeriod = row["FormCommissionInvitationCommissionTimePeriod"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirJobZipCode = row["FormCommissionInvitationHeirJobZipCode"].ToString();
		formCommissionInvitation.FormCommissionInvitationInvitationType1 = row["FormCommissionInvitationInvitationType1"].ToString();
		formCommissionInvitation.FormCommissionInvitationInvitationType2 = row["FormCommissionInvitationInvitationType2"].ToString();
		formCommissionInvitation.FormCommissionInvitationInvitationType3 = row["FormCommissionInvitationInvitationType3"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionType1 = row["FormCommissionInvitationCommissionType1"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionType2 = row["FormCommissionInvitationCommissionType2"].ToString();
		formCommissionInvitation.FormCommissionInvitationDeadUniqueCode = row["FormCommissionInvitationDeadUniqueCode"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirJobAddress = row["FormCommissionInvitationHeirJobAddress"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirHomeAddress = row["FormCommissionInvitationHeirHomeAddress"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirHomePhoneNumber = row["FormCommissionInvitationHeirHomePhoneNumber"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirHomeJobPhoneNumber = row["FormCommissionInvitationHeirHomeJobPhoneNumber"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirHomeZipCode = row["FormCommissionInvitationHeirHomeZipCode"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirFatherName = row["FormCommissionInvitationHeirFatherName"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirIdentifier = row["FormCommissionInvitationHeirIdentifier"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirCertificateNumber = row["FormCommissionInvitationHeirCertificateNumber"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirIssuanceCity = row["FormCommissionInvitationHeirIssuanceCity"].ToString();
		formCommissionInvitation.FormCommissionInvitationDeadFullName = row["FormCommissionInvitationDeadFullName"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirRelation = row["FormCommissionInvitationHeirRelation"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirBirthDate = row["FormCommissionInvitationHeirBirthDate"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionDate = row["FormCommissionInvitationCommissionDate"].ToString();
		formCommissionInvitation.FormCommissionInvitationCommissionTime = row["FormCommissionInvitationCommissionTime"].ToString();
		formCommissionInvitation.FormCommissionInvitationPenaltyDate = row["FormCommissionInvitationPenaltyDate"].ToString();
		formCommissionInvitation.FormCommissionInvitationRegisterInformarionID = (row["FormCommissionInvitationRegisterInformarionID"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationRegisterInformarionID"]) : 0 ;
		formCommissionInvitation.FormCommissionInvitationHeirNationalCode = (row["FormCommissionInvitationHeirNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationHeirNationalCode"]) : 0 ;
		formCommissionInvitation.FormCommissionInvitationDeclarationID = (row["FormCommissionInvitationDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormCommissionInvitationDeclarationID"]) : 0 ;
		formCommissionInvitation.FormCommissionInvitationRegisterDate = row["FormCommissionInvitationRegisterDate"].ToString();
		formCommissionInvitation.FormCommissionInvitationDossierClasses = row["FormCommissionInvitationDossierClasses"].ToString();
		formCommissionInvitation.FormCommissionInvitationTaxOfficeProvince = row["FormCommissionInvitationTaxOfficeProvince"].ToString();
		formCommissionInvitation.FormCommissionInvitationTaxOfficeCity = row["FormCommissionInvitationTaxOfficeCity"].ToString();
		formCommissionInvitation.FormCommissionInvitationTaxOfficeAddress = row["FormCommissionInvitationTaxOfficeAddress"].ToString();
		formCommissionInvitation.FormCommissionInvitationTaxOfficePhoneNumber = row["FormCommissionInvitationTaxOfficePhoneNumber"].ToString();
		formCommissionInvitation.FormCommissionInvitationHeirFullName = row["FormCommissionInvitationHeirFullName"].ToString();
		formCommissionInvitation.FormCommissionInvitationTaxUnitCode = (row["FormCommissionInvitationTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["FormCommissionInvitationTaxUnitCode"]) : 0 ;
		formCommissionInvitation.FormCommissionInvitationHeirShare = (row["FormCommissionInvitationHeirShare"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirShare"]) : 0 ;
		formCommissionInvitation.FormCommissionInvitationHeirExemption = (row["FormCommissionInvitationHeirExemption"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirExemption"]) : 0 ;
		formCommissionInvitation.FormCommissionInvitationHeirIncludedIncome = (row["FormCommissionInvitationHeirIncludedIncome"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirIncludedIncome"]) : 0 ;
		formCommissionInvitation.FormCommissionInvitationHeirTax = (row["FormCommissionInvitationHeirTax"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationHeirTax"]) : 0 ;
		formCommissionInvitation.FormCommissionInvitationPenaltySum = (row["FormCommissionInvitationPenaltySum"] != DBNull.Value) ? Convert.ToSingle(row["FormCommissionInvitationPenaltySum"]) : 0 ;
		return formCommissionInvitation;
	}
	public List<FormDeclarationDelivery> GetListFormDeclarationDelivery(Int64 registerInformationID)
	{
		List<FormDeclarationDelivery> listFormDeclarationDelivery = new List<FormDeclarationDelivery>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationDeliveryRegisterInformationID", registerInformationID)
		};

		//Lets get the list of FormDeclarationDelivery records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDeclarationDelivery_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formDeclarationDelivery
				listFormDeclarationDelivery = new List<FormDeclarationDelivery>();

				//Now lets populate the FormDeclarationDelivery details into the list of formDeclarationDeliverys
				foreach (DataRow row in table.Rows)
				{
					FormDeclarationDelivery formDeclarationDelivery = ConvertRowToFormDeclarationDelivery(row);
					listFormDeclarationDelivery.Add(formDeclarationDelivery);
				}
			}
		}

		return listFormDeclarationDelivery;
	}

	private FormDeclarationDelivery ConvertRowToFormDeclarationDelivery(DataRow row)
	{
		FormDeclarationDelivery formDeclarationDelivery = new FormDeclarationDelivery();
		formDeclarationDelivery.FormDeclarationDeliveryID = (row["FormDeclarationDeliveryID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationDeliveryID"]) : 0 ;
		formDeclarationDelivery.FormDeclarationDeliveryPrintRegisterInformationID = row["FormDeclarationDeliveryPrintRegisterInformationID"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryPrintRegisterDate = row["FormDeclarationDeliveryPrintRegisterDate"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryDeadIssuanceCity = row["FormDeclarationDeliveryDeadIssuanceCity"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryDeadDeathCity = row["FormDeclarationDeliveryDeadDeathCity"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryUttererRole = row["FormDeclarationDeliveryUttererRole"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryDeclarativeValueString = row["FormDeclarationDeliveryDeclarativeValueString"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryRuleComment2 = row["FormDeclarationDeliveryRuleComment2"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryHeritageDescription = row["FormDeclarationDeliveryHeritageDescription"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxGroupCode = row["FormDeclarationDeliveryTaxGroupCode"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxGroupUserName = row["FormDeclarationDeliveryTaxGroupUserName"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryDeadName = row["FormDeclarationDeliveryDeadName"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryDeadFamilu = row["FormDeclarationDeliveryDeadFamilu"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryDeadCertificateNumber = row["FormDeclarationDeliveryDeadCertificateNumber"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryDeadNationalCode = row["FormDeclarationDeliveryDeadNationalCode"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryApplicantName = row["FormDeclarationDeliveryApplicantName"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryApplicantFamily = row["FormDeclarationDeliveryApplicantFamily"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxUnitCode = row["FormDeclarationDeliveryTaxUnitCode"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxUnitUserName = row["FormDeclarationDeliveryTaxUnitUserName"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxUnitUserFamily = row["FormDeclarationDeliveryTaxUnitUserFamily"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxGroupUserFamily = row["FormDeclarationDeliveryTaxGroupUserFamily"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryUttererFamily = row["FormDeclarationDeliveryUttererFamily"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryUttererCertificateNumber = row["FormDeclarationDeliveryUttererCertificateNumber"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryUttererNationalCode = row["FormDeclarationDeliveryUttererNationalCode"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryUttererIssuanceCity = row["FormDeclarationDeliveryUttererIssuanceCity"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryComment2 = row["FormDeclarationDeliveryComment2"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryApplicantNumber = row["FormDeclarationDeliveryApplicantNumber"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryRegisterInformationID = (row["FormDeclarationDeliveryRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationDeliveryRegisterInformationID"]) : 0 ;
		formDeclarationDelivery.FormDeclarationDeliveryDeclarationID = (row["FormDeclarationDeliveryDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationDeliveryDeclarationID"]) : 0 ;
		formDeclarationDelivery.FormDeclarationDeliveryRegisterarUserNationalCode = (row["FormDeclarationDeliveryRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationDeliveryRegisterarUserNationalCode"]) : 0 ;
		formDeclarationDelivery.FormDeclarationDeliveryDossierClasses = row["FormDeclarationDeliveryDossierClasses"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxOfficePhoneNumber = row["FormDeclarationDeliveryTaxOfficePhoneNumber"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryApplicantDate = row["FormDeclarationDeliveryApplicantDate"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryDeadDeathDate = row["FormDeclarationDeliveryDeadDeathDate"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryRegisterInformationDate = row["FormDeclarationDeliveryRegisterInformationDate"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryRuleComment1 = row["FormDeclarationDeliveryRuleComment1"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeProvince = row["FormDeclarationDeliveryTaxOfficeProvince"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeCode = row["FormDeclarationDeliveryTaxOfficeCode"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeCity = row["FormDeclarationDeliveryTaxOfficeCity"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryTaxOfficeAddress = row["FormDeclarationDeliveryTaxOfficeAddress"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryUttererName = row["FormDeclarationDeliveryUttererName"].ToString();
		formDeclarationDelivery.FormDeclarationDeliveryDeclarativeValue = (row["FormDeclarationDeliveryDeclarativeValue"] != DBNull.Value) ? Convert.ToSingle(row["FormDeclarationDeliveryDeclarativeValue"]) : 0 ;
		return formDeclarationDelivery;
	}
	public List<FormDeclarationInputInfo> GetListFormDeclarationInputInfo(Int64 registerInformationID)
	{
		List<FormDeclarationInputInfo> listFormDeclarationInputInfo = new List<FormDeclarationInputInfo>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@FormDeclarationInputInfoRegisterInformationID", registerInformationID)
		};

		//Lets get the list of FormDeclarationInputInfo records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDeclarationInputInfo_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formDeclarationInputInfo
				listFormDeclarationInputInfo = new List<FormDeclarationInputInfo>();

				//Now lets populate the FormDeclarationInputInfo details into the list of formDeclarationInputInfos
				foreach (DataRow row in table.Rows)
				{
					FormDeclarationInputInfo formDeclarationInputInfo = ConvertRowToFormDeclarationInputInfo(row);
					listFormDeclarationInputInfo.Add(formDeclarationInputInfo);
				}
			}
		}

		return listFormDeclarationInputInfo;
	}

	private FormDeclarationInputInfo ConvertRowToFormDeclarationInputInfo(DataRow row)
	{
		FormDeclarationInputInfo formDeclarationInputInfo = new FormDeclarationInputInfo();
		formDeclarationInputInfo.FormDeclarationInputInfoID = (row["FormDeclarationInputInfoID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoID"]) : 0 ;
		formDeclarationInputInfo.FormDeclarationInputInfoPrintRegisterInformationID = row["FormDeclarationInputInfoPrintRegisterInformationID"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoPrintRegisterDate = row["FormDeclarationInputInfoPrintRegisterDate"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathProvince = row["FormDeclarationInputInfoDeadDeathProvince"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathCity = row["FormDeclarationInputInfoDeadDeathCity"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoProvince = row["FormDeclarationInputInfoTaxOfficeRegisterInfoProvince"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeRegisterInfoCity = row["FormDeclarationInputInfoTaxOfficeRegisterInfoCity"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoTaxUnitCode = row["FormDeclarationInputInfoTaxUnitCode"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadZipCode = row["FormDeclarationInputInfoDeadZipCode"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadFatherName = row["FormDeclarationInputInfoDeadFatherName"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateNumber = row["FormDeclarationInputInfoDeadCertificateNumber"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadCertificateSerial = row["FormDeclarationInputInfoDeadCertificateSerial"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceProvice = row["FormDeclarationInputInfoDeadIssuanceProvice"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceCity = row["FormDeclarationInputInfoDeadIssuanceCity"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDepartmant = row["FormDeclarationInputInfoDeadIssuanceDepartmant"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeclarationID = (row["FormDeclarationInputInfoDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoDeclarationID"]) : 0 ;
		formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationID = (row["FormDeclarationInputInfoRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoRegisterInformationID"]) : 0 ;
		formDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationID = (row["FormDeclarationInputInfoDeclarationRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoDeclarationRegisterInformationID"]) : 0 ;
		formDeclarationInputInfo.FormDeclarationInputInfoRegisterarUserNationalCode = (row["FormDeclarationInputInfoRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDeclarationInputInfoRegisterarUserNationalCode"]) : 0 ;
		formDeclarationInputInfo.FormDeclarationInputInfoDeadIssuanceDate = row["FormDeclarationInputInfoDeadIssuanceDate"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadBirthDate = row["FormDeclarationInputInfoDeadBirthDate"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadDeathDate = row["FormDeclarationInputInfoDeadDeathDate"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeclarationRegisterInformationDate = row["FormDeclarationInputInfoDeclarationRegisterInformationDate"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoApproveDate = row["FormDeclarationInputInfoApproveDate"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoRegisterInformationDate = row["FormDeclarationInputInfoRegisterInformationDate"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadNationalCode = row["FormDeclarationInputInfoDeadNationalCode"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeTitle = row["FormDeclarationInputInfoTaxOfficeTitle"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeCity = row["FormDeclarationInputInfoTaxOfficeCity"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeclarationStage = row["FormDeclarationInputInfoDeclarationStage"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadName = row["FormDeclarationInputInfoDeadName"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadFamily = row["FormDeclarationInputInfoDeadFamily"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoDeadUniqueCode = row["FormDeclarationInputInfoDeadUniqueCode"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoApprovalUserName = row["FormDeclarationInputInfoApprovalUserName"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoApprovalUserFamily = row["FormDeclarationInputInfoApprovalUserFamily"].ToString();
		formDeclarationInputInfo.FormDeclarationInputInfoTaxOfficeProvince = row["FormDeclarationInputInfoTaxOfficeProvince"].ToString();
		return formDeclarationInputInfo;
	}
	public List<FormDeterministicPaper> GetListFormDeterministicPaper(Int64 registerInformationID)
	{
		List<FormDeterministicPaper> listFormDeterministicPaper = new List<FormDeterministicPaper>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@FormDeterministicPaperRegisterInformationID", registerInformationID)
		};

		//Lets get the list of FormDeterministicPaper records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDeterministicPaper_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formDeterministicPaper
				listFormDeterministicPaper = new List<FormDeterministicPaper>();

				//Now lets populate the FormDeterministicPaper details into the list of formDeterministicPapers
				foreach (DataRow row in table.Rows)
				{
					FormDeterministicPaper formDeterministicPaper = ConvertRowToFormDeterministicPaper(row);
					listFormDeterministicPaper.Add(formDeterministicPaper);
				}
			}
		}

		return listFormDeterministicPaper;
	}

	private FormDeterministicPaper ConvertRowToFormDeterministicPaper(DataRow row)
	{
		FormDeterministicPaper formDeterministicPaper = new FormDeterministicPaper();
		formDeterministicPaper.FormDeterministicPaperID = (row["FormDeterministicPaperID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperID"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperPrintRegisterInformationID = row["FormDeterministicPaperPrintRegisterInformationID"].ToString();
		formDeterministicPaper.FormDeterministicPaperPrintRegisterDate = row["FormDeterministicPaperPrintRegisterDate"].ToString();
		formDeterministicPaper.FormDeterministicPaperReductionType = row["FormDeterministicPaperReductionType"].ToString();
		formDeterministicPaper.FormDeterministicPaperPenaltyReason = row["FormDeterministicPaperPenaltyReason"].ToString();
		formDeterministicPaper.FormDeterministicPaperComment = row["FormDeterministicPaperComment"].ToString();
		formDeterministicPaper.FormDeterministicPaperUser1Code = row["FormDeterministicPaperUser1Code"].ToString();
		formDeterministicPaper.FormDeterministicPaperUser1FullName = row["FormDeterministicPaperUser1FullName"].ToString();
		formDeterministicPaper.FormDeterministicPaperOperationYear2 = row["FormDeterministicPaperOperationYear2"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirJobZipCode = row["FormDeterministicPaperHeirJobZipCode"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirHomeZipCode = row["FormDeterministicPaperHeirHomeZipCode"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirIdentifier = row["FormDeterministicPaperHeirIdentifier"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxTitle = row["FormDeterministicPaperTaxTitle"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxReason = row["FormDeterministicPaperTaxReason"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxNumber = row["FormDeterministicPaperTaxNumber"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirIssuanceDepartmant = row["FormDeterministicPaperHeirIssuanceDepartmant"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirIssuanceCity = row["FormDeterministicPaperHeirIssuanceCity"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirJobAddress = row["FormDeterministicPaperHeirJobAddress"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirHomeAddress = row["FormDeterministicPaperHeirHomeAddress"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirJobPhoneNumber = row["FormDeterministicPaperHeirJobPhoneNumber"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirHomePhoneNumber = row["FormDeterministicPaperHeirHomePhoneNumber"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirName = row["FormDeterministicPaperHeirName"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirFamily = row["FormDeterministicPaperHeirFamily"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirFatherName = row["FormDeterministicPaperHeirFatherName"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirCertificateNumber = row["FormDeterministicPaperHeirCertificateNumber"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirNationalCode = row["FormDeterministicPaperHeirNationalCode"].ToString();
		formDeterministicPaper.FormDeterministicPaperHeirIssuanceDate = row["FormDeterministicPaperHeirIssuanceDate"].ToString();
		formDeterministicPaper.FormDeterministicPaperDossierClasses = row["FormDeterministicPaperDossierClasses"].ToString();
		formDeterministicPaper.FormDeterministicPaperRegisterInformationID = (row["FormDeterministicPaperRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperRegisterInformationID"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperDeclarationID = (row["FormDeterministicPaperDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperDeclarationID"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperRegisterarUserNationalCode = (row["FormDeterministicPaperRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDeterministicPaperRegisterarUserNationalCode"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperRegisterInformationDate = row["FormDeterministicPaperRegisterInformationDate"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxDate = row["FormDeterministicPaperTaxDate"].ToString();
		formDeterministicPaper.FormDeterministicPaperAnnonsiationDate = row["FormDeterministicPaperAnnonsiationDate"].ToString();
		formDeterministicPaper.FormDeterministicPaperReductionDate = row["FormDeterministicPaperReductionDate"].ToString();
		formDeterministicPaper.FormDeterministicPaperPenaltyDate = row["FormDeterministicPaperPenaltyDate"].ToString();
		formDeterministicPaper.FormDeterministicPaperOperationYear1 = row["FormDeterministicPaperOperationYear1"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxOfficeProvince = row["FormDeterministicPaperTaxOfficeProvince"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxOfficeCode = row["FormDeterministicPaperTaxOfficeCode"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxUintCode = row["FormDeterministicPaperTaxUintCode"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxOfficeAddress = row["FormDeterministicPaperTaxOfficeAddress"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxOfficePhoneNumber = row["FormDeterministicPaperTaxOfficePhoneNumber"].ToString();
		formDeterministicPaper.FormDeterministicPaperPayableTaxLetter = row["FormDeterministicPaperPayableTaxLetter"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxTitle2 = row["FormDeterministicPaperTaxTitle2"].ToString();
		formDeterministicPaper.FormDeterministicPaperTaxBase = (row["FormDeterministicPaperTaxBase"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxBase"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperTaxReduction = (row["FormDeterministicPaperTaxReduction"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxReduction"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperTaxRemaining = (row["FormDeterministicPaperTaxRemaining"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxRemaining"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperTax = (row["FormDeterministicPaperTax"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTax"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperReduction = (row["FormDeterministicPaperReduction"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperReduction"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperPenalty = (row["FormDeterministicPaperPenalty"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperPenalty"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperTotalWithoutPenalty = (row["FormDeterministicPaperTotalWithoutPenalty"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTotalWithoutPenalty"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperTotal = (row["FormDeterministicPaperTotal"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTotal"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperPayableTax = (row["FormDeterministicPaperPayableTax"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperPayableTax"]) : 0 ;
		formDeterministicPaper.FormDeterministicPaperTaxRemaining2 = (row["FormDeterministicPaperTaxRemaining2"] != DBNull.Value) ? Convert.ToSingle(row["FormDeterministicPaperTaxRemaining2"]) : 0 ;
		return formDeterministicPaper;
	}
	public List<FormDiagnosisPaper> GetListFormDiagnosisPaper(Int64 registerInformationID)
	{
		List<FormDiagnosisPaper> listFormDiagnosisPaper = new List<FormDiagnosisPaper>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisPaperRegisterInformationID", registerInformationID)
		};

		//Lets get the list of FormDiagnosisPaper records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDiagnosisPaper_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formDiagnosisPaper
				listFormDiagnosisPaper = new List<FormDiagnosisPaper>();

				//Now lets populate the FormDiagnosisPaper details into the list of formDiagnosisPapers
				foreach (DataRow row in table.Rows)
				{
					FormDiagnosisPaper formDiagnosisPaper = ConvertRowToFormDiagnosisPaper(row);
					listFormDiagnosisPaper.Add(formDiagnosisPaper);
				}
			}
		}

		return listFormDiagnosisPaper;
	}

	private FormDiagnosisPaper ConvertRowToFormDiagnosisPaper(DataRow row)
	{
		FormDiagnosisPaper formDiagnosisPaper = new FormDiagnosisPaper();
		formDiagnosisPaper.FormDiagnosisPaperID = (row["FormDiagnosisPaperID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperID"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperPrintRegisterInformationID = row["FormDiagnosisPaperPrintRegisterInformationID"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperPrintRegisterDate = row["FormDiagnosisPaperPrintRegisterDate"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperlUser1Code = row["FormDiagnosisPaperlUser1Code"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperUser1FullName = row["FormDiagnosisPaperUser1FullName"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperUser2Code = row["FormDiagnosisPaperUser2Code"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperlUser2FullName = row["FormDiagnosisPaperlUser2FullName"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperTaxDescription = row["FormDiagnosisPaperTaxDescription"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperDeadNationality = row["FormDiagnosisPaperDeadNationality"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperDeadLastAddress = row["FormDiagnosisPaperDeadLastAddress"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirLevel1 = row["FormDiagnosisPaperHeirLevel1"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirLevel2 = row["FormDiagnosisPaperHeirLevel2"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirLevel3 = row["FormDiagnosisPaperHeirLevel3"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirLevel4 = row["FormDiagnosisPaperHeirLevel4"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirName = row["FormDiagnosisPaperHeirName"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirFamily = row["FormDiagnosisPaperHeirFamily"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirIdentifier = row["FormDiagnosisPaperHeirIdentifier"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirAddress = row["FormDiagnosisPaperHeirAddress"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirNationalCode = row["FormDiagnosisPaperHeirNationalCode"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperDeadFullName = row["FormDiagnosisPaperDeadFullName"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperHeirZipCode = row["FormDiagnosisPaperHeirZipCode"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperRegisterInformationID = (row["FormDiagnosisPaperRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperRegisterInformationID"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperDeclarationID = (row["FormDiagnosisPaperDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperDeclarationID"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperRegisterarUserNationalCode = (row["FormDiagnosisPaperRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisPaperRegisterarUserNationalCode"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperDossierClasses = row["FormDiagnosisPaperDossierClasses"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperDeadDeathDate = row["FormDiagnosisPaperDeadDeathDate"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperRegisterInformationDate = row["FormDiagnosisPaperRegisterInformationDate"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperCommentHeader = row["FormDiagnosisPaperCommentHeader"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperTaxOfficeProvince = row["FormDiagnosisPaperTaxOfficeProvince"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperTaxOfficeCode = row["FormDiagnosisPaperTaxOfficeCode"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperTaxUnitCode = row["FormDiagnosisPaperTaxUnitCode"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperTaxOfficeAddress = row["FormDiagnosisPaperTaxOfficeAddress"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperTaxOfficePhoneNumber = row["FormDiagnosisPaperTaxOfficePhoneNumber"].ToString();
		formDiagnosisPaper.FormDiagnosisPaperTotalValue1 = (row["FormDiagnosisPaperTotalValue1"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue1"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperReduction1 = (row["FormDiagnosisPaperReduction1"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperReduction1"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperTotalValue2 = (row["FormDiagnosisPaperTotalValue2"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue2"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperReduction2 = (row["FormDiagnosisPaperReduction2"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperReduction2"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperTotalValue3 = (row["FormDiagnosisPaperTotalValue3"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue3"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperYourShare = (row["FormDiagnosisPaperYourShare"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperYourShare"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperIncludedShare = (row["FormDiagnosisPaperIncludedShare"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperIncludedShare"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperYourShareWill = (row["FormDiagnosisPaperYourShareWill"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperYourShareWill"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperTotalValue4 = (row["FormDiagnosisPaperTotalValue4"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTotalValue4"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperReduction3 = (row["FormDiagnosisPaperReduction3"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperReduction3"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperTax = (row["FormDiagnosisPaperTax"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTax"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperTaxTypeA = (row["FormDiagnosisPaperTaxTypeA"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTaxTypeA"]) : 0 ;
		formDiagnosisPaper.FormDiagnosisPaperTaxTypeB = (row["FormDiagnosisPaperTaxTypeB"] != DBNull.Value) ? Convert.ToSingle(row["FormDiagnosisPaperTaxTypeB"]) : 0 ;
		return formDiagnosisPaper;
	}
	public List<FormDiagnosisResult> GetListFormDiagnosisResult(Int64 registerInformationID)
	{
		List<FormDiagnosisResult> listFormDiagnosisResult = new List<FormDiagnosisResult>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@FormDiagnosisResultRegisterInformationID", registerInformationID)
		};

		//Lets get the list of FormDiagnosisResult records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormDiagnosisResult_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formDiagnosisResult
				listFormDiagnosisResult = new List<FormDiagnosisResult>();

				//Now lets populate the FormDiagnosisResult details into the list of formDiagnosisResults
				foreach (DataRow row in table.Rows)
				{
					FormDiagnosisResult formDiagnosisResult = ConvertRowToFormDiagnosisResult(row);
					listFormDiagnosisResult.Add(formDiagnosisResult);
				}
			}
		}

		return listFormDiagnosisResult;
	}

	private FormDiagnosisResult ConvertRowToFormDiagnosisResult(DataRow row)
	{
		FormDiagnosisResult formDiagnosisResult = new FormDiagnosisResult();
		formDiagnosisResult.FormDiagnosisResultID = (row["FormDiagnosisResultID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisResultID"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultDeclarationID = (row["FormDiagnosisResultDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisResultDeclarationID"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultRegisterInformationID = (row["FormDiagnosisResultRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisResultRegisterInformationID"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultApplicantNationalCode = (row["FormDiagnosisResultApplicantNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisResultApplicantNationalCode"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultZipCode = (row["FormDiagnosisResultZipCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisResultZipCode"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultDeadNationalCode = (row["FormDiagnosisResultDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormDiagnosisResultDeadNationalCode"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultDeadIssuanceCity = row["FormDiagnosisResultDeadIssuanceCity"].ToString();
		formDiagnosisResult.FormDiagnosisResultRegisterDate = row["FormDiagnosisResultRegisterDate"].ToString();
		formDiagnosisResult.FormDiagnosisResultApplicantBirthDate = row["FormDiagnosisResultApplicantBirthDate"].ToString();
		formDiagnosisResult.FormDiagnosisResultDeadDeathDate = row["FormDiagnosisResultDeadDeathDate"].ToString();
		formDiagnosisResult.FormDiagnosisResultDiagnosisReportDate = row["FormDiagnosisResultDiagnosisReportDate"].ToString();
		formDiagnosisResult.FormDiagnosisResultRequestDate = row["FormDiagnosisResultRequestDate"].ToString();
		formDiagnosisResult.FormDiagnosisResultTaxOfficeTitle = row["FormDiagnosisResultTaxOfficeTitle"].ToString();
		formDiagnosisResult.FormDiagnosisResultTaxOfficeAddress = row["FormDiagnosisResultTaxOfficeAddress"].ToString();
		formDiagnosisResult.FormDiagnosisResultTaxOfficePhoneNumber = row["FormDiagnosisResultTaxOfficePhoneNumber"].ToString();
		formDiagnosisResult.FormDiagnosisResultTaxOfficeZipCode = row["FormDiagnosisResultTaxOfficeZipCode"].ToString();
		formDiagnosisResult.FormDiagnosisResultDossierClasses = row["FormDiagnosisResultDossierClasses"].ToString();
		formDiagnosisResult.FormDiagnosisResultApplicantFullName = row["FormDiagnosisResultApplicantFullName"].ToString();
		formDiagnosisResult.FormDiagnosisResultDescription = row["FormDiagnosisResultDescription"].ToString();
		formDiagnosisResult.FormDiagnosisResultUser1FullName = row["FormDiagnosisResultUser1FullName"].ToString();
		formDiagnosisResult.FormDiagnosisResultUser2FullName = row["FormDiagnosisResultUser2FullName"].ToString();
		formDiagnosisResult.FormDiagnosisResultPhoneNumber = row["FormDiagnosisResultPhoneNumber"].ToString();
		formDiagnosisResult.FormDiagnosisResultApplicantRole = row["FormDiagnosisResultApplicantRole"].ToString();
		formDiagnosisResult.FormDiagnosisResultDeadFullName = row["FormDiagnosisResultDeadFullName"].ToString();
		formDiagnosisResult.FormDiagnosisResultDeadFatherName = row["FormDiagnosisResultDeadFatherName"].ToString();
		formDiagnosisResult.FormDiagnosisResultDeadDeathCity = row["FormDiagnosisResultDeadDeathCity"].ToString();
		formDiagnosisResult.FormDiagnosisResultDeadCertificateNumber = row["FormDiagnosisResultDeadCertificateNumber"].ToString();
		formDiagnosisResult.FormDiagnosisResultDiagnosisReportNumber = row["FormDiagnosisResultDiagnosisReportNumber"].ToString();
		formDiagnosisResult.FormDiagnosisResultRequestNumber = row["FormDiagnosisResultRequestNumber"].ToString();
		formDiagnosisResult.FormDiagnosisResultApplicantFatherName = row["FormDiagnosisResultApplicantFatherName"].ToString();
		formDiagnosisResult.FormDiagnosisResultApplicantBirthCity = row["FormDiagnosisResultApplicantBirthCity"].ToString();
		formDiagnosisResult.FormDiagnosisResultApplicantCertificateNumber = row["FormDiagnosisResultApplicantCertificateNumber"].ToString();
		formDiagnosisResult.FormDiagnosisResultApplicantIssuanceCity = row["FormDiagnosisResultApplicantIssuanceCity"].ToString();
		formDiagnosisResult.FormDiagnosisResultCommercialNumber = row["FormDiagnosisResultCommercialNumber"].ToString();
		formDiagnosisResult.FormDiagnosisResultAddress = row["FormDiagnosisResultAddress"].ToString();
		formDiagnosisResult.FormDiagnosisResultTaxOfficeCode = (row["FormDiagnosisResultTaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["FormDiagnosisResultTaxOfficeCode"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultTaxGroupCode = (row["FormDiagnosisResultTaxGroupCode"] != DBNull.Value) ? Convert.ToInt32(row["FormDiagnosisResultTaxGroupCode"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultTaxUnitCode = (row["FormDiagnosisResultTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["FormDiagnosisResultTaxUnitCode"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultUser1Code = (row["FormDiagnosisResultUser1Code"] != DBNull.Value) ? Convert.ToInt32(row["FormDiagnosisResultUser1Code"]) : 0 ;
		formDiagnosisResult.FormDiagnosisResultUser2Code = (row["FormDiagnosisResultUser2Code"] != DBNull.Value) ? Convert.ToInt32(row["FormDiagnosisResultUser2Code"]) : 0 ;
		return formDiagnosisResult;
	}
	public List<FormFreedom> GetListFormFreedom(Int64 registerInformationID)
	{
		List<FormFreedom> listFormFreedom = new List<FormFreedom>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@FormFreedomRegisterInformationID", registerInformationID)
		};

		//Lets get the list of FormFreedom records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormFreedom_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formFreedom
				listFormFreedom = new List<FormFreedom>();

				//Now lets populate the FormFreedom details into the list of formFreedoms
				foreach (DataRow row in table.Rows)
				{
					FormFreedom formFreedom = ConvertRowToFormFreedom(row);
					listFormFreedom.Add(formFreedom);
				}
			}
		}

		return listFormFreedom;
	}

	private FormFreedom ConvertRowToFormFreedom(DataRow row)
	{
		FormFreedom formFreedom = new FormFreedom();
		formFreedom.FormFreedomID = (row["FormFreedomID"] != DBNull.Value) ? Convert.ToInt64(row["FormFreedomID"]) : 0 ;
		formFreedom.FormFreedomDeclarationID = (row["FormFreedomDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormFreedomDeclarationID"]) : 0 ;
		formFreedom.FormFreedomRegisterInformationID = (row["FormFreedomRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormFreedomRegisterInformationID"]) : 0 ;
		formFreedom.FormFreedomApplicantNationalCode = (row["FormFreedomApplicantNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormFreedomApplicantNationalCode"]) : 0 ;
		formFreedom.FormFreedomZipCode = (row["FormFreedomZipCode"] != DBNull.Value) ? Convert.ToInt64(row["FormFreedomZipCode"]) : 0 ;
		formFreedom.FormFreedomDeadNationalCode = (row["FormFreedomDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormFreedomDeadNationalCode"]) : 0 ;
		formFreedom.FormFreedomRegisterDate = row["FormFreedomRegisterDate"].ToString();
		formFreedom.FormFreedomRequestDate = row["FormFreedomRequestDate"].ToString();
		formFreedom.FormFreedomApplicantBirthDate = row["FormFreedomApplicantBirthDate"].ToString();
		formFreedom.FormFreedomDeadDeathDate = row["FormFreedomDeadDeathDate"].ToString();
		formFreedom.FormFreedomDeclarationRegisterDate = row["FormFreedomDeclarationRegisterDate"].ToString();
		formFreedom.FormFreedomDiagnosisDate = row["FormFreedomDiagnosisDate"].ToString();
		formFreedom.FormFreedomHeirsCertificateDate = row["FormFreedomHeirsCertificateDate"].ToString();
		formFreedom.FormFreedomTaxOfficeTitle = row["FormFreedomTaxOfficeTitle"].ToString();
		formFreedom.FormFreedomTaxOfficeAddress = row["FormFreedomTaxOfficeAddress"].ToString();
		formFreedom.FormFreedomTaxOfficePhoneNumber = row["FormFreedomTaxOfficePhoneNumber"].ToString();
		formFreedom.FormFreedomTaxOfficeZipCode = row["FormFreedomTaxOfficeZipCode"].ToString();
		formFreedom.FormFreedomDossierClasses = row["FormFreedomDossierClasses"].ToString();
		formFreedom.FormFreedomRequestResource = row["FormFreedomRequestResource"].ToString();
		formFreedom.FormFreedomDescriptionHeritage = row["FormFreedomDescriptionHeritage"].ToString();
		formFreedom.FormFreedomUser1FullName = row["FormFreedomUser1FullName"].ToString();
		formFreedom.FormFreedomPhoneNumber = row["FormFreedomPhoneNumber"].ToString();
		formFreedom.FormFreedomUttererRole = row["FormFreedomUttererRole"].ToString();
		formFreedom.FormFreedomHeirsCertificateNumber = row["FormFreedomHeirsCertificateNumber"].ToString();
		formFreedom.FormFreedomHeirsCertificateSource = row["FormFreedomHeirsCertificateSource"].ToString();
		formFreedom.FormFreedomHeirsCertificateBranch = row["FormFreedomHeirsCertificateBranch"].ToString();
		formFreedom.FormFreedomDeadIssuanceCity = row["FormFreedomDeadIssuanceCity"].ToString();
		formFreedom.FormFreedomDeclarationRegisterNumber = row["FormFreedomDeclarationRegisterNumber"].ToString();
		formFreedom.FormFreedomDiagnosisNumber = row["FormFreedomDiagnosisNumber"].ToString();
		formFreedom.FormFreedomCourt = row["FormFreedomCourt"].ToString();
		formFreedom.FormFreedomBranch = row["FormFreedomBranch"].ToString();
		formFreedom.FormFreedomUser2FullName = row["FormFreedomUser2FullName"].ToString();
		formFreedom.FormFreedomApplicantIssuanceCity = row["FormFreedomApplicantIssuanceCity"].ToString();
		formFreedom.FormFreedomCommercialNumber = row["FormFreedomCommercialNumber"].ToString();
		formFreedom.FormFreedomDeadFullName = row["FormFreedomDeadFullName"].ToString();
		formFreedom.FormFreedomDeadFatherName = row["FormFreedomDeadFatherName"].ToString();
		formFreedom.FormFreedomDeadDeathCity = row["FormFreedomDeadDeathCity"].ToString();
		formFreedom.FormFreedomDeadCertificateNumber = row["FormFreedomDeadCertificateNumber"].ToString();
		formFreedom.FormFreedomRequestNumber = row["FormFreedomRequestNumber"].ToString();
		formFreedom.FormFreedomAddress = row["FormFreedomAddress"].ToString();
		formFreedom.FormFreedomApplicantFullName = row["FormFreedomApplicantFullName"].ToString();
		formFreedom.FormFreedomApplicantFatherName = row["FormFreedomApplicantFatherName"].ToString();
		formFreedom.FormFreedomApplicantBirthCity = row["FormFreedomApplicantBirthCity"].ToString();
		formFreedom.FormFreedomApplicantCertificateNumber = row["FormFreedomApplicantCertificateNumber"].ToString();
		formFreedom.FormFreedomTaxOfficeCode = (row["FormFreedomTaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["FormFreedomTaxOfficeCode"]) : 0 ;
		formFreedom.FormFreedomTaxGroupCode = (row["FormFreedomTaxGroupCode"] != DBNull.Value) ? Convert.ToInt32(row["FormFreedomTaxGroupCode"]) : 0 ;
		formFreedom.FormFreedomTaxUnitCode = (row["FormFreedomTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["FormFreedomTaxUnitCode"]) : 0 ;
		formFreedom.FormFreedomUser1Code = (row["FormFreedomUser1Code"] != DBNull.Value) ? Convert.ToInt32(row["FormFreedomUser1Code"]) : 0 ;
		formFreedom.FormFreedomUser2Code = (row["FormFreedomUser2Code"] != DBNull.Value) ? Convert.ToInt32(row["FormFreedomUser2Code"]) : 0 ;
		return formFreedom;
	}
	public List<FormHeritageBill> GetListFormHeritageBill(Int64 registerInformationID)
	{
		List<FormHeritageBill> listFormHeritageBill = new List<FormHeritageBill>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageBillRegisterInformationID", registerInformationID)
		};

		//Lets get the list of FormHeritageBill records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeritageBill_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formHeritageBill
				listFormHeritageBill = new List<FormHeritageBill>();

				//Now lets populate the FormHeritageBill details into the list of formHeritageBills
				foreach (DataRow row in table.Rows)
				{
					FormHeritageBill formHeritageBill = ConvertRowToFormHeritageBill(row);
					listFormHeritageBill.Add(formHeritageBill);
				}
			}
		}

		return listFormHeritageBill;
	}

	private FormHeritageBill ConvertRowToFormHeritageBill(DataRow row)
	{
		FormHeritageBill formHeritageBill = new FormHeritageBill();
		formHeritageBill.FormHeritageBillID = (row["FormHeritageBillID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillID"]) : 0 ;
		formHeritageBill.FormHeritageBillPrintRegisterInformationID = row["FormHeritageBillPrintRegisterInformationID"].ToString();
		formHeritageBill.FormHeritageBillPrintRegisterDate = row["FormHeritageBillPrintRegisterDate"].ToString();
		formHeritageBill.FormHeritageBillTaxTotalLetter = row["FormHeritageBillTaxTotalLetter"].ToString();
		formHeritageBill.FormHeritageBillUser1Code = row["FormHeritageBillUser1Code"].ToString();
		formHeritageBill.FormHeritageBillUser2Code = row["FormHeritageBillUser2Code"].ToString();
		formHeritageBill.FormHeritageBillTaxOfficeTitle = row["FormHeritageBillTaxOfficeTitle"].ToString();
		formHeritageBill.FormHeritageBillDeadFullName = row["FormHeritageBillDeadFullName"].ToString();
		formHeritageBill.FormHeritageBillDescriptions = row["FormHeritageBillDescriptions"].ToString();
		formHeritageBill.FormHeritageBillHeritageBill = row["FormHeritageBillHeritageBill"].ToString();
		formHeritageBill.FormHeritageBillRegisterInformationID = (row["FormHeritageBillRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillRegisterInformationID"]) : 0 ;
		formHeritageBill.FormHeritageBillDeclarationID = (row["FormHeritageBillDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillDeclarationID"]) : 0 ;
		formHeritageBill.FormHeritageBillRegisterarUserNationalCode = (row["FormHeritageBillRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillRegisterarUserNationalCode"]) : 0 ;
		formHeritageBill.FormHeritageBillDeadNationalCode = (row["FormHeritageBillDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageBillDeadNationalCode"]) : 0 ;
		formHeritageBill.FormHeritageBillDeadDeathDate = row["FormHeritageBillDeadDeathDate"].ToString();
		formHeritageBill.FormHeritageBillDossierClasses = row["FormHeritageBillDossierClasses"].ToString();
		formHeritageBill.FormHeritageBillRegisterInformationDate = row["FormHeritageBillRegisterInformationDate"].ToString();
		formHeritageBill.FormHeritageBillHeirsNumberSummury = row["FormHeritageBillHeirsNumberSummury"].ToString();
		formHeritageBill.FormHeritageBillHeirSharesSummury = row["FormHeritageBillHeirSharesSummury"].ToString();
		formHeritageBill.FormHeritageBillTaxDescription = row["FormHeritageBillTaxDescription"].ToString();
		formHeritageBill.FormHeritageBillBillType = row["FormHeritageBillBillType"].ToString();
		formHeritageBill.FormHeritageBillUser2FullName = row["FormHeritageBillUser2FullName"].ToString();
		formHeritageBill.FormHeritageBillUser1FullName = row["FormHeritageBillUser1FullName"].ToString();
		formHeritageBill.FormHeritageBillENZ = (row["FormHeritageBillENZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillENZ"]) : 0 ;
		formHeritageBill.FormHeritageBillANZ = (row["FormHeritageBillANZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillANZ"]) : 0 ;
		formHeritageBill.FormHeritageBillMNZ = (row["FormHeritageBillMNZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillMNZ"]) : 0 ;
		formHeritageBill.FormHeritageBillDMNZ = (row["FormHeritageBillDMNZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDMNZ"]) : 0 ;
		formHeritageBill.FormHeritageBillDENZ = (row["FormHeritageBillDENZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDENZ"]) : 0 ;
		formHeritageBill.FormHeritageBillDANZ = (row["FormHeritageBillDANZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDANZ"]) : 0 ;
		formHeritageBill.FormHeritageBillTotalValue = (row["FormHeritageBillTotalValue"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillTotalValue"]) : 0 ;
		formHeritageBill.FormHeritageBillTaxTotal = (row["FormHeritageBillTaxTotal"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillTaxTotal"]) : 0 ;
		formHeritageBill.FormHeritageBillDEKHZ = (row["FormHeritageBillDEKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDEKHZ"]) : 0 ;
		formHeritageBill.FormHeritageBillDAKHZ = (row["FormHeritageBillDAKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDAKHZ"]) : 0 ;
		formHeritageBill.FormHeritageBillDMKHZ = (row["FormHeritageBillDMKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillDMKHZ"]) : 0 ;
		formHeritageBill.FormHeritageBillE2KHZ = (row["FormHeritageBillE2KHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillE2KHZ"]) : 0 ;
		formHeritageBill.FormHeritageBillA2KHZ = (row["FormHeritageBillA2KHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillA2KHZ"]) : 0 ;
		formHeritageBill.FormHeritageBillM2KHZ = (row["FormHeritageBillM2KHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillM2KHZ"]) : 0 ;
		formHeritageBill.FormHeritageBillE2NZ = (row["FormHeritageBillE2NZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillE2NZ"]) : 0 ;
		formHeritageBill.FormHeritageBillA2NZ = (row["FormHeritageBillA2NZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillA2NZ"]) : 0 ;
		formHeritageBill.FormHeritageBillM2NZ = (row["FormHeritageBillM2NZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillM2NZ"]) : 0 ;
		formHeritageBill.FormHeritageBillEKHZ = (row["FormHeritageBillEKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillEKHZ"]) : 0 ;
		formHeritageBill.FormHeritageBillAKHZ = (row["FormHeritageBillAKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillAKHZ"]) : 0 ;
		formHeritageBill.FormHeritageBillMKHZ = (row["FormHeritageBillMKHZ"] != DBNull.Value) ? Convert.ToSingle(row["FormHeritageBillMKHZ"]) : 0 ;
		return formHeritageBill;
	}
	public List<FormHeritageEvaluation> GetListFormHeritageEvaluation(Int64 registerInformationID)
	{
		List<FormHeritageEvaluation> listFormHeritageEvaluation = new List<FormHeritageEvaluation>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@FormHeritageEvaluationRegisterInformationID", registerInformationID)
		};

		//Lets get the list of FormHeritageEvaluation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormHeritageEvaluation_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formHeritageEvaluation
				listFormHeritageEvaluation = new List<FormHeritageEvaluation>();

				//Now lets populate the FormHeritageEvaluation details into the list of formHeritageEvaluations
				foreach (DataRow row in table.Rows)
				{
					FormHeritageEvaluation formHeritageEvaluation = ConvertRowToFormHeritageEvaluation(row);
					listFormHeritageEvaluation.Add(formHeritageEvaluation);
				}
			}
		}

		return listFormHeritageEvaluation;
	}

	private FormHeritageEvaluation ConvertRowToFormHeritageEvaluation(DataRow row)
	{
		FormHeritageEvaluation formHeritageEvaluation = new FormHeritageEvaluation();
		formHeritageEvaluation.FormHeritageEvaluationID = (row["FormHeritageEvaluationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageEvaluationID"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationRegisterInformationID = (row["FormHeritageEvaluationRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageEvaluationRegisterInformationID"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationDeclarationID = (row["FormHeritageEvaluationDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageEvaluationDeclarationID"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationApplicantNationalCode = (row["FormHeritageEvaluationApplicantNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageEvaluationApplicantNationalCode"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationZipCode = (row["FormHeritageEvaluationZipCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageEvaluationZipCode"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationDeadNationalCode = (row["FormHeritageEvaluationDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormHeritageEvaluationDeadNationalCode"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationRegisterDate = row["FormHeritageEvaluationRegisterDate"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationApplicantBirthDate = row["FormHeritageEvaluationApplicantBirthDate"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDeadDeathDate = row["FormHeritageEvaluationDeadDeathDate"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDeadIssuanceDate = row["FormHeritageEvaluationDeadIssuanceDate"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDiagnosisReportDate = row["FormHeritageEvaluationDiagnosisReportDate"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationRequestDate = row["FormHeritageEvaluationRequestDate"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationTaxOfficeTitle = row["FormHeritageEvaluationTaxOfficeTitle"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationTaxOfficeAddress = row["FormHeritageEvaluationTaxOfficeAddress"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationTaxOfficePhoneNumber = row["FormHeritageEvaluationTaxOfficePhoneNumber"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationTaxOfficeZipCode = row["FormHeritageEvaluationTaxOfficeZipCode"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDossierClasses = row["FormHeritageEvaluationDossierClasses"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationApplicantFullName = row["FormHeritageEvaluationApplicantFullName"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDescription = row["FormHeritageEvaluationDescription"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationUser1FullName = row["FormHeritageEvaluationUser1FullName"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationUser2FullName = row["FormHeritageEvaluationUser2FullName"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationPhoneNumber = row["FormHeritageEvaluationPhoneNumber"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationApplicantRole = row["FormHeritageEvaluationApplicantRole"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDeadIssuanceCity = row["FormHeritageEvaluationDeadIssuanceCity"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDeadFullName = row["FormHeritageEvaluationDeadFullName"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDeadFatherName = row["FormHeritageEvaluationDeadFatherName"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDeadDeathCity = row["FormHeritageEvaluationDeadDeathCity"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDeadCertificateNumber = row["FormHeritageEvaluationDeadCertificateNumber"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationDiagnosisReportNumber = row["FormHeritageEvaluationDiagnosisReportNumber"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationRequestNumber = row["FormHeritageEvaluationRequestNumber"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationApplicantFatherName = row["FormHeritageEvaluationApplicantFatherName"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationApplicantBirthCity = row["FormHeritageEvaluationApplicantBirthCity"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationApplicantCertificateNumber = row["FormHeritageEvaluationApplicantCertificateNumber"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationApplicantIssuanceCity = row["FormHeritageEvaluationApplicantIssuanceCity"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationCommercialNumber = row["FormHeritageEvaluationCommercialNumber"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationAddress = row["FormHeritageEvaluationAddress"].ToString();
		formHeritageEvaluation.FormHeritageEvaluationTaxOfficeCode = (row["FormHeritageEvaluationTaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["FormHeritageEvaluationTaxOfficeCode"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationTaxGroupCode = (row["FormHeritageEvaluationTaxGroupCode"] != DBNull.Value) ? Convert.ToInt32(row["FormHeritageEvaluationTaxGroupCode"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationTaxUnitCode = (row["FormHeritageEvaluationTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["FormHeritageEvaluationTaxUnitCode"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationUser1Code = (row["FormHeritageEvaluationUser1Code"] != DBNull.Value) ? Convert.ToInt32(row["FormHeritageEvaluationUser1Code"]) : 0 ;
		formHeritageEvaluation.FormHeritageEvaluationUser2Code = (row["FormHeritageEvaluationUser2Code"] != DBNull.Value) ? Convert.ToInt32(row["FormHeritageEvaluationUser2Code"]) : 0 ;
		return formHeritageEvaluation;
	}
	public List<FormTaxBill> GetListFormTaxBill(Int64 registerInformationID)
	{
		List<FormTaxBill> listFormTaxBill = new List<FormTaxBill>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@FormTaxBillRegisterInformationID", registerInformationID)
		};

		//Lets get the list of FormTaxBill records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormTaxBill_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formTaxBill
				listFormTaxBill = new List<FormTaxBill>();

				//Now lets populate the FormTaxBill details into the list of formTaxBills
				foreach (DataRow row in table.Rows)
				{
					FormTaxBill formTaxBill = ConvertRowToFormTaxBill(row);
					listFormTaxBill.Add(formTaxBill);
				}
			}
		}

		return listFormTaxBill;
	}

	private FormTaxBill ConvertRowToFormTaxBill(DataRow row)
	{
		FormTaxBill formTaxBill = new FormTaxBill();
		formTaxBill.FormTaxBillID = (row["FormTaxBillID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillID"]) : 0 ;
		formTaxBill.FormTaxBillPrintRegisterDate = row["FormTaxBillPrintRegisterDate"].ToString();
		formTaxBill.FormTaxBillPrintRegisterInformationID = row["FormTaxBillPrintRegisterInformationID"].ToString();
		formTaxBill.FormTaxBillDossierClasses = row["FormTaxBillDossierClasses"].ToString();
		formTaxBill.FormTaxBillUser2Code = row["FormTaxBillUser2Code"].ToString();
		formTaxBill.FormTaxBillDescription = row["FormTaxBillDescription"].ToString();
		formTaxBill.FormTaxBillTaxTotalLetter = row["FormTaxBillTaxTotalLetter"].ToString();
		formTaxBill.FormTaxBillBillType = row["FormTaxBillBillType"].ToString();
		formTaxBill.FormTaxBillTaxTotalDescription = row["FormTaxBillTaxTotalDescription"].ToString();
		formTaxBill.FormTaxBillTaxTypeA = (row["FormTaxBillTaxTypeA"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTaxTypeA"]) : 0 ;
		formTaxBill.FormTaxBillTaxTypeB = (row["FormTaxBillTaxTypeB"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTaxTypeB"]) : 0 ;
		formTaxBill.FormTaxBillTaxTotal = (row["FormTaxBillTaxTotal"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTaxTotal"]) : 0 ;
		formTaxBill.FormTaxBillTotalShare = (row["FormTaxBillTotalShare"] != DBNull.Value) ? Convert.ToSingle(row["FormTaxBillTotalShare"]) : 0 ;
		formTaxBill.FormTaxBillDeclarationID = (row["FormTaxBillDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillDeclarationID"]) : 0 ;
		formTaxBill.FormTaxBillRegisterInformationID = (row["FormTaxBillRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillRegisterInformationID"]) : 0 ;
		formTaxBill.FormTaxBillRegisterarUserNationalCode = (row["FormTaxBillRegisterarUserNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillRegisterarUserNationalCode"]) : 0 ;
		formTaxBill.FormTaxBillDeadNationalCode = (row["FormTaxBillDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxBillDeadNationalCode"]) : 0 ;
		formTaxBill.FormTaxBillDeadDeathDate = row["FormTaxBillDeadDeathDate"].ToString();
		formTaxBill.FormTaxBillRegisterInformationDate = row["FormTaxBillRegisterInformationDate"].ToString();
		formTaxBill.FormTaxBillTaxOfficeTitle = row["FormTaxBillTaxOfficeTitle"].ToString();
		formTaxBill.FormTaxBillDeadFullName = row["FormTaxBillDeadFullName"].ToString();
		formTaxBill.FormTaxBillHeirsNumberSummury = row["FormTaxBillHeirsNumberSummury"].ToString();
		formTaxBill.FormTaxBillUser2FullName = row["FormTaxBillUser2FullName"].ToString();
		formTaxBill.FormTaxBillUser1FullName = row["FormTaxBillUser1FullName"].ToString();
		formTaxBill.FormTaxBillUser1Code = row["FormTaxBillUser1Code"].ToString();
		return formTaxBill;
	}
	public List<FormTaxPaymentCertificate> GetListFormTaxPaymentCertificate(Int64 registerInformationID)
	{
		List<FormTaxPaymentCertificate> listFormTaxPaymentCertificate = new List<FormTaxPaymentCertificate>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@FormTaxPayementCertificateRegisterInformationID", registerInformationID)
		};

		//Lets get the list of FormTaxPaymentCertificate records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("FormTaxPaymentCertificate_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of formTaxPaymentCertificate
				listFormTaxPaymentCertificate = new List<FormTaxPaymentCertificate>();

				//Now lets populate the FormTaxPaymentCertificate details into the list of formTaxPaymentCertificates
				foreach (DataRow row in table.Rows)
				{
					FormTaxPaymentCertificate formTaxPaymentCertificate = ConvertRowToFormTaxPaymentCertificate(row);
					listFormTaxPaymentCertificate.Add(formTaxPaymentCertificate);
				}
			}
		}

		return listFormTaxPaymentCertificate;
	}

	private FormTaxPaymentCertificate ConvertRowToFormTaxPaymentCertificate(DataRow row)
	{
		FormTaxPaymentCertificate formTaxPaymentCertificate = new FormTaxPaymentCertificate();
		formTaxPaymentCertificate.FormTaxPayementCertificateID = (row["FormTaxPayementCertificateID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateID"]) : 0 ;
		formTaxPaymentCertificate.FormTaxPayementCertificatePrintRegisterDate = row["FormTaxPayementCertificatePrintRegisterDate"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificatePrintRegisterInformationID = row["FormTaxPayementCertificatePrintRegisterInformationID"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeathMounth = row["FormTaxPayementCertificateDeathMounth"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeathYear = row["FormTaxPayementCertificateDeathYear"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeathCity = row["FormTaxPayementCertificateDeathCity"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDescription1 = row["FormTaxPayementCertificateDescription1"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDescription2 = row["FormTaxPayementCertificateDescription2"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDescription3 = row["FormTaxPayementCertificateDescription3"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateSource = row["FormTaxPayementCertificateHeirsCertificateSource"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateBranch = row["FormTaxPayementCertificateHeirsCertificateBranch"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeadName = row["FormTaxPayementCertificateDeadName"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeadLastName = row["FormTaxPayementCertificateDeadLastName"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeadCertificateNumber = row["FormTaxPayementCertificateDeadCertificateNumber"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeathDay = row["FormTaxPayementCertificateDeathDay"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateIssuanceCity = row["FormTaxPayementCertificateIssuanceCity"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestNumber = row["FormTaxPayementCertificateDeclarationRequestNumber"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestResource = row["FormTaxPayementCertificateDeclarationRequestResource"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateApplicantFullName = row["FormTaxPayementCertificateApplicantFullName"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateApplicantFatherName = row["FormTaxPayementCertificateApplicantFatherName"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDescription4 = row["FormTaxPayementCertificateDescription4"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDescriptionHeritage = row["FormTaxPayementCertificateDescriptionHeritage"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateRequestNumber = row["FormTaxPayementCertificateRequestNumber"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateUser1FullName = row["FormTaxPayementCertificateUser1FullName"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateUser2FullName = row["FormTaxPayementCertificateUser2FullName"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateRegisterInformationID = (row["FormTaxPayementCertificateRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateRegisterInformationID"]) : 0 ;
		formTaxPaymentCertificate.FormTaxPayementCertificateDeadNationalCode = (row["FormTaxPayementCertificateDeadNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateDeadNationalCode"]) : 0 ;
		formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationID = (row["FormTaxPayementCertificateDeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateDeclarationID"]) : 0 ;
		formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeZipCode = (row["FormTaxPayementCertificateTaxOfficeZipCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateTaxOfficeZipCode"]) : 0 ;
		formTaxPaymentCertificate.FormTaxPayementCertificateApplicantNationalCode = (row["FormTaxPayementCertificateApplicantNationalCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateApplicantNationalCode"]) : 0 ;
		formTaxPaymentCertificate.FormTaxPayementCertificateZipCode = (row["FormTaxPayementCertificateZipCode"] != DBNull.Value) ? Convert.ToInt64(row["FormTaxPayementCertificateZipCode"]) : 0 ;
		formTaxPaymentCertificate.FormTaxPayementCertificateApplicantName = row["FormTaxPayementCertificateApplicantName"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateRegisterDate = row["FormTaxPayementCertificateRegisterDate"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateDate = row["FormTaxPayementCertificateHeirsCertificateDate"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateRequestDate = row["FormTaxPayementCertificateRequestDate"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeclarationRequestDate = row["FormTaxPayementCertificateDeclarationRequestDate"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateApplicantBirthDate = row["FormTaxPayementCertificateApplicantBirthDate"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDossierClasses = row["FormTaxPayementCertificateDossierClasses"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeTitle = row["FormTaxPayementCertificateTaxOfficeTitle"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeCity = row["FormTaxPayementCertificateTaxOfficeCity"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeAddress = row["FormTaxPayementCertificateTaxOfficeAddress"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficePhoneNumber = row["FormTaxPayementCertificateTaxOfficePhoneNumber"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateHeirsCertificateNumber = row["FormTaxPayementCertificateHeirsCertificateNumber"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeadFatherName = row["FormTaxPayementCertificateDeadFatherName"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificatePhoneNumber = row["FormTaxPayementCertificatePhoneNumber"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateDeadIssuanceCity = row["FormTaxPayementCertificateDeadIssuanceCity"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateApplicantBirthCity = row["FormTaxPayementCertificateApplicantBirthCity"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateApplicantCertificateNumber = row["FormTaxPayementCertificateApplicantCertificateNumber"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateApplicantIssuanceCity = row["FormTaxPayementCertificateApplicantIssuanceCity"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateApplicantRole = row["FormTaxPayementCertificateApplicantRole"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateAddress = row["FormTaxPayementCertificateAddress"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateCommercialNumer = row["FormTaxPayementCertificateCommercialNumer"].ToString();
		formTaxPaymentCertificate.FormTaxPayementCertificateTaxOfficeCode = (row["FormTaxPayementCertificateTaxOfficeCode"] != DBNull.Value) ? Convert.ToInt32(row["FormTaxPayementCertificateTaxOfficeCode"]) : 0 ;
		formTaxPaymentCertificate.FormTaxPayementCertificateTaxGroupCode = (row["FormTaxPayementCertificateTaxGroupCode"] != DBNull.Value) ? Convert.ToInt32(row["FormTaxPayementCertificateTaxGroupCode"]) : 0 ;
		formTaxPaymentCertificate.FormTaxPayementCertificateTaxUnitCode = (row["FormTaxPayementCertificateTaxUnitCode"] != DBNull.Value) ? Convert.ToInt32(row["FormTaxPayementCertificateTaxUnitCode"]) : 0 ;
		return formTaxPaymentCertificate;
	}
	public List<Heir> GetListHeir(Int64 registerInformationID)
	{
		List<Heir> listHeir = new List<Heir>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", registerInformationID)
		};

		//Lets get the list of Heir records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Heir_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of heir
				listHeir = new List<Heir>();

				//Now lets populate the Heir details into the list of heirs
				foreach (DataRow row in table.Rows)
				{
					Heir heir = ConvertRowToHeir(row);
					listHeir.Add(heir);
				}
			}
		}

		return listHeir;
	}

	private Heir ConvertRowToHeir(DataRow row)
	{
		Heir heir = new Heir();
		heir.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
		heir.RelationIDTitle = row["RelationIDTitle"].ToString();
		heir.EducationStateIDTitle = row["EducationStateIDTitle"].ToString();
		heir.MarriageIDTitle = row["MarriageIDTitle"].ToString();
		heir.NationalityIDTitle = row["NationalityIDTitle"].ToString();
		heir.PhysicalStateIDTitle = row["PhysicalStateIDTitle"].ToString();
		heir.ResidenceIDTitle = row["ResidenceIDTitle"].ToString();
		heir.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		heir.OldRegisterDate = row["OldRegisterDate"].ToString();
		heir.RelationID = (row["RelationID"] != DBNull.Value) ? Convert.ToInt32(row["RelationID"]) : 0 ;
		heir.NationalityID = (row["NationalityID"] != DBNull.Value) ? Convert.ToInt32(row["NationalityID"]) : 0 ;
		heir.ResidenceID = (row["ResidenceID"] != DBNull.Value) ? Convert.ToInt32(row["ResidenceID"]) : 0 ;
		heir.PhysicalStateID = (row["PhysicalStateID"] != DBNull.Value) ? Convert.ToInt32(row["PhysicalStateID"]) : 0 ;
		heir.EducationStateID = (row["EducationStateID"] != DBNull.Value) ? Convert.ToInt32(row["EducationStateID"]) : 0 ;
		heir.MarriageID = (row["MarriageID"] != DBNull.Value) ? Convert.ToInt32(row["MarriageID"]) : 0 ;
		heir.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		heir.AgreementTypeID = (row["AgreementTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AgreementTypeID"]) : 0 ;
		heir.DeclerativeShare = (row["DeclerativeShare"] != DBNull.Value) ? Convert.ToSingle(row["DeclerativeShare"]) : 0 ;
		heir.DiagnosisShare = (row["DiagnosisShare"] != DBNull.Value) ? Convert.ToSingle(row["DiagnosisShare"]) : 0 ;
		heir.HandShare = (row["HandShare"] != DBNull.Value) ? Convert.ToSingle(row["HandShare"]) : 0 ;
		heir.AdjustmentTaxValue = (row["AdjustmentTaxValue"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentTaxValue"]) : 0 ;
		heir.AdjustmentIncomeValue = (row["AdjustmentIncomeValue"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentIncomeValue"]) : 0 ;
		heir.CommissionAdjustmentShareValue1 = (row["CommissionAdjustmentShareValue1"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue1"]) : 0 ;
		heir.CommissionAdjustmentIncomeValue4 = (row["CommissionAdjustmentIncomeValue4"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue4"]) : 0 ;
		heir.CommissionAdjustmentShareValue5 = (row["CommissionAdjustmentShareValue5"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue5"]) : 0 ;
		heir.CommissionAdjustmentIncomeValue5 = (row["CommissionAdjustmentIncomeValue5"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue5"]) : 0 ;
		heir.CommissionAdjustmentShareValue6 = (row["CommissionAdjustmentShareValue6"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue6"]) : 0 ;
		heir.CommissionAdjustmentIncomeValue6 = (row["CommissionAdjustmentIncomeValue6"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue6"]) : 0 ;
		heir.CommissionAdjustmentIncomeValue1 = (row["CommissionAdjustmentIncomeValue1"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue1"]) : 0 ;
		heir.CommissionAdjustmentShareValue2 = (row["CommissionAdjustmentShareValue2"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue2"]) : 0 ;
		heir.CommissionAdjustmentIncomeValue2 = (row["CommissionAdjustmentIncomeValue2"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue2"]) : 0 ;
		heir.CommissionAdjustmentShareValue3 = (row["CommissionAdjustmentShareValue3"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue3"]) : 0 ;
		heir.CommissionAdjustmentIncomeValue3 = (row["CommissionAdjustmentIncomeValue3"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue3"]) : 0 ;
		heir.CommissionAdjustmentShareValue4 = (row["CommissionAdjustmentShareValue4"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue4"]) : 0 ;
		heir.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		heir.ParentHeirID = (row["ParentHeirID"] != DBNull.Value) ? Convert.ToInt64(row["ParentHeirID"]) : 0 ;
		heir.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		heir.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		heir.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		heir.AdjustmentTaxRegisterInformationID = (row["AdjustmentTaxRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentTaxRegisterInformationID"]) : 0 ;
		heir.CommissionAdjustmentIncomeRegisterInformationID5 = (row["CommissionAdjustmentIncomeRegisterInformationID5"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID5"]) : 0 ;
		heir.CommissionAdjustmentShareRegisterInformationID6 = (row["CommissionAdjustmentShareRegisterInformationID6"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID6"]) : 0 ;
		heir.CommissionAdjustmentIncomeRegisterInformationID6 = (row["CommissionAdjustmentIncomeRegisterInformationID6"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID6"]) : 0 ;
		heir.CommissionAdjustmentIncomeRegisterInformationID2 = (row["CommissionAdjustmentIncomeRegisterInformationID2"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID2"]) : 0 ;
		heir.CommissionAdjustmentShareRegisterInformationID3 = (row["CommissionAdjustmentShareRegisterInformationID3"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID3"]) : 0 ;
		heir.CommissionAdjustmentIncomeRegisterInformationID3 = (row["CommissionAdjustmentIncomeRegisterInformationID3"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID3"]) : 0 ;
		heir.CommissionAdjustmentShareRegisterInformationID4 = (row["CommissionAdjustmentShareRegisterInformationID4"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID4"]) : 0 ;
		heir.CommissionAdjustmentIncomeRegisterInformationID4 = (row["CommissionAdjustmentIncomeRegisterInformationID4"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID4"]) : 0 ;
		heir.CommissionAdjustmentShareRegisterInformationID5 = (row["CommissionAdjustmentShareRegisterInformationID5"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID5"]) : 0 ;
		heir.AdjustmentIncomeRegisterInformationID = (row["AdjustmentIncomeRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentIncomeRegisterInformationID"]) : 0 ;
		heir.CommissionAdjustmentShareRegisterInformationID1 = (row["CommissionAdjustmentShareRegisterInformationID1"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID1"]) : 0 ;
		heir.CommissionAdjustmentIncomeRegisterInformationID1 = (row["CommissionAdjustmentIncomeRegisterInformationID1"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID1"]) : 0 ;
		heir.AdjustmentHeritageRegisterInformationID = (row["AdjustmentHeritageRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentHeritageRegisterInformationID"]) : 0 ;
		heir.CommissionAdjustmentHeritageRegisterInformationID = (row["CommissionAdjustmentHeritageRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentHeritageRegisterInformationID"]) : 0 ;
		heir.CommissionAdjustmentShareRegisterInformationID2 = (row["CommissionAdjustmentShareRegisterInformationID2"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID2"]) : 0 ;
		heir.AdjustmentTaxDate = row["AdjustmentTaxDate"].ToString();
		heir.AdjustmentIncomeDate = row["AdjustmentIncomeDate"].ToString();
		heir.CommissionAdjustmentShareDate1 = row["CommissionAdjustmentShareDate1"].ToString();
		heir.CommissionAdjustmentIncomeDate1 = row["CommissionAdjustmentIncomeDate1"].ToString();
		heir.AdjustmentHeritageDate = row["AdjustmentHeritageDate"].ToString();
		heir.CommissionAdjustmentHeritageDate = row["CommissionAdjustmentHeritageDate"].ToString();
		heir.CommissionAdjustmentIncomeDate4 = row["CommissionAdjustmentIncomeDate4"].ToString();
		heir.CommissionAdjustmentShareDate5 = row["CommissionAdjustmentShareDate5"].ToString();
		heir.CommissionAdjustmentIncomeDate5 = row["CommissionAdjustmentIncomeDate5"].ToString();
		heir.CommissionAdjustmentShareDate6 = row["CommissionAdjustmentShareDate6"].ToString();
		heir.CommissionAdjustmentIncomeDate6 = row["CommissionAdjustmentIncomeDate6"].ToString();
		heir.AdjustmentFinalizationDate = row["AdjustmentFinalizationDate"].ToString();
		heir.CommissionAdjustmentShareDate2 = row["CommissionAdjustmentShareDate2"].ToString();
		heir.CommissionAdjustmentIncomeDate2 = row["CommissionAdjustmentIncomeDate2"].ToString();
		heir.CommissionAdjustmentShareDate3 = row["CommissionAdjustmentShareDate3"].ToString();
		heir.CommissionAdjustmentIncomeDate3 = row["CommissionAdjustmentIncomeDate3"].ToString();
		heir.CommissionAdjustmentShareDate4 = row["CommissionAdjustmentShareDate4"].ToString();

		heir.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
		heir.PrintNationalCode = row["PrintNationalCode"].ToString();
		heir.FullName = row["FullName"].ToString();
		heir.GenderIDTitle = row["GenderIDTitle"].ToString();
		heir.Religion_DinIDTitle = row["Religion_DinIDTitle"].ToString();
		heir.Religion_MazhabIDTitle = row["Religion_MazhabIDTitle"].ToString();
		heir.IssuanceProvinceIDTitle = row["IssuanceProvinceIDTitle"].ToString();
		heir.IssuanceCityIDTitle = row["IssuanceCityIDTitle"].ToString();
		heir.IssuanceDepartment = row["IssuanceDepartment"].ToString();
		heir.CertificateNumber = row["CertificateNumber"].ToString();
		heir.CertificateSerial = row["CertificateSerial"].ToString();
		heir.ZipCode = row["ZipCode"].ToString();
		heir.HomeAddress = row["HomeAddress"].ToString();
		heir.PhoneNumber = row["PhoneNumber"].ToString();
		heir.Job = row["Job"].ToString();
		heir.JobAddress = row["JobAddress"].ToString();
		heir.JobPhoneNumber = row["JobPhoneNumber"].ToString();
		heir.Comment = row["Comment"].ToString();
		heir.BirthCity = row["BirthCity"].ToString();
		heir.JobZipCode = row["JobZipCode"].ToString();
		heir.CertificateSerialLetter = row["CertificateSerialLetter"].ToString();
		heir.CertificateSerialNumber = row["CertificateSerialNumber"].ToString();
		heir.FatherName = row["FatherName"].ToString();
		heir.Name = row["Name"].ToString();
		heir.Family = row["Family"].ToString();
		heir.BirthDate = row["BirthDate"].ToString();
		heir.IssuanceDate = row["IssuanceDate"].ToString();
		heir.GenderID = (row["GenderID"] != DBNull.Value) ? Convert.ToInt32(row["GenderID"]) : 0 ;
		heir.IssuanceProvinceID = (row["IssuanceProvinceID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceProvinceID"]) : 0 ;
		heir.IssuanceCityID = (row["IssuanceCityID"] != DBNull.Value) ? Convert.ToInt32(row["IssuanceCityID"]) : 0 ;
		heir.Religion_DinID = (row["Religion_DinID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_DinID"]) : 0 ;
		heir.Religion_MazhabID = (row["Religion_MazhabID"] != DBNull.Value) ? Convert.ToInt32(row["Religion_MazhabID"]) : 0 ;
		return heir;
	}
	public List<InquiryResponse> GetListInquiryResponse(Int64 registerInformationID)
	{
		List<InquiryResponse> listInquiryResponse = new List<InquiryResponse>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", registerInformationID)
		};

		//Lets get the list of InquiryResponse records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("InquiryResponse_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of inquiryResponse
				listInquiryResponse = new List<InquiryResponse>();

				//Now lets populate the InquiryResponse details into the list of inquiryResponses
				foreach (DataRow row in table.Rows)
				{
					InquiryResponse inquiryResponse = ConvertRowToInquiryResponse(row);
					listInquiryResponse.Add(inquiryResponse);
				}
			}
		}

		return listInquiryResponse;
	}

	private InquiryResponse ConvertRowToInquiryResponse(DataRow row)
	{
		InquiryResponse inquiryResponse = new InquiryResponse();
		inquiryResponse.InquiryResponseID = (row["InquiryResponseID"] != DBNull.Value) ? Convert.ToInt64(row["InquiryResponseID"]) : 0 ;
		inquiryResponse.RegisterDate = row["RegisterDate"].ToString();
		inquiryResponse.OldRegisterDate = row["OldRegisterDate"].ToString();
		inquiryResponse.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		inquiryResponse.Owner = row["Owner"].ToString();
		inquiryResponse.Number = row["Number"].ToString();
		inquiryResponse.Comments = row["Comments"].ToString();
		inquiryResponse.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		inquiryResponse.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		inquiryResponse.ResponseDate = row["ResponseDate"].ToString();
		return inquiryResponse;
	}
	public List<ReDiagnosisRequest> GetListReDiagnosisRequest(Int64 registerInformationID)
	{
		List<ReDiagnosisRequest> listReDiagnosisRequest = new List<ReDiagnosisRequest>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", registerInformationID)
		};

		//Lets get the list of ReDiagnosisRequest records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("ReDiagnosisRequest_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of reDiagnosisRequest
				listReDiagnosisRequest = new List<ReDiagnosisRequest>();

				//Now lets populate the ReDiagnosisRequest details into the list of reDiagnosisRequests
				foreach (DataRow row in table.Rows)
				{
					ReDiagnosisRequest reDiagnosisRequest = ConvertRowToReDiagnosisRequest(row);
					listReDiagnosisRequest.Add(reDiagnosisRequest);
				}
			}
		}

		return listReDiagnosisRequest;
	}

	private ReDiagnosisRequest ConvertRowToReDiagnosisRequest(DataRow row)
	{
		ReDiagnosisRequest reDiagnosisRequest = new ReDiagnosisRequest();
		reDiagnosisRequest.ReDiagnosisRequestID = (row["ReDiagnosisRequestID"] != DBNull.Value) ? Convert.ToInt64(row["ReDiagnosisRequestID"]) : 0 ;
		reDiagnosisRequest.PrintRegisterDate = row["PrintRegisterDate"].ToString();
		reDiagnosisRequest.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		reDiagnosisRequest.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		reDiagnosisRequest.RequestDate = row["RequestDate"].ToString();
		return reDiagnosisRequest;
	}
	public List<Reports> GetListReports(Int64 registerInformationID)
	{
		List<Reports> listReports = new List<Reports>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", registerInformationID)
		};

		//Lets get the list of Reports records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Reports_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
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
	public List<Utterer> GetListUtterer(Int64 registerInformationID)
	{
		List<Utterer> listUtterer = new List<Utterer>() { };
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", registerInformationID)
		};

		//Lets get the list of Utterer records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Utterer_GetList_UseInRegisterInformation", CommandType.StoredProcedure, parametersRegisterInformation))
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
	public Int64 Insert(RegisterInformation registerInformation)
	{
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@RegisterTypeID", (registerInformation.RegisterTypeID > 0) ? registerInformation.RegisterTypeID : (object)DBNull.Value),
			new SqlParameter("@UserID", (registerInformation.UserID != null) ? registerInformation.UserID : (object)DBNull.Value),
			new SqlParameter("@OldID", (registerInformation.OldID != null) ? registerInformation.OldID : (object)DBNull.Value),
			new SqlParameter("@OldRegisterInformationID", (registerInformation.OldRegisterInformationID != null) ? registerInformation.OldRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@RegisterDate", (registerInformation.RegisterDate != null) ? registerInformation.RegisterDate : (object)DBNull.Value),
			new SqlParameter("@RegisterTime", (registerInformation.RegisterTime != null) ? registerInformation.RegisterTime : (object)DBNull.Value),
			new SqlParameter("@OldRegisterDate", (registerInformation.OldRegisterDate != null) ? registerInformation.OldRegisterDate : (object)DBNull.Value)
		};
		registerInformation.RegisterInformationID = SqlDBHelper.ExecuteScalar("RegisterInformation_Insert", CommandType.StoredProcedure, parametersRegisterInformation);
		return registerInformation.RegisterInformationID;
	}

	public bool Update(RegisterInformation registerInformation)
	{
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", registerInformation.RegisterInformationID),
			new SqlParameter("@RegisterTypeID", (registerInformation.RegisterTypeID != null && registerInformation.RegisterTypeID >0 ) ? registerInformation.RegisterTypeID : (object)DBNull.Value),
			new SqlParameter("@UserID", (registerInformation.UserID != null) ? registerInformation.UserID : (object)DBNull.Value),
			new SqlParameter("@OldID", (registerInformation.OldID != null) ? registerInformation.OldID : (object)DBNull.Value),
			new SqlParameter("@OldRegisterInformationID", (registerInformation.OldRegisterInformationID != null) ? registerInformation.OldRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@RegisterDate", (registerInformation.RegisterDate != null) ? registerInformation.RegisterDate : (object)DBNull.Value),
			new SqlParameter("@RegisterTime", (registerInformation.RegisterTime != null) ? registerInformation.RegisterTime : (object)DBNull.Value),
			new SqlParameter("@OldRegisterDate", (registerInformation.OldRegisterDate != null) ? registerInformation.OldRegisterDate : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("RegisterInformation_Update", CommandType.StoredProcedure, parametersRegisterInformation);
	}

	public bool Delete(Int64 registerInformationID)
	{
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", registerInformationID)
		};
		return SqlDBHelper.ExecuteNonQuery("RegisterInformation_Delete", CommandType.StoredProcedure, parametersRegisterInformation);
	}

	public RegisterInformation GetDetails(Int64 registerInformationID)
	{
		RegisterInformation registerInformation = new RegisterInformation();

		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", registerInformationID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RegisterInformation_GetDetails", CommandType.StoredProcedure, parametersRegisterInformation))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				registerInformation.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
				registerInformation.RegisterTypeIDTitle = row["RegisterTypeIDTitle"].ToString();
				registerInformation.RegisterTypeID = (row["RegisterTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RegisterTypeID"]) : 0 ;
				registerInformation.UserID = (row["UserID"] != DBNull.Value) ? Convert.ToInt64(row["UserID"]) : 0 ;
				registerInformation.OldID = (row["OldID"] != DBNull.Value) ? Convert.ToInt64(row["OldID"]) : 0 ;
				registerInformation.OldRegisterInformationID = (row["OldRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["OldRegisterInformationID"]) : 0 ;
				registerInformation.RegisterDate = row["RegisterDate"].ToString();
				registerInformation.RegisterTime = row["RegisterTime"].ToString();
				registerInformation.OldRegisterDate = row["OldRegisterDate"].ToString();
			}
		}

		return registerInformation;
	}

	public List<RegisterInformation> GetListAll()
	{
		List<RegisterInformation> listRegisterInformation = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("RegisterInformation_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listRegisterInformation = new List<RegisterInformation>();

				foreach (DataRow row in table.Rows)
				{
					RegisterInformation registerInformation = new RegisterInformation();
					registerInformation.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					registerInformation.RegisterTypeIDTitle = row["RegisterTypeIDTitle"].ToString();
					registerInformation.RegisterTypeID = (row["RegisterTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RegisterTypeID"]) : 0 ;
					registerInformation.UserID = (row["UserID"] != DBNull.Value) ? Convert.ToInt64(row["UserID"]) : 0 ;
					registerInformation.OldID = (row["OldID"] != DBNull.Value) ? Convert.ToInt64(row["OldID"]) : 0 ;
					registerInformation.OldRegisterInformationID = (row["OldRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["OldRegisterInformationID"]) : 0 ;
					registerInformation.RegisterDate = row["RegisterDate"].ToString();
					registerInformation.RegisterTime = row["RegisterTime"].ToString();
					registerInformation.OldRegisterDate = row["OldRegisterDate"].ToString();
					listRegisterInformation.Add(registerInformation);
				}
			}
		}

		return listRegisterInformation;
	}

	public bool Exists(Int64 registerInformationID)
	{
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", registerInformationID)
		};
		return (SqlDBHelper.ExecuteScalar("RegisterInformation_Exists", CommandType.StoredProcedure, parametersRegisterInformation)>0);
	}

	public bool Exists(RegisterInformation registerInformation)
	{
		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", registerInformation.RegisterInformationID)
		};
		return (SqlDBHelper.ExecuteScalar("RegisterInformation_Exists", CommandType.StoredProcedure, parametersRegisterInformation)>0);
	}

	public List<RegisterInformation> SearchLike(RegisterInformation registerInformation)
	{
		List<RegisterInformation> listRegisterInformation = new List<RegisterInformation>();


		SqlParameter[] parametersRegisterInformation = new SqlParameter[]
		{
			new SqlParameter("@RegisterInformationID", registerInformation.RegisterInformationID),
			new SqlParameter("@RegisterTypeIDTitle", registerInformation.RegisterTypeIDTitle),
			new SqlParameter("@RegisterTypeID", registerInformation.RegisterTypeID),
			new SqlParameter("@UserID", registerInformation.UserID),
			new SqlParameter("@OldID", registerInformation.OldID),
			new SqlParameter("@OldRegisterInformationID", registerInformation.OldRegisterInformationID),
			new SqlParameter("@RegisterDate", registerInformation.RegisterDate),
			new SqlParameter("@RegisterTime", registerInformation.RegisterTime),
			new SqlParameter("@OldRegisterDate", registerInformation.OldRegisterDate),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RegisterInformation_SearchLike", CommandType.StoredProcedure, parametersRegisterInformation))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					RegisterInformation tmpRegisterInformation = new RegisterInformation();
					tmpRegisterInformation.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					tmpRegisterInformation.RegisterTypeIDTitle = row["RegisterTypeIDTitle"].ToString();
					tmpRegisterInformation.RegisterTypeID = (row["RegisterTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RegisterTypeID"]) : 0 ;
					tmpRegisterInformation.UserID = (row["UserID"] != DBNull.Value) ? Convert.ToInt64(row["UserID"]) : 0 ;
					tmpRegisterInformation.OldID = (row["OldID"] != DBNull.Value) ? Convert.ToInt64(row["OldID"]) : 0 ;
					tmpRegisterInformation.OldRegisterInformationID = (row["OldRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["OldRegisterInformationID"]) : 0 ;
					tmpRegisterInformation.RegisterDate = row["RegisterDate"].ToString();
					tmpRegisterInformation.RegisterTime = row["RegisterTime"].ToString();
					tmpRegisterInformation.OldRegisterDate = row["OldRegisterDate"].ToString();

					listRegisterInformation.Add(tmpRegisterInformation);
				}
			}
		}

		return listRegisterInformation;
	}

}
}
