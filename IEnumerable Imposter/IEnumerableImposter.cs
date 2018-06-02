using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerable_Imposter {
    public class IEnumerableImposter : Random, IEnumerable<int> {
        public IEnumerator GetEnumerator() => GetEnumerator();
        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            while (true) yield return Next();
        }
    }
}