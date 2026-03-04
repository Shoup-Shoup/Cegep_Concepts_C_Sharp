using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Heritage
{
    internal class Ex2_CompteEpargne_ConstructeurHeritee : Ex2_CompteBancaire_Constructeur
    {
        double tauxEpargne;

        /* Constructeur et héritage:
         *      Si la classe mère a un constructeur défini la classe fille doit aussi en avoir un, sinon il sera impossible 
         *          de créer un objet
         *      Quand on crée un objet d'une classe dérivée, le constructeur de la classe de base est toujours appelé en premeier
         *          (toujours du plus général au plus spécifique)
         *      Si la classe de base a un constructeur paramétré, alors le constructeur de la classe dérivée doit appeler ce 
         *          constructeur avec le mot clé base
         */

        //Pour appeler le constructeur de base on doit écrir: public NomDeLaClasseFille(paramètresClasseFille, paramètresClasseMère) : base(paramètresClasseMère)
        public Ex2_CompteEpargne_ConstructeurHeritee(double tauxEpargne, string nom, string prenom) : base(nom, prenom)
        {
            this.tauxEpargne = tauxEpargne;
        }

        //affiche les informtion du compte épargne
        public void AfficherInfo()
        {
            //Console.WriteLine($"Nom: {Nom}");
            //Console.WriteLine($"Prenom: {Prenom}");
            //Console.WriteLine($"Numero: {Numero}");

            base.AfficherInfoCompte();
            Console.WriteLine($"Taux Epargne: {tauxEpargne}");
        }
    }
}
