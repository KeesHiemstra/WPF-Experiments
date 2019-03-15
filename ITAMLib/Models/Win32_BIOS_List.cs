using ITAMLib.Models;
using System;
using System.Collections.Generic;
using System.Management;
using System.Windows;

namespace ITAMLib.Models
{
  public class Win32_BIOS_List
  {
    public string ComputerName { get; set; }
    public List<Win32_BIOS> Items = new List<Win32_BIOS>();

    public Win32_BIOS_List(string WmiClass, string members)
    {
      ComputerName = System.Environment.MachineName;
      CollectWmiClass(WmiClass, members);
    }

    private void CollectWmiClass(string wmiClass, string members)
    {
      Items.Clear();

      try
      {
        foreach (ManagementObject managementObject in WmiList.GetCollection(wmiClass, members))
        {
          WmiRecord record = new WmiRecord();
          foreach (PropertyData propertyData in managementObject.Properties)
          {
            record.ProcessProperty(propertyData);
          }
          Items.Add(new Win32_BIOS(record));
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Quering the WMI results in an exception:\n{ex.Message}", "Exception", MessageBoxButton.OK, MessageBoxImage.Exclamation);
      }

    }
  }
}
