using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(ThrowsException());
            Console.WriteLine("We're done");
            Console.ReadLine();
        }

        static string ThrowsException() {
            try {
                throw new Exception();
            }
            catch {
                Console.WriteLine("Oh no! Exception");
                return "From the catch";
            }
            //Finally block ALWAYS executes
            finally {
                Console.WriteLine("This is the finally block");

            }
        }
    }
}
