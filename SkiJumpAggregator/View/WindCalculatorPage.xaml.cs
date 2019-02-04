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
using SkiJumpAggregator.ViewModel;

namespace SkiJumpAggregator.View
{
    /// <summary>
    /// Logika interakcji dla klasy WindCalculatorPage.xaml
    /// </summary>
    public partial class WindCalculatorPage : Page
    {
        public WindCalculatorPage()
        {

            InitializeComponent();
            
        }

        private void ReturnBtn_Click(object sender, RoutedEventArgs e)
        {

            this.NavigationService.Navigate(new MenuPage());

        }

        // TODO: fix DataContext

       /* private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            WindCalculatorViewModel windCalculatorViewModel = new WindCalculatorViewModel();
            this.DataContext = windCalculatorViewModel;
            windCalculatorViewModel.CalculateButtonPressed();

            
        }*/

    }
}
