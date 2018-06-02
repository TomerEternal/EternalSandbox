using IEnumerable_Imposter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox {
    class Program {
        static void Main(string[] args) {
            foreach (var item in new IEnumerableImposter()) {
                Console.WriteLine(item);
            }
        }
    }
}
