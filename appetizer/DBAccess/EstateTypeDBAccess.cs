using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class EstateTypeDBAccess
{

	EstateDBAccess estateDBAccess = new EstateDBAccess();

	public List<Estate> GetListEstate(int estateTypeID)
	{
		List<Estate> listEstate = new List<Estate>() { };
		SqlParameter[] parametersEstateType = new SqlParameter[]
		{
			new SqlParameter("@EstateTypeID", estateTypeID)
		};

		//Lets get the list of Estate records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Estate_GetList_UseInEstateType", CommandType.StoredProcedure, parametersEstateType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of estate
				listEstate = new List<Estate>();

				//Now lets populate the Estate details into the list of estates
				foreach (DataRow row in table.Rows)
				{
					Estate estate = ConvertRowToEstate(row);
					listEstate.Add(estate);
				}
			}
		}

		return listEstate;
	}

	private Estate ConvertRowToEstate(DataRow row)
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

		estate.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		estate.StageTitle = row["StageTitle"].ToString();
		estate.RegisterDate = row["RegisterDate"].ToString();
		estate.OldRegisterDate = row["OldRegisterDate"].ToString();
		estate.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		estate.Sixth = row["Sixth"].ToString();
		estate.PreviousOwner = row["PreviousOwner"].ToString();
		estate.Comment = row["Comment"].ToString();
		estate.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		estate.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		estate.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		estate.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		estate.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		estate.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		estate.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		estate.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		estate.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		estate.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return estate;
	}
	public Int64 Insert(EstateType estateType)
	{
		SqlParameter[] parametersEstateType = new SqlParameter[]
		{
			new SqlParameter("@Category", (estateType.Category != null) ? estateType.Category : (object)DBNull.Value),
			new SqlParameter("@Title", estateType.Title)
		};
		estateType.EstateTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("EstateType_Insert", CommandType.StoredProcedure, parametersEstateType));
		return estateType.EstateTypeID;
	}

	public bool Update(EstateType estateType)
	{
		SqlParameter[] parametersEstateType = new SqlParameter[]
		{
			new SqlParameter("@EstateTypeID", estateType.EstateTypeID),
			new SqlParameter("@Category", (estateType.Category != null) ? estateType.Category : (object)DBNull.Value),
			new SqlParameter("@Title", estateType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("EstateType_Update", CommandType.StoredProcedure, parametersEstateType);
	}

	public bool Delete(int estateTypeID)
	{
		SqlParameter[] parametersEstateType = new SqlParameter[]
		{
			new SqlParameter("@EstateTypeID", estateTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("EstateType_Delete", CommandType.StoredProcedure, parametersEstateType);
	}

	public EstateType GetDetails(int estateTypeID)
	{
		EstateType estateType = new EstateType();

		SqlParameter[] parametersEstateType = new SqlParameter[]
		{
			new SqlParameter("@EstateTypeID", estateTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("EstateType_GetDetails", CommandType.StoredProcedure, parametersEstateType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				estateType.EstateTypeID = (row["EstateTypeID"] != DBNull.Value) ? Convert.ToInt32(row["EstateTypeID"]) : 0 ;
				estateType.Category = (row["Category"] != DBNull.Value) ? Convert.ToInt32(row["Category"]) : 0 ;
				estateType.Title = row["Title"].ToString();
			}
		}

		return estateType;
	}

	public List<EstateType> GetListAll()
	{
		List<EstateType> listEstateType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("EstateType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listEstateType = new List<EstateType>();

				foreach (DataRow row in table.Rows)
				{
					EstateType estateType = new EstateType();
					estateType.EstateTypeID = (row["EstateTypeID"] != DBNull.Value) ? Convert.ToInt32(row["EstateTypeID"]) : 0 ;
					estateType.Category = (row["Category"] != DBNull.Value) ? Convert.ToInt32(row["Category"]) : 0 ;
					estateType.Title = row["Title"].ToString();
					listEstateType.Add(estateType);
				}
			}
		}

		return listEstateType;
	}

	public bool Exists(int estateTypeID)
	{
		SqlParameter[] parametersEstateType = new SqlParameter[]
		{
			new SqlParameter("@EstateTypeID", estateTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("EstateType_Exists", CommandType.StoredProcedure, parametersEstateType)>0);
	}

	public bool Exists(EstateType estateType)
	{
		SqlParameter[] parametersEstateType = new SqlParameter[]
		{
			new SqlParameter("@EstateTypeID", estateType.EstateTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("EstateType_Exists", CommandType.StoredProcedure, parametersEstateType)>0);
	}

	public List<EstateType> SearchLike(EstateType estateType)
	{
		List<EstateType> listEstateType = new List<EstateType>();


		SqlParameter[] parametersEstateType = new SqlParameter[]
		{
			new SqlParameter("@EstateTypeID", estateType.EstateTypeID),
			new SqlParameter("@Category", estateType.Category),
			new SqlParameter("@Title", estateType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("EstateType_SearchLike", CommandType.StoredProcedure, parametersEstateType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					EstateType tmpEstateType = new EstateType();
					tmpEstateType.EstateTypeID = (row["EstateTypeID"] != DBNull.Value) ? Convert.ToInt32(row["EstateTypeID"]) : 0 ;
					tmpEstateType.Category = (row["Category"] != DBNull.Value) ? Convert.ToInt32(row["Category"]) : 0 ;
					tmpEstateType.Title = row["Title"].ToString();

					listEstateType.Add(tmpEstateType);
				}
			}
		}

		return listEstateType;
	}

}
}
