using System;
using System.Linq;

namespace Wincubate.CS7xQuiz.Question07
{
    // https://codeblog.jonskeet.uk/2012/01/30/currying-vs-partial-function-application/
    class Program
    {
        static Func<T1, Func<T2, TResult>> Curry<T1, T2, TResult>( Func<T1, T2, TResult> func )
            => a => b => func(a, b);

        static void Main( string[] args )
        {
            var f = Curry<int, int, int>(( x, y ) => y - x)(5);
            var i = f(7);
            Console.WriteLine(i);
        }
    }
}
