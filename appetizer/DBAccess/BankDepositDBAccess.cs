using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class BankDepositDBAccess
{
	HeritageDBAccess heritageDBAccess = new HeritageDBAccess();


	public Int64 Insert(BankDeposit bankDeposit)
	{
		if (!heritageDBAccess.Exists(bankDeposit))
			bankDeposit.HeritageID = heritageDBAccess.Insert(bankDeposit);

		SqlParameter[] parametersBankDeposit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", (bankDeposit.HeritageID > 0) ? bankDeposit.HeritageID : (object)DBNull.Value),
			new SqlParameter("@BankCategoryID", (bankDeposit.BankCategoryID > 0) ? bankDeposit.BankCategoryID : (object)DBNull.Value),
			new SqlParameter("@BankTypeID", (bankDeposit.BankTypeID > 0) ? bankDeposit.BankTypeID : (object)DBNull.Value),
			new SqlParameter("@Branch", bankDeposit.Branch),
			new SqlParameter("@City", bankDeposit.City),
			new SqlParameter("@AccountNumber", bankDeposit.AccountNumber),
			new SqlParameter("@BankAccountTypeID", (bankDeposit.BankAccountTypeID > 0) ? bankDeposit.BankAccountTypeID : (object)DBNull.Value),
			new SqlParameter("@CurrencyDeposit", bankDeposit.CurrencyDeposit),
			new SqlParameter("@DeclarationID", (bankDeposit.DeclarationID > 0) ? bankDeposit.DeclarationID : (object)DBNull.Value),
			new SqlParameter("@BankID", (bankDeposit.BankID > 0) ? bankDeposit.BankID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("BankDeposit_Insert", CommandType.StoredProcedure, parametersBankDeposit);
	}

	public bool Update(BankDeposit bankDeposit)
	{
		heritageDBAccess.Update(bankDeposit);

		SqlParameter[] parametersBankDeposit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", bankDeposit.HeritageID),
			new SqlParameter("@BankCategoryID", (bankDeposit.BankCategoryID != null && bankDeposit.BankCategoryID >0 ) ? bankDeposit.BankCategoryID : (object)DBNull.Value),
			new SqlParameter("@BankTypeID", (bankDeposit.BankTypeID != null && bankDeposit.BankTypeID >0 ) ? bankDeposit.BankTypeID : (object)DBNull.Value),
			new SqlParameter("@Branch", bankDeposit.Branch),
			new SqlParameter("@City", bankDeposit.City),
			new SqlParameter("@AccountNumber", bankDeposit.AccountNumber),
			new SqlParameter("@BankAccountTypeID", (bankDeposit.BankAccountTypeID != null && bankDeposit.BankAccountTypeID >0 ) ? bankDeposit.BankAccountTypeID : (object)DBNull.Value),
			new SqlParameter("@CurrencyDeposit", bankDeposit.CurrencyDeposit),
			new SqlParameter("@DeclarationID", bankDeposit.DeclarationID),
			new SqlParameter("@BankID", (bankDeposit.BankID != null && bankDeposit.BankID >0 ) ? bankDeposit.BankID : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("BankDeposit_Update", CommandType.StoredProcedure, parametersBankDeposit);
	}

	public bool Delete(Int64 heritageID)
	{
		SqlParameter[] parametersBankDeposit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return SqlDBHelper.ExecuteNonQuery("BankDeposit_Delete", CommandType.StoredProcedure, parametersBankDeposit);
	}

	public BankDeposit GetDetails(Int64 heritageID)
	{
		BankDeposit bankDeposit = new BankDeposit();

		SqlParameter[] parametersBankDeposit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BankDeposit_GetDetails", CommandType.StoredProcedure, parametersBankDeposit))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

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

				Heritage heritage = heritageDBAccess.GetDetails(bankDeposit.HeritageID);
				bankDeposit.HeritageID = heritage.HeritageID;
				bankDeposit.StageTitle = heritage.StageTitle;
				bankDeposit.RegisterDate = heritage.RegisterDate;
				bankDeposit.OldRegisterDate = heritage.OldRegisterDate;
				bankDeposit.OldRegisterInformationID = heritage.OldRegisterInformationID;
				bankDeposit.Sixth = heritage.Sixth;
				bankDeposit.PreviousOwner = heritage.PreviousOwner;
				bankDeposit.Comment = heritage.Comment;
				bankDeposit.RegisterInformationID = heritage.RegisterInformationID;
				bankDeposit.AdjustmentID = heritage.AdjustmentID;
				bankDeposit.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
				bankDeposit.Stage = heritage.Stage;
				bankDeposit.UserOrder = heritage.UserOrder;
				bankDeposit.Value1 = heritage.Value1;
				bankDeposit.Value2 = heritage.Value2;
				bankDeposit.Value3 = heritage.Value3;
				bankDeposit.DeadIsOwner = heritage.DeadIsOwner;
				bankDeposit.IsDiagonesed = heritage.IsDiagonesed;
			}
		}

		return bankDeposit;
	}

	public List<BankDeposit> GetListAll()
	{
		List<BankDeposit> listBankDeposit = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("BankDeposit_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listBankDeposit = new List<BankDeposit>();

				foreach (DataRow row in table.Rows)
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

					Heritage heritage = heritageDBAccess.GetDetails(bankDeposit.HeritageID);
					bankDeposit.StageTitle = heritage.StageTitle;
					bankDeposit.RegisterDate = heritage.RegisterDate;
					bankDeposit.OldRegisterDate = heritage.OldRegisterDate;
					bankDeposit.OldRegisterInformationID = heritage.OldRegisterInformationID;
					bankDeposit.Sixth = heritage.Sixth;
					bankDeposit.PreviousOwner = heritage.PreviousOwner;
					bankDeposit.Comment = heritage.Comment;
					bankDeposit.RegisterInformationID = heritage.RegisterInformationID;
					bankDeposit.AdjustmentID = heritage.AdjustmentID;
					bankDeposit.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					bankDeposit.Stage = heritage.Stage;
					bankDeposit.UserOrder = heritage.UserOrder;
					bankDeposit.Value1 = heritage.Value1;
					bankDeposit.Value2 = heritage.Value2;
					bankDeposit.Value3 = heritage.Value3;
					bankDeposit.DeadIsOwner = heritage.DeadIsOwner;
					bankDeposit.IsDiagonesed = heritage.IsDiagonesed;
					listBankDeposit.Add(bankDeposit);
				}
			}
		}

		return listBankDeposit;
	}

	public bool Exists(Int64 heritageID)
	{
		SqlParameter[] parametersBankDeposit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", heritageID)
		};
		return (SqlDBHelper.ExecuteScalar("BankDeposit_Exists", CommandType.StoredProcedure, parametersBankDeposit)>0);
	}

	public bool Exists(BankDeposit bankDeposit)
	{
		SqlParameter[] parametersBankDeposit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", bankDeposit.HeritageID)
		};
		return (SqlDBHelper.ExecuteScalar("BankDeposit_Exists", CommandType.StoredProcedure, parametersBankDeposit)>0);
	}

	public List<BankDeposit> SearchLike(BankDeposit bankDeposit)
	{
		List<BankDeposit> listBankDeposit = new List<BankDeposit>();


		SqlParameter[] parametersBankDeposit = new SqlParameter[]
		{
			new SqlParameter("@HeritageID", bankDeposit.HeritageID),
			new SqlParameter("@BankIDTitle", bankDeposit.BankIDTitle),
			new SqlParameter("@BankAccountTypeIDTitle", bankDeposit.BankAccountTypeIDTitle),
			new SqlParameter("@BankCategoryIDTitle", bankDeposit.BankCategoryIDTitle),
			new SqlParameter("@BankTypeIDTitle", bankDeposit.BankTypeIDTitle),
			new SqlParameter("@BankCategoryID", bankDeposit.BankCategoryID),
			new SqlParameter("@BankTypeID", bankDeposit.BankTypeID),
			new SqlParameter("@Branch", bankDeposit.Branch),
			new SqlParameter("@City", bankDeposit.City),
			new SqlParameter("@AccountNumber", bankDeposit.AccountNumber),
			new SqlParameter("@BankAccountTypeID", bankDeposit.BankAccountTypeID),
			new SqlParameter("@CurrencyDeposit", bankDeposit.CurrencyDeposit),
			new SqlParameter("@DeclarationID", bankDeposit.DeclarationID),
			new SqlParameter("@BankID", bankDeposit.BankID),

			new SqlParameter("@StageTitle", bankDeposit.StageTitle),
			new SqlParameter("@RegisterDate", bankDeposit.RegisterDate),
			new SqlParameter("@OldRegisterDate", bankDeposit.OldRegisterDate),
			new SqlParameter("@OldRegisterInformationID", bankDeposit.OldRegisterInformationID),
			new SqlParameter("@Sixth", bankDeposit.Sixth),
			new SqlParameter("@PreviousOwner", bankDeposit.PreviousOwner),
			new SqlParameter("@Comment", bankDeposit.Comment),
			new SqlParameter("@RegisterInformationID", bankDeposit.RegisterInformationID),
			new SqlParameter("@AdjustmentID", bankDeposit.AdjustmentID),
			new SqlParameter("@CommissionAdjustmentID", bankDeposit.CommissionAdjustmentID),
			new SqlParameter("@Stage", bankDeposit.Stage),
			new SqlParameter("@UserOrder", bankDeposit.UserOrder),
			new SqlParameter("@Value1", bankDeposit.Value1),
			new SqlParameter("@Value2", bankDeposit.Value2),
			new SqlParameter("@Value3", bankDeposit.Value3),
			new SqlParameter("@DeadIsOwner", bankDeposit.DeadIsOwner),
			new SqlParameter("@IsDiagonesed", bankDeposit.IsDiagonesed)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BankDeposit_SearchLike", CommandType.StoredProcedure, parametersBankDeposit))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					BankDeposit tmpBankDeposit = new BankDeposit();
					tmpBankDeposit.HeritageID = (row["HeritageID"] != DBNull.Value) ? Convert.ToInt64(row["HeritageID"]) : 0 ;
					tmpBankDeposit.BankIDTitle = row["BankIDTitle"].ToString();
					tmpBankDeposit.BankAccountTypeIDTitle = row["BankAccountTypeIDTitle"].ToString();
					tmpBankDeposit.BankCategoryIDTitle = row["BankCategoryIDTitle"].ToString();
					tmpBankDeposit.BankTypeIDTitle = row["BankTypeIDTitle"].ToString();
					tmpBankDeposit.BankCategoryID = (row["BankCategoryID"] != DBNull.Value) ? Convert.ToInt64(row["BankCategoryID"]) : 0 ;
					tmpBankDeposit.BankTypeID = (row["BankTypeID"] != DBNull.Value) ? Convert.ToInt64(row["BankTypeID"]) : 0 ;
					tmpBankDeposit.Branch = row["Branch"].ToString();
					tmpBankDeposit.City = row["City"].ToString();
					tmpBankDeposit.AccountNumber = row["AccountNumber"].ToString();
					tmpBankDeposit.BankAccountTypeID = (row["BankAccountTypeID"] != DBNull.Value) ? Convert.ToInt32(row["BankAccountTypeID"]) : 0 ;
					tmpBankDeposit.CurrencyDeposit = (row["CurrencyDeposit"] != DBNull.Value) ? Convert.ToSingle(row["CurrencyDeposit"]) : 0 ;
					tmpBankDeposit.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
					tmpBankDeposit.BankID = (row["BankID"] != DBNull.Value) ? Convert.ToInt64(row["BankID"]) : 0 ;

					Heritage heritage = heritageDBAccess.GetDetails(tmpBankDeposit.HeritageID);
					tmpBankDeposit.HeritageID = heritage.HeritageID;
					tmpBankDeposit.StageTitle = heritage.StageTitle;
					tmpBankDeposit.RegisterDate = heritage.RegisterDate;
					tmpBankDeposit.OldRegisterDate = heritage.OldRegisterDate;
					tmpBankDeposit.OldRegisterInformationID = heritage.OldRegisterInformationID;
					tmpBankDeposit.Sixth = heritage.Sixth;
					tmpBankDeposit.PreviousOwner = heritage.PreviousOwner;
					tmpBankDeposit.Comment = heritage.Comment;
					tmpBankDeposit.RegisterInformationID = heritage.RegisterInformationID;
					tmpBankDeposit.AdjustmentID = heritage.AdjustmentID;
					tmpBankDeposit.CommissionAdjustmentID = heritage.CommissionAdjustmentID;
					tmpBankDeposit.Stage = heritage.Stage;
					tmpBankDeposit.UserOrder = heritage.UserOrder;
					tmpBankDeposit.Value1 = heritage.Value1;
					tmpBankDeposit.Value2 = heritage.Value2;
					tmpBankDeposit.Value3 = heritage.Value3;
					tmpBankDeposit.DeadIsOwner = heritage.DeadIsOwner;
					tmpBankDeposit.IsDiagonesed = heritage.IsDiagonesed;

					listBankDeposit.Add(tmpBankDeposit);
				}
			}
		}

		return listBankDeposit;
	}

}
}
