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

namespace ex_016_002_properties
{
    class Nounours
    {
        //une propriété ressemble à un champ de l'extérieur mais se comporte comme une méthode à l'intérieur
        //on l'utilise comme accesseur sur un champ privé pour garantir l'encapsulation
        //en lecture/écriture, lecture ou écriture
        //on l'associe donc généralement à un champ privé
        public string Nom
        {
            get //public string GetNom()
            {
                return mNom;
            }
            set //public void SetNom(string value)
            {
                mNom = value;
            }
        }
        private string mNom;

        //on peut en conséquence, protéger nos champs privés de différentes manières
        public int Taille
        {
            get
            {
                return mTaille;
            }
            set
            {
                if (value > 0)
                {
                    mTaille = value;
                }
            }
        }
        private int mTaille;

        //on peut aussi avoir une propriété en lecture seule
        public DateTime DateDeNaissance
        {
            get
            {
                return mDateDeNaissance;
            }
        }
        private DateTime mDateDeNaissance;

        //ou en écriture seule

        //automatic properties
        //on peut aussi définir une propriété sans membre privé si le getter et le setter sont basiques (aux modifiers près)
        //(ne marche pas sur les structures)
        public int Poils
        {
            get;
            private set;
        }

        //calculated properties
        //une propriété n'est pas forcément liée à un membre privé (ou protégé), elle est peut être calculée à partir d'autres membres ou propriétés
        public float PoilsParCm
        {
            get
            {
                return (float)Poils / (float)Taille;
            }
        }

        public Nounours(string nom, int taille, DateTime naissance, int poils)
        {
            Nom = nom;
            Taille = taille;
            mDateDeNaissance = naissance;
            Poils = poils;
        }

        //propriété statique
        public static string Définition
        {
            get
            {
                return mDéfinition;
            }
            set
            {
                mDéfinition = value;
            }
        }
        private static string mDéfinition = "Mot enfantin pour désigner un ours en peluche";
    }

    class Program
    {
        static void Main(string[] args)
        {
            //les propriétés s'utilisent comme des membres
            Nounours nounours = new Nounours("ours", 42, DateTime.Today, 30000);
            Console.WriteLine("Nounours nounours = new Nounours(\"ours\", 42, DateTime.Today, 30000);");
            Console.WriteLine("Nom : {0}", nounours.Nom);
            Console.WriteLine("Poils : {0}", nounours.Poils);
            Console.WriteLine("Taille {0}: ", nounours.Taille);
            Console.WriteLine("Date de naissance : {0}", nounours.DateDeNaissance);
            Console.WriteLine("Poils par cm : {0}", nounours.PoilsParCm);
            Console.WriteLine("nounours.Taille = 41;");
            nounours.Taille = 41;
            Console.WriteLine("Taille : {0}", nounours.Taille);
            Console.WriteLine("Poils par cm : {0}", nounours.PoilsParCm);
            Console.WriteLine("Définition : {0}", Nounours.Définition);
        }
    }
}
