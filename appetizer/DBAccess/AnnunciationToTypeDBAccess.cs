using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class AnnunciationToTypeDBAccess
{

	AnnunciationDBAccess annunciationDBAccess = new AnnunciationDBAccess();

	public List<Annunciation> GetListAnnunciation(int annunciationToTypeID)
	{
		List<Annunciation> listAnnunciation = new List<Annunciation>() { };
		SqlParameter[] parametersAnnunciationToType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationToTypeID", annunciationToTypeID)
		};

		//Lets get the list of Annunciation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Annunciation_GetList_UseInAnnunciationToType", CommandType.StoredProcedure, parametersAnnunciationToType))
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
	public Int64 Insert(AnnunciationToType annunciationToType)
	{
		SqlParameter[] parametersAnnunciationToType = new SqlParameter[]
		{
			new SqlParameter("@Title", (annunciationToType.Title != null) ? annunciationToType.Title : (object)DBNull.Value)
		};
		annunciationToType.AnnunciationToTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("AnnunciationToType_Insert", CommandType.StoredProcedure, parametersAnnunciationToType));
		return annunciationToType.AnnunciationToTypeID;
	}

	public bool Update(AnnunciationToType annunciationToType)
	{
		SqlParameter[] parametersAnnunciationToType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationToTypeID", annunciationToType.AnnunciationToTypeID),
			new SqlParameter("@Title", (annunciationToType.Title != null) ? annunciationToType.Title : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("AnnunciationToType_Update", CommandType.StoredProcedure, parametersAnnunciationToType);
	}

	public bool Delete(int annunciationToTypeID)
	{
		SqlParameter[] parametersAnnunciationToType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationToTypeID", annunciationToTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("AnnunciationToType_Delete", CommandType.StoredProcedure, parametersAnnunciationToType);
	}

	public AnnunciationToType GetDetails(int annunciationToTypeID)
	{
		AnnunciationToType annunciationToType = new AnnunciationToType();

		SqlParameter[] parametersAnnunciationToType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationToTypeID", annunciationToTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("AnnunciationToType_GetDetails", CommandType.StoredProcedure, parametersAnnunciationToType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				annunciationToType.AnnunciationToTypeID = (row["AnnunciationToTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AnnunciationToTypeID"]) : 0 ;
				annunciationToType.Title = row["Title"].ToString();
			}
		}

		return annunciationToType;
	}

	public List<AnnunciationToType> GetListAll()
	{
		List<AnnunciationToType> listAnnunciationToType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("AnnunciationToType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listAnnunciationToType = new List<AnnunciationToType>();

				foreach (DataRow row in table.Rows)
				{
					AnnunciationToType annunciationToType = new AnnunciationToType();
					annunciationToType.AnnunciationToTypeID = (row["AnnunciationToTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AnnunciationToTypeID"]) : 0 ;
					annunciationToType.Title = row["Title"].ToString();
					listAnnunciationToType.Add(annunciationToType);
				}
			}
		}

		return listAnnunciationToType;
	}

	public bool Exists(int annunciationToTypeID)
	{
		SqlParameter[] parametersAnnunciationToType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationToTypeID", annunciationToTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("AnnunciationToType_Exists", CommandType.StoredProcedure, parametersAnnunciationToType)>0);
	}

	public bool Exists(AnnunciationToType annunciationToType)
	{
		SqlParameter[] parametersAnnunciationToType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationToTypeID", annunciationToType.AnnunciationToTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("AnnunciationToType_Exists", CommandType.StoredProcedure, parametersAnnunciationToType)>0);
	}

	public List<AnnunciationToType> SearchLike(AnnunciationToType annunciationToType)
	{
		List<AnnunciationToType> listAnnunciationToType = new List<AnnunciationToType>();


		SqlParameter[] parametersAnnunciationToType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationToTypeID", annunciationToType.AnnunciationToTypeID),
			new SqlParameter("@Title", annunciationToType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("AnnunciationToType_SearchLike", CommandType.StoredProcedure, parametersAnnunciationToType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					AnnunciationToType tmpAnnunciationToType = new AnnunciationToType();
					tmpAnnunciationToType.AnnunciationToTypeID = (row["AnnunciationToTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AnnunciationToTypeID"]) : 0 ;
					tmpAnnunciationToType.Title = row["Title"].ToString();

					listAnnunciationToType.Add(tmpAnnunciationToType);
				}
			}
		}

		return listAnnunciationToType;
	}

}
}
