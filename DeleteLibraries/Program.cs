using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace DeleteLibraries
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      string[] args = Environment.GetCommandLineArgs();
      if (args.Length != 2) Environment.Exit(1);
      
      string installDir = args[1];
      string libDir = Path.Combine(installDir, "Libraries");
      try {
        if (Directory.Exists(libDir)) {
          Directory.Delete(libDir, true);
        }
        if (Directory.Exists(installDir)) {
          Directory.Delete(installDir);
        }
      } catch (Exception) {
        Environment.Exit(1);
      }
    }
  }
}
