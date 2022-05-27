// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : InfoChangedEventArgs.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-04-27
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadcaster_Subscriber
{
    /// <summary>
    /// classe propageant les arguments de l'événement
    /// Dans le pattern standard, cette classe dérive de System.EventArgs
    /// Par convention, son nom terminer en ...EventArgs.
    /// Par convention, son nom débute par le nom de l'événement InfoChanged...
    /// Elle ne contient que des propriétés en lecture seule ou des champs readonly public, et un constructeur pour les setter.
    /// </summary>
    public class InfoChangedEventArgs : System.EventArgs
    {
        /// <summary>
        /// nouvelle info
        /// </summary>
        public string NewInfo
        {
            get;
            private set;
        }

        /// <summary>
        /// date de parution de l'info
        /// </summary>
        public DateTime InfoDate
        {
            get;
            private set;
        }

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="new_info">nouvelle info</param>
        /// <param name="info_date">date de parution de l'info</param>
        public InfoChangedEventArgs(string new_info, DateTime info_date)
        {
            NewInfo = new_info;
            InfoDate = info_date;
        }
    }
}

