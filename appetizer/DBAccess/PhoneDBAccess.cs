using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class PhoneDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(Phone phone)
	{
		if (!heritageDBAccess.Exists(phone))
			phone.HeritageID = heritageDBAccess.Insert(phone);

		SqlParameter[] parametersPhone = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (phone.HeritageID > 0) ? phone.HeritageID : (object)DBNull.Value),
			new SqlParameter("@DeclarationID", (phone.DeclarationID > 0) ? phone.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@ProductionUnitID", (phone.ProductionUnitID > 0) ? phone.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@Number", phone.Number),
			new SqlParameter("@City", (phone.City != null) ? phone.City : (object)DBNull.Value),
			new SqlParameter("@Type", (phone.Type != null) ? phone.Type : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("Phone_Insert", CommandType.StoredProcedure, parametersPhone);
	}

	public bool Update(Phone phone)
	{
		heritageDBAccess.Update(phone);

		SqlParameter[] parametersPhone = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", phone.HeritageID),
			new SqlParameter("@DeclarationID", phone.DeclarationID),
			new SqlParameter("@ProductionUnitID", (phone.ProductionUnitID != null && phone.ProductionUnitID >0 ) ? phone.ProductionUnitID : (object)DBNull.Value),
			new SqlParameter("@Number", phone.Number),
			new SqlParameter("@City", (phone.City != null) ? phone.City : (object)DBNull.Value),
			new SqlParameter("@Type", (phone.Type != null) ? phone.Type : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Phone_Update", CommandType.StoredProcedure, parametersPhone);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersPhone = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("Phone_Delete", CommandType.StoredProcedure, parametersPhone);
	}

	public Phone GetDetails(Int64 heritageID)
	{
		Phone phone = new Phone();

		SqlParameter[] parametersPhone = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Phone_GetDetails", CommandType.StoredProcedure, parametersPhone))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				phone.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
				phone.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
				phone.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
				phone.Number = row["Number"].ToString();
				phone.City = row["City"].ToString();
				phone.Type = (row["Type"] != DBNull.Value) ? Convert.ToBoolean((row["Type"].ToString() == "1" || row["Type"].ToString().ToLower() == "true" ) ? true : false) : false ;

				Heritage heritage = heritageDBAccess.GetDetails(phone.HeritageID);
				phone.HeritageID = heritage.HeritageID;
				phone.StageTitle = heritage.StageTitle;
				phone.RegisterDate = heritage.RegisterDate;
				phone.OldRegisterDate = heritage.OldRegisterDate;
				phone.OldRegisterInformationID = heritage.OldRegisterInformationID;
				phone.Sixth = heritage.Sixth;
				phone.PreviousOwner = heritage.PreviousOwner;
				phone.Comment = heritage.Comment;
				phone.RegisterInformationID = heritage.RegisterInformationID;
				phone.AdjustmentID = heritage.AdjustmentID;
				phone.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				phone.Stage = heritage.Stage;
				phone.UserOrder = heritage.UserOrder;
				phone.Value1 = heritage.Value1;
				phone.Value2 = heritage.Value2;
				phone.Value3 = heritage.Value3;
				phone.DeadIsOwner = heritage.DeadIsOwner;
				phone.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return phone;
	}

	public List<Phone> GetListAll()
	{
		List<Phone> listPhone = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Phone_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listPhone = new List<Phone>();

				foreach (DataRow row in table.Rows)
				{
					Phone phone = new Phone();
					phone.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					phone.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					phone.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					phone.Number = row["Number"].ToString();
					phone.City = row["City"].ToString();
				phone.Type = (row["Type"] != DBNull.Value) ? Convert.ToBoolean((row["Type"].ToString() == "1" || row["Type"].ToString().ToLower() == "true" ) ? true : false) : false ;

					Heritage heritage = heritageDBAccess.GetDetails(phone.HeritageID);
					phone.StageTitle = heritage.StageTitle;
					phone.RegisterDate = heritage.RegisterDate;
					phone.OldRegisterDate = heritage.OldRegisterDate;
					phone.OldRegisterInformationID = heritage.OldRegisterInformationID;
					phone.Sixth = heritage.Sixth;
					phone.PreviousOwner = heritage.PreviousOwner;
					phone.Comment = heritage.Comment;
					phone.RegisterInformationID = heritage.RegisterInformationID;
					phone.AdjustmentID = heritage.AdjustmentID;
					phone.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					phone.Stage = heritage.Stage;
					phone.UserOrder = heritage.UserOrder;
					phone.Value1 = heritage.Value1;
					phone.Value2 = heritage.Value2;
					phone.Value3 = heritage.Value3;
					phone.DeadIsOwner = heritage.DeadIsOwner;
					phone.IsDiagonesed = heritage.IsDiagonesed;
					listPhone.Add(phone);
				}
			}
		}

		return listPhone;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersPhone = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Phone_Exists", CommandType.StoredProcedure, parametersPhone)>0);
	}

	public bool Exists(Phone phone)
	{
		SqlParameter[] parametersPhone = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", phone.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("Phone_Exists", CommandType.StoredProcedure, parametersPhone)>0);
	}

	public List<Phone> SearchLike(Phone phone)
	{
		List<Phone> listPhone = new List<Phone>();


		SqlParameter[] parametersPhone = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", phone.HeritageID),
			new SqlParameter("@DeclarationID", phone.DeclarationID),
			new SqlParameter("@ProductionUnitID", phone.ProductionUnitID),
			new SqlParameter("@Number", phone.Number),
			new SqlParameter("@City", phone.City),
			new SqlParameter("@Type", phone.Type),

			new SqlParameter("@StageTitle", phone.StageTitle),
			new SqlParameter("@RegisterDate", phone.RegisterDate),
			new SqlParameter("@OldRegisterDate", phone.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", phone.OldRegisterInformationID),
			new SqlParameter("@Sixth", phone.Sixth),
			new SqlParameter("@PreviousOwner", phone.PreviousOwner),
			new SqlParameter("@Comment", phone.Comment),
			new SqlParameter("@RegisterInformationID", phone.RegisterInformationID),
			new SqlParameter("@AdjustmentID", phone.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", phone.CommissionAdjustmentID),
			new SqlParameter("@Stage", phone.Stage),
			new SqlParameter("@UserOrder", phone.UserOrder),
			new SqlParameter("@Value1", phone.Value1),
			new SqlParameter("@Value2", phone.Value2),
			new SqlParameter("@Value3", phone.Value3),
			new SqlParameter("@DeadIsOwner", phone.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", phone.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Phone_SearchLike", CommandType.StoredProcedure, parametersPhone))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Phone tmpPhone = new Phone();
					tmpPhone.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpPhone.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpPhone.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
					tmpPhone.Number = row["Number"].ToString();
					tmpPhone.City = row["City"].ToString();
					tmpPhone.Type = (row["Type"] != DBNull.Value) ? Convert.ToBoolean((row["Type"].ToString() == "1" || row["Type"].ToString().ToLower() == "true" ) ? true : false) : false ;

					Heritage heritage = heritageDBAccess.GetDetails(tmpPhone.HeritageID);
					tmpPhone.HeritageID = heritage.HeritageID;
					tmpPhone.StageTitle = heritage.StageTitle;
					tmpPhone.RegisterDate = heritage.RegisterDate;
					tmpPhone.OldRegisterDate = heritage.OldRegisterDate;
					tmpPhone.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpPhone.Sixth = heritage.Sixth;
					tmpPhone.PreviousOwner = heritage.PreviousOwner;
					tmpPhone.Comment = heritage.Comment;
					tmpPhone.RegisterInformationID = heritage.RegisterInformationID;
					tmpPhone.AdjustmentID = heritage.AdjustmentID;
					tmpPhone.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpPhone.Stage = heritage.Stage;
					tmpPhone.UserOrder = heritage.UserOrder;
					tmpPhone.Value1 = heritage.Value1;
					tmpPhone.Value2 = heritage.Value2;
					tmpPhone.Value3 = heritage.Value3;
					tmpPhone.DeadIsOwner = heritage.DeadIsOwner;
					tmpPhone.IsDiagonesed = heritage.IsDiagonesed;

					listPhone.Add(tmpPhone);
				}
			}
		}

		return listPhone;
	}

}
}
