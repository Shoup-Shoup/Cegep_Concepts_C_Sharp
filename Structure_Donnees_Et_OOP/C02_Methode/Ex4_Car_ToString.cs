using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_Methode
{
    internal class Ex4_Car_ToString
    {     
        string make;
        string model;
        int year;
        string color;

        public Ex4_Car_ToString(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        /* Méthode ToString:
       *      C'est une méthode hérité de la classe de base Object (la classe mère de tous les objets en c#)
       *      Permet d'afficher un objet sous forme de texte dans la console
       *      Elle  doit être redéfinit (override) pour pouvoir être plus lisible dans la console
       */

        public override string ToString()
        {
            //we want to return a string representation of our object
            return "This is a " + make + " " + model;
        }

    }
}
