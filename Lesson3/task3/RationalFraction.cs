using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.task3
{
    class RationalFraction
    {
        private int numerator;
        private int denominator;

        public RationalFraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен 0");

            this.numerator = numerator;
            this.denominator = denominator;
        }

        public RationalFraction Plus(RationalFraction a)
        {
            int numerator = this.numerator * a.denominator + a.numerator * this.denominator;
            int denominator = this.denominator * a.denominator;
            return new RationalFraction(numerator, denominator).Reduce();
        }

        public RationalFraction Minus(RationalFraction a)
        {
            int numerator = this.numerator * a.denominator - a.numerator * this.denominator;
            int denominator = this.denominator * a.denominator;
            return new RationalFraction(numerator, denominator).Reduce();
        }

        public RationalFraction Mult(RationalFraction a)
        {
            int numerator = this.numerator * a.numerator;
            int denominator = this.denominator * a.denominator;
            return new RationalFraction(numerator, denominator).Reduce();
        }

        public RationalFraction Div(RationalFraction a)
        {
            int numerator = this.numerator * a.denominator;
            int denominator = this.denominator * a.numerator;
            return new RationalFraction(numerator, denominator).Reduce();
        }

        public RationalFraction Reduce()
        {
            int gdc = GCD(numerator, denominator);
            return new RationalFraction(numerator / gdc, denominator / gdc);
        }

        public override string ToString()
        {
            return $"({numerator}/{denominator})";
        }

        private int GCD(int a, int b)
        {
            if (a == 0)
                return b;

            int min = a < b ? a : b;
            int max = a > b ? a : b;

            return GCD(max % min, min);
        }
    }
}
