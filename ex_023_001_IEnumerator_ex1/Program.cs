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

namespace ex_023_001_IEnumerator_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3 };
            System.Collections.IEnumerator etor = tab.GetEnumerator();

            while (etor.MoveNext())
            {
                int a = (int)etor.Current;
                Console.WriteLine(a);
            }

            Console.WriteLine("ou");

            foreach (int a in tab)
            {
                Console.WriteLine(a);
            }

            //2ème exemple
            string s = "Bonjour";
            System.Collections.IEnumerator str_etor = s.GetEnumerator();
            while (str_etor.MoveNext())
            {
                Console.Write(str_etor.Current + ".");
            }
        }
    }
}
