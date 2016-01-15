using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithTests {
    public class Calculator {

        public double Add(params double[] nums) {
            double sum = 0;
            foreach (double val in nums) {
                sum += val;
            }
            return sum;
            //return nums.Sum();
        }
        public double Subtract(double num1, double num2) {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2) {
            return num1 * num2;
        }
        public double Divide(double num1, double num2) {
            return num1 / num2;
        }
        public double Exp(double b, double exp) {
            return Math.Pow(b, exp);
        }

    }
}
