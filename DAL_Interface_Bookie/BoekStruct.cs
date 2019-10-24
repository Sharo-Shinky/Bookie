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
    }
}
