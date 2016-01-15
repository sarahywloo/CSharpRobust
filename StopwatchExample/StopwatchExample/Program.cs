using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchExample {
    class Program {
        static void Main(string[] args) {

            //Generate list of random numbers
            var randomNumbers = new List<int>();
            var rand = new Random();

            for(int i = 0; i < 10000; i++) {
                randomNumbers.Add(rand.Next(1000));
            }

            //Create a stopwatch
            var stopwatch = new Stopwatch();

            stopwatch.Start();

            //Counting all duplicates

            var checkNums = randomNumbers.Distinct().ToList();
            var remaining = new List<int>(randomNumbers);

            while (checkNums.Count > 0) {
                int numToCheck = checkNums.First();
                checkNums.RemoveAt(0);

                int duplicateCount = 0;

                for (int i = 0; i <remaining.Count; i++) {
                    if(remaining[i] == numToCheck) {
                        duplicateCount++;
                        Console.WriteLine("{0} has {1} duplicates", numToCheck, duplicateCount);
                    }
                }
            }

            //Another method:
            //foreach (var n1 in randomNumbers) {

            //    int duplicateCount = 0;

            //    foreach (var n2 in randomNumbers) {
            //        if (n1 == n2) {
            //            duplicateCount++;

            //        }
            //    }
            //    Console.WriteLine("{0} has {1} duplicates", n1, duplicateCount);
            //}


            stopwatch.Stop();
            Console.WriteLine("The total time is {0} milliseconds", stopwatch.ElapsedMilliseconds);

            Console.ReadLine();
        }

    }
}
