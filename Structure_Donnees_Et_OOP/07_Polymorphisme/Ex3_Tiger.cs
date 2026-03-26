using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Polymorphisme
{
    internal class Ex3_Tiger : Ex3_IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The tiger is looking for food");
        }
    }
}
