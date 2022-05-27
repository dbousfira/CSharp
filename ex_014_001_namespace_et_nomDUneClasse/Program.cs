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

// un namespace est un domaine dans lequel les types doivent être uniques
// on peut organiser les types de manière hiérarchique, pour deux raisons :
//      - éviter les conflits
//      - les rendre plus faciles à trouver
// par exemple : System.Collections.Generic.List<>

//using permet d'importer un namespace et ses types (mais pas les namespaces qu'il contient)
using Ext;
using Ext.Milieu.Int;


namespace Ext.Milieu.Int
{
    public class C1 { } //le vrai nom de C1 est : Ext.Milieu.Int.C1
}

namespace Ext
{
    namespace Milieu
    {
        namespace Int
        {
            public class C2 { } // le vrai nom de C2 est : Ext.Milieu.Int.C2
        }
        public class C3 { } //le vrai nom de C3 est : Ext.Milieu.C3
    }
    public class C4 { } // le vrai nom de C4 est : Ext.C4
}

namespace ex_014_001_namespace_et_nomDUneClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            C4 b = new C4();
            Console.WriteLine(b.GetType());

            C1 c = new C1();
            Console.WriteLine(c.GetType());

            C2 d = new C2();
            Console.WriteLine(d.GetType());

            Ext.Milieu.C3 a = new Ext.Milieu.C3();
            Console.WriteLine(a.GetType());
        }
    }
}

