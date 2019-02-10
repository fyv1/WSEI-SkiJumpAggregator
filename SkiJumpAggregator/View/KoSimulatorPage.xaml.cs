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
    /// Logika interakcji dla klasy KoSimulatorPage.xaml
    /// </summary>
    public partial class KoSimulatorPage : Page
    {
        KoViewModel ko = new KoViewModel();
        
        public KoSimulatorPage()
        {
            InitializeComponent();


            JumpersList.ItemsSource = ko.JumperList;


        }

       

        private void ReturnBtn_Click(object sender, RoutedEventArgs e)
        {

            this.NavigationService.Navigate(new MenuPage());

        }
    }
}
