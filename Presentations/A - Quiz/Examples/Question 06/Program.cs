using System;

namespace Wincubate.CS7xQuiz.Question06
{
    // https://www.safaribooksonline.com/library/view/c-in-a/0596001819/ch04s08.html
    class Program
    {
        unsafe static void Main( string[] args )
        {
            ushort[] data = { 0, 1, 2, 3, 4 };
            void Flash( void* pointer )
            {
                byte* b = (byte*)pointer;
                for (int i = 0; i < 10; i++) { *b++ = 0; }
            }
            fixed (ushort* pointer = data) { Flash(pointer); }
            Console.WriteLine(data[4]);
        }
    }
}
