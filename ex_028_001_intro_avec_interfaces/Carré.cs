// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Carré.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-04-27
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_028_001_intro_avec_interfaces
{
    class Carré : IModifieur
    {
        public int Modifier(int nombreAModifier)
        {
            return nombreAModifier * nombreAModifier;
        }
    }
}
