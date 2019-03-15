using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ITAMLib.Models
{
  public class WmiProperty
  {
    public string Name { get; set; }
    public string Type { get; set; }
    public string Value { get; set; }

    public WmiProperty(PropertyData data)
    {
      Name = data.Name;
      Type = data.Type.ToString();
      if (data.Value == null)
      {
        // Return <null> if the data null
        Value = "<null>";
      }
      else if (data.IsArray)
      {
        // Return a string formatted {data[, ]...}
        string array = "";

        if (data.Value.GetType() == typeof(string[]))
        {
          foreach (string item in (string[])data.Value)
          {
            if (!string.IsNullOrEmpty(array))
            {
              array += ", ";
            }

            array += item;
          }
        }
        else if (data.Value.GetType() == typeof(UInt16[]))
        {
          foreach (UInt16 item in (UInt16[])data.Value)
          {
            if (!string.IsNullOrEmpty(array))
            {
              array += ", ";
            }

            array += item.ToString();
          }
        }
        else
        {
          // The array can't use known format
          array = "<unknown>";
        }
        Value = "array {" + array + "}";
      }
      else if (data.Type.ToString() == "DataTime")
      {
        // Try translate the data as a default data format
        Value = ((DateTime)data.Value).ToString("yyyy-MM-dd HH:mm:ss.fff");
      }
      else
      {
        // Using default ToString() format
        try
        {
          Value = data.Value.ToString();
        }
        catch (Exception ex)
        {
          Value = $"Data error: {ex.Message}";
        }
      }
    }
  }
}
