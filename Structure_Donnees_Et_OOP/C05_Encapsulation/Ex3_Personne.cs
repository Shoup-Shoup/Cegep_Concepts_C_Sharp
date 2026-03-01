using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05_Encapsulation
{
    internal class Ex3_Personne
    {
        /*
         * Exemple 3: for some reason ici on a créer les set et get sur des lignes à part et il n'y a pas de cosntructeur aussi, donc ce serait le constructeur par défaut qui est utilisé
         */

        //déclaration des attributs
        string nom, prenom;


        //Dfinition des accesseurs pour les attributs
        public string GetNom() { return nom; }
        public string GetPrenom() { return prenom; }


        //Définition des mutateurs (modifier les attributs)
        public void SetNom(string nom) { this.nom = nom; }
        public void SetPrenom(string prenom) { this.prenom = prenom; }
    }
}
