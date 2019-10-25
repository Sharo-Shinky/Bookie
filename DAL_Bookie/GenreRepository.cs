using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_Bookie;

namespace DAL_Bookie
{
    public class GenreRepository : IGenreRepository, IGenreCollectieRepository
    {
        private IGenreContext GenreContext;

        public GenreRepository(IGenreContext genreContext)
        {
            GenreContext = genreContext;
        }

        public List<GenreStruct> GetAllGenres() => GenreContext.GetAllGenres();

        public GenreStruct GetGenreById(int id) => GenreContext.GetGenreById(id);

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
