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
    /// <summary>
    /// le délégué
    /// Toutes les méthodes qui voudront être des "instances déléguées" de ce "type délégué"
    /// devront avoir la même signature, soit ici : prendre un entier en paramètre et rendre un entier.
    /// </summary>
    /// <param name="x">un entier</param>
    /// <returns>un autre entier dépendant du paramètre et de l'exécution de la fonction de type Modifieur</returns>
    delegate int Modifieur(int x);

    class Program
    {
        /// <summary>
        /// méthode prenant en paramètre un type délégué ("Modifieur")
        /// On peut donc utiliser dans cette méthode, n'importe quelle méthode ayant la signature du délégué.
        /// </summary>
        /// <param name="nombres">tableau de nombres à modifier</param>
        /// <param name="m">instance déléguée qui sera utilisée dans la méthode Modifie</param>
        static void Modifie(int[] nombres, Modifieur m)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                //ici on utilise l'instance délégué pour cette instruction
                nombres[i] = m(nombres[i]);
            }
        }

        /// <summary>
        /// ici, on a une méthode de type "Modifieur" (le délégué au-dessus)
        /// et on l'utilise comme type de méthode dans la signature d'une méthode (Modifie juste au-dessus).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Affichage des infos dans la Console
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("int[] tab = { 1, 2, 3, 4 };");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            int[] tab = { 1, 2, 3, 4 };
            #region Affichage des infos dans la Console
            foreach (int i in tab)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Affichage des infos dans la Console
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Modifie(tab, MaClasseDeMath.Carré);");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            Modifieur n = MaClasseDeMath.Carré;
            Modifie(tab, n);
            #region Affichage des infos dans la Console
            foreach (int i in tab)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Affichage des infos dans la Console
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Modifie(tab, Double);");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            Modifie(tab, Double);
            #region Affichage des infos dans la Console
            foreach (int i in tab)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Affichage des infos dans la Console
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Modifie(tab, Droite.Image);");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            Droite droite = new Droite(1, 2);
            Modifie(tab, droite.Image);
            #region Affichage des infos dans la Console
            foreach (int i in tab)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

        }

        /// <summary>
        /// méthode static de type "Modifieur" car elle a la même signature que le délégué Modifieur
        /// </summary>
        /// <param name="x">un entier</param>
        /// <returns>le double de l'entier pris en paramètre</returns>
        static int Double(int x)
        {
            return x * 2;
        }


    }
}

