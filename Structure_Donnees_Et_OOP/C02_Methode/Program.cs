namespace C02_Methode
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
             *                  abstract = 
             *                  static = meaning the method belongs to the class and not the object
             *                  virtual = 
             *                  override = 
             */


            /* La surcharge de méthode:
             *      Ce sont des méthodes qui partage le même nom, mais qui ont des paramètres différents ce qui les différencie
             *          et les rend unique. Le nom de la méthode plus ces paramètres est ce qu'on appel la signature de la méthode
             */


            /*
             * Exemple 1: Method overload: On veut parfois multiplier trois nombres ensemble et parfois deux nombres
             */

            Console.WriteLine("--------------Multiplication de deux nombres--------------");
            Console.WriteLine();

            double somme1 = Multiply(3, 2);

            Console.WriteLine(somme1);
            Console.WriteLine();

            Console.WriteLine("--------------Multiplication de trois nombres--------------");
            Console.WriteLine();

            double somme2 = Multiply(2, 4, 3);

            Console.WriteLine();


            /*
             * Exemple 2: Method overload: Additionner différents nombres avec une classe
             */

            Console.WriteLine("----------------------Addition de nombres----------------------");

            Ex2_Addition_Overload calcul1 = new Ex2_Addition_Overload(); //Appel du constructeur par défaut

            //Appel de la méthode pour additionner deux parametres
            Console.WriteLine($"voici le résultat {calcul1.Additionner(7, 8)}");
            Console.WriteLine($"voici le résultat {calcul1.Additionner(7, 8, 9)}");
            Console.WriteLine($"voici le résultat {calcul1.Additionner(7.5f, 8.1f)}");

            /*
             * Exemple 3: Static modifier: we dont want each car to be able to start the race on their own individually 
             */

            /* Qualificateur static (pour une méthode ou un attribut):
             *      Le membre qualifié de static appartiendra à la classe elle même et non à l'objet
             *      Sans le keyword static, la méthode ou l'attribut appartient à chaque objet
             */

            Ex3_Car_StaticModifier car1 = new Ex3_Car_StaticModifier("Mustang");
            Ex3_Car_StaticModifier car2 = new Ex3_Car_StaticModifier("Corvette");
            Ex3_Car_StaticModifier car3 = new Ex3_Car_StaticModifier("Lambo");

            Ex3_Car_StaticModifier.StartRace();//so its kind of like instead of calling each object individually to invoke the method to start the race, you invoke the method using the entire class, meaning all the cars at once

        }

        /*
         * Exemple 1: Method overload
         */

        //Multiply 2 nombres
        static double Multiply(double a, double b)
        {
            return a * b;
        }

        //Mutiply 3 nombres
        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
