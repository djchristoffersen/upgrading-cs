using System;

namespace Wincubate.CS7xQuiz.Question04
{
    class Program
    {
        static void Main( string[] args )
        {
            object[] array = new string[5];
            array[0] = "Hello, World!";
            array[1] = "Covariance";

            array[0] = 87;
            Console.WriteLine(array[0]);
        }
    }

    // Compile-time error
    // Run-time error
    // Prints "Hello, World"
    // Prints 87
}
