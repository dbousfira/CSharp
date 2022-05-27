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
using System.Text;

namespace ex_006_002_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth += 15;
            Console.WindowHeight = Console.LargestWindowHeight;

            Console.Write("STRING BUILDER : version ");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("muable");
            Console.ResetColor();
            Console.WriteLine(" de string");

            //construction
            Console.WriteLine("\n CONSTRUCTION");
            Console.WriteLine("à l'aide d'un string : StringBuilder s1 = new StringBuilder(\"Bonjour\");");
            StringBuilder s1 = new StringBuilder("Bonjour");
            Console.WriteLine(s1.ToString());
            Console.WriteLine("à l'aide d'une sous-chaîne d'un string : s1 = new StringBuilder(\"Bonjour\", 0, 3, 3);");
            s1 = new StringBuilder("Bonjour", 0, 3, 3);
            Console.WriteLine(s1);

            //manipuler les string builder
            Console.WriteLine("\n MANIPULER LES STRING BUILDER");
            //append
            Console.WriteLine("APPEND");
            StringBuilder s7 = new StringBuilder().Append("Jim").Append(" ").Append("Raynor");
            Console.WriteLine("new StringBuilder().Append(\"Jim\").Append(\" \").Append(\"Raynor\"); contient {0}", s7);
            Console.WriteLine("APPEND FORMAT");
            string format = "Il y a {0} élèves inscrits en {1} année à l'IUT pour l'année scolaire {2}";
            Console.WriteLine("Le format : {0}", format);
            StringBuilder s9 = new StringBuilder().AppendFormat(format, 110, "2ème", "2011-2012");
            Console.WriteLine("new StringBuilder().AppendFormat(format, 110, \"2ème\", \"2011-2012\"); vaut :\n{0}", s9);
            Console.WriteLine();

            //insert, remove, replace
            StringBuilder s8 = new StringBuilder("Jim Raynor");
            Console.WriteLine("StringBuilder s8 = new StringBuilder(\"Jim Raynor\");");
            Console.WriteLine("REMOVE");
            s8.Remove(2, 3);
            Console.WriteLine("s8.Remove(2, 3) vaut {0}", s8);
            Console.WriteLine("INSERT");
            s8.Insert(2, "m R");
            Console.WriteLine("s8.Insert(2, \"m R\") vaut {0}", s8);
            Console.WriteLine("CLEAR");
            s8.Clear();
            Console.WriteLine("s8.Clear()");
            Console.WriteLine("REPLACE");
            Console.WriteLine("s8.Append(\"Les chaussettes de l'archiduchesse\");");
            s8.Append("Les chaussettes de l'archiduchesse");
            s8.Replace(" ", "_");
            Console.WriteLine("s8.Replace(\" \", \"_\") vaut {0}", s8);
        }
    }
}
