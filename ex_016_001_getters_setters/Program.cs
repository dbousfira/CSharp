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

namespace ex_016_001_getters_setters
{
    class Nounours
    {
        //un getter permet de lire un champ privé
        public string GetNom()
        {
            return mNom;
        }

        //un setter permet de modifier un champ privé
        public void SetNom(string value)
        {
            mNom = value;
        }
        private string mNom;

        //on peut ainsi, protéger nos champs privés de différentes manières
        public int GetTaille()
        {
            return mTaille;
        }
        public void SetTaille(int value)
        {
            if (value > 0)
            {
                mTaille = value;
            }
        }
        private int mTaille;

        public int GetPoils()
        {
            return mPoils;
        }
        private void SetPoils(int value)
        {
            if (value >= 0)
            {
                mPoils = value;
            }
        }
        private int mPoils;

        //on peut aussi avoir un getter uniquement et transformer ainsi le champ en lecture seule
        //ou un setter privé comme pour mPoils
        public DateTime GetDateDeNaissance()
        {
            return mDateDeNaissance;
        }
        private DateTime mDateDeNaissance;

        //ou en écriture seule...

        //un getter n'est pas forcément lié à un membre, mais peut simuler la lecture d'un membre qui est alors calculé à la volée
        public float GetPoilsParCm()
        {
            return (float)mPoils / (float)mTaille;
        }

        //on utilise les setters pour initialiser les membres
        public Nounours(string nom, int taille, DateTime naissance, int poils)
        {
            SetNom(nom);
            SetTaille(taille);
            mDateDeNaissance = naissance;
            SetPoils(poils);
        }

        //getter et setter statiques
        public static string GetDéfinition()
        {
            return mDéfinition;
        }
        public static void SetDéfinition(string value)
        {
            mDéfinition = value;
        }
        private static string mDéfinition = "Mot enfantin pour désigner un ours en peluche";
    }

    class Program
    {
        static void Main(string[] args)
        {
            //utilisation des getters et setters
            Nounours nounours = new Nounours("ours", 42, DateTime.Today, 30000);
            Console.WriteLine("Nounours nounours = new Nounours(\"ours\", 42, DateTime.Today, 30000);");
            Console.WriteLine("Nom : {0}", nounours.GetNom());
            Console.WriteLine("Poils : {0}", nounours.GetPoils());
            Console.WriteLine("Taille : {0}", nounours.GetTaille());
            Console.WriteLine("Date de naissance : {0}", nounours.GetDateDeNaissance());
            Console.WriteLine("Poils par cm : {0}", nounours.GetPoilsParCm());
            Console.WriteLine("nounours.SetTaille(41);");
            nounours.SetTaille(41);
            Console.WriteLine("Taille : {0}", nounours.GetTaille());
            Console.WriteLine("Poils par cm : {0}", nounours.GetPoilsParCm());
            Console.WriteLine("Définition : {0}", Nounours.GetDéfinition());
        }
    }
}
