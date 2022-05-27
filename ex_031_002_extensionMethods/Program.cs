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

namespace ex_031_002_extensionMethods
{
    //la classe doit être statique
    public static class MyStringAdds
    {
        //il faut utiliser le this dans la signature
        public static string Comment(this string s)
        {
            StringBuilder str = new StringBuilder(s);
            str.Append(" */");
            str.Insert(0, "/* ");
            return str.ToString();
        }

        public static string DeleteWhiteSpaces(this string s)
        {
            StringBuilder str = new StringBuilder(s);
            str.Replace(" ", "-");
            return str.ToString();
        }

        public static int Inverse(this int i)
        {
            return -i;
        }

        public static int CountNonWhiteSpacesCharacters(this string s, int index)
        {
            int nb = 0;
            for (int i = index; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    nb++;
                }
            }
            return nb;
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            string s = "Voici une phrase inintéressante";
            Console.WriteLine(s);
            Console.WriteLine(s.Comment());
            Console.WriteLine(s.DeleteWhiteSpaces());
            Console.WriteLine(s.Comment().DeleteWhiteSpaces());
            Console.WriteLine(s.DeleteWhiteSpaces().Comment());
            Console.WriteLine(s.CountNonWhiteSpacesCharacters(0));
            Console.WriteLine(s.CountNonWhiteSpacesCharacters(12));
            Console.WriteLine(s.DeleteWhiteSpaces().CountNonWhiteSpacesCharacters(0).Inverse());
        }
    }
}
