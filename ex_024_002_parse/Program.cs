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

namespace ex_024_002_parse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double d;
            string s = Console.ReadLine();

            //n = Int32.Parse(s);
            //bool res = Int32.TryParse(s, out n);
            //if (res == true)
            //{
            //    Console.WriteLine(n);
            //}
            //else
            //{
            //    Console.WriteLine("conversion impossible");
            //}

            //bool res = Double.TryParse(s, out d);
            //if (res == true)
            //{
            //    Console.WriteLine(d);
            //}
            //else
            //{
            //    Console.WriteLine("conversion impossible");
            //}

            bool res = Double.TryParse(s, System.Globalization.NumberStyles.Number, new System.Globalization.CultureInfo("en-US"), out d);
            if (res == true)
            {
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine("conversion impossible");
            }
        }
    }
}
