using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    internal class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator = 0, int denominator = 0)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public static Fraction Add(Fraction first, Fraction second)
        {
            if (second.Numerator == 0)
            {
                return first;
            }
            else
            if (first.Numerator == 0)
            {
                return second;
            }
            int numerator = (first.Numerator * second.Denominator) + (second.Numerator * first.Denominator);
            int denominator = first.Denominator * second.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction Subtract(Fraction first, Fraction second)
        {
            if(second.Numerator == 0)
            {
                return first;
            }
            else
            if (first.Numerator == 0)
            {
                return new Fraction (-second.Numerator, second.Denominator);
            }
            int numerator = (first.Numerator * second.Denominator) - (second.Numerator * first.Denominator);
            int denominator = first.Denominator * second.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction Multiply(Fraction first, Fraction second)
        {
            int numerator = first.Numerator * second.Numerator;
            int denominator = first.Denominator * second.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction Divide(Fraction first, Fraction second)
        {
            int numerator = first.Numerator * second.Denominator;
            int denominator = first.Denominator * second.Numerator;
            return new Fraction(numerator, denominator);
        }

        public static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                int c = a % b;
                return GCD(b, c);
            }
        }

        public static Fraction Simplify(Fraction frac)
        {
            int gcd = GCD(frac.Numerator, frac.Denominator);
            while (gcd != 1 && gcd != 0)
            {
                frac.Numerator /= gcd;
                frac.Denominator /= gcd;
                gcd = GCD(frac.Numerator, frac.Denominator);
            }
            return frac;
        }

        public override string ToString()
        {
            return $"[{Numerator}, {Denominator}]";
        }
    }
}
