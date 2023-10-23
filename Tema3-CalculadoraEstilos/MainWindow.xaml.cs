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

namespace Tema3_CalculadoraEstilos
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (button.Equals(boton1))
                recuadroMuestraNumero.Text += "1";
            else if (button.Equals(boton2))
                recuadroMuestraNumero.Text += "2";
            else if (button.Equals(boton3))
                recuadroMuestraNumero.Text += "3";
            else if (button.Equals(boton4))
                recuadroMuestraNumero.Text += "4";
            else if (button.Equals(boton5))
                recuadroMuestraNumero.Text += "5";
            else if (button.Equals(boton6))
                recuadroMuestraNumero.Text += "6";
            else if (button.Equals(boton7))
                recuadroMuestraNumero.Text += "7";
            else if (button.Equals(boton8))
                recuadroMuestraNumero.Text += "8";
            else if (button.Equals(boton9))
                recuadroMuestraNumero.Text += "9";
            else if (button.Equals(boton0))
                recuadroMuestraNumero.Text += "0";


        }
    }
}
