using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class HajjTypeDBAccess
{

	HajjDBAccess hajjDBAccess = new HajjDBAccess();

	public List<Hajj> GetListHajj(int hajjTypeID)
	{
		List<Hajj> listHajj = new List<Hajj>() { };
		SqlParameter[] parametersHajjType = new SqlParameter[]
		{
			new SqlParameter("@HajjTypeID", hajjTypeID)
		};

		//Lets get the list of Hajj records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Hajj_GetList_UseInHajjType", CommandType.StoredProcedure, parametersHajjType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of hajj
				listHajj = new List<Hajj>();

				//Now lets populate the Hajj details into the list of hajjs
				foreach (DataRow row in table.Rows)
				{
					Hajj hajj = ConvertRowToHajj(row);
					listHajj.Add(hajj);
				}
			}
		}

		return listHajj;
	}

	private Hajj ConvertRowToHajj(DataRow row)
	{
		Hajj hajj = new Hajj();
		hajj.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		hajj.HajjTypeIDTitle = row["HajjTypeIDTitle"].ToString();
		hajj.BankInquiryHajjIDTitle = row["BankInquiryHajjIDTitle"].ToString();
		hajj.FactorDate = row["FactorDate"].ToString();
		hajj.FactorNumber = row["FactorNumber"].ToString();
		hajj.HajjTypeID = (row["HajjTypeID"] != DBNull.Value) ? Convert.ToInt32(row["HajjTypeID"]) : 0 ;
		hajj.BankInquiryHajjID = (row["BankInquiryHajjID"] != DBNull.Value) ? Convert.ToInt32(row["BankInquiryHajjID"]) : 0 ;
		hajj.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;

		hajj.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		hajj.StageTitle = row["StageTitle"].ToString();
		hajj.RegisterDate = row["RegisterDate"].ToString();
		hajj.OldRegisterDate = row["OldRegisterDate"].ToString();
		hajj.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		hajj.Sixth = row["Sixth"].ToString();
		hajj.PreviousOwner = row["PreviousOwner"].ToString();
		hajj.Comment = row["Comment"].ToString();
		hajj.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		hajj.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		hajj.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		hajj.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		hajj.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		hajj.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		hajj.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		hajj.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		hajj.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		hajj.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return hajj;
	}
	public Int64 Insert(HajjType hajjType)
	{
		SqlParameter[] parametersHajjType = new SqlParameter[]
		{
			new SqlParameter("@Title", hajjType.Title)
		};
		hajjType.HajjTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("HajjType_Insert", CommandType.StoredProcedure, parametersHajjType));
		return hajjType.HajjTypeID;
	}

	public bool Update(HajjType hajjType)
	{
		SqlParameter[] parametersHajjType = new SqlParameter[]
		{
			new SqlParameter("@HajjTypeID", hajjType.HajjTypeID),
			new SqlParameter("@Title", hajjType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("HajjType_Update", CommandType.StoredProcedure, parametersHajjType);
	}

	public bool Delete(int hajjTypeID)
	{
		SqlParameter[] parametersHajjType = new SqlParameter[]
		{
			new SqlParameter("@HajjTypeID", hajjTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("HajjType_Delete", CommandType.StoredProcedure, parametersHajjType);
	}

	public HajjType GetDetails(int hajjTypeID)
	{
		HajjType hajjType = new HajjType();

		SqlParameter[] parametersHajjType = new SqlParameter[]
		{
			new SqlParameter("@HajjTypeID", hajjTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("HajjType_GetDetails", CommandType.StoredProcedure, parametersHajjType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				hajjType.HajjTypeID = (row["HajjTypeID"] != DBNull.Value) ? Convert.ToInt32(row["HajjTypeID"]) : 0 ;
				hajjType.Title = row["Title"].ToString();
			}
		}

		return hajjType;
	}

	public List<HajjType> GetListAll()
	{
		List<HajjType> listHajjType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("HajjType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listHajjType = new List<HajjType>();

				foreach (DataRow row in table.Rows)
				{
					HajjType hajjType = new HajjType();
					hajjType.HajjTypeID = (row["HajjTypeID"] != DBNull.Value) ? Convert.ToInt32(row["HajjTypeID"]) : 0 ;
					hajjType.Title = row["Title"].ToString();
					listHajjType.Add(hajjType);
				}
			}
		}

		return listHajjType;
	}

	public bool Exists(int hajjTypeID)
	{
		SqlParameter[] parametersHajjType = new SqlParameter[]
		{
			new SqlParameter("@HajjTypeID", hajjTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("HajjType_Exists", CommandType.StoredProcedure, parametersHajjType)>0);
	}

	public bool Exists(HajjType hajjType)
	{
		SqlParameter[] parametersHajjType = new SqlParameter[]
		{
			new SqlParameter("@HajjTypeID", hajjType.HajjTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("HajjType_Exists", CommandType.StoredProcedure, parametersHajjType)>0);
	}

	public List<HajjType> SearchLike(HajjType hajjType)
	{
		List<HajjType> listHajjType = new List<HajjType>();


		SqlParameter[] parametersHajjType = new SqlParameter[]
		{
			new SqlParameter("@HajjTypeID", hajjType.HajjTypeID),
			new SqlParameter("@Title", hajjType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("HajjType_SearchLike", CommandType.StoredProcedure, parametersHajjType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					HajjType tmpHajjType = new HajjType();
					tmpHajjType.HajjTypeID = (row["HajjTypeID"] != DBNull.Value) ? Convert.ToInt32(row["HajjTypeID"]) : 0 ;
					tmpHajjType.Title = row["Title"].ToString();

					listHajjType.Add(tmpHajjType);
				}
			}
		}

		return listHajjType;
	}

}
}
