using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_Bookie;
using Logic_Interface_Bookie;

namespace Logic_Bookie
{
    public class Genre : IGenre
    {
        public int Id { get; private set; }

        public string Naam { get; private set; }

        private IGenreRepository GenreRepository;

        public Genre(IGenreRepository genreRepository)
        {
            GenreRepository = genreRepository;
        }

        public Genre(GenreStruct genreStruct)
        {
            Id = genreStruct.Id;
            Naam = genreStruct.Naam;
        }

        public void UpdateGenre(IGenre genre)
        {
            GenreRepository.UpdateGenre(new GenreStruct(genre.Id, genre.Naam));
        }
    }
}
