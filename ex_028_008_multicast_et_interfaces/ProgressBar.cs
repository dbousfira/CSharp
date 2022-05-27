// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : ProgressBar.cs
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
    class ProgressBar : IProgression
    {
        static int MaxWidth = Console.WindowWidth - 1;

        public int Progression
        {
            set
            {
                Console.WriteLine(String.Empty.PadLeft(value * MaxWidth / 100, '*'));
            }
        }
    }
}
