using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos_controlsEnBinding.ViewModels
{
    public class DatumViewModel : INotifyPropertyChanged
    {
        public DatumViewModel()
        {
            _startDate = new DateTime(2020, 12, 12);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private DateTime _startDate;
        public DateTime StartDate
        {
            get { return _startDate; }
            set {
                _startDate = value;
                OnPropertyChanged(nameof(StartDate));
                Debug.WriteLine(_startDate.ToShortDateString());
            }
        }
      
        private void OnPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

    }
}
