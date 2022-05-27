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

namespace ex_005_002_copie_de_tableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = Console.LargestWindowHeight;


            //COPIE DE TABLEAUX
            Console.WriteLine("\nCopie de tableaux");

            //1. copie de références
            Console.WriteLine("\nCopie de références\n");
            //préparation des tableaux
            int[] tab6 = { 1, 2, 3 };
            int[] tab7 = { 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("contenu de tab6");
            foreach (int i in tab6) Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine("contenu de tab7");
            foreach (int i in tab7) Console.Write(i + " ");
            Console.WriteLine();
            //recopie des références
            Console.WriteLine("tab7 = tab6;");
            tab7 = tab6; //attention, on ne copie que les références ! le contenu est donc partagé ! La preuve :
            //affichage des tableaux après copie des références
            Console.WriteLine("contenu de tab6");
            foreach (int i in tab6) Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine("contenu de tab7");
            foreach (int i in tab7) Console.Write(i + " ");
            Console.WriteLine();
            //modification d'une case d'un des tableaux
            Console.WriteLine("tab7[1] = 4;");
            tab7[1] = 4;
            //affichage des contenus après copie modification d'un des deux tableaux
            Console.WriteLine("contenu de tab7");
            foreach (int i in tab7) Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine("contenu de tab6");
            foreach (int i in tab6) Console.Write(i + " ");
            Console.WriteLine();

            //2. copie de contenus, méthode 1 : new + CopyTo
            Console.WriteLine("\nCopie de contenus, méthode 1\n");
            //préparation des tableaux
            int[] tab8 = { 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("contenu de tab6");
            foreach (int i in tab6) Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine("contenu de tab8");
            foreach (int i in tab8) Console.Write(i + " ");
            Console.WriteLine();
            //recopie des contenus
            Console.WriteLine("tab8 = new int[tab6.Length];\ntab6.CopyTo(tab8, 0);");
            tab8 = new int[tab6.Length]; // on alloue la place de tab6 pour tab8
            tab6.CopyTo(tab8, 0); // on recopie le contenu de tab6 dans tab8 (ils ont la même taille à cause de la ligne d'avant, donc tout va bien)
            //affichage des résultats
            Console.WriteLine("contenu de tab6");
            foreach (int i in tab6) Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine("contenu de tab8");
            foreach (int i in tab8) Console.Write(i + " ");
            Console.WriteLine();
            //modification d'un des deux tableaux
            Console.WriteLine("tab8[1] = 2;");
            tab8[1] = 2;
            //affichage des contenus après modification d'un des deux tableaux
            Console.WriteLine("contenu de tab6");
            foreach (int i in tab6) Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine("contenu de tab8");
            foreach (int i in tab8) Console.Write(i + " ");
            Console.WriteLine();

            //3. copie de contenus, méthode 2 : Clone
            Console.WriteLine("\nCopie de contenus, méthode 2\n");
            //préparation des tableaux
            int[] tab9 = { 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("contenu de tab6");
            foreach (int i in tab6) Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine("contenu de tab9");
            foreach (int i in tab9) Console.Write(i + " ");
            Console.WriteLine();
            //clonage des tableaux
            Console.WriteLine("tab9 = (int[])tab6.Clone();");
            tab9 = (int[])tab6.Clone();
            //affichage après clonage
            Console.WriteLine("contenu de tab6");
            foreach (int i in tab6) Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine("contenu de tab9");
            foreach (int i in tab9) Console.Write(i + " ");
            Console.WriteLine();
            //modification d'un des deux tableaux
            Console.WriteLine("tab9[1] = 2;");
            tab9[1] = 2;
            //affichage après modification
            Console.WriteLine("contenu de tab6");
            foreach (int i in tab6) Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine("contenu de tab9");
            foreach (int i in tab9) Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
