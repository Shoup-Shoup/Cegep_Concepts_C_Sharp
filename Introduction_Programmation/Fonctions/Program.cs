using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Fonctions (ou méthodes): 
             *          Une méthode est un bloc de code qui contient un série d'instruction. Elle permet de réutiliser du code 
             *              et de le briser en plusieurs petits problèmes
             *          Elle a un type (string, double, int, etc...)
             *          Elle retourne toujours une valeur de son propre type 
             *          Si le type est void, elle ne retournera pas de valeur
             *          Son nom commence par une lettre majuscule et décrit toujours une action avec un verbe a l'infinitif 
             *              (ex: AfficherInfo)
             *          Elle contient souvant des paramètres (ex: int age, string nom). Ces parèmetres sont déclaré a coté de son nom 
             *              afin de pouvoir les réutiliser a l'intérieur
             */


            /*
             * Example 1: I want to sing happy birthday to 3 different people in a row
             */

            Console.WriteLine("-------------------Without using a method-------------------");
            Console.WriteLine();

            //Person 1
            string name1 = "Mari";
            int age1 = 19;

            //Person 2
            string name2 = "JC";
            int age2 = 23;

            //Person 3
            string name3 = "Cass";
            int age3 = 26;


            Console.WriteLine("Happy birthday to you");
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine($"Happy birthday dear {name1}");
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine();
            Console.WriteLine($"you are {age1} years old");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Happy birthday to you");
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine($"Happy birthday dear {name2}");
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine();
            Console.WriteLine($"you are {age2} years old");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Happy birthday to you");
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine($"Happy birthday dear {name3}");
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine();
            Console.WriteLine($"you are {age3} years old");
            Console.WriteLine();
            Console.WriteLine();

            //we have to rewrite the code 3 times


            Console.WriteLine("-------------------With a method-------------------");
            Console.WriteLine();

            //Je passe en paramètres les variables que je veux utiliser avec ma méthode
            SingHappyBirthday(name1, age1);

            SingHappyBirthday(name2, age2);

            SingHappyBirthday(name3, age3);

            //makes the code way shorter because i only have to write the methode once
        }

        //The methode is created after the main on inside a personalized class
        static void SingHappyBirthday(string name, int age)//pour que la fonctions récupère la variable déclaré dans le main elle doit etre mis comme parametre avec son type en avant, mais n'a pas besoin d'avoir le mm nom que le nom de la variable déclarer dans le main
        {
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine($"Happy birthday dear {name}");//variable name is declared in main
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine();
            Console.WriteLine($"you are {age} years old");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    }
}
