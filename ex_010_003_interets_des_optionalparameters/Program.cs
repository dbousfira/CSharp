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

//cet exemple montre trois manières différentes de gérer les paramètres par défaut
namespace ex_010_003_interets_des_optionalparameters
{
    class C1
    {
        /// <summary>
        /// une méthode qui gère les paramètres remplis avec null : 
        /// l'utilisateur doit toujours renseigner chaque paramètre
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <returns></returns>
        public static string Method(string s1, string s2, string s3)
        {
            if (s1 == null)
            {
                s1 = "nothing";
            }
            if (s2 == null)
            {
                s2 = "nothing";
            }
            if (s3 == null)
            {
                s3 = "nothing";
            }
            return string.Format("{0} + {1} + {2}", s1, s2, s3);
        }
    }

    class C2
    {
        /// <summary>
        /// la méthode Method possède trois overload afin de gérer des valeurs par défaut
        /// Risque de confusion et impossibilité de faire toutes les combinaisons.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <returns></returns>
        public static string Method(string s1, string s2, string s3)
        {
            return string.Format("{0} + {1} + {2}", s1, s2, s3);
        }
        public static string Method(string s1, string s2)
        {
            return string.Format("{0} + {1} + nothing", s1, s2);
        }
        public static string Method(string s)
        {
            return string.Format("{0} + nothing + nothing", s);
        }
    }

    class C3
    {
        /// <summary>
        /// avec les paramètres optionnels, toutes les combinaisons sont possibles et une seule méthode suffit.
        /// Un seul inconvénient : les noms des paramètres font maintenant partis de l'API
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <returns></returns>
        public static string Method(string s1 = "nothing", string s2 = "nothing", string s3 = "nothing")
        {
            return string.Format("{0} + {1} + {2}", s1, s2, s3);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Méthode 1 : tous les champs doivent toujours être renseignés");
            Console.WriteLine("C1.Method(\"a\", \"b\", \"c\")");
            Console.WriteLine(C1.Method("a", "b", "c"));
            Console.WriteLine("C1.Method(\"a\", \"b\", null)");
            Console.WriteLine(C1.Method("a", "b", null));
            Console.WriteLine("C1.Method(\"a\", null, null)");
            Console.WriteLine(C1.Method("a", null, null));
            Console.WriteLine("C1.Method(null, \"b\", null)");
            Console.WriteLine(C1.Method(null, "b", null));

            Console.WriteLine();
            Console.WriteLine("Méthode 2 : Overloads");
            Console.WriteLine("C2.Method(\"a\", \"b\", \"c\")");
            Console.WriteLine(C2.Method("a", "b", "c"));
            Console.WriteLine("C2.Method(\"a\", \"b\")");
            Console.WriteLine(C2.Method("a", "b"));
            Console.WriteLine("C2.Method(\"a\")");
            Console.WriteLine(C2.Method("a"));

            Console.WriteLine();
            Console.WriteLine("Méthode 3 : optional parameters and named parameters");
            Console.WriteLine("C3.Method(\"a\", \"b\", \"c\")");
            Console.WriteLine(C3.Method("a", "b", "c"));
            Console.WriteLine("C3.Method(\"a\", \"b\")");
            Console.WriteLine(C3.Method("a", "b"));
            Console.WriteLine("C3.Method(\"a\")");
            Console.WriteLine(C3.Method("a"));
            Console.WriteLine("C3.Method(s2:\"b\")");
            Console.WriteLine(C3.Method(s2: "b"));
        }
    }
}
