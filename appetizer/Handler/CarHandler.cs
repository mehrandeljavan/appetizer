using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Taxer.DBA;

namespace Taxer.Models
{
public class CarHandler
{
	// Handle to the Car DBAccess class
	CarDBAccess carDb = null;

	public CarHandler()
	{
		carDb = new CarDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of cars, we can put some logic here if needed 
	public List<Car> GetListAll()
	{
		return carDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of cars, we can put some logic here if needed 
	public bool Update(Car car)
	{
		return carDb.Update(car);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of cars, we can put some logic here if needed 
	public Car GetDetails(Int64 heritageID)
	{
		return carDb.GetDetails(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of cars, we can put some logic here if needed 
	public bool Delete(Int64 heritageID)
	{
		return carDb.Delete(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of cars, we can put some logic here if needed 
	public Int64 Insert(Car car)
	{
		return carDb.Insert(car);
	}

	public bool Exists(Car car)
	{
		return carDb.Exists(car);
	}

	public bool Exists(Int64 heritageID)
	{
		return carDb.Exists(heritageID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of cars, we can put some logic here if needed 
	public List<Car> SearchLike(Car car)
	{
		return carDb.SearchLike(car);
	}

}
}
