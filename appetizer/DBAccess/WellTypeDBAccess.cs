using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class WellTypeDBAccess
{

	WellDBAccess wellDBAccess = new WellDBAccess();

	public List<Well> GetListWell(int wellTypeID)
	{
		List<Well> listWell = new List<Well>() { };
		SqlParameter[] parametersWellType = new SqlParameter[]
		{
			new SqlParameter("@WellTypeID", wellTypeID)
		};

		//Lets get the list of Well records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Well_GetList_UseInWellType", CommandType.StoredProcedure, parametersWellType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of well
				listWell = new List<Well>();

				//Now lets populate the Well details into the list of wells
				foreach (DataRow row in table.Rows)
				{
					Well well = ConvertRowToWell(row);
					listWell.Add(well);
				}
			}
		}

		return listWell;
	}

	private Well ConvertRowToWell(DataRow row)
	{
		Well well = new Well();
		well.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		well.WellTypeIDTitle = row["WellTypeIDTitle"].ToString();
		well.WellTypeID = (row["WellTypeID"] != DBNull.Value) ? Convert.ToInt32(row["WellTypeID"]) : 0 ;
		well.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		well.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
		well.Plaque = row["Plaque"].ToString();
		well.Scope = row["Scope"].ToString();
		well.DocNo = row["DocNo"].ToString();

		well.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		well.StageTitle = row["StageTitle"].ToString();
		well.RegisterDate = row["RegisterDate"].ToString();
		well.OldRegisterDate = row["OldRegisterDate"].ToString();
		well.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		well.Sixth = row["Sixth"].ToString();
		well.PreviousOwner = row["PreviousOwner"].ToString();
		well.Comment = row["Comment"].ToString();
		well.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		well.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		well.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		well.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		well.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		well.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		well.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		well.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		well.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		well.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return well;
	}
	public Int64 Insert(WellType wellType)
	{
		SqlParameter[] parametersWellType = new SqlParameter[]
		{
			new SqlParameter("@Title", (wellType.Title != null) ? wellType.Title : (object)DBNull.Value)
		};
		wellType.WellTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("WellType_Insert", CommandType.StoredProcedure, parametersWellType));
		return wellType.WellTypeID;
	}

	public bool Update(WellType wellType)
	{
		SqlParameter[] parametersWellType = new SqlParameter[]
		{
			new SqlParameter("@WellTypeID", wellType.WellTypeID),
			new SqlParameter("@Title", (wellType.Title != null) ? wellType.Title : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("WellType_Update", CommandType.StoredProcedure, parametersWellType);
	}

	public bool Delete(int wellTypeID)
	{
		SqlParameter[] parametersWellType = new SqlParameter[]
		{
			new SqlParameter("@WellTypeID", wellTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("WellType_Delete", CommandType.StoredProcedure, parametersWellType);
	}

	public WellType GetDetails(int wellTypeID)
	{
		WellType wellType = new WellType();

		SqlParameter[] parametersWellType = new SqlParameter[]
		{
			new SqlParameter("@WellTypeID", wellTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("WellType_GetDetails", CommandType.StoredProcedure, parametersWellType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				wellType.WellTypeID = (row["WellTypeID"] != DBNull.Value) ? Convert.ToInt32(row["WellTypeID"]) : 0 ;
				wellType.Title = row["Title"].ToString();
			}
		}

		return wellType;
	}

	public List<WellType> GetListAll()
	{
		List<WellType> listWellType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("WellType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listWellType = new List<WellType>();

				foreach (DataRow row in table.Rows)
				{
					WellType wellType = new WellType();
					wellType.WellTypeID = (row["WellTypeID"] != DBNull.Value) ? Convert.ToInt32(row["WellTypeID"]) : 0 ;
					wellType.Title = row["Title"].ToString();
					listWellType.Add(wellType);
				}
			}
		}

		return listWellType;
	}

	public bool Exists(int wellTypeID)
	{
		SqlParameter[] parametersWellType = new SqlParameter[]
		{
			new SqlParameter("@WellTypeID", wellTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("WellType_Exists", CommandType.StoredProcedure, parametersWellType)>0);
	}

	public bool Exists(WellType wellType)
	{
		SqlParameter[] parametersWellType = new SqlParameter[]
		{
			new SqlParameter("@WellTypeID", wellType.WellTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("WellType_Exists", CommandType.StoredProcedure, parametersWellType)>0);
	}

	public List<WellType> SearchLike(WellType wellType)
	{
		List<WellType> listWellType = new List<WellType>();


		SqlParameter[] parametersWellType = new SqlParameter[]
		{
			new SqlParameter("@WellTypeID", wellType.WellTypeID),
			new SqlParameter("@Title", wellType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("WellType_SearchLike", CommandType.StoredProcedure, parametersWellType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					WellType tmpWellType = new WellType();
					tmpWellType.WellTypeID = (row["WellTypeID"] != DBNull.Value) ? Convert.ToInt32(row["WellTypeID"]) : 0 ;
					tmpWellType.Title = row["Title"].ToString();

					listWellType.Add(tmpWellType);
				}
			}
		}

		return listWellType;
	}

}
}
