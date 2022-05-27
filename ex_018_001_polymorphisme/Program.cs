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

namespace ex_018_001_polymorphisme
{
    //classe mère
    class MediaObjet
    {
        public string Titre
        {
            get { return mTitre; }
        }
        protected string mTitre = "unknown";
        protected int mAnnéeCréation;

        public MediaObjet(string titre, int année)
        {
            mTitre = titre;
            mAnnéeCréation = année;
        }

        //notez que Affiche est maintenant virtuelle
        public virtual void Affiche()
        {
            Console.WriteLine("Ce média s'intitule {0} et a été créé en {1}", mTitre, mAnnéeCréation);
        }
    }

    //une classe fille
    class Disque : MediaObjet
    {
        private string mArtiste = "unknown";

        public Disque(string titre, int année, string artiste)
            : base(titre, année)
        {
            mArtiste = artiste;
        }

        //on précise qu'il s'agit bien de la méthode virtuelle de la classe mère avec le mot clé override
        public override void Affiche()
        {
            Console.WriteLine("Le disque {0} a été enregistré par {1} en {2}", mTitre, mArtiste, mAnnéeCréation);
            //on peut aussi continuer à appeler la méthode Affiche de la classe mère à l'aide de base en décommentant la ligne suivante :
            //base.Affiche();
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

        //on précise qu'il s'agit bien de la méthode virtuelle de la classe mère avec le mot clé override
        public override void Affiche()
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
            //mo2 est de type MediaObjet mais construit avec le constructeur de Livre, il appelle Affiche de Livre
            MediaObjet mo2 = new Livre("Attenti al Gorilla", 1995, "Sandrone Dazieri");
            mo2.Affiche();
            //mo2 est de type MediaObjet mais construit avec le constructeur de Disque, il appelle Affiche de Disque
            MediaObjet mo3 = new Disque("Underground", 2007, "Chris Potter");
            mo3.Affiche();
            //avec les méthodes virtuelles, lors de l'exécution, le véritable type est testé.

            //on peut toutefois continuer à appeler la méthode (dite maintenant cachée) de la classe mère 0 l'aide de base
            //cf. commentaire dans la classe Disque



            //on peut aussi utiliser le mot clé "is" pour tester le type d'un objet
            if (mo1 is Livre)
            {
                Console.WriteLine(mo1.Titre + " est un livre");
            }
            else
            {
                Console.WriteLine(mo1.Titre + " n'est pas un livre");
            }
            if (mo2 is Livre)
            {
                Console.WriteLine(mo2.Titre + " est un livre");
            }
            else
            {
                Console.WriteLine(mo2.Titre + " n'est pas un livre");
            }
            if (mo3 is Livre)
            {
                Console.WriteLine(mo3.Titre + " est un livre");
            }
            else
            {
                Console.WriteLine(mo3.Titre + " n'est pas un livre");
            }



            //ou encore le mot clé as
            Livre l2 = mo2 as Livre;
            if (l2 != null)
                l2.Affiche();
            else
                Console.WriteLine(mo2.Titre + " n'est pas un livre");

            Livre l3 = mo3 as Livre;
            if (l3 != null)
                l3.Affiche();
            else
                Console.WriteLine(mo3.Titre + " n'est pas un livre");
        }
    }
}
