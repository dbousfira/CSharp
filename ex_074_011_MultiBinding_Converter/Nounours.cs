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
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_074_011_MultiBinding_Converter
{
    public class Nounours : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(String info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }

        public string Nom
        {
            get
            {
                return mNom;
            }
            set
            {
                mNom = value;
                OnPropertyChanged("Nom");
            }
        }
        private string mNom;

        public DateTime DateDeNaissance
        {
            get
            {
                return mDateDeNaissance;
            }
            set
            {
                mDateDeNaissance = value;
                OnPropertyChanged("DateDeNaissance");
            }
        }
        private DateTime mDateDeNaissance;

        public int NbPoils
        {
            get
            {
                return mNbPoils;
            }
            set
            {
                mNbPoils = value;
                OnPropertyChanged("NbPoils");
            }
        }
        private int mNbPoils;

        public Nounours(string nom, DateTime naissance, int nbPoils)
        {
            Nom = nom;
            DateDeNaissance = naissance;
            NbPoils = nbPoils;
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
            return new StringBuilder().AppendFormat("{0} ({1:dd/mm/yyyy}, {2} poils)", Nom, DateDeNaissance, NbPoils).ToString();
        }

    }
}
