using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_Heritage
{
    internal class Ex3_CompteBancaire_ConstructeurBase
    {
        protected string Nom;
        protected string Prenom;
        public string Numero { get; set; }

        public Ex3_CompteBancaire_ConstructeurBase(string nom, string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }

        protected void AfficherInfoCompte()
        {
            Console.WriteLine($"Nom: {Nom}");
            Console.WriteLine($"Prenom: {Prenom}");
            Console.WriteLine($"Numero: {Numero}");
        }
    }
}
