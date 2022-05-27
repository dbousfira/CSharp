// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : NounoursNbPoilsEqualityComparer.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-03-30
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_023_014_DictionaryCustomType
{
    class NounoursNbPoilsEqualityComparer : EqualityComparer<Nounours>
    {
        public override bool Equals(Nounours x, Nounours y)
        {
            return x.NbPoils == y.NbPoils;
        }

        public override int GetHashCode(Nounours obj)
        {
            return obj.NbPoils;
        }
    }
}
