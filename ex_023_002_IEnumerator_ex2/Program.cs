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

namespace ex_023_002_IEnumerator_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            StrangeCollection col = new StrangeCollection();
            foreach (int i in col)
            {
                Console.WriteLine(i);
            }
        }
    }
}
