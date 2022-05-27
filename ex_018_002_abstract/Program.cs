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

namespace ex_018_002_abstract
{
    //classe mère abstraite
    //notez le mot clé abstract
     class MediaObjet
    {
        public string Titre
        {
            get { return mTitre; }
        }
        protected string mTitre;
        protected int mAnnéeCréation;

        public MediaObjet(string titre, int année)
        {
            mTitre = titre;
            mAnnéeCréation = année;
        }

        //notez que Affiche est maintenant abstraite : les classes filles, si elles veulent être concrètes, doivent l'implémenter
        public abstract void Affiche();

    }

    //une classe fille
    class Disque : MediaObjet
    {
        private string mArtiste;

        public Disque(string titre, int année, string artiste)
            : base(titre, année)
        {
            mArtiste = artiste;
        }

        //on précise qu'il s'agit bien de la méthode abstraite de la classe mère abstraite avec le mot clé override
        public override void Affiche()
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

        //on précise qu'il s'agit bien de la méthode abstraite de la classe mère abstraite avec le mot clé override
        public override void Affiche()
        {
            Console.WriteLine("Le livre {0} a été écrit par {1} en {2}", mTitre, mAuteur, mAnnéeCréation);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //l est de type Livre (construit avec Livre) et appelle Affiche de Livre
            Livre l = new Livre("Attenti al Gorilla", 1995, "Sandrone Dazieri");
            l.Affiche();

            //d est de type Disque (construit avec Disque) et appelle Affiche de Disque
            Disque d = new Disque("Underground", 2007, "Chris Potter");
            d.Affiche();

            //on ne peut pas appeler le constructeur de MediaObjet car la classe est abstraite
            //MediaObjet mo = new MediaObjet("La Grande Vadrouille", 1966);
            //mo.Affiche();

            //modifions un peu à présent :

            //on ne peut toujours pas appeler le constructeur de MediaObjet (classe abstraite)
            //MediaObjet mo1 = new MediaObjet("La Grande Vadrouille", 1966);
            //mo1.Affiche();
            //mo2 est de type MediaObjet mais construit avec le constructeur de Livre, il appelle Affiche de Livre
            //même si mo2 est de type MediaObjet(classe abstraite), comme il a été construit avec une classe concrète (Livre), il n'y a pas d'erreurs
            MediaObjet mo2 = new Livre("Attenti al Gorilla", 1995, "Sandrone Dazieri");
            mo2.Affiche();
            //mo2 est de type MediaObjet mais construit avec le constructeur de Disque, il appelle Affiche de Disque
            MediaObjet mo3 = new Disque("Underground", 2007, "Chris Potter");
            mo3.Affiche();
            //avec les méthodes virtuelles, lors de l'exécution, le véritable type est testé.




            //on peut aussi toujours le mot clé "is" pour tester le type d'un objet
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
                Console.WriteLine(mo2.Titre + " n'est pas un libre");

            Livre l3 = mo3 as Livre;
            if (l3 != null)
                l3.Affiche();
            else
                Console.WriteLine(mo3.Titre + " n'est pas un livre");
        }
    }
}
