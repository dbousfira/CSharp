// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : Program.cs
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
    class Program
    {
        static void Main(string[] args)
        {
            //déclaration et affectation d'un Broadcaster
            Broadcaster info_sport = new Broadcaster("info sport", "rien");

            //déclaration et abonnement de deux Subscriber
            Subscriber arthur = new Subscriber("Arthur");
            arthur.Subscribe(info_sport);
            Subscriber richard = new Subscriber("Richard");
            richard.Subscribe(info_sport);

            //génération d'une nouvelle info
            info_sport.Info = "Del Potro bat Federer en finale de l'US Open";

            Console.WriteLine();
        }
    }
}

