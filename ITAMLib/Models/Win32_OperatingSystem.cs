using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAMLib.Models
{
  public class Win32_OperatingSystem
  {
    public Win32_OperatingSystem(WmiRecord data)
    {
      BootDevice = data.Properties["BootDevice"];
      BuildNumber = data.Properties["BuildNumber"];
      BuildType = data.Properties["BuildType"];
      Caption = data.Properties["Caption"];
      CodeSet = data.Properties["CodeSet"];
      CountryCode = data.Properties["CountryCode"];
      CSName = data.Properties["CSName"];
      CurrentTimeZone = data.Properties["CurrentTimeZone"];
      DataExecutionPrevention_32BitApplications = data.Properties["DataExecutionPrevention_32BitApplications"];
      DataExecutionPrevention_Available = data.Properties["DataExecutionPrevention_Available"];
      DataExecutionPrevention_Drivers = data.Properties["DataExecutionPrevention_Drivers"];
      DataExecutionPrevention_SupportPolicy = data.Properties["DataExecutionPrevention_SupportPolicy"];
      Debug = data.Properties["Debug"];
      Description = data.Properties["Description"];
      Distributed = data.Properties["Distributed"];
      EncryptionLevel = data.Properties["EncryptionLevel"];
      ForegroundApplicationBoost = data.Properties["ForegroundApplicationBoost"];
      InstallDate = data.Properties["InstallDate"];
      LastBootUpTime = data.Properties["LastBootUpTime"];
      Locale = data.Properties["Locale"];
      Manufacturer = data.Properties["Manufacturer"];
      MUILanguages = data.Properties["MUILanguages"];
      Name = data.Properties["Name"];
      NumberOfLicensedUsers = data.Properties["NumberOfLicensedUsers"];
      OperatingSystemSKU = data.Properties["OperatingSystemSKU"];
      Organization = data.Properties["Organization"];
      OSArchitecture = data.Properties["OSArchitecture"];
      OSLanguage = data.Properties["OSLanguage"];
      OSProductSuite = data.Properties["OSProductSuite"];
      OSType = data.Properties["OSType"];
      OtherTypeDescription = data.Properties["OtherTypeDescription"];
      PortableOperatingSystem = data.Properties["PortableOperatingSystem"];
      Primary = data.Properties["Primary"];
      ProductType = data.Properties["ProductType"];
      RegisteredUser = data.Properties["RegisteredUser"];
      SerialNumber = data.Properties["SerialNumber"];
      ServicePackMajorVersion = data.Properties["ServicePackMajorVersion"];
      ServicePackMinorVersion = data.Properties["ServicePackMinorVersion"];
      Status = data.Properties["Status"];
      SystemDevice = data.Properties["SystemDevice"];
      SystemDirectory = data.Properties["SystemDirectory"];
      SystemDrive = data.Properties["SystemDrive"];
      Version = data.Properties["Version"];
      WindowsDirectory = data.Properties["WindowsDirectory"];
    }

    public string BootDevice { get; private set; }
    public string BuildNumber { get; private set; }
    public string BuildType { get; private set; }
    public string Caption { get; private set; }
    public string CodeSet { get; private set; }
    public string CountryCode { get; private set; }
    public string CSName { get; private set; }
    public string CurrentTimeZone { get; private set; }
    public string DataExecutionPrevention_32BitApplications { get; private set; }
    public string DataExecutionPrevention_Available { get; private set; }
    public string DataExecutionPrevention_Drivers { get; private set; }
    public string DataExecutionPrevention_SupportPolicy { get; private set; }
    public string Debug { get; private set; }
    public string Description { get; private set; }
    public string Distributed { get; private set; }
    public string EncryptionLevel { get; private set; }
    public string ForegroundApplicationBoost { get; private set; }
    public string InstallDate { get; private set; }
    public string LastBootUpTime { get; private set; }
    public string Locale { get; private set; }
    public string Manufacturer { get; private set; }
    public string MUILanguages { get; private set; }
    public string Name { get; private set; }
    public string NumberOfLicensedUsers { get; private set; }
    public string OperatingSystemSKU { get; private set; }
    public string Organization { get; private set; }
    public string OSArchitecture { get; private set; }
    public string OSLanguage { get; private set; }
    public string OSProductSuite { get; private set; }
    public string OSType { get; private set; }
    public string OtherTypeDescription { get; private set; }
    public string PortableOperatingSystem { get; private set; }
    public string Primary { get; private set; }
    public string ProductType { get; private set; }
    public string RegisteredUser { get; private set; }
    public string SerialNumber { get; private set; }
    public string ServicePackMajorVersion { get; private set; }
    public string ServicePackMinorVersion { get; private set; }
    public string Status { get; private set; }
    public string SystemDevice { get; private set; }
    public string SystemDirectory { get; private set; }
    public string SystemDrive { get; private set; }
    public string Version { get; private set; }
    public string WindowsDirectory { get; private set; }
  }
}
