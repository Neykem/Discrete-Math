
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;
using System.Collections.Generic;
using System.IO;

namespace Discrete_Math
{
    public partial class MainWindow : Window
    {
        public XDocument Document { get; private set; }
        static List <BooleanFunction> list_boolean = new List<BooleanFunction>();
        private static int indexList = 0;
        private static int idSelect;
        static bool menuIShidden = true;
        static bool TruthTableIScalc = false;
        static bool psnfIScalc = false;
        static bool pdnfIScalc = false;
        static TruthTable PSNF = new TruthTable();
        static TruthTable PDNF = new TruthTable();
        public MainWindow()
        {
            try
            {
                string buff = "";
                idSelect = 0;
                InitializeComponent();
                Document = new XDocument(new XElement("Root"));
                list_boolean.Add(new BooleanFunction(indexList, "My boolean Function", 12, 244));
                DataContext = Document.Root;
                TextBoxName.Text = list_boolean[0].Name;
            }
            catch
            {
                MessageBox.Show("Ошибка иницализаций программы!", "Error 1");
            }
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
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
                ButtonClear.Visibility = Visibility.Hidden;
            }
            else if (menuIShidden == false)
            {
                ButtonMenu.Margin = new Thickness(652, 10, 10, 402);
                GridMenu.Visibility = Visibility.Hidden;
                menuIShidden = true;
                ButtonMenuAdd.Visibility = Visibility.Hidden;
                DataGridCommon.Visibility = Visibility.Hidden;

                ButtonCalcPDNF.Visibility = Visibility.Visible;
                ButtonPSNF.Visibility = Visibility.Visible;
                ButtonSaveTXT.Visibility = Visibility.Visible;
                ButtonTruthTable.Visibility = Visibility.Visible;
                ButtonClear.Visibility = Visibility.Visible;
            }
        }
        private void AddMore(object sender, RoutedEventArgs e)
        {
            try
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
                Document.Root.Add(newItem);
            }
            catch
            {
                MessageBox.Show("Ошибка добавления новой функций!", "Error 2");
            }
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                    var newItem = new XElement("Item",
                    new XAttribute("ID", indexList),
                    new XAttribute("Name", "My boolean Function"),
                    new XAttribute("N1", 12),
                    new XAttribute("N2", 244));
                    Document.Root.Add(newItem);
            }
            catch
            {
                MessageBox.Show("Ошибка иницализаций поля данных!", "Error 3");
            }
        }

        private void SCI(object sender, SelectionChangedEventArgs e)
        {
            try
            {
            idSelect = DataGridCommon.SelectedIndex;
            TextBoxName.Text = list_boolean[idSelect].Name;
            TextBoxContent.Clear();
                TruthTableIScalc = false;
                psnfIScalc = false;
                pdnfIScalc = false;
            }
            catch
            {
                MessageBox.Show("Ошибка при выборе элемента!", "Error 4");
            }
        }

        private void ButtonTruthTable_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TruthTableIScalc == false)
                {
                    //MessageBox.Show(list_boolean[idSelect].Name);
                    string buff = "";
                    list_boolean[idSelect].CalculationTruthTable(list_boolean[idSelect]);
                    TextBoxName.Text = list_boolean[idSelect].Name;
                    TextBoxContent.Text += "Таблица истинности для F(N1 = " + list_boolean[idSelect].N1 + ", N2 = " + list_boolean[idSelect].N2 + ")" + '\n';
                    for (int n = 0; 5 > n; n++)
                    {
                        buff += "|" + '\t';
                        buff += list_boolean[idSelect].boolean_Function_TruthTable_interface.row_table_name[n];
                        buff += '\t' + "|";
                    }
                    buff += '\n';
                    TextBoxContent.Text += buff;
                    buff = "";

                    TextBoxContent.Text += CommonFunction.TwoDimensionalArrOut(list_boolean[idSelect].boolean_Function_TruthTable_interface.variable_table, 8, 5);
                    TruthTableIScalc = true;
                }
                else
                {
                    MessageBox.Show("Таблица истинности уже вычислена!","Предупреждение");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при вычислений таблицы истенности!", "Error 5");
            }
        }
        private void ButtonCalcPDNF_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (pdnfIScalc == false)
                {
                    PDNF = list_boolean[idSelect].CalculationPDNF(list_boolean[idSelect].boolean_Function_TruthTable_interface, 3);
                    TextBoxContent.Text += "СДНФ для F(N1 = " + list_boolean[idSelect].N1 + ")" + '\n';
                    TextBoxContent.Text += CommonFunction.OneDimensionalArrOut(PDNF.row_table_name, 4);
                    TextBoxContent.Text += CommonFunction.TwoDimensionalArrOut(PDNF.variable_table, CommonFunction.CalculateArrSize(8, 3, 1, list_boolean[idSelect].boolean_Function_TruthTable_interface), 4);

                    PDNF = list_boolean[idSelect].CalculationPDNF(list_boolean[idSelect].boolean_Function_TruthTable_interface, 4);
                    TextBoxContent.Text += "СДНФ для F(N2 = " + list_boolean[idSelect].N2 + ")" + '\n';
                    TextBoxContent.Text += CommonFunction.OneDimensionalArrOut(PDNF.row_table_name, 4);
                    TextBoxContent.Text += CommonFunction.TwoDimensionalArrOut(PDNF.variable_table, CommonFunction.CalculateArrSize(8, 4, 1, list_boolean[idSelect].boolean_Function_TruthTable_interface), 4);
                    pdnfIScalc = true;
                }
                else
                {
                    MessageBox.Show("Таблица СДНФ уже вычислена!", "Предупреждение");
                }
            }
            catch
            {
                if (TruthTableIScalc == false)
                {
                    MessageBox.Show("Ошибка, требуется вычислить таблицу истенности!", "Предупеждение");
                }
                else
                {
                    MessageBox.Show("Ошибка при вычислений таблицы СДНФ!", "Error 6");
                }
            }
        }
        private void ButtonSaveTXT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
                dialog.FileName = "SelectDocumentFormOutput"; // Default file name
                dialog.DefaultExt = ".text"; // Default file extension
                dialog.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

                // Show save file dialog box
                Nullable<bool> result = dialog.ShowDialog();

                // Process save file dialog box results
                if (result == true)
                {
                    // Save document
                    string filename = dialog.FileName;
                    File.WriteAllText(dialog.FileName, TextBoxContent.Text);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка, при записи в файл!", "Error");
            }
        }
    private void ButtonPSNF_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (psnfIScalc == false)
                {
                PSNF = list_boolean[idSelect].CalculationPSNF(list_boolean[idSelect].boolean_Function_TruthTable_interface, 3);
                TextBoxContent.Text += "СКНФ для F(N1 = " + list_boolean[idSelect].N1 + ")" + '\n';
                TextBoxContent.Text += CommonFunction.OneDimensionalArrOut(PSNF.row_table_name, 4);
                TextBoxContent.Text += CommonFunction.TwoDimensionalArrOut(PSNF.variable_table, CommonFunction.CalculateArrSize(8, 3, 0, list_boolean[idSelect].boolean_Function_TruthTable_interface), 4);

                PSNF = list_boolean[idSelect].CalculationPSNF(list_boolean[idSelect].boolean_Function_TruthTable_interface, 4);
                TextBoxContent.Text += "СКНФ для F(N2 = " + list_boolean[idSelect].N2 + ")" + '\n';
                TextBoxContent.Text += CommonFunction.OneDimensionalArrOut(PSNF.row_table_name, 4);
                TextBoxContent.Text += CommonFunction.TwoDimensionalArrOut(PSNF.variable_table, CommonFunction.CalculateArrSize(8, 4, 0, list_boolean[idSelect].boolean_Function_TruthTable_interface), 4);
                psnfIScalc = true;
                }
                else
                {
                    MessageBox.Show("Таблица СДНФ уже вычислена!", "Предупреждение");
                }
            }
            catch
            {
                if (TruthTableIScalc == false)
                {
                    MessageBox.Show("Ошибка, требуется вычислить таблицу истенности!", "Предупеждение");
                }
                else
                {
                    MessageBox.Show("Ошибка при вычислений таблицы СКНФ!", "Error 7");
                }
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

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            TextBoxContent.Clear();
            TruthTableIScalc = false;
            psnfIScalc = false;
            pdnfIScalc = false;
        }
    }
}
