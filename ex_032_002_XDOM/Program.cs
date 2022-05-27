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
using System.Xml.Linq;

namespace ex_032_002_XDOM
{
    class Program
    {
        static void Main(string[] args)
        {
            LireVolcansInXMLFile();
            Console.WriteLine("VOLCANS LUS :");
            foreach (var volcan in listeVolcans)
            {
                Console.WriteLine(volcan);
            }
            Console.WriteLine("".PadRight(Console.WindowWidth - 1, '*'));

            var pariou = new Volcan() { Nom = "Puy de Pariou",
                                            Altitude = 1209,
                                            Latitude = 45.795462f,
                                            Longitude = 2.970257f,
                                            Pays = "France",
                                      };
            pariou.AjouterRoches("Trachy-basalte", "trachy-andésite", "trachyte");
            listeVolcans.Add(pariou);

            Console.WriteLine("VOLCANS APRES AJOUT :");
            foreach (var volcan in listeVolcans)
            {
                Console.WriteLine(volcan);
            }
            Console.WriteLine("".PadRight(Console.WindowWidth - 1, '*'));

            EcrireVolcansInXMLFile();
        }

        static List<Volcan> listeVolcans = new List<Volcan>();

        static void LireVolcansInXMLFile()
        {
            DirectoryInfo dirInfo = Directory.GetParent((Directory.GetCurrentDirectory()));
            string dirData = dirInfo.FullName + "\\ex_032_002_XDOM\\XML\\";

            XDocument volcansFichier = XDocument.Load(dirData + "volcans.xml");

            listeVolcans = volcansFichier.Descendants("volcan")
                          .Select(eltVolcan => new Volcan()
                          {
                              Pays = eltVolcan.Attribute("pays").Value,
                              Nom = eltVolcan.Element("nom").Value,
                              Altitude = XmlConvert.ToSingle(eltVolcan.Element("altitude").Value),
                              Latitude = XmlConvert.ToSingle(eltVolcan.Element("coordonnées").Element("latitude").Value),
                              Longitude = XmlConvert.ToSingle(eltVolcan.Element("coordonnées").Element("longitude").Value)
                          }).ToList();

            foreach (var volcan in listeVolcans)
            {
                var rochesElt = volcansFichier.Descendants("volcan")
                                             .Single(elt => elt.Element("nom").Value == volcan.Nom)
                                             .Element("roches");
                if (rochesElt == null)
                {
                    continue;
                }
                volcan.AjouterRoches(rochesElt.Value.Split());
            }
        }

        private static void EcrireVolcansInXMLFile()
        {
            DirectoryInfo dirInfo = Directory.GetParent((Directory.GetCurrentDirectory()));
            string dirData = dirInfo.FullName + "\\ex_032_002_XDOM\\XML\\";

            XDocument volcansFichier = new XDocument();// XDocument.Load(dirData + "volcansAjout.xml");

            var volcansElts = listeVolcans.Select(volcan => new XElement("volcan",
                                            new XAttribute("pays", volcan.Pays),
                                            new XElement("nom", volcan.Nom),
                                            new XElement("altitude", XmlConvert.ToString(volcan.Altitude)),
                                            new XElement("coordonnées",
                                                new XElement("latitude", XmlConvert.ToString(volcan.Latitude)),
                                                new XElement("longitude", XmlConvert.ToString(volcan.Longitude))),
                                            new XElement("roches", volcan.Roches.Count() > 0 ? volcan.Roches.Aggregate((stringRoche, nextRoche) => string.Format("{0} {1}", stringRoche, nextRoche)) : "")));

            volcansFichier.Add(new XElement("volcans", volcansElts));

            volcansFichier.Save(dirData + "volcansAjout.xml");
        
        }
        
    }
}
