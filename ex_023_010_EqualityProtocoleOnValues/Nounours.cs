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

namespace ex_023_010_EqualityProtocoleOnValues
{
    struct Nounours : IEquatable<Nounours>
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

        public Nounours(int id, string name)
        {
            mId = id;
            mName = name;
        }

        //...

        /// <summary>
        /// returns a hash code in order to use this class in hash table
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return Id%31;
        }

        /// <summary>
        /// checks if the "right" object is equal to this Nounours or not
        /// </summary>
        /// <param name="right">the other object to be compared with this Nounours</param>
        /// <returns>true if equals, false if not</returns>
        public override bool Equals(object right)
        {
            if (!(right is Nounours))
            {
                return false;
            }
            return Equals((Nounours)right);
        }

        /// <summary>
        /// checks if this Nounours is equal to the other Nounours
        /// </summary>
        /// <param name="other">the other Nounours to be compared with</param>
        /// <returns>true if equals</returns>
        public bool Equals(Nounours other)
        {
            return (this.Id == other.Id);
        }

        public static bool operator ==(Nounours nounours1, Nounours nounours2)
        {
            return nounours1.Equals(nounours2);
        }

        public static bool operator !=(Nounours nounours1, Nounours nounours2)
        {
            return !nounours1.Equals(nounours2);
        }


    }
}
