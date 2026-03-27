using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03_Objet_etAttribut_
{
    internal class C4_Player
    {
        public String username;

        public C4_Player(String username)
        {
            this.username = username;
        }

        public override string ToString()
        {
            return username;
        }
    }
}
