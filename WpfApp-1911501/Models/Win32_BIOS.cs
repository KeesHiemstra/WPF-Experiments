using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_1911501.Models
{
  public class Win32_BIOS
  {
    //Manufacturer	String	Hewlett-Packard
    public string	Manufacturer { get; set; }

    //SerialNumber	String	CNU402BVC3
    public string SerialNumber { get; set; }

    //SMBIOSBIOSVersion	String	L71 Ver. 01.04
    public string SMBIOSBIOSVersion { get; set; }
  }

  public class Win32_BIOS_List
  {
    public string ComputerName { get; set; }
    List<Win32_BIOS> Items = new List<Win32_BIOS>();
  }
}
