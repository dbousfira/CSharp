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
            //création d'un diffuseur
            Broadcaster info_sport = new Broadcaster("Info Sport");
            info_sport.Info = "Toulouse s'impose face à Toulon 32 à 9";

            //deux instances d'Subscriber s'abonnent à l'instance de délégué info_sport.Informer
            Subscriber arthur = new Subscriber("Arthur");
            arthur.Abonnement(info_sport);
            info_sport.Info = "Grenoble domine le Racing-Metro 27 à 13";

            Subscriber richard = new Subscriber("Richard");
            richard.Abonnement(info_sport);

            //une nouvelle info tombe, l'appel du setter de la propriété Broadcaster.Info va exécuter les méthodes pointées par l'instance 
            // de délégué info_sport.Informer, soit arthur.RecevoirInfo et richard.RecevoirInfo
            info_sport.Info = "L'ASM bat le Stade Français 28 à 25";
            //Informer("L'ASM bat le Stade Français 28 à 25", DateTime.Now);
            // <=> arthur.RecevoirInfo("L'ASM bat le Stade Français 28 à 25", DateTime.Now);
            //     richard.RecevoirInfo("L'ASM bat le Stade Français 28 à 25", DateTime.Now);
            Console.WriteLine();

            //arthur désabonne richard et s'abonne tout seul
            arthur.DésabonnerToutLeMondeSaufMoi(info_sport);
            //un nouvelle info tombe, arthur reçoit l'info mais pas richard
            info_sport.Info = "La Nouvelle-Zélande gagne le Four Nations en battant l'Argentine 54 à 15";

            //c'est un peu nul quand même, qu'un abonné ait l'autorisation de désabonner les autres...
            // A SUIVRE dans ex_04_013_event_Broadcaster_Subscriber
        }
    }
}
