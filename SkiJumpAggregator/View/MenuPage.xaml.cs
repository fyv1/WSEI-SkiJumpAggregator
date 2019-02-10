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

namespace SkiJumpAggregator.View
{
    /// <summary>
    /// Logika interakcji dla klasy MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void WindCalcBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new WindCalculatorPage());
        }

        private void KoBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new KoSimulatorPage());
        }
    }
}
