using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_1911501.Models
{
  public class Win32_BIOS
  {
    public Win32_BIOS(WmiRecord data)
    {
      Manufacturer = data.Properties["Manufacturer"];
      SerialNumber = data.Properties["SerialNumber"];
      SMBIOSBIOSVersion = data.Properties["SMBIOSBIOSVersion"];
    }

    public string Manufacturer { get; private set; }
    public string SerialNumber { get; private set; }
    public string SMBIOSBIOSVersion { get; private set; }
  }
}
