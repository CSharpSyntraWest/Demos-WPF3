using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos_controlsEnBinding.Models
{
    public class DataOperaties
    {
        private WerknemersCollectie _werknemers;
        public DataOperaties()
        {
            _werknemers = new WerknemersCollectie();
        }
        public WerknemersCollectie GeefAlleWerknemers()
        {
            return _werknemers;
        }
        public WerknemersCollectie VoegWerknemerToe()
        {
            int newId = _werknemers.Count;
            _werknemers.Add(new Werknemer() { IdWerknemer=newId,Naam="N/A",Salaris=1000,Functie="N/A"});
            return _werknemers;
        }

        public WerknemersCollectie VerwijderWerknemer(int index)
        {
            _werknemers.RemoveAt(index);
            return _werknemers;
        }
    }
}
