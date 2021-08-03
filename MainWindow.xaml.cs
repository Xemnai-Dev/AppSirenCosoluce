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

namespace AppSiren
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

        private void VerifySiren(object sender, RoutedEventArgs e)
        {
            Siren siren = new Siren(SirenInput.Text);
          
            if (siren.IsValid)
                MessageBox.Show("Siren Valide! ", "Valide ?");
            else
                MessageBox.Show("Siren Invalide! ", "Valide ?");
        }

        private void VerifySiret(object sender, RoutedEventArgs e)
        {
            Siret siret = new Siret(SirenInput.Text);

            if (siret.IsValid)
                MessageBox.Show("Siret Valide! ", "Valide ?");
            else
                MessageBox.Show("Siret Invalide! ", "Valide ?");
        }
    }
}
