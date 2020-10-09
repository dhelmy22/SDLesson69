using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Calculator
    {
        // Add
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }
        public double Add(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }
        public int Multiply(int numOne, int numTwo) 
        {
            int mult = numOne * numTwo;
            return mult;
        }
        public int Subtract(int numOne, int numTwo)
        {
            int sub = numOne - numTwo;
            return sub;
        }
        public int Divide(int numOne, int numTwo)
        {
            int div = numTwo / numOne;
            return div;
        }
       //


    }
}
