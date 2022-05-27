// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Droite.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-04-27
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_028_006_Strategy_et_interface
{
    class Droite : IModifieur
    {
        public int Offset
        {
            get;
            private set;
        }

        public int Pente
        {
            get;
            private set;
        }

        public Droite(int offset, int pente)
        {
            Offset = offset;
            Pente = pente;
        }

        public int Modifier(int nombreAModifier)
        {
            return Offset + Pente * nombreAModifier;
        }
    }
}
