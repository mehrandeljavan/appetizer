using System;
using System.Collections.Generic;
////using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
public class FormInquiryResponse
{
	private Int64 registerInformationID;
	private Int64? inquiryRegisterInformationID;

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

	public Int64? InquiryRegisterInformationID
	{
		get
		{
			return inquiryRegisterInformationID;
		}
		set
		{
			inquiryRegisterInformationID = value;
		}
	}

}
}
