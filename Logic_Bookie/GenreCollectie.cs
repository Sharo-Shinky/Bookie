using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_Bookie;
using Logic_Interface_Bookie;

namespace Logic_Bookie
{
    public class GenreCollectie : IGenreCollectie
    {
        private IGenreCollectieRepository GenreCollectieRepository;

        public GenreCollectie(IGenreCollectieRepository genreCollectieRepository)
        {
            GenreCollectieRepository = genreCollectieRepository;
        }
        public List<IGenre> GetAllGenres()
        {
            List<IGenre> GenreList = new List<IGenre>();

            foreach (GenreStruct genreStruct in GenreCollectieRepository.GetAllGenres())
            {
                GenreList.Add(new Genre(genreStruct));
            }

            return GenreList;
        }

        public IGenre GetGenreById(int id)
        {
            IGenre genre = new Genre(GenreCollectieRepository.GetGenreById(id));

            return genre;
        }

        public void VerwijderGenre(int id)
        {
            GenreCollectieRepository.VerwijderGenre(id);
        }

        public void VoegGenreToe(IGenre genre)
        {
            GenreCollectieRepository.VoegGenreToe(new GenreStruct(genre.Naam));
        }
    }
}
