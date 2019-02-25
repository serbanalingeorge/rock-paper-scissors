using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RockPaperScissors.Report
{
    public class HtmlTemplate
    {
        private readonly string html;

        public HtmlTemplate(string templatePath)
        {
            using (var reader = new StreamReader(templatePath))
                html = reader.ReadToEnd();

        }

        public string Render(object values)
        {
            return values.GetType().GetProperties().Aggregate(html, (current, p) => current.Replace("[" + p.Name + "]", (p.GetValue(values, null) as string) ?? string.Empty));
        }
    }
}
