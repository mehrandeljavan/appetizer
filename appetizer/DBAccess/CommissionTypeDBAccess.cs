using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class CommissionTypeDBAccess
{

	CommissionInvitationDBAccess commissionInvitationDBAccess = new CommissionInvitationDBAccess();

	public List<CommissionInvitation> GetListCommissionInvitation(int commisionTypeID)
	{
		List<CommissionInvitation> listCommissionInvitation = new List<CommissionInvitation>() { };
		SqlParameter[] parametersCommissionType = new SqlParameter[]
		{
			new SqlParameter("@CommissionTypeID", commisionTypeID)
		};

		//Lets get the list of CommissionInvitation records from database
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionInvitation_GetList_UseInCommissionType", CommandType.StoredProcedure, parametersCommissionType))
		{
			//check if any record exists or not
			if (table.Rows.Count > 0)
			{
				//Lets go ahead and create the list of commissionInvitation
				listCommissionInvitation = new List<CommissionInvitation>();

				//Now lets populate the CommissionInvitation details into the list of commissionInvitations
				foreach (DataRow row in table.Rows)
				{
					CommissionInvitation commissionInvitation = ConvertRowToCommissionInvitation(row);
					listCommissionInvitation.Add(commissionInvitation);
				}
			}
		}

		return listCommissionInvitation;
	}

	private CommissionInvitation ConvertRowToCommissionInvitation(DataRow row)
	{
		CommissionInvitation commissionInvitation = new CommissionInvitation();
		commissionInvitation.CommissionInvitationID = (row["CommissionInvitationID"] != DBNull.Value) ? Convert.ToInt64(row["CommissionInvitationID"]) : 0 ;
		commissionInvitation.InvitationTypeIDTitle = row["InvitationTypeIDTitle"].ToString();
		commissionInvitation.CommissionTypeIDTitle = row["CommissionTypeIDTitle"].ToString();
		commissionInvitation.CommissionDayIDTitle = row["CommissionDayIDTitle"].ToString();
		commissionInvitation.InvitationTypeID = (row["InvitationTypeID"] != DBNull.Value) ? Convert.ToInt32(row["InvitationTypeID"]) : 0 ;
		commissionInvitation.CommissionTypeID = (row["CommissionTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionTypeID"]) : 0 ;
		commissionInvitation.CommissionDayID = (row["CommissionDayID"] != DBNull.Value) ? Convert.ToInt32(row["CommissionDayID"]) : 0 ;
		commissionInvitation.HeirID = (row["HeirID"] != DBNull.Value) ? Convert.ToInt64(row["HeirID"]) : 0 ;
		commissionInvitation.DeclarationID = (row["DeclarationID"] != DBNull.Value) ? Convert.ToInt64(row["DeclarationID"]) : 0 ;
		commissionInvitation.CommissionHour = row["CommissionHour"].ToString();
		commissionInvitation.CommssionDate = row["CommssionDate"].ToString();
		commissionInvitation.CommissionAddress = row["CommissionAddress"].ToString();
		return commissionInvitation;
	}
	public Int64 Insert(CommissionType commissionType)
	{
		SqlParameter[] parametersCommissionType = new SqlParameter[]
		{
			new SqlParameter("@Title", (commissionType.Title != null) ? commissionType.Title : (object)DBNull.Value)
		};
		commissionType.CommisionTypeID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("CommissionType_Insert", CommandType.StoredProcedure, parametersCommissionType));
		return commissionType.CommisionTypeID;
	}

	public bool Update(CommissionType commissionType)
	{
		SqlParameter[] parametersCommissionType = new SqlParameter[]
		{
			new SqlParameter("@CommisionTypeID", commissionType.CommisionTypeID),
			new SqlParameter("@Title", (commissionType.Title != null) ? commissionType.Title : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("CommissionType_Update", CommandType.StoredProcedure, parametersCommissionType);
	}

	public bool Delete(int commisionTypeID)
	{
		SqlParameter[] parametersCommissionType = new SqlParameter[]
		{
			new SqlParameter("@CommisionTypeID", commisionTypeID)
		};
		return SqlDBHelper.ExecuteNonQuery("CommissionType_Delete", CommandType.StoredProcedure, parametersCommissionType);
	}

	public CommissionType GetDetails(int commisionTypeID)
	{
		CommissionType commissionType = new CommissionType();

		SqlParameter[] parametersCommissionType = new SqlParameter[]
		{
			new SqlParameter("@CommisionTypeID", commisionTypeID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionType_GetDetails", CommandType.StoredProcedure, parametersCommissionType))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				commissionType.CommisionTypeID = (row["CommisionTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommisionTypeID"]) : 0 ;
				commissionType.Title = row["Title"].ToString();
			}
		}

		return commissionType;
	}

	public List<CommissionType> GetListAll()
	{
		List<CommissionType> listCommissionType = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("CommissionType_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listCommissionType = new List<CommissionType>();

				foreach (DataRow row in table.Rows)
				{
					CommissionType commissionType = new CommissionType();
					commissionType.CommisionTypeID = (row["CommisionTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommisionTypeID"]) : 0 ;
					commissionType.Title = row["Title"].ToString();
					listCommissionType.Add(commissionType);
				}
			}
		}

		return listCommissionType;
	}

	public bool Exists(int commisionTypeID)
	{
		SqlParameter[] parametersCommissionType = new SqlParameter[]
		{
			new SqlParameter("@CommisionTypeID", commisionTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("CommissionType_Exists", CommandType.StoredProcedure, parametersCommissionType)>0);
	}

	public bool Exists(CommissionType commissionType)
	{
		SqlParameter[] parametersCommissionType = new SqlParameter[]
		{
			new SqlParameter("@CommisionTypeID", commissionType.CommisionTypeID)
		};
		return (SqlDBHelper.ExecuteScalar("CommissionType_Exists", CommandType.StoredProcedure, parametersCommissionType)>0);
	}

	public List<CommissionType> SearchLike(CommissionType commissionType)
	{
		List<CommissionType> listCommissionType = new List<CommissionType>();


		SqlParameter[] parametersCommissionType = new SqlParameter[]
		{
			new SqlParameter("@CommisionTypeID", commissionType.CommisionTypeID),
			new SqlParameter("@Title", commissionType.Title),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("CommissionType_SearchLike", CommandType.StoredProcedure, parametersCommissionType))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					CommissionType tmpCommissionType = new CommissionType();
					tmpCommissionType.CommisionTypeID = (row["CommisionTypeID"] != DBNull.Value) ? Convert.ToInt32(row["CommisionTypeID"]) : 0 ;
					tmpCommissionType.Title = row["Title"].ToString();

					listCommissionType.Add(tmpCommissionType);
				}
			}
		}

		return listCommissionType;
	}

}
}
