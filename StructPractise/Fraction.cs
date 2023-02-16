using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace StructPractise
{
    struct Fraction
    {
        public double numerator { get; set; }
        public double denominator { set; get; }

        public Fraction(double numerator, double denominator)
        {
            if(numerator <= denominator)
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }
            else
            {
                this.numerator = 1;
                this.denominator = 2;
            }
            
        }
        public void Print()
        {
            Console.WriteLine(numerator);
            Console.WriteLine("__");
            Console.WriteLine(denominator);
        }
        public double Result()
        {
            return numerator / denominator;
        }

        public Fraction Add(Fraction other)
        {
            return new Fraction(this.numerator * other.denominator + other.numerator * this.denominator, this.denominator * other.denominator);
        }
        public Fraction Add(double numerator, double denominator)
        {
            return new Fraction(this.numerator * denominator + numerator * this.denominator, this.denominator * denominator);
        }
        public Fraction Substract(Fraction other)
        {
            return new Fraction(this.numerator * other.denominator - other.numerator * this.denominator, this.denominator * other.denominator);
        }
        public Fraction Substract(double numerator, double denominator)
        {
            return new Fraction(this.numerator * denominator - numerator * this.denominator, this.denominator * denominator);
        }
        public Fraction Multiply(Fraction other)
        {
            return new Fraction(this.numerator * other.denominator * other.numerator * this.denominator, this.denominator * other.denominator);
        }
        public Fraction Multiply(double numerator, double denominator)
        {
            return new Fraction(this.numerator * denominator * numerator * this.denominator, this.denominator * denominator);
        }
        public Fraction Divide(Fraction other)
        {
            return new Fraction(this.numerator * other.denominator / other.numerator * this.denominator, this.denominator * other.denominator);
        }
        public Fraction Divide(double numerator, double denominator)
        {
            return new Fraction(this.numerator * denominator / numerator * this.denominator, this.denominator * denominator);
        }
    }
}

