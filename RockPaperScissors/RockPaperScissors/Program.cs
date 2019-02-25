using System;
using RockPaperScissors.DBConnection;
using RockPaperScissors.GameRules;
using RockPaperScissors.Report;


namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.DisplayGame();
            game.ChooseGame();

            /*var template = new HtmlTemplate(@"C:\Users\george_serban\rock-paper-scissors\Template.txt");
            var output = template.Render(new
            {
                TITLE = "Report",
                METAKEYWORDS = "key1, key2, key3",
                BODY = "Body content",
                ETC = "etc"
            });*/
            //Console.WriteLine(output);
            Console.ReadLine();

        }
    }

}
