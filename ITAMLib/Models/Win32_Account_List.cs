using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ITAMLib.Models
{
  public class Win32_Account_List
  {
    public string ComputerName { get; set; }
    public List<Win32_Account> Items = new List<Win32_Account>();

    public Win32_Account_List(string WmiClass, string members)
    {
      ComputerName = System.Environment.MachineName;
      CollectWmiClass(WmiClass, members);
    }

    private async void CollectWmiClass(string wmiClass, string members)
    {
      Items.Clear();

      foreach (ManagementObject managementObject in WmiList.GetCollection(wmiClass, members))
      {
        try
        {
          WmiRecord record = new WmiRecord(members);
          foreach (PropertyData propertyData in managementObject.Properties)
          {
            record.ProcessProperty(propertyData);
          }
          Items.Add(new Win32_Account(record));
        }
        catch { }
      }
    }
  }

}




