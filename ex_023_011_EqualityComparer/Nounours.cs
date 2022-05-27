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

namespace ex_023_011_EqualityComparer
{
    partial class Nounours : IEquatable<Nounours>
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
            private set;
        }

        public Nounours(int id, string name, DateTime dateDeNaissance, int nbPoils)
        {
            Id = id;
            Name = name;
            DateDeNaissance = dateDeNaissance;
            NbPoils = nbPoils;
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
            //check null
            if (object.ReferenceEquals(right, null))
            {
                return false;
            }

            if (object.ReferenceEquals(this, right))
            {
                return true;
            }

            if (this.GetType() != right.GetType())
            {
                return false;
            }

            return this.Equals(right as Nounours);
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
    }
}
