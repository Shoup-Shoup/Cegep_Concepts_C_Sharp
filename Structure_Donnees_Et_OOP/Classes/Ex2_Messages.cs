using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    /*
     * Exemple 2: Classe a l'extérieur de Program.cs
     */

    //On va mettre satic pour le moment, mais jsp pk encore

    static internal class Ex2_Messages
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
