using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Classes: 
             *      C'est un ramassis de code contenant plusieurs méthodes créer par visual studio et le language 
             *      de programmation qu'on peut utiliser pour exécuté certaine action
             *       Par exemple, il existe la classe Math qui permet d'éxécuté pleins d'opération mathématiques différentes
             */

            /*
             * Exemple 1: Classe console
             */

            //Pour écrir sur la console on peut utiliser la fonction writeline de la class console
            Console.WriteLine("Hello World!");

            //Mais pour écrir des plusieur choses une à côté de l'autre on peut utiliser la méthode write
            Console.Write("Hello World! ");
            Console.Write("Hello World! ");

            /*
             * \b = backspace
             * \n = new line
             * \t = horizontal tab
             * \v = vertical tab
             * \" = show quotation mark
             * \' = show single quotation mark
             * \\ = show backslash
             * \
             */

            Console.ReadKey(); //wait until you click on a key to show the ugly part of the code


            //But des librairies: effectuer des opérations communes, math avancés
            //Math
            double pi = Math.PI;
            double e = Math.E;

            Math.Sqrt(100); //100
            Math.Pow(3, 2); // 3^2 = 9

            //string 
            string nom = "Fred";
            nom.ToLower(); //met en minuscule "fred"
            nom.ToUpper(); // majuscule "FRED"

            string entree = "   380 rue jean paul            ";
            Console.WriteLine(entree.Trim()); //enleve les espaces au début et a la fin

            //on peut mettre en chaine les opérations
            string prenom = " fREd  ";
            //" fREd  " --> upper --> " FRED  " ---> trim --- > "FRED"
            Console.WriteLine(prenom.ToUpper().Trim());

            //obtenir des chars d'une string:
            // string = tableau chars ['f', 'r', 'e', 'd']
            string nomPrenom = "Labelle,Frederic";

            string justeNom = nomPrenom.Substring(0, 7);
            string justePrenom = nomPrenom.Substring(8, 8);
            Console.WriteLine(justeNom);
            Console.WriteLine(justePrenom);

            //bonne facons:
            int indexVirgule = nomPrenom.IndexOf(","); //renvoie la position de la virgule (un nombre)
            Console.WriteLine(indexVirgule);

            justeNom = nomPrenom.Substring(0, indexVirgule);
            justePrenom = nomPrenom.Substring(indexVirgule + 1, nomPrenom.Length - indexVirgule - 1);

            Console.WriteLine(justeNom);
            Console.WriteLine(justePrenom);

            //Random
            Random random = new Random();

            int entierAléatoire = random.Next(20, 30); //[20, 30[
            double doubleAléatoire = random.NextDouble(); //[0, 1[
        }
    }
}
