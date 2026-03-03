using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Encapsulation
{
    internal class Ex4_Employe_DateTime
    {
        DateTime DateNaissance; //un objet de type DateTime

        //Déclération et définition des propriétés

        public string Nom { get; set; }//Majuscule important pour nom
        public string Prenom { get; set; }

        public int Age
        {
            get
            {
                var ageReel = DateTime.Now - DateNaissance;
                return (ageReel.Days) / 365;
            }

            private set { } //private = interdiction de modifier           
        }

        //constructeur pour initialiser la date de naissance
        public Ex4_Employe_DateTime(DateTime dateNaissance)//vérifié tjrs type de parametre
        {
            this.DateNaissance = dateNaissance;
        }

        //Méthode pour afficher les informations d'un employé

        public void AfficherInformation()
        {
            Console.WriteLine("Nom: " + Nom);
            Console.WriteLine("Prenom: " + Prenom);
            Console.WriteLine("Date de naissance: " + DateNaissance);
            Console.WriteLine("Age: " + Age);
        }
    }
}
