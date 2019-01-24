using System;
using System.ComponentModel;

namespace SkiJumpAggregator.Model
{
    public class WindCalculatorModel : INotifyPropertyChanged
    {

        private void Formula(int HS, double avgSpeed)
        {
            
        }

        private void RoundUp(double score)
        {
            // use score from Formula()
            
        }

        private void PointsFromHS(int HS)
        {
            // use switch case with pattern from wiki
            
        }

        public double CalculateToPoints(double score)
        {
            // return points from RoundUp() divided by PointsFromHS()
            return;
        }



        public event PropertyChangedEventHandler PropertyChanged;
    }
}
