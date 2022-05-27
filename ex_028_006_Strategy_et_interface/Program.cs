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

namespace ex_028_006_Strategy_et_interface
{
    class Program
    {
        IModifieur mModifieur;

        public Program(IModifieur modifieur)
        {
            mModifieur = modifieur;
        }

        public void Modifie(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = mModifieur.Modifier(tab[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] tableau = { 1, 2, 3, 4, 5 };
            Program p = new Program(new Carré());
            p.Modifie(tableau);
            foreach (int i in tableau)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            p = new Program(new Cube());
            p.Modifie(tableau);
            foreach (int i in tableau)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            p = new Program(new Droite(2, 3));
            p.Modifie(tableau);
            foreach (int i in tableau)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }


    }
}
