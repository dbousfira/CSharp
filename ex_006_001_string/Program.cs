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
using System.Globalization;

namespace ex_006_001_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth +=15;

            Console.WriteLine("STRING : Chaîne de caractères immuable");

            //construction
            Console.WriteLine("CONSTRUCTION");
            string s1 = "Bonjour";

            //caractères spéciaux avec le caractère d'échappement \
            Console.WriteLine("CARACTERES SPECIAUX");
            string s2 = "\'coucou1\' \"coucou2\" \\coucou3\\";
            Console.WriteLine(s2);
            s2 = "nouvelle\nligne";
            Console.WriteLine(s2);
            s2 = "retour\rcharriot";
            Console.WriteLine(s2);
            s2 = "horizontal\ttab";
            Console.WriteLine(s2);
            s2 = "alerte audio \a"; // \a fait un son lorsque le string est affiché
            Console.WriteLine(s2);

            //verbatim
            Console.WriteLine("\n VERBATIM");
            string s3 = "\\\\server\\machin\\trucmuche\\home"; // chaîne non verbatim, il faut utiliser le caractère d'échappement pour afficher 
                                                               // les backslashs
            Console.WriteLine(s3);
            s3 = @"\\server\machin\truchmuche\home";           // chaîne verbatim, les caractères spéciaux sont traités comme les autres
            Console.WriteLine(s3);

            //string vide
            Console.WriteLine("\n CHAINE DE CARACTERES VIDE");
            string s4 = "";
            Console.WriteLine("la chaîne de caractères : \"" + s4 + "\" a une longueur de : " + s4.Length + " caractère(s)");
            //ou
            s4 = String.Empty;
            Console.WriteLine("la chaîne de caractères : \"" + s4 + "\" a une longueur de : " + s4.Length + " caractère(s)");
            Console.WriteLine("s4 == \"\" ? " + (s4 == ""));
            Console.WriteLine("s4 == String.Empty ? " + (s4 == string.Empty));
            Console.WriteLine("s4.Length == 0 ? " + (s4.Length == 0));

            //string null (string est reference type)
            Console.WriteLine("\n CHAINE DE CARACTERES NULLE");
            string s5 = null;
            Console.WriteLine("s5 == \"\" ? " + (s5 == ""));
            try
            {
                Console.WriteLine("s5.Length == 0 ? " + (s5.Length == 0));
            }
            catch
            {
                Console.WriteLine("s5.Length == 0 ? False");
            }

            Console.WriteLine("string.IsNullOrEmpty(s4) ?" + string.IsNullOrEmpty(s4));
            Console.WriteLine("string.IsNullOrEmpty(s5) ?" + string.IsNullOrEmpty(s5));
            Console.WriteLine("string.IsNullOrWhiteSpace(\"   \") ?" + string.IsNullOrWhiteSpace("   "));

            //accéder et chercher dans les string
            Console.WriteLine("\n RECHERCHER DANS LES STRING");
            string s6 = "barbapapa";
            Console.WriteLine(s6);
            Console.WriteLine("3ème caractère : " + s6[2]);
            Console.WriteLine("s6.Contains(\"pa\") ? " + s6.Contains("pa"));
            Console.WriteLine("s6.EndsWith(\"pa\") ? " + s6.EndsWith("pa"));
            Console.WriteLine("s6.StartsWith(\"ba\") ? " + s6.StartsWith("ba"));
            Console.WriteLine("s6.IndexOf(\"ba\") ? " + s6.IndexOf("ba"));

            //manipuler les string
            Console.WriteLine("\n MANIPULER LES STRING");
            Console.WriteLine("CONCATENATION DE STRING");
            //concatenation de string
            string s7 = "Jim" + " " + "Raynor";
            Console.WriteLine("\"Jim\" + \" \" + \"Raynor\" = \"{0}\"", s7);   
            //substring
            Console.WriteLine("SUBSTRING");
            string s8 = s7.Substring(0, 3);
            Console.WriteLine("\"Jim Raynor\".Substring(0, 3) = {0}", s8);
            s8 = s7.Substring(2, 3);
            Console.WriteLine("\"Jim Raynor\".Substring(2, 3) = {0}", s8);
            s8 = s7.Substring(5);
            Console.WriteLine("\"Jim Raynor\".Substring(5) = {0}", s8);

            //insert, remove, replace, ToUpper, ToLower
            Console.WriteLine("REMOVE");
            s8 = s7.Remove(2, 3);
            Console.WriteLine("\"Jim Raynor\".Remove(2, 3) = {0}", s8);
            Console.WriteLine("INSERT");
            s8 = s8.Insert(2, "m R");
            Console.WriteLine("\"Jiaynor\".Insert(2, \"m R\") = {0}", s8);
            Console.WriteLine("REPLACE");
            s8 = "Les chaussettes de l'archiduchesse";
            s8 = s8.Replace(" ", "_");
            Console.WriteLine("\"Les chaussettes de l'archiduchesse\".Replace(\" \", \"_\") = {0}", s8);
            Console.WriteLine("TO UPPER, TO LOWER");            
            s8 = s8.ToUpper();
            Console.WriteLine("\"Les_chaussettes_de_l'archiduchesse\".ToUpper() = {0}", s8);
            s8 = s8.ToLower();
            Console.WriteLine("\"LES_CHAUSSETTES_DE_L'ARCHIDUCHESSE\".ToLower() = {0}", s8);


            //PadLeft, PadRight
            Console.WriteLine("\n PADLEFT, PADRIGHT, TRIM");
            s8 = s8.PadLeft(50).PadRight(60, '!');
            Console.WriteLine("\"les_chaussettes_de_l'archiduchesse\".PadLeft(50).PadRight(60, \'!\') = \n{0}", s8);


            //Trim : enlève les blancs (whitespace, tab, new lines...)
            s8 = s8.Trim(); //existe aussi avec TrimStart et TrimEnd
            Console.WriteLine("\"                les_chaussettes_de_l'archiduchesse!!!!!!!!!!\".Trim() = \n{0}", s8);

            //Split et Join
            Console.WriteLine("\n SPLIT ET JOIN");
            s8 = "Les chaussettes de l'archiduchesse";
            Console.WriteLine("\"{0}\" est composé des mots suivants \n(\"Les chaussettes de l'archiduchesse\".Split()): ", s8);
            string[] mots = s8.Split();
            foreach (string m in mots)
            {
                Console.WriteLine("\t- {0}", m);
            }
            Console.WriteLine("On peut regrouper les mots précédents (tableau de string : string[] mots;) avec Join");
            string s9 = string.Join(" ", mots);
            Console.WriteLine("string.Join(\" \", mots) = {0}", s9);

            //Format
            Console.WriteLine("\n STRING.FORMAT");
            string format = "Il y a {0} élèves inscrits en {1} année à l'IUT pour l'année scolaire {2}";
            Console.WriteLine("Le format : \"{0}\"", format);
            string chaineFormatée = string.Format(format, 110, "2ème", "2011-2012");
            Console.WriteLine("chaîne formatée avec le format : {0}", chaineFormatée);
            Console.WriteLine("on peut aussi tout faire dans le Console.WriteLine, sans préciser string.Format : ");
            Console.WriteLine("Il y a {0} élèves inscrits en {1} année à l'IUT pour l'année scolaire {2}", 110, "2ème", "2010-2011");
            format = "Nb élèves : {0, -5} Année : {1, -5} Année universitaire : {2, 15}";
            Console.WriteLine("format plus élaboré, pour imposer des tailles : \n{0}", format);
            Console.WriteLine("Quelques chaînes formatées (avec ou sans string.Format pour voir la différence d'écriture) : ");
            chaineFormatée = string.Format(format, 110, "2ème", "2010-2011");
            Console.WriteLine(chaineFormatée);
            chaineFormatée = "Nb élèves : " + 110.ToString().PadRight(5) + " Année : " + "2ème".PadRight(5) + " Année universitaire : " + "2010-2011".PadLeft(15);
            Console.WriteLine(chaineFormatée);
            chaineFormatée = "Nb élèves : " + 98.ToString().PadRight(5) + " Année : " + "2ème".PadRight(5) + " Année universitaire : " + "2010-2011".PadLeft(15);
            Console.WriteLine(chaineFormatée);

            //comparaison de string
            Console.WriteLine("\n COMPARAISON DE STRING");
            //equality comparison
            Console.WriteLine("\"yaha\" == \"YAHA\" ? " + ("yaha" == "YAHA"));
            Console.WriteLine("\"yaha\".Equals(\"YAHA\") ? " + ("yaha".Equals("YAHA")));
            Console.WriteLine("string.Equals(\"yaha\", \"YAHA\") ? " + string.Equals("yaha", "YAHA"));
            Console.WriteLine("\"yaha\".Equals(\"YAHA\", StringComparison.CurrentCultureIgnoreCase) ? " + ("yaha".Equals("YAHA", StringComparison.CurrentCultureIgnoreCase)));
            Console.WriteLine("string.Equals(\"yaha\", \"YAHA\", StringComparison.CurrentCultureIgnoreCase) ? " + string.Equals("yaha", "YAHA", StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine("string.Equals(\"éèàô\", \"eeao\") ? " + string.Compare("éèàô", "eeao", CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace));
        
        }
    }
}
