// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Cube.cs
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
    class Cube : IModifieur
    {
        public int Modifier(int nombreAModifier)
        {
            return nombreAModifier * nombreAModifier * nombreAModifier;
        }
    }
}
