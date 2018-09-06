using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class AnnunciationResultTypeDBAccess
{

	AnnunciationDBAccess annunciationDBAccess = new AnnunciationDBAccess();

	public List<Annunciation> GetListAnnunciation(int annunciationResultTypeID)
	{
		List<Annunciation> listAnnunciation = new List<Annunciation>() { };
		SqlParameter[] parametersAnnunciationResultType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationResultTypeID", annunciationResultTypeID)
		};

		//Lets get the list of Annunciation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Annunciation_GetList_UseInAnnunciationResultType", CommandType.StoredProcedure, parametersAnnunciationResultType))
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
	public Int64 Insert(AnnunciationResultType annunciationResultType)
	{
		SqlParameter[] parametersAnnunciationResultType = new SqlParameter[]
		{
			new SqlParameter("@Title", annunciationResultType.Title)
		};
		annunciationResultType.AnnunciationResultTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("AnnunciationResultType_Insert", CommandType.StoredProcedure, parametersAnnunciationResultType));
		return annunciationResultType.AnnunciationResultTypeID;
	}

	public bool Update(AnnunciationResultType annunciationResultType)
	{
		SqlParameter[] parametersAnnunciationResultType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationResultTypeID", annunciationResultType.AnnunciationResultTypeID),
			new SqlParameter("@Title", annunciationResultType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("AnnunciationResultType_Update", CommandType.StoredProcedure, parametersAnnunciationResultType);
	}

	public bool Delete(int annunciationResultTypeID)
	{
		SqlParameter[] parametersAnnunciationResultType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationResultTypeID", annunciationResultTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("AnnunciationResultType_Delete", CommandType.StoredProcedure, parametersAnnunciationResultType);
	}

	public AnnunciationResultType GetDetails(int annunciationResultTypeID)
	{
		AnnunciationResultType annunciationResultType = new AnnunciationResultType();

		SqlParameter[] parametersAnnunciationResultType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationResultTypeID", annunciationResultTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("AnnunciationResultType_GetDetails", CommandType.StoredProcedure, parametersAnnunciationResultType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				annunciationResultType.AnnunciationResultTypeID = (row["AnnunciationResultTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AnnunciationResultTypeID"]) : 0 ;
				annunciationResultType.Title = row["Title"].ToString();
			}
		}

		return annunciationResultType;
	}

	public List<AnnunciationResultType> GetListAll()
	{
		List<AnnunciationResultType> listAnnunciationResultType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("AnnunciationResultType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listAnnunciationResultType = new List<AnnunciationResultType>();

				foreach (DataRow row in table.Rows)
				{
					AnnunciationResultType annunciationResultType = new AnnunciationResultType();
					annunciationResultType.AnnunciationResultTypeID = (row["AnnunciationResultTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AnnunciationResultTypeID"]) : 0 ;
					annunciationResultType.Title = row["Title"].ToString();
					listAnnunciationResultType.Add(annunciationResultType);
				}
			}
		}

		return listAnnunciationResultType;
	}

	public bool Exists(int annunciationResultTypeID)
	{
		SqlParameter[] parametersAnnunciationResultType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationResultTypeID", annunciationResultTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("AnnunciationResultType_Exists", CommandType.StoredProcedure, parametersAnnunciationResultType)>0);
	}

	public bool Exists(AnnunciationResultType annunciationResultType)
	{
		SqlParameter[] parametersAnnunciationResultType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationResultTypeID", annunciationResultType.AnnunciationResultTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("AnnunciationResultType_Exists", CommandType.StoredProcedure, parametersAnnunciationResultType)>0);
	}

	public List<AnnunciationResultType> SearchLike(AnnunciationResultType annunciationResultType)
	{
		List<AnnunciationResultType> listAnnunciationResultType = new List<AnnunciationResultType>();


		SqlParameter[] parametersAnnunciationResultType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationResultTypeID", annunciationResultType.AnnunciationResultTypeID),
			new SqlParameter("@Title", annunciationResultType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("AnnunciationResultType_SearchLike", CommandType.StoredProcedure, parametersAnnunciationResultType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					AnnunciationResultType tmpAnnunciationResultType = new AnnunciationResultType();
					tmpAnnunciationResultType.AnnunciationResultTypeID = (row["AnnunciationResultTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AnnunciationResultTypeID"]) : 0 ;
					tmpAnnunciationResultType.Title = row["Title"].ToString();

					listAnnunciationResultType.Add(tmpAnnunciationResultType);
				}
			}
		}

		return listAnnunciationResultType;
	}

}
}
