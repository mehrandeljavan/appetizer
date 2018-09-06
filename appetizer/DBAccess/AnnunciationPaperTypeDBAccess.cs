using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class AnnunciationPaperTypeDBAccess
{

	AnnunciationDBAccess annunciationDBAccess = new AnnunciationDBAccess();

	public List<Annunciation> GetListAnnunciation(int annunciationPaperTypeID)
	{
		List<Annunciation> listAnnunciation = new List<Annunciation>() { };
		SqlParameter[] parametersAnnunciationPaperType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationPaperTypeID", annunciationPaperTypeID)
		};

		//Lets get the list of Annunciation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Annunciation_GetList_UseInAnnunciationPaperType", CommandType.StoredProcedure, parametersAnnunciationPaperType))
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
	public Int64 Insert(AnnunciationPaperType annunciationPaperType)
	{
		SqlParameter[] parametersAnnunciationPaperType = new SqlParameter[]
		{
			new SqlParameter("@Title", annunciationPaperType.Title)
		};
		annunciationPaperType.AnnunciationPaperTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("AnnunciationPaperType_Insert", CommandType.StoredProcedure, parametersAnnunciationPaperType));
		return annunciationPaperType.AnnunciationPaperTypeID;
	}

	public bool Update(AnnunciationPaperType annunciationPaperType)
	{
		SqlParameter[] parametersAnnunciationPaperType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationPaperTypeID", annunciationPaperType.AnnunciationPaperTypeID),
			new SqlParameter("@Title", annunciationPaperType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("AnnunciationPaperType_Update", CommandType.StoredProcedure, parametersAnnunciationPaperType);
	}

	public bool Delete(int annunciationPaperTypeID)
	{
		SqlParameter[] parametersAnnunciationPaperType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationPaperTypeID", annunciationPaperTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("AnnunciationPaperType_Delete", CommandType.StoredProcedure, parametersAnnunciationPaperType);
	}

	public AnnunciationPaperType GetDetails(int annunciationPaperTypeID)
	{
		AnnunciationPaperType annunciationPaperType = new AnnunciationPaperType();

		SqlParameter[] parametersAnnunciationPaperType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationPaperTypeID", annunciationPaperTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("AnnunciationPaperType_GetDetails", CommandType.StoredProcedure, parametersAnnunciationPaperType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				annunciationPaperType.AnnunciationPaperTypeID = (row["AnnunciationPaperTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AnnunciationPaperTypeID"]) : 0 ;
				annunciationPaperType.Title = row["Title"].ToString();
			}
		}

		return annunciationPaperType;
	}

	public List<AnnunciationPaperType> GetListAll()
	{
		List<AnnunciationPaperType> listAnnunciationPaperType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("AnnunciationPaperType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listAnnunciationPaperType = new List<AnnunciationPaperType>();

				foreach (DataRow row in table.Rows)
				{
					AnnunciationPaperType annunciationPaperType = new AnnunciationPaperType();
					annunciationPaperType.AnnunciationPaperTypeID = (row["AnnunciationPaperTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AnnunciationPaperTypeID"]) : 0 ;
					annunciationPaperType.Title = row["Title"].ToString();
					listAnnunciationPaperType.Add(annunciationPaperType);
				}
			}
		}

		return listAnnunciationPaperType;
	}

	public bool Exists(int annunciationPaperTypeID)
	{
		SqlParameter[] parametersAnnunciationPaperType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationPaperTypeID", annunciationPaperTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("AnnunciationPaperType_Exists", CommandType.StoredProcedure, parametersAnnunciationPaperType)>0);
	}

	public bool Exists(AnnunciationPaperType annunciationPaperType)
	{
		SqlParameter[] parametersAnnunciationPaperType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationPaperTypeID", annunciationPaperType.AnnunciationPaperTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("AnnunciationPaperType_Exists", CommandType.StoredProcedure, parametersAnnunciationPaperType)>0);
	}

	public List<AnnunciationPaperType> SearchLike(AnnunciationPaperType annunciationPaperType)
	{
		List<AnnunciationPaperType> listAnnunciationPaperType = new List<AnnunciationPaperType>();


		SqlParameter[] parametersAnnunciationPaperType = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationPaperTypeID", annunciationPaperType.AnnunciationPaperTypeID),
			new SqlParameter("@Title", annunciationPaperType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("AnnunciationPaperType_SearchLike", CommandType.StoredProcedure, parametersAnnunciationPaperType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					AnnunciationPaperType tmpAnnunciationPaperType = new AnnunciationPaperType();
					tmpAnnunciationPaperType.AnnunciationPaperTypeID = (row["AnnunciationPaperTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AnnunciationPaperTypeID"]) : 0 ;
					tmpAnnunciationPaperType.Title = row["Title"].ToString();

					listAnnunciationPaperType.Add(tmpAnnunciationPaperType);
				}
			}
		}

		return listAnnunciationPaperType;
	}

}
}
