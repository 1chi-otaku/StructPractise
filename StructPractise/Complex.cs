using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPractise
{
    class Complex
    {
        public double r, i;

        public Complex(double r, double i)
        {
            this.r = r;
            this.i = i;
        }

        static public Complex Sum(Complex a, Complex b)
        {
            return new Complex(a.r + b.r, a.i + b.i);
        }
        static public Complex Multiplication(Complex a, Complex b)
        {
            return new Complex(a.r * b.r, a.i * b.i);
        }
        static public Complex Subtract(Complex a, Complex b)
        {
            return new Complex(a.r - b.r, a.i - b.i);
        }
        static public Complex Divide(Complex a, Complex b)
        {
            return new Complex(a.r / b.r, a.i / b.i);
        }

        public void Print()
        {
            Console.Write(r + "+ i(" + i + ")");
        }

    }
}
