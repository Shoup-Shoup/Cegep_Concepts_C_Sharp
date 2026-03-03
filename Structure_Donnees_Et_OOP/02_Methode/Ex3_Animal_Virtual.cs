using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Methode
{
    internal class Ex3_Animal_Virtual
    {
        /* Virtual Methods:
         *      méthode d'une class de base qui peut être redéfinie dans une classe dérivée. Sans ce keyword, une méthode ne peut
         *          être redéfinie
         */

        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
}
