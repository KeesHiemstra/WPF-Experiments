using ITAMLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_1911501
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    //Win32_BIOS_List win32_Bios = new Win32_BIOS_List("Win32_BIOS", "CurrentLanguage,Manufacturer,Name,PrimaryBIOS,ReleaseDate,SerialNumber,SMBIOSBIOSVersion,Version");
    //Win32_OperatingSystem_List win32_Operatingsystem = new Win32_OperatingSystem_List("Win32_OperatingSystem", "BootDevice,BuildNumber,BuildType,Caption,CodeSet,CountryCode,CSName,CurrentTimeZone,DataExecutionPrevention_32BitApplications,DataExecutionPrevention_Available,DataExecutionPrevention_Drivers,DataExecutionPrevention_SupportPolicy,Debug,Description,Distributed,EncryptionLevel,ForegroundApplicationBoost,InstallDate,LastBootUpTime,Locale,Manufacturer,MUILanguages,Name,NumberOfLicensedUsers,OperatingSystemSKU,Organization,OSArchitecture,OSLanguage,OSProductSuite,OSType,OtherTypeDescription,PortableOperatingSystem,Primary,ProductType,RegisteredUser,SerialNumber,ServicePackMajorVersion,ServicePackMinorVersion,Status,SystemDevice,SystemDirectory,SystemDrive,Version,WindowsDirectory");
    Win32_Product_List win32_Product = new Win32_Product_List("Win32_Product", "AssignmentType,HelpLink,HelpTelephone,IdentifyingNumber,InstallDate,InstallLocation,InstallSource,InstallState,Language,LocalPackage,Name,PackageCache,PackageCode,PackageName,ProductID,RegCompany,RegOwner,SKUNumber,Transforms,URLInfoAbout,URLUpdateInfo,Vendor,Version");
    //public Win32_Account_List win32_Account = new Win32_Account_List("Win32_Account", "AccountType,Caption,Description,Disabled,Domain,FullName,InstallDate,LocalAccount,Lockout,Name,PasswordChangeable,PasswordExpires,PasswordRequired,SID,SIDType,Status");
    //public Win32_Environment_List win32_Environment = new Win32_Environment_List("Win32_Environment", "Name,SystemVariable,UserName,VariableValue");

    private static DateTime Start = DateTime.Now;

    public int ItemCount { get { return win32_Product.Items.Count; } }
    public TimeSpan RunTime { get { return DateTime.Now - Start; } }

    public MainWindow()
    {
      InitializeComponent();

      DataContext = this;
    }

    private async void Window_Loaded(object sender, RoutedEventArgs e)
    {
      await GetWin32_Product();
    }

    private async Task GetWin32_Product()
    {
      SoftwareDataGrid.ItemsSource = win32_Product.Items;
    }

  }
}
