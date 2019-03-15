using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_1911501.Models
{
  public class Win32_BIOS
  {
    private string _manufacturer;
    private string _serialNumber;
    private string _sMBIOSBIOSVersion;

    public Win32_BIOS(WmiRecord data)
    {
      Manufacturer = data.Properties["Manufacturer"];
      SerialNumber = data.Properties["SerialNumber"];
      SMBIOSBIOSVersion = data.Properties["SMBIOSBIOSVersion"];
    }

    //Manufacturer	String	Hewlett-Packard
    public string Manufacturer { get => _manufacturer; set => _manufacturer = value; }

    //SerialNumber	String	CNU402BVC3
    public string SerialNumber { get => _serialNumber; set => _serialNumber = value; }

    //SMBIOSBIOSVersion	String	L71 Ver. 01.04
    public string SMBIOSBIOSVersion { get => _sMBIOSBIOSVersion; set => _sMBIOSBIOSVersion = value; }
  }
}
