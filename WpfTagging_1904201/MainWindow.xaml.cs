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
using System.Windows.Controls;

namespace WpfTagging_1904201
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private ObservableCollection<Project> Projects = new ObservableCollection<Project>();
    private ProjectWindowsArgs windowArgs = new ProjectWindowsArgs();

    public string SelectedWeekNoCompact;
    public int SelectedWeekNoMaxumumCount;

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
      var Sorted = Projects.OrderByDescending(m => m.WeekNoReference);
      //string json = JsonConvert.SerializeObject(Projects, Formatting.Indented);
      string json = JsonConvert.SerializeObject(Sorted, Formatting.Indented);
      using (StreamWriter stream = new StreamWriter(GetJsonFileName("Projects")))
      {
        stream.Write(json);
      }
    }

    private void ProjectAdd()
    {
      Project project = new Project
      {
        WeekNoCompact = SelectedWeekNoCompact,
        Count = SelectedWeekNoMaxumumCount + 1
      };

      windowArgs.Save = false;
      ProjectWindow window = new ProjectWindow(project, windowArgs);
      window.ShowDialog();

      if (!windowArgs.Save)
      {
        //Cancelled
        return;
      }

      Projects.Add(windowArgs.ProjectScreen);
      ProjectDate_SelectedDateChanged();
    }

    private void ProjectEdit(Project project)
    {
      windowArgs.Save = false;
      ProjectWindow window = new ProjectWindow(project, windowArgs);
      window.ShowDialog();

      if (!windowArgs.Save)
      {
        return;
      }

      int Counter = 0;
      while (Projects[Counter].WeekNoReference != windowArgs.ProjectScreen.WeekNoReference &&
        Counter < Projects.Count)
      {
        Counter++;
      }
      Projects[Counter] = windowArgs.ProjectScreen;
    }

    private void ProjectDate_SelectedDateChanged()
    {
      DateTimeWeekNumber dwn = new DateTimeWeekNumber(DatePickerProjectDate.SelectedDate.Value);
      SelectedWeekNoCompact = dwn.WeekNoCompact;

      SelectedWeekNoMaxumumCount = GetSelectedWeekNoMaxumumCount(SelectedWeekNoCompact);

      CurrentWeekNoCompact.Text = $"WeekRef: {SelectedWeekNoCompact}";
      CurrentWeekNoCount.Text = $"Max: {SelectedWeekNoMaxumumCount}";
    }

    private int GetSelectedWeekNoMaxumumCount(string selectedWeekNoCompact)
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

    #region Buttons and MenuItems
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
    #endregion

    private void DataGridProject_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
      object SelectedRow = ((DataGrid)e.Source).CurrentItem;
      Project Edit = (Project)SelectedRow;

      ProjectEdit(Edit);
    }

  }
}