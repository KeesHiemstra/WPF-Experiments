using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTagging_1904201.Models
{
  public class Project
  {
    /// <summary>
    /// WeekNumberCompact followed with a follow number (2 digits) e.g. 1904201
    /// </summary>
    public string WeekNoReference
    {
      get { return $"{WeekNoCompact}{Count.ToString("D2")}"; }
    }

    /// <summary>
    /// WeekNumberCompact (yyWWD) e.g. 19042
    /// </summary>
    public string WeekNoCompact { get; set; }

    /// <summary>
    /// Count in the day e.g. 1
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// e.g. WpfTagging
    /// </summary>
    public string ProjectName { get; set; }

    /// <summary>
    /// e.g.
    /// </summary>
    public string Title { get; set; }

    public Project Copy()
    {
      Project copy = new Project();
      copy = (Project)this.MemberwiseClone();

      return copy;
    }

    public static Project CopyX(Project copy)
    {
      Project Backup = new Project
      {
        WeekNoCompact = copy.WeekNoCompact,
        Count = copy.Count,
        ProjectName = copy.ProjectName,
        Title = copy.Title
      };
      return Backup;
    }
  }
}
