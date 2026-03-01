using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructeurs
{
    internal class Ex1_Humain
    {
        public string name;
        public int age;
        public string address;

        //to write the constructor: public className(parametres)
        public Ex1_Humain(string name, int age, string address) //ceci est un constructeur paramétré puisqu'il contient des paramètres
        {
            /* Pointeur this: 
             *      Le this.nomAttribut permet de distinguer l'attribut du paramètre
             *      Il fait référence à l'instance (objet) actuelle de la classe 
             */

            //assigning fields: this.fieldName = parametreName;
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public void Living()//if you write "string name" as a parametre, you will have to pass on a parametre when calling the method, but here you dont seem to have to declare name as a parametre anyways
        {
            Console.WriteLine(name + "is a living human being");
        }

        public void Aging()
        {
            Console.WriteLine($"This human has been living for {age} years");
        }

        public void Doxxing()
        {
            Console.WriteLine("To go an harrass the human, go to " + address);
        }

    }
}
