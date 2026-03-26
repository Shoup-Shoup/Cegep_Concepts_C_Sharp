namespace _02_Methode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Methodes (ou fonctions): *se référer au projet "Fonctions" de la solution "Introduction_Programmation" pour de l'information sur le concepte de base de la méthode
             *      Dans le context de la programation orienté objet, une méthode est un bloc de code qui permet d'exécuté 
             *          une seule action dans une classe. 
             *      Par exemple, si on a une classe appelé "Voiture", la méthode "Démarrer" permettrait de démarer la voiture.
             *          On appelerait donc cette méthode une instance de la classe "Voiture"
             *      Il existe plusieur qualificateur de méthodes qui détermine qui peut l'appeler et y accéder, donc son niveau d'accès:  
             *                  public =
             *                  private =
             *                  protected =
             *                  static = meaning the method belongs to the class and not the object
             *                  abstract = une méthode abstraite ne doit rien contenir, doit faire partie d'une classe abstract et 
             *                      doit être redéfinie dans la classe dérivée (avec override)
             *                  virtual = une méthode virtual autorise la redéfinition par une methode override de la classe dérivée,
             *                      mais ce n'est pas obligatoire
             *                  override = 
             */


            /*
             * Exemple 1: Method overload: On veut parfois multiplier trois nombres ensemble et parfois deux nombres
             */

            Console.WriteLine("--------------Multiplication de deux nombres--------------");
            Console.WriteLine();

            Ex1_Multiplying_Overload calcul1 = new Ex1_Multiplying_Overload();

            double somme1 = calcul1.Multiply(3, 2);

            Console.WriteLine(somme1);

            Console.WriteLine();
            Console.WriteLine("--------------Multiplication de trois nombres--------------");
            Console.WriteLine();

            double somme2 = calcul1.Multiply(2, 4, 3);

            Console.WriteLine(somme2);


            /*
             * Exemple 2: Static modifier: we dont want each car to be able to start the race on their own individually 
             */

            Console.WriteLine();
            Console.WriteLine("----------------------Chose a car to race with----------------------");
            Console.WriteLine();

            Ex2_Car_StaticModifier car1 = new Ex2_Car_StaticModifier("Mustang");
            Ex2_Car_StaticModifier car2 = new Ex2_Car_StaticModifier("Corvette");
            Ex2_Car_StaticModifier car3 = new Ex2_Car_StaticModifier("Lambo");

            Ex2_Car_StaticModifier.StartRace();//so its kind of like instead of calling each object individually to invoke the method to start the race, you invoke the method using the entire class, meaning all the cars at once

            /*
             * Exemple 3: Methode ToString
             */

            Console.WriteLine();
            Console.WriteLine("----------------------My car----------------------");
            Console.WriteLine();

            Ex3_Car_ToString car = new Ex3_Car_ToString("Chevy", "Corvette", 2022, "blue");

            //if we dont override this method, the console will write: C02_Methode.Ex5_Car_ToStringMethod
            Console.WriteLine(car.ToString());

            //you could also just type the name of the object and it will do the same thing
            Console.WriteLine(car);


        }        
    }
}
