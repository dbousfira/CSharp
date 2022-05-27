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

namespace ex_028_008_multicast_et_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasseQuiFaitDuGrosTravail cqfdgt = new ClasseQuiFaitDuGrosTravail();
            cqfdgt.GrosTravail();

            IProgression p1 = new AffichePourcentage();
            cqfdgt.Attacher(p1);
            cqfdgt.GrosTravail();

            IProgression p2 = new ProgressBar();
            cqfdgt.Attacher(p2);
            cqfdgt.GrosTravail();

            cqfdgt.Détacher(p1);
            cqfdgt.GrosTravail();

            cqfdgt.Détacher(p2);

            cqfdgt.Attacher(new ClearProgression());
            cqfdgt.Attacher(new ProgressBar());
            cqfdgt.Attacher(new AffichePourcentage());
            cqfdgt.GrosTravail();
        }
    }
}
