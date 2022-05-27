// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Nounours.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-03-30
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_023_012_OrderComparisonProtocole
{
    partial class Nounours : IComparable<Nounours>, IComparable
    {
        public int Id
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }

        public DateTime DateDeNaissance
        {
            get;
            private set;
        }

        public int NbPoils
        {
            get;
            private set;
        }

        public float Taille
        {
            get;
            private set;
        }

        public Nounours(int id, string name, DateTime dateDeNaissance, int nbPoils, float taille)
        {
            Id = id;
            Name = name;
            DateDeNaissance = dateDeNaissance;
            NbPoils = nbPoils;
            Taille = taille;
        }

        //...


        public int CompareTo(Nounours other)
        {
            return Taille.CompareTo(other.Taille);
        }

        int IComparable.CompareTo(object obj)
        {
            if (!(obj is Nounours))
            {
                throw new ArgumentException("Argument is not a Nounours", "obj");
            }
            Nounours otherNounours = obj as Nounours;
            return this.CompareTo(otherNounours);
        }

        public static bool operator <(Nounours left, Nounours right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator <=(Nounours left, Nounours right)
        {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >(Nounours left, Nounours right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator >=(Nounours left, Nounours right)
        {
            return left.CompareTo(right) >= 0;
        }
    }
}
