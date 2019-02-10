using System;
using System.ComponentModel;

namespace SkiJumpAggregator.Model
{
    public class KoSimulatorModel : INotifyPropertyChanged
    {

        public KoSimulatorModel()
        {
            _FISretrieverModel fr = new _FISretrieverModel();

        }
        
        
        

        public event PropertyChangedEventHandler PropertyChanged;
        
    }
}
