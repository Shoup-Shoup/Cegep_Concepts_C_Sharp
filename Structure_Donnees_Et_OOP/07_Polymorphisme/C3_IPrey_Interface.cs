using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Polymorphisme
{
    internal interface C3_IPrey_Interface
    {
        /* Interface: 
         *      Sorte de contrat qui définit ce qu’un objet doit pouvoir faire, sans dire comment il le fait
         *      Une classe interface définie des méthodes et des propriétés
         *      La classe interface défini ce que la classe derivée doit avoir et la classe dérivée défini comment elle doit le faire
         *      A same class can inherit multiple interface classes
         *      It also provides added security
         *      Elle ne contient aucun attribut
         *      Sert uniquement à déclarer des méthodes que les classes dérivées seront obligé d'implémenter
         *      Les classes qui implémente une interface doivent fournir leur propre version des méthodes sans avoir besoin d'utiliser
         *          le mot clé override (il est utilisé uniquement lorsque la méthode est hérité d'une classe mère avec des méthode 
         *          virtuelle ou abstraite)
         *      On peut utiliser les classes interfaces pour simuler l'héritage multiple
         */


        void Flee(); //Implementing this method is the job of the inheriting class that is using this interface
    }
}
