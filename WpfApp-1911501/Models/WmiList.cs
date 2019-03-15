using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_1911501.Models
{
  public static class WmiList
  {
    public static ManagementObjectCollection GetCollection(string wmiClass)
    {
      return GetCollection(wmiClass, "*");
    }

    public static ManagementObjectCollection GetCollection(string wmiClass, string Members)
    {
      ConnectionOptions options = new ConnectionOptions();
      options.Impersonation = System.Management.ImpersonationLevel.Impersonate;

      ManagementScope scope = new ManagementScope("\\\\.\\root\\cimv2", options);
      scope.Connect();

      //Query system for Operating System information
      ObjectQuery query = new ObjectQuery($"SELECT {Members} FROM {wmiClass}");

      ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

      ManagementObjectCollection queryCollection = searcher.Get();

      return queryCollection;
    }
  }
}
