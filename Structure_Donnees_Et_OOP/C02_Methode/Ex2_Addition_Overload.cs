using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_Methode
{
    internal class Ex2_Addition_Overload
    {
        int x, y, z;

        /* La surcharge de méthode:
        *      Ce sont des méthodes qui partage le même nom, mais qui ont des paramètres différents ce qui les différencie
        *          et les rend unique. Le nom de la méthode plus ces paramètres est ce qu'on appel la signature de la méthode
        */

        //Définition de la méthode pour additionner deux paramètres
        public int Additionner(int x, int y)
        { return x + y; }

        //Définition de la méthode pour additionner trois paramètres
        public int Additionner(int x, int y, int z) //différence de type de parametres ou de nombre de parametre (surcharge de methode)
        { return x + y + z; }

        public float Additionner(float p, float k)
        { return p + k; }
    }
}
