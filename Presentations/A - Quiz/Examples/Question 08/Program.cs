using System;

namespace Wincubate.CS7xQuiz.Question08
{
    interface I
    {
        void Execute();
    }

    class A
    {
        public void Execute() => Console.WriteLine( 87 );        
    }

    class B : A, I { }

    class Program
    {
        static void Main(string[] args)
        {
            I b = new B();
            b.Execute();
        }
    }
}
