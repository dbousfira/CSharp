// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Droite.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-04-27
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace2
{
    /// <summary>
    /// classe représentant une droite
    /// </summary>
    public class Droite
    {
        /// <summary>
        /// valeur du point d'abscisse nul de la droite
        /// </summary>
        int mOffset;

        /// <summary>
        /// coefficient directeur de la droite
        /// </summary>
        int mPente;

        /// <summary>
        /// constructeur de la droite
        /// </summary>
        /// <param name="offset">valeur du point d'abscisse nul</param>
        /// <param name="pente">coefficient directeur de la droite</param>
        public Droite(int offset, int pente)
        {
            mOffset = offset;
            mPente = pente;
        }

        /// <summary>
        /// calcul l'ordonnée d'un point de la droite à partir de son abscisse
        /// Cette méthode est du type "Modifieur" car sa signature est la même que celle du délégué.
        /// </summary>
        /// <param name="a">abscisse du point</param>
        /// <returns>ordonnée du point sur la droite</returns>
        public int Image(int a)
        {
            return mOffset + mPente * a;
        }
    }
}

