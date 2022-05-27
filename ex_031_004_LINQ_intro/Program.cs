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

namespace ex_031_004_LINQ_intro
{
    class Program
    {
        class Nounours
        {
            public Nounours(string nom, DateTime naissance)
            {
                Nom = nom;
                Naissance = naissance;
            }

            public string Nom
            {
                get;
                private set;
            }

            public DateTime Naissance
            {
                get;
                private set;
            }
        }

        static void Display(Nounours[] nounours)
        {
            Console.WriteLine("début");
            foreach (Nounours n in nounours)
            {
                Console.WriteLine(n.Nom + "(" + n.Naissance + ")");
            }
            Console.WriteLine("fin");
        }

        static void Main(string[] args)
        {
            Nounours[] nounours = { new Nounours("mouton", new DateTime(2009, 09, 16)),
                                      new Nounours("ours", new DateTime(2009, 08, 15)),
                                      new Nounours("chat", new DateTime(2009, 07, 14)),
                                      new Nounours("chien", new DateTime(2009, 06, 13)),
                                      new Nounours("lapin", new DateTime(2009, 05, 12)),
                                      new Nounours("macaque", new DateTime(2009, 04, 11))};
            Display(nounours);

            //lambda queries
            IEnumerable<Nounours> filteredNounours;
            filteredNounours = nounours.Where(n => n.Nom.Length >= 5);
            Display(filteredNounours.ToArray<Nounours>());

            filteredNounours = nounours.Where(n => n.Naissance > new DateTime(2009, 07, 31));
            Display(filteredNounours.ToArray<Nounours>());
            //on peut chainer
            filteredNounours = nounours.Where(n => n.Nom.Length >= 5)
                                       .Where(n => n.Naissance > new DateTime(2009, 07, 31));
            Display(filteredNounours.ToArray<Nounours>());

            // comprehension queries
            filteredNounours = from n in nounours
                               where n.Nom.Length >= 5
                               select n;
            Display(filteredNounours.ToArray<Nounours>());

            filteredNounours = from n in nounours
                               where n.Naissance > new DateTime(2009, 07, 31)
                               select n;
            Display(filteredNounours.ToArray<Nounours>());

            filteredNounours = from n in nounours
                               where n.Nom.Length >= 5
                               where n.Naissance > new DateTime(2009, 07, 31)
                               select n;
            Display(filteredNounours.ToArray<Nounours>());

            //orderby
            filteredNounours = nounours.Where(n => n.Nom.Length >= 5).OrderBy(n => n.Nom);
            Display(filteredNounours.ToArray<Nounours>());

            //Take
            filteredNounours = nounours.Take(3).OrderBy(n => n.Nom);
            Display(filteredNounours.ToArray<Nounours>());

            //Skip
            filteredNounours = nounours.Skip(3).OrderBy(n => n.Nom);
            Display(filteredNounours.ToArray<Nounours>());

            //Reverse
            filteredNounours = nounours.OrderBy(n => n.Nom).Reverse();
            Display(filteredNounours.ToArray<Nounours>());

            //First, Last, ElementAt
            filteredNounours = nounours.OrderBy(n => n.Nom);
            Console.WriteLine("1st " + filteredNounours.First().Nom +
                "\nlast " + filteredNounours.Last().Nom +
                "\n2nd " + filteredNounours.ElementAt(1).Nom);

            //deferred execution
            filteredNounours = nounours.Where(n => n.Nom.Contains("i"));
            Display(filteredNounours.ToArray<Nounours>());
            Nounours[] tab_nounours = filteredNounours.ToArray<Nounours>();

            nounours[0] = new Nounours("girafe", new DateTime(2007, 08, 09));

            //filteredNounours = nounours.Where(n => n.Nom.Contains("i"));
            Display(tab_nounours);
            Display(filteredNounours.ToArray<Nounours>());

            //subqueries
            filteredNounours = nounours.Where(n => n.Nom.Length
                                                == nounours.OrderBy(n2 => n2.Nom.Length)
                                                .Select(n2 => n2.Nom.Length).First());
            Display(filteredNounours.ToArray<Nounours>());
        }
    }
}
