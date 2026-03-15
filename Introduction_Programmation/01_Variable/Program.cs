using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Variable
{
    internal class Program
    {
        const double PI = 3.1416; // le nom des constantes est toujours en majuscules et s'il y a plus qu'un mot, on mets des barre en bas. 
        // const double NOMBRE; pas le droit de juste déclarer, il faut aussi mettre la valeur
        const int NOMBRE = 10;
        const string TECHNICIEN = "technicien";
        private const string SIGLE_COURS = "SF1";

        static void Main(string[] args)
        {
            /* Variables:
             *      Demande deux étapes: déclaration et initialisation
             * 
             */

            int sommeFortunes = 100;

            //Défénir une valeur; Type Nom;
            // Assigner: Nom = valeur;
            sommeFortunes = sommeFortunes - 15;
            // on ne peut pas défénir un variable deux fois différentes, mais on peut l'assigner plusieurs fois


            //Littéral VS variable
            double argent = 50.28; //Variable = argent, Littérale = 50.28
            double beaucoupArgent = argent + 30;


            //Priorité opérations
            double y = 10 * 2 + 5; //=25
            Console.WriteLine(y);
            Console.WriteLine(10 * (2 + 5));


            //Limitations:
            //int int = 5;    (On ne peut pas utiliser un mot réservé pour nomer une variable)


            //Nomenclature:
            //pas une lettre, pas abréviation, pas d'accent, écrir en camelCase (premier mot en miniscule et les autres mots commencent par une majuscule)



            //créer des constante (qui ne peut jamais changer)
            const double PI = 3.1416;


            //type de données/variable
            //Erreurs de conversion

            /// 2/3 en double : 0.66,  
            /// en int = 0 (enlève la décimale au complet)

            //Celcius en farenheight
            int cel = 24;
            double far = (cel * 9 / 5) + 32;
            // La console fait les math un élément a la fois de droite a gauche

            Console.WriteLine(far);

            // rajouter un.0 au 9 et 5 pour que ca fonctionne et donne des doubles
            far = (cel * 9.0 / 5) + 32;

            //ou changer le int 24 en double 24.0 pour que ca marche

            Console.WriteLine(far);



            //limite mémoire
            //int nombre = 300000; trop gros nombre pour un int
            long nombreLong = 30000000; //pour les nombre plus gros
            double nombreVirgule = 300000000.14;
            uint entierNonSigne = 40; // seulement les chiffre positif (rien avec des moins)

            Console.WriteLine("int : " + sizeof(int)); // 4 octes (bytes en anglais) (1 octet = 8 bits, 4 octets = 32 bits (32 fois 1/0))
            Console.WriteLine("long : " + sizeof(long)); // 8 octets
            Console.WriteLine("float : " + sizeof(float)); // 4 octets, décimal mais moins précis
            Console.WriteLine("double : " + sizeof(double)); // 8 octets
            Console.WriteLine("char : " + sizeof(char)); // 2 octets 'A' '1' '$', 'A' = 65d (= 00000000 01000001)
            Console.WriteLine("uint : " + sizeof(uint)); // 4 octets
                                                         // int: -2 147 483 648 a + 2 147 483 647
                                                         // uint: 0 a 4 294 967 295

            // int montant = 2147483648; (devrait faire: uint ,car plus de place, mais pas négatifs)


            /*
             * Exemple 1: basics
             */

            int x; //Déclaration
            x = 10; //Initialisation

            int y2 = 20; //initialisation et déclaration en un

            Console.WriteLine(x); //to display a simple variable
            Console.WriteLine(y);

            int z2 = x + y2; //simple math

            Console.WriteLine(z2);

            //The name of your variable must be descriptiv of what it contains
            int age = 20;

            Console.WriteLine("my age is: " + age); //first way to display variable and text
            Console.WriteLine($"my age is: {age}"); //second way to display variable and text


            /*
             * Exemple 2: types of variables
             */

            int a = -2147483648;
            uint b = 4294967295;
            float c = -999999999;
            double d = 12.34;
            long e = -9223372036854775808;
            ulong f = 18446744073709551615;

            string h = "hello";
            char i = 'i';
            bool j = true;
            bool k = false;


            Console.WriteLine("---------------------------------------------");
            // chaine de caractères (string)
            // caractères spéciaux 
            char special = '\0';
            Console.WriteLine('A' + special + 'A'); // 65 + x + 65
            Console.WriteLine("A" + special + 'A'); // \0 n'apparait pas, ca sert a terminer une chaine de caractère (plus en C++)

            char specialDeux = '\n';
            Console.WriteLine("allo" + specialDeux + "allo");//\n fait un saut de ligne (new line)
            Console.WriteLine("\n");




            //Échappement
            // si on voulais faire afficher \ ou créer un char avec ' comme valeur ?? (Console.WriteLine("\" + "'" ); = pas possible)
            Console.WriteLine("allo \\");
            char apostrophe = '\'';
            Console.WriteLine("a \\n a");





            //Casting
            // perte de décimal si on divise un entier sans décimale par un entier sans décimale
            double dd = 9 / 5;
            Console.WriteLine(dd + "test");

            // Solution 1: transformer un des deux chiffre en double avec une décimale
            double ddd = 9.0 / 5;

            //Solution 2: mettre le type de variable double entre parenthèse devant l'entier (du casting)
            double dddd = (double)9 / 5;
            Console.WriteLine(ddd + dddd);





            //Conversion de string
            // int + string OU string + int OU string + string: = toujours un string
            Console.WriteLine("test : " + 3 + 3 + 3); //il ne fera pas les maths avec les 3
            //il faut rajouter des parenthèse pour faire des maths
            Console.WriteLine("test : " + (3 + 3 + 3));
            // ou on peut faire une variable avec les maths dedans
            int calcul = 3 + 3 + 3;
            Console.WriteLine("test:" + calcul);




            //entrées sorties (pour que l'utilisateur écrive sur la console)
            Console.WriteLine("entrer un entier:");
            string entier = Console.ReadLine();
            int entierConverti = int.Parse(entier);// si pas un nombre, ca va pas fonctionner (ca va crash)
            Console.WriteLine("mon entier entré au clavier:" + entierConverti);

            Console.WriteLine("entrer un double: ");
            string Double = Console.ReadLine();
            double DoubleConverti = double.Parse(Double); //, ou . sont très important
            Console.WriteLine("mon double entré au clavier: " + DoubleConverti);




            //Formatage de string
            int age2 = 19;
            Console.WriteLine("mon age " + age + " ans");
            // pour montrer la variable dans le text sans les plus
            Console.WriteLine($"mon age: {age} ans");

            Console.WriteLine($"mon double:{DoubleConverti,41}"); // espacement avant/après (selon positif ou négatif)
            Console.WriteLine($"mon double:{DoubleConverti: 0.00}"); // format le nombre de décimal a afficher
            Console.WriteLine($"mon double: {DoubleConverti.ToString("0.###")}");//max 3 décimale seulement si il y a besoin
            Console.WriteLine($"mon double:{DoubleConverti: 0:##}"); // arrondi, mais ex: 5.2 = 5.2 et non 5.20
            Console.WriteLine($"mon double:{DoubleConverti: 00000000}"); // rempli des 0 a gauche


        }
    }
}
