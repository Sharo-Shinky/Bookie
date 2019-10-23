using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Interface_Bookie
{
    public interface IBoek
    {
        string Titel { get; }
        int Bladzijdes { get; }
        int Beoordeling { get; }
        int Volgnummer { get; }
        int GelezenInJaar { get; }
        //ENUM STATUS MOET NOG TOEGEVOEGD WORDEN....IN 1 LAAG OF IN APARTE LAAG?
        string Taal { get; }
        string Opmerking { get; }
        void UpdateBoek(IBoek boek);
    }
}
