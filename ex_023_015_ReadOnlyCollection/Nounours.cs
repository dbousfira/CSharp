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

namespace ex_023_015_ReadOnlyCollection
{
    /// <summary>
    /// Nounours est immuable
    /// </summary>
    struct Nounours
    {
        public int Id
        {
            get
            {
                return mId;
            }
            private set
            {
                mId = value;
            }
        }
        private int mId;

        public string Name
        {
            get
            {
                return mName;
            }
            private set
            {
                mName = value;
            }
        }
        private string mName;

        public DateTime DateDeNaissance
        {
            get
            {
                return mDateDeNaissance;
            }
            private set
            {
                mDateDeNaissance = value;
            }
        }
        private DateTime mDateDeNaissance;

        public int NbPoils
        {
            get
            {
                return mNbPoils;
            }
            private set
            {
                mNbPoils = value;
            }
        }
        private int mNbPoils;

        public Nounours(int id, string name, DateTime dateDeNaissance, int nbPoils)
        {
            mId = id;
            mName = name;
            mDateDeNaissance = dateDeNaissance;
            mNbPoils = nbPoils;
        }
    }
}
