using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class OperatorTypeDBAccess
{

	AnnunciationDBAccess annunciationDBAccess = new AnnunciationDBAccess();

	public List<Annunciation> GetListAnnunciation(int operatorTypeID)
	{
		List<Annunciation> listAnnunciation = new List<Annunciation>() { };
		SqlParameter[] parametersOperatorType = new SqlParameter[]
		{
			new SqlParameter("@OperatorTypeID", operatorTypeID)
		};

		//Lets get the list of Annunciation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Annunciation_GetList_UseInOperatorType", CommandType.StoredProcedure, parametersOperatorType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of annunciation
				listAnnunciation = new List<Annunciation>();

				//Now lets populate the Annunciation details into the list of annunciations
				foreach (DataRow row in table.Rows)
				{
					Annunciation annunciation = ConvertRowToAnnunciation(row);
					listAnnunciation.Add(annunciation);
				}
			}
		}

		return listAnnunciation;
	}

	private Annunciation ConvertRowToAnnunciation(DataRow row)
	{
		Annunciation annunciation = new Annunciation();
		annunciation.AnnunciationPaperTypeID = (row["AnnunciationPaperTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AnnunciationPaperTypeID"]) : 0 ;
		annunciation.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
		annunciation.RegisterDate1 = row["RegisterDate1"].ToString();
		annunciation.AnnunciationPlaceIDTitle = row["AnnunciationPlaceIDTitle"].ToString();
		annunciation.AnnunciationResultTypeIDTitle = row["AnnunciationResultTypeIDTitle"].ToString();
		annunciation.AnnunciationToOthersReasonIDTitle = row["AnnunciationToOthersReasonIDTitle"].ToString();
		annunciation.AnnunciationToTypeIDTitle = row["AnnunciationToTypeIDTitle"].ToString();
		annunciation.RegularAnnunciationReasonIDTitle = row["RegularAnnunciationReasonIDTitle"].ToString();
		annunciation.RegularAnnunciationTypeIDTitle = row["RegularAnnunciationTypeIDTitle"].ToString();
		annunciation.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		annunciation.OldRegisterDate = row["OldRegisterDate"].ToString();
		annunciation.RegisterDate2 = row["RegisterDate2"].ToString();
		annunciation.PaperRegisterDate = row["PaperRegisterDate"].ToString();
		annunciation.OperatorName = row["OperatorName"].ToString();
		annunciation.Reciver = row["Reciver"].ToString();
		annunciation.RelationToHeir = row["RelationToHeir"].ToString();
		annunciation.Annuncier = row["Annuncier"].ToString();
		annunciation.RejectOther = row["RejectOther"].ToString();
		annunciation.RegisterInformationID2 = (row["RegisterInformationID2"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID2"]) : 0 ;
		annunciation.PaperRegisterInformationID = (row["PaperRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["PaperRegisterInformationID"]) : 0 ;
		annunciation.AnnunciationDate = row["AnnunciationDate"].ToString();
		annunciation.PaperDate = row["PaperDate"].ToString();
		annunciation.AnnunciationToTypeID = (row["AnnunciationToTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AnnunciationToTypeID"]) : 0 ;
		annunciation.AnnunciationPlaceID = (row["AnnunciationPlaceID"] != DBNull.Value) ? Convert.ToInt32(row["AnnunciationPlaceID"]) : 0 ;
		annunciation.AnnunciationToOthersReasonID = (row["AnnunciationToOthersReasonID"] != DBNull.Value) ? Convert.ToInt32(row["AnnunciationToOthersReasonID"]) : 0 ;
		annunciation.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt32(row["RegisterInformationID"]) : 0 ;
		annunciation.RegularAnnunciationReasonID = (row["RegularAnnunciationReasonID"] != DBNull.Value) ? Convert.ToInt32(row["RegularAnnunciationReasonID"]) : 0 ;
		annunciation.RegularAnnunciationTypeID = (row["RegularAnnunciationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RegularAnnunciationTypeID"]) : 0 ;
		annunciation.AnnunciationResultTypeID = (row["AnnunciationResultTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AnnunciationResultTypeID"]) : 0 ;
		annunciation.OperatorTypeID = (row["OperatorTypeID"] != DBNull.Value) ? Convert.ToInt32(row["OperatorTypeID"]) : 0 ;
		annunciation.Reject1 = (row["Reject1"] != DBNull.Value) ? Convert.ToBoolean((row["Reject1"].ToString() == "1" || row["Reject1"].ToString().ToLower() == "true" ) ? true : false) : false ;
		annunciation.Reject2 = (row["Reject2"] != DBNull.Value) ? Convert.ToBoolean((row["Reject2"].ToString() == "1" || row["Reject2"].ToString().ToLower() == "true" ) ? true : false) : false ;
		annunciation.Reject3 = (row["Reject3"] != DBNull.Value) ? Convert.ToBoolean((row["Reject3"].ToString() == "1" || row["Reject3"].ToString().ToLower() == "true" ) ? true : false) : false ;
		annunciation.Reject4 = (row["Reject4"] != DBNull.Value) ? Convert.ToBoolean((row["Reject4"].ToString() == "1" || row["Reject4"].ToString().ToLower() == "true" ) ? true : false) : false ;
		annunciation.Reject5 = (row["Reject5"] != DBNull.Value) ? Convert.ToBoolean((row["Reject5"].ToString() == "1" || row["Reject5"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return annunciation;
	}
	public Int64 Insert(OperatorType operatorType)
	{
		SqlParameter[] parametersOperatorType = new SqlParameter[]
		{
			new SqlParameter("@Title", (operatorType.Title != null) ? operatorType.Title : (object)DBNull.Value)
		};
		operatorType.OperatorTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("OperatorType_Insert", CommandType.StoredProcedure, parametersOperatorType));
		return operatorType.OperatorTypeID;
	}

	public bool Update(OperatorType operatorType)
	{
		SqlParameter[] parametersOperatorType = new SqlParameter[]
		{
			new SqlParameter("@OperatorTypeID", operatorType.OperatorTypeID),
			new SqlParameter("@Title", (operatorType.Title != null) ? operatorType.Title : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("OperatorType_Update", CommandType.StoredProcedure, parametersOperatorType);
	}

	public bool Delete(int operatorTypeID)
	{
		SqlParameter[] parametersOperatorType = new SqlParameter[]
		{
			new SqlParameter("@OperatorTypeID", operatorTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("OperatorType_Delete", CommandType.StoredProcedure, parametersOperatorType);
	}

	public OperatorType GetDetails(int operatorTypeID)
	{
		OperatorType operatorType = new OperatorType();

		SqlParameter[] parametersOperatorType = new SqlParameter[]
		{
			new SqlParameter("@OperatorTypeID", operatorTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("OperatorType_GetDetails", CommandType.StoredProcedure, parametersOperatorType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				operatorType.OperatorTypeID = (row["OperatorTypeID"] != DBNull.Value) ? Convert.ToInt32(row["OperatorTypeID"]) : 0 ;
				operatorType.Title = row["Title"].ToString();
			}
		}

		return operatorType;
	}

	public List<OperatorType> GetListAll()
	{
		List<OperatorType> listOperatorType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("OperatorType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listOperatorType = new List<OperatorType>();

				foreach (DataRow row in table.Rows)
				{
					OperatorType operatorType = new OperatorType();
					operatorType.OperatorTypeID = (row["OperatorTypeID"] != DBNull.Value) ? Convert.ToInt32(row["OperatorTypeID"]) : 0 ;
					operatorType.Title = row["Title"].ToString();
					listOperatorType.Add(operatorType);
				}
			}
		}

		return listOperatorType;
	}

	public bool Exists(int operatorTypeID)
	{
		SqlParameter[] parametersOperatorType = new SqlParameter[]
		{
			new SqlParameter("@OperatorTypeID", operatorTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("OperatorType_Exists", CommandType.StoredProcedure, parametersOperatorType)>0);
	}

	public bool Exists(OperatorType operatorType)
	{
		SqlParameter[] parametersOperatorType = new SqlParameter[]
		{
			new SqlParameter("@OperatorTypeID", operatorType.OperatorTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("OperatorType_Exists", CommandType.StoredProcedure, parametersOperatorType)>0);
	}

	public List<OperatorType> SearchLike(OperatorType operatorType)
	{
		List<OperatorType> listOperatorType = new List<OperatorType>();


		SqlParameter[] parametersOperatorType = new SqlParameter[]
		{
			new SqlParameter("@OperatorTypeID", operatorType.OperatorTypeID),
			new SqlParameter("@Title", operatorType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("OperatorType_SearchLike", CommandType.StoredProcedure, parametersOperatorType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					OperatorType tmpOperatorType = new OperatorType();
					tmpOperatorType.OperatorTypeID = (row["OperatorTypeID"] != DBNull.Value) ? Convert.ToInt32(row["OperatorTypeID"]) : 0 ;
					tmpOperatorType.Title = row["Title"].ToString();

					listOperatorType.Add(tmpOperatorType);
				}
			}
		}

		return listOperatorType;
	}

}
}
