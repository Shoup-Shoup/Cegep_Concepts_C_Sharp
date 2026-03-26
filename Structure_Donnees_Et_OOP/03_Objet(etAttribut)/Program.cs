using C03_Objet_etAttribut_;

namespace _03_Objet_etAttribut_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Objets:
             *      Un objet est un instance d'une classe
             *      L'objet est quelque chose de réel en mémoire
             *      Exemple: the blueprint of a house would be a class and an actual built house would be an object
             *      Un objet possède ses propres valeurs de variable et il peut utiliser les méthode de la class
             *      Les objets utilise des attributs (ce qu'un objet a) et des méthodes (ce qu'un objet peut faire)
             */


            /*
             * Exemple 1: Attributs: Créer un objet simple et l'afficher
             */

            Console.WriteLine();
            Console.WriteLine("---------------------Humain---------------------");
            Console.WriteLine();

            //Ici on va utilisé la class Ex1_Human comme si c'était un type de variable pour ensuite creér la variable humain1. On appel ca une instance de la classe puisqu'on instancie un objet du type de la classe
            Ex1_Human_Attributs human1 = new Ex1_Human_Attributs();

            //Ici on accède aux attributs déjà déclaré dans la class et on instancie la variable en lui attribuant une valeur en écrivant: nom
            human1.name = "Rick";
            human1.age = 70;

            //Ici on va chercher les méthode de la classe pour que humain1 puisse les faires
            human1.Eat();
            human1.Sleep();


            //Comme on a créer une classe à part, on peut ensuite créer autant d'objet qu'on le désir
            Ex1_Human_Attributs human2 = new Ex1_Human_Attributs();

            human2.name = "Morty";
            human2.age = 14;

            human2.Eat();
            human2.Sleep();

            /*
             * Exemple 2: Attribut et static modifier: If we have a race and want to keep track of the amount of cars in the race 
             */

            Console.WriteLine();
            Console.WriteLine("-----------------Number of cars without using keyword static-----------------");
            Console.WriteLine();

            Ex2_Car_AttributStatic car1 = new Ex2_Car_AttributStatic("Mustang");
            Ex2_Car_AttributStatic car2 = new Ex2_Car_AttributStatic("Corvette");
            Ex2_Car_AttributStatic car3 = new Ex2_Car_AttributStatic("Lambo");

            Console.WriteLine("Number of cars after adding car 1: " + car1.Ex1_numberOfCars);
            Console.WriteLine("Number of cars after adding car 2: " + car2.Ex1_numberOfCars); //the number of cars will stay one


            Console.WriteLine();
            Console.WriteLine("-----------------Number of cars with keyword static-----------------");
            Console.WriteLine();

            Console.WriteLine("Number of cars total: " + Ex2_Car_AttributStatic.Ex2_numberOfCars);//must type the name of the class instead of the field to access a static field

            /*
             * Exemple 3: Array of objects
             */

            Console.WriteLine();
            Console.WriteLine("-----------------Cars parked in a garage long way to display-----------------");
            Console.WriteLine();

            Ex3_Car[] garage1 = new Ex3_Car[3];

            Ex3_Car car4 = new Ex3_Car("Mustang");
            Ex3_Car car5 = new Ex3_Car("Corvette");
            Ex3_Car car6 = new Ex3_Car("Lambo");

            garage1[0] = car4;
            garage1[1] = car5;
            garage1[2] = car6;

            Console.WriteLine(garage1[0]); //Console: C03_Objet_etAttribut_.Ex3_Car
            Console.WriteLine(garage1[0].model); //va donner le model a la console
            Console.WriteLine(garage1[1].model);
            Console.WriteLine(garage1[2].model);


            Console.WriteLine();
            Console.WriteLine("-----------------Cars parked in a garage short way to display-----------------");
            Console.WriteLine();

            Ex3_Car[] garage2 = { new Ex3_Car("Mustang"), new Ex3_Car("Corvette"), new Ex3_Car("Lambo") };

            foreach (Ex3_Car car in garage2)
            {
                Console.WriteLine(car);
            }


            /*
             * Exemple 4: List of objects
             */


            /*
             * Exemple 5: Objects as arguments
             */

            Ex5_Car car7 = new Ex5_Car("Mustang", "red");            
            ChangeColor(car7, "silver");
            Console.WriteLine("car 1: " + car7.color + " " + car7.model);

            Ex5_Car car8 = Copy(car7);
            Console.WriteLine("copy of car 1: " + car8.color + " " + car8.model);

        }
        

        /*
         * Exemple 5: Objects as arguments
         */

        //Method to change color
        public static void ChangeColor(Ex5_Car car, string color)
        {
            //car.color takes the field of the car class
            car.color = color;
        }

        //Method to copy a car
        public static Ex5_Car Copy(Ex5_Car car)
        {
            return new Ex5_Car(car.model, car.color); //using the model and color of the car passed in argument(paramètre)
        }
    }
}
