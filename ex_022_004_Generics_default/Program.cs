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

namespace ex_022_004_Generics_default
{
    /// <summary>
    /// exemple montrant l'utilisation du mot clé default (cf. indexer)
    /// </summary>
    class Program
    {
        /// <summary>
        /// 1er exemple : un tableau de "choses" (inconnues à l'avance)
        /// </summary>
        /// <typeparam name="T">choses contenues par le tableau</typeparam>
        public class Tableau<T>
        {
            /// <summary>
            /// taille du tableau
            /// </summary>
            public int Size
            {
                get { return mSize; }
            }
            int mSize = 0;

            /// <summary>
            /// tableau d'object
            /// </summary>
            T[] mData = new T[0];

            /// <summary>
            /// ajoute un objet à la fin du tableau
            /// </summary>
            /// <param name="objet">objet à rajouter</param>
            public void Push(T objet)
            {
                mSize++;
                T[] data = new T[mSize];
                mData.CopyTo(data, 0);
                data[mSize - 1] = objet;
                mData = data;
            }

            /// <summary>
            /// indexer en lecture seule pour lire les éléments du tableau
            /// </summary>
            /// <param name="index">index dans le tableau</param>
            /// <returns>la valeur à cet index</returns>
            public T this[int index]
            {
                get
                {
                    if (index < 0 || index >= mSize)
                    {
                        return default(T);  // <<<<-----------------   utilisation du mot clé default : rend la valeur par défaut du type
                        //                          e.g. 0 pour int, null pour Nounours (reference)
                    }
                    return mData[index];
                }
            }
        }

        public class Nounours
        {
            public Nounours(string nom)
            {
                Nom = nom;
            }

            public string Nom
            {
                get;
                private set;
            }
        }

        static void Main(string[] args)
        {
            Tableau<int> tab_int = new Tableau<int>();
            tab_int.Push(10);
            tab_int.Push(20);
            tab_int.Push(30);
            tab_int.Push(40);
            tab_int.Push(50);
            for (int i = 0; i < tab_int.Size + 1; i++)
            {
                Console.WriteLine(tab_int[i]);
            }
            Console.WriteLine("fin\n");

            Tableau<Nounours> tab_nounours = new Tableau<Nounours>();
            tab_nounours.Push(new Nounours("Hello Kitty"));
            tab_nounours.Push(new Nounours("Pokemon"));
            tab_nounours.Push(new Nounours("Pokoyo"));
            tab_nounours.Push(new Nounours("Tigrou"));
            tab_nounours.Push(new Nounours("PussInBoots"));
            for (int i = 0; i < tab_nounours.Size + 1; i++)
            {
                if (tab_nounours[i] != null)
                    Console.WriteLine(tab_nounours[i].Nom);
            }
            Console.WriteLine("fin\n");
        }
    }
}
