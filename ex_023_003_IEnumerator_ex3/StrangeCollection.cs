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

namespace ex_023_003_IEnumerator_ex3
{
    class StrangeCollection : IEnumerable<int>
    {
        int[] data = { 1, 2, 3, 4, 5, 6 };

        public IEnumerator<int> GetEnumerator()
        {
            return new StrangeEnumerator(this);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new StrangeEnumerator(this);
        }

        class StrangeEnumerator : IEnumerator<int>
        {
            int mCurrentIndex = -1;
            StrangeCollection mCollection;

            internal StrangeEnumerator(StrangeCollection collection)
            {
                mCollection = collection;
            }

            public int Current
            {
                get
                {
                    return mCollection.data[mCurrentIndex];
                }
            }
            object System.Collections.IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public bool MoveNext()
            {
                mCurrentIndex++;
                while (mCurrentIndex < mCollection.data.Length && mCollection.data[mCurrentIndex] % 2 != 0)
                {
                    mCurrentIndex++;
                }
                return mCurrentIndex < mCollection.data.Length;
            }

            public void Reset()
            {
                mCurrentIndex = -1;
            }

            void IDisposable.Dispose() { }
        }
    }
}
