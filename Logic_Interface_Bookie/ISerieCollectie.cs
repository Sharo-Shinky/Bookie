using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Interface_Bookie
{
    public interface ISerieCollectie
    {
        void VoegSerieToe(ISerie serie);

        void VerwijderSerie(int id);

        List<ISerie> GetAllSeries();

        ISerie GetById(int id);
    }
}
