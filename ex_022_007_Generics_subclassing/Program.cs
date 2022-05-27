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

namespace ex_022_007_Generics_subclassing
{
    /// <summary>
    /// Généricité et dérivation
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
            protected int mSize = 0;

            /// <summary>
            /// tableau d'object
            /// </summary>
            protected T[] mData = new T[0];

            /// <summary>
            /// ajoute un objet à la fin du tableau
            /// </summary>
            /// <param name="objet">objet à rajouter</param>
            virtual public void Push(T objet)
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
            virtual public T this[int index]
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
        /// dérivation qui laisse le type générique ouvert
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class SuperTableau<T> : Tableau<T> where T : new()
        {
            public T Pop()
            {
                if (Size > 0)
                {
                    mSize--;
                    return mData[Size];

                }
                else
                {
                    return new T();
                }
            }
        }

        /// <summary>
        /// dérivation fermant le type générique avec un type concret
        /// </summary>
        public class TableauInt : Tableau<int>
        {
            public override int this[int index]
            {
                get
                {
                    if (index < 0 || index >= Size)
                    {
                        return 0;
                    }
                    return mData[index];
                }
            }
        }

        /// <summary>
        /// dérivation ouvrant un nouveau type générique
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        public class TableauDouble<T, U> : Tableau<T> where U : new()
        {
            U[] mData2 = new U[0];

            public override void Push(T objet)
            {
                Push(objet);
                U[] data = new U[Size];
                mData2.CopyTo(data, 0);
                data[Size - 1] = new U();
                mData2 = data;
            }

            public void Push(T obj1, U obj2)
            {
                base.Push(obj1);
                U[] data = new U[Size];
                mData2.CopyTo(data, 0);
                data[Size - 1] = obj2;
                mData2 = data;
            }

            public U GetU(int index)
            {
                if (index < 0 || index >= mSize)
                {
                    throw new IndexOutOfRangeException();
                }
                return mData2[index];
            }

        }

        static void Main(string[] args)
        {
            Tableau<int> tab_int = new Tableau<int>();
            tab_int.Push(1);
            tab_int.Push(2);
            tab_int.Push(3);
            for (int i = 0; i < tab_int.Size; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("fin");
            Console.WriteLine();

            SuperTableau<int> sup_tab = new SuperTableau<int>();
            sup_tab.Push(7);
            sup_tab.Push(8);
            sup_tab.Push(9);
            while (sup_tab.Size > 0)
            {
                Console.WriteLine(sup_tab.Pop());
            }
            Console.WriteLine("fin");
            Console.WriteLine();

            TableauInt tab_int2 = new TableauInt();
            tab_int2.Push(4);
            tab_int2.Push(5);
            tab_int2.Push(6);
            for (int i = 0; i < tab_int2.Size; i++)
            {
                Console.WriteLine(tab_int2[i]);
            }
            Console.WriteLine("fin");
            Console.WriteLine();

            TableauDouble<int, float> tab3 = new TableauDouble<int, float>();
            tab3.Push(11, 1.1f);
            tab3.Push(12, 1.2f);
            tab3.Push(13, 1.3f);
            for (int i = 0; i < tab3.Size; i++)
            {
                Console.WriteLine(tab3[i] + " " + tab3.GetU(i));
            }


        }
    }
}
