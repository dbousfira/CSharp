// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Program.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-04-27
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_028_001_intro_avec_interfaces
{
    class Program : IModifieur
    {
        static void Main(string[] args)
        {
            IModifieur m = new Program();
            Console.WriteLine(m.Modifier(5));

            m = new Carré();
            Console.WriteLine(m.Modifier(5));

            m = new Cube();
            Console.WriteLine(m.Modifier(5));

            m = new Droite(2, 3);
            Console.WriteLine(m.Modifier(5));
        }

        public int Modifier(int nombreAModifier)
        {
            return 2 * nombreAModifier;
        }
    }
}
