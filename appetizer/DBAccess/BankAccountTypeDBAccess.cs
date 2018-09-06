using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class BankAccountTypeDBAccess
{

	BankDepositDBAccess bankDepositDBAccess = new BankDepositDBAccess();
	BankDepositProfitDBAccess bankDepositProfitDBAccess = new BankDepositProfitDBAccess();

	public List<BankDeposit> GetListBankDeposit(int bankAccountTypeID)
	{
		List<BankDeposit> listBankDeposit = new List<BankDeposit>() { };
		SqlParameter[] parametersBankAccountType = new SqlParameter[]
		{
			new SqlParameter("@BankAccountTypeID", bankAccountTypeID)
		};

		//Lets get the list of BankDeposit records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BankDeposit_GetList_UseInBankAccountType", CommandType.StoredProcedure, parametersBankAccountType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of bankDeposit
				listBankDeposit = new List<BankDeposit>();

				//Now lets populate the BankDeposit details into the list of bankDeposits
				foreach (DataRow row in table.Rows)
				{
					BankDeposit bankDeposit = ConvertRowToBankDeposit(row);
					listBankDeposit.Add(bankDeposit);
				}
			}
		}

		return listBankDeposit;
	}

	private BankDeposit ConvertRowToBankDeposit(DataRow row)
	{
		BankDeposit bankDeposit = new BankDeposit();
		bankDeposit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		bankDeposit.BankIDTitle = row["BankIDTitle"].ToString();
		bankDeposit.BankAccountTypeIDTitle = row["BankAccountTypeIDTitle"].ToString();
		bankDeposit.BankCategoryIDTitle = row["BankCategoryIDTitle"].ToString();
		bankDeposit.BankTypeIDTitle = row["BankTypeIDTitle"].ToString();
		bankDeposit.BankCategoryID = (row["BankCategoryID"] != DBNull.Value) ? Convert.ToInt64(row["BankCategoryID"]) : 0 ;
		bankDeposit.BankTypeID = (row["BankTypeID"] != DBNull.Value) ? Convert.ToInt64(row["BankTypeID"]) : 0 ;
		bankDeposit.Branch = row["Branch"].ToString();
		bankDeposit.City = row["City"].ToString();
		bankDeposit.AccountNumber = row["AccountNumber"].ToString();
		bankDeposit.BankAccountTypeID = (row["BankAccountTypeID"] != DBNull.Value) ? Convert.ToInt32(row["BankAccountTypeID"]) : 0 ;
		bankDeposit.CurrencyDeposit = (row["CurrencyDeposit"] != DBNull.Value) ? Convert.ToSingle(row["CurrencyDeposit"]) : 0 ;
		bankDeposit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		bankDeposit.BankID = (row["BankID"] != DBNull.Value) ? Convert.ToInt64(row["BankID"]) : 0 ;

		bankDeposit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		bankDeposit.StageTitle = row["StageTitle"].ToString();
		bankDeposit.RegisterDate = row["RegisterDate"].ToString();
		bankDeposit.OldRegisterDate = row["OldRegisterDate"].ToString();
		bankDeposit.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		bankDeposit.Sixth = row["Sixth"].ToString();
		bankDeposit.PreviousOwner = row["PreviousOwner"].ToString();
		bankDeposit.Comment = row["Comment"].ToString();
		bankDeposit.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		bankDeposit.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		bankDeposit.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		bankDeposit.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		bankDeposit.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		bankDeposit.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		bankDeposit.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		bankDeposit.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		bankDeposit.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		bankDeposit.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return bankDeposit;
	}
	public List<BankDepositProfit> GetListBankDepositProfit(int bankAccountTypeID)
	{
		List<BankDepositProfit> listBankDepositProfit = new List<BankDepositProfit>() { };
		SqlParameter[] parametersBankAccountType = new SqlParameter[]
		{
			new SqlParameter("@BankAccountTypeID", bankAccountTypeID)
		};

		//Lets get the list of BankDepositProfit records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BankDepositProfit_GetList_UseInBankAccountType", CommandType.StoredProcedure, parametersBankAccountType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of bankDepositProfit
				listBankDepositProfit = new List<BankDepositProfit>();

				//Now lets populate the BankDepositProfit details into the list of bankDepositProfits
				foreach (DataRow row in table.Rows)
				{
					BankDepositProfit bankDepositProfit = ConvertRowToBankDepositProfit(row);
					listBankDepositProfit.Add(bankDepositProfit);
				}
			}
		}

		return listBankDepositProfit;
	}

	private BankDepositProfit ConvertRowToBankDepositProfit(DataRow row)
	{
		BankDepositProfit bankDepositProfit = new BankDepositProfit();
		bankDepositProfit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		bankDepositProfit.BankIDTitle = row["BankIDTitle"].ToString();
		bankDepositProfit.BankAccountTypeIDTitle = row["BankAccountTypeIDTitle"].ToString();
		bankDepositProfit.BankCategoryIDTitle = row["BankCategoryIDTitle"].ToString();
		bankDepositProfit.BankTypeIDTitle = row["BankTypeIDTitle"].ToString();
		bankDepositProfit.BankCategoryID = (row["BankCategoryID"] != DBNull.Value) ? Convert.ToInt64(row["BankCategoryID"]) : 0 ;
		bankDepositProfit.BankTypeID = (row["BankTypeID"] != DBNull.Value) ? Convert.ToInt64(row["BankTypeID"]) : 0 ;
		bankDepositProfit.Branch = row["Branch"].ToString();
		bankDepositProfit.City = row["City"].ToString();
		bankDepositProfit.AccountNumber = row["AccountNumber"].ToString();
		bankDepositProfit.BankAccountTypeID = (row["BankAccountTypeID"] != DBNull.Value) ? Convert.ToInt32(row["BankAccountTypeID"]) : 0 ;
		bankDepositProfit.CurrencyDeposit = (row["CurrencyDeposit"] != DBNull.Value) ? Convert.ToSingle(row["CurrencyDeposit"]) : 0 ;
		bankDepositProfit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		bankDepositProfit.BankID = (row["BankID"] != DBNull.Value) ? Convert.ToInt64(row["BankID"]) : 0 ;

		bankDepositProfit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
		bankDepositProfit.StageTitle = row["StageTitle"].ToString();
		bankDepositProfit.RegisterDate = row["RegisterDate"].ToString();
		bankDepositProfit.OldRegisterDate = row["OldRegisterDate"].ToString();
		bankDepositProfit.OldRegisterInformationID = row["OldRegisterInformationID"].ToString();
		bankDepositProfit.Sixth = row["Sixth"].ToString();
		bankDepositProfit.PreviousOwner = row["PreviousOwner"].ToString();
		bankDepositProfit.Comment = row["Comment"].ToString();
		bankDepositProfit.RegisterInformationID = (row["RegisterInformationID"] != DBNull.Value) ? Convert.ToInt64(row["RegisterInformationID"]) : 0 ;
		bankDepositProfit.AdjustmentID = (row["AdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["AdjustmentID"]) : 0 ;
		bankDepositProfit.CommissionAdjustmentID = (row["CommissionAdjustmentID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionAdjustmentID"]) : 0 ;
		bankDepositProfit.Stage = (row["Stage"] != DBNull.Value) ? Convert.ToInt32(row["Stage"]) : 0 ;
		bankDepositProfit.UserOrder = (row["UserOrder"] != DBNull.Value) ? Convert.ToInt32(row["UserOrder"]) : 0 ;
		bankDepositProfit.Value1 = (row["Value1"] != DBNull.Value) ? Convert.ToSingle(row["Value1"]) : 0 ;
		bankDepositProfit.Value2 = (row["Value2"] != DBNull.Value) ? Convert.ToSingle(row["Value2"]) : 0 ;
		bankDepositProfit.Value3 = (row["Value3"] != DBNull.Value) ? Convert.ToSingle(row["Value3"]) : 0 ;
		bankDepositProfit.DeadIsOwner = (row["DeadIsOwner"] != DBNull.Value) ? Convert.ToBoolean((row["DeadIsOwner"].ToString() == "1" || row["DeadIsOwner"].ToString().ToLower() == "true" ) ? true : false) : false ;
		bankDepositProfit.IsDiagonesed = (row["IsDiagonesed"] != DBNull.Value) ? Convert.ToBoolean((row["IsDiagonesed"].ToString() == "1" || row["IsDiagonesed"].ToString().ToLower() == "true" ) ? true : false) : false ;
		return bankDepositProfit;
	}
	public Int64 Insert(BankAccountType bankAccountType)
	{
		SqlParameter[] parametersBankAccountType = new SqlParameter[]
		{
			new SqlParameter("@Title", (bankAccountType.Title != null) ? bankAccountType.Title : (object)DBNull.Value)
		};
		bankAccountType.BankAccountTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("BankAccountType_Insert", CommandType.StoredProcedure, parametersBankAccountType));
		return bankAccountType.BankAccountTypeID;
	}

	public bool Update(BankAccountType bankAccountType)
	{
		SqlParameter[] parametersBankAccountType = new SqlParameter[]
		{
			new SqlParameter("@BankAccountTypeID", bankAccountType.BankAccountTypeID),
			new SqlParameter("@Title", (bankAccountType.Title != null) ? bankAccountType.Title : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("BankAccountType_Update", CommandType.StoredProcedure, parametersBankAccountType);
	}

	public bool Delete(int bankAccountTypeID)
	{
		SqlParameter[] parametersBankAccountType = new SqlParameter[]
		{
			new SqlParameter("@BankAccountTypeID", bankAccountTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("BankAccountType_Delete", CommandType.StoredProcedure, parametersBankAccountType);
	}

	public BankAccountType GetDetails(int bankAccountTypeID)
	{
		BankAccountType bankAccountType = new BankAccountType();

		SqlParameter[] parametersBankAccountType = new SqlParameter[]
		{
			new SqlParameter("@BankAccountTypeID", bankAccountTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BankAccountType_GetDetails", CommandType.StoredProcedure, parametersBankAccountType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				bankAccountType.BankAccountTypeID = (row["BankAccountTypeID"] != DBNull.Value) ? Convert.ToInt32(row["BankAccountTypeID"]) : 0 ;
				bankAccountType.Title = row["Title"].ToString();
			}
		}

		return bankAccountType;
	}

	public List<BankAccountType> GetListAll()
	{
		List<BankAccountType> listBankAccountType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("BankAccountType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listBankAccountType = new List<BankAccountType>();

				foreach (DataRow row in table.Rows)
				{
					BankAccountType bankAccountType = new BankAccountType();
					bankAccountType.BankAccountTypeID = (row["BankAccountTypeID"] != DBNull.Value) ? Convert.ToInt32(row["BankAccountTypeID"]) : 0 ;
					bankAccountType.Title = row["Title"].ToString();
					listBankAccountType.Add(bankAccountType);
				}
			}
		}

		return listBankAccountType;
	}

	public bool Exists(int bankAccountTypeID)
	{
		SqlParameter[] parametersBankAccountType = new SqlParameter[]
		{
			new SqlParameter("@BankAccountTypeID", bankAccountTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("BankAccountType_Exists", CommandType.StoredProcedure, parametersBankAccountType)>0);
	}

	public bool Exists(BankAccountType bankAccountType)
	{
		SqlParameter[] parametersBankAccountType = new SqlParameter[]
		{
			new SqlParameter("@BankAccountTypeID", bankAccountType.BankAccountTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("BankAccountType_Exists", CommandType.StoredProcedure, parametersBankAccountType)>0);
	}

	public List<BankAccountType> SearchLike(BankAccountType bankAccountType)
	{
		List<BankAccountType> listBankAccountType = new List<BankAccountType>();


		SqlParameter[] parametersBankAccountType = new SqlParameter[]
		{
			new SqlParameter("@BankAccountTypeID", bankAccountType.BankAccountTypeID),
			new SqlParameter("@Title", bankAccountType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BankAccountType_SearchLike", CommandType.StoredProcedure, parametersBankAccountType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					BankAccountType tmpBankAccountType = new BankAccountType();
					tmpBankAccountType.BankAccountTypeID = (row["BankAccountTypeID"] != DBNull.Value) ? Convert.ToInt32(row["BankAccountTypeID"]) : 0 ;
					tmpBankAccountType.Title = row["Title"].ToString();

					listBankAccountType.Add(tmpBankAccountType);
				}
			}
		}

		return listBankAccountType;
	}

}
}
