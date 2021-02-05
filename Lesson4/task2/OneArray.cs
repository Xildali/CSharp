using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.task2
{
    class OneArray
    {
        private int[] array;

        #region Constructors

        public OneArray(int[] array)
        {
            this.array = array;
        }

        public OneArray(int size, int firstValue, int stepSize)
        {
            array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = firstValue + stepSize * i;
            }
        }

        public OneArray(string fileName)
        {
            Reader reader = new Reader(fileName);

            int size = reader.NextInt();
            array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = reader.NextInt();
            }

            reader.Close();
        }

        #endregion

        #region Properties

        public int this[int i]
        {
            get
            {
                return array[i];
            }
            set
            {
                array[i] = value;
            }
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return sum;
            }
        }

        public int MaxCount
        {
            get
            {
                int max = int.MinValue;
                int count = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == max)
                    {
                        count++;
                    }
                    else if (array[i] > max)
                    {
                        max = array[i];
                        count = 1;
                    }
                }

                return count;
            }
        }

        #endregion

        #region Methods

        public void Inverse()
        {
            Mult(-1);
        }

        public void Mult(int x)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= x;
            }
        }

        public void SaveToFile(string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);

            writer.WriteLine(array.Length);

            for (int i = 0; i < array.Length; i++)
            {
                writer.WriteLine(array[i]);
            }

            writer.Close();
        }

        public override string ToString()
        {
            return string.Join(", ", array);
        }

        #endregion
    }
}
