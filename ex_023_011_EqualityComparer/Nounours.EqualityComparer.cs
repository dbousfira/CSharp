// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Nounours.EqualityComparer.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-03-30
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_023_011_EqualityComparer
{
    partial class Nounours
    {
        private class DateDeNaissanceEqualityComparer : EqualityComparer<Nounours>
        {
            public override bool Equals(Nounours x, Nounours y)
            {
                return x.DateDeNaissance == y.DateDeNaissance;
            }

            public override int GetHashCode(Nounours obj)
            {
                return (int)(obj.DateDeNaissance.Ticks % Int32.MaxValue);
            }
        }

        public static IEqualityComparer<Nounours> DateDeNaissanceEqualityCompare
        {
            get
            {
                if (mDateDeNaissanceEqualityCompare == null)
                {
                    mDateDeNaissanceEqualityCompare = new DateDeNaissanceEqualityComparer();
                }
                return mDateDeNaissanceEqualityCompare;
            }
        }
        private static DateDeNaissanceEqualityComparer mDateDeNaissanceEqualityCompare = null;
    }
}
