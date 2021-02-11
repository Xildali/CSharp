using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.task2
{
    class Choice
    {
        public Function Func { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public double Step { get; set; }

        public Choice(Function func, double a, double b, double step)
        {
            Func = func;
            A = a;
            B = b;
            Step = step;
        }
    }
}
