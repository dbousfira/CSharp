// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Program.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-04-27
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_028_003_interface_comme_paramètre
{
    class Program : IModifieur
    {
        static void Main(string[] args)
        {
            int[] tableau = { 1, 2, 3, 4, 5 };
            IModifieur m = new Program();
            Modifie(tableau, m);
            foreach (int i in tableau)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            m = new Carré();
            Modifie(tableau, m);
            foreach (int i in tableau)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            m = new Cube();
            Modifie(tableau, m);
            foreach (int i in tableau)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            m = new Droite(2, 3);
            Modifie(tableau, m);
            foreach (int i in tableau)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public int Modifier(int nombreAModifier)
        {
            return 2 * nombreAModifier;
        }

        public static void Modifie(int[] tab, IModifieur mod)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = mod.Modifier(tab[i]);
            }
        }
    }
}
