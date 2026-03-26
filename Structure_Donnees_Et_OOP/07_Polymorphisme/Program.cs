using _02_Methode;

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
             * Exemple 2: méthode virtual et override
             */

            Console.WriteLine();
            Console.WriteLine("----------------------Animals making sounds----------------------");
            Console.WriteLine();

            Ex2_Dog dog = new Ex2_Dog();          
            Ex2_Cat_Override cat = new Ex2_Cat_Override();

            dog.Speak(); //Me: "cat, invoke your speak method please", Cat goes: "meow"
            cat.Speak();

            /*
             * Exemple 3: Classe interface
             */

            Ex3_Rabbit rabbit = new Ex3_Rabbit();
            rabbit.Flee();

            Ex3_Tiger tiger = new Ex3_Tiger();
            tiger.Hunt();

            Ex3_Fish fish = new Ex3_Fish();
            fish.Flee();
            fish.Hunt();
           
        }
    }
}

