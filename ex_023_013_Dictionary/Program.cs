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

namespace ex_023_013_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dico = new Dictionary<string, int>();

            dico.Add("Romain", 1);  //ajoute un nouveau couple "Romain", 1
            dico["Simon"] = 2;      //ajoute un nouveau couple "Simon", 2
            dico["Guillaume"] = 2;  //ajoute un nouveau couple "Guillaume", 2
            dico["Guillaume"] = 3;  //modifie la valeur du couple dont la clé est "Guillaume" en 3
            dico["Romain"]++;       //modifie la valeur du couple dont la clé est "Romain" en 2

            Console.WriteLine("valeur de 'Romain' : " + dico["Romain"]);
            Console.WriteLine("valeur de 'Simon' : " + dico["Simon"]);
            Console.WriteLine("valeur de 'Guillaume' : " + dico["Guillaume"]);

            Console.WriteLine("le dico contient-il une clé 'Simon' ? " + dico.ContainsKey("Simon"));
            Console.WriteLine("le dico contient-il une valeur '2' ? " + dico.ContainsValue(2));

            //TryGetValue
            int val;
            if (!dico.TryGetValue("Simon", out val))
            {
                Console.WriteLine("pas de Simon");
            }
            else
            {
                Console.WriteLine("Simon existe " + val + " fois");
            }

            if (!dico.TryGetValue("Gertrude", out val))
            {
                Console.WriteLine("pas de Gertrude");
            }
            else
            {
                Console.WriteLine("Gertrude existe");
            }

            //enumeration
            Console.WriteLine("***********************");
            foreach (KeyValuePair<string, int> pair in dico)
            {
                Console.WriteLine(pair.Key + "   " + pair.Value);
            }
            Console.WriteLine("***********************");
            foreach (string s in dico.Keys)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("***********************");
            foreach (int i in dico.Values)
            {
                Console.WriteLine(i);
            }



            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("mille", 1000);
            d.Add("dix", 10);
            d.Add("cent", 100);
            foreach (KeyValuePair<string, int> pair in d)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }

            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();
            sd.Add(10, "dix");
            sd.Add(100, "cent");
            sd.Add(1000, "mille");
            foreach (KeyValuePair<int, string> pair in sd)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
        }
    }
}
