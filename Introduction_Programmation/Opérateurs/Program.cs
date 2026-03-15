using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Opérateurs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Code

            /*
             *  Commentaires
             *  sur plusieurs lignes
             */

            Console.Write("hello world");

            Console.ReadKey();

            /* a=2 
             * b=2*a +3
             * Pour une variable: type nom = valeur`;
             */
            /*  exemple:  */
            int a = 2;
            int b = 2 * a + 3;


            //Les types de variables
            int c = 15; // int = nb entier
            double salaire = 10.25; //double = nb décimal
            string prenom = "mari"; // string = plusieurs caractères
            char initial = 'm'; // char = un caractère (avec des guillemets simples)


            //Math + - * /
            int fortune1 = 5 + 5;
            int fortune2 = 10 + 2;
            int sommeFortunes = fortune1 + fortune2;

            /*
             * Si (moins de (<) 18 ans), write "mineur"
             * Sinon (>= 18), Write "majeur"
             */

            /*
            *J'ai moins de 18 ans? --> deux coix (oui/non, vrai/faux, true/false)
            *Quel ets ma couleur pref? bcp de choix
            *
            *Booleen est une variable qui est true or false
            *
            */

            bool couleurPrefEstMauve = true; //en int = 1 
            bool estMineur = false; //en int = 0

            //Opérations de comparaisons:
            /* 
             * = (égale)
             * >= (plus grand ou égal)
             * <= (plus petit ou égal)
             * > (plus grand que)
             * < (plus petit que)
             * =! (n'égale pas)
             * == (sert a comparer)
             * 
             * Ex:  couleurPref [ == ] "mauve"
             *      estMageur: age [ >= ] 18 ou [ > ] 17
             *      estMineur: age [ < ] 18 ou age [ <= ] 17
             *      courPrefPasRouge: couleurPref [ =! ] mauve
             */


            string couleurPref = "Mauve";

            bool couleurPrefEstOrange = (couleurPref == "Orange"); //bool nom = condition;
            Console.WriteLine($"Est-ce que ma couleur préféré est le orange?: {couleurPrefEstOrange}");

            //Types, comparer des pommes avec des pommes
            /*
             * ("délicieuseRouge" == "délicieuseRouge") : true
             * ("délicieuseRouge" == "mcIntosh") : false
             * ("délicieuseRouge" == 25.50): erreur (peut pas convertir un string en double)
             */

            bool b1 = (5 == 5);
            Console.WriteLine(b1);
            bool b2 = (5 == 5.0); // conversion possible du int -> double
            Console.WriteLine(b2);

            // conversion char -> int =possible (ex: '5' = 53 en ascii)
            bool b3 = (5 == '5'); // faux, 5 =! 53 (5 en ascii)
            Console.WriteLine(b3);


            //bool b4 = (5 == "5"); erreur
            //bool b5 = ("5" == '5'); erreur

            //Comparer des string
            bool b7 = (10 == 10);
            Console.WriteLine("Bonjour" == "Bonjour"); //true
            Console.WriteLine("bonjour" == "Bonjour"); //false ('b' = 98 et 'B' = 66
            Console.WriteLine("Bonjour" == "Bonjour "); // ' ' = 32
            Console.WriteLine("Bonjour" == "hi"); // faux


            //Opérateurs logique
            string nomprof = "Houssem";
            int ageProf = 35;

            //On pose une condition:
            //pour etre cool, il faut s'appeler "Houssem" et faut etre majeur (pour la biere)
            //comment on traduit ca en code?

            bool estCoolCritere1 = nomprof == "Houssem";
            bool estCoolCritere2 = ageProf > 18;

            bool estCool = estCoolCritere1 && estCoolCritere2; // && = et
            Console.WriteLine(estCool);
            //Pour tester, modifiez un des deux valeurs des premiere variables bool (age et nomProf)

            //Maintenant pour etre cool, on peut s'appeler fred et on laisse fair ela biere
            bool estCoolNewCritere = (nomprof == "Houssem") || (nomprof == "Fred"); // || = ou
            Console.WriteLine(estCoolNewCritere);


            // non/inverse (!)
            //Supposon on dit je suis belle
            bool estBelle = true;

            Console.WriteLine($"Sui-je belle {estBelle}");

            estBelle = false;
            // ou
            estBelle = !estBelle;
            Console.WriteLine($"Sui-je belle {estBelle}");


            //on veut savoir si un nombre est entre 10 et 30 
            int nombre = 10;

            bool estEntre10EtInfini = nombre >= 10;
            bool estEntre20etMoinsInfini = nombre <= 20;
            bool nombreEntre10Et20 = estEntre10EtInfini && estEntre20etMoinsInfini;

            Console.WriteLine($"{nombre} est entre 10 et 20?: {nombreEntre10Et20}");



            //attention au tautologies (tjrs vrai) et condradictions (tjrs faux)
            int température = 29;
            bool iraJouerTennisToujours = température <= 18 || température >= 18; //Sera toujours vrai
            bool iraJouerTennisJamais = température > 18 && température < 18; // Sera toujours faux


            //Modulo (%)
            int quotient = 11 / 5; //Puisque c'est en int (division entiere), j'obtient le résultat, mais il reste le "reste".
            int reste = 11 % 5; //donne le reste de cette divison
            Console.WriteLine($"La division 11/5 donne {quotient} avec un reste de {reste}.");

            //Pair et impaire:
            int nombre2 = 20; //essayer avec 1, 2, 3, 4, 5 ...
            //imprimer a la console si c'est paire ou impaire avec les modulo

            if (nombre % 2 == 0) //si lorsqu'on divise le nombre par deux ca donne 0 RESTE, alors c'est paire, sinon, (S'il y a des reste) c'est impaire. On ne pourrait pas utiliser la division normal pcq il faudrait avoir toutes les possibilité de résultats de division par 2
            {
                Console.WriteLine($"{nombre} est pair");
            }
            else
            {
                Console.WriteLine($"{nombre} est impair");
            }

            // utilité modulo: faire des calculs, vérifier propriétés math des nombres...


            double modulo = 10 % 2;
            Console.WriteLine(modulo);

            double modulo2 = 10 % 3;
            Console.WriteLine(modulo2);

            modulo2 = 10.0 % 3.0; //Ca va ne donner 1 s'il y a un reste, peut importe le nombre de reste
            Console.WriteLine(modulo2);


            //faire des if else que on peut reréférencer après
            bool condition = true;
            int testIfElse = 0;

            if (condition)
            {
                testIfElse = 4;
            }

            testIfElse += 4;

            Console.WriteLine(testIfElse);

        }

    }
    }
}
