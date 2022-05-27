// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Volcan.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-05-26
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_032_002_XDOM
{
    /// <summary>
    /// classe de stockage pour les données d'un volcan
    /// </summary>
    public class Volcan
    {
        /// <summary>
        /// nom du volcan
        /// </summary>
        public string Nom
        {
            get;
            set;
        }

        /// <summary>
        /// pays où se trouve ce volcan
        /// </summary>
        public string Pays
        {
            get;
            set;
        }

        /// <summary>
        /// altitude de ce volcan
        /// </summary>
        public float Altitude
        {
            get;
            set;
        }

        /// <summary>
        /// latitude de ce volcan
        /// </summary>
        public float Latitude
        {
            get;
            set;
        }

        /// <summary>
        /// longitude de ce volcan
        /// </summary>
        public float Longitude
        {
            get;
            set;
        }

        /// <summary>
        /// differentes roches de ce volcan
        /// </summary>
        public IEnumerable<string> Roches
        {
            get
            {
                return mRoches;
            }
        }
        /// <seealso cref="Roches"/>
        private List<string> mRoches = new List<string>();

        /// <summary>
        /// ajoute une roche à la collection de roches de ce volcan
        /// </summary>
        /// <param name="rock"></param>
        public void AjouterRoches(params string[] roches)
        {
            mRoches.AddRange(roches);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nom : {0}\n", Nom);
            sb.AppendFormat("Altitude : {0} mètres\n", Altitude);

            sb.AppendLine();
            sb.AppendFormat("Coordonnées : {0} ; {1}\n", Latitude, Longitude);

            if (mRoches.Count > 0)
            {
                sb.AppendLine("Roches :");
                mRoches.ForEach(rock => sb.AppendFormat("\t{0}\n", rock));
            }

            return sb.ToString();
        }
    }
}
