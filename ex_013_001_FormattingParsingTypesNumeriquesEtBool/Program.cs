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

namespace ex_013_001_FormattingParsingTypesNumeriquesEtBool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //Formatage avec ToString
            bool b = true;
            string s = b.ToString();
            Console.WriteLine("b vaut {0} : ", s);

            int i = 123, j = 1234, k = 12345;
            s = i.ToString();
            Console.WriteLine("i vaut {0} : ", s);

            Console.WriteLine();

            Console.WriteLine("FORMATS STANDARDS");
            //il existe énormément de variantes :
            //Format standards
            float f = 12345.6789f;
            float g = 0.00000006f;
            float h = 123456789.123f;
            Console.WriteLine("f = {0}", f.ToString());
            Console.WriteLine("g = {0}", g.ToString());
            Console.WriteLine("h = {0}", h.ToString());
            Console.WriteLine("\nG : notation exponentielle pour les grands ou les petits nombres");
            Console.WriteLine("f.ToString(\"G\") : {0}", f.ToString("G"));
            Console.WriteLine("g.ToString(\"G\") : {0}", g.ToString("G"));
            Console.WriteLine("h.ToString(\"G\") : {0}", h.ToString("G"));

            Console.WriteLine("\nG3 : limite la notation à 3 chiffres maximum");
            Console.WriteLine("f.ToString(\"G3\") : {0}", f.ToString("G3"));
            Console.WriteLine("g.ToString(\"G3\") : {0}", g.ToString("G3"));
            Console.WriteLine("h.ToString(\"G3\") : {0}", h.ToString("G3"));

            Console.WriteLine("\nF2 : arrondit à deux décimales");
            Console.WriteLine("f.ToString(\"F2\") : {0}", f.ToString("F2"));
            Console.WriteLine("g.ToString(\"F2\") : {0}", g.ToString("F2"));
            Console.WriteLine("h.ToString(\"F2\") : {0}", h.ToString("F2"));

            Console.WriteLine("\nE : force la notation exponentielle (avec 6 chiffres, existe aussi avec E2, E3...");
            Console.WriteLine("f.ToString(\"E\") : {0}", f.ToString("E"));
            Console.WriteLine("g.ToString(\"E2 \") : {0}", g.ToString("E2"));
            Console.WriteLine("h.ToString(\"E3\") : {0}", h.ToString("E3"));

            Console.WriteLine("\nC : currency (monnaie)");
            Console.WriteLine("f.ToString(\"C\") : {0}", f.ToString("C"));
            //number format info
            System.Globalization.NumberFormatInfo monnaie = new System.Globalization.NumberFormatInfo();
            monnaie.CurrencySymbol = "$$";
            Console.WriteLine("g.ToString(\"C2 \") : {0}", g.ToString("C2", monnaie));
            //culture info
            System.Globalization.CultureInfo info = System.Globalization.CultureInfo.GetCultureInfo("en-GB");
            Console.WriteLine("h.ToString(\"C3\") : {0}", h.ToString("C3"));

            Console.WriteLine();

            float p = 0.5349f, q = 0.53492f, r = 0.534923f;
            Console.WriteLine("p = {0}", p.ToString());
            Console.WriteLine("q = {0}", q.ToString());
            Console.WriteLine("r = {0}", r.ToString());
            Console.WriteLine("\nP : pourcentage");
            Console.WriteLine("p.ToString(\"P\") : {0}", p.ToString("P"));
            Console.WriteLine("a.ToString(\"P0 \") : {0}", q.ToString("P0"));
            Console.WriteLine("r.ToString(\"P1\") : {0}", r.ToString("P1"));

            Console.WriteLine();

            Console.WriteLine("i = {0}", i.ToString());
            Console.WriteLine("j = {0}", j.ToString());
            Console.WriteLine("k = {0}", k.ToString());
            Console.WriteLine("\nD4 : pad left avec des 0 à gauche pour avoir au moins 4 chiffres");
            Console.WriteLine("i.ToString(\"D4\") : {0}", i.ToString("D4"));
            Console.WriteLine("j.ToString(\"D4\") : {0}", j.ToString("D4"));
            Console.WriteLine("k.ToString(\"D4\") : {0}", k.ToString("D4"));

            Console.WriteLine();

            //formats personnalisés
            Console.WriteLine("FORMATS PERSONNALISES");
            float l = 123.456f;
            Console.WriteLine("l = {0}", l);
            Console.WriteLine("\n .## limite à deux nombres max après la virgule");
            Console.WriteLine("l.ToString(\".##\") : {0}", l.ToString(".##"));
            Console.WriteLine("l.ToString(\".###\") : {0}", l.ToString(".###"));
            Console.WriteLine("\n .00 comme précédemment mais complète avec des 00");
            Console.WriteLine("l.ToString(\".00\") : {0}", l.ToString(".00"));
            Console.WriteLine("l.ToString(\".0000\") : {0}", l.ToString(".0000"));
            Console.WriteLine("l.ToString(\"00.00\") : {0}", l.ToString("00.00"));
            Console.WriteLine("l.ToString(\"0000.00\") : {0}", l.ToString("0000.00"));

            int m = 5, n = -5, o = 0;
            Console.WriteLine();
            Console.WriteLine("m = {0}", m);
            Console.WriteLine("n = {0}", n);
            Console.WriteLine("o = {0}", o);
            Console.WriteLine("\n +#;(#);zero rend le nombre \"+lenombre\" si positif, \"(lenombre)\" si négatif, \"zero\" si = 0");
            Console.WriteLine("m.ToString(\"+#;(#);zero\") : {0}", m.ToString("+#;(#);zero"));
            Console.WriteLine("n.ToString(\"+#;(#);zero\") : {0}", n.ToString("+#;(#);zero"));
            Console.WriteLine("o.ToString(\"+#;(#);zero\") : {0}", o.ToString("+#;(#);zero"));

            Console.WriteLine();

            //parsing
            Console.WriteLine("PARSING");

            //méthodes statiques Parse, mais il vaut mieux la mettre dans un bloc try
            Console.WriteLine("i = int.Parse(\"yaha\");");
            try
            {
                i = int.Parse("yaha");
            }
            catch (FormatException e)
            {
                Console.WriteLine("le parse a échoué (exception : {0})", e.Message);
            }
            Console.WriteLine("i = int.Parse(123);");
            
            try
            {
                i = int.Parse("123");
            }
            catch (FormatException e)
            {
                Console.WriteLine("le parse a échoué (exception : {0})", e.Message);
            }
            Console.WriteLine(i);

            //ou avec TryParse : rend true si a fonctionné et le résultat dans le paramètre out
                                //rend false si n'a pas fonctionné et il ne faut surtout pas regarder le résultat dans out
                                // pas d'exception de lancée
            Console.WriteLine("int.TryParse(\"yaha\", out i) + \" échec\"");
            Console.WriteLine(int.TryParse("yaha", out i) + " échec");
            Console.WriteLine("int.TryParse(\"123\", out i) + \" \" + i");
            Console.WriteLine(int.TryParse("123", out i) + " " + i);

            //attention à la culture !
            //Console.WriteLine(double.Parse("1.23"));
            Console.WriteLine("double.Parse(\"1,23\")");
            Console.WriteLine(double.Parse("1,23"));
            Console.WriteLine("double.Parse(\"1.23\", System.Globalization.CultureInfo.InvariantCulture)");
            Console.WriteLine(double.Parse("1.23", System.Globalization.CultureInfo.InvariantCulture));

            //on peut compléter le parsing avec des styles (flags)
            //autoriser les parenthèses :
            string stringToParse = "(123)";
            Console.WriteLine("stringToParse = {0}", stringToParse);
            Console.WriteLine("int.TryParse(stringToParse, out i) = {0}", int.TryParse(stringToParse, out i));
            Console.WriteLine("int.TryParse(stringToParse, System.Globalization.NumberStyles.AllowParentheses, System.Globalization.CultureInfo.CurrentCulture, out i) = {0}\ni vaut = {1}", 
                int.TryParse(stringToParse, 
                             System.Globalization.NumberStyles.AllowParentheses, 
                             System.Globalization.CultureInfo.CurrentCulture, 
                             out i), 
                          i);
        }
    }
}
