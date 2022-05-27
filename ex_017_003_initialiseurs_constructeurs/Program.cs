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

namespace ex_017_003_initialiseurs_constructeurs
{
    class UneClasse
    {
        public UneClasse(string info)
        {
            Console.WriteLine("appel du constructeur de UneClasse {0}", info);
        }
    }

    class BaseClass
    {
        static UneClasse une_classe = new UneClasse("(depuis un membre statique de BaseClass) ");

        UneClasse une_classe2 = new UneClasse("(depuis un membre d'une instance de BaseClass) ");

        static BaseClass()
        {
            Console.WriteLine("appel du constructeur statique de BaseClass");
        }

        public BaseClass()
        {
            Console.WriteLine("appel du constructeur d'une instance de BaseClass");
        }
    }

    class ChildClass : BaseClass
    {
        static UneClasse une_classe3 = new UneClasse(" (depuis un membre statique de ChildClass)");

        UneClasse une_classe4 = new UneClasse(" (depuis un membre d'une instance de ChildClass) ");

        static ChildClass()
        {
            Console.WriteLine("appel du constructeur statique de ChildClass");
        }

        public ChildClass()
        {
            Console.WriteLine("appel du constructeur d'une instance de ChildClass");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChildClass c = new ChildClass();
        }
    }
}
