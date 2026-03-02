using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_Methode
{
    internal class Ex4_Cat_OverrideModifier : Ex4_Animal_VirtualModifier
    {
        /* Method Overriding:
         *      Lorsque une classe dérivée fournit sa propre version d'une méthode déjà définie et hérité par la classe de base
         *      Pour qu'une méthode puisse être override elle doit être qualifier de virtual, abstract ou override dans la classe mère
         *          et de override dans la classe fille
         *      La méthode qui est override doit avoir la même signature (nom de la méthode + ses paramètres) que la méthode
         *          de la classe de base
         */

        public override void Speak()
        {
            Console.WriteLine("cat goes *meow*");
        }
    }
}
