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

namespace ex_017_002_redefinitionDeMethodes
{
    //classe mère
    //notez que les champs ne sont plus private mais protected (toujours invisibles de l'extérieur, mais visibles dans les classes filles)
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
        public new void Affiche()
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

        public new void Affiche()
        {
            Console.WriteLine("Le livre {0} a été écrit par {1} en {2}", mTitre, mAuteur, mAnnéeCréation);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ici pas de pb : 

            //l est de type Livre (construit avec Livre) et appelle Affiche de Livre
            Livre l = new Livre("Attenti al Gorilla", 1995, "Sandrone Dazieri");
            l.Affiche();

            //d est de type Disque (construit avec Disque) et appelle Affiche de Disque
            Disque d = new Disque("Underground", 2007, "Chris Potter");
            d.Affiche();

            //mo est de type MediaObjet (construit avec MediaObjet) et appelle Affiche de MediaObjet
            MediaObjet mo = new MediaObjet("La Grande Vadrouille", 1966);
            mo.Affiche();

            //modifions un peu à présent :

            //mo1 est de type MediaObjet et construit avec le constructeur de MediaObjet, il appelle Affiche de MediaObjet
            MediaObjet mo1 = new MediaObjet("La Grande Vadrouille", 1966);
            mo1.Affiche();
            //mo2 est de type MediaObjet mais construit avec le constructeur de Libre, il appelle Affiche de MediaObjet
            MediaObjet mo2 = new Livre("Attenti al Gorilla", 1995, "Sandrone Dazieri");
            mo2.Affiche();
            //mo2 est de type MediaObjet mais construit avec le constructeur de Disque, il appelle Affiche de MediaObjet
            MediaObjet mo3 = new Disque("Underground", 2007, "Chris Potter");
            mo3.Affiche();
            //c'est donc le type qui compte pour savoir quelle méthode appeler, quel que soit le constructeur.
            //attention, on ne peut pas appeler n'importe quel constructeur !
            //1 Livre est un MediaObjet donc on peut construire un Livre et l'utiliser comme un MediaObjet
            //mais un MediaObjet n'est pas obligatoirement un Livre, on ne peut donc pas construire un Livre avec le constructeur d'un MediaObjet

            //on peut toutefois reconnaître le "vrai" type (celui "du" au constructeur) à l'aide des fonctions virtuelles.
            // cf. exemple polymorphisme.
        }
    }
}
