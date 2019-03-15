using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_1911501.Models
{
  public class WmiRecord
  {
    public Dictionary<string, string> Properties = new Dictionary<string, string>();

    public WmiRecord()
    {

    }

    public void ProcessProperty(PropertyData data)
    {
      WmiProperty property = new WmiProperty(data);
      Properties.Add(property.Name, property.Value);
    } 
  }
}
