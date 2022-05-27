// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Program.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-05-26
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_032_001_TextReader_TextWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //METHODE 1
            //écriture de deux lignes dans un fichier
            //using : on utilise un bloc using pour les ressources non managées (comme les streams, les images, etc...)
            //          using est un raccourci pour appeler Dispose() sur une instance d'un type implémentant IDisposable,
            //          tout en utilisant implicitement try/finally
            //          vous n'avez du coup pas besoin de nettoyer explicitement vos ressources si vous les construisez à l'intérieur d'un bloc using

            //construction d'un stream : celui-ci ne gère que des bytes
            //si vous voulez écrire des char, des strings, des fragments xml, etc... vous devez brancher un adapter à votre stream
            //ici, nous branchons un textwriter pour pouvoir écrire directement du texte
            using (FileStream fs = File.Create("test1.txt"))
            {
                using (TextWriter writer = new StreamWriter(fs))
                {
                    writer.WriteLine("Une première ligne vraiment très intéressante...");
                    writer.WriteLine("Une deuxième ligne vraiment très intéressante...");
                }
            }
            //lecture de deux lignes dans un fichier
            using (FileStream fs = File.OpenRead("test1.txt"))
            {
                using (TextReader reader = new StreamReader(fs))
                {
                    Console.WriteLine(reader.ReadLine());
                    Console.WriteLine(reader.ReadLine());
                }
            }

            Console.WriteLine("".PadRight(Console.WindowWidth - 1, '*'));

            //METHODE 2
            //on branche tellement souvent un adapter de type Text à un stream, qu'il existe des raccourcis avec :
            // File.CreateText, File.AppendText, File.OpenText
            //Ceux-ci permettent de n'utiliser qu'un seul bloc using pour faire la même chose. 
            using (TextWriter writer = File.CreateText("test2.txt"))
            {
                writer.WriteLine("Une troisième ligne vraiment très intéressante...");
                writer.WriteLine("Une quatrième ligne vraiment très intéressante...");
            }

            //comme son nom l'indique, AppendText permet d'écrire à la fin du flux
            using (TextWriter writer = File.AppendText("test2.txt"))
            {
                writer.WriteLine("Une cinquième ligne vraiment très intéressante...");
            }

            //Peek() permet de vérifier si on est arrivé à la fin du flux.
            using (TextReader reader = File.OpenText("test2.txt"))
            {
                while (reader.Peek() > -1)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }

            Console.WriteLine("".PadRight(Console.WindowWidth - 1, '*'));
            
            //on peut aussi tester si ReadLine rend null pour tester la fin du fichier
            using (TextReader reader = File.OpenText("test2.txt"))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine("".PadRight(Console.WindowWidth - 1, '*'));

            //ECRIRE DES DONNEES AUTRES QUE DU TEXTE
            using (TextWriter writer = File.CreateText("test3.txt"))
            {
                writer.WriteLine(12345);
                writer.WriteLine(DateTime.Now);
                writer.WriteLine(true);
            }

            using (TextReader reader = File.OpenText("test3.txt"))
            {
                int a;
                int.TryParse(reader.ReadLine(), out a);
                DateTime date;
                DateTime.TryParse(reader.ReadLine(), out date);
                bool b;
                bool.TryParse(reader.ReadLine(), out b);
                Console.WriteLine(a);
                Console.WriteLine(date);
                Console.WriteLine(b);
            }
        }
    }
}
