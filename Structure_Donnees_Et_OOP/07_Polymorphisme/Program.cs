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

            Console.WriteLine("---------------------Race---------------------");

            Ex1_Car car = new Ex1_Car(); //car identifies as an Object, a Car and a Vehicule
            Ex1_Bicycle bicycle = new Ex1_Bicycle();//bicycle identifies as an Object, a Bicycle and a Vehicule
            Ex1_Boat boat = new Ex1_Boat();//boat identifies as an Object, a Boat and a Vehicule

            //cant put a bicycle and a boat in the car class
            //Ex1_Car[] vehicules = { car, bicycle, boat };

            //so we find what all three objects have in common:
            Ex1_Vehicule[] vehicules = { car, bicycle, boat };


            /* Part 2: Methods */

            //al the objects in the array will use their go methods at the same time
            foreach (Ex1_Vehicule vehicule in vehicules)
            {
                vehicule.Go();
            }

            /*
             * Exemple 2: Classe interface
             */

            Ex2_Rabbit rabbit = new Ex2_Rabbit();
            rabbit.Flee();

            Ex2_Tiger tiger = new Ex2_Tiger();
            tiger.Hunt();

            Ex2_Fish fish = new Ex2_Fish();
            fish.Flee();
            fish.Hunt();
           
        }
    }
}

