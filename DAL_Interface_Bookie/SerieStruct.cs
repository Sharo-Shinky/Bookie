using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_Bookie
{
    public class SerieStruct
    {
        public int Id { get; private set; }
        public string Titel { get; private set; }

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
