using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAMLib.Models
{
  public class Win32_Environment
  {
    public Win32_Environment(WmiRecord data)
    {
      Name = data.Properties["Name"];
      SystemVariable = data.Properties["SystemVariable"];
      UserName = data.Properties["UserName"];
      VariableValue = data.Properties["VariableValue"];
    }

    public string Name { get; private set; }
    public string SystemVariable { get; private set; }
    public string UserName { get; private set; }
    public string VariableValue { get; private set; }
  }
}
