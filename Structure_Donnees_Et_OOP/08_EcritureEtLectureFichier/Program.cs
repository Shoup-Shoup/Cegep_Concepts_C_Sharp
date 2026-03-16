namespace _08_EcritureEtLectureFichier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Classe StreamReader:
             *      Permet de lire des données ligne par ligne ou caractère par caractère dans un fichier
             *      
             * Classe StreamWriter:
             *      Permet d'écrir des données dans un fichier, soit en créant un nouveau fichier, soit en écrasant
             *          un fichier existant.
             * 
             */


            /*
             * Exemple 1: StreamReader
             */

            Console.WriteLine();
            Console.WriteLine("-------------------------StreamReader-------------------------");
            Console.WriteLine();

            StreamReader reader = new StreamReader("Donnees.csv"); //sert a lire un fichier déjà existant

            string? line = reader.ReadLine(); //this line mean it is reading the first line of the file, we can add a ? to say that the file might be null

            while (line != null) //check if the line is empty
            {
                Console.WriteLine(line);//if it isnt empty, print the line on the console

                line = reader.ReadLine();//then the variable line will contain the read of the next line
            }

            reader.Close(); //very important to close de file once it's done reading


            /*
             * Exemple 2: Facons plus simple de faire streamReader
             */

            Console.WriteLine();
            Console.WriteLine("-------------------------StreamReader Façons Simplifié-------------------------");
            Console.WriteLine();

            using (StreamReader file = new StreamReader("Donnees.csv")) //open and closes without extra steps
            {
                string ligne1;

                while ((ligne1 = file.ReadLine()) != null)
                {
                    Console.WriteLine(ligne1);
                }
            }


            /*
             * Exemple 3: StreamWriter
             */

            StreamWriter writer = new StreamWriter("MyName.csv"); //if the file doesnt exist, the streamwriter class wil create one for us

            char[] letters = { 'M', 'A', 'R', 'I', 'L', 'O', 'U' };

            foreach (char letter in letters)
            {
                writer.WriteLine(letter);
            }

            writer.Close();


            /*
             * Exemple 4: Séparer et réutiliser les données d'un fichier avec des listes
             */

            List<double> temps = new List<double>(); //on va pouvoir mettre les données dans des listes
            List<double> hauteurs = new List<double>();


            //Lire le fichier
            StreamReader fichier = new StreamReader("Donnees.csv"); //Ouverture du fichier en lecture

            string ligne2; //déclare une chaine de caractères

            fichier.ReadLine(); //saute la première ligne du fichier

            while ((ligne2 = fichier.ReadLine()) != null)//extraction d'une ligne et vérifie si elle est vide
            {            
                string[] donnees = ligne2.Split(';'); //coupe la ligne au moment ou il y a le ; pour créer des données séparé
                temps.Add(double.Parse(donnees[0]));
                hauteurs.Add(double.Parse(donnees[1]));
            }


            //Écrir dans le fichier
            StreamWriter fichierSorti = new StreamWriter("Resultat.csv");

            //Première ligne du fichier
            fichierSorti.WriteLine("temps (s); hauteur (m)");

            for (int i = 0; i < temps.Count; i++)
            {
                fichierSorti.WriteLine($"{temps[i]};{hauteurs[i]}");
            }

            fichierSorti.Close(); //important pour enregistrer


            Console.WriteLine("Résultats enregistrés dans le fichier Resultat.csv");


            /*
             * Exemple 5: Charger un fichier en mémoir avec un tableau en deux dimensions
             */

            Console.WriteLine();
            Console.WriteLine("-------------------------Matrice-------------------------");
            Console.WriteLine();

            //Charger le tableau
            string nomFichier = "Donnees.csv";
            double[,] valeurs;

            string[] lignes = File.ReadAllLines(nomFichier); //Extrait toutes les lignes du fichier et sauvegarde dans un vecteur
            int nombreLignes = lignes.Length; //donne le nombre de ligne

            int nombreColonne = lignes[0].Split(';').Length; //lignes[0].Split(';') donne un vecteur et length nous donne la taille du vecteur

            //allocation mémoire pour le tableau
            valeurs = new double[nombreLignes, nombreColonne];

            //Remplissage du Tableau a partir du fichier

            for (int i = 0; i < nombreLignes; i++)
            {
                string[] element = lignes[i].Split(";"); //Construit un vecteur de string
                for (int j = 0; j < nombreColonne; j++)
                {
                    valeurs[i, j] = double.Parse(element[j]);
                }
            }

            //Afficher le tableau sur la console
            int taille = valeurs.GetLength(0); //GetLength(0): retourne le nombre de ligne d'un tableau a deux dimentsion, GetLength(1); retourne colonne

            for (int i = 0; i < taille; i++)
            {
                for (int j = 0; j < taille; j++)
                {
                    Console.Write(valeurs[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
