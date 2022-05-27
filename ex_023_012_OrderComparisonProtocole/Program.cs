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

namespace ex_023_012_OrderComparisonProtocole
{
    class Program
    {
        static void Main(string[] args)
        {

            Nounours[] monLit = { new Nounours(1, "Beluga", new DateTime(2012, 07, 29), 0, 35f),
                                    new Nounours(2, "Singe", new DateTime(2009, 08, 09), 1345, 15f),
                                    new Nounours(3, "Girafe", new DateTime(2007, 11, 02), 567, 215f)};
            foreach (Nounours n in monLit)
            {
                Console.WriteLine(n.Name);
            }
            Console.WriteLine("*****************");

            Array.Sort(monLit);
            foreach (Nounours n in monLit)
            {
                Console.WriteLine(n.Name);
            }
            Console.WriteLine("*****************");

            Array.Sort(monLit, Nounours.NbPoilsCompare);
            foreach (Nounours n in monLit)
            {
                Console.WriteLine(n.Name);
            }
            Console.WriteLine("*****************");

            Array.Sort(monLit, new NounoursDateComparer());
            foreach (Nounours n in monLit)
            {
                Console.WriteLine(n.Name);
            }
            Console.WriteLine("*****************");
        }
    }
}
