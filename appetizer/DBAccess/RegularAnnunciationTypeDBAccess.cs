using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class RegularAnnunciationTypeDBAccess
{

	AnnunciationDBAccess annunciationDBAccess = new AnnunciationDBAccess();

	public List<Annunciation> GetListAnnunciation(int regularAnnunciationTypeID)
	{
		List<Annunciation> listAnnunciation = new List<Annunciation>() { };
		SqlParameter[] parametersRegularAnnunciationType = new SqlParameter[]
		{
			new SqlParameter("@RegularAnnunciationTypeID", regularAnnunciationTypeID)
		};

		//Lets get the list of Annunciation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Annunciation_GetList_UseInRegularAnnunciationType", CommandType.StoredProcedure, parametersRegularAnnunciationType))
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
	public Int64 Insert(RegularAnnunciationType regularAnnunciationType)
	{
		SqlParameter[] parametersRegularAnnunciationType = new SqlParameter[]
		{
			new SqlParameter("@Category", regularAnnunciationType.Category),
			new SqlParameter("@Title", regularAnnunciationType.Title)
		};
		regularAnnunciationType.RegularAnnunciationTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("RegularAnnunciationType_Insert", CommandType.StoredProcedure, parametersRegularAnnunciationType));
		return regularAnnunciationType.RegularAnnunciationTypeID;
	}

	public bool Update(RegularAnnunciationType regularAnnunciationType)
	{
		SqlParameter[] parametersRegularAnnunciationType = new SqlParameter[]
		{
			new SqlParameter("@RegularAnnunciationTypeID", regularAnnunciationType.RegularAnnunciationTypeID),
			new SqlParameter("@Category", regularAnnunciationType.Category),
			new SqlParameter("@Title", regularAnnunciationType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("RegularAnnunciationType_Update", CommandType.StoredProcedure, parametersRegularAnnunciationType);
	}

	public bool Delete(int regularAnnunciationTypeID)
	{
		SqlParameter[] parametersRegularAnnunciationType = new SqlParameter[]
		{
			new SqlParameter("@RegularAnnunciationTypeID", regularAnnunciationTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("RegularAnnunciationType_Delete", CommandType.StoredProcedure, parametersRegularAnnunciationType);
	}

	public RegularAnnunciationType GetDetails(int regularAnnunciationTypeID)
	{
		RegularAnnunciationType regularAnnunciationType = new RegularAnnunciationType();

		SqlParameter[] parametersRegularAnnunciationType = new SqlParameter[]
		{
			new SqlParameter("@RegularAnnunciationTypeID", regularAnnunciationTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RegularAnnunciationType_GetDetails", CommandType.StoredProcedure, parametersRegularAnnunciationType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				regularAnnunciationType.RegularAnnunciationTypeID = (row["RegularAnnunciationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RegularAnnunciationTypeID"]) : 0 ;
				regularAnnunciationType.Category = (row["Category"] != DBNull.Value) ? Convert.ToInt32(row["Category"]) : 0 ;
				regularAnnunciationType.Title = row["Title"].ToString();
			}
		}

		return regularAnnunciationType;
	}

	public List<RegularAnnunciationType> GetListAll()
	{
		List<RegularAnnunciationType> listRegularAnnunciationType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("RegularAnnunciationType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listRegularAnnunciationType = new List<RegularAnnunciationType>();

				foreach (DataRow row in table.Rows)
				{
					RegularAnnunciationType regularAnnunciationType = new RegularAnnunciationType();
					regularAnnunciationType.RegularAnnunciationTypeID = (row["RegularAnnunciationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RegularAnnunciationTypeID"]) : 0 ;
					regularAnnunciationType.Category = (row["Category"] != DBNull.Value) ? Convert.ToInt32(row["Category"]) : 0 ;
					regularAnnunciationType.Title = row["Title"].ToString();
					listRegularAnnunciationType.Add(regularAnnunciationType);
				}
			}
		}

		return listRegularAnnunciationType;
	}

	public bool Exists(int regularAnnunciationTypeID)
	{
		SqlParameter[] parametersRegularAnnunciationType = new SqlParameter[]
		{
			new SqlParameter("@RegularAnnunciationTypeID", regularAnnunciationTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("RegularAnnunciationType_Exists", CommandType.StoredProcedure, parametersRegularAnnunciationType)>0);
	}

	public bool Exists(RegularAnnunciationType regularAnnunciationType)
	{
		SqlParameter[] parametersRegularAnnunciationType = new SqlParameter[]
		{
			new SqlParameter("@RegularAnnunciationTypeID", regularAnnunciationType.RegularAnnunciationTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("RegularAnnunciationType_Exists", CommandType.StoredProcedure, parametersRegularAnnunciationType)>0);
	}

	public List<RegularAnnunciationType> SearchLike(RegularAnnunciationType regularAnnunciationType)
	{
		List<RegularAnnunciationType> listRegularAnnunciationType = new List<RegularAnnunciationType>();


		SqlParameter[] parametersRegularAnnunciationType = new SqlParameter[]
		{
			new SqlParameter("@RegularAnnunciationTypeID", regularAnnunciationType.RegularAnnunciationTypeID),
			new SqlParameter("@Category", regularAnnunciationType.Category),
			new SqlParameter("@Title", regularAnnunciationType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RegularAnnunciationType_SearchLike", CommandType.StoredProcedure, parametersRegularAnnunciationType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					RegularAnnunciationType tmpRegularAnnunciationType = new RegularAnnunciationType();
					tmpRegularAnnunciationType.RegularAnnunciationTypeID = (row["RegularAnnunciationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RegularAnnunciationTypeID"]) : 0 ;
					tmpRegularAnnunciationType.Category = (row["Category"] != DBNull.Value) ? Convert.ToInt32(row["Category"]) : 0 ;
					tmpRegularAnnunciationType.Title = row["Title"].ToString();

					listRegularAnnunciationType.Add(tmpRegularAnnunciationType);
				}
			}
		}

		return listRegularAnnunciationType;
	}

}
}
