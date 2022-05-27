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

namespace ex_017_001_heritage_syntaxe
{
    //classe mère
    //notez que les champs private ne sont pas accessibles par les classes filles,
    //alors que les champs protected sont toujours invisibles de l'extérieur, mais visibles dans les classes filles
    class MediaObjet
    {
        protected string mTitre;
        protected int mAnnéeCréation;

        public MediaObjet(string titre, int année)
        {
            mTitre = titre;
            mAnnéeCréation = année;
        }

        public void Affiche()
        {
            Console.WriteLine("Ce média s'intitule {0} et a été créé en {1}", mTitre, mAnnéeCréation);
        }
    }

    //une classe fille
    class Disque : MediaObjet
    {
        private string mArtiste;

        //notez de quelle manière on appelle le constructeur de la classe mère avec base
        public Disque(string titre, int année, string artiste)
            : base(titre, année)
        {
            mArtiste = artiste;
        }

        //méthode redéfinie
        public void Affiche()
        {
            Console.WriteLine("Le disque {0} a été enregistré par {1} en {2}", mTitre, mArtiste, mAnnéeCréation);
        }
    }

    //une autre classe fille
    class Livre : MediaObjet
    {
        private string mAuteur;

        public Livre(string titre, int année, string auteur)
            : base(titre, année)
        {
            mAuteur = auteur;
        }

        public void Affiche()
        {
            Console.WriteLine("Le livre {0} a été écrit par {1} en {2}", mTitre, mAuteur, mAnnéeCréation);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Livre l = new Livre("Attenti al Gorilla", 1995, "Sandrone Dazieri");
            Disque d = new Disque("Underground", 2007, "Chris Potter");
            MediaObjet mo = new MediaObjet("La Grande Vadrouille", 1966);

            l.Affiche();
            d.Affiche();
            mo.Affiche();
        }
    }
}
