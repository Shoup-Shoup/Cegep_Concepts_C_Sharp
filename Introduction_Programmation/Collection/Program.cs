using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Je veux faire une application pour jouer au poker
            //Garder en mémoir le montant de chaque joueur

            double montantJoueur1 = 100;
            double montantJoueur2 = 100;
            double montantJoueur3 = 100;
            double montantJoueur4 = 100;
            //Difficile à suivre

            //boucles impossibles
            for (int i = 1; i <= 4; i++)
            {
                //montantJoueur1{i} += 5; --> pas une syntaxe valide
            }

            const int NOMBRE_JOUEURS = 4;

            //Créons un tableau
            //type[] nomDesElements = new type[nombreElements];
            double[] montantJoueursV1 = new double[NOMBRE_JOUEURS]; //CONSTANTES!
            string[] nomJoueursV1 = new string[NOMBRE_JOUEURS];

            //initialise des valeurs
            double[] montantJoueursV2 = new double[NOMBRE_JOUEURS] { 100, 70, 66, 104.5 }; //CONSTANTES
            string[] nomJoueursV2 = new string[NOMBRE_JOUEURS] { "Fred", "Alex", "Bob", "Alice" };

            //En mémoir: équivalent à déclarer 4 variables continues (côte à côte en mémoire)
            //Accéder aux valeurs: [index/indice], débute à 0
            //ex: montantJoueurs [0] vaut 100 ---> et donc le dernier élément est à l'indice... taille -1
            //Crash si dépasse "out of range" montantJoueurs [10000], montantJoueurs [NOMBRE_Joueur]

            //Itérer dns le tableau, reprenons le for:
            for (int i = 1; i < NOMBRE_JOUEURS; i++)
            {
                montantJoueursV2[i] += 5;
                Console.WriteLine(montantJoueursV2[i]);
                Console.WriteLine(i);
            }

            const int NOMBRE_ELEVES = 3;

            //initialiser / défaut (souvent 0 ou "")
            int[] noteEleves = new int[NOMBRE_ELEVES] { 0, 0, 0 };

            //modifier valeurs
            for (int i = 0; i < NOMBRE_ELEVES; i++)
            {
                noteEleves[i] = 60;
            }

            //Trouver une valeur
            string nomRecherche = "Fred";
            for (int i = 0; i < NOMBRE_JOUEURS; i++)
            {
                if (nomJoueursV2[i] == nomRecherche)
                {
                    Console.WriteLine($"J'ai trouvé {nomRecherche} à l'indice {i}");
                }
            }


            //Tests (they are called arrays in english btw): it can store multiple variables

            //three ways of declaring the arrays for some reason?
            string[] nomAmis = { "Félix", "Éli", "Maddie" };

            string[] cars = new string[3];
            cars[0] = "Tesla";
            cars[1] = "Subaru";
            cars[2] = "Toyota";

            //preferred methode by the teacher?
            string[] nomFamille = new string[5] { "Mélanie", "Pacal", "Cassie", "JC", "Mari" };



            Console.WriteLine(nomFamille);//ca ne va pas montrer tous ce qui est dans le tableau

            //Facons 1 de montrer les variables
            Console.WriteLine(nomFamille[0]); //always starts at 0

            //Facons 2 de montrer les variables
            for (int i = 0; i < nomFamille.Length; i++)
            {
                Console.WriteLine(nomFamille[i]);
            }

            //To change de variable
            nomFamille[4] = "Marilou";

            Console.WriteLine(nomFamille[4]);



            //List
            string[] nomJoueurs = new string[4] { "Fred", "Bob", "Alice", "Carlos" };
            //nomJoueurs[4] = "Nouveau nom"; ---> Out of range (OOR)
            //nomJoueurs.Add("Nouveau nom"); ---> existe pas
            //Les tableaux ont une taille FIX

            //Solution: liste
            //Liste<type> nomListeAvecUnS = new List<type>(); (ctrl + d ---> copier coller la ligne en dessous)
            //Liste<type> nomListeAvecUnS = new List<type>() {valeur1, valeur2, ...}
            List<string> nomDesJoueurs = new List<string>();
            List<double> montantJoueurs = new List<double>() { 100, 100, 100, 100 };

            //show something from the list
            Console.WriteLine(montantJoueurs[0]);

            //suppression
            montantJoueurs.RemoveAt(0); // (la position de l'index)
            nomDesJoueurs.Remove("Bob"); // supprime la première occurence de Bob, (élément à enlever) selon le type ("Fred"), (1), (true)
            nomDesJoueurs.Clear(); //enlève tout, conserve la taille en mémoire

            //Ajout
            nomDesJoueurs.Add("nouveau joueur"); //type est important
            nomDesJoueurs.Insert(1, "nom 2");
            //Mémoire: tableau, si plein, sa taille x2        

            Console.WriteLine("---------");
            //count the size of the list
            Console.WriteLine(nomDesJoueurs.Count());

            //find the placement of an element
            Console.WriteLine(nomDesJoueurs.IndexOf("nom 2"));
            Console.WriteLine(montantJoueurs.LastIndexOf(100));

            Console.WriteLine(montantJoueurs.Contains(100));

            nomDesJoueurs.Sort(); //sort in alphabetic order
            nomDesJoueurs.Reverse();//sort in reverse order


            //iteration
            List<string> matieres = new List<string>() { "intro prog", "physique", "philo", "stats" };

            for (int i = 0; i < matieres.Count; i++)
            {
                string nom = matieres[i];
                Console.WriteLine($"Matière {i}: {nom}");

            }

            //Tableau 2D
            //Problème: représenter données à 2 dimensions
            //Ex: jeux échec, connect 4
            //plusieurs données par joueurs: 4 joueurs de bowling ont 10 manches chacun...
            //type[,] nomDeuxDimensions = new type[¸tailleDimension1, tailleDimension2];
            const int NOMBRE_LIGNE = 3;
            const int NOMBRE_COLONNE = 3;
            int[,] ticTacToeValeurs = new int[NOMBRE_LIGNE, NOMBRE_COLONNE] {
                { 0,1,0 },
                { 2,1,0 },
                { 2,1,0 }
            };

            //itération
            for (int ligne = 0; ligne < NOMBRE_LIGNE; ligne++)
            {
                for (int colonne = 0; colonne < NOMBRE_COLONNE; colonne++)
                {
                    Console.Write($"{ticTacToeValeurs[ligne, colonne]} ");
                }
                Console.WriteLine();
            }

            //Modifier
            ticTacToeValeurs[0, 0] = 2;

            //Tableau 1D et 2D = taille prédéfinie
            //      On choisit la dimension selon la représantation (jeu 2D, matrice)


            //List: structure la plus utilisée (90% du temps) et versatile, taille flexible

            string test = nomDesJoueurs[0];
            nomDesJoueurs[0] = "nom !";

            //Exemple
            List<string> nomEtudiants = new List<string>() { "fred", "Alain" };

            //ajoutons des notes:
            List<double> noteEtudiants = new List<double>();

            for (int i = 0; i < nomEtudiants.Count; i++)
            {
                Console.Write($"{i} - Veuillez entrer la note pour {nomEtudiants[i]}: ");
                double note = double.Parse(Console.ReadLine());
                noteEtudiants.Add(note);
            }

            //afficher les étudiants et leur note
            //Je peux itérer sur 2 listes dans le meme for, mais attention a ce que leur TAILLE soit identique!
            for (int i = 0; i < nomEtudiants.Count; i++)
            {
                Console.WriteLine($"{nomEtudiants[i]} a obtenu {noteEtudiants[i]} %");
            }
        }
    }
}
