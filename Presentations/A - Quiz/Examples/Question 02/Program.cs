using System;

namespace Wincubate.CS7xQuiz.Question02
{
    class Program
    {
        static string var
        {
            get
            {
                var var = "var";
                return var;
            }
        }

        static void Main( string[] args )
        {
            string await() => var;
            Console.WriteLine(await());
        }
    }

    // Compile-time error
    // Run-time error
    // Infinite loop at run-time
    // Prints var
}
