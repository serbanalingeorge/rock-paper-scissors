using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public static class HtmlGenerator
    {
        private const string FilePath = @"C:\Users\george_serban\rock-paper-scissors\RockPaperScissors\HtmlReport\htmlreport.html";

        private const string HtmlArgument =
            @"/c C:\Users\george_serban\rock-paper-scissors\RockPaperScissors\NUnit-HTML-Report-Generator\NUnitHTMLReportGenerator.exe C:\Users\george_serban\rock-paper-scissors\RockPaperScissors\NUnitTests\bin\Debug\TestResult.xml C:\Users\george_serban\rock-paper-scissors\RockPaperScissors\HtmlReport\htmlreport.html";

        public static void DeleteOldReport()
        {
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
        }

        private static void StartProcess(string argument)
        {
            var process = new Process();
            var startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden, FileName = "cmd.exe", Arguments = argument
            };
            process.StartInfo = startInfo;
            process.Start();
            process.Close();
        }

        public static void CreateReport()
        {
            try
            {
                StartProcess(HtmlArgument);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
