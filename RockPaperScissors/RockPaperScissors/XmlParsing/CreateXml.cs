using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RockPaperScissors.XmlParsing
{
    public static class CreateXml
    {
        private const string FilePath = @"C:\Users\george_serban\rock-paper-scissors\RockPaperScissors\test.xml";

        public static void CreateFile()
        {
            var xmlDoc = new XmlDocument();

            if (!File.Exists(FilePath)) return;
            xmlDoc.Load(FilePath);

            var elmRoot = xmlDoc.DocumentElement;

            if (elmRoot != null)
            {
                elmRoot.RemoveAll();  

                var testCases = xmlDoc.CreateElement("testcases");   

                var first = xmlDoc.CreateElement("testcase");

                var second = xmlDoc.CreateElement("testcase");

                var name = xmlDoc.CreateElement("Name"); 
                name.InnerText = "TestCase";   

                var status = xmlDoc.CreateElement("Status");  
                status.InnerText = "Pass"; 

                var duration = xmlDoc.CreateElement("Time"); 
                duration.InnerText = "0.026";  

                first.AppendChild(name); 
                first.AppendChild(status); 
                first.AppendChild(duration);

                testCases.AppendChild(first);
                testCases.AppendChild(second);

                elmRoot.AppendChild(testCases);  
            }

            xmlDoc.Save(FilePath); 
        }

    }
}
