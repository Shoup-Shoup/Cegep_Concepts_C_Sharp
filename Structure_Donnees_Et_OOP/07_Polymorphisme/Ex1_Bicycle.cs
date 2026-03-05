using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Polymorphisme
{
    internal class Ex1_Bicycle : Ex1_Vehicule
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving!");
        }
    }
}
