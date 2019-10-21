using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Interface_Bookie
{
    public interface IBoekCollectie
    {
        void VoegBoekToe(IBoek boek);

        void VerwijderBoek(int id);

        List<IBoek> GetAllBoeken();

        IBoek GetBoekById(int id);
    }
}
