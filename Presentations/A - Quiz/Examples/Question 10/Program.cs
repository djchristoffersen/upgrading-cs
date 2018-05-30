using System;

namespace Wincubate.CS7xQuiz.Question10
{
    class Program
    {
        static void Main( string[] args )
        {
            //Show((color: ConsoleColor.White));
            Show(color: ConsoleColor.White);
        }

        static void Show(
            string club = "AGF",
            ConsoleColor color = ConsoleColor.DarkBlue
        ) =>
            Console.WriteLine($"{club} playing in {color} jerseys");
    }
}
