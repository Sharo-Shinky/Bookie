using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Interface_Bookie
{
    public interface IAuteurCollectie
    {
        void VoegAuteurToe(IAuteur auteur);

        void VerwijderAuteur(int id);

        List<IAuteur> GetAllAuteurs();

        IAuteur GetAuteurById(int id);
    }
}
