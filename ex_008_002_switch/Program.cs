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

namespace ex_008_002_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int i = random.Next(6);

            switch (i)
            {
                case 0:
                    Console.WriteLine("i vaut 0"); //1 ou plusieurs instruction puis break; ("obligatoire")
                    break;
                case 1:
                case 2:
                    Console.WriteLine("i vaut 1 ou 2"); // pour que deux case partagent les mêmes instructions,
                    break;                              // il faut que le premier soit vide et sans break;
                case 3:
                    Console.WriteLine("goto à la place de break"); //si le case n'est pas vide, je peux quand même rejoindre un autre case,
                    goto case 4;                                    // à l'aide d'un goto
                case 4:
                    Console.WriteLine("i vaut 3 ou 4");
                    break;
                default:
                    Console.WriteLine("i vaut autre chose");
                    break;
            }

            string[] jours = { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };

            string jour = jours[random.Next(jours.Length)];

            //le switch fonctionne pour les chaînes de caractères !!!
            switch (jour)
            {
                case "lundi":
                    Console.WriteLine("J'aime pas le {0}", jour);
                    break;
                case "mardi":
                    Console.WriteLine("Faut travailler un peu... le {0}", jour);
                    break;
                case "mercredi":
                    Console.WriteLine("Ah l'époque où on ne travaillait pas le mercredi !");
                    break;
                case "jeudi":
                case "vendredi":
                    goto case "mardi";
                case "samedi":
                    Console.WriteLine("Vivement le weekend");
                    break;
                case "dimanche":
                    Console.WriteLine("Je travaillerai demain");
                    break;
                default:
                    Console.WriteLine("Quel jour on est !!!!????");
                    break;
            }
        }
    }
}
