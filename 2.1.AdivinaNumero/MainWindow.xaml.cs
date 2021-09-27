using System;
using System.Windows;

namespace _2._1.AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numeroAleatorio;

        public MainWindow()
        {
            InitializeComponent();
            numeroAleatorio = new Random().Next(0, 101);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//Boton que comprueba el numero introducido
        {
            if (Entrada.Text.Equals(numeroAleatorio.ToString()))
            {
                MessageBox.Show("Has hacertado el número es: " + numeroAleatorio);
            }
            else
            {
                if (Convert.ToInt32(Entrada.Text) < numeroAleatorio)
                {
                    MessageBox.Show("Has fallado, el número es mayor");
                }
                else
                {
                    MessageBox.Show("Has fallado, el número es menor"); 
                }

            }
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)//Boton que cambia el número
        {
            numeroAleatorio = new Random().Next(0, 101);
            MessageBox.Show("El número ha sido cambiado");
        }
    }
}
