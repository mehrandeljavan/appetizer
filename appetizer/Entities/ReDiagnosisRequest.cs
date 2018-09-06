using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class ReDiagnosisRequest
{
	private Int64 reDiagnosisRequestID;
	private string printRegisterDate;
	private Int64 declarationID;
	private Int64 registerInformationID;
	private string requestDate;

	public Int64 ReDiagnosisRequestID
	{
		get
		{
			return reDiagnosisRequestID;
		}
		set
		{
			reDiagnosisRequestID = value;
		}
	}

	public string PrintRegisterDate
	{
		get
		{
			return printRegisterDate;
		}
		set
		{
			printRegisterDate = value;
		}
	}

	public Int64 DeclarationID
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

	public Int64 RegisterInformationID
	{
		get
		{
			return registerInformationID;
		}
		set
		{
			registerInformationID = value;
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

}
}
