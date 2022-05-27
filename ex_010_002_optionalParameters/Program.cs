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

namespace ex_010_002_optionalParameters
{
    class ExFunct
    {
        //arguments optionnels (et arguments nommés)
        public string SomeString(int x = 1, int y = 2, int z = 3)
        {
            return string.Format("x : {0}, y : {1}, z : {2}", x, y, z);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ExFunct f = new ExFunct();

            Console.WriteLine("arguments optionnels et arguments nommés");
            Console.WriteLine("SomeString() : " + f.SomeString());
            Console.WriteLine("SomeString(4) : " + f.SomeString(4));
            Console.WriteLine("SomeString(4, 5) : " + f.SomeString(4, 5));
            Console.WriteLine("SomeString(4, 5, 6) : " + f.SomeString(4, 5, 6));
            Console.WriteLine("SomeString(y:5, z:6) : " + f.SomeString(y: 5, z: 6));
            Console.WriteLine("SomeString(y:5) : " + f.SomeString(y: 5));
            //Console.WriteLine("SomeString(y:5, 6) : " + f.SomeString(y:5, 6));
            //ne compile pas (pas d'arguments positionnels après un argument nommé)
        }
    }
}
