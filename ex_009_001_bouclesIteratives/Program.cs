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

namespace ex_009_001_bouclesIteratives
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] jours = { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };

            //BOUCLE WHILE
            Console.WriteLine("boucle while");
            int i = 0;
            while (i < jours.Length)
            {
                Console.Write(jours[i] + " ");
                i++;
            }

            Console.WriteLine();

            //BOUCLE DO-WHILE
            Console.WriteLine("boucle do-while");
            int j = 0;
            do
            {
                Console.Write(jours[j] + " ");
                j++;
            }
            while (j < jours.Length);

            Console.WriteLine();

            //BOUCLE FOR
            Console.WriteLine("boucle for");
            for(int k=0; k<jours.Length; k++)
            {
                Console.Write(jours[k] + " ");
            }

            Console.WriteLine();

            //BOUCLE FOREACH
            Console.WriteLine("boucle foreach");
            foreach (string jour in jours)
            {
                Console.Write(jour + " ");
            }

            Console.WriteLine();

            foreach (string jour in jours)
            {
                if (jour == "Mercredi")
                    continue; //continue est autorisé : passe directement à l'itération suivante 
                if (jour == "Samedi")
                    break;    //break est autorisé : arrête la boucle
                Console.WriteLine(jour);
            }
        }
    }
}
