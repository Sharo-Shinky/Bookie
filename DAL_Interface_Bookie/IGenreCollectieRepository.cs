using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_Bookie
{
    public interface IGenreCollectieRepository
    {
        void VoegGenreToe(GenreStruct genre);

        void VerwijderGenre(int id);

        List<GenreStruct> GetAllGenres();

        GenreStruct GetGenreById(int id);
    }
}
