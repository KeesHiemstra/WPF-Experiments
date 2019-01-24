using System;
using System.Windows;
using System.Reflection;
using WpfTagging_1904201.Models;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.IO;
using CHiDateTimeWeekNumber;
using System.ComponentModel;
using System.Linq;

namespace WpfTagging_1904201
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private ObservableCollection<Project> Projects = new ObservableCollection<Project>();
    private string SelectedWeekNoCompact;

    public MainWindow()
    {
      FileOpen();

      InitializeComponent();

      DatePickerProjectDate.SelectedDate = DateTime.Now;
      DatePickerProjectDate.DisplayDateEnd = DateTime.Now;

      UpdateDataGridProjects(true);
    }

    private void UpdateDataGridProjects(bool initialize = false)
    {
      DataGridProject.DataContext = null;
      if (initialize)
      {
        DataGridProject.Columns[0].SortDirection = ListSortDirection.Descending;
      }
      DataGridProject.DataContext = Projects;
    }

    private void DisplayWeekNoCompact()
    {

    }

    private void FileExit()
    {
      this.Close();
    }

    private void FileOpen()
    {
      using (StreamReader stream = File.OpenText(GetJsonFileName("Projects")))
      {
        string json = stream.ReadToEnd();
        Projects = JsonConvert.DeserializeObject<ObservableCollection<Project>>(json);
      }
    }

    private void FileSave()
    {
      string json = JsonConvert.SerializeObject(Projects, Formatting.Indented);
      using (StreamWriter stream = new StreamWriter(GetJsonFileName("Projects")))
      {
        stream.Write(json);
      }
    }

    private void ProjectAdd()
    {
      throw new NotImplementedException();
    }

    private void ProjectDate_SelectedDateChanged()
    {
      DateTimeWeekNumber dwn = new DateTimeWeekNumber(DatePickerProjectDate.SelectedDate.Value);
      SelectedWeekNoCompact = dwn.WeekNoCompact;

      int SelectedWeekNoCount = GetMaximumCount(SelectedWeekNoCompact);

      CurrentWeekNoCompact.Text = $"WeekRef: {SelectedWeekNoCompact}";
      CurrentWeekNoCount.Text = $"Max: {SelectedWeekNoCount}";
    }

    private int GetMaximumCount(string selectedWeekNoCompact)
    {
      int result = 0;

      if (Projects == null)
      {
        return result;
      }

      var select = from s in Projects
                   where s.WeekNoCompact == selectedWeekNoCompact
                   select s.Count;
      if (select.Count() != 0)
      {
        result = select.Max();
      }

      return result;
    }

    private string GetJsonFileName(string FileName)
    {
      string OneDrive = Environment.GetEnvironmentVariable("OneDrive");

      return $"{OneDrive}\\Data\\{FileName}.json"; ;
    }

    private void HelpAbout()
    {
      Assembly thisAssembly = typeof(MainWindow).Assembly;
      AssemblyName thisAssemblyName = thisAssembly.GetName();

      Version version = thisAssemblyName.Version;

      MessageBox.Show($"Version: {version}", "About");
    }

    private void ButtonProjectAdd_Click(object sender, RoutedEventArgs e)
    {
      ProjectAdd();
    }

    private void MenuItemDataRefresh_Click(object sender, RoutedEventArgs e)
    {
      UpdateDataGridProjects();
    }

    private void MenuItemFileExit_Click(object sender, RoutedEventArgs e)
    {
      FileExit();
    }

    private void MenuItemFileOpen_Click(object sender, RoutedEventArgs e)
    {
      FileOpen();
    }

    private void MenuItemFileSave_Click(object sender, RoutedEventArgs e)
    {
      FileSave();
    }

    private void MenuItemHelpAbout_Click(object sender, RoutedEventArgs e)
    {
      HelpAbout();
    }

    private void DatePickerProjectDate_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
      ProjectDate_SelectedDateChanged();
    }

  }
}