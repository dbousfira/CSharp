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

namespace ex_023_011_EqualityComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Nounours chucky1 = new Nounours(1, "chucky 1", new DateTime(1988, 11, 9), 150);
            Nounours chucky2 = new Nounours(2, "chucky 2", new DateTime(1988, 11, 9), 125);
            Nounours chucky3 = new Nounours(3, "chucky 3", new DateTime(1992, 11, 9), 125);
            Console.WriteLine("chucky 1 == chucky 2 ? " + (chucky1 == chucky2));
            Console.WriteLine("chucky1.Equals(chucky2) ? " + chucky1.Equals(chucky2));
            Console.WriteLine("Nounours.DateDeNaissanceEqualityCompare.Equals(chucky1, chucky2) ? " + Nounours.DateDeNaissanceEqualityCompare.Equals(chucky1, chucky2));
            Console.WriteLine("new NounoursNbPoilsEqualityComparer().Equals(chucky2, chucky3) ? " + new NounoursNbPoilsEqualityComparer().Equals(chucky2, chucky3));
        }
    }
}
