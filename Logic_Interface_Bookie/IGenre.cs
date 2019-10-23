using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Interface_Bookie
{
    public interface IGenre
    {
        string Naam { get; }
        void UpdateGenre(IGenre genre);
    }
}
