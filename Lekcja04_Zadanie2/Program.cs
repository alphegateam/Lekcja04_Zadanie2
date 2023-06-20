using System;
using System.Text;
using System.Collections.Generic;


namespace Zadanie_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lekcja 4, zadanie dowowe 2.
            char a, b, c;
            Console.WriteLine("Podaj pierwszy znak: ");
            a = Console.ReadKey().KeyChar;
            Console.WriteLine("\n Drugi pierwszy znak: ");
            b = Console.ReadKey().KeyChar;
            Console.WriteLine("\n Trzeci pierwszy znak: ");
            c = Console.ReadKey().KeyChar;
            
            Console.WriteLine("Oto wpisane znaki w odwrotnej kolejności: ");
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(a);
        }
    }
}


