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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ПР26._02._2024
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double x = 0;
        double y = 0;
        double z = 0;

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            x = Convert.ToDouble(InputX.Text);
            y = Convert.ToDouble(InputY.Text);
            z = Convert.ToDouble(InputZ.Text);
            double a = 0;
            CalculateAnswer.Items.Clear();
            a = Math.Log(Math.Pow(y, -Math.Sqrt(Math.Abs(x)))) * (x - (y / 2) + Math.Pow(Math.Sin(Math.Atan(z)), 2));
            CalculateAnswer.Items.Add("ПР№3 Волков А.П.");
            CalculateAnswer.Items.Add($"X = {x}");
            CalculateAnswer.Items.Add($"Y = {y}");
            CalculateAnswer.Items.Add($"Z = {z}");
            CalculateAnswer.Items.Add($"Результат a = {a}");
        }
    }
}
