namespace _05_Encapsulation
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
             * Concept 1: Propriétés écriture moderne
             */

            Console.WriteLine();
            Console.WriteLine("----------------Car----------------");
            Console.WriteLine();

            //Create an object
            C1_Car_Properties car = new C1_Car_Properties(400);

            //I we try: car.speed = 1000000000; ---> it wont work because the attribute is now private, so you have to get the property instead
            car.Speed = 1000000000;

            //Since we try to put a speed over the limit, it will default back to 500
            Console.WriteLine("Car's speed: " + car.Speed);

            /*
             * Concept 2: Propriétés auto-implémenté
             */

            Console.WriteLine();
            Console.WriteLine("-------------Animal-------------");
            Console.WriteLine();

            C2_Animal_AutoImplemented animal1 = new C2_Animal_AutoImplemented("Chien");

            Console.WriteLine("type d'animal: " + animal1.Type);

            /*
             * Concept 3: getters et setters avec écriture manuelle
             */

            Console.WriteLine();
            Console.WriteLine("---------------------Personne---------------------");
            Console.WriteLine();

            C3_Personne_Manuelle personne_01 = new C3_Personne_Manuelle();//fait appel au constructeur par defaut

            //Affection des données
            personne_01.SetNom("LeBlanc");
            personne_01.SetPrenom("Paul");


            //Récuperer le nom et le prenom
            var nom = personne_01.GetNom(); //récupérer le nom
            var prenom = personne_01.GetPrenom();

            Console.WriteLine("\t Nom:" + nom);
            Console.WriteLine("\t Prenom:" + prenom);

            Console.WriteLine();

        }
    }
}
