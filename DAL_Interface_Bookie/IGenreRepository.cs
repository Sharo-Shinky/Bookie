using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_Bookie
{
    public interface IGenreRepository
    {
        void UpdateGenre(GenreStruct genre);
    }
}
