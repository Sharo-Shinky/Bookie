using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_Bookie
{
    public class BoekStruct
    {
        int Id { get; }
        string Titel { get; }
        int Bladzijdes { get; }
        int Beoordeling { get; }
        int Volgnummer { get; }
        int GelezenInJaar { get; }
        int Status { get; }
        string Taal { get; }
        string Opmerking { get; }

        public BoekStruct(string titel, int bladzijdes, int beoordeling, int volgnummer, int gelezenInJaar, int status, string taal, string opmerking)
        {
            Titel = titel;
            Bladzijdes = bladzijdes;
            Beoordeling = beoordeling;
            Volgnummer = volgnummer;
            GelezenInJaar = gelezenInJaar;
            Status = status;
            Taal = taal;
            Opmerking = opmerking;
        }

        public BoekStruct(int id, string titel, int bladzijdes, int beoordeling, int volgnummer, int gelezenInJaar, int status, string taal, string opmerking)
        {
            Id = id;
            Titel = titel;
            Bladzijdes = bladzijdes;
            Beoordeling = beoordeling;
            Volgnummer = volgnummer;
            GelezenInJaar = gelezenInJaar;
            Status = status;
            Taal = taal;
            Opmerking = opmerking;
        }
    }
}
