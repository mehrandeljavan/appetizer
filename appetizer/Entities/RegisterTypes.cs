using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taxer.DBA;

namespace Taxer.Models
{
[Serializable]
public partial class RegisterTypes
{
	private int registerTypeID;
	private string title;
	private List<RegisterInformation> registerInformationList;

	public int RegisterTypeID
	{
		get
		{
			return registerTypeID;
		}
		set
		{
			registerTypeID = value;
		}
	}

	public string Title
	{
		get
		{
			return title;
		}
		set
		{
			title = value;
		}
	}

	public List<RegisterInformation> RegisterInformationList
	{
		get
		{
			return registerInformationList;
		}
		set
		{
			registerInformationList = value;
		}
	}

	public List<RegisterInformation> GetListRegisterInformation()
	{
		RegisterInformationList = new RegisterTypesDBAccess().GetListRegisterInformation(this.RegisterTypeID);
		return RegisterInformationList;
	}

	public bool AddRegisterInformation(RegisterInformation registerInformation)
	{
		registerInformation.RegisterTypeID = this.RegisterTypeID;
		RegisterInformationDBAccess registerInformationDBAccess = new RegisterInformationDBAccess();
		if (registerInformationDBAccess.Insert(registerInformation)>0)
			return (true);
		return (false);
	}

}
}
