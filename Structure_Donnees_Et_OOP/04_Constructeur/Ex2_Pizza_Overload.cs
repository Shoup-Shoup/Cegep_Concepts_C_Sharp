using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Constructeur
{
    internal class Ex2_Pizza_Overload
    {
        /* Overloaded Constructor: 
             *      Way to create multiple constructors within the same class
             *      It has to have different parameters: different type of parameters and/or a different number, 
             *          but it can't be the same amount and type of parameters but with different names, cuz the computer 
             *          doesnt look at the names
             */

        string bread, sauce, cheese, toppings;


        //First constructor
        public Ex2_Pizza_Overload(string bread, string sauce, string cheese, string toppings)
        {
            this.bread = bread; 
            this.sauce = sauce;
            this.cheese = cheese;
            this.toppings = toppings;
        }

        //but what if we want to create a pizza without a topping? 
        //we would then create a constructor, with the same name but without the topping parametre 

        public Ex2_Pizza_Overload(string bread, string sauce, string cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }

        //pizza without cheese or toppings
        public Ex2_Pizza_Overload(string bread, string sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }

        //pizza with only bread
        public Ex2_Pizza_Overload(string bread)
        {
            this.bread = bread;
        }
    }
}
