using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Encapsulation
{
    internal class Ex3_Personne_Manuelle
    {

        //déclaration des attributs
        string nom, prenom;


        //Dfinition des accesseurs pour les attributs (écriture plus ancienne)
        public string GetNom() { return nom; }
        public string GetPrenom() { return prenom; }


        //Définition des mutateurs (modifier les attributs)
        public void SetNom(string nom) { this.nom = nom; }
        public void SetPrenom(string prenom) { this.prenom = prenom; }
    }
}
