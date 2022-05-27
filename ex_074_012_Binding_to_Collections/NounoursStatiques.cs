using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_074_012_Binding_to_Collections
{
    public static class NounoursStatiques
    {
        public static List<Nounours> ListeNounours = new List<Nounours>()
        {
            new Nounours("Chewbacca", new DateTime(1977, 5, 27), 1234567),
            new Nounours("Yoda", new DateTime(1980, 5, 21), 3),
            new Nounours("Ewok", new DateTime(1983, 5, 25), 3456789)
        };
    }
}
