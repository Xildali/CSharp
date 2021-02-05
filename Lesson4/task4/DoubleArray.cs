using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.task4
{
    class DoubleArray
    {
        private int[][] array;

        #region Constructors

        public DoubleArray(int rows, int cols)
        {
            Random random = new Random();

            array = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                array[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    array[i][j] = random.Next(10);
                }
            }
        }

        public DoubleArray(string fileName)
        {
            Reader reader = new Reader(fileName);

            int rows = reader.NextInt();
            int cols = reader.NextInt();

            array = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                array[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    array[i][j] = reader.NextInt();
                }
            }

            reader.Close();
        }

        #endregion

        #region Properties

        public int[] this[int i]
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

        public int Min
        {
            get
            {
                int min = array[0][0];
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        if (array[i][j] < min)
                            min = array[i][j];
                    }
                }
                return min;
            }
        }

        public int Max
        {
            get
            {
                int max = array[0][0];
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        if (array[i][j] > max)
                            max = array[i][j];
                    }
                }
                return max;
            }
        }

        #endregion

        #region Methods

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                }
            }
            return sum;
        }

        public int Sum(int minNumber)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] > minNumber)
                        sum += array[i][j];
                }
            }
            return sum;
        }

        public void MaxIndex(out int row, out int col)
        {
            row = 0;
            col = 0;
            int max = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] > max)
                    {
                        max = array[i][j];
                        row = i;
                        col = j;
                    }
                }
            }
        }

        public void SaveToFile(string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);

            writer.WriteLine(array.Length);
            writer.WriteLine(array[0].Length);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[0].Length; j++)
                {
                    writer.WriteLine(array[i][j]);
                }
            }

            writer.Close();
        }

        public override string ToString()
        {
            string[] rows = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                rows[i] = $"[{string.Join(", ", array[i])}]";
            }
            return $"[{string.Join(", ", rows)}]";
        }

        #endregion
    }
}
