
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Text;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Discrete_Math
{
    public partial class MainWindow : Window
    {
        public XDocument Document { get; private set; }
        static List <BooleanFunction> list_boolean = new List<BooleanFunction>();
        private int indexList = 0;
        static TruthTable PSNF = new TruthTable();
        static TruthTable PDNF = new TruthTable();
        public MainWindow()
        {
            string buff = "";
            InitializeComponent();
            Document = new XDocument(new XElement("Root"));
            list_boolean.Add(new BooleanFunction(indexList,"My boolean Function", 12, 244));

            //BooleanFunction booleanFunction = new BooleanFunction("My boolean Function", 12, 244);

            //list_boolean[0].CalculationTruthTable(booleanFunction);
            //PSNF = list_boolean[0].CalculationPSNF(booleanFunction.boolean_Function_TruthTable_interface, 3);
            //PDNF = list_boolean[0].CalculationPDNF(booleanFunction.boolean_Function_TruthTable_interface, 3);

            DataContext = Document.Root;
            //TextBoxName.Text = booleanFunction.Name;
            //TextBoxContent.Text = "";
            //TextBoxContent.Text += "Таблица истенности для F(N1 = " + booleanFunction.N1 + ", N2 = " + booleanFunction.N2 + ")" + '\n';
            //for (int n = 0; 5 > n; n++)
            //{
            //    buff += "|" + '\t';
            //    buff += booleanFunction.boolean_Function_TruthTable_interface.row_table_name[n];
            //    buff += '\t' + "|";
            //}
            //buff += '\n';
            //TextBoxContent.Text += buff;
            //buff = "";

            //TextBoxContent.Text += CommonFunction.TwoDimensionalArrOut(booleanFunction.boolean_Function_TruthTable_interface.variable_table, 8, 5);

            //TextBoxContent.Text += "СДНФ для F(N1 = " + booleanFunction.N1  + ")" + '\n';
            //TextBoxContent.Text += CommonFunction.OneDimensionalArrOut(PDNF.row_table_name, 4);
            //TextBoxContent.Text += CommonFunction.TwoDimensionalArrOut(PDNF.variable_table, CommonFunction.CalculateArrSize(8, 3, 1, booleanFunction.boolean_Function_TruthTable_interface), 4);
            //TextBoxContent.Text += "СКНФ для F(N1 = " + booleanFunction.N1  + ")" + '\n';
            //TextBoxContent.Text += CommonFunction.OneDimensionalArrOut(PSNF.row_table_name, 4);
            //TextBoxContent.Text += CommonFunction.TwoDimensionalArrOut(PSNF.variable_table, CommonFunction.CalculateArrSize(8, 3, 0, booleanFunction.boolean_Function_TruthTable_interface), 4);

            //PSNF = booleanFunction.CalculationPSNF(booleanFunction.boolean_Function_TruthTable_interface, 4);
            //PDNF = booleanFunction.CalculationPDNF(booleanFunction.boolean_Function_TruthTable_interface, 4);
            //TextBoxContent.Text += "СДНФ для F(N2 = " + booleanFunction.N2 + ")" + '\n';
            //TextBoxContent.Text += CommonFunction.OneDimensionalArrOut(PDNF.row_table_name, 4);
            //TextBoxContent.Text += CommonFunction.TwoDimensionalArrOut(PDNF.variable_table, CommonFunction.CalculateArrSize(8, 4, 1, booleanFunction.boolean_Function_TruthTable_interface), 4);
            //TextBoxContent.Text += "СКНФ для F(N2 = " + booleanFunction.N2 + ")" + '\n';
            //TextBoxContent.Text += CommonFunction.OneDimensionalArrOut(PSNF.row_table_name, 4);
            //TextBoxContent.Text += CommonFunction.TwoDimensionalArrOut(PSNF.variable_table, CommonFunction.CalculateArrSize(8, 4, 0, booleanFunction.boolean_Function_TruthTable_interface), 4);
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        static bool menuIShidden = true;
        private void ButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            if (menuIShidden == true)
            {
                ButtonMenu.Margin = new Thickness(541, 10, 121, 402);
                GridMenu.Visibility = Visibility.Visible; 
                menuIShidden = false;
                ButtonMenuAdd.Visibility = Visibility.Visible;
                DataGridCommon.Visibility = Visibility.Visible;

                ButtonCalcPDNF.Visibility = Visibility.Hidden;
                ButtonPSNF.Visibility = Visibility.Hidden;
                ButtonSaveTXT.Visibility = Visibility.Hidden;
                ButtonTruthTable.Visibility = Visibility.Hidden;
            }
            else if (menuIShidden == false)
            {
                ButtonMenu.Margin = new Thickness(652, 10, 10, 402);
                GridMenu.Visibility = Visibility.Hidden;
                menuIShidden = true;
                ButtonMenuAdd.Visibility = Visibility.Hidden;
                DataGridCommon.Visibility = Visibility.Hidden;
                ButtonCalcPDNF.Visibility = Visibility.Visible;

                ButtonCalcPDNF.Visibility = Visibility.Visible;
                ButtonPSNF.Visibility = Visibility.Visible;
                ButtonSaveTXT.Visibility = Visibility.Visible;
                ButtonTruthTable.Visibility = Visibility.Visible;
            }
        }
        private void AddMore(object sender, RoutedEventArgs e)
        {
            indexList++;
            AddNewFunction addNewFunction = new AddNewFunction();
            addNewFunction.ShowDialog();
            list_boolean.Add(new BooleanFunction(indexList, AddNewFunction.Name_buff, AddNewFunction.N1_buff, AddNewFunction.N2_buff));
            var newItem = new XElement("Item",
                    new XAttribute("ID", indexList),
                    new XAttribute("Name", AddNewFunction.Name_buff),
                    new XAttribute("N1", AddNewFunction.N1_buff),
                    new XAttribute("N2", AddNewFunction.N2_buff));
            Document.Root.Add(newItem);;
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var newItem = new XElement("Item",
                    new XAttribute("ID", indexList),
                    new XAttribute("Name", "My boolean Function"),
                    new XAttribute("N1", 12),
                    new XAttribute("N2", 244));
            Document.Root.Add(newItem);
        }

        private void SCI(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(DataGridCommon.SelectedItem.ToString());
        }

        private void ButtonTruthTable_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(list_boolean[0].Name);
            string buff = "";
            list_boolean[0].CalculationTruthTable(list_boolean[0]);
            TextBoxName.Text = list_boolean[0].Name;
            TextBoxContent.Text = "";
            TextBoxContent.Text += "Таблица истенности для F(N1 = " + list_boolean[0].N1 + ", N2 = " + list_boolean[0].N2 + ")" + '\n';
            for (int n = 0; 5 > n; n++)
            {
                buff += "|" + '\t';
                buff += list_boolean[0].boolean_Function_TruthTable_interface.row_table_name[n];
                buff += '\t' + "|";
            }
            buff += '\n';
            TextBoxContent.Text += buff;
            buff = "";

            TextBoxContent.Text += CommonFunction.TwoDimensionalArrOut(list_boolean[0].boolean_Function_TruthTable_interface.variable_table, 8, 5);
        }
        private void ButtonCalcPDNF_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonSaveTXT_Click(object sender, RoutedEventArgs e)
        {
                
        }
        private void ButtonPSNF_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PSNF = list_boolean[0].CalculationPSNF(list_boolean[0].boolean_Function_TruthTable_interface, 3);
                TextBoxContent.Text += "СКНФ для F(N1 = " + list_boolean[0].N1 + ")" + '\n';
                TextBoxContent.Text += CommonFunction.OneDimensionalArrOut(PSNF.row_table_name, 4);
                TextBoxContent.Text += CommonFunction.TwoDimensionalArrOut(PSNF.variable_table, CommonFunction.CalculateArrSize(8, 3, 0, list_boolean[0].boolean_Function_TruthTable_interface), 4);

                PSNF = list_boolean[0].CalculationPSNF(list_boolean[0].boolean_Function_TruthTable_interface, 4);
                TextBoxContent.Text += "СКНФ для F(N2 = " + list_boolean[0].N2 + ")" + '\n';
                TextBoxContent.Text += CommonFunction.OneDimensionalArrOut(PSNF.row_table_name, 4);
                TextBoxContent.Text += CommonFunction.TwoDimensionalArrOut(PSNF.variable_table, CommonFunction.CalculateArrSize(8, 4, 0, list_boolean[0].boolean_Function_TruthTable_interface), 4);
            }
            catch
            {
                MessageBox.Show("Ошибка, требуется вычислить таблицу истенности!","Error");
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void ButtonHidden_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonMinimized_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
