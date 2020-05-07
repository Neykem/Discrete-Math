using System;
using System.Windows;

namespace Discrete_Math
{
    class BooleanFunction : IBooleanFunc
    {
        private int id { get; set; }
        private int n1 { get; set; }
        private int n2 { get; set; }
        private char[] n1_bool { get; set; }
        private char[] n2_bool { get; set; }
        private TruthTable boolean_Function_TruthTable;
        public string Name;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int N1
        {
            get { return n1; }
            private set {  n1 = value; }
        }
        public int N2
        {
            get { return n2; }
            private set { n2 = value; }
        }
        public TruthTable boolean_Function_TruthTable_interface
        {
            get { return boolean_Function_TruthTable; }
            set { boolean_Function_TruthTable = value; }
        }
        public BooleanFunction(int arg_id, string name, int arg_n1, int arg_n2)
        {
            ID = arg_id;
            Name = name;
            n1 = arg_n1;
            n2 = arg_n2;
            n1_bool = ConvertToBool(arg_n1);
            n2_bool = ConvertToBool(arg_n2);
        }
        public char[] ConvertToBool(int number)
        {
            string result = null;
            result = Convert.ToString(number, 2);
            if (result.Length < 8)
            {
                int buff = 8 - result.Length;
                for (int n = 0; n != buff; n++)
                {
                    result = '0' + result;
                }
            }
            MessageBox.Show(result);
            return result.ToCharArray();
        }

        public TruthTable CalculationTruthTable(BooleanFunction booleanFunction)
        {
            TruthTable truthTable = new TruthTable();
            string[] buff = { "x", "y", "z", "F1", "F2"};
            truthTable.row_table_name = buff;
            int[,] buff3 = new int[8, 5];
            truthTable.variable_table = buff3;

            int[] buff2 = new int[] {0,0,0,0,1,1,1,1};
            truthTable.SetRow(buff2, truthTable, 0, 7);
            buff2 = new int[] {0,0,1,1,0,0,1,1};
            truthTable.SetRow(buff2, truthTable, 1, 7);
            buff2 = new int[] {0,1,0,1,0,1,0,1};
            truthTable.SetRow(buff2, truthTable, 2, 7);

            truthTable.SetRow(n1_bool, truthTable, 3, 7);
            truthTable.SetRow(n2_bool, truthTable, 4, 7);

            booleanFunction.boolean_Function_TruthTable = truthTable;
            return truthTable;
        }
        public TruthTable CalculationPDNF(TruthTable truthTable, int index_row)
        {
            int kol_column = 8; // kol colomn from function wich 3 vars
            int index_row_PDNF = 0;
            int index_row_n2;
            int size = 0;

            if (index_row == 3) { index_row_n2 = index_row; }
            else { index_row_n2 = 3; }
            string[] buff = { "x", "y", "z", "F"};
            TruthTable truthTableCalculation = new TruthTable();
            truthTableCalculation.row_table_name = buff;
            for (int n = 0; n<kol_column; n++)
            {
                if (truthTable.variable_table[n, index_row] == 1) {
                    size++;
                }
            }
            truthTableCalculation.variable_table = new int[size, 4];
            for (int n = 0; n < kol_column; n++)
            {
                if (truthTable.variable_table[n, index_row] == 1)
                {
                    truthTableCalculation.variable_table[index_row_PDNF, index_row_n2] = truthTable.variable_table[n, index_row];
                    truthTableCalculation.variable_table[index_row_PDNF, 0] = truthTable.variable_table[n, 0];
                    truthTableCalculation.variable_table[index_row_PDNF, 1] = truthTable.variable_table[n, 1];
                    truthTableCalculation.variable_table[index_row_PDNF, 2] = truthTable.variable_table[n, 2];
                    index_row_PDNF++;
                }
            }
            return truthTableCalculation;
        }
        public TruthTable CalculationPSNF(TruthTable truthTable, int index_row)
        {
            int kol_column = 8; // kol colomn from function wich 3 vars 
            int index_row_PSNF = 0;
            int index_row_n2;
            int size = 0;
            
            if(index_row == 3) { index_row_n2 = index_row; }
            else { index_row_n2 = 3; }
            string[] buff = { "x", "y", "z", "F" };
            TruthTable truthTableCalculation = new TruthTable();
            truthTableCalculation.row_table_name = buff;
            for (int n = 0; n < kol_column; n++)
            {
                if (truthTable.variable_table[n, index_row] == 0)
                {
                    size++;
                }
            }
            truthTableCalculation.variable_table = new int[size,4];
            for (int n = 0; n < kol_column; n++)
            {
                if (truthTable.variable_table[n, index_row] == 0)
                {
                    truthTableCalculation.variable_table[index_row_PSNF, index_row_n2] = truthTable.variable_table[n, index_row];
                    truthTableCalculation.variable_table[index_row_PSNF, 0] = truthTable.variable_table[n, 0];
                    truthTableCalculation.variable_table[index_row_PSNF, 1] = truthTable.variable_table[n, 1];
                    truthTableCalculation.variable_table[index_row_PSNF, 2] = truthTable.variable_table[n, 2];
                    index_row_PSNF++;
                }
            }
            return truthTableCalculation;
        }
    }
}