using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAMLib.Models
{
  public class Logging
  {
    private static string logFile;
    private LogAction minimumLogAction = LogAction.Trace;
    public enum LogAction { Error, Warning, Info, Debug, Trace };

    public Logging()
    {
    }

    public Logging(string LogFileName, LogAction MinimumLogAction = LogAction.Debug)
    {
      logFile = LogFileName;
      minimumLogAction = MinimumLogAction;
    }

    public async Task Error(string Message)
    {
      await LogMessage(Message, LogAction.Error);
    }

    public async Task Warning(string Message)
    {
      await LogMessage(Message, LogAction.Warning);
    }

    public async Task Info(string Message)
    {
      await LogMessage(Message, LogAction.Info);
    }

    public async Task Debug(string Message)
    {
      await LogMessage(Message, LogAction.Debug);
    }

    public async Task Trace(string Message)
    {
      await LogMessage(Message, LogAction.Trace);
    }

    private async Task LogMessage(string Message, LogAction Action)
    {
      if (string.IsNullOrEmpty(logFile))
      {
        return;
      }

      if (Action > minimumLogAction)
      {
        return;
      }

      string action;
      switch (Action)
      {
        case LogAction.Error:
          action = "Error";
          break;
        case LogAction.Warning:
          action = "Warn ";
          break;
        case LogAction.Info:
          action = "Info ";
          break;
        case LogAction.Debug:
          action = "Debug";
          break;
        case LogAction.Trace:
          action = "Trace";
          break;
        default:
          action = "info ";
          break;
      }
      string message = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fffff")} [{action}] {Message}";
      using (StreamWriter stream = new StreamWriter(logFile, true))
      {
        await stream.WriteLineAsync(message);
      }
    }
  }
}
