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

namespace ex_016_005_partial
{
    class Program
    {
        static void Main(string[] args)
        {
            MaClasse c = new MaClasse();
            c.N1 = 1;
            c.N2 = 2;
            c.N3 = 3;
            Console.WriteLine(c);
        }
    }
}
