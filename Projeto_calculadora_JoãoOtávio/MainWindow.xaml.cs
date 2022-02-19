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

namespace Projeto_calculadora_JoãoOtávio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int valor = 0;
        string operacao;
        int ultimoValor = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void igual_Click(object sender, RoutedEventArgs e)
        {
            string operacao1 = operacao;
            switch (operacao1) 
            {

                case "+":
                    
                    valor = valor + ultimoValor;
                    saida.Text = "" + valor;
                break;
                
                case "-":

                    valor = valor - ultimoValor;
                    saida.Text = "" + valor;
                    break;
                case "/":

                    valor = valor / ultimoValor;
                    saida.Text = "" + valor;
                    break;
                case "*":

                    valor = valor * ultimoValor;
                    saida.Text = "" + valor;
                    break;
            }
        }

        private void clear_button_Click(object sender, RoutedEventArgs e)
        {

                
            result.Text = "";            
            
            saida.Text = "";
                
            valor = 0;

            
        }

        private void soma_Click(object sender, RoutedEventArgs e)
        {
            if (result.Text != "")
            {
                ultimoValor = int.Parse(result.Text);
                valor = valor + ultimoValor;
                saida.Text = "" + valor;
                result.Text = "";
                operacao = "+";
                
            }

        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            if (result.Text != "")
            {
                ultimoValor = int.Parse(result.Text);
                valor = valor - ultimoValor;
                saida.Text = "" + valor;
                result.Text = "";
                operacao = "-";
            }
        }

        private void divisao_Click(object sender, RoutedEventArgs e)
        {
            if (result.Text != "")
            {
                ultimoValor = int.Parse(result.Text);
                valor = valor / ultimoValor;
                saida.Text = "" + valor;
                result.Text = "";
                operacao = "/";

            }
        }
        
        private void mult_Click(object sender, RoutedEventArgs e)
        {
            if (result.Text != "")
            {
                ultimoValor = int.Parse(result.Text);
                valor = valor * ultimoValor;
                saida.Text = "" + valor;
                result.Text = "";
                operacao = "*";

            }
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "0";
            
        }

        private void um_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "1";

        }

        private void dois_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "2";

        }

        private void tres_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "3";

        }

        private void quatro_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "4";

        }

        private void cinco_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "5";

        }

        private void seis_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "6";

        }

        private void sete_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "7";

        }

        private void oito_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "8";

        }

        private void nove_Click(object sender, RoutedEventArgs e)
        {
            result.Text += "9";

        }
    }
}
