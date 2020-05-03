using System;

namespace Discrete_Math
{
    public struct TruthTable
    {
        public string[] row_table_name;
        public int[,] variable_table;

        public void SetRow(int[] row_var, TruthTable truthTable, int index_row, int kol_column) // int kol_c for xyz = 8
        {
            for (int n = 0; n <= kol_column; n++)
            {
                truthTable.variable_table[n, index_row] = row_var[n];
            }
        }
        public void SetRow(char[] row_var, TruthTable truthTable, int index_row, int kol_column) 
        {
            for (int n = 0; n < kol_column; n++)
            {
                truthTable.variable_table[n, index_row] = Convert.ToInt32(row_var[n].ToString());
            }
        }
    }
}
