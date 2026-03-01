using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03_Objet_etAttribut_
{
    internal class Ex2_Car_StaticModifier
    {
        string model;

        //Exemple sans le static
        public int Ex1_numberOfCars;

        //Adding keyword static
        public static int Ex2_numberOfCars;

        public Ex2_Car_StaticModifier(string model)
        {
            this.model = model;
            Ex1_numberOfCars++; //incrémentation de number of cars pour que à chque fois qu'on créer un objet, ca augmente le nombre de +1
            Ex2_numberOfCars++;
        }
    }
}
