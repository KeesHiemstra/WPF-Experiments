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
using System.Windows.Shapes;
using WpfTagging_1904201.Models;

namespace WpfTagging_1904201
{
  /// <summary>
  /// Interaction logic for ProjectWindow.xaml
  /// </summary>
  public partial class ProjectWindow : Window
  {
    private Project projectScreen = new Project();
    private ProjectWindowsArgs windowsArgs = new ProjectWindowsArgs();

    public ProjectWindow(Project projectParameter, ProjectWindowsArgs e)
    {
      projectScreen = projectParameter.Copy();
      windowsArgs = e;
      e.Save = false;
      e.ProjectScreen = projectScreen;

      DataContext = projectScreen;

      InitializeComponent();

      ButtonSave.IsEnabled = !string.IsNullOrWhiteSpace(ProjectName.Text);
      ProjectName.Focus();
    }

    private void ButtonSave_Click(object sender, RoutedEventArgs e)
    {
      windowsArgs.Save = true;
      Close();
    }

    private void ButtonCancel_Click(object sender, RoutedEventArgs e)
    {
      Close();
    }

    private void ProjectName_LostFocus(object sender, RoutedEventArgs e)
    {
      ButtonSave.IsEnabled = !string.IsNullOrWhiteSpace(ProjectName.Text);
    }

    private void ProjectName_TextChanged(object sender, TextChangedEventArgs e)
    {
      if (ButtonSave == null)
      {
        return;
      }
      ButtonSave.IsEnabled = !string.IsNullOrWhiteSpace(ProjectName.Text);
    }
  }

 public class ProjectWindowsArgs
  {
    public bool Save { get; set; }

    public Project ProjectScreen { get; set; }
  }
}
