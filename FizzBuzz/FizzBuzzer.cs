using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz {
    public class FizzBuzzer {
        static void StartFizzBuzzing(int iterations, params (int divider, string name)[] rules) {
            Enumerable.Range(0, iterations).ForEach(number => {
                if (!rules.Any(r => {
                    if (number % r.divider != 0)
                        return false;
                    else
                        Console.Write(r.name);
                    return true;

                }))
                    Console.Write(number);
                Console.WriteLine();
            });
        }
    }
}
