// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : AffichePourcentage.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-04-27
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_028_008_multicast_et_interfaces
{
    class AffichePourcentage : IProgression
    {
        public int Progression
        {
            set
            {
                Console.WriteLine("{0}%...", value);
            }
        }
    }
}
