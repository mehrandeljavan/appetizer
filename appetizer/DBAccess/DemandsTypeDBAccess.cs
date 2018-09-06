using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class DemandsTypeDBAccess
{

	DemandsDBAccess demandsDBAccess = new DemandsDBAccess();

	public List<Demands> GetListDemands(int demandsTypeID)
	{
		List<Demands> listDemands = new List<Demands>() { };
		SqlParameter[] parametersDemandsType = new SqlParameter[]
		{
			new SqlParameter("@DemandsTypeID", demandsTypeID)
		};

		//Lets get the list of Demands records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Demands_GetList_UseInDemandsType", CommandType.StoredProcedure, parametersDemandsType))
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
	public Int64 Insert(DemandsType demandsType)
	{
		SqlParameter[] parametersDemandsType = new SqlParameter[]
		{
			new SqlParameter("@Categoty", (demandsType.Categoty != null) ? demandsType.Categoty : (object)DBNull.Value),
			new SqlParameter("@Title", demandsType.Title)
		};
		demandsType.DemandsTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("DemandsType_Insert", CommandType.StoredProcedure, parametersDemandsType));
		return demandsType.DemandsTypeID;
	}

	public bool Update(DemandsType demandsType)
	{
		SqlParameter[] parametersDemandsType = new SqlParameter[]
		{
			new SqlParameter("@DemandsTypeID", demandsType.DemandsTypeID),
			new SqlParameter("@Categoty", (demandsType.Categoty != null) ? demandsType.Categoty : (object)DBNull.Value),
			new SqlParameter("@Title", demandsType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("DemandsType_Update", CommandType.StoredProcedure, parametersDemandsType);
	}

	public bool Delete(int demandsTypeID)
	{
		SqlParameter[] parametersDemandsType = new SqlParameter[]
		{
			new SqlParameter("@DemandsTypeID", demandsTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("DemandsType_Delete", CommandType.StoredProcedure, parametersDemandsType);
	}

	public DemandsType GetDetails(int demandsTypeID)
	{
		DemandsType demandsType = new DemandsType();

		SqlParameter[] parametersDemandsType = new SqlParameter[]
		{
			new SqlParameter("@DemandsTypeID", demandsTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DemandsType_GetDetails", CommandType.StoredProcedure, parametersDemandsType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				demandsType.DemandsTypeID = (row["DemandsTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DemandsTypeID"]) : 0 ;
				demandsType.Categoty = (row["Categoty"] != DBNull.Value) ? Convert.ToInt32(row["Categoty"]) : 0 ;
				demandsType.Title = row["Title"].ToString();
			}
		}

		return demandsType;
	}

	public List<DemandsType> GetListAll()
	{
		List<DemandsType> listDemandsType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("DemandsType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listDemandsType = new List<DemandsType>();

				foreach (DataRow row in table.Rows)
				{
					DemandsType demandsType = new DemandsType();
					demandsType.DemandsTypeID = (row["DemandsTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DemandsTypeID"]) : 0 ;
					demandsType.Categoty = (row["Categoty"] != DBNull.Value) ? Convert.ToInt32(row["Categoty"]) : 0 ;
					demandsType.Title = row["Title"].ToString();
					listDemandsType.Add(demandsType);
				}
			}
		}

		return listDemandsType;
	}

	public bool Exists(int demandsTypeID)
	{
		SqlParameter[] parametersDemandsType = new SqlParameter[]
		{
			new SqlParameter("@DemandsTypeID", demandsTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("DemandsType_Exists", CommandType.StoredProcedure, parametersDemandsType)>0);
	}

	public bool Exists(DemandsType demandsType)
	{
		SqlParameter[] parametersDemandsType = new SqlParameter[]
		{
			new SqlParameter("@DemandsTypeID", demandsType.DemandsTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("DemandsType_Exists", CommandType.StoredProcedure, parametersDemandsType)>0);
	}

	public List<DemandsType> SearchLike(DemandsType demandsType)
	{
		List<DemandsType> listDemandsType = new List<DemandsType>();


		SqlParameter[] parametersDemandsType = new SqlParameter[]
		{
			new SqlParameter("@DemandsTypeID", demandsType.DemandsTypeID),
			new SqlParameter("@Categoty", demandsType.Categoty),
			new SqlParameter("@Title", demandsType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DemandsType_SearchLike", CommandType.StoredProcedure, parametersDemandsType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					DemandsType tmpDemandsType = new DemandsType();
					tmpDemandsType.DemandsTypeID = (row["DemandsTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DemandsTypeID"]) : 0 ;
					tmpDemandsType.Categoty = (row["Categoty"] != DBNull.Value) ? Convert.ToInt32(row["Categoty"]) : 0 ;
					tmpDemandsType.Title = row["Title"].ToString();

					listDemandsType.Add(tmpDemandsType);
				}
			}
		}

		return listDemandsType;
	}

}
}
