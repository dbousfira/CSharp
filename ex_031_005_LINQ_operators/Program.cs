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

namespace ex_031_005_LINQ_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 8, 4, 13, 7, 4, 6, 7, 4 };

            /////////////
            //Filtering//
            /////////////
            Console.WriteLine("Filtering");

            //Where : condition
            Console.WriteLine("Where");
            IEnumerable<int> filtering = numbers.Where(n => n % 2 == 0);
            foreach (int n in filtering)
            {
                Console.WriteLine(n + " ");
            }
            Console.WriteLine();

            //Take : prend les n premiers
            Console.WriteLine("Take");
            IEnumerable<int> take = numbers.Take(3);
            foreach (int n in take)
            {
                Console.WriteLine(n + " ");
            }
            Console.WriteLine();

            //TakeWhile : prend les premiers tant qu'une condition est vérifiée
            Console.WriteLine("TakeWhile");
            IEnumerable<int> takewhile = numbers.TakeWhile(n => n < 10);
            foreach (int n in takewhile)
            {
                Console.WriteLine(n + " ");
            }
            Console.WriteLine();

            //Skip : évite les n premiers
            Console.WriteLine("Skip");
            IEnumerable<int> skip = numbers.Skip(3);
            foreach (int n in skip)
            {
                Console.WriteLine(n + " ");
            }
            Console.WriteLine();

            //SkipWhile : évite les premiers tant qu'une condition est vérifiée
            Console.WriteLine("SkipWhile");
            IEnumerable<int> skipwhile = numbers.SkipWhile(n => n < 10);
            foreach (int n in skipwhile)
            {
                Console.WriteLine(n + " ");
            }
            Console.WriteLine();

            //Distinct : retire les doublons
            Console.WriteLine("Distinct");
            IEnumerable<int> distinct = numbers.Distinct();
            foreach (int n in distinct)
            {
                Console.WriteLine(n + " ");
            }
            Console.WriteLine();

            //////////////
            //Projecting//
            //////////////
            Console.WriteLine("Projecting");

            //Select : chaque élément est transformé par une expression lambda
            Console.WriteLine("Select");
            IEnumerable<int> select = numbers.Select(i => i * 10);
            foreach (int n in select)
            {
                Console.WriteLine(n + " ");
            }
            Console.WriteLine();

            //Select : on obtient une collection de même taille, mais pas obligatoirement de même type (dépend de la transformation)
            string[] bestioles = { "chat", "chien", "mouton", "elephant" };
            IEnumerable<int> select2 = bestioles.Select(s => s.Length);
            foreach (int i in select2)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();

            ////////////
            //Grouping//
            ////////////

            //GroupBy : groupe les éléments en fonction d'un critère
            Console.WriteLine("GroupBy");
            string[] bestioles2 = { "serpent", "chat", "éléphant", "chien", "étudiant", "souris", "singe", "bisounours", "hydralisk", "macaque", "cheval" };
            IEnumerable<IGrouping<char, string>> query
                = bestioles2.GroupBy(bestiole => bestiole[0]).OrderBy(group => group.Key);
            foreach (IGrouping<char, string> group in query)
            {
                Console.WriteLine("bestioles commençant par la lettre " + group.Key + " :");
                foreach (string s in group)
                {
                    Console.WriteLine("\t" + s);
                }
            }
            Console.WriteLine();

            IEnumerable<IGrouping<int, string>> query2
                = bestioles2.GroupBy(bestiole => bestiole.Length).OrderBy(group => group.Key);
            foreach (IGrouping<int, string> group in query2)
            {
                Console.WriteLine("bestioles de " + group.Key + " lettres :");
                foreach (string s in group)
                {
                    Console.WriteLine("\t" + s);
                }
            }
            Console.WriteLine();


            /////////////////
            //set operators//
            /////////////////
            Console.WriteLine("Set operators");

            int[] séquence1 = { 1, 2, 3 };
            int[] séquence2 = { 3, 4, 5 };

            //Concat : tous les éléments de la séquence 1, puis tous les éléments de la séquence 2
            Console.WriteLine("Concat");
            IEnumerable<int> concat = séquence1.Concat(séquence2);
            foreach (int n in concat)
            {
                Console.WriteLine(n + " ");
            }
            Console.WriteLine();

            //Union : tous les éléments de la séquence 1, puis tous les éléments de la séquence 2 (sans doublons)
            Console.WriteLine("Union");
            IEnumerable<int> union = séquence1.Union(séquence2);
            foreach (int n in union)
            {
                Console.WriteLine(n + " ");
            }
            Console.WriteLine();

            //Intersect : tous les éléments qui sont dans la séquence 1 ET dans la séquence 2
            Console.WriteLine("Intersect");
            IEnumerable<int> intersect = séquence1.Intersect(séquence2);
            foreach (int n in intersect)
            {
                Console.WriteLine(n + " ");
            }
            Console.WriteLine();

            //Except : tous les éléments de la séquence 1 SAUF ceux qui sont aussi dans la séquence 2
            Console.WriteLine("Except");
            IEnumerable<int> except = séquence1.Except(séquence2);
            foreach (int n in except)
            {
                Console.WriteLine(n + " ");
            }
            Console.WriteLine();
            IEnumerable<int> except2 = séquence2.Except(séquence1);
            foreach (int n in except2)
            {
                Console.WriteLine(n + " ");
            }
            Console.WriteLine();

            //////////////////////
            //element  operators//
            //////////////////////
            Console.WriteLine("Element operators");

            //Single : prend le seul et unique élément vérifiant la condition
            Console.WriteLine("Single");
            Console.WriteLine(bestioles.Single(b => b.Length == bestioles.Max(b2 => b2.Length)));
            Console.WriteLine();

            ///////////////////////
            //aggregation methods//
            ///////////////////////
            Console.WriteLine("Aggregation methods");

            //Count : compte le nombre d'éléments (avec éventuellement une condition)
            Console.WriteLine("Count");
            Console.WriteLine(bestioles.Count());
            Console.WriteLine(bestioles.Count(b => b.Length < 6));
            Console.WriteLine();

            //Min Max : rend le plus petit ou le plus grand élément d'une collection (avec éventuellement une condition)
            Console.WriteLine("Min");
            Console.WriteLine(numbers.Min());
            Console.WriteLine();

            Console.WriteLine("Max");
            Console.WriteLine(bestioles.Single(b => b.Length == bestioles.Max(b2 => b2.Length)));
            Console.WriteLine();
        }
    }
}
