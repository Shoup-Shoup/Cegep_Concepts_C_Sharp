using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Polymorphisme
{
    internal class Ex3_Rabbit : Ex3_IPrey_Interface //to use the interface class you have to implement all the methods from said class
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away");
        }
    }
}
