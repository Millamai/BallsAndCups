namespace BallsAndCups
{
    /// <summary>
    /// Class <c>Program</c> a small game for playing balls and cups. 
    /// The user gets one change to pick a cup
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vælg, hvilken bæger du tror kuglen ligger i?");
            Console.WriteLine("(Tast 1, 2 eller 3 og tryk enter)");
            Console.WriteLine(" ");

            //Draw the cups
            DrawCups();
            
            //pick a random number between 1 and 3 - if the user chooses this number, he or she
            //has won the game
            Random rnd = new Random();
            int winnerCup = rnd.Next(1, 3);

            //fetch the user input
            string choosenCup = Console.ReadLine();
            if (choosenCup == winnerCup.ToString()) {
                Console.WriteLine("You won the game");
            } else
            { 
                Console.WriteLine("Sorry you lost, the right cup was number:"+winnerCup);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Method <c>DrawCups</c> draws 3 cups into the console, each represented by different colour
        /// </summary>
        private static void DrawCups()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("     #     ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("     #     ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("     #     ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("     1     ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("     2     ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("     3     ");
            //sets default color back again
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
