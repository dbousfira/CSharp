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

namespace ex_016_004_readonly
{
    /// <summary>
    /// classe représentant un disque
    /// </summary>
    class Disque
    {
        /// <summary>
        /// artiste du disque (en readonly) (public pour la simplicité de l'exemple !)
        /// </summary>
        public readonly Artiste mArtiste;

        /// <summary>
        /// année de sortie (en readonly) (public pour la simplicité de l'exemple !)
        /// </summary>
        public readonly int mAnnée;

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="artiste"></param>
        /// <param name="année"></param>
        public Disque(Artiste artiste, int année)
        {
            mArtiste = artiste;
            mAnnée = année;
        }
    }

    /// <summary>
    /// classe représentant un artiste
    /// </summary>
    class Artiste
    {
        /// <summary>
        /// nom de l'artiste (public pour la simplicité de l'exemple !)
        /// </summary>
        public string mName;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Disque d = new Disque(new Artiste { mName = "Miles Davis" }, 1956);
            Console.WriteLine("artiste : " + d.mArtiste.mName + "; année : " + d.mAnnée);
            //d.mAnnée = 1951; // ne compile pas (pas d'assignation possible car readonly)
            //d.mArtiste = new Artiste { mName = "Charlie Parker" };// ne compile pas (pas d'assignation possible car readonly)
            d.mArtiste.mName = "Charlie Parker"; //compile par l'adresse mArtiste n'a pas changé (readonly), mais le contenu pointé par la référence
            // n'est pas en readonly et peut donc être modifié
            Console.WriteLine("artiste : " + d.mArtiste.mName + "; année : " + d.mAnnée);
        }
    }
}
