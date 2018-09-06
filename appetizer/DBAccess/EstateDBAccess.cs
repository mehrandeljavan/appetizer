using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class EstateDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(Estate estate)
	{
		if (!heritageDBAccess.Exists(estate))
			estate.HeritageID = heritageDBAccess.Insert(estate);

		SqlParameter[] parametersEstate = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (estate.HeritageID > 0) ? estate.HeritageID : (object)DBNull.Value),
			new SqlParameter("@IndependentOf", (estate.IndependentOf != null) ? estate.IndependentOf : (object)DBNull.Value),
			new SqlParameter("@InquiryTo", (estate.InquiryTo != null) ? estate.InquiryTo : (object)DBNull.Value),
			new SqlParameter("@ProductionUnitID", (estate.ProductionUnitID > 0) ? estate.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@MainPlaqueNumber", estate.MainPlaqueNumber),
			new SqlParameter("@SubPlaqueNumber", (estate.SubPlaqueNumber != null) ? estate.SubPlaqueNumber : (object)DBNull.Value),
			new SqlParameter("@SectionPlaqueNumber", (estate.SectionPlaqueNumber != null) ? estate.SectionPlaqueNumber : (object)DBNull.Value),
			new SqlParameter("@RegisterState", estate.RegisterState),
			new SqlParameter("@EstateTypeID", (estate.EstateTypeID > 0) ? estate.EstateTypeID : (object)DBNull.Value),
			new SqlParameter("@Water", (estate.Water != null) ? estate.Water : (object)DBNull.Value),
			new SqlParameter("@Electric", (estate.Electric != null) ? estate.Electric : (object)DBNull.Value),
			new SqlParameter("@Gass", (estate.Gass != null) ? estate.Gass : (object)DBNull.Value),
			new SqlParameter("@Wastewater", (estate.Wastewater != null) ? estate.Wastewater : (object)DBNull.Value),
			new SqlParameter("@GoodwillValue", estate.GoodwillValue),
			new SqlParameter("@Area1", (estate.Area1 != null) ? estate.Area1 : (object)DBNull.Value),
			new SqlParameter("@Area2", (estate.Area2 != null) ? estate.Area2 : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (estate.DeclarationID > 0) ? estate.DeclarationID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("Estate_Insert", CommandType.StoredProcedure, parametersEstate);
	}

	public bool Update(Estate estate)
	{
		heritageDBAccess.Update(estate);

		SqlParameter[] parametersEstate = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", estate.HeritageID),
			new SqlParameter("@IndependentOf", (estate.IndependentOf != null) ? estate.IndependentOf : (object)DBNull.Value),
			new SqlParameter("@InquiryTo", (estate.InquiryTo != null) ? estate.InquiryTo : (object)DBNull.Value),
			new SqlParameter("@ProductionUnitID", (estate.ProductionUnitID != null && estate.ProductionUnitID >0 ) ? estate.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@MainPlaqueNumber", estate.MainPlaqueNumber),
			new SqlParameter("@SubPlaqueNumber", (estate.SubPlaqueNumber != null) ? estate.SubPlaqueNumber : (object)DBNull.Value),
			new SqlParameter("@SectionPlaqueNumber", (estate.SectionPlaqueNumber != null) ? estate.SectionPlaqueNumber : (object)DBNull.Value),
			new SqlParameter("@RegisterState", estate.RegisterState),
			new SqlParameter("@EstateTypeID", (estate.EstateTypeID != null && estate.EstateTypeID >0 ) ? estate.EstateTypeID : (object)DBNull.Value),
			new SqlParameter("@Water", (estate.Water != null) ? estate.Water : (object)DBNull.Value),
			new SqlParameter("@Electric", (estate.Electric != null) ? estate.Electric : (object)DBNull.Value),
			new SqlParameter("@Gass", (estate.Gass != null) ? estate.Gass : (object)DBNull.Value),
			new SqlParameter("@Wastewater", (estate.Wastewater != null) ? estate.Wastewater : (object)DBNull.Value),
			new SqlParameter("@GoodwillValue", estate.GoodwillValue),
			new SqlParameter("@Area1", (estate.Area1 != null) ? estate.Area1 : (object)DBNull.Value),
			new SqlParameter("@Area2", (estate.Area2 != null) ? estate.Area2 : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", estate.DeclarationID)
		};
		return SqlDBHelper.ExecuteNonQuery("Estate_Update", CommandType.StoredProcedure, parametersEstate);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersEstate = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("Estate_Delete", CommandType.StoredProcedure, parametersEstate);
	}

	public Estate GetDetails(Int64 heritageID)
	{
		Estate estate = new Estate();

		SqlParameter[] parametersEstate = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Estate_GetDetails", CommandType.StoredProcedure, parametersEstate))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				estate.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				estate.EstateTypeIDTitle = row["EstateTypeIDTitle"].ToString();
				estate.IndependentOf = row["IndependentOf"].ToString();
				estate.InquiryTo = row["InquiryTo"].ToString();
				estate.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
				estate.MainPlaqueNumber = row["MainPlaqueNumber"].ToString();
				estate.SubPlaqueNumber = row["SubPlaqueNumber"].ToString();
				estate.SectionPlaqueNumber = row["SectionPlaqueNumber"].ToString();
				estate.RegisterState = row["RegisterState"].ToString();
				estate.EstateTypeID = (row["EstateTypeID"] != DBNull.Value) ? Convert.ToInt32(row["EstateTypeID"]) : 0 ;
				estate.Water = (row["Water"] != DBNull.Value) ? Convert.ToInt32(row["Water"]) : 0 ;
				estate.Electric = (row["Electric"] != DBNull.Value) ? Convert.ToInt32(row["Electric"]) : 0 ;
				estate.Gass = (row["Gass"] != DBNull.Value) ? Convert.ToInt32(row["Gass"]) : 0 ;
				estate.Wastewater = (row["Wastewater"] != DBNull.Value) ? Convert.ToInt32(row["Wastewater"]) : 0 ;
				estate.GoodwillValue = (row["GoodwillValue"] != DBNull.Value) ? Convert.ToSingle(row["GoodwillValue"]) : 0 ;
				estate.Area1 = (row["Area1"] != DBNull.Value) ? Convert.ToSingle(row["Area1"]) : 0 ;
				estate.Area2 = (row["Area2"] != DBNull.Value) ? Convert.ToSingle(row["Area2"]) : 0 ;
				estate.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

				Heritage heritage = heritageDBAccess.GetDetails(estate.HeritageID);
				estate.HeritageID = heritage.HeritageID;
				estate.StageTitle = heritage.StageTitle;
				estate.RegisterDate = heritage.RegisterDate;
				estate.OldRegisterDate = heritage.OldRegisterDate;
				estate.OldRegisterInformationID = heritage.OldRegisterInformationID;
				estate.Sixth = heritage.Sixth;
				estate.PreviousOwner = heritage.PreviousOwner;
				estate.Comment = heritage.Comment;
				estate.RegisterInformationID = heritage.RegisterInformationID;
				estate.AdjustmentID = heritage.AdjustmentID;
				estate.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				estate.Stage = heritage.Stage;
				estate.UserOrder = heritage.UserOrder;
				estate.Value1 = heritage.Value1;
				estate.Value2 = heritage.Value2;
				estate.Value3 = heritage.Value3;
				estate.DeadIsOwner = heritage.DeadIsOwner;
				estate.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return estate;
	}

	public List<Estate> GetListAll()
	{
		List<Estate> listEstate = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Estate_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listEstate = new List<Estate>();

				foreach (DataRow row in table.Rows)
				{
					Estate estate = new Estate();
					estate.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					estate.EstateTypeIDTitle = row["EstateTypeIDTitle"].ToString();
					estate.IndependentOf = row["IndependentOf"].ToString();
					estate.InquiryTo = row["InquiryTo"].ToString();
					estate.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					estate.MainPlaqueNumber = row["MainPlaqueNumber"].ToString();
					estate.SubPlaqueNumber = row["SubPlaqueNumber"].ToString();
					estate.SectionPlaqueNumber = row["SectionPlaqueNumber"].ToString();
					estate.RegisterState = row["RegisterState"].ToString();
					estate.EstateTypeID = (row["EstateTypeID"] != DBNull.Value) ? Convert.ToInt32(row["EstateTypeID"]) : 0 ;
					estate.Water = (row["Water"] != DBNull.Value) ? Convert.ToInt32(row["Water"]) : 0 ;
					estate.Electric = (row["Electric"] != DBNull.Value) ? Convert.ToInt32(row["Electric"]) : 0 ;
					estate.Gass = (row["Gass"] != DBNull.Value) ? Convert.ToInt32(row["Gass"]) : 0 ;
					estate.Wastewater = (row["Wastewater"] != DBNull.Value) ? Convert.ToInt32(row["Wastewater"]) : 0 ;
					estate.GoodwillValue = (row["GoodwillValue"] != DBNull.Value) ? Convert.ToSingle(row["GoodwillValue"]) : 0 ;
					estate.Area1 = (row["Area1"] != DBNull.Value) ? Convert.ToSingle(row["Area1"]) : 0 ;
					estate.Area2 = (row["Area2"] != DBNull.Value) ? Convert.ToSingle(row["Area2"]) : 0 ;
					estate.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(estate.HeritageID);
					estate.StageTitle = heritage.StageTitle;
					estate.RegisterDate = heritage.RegisterDate;
					estate.OldRegisterDate = heritage.OldRegisterDate;
					estate.OldRegisterInformationID = heritage.OldRegisterInformationID;
					estate.Sixth = heritage.Sixth;
					estate.PreviousOwner = heritage.PreviousOwner;
					estate.Comment = heritage.Comment;
					estate.RegisterInformationID = heritage.RegisterInformationID;
					estate.AdjustmentID = heritage.AdjustmentID;
					estate.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					estate.Stage = heritage.Stage;
					estate.UserOrder = heritage.UserOrder;
					estate.Value1 = heritage.Value1;
					estate.Value2 = heritage.Value2;
					estate.Value3 = heritage.Value3;
					estate.DeadIsOwner = heritage.DeadIsOwner;
					estate.IsDiagonesed = heritage.IsDiagonesed;
					listEstate.Add(estate);
				}
			}
		}

		return listEstate;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersEstate = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Estate_Exists", CommandType.StoredProcedure, parametersEstate)>0);
	}

	public bool Exists(Estate estate)
	{
		SqlParameter[] parametersEstate = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", estate.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Estate_Exists", CommandType.StoredProcedure, parametersEstate)>0);
	}

	public List<Estate> SearchLike(Estate estate)
	{
		List<Estate> listEstate = new List<Estate>();


		SqlParameter[] parametersEstate = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", estate.HeritageID),
			new SqlParameter("@EstateTypeIDTitle", estate.EstateTypeIDTitle),
			new SqlParameter("@IndependentOf", estate.IndependentOf),
			new SqlParameter("@InquiryTo", estate.InquiryTo),
			new SqlParameter("@ProductionUnitID", estate.ProductionUnitID),
			new SqlParameter("@MainPlaqueNumber", estate.MainPlaqueNumber),
			new SqlParameter("@SubPlaqueNumber", estate.SubPlaqueNumber),
			new SqlParameter("@SectionPlaqueNumber", estate.SectionPlaqueNumber),
			new SqlParameter("@RegisterState", estate.RegisterState),
			new SqlParameter("@EstateTypeID", estate.EstateTypeID),
			new SqlParameter("@Water", estate.Water),
			new SqlParameter("@Electric", estate.Electric),
			new SqlParameter("@Gass", estate.Gass),
			new SqlParameter("@Wastewater", estate.Wastewater),
			new SqlParameter("@GoodwillValue", estate.GoodwillValue),
			new SqlParameter("@Area1", estate.Area1),
			new SqlParameter("@Area2", estate.Area2),
			new SqlParameter("@DeclarationID", estate.DeclarationID),

			new SqlParameter("@StageTitle", estate.StageTitle),
			new SqlParameter("@RegisterDate", estate.RegisterDate),
			new SqlParameter("@OldRegisterDate", estate.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", estate.OldRegisterInformationID),
			new SqlParameter("@Sixth", estate.Sixth),
			new SqlParameter("@PreviousOwner", estate.PreviousOwner),
			new SqlParameter("@Comment", estate.Comment),
			new SqlParameter("@RegisterInformationID", estate.RegisterInformationID),
			new SqlParameter("@AdjustmentID", estate.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", estate.CommissionAdjustmentID),
			new SqlParameter("@Stage", estate.Stage),
			new SqlParameter("@UserOrder", estate.UserOrder),
			new SqlParameter("@Value1", estate.Value1),
			new SqlParameter("@Value2", estate.Value2),
			new SqlParameter("@Value3", estate.Value3),
			new SqlParameter("@DeadIsOwner", estate.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", estate.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Estate_SearchLike", CommandType.StoredProcedure, parametersEstate))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Estate tmpEstate = new Estate();
					tmpEstate.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpEstate.EstateTypeIDTitle = row["EstateTypeIDTitle"].ToString();
					tmpEstate.IndependentOf = row["IndependentOf"].ToString();
					tmpEstate.InquiryTo = row["InquiryTo"].ToString();
					tmpEstate.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					tmpEstate.MainPlaqueNumber = row["MainPlaqueNumber"].ToString();
					tmpEstate.SubPlaqueNumber = row["SubPlaqueNumber"].ToString();
					tmpEstate.SectionPlaqueNumber = row["SectionPlaqueNumber"].ToString();
					tmpEstate.RegisterState = row["RegisterState"].ToString();
					tmpEstate.EstateTypeID = (row["EstateTypeID"] != DBNull.Value) ? Convert.ToInt32(row["EstateTypeID"]) : 0 ;
					tmpEstate.Water = (row["Water"] != DBNull.Value) ? Convert.ToInt32(row["Water"]) : 0 ;
					tmpEstate.Electric = (row["Electric"] != DBNull.Value) ? Convert.ToInt32(row["Electric"]) : 0 ;
					tmpEstate.Gass = (row["Gass"] != DBNull.Value) ? Convert.ToInt32(row["Gass"]) : 0 ;
					tmpEstate.Wastewater = (row["Wastewater"] != DBNull.Value) ? Convert.ToInt32(row["Wastewater"]) : 0 ;
					tmpEstate.GoodwillValue = (row["GoodwillValue"] != DBNull.Value) ? Convert.ToSingle(row["GoodwillValue"]) : 0 ;
					tmpEstate.Area1 = (row["Area1"] != DBNull.Value) ? Convert.ToSingle(row["Area1"]) : 0 ;
					tmpEstate.Area2 = (row["Area2"] != DBNull.Value) ? Convert.ToSingle(row["Area2"]) : 0 ;
					tmpEstate.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(tmpEstate.HeritageID);
					tmpEstate.HeritageID = heritage.HeritageID;
					tmpEstate.StageTitle = heritage.StageTitle;
					tmpEstate.RegisterDate = heritage.RegisterDate;
					tmpEstate.OldRegisterDate = heritage.OldRegisterDate;
					tmpEstate.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpEstate.Sixth = heritage.Sixth;
					tmpEstate.PreviousOwner = heritage.PreviousOwner;
					tmpEstate.Comment = heritage.Comment;
					tmpEstate.RegisterInformationID = heritage.RegisterInformationID;
					tmpEstate.AdjustmentID = heritage.AdjustmentID;
					tmpEstate.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpEstate.Stage = heritage.Stage;
					tmpEstate.UserOrder = heritage.UserOrder;
					tmpEstate.Value1 = heritage.Value1;
					tmpEstate.Value2 = heritage.Value2;
					tmpEstate.Value3 = heritage.Value3;
					tmpEstate.DeadIsOwner = heritage.DeadIsOwner;
					tmpEstate.IsDiagonesed = heritage.IsDiagonesed;

					listEstate.Add(tmpEstate);
				}
			}
		}

		return listEstate;
	}

}
}
