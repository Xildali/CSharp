using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.task1
{
    struct ComplexStruct
    {
        public double re;
        public double im;

        public ComplexStruct(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public ComplexStruct Plus(ComplexStruct x)
        {
            double re = this.re + x.re;
            double im = this.im + x.im;
            return new ComplexStruct(re, im);
        }

        public ComplexStruct Minus(ComplexStruct x)
        {
            double re = this.re - x.re;
            double im = this.im - x.im;
            return new ComplexStruct(re, im);
        }

        public override string ToString()
        {
            return $"({re:0.##} + {im:0.##}i)";
        }

    }
}
