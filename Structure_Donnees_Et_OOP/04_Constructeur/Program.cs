namespace _04_Constructeur
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
             * Concept 1: Constructeur Paramétré: Humain
             */

            Console.WriteLine("-------------Human-------------");
            Console.WriteLine();

            //Au lieu d'instancier chaque variable individuellement, on peut maintenant juste les passer en paramètres de l'objet grace au constructeur
            C1_Humain_Parametree human1 = new C1_Humain_Parametree("Morty", 14, "123 Street");

            human1.Living();
            human1.Aging();
            human1.Doxxing();

            Console.WriteLine();

            /*
             * Concept 2: Overloaded constructors: 
             */

            C2_Pizza_Overload pizza1 = new C2_Pizza_Overload("stuffed crust", "red sauce", "mozzarella", "pepperoni");

            //creating a pizza without toppings
            C2_Pizza_Overload pizza2 = new C2_Pizza_Overload("stuffed crust", "red sauce", "mozzarella");

            //creating a pizza without toppings and cheese
            C2_Pizza_Overload pizza3 = new C2_Pizza_Overload("stuffed crust", "red sauce");
        }
    }
}
