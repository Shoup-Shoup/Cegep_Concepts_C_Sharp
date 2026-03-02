using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_Heritage
{
    internal class Ex2_CompteEpargne : Ex2_CompteBancaire
    {
        public double TauxEpargne { get; set; }

        //Affiche les informations d'un compte epargne

        public void AfficherCompteEpargne()
        {
            Console.WriteLine($"Taux Epargne: {TauxEpargne}");
        }
    }
}
