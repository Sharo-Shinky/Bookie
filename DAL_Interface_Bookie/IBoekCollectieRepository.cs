using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_Bookie
{
    public interface IBoekCollectieRepository
    {
        void VoegBoekToe(BoekStruct boek);

        void VerwijderBoek(int id);

        List<BoekStruct> GetAllBoeken();

        BoekStruct GetBoekById(int id);
    }
}
