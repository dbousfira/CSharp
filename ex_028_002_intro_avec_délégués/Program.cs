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
    /// le délégué ! tada ! 
    /// c'est un peu comme la déclaration d'un nouveau "type de méthodes"
    /// Toutes les méthodes qui voudront être des "instances déléguées" de ce "type délégué"
    /// devront avoir la même signature, soit ici : prendre un entier en paramètre et rendre un entier.
    /// </summary>
    /// <param name="x">un entier</param>
    /// <returns>un autre entier dépendant du paramètre et de l'exécution de la fonction de type Modifieur</returns>
    delegate int Modifieur(int x);

    class Program
    {
        /// <summary>
        /// ici, on a une méthode "m" de type "Modifieur" (le délégué juste au-dessus)
        /// et on l'affecte avec différentes "valeurs" (ici méthodes) possibles.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //on affecte Program.Double (méthode static de la même classe que Main) à m
            #region Affichage des infos dans la Console
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("utilisation d'une méthode ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("statique ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("comme instance de délégué : ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Double");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Modifieur m = Double;");
            Console.WriteLine("int resultat = m(3)");
            Console.ForegroundColor = ConsoleColor.Red;
            #endregion
            Modifieur m = Double;
            int resultat = m(3);
            Console.WriteLine("m(3) = " + resultat);
            #region Affichage des infos dans la Console
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            Console.WriteLine("m.Target == null ? " + (m.Target == null));
            Console.WriteLine("m.Method : " + m.Method);
            #region Affichage des infos dans la Console
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            #endregion



            //on affecte MaClasseDeMath.Carré (méthode static d'une autre classe que Main) à m
            #region Affichage des infos dans la Console
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("utilisation d'une méthode ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("statique d'une autre classe ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("comme instance de délégué : ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("MaClasseDeMath.Carré");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Modifieur m = MaClasseDeMath.Carré;");
            Console.WriteLine("int resultat = m(3)");
            Console.ForegroundColor = ConsoleColor.Red;
            #endregion
            m = MaClasseDeMath.Carré;
            resultat = m(3);
            Console.WriteLine("m(3) = " + resultat);
            #region Affichage des infos dans la Console
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            Console.WriteLine("m.Target == null ? " + (m.Target == null));
            Console.WriteLine("m.Method : " + m.Method);
            #region Affichage des infos dans la Console
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            #endregion

            //on affecte Droite.Image (méthode non static d'une autre classe que Main) à m
            #region Affichage des infos dans la Console
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("utilisation d'une méthode ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("non statique d'une autre classe ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("comme instance de délégué : ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Droite.Image");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Droite droite = new Droite(1, 2);");
            Console.WriteLine("Modifieur m = droite.Image;");
            Console.WriteLine("int resultat = m(3)");
            Console.ForegroundColor = ConsoleColor.Red;
            #endregion
            Droite droite = new Droite(1, 2);
            m = droite.Image;
            resultat = m(3);
            Console.WriteLine("m(3) = " + resultat);
            #region Affichage des infos dans la Console
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            Console.WriteLine("m.Target == null ? " + (m.Target == null));
            Console.WriteLine("m.Target : " + m.Target);
            Console.WriteLine("m.Method : " + m.Method);
            #region Affichage des infos dans la Console
            Console.ForegroundColor = ConsoleColor.White;
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

        static int Triple(int x)
        {
            return x * 3;
        }
    }

}
