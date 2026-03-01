using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05_Encapsulation
{
    internal class Ex2_Animal_AutoImplemented
    {
        /* Auto-Implemented Properties:
         *      C'est une propriété pour laquel on a pas besoin de déclaré d'attribut
         *      C'est un bon shortcut quand il n'y a pas besoin de restreindre plus que ca l'attribut (comme a l'exemple 1)
         */

        //s'écrit: public type NameOfField { set; get; }
        public string Type { get; set; } // pas besoin de déclarer un attribut avant

        //Constructeur
        public Ex2_Animal_AutoImplemented(string type)
        {
            this.Type = type;
        }

        
    }
}
