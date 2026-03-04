using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Polymorphisme
{
    internal class Ex1_Car : Ex1_Vehicule
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving!");
        }
    }
}
