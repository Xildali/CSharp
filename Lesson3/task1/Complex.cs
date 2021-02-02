using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.task1
{
    class Complex
    {
        private double re;
        private double im;

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public Complex Plus(Complex a)
        {
            double re = this.re + a.re;
            double im = this.im + a.im;
            return new Complex(re, im);
        }

        public Complex Minus(Complex a)
        {
            double re = this.re - a.re;
            double im = this.im - a.im;
            return new Complex(re, im);
        }

        public Complex Mult(Complex a)
        {
            double re = (this.re * a.re - this.im * a.im);
            double im = (this.re * a.im + a.re * this.im);
            return new Complex(re, im);
        }

        public override string ToString()
        {
            return $"({re:0.##} + {im:0.##}i)";
        }
    }
}
