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

namespace ex_016_003_indexers
{
    class Nounours
    {
        //une propriété
        public string Nom
        {
            get
            {
                return mNom;
            }
            set
            {
                mNom = value;
            }
        }
        private string mNom;
    }

    //classe possédant des indexeurs
    class MonLit
    {
        Nounours[] mNounours;

        //constructeur
        public MonLit(int nombre)
        {
            mNounours = new Nounours[nombre];
        }

        //une propriété de plus
        public int NombreNounours
        {
            get
            {
                return mNounours.Length;
            }
        }

        //indexer
        public Nounours this[int index]
        {
            get
            {
                if (index >= NombreNounours || index < 0)
                {
                    return null;
                }
                return mNounours[index];
            }
            set
            {
                if (index < NombreNounours && index >= 0)
                {
                    mNounours[index] = value;
                }
            }
        }

        //un autre indexeur
        public Nounours this[string nom]
        {
            get
            {
                foreach (Nounours n in mNounours)
                {
                    if (n.Nom == nom)
                    {
                        return n;
                    }
                }
                return null;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Création d'un lit avec trois nounours");
            MonLit monlit = new MonLit(3);
            monlit[0] = new Nounours { Nom = "zinzin" };
            monlit[1] = new Nounours { Nom = "rooooo" };
            monlit[2] = new Nounours { Nom = "argh" };

            Console.WriteLine("contenu du 1er lit");
            for (int i = 0; i < monlit.NombreNounours; i++)
            {
                Console.WriteLine(monlit[i].Nom);
            }

            Console.ReadLine();

            Console.WriteLine("modification d'un nounours du lit avec l'indexeur");
            if (monlit["rooooo"] != null)
            {
                monlit["rooooo"].Nom = "zibaouin";
            }

            Console.WriteLine("contenu du lit");
            for (int i = 0; i < monlit.NombreNounours; i++)
            {
                Console.WriteLine(monlit[i].Nom);
            }

            Console.ReadLine();
            Console.WriteLine("création d'une maison avec deux lits : 1er lit = le précédent, 2ème lit de 4 nouveaux nounours");
            MaMaison maison = new MaMaison(2);
            maison[0] = monlit;
            maison[1] = new MonLit(4);
            //notez que maison[1, 0] = new Nounours(); ne compile pas, car l'indexeur n'a pas de 'set'
            //mais on peut accéder quand même à maison[1][0] car on accède à la référence maison[1] de type MonLit et de là, grâce à l'indexeur,
            //au nounours maison[1][0]... donc ... ATTENTION AUX REFERENCES PUBLIQUES DANS VOTRE API !
            maison[1][0] = new Nounours();
            maison[1, 0].Nom = "Nigel";
            maison[1][1] = new Nounours();
            maison[1, 1].Nom = "David";
            maison[1][2] = new Nounours();
            maison[1, 2].Nom = "Derek";
            maison[1][3] = new Nounours();
            maison[1, 3].Nom = "Ian";
            Console.WriteLine("contenu du lit");
            for (int i = 0; i < maison.NbreLits; i++)
            {
                Console.WriteLine("lit n°" + (i + 1));
                for (int j = 0; j < maison[i].NombreNounours; j++)
                {
                    Console.WriteLine(maison[i, j].Nom);
                }
                Console.WriteLine();
            }
        }
    }

    //exemple d'indexeur à 2 variables
    class MaMaison
    {
        MonLit[] mLits;

        public MaMaison(int nombre)
        {
            mLits = new MonLit[nombre];
        }

        //une propriété en lecture seule
        public int NbreLits
        {
            get
            {
                return mLits.Length;
            }
        }

        //un indexeur simple
        public MonLit this[int lit]
        {
            get
            {
                if (lit >= NbreLits || lit < 0)
                {
                    return null;
                }
                return mLits[lit];
            }
            set
            {
                if (lit < NbreLits && lit >= 0)
                {
                    mLits[lit] = value;
                }
            }
        }

        //un indexeur à double entrée
        public Nounours this[int lit, int nounours]
        {
            get
            {
                if (lit >= NbreLits || lit < 0 || nounours >= mLits[lit].NombreNounours || nounours < 0)
                {
                    return null;
                }
                return mLits[lit][nounours];
            }
        }
    }
}
