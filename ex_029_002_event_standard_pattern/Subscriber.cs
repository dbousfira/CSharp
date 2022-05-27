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
    /// la classe dont les instances vont s'abonner à l'événement
    /// </summary>
    public class Subscriber
    {
        /// <summary>
        /// nom du subscriber
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// méthode ayant la même signature que l'événement, elle peut donc s'abonner.
        /// </summary>
        /// <param name="sender">celui qui génère l'événement</param>
        /// <param name="args">arguments de l'événement</param>
        public void ReceiveInfo(object sender, InfoChangedEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Name);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" a reçu l'info : ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(args.NewInfo);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" à ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(args.InfoDate.ToShortTimeString());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" provenant de ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine((sender as Broadcaster).Name);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="name">nom de l'abonné</param>
        public Subscriber(string name)
        {
            Name = name;
        }

        /// <summary>
        /// abonnement de cette instance de Subscriber à l'événement de Broadcaster
        /// </summary>
        /// <param name="br">le Broadcaster possédant l'événement auquel s'abonne ce Subscriber</param>
        public void Subscribe(Broadcaster br)
        {
            //abonnement, on peut utiliser += avec une méthode de cette instance de Subscriber
            br.InfoChanged += ReceiveInfo;
        }
    }
}

