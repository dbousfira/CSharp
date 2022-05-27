// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : MaClasse.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-03-30
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_016_005_partial
{
    partial class MaClasse
    {
        public int N1
        {
            get;
            set;
        }
        public int N2
        {
            get;
            set;
        }

        public override string ToString()
        {
            return N1.ToString() + " " + N2.ToString() + " " + N3.ToString();
        }

    }
}
