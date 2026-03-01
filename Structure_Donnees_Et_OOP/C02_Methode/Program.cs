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
             *                  virtual = 
             *                  override = 
             */


            /* La surcharge de méthode:
             *      Ce sont des méthodes qui partage le même nom, mais qui ont des paramètres différents ce qui les différencie
             *          et les rend unique. Le nom de la méthode plus ces paramètres est ce qu'on appel la signature de la méthode
             */


            /*
             * Exemple 1: On veut parfois multiplier trois nombres ensemble et parfois deux nombres
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
             * Exemple 2: Additionner différents nombres avec une classe
             */

            Console.WriteLine("----------------------Addition de nombres----------------------");

            Ex2_Addition_Overload calcul1 = new Ex2_Addition_Overload(); //Appel du constructeur par défaut

            //Appel de la méthode pour additionner deux parametres
            Console.WriteLine($"voici le résultat {calcul1.Additionner(7, 8)}");
            Console.WriteLine($"voici le résultat {calcul1.Additionner(7, 8, 9)}");
            Console.WriteLine($"voici le résultat {calcul1.Additionner(7.5f, 8.1f)}");

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
