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
using System.Xml;

namespace ex_034_003_XmlReader_XmlWriter
{
    class Program
    {
        // XmlReader et XmlWriter lisent et écrivent des fragments XML
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
            DirectoryInfo dirInfo = Directory.GetParent(Directory.GetCurrentDirectory());
            string dirData = string.Format("{0}\\ex_034_003_XmlReader_XmlWriter\\XML\\", dirInfo.FullName);
            string xmlFile = string.Format("{0}{1}", dirData, "nounours.xml");

            //settings pour que le fichier écrit soit indenté
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            //création du writer
            XmlWriter mWriter = XmlWriter.Create(xmlFile, settings);

            //écrit l'élément racine "nounours"
            mWriter.WriteStartElement("nounours");

            //écrit l'attribut @nom
            mWriter.WriteAttributeString("nom", nounours.Nom);

            //écrit le sous-élément naissance
            mWriter.WriteStartElement("naissance");
            mWriter.WriteValue(nounours.DateDeNaissance);
            mWriter.WriteEndElement();

            //écrit le sous-élément nb_poils
            mWriter.WriteStartElement("nb_poils");
            mWriter.WriteValue(nounours.NbPoils);
            mWriter.WriteEndElement();

            //ferme la balise nounours
            mWriter.WriteEndElement();

            //ferme le fichier xml
            mWriter.Close();
        }

        static Nounours ChargerNounours()
        {
            DirectoryInfo dirInfo = Directory.GetParent(Directory.GetCurrentDirectory());
            string dirData = string.Format("{0}\\ex_034_003_XmlReader_XmlWriter\\XML\\", dirInfo.FullName);
            string xmlFile = string.Format("{0}{1}", dirData, "nounours.xml");

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            settings.IgnoreProcessingInstructions = true;

            XmlReader reader = XmlReader.Create(xmlFile, settings);

            Nounours nounours = new Nounours();

            while (reader.NodeType != XmlNodeType.Element)
            {
                reader.Read();
            }
            nounours.Nom = reader.GetAttribute("nom");
            reader.ReadStartElement("nounours");
            nounours.DateDeNaissance = reader.ReadElementContentAsDateTime("naissance", "");
            nounours.NbPoils = reader.ReadElementContentAsInt("nb_poils", "");
            reader.ReadEndElement();

            return nounours;
        }
    }
}
