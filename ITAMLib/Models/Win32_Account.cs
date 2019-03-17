using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAMLib.Models
{
  public class Win32_Account
  {
    public Win32_Account(WmiRecord data)
    {
      AccountType = data.Properties["AccountType"];
      Caption = data.Properties["Caption"];
      Description = data.Properties["Description"];
      Disabled = data.Properties["Disabled"];
      Domain = data.Properties["Domain"];
      FullName = data.Properties["FullName"];
      InstallDate = data.Properties["InstallDate"];
      LocalAccount = data.Properties["LocalAccount"];
      Lockout = data.Properties["Lockout"];
      Name = data.Properties["Name"];
      PasswordChangeable = data.Properties["PasswordChangeable"];
      PasswordExpires = data.Properties["PasswordExpires"];
      PasswordRequired = data.Properties["PasswordRequired"];
      SID = data.Properties["SID"];
      SIDType = data.Properties["SIDType"];
      Status = data.Properties["Status"];
    }

    public string AccountType { get; private set; }
    public string Caption { get; private set; }
    public string Description { get; private set; }
    public string Disabled { get; private set; }
    public string Domain { get; private set; }
    public string FullName { get; private set; }
    public string InstallDate { get; private set; }
    public string LocalAccount { get; private set; }
    public string Lockout { get; private set; }
    public string Name { get; private set; }
    public string PasswordChangeable { get; private set; }
    public string PasswordExpires { get; private set; }
    public string PasswordRequired { get; private set; }
    public string SID { get; private set; }
    public string SIDType { get; private set; }
    public string Status { get; private set; }
  }
}
