// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Nounours.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-03-30
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_023_016_IEnumerableOfInterfaces
{
    /// <summary>
    /// Nounours est un type muable
    /// </summary>
    class Nounours : INounours
    {
        public int Id
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }

        public DateTime DateDeNaissance
        {
            get;
            private set;
        }

        public int NbPoils
        {
            get;
            set;
        }

        public Nounours(int id, string name, DateTime dateDeNaissance, int nbPoils)
        {
            Id = id;
            Name = name;
            DateDeNaissance = dateDeNaissance;
            NbPoils = nbPoils;
        }
    }

    public interface INounours
    {
        int Id
        {
            get;
        }

        string Name
        {
            get;
        }

        DateTime DateDeNaissance
        {
            get;
        }

        int NbPoils
        {
            get;
        }
    }
}
