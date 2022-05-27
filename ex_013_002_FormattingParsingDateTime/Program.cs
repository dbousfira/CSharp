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

namespace ex_013_002_FormattingParsingDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Formatages standards et sensible à la culture
            DateTime maintenant = DateTime.Now;

            Console.WriteLine(maintenant.ToShortDateString());
            Console.WriteLine(maintenant.ToLongDateString());
            Console.WriteLine(maintenant.ToShortTimeString());
            Console.WriteLine(maintenant.ToLongTimeString());
            Console.WriteLine(maintenant.ToString("f"));
            Console.WriteLine(maintenant.ToString("F"));
            Console.WriteLine(maintenant.ToString("g"));
            Console.WriteLine(maintenant.ToString("m"));
            Console.WriteLine(maintenant.ToString("y"));

            //Formatage standard et insensible à la culture
            Console.WriteLine(maintenant.ToString("o")); //conseillé lors de l'écriture dans un fichier (pour garantir la lecture)

            //Formatages personnalisés
            Console.WriteLine(maintenant.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(maintenant.ToString("dd MMM yyyy HH:mm:ss"));
            Console.WriteLine(maintenant.ToString("ddd dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(maintenant.ToString("dddd dd MMMM yyyy HH:mm:ss"));

            //le troisième argument de ParseExact permet de préciser la culture. Si null, alors prend la culture par défaut sur votre .NET
            string dateString = maintenant.ToString("o");
            DateTime dateParsée = DateTime.ParseExact(dateString, "o", null);
            Console.WriteLine(dateParsée);

            dateString = maintenant.ToString("dddd dd MMMM yyyy HH:mm:ss");
            dateParsée = DateTime.ParseExact(dateString, "dddd dd MMMM yyyy HH:mm:ss", null);
            Console.WriteLine(dateParsée);
        }
    }
}
