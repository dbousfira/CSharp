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

namespace ex_020_001_structures
{
    /// <summary>
    /// présentation rapide des structures en C# : 
    /// - les variables structurées sont de type "valeur" (allouées en mémoire sur la pile, plus rapide que sur le tas, mais moins de place)
    /// - pas d'héritage possible
    /// - pas de constructeur par défaut et pas d'initialisation dans la définition des champs.
    /// - pas de propriété automatique
    /// </summary>
    struct StructDisque
    {
        public string Titre
        {
            get
            {
                return mTitre;
            }
            set
            {
                mTitre = value;
            }
        }
        private string mTitre;

        public int Année
        {
            get
            {
                return mAnnée;
            }
            set
            {
                mAnnée = value;
            }
        }
        private int mAnnée;

        public StructDisque(string titre, int année)
        {
            mTitre = titre;
            mAnnée = année;
        }
    }

    class ClassDisque
    {
        public string Titre
        {
            get
            {
                return mTitre;
            }
            set
            {
                mTitre = value;
            }
        }
        private string mTitre;

        public int Année
        {
            get
            {
                return mAnnée;
            }
            set
            {
                mAnnée = value;
            }
        }
        private int mAnnée;

        public ClassDisque(string titre, int année)
        {
            mTitre = titre;
            mAnnée = année;
        }
    }

    /// <summary>
    /// utilisation d'une structure
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Avec des structures :");
                StructDisque sd1 = new StructDisque("Voice In The Night", 1999);
                int year = sd1.Année;
                string title = sd1.Titre;
                Console.WriteLine("sd1 : " + sd1.Titre + " (" + sd1.Année + ")");
                Console.WriteLine();

                StructDisque sd2 = new StructDisque("The Water Is Wide", 2000);
                year = sd2.Année;
                title = sd2.Titre;
                Console.WriteLine("sd2 : " + sd2.Titre + " (" + sd2.Année + ")");
                Console.WriteLine();

                sd2 = sd1;
                Console.WriteLine("sd2 = sd1;");
                Console.WriteLine("sd1 : " + sd1.Titre + " (" + sd1.Année + ")");
                Console.WriteLine("sd2 : " + sd2.Titre + " (" + sd2.Année + ")");
                Console.WriteLine();

                Console.WriteLine("modification de sd1");
                sd1.Titre = "Hyperion With Higgins";
                sd1.Année = 2001;
                Console.WriteLine("sd1 : " + sd1.Titre + " (" + sd1.Année + ")");
                Console.WriteLine("sd2 : " + sd2.Titre + " (" + sd2.Année + ")");
                Console.WriteLine();
            }

            {
                Console.WriteLine("Avec des classes :");
                ClassDisque cd1 = new ClassDisque("Voice In The Night", 1999);
                int year = cd1.Année;
                string title = cd1.Titre;
                Console.WriteLine("cd1 : " + cd1.Titre + " (" + cd1.Année + ")");
                Console.WriteLine();

                ClassDisque cd2 = new ClassDisque("The Water Is Wide", 2000);
                year = cd2.Année;
                title = cd2.Titre;
                Console.WriteLine("cd2 : " + cd2.Titre + " (" + cd2.Année + ")");
                Console.WriteLine();

                cd2 = cd1;
                Console.WriteLine("cd2 = cd1;");
                Console.WriteLine("cd1 : " + cd1.Titre + " (" + cd1.Année + ")");
                Console.WriteLine("cd2 : " + cd2.Titre + " (" + cd2.Année + ")");
                Console.WriteLine();

                Console.WriteLine("modification de cd1");
                cd1.Titre = "Hyperion With Higgins";
                cd1.Année = 2001;
                cd1 = new ClassDisque("Hyperion With Higgins", 2001);
                Console.WriteLine("cd1 : " + cd1.Titre + " (" + cd1.Année + ")");
                Console.WriteLine("cd2 : " + cd2.Titre + " (" + cd2.Année + ")");
                Console.WriteLine();
            }
        }
    }
}
