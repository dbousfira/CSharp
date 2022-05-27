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
    /// classe générant l'événement
    /// </summary>
    public class Broadcaster
    {
        /// <summary>
        /// type délégué de l'événement
        /// Cette déclaration peut également être faite en dehors de la classe Broadcaster
        /// </summary>
        /// <typeparam name="TEventArgs">type des arguments d'événement (C# 2 et plus)</typeparam>
        /// <param name="source">la source, c'est-à-dire l'objet qui générera l'événement</param>
        /// <param name="e">les arguments d'événement</param>
        /// <remarks>Si vous avez plusieurs événements avec différentes implémentations de EventArgs, une seule déclaration de type délégué suffit !
        /// Grâce à la généricité, elle vaut pour tous les événements de type EventHandler avec TEventArgs qui s'adpate.
        /// CETTE LIGNE EXISTE DEJA ET N'EST DONC PAS NECESSAIRE !!!!</remarks>
        //public delegate void EventHandler<TEventArgs>(object source, TEventArgs e) where TEventArgs : EventArgs;

        /// <summary>
        /// déclaration de l'événement :
        /// il est une instance du type délégué précédent, EventHandler, où TEventArgs vaut InfoChangedEventArgs.
        /// Le mot clé event garantit qu'il s'agit d'un événement.
        /// </summary>
        public event EventHandler<InfoChangedEventArgs> InfoChanged;

        /// <summary>
        /// Cette méthode est celle qu'on appelle lorsqu'on veut lancer l'événement.
        /// Elle vérifie d'abord que l'instance de délégué pointe sur au moins une méthode, si c'est le cas, elle génère l'événement.
        /// Par convention, cette méthode commence par On... et continue avec le nom de l'événement ...InfoChanged.
        /// On la choisit protected virtual pour qu'elle puisse être réimplémentée par les classes filles en général. Mais vous pouvez choisir un autre
        /// degré d'accessibilité.
        /// </summary>
        /// <param name="args">arguments de cet événement</param>
        protected virtual void OnInfoChanged(InfoChangedEventArgs args)
        {
            if (InfoChanged != null)
            {
                InfoChanged(this, args);
            }
        }

        /// <summary>
        /// propriété Info
        /// </summary>
        public string Info
        {
            get { return mInfo; }
            set
            {
                if (mInfo == value)
                {
                    return;
                }
                mInfo = value;
                //génère l'événement avec des arguments construits à la volée
                OnInfoChanged(new InfoChangedEventArgs(value, DateTime.Now));
            }
        }
        string mInfo;

        /// <summary>
        /// nom du broadcaster
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="info">l'info</param>
        public Broadcaster(string name, string info)
        {
            Name = name;
            Info = info;
        }
    }
}
