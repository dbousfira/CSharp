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

namespace ex_023_015_ReadOnlyCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            MonLit monlit = new MonLit();

            monlit.NounoursList.RemoveAt(0); // dangereux !

            (monlit.NounoursIEnumerable as List<Nounours>).RemoveAt(0); // c'est mieux, mais pas suffisant... 

            //List<Nounours> test = (monlit.NounoursROC as List<Nounours>); // pas possible
            //monlit.NounoursROC[0] = new Nounours(5, "betterave", DateTime.Now, 0); // pas possible
        }
    }
}
