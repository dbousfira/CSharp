// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Oiseau.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-05-26
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public class Oiseau
    {
        public Oiseau()
        {
            Name = "cuicui";
        }

        public string Name
        {
            get;
            protected set;
        }
    }
}
