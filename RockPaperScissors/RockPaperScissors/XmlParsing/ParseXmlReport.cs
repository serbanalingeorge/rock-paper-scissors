using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RockPaperScissors.XmlParsing
{
    public static class ParseXmlReport
    {
        private const string FilePath = @"C:\Users\george_serban\rock-paper-scissors\RockPaperScissors\NUnitTests\bin\Debug\TestResult.xml";

        public static void PrintToConsole()
        {
            var xmlDoc = new XmlDocument(); 

            xmlDoc.Load(FilePath); 

            var testCases = xmlDoc.GetElementsByTagName("test-case");

            Console.WriteLine("Unit Test Report");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("STATUS |   TIME   | TEST NAME");
            Console.WriteLine("-----------------------------");
            
            foreach (XmlElement val in testCases)
            {
                Console.WriteLine(val.GetAttribute("result") + " | " + val.GetAttribute("duration") + " | " + val.GetAttribute("fullname"));
                
            }
            xmlDoc.PreserveWhitespace = true;
            xmlDoc.Save(@"C:\Users\george_serban\rock-paper-scissors\RockPaperScissors\report.xml");
        }
    }
}
