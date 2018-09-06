using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class Dead : Person
{
	private string registerDate;
	private string oldRegisterInformationID;
	private string oldRegisterDate;
	private string deathProvinceIDTitle;
	private string deathCityIDTitle;
	private string martyrProfReferenceIDTitle;
	private string nationalityIDTitle;
	private string residenceIDTitle;
	private string martyrProfDescription;
	private string uniqeCode;
	private string probateIssuedCity;
	private Int64? dossierID;
	private Int64? registerInformationID;
	private string probateDocNumber;
	private string probateIssued;
	private string deathDate;
	private string probateDate;
	private int? deathProvinceID;
	private int? deathCityID;
	private int? martyrProfReferenceID;
	private int? nationalityID;
	private int? residenceID;
	private bool? isMartyr;

	public string RegisterDate
	{
		get
		{
			return registerDate;
		}
		set
		{
			registerDate = value;
		}
	}

	public string OldRegisterInformationID
	{
		get
		{
			return oldRegisterInformationID;
		}
		set
		{
			oldRegisterInformationID = value;
		}
	}

	public string OldRegisterDate
	{
		get
		{
			return oldRegisterDate;
		}
		set
		{
			oldRegisterDate = value;
		}
	}

	public string DeathProvinceIDTitle
	{
		get
		{
			return deathProvinceIDTitle;
		}
		set
		{
			deathProvinceIDTitle = value;
		}
	}

	public string DeathCityIDTitle
	{
		get
		{
			return deathCityIDTitle;
		}
		set
		{
			deathCityIDTitle = value;
		}
	}

	public string MartyrProfReferenceIDTitle
	{
		get
		{
			return martyrProfReferenceIDTitle;
		}
		set
		{
			martyrProfReferenceIDTitle = value;
		}
	}

	public string NationalityIDTitle
	{
		get
		{
			return nationalityIDTitle;
		}
		set
		{
			nationalityIDTitle = value;
		}
	}

	public string ResidenceIDTitle
	{
		get
		{
			return residenceIDTitle;
		}
		set
		{
			residenceIDTitle = value;
		}
	}

	public string MartyrProfDescription
	{
		get
		{
			return martyrProfDescription;
		}
		set
		{
			martyrProfDescription = value;
		}
	}

	public string UniqeCode
	{
		get
		{
			return uniqeCode;
		}
		set
		{
			uniqeCode = value;
		}
	}

	public string ProbateIssuedCity
	{
		get
		{
			return probateIssuedCity;
		}
		set
		{
			probateIssuedCity = value;
		}
	}

	public Int64? DossierID
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

	public Int64? RegisterInformationID
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

	public string ProbateDocNumber
	{
		get
		{
			return probateDocNumber;
		}
		set
		{
			probateDocNumber = value;
		}
	}

	public string ProbateIssued
	{
		get
		{
			return probateIssued;
		}
		set
		{
			probateIssued = value;
		}
	}

	public string DeathDate
	{
		get
		{
			return deathDate;
		}
		set
		{
			deathDate = value;
		}
	}

	public string ProbateDate
	{
		get
		{
			return probateDate;
		}
		set
		{
			probateDate = value;
		}
	}

	public int? DeathProvinceID
	{
		get
		{
			return deathProvinceID;
		}
		set
		{
			deathProvinceID = value;
		}
	}

	public int? DeathCityID
	{
		get
		{
			return deathCityID;
		}
		set
		{
			deathCityID = value;
		}
	}

	public int? MartyrProfReferenceID
	{
		get
		{
			return martyrProfReferenceID;
		}
		set
		{
			martyrProfReferenceID = value;
		}
	}

	public int? NationalityID
	{
		get
		{
			return nationalityID;
		}
		set
		{
			nationalityID = value;
		}
	}

	public int? ResidenceID
	{
		get
		{
			return residenceID;
		}
		set
		{
			residenceID = value;
		}
	}

	public bool? IsMartyr
	{
		get
		{
			return isMartyr;
		}
		set
		{
			isMartyr = value;
		}
	}

}
}
