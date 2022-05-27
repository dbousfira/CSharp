// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Broadcaster.cs
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
    /// classe possédant un type délégué Information et une instance de ce délégué Informer
    /// Elle diffuse des informations aux abonnés
    /// </summary>
    class Broadcaster
    {
        /// <summary>
        /// type délégué (ne rend rien et prend en paramètres deux chaînes de caractères
        /// </summary>
        public delegate void Information(string info, DateTime date);

        /// <summary>
        /// instance du délégué Information
        /// </summary>
        public event Information Informer;

        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// information à diffuser (si celle-ci a été modifiée)
        /// </summary>
        public string Info
        {
            get { return mInfo; }
            set
            {
                //si l'information n'est pas modifiée, on ne fait rien
                if (mInfo == value)
                {
                    return;
                }
                //sinon, on vérifie que l'instance de délégué n'est pas nulle (le pointeur pointe sur au moins une fonction)
                if (Informer != null)
                {
                    //si elle n'est pas nulle, on exécute toutes les méthodes pointées
                    Informer(value, DateTime.Now);
                }
                mInfo = value;
            }
        }
        string mInfo;

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="info">information de départ</param>
        public Broadcaster(string name)
        {
            Name = name;
        }

    }
}
