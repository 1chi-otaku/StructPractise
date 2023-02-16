using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region #1 Дробь
            //Fraction a = new Fraction(1, 2);
            //Fraction b = new Fraction(3, 4);

            //Fraction c = a.Add(b);
            //Console.WriteLine("Summ - " + c.Result());
            //c = a.Substract(b);
            //Console.WriteLine("Substract - " + c.Result());
            //c = a.Multiply(1, 6);
            //Console.WriteLine("Multiply - " + c.Result());
            //c = a.Divide(b);
            //Console.WriteLine("Divide - " + c.Result());
            #endregion
            #region #2 Комплексное число

            //Complex c = Complex.Sum(new Complex(2, 3), new Complex(5, 7));
            //Console.WriteLine("Sum:");
            //c.Print();
            //c = Complex.Subtract(new Complex(2, 3), new Complex(5, 7));
            //Console.WriteLine();
            //Console.WriteLine("Subs:");
            //c.Print();
            //c = Complex.Divide(new Complex(2, 3), new Complex(5, 7));
            //Console.WriteLine();
            //Console.WriteLine("Div:");
            //c.Print();
            //c = Complex.Multiplication(new Complex(2, 3), new Complex(5, 7));
            //Console.WriteLine();
            //Console.WriteLine("Mult:");
            //c.Print();
            //Console.WriteLine();

            #endregion


            #region #3 День Рождения

            Birthday Tom = new Birthday(29, 06, 1991);

            Tom.PrintBirthday();
            Tom.DayOfBirth();
            Console.WriteLine(Tom.DaysBeforeBirthday() + " days before birthday!");


            #endregion


        }
    }
}
