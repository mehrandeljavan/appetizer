using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class BankDepositProfitDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(BankDepositProfit bankDepositProfit)
	{
		if (!heritageDBAccess.Exists(bankDepositProfit))
			bankDepositProfit.HeritageID = heritageDBAccess.Insert(bankDepositProfit);

		SqlParameter[] parametersBankDepositProfit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (bankDepositProfit.HeritageID > 0) ? bankDepositProfit.HeritageID : (object)DBNull.Value),
			new SqlParameter("@BankCategoryID", (bankDepositProfit.BankCategoryID > 0) ? bankDepositProfit.BankCategoryID : (object)DBNull.Value),
			new SqlParameter("@BankTypeID", (bankDepositProfit.BankTypeID > 0) ? bankDepositProfit.BankTypeID : (object)DBNull.Value),
			new SqlParameter("@Branch", bankDepositProfit.Branch),
			new SqlParameter("@City", bankDepositProfit.City),
			new SqlParameter("@AccountNumber", bankDepositProfit.AccountNumber),
			new SqlParameter("@BankAccountTypeID", (bankDepositProfit.BankAccountTypeID > 0) ? bankDepositProfit.BankAccountTypeID : (object)DBNull.Value),
			new SqlParameter("@CurrencyDeposit", bankDepositProfit.CurrencyDeposit),
			new SqlParameter("@DeclarationID", (bankDepositProfit.DeclarationID > 0) ? bankDepositProfit.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@BankID", (bankDepositProfit.BankID > 0) ? bankDepositProfit.BankID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("BankDepositProfit_Insert", CommandType.StoredProcedure, parametersBankDepositProfit);
	}

	public bool Update(BankDepositProfit bankDepositProfit)
	{
		heritageDBAccess.Update(bankDepositProfit);

		SqlParameter[] parametersBankDepositProfit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", bankDepositProfit.HeritageID),
			new SqlParameter("@BankCategoryID", (bankDepositProfit.BankCategoryID != null && bankDepositProfit.BankCategoryID >0 ) ? bankDepositProfit.BankCategoryID : (object)DBNull.Value),
			new SqlParameter("@BankTypeID", (bankDepositProfit.BankTypeID != null && bankDepositProfit.BankTypeID >0 ) ? bankDepositProfit.BankTypeID : (object)DBNull.Value),
			new SqlParameter("@Branch", bankDepositProfit.Branch),
			new SqlParameter("@City", bankDepositProfit.City),
			new SqlParameter("@AccountNumber", bankDepositProfit.AccountNumber),
			new SqlParameter("@BankAccountTypeID", (bankDepositProfit.BankAccountTypeID != null && bankDepositProfit.BankAccountTypeID >0 ) ? bankDepositProfit.BankAccountTypeID : (object)DBNull.Value),
			new SqlParameter("@CurrencyDeposit", bankDepositProfit.CurrencyDeposit),
			new SqlParameter("@DeclarationID", bankDepositProfit.DeclarationID),
			new SqlParameter("@BankID", (bankDepositProfit.BankID != null && bankDepositProfit.BankID >0 ) ? bankDepositProfit.BankID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("BankDepositProfit_Update", CommandType.StoredProcedure, parametersBankDepositProfit);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersBankDepositProfit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("BankDepositProfit_Delete", CommandType.StoredProcedure, parametersBankDepositProfit);
	}

	public BankDepositProfit GetDetails(Int64 heritageID)
	{
		BankDepositProfit bankDepositProfit = new BankDepositProfit();

		SqlParameter[] parametersBankDepositProfit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BankDepositProfit_GetDetails", CommandType.StoredProcedure, parametersBankDepositProfit))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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

				Heritage heritage = heritageDBAccess.GetDetails(bankDepositProfit.HeritageID);
				bankDepositProfit.HeritageID = heritage.HeritageID;
				bankDepositProfit.StageTitle = heritage.StageTitle;
				bankDepositProfit.RegisterDate = heritage.RegisterDate;
				bankDepositProfit.OldRegisterDate = heritage.OldRegisterDate;
				bankDepositProfit.OldRegisterInformationID = heritage.OldRegisterInformationID;
				bankDepositProfit.Sixth = heritage.Sixth;
				bankDepositProfit.PreviousOwner = heritage.PreviousOwner;
				bankDepositProfit.Comment = heritage.Comment;
				bankDepositProfit.RegisterInformationID = heritage.RegisterInformationID;
				bankDepositProfit.AdjustmentID = heritage.AdjustmentID;
				bankDepositProfit.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				bankDepositProfit.Stage = heritage.Stage;
				bankDepositProfit.UserOrder = heritage.UserOrder;
				bankDepositProfit.Value1 = heritage.Value1;
				bankDepositProfit.Value2 = heritage.Value2;
				bankDepositProfit.Value3 = heritage.Value3;
				bankDepositProfit.DeadIsOwner = heritage.DeadIsOwner;
				bankDepositProfit.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return bankDepositProfit;
	}

	public List<BankDepositProfit> GetListAll()
	{
		List<BankDepositProfit> listBankDepositProfit = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("BankDepositProfit_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listBankDepositProfit = new List<BankDepositProfit>();

				foreach (DataRow row in table.Rows)
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

					Heritage heritage = heritageDBAccess.GetDetails(bankDepositProfit.HeritageID);
					bankDepositProfit.StageTitle = heritage.StageTitle;
					bankDepositProfit.RegisterDate = heritage.RegisterDate;
					bankDepositProfit.OldRegisterDate = heritage.OldRegisterDate;
					bankDepositProfit.OldRegisterInformationID = heritage.OldRegisterInformationID;
					bankDepositProfit.Sixth = heritage.Sixth;
					bankDepositProfit.PreviousOwner = heritage.PreviousOwner;
					bankDepositProfit.Comment = heritage.Comment;
					bankDepositProfit.RegisterInformationID = heritage.RegisterInformationID;
					bankDepositProfit.AdjustmentID = heritage.AdjustmentID;
					bankDepositProfit.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					bankDepositProfit.Stage = heritage.Stage;
					bankDepositProfit.UserOrder = heritage.UserOrder;
					bankDepositProfit.Value1 = heritage.Value1;
					bankDepositProfit.Value2 = heritage.Value2;
					bankDepositProfit.Value3 = heritage.Value3;
					bankDepositProfit.DeadIsOwner = heritage.DeadIsOwner;
					bankDepositProfit.IsDiagonesed = heritage.IsDiagonesed;
					listBankDepositProfit.Add(bankDepositProfit);
				}
			}
		}

		return listBankDepositProfit;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersBankDepositProfit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("BankDepositProfit_Exists", CommandType.StoredProcedure, parametersBankDepositProfit)>0);
	}

	public bool Exists(BankDepositProfit bankDepositProfit)
	{
		SqlParameter[] parametersBankDepositProfit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", bankDepositProfit.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("BankDepositProfit_Exists", CommandType.StoredProcedure, parametersBankDepositProfit)>0);
	}

	public List<BankDepositProfit> SearchLike(BankDepositProfit bankDepositProfit)
	{
		List<BankDepositProfit> listBankDepositProfit = new List<BankDepositProfit>();


		SqlParameter[] parametersBankDepositProfit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", bankDepositProfit.HeritageID),
			new SqlParameter("@BankIDTitle", bankDepositProfit.BankIDTitle),
			new SqlParameter("@BankAccountTypeIDTitle", bankDepositProfit.BankAccountTypeIDTitle),
			new SqlParameter("@BankCategoryIDTitle", bankDepositProfit.BankCategoryIDTitle),
			new SqlParameter("@BankTypeIDTitle", bankDepositProfit.BankTypeIDTitle),
			new SqlParameter("@BankCategoryID", bankDepositProfit.BankCategoryID),
			new SqlParameter("@BankTypeID", bankDepositProfit.BankTypeID),
			new SqlParameter("@Branch", bankDepositProfit.Branch),
			new SqlParameter("@City", bankDepositProfit.City),
			new SqlParameter("@AccountNumber", bankDepositProfit.AccountNumber),
			new SqlParameter("@BankAccountTypeID", bankDepositProfit.BankAccountTypeID),
			new SqlParameter("@CurrencyDeposit", bankDepositProfit.CurrencyDeposit),
			new SqlParameter("@DeclarationID", bankDepositProfit.DeclarationID),
			new SqlParameter("@BankID", bankDepositProfit.BankID),

			new SqlParameter("@StageTitle", bankDepositProfit.StageTitle),
			new SqlParameter("@RegisterDate", bankDepositProfit.RegisterDate),
			new SqlParameter("@OldRegisterDate", bankDepositProfit.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", bankDepositProfit.OldRegisterInformationID),
			new SqlParameter("@Sixth", bankDepositProfit.Sixth),
			new SqlParameter("@PreviousOwner", bankDepositProfit.PreviousOwner),
			new SqlParameter("@Comment", bankDepositProfit.Comment),
			new SqlParameter("@RegisterInformationID", bankDepositProfit.RegisterInformationID),
			new SqlParameter("@AdjustmentID", bankDepositProfit.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", bankDepositProfit.CommissionAdjustmentID),
			new SqlParameter("@Stage", bankDepositProfit.Stage),
			new SqlParameter("@UserOrder", bankDepositProfit.UserOrder),
			new SqlParameter("@Value1", bankDepositProfit.Value1),
			new SqlParameter("@Value2", bankDepositProfit.Value2),
			new SqlParameter("@Value3", bankDepositProfit.Value3),
			new SqlParameter("@DeadIsOwner", bankDepositProfit.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", bankDepositProfit.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BankDepositProfit_SearchLike", CommandType.StoredProcedure, parametersBankDepositProfit))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					BankDepositProfit tmpBankDepositProfit = new BankDepositProfit();
					tmpBankDepositProfit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpBankDepositProfit.BankIDTitle = row["BankIDTitle"].ToString();
					tmpBankDepositProfit.BankAccountTypeIDTitle = row["BankAccountTypeIDTitle"].ToString();
					tmpBankDepositProfit.BankCategoryIDTitle = row["BankCategoryIDTitle"].ToString();
					tmpBankDepositProfit.BankTypeIDTitle = row["BankTypeIDTitle"].ToString();
					tmpBankDepositProfit.BankCategoryID = (row["BankCategoryID"] != DBNull.Value) ? Convert.ToInt64(row["BankCategoryID"]) : 0 ;
					tmpBankDepositProfit.BankTypeID = (row["BankTypeID"] != DBNull.Value) ? Convert.ToInt64(row["BankTypeID"]) : 0 ;
					tmpBankDepositProfit.Branch = row["Branch"].ToString();
					tmpBankDepositProfit.City = row["City"].ToString();
					tmpBankDepositProfit.AccountNumber = row["AccountNumber"].ToString();
					tmpBankDepositProfit.BankAccountTypeID = (row["BankAccountTypeID"] != DBNull.Value) ? Convert.ToInt32(row["BankAccountTypeID"]) : 0 ;
					tmpBankDepositProfit.CurrencyDeposit = (row["CurrencyDeposit"] != DBNull.Value) ? Convert.ToSingle(row["CurrencyDeposit"]) : 0 ;
					tmpBankDepositProfit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpBankDepositProfit.BankID = (row["BankID"] != DBNull.Value) ? Convert.ToInt64(row["BankID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(tmpBankDepositProfit.HeritageID);
					tmpBankDepositProfit.HeritageID = heritage.HeritageID;
					tmpBankDepositProfit.StageTitle = heritage.StageTitle;
					tmpBankDepositProfit.RegisterDate = heritage.RegisterDate;
					tmpBankDepositProfit.OldRegisterDate = heritage.OldRegisterDate;
					tmpBankDepositProfit.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpBankDepositProfit.Sixth = heritage.Sixth;
					tmpBankDepositProfit.PreviousOwner = heritage.PreviousOwner;
					tmpBankDepositProfit.Comment = heritage.Comment;
					tmpBankDepositProfit.RegisterInformationID = heritage.RegisterInformationID;
					tmpBankDepositProfit.AdjustmentID = heritage.AdjustmentID;
					tmpBankDepositProfit.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpBankDepositProfit.Stage = heritage.Stage;
					tmpBankDepositProfit.UserOrder = heritage.UserOrder;
					tmpBankDepositProfit.Value1 = heritage.Value1;
					tmpBankDepositProfit.Value2 = heritage.Value2;
					tmpBankDepositProfit.Value3 = heritage.Value3;
					tmpBankDepositProfit.DeadIsOwner = heritage.DeadIsOwner;
					tmpBankDepositProfit.IsDiagonesed = heritage.IsDiagonesed;

					listBankDepositProfit.Add(tmpBankDepositProfit);
				}
			}
		}

		return listBankDepositProfit;
	}

}
}
