using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            bool test = a == 3;
            Console.WriteLine(test);

            test = a == 4;
            Console.WriteLine(test);

            int monAge = 18;
            bool etreMajeur = monAge >= 18;

            if (etreMajeur)
            {
                Console.WriteLine("je suis majeur");
            }
            else
            {
                Console.WriteLine("je suis mineur");
            }


            //demander un nombre
            //si positif: "bravo", sinon: "dommage"

            Console.WriteLine("entrer un nombre");
            string numeroUtilisateur = Console.ReadLine();
            int numero = int.Parse(numeroUtilisateur);

            if (numero > 0)
            {
                Console.WriteLine("Bravo");
            }

            else if (numero < 0)
            {
                Console.WriteLine("dommage");
            }

            else
            {
                Console.WriteLine("neutre");
            }


            //Demander le mois préféré
            Console.WriteLine("quel est votre mois de naissance?");
            string moisUtilisateur = Console.ReadLine();

            if (moisUtilisateur == "octobre" || moisUtilisateur == "aout")
            {
                Console.WriteLine("Moi aussi");
            }

            else
            {
                Console.WriteLine("u suck");
            }

            //faire un menu
            Console.WriteLine("choisissez\n 1.Les sports \n 2.La nature \n 3.Les nouvelles");
            string choix = Console.ReadLine();

            if (choix == "1")
            {
                Console.WriteLine("Sport");
            }

            else if (choix == "2")
            {
                Console.WriteLine("Nature");
            }

            else if (choix == "3")
            {
                Console.WriteLine("Nouvelles");
            }

            else //est dépendant au if juste avant, peut importe
            {
                Console.WriteLine("invalide");
            }

            //on répete "else if(choix == "X")
            //Sintaxe plus propre: switch
            //variable (string, char, int) de laquelle je veux verifier des valeurs (denombres, pas intervale)
            switch (choix)
            {
                case "1":
                    {
                        Console.WriteLine("sport");
                        break;
                    }

                case "2":
                    Console.WriteLine("nature");
                    break;

                case "3":
                    Console.WriteLine("nouvelle");
                    break;

                default: //comme le else seul
                    Console.WriteLine("invalide");
                    break;
            }

            //Plusieurs valeurs --> meme code: 8 aussi sport
            switch (choix)
            {
                case "1":
                case "8":
                    {
                        Console.WriteLine("sport");
                        break;
                    }

                case "2":
                    Console.WriteLine("nature");
                    break;

                case "3":
                    Console.WriteLine("nouvelle");
                    break;

                default: //comme le else seul
                    Console.WriteLine("invalide");
                    break;
            }

            //scope
            switch (choix)
            {
                case "1":
                    {
                        int resultat = 2;
                        break;
                    }

                case "2":
                    {
                        int resultat = 3; //mettre des accolade3 pour renommer plusieurs fois la variable
                        break;
                    }
            }

            //if dans un switch
            string couleur = "bleu";

            switch (choix)
            {

                case "1":
                    if (couleur == "bleu")
                    {
                        Console.WriteLine("bleu");
                    }
                    break;
            }
        }
    }
}
