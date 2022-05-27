// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Program.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-04-13
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_030_002_lambdaExpressions
{
    class Program
    {
        delegate int Modification(int i);

        delegate int Modification2(int i, int j);


        static void Main(string[] args)
        {
            Modification carré = x => x * x;
            Console.WriteLine(carré(3));

            //équivalent à : 
            //Modification carré = Carré
            //Console.WriteLine(carré(3));

            Modification2 multi = (i, j) => i * j;
            Modification2 somme = (i, j) => i + j;
            Console.WriteLine(multi(1, 2));
            Console.WriteLine(somme(1, 2));



            //on affecte une expression lambda à m
            Modification m = i => i * 2;
            int resultat = m(3);
            Console.WriteLine("m(3) = " + resultat);
            Console.WriteLine("m.Target == null ? " + (m.Target == null));
            Console.WriteLine("m.Method : " + m.Method);

            //on affecte une autre expression lambda à m
            m = i => i * i;
            resultat = m(3);
            Console.WriteLine("m(3) = " + resultat);
            Console.WriteLine("m.Target == null ? " + (m.Target == null));
            Console.WriteLine("m.Method : " + m.Method);

            //on affecte à m une autre expression lambda utilisant des variables locales à Program 
            int offset = 1, pente = 2;
            m = i => offset + pente * i;
            resultat = m(3);
            Console.WriteLine("m(3) = " + resultat);
            Console.WriteLine("m.Target == null ? " + (m.Target == null));
            Console.WriteLine("m.Target : " + m.Target);
            Console.WriteLine("m.Method : " + m.Method);
        }

        //static int Carré(int x)
        //{ 
        //  return x*x;
        //}
    }
}
