// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : InfoSportBroadcaster.cs
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
    class InfoSportBroadcaster : Broadcaster
    {
        public string LastInfo
        {
            get
            {
                return mLastInfo;
            }
            private set
            {
                if (value != mLastInfo)
                {
                    mLastInfo = value;
                    Notify();
                }
            }
        }
        string mLastInfo;

        public DateTime LastDateTime
        {
            get
            {
                return mLastDateTime;
            }
            private set
            {
                if (value != mLastDateTime)
                {
                    mLastDateTime = value;
                }
            }
        }
        DateTime mLastDateTime;

        public void AddInfo(string info)
        {
            LastDateTime = DateTime.Now;
            LastInfo = info;
        }
    }
}
