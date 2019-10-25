using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_Bookie;

namespace DAL_Bookie
{
    public interface IGenreContext
    {
        void VoegGenreToe(GenreStruct genre);

        void VerwijderGenre(int id);

        List<GenreStruct> GetAllGenres();

        GenreStruct GetGenreById(int id);

        void UpdateGenre(GenreStruct genre);
    }
}
