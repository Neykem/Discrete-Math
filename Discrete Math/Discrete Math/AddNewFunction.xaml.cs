using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Discrete_Math
{
    /// <summary>
    /// Логика взаимодействия для AddNewFunction.xaml
    /// </summary>
    public partial class AddNewFunction : Window
    {
        public static int ID_buff;
        public static string Name_buff;
        public static int N1_buff;
        public static int N2_buff;
        public AddNewFunction()
        {
            InitializeComponent();
        }

        private void TextBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxN1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_N2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonClickAdd(object sender, RoutedEventArgs e)
        {
            try
            {
                Name_buff = TextBoxName.Text;
                N1_buff = Convert.ToInt32(TextBoxN1.Text);
                N2_buff = Convert.ToInt32(TextBoxN2.Text);
            }
            catch
            {
                MessageBox.Show("Вводите только целые числа!");
                TextBoxN1.Text = "";
                TextBoxN2.Text = "";
            }
            this.Close();
        }
    }
}
