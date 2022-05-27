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
using System.Xml.Linq;

namespace ex_032_001_XDOM_base
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirInfo = Directory.GetParent((Directory.GetCurrentDirectory()));
            string dirData = dirInfo.FullName + "\\ex_032_001_XDOM_base\\XML\\";

            XDocument volcansFichier = XDocument.Load(dirData + "volcans.xml");
            Console.WriteLine(volcansFichier);

            volcansFichier.Save(dirData + "volcansSave.xml");

            XElement testVolcan = XElement.Parse(
                @"<volcan activité='endormi' pays='France' type='gris'>
                    <nom>Puy de Dôme</nom>
                    <endormi_depuis>P6000Y</endormi_depuis>
                    <altitude>1465</altitude>
                    <coordonnées>
                      <latitude>45.7723</latitude>
                      <longitude>2.9658</longitude>
                    </coordonnées>
                  </volcan>");
            Console.WriteLine(testVolcan);

            testVolcan.Save(dirData + "unVolcan.xml");
        }
    }
}
