using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Objet_etAttribut_
{
    internal class Ex1_Human_Attributs
    {
        /*
        * Attributs (fields en anglais):
        *      They are defining caracteristique of what an object has
        *      Ce sont des variables déclarées a l'intérieur d'une classe qui stock les données pour les objets
        *      Il existe plusieurs qualificateurs d'attributs:
        *                      private =
        *                      protected =
        *                      static = meaning the field belongs to the class and not the object
        *                      readonly = 
        *                      const =
        */


        //Creating fields: Defining attributes of what humans should have
        public string name;
        public int age;


        public void Eat()
        {
            Console.WriteLine(name + "is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + "is sleeping");
        }
    }
}
