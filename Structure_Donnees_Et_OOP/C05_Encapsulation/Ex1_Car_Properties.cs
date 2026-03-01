using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05_Encapsulation
{
    internal class Ex1_Car_Properties
    {
        private int speed;

        //Constructeur
        public Ex1_Car_Properties(int speed)
        {
            //assigné la propriété Speed au paramètre
            Speed = speed;
        }

        /* Propriétés: 
         *      C'est une partie de la class qui donne un accès controllé aux attributs
         *      Elle combile des aspets des attributs et des méthodes (entre deux)
         *      Elle utilise le même nom que l'attribut auquel elle est associé, mais avec une majuscule
         *      Elle a des modificateur d'accès qui peuvent avoir différents niveaux: 
         *                      public = visible et modifiable partout
         *                      private = visible uniquement dans la classe elle-même (modificateur d'accès par défaut desattributs)
         *                      protected = visible dans la classe et la classe qui hérite de la classe mère
         *      Elle contient des accesseurs(getters en En) et des mutateurs (setters en En):
         *                      getter = méthode qui permet de lire la valeur d'un attribut et ne modifie pas l'objet
         *                      setter = méthode qui permet de modifier la valeur d'un attribut
         */

        //On l'écrit: modificateurAcces type NomAttribut {
        public int Speed 
        {
            get { return speed; } //reads the value within the field


            /* Keyword value: 
             *      Kind of like a parametre
             *      It's the value that will be assign once the object is created
             */

            set //write a new value
            {
                if (value > 500) //allows to limit the client coder to using a max speed of 500
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
}
