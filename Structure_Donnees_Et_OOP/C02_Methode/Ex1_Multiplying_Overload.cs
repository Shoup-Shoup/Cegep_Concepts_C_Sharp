using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_Methode
{
    internal class Ex1_Multiplying_Overload
    {
        double a, b, c;

        /* La surcharge de méthode:
        *      Ce sont des méthodes qui partage le même nom, mais qui ont des paramètres différents ce qui les différencie
        *          et les rend unique. Le nom de la méthode plus ces paramètres est ce qu'on appel la signature de la méthode
        */

        //Définition de la méthode pour Multiplier 2 nombres
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        //Définition de la méthode pour multiplier trois paramètres
        public double Multiply(double a, double b, double c) //différence de type de parametres ou de nombre de parametre (surcharge de methode)
        {
            return a * b * c;
        }

        public float Multiply(float p, float k)
        { return p + k; }

        
    }
}
