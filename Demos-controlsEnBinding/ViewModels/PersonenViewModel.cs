using Demos_controlsEnBinding.Models;
using Demos_controlsEnBinding.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos_controlsEnBinding.ViewModels
{
    public class PersonenViewModel: ObservableObject
    {
        private ObservableCollection<Persoon> _personen;
        public PersonenViewModel()
        {
            _personen = new ObservableCollection<Persoon>();
            _personen.Add(new Persoon() { VoorNaam = "Jan", FamilieNaam = "Jansen" });
            _personen.Add(new Persoon() { VoorNaam = "Piet", FamilieNaam = "Piet" });
            _personen.Add(new Persoon() { VoorNaam = "Joris", FamilieNaam = "Kornelis" });
        }
        public ObservableCollection<Persoon> Personen
        {
            get {
                return _personen;
            }
            set {
                _personen = value;
                NotifyPropertyChanged();
            }
        }
    }
}
