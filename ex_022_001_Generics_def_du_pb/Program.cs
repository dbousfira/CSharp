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

namespace ex_022_001_Generics_def_du_pb
{
    /// <summary>
    /// Définition du problème :
    /// - on construit un tableau d'entiers à taille variable
    /// - on construit ensuite le même tableau, mais de nounours
    /// - à chaque fois, on refait une classe, seulement pour contenir d'autres types...
    /// c'est pénible...
    /// </summary>
    class Program
    {
        /// <summary>
        /// 1er exemple : un tableau d'entiers
        /// </summary>
        public class IntArray
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
            /// tableau d'entiers
            /// </summary>
            int[] mData = new int[0];

            /// <summary>
            /// ajoute un entier à la fin du tableau
            /// </summary>
            /// <param name="entier">entier à rajouter</param>
            public void Push(int entier)
            {
                mSize++;
                int[] data = new int[mSize];
                mData.CopyTo(data, 0);
                data[mSize - 1] = entier;
                mData = data;
            }

            /// <summary>
            /// indexer en lecture seule pour lire les éléments du tableau
            /// </summary>
            /// <param name="index">index dans le tableau</param>
            /// <returns>la valeur à cet index</returns>
            public int this[int index]
            {
                get
                {
                    if (index < 0 || index >= mSize)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    return mData[index];
                }
            }
        }



        static void Main(string[] args)
        {
            IntArray tab_int = new IntArray();
            tab_int.Push(10);
            tab_int.Push(20);
            tab_int.Push(30);
            tab_int.Push(40);
            tab_int.Push(50);
            Console.WriteLine("début de tab_int");
            for (int i = 0; i < tab_int.Size; i++)
            {
                Console.WriteLine(tab_int[i]);
            }
            Console.WriteLine("fin\n");

            NounoursArray tab_nounours = new NounoursArray();
            tab_nounours.Push(new Nounours("Hello Kitty"));
            tab_nounours.Push(new Nounours("Pokemon"));
            tab_nounours.Push(new Nounours("Pokoyo"));
            tab_nounours.Push(new Nounours("Tigrou"));
            tab_nounours.Push(new Nounours("PussInBoots"));
            Console.WriteLine("début de tab_nounours");
            for (int i = 0; i < tab_int.Size; i++)
            {
                Console.WriteLine(tab_nounours[i].Nom);
            }
            Console.WriteLine("fin\n");
        }

        /// <summary>
        /// class Nounours
        /// </summary>
        public class Nounours
        {
            /// <summary>
            /// constructeur
            /// </summary>
            /// <param name="nom">nom du nounours</param>
            public Nounours(string nom)
            {
                Nom = nom;
            }

            /// <summary>
            /// nom du nounours
            /// </summary>
            public string Nom
            {
                get;
                private set;
            }
        }

        /// <summary>
        /// un tableau de nounours
        /// </summary>
        public class NounoursArray
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
            /// tableau de nounours
            /// </summary>
            Nounours[] mData = new Nounours[0];

            /// <summary>
            /// ajoute un nounours à la fin du tableau
            /// </summary>
            /// <param name="nounours">nounours à rajouter</param>
            public void Push(Nounours nounours)
            {
                mSize++;
                Nounours[] data = new Nounours[mSize];
                mData.CopyTo(data, 0);
                data[mSize - 1] = nounours;
                mData = data;
            }

            /// <summary>
            /// indexer en lecture seule pour lire les éléments du tableau
            /// </summary>
            /// <param name="index">index dans le tableau</param>
            /// <returns>la valeur à cet index</returns>
            public Nounours this[int index]
            {
                get
                {
                    if (index < 0 || index >= mSize)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    return mData[index];
                }
            }
        }
    }
}
