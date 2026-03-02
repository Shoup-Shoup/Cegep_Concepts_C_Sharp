namespace C04_Constructeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Constructeur:
             *      Un constructeur est un type de méthode particulier qu'on retrouve dans une classe
             *      Ils ont le même nom que la classe et n'ont pas de type donc ne retourne rien
             *      Il est appelé au moment ou on instancie un objet et il permet d'initialiser l'objet et de reservé de 
             *          l'espace mémoir pour l'objet
             *      Si on ne créer pas de constructeur, le compilateur va faire appel au constructeur par défaut, mais les données
             *          ne seront pas initialisé
             *      Les variables qui seront mis dans le constructeur ce sont les variable que nous devront écrir en paramètre quand 
             *      on va créer l'objet. Toutes les autres variable devront être instancier manuellement
             */


            /*
             * Exemple 1: Humain
             */

            Console.WriteLine("-------------Human-------------");
            Console.WriteLine();

            //Au lieu d'instancier chaque variable individuellement, on peut maintenant juste les passer en paramètres de l'objet grace au constructeur
            Ex1_Humain human1 = new Ex1_Humain("Morty", 14, "123 Street");

            human1.Living();
            human1.Aging();
            human1.Doxxing();

            Console.WriteLine();


            /*
             * Exemple 2: Étudiant
             */

            Console.WriteLine("-------------------Étudiant-------------------");
            Console.WriteLine();

            string nom;
            Console.Write("Entrez votre nom: ");
            nom = Console.ReadLine();

            string prenom;
            Console.Write("Entrez votre prenom: ");
            prenom = Console.ReadLine();

            string departement;
            Console.Write("Entrez votre département: ");
            departement = Console.ReadLine();

            int age;
            Console.Write("Entrez votre age: ");
            age = int.Parse(Console.ReadLine());


            //instanciation d'un objet de type Étudiant (déclaration d'une variable de type étudiant)
            Ex2_Etudiant eleve01 = new Ex2_Etudiant("Jean", "Paul", "Mécanique", 20); //appel du constructur pour initialiser les attributs de la classe

            // appel de la méthode pour afficher un étudiant
            eleve01.AfficherInfo();
        }
    }
}
