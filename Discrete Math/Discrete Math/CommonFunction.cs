using System;

namespace Discrete_Math
{
    public abstract class CommonFunction
    {
        public static int CalculateArrSize(int kol_column, int index_row, int condition, TruthTable truthTable) // вычисляет рсзмер массива для СКНФ/СДНФ; 1arg - количество строк по 'y'; 2arg - строка с функцией; 3arg - Критерий оченки для СКНФ = 0, для СДНФ = 1; 4arg - Матрица истенности;
        {
            int size = 0;
            for (int n = 0; n < kol_column; n++)
            {
                if (truthTable.variable_table[n, index_row] == condition)
                {
                    size++;
                }
            }
            return size;
        }
        public static string OneDimensionalArrOut(int[] row_var, int size_arr)
        {
            string buff = "";
            for (int n = 0; size_arr > n; n++)
            {
                buff += "|" + '\t';
                buff += row_var[n].ToString();
                buff += '\t' + "|";
            }
            buff += '\n';
            return buff;
        }
        public static string OneDimensionalArrOut(string[] row_var, int size_arr)
        {
            string buff = "";
            for (int n = 0; size_arr > n; n++)
            {
                buff += "|" + '\t';
                buff += row_var[n].ToString();
                buff += '\t' + "|";
            }
            buff += '\n';
            return buff;
        }
        public static string TwoDimensionalArrOut(int[,] row_var, int size_arr_x, int size_arr_y)
        {
            string buff = "";
            for (int n = 0; size_arr_x > n; n++)
            {
                for (int j = 0; size_arr_y > j; j++)
                {
                    buff += "|" + '\t';
                    buff += row_var[n, j].ToString();
                    buff += '\t' + "|";

                }
                buff += '\n';
            }
            return buff;
        }
        public static string TwoDimensionalArrOut(char[,] row_var, int size_arr_x, int size_arr_y)
        {
            string buff = "";
            for (int n = 0; size_arr_x > n; n++)
            {
                for (int j = 0; size_arr_y > j; j++)
                {
                    buff += "|" + '\t';
                    buff += row_var[n, j].ToString();
                    buff += '\t' + "|";

                }
                buff += '\n';
            }
            return buff;
        }
    }
}
