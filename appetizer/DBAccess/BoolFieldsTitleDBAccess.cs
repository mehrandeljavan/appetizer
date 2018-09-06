using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class BoolFieldsTitleDBAccess
{


	public Int64 Insert(BoolFieldsTitle boolFieldsTitle)
	{
		SqlParameter[] parametersBoolFieldsTitle = new SqlParameter[]
		{
			new SqlParameter("@TableName", boolFieldsTitle.TableName),
			new SqlParameter("@ColumnName", boolFieldsTitle.ColumnName),
			new SqlParameter("@TrueTitle", boolFieldsTitle.TrueTitle),
			new SqlParameter("@FalseTitle", boolFieldsTitle.FalseTitle)
		};
		boolFieldsTitle.BoolFieldsTitleID = Convert.ToInt32(SqlDBHelper.ExecuteScalar("BoolFieldsTitle_Insert", CommandType.StoredProcedure, parametersBoolFieldsTitle));
		return boolFieldsTitle.BoolFieldsTitleID;
	}

	public bool Update(BoolFieldsTitle boolFieldsTitle)
	{
		SqlParameter[] parametersBoolFieldsTitle = new SqlParameter[]
		{
			new SqlParameter("@BoolFieldsTitleID", boolFieldsTitle.BoolFieldsTitleID),
			new SqlParameter("@TableName", boolFieldsTitle.TableName),
			new SqlParameter("@ColumnName", boolFieldsTitle.ColumnName),
			new SqlParameter("@TrueTitle", boolFieldsTitle.TrueTitle),
			new SqlParameter("@FalseTitle", boolFieldsTitle.FalseTitle)
		};
		return SqlDBHelper.ExecuteNonQuery("BoolFieldsTitle_Update", CommandType.StoredProcedure, parametersBoolFieldsTitle);
	}

	public bool Delete(int boolFieldsTitleID)
	{
		SqlParameter[] parametersBoolFieldsTitle = new SqlParameter[]
		{
			new SqlParameter("@BoolFieldsTitleID", boolFieldsTitleID)
		};
		return SqlDBHelper.ExecuteNonQuery("BoolFieldsTitle_Delete", CommandType.StoredProcedure, parametersBoolFieldsTitle);
	}

	public BoolFieldsTitle GetDetails(int boolFieldsTitleID)
	{
		BoolFieldsTitle boolFieldsTitle = new BoolFieldsTitle();

		SqlParameter[] parametersBoolFieldsTitle = new SqlParameter[]
		{
			new SqlParameter("@BoolFieldsTitleID", boolFieldsTitleID)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BoolFieldsTitle_GetDetails", CommandType.StoredProcedure, parametersBoolFieldsTitle))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				boolFieldsTitle.BoolFieldsTitleID = (row["BoolFieldsTitleID"] != DBNull.Value) ? Convert.ToInt32(row["BoolFieldsTitleID"]) : 0 ;
				boolFieldsTitle.TableName = row["TableName"].ToString();
				boolFieldsTitle.ColumnName = row["ColumnName"].ToString();
				boolFieldsTitle.TrueTitle = row["TrueTitle"].ToString();
				boolFieldsTitle.FalseTitle = row["FalseTitle"].ToString();
			}
		}

		return boolFieldsTitle;
	}

	public List<BoolFieldsTitle> GetListAll()
	{
		List<BoolFieldsTitle> listBoolFieldsTitle = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("BoolFieldsTitle_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listBoolFieldsTitle = new List<BoolFieldsTitle>();

				foreach (DataRow row in table.Rows)
				{
					BoolFieldsTitle boolFieldsTitle = new BoolFieldsTitle();
					boolFieldsTitle.BoolFieldsTitleID = (row["BoolFieldsTitleID"] != DBNull.Value) ? Convert.ToInt32(row["BoolFieldsTitleID"]) : 0 ;
					boolFieldsTitle.TableName = row["TableName"].ToString();
					boolFieldsTitle.ColumnName = row["ColumnName"].ToString();
					boolFieldsTitle.TrueTitle = row["TrueTitle"].ToString();
					boolFieldsTitle.FalseTitle = row["FalseTitle"].ToString();
					listBoolFieldsTitle.Add(boolFieldsTitle);
				}
			}
		}

		return listBoolFieldsTitle;
	}

	public bool Exists(int boolFieldsTitleID)
	{
		SqlParameter[] parametersBoolFieldsTitle = new SqlParameter[]
		{
			new SqlParameter("@BoolFieldsTitleID", boolFieldsTitleID)
		};
		return (SqlDBHelper.ExecuteScalar("BoolFieldsTitle_Exists", CommandType.StoredProcedure, parametersBoolFieldsTitle)>0);
	}

	public bool Exists(BoolFieldsTitle boolFieldsTitle)
	{
		SqlParameter[] parametersBoolFieldsTitle = new SqlParameter[]
		{
			new SqlParameter("@BoolFieldsTitleID", boolFieldsTitle.BoolFieldsTitleID)
		};
		return (SqlDBHelper.ExecuteScalar("BoolFieldsTitle_Exists", CommandType.StoredProcedure, parametersBoolFieldsTitle)>0);
	}

	public List<BoolFieldsTitle> SearchLike(BoolFieldsTitle boolFieldsTitle)
	{
		List<BoolFieldsTitle> listBoolFieldsTitle = new List<BoolFieldsTitle>();


		SqlParameter[] parametersBoolFieldsTitle = new SqlParameter[]
		{
			new SqlParameter("@BoolFieldsTitleID", boolFieldsTitle.BoolFieldsTitleID),
			new SqlParameter("@TableName", boolFieldsTitle.TableName),
			new SqlParameter("@ColumnName", boolFieldsTitle.ColumnName),
			new SqlParameter("@TrueTitle", boolFieldsTitle.TrueTitle),
			new SqlParameter("@FalseTitle", boolFieldsTitle.FalseTitle),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("BoolFieldsTitle_SearchLike", CommandType.StoredProcedure, parametersBoolFieldsTitle))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					BoolFieldsTitle tmpBoolFieldsTitle = new BoolFieldsTitle();
					tmpBoolFieldsTitle.BoolFieldsTitleID = (row["BoolFieldsTitleID"] != DBNull.Value) ? Convert.ToInt32(row["BoolFieldsTitleID"]) : 0 ;
					tmpBoolFieldsTitle.TableName = row["TableName"].ToString();
					tmpBoolFieldsTitle.ColumnName = row["ColumnName"].ToString();
					tmpBoolFieldsTitle.TrueTitle = row["TrueTitle"].ToString();
					tmpBoolFieldsTitle.FalseTitle = row["FalseTitle"].ToString();

					listBoolFieldsTitle.Add(tmpBoolFieldsTitle);
				}
			}
		}

		return listBoolFieldsTitle;
	}

}
}
