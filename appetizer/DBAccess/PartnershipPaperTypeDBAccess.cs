using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class PartnershipPaperTypeDBAccess
{

	PartnershipPapersDBAccess partnershipPapersDBAccess = new PartnershipPapersDBAccess();

	public List<PartnershipPapers> GetListPartnershipPapers(int partnershipPaperTypeID)
	{
		List<PartnershipPapers> listPartnershipPapers = new List<PartnershipPapers>() { };
		SqlParameter[] parametersPartnershipPaperType = new SqlParameter[]
		{
			new SqlParameter("@PartnershipPaperTypeID", partnershipPaperTypeID)
		};

		//Lets get the list of PartnershipPapers records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("PartnershipPapers_GetList_UseInPartnershipPaperType", CommandType.StoredProcedure, parametersPartnershipPaperType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of partnershipPapers
				listPartnershipPapers = new List<PartnershipPapers>();

				//Now lets populate the PartnershipPapers details into the list of partnershipPaperss
				foreach (DataRow row in table.Rows)
				{
					PartnershipPapers partnershipPapers = ConvertRowToPartnershipPapers(row);
					listPartnershipPapers.Add(partnershipPapers);
				}
			}
		}

		return listPartnershipPapers;
	}

	private PartnershipPapers ConvertRowToPartnershipPapers(DataRow row)
	{
		PartnershipPapers partnershipPapers = new PartnershipPapers();
		partnershipPapers.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		partnershipPapers.PartnershipPaperTypeIDTitle = row["PartnershipPaperTypeIDTitle"].ToString();
		partnershipPapers.PartnershipPaperTypeID = (row["PartnershipPaperTypeID"] != DBNull.Value) ? Convert.ToInt32(row["PartnershipPaperTypeID"]) : 0 ;
		partnershipPapers.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		partnershipPapers.ProjectName = row["ProjectName"].ToString();
		partnershipPapers.SellerName = row["SellerName"].ToString();
		partnershipPapers.PaperNumber = row["PaperNumber"].ToString();

		partnershipPapers.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		partnershipPapers.StageTitle = row["StageTitle"].ToString();
		partnershipPapers.RegisterDate = row["RegisterDate"].ToString();
		partnershipPapers.OldRegisterDate = row["OldRegisterDate"].ToString();
		partnershipPapers.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		partnershipPapers.Sixth = row["Sixth"].ToString();
		partnershipPapers.PreviousOwner = row["PreviousOwner"].ToString();
		partnershipPapers.Comment = row["Comment"].ToString();
		partnershipPapers.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		partnershipPapers.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		partnershipPapers.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		partnershipPapers.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		partnershipPapers.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		partnershipPapers.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		partnershipPapers.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		partnershipPapers.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		partnershipPapers.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		partnershipPapers.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return partnershipPapers;
	}
	public Int64 Insert(PartnershipPaperType partnershipPaperType)
	{
		SqlParameter[] parametersPartnershipPaperType = new SqlParameter[]
		{
			new SqlParameter("@Title", partnershipPaperType.Title)
		};
		partnershipPaperType.PartnershipPaperTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("PartnershipPaperType_Insert", CommandType.StoredProcedure, parametersPartnershipPaperType));
		return partnershipPaperType.PartnershipPaperTypeID;
	}

	public bool Update(PartnershipPaperType partnershipPaperType)
	{
		SqlParameter[] parametersPartnershipPaperType = new SqlParameter[]
		{
			new SqlParameter("@PartnershipPaperTypeID", partnershipPaperType.PartnershipPaperTypeID),
			new SqlParameter("@Title", partnershipPaperType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("PartnershipPaperType_Update", CommandType.StoredProcedure, parametersPartnershipPaperType);
	}

	public bool Delete(int partnershipPaperTypeID)
	{
		SqlParameter[] parametersPartnershipPaperType = new SqlParameter[]
		{
			new SqlParameter("@PartnershipPaperTypeID", partnershipPaperTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("PartnershipPaperType_Delete", CommandType.StoredProcedure, parametersPartnershipPaperType);
	}

	public PartnershipPaperType GetDetails(int partnershipPaperTypeID)
	{
		PartnershipPaperType partnershipPaperType = new PartnershipPaperType();

		SqlParameter[] parametersPartnershipPaperType = new SqlParameter[]
		{
			new SqlParameter("@PartnershipPaperTypeID", partnershipPaperTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("PartnershipPaperType_GetDetails", CommandType.StoredProcedure, parametersPartnershipPaperType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				partnershipPaperType.PartnershipPaperTypeID = (row["PartnershipPaperTypeID"] != DBNull.Value) ? Convert.ToInt32(row["PartnershipPaperTypeID"]) : 0 ;
				partnershipPaperType.Title = row["Title"].ToString();
			}
		}

		return partnershipPaperType;
	}

	public List<PartnershipPaperType> GetListAll()
	{
		List<PartnershipPaperType> listPartnershipPaperType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("PartnershipPaperType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listPartnershipPaperType = new List<PartnershipPaperType>();

				foreach (DataRow row in table.Rows)
				{
					PartnershipPaperType partnershipPaperType = new PartnershipPaperType();
					partnershipPaperType.PartnershipPaperTypeID = (row["PartnershipPaperTypeID"] != DBNull.Value) ? Convert.ToInt32(row["PartnershipPaperTypeID"]) : 0 ;
					partnershipPaperType.Title = row["Title"].ToString();
					listPartnershipPaperType.Add(partnershipPaperType);
				}
			}
		}

		return listPartnershipPaperType;
	}

	public bool Exists(int partnershipPaperTypeID)
	{
		SqlParameter[] parametersPartnershipPaperType = new SqlParameter[]
		{
			new SqlParameter("@PartnershipPaperTypeID", partnershipPaperTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("PartnershipPaperType_Exists", CommandType.StoredProcedure, parametersPartnershipPaperType)>0);
	}

	public bool Exists(PartnershipPaperType partnershipPaperType)
	{
		SqlParameter[] parametersPartnershipPaperType = new SqlParameter[]
		{
			new SqlParameter("@PartnershipPaperTypeID", partnershipPaperType.PartnershipPaperTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("PartnershipPaperType_Exists", CommandType.StoredProcedure, parametersPartnershipPaperType)>0);
	}

	public List<PartnershipPaperType> SearchLike(PartnershipPaperType partnershipPaperType)
	{
		List<PartnershipPaperType> listPartnershipPaperType = new List<PartnershipPaperType>();


		SqlParameter[] parametersPartnershipPaperType = new SqlParameter[]
		{
			new SqlParameter("@PartnershipPaperTypeID", partnershipPaperType.PartnershipPaperTypeID),
			new SqlParameter("@Title", partnershipPaperType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("PartnershipPaperType_SearchLike", CommandType.StoredProcedure, parametersPartnershipPaperType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					PartnershipPaperType tmpPartnershipPaperType = new PartnershipPaperType();
					tmpPartnershipPaperType.PartnershipPaperTypeID = (row["PartnershipPaperTypeID"] != DBNull.Value) ? Convert.ToInt32(row["PartnershipPaperTypeID"]) : 0 ;
					tmpPartnershipPaperType.Title = row["Title"].ToString();

					listPartnershipPaperType.Add(tmpPartnershipPaperType);
				}
			}
		}

		return listPartnershipPaperType;
	}

}
}
