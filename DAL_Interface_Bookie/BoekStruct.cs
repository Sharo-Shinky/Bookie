using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_Bookie
{
    public class BoekStruct
    {
        public int Id { get; private set; }
        public string Titel { get; private set; }
        public int Bladzijdes { get; private set; }
        public int Beoordeling { get; private set; }
        public int Volgnummer { get; private set; }
        public int GelezenInJaar { get; private set; }
        public int Status { get; private set; }
        public string Taal { get; private set; }
        public string Opmerking { get; private set; }

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
