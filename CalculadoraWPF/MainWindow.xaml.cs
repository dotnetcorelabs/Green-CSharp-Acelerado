using CalculadoraWPF.ViewModels;
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

namespace CalculadoraWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private event EventHandler<string> OnNumberChanged;

        private string numeroAtual;
        public string NumeroAtual
        {
            get
            {
                return numeroAtual;
            }
            set
            {
                numeroAtual = value;
                OnNumberChanged?.Invoke(this, numeroAtual);
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MainViewModel();

            ///OnNumberChanged += MainWindow_OnNumberChanged;
        }

        private void MainWindow_OnNumberChanged(object sender, string e)
        {
            Resultado.Text = e;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NumeroAtual = "1";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NumeroAtual = "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NumeroAtual = "3";
        }
    }
}
