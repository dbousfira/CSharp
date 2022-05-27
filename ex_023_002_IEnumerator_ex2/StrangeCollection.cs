// ========================================================================
//
// Copyright (C) 2013-2014 MARC CHEVALDONNE
//                         marc.chevaldonne.free.fr
//
// Module        : StrangeCollection.cs
// Author        : Marc Chevaldonné
// Creation date : 2014-03-30
//
// ========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_023_002_IEnumerator_ex2
{
    class StrangeCollection : IEnumerable<int>
    {
        int[] data = { 1, 2, 3, 4, 5, 6 };

        public IEnumerator<int> GetEnumerator()
        {
            foreach (int i in data)
            {
                if (i % 2 == 0)
                {
                    yield return i;
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
