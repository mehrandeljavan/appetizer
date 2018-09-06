using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class DemandDocumentDBAccess
{

	DemandsDBAccess demandsDBAccess = new DemandsDBAccess();

	public List<Demands> GetListDemands(int demandDocumentID)
	{
		List<Demands> listDemands = new List<Demands>() { };
		SqlParameter[] parametersDemandDocument = new SqlParameter[]
		{
			new SqlParameter("@DemandDocumentID", demandDocumentID)
		};

		//Lets get the list of Demands records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Demands_GetList_UseInDemandDocument", CommandType.StoredProcedure, parametersDemandDocument))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of demands
				listDemands = new List<Demands>();

				//Now lets populate the Demands details into the list of demandss
				foreach (DataRow row in table.Rows)
				{
					Demands demands = ConvertRowToDemands(row);
					listDemands.Add(demands);
				}
			}
		}

		return listDemands;
	}

	private Demands ConvertRowToDemands(DataRow row)
	{
		Demands demands = new Demands();
		demands.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		demands.DemandDocumentIDTitle = row["DemandDocumentIDTitle"].ToString();
		demands.DemandsTypeIDTitle = row["DemandsTypeIDTitle"].ToString();
		demands.DemandsTypeID = (row["DemandsTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DemandsTypeID"]) : 0 ;
		demands.DemandDocumentID = (row["DemandDocumentID"] != DBNull.Value) ? Convert.ToInt32(row["DemandDocumentID"]) : 0 ;
		demands.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		demands.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
		demands.DebtorName = row["DebtorName"].ToString();
		demands.DocumentNumber = row["DocumentNumber"].ToString();

		demands.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		demands.StageTitle = row["StageTitle"].ToString();
		demands.RegisterDate = row["RegisterDate"].ToString();
		demands.OldRegisterDate = row["OldRegisterDate"].ToString();
		demands.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		demands.Sixth = row["Sixth"].ToString();
		demands.PreviousOwner = row["PreviousOwner"].ToString();
		demands.Comment = row["Comment"].ToString();
		demands.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		demands.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		demands.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		demands.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		demands.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		demands.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		demands.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		demands.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		demands.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		demands.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return demands;
	}
	public Int64 Insert(DemandDocument demandDocument)
	{
		SqlParameter[] parametersDemandDocument = new SqlParameter[]
		{
			new SqlParameter("@Title", demandDocument.Title)
		};
		demandDocument.DemandDocumentID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("DemandDocument_Insert", CommandType.StoredProcedure, parametersDemandDocument));
		return demandDocument.DemandDocumentID;
	}

	public bool Update(DemandDocument demandDocument)
	{
		SqlParameter[] parametersDemandDocument = new SqlParameter[]
		{
			new SqlParameter("@DemandDocumentID", demandDocument.DemandDocumentID),
			new SqlParameter("@Title", demandDocument.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("DemandDocument_Update", CommandType.StoredProcedure, parametersDemandDocument);
	}

	public bool Delete(int demandDocumentID)
	{
		SqlParameter[] parametersDemandDocument = new SqlParameter[]
		{
			new SqlParameter("@DemandDocumentID", demandDocumentID)
		};
		return SqlDBHelper.ExecuteNonQuery("DemandDocument_Delete", CommandType.StoredProcedure, parametersDemandDocument);
	}

	public DemandDocument GetDetails(int demandDocumentID)
	{
		DemandDocument demandDocument = new DemandDocument();

		SqlParameter[] parametersDemandDocument = new SqlParameter[]
		{
			new SqlParameter("@DemandDocumentID", demandDocumentID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DemandDocument_GetDetails", CommandType.StoredProcedure, parametersDemandDocument))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				demandDocument.DemandDocumentID = (row["DemandDocumentID"] != DBNull.Value) ? Convert.ToInt32(row["DemandDocumentID"]) : 0 ;
				demandDocument.Title = row["Title"].ToString();
			}
		}

		return demandDocument;
	}

	public List<DemandDocument> GetListAll()
	{
		List<DemandDocument> listDemandDocument = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("DemandDocument_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listDemandDocument = new List<DemandDocument>();

				foreach (DataRow row in table.Rows)
				{
					DemandDocument demandDocument = new DemandDocument();
					demandDocument.DemandDocumentID = (row["DemandDocumentID"] != DBNull.Value) ? Convert.ToInt32(row["DemandDocumentID"]) : 0 ;
					demandDocument.Title = row["Title"].ToString();
					listDemandDocument.Add(demandDocument);
				}
			}
		}

		return listDemandDocument;
	}

	public bool Exists(int demandDocumentID)
	{
		SqlParameter[] parametersDemandDocument = new SqlParameter[]
		{
			new SqlParameter("@DemandDocumentID", demandDocumentID)
		};
		return (SqlDBHelper.ExecuteScalar("DemandDocument_Exists", CommandType.StoredProcedure, parametersDemandDocument)>0);
	}

	public bool Exists(DemandDocument demandDocument)
	{
		SqlParameter[] parametersDemandDocument = new SqlParameter[]
		{
			new SqlParameter("@DemandDocumentID", demandDocument.DemandDocumentID)
		};
		return (SqlDBHelper.ExecuteScalar("DemandDocument_Exists", CommandType.StoredProcedure, parametersDemandDocument)>0);
	}

	public List<DemandDocument> SearchLike(DemandDocument demandDocument)
	{
		List<DemandDocument> listDemandDocument = new List<DemandDocument>();


		SqlParameter[] parametersDemandDocument = new SqlParameter[]
		{
			new SqlParameter("@DemandDocumentID", demandDocument.DemandDocumentID),
			new SqlParameter("@Title", demandDocument.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DemandDocument_SearchLike", CommandType.StoredProcedure, parametersDemandDocument))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					DemandDocument tmpDemandDocument = new DemandDocument();
					tmpDemandDocument.DemandDocumentID = (row["DemandDocumentID"] != DBNull.Value) ? Convert.ToInt32(row["DemandDocumentID"]) : 0 ;
					tmpDemandDocument.Title = row["Title"].ToString();

					listDemandDocument.Add(tmpDemandDocument);
				}
			}
		}

		return listDemandDocument;
	}

}
}
