using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_Bookie
{
    public interface ISerieCollectieRepository
    {
        void VoegSerieToe(SerieStruct serie);

        void VerwijderSerie(int id);

        List<SerieStruct> GetAllSeries();

        SerieStruct GetById(int id);
    }
}
