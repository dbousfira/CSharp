// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : ConcreteSubscriber.cs
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
    class ConcreteSubscriber : ISubscriber
    {
        public string Name
        {
            get;
            private set;
        }

        InfoSportBroadcaster mCaster;

        public ConcreteSubscriber(string name, InfoSportBroadcaster caster)
        {
            Name = name;
            mCaster = caster;
        }

        public void Update()
        {
            Console.WriteLine("{0} a reçu l'info {1} le {2} à {3}",
                                Name,
                                mCaster.LastInfo,
                                mCaster.LastDateTime.ToShortDateString(),
                                mCaster.LastDateTime.ToShortTimeString());
        }
    }
}
