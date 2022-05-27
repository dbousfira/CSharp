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

namespace ex_015_002_ordreAppelStatic
{
    class SansIntérêt
    {
        static int n = 0;

        public SansIntérêt(string nom)
        {
            n++;
            Console.WriteLine("exécution du constructeur de l'instance sans intérêt n°" + n + "(" + nom + ")");
        }
    }

    class UneClasse
    {
        public static SansIntérêt mMembreStatique1 = new SansIntérêt("membre statique 1");
        public static SansIntérêt mMembreStatique2 = new SansIntérêt("membre statique 2");
        static UneClasse()
        {
            Console.WriteLine("exécution du constructeur par défaut statique de UneClasse");
        }
        public SansIntérêt mMembreNonStatique1 = new SansIntérêt("membre instance 1");

        public SansIntérêt mMembreNonStatique2 = new SansIntérêt("membre instance 2");



        public UneClasse()
        {
            Console.WriteLine("exécution du constructeur de l'instance de UneClasse");
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            UneClasse c = new UneClasse();
        }
    }
}
