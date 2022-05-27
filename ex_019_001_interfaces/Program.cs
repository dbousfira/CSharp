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

namespace ex_019_001_interfaces
{
    //interface
    //notez le mot clé interface
    interface IMediaObjet
    {
        //une interface ne possède pas de champs et ses méthodes et propriétés ne sont pas implémentées

        //les méthodes, propriétés, indexeurs et événements ne donnent pas l'accessibilité (public, private, internal, protected)
        //Cette accessibilité est implicitement publique.
        //En conséquence, les classes implémentant l'interface devront obligatoirement implémenter les méthodes, propriétés, indexeurs et événements
        //déclarés par l'interface comme publiques
        void Affiche();

        string Titre
        {
            get;
        }
    }

    interface IMusiqueObjet
    {
        string Producteur
        {
            get;
        }
    }



    //une classe fille
    class Livre : IMediaObjet
    {
        protected string mTitre;
        protected int mAnnéeCréation;
        private string mAuteur;

        public Livre(string titre, int année, string auteur)
        {
            mTitre = titre;
            mAnnéeCréation = année;
            mAuteur = auteur;
        }

        //pas besoin de préciser override
        public void Affiche()
        {
            Console.WriteLine("Le livre {0} a été écrit par {1} en {2}", mTitre, mAuteur, mAnnéeCréation);
        }

        public string Titre
        {
            get
            {
                return mTitre;
            }
        }
    }

    //on peut implémenter plusieurs interfaces
    class Disque : IMediaObjet, IMusiqueObjet
    {
        private string mArtiste;
        protected string mTitre;
        protected int mAnnéeCréation;
        private string mProducteur;

        public Disque(string titre, int année, string artiste, string producteur)
        {
            mTitre = titre;
            mAnnéeCréation = année;
            mArtiste = artiste;
            mProducteur = producteur;
        }

        //pas besoin de préciser override
        public void Affiche()
        {
            Console.WriteLine("Le disque {0} a été enregistré par {1} en {2}, et produit par {3}", mTitre, mArtiste, mAnnéeCréation, mProducteur);
        }

        public string Titre
        {
            get
            {
                return mTitre;
            }
            private set
            {
                mTitre = value;
            }
        }

        public string Producteur
        {
            get
            {
                return mProducteur;
            }
        }

    }

    //les structures aussi peuvent implémenter des interfaces
    struct Film : IMediaObjet
    {
        string mTitre;

        public Film(string titre)
        {
            mTitre = titre;
        }

        public string Titre
        {
            get
            {
                return mTitre;
            }
        }
        public void Affiche()
        {
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
            Disque d = new Disque("Tommy", 1969, "The Who", "Kit Lambert");
            d.Affiche();

            //on ne peut pas appeler le constructeur de IMediaObjet car c'est une interface
            //IMediaObjet mo = new IMediaObjet();
            //mo.Affiche();

            //mo2 implémente IMediaObjet et est construit avec le constructeur de Livre, il appelle Affiche de Livre
            //même si mo2 est de type IMediaObjet(interface), comme il a été construit avec une classe concrète (Livre), il n'y a pas d'erreurs
            IMediaObjet mo2 = new Livre("Attenti al Gorilla", 1995, "Sandrone Dazieri");
            mo2.Affiche();
            //mo3 implémente IMediaObjet et est construit avec le constructeur de Disque, il appelle Affiche de Disque
            //même si mo3 est de type IMediaObjet(interface), comme il a été construit avec une classe concrète (Disque), il n'y a pas d'erreurs
            IMediaObjet mo3 = new Disque("Tommy", 1969, "The Who", "Kit Lambert");
            mo3.Affiche();
            //avec les méthodes virtuelles, lors de l'exécution, le véritable type est testé.




            //on peut aussi vérifier avec is ou as qu'un objet implémente une interface
            if (l is IMusiqueObjet)
            {
                Console.WriteLine(l.Titre + " implémente l'interface IMusiqueObjet");
            }
            else
            {
                Console.WriteLine(l.Titre + " n'implémente pas l'interface");
            }
            if (d is IMusiqueObjet)
            {
                Console.WriteLine(d.Titre + " implémente l'interface IMusiqueObjet");
            }
            else
            {
                Console.WriteLine(d.Titre + " n'implémente pas l'interface");
            }

        }
    }
}
