// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Nounours.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-05-26
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ex_035_DataContractSerializer
{
    [DataContract]
    public class Nounours
    {
        [DataMember]
        public string Nom
        {
            get;
            set;
        }

        [DataMember (Name="naissance")]
        public DateTime DateDeNaissance
        {
            get;
            set;
        }

        [DataMember]
        public int NbPoils
        {
            get;
            set;
        }

        [DataMember (EmitDefaultValue=false)]
        public List<Nounours> Amis
        {
            get;
            set;
        }

        public Nounours()
        {
            Amis = new List<Nounours>();
        }

        /// <summary>
        /// returns a hash code in order to use this class in hash table
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            return Nom.GetHashCode();
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
            return (this.Nom.Equals(other.Nom) && this.DateDeNaissance == other.DateDeNaissance);
        }

        public override string ToString()
        {
            return new StringBuilder().AppendFormat("{0} ({1:dd/MM/yyyy}, {2} poils{3})", Nom, DateDeNaissance, NbPoils,
                Amis.Count > 0 ? ", amis : " + Amis.Select(nounours => nounours.Nom).Aggregate((noms, nom) => string.Format("{0} {1}", noms, nom)) : "" ).ToString();
        }

    }
}
