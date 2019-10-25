using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_Bookie
{
    public class GenreStruct
    {
        public int Id { get; private set; }
        public string Naam { get; private set; }

        public GenreStruct(string naam)
        {
            Naam = naam;
        }

        public GenreStruct(int id, string naam)
        {
            Id = id;
            Naam = naam;
        }
    }
}
