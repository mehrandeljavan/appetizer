using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class TransferRightTypeDBAccess
{

	TransferRightDBAccess transferRightDBAccess = new TransferRightDBAccess();

	public List<TransferRight> GetListTransferRight(int transferRightTypeID)
	{
		List<TransferRight> listTransferRight = new List<TransferRight>() { };
		SqlParameter[] parametersTransferRightType = new SqlParameter[]
		{
			new SqlParameter("@TransferRightTypeID", transferRightTypeID)
		};

		//Lets get the list of TransferRight records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("TransferRight_GetList_UseInTransferRightType", CommandType.StoredProcedure, parametersTransferRightType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of transferRight
				listTransferRight = new List<TransferRight>();

				//Now lets populate the TransferRight details into the list of transferRights
				foreach (DataRow row in table.Rows)
				{
					TransferRight transferRight = ConvertRowToTransferRight(row);
					listTransferRight.Add(transferRight);
				}
			}
		}

		return listTransferRight;
	}

	private TransferRight ConvertRowToTransferRight(DataRow row)
	{
		TransferRight transferRight = new TransferRight();
		transferRight.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		transferRight.TransferRightTypeIDTitle = row["TransferRightTypeIDTitle"].ToString();
		transferRight.BalconyArea = row["BalconyArea"].ToString();
		transferRight.BalconyHeight = row["BalconyHeight"].ToString();
		transferRight.UndergroundArea = row["UndergroundArea"].ToString();
		transferRight.UndergroundHeight = row["UndergroundHeight"].ToString();
		transferRight.Adderss = row["Adderss"].ToString();
		transferRight.RegisterPart = row["RegisterPart"].ToString();
		transferRight.TransferRightTypeID = (row["TransferRightTypeID"] != DBNull.Value) ? Convert.ToInt32(row["TransferRightTypeID"]) : 0 ;
		transferRight.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		transferRight.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
		transferRight.Name = row["Name"].ToString();
		transferRight.ShopArea = row["ShopArea"].ToString();
		transferRight.ShopHeight = row["ShopHeight"].ToString();
		transferRight.Door = row["Door"].ToString();
		transferRight.DoorsNumber = row["DoorsNumber"].ToString();
		transferRight.DoorNumber = row["DoorNumber"].ToString();
		transferRight.RegisterPlague = row["RegisterPlague"].ToString();

		transferRight.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		transferRight.StageTitle = row["StageTitle"].ToString();
		transferRight.RegisterDate = row["RegisterDate"].ToString();
		transferRight.OldRegisterDate = row["OldRegisterDate"].ToString();
		transferRight.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		transferRight.Sixth = row["Sixth"].ToString();
		transferRight.PreviousOwner = row["PreviousOwner"].ToString();
		transferRight.Comment = row["Comment"].ToString();
		transferRight.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		transferRight.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		transferRight.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		transferRight.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		transferRight.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		transferRight.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		transferRight.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		transferRight.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		transferRight.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		transferRight.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return transferRight;
	}
	public Int64 Insert(TransferRightType transferRightType)
	{
		SqlParameter[] parametersTransferRightType = new SqlParameter[]
		{
			new SqlParameter("@Title", transferRightType.Title)
		};
		transferRightType.TransferRightTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("TransferRightType_Insert", CommandType.StoredProcedure, parametersTransferRightType));
		return transferRightType.TransferRightTypeID;
	}

	public bool Update(TransferRightType transferRightType)
	{
		SqlParameter[] parametersTransferRightType = new SqlParameter[]
		{
			new SqlParameter("@TransferRightTypeID", transferRightType.TransferRightTypeID),
			new SqlParameter("@Title", transferRightType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("TransferRightType_Update", CommandType.StoredProcedure, parametersTransferRightType);
	}

	public bool Delete(int transferRightTypeID)
	{
		SqlParameter[] parametersTransferRightType = new SqlParameter[]
		{
			new SqlParameter("@TransferRightTypeID", transferRightTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("TransferRightType_Delete", CommandType.StoredProcedure, parametersTransferRightType);
	}

	public TransferRightType GetDetails(int transferRightTypeID)
	{
		TransferRightType transferRightType = new TransferRightType();

		SqlParameter[] parametersTransferRightType = new SqlParameter[]
		{
			new SqlParameter("@TransferRightTypeID", transferRightTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("TransferRightType_GetDetails", CommandType.StoredProcedure, parametersTransferRightType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				transferRightType.TransferRightTypeID = (row["TransferRightTypeID"] != DBNull.Value) ? Convert.ToInt32(row["TransferRightTypeID"]) : 0 ;
				transferRightType.Title = row["Title"].ToString();
			}
		}

		return transferRightType;
	}

	public List<TransferRightType> GetListAll()
	{
		List<TransferRightType> listTransferRightType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("TransferRightType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listTransferRightType = new List<TransferRightType>();

				foreach (DataRow row in table.Rows)
				{
					TransferRightType transferRightType = new TransferRightType();
					transferRightType.TransferRightTypeID = (row["TransferRightTypeID"] != DBNull.Value) ? Convert.ToInt32(row["TransferRightTypeID"]) : 0 ;
					transferRightType.Title = row["Title"].ToString();
					listTransferRightType.Add(transferRightType);
				}
			}
		}

		return listTransferRightType;
	}

	public bool Exists(int transferRightTypeID)
	{
		SqlParameter[] parametersTransferRightType = new SqlParameter[]
		{
			new SqlParameter("@TransferRightTypeID", transferRightTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("TransferRightType_Exists", CommandType.StoredProcedure, parametersTransferRightType)>0);
	}

	public bool Exists(TransferRightType transferRightType)
	{
		SqlParameter[] parametersTransferRightType = new SqlParameter[]
		{
			new SqlParameter("@TransferRightTypeID", transferRightType.TransferRightTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("TransferRightType_Exists", CommandType.StoredProcedure, parametersTransferRightType)>0);
	}

	public List<TransferRightType> SearchLike(TransferRightType transferRightType)
	{
		List<TransferRightType> listTransferRightType = new List<TransferRightType>();


		SqlParameter[] parametersTransferRightType = new SqlParameter[]
		{
			new SqlParameter("@TransferRightTypeID", transferRightType.TransferRightTypeID),
			new SqlParameter("@Title", transferRightType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("TransferRightType_SearchLike", CommandType.StoredProcedure, parametersTransferRightType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					TransferRightType tmpTransferRightType = new TransferRightType();
					tmpTransferRightType.TransferRightTypeID = (row["TransferRightTypeID"] != DBNull.Value) ? Convert.ToInt32(row["TransferRightTypeID"]) : 0 ;
					tmpTransferRightType.Title = row["Title"].ToString();

					listTransferRightType.Add(tmpTransferRightType);
				}
			}
		}

		return listTransferRightType;
	}

}
}
