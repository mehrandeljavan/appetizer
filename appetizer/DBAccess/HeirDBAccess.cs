using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class HeirDBAccess
{
	PersonDBAccess personDBAccess = new PersonDBAccess();

	AdjustmentHeritageDBAccess adjustmentHeritageDBAccess = new AdjustmentHeritageDBAccess();
	AnnunciationDBAccess annunciationDBAccess = new AnnunciationDBAccess();
	CommissionAdjustmentHeritageDBAccess commissionAdjustmentHeritageDBAccess = new CommissionAdjustmentHeritageDBAccess();
	CommissionInvitationDBAccess commissionInvitationDBAccess = new CommissionInvitationDBAccess();
	CommissionVerdictDBAccess commissionVerdictDBAccess = new CommissionVerdictDBAccess();

	public List<AdjustmentHeritage> GetListAdjustmentHeritage(Int64 heirID)
	{
		List<AdjustmentHeritage> listAdjustmentHeritage = new List<AdjustmentHeritage>() { };
		SqlParameter[] parametersHeir = new SqlParameter[]
		{
			new SqlParameter("@HeirID", heirID)
		};

		//Lets get the list of AdjustmentHeritage records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("AdjustmentHeritage_GetList_UseInHeir", CommandType.StoredProcedure, parametersHeir))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of adjustmentHeritage
				listAdjustmentHeritage = new List<AdjustmentHeritage>();

				//Now lets populate the AdjustmentHeritage details into the list of adjustmentHeritages
				foreach (DataRow row in table.Rows)
				{
					AdjustmentHeritage adjustmentHeritage = ConvertRowToAdjustmentHeritage(row);
					listAdjustmentHeritage.Add(adjustmentHeritage);
				}
			}
		}

		return listAdjustmentHeritage;
	}

	private AdjustmentHeritage ConvertRowToAdjustmentHeritage(DataRow row)
	{
		AdjustmentHeritage adjustmentHeritage = new AdjustmentHeritage();
		adjustmentHeritage.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
		adjustmentHeritage.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		adjustmentHeritage.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		adjustmentHeritage.OldRegisterDate = row["OldRegisterDate"].ToString();
		adjustmentHeritage.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		adjustmentHeritage.AdjustmentValue1 = (row["AdjustmentValue1"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue1"]) : 0 ;
		adjustmentHeritage.AdjustmentValue2 = (row["AdjustmentValue2"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue2"]) : 0 ;
		return adjustmentHeritage;
	}
	public List<Annunciation> GetListAnnunciation(Int64 heirID)
	{
		List<Annunciation> listAnnunciation = new List<Annunciation>() { };
		SqlParameter[] parametersHeir = new SqlParameter[]
		{
			new SqlParameter("@HeirID", heirID)
		};

		//Lets get the list of Annunciation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Annunciation_GetList_UseInHeir", CommandType.StoredProcedure, parametersHeir))
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
	public List<CommissionAdjustmentHeritage> GetListCommissionAdjustmentHeritage(Int64 heirID)
	{
		List<CommissionAdjustmentHeritage> listCommissionAdjustmentHeritage = new List<CommissionAdjustmentHeritage>() { };
		SqlParameter[] parametersHeir = new SqlParameter[]
		{
			new SqlParameter("@HeirID", heirID)
		};

		//Lets get the list of CommissionAdjustmentHeritage records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionAdjustmentHeritage_GetList_UseInHeir", CommandType.StoredProcedure, parametersHeir))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of commissionAdjustmentHeritage
				listCommissionAdjustmentHeritage = new List<CommissionAdjustmentHeritage>();

				//Now lets populate the CommissionAdjustmentHeritage details into the list of commissionAdjustmentHeritages
				foreach (DataRow row in table.Rows)
				{
					CommissionAdjustmentHeritage commissionAdjustmentHeritage = ConvertRowToCommissionAdjustmentHeritage(row);
					listCommissionAdjustmentHeritage.Add(commissionAdjustmentHeritage);
				}
			}
		}

		return listCommissionAdjustmentHeritage;
	}

	private CommissionAdjustmentHeritage ConvertRowToCommissionAdjustmentHeritage(DataRow row)
	{
		CommissionAdjustmentHeritage commissionAdjustmentHeritage = new CommissionAdjustmentHeritage();
		commissionAdjustmentHeritage.CommissionVerdictTypeID = (row["CommissionVerdictTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionVerdictTypeID"]) : 0 ;
		commissionAdjustmentHeritage.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
		commissionAdjustmentHeritage.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		commissionAdjustmentHeritage.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		commissionAdjustmentHeritage.OldRegisterDate = row["OldRegisterDate"].ToString();
		commissionAdjustmentHeritage.AdjustmentValue1 = (row["AdjustmentValue1"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue1"]) : 0 ;
		commissionAdjustmentHeritage.AdjustmentValue2 = (row["AdjustmentValue2"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentValue2"]) : 0 ;
		commissionAdjustmentHeritage.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		return commissionAdjustmentHeritage;
	}
	public List<CommissionInvitation> GetListCommissionInvitation(Int64 heirID)
	{
		List<CommissionInvitation> listCommissionInvitation = new List<CommissionInvitation>() { };
		SqlParameter[] parametersHeir = new SqlParameter[]
		{
			new SqlParameter("@HeirID", heirID)
		};

		//Lets get the list of CommissionInvitation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionInvitation_GetList_UseInHeir", CommandType.StoredProcedure, parametersHeir))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of commissionInvitation
				listCommissionInvitation = new List<CommissionInvitation>();

				//Now lets populate the CommissionInvitation details into the list of commissionInvitations
				foreach (DataRow row in table.Rows)
				{
					CommissionInvitation commissionInvitation = ConvertRowToCommissionInvitation(row);
					listCommissionInvitation.Add(commissionInvitation);
				}
			}
		}

		return listCommissionInvitation;
	}

	private CommissionInvitation ConvertRowToCommissionInvitation(DataRow row)
	{
		CommissionInvitation commissionInvitation = new CommissionInvitation();
		commissionInvitation.CommissionInvitationID = (row["CommissionInvitationID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionInvitationID"]) : 0 ;
		commissionInvitation.InvitationTypeIDTitle = row["InvitationTypeIDTitle"].ToString();
		commissionInvitation.CommissionTypeIDTitle = row["CommissionTypeIDTitle"].ToString();
		commissionInvitation.CommissionDayIDTitle = row["CommissionDayIDTitle"].ToString();
		commissionInvitation.InvitationTypeID = (row["InvitationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["InvitationTypeID"]) : 0 ;
		commissionInvitation.CommissionTypeID = (row["CommissionTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionTypeID"]) : 0 ;
		commissionInvitation.CommissionDayID = (row["CommissionDayID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionDayID"]) : 0 ;
		commissionInvitation.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
		commissionInvitation.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		commissionInvitation.CommissionHour = row["CommissionHour"].ToString();
		commissionInvitation.CommssionDate = row["CommssionDate"].ToString();
		commissionInvitation.CommissionAddress = row["CommissionAddress"].ToString();
		return commissionInvitation;
	}
	public List<CommissionVerdict> GetListCommissionVerdict(Int64 heirID)
	{
		List<CommissionVerdict> listCommissionVerdict = new List<CommissionVerdict>() { };
		SqlParameter[] parametersHeir = new SqlParameter[]
		{
			new SqlParameter("@HeirID", heirID)
		};

		//Lets get the list of CommissionVerdict records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionVerdict_GetList_UseInHeir", CommandType.StoredProcedure, parametersHeir))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of commissionVerdict
				listCommissionVerdict = new List<CommissionVerdict>();

				//Now lets populate the CommissionVerdict details into the list of commissionVerdicts
				foreach (DataRow row in table.Rows)
				{
					CommissionVerdict commissionVerdict = ConvertRowToCommissionVerdict(row);
					listCommissionVerdict.Add(commissionVerdict);
				}
			}
		}

		return listCommissionVerdict;
	}

	private CommissionVerdict ConvertRowToCommissionVerdict(DataRow row)
	{
		CommissionVerdict commissionVerdict = new CommissionVerdict();
		commissionVerdict.CommissionVerdictTypeID = (row["CommissionVerdictTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionVerdictTypeID"]) : 0 ;
		commissionVerdict.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
		commissionVerdict.CommissionVerdictTypeIDTitle = row["CommissionVerdictTypeIDTitle"].ToString();
		commissionVerdict.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		commissionVerdict.OldRegisterDate = row["OldRegisterDate"].ToString();
		commissionVerdict.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		commissionVerdict.VerdictDate = row["VerdictDate"].ToString();
		commissionVerdict.VerdictNumber = row["VerdictNumber"].ToString();
		commissionVerdict.Comment = row["Comment"].ToString();
		return commissionVerdict;
	}
	public Int64 Insert(Heir heir)
	{
		if (!personDBAccess.Exists(heir))
			heir.NationalCode = personDBAccess.Insert(heir);

		SqlParameter[] parametersHeir = new SqlParameter[]
		{
			new SqlParameter("@RelationID", (heir.RelationID > 0) ? heir.RelationID : (object)DBNull.Value),
			new SqlParameter("@NationalityID", (heir.NationalityID > 0) ? heir.NationalityID : (object)DBNull.Value),
			new SqlParameter("@ResidenceID", (heir.ResidenceID > 0) ? heir.ResidenceID : (object)DBNull.Value),
			new SqlParameter("@PhysicalStateID", (heir.PhysicalStateID > 0) ? heir.PhysicalStateID : (object)DBNull.Value),
			new SqlParameter("@EducationStateID", (heir.EducationStateID > 0) ? heir.EducationStateID : (object)DBNull.Value),
			new SqlParameter("@MarriageID", (heir.MarriageID > 0) ? heir.MarriageID : (object)DBNull.Value),
			new SqlParameter("@Stage", (heir.Stage != null) ? heir.Stage : (object)DBNull.Value),
			new SqlParameter("@AgreementTypeID", (heir.AgreementTypeID > 0) ? heir.AgreementTypeID : (object)DBNull.Value),
			new SqlParameter("@DeclerativeShare", (heir.DeclerativeShare != null) ? heir.DeclerativeShare : (object)DBNull.Value),
			new SqlParameter("@DiagnosisShare", (heir.DiagnosisShare != null) ? heir.DiagnosisShare : (object)DBNull.Value),
			new SqlParameter("@HandShare", heir.HandShare),
			new SqlParameter("@AdjustmentTaxValue", (heir.AdjustmentTaxValue != null) ? heir.AdjustmentTaxValue : (object)DBNull.Value),
			new SqlParameter("@AdjustmentIncomeValue", (heir.AdjustmentIncomeValue != null) ? heir.AdjustmentIncomeValue : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareValue1", (heir.CommissionAdjustmentShareValue1 != null) ? heir.CommissionAdjustmentShareValue1 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeValue4", (heir.CommissionAdjustmentIncomeValue4 != null) ? heir.CommissionAdjustmentIncomeValue4 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareValue5", (heir.CommissionAdjustmentShareValue5 != null) ? heir.CommissionAdjustmentShareValue5 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeValue5", (heir.CommissionAdjustmentIncomeValue5 != null) ? heir.CommissionAdjustmentIncomeValue5 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareValue6", (heir.CommissionAdjustmentShareValue6 != null) ? heir.CommissionAdjustmentShareValue6 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeValue6", (heir.CommissionAdjustmentIncomeValue6 != null) ? heir.CommissionAdjustmentIncomeValue6 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeValue1", (heir.CommissionAdjustmentIncomeValue1 != null) ? heir.CommissionAdjustmentIncomeValue1 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareValue2", (heir.CommissionAdjustmentShareValue2 != null) ? heir.CommissionAdjustmentShareValue2 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeValue2", (heir.CommissionAdjustmentIncomeValue2 != null) ? heir.CommissionAdjustmentIncomeValue2 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareValue3", (heir.CommissionAdjustmentShareValue3 != null) ? heir.CommissionAdjustmentShareValue3 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeValue3", (heir.CommissionAdjustmentIncomeValue3 != null) ? heir.CommissionAdjustmentIncomeValue3 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareValue4", (heir.CommissionAdjustmentShareValue4 != null) ? heir.CommissionAdjustmentShareValue4 : (object)DBNull.Value),
			new SqlParameter("@IsDiagonesed", (heir.IsDiagonesed != null) ? heir.IsDiagonesed : (object)DBNull.Value),
			new SqlParameter("@ParentHeirID", (heir.ParentHeirID != null) ? heir.ParentHeirID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (heir.DeclarationID > 0) ? heir.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@NationalCode", (heir.NationalCode > 0) ? heir.NationalCode : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", (heir.RegisterInformationID > 0) ? heir.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@AdjustmentTaxRegisterInformationID", (heir.AdjustmentTaxRegisterInformationID != null) ? heir.AdjustmentTaxRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeRegisterInformationID5", (heir.CommissionAdjustmentIncomeRegisterInformationID5 != null) ? heir.CommissionAdjustmentIncomeRegisterInformationID5 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareRegisterInformationID6", (heir.CommissionAdjustmentShareRegisterInformationID6 != null) ? heir.CommissionAdjustmentShareRegisterInformationID6 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeRegisterInformationID6", (heir.CommissionAdjustmentIncomeRegisterInformationID6 != null) ? heir.CommissionAdjustmentIncomeRegisterInformationID6 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeRegisterInformationID2", (heir.CommissionAdjustmentIncomeRegisterInformationID2 != null) ? heir.CommissionAdjustmentIncomeRegisterInformationID2 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareRegisterInformationID3", (heir.CommissionAdjustmentShareRegisterInformationID3 != null) ? heir.CommissionAdjustmentShareRegisterInformationID3 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeRegisterInformationID3", (heir.CommissionAdjustmentIncomeRegisterInformationID3 != null) ? heir.CommissionAdjustmentIncomeRegisterInformationID3 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareRegisterInformationID4", (heir.CommissionAdjustmentShareRegisterInformationID4 != null) ? heir.CommissionAdjustmentShareRegisterInformationID4 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeRegisterInformationID4", (heir.CommissionAdjustmentIncomeRegisterInformationID4 != null) ? heir.CommissionAdjustmentIncomeRegisterInformationID4 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareRegisterInformationID5", (heir.CommissionAdjustmentShareRegisterInformationID5 != null) ? heir.CommissionAdjustmentShareRegisterInformationID5 : (object)DBNull.Value),
			new SqlParameter("@AdjustmentIncomeRegisterInformationID", (heir.AdjustmentIncomeRegisterInformationID != null) ? heir.AdjustmentIncomeRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareRegisterInformationID1", (heir.CommissionAdjustmentShareRegisterInformationID1 != null) ? heir.CommissionAdjustmentShareRegisterInformationID1 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeRegisterInformationID1", (heir.CommissionAdjustmentIncomeRegisterInformationID1 != null) ? heir.CommissionAdjustmentIncomeRegisterInformationID1 : (object)DBNull.Value),
			new SqlParameter("@AdjustmentHeritageRegisterInformationID", (heir.AdjustmentHeritageRegisterInformationID != null) ? heir.AdjustmentHeritageRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentHeritageRegisterInformationID", (heir.CommissionAdjustmentHeritageRegisterInformationID != null) ? heir.CommissionAdjustmentHeritageRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareRegisterInformationID2", (heir.CommissionAdjustmentShareRegisterInformationID2 != null) ? heir.CommissionAdjustmentShareRegisterInformationID2 : (object)DBNull.Value),
			new SqlParameter("@AdjustmentTaxDate", (heir.AdjustmentTaxDate != null) ? heir.AdjustmentTaxDate : (object)DBNull.Value),
			new SqlParameter("@AdjustmentIncomeDate", (heir.AdjustmentIncomeDate != null) ? heir.AdjustmentIncomeDate : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareDate1", (heir.CommissionAdjustmentShareDate1 != null) ? heir.CommissionAdjustmentShareDate1 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeDate1", (heir.CommissionAdjustmentIncomeDate1 != null) ? heir.CommissionAdjustmentIncomeDate1 : (object)DBNull.Value),
			new SqlParameter("@AdjustmentHeritageDate", (heir.AdjustmentHeritageDate != null) ? heir.AdjustmentHeritageDate : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentHeritageDate", (heir.CommissionAdjustmentHeritageDate != null) ? heir.CommissionAdjustmentHeritageDate : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeDate4", (heir.CommissionAdjustmentIncomeDate4 != null) ? heir.CommissionAdjustmentIncomeDate4 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareDate5", (heir.CommissionAdjustmentShareDate5 != null) ? heir.CommissionAdjustmentShareDate5 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeDate5", (heir.CommissionAdjustmentIncomeDate5 != null) ? heir.CommissionAdjustmentIncomeDate5 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareDate6", (heir.CommissionAdjustmentShareDate6 != null) ? heir.CommissionAdjustmentShareDate6 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeDate6", (heir.CommissionAdjustmentIncomeDate6 != null) ? heir.CommissionAdjustmentIncomeDate6 : (object)DBNull.Value),
			new SqlParameter("@AdjustmentFinalizationDate", (heir.AdjustmentFinalizationDate != null) ? heir.AdjustmentFinalizationDate : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareDate2", (heir.CommissionAdjustmentShareDate2 != null) ? heir.CommissionAdjustmentShareDate2 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeDate2", (heir.CommissionAdjustmentIncomeDate2 != null) ? heir.CommissionAdjustmentIncomeDate2 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareDate3", (heir.CommissionAdjustmentShareDate3 != null) ? heir.CommissionAdjustmentShareDate3 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeDate3", (heir.CommissionAdjustmentIncomeDate3 != null) ? heir.CommissionAdjustmentIncomeDate3 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareDate4", (heir.CommissionAdjustmentShareDate4 != null) ? heir.CommissionAdjustmentShareDate4 : (object)DBNull.Value)
		};
		heir.HeirID = SqlDBHelper.ExecuteScalar("Heir_Insert", CommandType.StoredProcedure, parametersHeir);
		return heir.HeirID;
	}

	public bool Update(Heir heir)
	{
		personDBAccess.Update(heir);

		SqlParameter[] parametersHeir = new SqlParameter[]
		{
			new SqlParameter("@HeirID", heir.HeirID),
			new SqlParameter("@RelationID", heir.RelationID),
			new SqlParameter("@NationalityID", (heir.NationalityID != null && heir.NationalityID >0 ) ? heir.NationalityID : (object)DBNull.Value),
			new SqlParameter("@ResidenceID", (heir.ResidenceID != null && heir.ResidenceID >0 ) ? heir.ResidenceID : (object)DBNull.Value),
			new SqlParameter("@PhysicalStateID", heir.PhysicalStateID),
			new SqlParameter("@EducationStateID", heir.EducationStateID),
			new SqlParameter("@MarriageID", heir.MarriageID),
			new SqlParameter("@Stage", (heir.Stage != null) ? heir.Stage : (object)DBNull.Value),
			new SqlParameter("@AgreementTypeID", (heir.AgreementTypeID != null && heir.AgreementTypeID >0 ) ? heir.AgreementTypeID : (object)DBNull.Value),
			new SqlParameter("@DeclerativeShare", (heir.DeclerativeShare != null) ? heir.DeclerativeShare : (object)DBNull.Value),
			new SqlParameter("@DiagnosisShare", (heir.DiagnosisShare != null) ? heir.DiagnosisShare : (object)DBNull.Value),
			new SqlParameter("@HandShare", heir.HandShare),
			new SqlParameter("@AdjustmentTaxValue", (heir.AdjustmentTaxValue != null) ? heir.AdjustmentTaxValue : (object)DBNull.Value),
			new SqlParameter("@AdjustmentIncomeValue", (heir.AdjustmentIncomeValue != null) ? heir.AdjustmentIncomeValue : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareValue1", (heir.CommissionAdjustmentShareValue1 != null) ? heir.CommissionAdjustmentShareValue1 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeValue4", (heir.CommissionAdjustmentIncomeValue4 != null) ? heir.CommissionAdjustmentIncomeValue4 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareValue5", (heir.CommissionAdjustmentShareValue5 != null) ? heir.CommissionAdjustmentShareValue5 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeValue5", (heir.CommissionAdjustmentIncomeValue5 != null) ? heir.CommissionAdjustmentIncomeValue5 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareValue6", (heir.CommissionAdjustmentShareValue6 != null) ? heir.CommissionAdjustmentShareValue6 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeValue6", (heir.CommissionAdjustmentIncomeValue6 != null) ? heir.CommissionAdjustmentIncomeValue6 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeValue1", (heir.CommissionAdjustmentIncomeValue1 != null) ? heir.CommissionAdjustmentIncomeValue1 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareValue2", (heir.CommissionAdjustmentShareValue2 != null) ? heir.CommissionAdjustmentShareValue2 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeValue2", (heir.CommissionAdjustmentIncomeValue2 != null) ? heir.CommissionAdjustmentIncomeValue2 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareValue3", (heir.CommissionAdjustmentShareValue3 != null) ? heir.CommissionAdjustmentShareValue3 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeValue3", (heir.CommissionAdjustmentIncomeValue3 != null) ? heir.CommissionAdjustmentIncomeValue3 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareValue4", (heir.CommissionAdjustmentShareValue4 != null) ? heir.CommissionAdjustmentShareValue4 : (object)DBNull.Value),
			new SqlParameter("@IsDiagonesed", (heir.IsDiagonesed != null) ? heir.IsDiagonesed : (object)DBNull.Value),
			new SqlParameter("@ParentHeirID", (heir.ParentHeirID != null) ? heir.ParentHeirID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", heir.DeclarationID),
			new SqlParameter("@NationalCode", (heir.NationalCode != null && heir.NationalCode >0 ) ? heir.NationalCode : (object)DBNull.Value),
			new SqlParameter("@RegisterInformationID", (heir.RegisterInformationID != null && heir.RegisterInformationID >0 ) ? heir.RegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@AdjustmentTaxRegisterInformationID", (heir.AdjustmentTaxRegisterInformationID != null) ? heir.AdjustmentTaxRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeRegisterInformationID5", (heir.CommissionAdjustmentIncomeRegisterInformationID5 != null) ? heir.CommissionAdjustmentIncomeRegisterInformationID5 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareRegisterInformationID6", (heir.CommissionAdjustmentShareRegisterInformationID6 != null) ? heir.CommissionAdjustmentShareRegisterInformationID6 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeRegisterInformationID6", (heir.CommissionAdjustmentIncomeRegisterInformationID6 != null) ? heir.CommissionAdjustmentIncomeRegisterInformationID6 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeRegisterInformationID2", (heir.CommissionAdjustmentIncomeRegisterInformationID2 != null) ? heir.CommissionAdjustmentIncomeRegisterInformationID2 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareRegisterInformationID3", (heir.CommissionAdjustmentShareRegisterInformationID3 != null) ? heir.CommissionAdjustmentShareRegisterInformationID3 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeRegisterInformationID3", (heir.CommissionAdjustmentIncomeRegisterInformationID3 != null) ? heir.CommissionAdjustmentIncomeRegisterInformationID3 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareRegisterInformationID4", (heir.CommissionAdjustmentShareRegisterInformationID4 != null) ? heir.CommissionAdjustmentShareRegisterInformationID4 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeRegisterInformationID4", (heir.CommissionAdjustmentIncomeRegisterInformationID4 != null) ? heir.CommissionAdjustmentIncomeRegisterInformationID4 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareRegisterInformationID5", (heir.CommissionAdjustmentShareRegisterInformationID5 != null) ? heir.CommissionAdjustmentShareRegisterInformationID5 : (object)DBNull.Value),
			new SqlParameter("@AdjustmentIncomeRegisterInformationID", (heir.AdjustmentIncomeRegisterInformationID != null) ? heir.AdjustmentIncomeRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareRegisterInformationID1", (heir.CommissionAdjustmentShareRegisterInformationID1 != null) ? heir.CommissionAdjustmentShareRegisterInformationID1 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeRegisterInformationID1", (heir.CommissionAdjustmentIncomeRegisterInformationID1 != null) ? heir.CommissionAdjustmentIncomeRegisterInformationID1 : (object)DBNull.Value),
			new SqlParameter("@AdjustmentHeritageRegisterInformationID", (heir.AdjustmentHeritageRegisterInformationID != null) ? heir.AdjustmentHeritageRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentHeritageRegisterInformationID", (heir.CommissionAdjustmentHeritageRegisterInformationID != null) ? heir.CommissionAdjustmentHeritageRegisterInformationID : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareRegisterInformationID2", (heir.CommissionAdjustmentShareRegisterInformationID2 != null) ? heir.CommissionAdjustmentShareRegisterInformationID2 : (object)DBNull.Value),
			new SqlParameter("@AdjustmentTaxDate", (heir.AdjustmentTaxDate != null) ? heir.AdjustmentTaxDate : (object)DBNull.Value),
			new SqlParameter("@AdjustmentIncomeDate", (heir.AdjustmentIncomeDate != null) ? heir.AdjustmentIncomeDate : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareDate1", (heir.CommissionAdjustmentShareDate1 != null) ? heir.CommissionAdjustmentShareDate1 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeDate1", (heir.CommissionAdjustmentIncomeDate1 != null) ? heir.CommissionAdjustmentIncomeDate1 : (object)DBNull.Value),
			new SqlParameter("@AdjustmentHeritageDate", (heir.AdjustmentHeritageDate != null) ? heir.AdjustmentHeritageDate : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentHeritageDate", (heir.CommissionAdjustmentHeritageDate != null) ? heir.CommissionAdjustmentHeritageDate : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeDate4", (heir.CommissionAdjustmentIncomeDate4 != null) ? heir.CommissionAdjustmentIncomeDate4 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareDate5", (heir.CommissionAdjustmentShareDate5 != null) ? heir.CommissionAdjustmentShareDate5 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeDate5", (heir.CommissionAdjustmentIncomeDate5 != null) ? heir.CommissionAdjustmentIncomeDate5 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareDate6", (heir.CommissionAdjustmentShareDate6 != null) ? heir.CommissionAdjustmentShareDate6 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeDate6", (heir.CommissionAdjustmentIncomeDate6 != null) ? heir.CommissionAdjustmentIncomeDate6 : (object)DBNull.Value),
			new SqlParameter("@AdjustmentFinalizationDate", (heir.AdjustmentFinalizationDate != null) ? heir.AdjustmentFinalizationDate : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareDate2", (heir.CommissionAdjustmentShareDate2 != null) ? heir.CommissionAdjustmentShareDate2 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeDate2", (heir.CommissionAdjustmentIncomeDate2 != null) ? heir.CommissionAdjustmentIncomeDate2 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareDate3", (heir.CommissionAdjustmentShareDate3 != null) ? heir.CommissionAdjustmentShareDate3 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentIncomeDate3", (heir.CommissionAdjustmentIncomeDate3 != null) ? heir.CommissionAdjustmentIncomeDate3 : (object)DBNull.Value),
			new SqlParameter("@CommissionAdjustmentShareDate4", (heir.CommissionAdjustmentShareDate4 != null) ? heir.CommissionAdjustmentShareDate4 : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Heir_Update", CommandType.StoredProcedure, parametersHeir);
	}

	public bool Delete(Int64 heirID)
	{
		SqlParameter[] parametersHeir = new SqlParameter[]
		{
			new SqlParameter("@HeirID", heirID)
		};
		return SqlDBHelper.ExecuteNonQuery("Heir_Delete", CommandType.StoredProcedure, parametersHeir);
	}

	public Heir GetDetails(Int64 heirID)
	{
		Heir heir = new Heir();

		SqlParameter[] parametersHeir = new SqlParameter[]
		{
			new SqlParameter("@HeirID", heirID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Heir_GetDetails", CommandType.StoredProcedure, parametersHeir))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				heir.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
				heir.RelationIDTitle = row["RelationIDTitle"].ToString();
				heir.EducationStateIDTitle = row["EducationStateIDTitle"].ToString();
				heir.MarriageIDTitle = row["MarriageIDTitle"].ToString();
				heir.NationalityIDTitle = row["NationalityIDTitle"].ToString();
				heir.PhysicalStateIDTitle = row["PhysicalStateIDTitle"].ToString();
				heir.ResidenceIDTitle = row["ResidenceIDTitle"].ToString();
				heir.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
				heir.OldRegisterDate = row["OldRegisterDate"].ToString();
				heir.RelationID = (row["RelationID"] != DBNull.Value) ? Convert.ToInt32(row["RelationID"]) : 0 ;
				heir.NationalityID = (row["NationalityID"] != DBNull.Value) ? Convert.ToInt32(row["NationalityID"]) : 0 ;
				heir.ResidenceID = (row["ResidenceID"] != DBNull.Value) ? Convert.ToInt32(row["ResidenceID"]) : 0 ;
				heir.PhysicalStateID = (row["PhysicalStateID"] != DBNull.Value) ? Convert.ToInt32(row["PhysicalStateID"]) : 0 ;
				heir.EducationStateID = (row["EducationStateID"] != DBNull.Value) ? Convert.ToInt32(row["EducationStateID"]) : 0 ;
				heir.MarriageID = (row["MarriageID"] != DBNull.Value) ? Convert.ToInt32(row["MarriageID"]) : 0 ;
				heir.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
				heir.AgreementTypeID = (row["AgreementTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AgreementTypeID"]) : 0 ;
				heir.DeclerativeShare = (row["DeclerativeShare"] != DBNull.Value) ? Convert.ToSingle(row["DeclerativeShare"]) : 0 ;
				heir.DiagnosisShare = (row["DiagnosisShare"] != DBNull.Value) ? Convert.ToSingle(row["DiagnosisShare"]) : 0 ;
				heir.HandShare = (row["HandShare"] != DBNull.Value) ? Convert.ToSingle(row["HandShare"]) : 0 ;
				heir.AdjustmentTaxValue = (row["AdjustmentTaxValue"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentTaxValue"]) : 0 ;
				heir.AdjustmentIncomeValue = (row["AdjustmentIncomeValue"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentIncomeValue"]) : 0 ;
				heir.CommissionAdjustmentShareValue1 = (row["CommissionAdjustmentShareValue1"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue1"]) : 0 ;
				heir.CommissionAdjustmentIncomeValue4 = (row["CommissionAdjustmentIncomeValue4"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue4"]) : 0 ;
				heir.CommissionAdjustmentShareValue5 = (row["CommissionAdjustmentShareValue5"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue5"]) : 0 ;
				heir.CommissionAdjustmentIncomeValue5 = (row["CommissionAdjustmentIncomeValue5"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue5"]) : 0 ;
				heir.CommissionAdjustmentShareValue6 = (row["CommissionAdjustmentShareValue6"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue6"]) : 0 ;
				heir.CommissionAdjustmentIncomeValue6 = (row["CommissionAdjustmentIncomeValue6"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue6"]) : 0 ;
				heir.CommissionAdjustmentIncomeValue1 = (row["CommissionAdjustmentIncomeValue1"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue1"]) : 0 ;
				heir.CommissionAdjustmentShareValue2 = (row["CommissionAdjustmentShareValue2"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue2"]) : 0 ;
				heir.CommissionAdjustmentIncomeValue2 = (row["CommissionAdjustmentIncomeValue2"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue2"]) : 0 ;
				heir.CommissionAdjustmentShareValue3 = (row["CommissionAdjustmentShareValue3"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue3"]) : 0 ;
				heir.CommissionAdjustmentIncomeValue3 = (row["CommissionAdjustmentIncomeValue3"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue3"]) : 0 ;
				heir.CommissionAdjustmentShareValue4 = (row["CommissionAdjustmentShareValue4"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue4"]) : 0 ;
				heir.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
				heir.ParentHeirID = (row["ParentHeirID"] != DBNull.Value) ? Convert.ToInt64(row["ParentHeirID"]) : 0 ;
				heir.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				heir.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
				heir.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
				heir.AdjustmentTaxRegisterInformationID = (row["AdjustmentTaxRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentTaxRegisterInformationID"]) : 0 ;
				heir.CommissionAdjustmentIncomeRegisterInformationID5 = (row["CommissionAdjustmentIncomeRegisterInformationID5"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID5"]) : 0 ;
				heir.CommissionAdjustmentShareRegisterInformationID6 = (row["CommissionAdjustmentShareRegisterInformationID6"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID6"]) : 0 ;
				heir.CommissionAdjustmentIncomeRegisterInformationID6 = (row["CommissionAdjustmentIncomeRegisterInformationID6"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID6"]) : 0 ;
				heir.CommissionAdjustmentIncomeRegisterInformationID2 = (row["CommissionAdjustmentIncomeRegisterInformationID2"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID2"]) : 0 ;
				heir.CommissionAdjustmentShareRegisterInformationID3 = (row["CommissionAdjustmentShareRegisterInformationID3"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID3"]) : 0 ;
				heir.CommissionAdjustmentIncomeRegisterInformationID3 = (row["CommissionAdjustmentIncomeRegisterInformationID3"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID3"]) : 0 ;
				heir.CommissionAdjustmentShareRegisterInformationID4 = (row["CommissionAdjustmentShareRegisterInformationID4"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID4"]) : 0 ;
				heir.CommissionAdjustmentIncomeRegisterInformationID4 = (row["CommissionAdjustmentIncomeRegisterInformationID4"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID4"]) : 0 ;
				heir.CommissionAdjustmentShareRegisterInformationID5 = (row["CommissionAdjustmentShareRegisterInformationID5"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID5"]) : 0 ;
				heir.AdjustmentIncomeRegisterInformationID = (row["AdjustmentIncomeRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentIncomeRegisterInformationID"]) : 0 ;
				heir.CommissionAdjustmentShareRegisterInformationID1 = (row["CommissionAdjustmentShareRegisterInformationID1"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID1"]) : 0 ;
				heir.CommissionAdjustmentIncomeRegisterInformationID1 = (row["CommissionAdjustmentIncomeRegisterInformationID1"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID1"]) : 0 ;
				heir.AdjustmentHeritageRegisterInformationID = (row["AdjustmentHeritageRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentHeritageRegisterInformationID"]) : 0 ;
				heir.CommissionAdjustmentHeritageRegisterInformationID = (row["CommissionAdjustmentHeritageRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentHeritageRegisterInformationID"]) : 0 ;
				heir.CommissionAdjustmentShareRegisterInformationID2 = (row["CommissionAdjustmentShareRegisterInformationID2"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID2"]) : 0 ;
				heir.AdjustmentTaxDate = row["AdjustmentTaxDate"].ToString();
				heir.AdjustmentIncomeDate = row["AdjustmentIncomeDate"].ToString();
				heir.CommissionAdjustmentShareDate1 = row["CommissionAdjustmentShareDate1"].ToString();
				heir.CommissionAdjustmentIncomeDate1 = row["CommissionAdjustmentIncomeDate1"].ToString();
				heir.AdjustmentHeritageDate = row["AdjustmentHeritageDate"].ToString();
				heir.CommissionAdjustmentHeritageDate = row["CommissionAdjustmentHeritageDate"].ToString();
				heir.CommissionAdjustmentIncomeDate4 = row["CommissionAdjustmentIncomeDate4"].ToString();
				heir.CommissionAdjustmentShareDate5 = row["CommissionAdjustmentShareDate5"].ToString();
				heir.CommissionAdjustmentIncomeDate5 = row["CommissionAdjustmentIncomeDate5"].ToString();
				heir.CommissionAdjustmentShareDate6 = row["CommissionAdjustmentShareDate6"].ToString();
				heir.CommissionAdjustmentIncomeDate6 = row["CommissionAdjustmentIncomeDate6"].ToString();
				heir.AdjustmentFinalizationDate = row["AdjustmentFinalizationDate"].ToString();
				heir.CommissionAdjustmentShareDate2 = row["CommissionAdjustmentShareDate2"].ToString();
				heir.CommissionAdjustmentIncomeDate2 = row["CommissionAdjustmentIncomeDate2"].ToString();
				heir.CommissionAdjustmentShareDate3 = row["CommissionAdjustmentShareDate3"].ToString();
				heir.CommissionAdjustmentIncomeDate3 = row["CommissionAdjustmentIncomeDate3"].ToString();
				heir.CommissionAdjustmentShareDate4 = row["CommissionAdjustmentShareDate4"].ToString();

				Person person = personDBAccess.GetDetails(heir.NationalCode);
				heir.NationalCode = person.NationalCode;
				heir.PrintNationalCode = person.PrintNationalCode;
				heir.FullName = person.FullName;
				heir.GenderIDTitle = person.GenderIDTitle;
				heir.Religion_DinIDTitle = person.Religion_DinIDTitle;
				heir.Religion_MazhabIDTitle = person.Religion_MazhabIDTitle;
				heir.IssuanceProvinceIDTitle = person.IssuanceProvinceIDTitle;
				heir.IssuanceCityIDTitle = person.IssuanceCityIDTitle;
				heir.IssuanceDepartment = person.IssuanceDepartment;
				heir.CertificateNumber = person.CertificateNumber;
				heir.CertificateSerial = person.CertificateSerial;
				heir.ZipCode = person.ZipCode;
				heir.HomeAddress = person.HomeAddress;
				heir.PhoneNumber = person.PhoneNumber;
				heir.Job = person.Job;
				heir.JobAddress = person.JobAddress;
				heir.JobPhoneNumber = person.JobPhoneNumber;
				heir.Comment = person.Comment;
				heir.BirthCity = person.BirthCity;
				heir.JobZipCode = person.JobZipCode;
				heir.CertificateSerialLetter = person.CertificateSerialLetter;
				heir.CertificateSerialNumber = person.CertificateSerialNumber;
				heir.FatherName = person.FatherName;
				heir.Name = person.Name;
				heir.Family = person.Family;
				heir.BirthDate = person.BirthDate;
				heir.IssuanceDate = person.IssuanceDate;
				heir.GenderID = person.GenderID;
				heir.IssuanceProvinceID = person.IssuanceProvinceID;
				heir.IssuanceCityID = person.IssuanceCityID;
				heir.Religion_DinID = person.Religion_DinID;
				heir.Religion_MazhabID = person.Religion_MazhabID;
			}
		}

		return heir;
	}

	public List<Heir> GetListAll()
	{
		List<Heir> listHeir = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Heir_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listHeir = new List<Heir>();

				foreach (DataRow row in table.Rows)
				{
					Heir heir = new Heir();
					heir.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
					heir.RelationIDTitle = row["RelationIDTitle"].ToString();
					heir.EducationStateIDTitle = row["EducationStateIDTitle"].ToString();
					heir.MarriageIDTitle = row["MarriageIDTitle"].ToString();
					heir.NationalityIDTitle = row["NationalityIDTitle"].ToString();
					heir.PhysicalStateIDTitle = row["PhysicalStateIDTitle"].ToString();
					heir.ResidenceIDTitle = row["ResidenceIDTitle"].ToString();
					heir.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					heir.OldRegisterDate = row["OldRegisterDate"].ToString();
					heir.RelationID = (row["RelationID"] != DBNull.Value) ? Convert.ToInt32(row["RelationID"]) : 0 ;
					heir.NationalityID = (row["NationalityID"] != DBNull.Value) ? Convert.ToInt32(row["NationalityID"]) : 0 ;
					heir.ResidenceID = (row["ResidenceID"] != DBNull.Value) ? Convert.ToInt32(row["ResidenceID"]) : 0 ;
					heir.PhysicalStateID = (row["PhysicalStateID"] != DBNull.Value) ? Convert.ToInt32(row["PhysicalStateID"]) : 0 ;
					heir.EducationStateID = (row["EducationStateID"] != DBNull.Value) ? Convert.ToInt32(row["EducationStateID"]) : 0 ;
					heir.MarriageID = (row["MarriageID"] != DBNull.Value) ? Convert.ToInt32(row["MarriageID"]) : 0 ;
					heir.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
					heir.AgreementTypeID = (row["AgreementTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AgreementTypeID"]) : 0 ;
					heir.DeclerativeShare = (row["DeclerativeShare"] != DBNull.Value) ? Convert.ToSingle(row["DeclerativeShare"]) : 0 ;
					heir.DiagnosisShare = (row["DiagnosisShare"] != DBNull.Value) ? Convert.ToSingle(row["DiagnosisShare"]) : 0 ;
					heir.HandShare = (row["HandShare"] != DBNull.Value) ? Convert.ToSingle(row["HandShare"]) : 0 ;
					heir.AdjustmentTaxValue = (row["AdjustmentTaxValue"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentTaxValue"]) : 0 ;
					heir.AdjustmentIncomeValue = (row["AdjustmentIncomeValue"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentIncomeValue"]) : 0 ;
					heir.CommissionAdjustmentShareValue1 = (row["CommissionAdjustmentShareValue1"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue1"]) : 0 ;
					heir.CommissionAdjustmentIncomeValue4 = (row["CommissionAdjustmentIncomeValue4"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue4"]) : 0 ;
					heir.CommissionAdjustmentShareValue5 = (row["CommissionAdjustmentShareValue5"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue5"]) : 0 ;
					heir.CommissionAdjustmentIncomeValue5 = (row["CommissionAdjustmentIncomeValue5"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue5"]) : 0 ;
					heir.CommissionAdjustmentShareValue6 = (row["CommissionAdjustmentShareValue6"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue6"]) : 0 ;
					heir.CommissionAdjustmentIncomeValue6 = (row["CommissionAdjustmentIncomeValue6"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue6"]) : 0 ;
					heir.CommissionAdjustmentIncomeValue1 = (row["CommissionAdjustmentIncomeValue1"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue1"]) : 0 ;
					heir.CommissionAdjustmentShareValue2 = (row["CommissionAdjustmentShareValue2"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue2"]) : 0 ;
					heir.CommissionAdjustmentIncomeValue2 = (row["CommissionAdjustmentIncomeValue2"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue2"]) : 0 ;
					heir.CommissionAdjustmentShareValue3 = (row["CommissionAdjustmentShareValue3"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue3"]) : 0 ;
					heir.CommissionAdjustmentIncomeValue3 = (row["CommissionAdjustmentIncomeValue3"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue3"]) : 0 ;
					heir.CommissionAdjustmentShareValue4 = (row["CommissionAdjustmentShareValue4"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue4"]) : 0 ;
				heir.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
					heir.ParentHeirID = (row["ParentHeirID"] != DBNull.Value) ? Convert.ToInt64(row["ParentHeirID"]) : 0 ;
					heir.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					heir.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					heir.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					heir.AdjustmentTaxRegisterInformationID = (row["AdjustmentTaxRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentTaxRegisterInformationID"]) : 0 ;
					heir.CommissionAdjustmentIncomeRegisterInformationID5 = (row["CommissionAdjustmentIncomeRegisterInformationID5"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID5"]) : 0 ;
					heir.CommissionAdjustmentShareRegisterInformationID6 = (row["CommissionAdjustmentShareRegisterInformationID6"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID6"]) : 0 ;
					heir.CommissionAdjustmentIncomeRegisterInformationID6 = (row["CommissionAdjustmentIncomeRegisterInformationID6"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID6"]) : 0 ;
					heir.CommissionAdjustmentIncomeRegisterInformationID2 = (row["CommissionAdjustmentIncomeRegisterInformationID2"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID2"]) : 0 ;
					heir.CommissionAdjustmentShareRegisterInformationID3 = (row["CommissionAdjustmentShareRegisterInformationID3"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID3"]) : 0 ;
					heir.CommissionAdjustmentIncomeRegisterInformationID3 = (row["CommissionAdjustmentIncomeRegisterInformationID3"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID3"]) : 0 ;
					heir.CommissionAdjustmentShareRegisterInformationID4 = (row["CommissionAdjustmentShareRegisterInformationID4"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID4"]) : 0 ;
					heir.CommissionAdjustmentIncomeRegisterInformationID4 = (row["CommissionAdjustmentIncomeRegisterInformationID4"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID4"]) : 0 ;
					heir.CommissionAdjustmentShareRegisterInformationID5 = (row["CommissionAdjustmentShareRegisterInformationID5"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID5"]) : 0 ;
					heir.AdjustmentIncomeRegisterInformationID = (row["AdjustmentIncomeRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentIncomeRegisterInformationID"]) : 0 ;
					heir.CommissionAdjustmentShareRegisterInformationID1 = (row["CommissionAdjustmentShareRegisterInformationID1"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID1"]) : 0 ;
					heir.CommissionAdjustmentIncomeRegisterInformationID1 = (row["CommissionAdjustmentIncomeRegisterInformationID1"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID1"]) : 0 ;
					heir.AdjustmentHeritageRegisterInformationID = (row["AdjustmentHeritageRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentHeritageRegisterInformationID"]) : 0 ;
					heir.CommissionAdjustmentHeritageRegisterInformationID = (row["CommissionAdjustmentHeritageRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentHeritageRegisterInformationID"]) : 0 ;
					heir.CommissionAdjustmentShareRegisterInformationID2 = (row["CommissionAdjustmentShareRegisterInformationID2"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID2"]) : 0 ;
					heir.AdjustmentTaxDate = row["AdjustmentTaxDate"].ToString();
					heir.AdjustmentIncomeDate = row["AdjustmentIncomeDate"].ToString();
					heir.CommissionAdjustmentShareDate1 = row["CommissionAdjustmentShareDate1"].ToString();
					heir.CommissionAdjustmentIncomeDate1 = row["CommissionAdjustmentIncomeDate1"].ToString();
					heir.AdjustmentHeritageDate = row["AdjustmentHeritageDate"].ToString();
					heir.CommissionAdjustmentHeritageDate = row["CommissionAdjustmentHeritageDate"].ToString();
					heir.CommissionAdjustmentIncomeDate4 = row["CommissionAdjustmentIncomeDate4"].ToString();
					heir.CommissionAdjustmentShareDate5 = row["CommissionAdjustmentShareDate5"].ToString();
					heir.CommissionAdjustmentIncomeDate5 = row["CommissionAdjustmentIncomeDate5"].ToString();
					heir.CommissionAdjustmentShareDate6 = row["CommissionAdjustmentShareDate6"].ToString();
					heir.CommissionAdjustmentIncomeDate6 = row["CommissionAdjustmentIncomeDate6"].ToString();
					heir.AdjustmentFinalizationDate = row["AdjustmentFinalizationDate"].ToString();
					heir.CommissionAdjustmentShareDate2 = row["CommissionAdjustmentShareDate2"].ToString();
					heir.CommissionAdjustmentIncomeDate2 = row["CommissionAdjustmentIncomeDate2"].ToString();
					heir.CommissionAdjustmentShareDate3 = row["CommissionAdjustmentShareDate3"].ToString();
					heir.CommissionAdjustmentIncomeDate3 = row["CommissionAdjustmentIncomeDate3"].ToString();
					heir.CommissionAdjustmentShareDate4 = row["CommissionAdjustmentShareDate4"].ToString();

					Person person = personDBAccess.GetDetails(heir.NationalCode);
					heir.PrintNationalCode = person.PrintNationalCode;
					heir.FullName = person.FullName;
					heir.GenderIDTitle = person.GenderIDTitle;
					heir.Religion_DinIDTitle = person.Religion_DinIDTitle;
					heir.Religion_MazhabIDTitle = person.Religion_MazhabIDTitle;
					heir.IssuanceProvinceIDTitle = person.IssuanceProvinceIDTitle;
					heir.IssuanceCityIDTitle = person.IssuanceCityIDTitle;
					heir.IssuanceDepartment = person.IssuanceDepartment;
					heir.CertificateNumber = person.CertificateNumber;
					heir.CertificateSerial = person.CertificateSerial;
					heir.ZipCode = person.ZipCode;
					heir.HomeAddress = person.HomeAddress;
					heir.PhoneNumber = person.PhoneNumber;
					heir.Job = person.Job;
					heir.JobAddress = person.JobAddress;
					heir.JobPhoneNumber = person.JobPhoneNumber;
					heir.Comment = person.Comment;
					heir.BirthCity = person.BirthCity;
					heir.JobZipCode = person.JobZipCode;
					heir.CertificateSerialLetter = person.CertificateSerialLetter;
					heir.CertificateSerialNumber = person.CertificateSerialNumber;
					heir.FatherName = person.FatherName;
					heir.Name = person.Name;
					heir.Family = person.Family;
					heir.BirthDate = person.BirthDate;
					heir.IssuanceDate = person.IssuanceDate;
					heir.GenderID = person.GenderID;
					heir.IssuanceProvinceID = person.IssuanceProvinceID;
					heir.IssuanceCityID = person.IssuanceCityID;
					heir.Religion_DinID = person.Religion_DinID;
					heir.Religion_MazhabID = person.Religion_MazhabID;
					listHeir.Add(heir);
				}
			}
		}

		return listHeir;
	}

	public bool Exists(Int64 heirID)
	{
		SqlParameter[] parametersHeir = new SqlParameter[]
		{
			new SqlParameter("@HeirID", heirID)
		};
		return (SqlDBHelper.ExecuteScalar("Heir_Exists", CommandType.StoredProcedure, parametersHeir)>0);
	}

	public bool Exists(Heir heir)
	{
		SqlParameter[] parametersHeir = new SqlParameter[]
		{
			new SqlParameter("@HeirID", heir.HeirID)
		};
		return (SqlDBHelper.ExecuteScalar("Heir_Exists", CommandType.StoredProcedure, parametersHeir)>0);
	}

	public List<Heir> SearchLike(Heir heir)
	{
		List<Heir> listHeir = new List<Heir>();


		SqlParameter[] parametersHeir = new SqlParameter[]
		{
			new SqlParameter("@HeirID", heir.HeirID),
			new SqlParameter("@RelationIDTitle", heir.RelationIDTitle),
			new SqlParameter("@EducationStateIDTitle", heir.EducationStateIDTitle),
			new SqlParameter("@MarriageIDTitle", heir.MarriageIDTitle),
			new SqlParameter("@NationalityIDTitle", heir.NationalityIDTitle),
			new SqlParameter("@PhysicalStateIDTitle", heir.PhysicalStateIDTitle),
			new SqlParameter("@ResidenceIDTitle", heir.ResidenceIDTitle),
			new SqlParameter("@OldRegisterInformationID", heir.OldRegisterInformationID),
			new SqlParameter("@OldRegisterDate", heir.OldRegisterDate),
			new SqlParameter("@RelationID", heir.RelationID),
			new SqlParameter("@NationalityID", heir.NationalityID),
			new SqlParameter("@ResidenceID", heir.ResidenceID),
			new SqlParameter("@PhysicalStateID", heir.PhysicalStateID),
			new SqlParameter("@EducationStateID", heir.EducationStateID),
			new SqlParameter("@MarriageID", heir.MarriageID),
			new SqlParameter("@Stage", heir.Stage),
			new SqlParameter("@AgreementTypeID", heir.AgreementTypeID),
			new SqlParameter("@DeclerativeShare", heir.DeclerativeShare),
			new SqlParameter("@DiagnosisShare", heir.DiagnosisShare),
			new SqlParameter("@HandShare", heir.HandShare),
			new SqlParameter("@AdjustmentTaxValue", heir.AdjustmentTaxValue),
			new SqlParameter("@AdjustmentIncomeValue", heir.AdjustmentIncomeValue),
			new SqlParameter("@CommissionAdjustmentShareValue1", heir.CommissionAdjustmentShareValue1),
			new SqlParameter("@CommissionAdjustmentIncomeValue4", heir.CommissionAdjustmentIncomeValue4),
			new SqlParameter("@CommissionAdjustmentShareValue5", heir.CommissionAdjustmentShareValue5),
			new SqlParameter("@CommissionAdjustmentIncomeValue5", heir.CommissionAdjustmentIncomeValue5),
			new SqlParameter("@CommissionAdjustmentShareValue6", heir.CommissionAdjustmentShareValue6),
			new SqlParameter("@CommissionAdjustmentIncomeValue6", heir.CommissionAdjustmentIncomeValue6),
			new SqlParameter("@CommissionAdjustmentIncomeValue1", heir.CommissionAdjustmentIncomeValue1),
			new SqlParameter("@CommissionAdjustmentShareValue2", heir.CommissionAdjustmentShareValue2),
			new SqlParameter("@CommissionAdjustmentIncomeValue2", heir.CommissionAdjustmentIncomeValue2),
			new SqlParameter("@CommissionAdjustmentShareValue3", heir.CommissionAdjustmentShareValue3),
			new SqlParameter("@CommissionAdjustmentIncomeValue3", heir.CommissionAdjustmentIncomeValue3),
			new SqlParameter("@CommissionAdjustmentShareValue4", heir.CommissionAdjustmentShareValue4),
			new SqlParameter("@IsDiagonesed", heir.IsDiagonesed),
			new SqlParameter("@ParentHeirID", heir.ParentHeirID),
			new SqlParameter("@DeclarationID", heir.DeclarationID),
			new SqlParameter("@NationalCode", heir.NationalCode),
			new SqlParameter("@RegisterInformationID", heir.RegisterInformationID),
			new SqlParameter("@AdjustmentTaxRegisterInformationID", heir.AdjustmentTaxRegisterInformationID),
			new SqlParameter("@CommissionAdjustmentIncomeRegisterInformationID5", heir.CommissionAdjustmentIncomeRegisterInformationID5),
			new SqlParameter("@CommissionAdjustmentShareRegisterInformationID6", heir.CommissionAdjustmentShareRegisterInformationID6),
			new SqlParameter("@CommissionAdjustmentIncomeRegisterInformationID6", heir.CommissionAdjustmentIncomeRegisterInformationID6),
			new SqlParameter("@CommissionAdjustmentIncomeRegisterInformationID2", heir.CommissionAdjustmentIncomeRegisterInformationID2),
			new SqlParameter("@CommissionAdjustmentShareRegisterInformationID3", heir.CommissionAdjustmentShareRegisterInformationID3),
			new SqlParameter("@CommissionAdjustmentIncomeRegisterInformationID3", heir.CommissionAdjustmentIncomeRegisterInformationID3),
			new SqlParameter("@CommissionAdjustmentShareRegisterInformationID4", heir.CommissionAdjustmentShareRegisterInformationID4),
			new SqlParameter("@CommissionAdjustmentIncomeRegisterInformationID4", heir.CommissionAdjustmentIncomeRegisterInformationID4),
			new SqlParameter("@CommissionAdjustmentShareRegisterInformationID5", heir.CommissionAdjustmentShareRegisterInformationID5),
			new SqlParameter("@AdjustmentIncomeRegisterInformationID", heir.AdjustmentIncomeRegisterInformationID),
			new SqlParameter("@CommissionAdjustmentShareRegisterInformationID1", heir.CommissionAdjustmentShareRegisterInformationID1),
			new SqlParameter("@CommissionAdjustmentIncomeRegisterInformationID1", heir.CommissionAdjustmentIncomeRegisterInformationID1),
			new SqlParameter("@AdjustmentHeritageRegisterInformationID", heir.AdjustmentHeritageRegisterInformationID),
			new SqlParameter("@CommissionAdjustmentHeritageRegisterInformationID", heir.CommissionAdjustmentHeritageRegisterInformationID),
			new SqlParameter("@CommissionAdjustmentShareRegisterInformationID2", heir.CommissionAdjustmentShareRegisterInformationID2),
			new SqlParameter("@AdjustmentTaxDate", heir.AdjustmentTaxDate),
			new SqlParameter("@AdjustmentIncomeDate", heir.AdjustmentIncomeDate),
			new SqlParameter("@CommissionAdjustmentShareDate1", heir.CommissionAdjustmentShareDate1),
			new SqlParameter("@CommissionAdjustmentIncomeDate1", heir.CommissionAdjustmentIncomeDate1),
			new SqlParameter("@AdjustmentHeritageDate", heir.AdjustmentHeritageDate),
			new SqlParameter("@CommissionAdjustmentHeritageDate", heir.CommissionAdjustmentHeritageDate),
			new SqlParameter("@CommissionAdjustmentIncomeDate4", heir.CommissionAdjustmentIncomeDate4),
			new SqlParameter("@CommissionAdjustmentShareDate5", heir.CommissionAdjustmentShareDate5),
			new SqlParameter("@CommissionAdjustmentIncomeDate5", heir.CommissionAdjustmentIncomeDate5),
			new SqlParameter("@CommissionAdjustmentShareDate6", heir.CommissionAdjustmentShareDate6),
			new SqlParameter("@CommissionAdjustmentIncomeDate6", heir.CommissionAdjustmentIncomeDate6),
			new SqlParameter("@AdjustmentFinalizationDate", heir.AdjustmentFinalizationDate),
			new SqlParameter("@CommissionAdjustmentShareDate2", heir.CommissionAdjustmentShareDate2),
			new SqlParameter("@CommissionAdjustmentIncomeDate2", heir.CommissionAdjustmentIncomeDate2),
			new SqlParameter("@CommissionAdjustmentShareDate3", heir.CommissionAdjustmentShareDate3),
			new SqlParameter("@CommissionAdjustmentIncomeDate3", heir.CommissionAdjustmentIncomeDate3),
			new SqlParameter("@CommissionAdjustmentShareDate4", heir.CommissionAdjustmentShareDate4),

			new SqlParameter("@PrintNationalCode", heir.PrintNationalCode),
			new SqlParameter("@FullName", heir.FullName),
			new SqlParameter("@GenderIDTitle", heir.GenderIDTitle),
			new SqlParameter("@Religion_DinIDTitle", heir.Religion_DinIDTitle),
			new SqlParameter("@Religion_MazhabIDTitle", heir.Religion_MazhabIDTitle),
			new SqlParameter("@IssuanceProvinceIDTitle", heir.IssuanceProvinceIDTitle),
			new SqlParameter("@IssuanceCityIDTitle", heir.IssuanceCityIDTitle),
			new SqlParameter("@IssuanceDepartment", heir.IssuanceDepartment),
			new SqlParameter("@CertificateNumber", heir.CertificateNumber),
			new SqlParameter("@CertificateSerial", heir.CertificateSerial),
			new SqlParameter("@ZipCode", heir.ZipCode),
			new SqlParameter("@HomeAddress", heir.HomeAddress),
			new SqlParameter("@PhoneNumber", heir.PhoneNumber),
			new SqlParameter("@Job", heir.Job),
			new SqlParameter("@JobAddress", heir.JobAddress),
			new SqlParameter("@JobPhoneNumber", heir.JobPhoneNumber),
			new SqlParameter("@Comment", heir.Comment),
			new SqlParameter("@BirthCity", heir.BirthCity),
			new SqlParameter("@JobZipCode", heir.JobZipCode),
			new SqlParameter("@CertificateSerialLetter", heir.CertificateSerialLetter),
			new SqlParameter("@CertificateSerialNumber", heir.CertificateSerialNumber),
			new SqlParameter("@FatherName", heir.FatherName),
			new SqlParameter("@Name", heir.Name),
			new SqlParameter("@Family", heir.Family),
			new SqlParameter("@BirthDate", heir.BirthDate),
			new SqlParameter("@IssuanceDate", heir.IssuanceDate),
			new SqlParameter("@GenderID", heir.GenderID),
			new SqlParameter("@IssuanceProvinceID", heir.IssuanceProvinceID),
			new SqlParameter("@IssuanceCityID", heir.IssuanceCityID),
			new SqlParameter("@Religion_DinID", heir.Religion_DinID),
			new SqlParameter("@Religion_MazhabID", heir.Religion_MazhabID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Heir_SearchLike", CommandType.StoredProcedure, parametersHeir))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Heir tmpHeir = new Heir();
					tmpHeir.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
					tmpHeir.RelationIDTitle = row["RelationIDTitle"].ToString();
					tmpHeir.EducationStateIDTitle = row["EducationStateIDTitle"].ToString();
					tmpHeir.MarriageIDTitle = row["MarriageIDTitle"].ToString();
					tmpHeir.NationalityIDTitle = row["NationalityIDTitle"].ToString();
					tmpHeir.PhysicalStateIDTitle = row["PhysicalStateIDTitle"].ToString();
					tmpHeir.ResidenceIDTitle = row["ResidenceIDTitle"].ToString();
					tmpHeir.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
					tmpHeir.OldRegisterDate = row["OldRegisterDate"].ToString();
					tmpHeir.RelationID = (row["RelationID"] != DBNull.Value) ? Convert.ToInt32(row["RelationID"]) : 0 ;
					tmpHeir.NationalityID = (row["NationalityID"] != DBNull.Value) ? Convert.ToInt32(row["NationalityID"]) : 0 ;
					tmpHeir.ResidenceID = (row["ResidenceID"] != DBNull.Value) ? Convert.ToInt32(row["ResidenceID"]) : 0 ;
					tmpHeir.PhysicalStateID = (row["PhysicalStateID"] != DBNull.Value) ? Convert.ToInt32(row["PhysicalStateID"]) : 0 ;
					tmpHeir.EducationStateID = (row["EducationStateID"] != DBNull.Value) ? Convert.ToInt32(row["EducationStateID"]) : 0 ;
					tmpHeir.MarriageID = (row["MarriageID"] != DBNull.Value) ? Convert.ToInt32(row["MarriageID"]) : 0 ;
					tmpHeir.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
					tmpHeir.AgreementTypeID = (row["AgreementTypeID"] != DBNull.Value) ? Convert.ToInt32(row["AgreementTypeID"]) : 0 ;
					tmpHeir.DeclerativeShare = (row["DeclerativeShare"] != DBNull.Value) ? Convert.ToSingle(row["DeclerativeShare"]) : 0 ;
					tmpHeir.DiagnosisShare = (row["DiagnosisShare"] != DBNull.Value) ? Convert.ToSingle(row["DiagnosisShare"]) : 0 ;
					tmpHeir.HandShare = (row["HandShare"] != DBNull.Value) ? Convert.ToSingle(row["HandShare"]) : 0 ;
					tmpHeir.AdjustmentTaxValue = (row["AdjustmentTaxValue"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentTaxValue"]) : 0 ;
					tmpHeir.AdjustmentIncomeValue = (row["AdjustmentIncomeValue"] != DBNull.Value) ? Convert.ToSingle(row["AdjustmentIncomeValue"]) : 0 ;
					tmpHeir.CommissionAdjustmentShareValue1 = (row["CommissionAdjustmentShareValue1"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue1"]) : 0 ;
					tmpHeir.CommissionAdjustmentIncomeValue4 = (row["CommissionAdjustmentIncomeValue4"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue4"]) : 0 ;
					tmpHeir.CommissionAdjustmentShareValue5 = (row["CommissionAdjustmentShareValue5"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue5"]) : 0 ;
					tmpHeir.CommissionAdjustmentIncomeValue5 = (row["CommissionAdjustmentIncomeValue5"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue5"]) : 0 ;
					tmpHeir.CommissionAdjustmentShareValue6 = (row["CommissionAdjustmentShareValue6"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue6"]) : 0 ;
					tmpHeir.CommissionAdjustmentIncomeValue6 = (row["CommissionAdjustmentIncomeValue6"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue6"]) : 0 ;
					tmpHeir.CommissionAdjustmentIncomeValue1 = (row["CommissionAdjustmentIncomeValue1"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue1"]) : 0 ;
					tmpHeir.CommissionAdjustmentShareValue2 = (row["CommissionAdjustmentShareValue2"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue2"]) : 0 ;
					tmpHeir.CommissionAdjustmentIncomeValue2 = (row["CommissionAdjustmentIncomeValue2"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue2"]) : 0 ;
					tmpHeir.CommissionAdjustmentShareValue3 = (row["CommissionAdjustmentShareValue3"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue3"]) : 0 ;
					tmpHeir.CommissionAdjustmentIncomeValue3 = (row["CommissionAdjustmentIncomeValue3"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentIncomeValue3"]) : 0 ;
					tmpHeir.CommissionAdjustmentShareValue4 = (row["CommissionAdjustmentShareValue4"] != DBNull.Value) ? Convert.ToSingle(row["CommissionAdjustmentShareValue4"]) : 0 ;
					tmpHeir.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
					tmpHeir.ParentHeirID = (row["ParentHeirID"] != DBNull.Value) ? Convert.ToInt64(row["ParentHeirID"]) : 0 ;
					tmpHeir.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpHeir.NationalCode = (row["NationalCode"] != DBNull.Value) ? Convert.ToInt64(row["NationalCode"]) : 0 ;
					tmpHeir.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
					tmpHeir.AdjustmentTaxRegisterInformationID = (row["AdjustmentTaxRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentTaxRegisterInformationID"]) : 0 ;
					tmpHeir.CommissionAdjustmentIncomeRegisterInformationID5 = (row["CommissionAdjustmentIncomeRegisterInformationID5"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID5"]) : 0 ;
					tmpHeir.CommissionAdjustmentShareRegisterInformationID6 = (row["CommissionAdjustmentShareRegisterInformationID6"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID6"]) : 0 ;
					tmpHeir.CommissionAdjustmentIncomeRegisterInformationID6 = (row["CommissionAdjustmentIncomeRegisterInformationID6"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID6"]) : 0 ;
					tmpHeir.CommissionAdjustmentIncomeRegisterInformationID2 = (row["CommissionAdjustmentIncomeRegisterInformationID2"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID2"]) : 0 ;
					tmpHeir.CommissionAdjustmentShareRegisterInformationID3 = (row["CommissionAdjustmentShareRegisterInformationID3"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID3"]) : 0 ;
					tmpHeir.CommissionAdjustmentIncomeRegisterInformationID3 = (row["CommissionAdjustmentIncomeRegisterInformationID3"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID3"]) : 0 ;
					tmpHeir.CommissionAdjustmentShareRegisterInformationID4 = (row["CommissionAdjustmentShareRegisterInformationID4"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID4"]) : 0 ;
					tmpHeir.CommissionAdjustmentIncomeRegisterInformationID4 = (row["CommissionAdjustmentIncomeRegisterInformationID4"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID4"]) : 0 ;
					tmpHeir.CommissionAdjustmentShareRegisterInformationID5 = (row["CommissionAdjustmentShareRegisterInformationID5"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID5"]) : 0 ;
					tmpHeir.AdjustmentIncomeRegisterInformationID = (row["AdjustmentIncomeRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentIncomeRegisterInformationID"]) : 0 ;
					tmpHeir.CommissionAdjustmentShareRegisterInformationID1 = (row["CommissionAdjustmentShareRegisterInformationID1"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID1"]) : 0 ;
					tmpHeir.CommissionAdjustmentIncomeRegisterInformationID1 = (row["CommissionAdjustmentIncomeRegisterInformationID1"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentIncomeRegisterInformationID1"]) : 0 ;
					tmpHeir.AdjustmentHeritageRegisterInformationID = (row["AdjustmentHeritageRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentHeritageRegisterInformationID"]) : 0 ;
					tmpHeir.CommissionAdjustmentHeritageRegisterInformationID = (row["CommissionAdjustmentHeritageRegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentHeritageRegisterInformationID"]) : 0 ;
					tmpHeir.CommissionAdjustmentShareRegisterInformationID2 = (row["CommissionAdjustmentShareRegisterInformationID2"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentShareRegisterInformationID2"]) : 0 ;
					tmpHeir.AdjustmentTaxDate = row["AdjustmentTaxDate"].ToString();
					tmpHeir.AdjustmentIncomeDate = row["AdjustmentIncomeDate"].ToString();
					tmpHeir.CommissionAdjustmentShareDate1 = row["CommissionAdjustmentShareDate1"].ToString();
					tmpHeir.CommissionAdjustmentIncomeDate1 = row["CommissionAdjustmentIncomeDate1"].ToString();
					tmpHeir.AdjustmentHeritageDate = row["AdjustmentHeritageDate"].ToString();
					tmpHeir.CommissionAdjustmentHeritageDate = row["CommissionAdjustmentHeritageDate"].ToString();
					tmpHeir.CommissionAdjustmentIncomeDate4 = row["CommissionAdjustmentIncomeDate4"].ToString();
					tmpHeir.CommissionAdjustmentShareDate5 = row["CommissionAdjustmentShareDate5"].ToString();
					tmpHeir.CommissionAdjustmentIncomeDate5 = row["CommissionAdjustmentIncomeDate5"].ToString();
					tmpHeir.CommissionAdjustmentShareDate6 = row["CommissionAdjustmentShareDate6"].ToString();
					tmpHeir.CommissionAdjustmentIncomeDate6 = row["CommissionAdjustmentIncomeDate6"].ToString();
					tmpHeir.AdjustmentFinalizationDate = row["AdjustmentFinalizationDate"].ToString();
					tmpHeir.CommissionAdjustmentShareDate2 = row["CommissionAdjustmentShareDate2"].ToString();
					tmpHeir.CommissionAdjustmentIncomeDate2 = row["CommissionAdjustmentIncomeDate2"].ToString();
					tmpHeir.CommissionAdjustmentShareDate3 = row["CommissionAdjustmentShareDate3"].ToString();
					tmpHeir.CommissionAdjustmentIncomeDate3 = row["CommissionAdjustmentIncomeDate3"].ToString();
					tmpHeir.CommissionAdjustmentShareDate4 = row["CommissionAdjustmentShareDate4"].ToString();

					Person person = personDBAccess.GetDetails(tmpHeir.NationalCode);
					tmpHeir.NationalCode = person.NationalCode;
					tmpHeir.PrintNationalCode = person.PrintNationalCode;
					tmpHeir.FullName = person.FullName;
					tmpHeir.GenderIDTitle = person.GenderIDTitle;
					tmpHeir.Religion_DinIDTitle = person.Religion_DinIDTitle;
					tmpHeir.Religion_MazhabIDTitle = person.Religion_MazhabIDTitle;
					tmpHeir.IssuanceProvinceIDTitle = person.IssuanceProvinceIDTitle;
					tmpHeir.IssuanceCityIDTitle = person.IssuanceCityIDTitle;
					tmpHeir.IssuanceDepartment = person.IssuanceDepartment;
					tmpHeir.CertificateNumber = person.CertificateNumber;
					tmpHeir.CertificateSerial = person.CertificateSerial;
					tmpHeir.ZipCode = person.ZipCode;
					tmpHeir.HomeAddress = person.HomeAddress;
					tmpHeir.PhoneNumber = person.PhoneNumber;
					tmpHeir.Job = person.Job;
					tmpHeir.JobAddress = person.JobAddress;
					tmpHeir.JobPhoneNumber = person.JobPhoneNumber;
					tmpHeir.Comment = person.Comment;
					tmpHeir.BirthCity = person.BirthCity;
					tmpHeir.JobZipCode = person.JobZipCode;
					tmpHeir.CertificateSerialLetter = person.CertificateSerialLetter;
					tmpHeir.CertificateSerialNumber = person.CertificateSerialNumber;
					tmpHeir.FatherName = person.FatherName;
					tmpHeir.Name = person.Name;
					tmpHeir.Family = person.Family;
					tmpHeir.BirthDate = person.BirthDate;
					tmpHeir.IssuanceDate = person.IssuanceDate;
					tmpHeir.GenderID = person.GenderID;
					tmpHeir.IssuanceProvinceID = person.IssuanceProvinceID;
					tmpHeir.IssuanceCityID = person.IssuanceCityID;
					tmpHeir.Religion_DinID = person.Religion_DinID;
					tmpHeir.Religion_MazhabID = person.Religion_MazhabID;

					listHeir.Add(tmpHeir);
				}
			}
		}

		return listHeir;
	}

}
}
