// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Lit.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-05-26
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_074_014_Binding_to_LINQ_results
{
    public class Lit : System.Collections.ObjectModel.ObservableCollection<Nounours>
    {
        //constructeur
        public Lit()
            : base()
        {
            Add(new Nounours("Babar", new DateTime(1931, 1, 1), 34));
            Add(new Nounours("Chucky", new DateTime(1988, 11, 9), 66));
            Add(new Nounours("Gizmo", new DateTime(1984, 6, 8), 1000000));
        }
    }
}
