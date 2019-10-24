using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_Bookie
{
    public class AuteurStruct
    {
        int Id { get; }
        string VoorNaam { get; }
        string AchterNaam { get; }

        public AuteurStruct(string voorNaam, string achterNaam)
        {
            VoorNaam = voorNaam;
            AchterNaam = achterNaam;
        }

        public AuteurStruct(int id, string voorNaam, string achterNaam)
        {
            Id = id;
            VoorNaam = voorNaam;
            AchterNaam = achterNaam;
        }
    }
}
