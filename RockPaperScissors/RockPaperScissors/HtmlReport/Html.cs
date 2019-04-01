using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace RockPaperScissors.HtmlReport
{
    public static class Html
    {
        public static void Generate()
        {
            try
            {
                var transform = new XslCompiledTransform();
                transform.Load(GetXslFile());
                transform.Transform(GetXmlFile(), GetHtmlFile());
                Console.WriteLine("HTML file saved to {0}", GetHtmlFile());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}",e);
            }
        }

        private static string GetParent()
        {
            return @"C:\Users\george_serban\rock-paper-scissors\RockPaperScissors";
        }

        private static string GetXmlFile()
        {
            return GetParent() + @"\NUnitTests\bin\Debug\TestResult.xml";
        }

        private static string GetXslFile()
        {
            return GetParent() + @"\report.xsl";
        }

        private static string GetHtmlFile()
        {
            return GetParent() + @"\HtmlReport\report.html";
        }
    }
}
