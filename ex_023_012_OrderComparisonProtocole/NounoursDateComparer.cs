// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : NounoursDateComparer.cs
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
    class NounoursDateComparer : IComparer<Nounours>
    {
        public int Compare(Nounours x, Nounours y)
        {
            return x.DateDeNaissance.CompareTo(y.DateDeNaissance);
        }
    }
}
