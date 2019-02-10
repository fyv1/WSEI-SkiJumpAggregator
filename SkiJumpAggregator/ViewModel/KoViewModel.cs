using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkiJumpAggregator.Model;
using System.Diagnostics;

namespace SkiJumpAggregator.ViewModel
{
    class KoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private _FISretrieverModel fr = new _FISretrieverModel();

        public ObservableCollection<SkiJumper> JumperList { get; set; }
        //public ObservableCollection<Competition> JumperList { get; set; }


        public KoViewModel()
        {
            JumperList = new ObservableCollection<SkiJumper>(fr.getSkiJumpers());
        }

    }
}
