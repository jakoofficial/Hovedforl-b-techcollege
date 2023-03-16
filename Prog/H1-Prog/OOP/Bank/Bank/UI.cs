using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class UI
    {

        public static void GetMenu()
        {
            PrintTextNL($"Welcome to the bank", ConsoleColor.Blue);
            PrintTextSL("1 ", ConsoleColor.Cyan); PrintTextNL("| see balance");
            PrintTextSL("2 ", ConsoleColor.Green); PrintTextNL("| deposit to account");
            PrintTextSL("3 ", ConsoleColor.Red); PrintTextNL("| withdraw from account");
            PrintTextSL("4 ", ConsoleColor.DarkYellow); PrintTextNL("| log out");

        }
        public static void End()
        {
            Console.Clear();
            Console.WriteLine("Thanks for using the bank");
        }

        public static void PrintTextNL(string text, ConsoleColor cc = ConsoleColor.White)
        {
            Console.ForegroundColor = cc;
            Console.WriteLine($"{text}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void PrintTextSL(string text, ConsoleColor cc = ConsoleColor.White)
        {
            Console.ForegroundColor = cc;
            Console.Write($"{text}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static double Input(string text)
        {
            Console.Clear();
            Console.Write(text);
            double.TryParse(Console.ReadLine(), out double inp);
            return inp;
        }
        public static double Input()
        {
            double.TryParse(Console.ReadLine(), out double inp);
            return inp;
        }
    }
}
