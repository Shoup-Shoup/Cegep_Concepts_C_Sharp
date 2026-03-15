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



            EstUtilisateurValide2("BOB", 20);
            ///AfficherMessageTest("fred")

            AfficherMessageTest("Mari");

            //Je veux calculer la valeur pour une fonction mathématique y=mx+b
            //Demander à l'utilisateur `m` et 'b' pour définir la fonction
            //Ensuite on demande de founir le "y" associé au "x" demander

            double valeurM = DemanderDouble("m");

            double valeurB = DemanderDouble("b");


            Console.WriteLine($"Vous avez défini la fonction comme suit: y = {valeurM}*x+{valeurB}");

            int minimum = TrouverMin(10, 35);
            Console.WriteLine($"minimum: {minimum}");

            List<int> liste = new List<int>() { 1, 2, 3, 4, 5 };
            int min = liste[0];
            int max = liste[0];
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

        //Après le main, ici qu'on met nos fonctions:
        //private static typeDeRetour nomFonction(paramètres)
        //type de retour: void (aucune valeur de retour), int, double, string, list<int>, int[]...
        //Paramètres: type nom, type nom, ....

        //Nom fonction: PascalCase, pas accent, verbe d'action:
        ///Bien: Afficher..., Calculer..., Lire...
        ///Mauvais: Nombre..., Calcul..., Faire...
        ///Complément: le^plus descriptif possible
        ///Bien: AfficherResultats, CalculerMoyenne, LireEntier
        ///Mauvais: Affficher, CalculerNombre
        ///ex pour bool: Est..., estImpaire, estNombreValide

        //Faut appeler la fonction, sinon rien se passe
        private static void AfficherMessageTest(string nom)//--> signature de la fonction
        {
            //Corps de la fonction:
            Console.WriteLine($"Bonjour {nom}");
        }

        //Ca met deux truc en un (m et b)
        private static double DemanderDouble(string nomValeur)
        {
            Console.Write($"Entrer la valeur {nomValeur}: ");
            bool estValide = double.TryParse(Console.ReadLine(), out double valeur);

            while (!estValide)
            {
                Console.WriteLine($"Erreur: la valeur {nomValeur} doit etre un nombre valide.");
                Console.Write($"Entrer la valeur {nomValeur}: ");
                estValide = double.TryParse(Console.ReadLine(), out valeur);
            }

            return valeur;
        }

        private static int TrouverMin(int nombre1, int nombre2)
        {
            if (nombre1 < nombre2)
            {
                return nombre1;
            }
            else
            {
                return nombre2;
            }
        }
        private static int TrouverMax(int nombre1, int nombre2)
        {
            if (nombre1 > nombre2)
            {
                return nombre1;
            }
            else
            {
                return nombre2;
            }
        }
        private static void TrouverMinMaxList(List<int> liste, out int min, out int max)
        {
            min = liste.Min();
            max = liste.Max();
        }


        //Valide si: nom > 5 caractères et que majeur
        private static bool EstUtilisateurValide(string nom, int age)
        {
            if (nom.Length > 5)
            {
                //nom valide
                if (age >= 18)
                {
                    //tout valide
                    return true;
                    Console.WriteLine("Valide");
                }
                else
                {
                    Console.WriteLine("Erreur, mineur");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Erreur, nom trop court");
                return false;
            }
        }

        //Version avec: condition de garde, "early return"
        private static bool EstUtilisateurValide2(string nom, int age)
        {
            if (nom.Length < 5)
            {
                Console.WriteLine("Erreur, nom trop court");
                return false;
            }

            //ici forcément le nom est valide

            if (age < 18)
            {
                Console.WriteLine("Erreur, mineur");
                return false;
            }

            Console.WriteLine("Valide");
            return true;

        }
    }
    
}
