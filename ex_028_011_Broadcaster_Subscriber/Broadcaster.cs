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

namespace ex_028_011_Broadcaster_Subscriber
{
    class Broadcaster
    {
        List<ISubscriber> mSubscribers = new List<ISubscriber>();

        public void Attach(ISubscriber subscriber)
        {
            mSubscribers.Add(subscriber);
        }

        public void Detach(ISubscriber subscriber)
        {
            mSubscribers.Remove(subscriber);
        }

        public void Notify()
        {
            foreach (ISubscriber subscriber in mSubscribers)
            {
                subscriber.Update();
            }
        }
    }
}
