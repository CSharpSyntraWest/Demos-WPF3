using Demos_controlsEnBinding.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos_controlsEnBinding.ViewModels
{
    class WerknemerVM : INotifyPropertyChanged
    {
        private DataOperaties _dataservice;
        private WerknemersCollectie _werknemers;
        public WerknemerVM()
        {
            _dataservice = new DataOperaties();
            _werknemers = _dataservice.GeefAlleWerknemers();
        }
        private int _recordIndex;
        public int RecordIndex
        {
            get { return _recordIndex; }
            set { _recordIndex = value;
                OnPropertyChanged(nameof(RecordIndex));
               }
        }
        public WerknemersCollectie Werknemers
        {
            get { return _werknemers; }
            set {
                _werknemers = value;
                OnPropertyChanged(nameof(Werknemers));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string pName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
            new PropertyChangedEventArgs(pName));
            }
        }
    }
}
