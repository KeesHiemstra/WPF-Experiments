using ITAMLib.Models;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ITAMLib.Models
{
  public class Win32_BIOS
  {
    public Win32_BIOS(WmiRecord data)
    {
      CurrentLanguage = data.Properties["CurrentLanguage"];
      Manufacturer = data.Properties["Manufacturer"];
      Name = data.Properties["Name"];
      PrimaryBIOS = data.Properties["PrimaryBIOS"];
      ReleaseDate = data.Properties["ReleaseDate"];
      SerialNumber = data.Properties["SerialNumber"];
      SMBIOSBIOSVersion = data.Properties["SMBIOSBIOSVersion"];
      Version = data.Properties["Version"];
    }

    public string CurrentLanguage { get; private set; }
    public string Manufacturer { get; private set; }
    public string Name { get; private set; }
    public string PrimaryBIOS { get; private set; }
    public string ReleaseDate { get; private set; }
    public string SerialNumber { get; private set; }
    public string SMBIOSBIOSVersion { get; private set; }
    public string Version { get; private set; }
  }
}
