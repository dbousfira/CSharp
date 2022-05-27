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

namespace ex_023_010_EqualityProtocoleOnValues
{
    class Program
    {
        static void Main(string[] args)
        {
            VieuxNounours grouinf = new VieuxNounours(1, "grouinf");
            VieuxNounours grouinf2 = new VieuxNounours(1, "grouinf2");
            //Console.WriteLine("grouinf == grouinf2 ? " + (grouinf == grouinf2));
            Console.WriteLine("grouinf.Equals(grouinf2) ? " + grouinf.Equals(grouinf2));

            Nounours grouinf3 = new Nounours(1, "grouinf3");
            Nounours grouinf4 = new Nounours(1, "grouinf4");
            Console.WriteLine("grouinf3 == grouinf4 ? " + (grouinf3 == grouinf4));
            Console.WriteLine("grouinf3.Equals(grouinf4) ? " + grouinf3.Equals(grouinf4));
        }
    }
}
