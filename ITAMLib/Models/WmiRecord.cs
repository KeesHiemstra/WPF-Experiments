using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ITAMLib.Models
{
  public class WmiRecord
  {
    public Dictionary<string, string> Properties = new Dictionary<string, string>();

    public WmiRecord(string members)
    {
      foreach (var item in members.Split(','))
      {
        Properties.Add(item, "<n/a>");
      }
    }

    public async Task ProcessProperty(PropertyData data)
    {
      WmiProperty property = new WmiProperty(data);
      try
      {
        Properties[property.Name] = property.Value;
      }
      catch { }
    } 
  }
}
