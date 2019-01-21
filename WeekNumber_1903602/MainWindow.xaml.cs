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
using WeekNumber_1903402;

namespace WeekNumber_1903602
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      Date.SelectedDate = DateTime.Now;
      GetWeekNumber();
    }

    private void GetWeekNumber()
    {
      DateTimeWeekNumber dwn = new DateTimeWeekNumber(Date.SelectedDate.Value);
      WeekNumber.Text = dwn.WeekNoCompact;
    }
    
    private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
    {
      GetWeekNumber();
    }

    private void ButtonCopy_Click(object sender, RoutedEventArgs e)
    {
      Clipboard.SetText(WeekNumber.Text);
    }

    private void Date_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
      GetWeekNumber();
    }
  }
}
