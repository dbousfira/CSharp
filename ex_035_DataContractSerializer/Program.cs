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
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ex_035_DataContractSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirInfo = Directory.GetParent(Directory.GetCurrentDirectory());
            string dirData = string.Format("{0}\\ex_035_DataContractSerializer\\XML\\", dirInfo.FullName);
            string xmlFile = string.Format("{0}{1}", dirData, "nounours.xml");

            Nounours chewie = new Nounours()
            {
                Nom = "Chewbacca",
                DateDeNaissance = new DateTime(1977, 5, 27),
                NbPoils = 1234567
            };

            Nounours yoda = new Nounours()
            {
                Nom = "Yoda",
                DateDeNaissance = new DateTime(1980, 5, 21),
                NbPoils = 3
            };

            Nounours ewok = new Nounours()
            {
                Nom = "Ewok",
                DateDeNaissance = new DateTime(1983, 5, 25),
                NbPoils = 3456789
            };

            chewie.Amis.Add(yoda);
            chewie.Amis.Add(ewok);

            Console.WriteLine(chewie);

            //1. Sérialisation d'un chewie en xml avec la méthode par défaut
            var serializer = new DataContractSerializer(typeof(Nounours));

            using (Stream s = File.Create(xmlFile))
            {
                serializer.WriteObject(s, chewie);
            }

            Nounours nounours2;
            using (Stream s = File.OpenRead(xmlFile))
            {
                nounours2 = serializer.ReadObject(s) as Nounours;
            }

            Console.WriteLine(nounours2);

            //2. spécifier le XmlWriter pour que cela soit plus lisible (indentation)
            string xmlFile2 = string.Format("{0}{1}", dirData, "nounours2.xml");

            XmlWriterSettings settings = new XmlWriterSettings() {Indent = true};
            using (XmlWriter writer = XmlWriter.Create(xmlFile2, settings))
            {
                serializer.WriteObject(writer, chewie);
            }

        }
    }
}
