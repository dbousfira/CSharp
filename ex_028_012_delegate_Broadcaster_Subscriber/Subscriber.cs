// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Subscriber.cs
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
    /// classe dont les instances vont s'abonner au type délégué Informer de la classe Broadcaster
    /// </summary>
    class Subscriber
    {
        /// <summary>
        /// nom de l'abonné
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// méthode du type délégué Broadcaster.Information
        /// </summary>
        public void RecevoirInfo(string info, DateTime date)
        {
            Console.WriteLine("{0} a reçu l'info {1} le {2} à {3}", Name, info, date.ToShortDateString(), date.ToShortTimeString());
        }

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="nom">nom de l'abonné</param>
        public Subscriber(string nom)
        {
            Name = nom;
        }

        /// <summary>
        /// méthode permettant à l'instance d'Subscriber de s'abonner à l'instance de délégué Informer d'un Broadcaster
        /// </summary>
        /// <param name="dif">le diffuseur</param>
        public void Abonnement(Broadcaster dif)
        {
            #region affichage console
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(Name + " vient de s'abonner à " + dif.Name);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            dif.Informer += RecevoirInfo;
        }

        public void Désabonnement(Broadcaster dif)
        {
            #region affichage console
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(Name + " vient de se désabonner de " + dif.Name);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            dif.Informer -= RecevoirInfo;
        }

        /// <summary>
        /// méthode qui désabonne tous les autres abonnés à l'instance de délégué Broadcaster.Informer et qui ne garde que l'instance this
        /// </summary>
        /// <param name="dif">le diffuseur</param>
        public void DésabonnerToutLeMondeSaufMoi(Broadcaster dif)
        {
            #region affichage console
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(Name + " vient de désabonner tout le monde sauf lui de " + dif.Name);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            dif.Informer = RecevoirInfo;
        }
    }
}

