using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAMLib.Models
{
  public class Win32_Product
  {
    public Win32_Product(WmiRecord data)
    {
      AssignmentType = data.Properties["AssignmentType"];
      HelpLink = data.Properties["HelpLink"];
      HelpTelephone = data.Properties["HelpTelephone"];
      IdentifyingNumber = data.Properties["IdentifyingNumber"];
      InstallDate = data.Properties["InstallDate"];
      InstallLocation = data.Properties["InstallLocation"];
      InstallSource = data.Properties["InstallSource"];
      InstallState = data.Properties["InstallState"];
      Language = data.Properties["Language"];
      LocalPackage = data.Properties["LocalPackage"];
      Name = data.Properties["Name"];
      PackageCache = data.Properties["PackageCache"];
      PackageCode = data.Properties["PackageCode"];
      PackageName = data.Properties["PackageName"];
      ProductID = data.Properties["ProductID"];
      RegCompany = data.Properties["RegCompany"];
      RegOwner = data.Properties["RegOwner"];
      SKUNumber = data.Properties["SKUNumber"];
      Transforms = data.Properties["Transforms"];
      URLInfoAbout = data.Properties["URLInfoAbout"];
      URLUpdateInfo = data.Properties["URLUpdateInfo"];
      Vendor = data.Properties["Vendor"];
      Version = data.Properties["Version"];
    }

    public string AssignmentType { get; private set; }
    public string HelpLink { get; private set; }
    public string HelpTelephone { get; private set; }
    public string IdentifyingNumber { get; private set; }
    public string InstallDate { get; private set; }
    public string InstallLocation { get; private set; }
    public string InstallSource { get; private set; }
    public string InstallState { get; private set; }
    public string Language { get; private set; }
    public string LocalPackage { get; private set; }
    public string Name { get; private set; }
    public string PackageCache { get; private set; }
    public string PackageCode { get; private set; }
    public string PackageName { get; private set; }
    public string ProductID { get; private set; }
    public string RegCompany { get; private set; }
    public string RegOwner { get; private set; }
    public string SKUNumber { get; private set; }
    public string Transforms { get; private set; }
    public string URLInfoAbout { get; private set; }
    public string URLUpdateInfo { get; private set; }
    public string Vendor { get; private set; }
    public string Version { get; private set; }
  }
}
