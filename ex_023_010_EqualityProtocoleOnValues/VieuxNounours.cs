// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : VieuxNounours.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-03-30
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_023_010_EqualityProtocoleOnValues
{
    struct VieuxNounours
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

        public VieuxNounours(int id, string name)
        {
            mId = id;
            mName = name;
        }

        //...
    }
}
