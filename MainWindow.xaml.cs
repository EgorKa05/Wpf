using System;
using System.Windows;

namespace WpfApplication1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = 1;
                double b = 100000;
                int n = 100000;

                // f(x) = 2x - ln(2x) + 234
                Func<double, double> f = (x) => x*x;

                string method = (cmbMethod.SelectedItem as System.Windows.Controls.ComboBoxItem).Content.ToString();

                MyCalculator calculator;

                if (method.Contains("средних"))
                    calculator = new MiddleRectangles();
                else
                    calculator = new Trapecia(); // по умолчанию трапеции

                double result = calculator.Calculate(a, b, n, f);

                txtResult.Text = $"Метод: {method}\nРезультат: {result:F6}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}