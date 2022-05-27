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

namespace ex_014_006_object_ToString
{
    //toutes les classes descendent de la classe Object. 
    //Object contient un constructeur, et les méthodes : Equals, GetType, et ToString
    //ici nous réécrivons ToString pour les classes Disque et Livre et Equals pour la classe Livre

    class Disque
    {
        private string mArtiste;
        string mTitre;
        int mAnnéeCréation;

        public Disque(string titre, int année, string artiste)
        {
            mTitre = titre;
            mAnnéeCréation = année;
            mArtiste = artiste;
        }

        //on réécrit ToString
        public override string ToString()
        {
            string s = string.Format("Le disque {0} a été enregistré par {1} en {2}", mTitre, mArtiste, mAnnéeCréation);
            return s;
        }
    }

    class Livre
    {
        protected string mTitre;
        int mAnnéeSortie;
        string mAuteur;

        public Livre(string titre, int année, string auteur)
        {
            mTitre = titre;
            mAnnéeSortie = année;
            mAuteur = auteur;
        }

        //on réécrit ToString
        public override string ToString()
        {
            string s = string.Format("Le livre {0} a été écrit par {1} en {2}", mTitre, mAuteur, mAnnéeSortie); 
            return s;
        }

        //on réécrit Equals, ici on décide par exemple que l'année n'a pas d'importance (une nouvelle édition par exemple)
        public override bool Equals(object obj)
        {
            if (mTitre == ((Livre)obj).mTitre && mAuteur == ((Livre)obj).mAuteur)
                return true;
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Livre l = new Livre("Attenti al Gorilla", 1995, "Sandrone Dazieri");
            Disque d = new Disque("Underground", 2007, "Chris Potter");

            Console.Write(l.GetType().Name + " : ");
            Console.WriteLine(l);

            Console.Write(d.GetType().Name + " : ");
            Console.WriteLine(d);

            Livre l2 = new Livre("Attenti al Gorilla", 1997, "Sandrone Dazieri");
            Livre l3 = new Livre("Attenti", 1995, "Sandrone Dazieri");
            if (l2.Equals(l))
                Console.WriteLine("l2 = l");
            if (l3.Equals(l))
                Console.WriteLine("l3 = l");
        }
    }
}
