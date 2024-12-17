using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceCalc
{
    public class Service1 : IService1
    {
        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Divide(double n1, double n2)
        {
            if (n2 == 0)
                throw new ArgumentException("Division by zero is not allowed.");
            return n1 / n2;
        }

        public double Modulus(double n1, double n2)
        {
            if (n2 == 0)
                throw new ArgumentException("Modulus by zero is not allowed.");
            return n1 % n2;
        }

        public double Logarithm(double n1, double baseValue)
        {
            if (n1 <= 0 || baseValue <= 0 || baseValue == 1)
                throw new ArgumentException("Invalid input for logarithm.");
            return Math.Log(n1, baseValue);
        }

        public double Exponential(double baseValue, double exponent)
        {
            return Math.Pow(baseValue, exponent);
        }

        public double SquareRoot(double n)
        {
            if (n < 0)
                throw new ArgumentException("Square root of a negative number is not allowed.");
            return Math.Sqrt(n);
        }
    }
}
