using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_Bookie
{
    public interface IBoekRepository
    {
        void UpdateBoek(BoekStruct boek);
    }
}
