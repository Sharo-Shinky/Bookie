using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Interface_Bookie
{
    public interface IAuteur
    {
        string VoorNaam { get; }
        string AchterNaam { get; }
        void UpdateAuteur(IAuteur auteur);
    }
}
