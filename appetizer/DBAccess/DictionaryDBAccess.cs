using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.Models;

namespace Taxer.DBA
{
public class DictionaryDBAccess
{


	public Int64 Insert(Dictionary dictionary)
	{
		SqlParameter[] parametersDictionary = new SqlParameter[]
		{
			new SqlParameter("@TableName", dictionary.TableName),
			new SqlParameter("@ColumnName", dictionary.ColumnName),
			new SqlParameter("@PersianDisplayName", (dictionary.PersianDisplayName != null) ? dictionary.PersianDisplayName : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteScalar("Dictionary_Insert", CommandType.StoredProcedure, parametersDictionary);
	}

	public bool Update(Dictionary dictionary)
	{
		SqlParameter[] parametersDictionary = new SqlParameter[]
		{
			new SqlParameter("@TableName", dictionary.TableName),
			new SqlParameter("@ColumnName", dictionary.ColumnName),
			new SqlParameter("@PersianDisplayName", (dictionary.PersianDisplayName != null) ? dictionary.PersianDisplayName : (object)DBNull.Value)
		};
		return SqlDBHelper.ExecuteNonQuery("Dictionary_Update", CommandType.StoredProcedure, parametersDictionary);
	}

	public bool Delete(string tableName , string columnName)
	{
		SqlParameter[] parametersDictionary = new SqlParameter[]
		{
			new SqlParameter("@TableName", tableName),
			new SqlParameter("@ColumnName", columnName)
		};
		return SqlDBHelper.ExecuteNonQuery("Dictionary_Delete", CommandType.StoredProcedure, parametersDictionary);
	}

	public Dictionary GetDetails(string tableName , string columnName)
	{
		Dictionary dictionary = new Dictionary();

		SqlParameter[] parametersDictionary = new SqlParameter[]
		{
			new SqlParameter("@TableName", tableName),
			new SqlParameter("@ColumnName", columnName)
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Dictionary_GetDetails", CommandType.StoredProcedure, parametersDictionary))
		{
			if (table.Rows.Count == 1)
			{
				DataRow row = table.Rows[0];

				dictionary.TableName = row["TableName"].ToString();
				dictionary.ColumnName = row["ColumnName"].ToString();
				dictionary.PersianDisplayName = row["PersianDisplayName"].ToString();
			}
		}

		return dictionary;
	}

	public List<Dictionary> GetListAll()
	{
		List<Dictionary> listDictionary = null;

		using (DataTable table = SqlDBHelper.ExecuteSelectCommand("Dictionary_GetListAll", CommandType.StoredProcedure))
		{
			if (table.Rows.Count > 0)
			{
				listDictionary = new List<Dictionary>();

				foreach (DataRow row in table.Rows)
				{
					Dictionary dictionary = new Dictionary();
					dictionary.TableName = row["TableName"].ToString();
					dictionary.ColumnName = row["ColumnName"].ToString();
					dictionary.PersianDisplayName = row["PersianDisplayName"].ToString();
					listDictionary.Add(dictionary);
				}
			}
		}

		return listDictionary;
	}

	public bool Exists(string tableName , string columnName)
	{
		SqlParameter[] parametersDictionary = new SqlParameter[]
		{
			new SqlParameter("@TableName", tableName),
			new SqlParameter("@ColumnName", columnName)
		};
		return (SqlDBHelper.ExecuteScalar("Dictionary_Exists", CommandType.StoredProcedure, parametersDictionary)>0);
	}

	public bool Exists(Dictionary dictionary)
	{
		SqlParameter[] parametersDictionary = new SqlParameter[]
		{
			new SqlParameter("@TableName", dictionary.TableName),
			new SqlParameter("@ColumnName", dictionary.ColumnName)
		};
		return (SqlDBHelper.ExecuteScalar("Dictionary_Exists", CommandType.StoredProcedure, parametersDictionary)>0);
	}

	public List<Dictionary> SearchLike(Dictionary dictionary)
	{
		List<Dictionary> listDictionary = new List<Dictionary>();


		SqlParameter[] parametersDictionary = new SqlParameter[]
		{
			new SqlParameter("@TableName", dictionary.TableName),
			new SqlParameter("@ColumnName", dictionary.ColumnName),
			new SqlParameter("@PersianDisplayName", dictionary.PersianDisplayName),
		};
		using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("Dictionary_SearchLike", CommandType.StoredProcedure, parametersDictionary))
		{
			if (table.Rows.Count > 0)
			{
				foreach (DataRow row in table.Rows)
				{
					Dictionary tmpDictionary = new Dictionary();
					tmpDictionary.TableName = row["TableName"].ToString();
					tmpDictionary.ColumnName = row["ColumnName"].ToString();
					tmpDictionary.PersianDisplayName = row["PersianDisplayName"].ToString();

					listDictionary.Add(tmpDictionary);
				}
			}
		}

		return listDictionary;
	}

}
}
