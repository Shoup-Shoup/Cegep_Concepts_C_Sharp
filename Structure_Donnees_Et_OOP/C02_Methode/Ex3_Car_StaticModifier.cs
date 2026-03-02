using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_Methode
{
    internal class Ex3_Car_StaticModifier
    {

        string model;

        public Ex3_Car_StaticModifier(string model)
        {
            this.model = model;
        }

        /* Qualificateur static (pour une méthode ou un attribut):
         *      Le membre qualifié de static appartiendra à la classe elle même et non à l'objet
         *      Sans le keyword static, la méthode ou l'attribut appartient à chaque objet
         */

        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}
