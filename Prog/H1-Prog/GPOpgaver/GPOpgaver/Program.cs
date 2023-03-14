using System;
using System.Runtime.InteropServices;

namespace GPOpgaver
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Opgaver.IsPalindrome("homoh"));
            Console.WriteLine(Opgaver.IsPalindrome("kayak"));

            Console.ReadLine();
        }
    }
}
