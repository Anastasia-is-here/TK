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

namespace TK
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

  
        public string mark(string _gr1, string _gr2, string _gr3)
        {
            int gr1, gr2, gr3, sum = 0;
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_gr1))
            {
                errors.AppendLine("Введите первую оценку");
            }
            else if (!Int32.TryParse(_gr1, out gr1))
            {
                errors.AppendLine("Неверный формат ввода первой оценки");
            }
            else if (gr1 < 0 || gr1 > 22)
            {
                errors.AppendLine("Значение первой оценки выходит за допустимые границы");
            }
            else sum += gr1;


            if (string.IsNullOrWhiteSpace(_gr2))
            {
                errors.AppendLine("Введите вторую оценку");
            }
            else if (!Int32.TryParse(_gr2, out gr2))
            {
                errors.AppendLine("Неверный формат ввода второй оценки");
            }
            else if (gr2 < 0 || gr2 > 38)
            {
                errors.AppendLine("Значение второй оценки выходит за допустимые границы");
            }
            else sum += gr2;

            if (string.IsNullOrWhiteSpace(_gr3))
            {
                errors.AppendLine("Введите третью оценку");
            }
            else if (!Int32.TryParse(_gr3, out gr3))
            {
                errors.AppendLine("Неверный формат ввода третьей оценки");
            }
            else if (gr3 < 0 || gr3 > 20)
            {
                errors.AppendLine("Значение третьей оценки выходит за допустимые границы");
            }
            else sum += gr3;


            if (errors.Length != 0)
            {
                MessageBox.Show(errors.ToString());
                return "ошибка";
            }



            if (sum >= 0 && sum <= 15)
            {
                return "2\n(неудовлетворительно)";
            }
            else if (sum >= 16 && sum <= 31)
            {
                return "3\n(удовлетворительно)";
            }
            else if (sum >= 32 && sum <= 55)
            {
                return "4\n(хорошо)";
            }
            else if (sum >= 56 && sum <= 80)
            {
                return "5\n(отлично)";
            }

            return "";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = mark(Grade1.Text, Grade2.Text, Grade3.Text);
        }
    }
}
