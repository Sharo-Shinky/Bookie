using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_Bookie;

namespace DAL_Bookie
{
    public class GenreSqlContext : IGenreContext
    {

        public List<GenreStruct> GetAllGenres()
        {
            throw new NotImplementedException();
        }

        public GenreStruct GetGenreById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateGenre(GenreStruct genre)
        {
            throw new NotImplementedException();
        }

        public void VerwijderGenre(int id)
        {
            throw new NotImplementedException();
        }

        public void VoegGenreToe(GenreStruct genre)
        {
            throw new NotImplementedException();
        }
    }
}
