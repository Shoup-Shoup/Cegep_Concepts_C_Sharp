using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01_Classe
{

    /* Abstract modifier:
     *      Sert a identifier un élément qui est volontairment incomplet    
     *      Si une classe non abstraite hérite d’une classe abstraite, elle est obligée d’implémenter des méthodes abstraites
     *      Using the abstract modifier on a class stops people from being able to create an instance of this class. Its stops
     *          us from doing that because the code thinks the class is incomplete
     */

    internal abstract class Ex4_Vehicule_AbstractModifier
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
}
