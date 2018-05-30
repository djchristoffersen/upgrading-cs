using System;

namespace Wincubate.CS7xQuiz.Question09
{
    class Zombie
    {
        public Func<int> X { get; }

        public Zombie()
        {
            int i = 87;
            X = () => ++i;
        }
    }

    class Program
    {
        static void Main( string[] args )
        {
            Zombie z = new Zombie();

            Console.WriteLine(z.X());
            Console.WriteLine(z.X());
            Console.WriteLine(z.X());
        }
    }
}
