using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.XmlParsing
{
    public class WriteFile
    {
        private const string FilePath = @"C:\Users\george_serban\rock-paper-scissors\RockPaperScissors\TextFile.txt";
        public void Create(string input)
        {
            using (var file = 
                new System.IO.StreamWriter(FilePath,true))
            {
                file.WriteLine(input);
            }
        }
    }
}
