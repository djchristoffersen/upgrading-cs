using System;

namespace Wincubate.CS7xQuiz.Question05
{
    class Program
    {
        static void Swap<T>( ref T a, ref T b ) where T : struct //, new()
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Main( string[] args )
        {
            int i = 42, j = 87;
            Swap(ref i, ref j);
            Console.WriteLine(i);
        }
    }
}
