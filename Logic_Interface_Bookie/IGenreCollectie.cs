using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Interface_Bookie
{
    public interface IGenreCollectie
    {
        void VoegGenreToe(IGenre genre);

        void VerwijderGenre(int id);

        List<IGenre> GetAllGenres();

        IGenre GetGenreById(int id);
    }
}
