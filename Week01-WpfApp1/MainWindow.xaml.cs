using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week01_WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"貓咪名稱：{name.Text}\n電話：{telephone.Text}");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(text_value.Text, out int n) && n > 0)
            {
                string result = "";

                
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        result += $"{i} x {j} = {i * j,-12}";
                    }
                    result += "\n";
                }

                
                value_tabel.Text = result;
            }
            else
            {
                value_tabel.Text = "請輸入大於 0 的數字！";
            }

        }

        
    }
}