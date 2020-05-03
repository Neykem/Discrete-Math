
using System.Windows;

namespace Discrete_Math
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            string buff = "";
            InitializeComponent();
            TruthTable PSNF = new TruthTable();
            TruthTable PDNF = new TruthTable();
            BooleanFunction booleanFunction = new BooleanFunction("My boolean Function", 12, 244);
            booleanFunction.CalculationTruthTable(booleanFunction);
            PSNF = booleanFunction.CalculationPSNF(booleanFunction.boolean_Function_TruthTable_interface, 3);
            PDNF = booleanFunction.CalculationPDNF(booleanFunction.boolean_Function_TruthTable_interface, 3);

            TextBoxName.Text = booleanFunction.Name;
            TextBoxContent.Text = "";
            TextBoxContent.Text += "Таблица истенности для F(N1 = " + booleanFunction.N1 + ", N2 = " + booleanFunction.N2 + ")" + '\n';
            for (int n = 0; 5 > n; n++)
            {
                buff += "|" + '\t';
                buff += booleanFunction.boolean_Function_TruthTable_interface.row_table_name[n];
                buff += '\t' + "|";
            }
            buff += '\n';
            TextBoxContent.Text += buff;
            buff = "";

            TextBoxContent.Text += CommonFunction.TwoDimensionalArrOut(booleanFunction.boolean_Function_TruthTable_interface.variable_table, 8, 5);

            TextBoxContent.Text += "СДНФ для F(N1 = " + booleanFunction.N1  + ")" + '\n';
            TextBoxContent.Text += CommonFunction.OneDimensionalArrOut(PDNF.row_table_name, 4);
            TextBoxContent.Text += CommonFunction.TwoDimensionalArrOut(PDNF.variable_table, CommonFunction.CalculateArrSize(8, 3, 1, booleanFunction.boolean_Function_TruthTable_interface), 4);
            TextBoxContent.Text += "СКНФ для F(N1 = " + booleanFunction.N1  + ")" + '\n';
            TextBoxContent.Text += CommonFunction.OneDimensionalArrOut(PSNF.row_table_name, 4);
            TextBoxContent.Text += CommonFunction.TwoDimensionalArrOut(PSNF.variable_table, CommonFunction.CalculateArrSize(8, 3, 0, booleanFunction.boolean_Function_TruthTable_interface), 4);

            PSNF = booleanFunction.CalculationPSNF(booleanFunction.boolean_Function_TruthTable_interface, 4);
            PDNF = booleanFunction.CalculationPDNF(booleanFunction.boolean_Function_TruthTable_interface, 4);
            TextBoxContent.Text += "СДНФ для F(N2 = " + booleanFunction.N2 + ")" + '\n';
            TextBoxContent.Text += CommonFunction.OneDimensionalArrOut(PDNF.row_table_name, 4);
            TextBoxContent.Text += CommonFunction.TwoDimensionalArrOut(PDNF.variable_table, CommonFunction.CalculateArrSize(8, 4, 1, booleanFunction.boolean_Function_TruthTable_interface), 4);
            TextBoxContent.Text += "СКНФ для F(N2 = " + booleanFunction.N2 + ")" + '\n';
            TextBoxContent.Text += CommonFunction.OneDimensionalArrOut(PSNF.row_table_name, 4);
            TextBoxContent.Text += CommonFunction.TwoDimensionalArrOut(PSNF.variable_table, CommonFunction.CalculateArrSize(8, 4, 0, booleanFunction.boolean_Function_TruthTable_interface), 4);
        }
    }
}
