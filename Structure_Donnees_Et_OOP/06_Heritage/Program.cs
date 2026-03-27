namespace _06_Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Héritage (inheritence en En):
             *      Permet a une classe fille (ou classe dérivée) d'hériter des méthodes et des attributs d'une classe mère 
             *          (ou classe de base)
             *      Classe mère (base) contient:
             *          Tous les attributs communs
             *          toutes les méthodes communes
             *      Classe fille (dérivée) contient:
             *          Hérite des méthodes et attributs de la classe mère
             *          A ses propres attributs personnelles
             *          A ses propres méthodes personnelles
             */


            /*
             * Concept 1: Heritage de base:  different sorts of vehicules
             */

            Console.WriteLine("----------------Vehicules----------------");
            Console.WriteLine();

            C1_Car car  = new C1_Car();
            C1_Bicycle bicycle = new C1_Bicycle();
            C1_Boat boat = new C1_Boat();

            Console.WriteLine("car");
            //The object car can access the field speed and method go() even if its not in the car class
            Console.WriteLine(car.speed);
            Console.WriteLine(car.nbWheels);
            car.go();
            Console.WriteLine();

            Console.WriteLine("bicycle");

            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.nbWheels);
            bicycle.go();
            Console.WriteLine();

            Console.WriteLine("boat");

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.nbWheels);
            boat.go();
            Console.WriteLine();

            /*
             * Concept 2: Constructeur hérité et keyword base:
             */

            Console.WriteLine("--------------------------Compte Bancaire (constructeur)--------------------------");

            C2_CompteEpargne_ConstructeurHeritee epargne1 = new C2_CompteEpargne_ConstructeurHeritee(2.4, "mari", "gau");
            epargne1.AfficherInfo();

            C2_CompteBancaire_Constructeur compte2 = epargne1;


        }
    }
}
    
    

