using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_Bookie
{
    public interface ISerieRepository
    {
        void UpdateSerie(SerieStruct serie);
        void VoegBoekToeAanSerie(BoekStruct boek);
    }
}
