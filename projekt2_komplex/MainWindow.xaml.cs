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
using System.Windows.Threading;

namespace projekt2_komplex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int idoSzam = new int();
        DispatcherTimer idozito;
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
            idozito = new DispatcherTimer();
            idozito.Interval = TimeSpan.FromSeconds(0.001);
            idozito.Tick += new EventHandler(IdozitoFeladata);

            ujFutam.IsEnabled = false;
        }

        private void IdozitoFeladata(object sender, EventArgs e)
        {
            int spongyaSebesseg = rnd.Next(1 , 3);
            int kapitanySebesseg = rnd.Next(1, 3);
            int sosigSebesseg = rnd.Next(1, 3);
            
            ++idoSzam;
            spongya.Margin = new Thickness(idoSzam * 1, 0, 0, 0);
            kapitany.Margin = new Thickness(idoSzam * 1, 63, 0, 0);
            sosig.Margin = new Thickness(idoSzam * 1, 202, 0, 0);

            if (spongya.Margin.Left >= celVonal.Margin.Left - 120)
            {
                spongya.Margin = new Thickness(celVonal.Margin.Left - 120, spongya.Margin.Top, 0, 0);
            }
            if (kapitany.Margin.Left >= celVonal.Margin.Left - 90)
            {
                kapitany.Margin = new Thickness(celVonal.Margin.Left - 90, kapitany.Margin.Top, 0, 0);
            }
            if (sosig.Margin.Left >= celVonal.Margin.Left - 70)
            {
                sosig.Margin = new Thickness(celVonal.Margin.Left - 70, sosig.Margin.Top, 0, 0);
            }

        }

        

        

        private void startGomb_Click_1(object sender, RoutedEventArgs e)
        {
            idozito.Start();
            startGomb.IsEnabled = false;
            ujFutam.IsEnabled = false;
        }

        private void ujFutam_Click(object sender, RoutedEventArgs e)
        {
            spongya.Margin = new Thickness(idoSzam * 10, 0, 0, 0);
            kapitany.Margin = new Thickness(idoSzam * 33, 63, 0, 0);
            sosig.Margin = new Thickness(idoSzam * 54, 202, 0, 0);
        }
    }
}
