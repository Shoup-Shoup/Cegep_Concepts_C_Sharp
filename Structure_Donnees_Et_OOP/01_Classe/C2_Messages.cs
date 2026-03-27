using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classe
{
    /*
     * Exemple 2: Classe a l'extérieur de Program.cs
     */

    static internal class C2_Messages
    {
        public static void Hello()
        {
            Console.WriteLine("Hello, welcome to this programe");
        }

        public static void Waiting()
        {
            Console.WriteLine("I am waiting for something");
        }

        public static void Bye()
        {
            Console.WriteLine("Goodbye! Thanks for visiting");
        }
    }
}