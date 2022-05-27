// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Nounours.NbPoilsComparer.cs
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
        private class NbPoilsComparer : IComparer<Nounours>
        {
            int IComparer<Nounours>.Compare(Nounours left, Nounours right)
            {
                return left.NbPoils.CompareTo(right.NbPoils);
            }
        }

        public static IComparer<Nounours> NbPoilsCompare
        {
            get
            {
                if (nbPoilsCompare == null)
                {
                    nbPoilsCompare = new NbPoilsComparer();
                }
                return nbPoilsCompare;
            }
        }
        private static NbPoilsComparer nbPoilsCompare = null;
    }
}
