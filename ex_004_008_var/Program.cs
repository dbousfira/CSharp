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

namespace ex_004_008_var
{
    class Program
    {
        static void Main(string[] args)
        {
            //var : mot clé pour déclarer en même temps qu'on initialise une variable
            //le type est automatiquement choisi
            var var1 = 5; // est équivalent à int var1 = 5;
            Console.WriteLine("le type de var1 est " + var1.GetType());
            var var2 = "coucou"; // est équivalent à string var2 = "coucou";
            Console.WriteLine("le type de var2 est " + var2.GetType());
        }
    }
}
