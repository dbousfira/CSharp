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

namespace ex_022_002_Generics_EtPourquoiPasObject
{
    /// <summary>
    /// première solution (mauvaise) : faire un tableau d'Object
    /// </summary>
    class Program
    {
        /// <summary>
        /// un tableau d'objet (donc n'importe quoi)
        /// </summary>
        public class ObjectArray
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
            object[] mData = new object[0];

            /// <summary>
            /// ajoute un objet à la fin du tableau
            /// </summary>
            /// <param name="objet">objet à rajouter</param>
            public void Push(object objet)
            {
                mSize++;
                object[] data = new object[mSize];
                mData.CopyTo(data, 0);
                data[mSize - 1] = objet;
                mData = data;
            }

            /// <summary>
            /// indexer en lecture seule pour lire les éléments du tableau
            /// </summary>
            /// <param name="index">index dans le tableau</param>
            /// <returns>la valeur à cet index</returns>
            public object this[int index]
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


        static void Main(string[] args)
        {
            ObjectArray tab_int = new ObjectArray();
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

            ObjectArray tab_nounours = new ObjectArray();
            tab_nounours.Push(new Nounours("Hello Kitty"));
            tab_nounours.Push(new Nounours("Pokemon"));
            tab_nounours.Push(new Nounours("Pokoyo"));
            tab_nounours.Push(new Nounours("Tigrou"));
            tab_nounours.Push(new Nounours("PussInBoots"));
            Console.WriteLine("début de tab_nounours");
            for (int i = 0; i < tab_int.Size; i++)
            {
                Console.WriteLine((tab_nounours[i] as Nounours).Nom); // il faut caster !
            }
            Console.WriteLine("fin\n");
        }
    }
}
