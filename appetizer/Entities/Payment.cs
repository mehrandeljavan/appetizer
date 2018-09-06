using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Payment
{
	private Int64 paymentID;
	private Int64 dossierID;
	private Int64? paymentValue;
	private string paymentDate;
	private string number;
	private string comment;

	public Int64 PaymentID
	{
		get
		{
			return paymentID;
		}
		set
		{
			paymentID = value;
		}
	}

	public Int64 DossierID
	{
		get
		{
			return dossierID;
		}
		set
		{
			dossierID = value;
		}
	}

	public Int64? PaymentValue
	{
		get
		{
			return paymentValue;
		}
		set
		{
			paymentValue = value;
		}
	}

	public string PaymentDate
	{
		get
		{
			return paymentDate;
		}
		set
		{
			paymentDate = value;
		}
	}

	public string Number
	{
		get
		{
			return number;
		}
		set
		{
			number = value;
		}
	}

	public string Comment
	{
		get
		{
			return comment;
		}
		set
		{
			comment = value;
		}
	}

}
}
