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

namespace ex_034_002_BinaryReader_BinaryWriter
{
    class Program
    {
        // BinaryReader et BinaryWriter lisent et écrivent des types natifs (bool, int, float, double, char, string...)
        static void Main(string[] args)
        {
            Nounours nounours = new Nounours()
            {
                Nom = "Chewbacca",
                DateDeNaissance = new DateTime(1977, 5, 27),
                NbPoils = 1234567
            };
            Console.WriteLine(nounours);

            SauvegarderNounours(nounours);
            Nounours nounours2 = ChargerNounours();
            Console.WriteLine(nounours2);
        }

        static void SauvegarderNounours(Nounours nounours)
        {
            using (FileStream fs = File.Create("nounours.txt"))
            {
                BinaryWriter writer = new BinaryWriter(fs);
                writer.Write(nounours.Nom);
                writer.Write(nounours.DateDeNaissance.ToString());
                writer.Write(nounours.NbPoils);
            }
        }

        static Nounours ChargerNounours()
        {
            Nounours nounours;
            using (FileStream fs = File.OpenRead("nounours.txt"))
            {
                BinaryReader reader = new BinaryReader(fs);
                nounours = new Nounours()
                {
                    Nom = reader.ReadString(),
                    DateDeNaissance = DateTime.Parse(reader.ReadString()),
                    NbPoils = reader.ReadInt32()
                };
            }
            return nounours;
        }
    }
}
