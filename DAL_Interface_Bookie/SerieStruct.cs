using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_Bookie
{
    public class SerieStruct
    {
        int Id { get; }
        string Titel { get; }

        public SerieStruct(string titel)
        {
            Titel = titel;
        }

        public SerieStruct(int id, string titel)
        {
            Id = id;
            Titel = titel;
        }
    }
}
