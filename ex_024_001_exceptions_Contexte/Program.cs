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

namespace ex_024_001_exceptions_Contexte
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("exemple d'exception gérée par le système : ");
            //int a = 10, b = 0;
            //int c = a / b;
            //Console.WriteLine("pas d'exception gérée");

            Console.WriteLine("exemple d'exception gérée par le système : ");
            int[] tab = { 1, 2, 3 };
            int d = tab[3];
            Console.WriteLine("pas d'exception gérée");
        }
    }
}
