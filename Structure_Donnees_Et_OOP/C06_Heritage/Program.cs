namespace C06_Heritage
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
             * Exemple 1: different sorts of vehicules
             */

            Console.WriteLine("----------------Vehicules----------------");
            Console.WriteLine();

            Ex1_Car car  = new Ex1_Car();
            Ex1_Bicycle bicycle = new Ex1_Bicycle();
            Ex1_Boat boat = new Ex1_Boat();

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
             * Exemple 2: Compte Bancaire
             */

            Console.WriteLine("-----------------Compte Bancaire-----------------");

            Ex2_CompteBancaire compte1 = new Ex2_CompteBancaire();
            compte1.Nom = "Lol";
            compte1.Prenom = "Vrm";
            compte1.Numero = "123";
            compte1.AfficherInfoCompte();

            var compteEpargne = new Ex2_CompteEpargne(); //var pour ne pas déclarer de type en particulier si on ne le connais pas
            compteEpargne.Nom = "Pineault";
            compteEpargne.Prenom = "Louise";
            compteEpargne.Numero = "5678";
            compteEpargne.TauxEpargne = 2.3;
            compteEpargne.AfficherInfoCompte();
            compteEpargne.AfficherCompteEpargne();

            /*
             * Exemple 3: Constructeur et héritage
             */

            Console.WriteLine("--------------------------Compte Bancaire (constructeur)--------------------------");

            Ex3_CompteEpargne_ConstructeurBase epargne1 = new Ex3_CompteEpargne_ConstructeurBase(2.4, "mari", "gau");
            epargne1.AfficherInfo();

            Ex3_CompteBancaire_ConstructeurBase compte2 = epargne1;


        }
    }
}
    
    

