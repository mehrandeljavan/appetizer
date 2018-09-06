using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class AnnunciationDBAccess
{


	public Int64 Insert(Annunciation annunciation)
	{
		SqlParameter[] parametersAnnunciation = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationPaperTypeID", (annunciation.AnnunciationPaperTypeID > 0) ? annunciation.AnnunciationPaperTypeID : (object)DBNull.Value),
			new SqlParameter("@HeirID", (annunciation.HeirID > 0) ? annunciation.HeirID : (object)DBNull.Value),
			new SqlParameter("@OperatorName", (annunciation.OperatorName != null) ? annunciation.OperatorName : (object)DBNull.Value),
			new SqlParameter("@Reciver", (annunciation.Reciver != null) ? annunciation.Reciver : (object)DBNull.Value),
			new SqlParameter("@RelationToHeir", (annunciation.RelationToHeir != null) ? annunciation.RelationToHeir : (object)DBNull.Value),
			new SqlParameter("@Annuncier", (annunciation.Annuncier != null) ? annunciation.Annuncier : (object)DBNull.Value),
			new SqlParameter("@RejectOther", (annunciation.RejectOther != null) ? annunciation.RejectOther : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID2", (annunciation.RegisterInformationID2 != null) ? annunciation.RegisterInformationID2 : (object)DBNull.Value),
			new SqlParameter("@PaperRegisterInformationID", annunciation.PaperRegisterInformationID),
			new SqlParameter("@AnnunciationDate", (annunciation.AnnunciationDate != null) ? annunciation.AnnunciationDate : (object)DBNull.Value),
			new SqlParameter("@PaperDate", annunciation.PaperDate),
			new SqlParameter("@AnnunciationToTypeID", (annunciation.AnnunciationToTypeID > 0) ? annunciation.AnnunciationToTypeID : (object)DBNull.Value),
			new SqlParameter("@AnnunciationPlaceID", (annunciation.AnnunciationPlaceID > 0) ? annunciation.AnnunciationPlaceID : (object)DBNull.Value),
			new SqlParameter("@AnnunciationToOthersReasonID", (annunciation.AnnunciationToOthersReasonID > 0) ? annunciation.AnnunciationToOthersReasonID : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", (annunciation.RegisterInformationID != null) ? annunciation.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@RegularAnnunciationReasonID", (annunciation.RegularAnnunciationReasonID > 0) ? annunciation.RegularAnnunciationReasonID : (object)DBNull.Value),
			new SqlParameter("@RegularAnnunciationTypeID", (annunciation.RegularAnnunciationTypeID > 0) ? annunciation.RegularAnnunciationTypeID : (object)DBNull.Value),
			new SqlParameter("@AnnunciationResultTypeID", (annunciation.AnnunciationResultTypeID > 0) ? annunciation.AnnunciationResultTypeID : (object)DBNull.Value),
			new SqlParameter("@OperatorTypeID", (annunciation.OperatorTypeID > 0) ? annunciation.OperatorTypeID : (object)DBNull.Value),
			new SqlParameter("@Reject1", (annunciation.Reject1 != null) ? annunciation.Reject1 : (object)DBNull.Value),
			new SqlParameter("@Reject2", (annunciation.Reject2 != null) ? annunciation.Reject2 : (object)DBNull.Value),
			new SqlParameter("@Reject3", (annunciation.Reject3 != null) ? annunciation.Reject3 : (object)DBNull.Value),
			new SqlParameter("@Reject4", (annunciation.Reject4 != null) ? annunciation.Reject4 : (object)DBNull.Value),
			new SqlParameter("@Reject5", (annunciation.Reject5 != null) ? annunciation.Reject5 : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("Annunciation_Insert", CommandType.StoredProcedure, parametersAnnunciation);
	}

	public bool Update(Annunciation annunciation)
	{
		SqlParameter[] parametersAnnunciation = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationPaperTypeID", annunciation.AnnunciationPaperTypeID),
			new SqlParameter("@HeirID", annunciation.HeirID),
			new SqlParameter("@OperatorName", (annunciation.OperatorName != null) ? annunciation.OperatorName : (object)DBNull.Value),
			new SqlParameter("@Reciver", (annunciation.Reciver != null) ? annunciation.Reciver : (object)DBNull.Value),
			new SqlParameter("@RelationToHeir", (annunciation.RelationToHeir != null) ? annunciation.RelationToHeir : (object)DBNull.Value),
			new SqlParameter("@Annuncier", (annunciation.Annuncier != null) ? annunciation.Annuncier : (object)DBNull.Value),
			new SqlParameter("@RejectOther", (annunciation.RejectOther != null) ? annunciation.RejectOther : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID2", (annunciation.RegisterInformationID2 != null) ? annunciation.RegisterInformationID2 : (object)DBNull.Value),
			new SqlParameter("@PaperRegisterInformationID", annunciation.PaperRegisterInformationID),
			new SqlParameter("@AnnunciationDate", (annunciation.AnnunciationDate != null) ? annunciation.AnnunciationDate : (object)DBNull.Value),
			new SqlParameter("@PaperDate", annunciation.PaperDate),
			new SqlParameter("@AnnunciationToTypeID", (annunciation.AnnunciationToTypeID != null && annunciation.AnnunciationToTypeID >0 ) ? annunciation.AnnunciationToTypeID : (object)DBNull.Value),
			new SqlParameter("@AnnunciationPlaceID", (annunciation.AnnunciationPlaceID != null && annunciation.AnnunciationPlaceID >0 ) ? annunciation.AnnunciationPlaceID : (object)DBNull.Value),
			new SqlParameter("@AnnunciationToOthersReasonID", (annunciation.AnnunciationToOthersReasonID != null && annunciation.AnnunciationToOthersReasonID >0 ) ? annunciation.AnnunciationToOthersReasonID : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", (annunciation.RegisterInformationID != null) ? annunciation.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@RegularAnnunciationReasonID", (annunciation.RegularAnnunciationReasonID != null && annunciation.RegularAnnunciationReasonID >0 ) ? annunciation.RegularAnnunciationReasonID : (object)DBNull.Value),
			new SqlParameter("@RegularAnnunciationTypeID", (annunciation.RegularAnnunciationTypeID != null && annunciation.RegularAnnunciationTypeID >0 ) ? annunciation.RegularAnnunciationTypeID : (object)DBNull.Value),
			new SqlParameter("@AnnunciationResultTypeID", (annunciation.AnnunciationResultTypeID != null && annunciation.AnnunciationResultTypeID >0 ) ? annunciation.AnnunciationResultTypeID : (object)DBNull.Value),
			new SqlParameter("@OperatorTypeID", (annunciation.OperatorTypeID != null && annunciation.OperatorTypeID >0 ) ? annunciation.OperatorTypeID : (object)DBNull.Value),
			new SqlParameter("@Reject1", (annunciation.Reject1 != null) ? annunciation.Reject1 : (object)DBNull.Value),
			new SqlParameter("@Reject2", (annunciation.Reject2 != null) ? annunciation.Reject2 : (object)DBNull.Value),
			new SqlParameter("@Reject3", (annunciation.Reject3 != null) ? annunciation.Reject3 : (object)DBNull.Value),
			new SqlParameter("@Reject4", (annunciation.Reject4 != null) ? annunciation.Reject4 : (object)DBNull.Value),
			new SqlParameter("@Reject5", (annunciation.Reject5 != null) ? annunciation.Reject5 : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Annunciation_Update", CommandType.StoredProcedure, parametersAnnunciation);
	}

	public bool Delete(int annunciationPaperTypeID , Int64 heirID)
	{
		SqlParameter[] parametersAnnunciation = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationPaperTypeID", annunciationPaperTypeID),
			new SqlParameter("@HeirID", heirID)
		};
		return SqlDBHelper.ExecuteNonQuery("Annunciation_Delete", CommandType.StoredProcedure, parametersAnnunciation);
	}

	public Annunciation GetDetails(int annunciationPaperTypeID , Int64 heirID)
	{
		Annunciation annunciation = new Annunciation();

		SqlParameter[] parametersAnnunciation = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationPaperTypeID", annunciationPaperTypeID),
			new SqlParameter("@HeirID", heirID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Annunciation_GetDetails", CommandType.StoredProcedure, parametersAnnunciation))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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
			}
		}

		return annunciation;
	}

	public List<Annunciation> GetListAll()
	{
		List<Annunciation> listAnnunciation = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Annunciation_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listAnnunciation = new List<Annunciation>();

				foreach (DataRow row in table.Rows)
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
					listAnnunciation.Add(annunciation);
				}
			}
		}

		return listAnnunciation;
	}

	public bool Exists(int annunciationPaperTypeID , Int64 heirID)
	{
		SqlParameter[] parametersAnnunciation = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationPaperTypeID", annunciationPaperTypeID),
			new SqlParameter("@HeirID", heirID)
		};
		return (SqlDBHelper.ExecuteScalar("Annunciation_Exists", CommandType.StoredProcedure, parametersAnnunciation)>0);
	}

	public bool Exists(Annunciation annunciation)
	{
		SqlParameter[] parametersAnnunciation = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationPaperTypeID", annunciation.AnnunciationPaperTypeID),
			new SqlParameter("@HeirID", annunciation.HeirID)
		};
		return (SqlDBHelper.ExecuteScalar("Annunciation_Exists", CommandType.StoredProcedure, parametersAnnunciation)>0);
	}

	public List<Annunciation> SearchLike(Annunciation annunciation)
	{
		List<Annunciation> listAnnunciation = new List<Annunciation>();


		SqlParameter[] parametersAnnunciation = new SqlParameter[]
		{
			new SqlParameter("@AnnunciationPaperTypeID", annunciation.AnnunciationPaperTypeID),
			new SqlParameter("@HeirID", annunciation.HeirID),
			new SqlParameter("@RegisterDate1", annunciation.RegisterDate1),
			new SqlParameter("@AnnunciationPlaceIDTitle", annunciation.AnnunciationPlaceIDTitle),
			new SqlParameter("@AnnunciationResultTypeIDTitle", annunciation.AnnunciationResultTypeIDTitle),
			new SqlParameter("@AnnunciationToOthersReasonIDTitle", annunciation.AnnunciationToOthersReasonIDTitle),
			new SqlParameter("@AnnunciationToTypeIDTitle", annunciation.AnnunciationToTypeIDTitle),
			new SqlParameter("@RegularAnnunciationReasonIDTitle", annunciation.RegularAnnunciationReasonIDTitle),
			new SqlParameter("@RegularAnnunciationTypeIDTitle", annunciation.RegularAnnunciationTypeIDTitle),
			new SqlParameter("@OldRegisterInformationID", annunciation.OldRegisterInformationID),
			new SqlParameter("@OldRegisterDate", annunciation.OldRegisterDate),
			new SqlParameter("@RegisterDate2", annunciation.RegisterDate2),
			new SqlParameter("@PaperRegisterDate", annunciation.PaperRegisterDate),
			new SqlParameter("@OperatorName", annunciation.OperatorName),
			new SqlParameter("@Reciver", annunciation.Reciver),
			new SqlParameter("@RelationToHeir", annunciation.RelationToHeir),
			new SqlParameter("@Annuncier", annunciation.Annuncier),
			new SqlParameter("@RejectOther", annunciation.RejectOther),
			new SqlParameter("@RegisterInformationID2", annunciation.RegisterInformationID2),
			new SqlParameter("@PaperRegisterInformationID", annunciation.PaperRegisterInformationID),
			new SqlParameter("@AnnunciationDate", annunciation.AnnunciationDate),
			new SqlParameter("@PaperDate", annunciation.PaperDate),
			new SqlParameter("@AnnunciationToTypeID", annunciation.AnnunciationToTypeID),
			new SqlParameter("@AnnunciationPlaceID", annunciation.AnnunciationPlaceID),
			new SqlParameter("@AnnunciationToOthersReasonID", annunciation.AnnunciationToOthersReasonID),
			new SqlParameter("@RegisterInformationID", annunciation.RegisterInformationID),
			new SqlParameter("@RegularAnnunciationReasonID", annunciation.RegularAnnunciationReasonID),
			new SqlParameter("@RegularAnnunciationTypeID", annunciation.RegularAnnunciationTypeID),
			new SqlParameter("@AnnunciationResultTypeID", annunciation.AnnunciationResultTypeID),
			new SqlParameter("@OperatorTypeID", annunciation.OperatorTypeID),
			new SqlParameter("@Reject1", annunciation.Reject1),
			new SqlParameter("@Reject2", annunciation.Reject2),
			new SqlParameter("@Reject3", annunciation.Reject3),
			new SqlParameter("@Reject4", annunciation.Reject4),
			new SqlParameter("@Reject5", annunciation.Reject5),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Annunciation_SearchLike", CommandType.StoredProcedure, parametersAnnunciation))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Annunciation tmpAnnunciation = new Annunciation();
					tmpAnnunciation.AnnunciationPaperTypeID = (row["AnnunciationPaperTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AnnunciationPaperTypeID"]) : 0 ;
					tmpAnnunciation.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
					tmpAnnunciation.RegisterDate1 = row["RegisterDate1"].ToString();
					tmpAnnunciation.AnnunciationPlaceIDTitle = row["AnnunciationPlaceIDTitle"].ToString();
					tmpAnnunciation.AnnunciationResultTypeIDTitle = row["AnnunciationResultTypeIDTitle"].ToString();
					tmpAnnunciation.AnnunciationToOthersReasonIDTitle = row["AnnunciationToOthersReasonIDTitle"].ToString();
					tmpAnnunciation.AnnunciationToTypeIDTitle = row["AnnunciationToTypeIDTitle"].ToString();
					tmpAnnunciation.RegularAnnunciationReasonIDTitle = row["RegularAnnunciationReasonIDTitle"].ToString();
					tmpAnnunciation.RegularAnnunciationTypeIDTitle = row["RegularAnnunciationTypeIDTitle"].ToString();
					tmpAnnunciation.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					tmpAnnunciation.OldRegisterDate = row["OldRegisterDate"].ToString();
					tmpAnnunciation.RegisterDate2 = row["RegisterDate2"].ToString();
					tmpAnnunciation.PaperRegisterDate = row["PaperRegisterDate"].ToString();
					tmpAnnunciation.OperatorName = row["OperatorName"].ToString();
					tmpAnnunciation.Reciver = row["Reciver"].ToString();
					tmpAnnunciation.RelationToHeir = row["RelationToHeir"].ToString();
					tmpAnnunciation.Annuncier = row["Annuncier"].ToString();
					tmpAnnunciation.RejectOther = row["RejectOther"].ToString();
					tmpAnnunciation.RegisterInformationID2 = (row["RegisterInformationID2"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID2"]) : 0 ;
					tmpAnnunciation.PaperRegisterInformationID = (row["PaperRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["PaperRegisterInformationID"]) : 0 ;
					tmpAnnunciation.AnnunciationDate = row["AnnunciationDate"].ToString();
					tmpAnnunciation.PaperDate = row["PaperDate"].ToString();
					tmpAnnunciation.AnnunciationToTypeID = (row["AnnunciationToTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AnnunciationToTypeID"]) : 0 ;
					tmpAnnunciation.AnnunciationPlaceID = (row["AnnunciationPlaceID"] != DBNull.Value) ? Convert.ToInt32(row["AnnunciationPlaceID"]) : 0 ;
					tmpAnnunciation.AnnunciationToOthersReasonID = (row["AnnunciationToOthersReasonID"] != DBNull.Value) ? Convert.ToInt32(row["AnnunciationToOthersReasonID"]) : 0 ;
					tmpAnnunciation.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt32(row["RegisterInformationID"]) : 0 ;
					tmpAnnunciation.RegularAnnunciationReasonID = (row["RegularAnnunciationReasonID"] != DBNull.Value) ? Convert.ToInt32(row["RegularAnnunciationReasonID"]) : 0 ;
					tmpAnnunciation.RegularAnnunciationTypeID = (row["RegularAnnunciationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["RegularAnnunciationTypeID"]) : 0 ;
					tmpAnnunciation.AnnunciationResultTypeID = (row["AnnunciationResultTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AnnunciationResultTypeID"]) : 0 ;
					tmpAnnunciation.OperatorTypeID = (row["OperatorTypeID"] != DBNull.Value) ? Convert.ToInt32(row["OperatorTypeID"]) : 0 ;
					tmpAnnunciation.Reject1 = (row["Reject1"] != DBNull.Value) ? Convert.ToBoolean((row["Reject1"].ToString() == "1" || row["Reject1"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpAnnunciation.Reject2 = (row["Reject2"] != DBNull.Value) ? Convert.ToBoolean((row["Reject2"].ToString() == "1" || row["Reject2"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpAnnunciation.Reject3 = (row["Reject3"] != DBNull.Value) ? Convert.ToBoolean((row["Reject3"].ToString() == "1" || row["Reject3"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpAnnunciation.Reject4 = (row["Reject4"] != DBNull.Value) ? Convert.ToBoolean((row["Reject4"].ToString() == "1" || row["Reject4"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpAnnunciation.Reject5 = (row["Reject5"] != DBNull.Value) ? Convert.ToBoolean((row["Reject5"].ToString() == "1" || row["Reject5"].ToString().ToLower() == "true" ) ? true : false) : false ;

					listAnnunciation.Add(tmpAnnunciation);
				}
			}
		}

		return listAnnunciation;
	}

}
}
