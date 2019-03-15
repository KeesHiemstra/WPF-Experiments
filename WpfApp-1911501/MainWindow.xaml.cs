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
    Win32_BIOS_List BIOS = new Win32_BIOS_List("Win32_BIOS", "Manufacturer,SerialNumber,SMBIOSBIOSVersion");

    public MainWindow()
    {
      InitializeComponent();

      DataContext = BIOS.Items;
      
    }
  }
}
