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

namespace ex_030_001_anonymousMethods
{
    class Program
    {
        /// <summary>
        /// le délégué 
        /// </summary>
        /// <param name="x">un entier</param>
        /// <returns>un autre entier dépendant du paramètre et de l'exécution de la fonction de type Modifieur</returns>
        delegate int Modifieur(int x);

        delegate int Opération(int x, int y);

        /// <summary>
        /// ici, on a une méthode "m" de type "Modifieur" (le délégué juste au-dessus)
        /// et on l'affecte avec différentes "valeurs" (ici méthodes) possibles.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //on affecte une méthode anonyme à m
            Modifieur m = delegate(int x) { return x * 2; };
            int resultat = m(3);
            Console.WriteLine("m(3) = " + resultat);
            Console.WriteLine("m.Target == null ? " + (m.Target == null));
            Console.WriteLine("m.Method : " + m.Method);

            //on affecte une autre méthode anonyme à m
            m = delegate(int x) { return x * x; };
            resultat = m(3);
            Console.WriteLine("m(3) = " + resultat);
            Console.WriteLine("m.Target == null ? " + (m.Target == null));
            Console.WriteLine("m.Method : " + m.Method);

            //on affecte à m une méthode anonyme utilisant des variables locales
            int offset = 1, pente = 2;
            m = delegate(int x) { return offset + pente * x; };
            resultat = m(3);
            Console.WriteLine("m(3) = " + resultat);
            Console.WriteLine("m.Target == null ? " + (m.Target == null));
            Console.WriteLine("m.Target : " + m.Target);
            Console.WriteLine("m.Method : " + m.Method);

            Opération o = delegate(int x, int y) { return x * y; };
            Console.WriteLine("2x3 = " + o(2, 3));

            o = delegate(int x, int y) { return y - 2; };
            Console.WriteLine("3-2 = " + o(2, 3));
        }
    }
}
