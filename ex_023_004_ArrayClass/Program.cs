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

namespace ex_023_004_ArrayClass
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder[] data = new StringBuilder[4];
            data[0] = new StringBuilder("sb1");
            data[1] = new StringBuilder("sb2");
            data[2] = new StringBuilder("sb3");

            //Copie, attention aux références !
            StringBuilder[] data2 = data; //data et data2 pointent sur les mêmes cases mémoire !
            StringBuilder[] data3 = (StringBuilder[])data.Clone(); //la ième case de data et la ième case de data3 contiennent les mêmes références

            //Length, Rank, GetLength
            int[, ,] tab = { { {1, 2, 3}, {4, 5, 6} },
                            { {7, 8, 9}, {0, 1, 2} },
                            { {3, 4, 5}, {6, 7, 8} },
                            { {9, 0, 1}, {2, 3, 4} } };
            Console.WriteLine("Length : " + tab.Length);
            Console.WriteLine("Rank : " + tab.Rank);
            Console.WriteLine("GetLength(0) : " + tab.GetLength(0));
            Console.WriteLine("GetLength(1) : " + tab.GetLength(1));
            Console.WriteLine("GetLength(2) : " + tab.GetLength(2));

            //Sort
            Console.WriteLine("Sort");
            int[] nombres = { 3, 2, 1 };
            foreach (int i in nombres) Console.Write(i + " ");
            Console.WriteLine();
            Array.Sort(nombres);
            foreach (int i in nombres) Console.Write(i + " ");
            Console.WriteLine();

            //on peut aussi trier deux tableaux en tandem : le premier est trié et les éléments du second prennent les mêmes positions
            int[] nombres2 = { 3, 2, 1 };
            string[] nombres3 = { "trois", "deux", "un" };
            Console.WriteLine("tandem Sort");
            foreach (int i in nombres2) Console.Write(i + " ");
            Console.WriteLine();
            foreach (string s in nombres3) Console.Write(s + " ");
            Console.WriteLine();
            Array.Sort(nombres2, nombres3);
            foreach (int i in nombres2) Console.Write(i + " ");
            Console.WriteLine();
            foreach (string s in nombres3) Console.Write(s + " ");
            Console.WriteLine();

            //inverser les éléments 
            Console.WriteLine("Reverse");
            int[] nombres4 = { 1, 2, 3, 4, 5, 6 };
            foreach (int i in nombres4) Console.Write(i + " ");
            Console.WriteLine();
            Array.Reverse(nombres4);
            foreach (int i in nombres4) Console.Write(i + " ");
            Console.WriteLine();

            //Read only
            System.Collections.ObjectModel.ReadOnlyCollection<int> nombres5 = Array.AsReadOnly<int>(nombres4);
            foreach (int i in nombres5) Console.Write(i + " ");
            Console.WriteLine();
            //nombres5[0] += 10; //erreur de compilation

            //faire des recherches
            int lookedElement = 2;
            Console.Write("l'élément " + lookedElement + " se trouve à la position ");
            Console.WriteLine(Array.IndexOf<int>(nombres4, lookedElement) + " dans le tableau nombres4");
            Console.WriteLine();

            Console.Write("Le premier élément du tableau nombres3 à contenir un 'u' est ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Array.Find<string>(nombres3, n => n.Contains("u")));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.Write("Les éléments du tableau nombres3 qui contiennent un 'u' sont ");
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (string s in Array.FindAll<string>(nombres3, n => n.Contains("u")))
            {
                Console.Write(s + " ");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();

            string àchercher = "deux";
            Console.Write("existe-t-il un élément nommé " + àchercher + " dans le tableau nombres3 ? "
                + Array.Exists<string>(nombres3, n => n.Equals(àchercher)));
            Console.WriteLine();

            àchercher = "quatre";
            Console.Write("existe-t-il un élément nommé " + àchercher + " dans le tableau nombres3 ? "
                + Array.Exists<string>(nombres3, n => n.Equals(àchercher)));
            Console.WriteLine();

        }
    }
}
