using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class BankInquiryHajjDBAccess
{

	HajjDBAccess hajjDBAccess = new HajjDBAccess();

	public List<Hajj> GetListHajj(int bankInquiryHajjID)
	{
		List<Hajj> listHajj = new List<Hajj>() { };
		SqlParameter[] parametersBankInquiryHajj = new SqlParameter[]
		{
			new SqlParameter("@BankInquiryHajjID", bankInquiryHajjID)
		};

		//Lets get the list of Hajj records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Hajj_GetList_UseInBankInquiryHajj", CommandType.StoredProcedure, parametersBankInquiryHajj))
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
	public Int64 Insert(BankInquiryHajj bankInquiryHajj)
	{
		SqlParameter[] parametersBankInquiryHajj = new SqlParameter[]
		{
			new SqlParameter("@Title", (bankInquiryHajj.Title != null) ? bankInquiryHajj.Title : (object)DBNull.Value)
		};
		bankInquiryHajj.BankInquiryHajjID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("BankInquiryHajj_Insert", CommandType.StoredProcedure, parametersBankInquiryHajj));
		return bankInquiryHajj.BankInquiryHajjID;
	}

	public bool Update(BankInquiryHajj bankInquiryHajj)
	{
		SqlParameter[] parametersBankInquiryHajj = new SqlParameter[]
		{
			new SqlParameter("@BankInquiryHajjID", bankInquiryHajj.BankInquiryHajjID),
			new SqlParameter("@Title", (bankInquiryHajj.Title != null) ? bankInquiryHajj.Title : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("BankInquiryHajj_Update", CommandType.StoredProcedure, parametersBankInquiryHajj);
	}

	public bool Delete(int bankInquiryHajjID)
	{
		SqlParameter[] parametersBankInquiryHajj = new SqlParameter[]
		{
			new SqlParameter("@BankInquiryHajjID", bankInquiryHajjID)
		};
		return SqlDBHelper.ExecuteNonQuery("BankInquiryHajj_Delete", CommandType.StoredProcedure, parametersBankInquiryHajj);
	}

	public BankInquiryHajj GetDetails(int bankInquiryHajjID)
	{
		BankInquiryHajj bankInquiryHajj = new BankInquiryHajj();

		SqlParameter[] parametersBankInquiryHajj = new SqlParameter[]
		{
			new SqlParameter("@BankInquiryHajjID", bankInquiryHajjID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BankInquiryHajj_GetDetails", CommandType.StoredProcedure, parametersBankInquiryHajj))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				bankInquiryHajj.BankInquiryHajjID = (row["BankInquiryHajjID"] != DBNull.Value) ? Convert.ToInt32(row["BankInquiryHajjID"]) : 0 ;
				bankInquiryHajj.Title = row["Title"].ToString();
			}
		}

		return bankInquiryHajj;
	}

	public List<BankInquiryHajj> GetListAll()
	{
		List<BankInquiryHajj> listBankInquiryHajj = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("BankInquiryHajj_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listBankInquiryHajj = new List<BankInquiryHajj>();

				foreach (DataRow row in table.Rows)
				{
					BankInquiryHajj bankInquiryHajj = new BankInquiryHajj();
					bankInquiryHajj.BankInquiryHajjID = (row["BankInquiryHajjID"] != DBNull.Value) ? Convert.ToInt32(row["BankInquiryHajjID"]) : 0 ;
					bankInquiryHajj.Title = row["Title"].ToString();
					listBankInquiryHajj.Add(bankInquiryHajj);
				}
			}
		}

		return listBankInquiryHajj;
	}

	public bool Exists(int bankInquiryHajjID)
	{
		SqlParameter[] parametersBankInquiryHajj = new SqlParameter[]
		{
			new SqlParameter("@BankInquiryHajjID", bankInquiryHajjID)
		};
		return (SqlDBHelper.ExecuteScalar("BankInquiryHajj_Exists", CommandType.StoredProcedure, parametersBankInquiryHajj)>0);
	}

	public bool Exists(BankInquiryHajj bankInquiryHajj)
	{
		SqlParameter[] parametersBankInquiryHajj = new SqlParameter[]
		{
			new SqlParameter("@BankInquiryHajjID", bankInquiryHajj.BankInquiryHajjID)
		};
		return (SqlDBHelper.ExecuteScalar("BankInquiryHajj_Exists", CommandType.StoredProcedure, parametersBankInquiryHajj)>0);
	}

	public List<BankInquiryHajj> SearchLike(BankInquiryHajj bankInquiryHajj)
	{
		List<BankInquiryHajj> listBankInquiryHajj = new List<BankInquiryHajj>();


		SqlParameter[] parametersBankInquiryHajj = new SqlParameter[]
		{
			new SqlParameter("@BankInquiryHajjID", bankInquiryHajj.BankInquiryHajjID),
			new SqlParameter("@Title", bankInquiryHajj.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BankInquiryHajj_SearchLike", CommandType.StoredProcedure, parametersBankInquiryHajj))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					BankInquiryHajj tmpBankInquiryHajj = new BankInquiryHajj();
					tmpBankInquiryHajj.BankInquiryHajjID = (row["BankInquiryHajjID"] != DBNull.Value) ? Convert.ToInt32(row["BankInquiryHajjID"]) : 0 ;
					tmpBankInquiryHajj.Title = row["Title"].ToString();

					listBankInquiryHajj.Add(tmpBankInquiryHajj);
				}
			}
		}

		return listBankInquiryHajj;
	}

}
}
