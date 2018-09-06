using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Request
{
	private Int64 requestID;
	private Int64? declarationID;
	private string requestDate;
	private string requestResource;
	private string requestNumber;

	public Int64 RequestID
	{
		get
		{
			return requestID;
		}
		set
		{
			requestID = value;
		}
	}

	public Int64? DeclarationID
	{
		get
		{
			return declarationID;
		}
		set
		{
			declarationID = value;
		}
	}

	public string RequestDate
	{
		get
		{
			return requestDate;
		}
		set
		{
			requestDate = value;
		}
	}

	public string RequestResource
	{
		get
		{
			return requestResource;
		}
		set
		{
			requestResource = value;
		}
	}

	public string RequestNumber
	{
		get
		{
			return requestNumber;
		}
		set
		{
			requestNumber = value;
		}
	}

}
}
