// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Program.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-03-30
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_023_016_IEnumerableOfInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            MonLit monlit = new MonLit();

            monlit.NounoursList.RemoveAt(0); // dangereux !

            (monlit.NounoursIEnumerable as List<Nounours>).RemoveAt(0); // c'est mieux, mais pas suffisant... 
            monlit.NounoursIEnumerable.ElementAt(0).NbPoils -= 100; //aïe...

            //List<Nounours> test = (monlit.NounoursROC as List<Nounours>); // pas possible
            //monlit.NounoursROC[0] = new Nounours(5, "betterave", DateTime.Now, 0); // pas possible
            //mais ...
            monlit.NounoursROC[0].NbPoils -= 100; // aïe...

            //ouf ! comme ça c'est parfait
            //            monlit.MesNounours.ElementAt(0).NbPoils -= 100;
        }
    }
}
