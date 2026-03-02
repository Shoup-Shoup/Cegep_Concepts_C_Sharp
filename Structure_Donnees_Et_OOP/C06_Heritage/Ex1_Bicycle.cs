using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_Heritage
{
    //Pour associer cette classe fille a une clase mère il faut faire: nomClasseFille : nomClasseMère
    internal class Ex1_Bicycle : Ex1_Vehicule
    {
        public int nbWheels = 2;
    }
}
