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

namespace ex_022_006_Generics_constraints2
{
    /// <summary>
    /// exemple d'utilisation de contraintes : T DOIT dériver de la classe Animal
    /// </summary>
    class Program
    {
        /// <summary>
        /// 1er exemple : un tableau de "choses" (inconnues à l'avance)
        /// </summary>
        /// <typeparam name="T">choses contenues par le tableau</typeparam>
        public class Tableau<T> where T : Animal
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
                        throw new IndexOutOfRangeException();
                    }
                    return mData[index];
                }
            }
        }

        public class Animal
        {
            public string Type
            {
                get;
                protected set;
            }
        }

        /// <summary>
        /// ne dérive pas d'Animal
        /// </summary>
        public class Caillou
        {
        }

        /// <summary>
        /// dérive d'Animal
        /// </summary>
        public class Oiseau : Animal
        {
            public Oiseau(string nom, string famille)
            {
                Type = "Tétrapode";
                Nom = nom;
                Famille = famille;
            }

            public string Nom
            {
                get;
                private set;
            }

            public string Famille
            {
                get;
                private set;
            }
        }

        static void Main(string[] args)
        {
            Tableau<Oiseau> tab_oiseaux = new Tableau<Oiseau>();
            tab_oiseaux.Push(new Oiseau("canard à bosse", "anatidés"));
            tab_oiseaux.Push(new Oiseau("faucon aplomado", "falconidés"));
            tab_oiseaux.Push(new Oiseau("effraie des clochers", "tytonidés"));
            for (int i = 0; i < tab_oiseaux.Size; i++)
            {
                Console.WriteLine(tab_oiseaux[i].Nom + " (famille:" + tab_oiseaux[i].Famille + " - type: " + tab_oiseaux[i].Type + ")");
            }
            Console.WriteLine("fin\n");

            //Tableau<Caillou> tab_caillou = new Tableau<Caillou>();
        }
    }
}
