using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class TransferRightDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(TransferRight transferRight)
	{
		if (!heritageDBAccess.Exists(transferRight))
			transferRight.HeritageID = heritageDBAccess.Insert(transferRight);

		SqlParameter[] parametersTransferRight = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (transferRight.HeritageID > 0) ? transferRight.HeritageID : (object)DBNull.Value),
			new SqlParameter("@BalconyArea", (transferRight.BalconyArea != null) ? transferRight.BalconyArea : (object)DBNull.Value),
			new SqlParameter("@BalconyHeight", (transferRight.BalconyHeight != null) ? transferRight.BalconyHeight : (object)DBNull.Value),
			new SqlParameter("@UndergroundArea", (transferRight.UndergroundArea != null) ? transferRight.UndergroundArea : (object)DBNull.Value),
			new SqlParameter("@UndergroundHeight", (transferRight.UndergroundHeight != null) ? transferRight.UndergroundHeight : (object)DBNull.Value),
			new SqlParameter("@Adderss", (transferRight.Adderss != null) ? transferRight.Adderss : (object)DBNull.Value),
			new SqlParameter("@RegisterPart", (transferRight.RegisterPart != null) ? transferRight.RegisterPart : (object)DBNull.Value),
			new SqlParameter("@TransferRightTypeID", (transferRight.TransferRightTypeID > 0) ? transferRight.TransferRightTypeID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (transferRight.DeclarationID > 0) ? transferRight.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@ProductionUnitID", (transferRight.ProductionUnitID > 0) ? transferRight.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@Name", (transferRight.Name != null) ? transferRight.Name : (object)DBNull.Value),
			new SqlParameter("@ShopArea", (transferRight.ShopArea != null) ? transferRight.ShopArea : (object)DBNull.Value),
			new SqlParameter("@ShopHeight", (transferRight.ShopHeight != null) ? transferRight.ShopHeight : (object)DBNull.Value),
			new SqlParameter("@Door", (transferRight.Door != null) ? transferRight.Door : (object)DBNull.Value),
			new SqlParameter("@DoorsNumber", (transferRight.DoorsNumber != null) ? transferRight.DoorsNumber : (object)DBNull.Value),
			new SqlParameter("@DoorNumber", (transferRight.DoorNumber != null) ? transferRight.DoorNumber : (object)DBNull.Value),
			new SqlParameter("@RegisterPlague", (transferRight.RegisterPlague != null) ? transferRight.RegisterPlague : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("TransferRight_Insert", CommandType.StoredProcedure, parametersTransferRight);
	}

	public bool Update(TransferRight transferRight)
	{
		heritageDBAccess.Update(transferRight);

		SqlParameter[] parametersTransferRight = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", transferRight.HeritageID),
			new SqlParameter("@BalconyArea", (transferRight.BalconyArea != null) ? transferRight.BalconyArea : (object)DBNull.Value),
			new SqlParameter("@BalconyHeight", (transferRight.BalconyHeight != null) ? transferRight.BalconyHeight : (object)DBNull.Value),
			new SqlParameter("@UndergroundArea", (transferRight.UndergroundArea != null) ? transferRight.UndergroundArea : (object)DBNull.Value),
			new SqlParameter("@UndergroundHeight", (transferRight.UndergroundHeight != null) ? transferRight.UndergroundHeight : (object)DBNull.Value),
			new SqlParameter("@Adderss", (transferRight.Adderss != null) ? transferRight.Adderss : (object)DBNull.Value),
			new SqlParameter("@RegisterPart", (transferRight.RegisterPart != null) ? transferRight.RegisterPart : (object)DBNull.Value),
			new SqlParameter("@TransferRightTypeID", (transferRight.TransferRightTypeID != null && transferRight.TransferRightTypeID >0 ) ? transferRight.TransferRightTypeID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", transferRight.DeclarationID),
			new SqlParameter("@ProductionUnitID", (transferRight.ProductionUnitID != null && transferRight.ProductionUnitID >0 ) ? transferRight.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@Name", (transferRight.Name != null) ? transferRight.Name : (object)DBNull.Value),
			new SqlParameter("@ShopArea", (transferRight.ShopArea != null) ? transferRight.ShopArea : (object)DBNull.Value),
			new SqlParameter("@ShopHeight", (transferRight.ShopHeight != null) ? transferRight.ShopHeight : (object)DBNull.Value),
			new SqlParameter("@Door", (transferRight.Door != null) ? transferRight.Door : (object)DBNull.Value),
			new SqlParameter("@DoorsNumber", (transferRight.DoorsNumber != null) ? transferRight.DoorsNumber : (object)DBNull.Value),
			new SqlParameter("@DoorNumber", (transferRight.DoorNumber != null) ? transferRight.DoorNumber : (object)DBNull.Value),
			new SqlParameter("@RegisterPlague", (transferRight.RegisterPlague != null) ? transferRight.RegisterPlague : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("TransferRight_Update", CommandType.StoredProcedure, parametersTransferRight);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersTransferRight = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("TransferRight_Delete", CommandType.StoredProcedure, parametersTransferRight);
	}

	public TransferRight GetDetails(Int64 heritageID)
	{
		TransferRight transferRight = new TransferRight();

		SqlParameter[] parametersTransferRight = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("TransferRight_GetDetails", CommandType.StoredProcedure, parametersTransferRight))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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

				Heritage heritage = heritageDBAccess.GetDetails(transferRight.HeritageID);
				transferRight.HeritageID = heritage.HeritageID;
				transferRight.StageTitle = heritage.StageTitle;
				transferRight.RegisterDate = heritage.RegisterDate;
				transferRight.OldRegisterDate = heritage.OldRegisterDate;
				transferRight.OldRegisterInformationID = heritage.OldRegisterInformationID;
				transferRight.Sixth = heritage.Sixth;
				transferRight.PreviousOwner = heritage.PreviousOwner;
				transferRight.Comment = heritage.Comment;
				transferRight.RegisterInformationID = heritage.RegisterInformationID;
				transferRight.AdjustmentID = heritage.AdjustmentID;
				transferRight.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				transferRight.Stage = heritage.Stage;
				transferRight.UserOrder = heritage.UserOrder;
				transferRight.Value1 = heritage.Value1;
				transferRight.Value2 = heritage.Value2;
				transferRight.Value3 = heritage.Value3;
				transferRight.DeadIsOwner = heritage.DeadIsOwner;
				transferRight.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return transferRight;
	}

	public List<TransferRight> GetListAll()
	{
		List<TransferRight> listTransferRight = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("TransferRight_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listTransferRight = new List<TransferRight>();

				foreach (DataRow row in table.Rows)
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

					Heritage heritage = heritageDBAccess.GetDetails(transferRight.HeritageID);
					transferRight.StageTitle = heritage.StageTitle;
					transferRight.RegisterDate = heritage.RegisterDate;
					transferRight.OldRegisterDate = heritage.OldRegisterDate;
					transferRight.OldRegisterInformationID = heritage.OldRegisterInformationID;
					transferRight.Sixth = heritage.Sixth;
					transferRight.PreviousOwner = heritage.PreviousOwner;
					transferRight.Comment = heritage.Comment;
					transferRight.RegisterInformationID = heritage.RegisterInformationID;
					transferRight.AdjustmentID = heritage.AdjustmentID;
					transferRight.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					transferRight.Stage = heritage.Stage;
					transferRight.UserOrder = heritage.UserOrder;
					transferRight.Value1 = heritage.Value1;
					transferRight.Value2 = heritage.Value2;
					transferRight.Value3 = heritage.Value3;
					transferRight.DeadIsOwner = heritage.DeadIsOwner;
					transferRight.IsDiagonesed = heritage.IsDiagonesed;
					listTransferRight.Add(transferRight);
				}
			}
		}

		return listTransferRight;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersTransferRight = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("TransferRight_Exists", CommandType.StoredProcedure, parametersTransferRight)>0);
	}

	public bool Exists(TransferRight transferRight)
	{
		SqlParameter[] parametersTransferRight = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", transferRight.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("TransferRight_Exists", CommandType.StoredProcedure, parametersTransferRight)>0);
	}

	public List<TransferRight> SearchLike(TransferRight transferRight)
	{
		List<TransferRight> listTransferRight = new List<TransferRight>();


		SqlParameter[] parametersTransferRight = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", transferRight.HeritageID),
			new SqlParameter("@TransferRightTypeIDTitle", transferRight.TransferRightTypeIDTitle),
			new SqlParameter("@BalconyArea", transferRight.BalconyArea),
			new SqlParameter("@BalconyHeight", transferRight.BalconyHeight),
			new SqlParameter("@UndergroundArea", transferRight.UndergroundArea),
			new SqlParameter("@UndergroundHeight", transferRight.UndergroundHeight),
			new SqlParameter("@Adderss", transferRight.Adderss),
			new SqlParameter("@RegisterPart", transferRight.RegisterPart),
			new SqlParameter("@TransferRightTypeID", transferRight.TransferRightTypeID),
			new SqlParameter("@DeclarationID", transferRight.DeclarationID),
			new SqlParameter("@ProductionUnitID", transferRight.ProductionUnitID),
			new SqlParameter("@Name", transferRight.Name),
			new SqlParameter("@ShopArea", transferRight.ShopArea),
			new SqlParameter("@ShopHeight", transferRight.ShopHeight),
			new SqlParameter("@Door", transferRight.Door),
			new SqlParameter("@DoorsNumber", transferRight.DoorsNumber),
			new SqlParameter("@DoorNumber", transferRight.DoorNumber),
			new SqlParameter("@RegisterPlague", transferRight.RegisterPlague),

			new SqlParameter("@StageTitle", transferRight.StageTitle),
			new SqlParameter("@RegisterDate", transferRight.RegisterDate),
			new SqlParameter("@OldRegisterDate", transferRight.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", transferRight.OldRegisterInformationID),
			new SqlParameter("@Sixth", transferRight.Sixth),
			new SqlParameter("@PreviousOwner", transferRight.PreviousOwner),
			new SqlParameter("@Comment", transferRight.Comment),
			new SqlParameter("@RegisterInformationID", transferRight.RegisterInformationID),
			new SqlParameter("@AdjustmentID", transferRight.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", transferRight.CommissionAdjustmentID),
			new SqlParameter("@Stage", transferRight.Stage),
			new SqlParameter("@UserOrder", transferRight.UserOrder),
			new SqlParameter("@Value1", transferRight.Value1),
			new SqlParameter("@Value2", transferRight.Value2),
			new SqlParameter("@Value3", transferRight.Value3),
			new SqlParameter("@DeadIsOwner", transferRight.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", transferRight.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("TransferRight_SearchLike", CommandType.StoredProcedure, parametersTransferRight))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					TransferRight tmpTransferRight = new TransferRight();
					tmpTransferRight.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpTransferRight.TransferRightTypeIDTitle = row["TransferRightTypeIDTitle"].ToString();
					tmpTransferRight.BalconyArea = row["BalconyArea"].ToString();
					tmpTransferRight.BalconyHeight = row["BalconyHeight"].ToString();
					tmpTransferRight.UndergroundArea = row["UndergroundArea"].ToString();
					tmpTransferRight.UndergroundHeight = row["UndergroundHeight"].ToString();
					tmpTransferRight.Adderss = row["Adderss"].ToString();
					tmpTransferRight.RegisterPart = row["RegisterPart"].ToString();
					tmpTransferRight.TransferRightTypeID = (row["TransferRightTypeID"] != DBNull.Value) ? Convert.ToInt32(row["TransferRightTypeID"]) : 0 ;
					tmpTransferRight.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpTransferRight.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					tmpTransferRight.Name = row["Name"].ToString();
					tmpTransferRight.ShopArea = row["ShopArea"].ToString();
					tmpTransferRight.ShopHeight = row["ShopHeight"].ToString();
					tmpTransferRight.Door = row["Door"].ToString();
					tmpTransferRight.DoorsNumber = row["DoorsNumber"].ToString();
					tmpTransferRight.DoorNumber = row["DoorNumber"].ToString();
					tmpTransferRight.RegisterPlague = row["RegisterPlague"].ToString();

					Heritage heritage = heritageDBAccess.GetDetails(tmpTransferRight.HeritageID);
					tmpTransferRight.HeritageID = heritage.HeritageID;
					tmpTransferRight.StageTitle = heritage.StageTitle;
					tmpTransferRight.RegisterDate = heritage.RegisterDate;
					tmpTransferRight.OldRegisterDate = heritage.OldRegisterDate;
					tmpTransferRight.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpTransferRight.Sixth = heritage.Sixth;
					tmpTransferRight.PreviousOwner = heritage.PreviousOwner;
					tmpTransferRight.Comment = heritage.Comment;
					tmpTransferRight.RegisterInformationID = heritage.RegisterInformationID;
					tmpTransferRight.AdjustmentID = heritage.AdjustmentID;
					tmpTransferRight.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpTransferRight.Stage = heritage.Stage;
					tmpTransferRight.UserOrder = heritage.UserOrder;
					tmpTransferRight.Value1 = heritage.Value1;
					tmpTransferRight.Value2 = heritage.Value2;
					tmpTransferRight.Value3 = heritage.Value3;
					tmpTransferRight.DeadIsOwner = heritage.DeadIsOwner;
					tmpTransferRight.IsDiagonesed = heritage.IsDiagonesed;

					listTransferRight.Add(tmpTransferRight);
				}
			}
		}

		return listTransferRight;
	}

}
}
