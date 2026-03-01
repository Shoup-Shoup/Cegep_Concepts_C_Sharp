namespace C05_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Encapsulation:
             *      Permet de protéger les données internes de l'objet en les rendant innaccessible depuis l'extérieur de l'objet
             *      Exemple: car speed is originally set at 400 when we create the object but anyone could change it to 10000000 
             *          because the field is public. We could change the field from public to private but then the entire field would
             *          be locked which can also be a problem so we use encapsulation instead
             */

            
            /*
             * Exemple 1: Propriétés classic
             */

            Console.WriteLine("----------------Car----------------");
            Console.WriteLine();

            //Create an object
            Ex1_Car_Properties car = new Ex1_Car_Properties(400);

            //I we try: car.speed = 1000000000; ---> it wont work because the attribute is now private, so you have to get the property instead
            car.Speed = 1000000000;

            //Since we try to put a speed over the limit, it will default back to 500
            Console.WriteLine("Car's speed: " + car.Speed);

            Console.WriteLine();

            /*
             * Exemple 2: Propriétés auto-implémenté
             */

            Console.WriteLine("-------------Animal-------------");
            Console.WriteLine();

            Ex2_Animal_AutoImplemented animal1 = new Ex2_Animal_AutoImplemented("Chien");

            Console.WriteLine("type d'animal: " + animal1.Type);

            Console.WriteLine();


            /*
             * Exemple 3: getters et setters coder sur des lignes à part
             */

            Console.WriteLine("---------------------Personne---------------------");
            Console.WriteLine();

            Ex3_Personne personne_01 = new Ex3_Personne();//fait appel au constructeur par defaut

            //Affection des données
            personne_01.SetNom("LeBlanc");
            personne_01.SetPrenom("Paul");


            //Récuperer le nom et le prenom
            var nom = personne_01.GetNom(); //récupérer le nom
            var prenom = personne_01.GetPrenom();

            Console.WriteLine("\t Nom:" + nom);
            Console.WriteLine("\t Prenom:" + prenom);

            Console.WriteLine();

            /*
             * Exemple 4: propriétés auto implémenté et classe DateTime
             */

            Console.WriteLine("------------Employe et son Age------------");
            Console.WriteLine();

            DateTime Datenaissance1 = new DateTime(1980, 10, 20);
            Ex4_Employe_DateTime employe01 = new Ex4_Employe_DateTime(Datenaissance1);
            employe01.Nom = "Laure";
            employe01.Prenom = "Leblanc";

            //afficher les informations
            employe01.AfficherInformation();


            DateTime Datenaissance2 = new DateTime(1997, 10, 20);
            Ex4_Employe_DateTime employe02 = new Ex4_Employe_DateTime(Datenaissance2);
            employe01.Nom = "Maude";
            employe01.Prenom = "Lafleur";

            //afficher les informations
            employe02.AfficherInformation();


        }
    }
}
