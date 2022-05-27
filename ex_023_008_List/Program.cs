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

namespace ex_023_008_List
{
    class Program
    {
        static void Display(List<string> colors)
        {
            Console.WriteLine("début");
            foreach (string s in colors)
            {
                Console.WriteLine("\t" + s);
            }
            Console.WriteLine("fin");
        }

        static void Main(string[] args)
        {
            List<string> colors = new List<string>();
            Console.WriteLine("Add");
            colors.Add("rouge");
            colors.Add("jaune");
            Display(colors);

            Console.WriteLine("AddRange");
            colors.AddRange(new string[] { "vert", "bleu", "orange" });
            Display(colors);

            Console.WriteLine("Insert");
            colors.Insert(1, "violet");
            Display(colors);

            Console.WriteLine("InsertRange");
            colors.InsertRange(3, new string[] { "beige", "gris", "noir", "rose" });
            Display(colors);

            Console.WriteLine("Remove");
            colors.Remove("bleu");
            colors.RemoveAt(2);
            colors.RemoveRange(3, 2);
            Display(colors);

            Console.WriteLine("RemoveAll string starting with v");
            colors.RemoveAll(delegate(string s) { return s.StartsWith("v"); });
            Display(colors);

            Console.WriteLine("indexer et Count");
            Console.WriteLine(colors[0]);
            Console.WriteLine(colors[colors.Count - 1]);

            Console.WriteLine("subsets");
            Display(colors.GetRange(1, 2));

            Console.WriteLine("ToArray");
            string[] tab = colors.ToArray();
            foreach (string s in tab) Console.Write(s + " ");
            Console.WriteLine();

            Console.WriteLine("CopyTo");
            colors.CopyTo(2, tab, 0, 2); //copie, à partir du 3 ème élément de colors, dans tab à partir du 1er élément, 2 éléments.
            foreach (string s in tab) Console.Write(s + " ");
            Console.WriteLine();

            Console.WriteLine("ConvertAll");
            List<string> Colors = colors.ConvertAll<string>(delegate(string s) { return (s.Substring(0, 1).ToUpper() + s.Substring(1)); });
            Display(Colors);
            List<int> lengths = colors.ConvertAll<int>(delegate(string s) { return (s.Length); });
            foreach (int i in lengths) Console.Write(i + " ");
            Console.WriteLine();

            //searching and sorting
            Console.WriteLine("Dans Colors, les éléments suivants commencent par 'R' : ");
            foreach (string s in Colors.FindAll(n => n.StartsWith("R")))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }


    }
}
