using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Person
{
	private Int64 nationalCode;
	private string printNationalCode;
	private string fullName;
	private string genderIDTitle;
	private string religion_DinIDTitle;
	private string religion_MazhabIDTitle;
	private string issuanceProvinceIDTitle;
	private string issuanceCityIDTitle;
	private string issuanceDepartment;
	private string certificateNumber;
	private string certificateSerial;
	private string zipCode;
	private string homeAddress;
	private string phoneNumber;
	private string job;
	private string jobAddress;
	private string jobPhoneNumber;
	private string comment;
	private string birthCity;
	private string jobZipCode;
	private string certificateSerialLetter;
	private string certificateSerialNumber;
	private string fatherName;
	private string name;
	private string family;
	private string birthDate;
	private string issuanceDate;
	private int? genderID;
	private int? issuanceProvinceID;
	private int? issuanceCityID;
	private int? religion_DinID;
	private int? religion_MazhabID;

	public Int64 NationalCode
	{
		get
		{
			return nationalCode;
		}
		set
		{
			nationalCode = value;
		}
	}

	public string PrintNationalCode
	{
		get
		{
			return printNationalCode;
		}
		set
		{
			printNationalCode = value;
		}
	}

	public string FullName
	{
		get
		{
			return fullName;
		}
		set
		{
			fullName = value;
		}
	}

	public string GenderIDTitle
	{
		get
		{
			return genderIDTitle;
		}
		set
		{
			genderIDTitle = value;
		}
	}

	public string Religion_DinIDTitle
	{
		get
		{
			return religion_DinIDTitle;
		}
		set
		{
			religion_DinIDTitle = value;
		}
	}

	public string Religion_MazhabIDTitle
	{
		get
		{
			return religion_MazhabIDTitle;
		}
		set
		{
			religion_MazhabIDTitle = value;
		}
	}

	public string IssuanceProvinceIDTitle
	{
		get
		{
			return issuanceProvinceIDTitle;
		}
		set
		{
			issuanceProvinceIDTitle = value;
		}
	}

	public string IssuanceCityIDTitle
	{
		get
		{
			return issuanceCityIDTitle;
		}
		set
		{
			issuanceCityIDTitle = value;
		}
	}

	public string IssuanceDepartment
	{
		get
		{
			return issuanceDepartment;
		}
		set
		{
			issuanceDepartment = value;
		}
	}

	public string CertificateNumber
	{
		get
		{
			return certificateNumber;
		}
		set
		{
			certificateNumber = value;
		}
	}

	public string CertificateSerial
	{
		get
		{
			return certificateSerial;
		}
		set
		{
			certificateSerial = value;
		}
	}

	public string ZipCode
	{
		get
		{
			return zipCode;
		}
		set
		{
			zipCode = value;
		}
	}

	public string HomeAddress
	{
		get
		{
			return homeAddress;
		}
		set
		{
			homeAddress = value;
		}
	}

	public string PhoneNumber
	{
		get
		{
			return phoneNumber;
		}
		set
		{
			phoneNumber = value;
		}
	}

	public string Job
	{
		get
		{
			return job;
		}
		set
		{
			job = value;
		}
	}

	public string JobAddress
	{
		get
		{
			return jobAddress;
		}
		set
		{
			jobAddress = value;
		}
	}

	public string JobPhoneNumber
	{
		get
		{
			return jobPhoneNumber;
		}
		set
		{
			jobPhoneNumber = value;
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

	public string BirthCity
	{
		get
		{
			return birthCity;
		}
		set
		{
			birthCity = value;
		}
	}

	public string JobZipCode
	{
		get
		{
			return jobZipCode;
		}
		set
		{
			jobZipCode = value;
		}
	}

	public string CertificateSerialLetter
	{
		get
		{
			return certificateSerialLetter;
		}
		set
		{
			certificateSerialLetter = value;
		}
	}

	public string CertificateSerialNumber
	{
		get
		{
			return certificateSerialNumber;
		}
		set
		{
			certificateSerialNumber = value;
		}
	}

	public string FatherName
	{
		get
		{
			return fatherName;
		}
		set
		{
			fatherName = value;
		}
	}

	public string Name
	{
		get
		{
			return name;
		}
		set
		{
			name = value;
		}
	}

	public string Family
	{
		get
		{
			return family;
		}
		set
		{
			family = value;
		}
	}

	public string BirthDate
	{
		get
		{
			return birthDate;
		}
		set
		{
			birthDate = value;
		}
	}

	public string IssuanceDate
	{
		get
		{
			return issuanceDate;
		}
		set
		{
			issuanceDate = value;
		}
	}

	public int? GenderID
	{
		get
		{
			return genderID;
		}
		set
		{
			genderID = value;
		}
	}

	public int? IssuanceProvinceID
	{
		get
		{
			return issuanceProvinceID;
		}
		set
		{
			issuanceProvinceID = value;
		}
	}

	public int? IssuanceCityID
	{
		get
		{
			return issuanceCityID;
		}
		set
		{
			issuanceCityID = value;
		}
	}

	public int? Religion_DinID
	{
		get
		{
			return religion_DinID;
		}
		set
		{
			religion_DinID = value;
		}
	}

	public int? Religion_MazhabID
	{
		get
		{
			return religion_MazhabID;
		}
		set
		{
			religion_MazhabID = value;
		}
	}

}
}
