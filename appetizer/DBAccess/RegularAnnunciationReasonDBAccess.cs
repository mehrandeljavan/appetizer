using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class RegularAnnunciationReasonDBAccess
{

	AnnunciationDBAccess annunciationDBAccess = new AnnunciationDBAccess();

	public List<Annunciation> GetListAnnunciation(int regularAnnunciationReasonID)
	{
		List<Annunciation> listAnnunciation = new List<Annunciation>() { };
		SqlParameter[] parametersRegularAnnunciationReason = new SqlParameter[]
		{
			new SqlParameter("@RegularAnnunciationReasonID", regularAnnunciationReasonID)
		};

		//Lets get the list of Annunciation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Annunciation_GetList_UseInRegularAnnunciationReason", CommandType.StoredProcedure, parametersRegularAnnunciationReason))
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
	public Int64 Insert(RegularAnnunciationReason regularAnnunciationReason)
	{
		SqlParameter[] parametersRegularAnnunciationReason = new SqlParameter[]
		{
			new SqlParameter("@Title", (regularAnnunciationReason.Title != null) ? regularAnnunciationReason.Title : (object)DBNull.Value)
		};
		regularAnnunciationReason.RegularAnnunciationReasonID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("RegularAnnunciationReason_Insert", CommandType.StoredProcedure, parametersRegularAnnunciationReason));
		return regularAnnunciationReason.RegularAnnunciationReasonID;
	}

	public bool Update(RegularAnnunciationReason regularAnnunciationReason)
	{
		SqlParameter[] parametersRegularAnnunciationReason = new SqlParameter[]
		{
			new SqlParameter("@RegularAnnunciationReasonID", regularAnnunciationReason.RegularAnnunciationReasonID),
			new SqlParameter("@Title", (regularAnnunciationReason.Title != null) ? regularAnnunciationReason.Title : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("RegularAnnunciationReason_Update", CommandType.StoredProcedure, parametersRegularAnnunciationReason);
	}

	public bool Delete(int regularAnnunciationReasonID)
	{
		SqlParameter[] parametersRegularAnnunciationReason = new SqlParameter[]
		{
			new SqlParameter("@RegularAnnunciationReasonID", regularAnnunciationReasonID)
		};
		return SqlDBHelper.ExecuteNonQuery("RegularAnnunciationReason_Delete", CommandType.StoredProcedure, parametersRegularAnnunciationReason);
	}

	public RegularAnnunciationReason GetDetails(int regularAnnunciationReasonID)
	{
		RegularAnnunciationReason regularAnnunciationReason = new RegularAnnunciationReason();

		SqlParameter[] parametersRegularAnnunciationReason = new SqlParameter[]
		{
			new SqlParameter("@RegularAnnunciationReasonID", regularAnnunciationReasonID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RegularAnnunciationReason_GetDetails", CommandType.StoredProcedure, parametersRegularAnnunciationReason))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				regularAnnunciationReason.RegularAnnunciationReasonID = (row["RegularAnnunciationReasonID"] != DBNull.Value) ? Convert.ToInt32(row["RegularAnnunciationReasonID"]) : 0 ;
				regularAnnunciationReason.Title = row["Title"].ToString();
			}
		}

		return regularAnnunciationReason;
	}

	public List<RegularAnnunciationReason> GetListAll()
	{
		List<RegularAnnunciationReason> listRegularAnnunciationReason = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("RegularAnnunciationReason_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listRegularAnnunciationReason = new List<RegularAnnunciationReason>();

				foreach (DataRow row in table.Rows)
				{
					RegularAnnunciationReason regularAnnunciationReason = new RegularAnnunciationReason();
					regularAnnunciationReason.RegularAnnunciationReasonID = (row["RegularAnnunciationReasonID"] != DBNull.Value) ? Convert.ToInt32(row["RegularAnnunciationReasonID"]) : 0 ;
					regularAnnunciationReason.Title = row["Title"].ToString();
					listRegularAnnunciationReason.Add(regularAnnunciationReason);
				}
			}
		}

		return listRegularAnnunciationReason;
	}

	public bool Exists(int regularAnnunciationReasonID)
	{
		SqlParameter[] parametersRegularAnnunciationReason = new SqlParameter[]
		{
			new SqlParameter("@RegularAnnunciationReasonID", regularAnnunciationReasonID)
		};
		return (SqlDBHelper.ExecuteScalar("RegularAnnunciationReason_Exists", CommandType.StoredProcedure, parametersRegularAnnunciationReason)>0);
	}

	public bool Exists(RegularAnnunciationReason regularAnnunciationReason)
	{
		SqlParameter[] parametersRegularAnnunciationReason = new SqlParameter[]
		{
			new SqlParameter("@RegularAnnunciationReasonID", regularAnnunciationReason.RegularAnnunciationReasonID)
		};
		return (SqlDBHelper.ExecuteScalar("RegularAnnunciationReason_Exists", CommandType.StoredProcedure, parametersRegularAnnunciationReason)>0);
	}

	public List<RegularAnnunciationReason> SearchLike(RegularAnnunciationReason regularAnnunciationReason)
	{
		List<RegularAnnunciationReason> listRegularAnnunciationReason = new List<RegularAnnunciationReason>();


		SqlParameter[] parametersRegularAnnunciationReason = new SqlParameter[]
		{
			new SqlParameter("@RegularAnnunciationReasonID", regularAnnunciationReason.RegularAnnunciationReasonID),
			new SqlParameter("@Title", regularAnnunciationReason.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("RegularAnnunciationReason_SearchLike", CommandType.StoredProcedure, parametersRegularAnnunciationReason))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					RegularAnnunciationReason tmpRegularAnnunciationReason = new RegularAnnunciationReason();
					tmpRegularAnnunciationReason.RegularAnnunciationReasonID = (row["RegularAnnunciationReasonID"] != DBNull.Value) ? Convert.ToInt32(row["RegularAnnunciationReasonID"]) : 0 ;
					tmpRegularAnnunciationReason.Title = row["Title"].ToString();

					listRegularAnnunciationReason.Add(tmpRegularAnnunciationReason);
				}
			}
		}

		return listRegularAnnunciationReason;
	}

}
}
