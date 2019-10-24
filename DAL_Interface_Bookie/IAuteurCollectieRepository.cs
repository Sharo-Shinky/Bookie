using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_Bookie
{
    public interface IAuteurCollectieRepository
    {
        void VoegAuteurToe(AuteurStruct auteur);

        void VerwijderAuteur(int id);

        List<AuteurStruct> GetAllAuteurs();

        AuteurStruct GetAuteurById(int id);
    }
}
