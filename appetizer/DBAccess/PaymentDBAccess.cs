using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class PaymentDBAccess
{


	public Int64 Insert(Payment payment)
	{
		SqlParameter[] parametersPayment = new SqlParameter[]
		{
			new SqlParameter("@DossierID", (payment.DossierID > 0) ? payment.DossierID : (object)DBNull.Value),
			new SqlParameter("@PaymentValue", (payment.PaymentValue != null) ? payment.PaymentValue : (object)DBNull.Value),
			new SqlParameter("@PaymentDate", (payment.PaymentDate != null) ? payment.PaymentDate : (object)DBNull.Value),
			new SqlParameter("@Number", (payment.Number != null) ? payment.Number : (object)DBNull.Value),
			new SqlParameter("@Comment", (payment.Comment != null) ? payment.Comment : (object)DBNull.Value)
		};
		payment.PaymentID = SqlDBHelper.ExecuteScalar("Payment_Insert", CommandType.StoredProcedure, parametersPayment);
		return payment.PaymentID;
	}

	public bool Update(Payment payment)
	{
		SqlParameter[] parametersPayment = new SqlParameter[]
		{
			new SqlParameter("@PaymentID", payment.PaymentID),
			new SqlParameter("@DossierID", payment.DossierID),
			new SqlParameter("@PaymentValue", (payment.PaymentValue != null) ? payment.PaymentValue : (object)DBNull.Value),
			new SqlParameter("@PaymentDate", (payment.PaymentDate != null) ? payment.PaymentDate : (object)DBNull.Value),
			new SqlParameter("@Number", (payment.Number != null) ? payment.Number : (object)DBNull.Value),
			new SqlParameter("@Comment", (payment.Comment != null) ? payment.Comment : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Payment_Update", CommandType.StoredProcedure, parametersPayment);
	}

	public bool Delete(Int64 paymentID)
	{
		SqlParameter[] parametersPayment = new SqlParameter[]
		{
			new SqlParameter("@PaymentID", paymentID)
		};
		return SqlDBHelper.ExecuteNonQuery("Payment_Delete", CommandType.StoredProcedure, parametersPayment);
	}

	public Payment GetDetails(Int64 paymentID)
	{
		Payment payment = new Payment();

		SqlParameter[] parametersPayment = new SqlParameter[]
		{
			new SqlParameter("@PaymentID", paymentID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Payment_GetDetails", CommandType.StoredProcedure, parametersPayment))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				payment.PaymentID = (row["PaymentID"] != DBNull.Value) ? Convert.ToInt64(row["PaymentID"]) : 0 ;
				payment.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
				payment.PaymentValue = (row["PaymentValue"] != DBNull.Value) ? Convert.ToInt64(row["PaymentValue"]) : 0 ;
				payment.PaymentDate = row["PaymentDate"].ToString();
				payment.Number = row["Number"].ToString();
				payment.Comment = row["Comment"].ToString();
			}
		}

		return payment;
	}

	public List<Payment> GetListAll()
	{
		List<Payment> listPayment = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Payment_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listPayment = new List<Payment>();

				foreach (DataRow row in table.Rows)
				{
					Payment payment = new Payment();
					payment.PaymentID = (row["PaymentID"] != DBNull.Value) ? Convert.ToInt64(row["PaymentID"]) : 0 ;
					payment.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					payment.PaymentValue = (row["PaymentValue"] != DBNull.Value) ? Convert.ToInt64(row["PaymentValue"]) : 0 ;
					payment.PaymentDate = row["PaymentDate"].ToString();
					payment.Number = row["Number"].ToString();
					payment.Comment = row["Comment"].ToString();
					listPayment.Add(payment);
				}
			}
		}

		return listPayment;
	}

	public bool Exists(Int64 paymentID)
	{
		SqlParameter[] parametersPayment = new SqlParameter[]
		{
			new SqlParameter("@PaymentID", paymentID)
		};
		return (SqlDBHelper.ExecuteScalar("Payment_Exists", CommandType.StoredProcedure, parametersPayment)>0);
	}

	public bool Exists(Payment payment)
	{
		SqlParameter[] parametersPayment = new SqlParameter[]
		{
			new SqlParameter("@PaymentID", payment.PaymentID)
		};
		return (SqlDBHelper.ExecuteScalar("Payment_Exists", CommandType.StoredProcedure, parametersPayment)>0);
	}

	public List<Payment> SearchLike(Payment payment)
	{
		List<Payment> listPayment = new List<Payment>();


		SqlParameter[] parametersPayment = new SqlParameter[]
		{
			new SqlParameter("@PaymentID", payment.PaymentID),
			new SqlParameter("@DossierID", payment.DossierID),
			new SqlParameter("@PaymentValue", payment.PaymentValue),
			new SqlParameter("@PaymentDate", payment.PaymentDate),
			new SqlParameter("@Number", payment.Number),
			new SqlParameter("@Comment", payment.Comment),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Payment_SearchLike", CommandType.StoredProcedure, parametersPayment))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Payment tmpPayment = new Payment();
					tmpPayment.PaymentID = (row["PaymentID"] != DBNull.Value) ? Convert.ToInt64(row["PaymentID"]) : 0 ;
					tmpPayment.DossierID = (row["DossierID"] != DBNull.Value) ? Convert.ToInt64(row["DossierID"]) : 0 ;
					tmpPayment.PaymentValue = (row["PaymentValue"] != DBNull.Value) ? Convert.ToInt64(row["PaymentValue"]) : 0 ;
					tmpPayment.PaymentDate = row["PaymentDate"].ToString();
					tmpPayment.Number = row["Number"].ToString();
					tmpPayment.Comment = row["Comment"].ToString();

					listPayment.Add(tmpPayment);
				}
			}
		}

		return listPayment;
	}

}
}
