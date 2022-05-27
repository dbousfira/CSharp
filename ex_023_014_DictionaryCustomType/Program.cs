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

namespace ex_023_014_DictionaryCustomType
{
    class Program
    {
        static void Main(string[] args)
        {
            var dico = new Dictionary<Nounours, int>();
            //var dico = new Dictionary<Nounours, int>(new NounoursNbPoilsEqualityComparer());
            Nounours mouton = new Nounours("mouton", new DateTime(2005, 04, 03), 2000);
            Nounours ours = new Nounours("ours", new DateTime(2006, 05, 04), 3000);
            Nounours chien = new Nounours("chien", new DateTime(2007, 06, 05), 1500);
            Nounours girafe = new Nounours("girafe", new DateTime(2008, 07, 06), 500);
            Nounours dromadaire = new Nounours("dromadaire", new DateTime(2012, 3, 11), 500);

            dico.Add(mouton, 0);
            dico.Add(ours, 0);
            dico.Add(chien, 0);
            dico.Add(girafe, 0);
            dico.Add(dromadaire, 0);
            DisplayDico(dico);

            dico[mouton]++;
            dico[chien]++;
            DisplayDico(dico);

            Nounours chien2 = new Nounours("chien", new DateTime(2007, 06, 05), 1500);
            Console.WriteLine(dico.ContainsKey(chien2));
            if (dico.ContainsKey(chien2))
            {
                dico[chien2]++;
            }
            else
            {
                dico.Add(chien2, 1);
            }
            DisplayDico(dico);
        }

        static void DisplayDico(Dictionary<Nounours, int> dico)
        {
            Console.WriteLine("**********************");
            foreach (KeyValuePair<Nounours, int> pair in dico)
            {
                Console.WriteLine(pair.Key.Name + "   " + pair.Value);
            }
            Console.WriteLine("**********************");
        }
    }
}
