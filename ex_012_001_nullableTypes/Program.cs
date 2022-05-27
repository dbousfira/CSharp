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

namespace ex_012_001_nullableTypes
{
    class Program
    {
        //les types référence peuvent représenter une valeur non-existante (null reference)
        //par contre, les valeurs elles, ne le peuvent pas : int i = null n'est pas autorisé
        //En C# on peut quand même le faire, à l'aide des nullable types
        static void Main(string[] args)
        {
            int? i = null;
            Console.WriteLine("int? i = null");
            Console.Write("i == null ? ");
            Console.WriteLine(i == null);
            Console.WriteLine("i.HasValue " + i.HasValue);
            Console.WriteLine("i or default : " + i.GetValueOrDefault());
            i = 2;
            Console.WriteLine("i = 2");
            Console.Write("i == null ? ");
            Console.WriteLine(i == null);
            Console.WriteLine("i.HasValue " + i.HasValue);
            Console.WriteLine("i or default : " + i.GetValueOrDefault());
            Console.WriteLine("i.Value : " + i.Value);

            //l'opérateur ?? est le null coalescing operator
            int? x = null;
            int y = x ?? 5; // y vaut 5 car x est null
            int? a = 1;
            int? b = 2;
            int? z = x ?? a ?? b; // y vaut 1 car a est la première valeur non nulle
            int? c = null;
            int? w = x ?? c ?? b; // y vaut 2 car b est la première valeur non nulle

            
        }
    }
}

