using System;
using System.ComponentModel;

namespace SkiJumpAggregator.Model
{
    public class WindCalculatorModel : INotifyPropertyChanged
    {
        private double score{get; set;}
        private double points{get; set;}

        private double Formula(int HS, double avgSpeed)
        {
            return score = avgSpeed * (HS - 36)/20;
        }

        private double RoundUp(double score)
        {
          return Math.Round(score * 2, MidpointRounding.AwayFromZero) / 2;
        }

        private double PointsFromK(int K)
        {
            if (K >= 20 && K <= 25 ) {
                return 4.8;
            }
            else if (K >= 26 && K <= 30 ){
                return 4.4;
            }
            else if (K >= 31 && K <= 34 ){
                return 4;
            }
            else if (K >= 35 && K <= 39 ){
                return 3.6;
            }
            else if (K >= 40 && K <= 49 ){
                return 3.2;
            }
            else if (K >= 50 && K <= 59 ){
                return 2.8;
            }
                else if (K >= 60 && K <= 69 ){
                return  2.4;
            }
            else if (K >= 70 && K <= 79 ){
                return 2.2;
            }
            else if (K >= 80 && K <= 99 ){
                return 2.0;
            }
            else if (K >= 100 && K <= 169 ){
                return 1.8;
            }
            else if (K >= 170){
                return 1.2;
            }
            else throw new HillTooSmallException("Skocznia za mała");

        }
            //use switch case with pattern from wiki
            
        

        
        public double CalculateToPoints(int K, int HS, double avgSpeed)
        {
            //return points from RoundUp() divided by PointsFromHS();

            
            return RoundUp(Formula(HS, avgSpeed)) / PointsFromK(K);
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
