using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class DebtsTypeDBAccess
{

	DebtsDBAccess debtsDBAccess = new DebtsDBAccess();

	public List<Debts> GetListDebts(int debtsTypeID)
	{
		List<Debts> listDebts = new List<Debts>() { };
		SqlParameter[] parametersDebtsType = new SqlParameter[]
		{
			new SqlParameter("@DebtsTypeID", debtsTypeID)
		};

		//Lets get the list of Debts records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Debts_GetList_UseInDebtsType", CommandType.StoredProcedure, parametersDebtsType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of debts
				listDebts = new List<Debts>();

				//Now lets populate the Debts details into the list of debtss
				foreach (DataRow row in table.Rows)
				{
					Debts debts = ConvertRowToDebts(row);
					listDebts.Add(debts);
				}
			}
		}

		return listDebts;
	}

	private Debts ConvertRowToDebts(DataRow row)
	{
		Debts debts = new Debts();
		debts.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		debts.DebtsTypeIDTitle = row["DebtsTypeIDTitle"].ToString();
		debts.DebtsTypeID = (row["DebtsTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DebtsTypeID"]) : 0 ;
		debts.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		debts.ProductionUnitID = (row["ProductionUnitID"] != DBNull.Value) ? Convert.ToInt64(row["ProductionUnitID"]) : 0 ;
		debts.CreditorName = row["CreditorName"].ToString();
		debts.CreditorAddress = row["CreditorAddress"].ToString();
		debts.DebtResource = row["DebtResource"].ToString();

		debts.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		debts.StageTitle = row["StageTitle"].ToString();
		debts.RegisterDate = row["RegisterDate"].ToString();
		debts.OldRegisterDate = row["OldRegisterDate"].ToString();
		debts.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		debts.Sixth = row["Sixth"].ToString();
		debts.PreviousOwner = row["PreviousOwner"].ToString();
		debts.Comment = row["Comment"].ToString();
		debts.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		debts.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		debts.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		debts.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		debts.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		debts.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		debts.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		debts.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		debts.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		debts.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return debts;
	}
	public Int64 Insert(DebtsType debtsType)
	{
		SqlParameter[] parametersDebtsType = new SqlParameter[]
		{
			new SqlParameter("@Title", debtsType.Title)
		};
		debtsType.DebtsTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("DebtsType_Insert", CommandType.StoredProcedure, parametersDebtsType));
		return debtsType.DebtsTypeID;
	}

	public bool Update(DebtsType debtsType)
	{
		SqlParameter[] parametersDebtsType = new SqlParameter[]
		{
			new SqlParameter("@DebtsTypeID", debtsType.DebtsTypeID),
			new SqlParameter("@Title", debtsType.Title)
		};
		return SqlDBHelper.ExecuteNonQuery("DebtsType_Update", CommandType.StoredProcedure, parametersDebtsType);
	}

	public bool Delete(int debtsTypeID)
	{
		SqlParameter[] parametersDebtsType = new SqlParameter[]
		{
			new SqlParameter("@DebtsTypeID", debtsTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("DebtsType_Delete", CommandType.StoredProcedure, parametersDebtsType);
	}

	public DebtsType GetDetails(int debtsTypeID)
	{
		DebtsType debtsType = new DebtsType();

		SqlParameter[] parametersDebtsType = new SqlParameter[]
		{
			new SqlParameter("@DebtsTypeID", debtsTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DebtsType_GetDetails", CommandType.StoredProcedure, parametersDebtsType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				debtsType.DebtsTypeID = (row["DebtsTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DebtsTypeID"]) : 0 ;
				debtsType.Title = row["Title"].ToString();
			}
		}

		return debtsType;
	}

	public List<DebtsType> GetListAll()
	{
		List<DebtsType> listDebtsType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("DebtsType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listDebtsType = new List<DebtsType>();

				foreach (DataRow row in table.Rows)
				{
					DebtsType debtsType = new DebtsType();
					debtsType.DebtsTypeID = (row["DebtsTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DebtsTypeID"]) : 0 ;
					debtsType.Title = row["Title"].ToString();
					listDebtsType.Add(debtsType);
				}
			}
		}

		return listDebtsType;
	}

	public bool Exists(int debtsTypeID)
	{
		SqlParameter[] parametersDebtsType = new SqlParameter[]
		{
			new SqlParameter("@DebtsTypeID", debtsTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("DebtsType_Exists", CommandType.StoredProcedure, parametersDebtsType)>0);
	}

	public bool Exists(DebtsType debtsType)
	{
		SqlParameter[] parametersDebtsType = new SqlParameter[]
		{
			new SqlParameter("@DebtsTypeID", debtsType.DebtsTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("DebtsType_Exists", CommandType.StoredProcedure, parametersDebtsType)>0);
	}

	public List<DebtsType> SearchLike(DebtsType debtsType)
	{
		List<DebtsType> listDebtsType = new List<DebtsType>();


		SqlParameter[] parametersDebtsType = new SqlParameter[]
		{
			new SqlParameter("@DebtsTypeID", debtsType.DebtsTypeID),
			new SqlParameter("@Title", debtsType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("DebtsType_SearchLike", CommandType.StoredProcedure, parametersDebtsType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					DebtsType tmpDebtsType = new DebtsType();
					tmpDebtsType.DebtsTypeID = (row["DebtsTypeID"] != DBNull.Value) ? Convert.ToInt32(row["DebtsTypeID"]) : 0 ;
					tmpDebtsType.Title = row["Title"].ToString();

					listDebtsType.Add(tmpDebtsType);
				}
			}
		}

		return listDebtsType;
	}

}
}
