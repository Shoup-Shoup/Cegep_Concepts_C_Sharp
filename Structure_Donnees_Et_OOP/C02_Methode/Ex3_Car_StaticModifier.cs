using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_Methode
{
    internal class Ex3_Car_StaticModifier
    {
        String model;

        public Ex3_Car_StaticModifier(String model)
        {
            this.model = model;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}
