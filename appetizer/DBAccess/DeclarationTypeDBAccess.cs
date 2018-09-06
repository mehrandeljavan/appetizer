using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class DeclarationTypeDBAccess
{

	DeclarationDBAccess declarationDBAccess = new DeclarationDBAccess();

	public List<Declaration> GetListDeclaration(int declarationTypeID)
	{
		List<Declaration> listDeclaration = new List<Declaration>() { };
		SqlParameter[] parametersDeclarationType = new SqlParameter[]
		{
			new SqlParameter("@DeclarationTypeID", declarationTypeID)
		};

		//Lets get the list of Declaration records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Declaration_GetList_UseInDeclarationType", CommandType.StoredProcedure, parametersDeclarationType))
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
	public Int64 Insert(DeclarationType declarationType)
	{
		SqlParameter[] parametersDeclarationType = new SqlParameter[]
		{
			new SqlParameter("@Title", (declarationType.Title != null) ? declarationType.Title : (object)DBNull.Value)
		};
		declarationType.DeclarationTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("DeclarationType_Insert", CommandType.StoredProcedure, parametersDeclarationType));
		return declarationType.DeclarationTypeID;
	}

	public bool Update(DeclarationType declarationType)
	{
		SqlParameter[] parametersDeclarationType = new SqlParameter[]
		{
			new SqlParameter("@DeclarationTypeID", declarationType.DeclarationTypeID),
			new SqlParameter("@Title", (declarationType.Title != null) ? declarationType.Title : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("DeclarationType_Update", CommandType.StoredProcedure, parametersDeclarationType);
	}

	public bool Delete(int declarationTypeID)
	{
		SqlParameter[] parametersDeclarationType = new SqlParameter[]
		{
			new SqlParameter("@DeclarationTypeID", declarationTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("DeclarationType_Delete", CommandType.StoredProcedure, parametersDeclarationType);
	}

	public DeclarationType GetDetails(int declarationTypeID)
	{
		DeclarationType declarationType = new DeclarationType();

		SqlParameter[] parametersDeclarationType = new SqlParameter[]
		{
			new SqlParameter("@DeclarationTypeID", declarationTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DeclarationType_GetDetails", CommandType.StoredProcedure, parametersDeclarationType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				declarationType.DeclarationTypeID = (row["DeclarationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DeclarationTypeID"]) : 0 ;
				declarationType.Title = row["Title"].ToString();
			}
		}

		return declarationType;
	}

	public List<DeclarationType> GetListAll()
	{
		List<DeclarationType> listDeclarationType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("DeclarationType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listDeclarationType = new List<DeclarationType>();

				foreach (DataRow row in table.Rows)
				{
					DeclarationType declarationType = new DeclarationType();
					declarationType.DeclarationTypeID = (row["DeclarationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DeclarationTypeID"]) : 0 ;
					declarationType.Title = row["Title"].ToString();
					listDeclarationType.Add(declarationType);
				}
			}
		}

		return listDeclarationType;
	}

	public bool Exists(int declarationTypeID)
	{
		SqlParameter[] parametersDeclarationType = new SqlParameter[]
		{
			new SqlParameter("@DeclarationTypeID", declarationTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("DeclarationType_Exists", CommandType.StoredProcedure, parametersDeclarationType)>0);
	}

	public bool Exists(DeclarationType declarationType)
	{
		SqlParameter[] parametersDeclarationType = new SqlParameter[]
		{
			new SqlParameter("@DeclarationTypeID", declarationType.DeclarationTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("DeclarationType_Exists", CommandType.StoredProcedure, parametersDeclarationType)>0);
	}

	public List<DeclarationType> SearchLike(DeclarationType declarationType)
	{
		List<DeclarationType> listDeclarationType = new List<DeclarationType>();


		SqlParameter[] parametersDeclarationType = new SqlParameter[]
		{
			new SqlParameter("@DeclarationTypeID", declarationType.DeclarationTypeID),
			new SqlParameter("@Title", declarationType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DeclarationType_SearchLike", CommandType.StoredProcedure, parametersDeclarationType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					DeclarationType tmpDeclarationType = new DeclarationType();
					tmpDeclarationType.DeclarationTypeID = (row["DeclarationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DeclarationTypeID"]) : 0 ;
					tmpDeclarationType.Title = row["Title"].ToString();

					listDeclarationType.Add(tmpDeclarationType);
				}
			}
		}

		return listDeclarationType;
	}

}
}
