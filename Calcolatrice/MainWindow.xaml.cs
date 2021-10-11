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

namespace Calcolatrice
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

        private void btnSomma_Click(object sender, RoutedEventArgs e)
        {
            int primoNumero, secondoNumero;
            if (txtNum1.Text != "" && txtNum2.Text != "")
            {
                try
                {
                    primoNumero = int.Parse(txtNum1.Text);
                    secondoNumero = int.Parse(txtNum2.Text);
                    lblRisultato.Content = primoNumero + secondoNumero;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "errore", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("inserisci tutti i dati richiesti", "attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                lblRisultato.Content = "";
                txtNum1.Clear();
                txtNum2.Clear();
                txtNum1.Focus();

            }
        }

        private void btnSottrazione_Click(object sender, RoutedEventArgs e)
        {
            int primoNumero, secondoNumero;
            if (txtNum1.Text != "" && txtNum2.Text != "")
            {
                try
                {
                    primoNumero = int.Parse(txtNum1.Text);
                    secondoNumero = int.Parse(txtNum2.Text);
                    lblRisultato.Content = primoNumero - secondoNumero;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "errore", MessageBoxButton.OK, MessageBoxImage.Warning);
                }


            }
            else
            {
                MessageBox.Show("inserisci tutti i dati richiesti", "attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                lblRisultato.Content = "";
                txtNum1.Clear();
                txtNum2.Clear();
                txtNum1.Focus();

            }
        }

        private void btnProdotto_Click(object sender, RoutedEventArgs e)
        {
            int primoNumero, secondoNumero;
            if (txtNum1.Text != "" && txtNum2.Text != "")
            {
                try
                {
                    primoNumero = int.Parse(txtNum1.Text);
                    secondoNumero = int.Parse(txtNum2.Text);
                    lblRisultato.Content = primoNumero * secondoNumero;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "errore", MessageBoxButton.OK, MessageBoxImage.Warning);
                }


            }
            else
            {
                MessageBox.Show("inserisci tutti i dati richiesti", "attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                lblRisultato.Content = "";
                txtNum1.Clear();
                txtNum2.Clear();
                txtNum1.Focus();

            }
        }

        private void btnDivisione_Click(object sender, RoutedEventArgs e)
        {
            int primoNumero, secondoNumero;
            if (txtNum1.Text != "" && txtNum2.Text != "")
            {

                try
                {
                    primoNumero = int.Parse(txtNum1.Text);
                    secondoNumero = int.Parse(txtNum2.Text);
                    lblRisultato.Content = primoNumero / secondoNumero;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "errore", MessageBoxButton.OK, MessageBoxImage.Warning);
                }


            }
            else
            {
                MessageBox.Show("inserisci tutti i dati richiesti", "attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                lblRisultato.Content = "";
                txtNum1.Clear();
                txtNum2.Clear();
                txtNum1.Focus();

            }
        }
    }
}
