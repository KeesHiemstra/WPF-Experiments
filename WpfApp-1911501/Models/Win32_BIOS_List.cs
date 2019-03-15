using System;
using System.Collections.Generic;
using System.Management;
using System.Windows;

namespace WpfApp_1911501.Models
{
  public class Win32_BIOS_List
  {
    public string ComputerName { get; set; }
    public List<Win32_BIOS> Items = new List<Win32_BIOS>();

    public Win32_BIOS_List(string WmiClass)
    {
      ComputerName = System.Environment.MachineName;
      CollectWmiClass(WmiClass);
    }

    private void CollectWmiClass(string wmiClass)
    {
      Items.Clear();

      ConnectionOptions options = new ConnectionOptions();
      options.Impersonation = System.Management.ImpersonationLevel.Impersonate;

      ManagementScope scope = new ManagementScope("\\\\.\\root\\cimv2", options);
      scope.Connect();

      //Query system for Operating System information
      ObjectQuery query = new ObjectQuery($"SELECT * FROM {wmiClass}");

      ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

      ManagementObjectCollection queryCollection = searcher.Get();

      try
      {
        foreach (ManagementObject managementObject in queryCollection)
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
