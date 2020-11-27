using Demos_controlsEnBinding.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demos_controlsEnBinding.Models
{
    public class Persoon: ObservableObject
    {
        private string _voorNaam;
        private string _familieNaam;
        public string VoorNaam { get { return _voorNaam; }

            set {
                _voorNaam = value;
                NotifyPropertyChanged();
            }
        }
        public string FamilieNaam { get { return _familieNaam; }

            set {
                _familieNaam = value;
                NotifyPropertyChanged();
            }
        }
    }
}
