using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using SkiJumpAggregator.Model;
using System.Windows.Controls;

namespace SkiJumpAggregator.ViewModel
{
    class WindCalculatorViewModel : INotifyPropertyChanged
    {
        private Model.WindCalculatorModel windCalculator;

        public string CalculatedPointsProperty { get; set; }
        private int kPoint;
        private int HsPoint;
        private double avgSpeed;



        public int InputK
        {
            get { return this.kPoint; }
            set { this.kPoint = value;  }
        }

        public int InputHs
        {
            get { return this.HsPoint; }
            set { this.HsPoint = value; }
        }
        public double InputAvgSpeed
        {
            get { return this.avgSpeed; }
            set { this.avgSpeed = value; }
        }


        public WindCalculatorViewModel()
        {
            this.windCalculator = new WindCalculatorModel();

        }
        
        

        public void CalculateButtonPressed()
        {
           this.CalculatedPointsProperty = windCalculator.CalculateToPoints(InputK, InputHs, InputAvgSpeed).ToString();

         //   this.CalculatedPointsProperty = windCalculator.CalculateToPoints(200, 250, 1.0d).ToString();

        }

        public event PropertyChangedEventHandler PropertyChanged;


    }
}
