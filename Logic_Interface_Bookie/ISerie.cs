using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Interface_Bookie
{
    public interface ISerie
    {
        int Id { get; }
        string Titel { get; }
        void UpdateSerie(ISerie serie);
        void VoegBoekToeAanSerie(IBoek boek);
    }
}
