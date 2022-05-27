// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : ClasseQuiFaitDuGrosTravail.cs
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
    public class ClasseQuiFaitDuGrosTravail
    {
        List<IProgression> mProgressions = new List<IProgression>();

        public void Attacher(IProgression prog)
        {
            mProgressions.Add(prog);
        }

        public void Détacher(IProgression prog)
        {
            mProgressions.Remove(prog);
        }

        void Notifier(int pourcentage)
        {
            foreach (IProgression prog in mProgressions)
            {
                prog.Progression = pourcentage;
            }
        }

        public void GrosTravail()
        {
            for (int i = 0; i <= 100; i++)
            {
                Notifier(i);
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}
