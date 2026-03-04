namespace _07_Polymorphisme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Polymorphism: 
             *      Greek word that means: to have many forms
             *      Permet a une méthode d'avoir des comportements différents selon l'objet qui l'utilise
             *      Objects can be identified by more than one type
             */


            /*
             * Exemple 1:  We have a race with 3 different vehicules
             */

            /* Part 1: objects can identify as multiple things: */

            Ex1_Car car = new Ex1_Car();
            Ex1_Bicycle bicycle = new Ex1_Bicycle();
            Ex1_Boat boat = new Ex1_Boat();

            //cant put a bicycle and a boat in the car class
            //Ex1_Car[] vehicules = { car, bicycle, boat };

            //so we find what all three objects have in common:
            Ex1_Vehicule[] vehicules = { car, bicycle, boat };

            /* Part 2: Methods */

        }
    }
}

