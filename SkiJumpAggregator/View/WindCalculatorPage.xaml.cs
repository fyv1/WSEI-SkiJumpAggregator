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
        WindCalculatorViewModel windCalculatorViewModel = new WindCalculatorViewModel();
        public WindCalculatorPage()
        {

            InitializeComponent();
            
            this.DataContext = this;
        }

        private void ReturnBtn_Click(object sender, RoutedEventArgs e)
        {

            this.NavigationService.Navigate(new MenuPage());

        }

     

       private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                windCalculatorViewModel.InputHs = Int32.Parse(HSin.Text);
                windCalculatorViewModel.InputK = Int32.Parse(Kin.Text);
                windCalculatorViewModel.InputAvgSpeed = Convert.ToDouble(Avgin.Text);
                windCalculatorViewModel.CalculateButtonPressed();
            }
            catch //(IncorrectDataException e)
            {
                MessageBox.Show("Wystąpił błąd - podaj prawidłowe dane", "Błędne dane!");
                // MessageBox.Show(e.Message, "Błędne dane!");
                this.DataContext = this;
            }
           

            this.DataContext = windCalculatorViewModel;

        }


    }
}
