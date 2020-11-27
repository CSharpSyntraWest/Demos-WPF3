using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos_controlsEnBinding.Models
{
    public class WerknemersCollectie:ObservableCollection<Werknemer>
    {
        public WerknemersCollectie()
        {
            Add(new Werknemer() { IdWerknemer = 1, Naam = "Jan Jansen", Salaris = 2500.00, Functie = "Developer" });
            Add(new Werknemer() { IdWerknemer = 2, Naam = "Piet Pieters", Salaris = 5000.00, Functie = "Manager" });
            Add(new Werknemer() { IdWerknemer = 3, Naam = "Jos De Klos", Salaris = 1500.00, Functie = "Secretaris" });
        }
    }
}
