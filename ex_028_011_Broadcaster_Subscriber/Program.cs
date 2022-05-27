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

namespace ex_028_011_Broadcaster_Subscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoSportBroadcaster caster = new InfoSportBroadcaster();

            ConcreteSubscriber arthur = new ConcreteSubscriber("Arthur", caster);
            ConcreteSubscriber richard = new ConcreteSubscriber("Richard", caster);

            caster.Attach(arthur);
            caster.AddInfo("L'ASM bat le Stade Français 28 à 25");
            System.Threading.Thread.Sleep(2000);

            caster.Attach(richard);
            caster.AddInfo("Grenoble domine le Racing-Metro 27 à 13");
            System.Threading.Thread.Sleep(2000);

            caster.Detach(arthur);
            caster.AddInfo("La Nouvelle-Zélande gagne le Four Nations en battant l'Argentine 54 à 15");
            System.Threading.Thread.Sleep(2000);
        }
    }
}
