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

namespace ex_004_004_TypeBool
{
    class Program
    {
        static void Main(string[] args)
        {
            //type booléen
            bool boolean; //true ou false

            boolean = true;
            Console.WriteLine("true : {0}", true);
            Console.WriteLine("false : {0}", false);

            Console.WriteLine("FalseString : {0}", bool.FalseString);
            Console.WriteLine("TrueString : {0}", bool.TrueString);
        }
    }
}
