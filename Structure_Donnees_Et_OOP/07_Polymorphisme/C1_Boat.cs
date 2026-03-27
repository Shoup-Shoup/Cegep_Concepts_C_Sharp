using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Polymorphisme
{
    internal class C1_Boat : C1_Vehicule
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving!");
        }
    }
}
