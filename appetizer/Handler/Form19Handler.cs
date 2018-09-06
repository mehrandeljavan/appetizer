using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class Form19Handler
{
	// Handle to the Form19 DBAccess class
	Form19DBAccess form19Db = null;

	public Form19Handler()
	{
		form19Db = new Form19DBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of form19s, we can put some logic here if needed 
	public List<Form19> GetListAll()
	{
		return form19Db.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of form19s, we can put some logic here if needed 
	public bool Update(Form19 form19)
	{
		return form19Db.Update(form19);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of form19s, we can put some logic here if needed 
	public Form19 GetDetails(Int64 form19ID)
	{
		return form19Db.GetDetails(form19ID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of form19s, we can put some logic here if needed 
	public bool Delete(Int64 form19ID)
	{
		return form19Db.Delete(form19ID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of form19s, we can put some logic here if needed 
	public Int64 Insert(Form19 form19)
	{
		return form19Db.Insert(form19);
	}

	public bool Exists(Form19 form19)
	{
		return form19Db.Exists(form19);
	}

	public bool Exists(Int64 form19ID)
	{
		return form19Db.Exists(form19ID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of form19s, we can put some logic here if needed 
	public List<Form19> SearchLike(Form19 form19)
	{
		return form19Db.SearchLike(form19);
	}

}
}
