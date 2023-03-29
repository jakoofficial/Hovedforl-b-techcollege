using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    public class Interact
    {
        public static void WriteText(string text, ConsoleColor cc = ConsoleColor.White)
        {

        }

        public static int Input()
        {
            Console.Write("> ");
            int.TryParse(Console.ReadLine(), out int inp);
            return inp;
        }
    }
}
