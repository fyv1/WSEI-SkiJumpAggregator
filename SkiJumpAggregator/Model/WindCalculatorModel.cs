using System;
using System.ComponentModel;

namespace SkiJumpAggregator.Model
{
    public class WindCalculatorModel : INotifyPropertyChanged
    {
        private double score{get; set;}
        private double points{get; set;}

        private void Formula(int HS, double avgSpeed)
        {
            score = avgSpeed * (HS - 36)/20;
        }

        private void RoundUp(double score)
        {
          score += Math.Round(score * 2, MidpointRounding.AwayFromZero) / 2;
        }
        private double PointsFromHS(int HS, int K)
       
        {
                if (K >= 20 && K <= 25 ) {
                    points = 4.8;
                }
                else if (K >= 26 && K <= 30 ){
                    points = 4.4;
                }
                else if (K >= 31 && K <= 34 ){
                    points = 4;
                }
                  else if (K >= 35 && K <= 39 ){
                    points = 3.6;
                }
                  else if (K >= 40 && K <= 49 ){
                    points = 3.2;
                }
                  else if (K >= 50 && K <= 59 ){
                    points = 2.8;
                }
                  else if (K >= 60 && K <= 69 ){
                    points =  2.4;
                }
                  else if (K >= 70 && K <= 79 ){
                    points = 2.2;
                }
                else if (K >= 80 && K <= 99 ){
                    points = 2.0;
                }
                else if (K >= 100 && K <= 169 ){
                    points = 1.8;
                }
                else if (K >= 170){
                    points = 1.2;
                }
           }
            //use switch case with pattern from wiki
            
        

        
        public double CalculateToPoints(double score)
        {
            //return points from RoundUp() divided by PointsFromHS();
            return score / points;
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
    }
