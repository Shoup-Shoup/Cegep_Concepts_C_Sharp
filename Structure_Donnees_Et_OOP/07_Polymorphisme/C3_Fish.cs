using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Polymorphisme
{
    internal class C3_Fish : C3_IPrey_Interface, C3_IPredator //a class can inherit two interface classes
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away");
        }

        public void Hunt()
        {
            Console.WriteLine("The fish is searching fpr smaller fish");
        }
    }
}
