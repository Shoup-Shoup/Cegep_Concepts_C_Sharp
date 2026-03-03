namespace _01_Classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Classes: 
             *      Dans le context de la programmation orienté objet, un classe est l'équivalent d'un type de variable,
             *          mais qui est crée par l'utilisateur et qui est utilisé par des objets (a blueprint to create an object)
             *      Pour créer une classe personalisé il faut sortir de la classe Program.cs et ajouté une nouvelle classe a 
             *          notre projet: Right click selected project --> select Add --> select Class... --> Change the name of the class 
             *          --> click the Add button
             *      On peut aussi créer une a la suite de la classe Program.cs (mais on utilise pas ca dans le cours en ce moment)
             *      Il existe plusieurs qualificateur (modifier en En) de classe:
             *                      public =
             *                      abstract = Une classe abstraite ne peut pas être instancié directement, elle va donc servir de
             *                          modèle pour d'autres classes et sera complété par la classe dérivée (héritage)
             *                      static = you wouldn't be able to create an object from a static class
             *                               For exemple: the math class
             *                                      To round a number you would not write:   Math math1 = new Math(); //creating an instance of the math class
             *                                                                               math1.Round(3.1416) //calling the round method of the math class through the math1 object
             *                                  
             *                                      Instead you would just write:            Math.Round(3.1416) //Call the method through the class itself
             */


            /*
             * Exemple 1 et 2: Récupérer les méthodes de la classe (on va utiliser l'exemple 2)
             */

            Console.WriteLine("--------------------Afficher des Messages de base--------------------");
            Console.WriteLine();

            //on écrit: nomDeLaClasse.Methode(paramètres);
            Ex2_Messages.Hello();
            Ex2_Messages.Waiting();
            Ex2_Messages.Bye();

            /*
             * Exemple 3: Utiliser la clase comme type de variable
             */

            //On viendrait déclaré ici plusieurs animaux différents du type Animal en écrivant: nomDeLaClasse nomDeLaVariable = new nomDeLaClasse();
            Ex3_Amimal chien = new Ex3_Amimal();

            Ex3_Amimal chat = new Ex3_Amimal();

            Ex3_Amimal poisson = new Ex3_Amimal();


            /*
             * Exemple 4: Abstract Classes: We have a race and we want people to choose a vehicule
             */

            Ex4_Car_Abstract car = new Ex4_Car_Abstract();
            Ex4_Bicycle_Abstract bicycle = new Ex4_Bicycle_Abstract();
            Ex4_Boat_Abstract boat = new Ex4_Boat_Abstract();

            // Ex4_Vehicule_AbstractModifier vehicule = new Ex4_Vehicule_AbstractModifier();
            //We dont want people to be able to create a generic vehicule using this line, so we would make the vehicule class abstract (incomplete)


        }
    }

    /*
     * Exemple 1: Ecxrir la classe après la class internal class Program
     */

    static class Ex1_Messages //here we used static so we would not have to create an object to show the massages, same thing we the methods
    {
        public static void Hello()
        {
            Console.WriteLine("Hello, welcome to this programe");
        }

        public static void Waiting()
        {
            Console.WriteLine("I am waiting for something");
        }

        public static void Bye()
        {
            Console.WriteLine("Goodbye! Thanks for visiting");
        }
    }

    class Ex3_Amimal
    {
        //Ceci est seulement un exemple pour comment utiliser les class comme type, donc on va rien mettre dans la classe pour le moment
    }
}
