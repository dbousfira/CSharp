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

namespace ex_017_004_casting
{
    class BaseClass
    {
        public string Affiche()
        {
            return "je suis une instance de BaseClass";
        }
    }

    class ChildClass : BaseClass
    {
        public string Affiche()
        {
            return "je suis une instance de ChildClass";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //upcasting : implicite
            Console.WriteLine("Upcasting");
            ChildClass c = new ChildClass();
            Console.WriteLine(c.Affiche());
            BaseClass b = c;
            Console.WriteLine(b.Affiche());
            Console.WriteLine();

            //downcasting (C-like) : explicite
            Console.WriteLine("Downcasting (C-like)");
            BaseClass b2 = new BaseClass();
            c = (ChildClass)b; //pas d'erreur
            Console.WriteLine(c.Affiche());
            try
            {
                c = (ChildClass)b2; // erreur, b2 n'est pas une ChildClass
                Console.WriteLine(c.Affiche());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();

            //downcasting en C# : explicite
            Console.WriteLine("Downcasting en C# avec is et as");
            Console.WriteLine("b  is ChildClass ? " + (b is ChildClass));
            Console.WriteLine("b2 is ChildClass ? " + (b2 is ChildClass));

            ChildClass c2 = b as ChildClass;
            if (c2 != null)
            {
                Console.WriteLine(c2.Affiche());
            }
            else
            {
                Console.WriteLine("c2 n'est pas de type ChildClass");
            }
            c2 = b2 as ChildClass;
            if (c2 != null)
            {
                Console.WriteLine(c2.Affiche());
            }
            else
            {
                Console.WriteLine("c2 n'est pas de type ChildClass");
            }
        }
    }
}
