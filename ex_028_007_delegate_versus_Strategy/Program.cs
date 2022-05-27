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

using Namespace2;

namespace Namespace1
{
    class Program
    {
        /// <summary>
        /// on définit le délégué ici avec la visibilité qui nous intéresse (ici j'ai choisi internal)
        /// </summary>
        /// <param name="x">un entier</param>
        /// <returns>un autre entier dépendant du paramètre et de l'exécution de la fonction de type Modifieur</returns>
        internal delegate int Modifieur(int x);

        /// <summary>
        /// instance du délégué de type délégué Modifieur déclaré au-dessus
        /// </summary>
        Modifieur MonModifieur;

        public void Modifie(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = MonModifieur(tab[i]);
            }
        }

        public Program(Modifieur modifieur)
        {
            MonModifieur = modifieur;
        }

        static void Main(string[] args)
        {
            int[] tableau = { 1, 2, 3, 4, 5 };
            Program p = new Program(MaClasseDeMath.Carré);
            p.Modifie(tableau);
            foreach (int i in tableau)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            p = new Program(MaClasseDeMath.Cube);
            p.Modifie(tableau);
            foreach (int i in tableau)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            p = new Program(new Droite(2, 3).Image);
            p.Modifie(tableau);
            foreach (int i in tableau)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }

}
