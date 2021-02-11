using System.Collections.Generic;
using System.IO;

namespace Lesson6.task2
{
    class Finder
    {
        public static readonly string FILE_NAME = "data.bin";

        private Function function;
        private double x1;
        private double x2;
        private double step;

        public Finder(Choice choice)
        {
            this.function = choice.Func;
            this.x1 = choice.A;
            this.x2 = choice.B;
            this.step = choice.Step;
        }

        public double[] Min(out double min)
        {
            SaveFunc();
            return Load(out min);
        }

        private void SaveFunc()
        {
            FileStream fs = new FileStream(FILE_NAME, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            double x = x1;
            while (x <= x2)
            {
                bw.Write(function(x));
                x += step;
            }

            bw.Close();
            fs.Close();
        }
        private double[] Load(out double min)
        {
            List<double> values = new List<double>();

            FileStream fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);

            min = double.MaxValue;
            double value;

            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                value = bw.ReadDouble();
                values.Add(value);

                if (value < min) min = value;
            }

            bw.Close();
            fs.Close();

            return values.ToArray();
        }
    }
}
