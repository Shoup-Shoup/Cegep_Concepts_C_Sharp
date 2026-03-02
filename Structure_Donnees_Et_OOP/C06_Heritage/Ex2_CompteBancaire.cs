using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_Heritage
{
    internal class Ex2_CompteBancaire
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Numero { get; set; }

        //Afficher informations du compte Bancaire

        public void AfficherInfoCompte()
        {
            Console.WriteLine($"Nom: {Nom}");
            Console.WriteLine($"Prenom: {Prenom}");
            Console.WriteLine($"Numero: {Numero}");
        }
    }
}
