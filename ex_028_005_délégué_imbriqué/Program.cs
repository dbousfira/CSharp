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

        static void Main(string[] args)
        {
            //on déclare une instance d'un type délégué déclaré dans une autre classe, le reste fonctionne pareil
            #region Affichage des infos dans la Console
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("utilisation d'une méthode ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("statique ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("comme instance de délégué d'un type délégué d'une autre classe : ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Double");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("MaClasseDeMath.Modifieur m = Double;");
            Console.WriteLine("int resultat = m(3)");
            Console.ForegroundColor = ConsoleColor.Red;
            #endregion
            MaClasseDeMath.Modifieur m = Double;
            int resultat = m(3);
            Console.WriteLine("m(3) = " + resultat);
            #region Affichage des infos dans la Console
            Console.ForegroundColor = ConsoleColor.DarkGray;
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
            Console.Write("comme instance de délégué d'un type délégué d'une autre classe : ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("MaClasseDeMath.Carré");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("MaClasseDeMath.Modifieur m = MaClasseDeMath.Carré;");
            Console.WriteLine("int resultat = m(3)");
            Console.ForegroundColor = ConsoleColor.Red;
            #endregion
            m = MaClasseDeMath.Carré;
            resultat = m(3);
            Console.WriteLine("m(3) = " + resultat);
            #region Affichage des infos dans la Console
            Console.ForegroundColor = ConsoleColor.DarkGray;
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
            Console.Write("comme instance de délégué d'un type délégué d'une autre classe : ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Droite.Image");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Droite droite = new Droite(1, 2);");
            Console.WriteLine("MaClasseDeMath.Modifieur m = droite.Image;");
            Console.WriteLine("int resultat = m(3)");
            Console.ForegroundColor = ConsoleColor.Red;
            #endregion
            Droite droite = new Droite(1, 2);
            m = droite.Image;
            resultat = m(3);
            Console.WriteLine("m(3) = " + resultat);
            #region Affichage des infos dans la Console
            Console.ForegroundColor = ConsoleColor.DarkGray;
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
    }

}
