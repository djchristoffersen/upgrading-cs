using System;

namespace Wincubate.CS7xQuiz.Question01
{
    interface I1
    {
        void DoStuff( int x = 42 );
    }

    interface I2
    {
        void DoStuff( int x = 87 );
    }

    class A : I1, I2
    {
        public void DoStuff( int x = 112 ) => Console.WriteLine( x );
        void I2.DoStuff( int x ) => DoStuff( x );
    }

    class Program
    {
        static void Main(string[] args)
        {
            I2 o = new A();
            o.DoStuff();
        }
    }
}
