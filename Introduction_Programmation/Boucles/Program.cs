using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Classic while loop ---> tant que (0 fois et plus)
            string motDePasseCorrect = "12345";

            Console.WriteLine("entrez le mot de passe: ");
            string motDePasseEntre = Console.ReadLine();

            while (motDePasseEntre != motDePasseCorrect)
            {
                Console.WriteLine("Mot de passe incorrect");
                motDePasseEntre = Console.ReadLine();
            }
            //si on se retrouve ici c'est que le while est faux
            Console.WriteLine("acces autorisé");


            //while loop = repeats some code while some condition remains true

            //Loop of having to enter something
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            while (name == "") //So basically, as long as there is nothing being entered for name, the code will continue to ask you to give it something different
            {
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine($"Hello {name}");


            //Option 2 of loop of having to enter something
            string nameOption2 = "";

            while (nameOption2 == "")
            {
                Console.WriteLine("Enter your name : ");
                nameOption2 = Console.ReadLine();
            }

            Console.WriteLine($"Hello {nameOption2}");


            //infinite loop (a évité)
            /* 
             Console.WriteLine("Enter something: ");
            string something = Console.ReadLine();
            
            while (1 == 1) //since 1 is always gonna be = 1, the message in the loop will be shown infinetly, but then since it's infinite you can't really write code afterwards
            {
                Console.WriteLine("help, i am stuck in an infinite loop...");              
            }
            */


            // do while: it will execute what's inside de loop before it checks the condition

            //Will show me the number once and then realize it doesn't respect the condition so it won't show it again after the first time
            int nombre = 6;
            do
            {
                Console.WriteLine(nombre);

            } while (nombre <= 5);


            //do/while ---> (1 fois ou plus) utiliser pour faire des menu (ex télés) 
            string optionChoisis;
            do
            {
                Console.WriteLine("Menu\nOption 1: Sport \nOption 2: Nature \nQ pour quitter le menu");
                optionChoisis = Console.ReadLine();

                switch (optionChoisis)
                {
                    case "1":
                        Console.WriteLine("sport");
                        break;
                    case "2":
                        Console.WriteLine("nature");
                        break;
                }
            } while (optionChoisis == "Q"); //donc si tu pese sur Q, ca va recommencer a te montrer les options


            //Boucle qui ne sera jamais vrai 
            int chiffre = -1;
            while (chiffre > 0)
            {
                Console.WriteLine("doesnt matter cuz you never gonna see this");
            }

            //utilité boucles: faire un travail plusieursfois
            //avec un while et do while: nombre indéterminé et répétitions
            //surtout pour une entrée utilisateur. ex: moyenne

            int nombreElement = 0;
            double somme = 0.0;
            double moyenne = 0.0;
            string entreeUtilisateur;

            do
            {
                //Travail (a effectuer X nombre de fois, selon l'utilisateur...)
                Console.WriteLine("Entrer un nombre, Q pour quitter: ");
                entreeUtilisateur = Console.ReadLine();
                bool estNombreValide = double.TryParse(entreeUtilisateur, out double nombre);

                if (estNombreValide)
                {
                    nombreElement++; //Equivalent a += 1
                    somme += nombre;
                }
                else if (entreeUtilisateur != "Q")
                {
                    Console.WriteLine("Invalide");
                }

            } while (entreeUtilisateur != "Q");

            moyenne = somme / nombreElement;
            Console.WriteLine($"moyenne = {moyenne}");

            //EX: afficher Bonjour 1!, Bonjour 2! ... jusqu'a 10!
            //on doit garder en mémoire un compteur

            int compteur = 1;
            while (compteur <= 10) //pour que ca arrete a 10
            {
                //travail
                Console.WriteLine($"Bonjour {compteur}!");
                compteur++; // tres important de mettre le compteur a jour, sinon ca va faire une boucle a l'infini

            }


            //A for loop will execute a code a finite amount of time, unlike the while loop that execute as long as the condition is true (so kind of infinetly)
            // Structure typique d'une boucle avec un nombre déterminé de répétitions:
            /*
             * (1) Compteur/Itérateur
             * int compteur/intérateur 
             * 
             * (2) Condition
             * while compteur < x
             * 
             * { Travail }
             *
             * (3) Incrémentation
             * compteur ++
             */

            // for( (1) itérateur; (2) condition; (3) incrémentation ) {Travail} --> les trois criteres sur la mm ligne
            for (int iterateur = 1; iterateur <= 10; iterateur++)
            {
                //travail
                Console.WriteLine($"\n\nBonjour {iterateur}!");
            }


            // situation: Je veux afficher bonjour a tous les étudiants (#1000, #2000, #3000 ... #18000)

            //Etape 1: identifier le travail répétitif
            // Bonjour #X (X varie)

            //etape 2: trouver le nombre d'itération
            //18 étudiants a qui on va dire bonjour donc: 18 = itération
            const int NOMBRE_ETUDIANTS = 18; //devrait aller au dessus du main

            for (int i = 0; i < NOMBRE_ETUDIANTS; i++) //commence les itérateur a 0 (donc 1 = 0)
            {
                // travail
                int numeroEtudiant = 1000 * (i + 1); // +1 pour commencer a #1000
                Console.WriteLine($"Bonjour etudiant # {numeroEtudiant}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i <= NOMBRE_ETUDIANTS; i++)
            {
                // travail
                int numeroEtudiant = 1000 * i; // pas besoin de faire +1 pcq on commence déja a 1
                Console.WriteLine($"Bonjour etudiant # {numeroEtudiant}");

                // autre travail: afficher "groupe de 5" chaque fois que 5 étudiants ont été affichés:
                if (i % 5 == 0)//modulo pour diviser en chaque groupe de 5
                {
                    Console.WriteLine("groupe de 5");
                }

            }

            //travailler a l'envers
            // compte a rebours: 10, 9, 8 ... Bonne année!
            const int DECOMPTE = 10;

            for (int i = DECOMPTE; i >= 0; i--)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("Bonne année!");


            //on voudrait enlever le 0:
            for (int i = DECOMPTE; i >= 0; i--)
            {
                if (i != 0)//Pourquoi faire une condition et un tour de boucle supplémentaire? plutôt ajuster limite boucle (correction: > et non >=)
                {
                    Console.WriteLine($"{i}");
                }

                Console.WriteLine($"{i}");
            }
            Console.WriteLine("Bonne année!");



            //Autre solution: si je veux pas compter a l'envers
            for (int i = 0; i < DECOMPTE; i++)
            {
                int compte = DECOMPTE - i;
                Console.WriteLine($"{compte}");
            }
            Console.WriteLine("Bonne année!");

            Console.WriteLine();
            Console.WriteLine();

            //Boucles imbriquées
            //Faire 5 fois le travail T
            //Faire 3 fois (5 fois le Tavail T)
            /*
             * 1 2 3 4 5
             * 1 2 3 4 5
             * 1 2 3 4 5
             */

            // On va écrir le programme " a la main"
            Console.WriteLine("1 ");
            Console.WriteLine("2 ");
            Console.WriteLine("3 ");
            Console.WriteLine("4 ");
            Console.WriteLine("5 ");

            Console.WriteLine();
            Console.WriteLine();


            //ecrir en for loop 3 fois, mais c'est une mauvaise facons de le faire si on veut l'avoir 1000 fois
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(" ");
            }
            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(" ");
            }
            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(" ");
            }
            Console.WriteLine();

            Console.WriteLine();

            //meilleure facons de le faire: on a mis la boucle de l'affichage de 1 2 3 4 5 dans une boucle pour afficher ca 3 fois
            for (int ligne = 0; ligne < 3; ligne++)// 3 fois
            {
                for (int i = 1; i <= 5; i++)//5 fois et ce 3 fois, donc 15 nombres au total
                {
                    Console.WriteLine(i);
                    Console.WriteLine(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Exercice 1 - A

            for (int i = 1; i <= 5; i++) //La trace: i = 1, 2, 3, 4, 5 
            {
                Console.WriteLine(i);
                Console.WriteLine(" ");
            }

            //Console:
            /*
             * 1 2 3 4 5
             */
        }
    }
}
